// https://fsharp.github.io/fslang-spec
open System

open System.Reflection

#r "nuget: FParsec"

open FParsec


open Microsoft.FSharp.Collections
open System
open System.Reflection
(*

let getAllInterfaceTypes (rootInterfaceType: Type) =
    if not rootInterfaceType.IsInterface then
        [||]
    else
        seq {
            yield rootInterfaceType
            yield! rootInterfaceType.GetInterfaces()
        }
        |> Seq.distinct
        |> Seq.toArray

let getAllInterfaceProperties (rootInterfaceType: Type) =
    getAllInterfaceTypes rootInterfaceType
    |> Seq.collect (fun interfaceType -> interfaceType.GetProperties(BindingFlags.Instance ||| BindingFlags.Public))
    |> Seq.distinctBy (fun property ->
        property.Name, property.PropertyType.FullName, property.GetIndexParameters() |> Array.length)
    |> Seq.sortBy (fun property -> property.Name)
    |> Seq.toArray

let isScalarDisplayType (type_: Type) =
    type_.IsPrimitive
    || type_ = typeof<string>
    || type_ = typeof<char>
    || type_ = typeof<bool>
    || type_ = typeof<int>
    || type_ = typeof<int64>
    || type_ = typeof<uint32>
    || type_ = typeof<uint64>
    || type_ = typeof<float>
    || type_ = typeof<decimal>
    || type_ = typeof<DateTime>
    || type_ = typeof<Guid>

let tryGetRelevantInterfaceType (value: obj) =
    let runtimeType = value.GetType()

    runtimeType.GetInterfaces()
    |> Array.filter (fun interfaceType ->
        interfaceType
        <> typeof<System.Collections.IEnumerable>)
    |> Array.sortByDescending (fun interfaceType ->
        getAllInterfaceProperties interfaceType
        |> Array.length)
    |> Array.tryHead

let rec formatValue (depth: int) (value: obj) =
    if depth > 6 then
        "<max-depth>"
    else
        match value with
        | null -> "null"
        | _ ->
            let valueType = value.GetType()

            if isScalarDisplayType valueType then
                sprintf "%A" value

            elif valueType.IsArray then
                let elements =
                    value :?> Array
                    |> Seq.cast<obj>
                    |> Seq.truncate 12
                    |> Seq.map (formatValue (depth + 1))
                    |> String.concat "; "

                $"[| {elements} |]"

            elif valueType <> typeof<string>
                 && typeof<System.Collections.IEnumerable>.IsAssignableFrom valueType then
                let elements =
                    value :?> System.Collections.IEnumerable
                    |> Seq.cast<obj>
                    |> Seq.truncate 12
                    |> Seq.map (formatValue (depth + 1))
                    |> String.concat "; "

                $"seq [ {elements} ]"

            else
                match tryGetRelevantInterfaceType value with
                | Some interfaceType -> formatInterfaceObject depth interfaceType value
                | None -> sprintf "%A" value

and formatInterfaceObject (depth: int) (interfaceType: Type) (value: obj) =
    let indent = String.replicate (depth * 2) " "
    let childIndent = String.replicate ((depth + 1) * 2) " "

    let formattedProperties =
        getAllInterfaceProperties interfaceType
        |> Array.map (fun property ->
            let formattedValue =
                try
                    property.GetValue(value, null)
                    |> formatValue (depth + 1)
                with
                | ex -> $"<error: {ex.GetType().Name}: {ex.Message}>"

            $"{childIndent}{property.Name} = {formattedValue}")
        |> String.concat Environment.NewLine

    $"{interfaceType.Name} {{{Environment.NewLine}{formattedProperties}{Environment.NewLine}{indent}}}"

let addInterfacePrinter<'InterfaceType> () =
    fsi.AddPrinter<'InterfaceType>(fun value -> formatInterfaceObject 0 typeof<'InterfaceType> (box value))



*)



open System
open System.Reflection

let getAllInterfaceTypes (rootInterfaceType: Type) =
    if not rootInterfaceType.IsInterface then
        [||]
    else
        seq {
            yield rootInterfaceType
            yield! rootInterfaceType.GetInterfaces()
        }
        |> Seq.distinct
        |> Seq.toArray

let getAllInterfaceProperties (rootInterfaceType: Type) =
    getAllInterfaceTypes rootInterfaceType
    |> Seq.collect (fun interfaceType -> interfaceType.GetProperties(BindingFlags.Instance ||| BindingFlags.Public))
    |> Seq.distinctBy (fun property ->
        property.Name, property.PropertyType.FullName, property.GetIndexParameters() |> Array.length)
    |> Seq.sortBy (fun property -> property.Name)
    |> Seq.toArray

