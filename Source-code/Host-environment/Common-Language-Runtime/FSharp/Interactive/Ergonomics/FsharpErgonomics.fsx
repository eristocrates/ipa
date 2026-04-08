// https://fsharp.github.io/fslang-spec
open System

open System.Reflection

#r "nuget: FParsec"
open FParsec

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
