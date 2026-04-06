// https://fsharp.github.io/fslang-spec
open System

open System.Reflection

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