let isScalarDisplayType (type_: Type) =
    type_.IsPrimitive
    || type_ = typeof<string>
    || type_ = typeof<char>
    || type_ = typeof<bool>
    || type_ = typeof<int>
    || type_ = typeof<int64>
    || type_ = typeof<uint32>
    || type_ = typeof<uint64>
    || type_ = typeof<float>
    || type_ = typeof<decimal>
    || type_ = typeof<DateTime>
    || type_ = typeof<Guid>

let isOptionType (type_: Type) =
    type_.IsGenericType
    && type_.GetGenericTypeDefinition() = typedefof<option<_>>

let tryGetRelevantInterfaceType (value: obj) =
    let runtimeType = value.GetType()

    runtimeType.GetInterfaces()
    |> Array.filter (fun interfaceType ->
        interfaceType
        <> typeof<System.Collections.IEnumerable>)
    |> Array.sortByDescending (fun interfaceType ->
        getAllInterfaceProperties interfaceType
        |> Array.length)
    |> Array.tryHead

let rec formatValue (depth: int) (value: obj) =
    if depth > 10 then
        "<max-depth>"
    else
        match value with
        | null -> "null"
        | _ ->
            let valueType = value.GetType()

            if isScalarDisplayType valueType then
                sprintf "%A" value

            elif valueType.IsArray then
                let elements =
                    value :?> Array
                    |> Seq.cast<obj>
                    |> Seq.truncate 12
                    |> Seq.map (formatValue (depth + 1))
                    |> String.concat "; "

                $"[| {elements} |]"

            elif valueType <> typeof<string>
                 && typeof<System.Collections.IEnumerable>.IsAssignableFrom valueType then
                let elements =
                    value :?> System.Collections.IEnumerable
                    |> Seq.cast<obj>
                    |> Seq.truncate 12
                    |> Seq.map (formatValue (depth + 1))
                    |> String.concat "; "

                $"seq [ {elements} ]"

            else
                match tryGetRelevantInterfaceType value with
                | Some interfaceType -> formatInterfaceObject depth interfaceType value
                | None -> sprintf "%A" value

and formatPropertyValue (depth: int) (propertyType: Type) (propertyValue: obj) =
    if isOptionType propertyType then
        if isNull propertyValue then
            "None"
        else
            let _, unionFields =
                Microsoft.FSharp.Reflection.FSharpValue.GetUnionFields(propertyValue, propertyType)

            match unionFields with
            | [| innerValue |] -> $"Some ({formatValue (depth + 1) innerValue})"
            | _ -> "None"
    else
        formatValue depth propertyValue

and formatInterfaceObject (depth: int) (interfaceType: Type) (value: obj) =
    let indent = String.replicate (depth * 2) " "
    let childIndent = String.replicate ((depth + 1) * 2) " "

    let formattedProperties =
        getAllInterfaceProperties interfaceType
        |> Array.map (fun property ->
            let formattedValue =
                try
                    property.GetValue(value, null)
                    |> formatPropertyValue (depth + 1) property.PropertyType
                with
                | ex -> $"<error: {ex.GetType().Name}: {ex.Message}>"

            $"{childIndent}{property.Name} = {formattedValue}")
        |> String.concat Environment.NewLine

    $"{interfaceType.Name} {{{Environment.NewLine}{formattedProperties}{Environment.NewLine}{indent}}}"

let addInterfacePrinter<'InterfaceType> () =
    fsi.AddPrinter<'InterfaceType>(fun value -> formatInterfaceObject 0 typeof<'InterfaceType> (box value))





















































(*
let getAllInterfacePropertiesOrdered (interfaceType: Type) =
    if not interfaceType.IsInterface then
        invalidArg (nameof interfaceType) "Expected an interface type."

    seq {
        yield interfaceType
        yield! interfaceType.GetInterfaces()
    }
    |> Seq.collect (fun currentInterfaceType ->
        currentInterfaceType.GetProperties(BindingFlags.Instance ||| BindingFlags.Public))
    |> Seq.distinctBy (fun property ->
        property.Name, property.PropertyType, property.GetIndexParameters() |> Array.length)
    |> Seq.sortBy (fun property -> property.Name)
    |> Seq.toArray










let getAllInterfaceProperties (interfaceType: Type) =
    if not interfaceType.IsInterface then
        invalidArg (nameof interfaceType) "Expected an interface type."

    seq {
        yield interfaceType
        yield! interfaceType.GetInterfaces()
    }
    |> Seq.collect (fun currentInterfaceType ->
        currentInterfaceType.GetProperties(BindingFlags.Instance ||| BindingFlags.Public))
    |> Seq.distinctBy (fun property ->
        property.Name, property.PropertyType, property.GetIndexParameters() |> Array.length)
    |> Seq.toArray

let inspectObjectExpression objectExpression =
    let objectExpressionInterface =
        objectExpression.GetType().GetInterfaces()
        |> Array.head

    getAllInterfacePropertiesOrdered objectExpressionInterface
    |> Array.iter (fun property ->
        let value =
            try
                property.GetValue(objectExpression, null)
            with
            | ex -> $"<error: {ex.Message}>"

        printfn "%s = %A" property.Name value)

    Console.WriteLine "\n"

*)
// https://fsharp.github.io/fslang-spec/type-definitions/#84-record-type-definitions
type RecordField =
    {

      field_identifier: string
      field_type: string

     }
    member this.asString = $"{this.field_identifier} : {this.field_type}"

