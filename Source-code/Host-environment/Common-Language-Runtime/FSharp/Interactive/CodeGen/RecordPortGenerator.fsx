open System
open System.IO
open System.Reflection
open Microsoft.FSharp.Reflection

let private primitiveTypeNames =
    dict [ typeof<string>, "string"
           typeof<int>, "int"
           typeof<int64>, "int64"
           typeof<float>, "float"
           typeof<bool>, "bool"
           typeof<unit>, "unit" ]

let rec renderType (typ: Type) =
    if primitiveTypeNames.ContainsKey typ then
        primitiveTypeNames.[typ]

    elif typ.IsGenericType then
        let genericDefinition = typ.GetGenericTypeDefinition()
        let genericArguments = typ.GetGenericArguments() |> Array.map renderType

        if genericDefinition = typedefof<option<_>> then
            $"{genericArguments.[0]} option"

        elif genericDefinition = typedefof<Async<_>> then
            $"Async<{genericArguments.[0]}>"

        elif genericDefinition = typedefof<FSharpFunc<_, _>> then
            let inputType = genericArguments.[0]
            let outputType = genericArguments.[1]

            $"{inputType} -> {outputType}"

        elif genericDefinition.FullName.StartsWith("System.Tuple") then
            genericArguments
            |> String.concat " * "
            |> sprintf "(%s)"

        else
            let baseName = typ.Name.Split('`').[0]

            genericArguments
            |> String.concat ", "
            |> sprintf "%s<%s>" baseName

    elif typ.IsArray then
        $"{renderType (typ.GetElementType())} array"

    else
        typ.Name

let rec collectFunctionArgumentsAndReturnType (typ: Type) =
    if typ.IsGenericType
       && typ.GetGenericTypeDefinition() = typedefof<FSharpFunc<_, _>> then
        let args = typ.GetGenericArguments()
        let inputType = args.[0]
        let outputType = args.[1]

        let laterInputs, finalOutput = collectFunctionArgumentsAndReturnType outputType

        inputType :: laterInputs, finalOutput
    else
        [], typ

let generateInterfaceFromRecordType (recordType: Type) =
    if not (FSharpType.IsRecord recordType) then
        failwithf "%s is not an F# record type." recordType.FullName

    let recordName = recordType.Name
    let interfaceName = $"I{recordName}"
    let adapterModuleName = $"{recordName}Interface"

    let fields =
        FSharpType.GetRecordFields(recordType, BindingFlags.Public ||| BindingFlags.Instance)

    let abstractMembers =
        fields
        |> Array.map (fun field -> $"    abstract {field.Name} : {renderType field.PropertyType}")
        |> String.concat Environment.NewLine

    let toInterfaceMembers =
        fields
        |> Array.map (fun field ->
            let argumentTypes, _returnType =
                collectFunctionArgumentsAndReturnType field.PropertyType

            if argumentTypes.IsEmpty then
                failwithf "Field %s is not a function field." field.Name

            let parameters =
                argumentTypes
                |> List.mapi (fun index _ -> $"parameter_{index}")
                |> String.concat " "

            $"            member _.{field.Name} {parameters} = rcord.{field.Name} {parameters}")
        |> String.concat Environment.NewLine

    let ofInterfaceFields =
        fields
        |> Array.map (fun field ->
            let argumentTypes, _returnType =
                collectFunctionArgumentsAndReturnType field.PropertyType

            if argumentTypes.IsEmpty then
                failwithf "Field %s is not a function field." field.Name

            let parameters =
                argumentTypes
                |> List.mapi (fun index _ -> $"parameter_{index}")
                |> String.concat " "

            $"            {field.Name} = fun {parameters} -> iface.{field.Name} {parameters}")
        |> String.concat Environment.NewLine

    $"""

type {interfaceName} =
{abstractMembers}

module {adapterModuleName} =

    let toInterface (rcord : {recordName}) : {interfaceName} =
        {{ new {interfaceName} with
{toInterfaceMembers}
        }}

    let ofInterface (iface : {interfaceName}) : {recordName} =
        {{
{ofInterfaceFields}
        }}
"""

let writeInterfaceFor<'Record> outputPath =
    let generatedText = generateInterfaceFromRecordType typeof<'Record>

    File.WriteAllText(outputPath, generatedText)
    generatedText
