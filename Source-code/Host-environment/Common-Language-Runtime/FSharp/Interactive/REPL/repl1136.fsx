// Async Task helpers

type Task<'OutputType> with
    member this.await = this.GetAwaiter().GetResult()

type Task with
    member this.await = this.GetAwaiter().GetResult()

let await (operation: Task<'OutputType>) : 'OutputType = operation.GetAwaiter().GetResult()



let awaitUnit (task: Task) = task.GetAwaiter().GetResult()



// BrowserApi  helpers

let coerce<'T> (value: obj) : 'T =

    if isNull value then
        Unchecked.defaultof<'T>

    elif typeof<'T> = typeof<obj> then
        unbox<'T> value

    elif typeof<'T>.IsInstanceOfType value then
        unbox<'T> value

    else
        Convert.ChangeType(value, typeof<'T>) |> unbox<'T>



let fromHandle<'T when 'T :> JsObject> (handle: JsHandle) : 'T =

    let instance = Activator.CreateInstance(typeof<'T>) :?> 'T

    let handleProperty =
        typeof<JsObject>.GetProperty ("Handle", BindingFlags.Instance ||| BindingFlags.Public)

    let setter = handleProperty.GetSetMethod(true)

    setter.Invoke(instance, [| box handle |])
    |> ignore

    instance




type PuppeteerBrowserBackend(page: CdpPage) =

    // BrowserApi deliberately makes JsHandle opaque.
    //
    // So our BrowserApi JsHandle is just an identity token,
    // and this dictionary contains the actual PuppeteerSharp handle.
    let handles = ConcurrentDictionary<JsHandle, IJSHandle>()


    let wrap (puppeteerHandle: IJSHandle) =

        let browserHandle = JsHandle(obj ())

        handles[browserHandle] <- puppeteerHandle

        browserHandle


    let unwrap (browserHandle: JsHandle) =

        match handles.TryGetValue browserHandle with
        | true, puppeteerHandle -> puppeteerHandle

        | false, _ -> invalidOp "Unknown BrowserApi JsHandle"

    let convertResultAsync (result: IJSHandle) =
        task {
            let! kind =
                result.EvaluateFunctionAsync<string>(
                    """
                    value => {
                        if (value === null)
                            return "null";

                        return typeof value;
                    }
                    """
                )

            match kind with
            | "undefined"
            | "null" ->
                do! result.DisposeAsync().AsTask()
                return null

            | "string" ->
                let! value = result.JsonValueAsync<string>()

                do! result.DisposeAsync().AsTask()

                return box value

            | "boolean" ->
                let! value = result.JsonValueAsync<bool>()

                do! result.DisposeAsync().AsTask()

                return box value

            | "number" ->
                let! value = result.JsonValueAsync<double>()

                do! result.DisposeAsync().AsTask()

                return box value

            | _ -> return box (wrap result)
        }


    let convertResult result = convertResultAsync result |> await
    // BrowserApi will sometimes pass one of its handles as an
    // argument to another browser method.
    //
    // Turn that back into the corresponding Puppeteer IJSHandle.
    let convertArgument (value: obj) =

        match value with
        | null -> null

        | :? JsHandle as browserHandle -> box (unwrap browserHandle)

        | value -> value


    // Puppeteer gives us IJSHandle even when the JavaScript result
    // is a primitive.
    //
    // BrowserApi wants:
    //   primitive -> ordinary .NET value
    //   JS object -> BrowserApi JsHandle
    let convertResult (result: IJSHandle) : obj =

        let kind =
            result
                .EvaluateFunctionAsync<string>(
                    """
                value => {
                    if (value === null)
                        return "null";

                    return typeof value;
                }
                """
                )
                .await

        match kind with

        | "undefined"
        | "null" ->

            result.DisposeAsync().AsTask() |> awaitUnit

            null


        | "string" ->

            let value = result.JsonValueAsync<string>() |> await

            result.DisposeAsync().AsTask() |> awaitUnit

            box value


        | "boolean" ->

            let value = result.JsonValueAsync<bool>() |> await

            result.DisposeAsync().AsTask() |> awaitUnit

            box value


        | "number" ->

            let value = result.JsonValueAsync<double>() |> await

            result.DisposeAsync().AsTask() |> awaitUnit

            box value


        | _ ->

            box (wrap result)

    member _.Wrap(handle: IJSHandle) = wrap handle

    member this.FrameGlobal(frame: CdpFrame, name: string) =

        frame.EvaluateFunctionHandleAsync("name => globalThis[name]", [| box name |])
        |> await
        |> this.Wrap

    interface IBrowserBackend with

        member _.GetProperty<'T>(target, propertyName) =

            let targetHandle = unwrap target

            let result =
                targetHandle.EvaluateFunctionHandleAsync(
                    """
                    (target, propertyName) =>
                        target[propertyName]
                    """,
                    [| box propertyName |]
                )
                |> await

            result |> convertResult |> coerce<'T>

        member _.SetProperty(target, propertyName, value) =

            let targetHandle = unwrap target

            targetHandle.EvaluateFunctionAsync(
                """
                (target, propertyName, value) => {
                    target[propertyName] = value;
                }
                """,
                [| box propertyName
                   convertArgument value |]
            )
            |> await
            |> ignore

        member _.Invoke<'T>(target, methodName, arguments) =

            let targetHandle = unwrap target

            let arguments =
                Array.append [| box methodName |] (arguments |> Array.map convertArgument)

            let result =
                targetHandle.EvaluateFunctionHandleAsync(
                    """
                    (target, methodName, ...arguments) =>
                        target[methodName](...arguments)
                    """,
                    arguments
                )
                |> await

            result |> convertResult |> coerce<'T>

        member _.InvokeVoid(target, methodName, arguments) =

            let targetHandle = unwrap target

            let arguments =
                Array.append [| box methodName |] (arguments |> Array.map convertArgument)

            targetHandle.EvaluateFunctionAsync(
                """
                (target, methodName, ...arguments) => {
                    target[methodName](...arguments);
                }
                """,
                arguments
            )
            |> await
            |> ignore

        member _.InvokeAsync<'T>(target, methodName, arguments) =

            task {
                let targetHandle = unwrap target

                let arguments =
                    Array.append [| box methodName |] (arguments |> Array.map convertArgument)

                let! result =
                    targetHandle.EvaluateFunctionHandleAsync(
                        """
                        (target, methodName, ...arguments) =>
                            target[methodName](...arguments)
                        """,
                        arguments
                    )

                let! converted = convertResultAsync result

                return coerce<'T> converted
            }

        member _.InvokeVoidAsync(target, methodName, arguments) =

            let operation =
                task {
                    let targetHandle = unwrap target

                    let arguments =
                        Array.append [| box methodName |] (arguments |> Array.map convertArgument)

                    let! _ =
                        targetHandle.EvaluateFunctionAsync(
                            """
                            (target, methodName, ...arguments) => {
                                target[methodName](...arguments);
                            }
                            """,
                            arguments
                        )

                    return ()
                }

            operation :> Task

        member _.GetGlobal(name) =

            page.EvaluateFunctionHandleAsync(
                """
                name => globalThis[name]
                """,
                [| box name |]
            )
            |> await
            |> wrap

        member _.Construct(jsClassName, arguments) =

            let arguments =
                Array.append [| box jsClassName |] (arguments |> Array.map convertArgument)

            page.EvaluateFunctionHandleAsync(
                """
                (className, ...arguments) => {
                    const constructor =
                        className
                            .split(".")
                            .reduce(
                                (current, part) => current[part],
                                globalThis
                            );

                    return Reflect.construct(
                        constructor,
                        arguments
                    );
                }
                """,
                arguments
            )
            |> await
            |> wrap


        member _.DisposeHandle(browserHandle) =

            match handles.TryRemove browserHandle with
            | true, puppeteerHandle -> puppeteerHandle.DisposeAsync()

            | false, _ -> ValueTask.CompletedTask


        member _.AddEventListener(_, _, _) =
            raise (NotSupportedException("Events are not implemented in the initial Puppeteer backend."))


        member _.RemoveEventListener(_, _, _) =
            raise (NotSupportedException("Events are not implemented in the initial Puppeteer backend."))


        member _.DisposeAsync() =

            let cleanup =
                task {
                    for KeyValue (_, handle) in handles do
                        do! handle.DisposeAsync().AsTask()

                    handles.Clear()
                }

            ValueTask(cleanup :> Task)




type Dom.Node with

    member this.asElement = this.Handle |> fromHandle<Dom.Element>

type Dom.NodeList with

    static member toArray(nodeList: Dom.NodeList) =
        [| for index = 0u to nodeList.Length - 1u do
               nodeList[index] |]

    static member toElements(nodeList: Dom.NodeList) =
        nodeList
        |> Dom.NodeList.toArray
        |> Array.map (fun node -> node.Handle |> fromHandle<Dom.Element>)




type Dom.Element with
    member this.outerHTML = string this.OuterHtml
    member this.QuerySelector(selector: Selector) = this.QuerySelector selector.Css

    member this.QuerySelectorAll(selector: Selector) =
        this.QuerySelectorAll selector.Css
        |> Dom.NodeList.toElements

type Dom.Document with
    member this.DomUrl = DomUrl this.Url
    member this.Uri = Uri this.Url
    member this.IriReference = IriReference this.Url
    member this.QuerySelector(selector: Selector) = this.QuerySelector selector.Css

    member this.QuerySelectorAll(selector: Selector) =
        this.QuerySelectorAll selector.Css
        |> Dom.NodeList.toElements





/// https://source.chromium.org/chromium/chromium/src/+/main:content/browser/devtools/devtools_agent_host_impl.cc?ss=chromium&q=f:devtools%20-f:out%20%22::kTypeTab%5B%5D%22
[<RequireQualifiedAccess>]
type kType =
    | tab
    | page
    | iframe
    | worker
    | shared_worker
    | service_worker
    | worklet
    | browser
    | webview
    | other
    | auction_worklet
    | assistive_technology
    | browser_ui
    member this.asString = this.ToString()

    member this.asTargetType =
        match this with
        | kType.tab -> TargetType.Tab
        | kType.page -> TargetType.Page
        | kType.iframe -> TargetType.IFrame
        | kType.worker -> TargetType.Worker
        | kType.shared_worker -> TargetType.SharedWorker
        | kType.service_worker -> TargetType.ServiceWorker
        | kType.worklet -> TargetType.Other
        | kType.browser -> TargetType.Browser
        | kType.webview -> TargetType.Webview
        | kType.other -> TargetType.Other
        | kType.auction_worklet -> TargetType.Other
        | kType.assistive_technology -> TargetType.Other
        | kType.browser_ui -> TargetType.Other






























// Javascript Authoring


type AngleSharpDomMetadataProvider() =
    inherit JavascriptMetadataProvider()

    let fallback = AttributeJavascriptMetadataProvider()

    override _.GetMemberMetadata(memberInfo: MemberInfo) =

        let domName =
            memberInfo.GetCustomAttributes(typeof<DomNameAttribute>, false)
            |> Seq.tryPick (function
                | :? DomNameAttribute as attribute -> Some attribute.OfficialName
                | _ -> None)

        match domName with
        | Some name -> JavascriptMemberAttribute(MemberName = name) :> IJavascriptMemberMetadata

        | None -> fallback.GetMemberMetadata(memberInfo)


type Javascript private () =

    static let options = JavascriptCompilationOptions(enum<JsCompilationFlags> 0)

    static do options.CustomMetadataProvider <- AngleSharpDomMetadataProvider()

    static member func<'InputType, 'OutputType>(expression: Expression<Func<'InputType, 'OutputType>>) = expression

    static member asText<'InputType, 'OutputType>(expression: Expression<Func<'InputType, 'OutputType>>) =
        expression.CompileToJavascript(options)












// resource helpers



type QueryParameter =
    | ParameterKeyValue of string * string
    | ParameterKeyValues of string * string array
    member this.parameterKey =
        match this with
        | ParameterKeyValue (parameterKey, parameterValue) -> parameterKey
        | ParameterKeyValues (parameterKey, parameterValues) -> parameterKey

    member this.parameterValue =
        match this with
        | ParameterKeyValue (parameterKey, parameterValue) -> parameterValue
        | ParameterKeyValues (parameterKey, parameterValues) -> parameterValues[0]

    member this.parameterValues =
        match this with
        | ParameterKeyValue (parameterKey, parameterValue) -> [| parameterValue |]
        | ParameterKeyValues (parameterKey, parameterValues) -> parameterValues

    member this.ParameterPath =
        Array.concat [| [| this.parameterKey |]
                        this.parameterValues |]
        |> String.concat "\\"



type ResourceReference =
    | UniformResourceIdentifier of Uri
    | UniformResourceLocator of DomUrl
    | InternationalizedResourceIdentifier of IriReference
    | FileSystemFile of FileInfo
    | FileSystemDirectory of DirectoryInfo
    static member Iri = @"D:\Iri" |> DirectoryInfo |> FileSystemDirectory

    static member SolarWinds =
        @"D:\Artifact\Company\SolarWinds"
        |> DirectoryInfo
        |> FileSystemDirectory

    static member NeoGov =
        @"D:\Artifact\Company\NeoGov"
        |> DirectoryInfo
        |> FileSystemDirectory

    static member SunshineHealth =
        @"D:\Artifact\Company\SunshineHealth"
        |> DirectoryInfo
        |> FileSystemDirectory

    static member MicrosoftGraph =
        @"D:\Artifact\Company\MicrosoftGraph"
        |> DirectoryInfo
        |> FileSystemDirectory

    static member AddQueryParameter (parameterKey: string) parameterValue (resourceReference: ResourceReference) =
        match resourceReference with
        | UniformResourceIdentifier uri ->
            new Uri(QueryStringUtilities.AddQueryString(uri.OriginalString, parameterKey, string parameterValue))
            |> UniformResourceIdentifier
        | UniformResourceLocator domUrl ->
            new DomUrl(QueryStringUtilities.AddQueryString(domUrl.Href, parameterKey, string parameterValue))
            |> UniformResourceLocator
        | InternationalizedResourceIdentifier iriReference ->
            new IriReference(
                QueryStringUtilities.AddQueryString(
                    iriReference.uri.OriginalString,
                    parameterKey,
                    string parameterValue
                )
            )
            |> InternationalizedResourceIdentifier
        | FileSystemFile fileInfo ->
            new FileInfo(QueryStringUtilities.AddQueryString(fileInfo.FullName, parameterKey, string parameterValue))
            |> FileSystemFile
        | FileSystemDirectory directoryInfo ->
            new DirectoryInfo(
                QueryStringUtilities.AddQueryString(directoryInfo.FullName, parameterKey, string parameterValue)
            )
            |> FileSystemDirectory

    static member UpsertQueryParameter (parameterKey: string) parameterValue (resourceReference: ResourceReference) =
        match resourceReference with
        | UniformResourceIdentifier uri ->
            new Uri(
                QueryStringUtilities.AddOrReplaceQueryString(uri.OriginalString, parameterKey, string parameterValue)
            )
            |> UniformResourceIdentifier
        | UniformResourceLocator domUrl ->
            new DomUrl(QueryStringUtilities.AddOrReplaceQueryString(domUrl.Href, parameterKey, string parameterValue))
            |> UniformResourceLocator
        | InternationalizedResourceIdentifier iriReference ->
            new IriReference(
                QueryStringUtilities.AddOrReplaceQueryString(
                    iriReference.uri.OriginalString,
                    parameterKey,
                    string parameterValue
                )
            )
            |> InternationalizedResourceIdentifier
        | FileSystemFile fileInfo ->
            new FileInfo(
                QueryStringUtilities.AddOrReplaceQueryString(fileInfo.FullName, parameterKey, string parameterValue)
            )
            |> FileSystemFile
        | FileSystemDirectory directoryInfo ->
            new DirectoryInfo(
                QueryStringUtilities.AddOrReplaceQueryString(
                    directoryInfo.FullName,
                    parameterKey,
                    string parameterValue
                )
            )
            |> FileSystemDirectory

    static member RemoveQueryParameter (parameterKey: string) (resourceReference: ResourceReference) =
        match resourceReference with
        | UniformResourceIdentifier uri ->
            new Uri(QueryStringUtilities.RemoveQueryString(uri.OriginalString, parameterKey))
            |> UniformResourceIdentifier
        | UniformResourceLocator domUrl ->
            new DomUrl(QueryStringUtilities.RemoveQueryString(domUrl.Href, parameterKey))
            |> UniformResourceLocator
        | InternationalizedResourceIdentifier iriReference ->
            new IriReference(QueryStringUtilities.RemoveQueryString(iriReference.uri.OriginalString, parameterKey))
            |> InternationalizedResourceIdentifier
        | FileSystemFile fileInfo ->
            new FileInfo(QueryStringUtilities.RemoveQueryString(fileInfo.FullName, parameterKey))
            |> FileSystemFile
        | FileSystemDirectory directoryInfo ->
            new DirectoryInfo(QueryStringUtilities.RemoveQueryString(directoryInfo.FullName, parameterKey))
            |> FileSystemDirectory

    member this.asString =
        match this with
        | UniformResourceIdentifier uri -> uri.OriginalString
        | UniformResourceLocator domUrl -> domUrl.Href
        | InternationalizedResourceIdentifier iriReference -> iriReference.uri.OriginalString
        | FileSystemFile fileInfo -> fileInfo.FullName
        | FileSystemDirectory directoryInfo -> directoryInfo.FullName

    member this.asUri = Uri this.asString
    member this.asDomUrl = DomUrl this.asString
    member this.asIriReference = IriReference this.asString

    member this.asFile =
        match this with
        | UniformResourceIdentifier uri ->
            Path.Combine(
                ResourceReference.Iri.asString,
                uri.Scheme,
                uri.AbsolutePath,
                uri.Fragment,
                this.QueryPathName,
                this.terminalName,
                $"{this.pathStem}{this.extension}"
            )
            |> FileInfo
        | UniformResourceLocator domUrl ->
            Path.Combine(
                ResourceReference.Iri.asString,
                domUrl.Protocol.TrimEnd(':'),
                domUrl.Host,
                this.AbsolutePathName,
                domUrl.Hash,
                this.QueryPathName,
                this.terminalName,
                $"{this.pathStem}{this.extension}"
            )
            |> FileInfo
        | InternationalizedResourceIdentifier iriReference ->
            Path.Combine(
                ResourceReference.Iri.asString,
                iriReference.uri.Scheme,
                iriReference.uri.AbsolutePath,
                iriReference.uri.Fragment,
                this.QueryPathName,
                this.terminalName,
                $"{this.pathStem}{this.extension}"
            )
            |> FileInfo
        | FileSystemFile fileInfo -> fileInfo.FullName |> FileInfo
        | FileSystemDirectory directoryInfo -> directoryInfo.FullName |> FileInfo

    member this.asDirectory =

        match this with
        | UniformResourceIdentifier uri ->
            Path.Combine(
                ResourceReference.Iri.asString,
                uri.Scheme,
                uri.AbsolutePath,
                uri.Fragment,
                this.QueryPathName,
                this.terminalName
            )
            |> DirectoryInfo
        | UniformResourceLocator domUrl ->
            Path.Combine(
                ResourceReference.Iri.asString,
                domUrl.Protocol.TrimEnd(':'),
                domUrl.Host,
                this.AbsolutePathName,
                domUrl.Hash,
                this.QueryPathName,
                this.terminalName
            )
            |> DirectoryInfo
        | InternationalizedResourceIdentifier iriReference ->
            Path.Combine(
                ResourceReference.Iri.asString,
                iriReference.uri.Scheme,
                iriReference.uri.AbsolutePath,
                iriReference.uri.Fragment,
                this.QueryPathName,
                this.terminalName
            )
            |> DirectoryInfo
        | FileSystemFile fileInfo ->
            Path.Combine(ResourceReference.Iri.asString, fileInfo.FullName)
            |> DirectoryInfo
        | FileSystemDirectory directoryInfo ->
            Path.Combine(ResourceReference.Iri.asString, directoryInfo.FullName)
            |> DirectoryInfo


    member this.QueryStringParameters =
        QueryStringUtilities.ParseQuery this.asUri.Query
        |> Seq.map (fun keyValue ->
            match keyValue.Key, keyValue.Value |> Seq.toArray with
            | parameterKey, [| parameterValue |] -> ParameterKeyValue(parameterKey, parameterValue)
            | parameterKey, parameterValues -> ParameterKeyValues(parameterKey, parameterValues))
        |> Seq.toArray
        |> Array.sortBy (fun parameter -> parameter.parameterKey)

    member this.AppendSegments(segments: string array) =
        match this with
        | UniformResourceIdentifier uri ->
            sprintf "%s/%s%s" (uri.AbsoluteUri.TrimEnd('/')) (segments |> String.concat "/") uri.Query
            |> Uri
            |> UniformResourceIdentifier
        | UniformResourceLocator domUrl ->
            sprintf
                "%s/%s%s"
                (domUrl.Origin + domUrl.Pathname.TrimEnd('/'))
                (segments |> String.concat "/")
                domUrl.Search
            |> DomUrl
            |> UniformResourceLocator
        | InternationalizedResourceIdentifier iriReference ->
            IriReference.FromDataSegments(iriReference, segments)
            |> InternationalizedResourceIdentifier
        | FileSystemFile fileInfo ->
            Path.Combine(fileInfo.FullName, segments |> String.concat "\\")
            |> FileInfo
            |> FileSystemFile
        | FileSystemDirectory directoryInfo ->
            Path.Combine(directoryInfo.FullName, segments |> String.concat "\\")
            |> DirectoryInfo
            |> FileSystemDirectory

    member this.AppendPath(path: string) = this.AppendSegments [| path |]

    member this.AbsolutePathName =
        match this with
        | UniformResourceIdentifier uri -> uri.AbsolutePath[1..]
        | UniformResourceLocator domUrl -> domUrl.Pathname[1..]
        | InternationalizedResourceIdentifier iriReference -> iriReference.uri.AbsolutePath[1..]
        | FileSystemFile fileInfo -> fileInfo.FullName
        | FileSystemDirectory directoryInfo -> directoryInfo.FullName

    member this.QueryPathName =
        this.QueryStringParameters
        |> Array.map (fun parameter -> parameter.ParameterPath)
        |> String.concat "\\"

    member this.terminalName =
        match this.asString.ToCharArray() |> Array.last with
        | '#' -> "hash"
        | '/' -> "slash"
        | _ -> "bare"

    member this.HashTerminated =
        match this with
        | UniformResourceIdentifier uri ->
            uri.OriginalString + "#"
            |> Uri
            |> UniformResourceIdentifier
        | UniformResourceLocator domUrl ->
            domUrl.Href + "#"
            |> DomUrl
            |> UniformResourceLocator
        | InternationalizedResourceIdentifier iriReference ->
            iriReference.uri.OriginalString + "#"
            |> IriReference
            |> InternationalizedResourceIdentifier
        | FileSystemFile fileInfo ->
            fileInfo.FullName + "#"
            |> FileInfo
            |> FileSystemFile
        | FileSystemDirectory directoryInfo ->
            directoryInfo.FullName + "#"
            |> DirectoryInfo
            |> FileSystemDirectory

    member this.SlashTerminated =
        match this with
        | UniformResourceIdentifier uri ->
            uri.OriginalString + "/"
            |> Uri
            |> UniformResourceIdentifier
        | UniformResourceLocator domUrl ->
            domUrl.Href + "/"
            |> DomUrl
            |> UniformResourceLocator
        | InternationalizedResourceIdentifier iriReference ->
            iriReference.uri.OriginalString + "/"
            |> IriReference
            |> InternationalizedResourceIdentifier
        | FileSystemFile fileInfo ->
            fileInfo.FullName + "/"
            |> FileInfo
            |> FileSystemFile
        | FileSystemDirectory directoryInfo ->
            directoryInfo.FullName + "/"
            |> DirectoryInfo
            |> FileSystemDirectory

    member this.extension = Path.GetExtension this.AbsolutePathName
    member this.pathStem = Path.GetFileNameWithoutExtension this.AbsolutePathName

    member this.CreateFileDirectory() =
        Directory.CreateDirectory this.asFile.DirectoryName
        |> ignore

    member this.WriteFileText(text: string) =
        this.CreateFileDirectory()
        File.WriteAllText(this.asFile.FullName, text)

    member this.WriteFileLines(lines: string array) =
        this.CreateFileDirectory()
        File.WriteAllLines(this.asFile.FullName, lines)

    member this.DownloadFileText() =
        this.CreateFileDirectory()

        http { GET this.asDomUrl.Href }
        |> Request.send
        |> Response.saveFile this.asFile.FullName

    member this.MimeType = MimeType.FromFileName this.asFile.FullName





// BiDi automation


let firefox =

    let driver = BiDiDriver(TimeSpan.FromSeconds 30.)

    task { return! driver.StartAsync("ws://127.0.0.1:9223/session") }
    |> await

    driver.Session.NewSessionAsync(NewCommandParameters())
    |> await
    |> ignore

    driver

type BiDiDriver with
    member this.BrowsingContextTree =
        task {
            let! tree = this.BrowsingContext.GetTreeAsync(GetTreeCommandParameters())
            return tree.ContextTree |> Seq.toArray
        }
        |> await



type BrowsingContextInfo with
    member this.ResourceName = DomUrl this.Url |> UniformResourceLocator












// Chrome devtools automation



let chrome =

    let options = ConnectOptions()

    options.BrowserURL <- "http://127.0.0.1:9222"
    options.DefaultViewport <- null

    let ibrowser =
        task { return! Puppeteer.ConnectAsync(options) }
        |> await

    ibrowser :?> CdpBrowser










type IPage with
    member this.asCdp = this :?> CdpPage

type IBrowser with
    member this.asCdp = this :?> CdpBrowser

type ITarget with
    member this.asCdp = this :?> CdpTarget

type IBrowserContext with
    member this.asCdp = this :?> CdpBrowserContext

type IRequest with
    member this.asCdp = this :?> CdpHttpRequest

type IResponse with
    member this.asCdp = this :?> CdpHttpResponse

type IElementHandle with
    member this.asCdp = this :?> CdpElementHandle






type CdpHttpRequest with
    member this.ResourceReference = DomUrl this.Url |> UniformResourceLocator

    member this.headers =
        this.Headers
        |> Seq.map (fun kvp -> kvp.Key, kvp.Value)
        |> Seq.toArray

    member this.header(targetHeader: string) =
        this.headers
        |> Array.tryPick (fun (headerKey, headerValue) ->
            if headerKey = targetHeader then
                Some headerValue
            else
                None)

    member this.PostText =
        if this.HasPostData then
            Some this.PostData
        else
            None



type CdpHttpResponse with
    member this.ResourceReference = DomUrl this.Url |> UniformResourceLocator

    member this.headers =
        this.Headers
        |> Seq.map (fun kvp -> kvp.Key, kvp.Value)
        |> Seq.toArray

    member this.Text() =
        try
            task { return! this.TextAsync() } |> await |> Some
        with
        | err ->
            logLines.Add(sprintf "request %s %A threw %s" this.Url this.headers err.Message)
            None





type CdpElementHandle with
    member this.EvaluateFunction(javascriptFunction: Expression<Func<'InputType, 'OutputType>>) =
        task { return! this.EvaluateFunctionAsync<string>(javascriptFunction |> Javascript.asText) }
        |> await

    member this.outerHTML =
        Javascript.func<AngleSharp.Dom.IElement, string> (fun element -> element.OuterHtml)
        |> this.EvaluateFunction
        |> HtmlNode.Parse

    member this.Click() = task { do! this.ClickAsync() } |> await

    member this.ScrollIntoView() =
        task { do! this.ScrollIntoViewAsync() } |> await

    member this.EnterText(text: string) =
        task {
            do! this.ClickAsync()
            do! this.TypeAsync(text)
        }
        |> await

    member this.Type(text: string) =
        task { do! this.TypeAsync(text) } |> await

    member this.InnerText() =
        task { return! this.InnerTextAsync() } |> await



type CdpPage with
    member this.QuerySelector(selector: Selector) =
        match task { return! this.QuerySelectorAllAsync selector.Css }
              |> await
            with
        | [||] -> None
        | elements -> Some elements[0]

    member this.ScrollToBottom() =
        task { return! this.EvaluateFunctionAsync("() => window.scrollTo(0, document.documentElement.scrollHeight)") }
        |> await

    member this.ScrollDown(pixels: int) =
        task { return! this.EvaluateFunctionAsync("(pixels) => window.scrollBy(0, pixels)", pixels) }
        |> await

    member this.ScrollUp(pixels: int) =
        task { return! this.EvaluateFunctionAsync("(pixels) => window.scrollBy(0, -pixels)", pixels) }
        |> await

    member this.SetTabName(name: string) =
        task { return! this.EvaluateFunctionAsync<string>("name => document.title = name", name) }

    member this.GoToAsync(url: DomUrl) =
        task { return! this.GoToAsync(url.Href) }

    member this.GoTo(url: DomUrl) =
        task { return! this.GoToAsync(url.Href) } |> await

    member this.GoBack() =
        task { return! this.GoBackAsync() } |> await

    member this.GoForward() =
        task { return! this.GoForwardAsync() } |> await



type CdpFrame with
    member this.Click(selector: Selector) =
        task { do! this.ClickAsync selector.Css } |> await

    member this.ResourceReference = DomUrl this.Url |> UniformResourceLocator



































// Network traffic helpers


let writeRequestResponse (response: CdpHttpResponse) (extensionOverride: string option) =
    let resourceReference =
        match extensionOverride with
        | Some extension ->
            Path.ChangeExtension(response.ResourceReference.asFile.FullName, extension)
            |> FileInfo
            |> FileSystemFile
        | None -> response.ResourceReference

    match response.Text() with
    | Some text ->
        printfn
            "%s\t\t%s%s -----> %s"
            response.ResourceReference.asDomUrl.Host
            response.ResourceReference.AbsolutePathName
            (response.ResourceReference.asDomUrl.Search.Truncate(100))
            resourceReference.asFile.FullName[resourceReference.asFile.DirectoryName.Length + 1 ..]

        resourceReference.WriteFileText text
    | None -> ()

let networkMailbox =
    MailboxProcessor<CdpHttpRequest>.Start
        (fun inbox ->
            let rec loop () =
                async {
                    let! request = inbox.Receive()

                    match request.Response.Status with
                    | HttpStatusCode.OK ->


                        finishedRequests.Add request

                        match request.Response.ResourceReference.asDomUrl.Host,
                              request.Response.ResourceReference.AbsolutePathName
                            with
                        | "app.securiti.ai", "core/v1/utils/geo/location" ->
                            Some "json"
                            |> writeRequestResponse request.Response
                        | "siteintercept.qualtrics.com", pathName when pathName.EndsWith("php") ->
                            Some "json"
                            |> writeRequestResponse request.Response



                        | _ -> ()
                    | _ -> failedRequests.Add request

                    return! loop ()
                }

            loop ())






























































(*

Uri "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"
DomUrl "https://html.spec.whatwg.org/entities.json"
IriReference "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"
FileInfo "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"
DirectoryInfo "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"


let solarwindsTest = DomUrl "https://leoncountyfl.samanage.com/incidents.json?report_id=9641268&assigned_to%5B%5D=10744815&data=state&sort_by=state&sort_order=DESC&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657" |> UniformResourceLocator
let entitiesTest = DomUrl "https://html.spec.whatwg.org/entities.json" |> UniformResourceLocator

FilePath.Sanitize solarwindsTest.asFile.FullName
entitiesTest.asFile.FullName


FilePath.Sanitize entitiesTest.asFile.FullName
let invalidPathTest = Path.GetInvalidPathChars() |> Array.map (fun character -> string character)
let invalidFileNameTest = Path.GetInvalidFileNameChars() |> Array.map (fun character -> string character)


type DomUrl with
    member this.pathName = this.Pathname[1..]
    member this.AppendPath(path:string) = Path.Combine(this.Origin + this.pathName, path.TrimStart('/')) + this.Search |> DomUrl
    member this.AppendSegments(segments:string list) =
        let absolutePath =
            List.concat [
                [this.Origin + this.Pathname]
                segments
            ]
            |> String.concat "/"
        absolutePath + this.Search |> DomUrl
    member this.SlashTerminated = this.Href + "/" |> DomUrl
    member this.HashTerminated = this.Href + "#" |> DomUrl
    member this.Absolute = this.Origin + this.Pathname |> DomUrl
    member this.asIriReference = IriReference this.Href
    member this.Query = QueryStringUtilities.ParseQuery this.Search |> Seq.map (fun keyValue ->  keyValue.Key, keyValue.Value |> Seq.toArray) |> Seq.toArray |> Array.sortBy (fun (key,values) -> key)
    member this.extension = Path.GetExtension this.pathName
    member this.pathStem = Path.GetFileNameWithoutExtension this.pathName


*)


// Rdf Helpers


type IriReference with
    static member fromUriNode(uriNode: UriNode) = IriReference uriNode.Uri
    member this.lexicalForm = this.uri.OriginalString
    member this.identity = this.lexicalForm

    member this.asUrl = DomUrl this.uri.OriginalString
    member this.asUri = this.uri
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode: INode = this.asUriNode
    member this.asRDFResource = new RDFResource(this.lexicalForm)

    member this.maybeCurie =
        match namespaceMapper.ReduceToQName this.lexicalForm with
        | true, qname -> Some qname
        | false, _ -> None

    member this.iriref = $"<{this.uri.OriginalString}>"