type RecordTypeDefinition =
    {

      type_name: string
      record_fields: RecordField seq

     }
    member this.asString =
        let record_fields_as_string =
            this.record_fields
            |> Seq.map (fun record_field -> "\t\t" + record_field.asString)
            |> String.concat "\n"

        $"""
type {this.type_name} = 
    {{
    {record_fields_as_string}
    }}
        """
            .TrimStart()
            .TrimEnd()

    static member fromType(particularType: Type) =
        let type_name = particularType.Name

        let record_fields =
            particularType.GetProperties()
            |> Array.map (fun property ->

                {


                  field_identifier = property.Name
                  field_type = property.PropertyType.FullName

                }

            )

        {

          type_name = type_name
          record_fields = record_fields

        }

module Identifier =
    let keywordSet: string Set =
        set [

              "abstract"
              "and"
              "as"
              "assert"
              "base"
              "begin"
              "class"
              "const"
              "default"
              "delegate"
              "do"
              "done"
              "downcast"
              "downto"
              "elif"
              "else"
              "end"
              "exception"
              "extern"
              "false"
              "finally"
              "fixed"
              "for"
              "fun"
              "function"
              "global"
              "if"
              "in"
              "inherit"
              "inline"
              "interface"
              "internal"
              "lazy"
              "let"
              "match"
              "member"
              "module"
              "mutable"
              "namespace"
              "new"
              "null"
              "of"
              "open"
              "or"
              "override"
              "private"
              "public"
              "rec"
              "return"
              "sig"
              "static"
              "struct"
              "then"
              "to"
              "true"
              "try"
              "type"
              "upcast"
              "use"
              "val"
              "void"
              "when"
              "while"
              "with"
              "yield" ]

    let futureSet: string Set =
        set [ "break"
              "checked"
              "component"
              "constraint"
              "continue"
              "fori"
              "include"
              "mixin"
              "parallel"
              "params"
              "process"
              "protected"
              "pure"
              "sealed"
              "tailcall"
              "trait"
              "virtual" ]

    let ocamlSet: string Set =
        set [ "break"
              "checked"
              "component"
              "const"
              "constraint"
              "continue"
              "event"
              "external"
              "include"
              "mixin"
              "parallel"
              "process"
              "protected"
              "pure"
              "sealed"
              "tailcall"
              "trait"
              "virtual"
              "land"

               ]

    let reservedKeywordSet =
        Set.unionMany (
            seq {
                keywordSet
                ocamlSet
                futureSet
            }
        )

    module Character =
        module First =
            let parser: Parser<char, unit> = choice [ pchar '_'; letter ]

        module Rest =
            let parser: Parser<string, unit> = manyChars (choice [ letter; digit; anyOf "\'_" ])

module Module =
    module Name =
        type ParameterRecord =
            { fallbackName: string
              keywordSet: Set<string>
              rawInput: string }

        let defaultParameters: ParameterRecord =
            { fallbackName = "ns"
              keywordSet = Identifier.reservedKeywordSet
              rawInput = "" }


        let parser (keywordSet: string Set) : Parser<string, unit> =
            pipe2 (Identifier.Character.First.parser) (Identifier.Character.Rest.parser) (fun first rest ->
                string first + rest)
            |>> fun rawName ->
                    match rawName with
                    | _ when keywordSet.Contains(rawName) -> $"``{rawName}``"
                    | _ -> rawName


        let inhabitant (parameter: ParameterRecord) : string =
            let backtickableName =
                parameter
                    .rawInput
                    .Replace('.', '_')
                    .Replace('+', '_')
                    .Replace('$', '_')
                    .Replace('&', '_')
                    .Replace('[', '_')
                    .Replace(']', '_')
                    .Replace('/', '_')
                    .Replace('\\', '_')
                    .Replace('*', '_')
                    .Replace('\"', '_')
                    .Replace('`', '_')

            match run (parser parameter.keywordSet .>> eof) backtickableName with
            | ParserResult.Success (moduleName, _, _) -> moduleName
            | ParserResult.Failure (msg, _, _) -> failwith msg
