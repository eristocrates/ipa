open System
open System.Text
open System.IO
open System.Globalization

// https://fsharp.github.io/fslang-spec
open System.Reflection
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Reflection

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers












type Character =
    abstract member as_rune: Rune

type QueryFragment_Character =
    inherit Character

type Unreserved_Character =
    inherit Character

type Reserved_Character =
    inherit Character

type Subcomponent_Delimiter_Character =
    inherit Reserved_Character

type General_Component_Delimiter_Character =
    inherit Reserved_Character

type Path_Delimiter_Character =
    inherit General_Component_Delimiter_Character

type Percent_Encoded_Character =
    inherit Character
    abstract member left_digit: char
    abstract member right_digit: char
    abstract member as_literal: string

[<RequireQualifiedAccess>]
type Registered_Name_Character =
    | From_Unreserved_Character of Unreserved_Character
    | From_Subcomponent_Delimiter_Character of Subcomponent_Delimiter_Character
    | From_Percent_Encoded_Character of Percent_Encoded_Character
    member this.as_rune =
        match this with
        | From_Unreserved_Character unreserved_character -> unreserved_character.as_rune
        | From_Subcomponent_Delimiter_Character subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune
        | From_Percent_Encoded_Character percent_encoded_character -> percent_encoded_character.as_rune


[<RequireQualifiedAccess>]
type PathSegment_Character =
    | From_Character of Character
    | From_Percent_Encoded_Character of Percent_Encoded_Character
    | From_Subcomponent_Delimiter_Character of Subcomponent_Delimiter_Character
    | From_Unreserved_Character of Unreserved_Character
    member this.as_rune =
        match this with
        | From_Percent_Encoded_Character percent_encoded_character -> percent_encoded_character.as_rune
        | From_Subcomponent_Delimiter_Character subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune
        | From_Unreserved_Character unreserved_character -> unreserved_character.as_rune
// TODO consider typing head vs tail?
type Scheme_Character =
    inherit Character


type Decimal_Numeral =
    abstract member as_int: int

type Decimal_Octet =
    inherit Decimal_Numeral

type Port =
    inherit Decimal_Numeral


type Component =
    abstract member as_string: string

// https://www.rfc-editor.org/rfc/rfc3986#section-2.2

type Fragment =
    inherit Component
    abstract member fragment_sequence: QueryFragment_Character seq

// TODO handle key value query strings
type Query =
    inherit Component
    abstract member query_sequence: QueryFragment_Character seq
// abstract member mapping: Map<string,string>
// abstract member keys: string set
// abstract member values: string set

type Segment =
    inherit Component
    abstract member segment_character_sequence: PathSegment_Character seq

type NonZero_Segment =
    inherit Segment

type NonZero_NonColon_Segment =
    inherit NonZero_Segment


type Registered_Name =
    inherit Component
    abstract member registered_name_character_sequence: Registered_Name_Character seq

type IPv4address =
    inherit Component
    abstract member outer_left_octet: Decimal_Octet
    abstract member inner_left_octet: Decimal_Octet
    abstract member inner_right_octet: Decimal_Octet
    abstract member outer_right_octet: Decimal_Octet

[<RequireQualifiedAccess>]
type Host =
    | From_Registered_Name of Registered_Name
    | From_IPv4address of IPv4address
    member this.as_string =
        match this with
        | From_Registered_Name registered_name -> registered_name.as_string
        | From_IPv4address ipv4address -> ipv4address.as_string


type UserInfo =
    inherit Component
    abstract member userinfo_character_sequence: PathSegment_Character seq

type Authority =
    inherit Component
    abstract member userinfo: UserInfo option
    abstract member host: Host
    abstract member port: Port option

type Scheme =
    inherit Component
    abstract member scheme_character_sequence: Scheme_Character seq




type Path_ =
    inherit Component
    abstract member segment_sequence: Segment seq


type Empty_Path =
    inherit Path_
    inherit Component


type Abempty_Path =
    inherit Path_

type Tailed_Path =
    inherit Path_
    abstract member tail_segment_sequence: Segment seq

type NonZero_Path =
    inherit Tailed_Path
    abstract member head_segment: NonZero_Segment

type NoScheme_Path =
    inherit Tailed_Path
    inherit Component
    abstract member head_segment: NonZero_NonColon_Segment

type Rootless_Path =
    inherit Tailed_Path
    abstract member head_segment: NonZero_Segment

type Absolute_Path =
    inherit Path_
    inherit Component
    abstract member nonzero_path: NonZero_Path option

type Network_Path =
    inherit Component
    abstract member network_authority: Authority
    abstract member abempty_path: Abempty_Path option


[<RequireQualifiedAccess>]
type Relative_Part =
    | From_Empty_Path of Empty_Path
    | From_NoScheme_Path of NoScheme_Path
    | From_Absolute_Path of Absolute_Path
    | From_Network_Path of Network_Path
    member this.as_string =
        match this with
        | From_Empty_Path empty_path -> empty_path.as_string
        | From_NoScheme_Path noscheme_path -> noscheme_path.as_string
        | From_Absolute_Path absolute_path -> absolute_path.as_string
        | From_Network_Path network_path -> network_path.as_string

