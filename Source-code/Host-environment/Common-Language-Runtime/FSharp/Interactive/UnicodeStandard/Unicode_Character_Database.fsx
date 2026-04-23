open System
open System.IO
open System.Linq
open System.Text
open System.Xml
open System.Xml.XPath
open System.Text.Unicode
open System.Globalization
open System.Xml.Linq
open System.Diagnostics

#r "nuget: FsCheck"
#r "nuget: Unquote"
#r "nuget: FSharp.UMX"
#r "nuget: FsUnit"

open FsUnit
open FsCheck
open Swensen.Unquote.Assertions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\Attribute_Local_Names.fsx"
open Attribute_Local_Names
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

open System.Diagnostics




type AutoLogBuilder() =
    let autolog logged_expression =
        printfn "expression is %A" logged_expression

    member this.Bind(right_hand_expression, rest_of_block_parameterized_by_left_hand_identifier) =
        autolog right_hand_expression
        rest_of_block_parameterized_by_left_hand_identifier right_hand_expression

    member this.Return(expression_at_end_of_block) = expression_at_end_of_block

let autolog = new AutoLogBuilder()



type StopwatchBuilder() =
    member this.timer = new Stopwatch()

    member this.Delay(computation_expression_block_as_function) =
        printfn "Starting computation timer"
        this.timer.Start()
        computation_expression_block_as_function ()

    member this.Bind(value, rest) =
        printfn "Value: %A" value
        rest value

    member this.Return(expression_to_return) =
        let return_value = expression_to_return
        this.timer.Stop()
        printfn "%A" this.timer.ElapsedMilliseconds
        return_value

let stopwatch = StopwatchBuilder()

let result =
    stopwatch {
        let! x = 42
        return x
    }

let loggedWorkflow =
    autolog {
        let! x = 42
        let! y = 43
        let! z = x + y
        return z
    }



(*
#r "nuget: LiteDB"
open LiteDB

#r "nuget: Grafeo"

open Grafeo
open System.Collections.Generic

*)
#r "nuget: FSharp.UMX"
open FSharp.UMX
#r "nuget: Stellar.FastDB"
open Stellar.Collections



// union
// intersection
// complementation
// equality
// inclusion
// Material_Set<'ElementType when 'ElementType: comparison>





