// https://fsharp.github.io/fslang-spec
open System


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