[<RequireQualifiedAccess>]
type Hierarchical_Part =
    | From_Empty_Path of Empty_Path
    | From_Rootless_Path of Rootless_Path
    | From_Absolute_Path of Absolute_Path
    | From_Network_Path of Network_Path
    member this.as_string =
        match this with
        | From_Empty_Path empty_path -> empty_path.as_string
        | From_Rootless_Path rootless_path -> rootless_path.as_string
        | From_Absolute_Path absolute_path -> absolute_path.as_string
        | From_Network_Path network_path -> network_path.as_string




type URI_Reference =
    inherit Component

type Relative_Reference =
    inherit URI_Reference
    abstract member relative_part: Relative_Part
    abstract member query: Query option
    abstract member fragment: Fragment option

type Absolute_URI =
    inherit Component
    abstract member scheme: Scheme
    abstract hierarchical_part: Hierarchical_Part
    abstract member query: Query option

type URI =
    inherit Absolute_URI
    inherit URI_Reference
    abstract member fragment: Fragment option

















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

let isInspectableUnionType (type_: Type) =
    FSharpType.IsUnion(type_, true)
    && not (isOptionType type_)

let isListType (type_: Type) =
    type_.IsGenericType
    && type_.GetGenericTypeDefinition() = typedefof<list<_>>

let isInspectableRuntimeUnionType (type_: Type) =
    FSharpType.IsUnion(type_, true)
    && not (isOptionType type_)
    && not (isListType type_)

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

            elif isInspectableRuntimeUnionType valueType then
                formatUnionValue depth valueType value

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

and formatUnionValue (depth: int) (unionType: Type) (unionValue: obj) =
    let unionCaseInfo, unionFields =
        FSharpValue.GetUnionFields(unionValue, unionType, true)

    match unionFields with
    | [||] -> unionCaseInfo.Name
    | [| singleField |] -> $"{unionCaseInfo.Name} ({formatValue (depth + 1) singleField})"
    | multipleFields ->
        let formattedFields =
            multipleFields
            |> Array.map (formatValue (depth + 1))
            |> String.concat ", "

        $"{unionCaseInfo.Name} ({formattedFields})"

and formatPropertyValue (depth: int) (propertyType: Type) (propertyValue: obj) =
    if isOptionType propertyType then
        if isNull propertyValue then
            "None"
        else
            let _, unionFields = FSharpValue.GetUnionFields(propertyValue, propertyType, true)

            match unionFields with
            | [| innerValue |] -> $"Some ({formatValue (depth + 1) innerValue})"
            | _ -> "None"

    elif isInspectableUnionType propertyType then
        if isNull propertyValue then
            "null"
        else
            formatUnionValue depth propertyType propertyValue

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





addInterfacePrinter<Character> ()
addInterfacePrinter<QueryFragment_Character> ()
addInterfacePrinter<PathSegment_Character> ()
addInterfacePrinter<Registered_Name_Character> ()
addInterfacePrinter<Unreserved_Character> ()
addInterfacePrinter<Reserved_Character> ()
addInterfacePrinter<Subcomponent_Delimiter_Character> ()
addInterfacePrinter<General_Component_Delimiter_Character> ()
addInterfacePrinter<Path_Delimiter_Character> ()
addInterfacePrinter<Percent_Encoded_Character> ()
addInterfacePrinter<Scheme_Character> ()

addInterfacePrinter<Decimal_Numeral> ()
addInterfacePrinter<Decimal_Octet> ()
addInterfacePrinter<Port> ()

addInterfacePrinter<Component> ()
addInterfacePrinter<Fragment> ()
addInterfacePrinter<Query> ()
addInterfacePrinter<Segment> ()
addInterfacePrinter<NonZero_Segment> ()
addInterfacePrinter<NonZero_NonColon_Segment> ()

addInterfacePrinter<Host> ()
addInterfacePrinter<Registered_Name> ()
addInterfacePrinter<IPv4address> ()

addInterfacePrinter<UserInfo> ()
addInterfacePrinter<Authority> ()
addInterfacePrinter<Scheme> ()

addInterfacePrinter<Hierarchical_Part> ()
addInterfacePrinter<Relative_Part> ()
addInterfacePrinter<Path_> ()
addInterfacePrinter<Empty_Path> ()
addInterfacePrinter<Abempty_Path> ()
addInterfacePrinter<Tailed_Path> ()
addInterfacePrinter<NonZero_Path> ()
addInterfacePrinter<NoScheme_Path> ()
addInterfacePrinter<Rootless_Path> ()
addInterfacePrinter<Absolute_Path> ()
addInterfacePrinter<Network_Path> ()

addInterfacePrinter<URI_Reference> ()
addInterfacePrinter<Relative_Reference> ()
addInterfacePrinter<Absolute_URI> ()
addInterfacePrinter<URI> ()