/// https://ncatlab.org/nlab/show/material+set+theory
[<RequireQualifiedAccess>]
type Material_Set<'ElementType when 'ElementType: comparison> =
    {

      set_definition_components: Set_Definition_Component<'ElementType> array

     }
    member this.contains(element: 'ElementType) =
        this.set_definition_components
        |> Array.exists (fun set_definition_component -> set_definition_component.contains element)

and [<RequireQualifiedAccess>] Set_Definition_Component<'ElementType when 'ElementType: comparison> =
    | FromExtensionalRoster of Extensional_Roster<'ElementType>
    | FromInclusiveInterval of Inclusive_Interval<'ElementType>

    member this.contains(element: 'ElementType) : bool =
        match this with
        | FromExtensionalRoster extensional_roster -> extensional_roster.contains element
        | FromInclusiveInterval inclusive_interval -> inclusive_interval.contains element

and Extensional_Roster<'ElementType when 'ElementType: comparison> =
    {

      extensional_set: Set<'ElementType>

     }
    member this.contains(element: 'ElementType) : bool = this.extensional_set.Contains(element)


and Inclusive_Interval<'ElementType when 'ElementType: comparison> =
    {

      first_element: 'ElementType
      last_element: 'ElementType

     }
    member this.contains(element: 'ElementType) =
        this.first_element <= element
        && element <= this.last_element


module Set_Definition_Component =
    let FromElementSequence<'ElementType when 'ElementType: comparison> (elements: seq<'ElementType>) =
        let element_set = Set.ofSeq elements
        let element_roster = { extensional_set = element_set }
        Set_Definition_Component.FromExtensionalRoster element_roster

    let FromElementInterval<'ElementType when 'ElementType: comparison>
        (first_element: 'ElementType)
        (last_element: 'ElementType)
        =
        test <@ first_element <= last_element @>

        Set_Definition_Component.FromInclusiveInterval
            { first_element = first_element
              last_element = last_element }

module Material_Set =
    let FromSetDefinitionComponent<'ElementType when 'ElementType: comparison>
        (set_definition_component: Set_Definition_Component<'ElementType>)
        : Material_Set<'ElementType> =
        {

          set_definition_components = [| set_definition_component |]

        }

    let FromSetDefinitionComponents<'ElementType when 'ElementType: comparison>
        (set_definition_components: Set_Definition_Component<'ElementType> array)
        : Material_Set<'ElementType> =
        {

          set_definition_components = set_definition_components

        }

    let FromInclusiveInterval<'ElementType when 'ElementType: comparison>
        (first_element: 'ElementType)
        (last_element: 'ElementType)

        : Material_Set<'ElementType> =
        FromSetDefinitionComponent(Set_Definition_Component.FromElementInterval first_element last_element)

    let FromExtensionalRoster<'ElementType when 'ElementType: comparison>
        (elements: 'ElementType list)

        : Material_Set<'ElementType> =
        FromSetDefinitionComponent(Set_Definition_Component.FromElementSequence elements)

    let FromSingleton<'ElementType when 'ElementType: comparison>
        (element: 'ElementType)

        : Material_Set<'ElementType> =
        FromExtensionalRoster [ element ]

    let FromUnion<'ElementType when 'ElementType: comparison>
        (material_sets: Material_Set<'ElementType> array)
        : Material_Set<'ElementType> =
        let concatenated_range_components =
            material_sets
            |> Array.collect (fun material_set ->

                material_set.set_definition_components
                |> Array.filter (fun set_definition_component -> set_definition_component.IsFromInclusiveInterval)
                |> Array.map (fun set_definition_component ->
                    let (Set_Definition_Component.FromInclusiveInterval inclusive_interval) =
                        set_definition_component

                    Set_Definition_Component.FromInclusiveInterval inclusive_interval


                )

            )

        let roster_set_union =
            material_sets
            |> Array.collect (fun material_set ->

                material_set.set_definition_components
                |> Array.filter (fun set_definition_component -> set_definition_component.IsFromExtensionalRoster)
                |> Array.map (fun set_definition_component ->
                    let (Set_Definition_Component.FromExtensionalRoster extensional_roster) =
                        set_definition_component

                    extensional_roster.extensional_set


                )

            )
            |> Set.unionMany

        let roster_union_component =
            if roster_set_union.Count > 0 then
                [| Set_Definition_Component.FromExtensionalRoster { extensional_set = roster_set_union } |]
            else
                [||]

        FromSetDefinitionComponents(Array.append concatenated_range_components roster_union_component)






let a_to_z = Material_Set.FromInclusiveInterval 0x0061 0x007A

let A_to_Z = Material_Set.FromInclusiveInterval 0x0041 0x005A

let ALPHA =
    Material_Set.FromUnion [| a_to_z
                              A_to_Z |]

let DIGIT = Material_Set.FromInclusiveInterval 0x0030 0x0039

let hyphen_minus = Material_Set.FromSingleton(int '-')
let full_stop = Material_Set.FromSingleton(int '.')
let low_line = Material_Set.FromSingleton(int '_')
let tilde = Material_Set.FromSingleton(int '~')

let unreserved =
    Material_Set.FromUnion [|

                              ALPHA
                              DIGIT
                              hyphen_minus
                              full_stop
                              low_line
                              tilde

                               |]









let fastDB_options = new FastDBOptions()
fastDB_options.DirectoryPath = @"C:\Repositories\eristocrates\ipa\Persistence\Database\Embedded\Document\FastDB"
fastDB_options.DatabaseName = "Unicode_Standard"
let fastDB = new FastDB(fastDB_options)

[<Struct>]
type Code_Point_Key = Code_Point_Key of int * string

[<Struct>]
type Unicode_Property<'PropertyType> = { value: 'PropertyType }

let unicode_code_space = fastDB.GetCollection<Code_Point_Key, string>()


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\PropertyAliases.fsx"
open PropertyAliases

[<Literal>]
let file_path = @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.flat.xml"





let xpath_document = stopwatch { return XPathDocument(file_path).CreateNavigator() }
// let type_provider = XmlProvider<file_path>.Load file_path


let ucd = XNamespace.op_Implicit "http://www.unicode.org/ns/2003/ucd/1.0"

let namespace_manager = XmlNamespaceManager xpath_document.NameTable
namespace_manager.AddNamespace("ucd", ucd.NamespaceName)




module XPathNodeIterator =
    let toElementArray (xpath_node_iterator: XPathNodeIterator) =
        seq {
            while xpath_node_iterator.MoveNext() do
                xpath_node_iterator.Current.Clone()
        }
        |> Seq.toArray

module XPathNavigator =
    let toAttributeArray (xpath_navigator: XPathNavigator) =
        seq {
            while xpath_navigator.MoveToNextAttribute() do
                xpath_navigator.Clone()
        }
        |> Seq.toArray

    let toParent (xpath_navigator: XPathNavigator) =
        let navigator = xpath_navigator.Clone()
        navigator.MoveToParent() |> ignore
        navigator



let navigate_xpath (xpath: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(xpath)
    xpath_expression.SetContext(namespace_manager)

    xpath_navigator.Select(xpath_expression)
    |> XPathNodeIterator.toElementArray

let document_xpath (xpath: string) = xpath_document |> navigate_xpath xpath

let char_elements () =
    document_xpath $"//ucd:char"
    |> Array.Parallel.filter (fun char_element ->

        String.IsNullOrWhiteSpace(char_element.GetAttribute("first-cp", ""))

    )

let char_attributes =
    char_elements ()
    |> Array.Parallel.collect (fun element ->
        element.MoveToFirstAttribute() |> ignore
        element |> XPathNavigator.toAttributeArray

    )
    |> Array.Parallel.filter (fun char_attribute -> not (String.IsNullOrEmpty char_attribute.Value))
    |> Array.Parallel.filter (fun char_attribute -> char_attribute.Value <> "N")
    |> Array.Parallel.filter (fun char_attribute -> char_attribute.Value <> "#")

char_attributes.Length
let int_from_hexdigit_string (hexdigit_string: string) = int $"0x{hexdigit_string}"

let code_point_from_attribute (char_attribute: XPathNavigator) =
    let char_attribute_element = char_attribute |> XPathNavigator.toParent
    let hexdigit_string = char_attribute_element.GetAttribute("cp", "")
    test <@ hexdigit_string.Length > 0 @>
    int_from_hexdigit_string hexdigit_string

let char_triples =
    char_attributes
    // |> Array.truncate 3
    |> Array.Parallel.map (fun char_attribute ->

        (code_point_from_attribute char_attribute, char_attribute.LocalName, char_attribute.Value)

    )

let (code_point, key, value) = char_triples |> Array.randomChoice


unicode_code_space.Add(Code_Point_Key(code_point, key), value)
unicode_code_space.Count
(*

    match char_attribute.LocalName with
    | "age" when char_attribute.Value <> "unassigned" ->


        unicode_code_space.Add(
            Code_Point_Key(code_point_from_attribute char_attribute, char_attribute.LocalName),
            { value = char_attribute.ValueAsDouble }
        )
    | _ ->

        unicode_code_space.Add(
            Code_Point_Key(code_point_from_attribute char_attribute, char_attribute.LocalName),
            { value = char_attribute.Value }
                    *)


(*

let databasePath = @"C:\Repositories\eristocrates\ipa\Application\LiteDB\lite.db"

let database = new LiteDatabase(databasePath)

// Get or create the collection
let customers = database.GetCollection<Customer>("customers")

// Create a new customer
let customer =
    {

      Id = 0 // LiteDB will auto-assign for int identity fields
      Name = "John Doe"
      Phones = [| "8000-0000"; "9000-0000" |]
      IsActive = true

    }

// Insert
customers.Insert(customer) |> ignore

// Re-read the inserted customer so the assigned Id is known
let inserted =
    customers.FindOne(fun (customer: Customer) -> customer.Name = "John Doe" && customer.IsActive)

// Update by creating a new record value
let updated = { inserted with Name = "Jane Doe" }

customers.Update(updated) |> ignore

// Create an index on Name
customers.EnsureIndex(fun (customer: Customer) -> customer.Name)
|> ignore

// Query with LINQ-like API
let results =
    customers
        .Query()
        .Where(fun (customer: Customer) -> customer.Name.StartsWith("J"))
        .OrderBy(fun (customer: Customer) -> customer.Name)
        .Limit(10)
        .ToList()

for customerResult in results do
    printfn $"%s{customerResult.Name}"

// Create a multikey index on Phones
customers.EnsureIndex(fun (customer: Customer) -> customer.Phones)
|> ignore

// Find one by phone number
let found =
    customers.FindOne(fun (customer: Customer) -> customer.Phones.Contains("9000-0000"))

match box found with
| null -> printfn "No matching customer found."
| _ -> printfn $"Found: %s{found.Name}"

*)






(*
task {
    use db =
        GrafeoDB.Open(@"C:\Repositories\eristocrates\ipa\Application\Grafeo\grafeo.db")

    // Execute a GQL query
    db.Execute("INSERT (:Person {name: 'Alix', age: 30})")
    |> ignore

    // Query with parameters
    let parameters = Dictionary<string, obj>()
    parameters["name"] <- "Alix"

    let result =
        db.ExecuteWithParams("MATCH (p:Person) WHERE p.name = $name RETURN p.name, p.age", parameters)

    for row in result.Rows do
        printfn "%O: %O" row["p.name"] row["p.age"]

    // Async execution
    let! asyncResult =
        db.ExecuteAsync("MATCH (p:Person) RETURN p")
        |> Async.AwaitTask

    // Just to prove we got something back
    printfn "Async rows: %d" asyncResult.Rows.Count

    // ACID transactions with auto-rollback
    use tx = db.BeginTransaction()

    tx.Execute("INSERT (:Person {name: 'Gus'})")
    |> ignore

    tx.Execute("INSERT (:Person {name: 'Vincent'})-[:KNOWS]->(:Person {name: 'Jules'})")
    |> ignore

    tx.Commit()
}
*)
(*
task {
    use db =
        GrafeoDB.Open(@"C:\Repositories\eristocrates\ipa\Application\Grafeo\grafeo.db")


    db.Execute("INSERT (:Person {name: 'Alix', age: 30})")
    |> ignore

    let args =
        dict [ "name", box "Alix" ]
        |> Dictionary<string, obj>

    let result =
        db.ExecuteWithParams("MATCH (p:Person) WHERE p.name = $name RETURN p.name, p.age", args)

    result.Rows
    |> Seq.iter (fun row -> printfn "%O: %O" row["p.name"] row["p.age"])

    use tx = db.BeginTransaction()

    tx.Execute("INSERT (:Person {name: 'Gus'})")
    |> ignore

    tx.Execute("INSERT (:Person {name: 'Vincent'})-[:KNOWS]->(:Person {name: 'Jules'})")
    |> ignore

    tx.Commit()
}
|> Async.AwaitTask
|> Async.RunSynchronously

let grafeo =
    GrafeoDB.Open(@"C:\Repositories\eristocrates\ipa\Application\Grafeo\grafeo.db")

let inspect_key (key: string) (dict: IReadOnlyDictionary<string, obj>) = $"{key}: {string (dict.Item key)}"

let info =
    seq {
        for key in grafeo.Info().Keys do
            grafeo.Info() |> inspect_key key
    }
    |> String.concat "\n"

grafeo.Info()

grafeo.Execute("MATCH (n) DETACH DELETE n")
|> ignore

grafeo.Execute("INSERT (:Person {name: 'Alix', age: 30})")
|> ignore

grafeo.Execute(
    """
    INSERT (:Person {
        name: 'Alix',
        age: 30,
        location: 'New York'
    })
    """
)

grafeo.Execute(
    """
    INSERT (:Person {
        name: 'Gus',
        age: 25,
        location: 'San Francisco'
    })
    """
)

grafeo.Execute(
    """
    INSERT (:Person {
        name: 'Harm',
        age: 35,
        location: 'New York'
    })
    """
)

grafeo.Execute(
    """
    INSERT (:Person {
        name: 'Dave',
        age: 28,
        location: 'Los Angeles'
    })
    """
)
// Alix knows Gus and Harm
grafeo.Execute(
    """
    MATCH (a:Person {name: 'Alix'}), (b:Person {name: 'Gus'})
    INSERT (a)-[:FRIENDS_WITH {since: 2020}]->(b)
"""
)

grafeo.Execute(
    """
    MATCH (a:Person {name: 'Alix'}), (c:Person {name: 'Harm'})
    INSERT (a)-[:FRIENDS_WITH {since: 2019}]->(c)
"""
)

// Gus knows Dave
grafeo.Execute(
    """
    MATCH (b:Person {name: 'Gus'}), (d:Person {name: 'Dave'})
    INSERT (b)-[:FRIENDS_WITH {since: 2021}]->(d)
"""
)

// Harm knows Dave
grafeo.Execute(
    """
    MATCH (c:Person {name: 'Harm'}), (d:Person {name: 'Dave'})
    INSERT (c)-[:FRIENDS_WITH {since: 2022}]->(d)
"""
)

let result =
    grafeo.ExecuteSparql(
        """
SELECT ?s ?p ?o
WHERE { ?s ?p ?o }
  """
    )
//let result = grafeo.Execute("MATCH (p:Person) RETURN p.name, p.age")

for row in result.Rows do
    printfn "%A" row

*)
