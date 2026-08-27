#r "nuget: CaseConverter"
open CaseConverter

type Converters with
    static member to_snake_case(original_string: string) = Converters.ToSnakeCase(original_string)
    static member toCamelCase(original_string: string) = Converters.ToCamelCase(original_string)

    static member To_Pascal_Snake_Case(original_string: string) =
        original_string
        |> Converters.ToSnakeCase
        |> Converters.ToTitleCase
