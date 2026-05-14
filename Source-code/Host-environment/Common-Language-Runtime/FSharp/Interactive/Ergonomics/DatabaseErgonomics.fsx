open System
open System.Xml
open System.Text
open System.Diagnostics
open System.Globalization
open System.IO

#r "nuget: LightningDB"
#r "nuget: MessagePack"
#r "nuget: MessagePack.FSharpExtensions"

#r "nuget: UUIDNext"

open UUIDNext.Tools
open UUIDNext

open LightningDB
open MessagePack


#r "nuget: Unquote"
#r "nuget: XParsec"
#r "nuget: Hedgehog"
#r "nuget: NeatIntervals"

open Swensen.Unquote.Assertions
#r "nuget: FsCheck"
open FsCheck
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

open StringExtensions
open Resource_Identifier
open XParsecErgonomics
open Unicode_Standard
open XParsec
open Internationalized_Resource_Identifier
open MessagePack.Resolvers
open MessagePack.FSharp


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\RdfErgonomics.fsx"
open RdfErgonomics


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\DiagnosticsErgonomics.fsx"
open DiagnosticsErgonomics

let message_pack_options =
    MessagePackSerializerOptions.Standard.WithResolver(
        CompositeResolver.Create(FSharpResolver.Instance, StandardResolver.Instance)
    )



































































type Database_Handles =
    { entity_to_component_id: LightningDatabase
      component_id_to_component: LightningDatabase
      component_to_component_id: LightningDatabase }

type Transaction_Context =
    { environment: LightningEnvironment
      databases: Database_Handles }

module Component_Id =

    type T = uint64

    let zero: T = 0UL

    let to_bytes (id: T) =
        let bytes = BitConverter.GetBytes(id)

        if BitConverter.IsLittleEndian then
            Array.Reverse(bytes)

        bytes

    let from_bytes (bytes: byte array) =
        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

let default_context = RDF_Context.Default_Context

module Assert =
    let inline spo<'SubjectType, 'PredicateType, 'ObjectType when 'SubjectType: (member as_subject: RDF_Subject) and 'PredicateType: (member as_predicate:
        RDF_Predicate) and 'ObjectType: (member as_object: RDF_Object)>
        (left_term: 'SubjectType)
        (center_term: 'PredicateType)
        (right_term: 'ObjectType)
        =
        {

          triple =
              { curSubject = left_term.as_subject
                curPredicate = center_term.as_predicate
                curObject = right_term.as_object }
          context = default_context }

    let inline spoc<'SubjectType, 'PredicateType, 'ObjectType, 'ContextType when 'SubjectType: (member as_subject:
        RDF_Subject) and 'PredicateType: (member as_predicate: RDF_Predicate) and 'ObjectType: (member as_object:
        RDF_Object) and 'ContextType: (member as_context: RDF_Context)>
        (left_term: 'SubjectType)
        (center_term: 'PredicateType)
        (right_term: 'ObjectType)
        (context_term: 'ContextType)
        =
        { spo left_term center_term right_term with

            context = context_term.as_context

         }

module RDF_Quad =
    let from_triple triple =
        { triple = triple
          context = default_context }

// TODO fix this component constructor, and figure out a way for quad_components to work with the term constructors|

module Component =
    let inline attribute_value<'AttributeType when 'AttributeType: (member as_predicate: RDF_Predicate)>
        (attribute: 'AttributeType)
        (quad: RDF_Quad)
        =
        {

          Attribute = attribute.as_predicate.representation.as_string
          Value = Statement.from_quad quad

        }

module LMDB =
    module Transaction =

        let write
            (transaction_context: Transaction_Context)
            (operation: LightningTransaction -> Database_Handles -> 'Result)
            =
            use transaction = transaction_context.environment.BeginTransaction()

            let result = operation transaction transaction_context.databases

            transaction.Commit() |> ignore

            result

        let read
            (transaction_context: Transaction_Context)
            (operation: LightningTransaction -> Database_Handles -> 'Result)
            =

            use transaction =
                transaction_context.environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            let result = operation transaction transaction_context.databases



            result


    /// http://www.lmdb.tech/doc/group__mdb__dbi__open.html#gaea2d873575b7875771ea5296b4c85beb
    module DatabaseConfiguration =


        let use_reverse_string_keys (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <-
                (database_configuration.Flags
                 ||| DatabaseOpenFlags.ReverseKey)

            database_configuration

        let use_sorted_duplicates (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <-
                (database_configuration.Flags
                 ||| DatabaseOpenFlags.DuplicatesSort)

            database_configuration

        let use_numeric_keys_in_native_byte_order (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <-
                (database_configuration.Flags
                 ||| DatabaseOpenFlags.IntegerKey)

            database_configuration

        let use_sorted_duplicates_with_fixed_size (database_configuration: DatabaseConfiguration) =

            database_configuration.Flags <-
                (database_configuration.Flags
                 ||| DatabaseOpenFlags.DuplicatesFixed)

            database_configuration |> use_sorted_duplicates

        let use_sorted_duplicates_with_numeric_keys_in_native_byte_order
            (database_configuration: DatabaseConfiguration)
            =

            database_configuration.Flags <-
                (database_configuration.Flags
                 ||| DatabaseOpenFlags.IntegerDuplicates)

            database_configuration |> use_sorted_duplicates

        let use_sorted_duplicates_with_reverse_string_keys (database_configuration: DatabaseConfiguration) =

            database_configuration.Flags <-
                (database_configuration.Flags
                 ||| DatabaseOpenFlags.ReverseDuplicates)

            database_configuration |> use_sorted_duplicates

        let create_DB_if_not_already_existing (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <-
                (database_configuration.Flags
                 ||| DatabaseOpenFlags.Create)

            database_configuration

        let duplicate_key_environment () =
            let database_open_config = DatabaseConfiguration()

            database_open_config.Flags <-
                (DatabaseOpenFlags.Create
                 ||| DatabaseOpenFlags.DuplicatesSort)

            database_open_config

    module env =
        let create_gigabytes_at_path (gigabites: int) (directory_path: string) =
            System.IO.Directory.CreateDirectory(directory_path)
            |> ignore

            let environment = new LightningEnvironment(directory_path)
            environment.MapSize <- int64 gigabites * GiB
            environment




module Decoded =

    let from_bytes (component_bytes: ReadOnlyMemory<byte>) =
        MessagePackSerializer.Deserialize<Component>(component_bytes, message_pack_options)



module Bytes =
    let from_runtime<'ComponentType> (runtime_component: 'ComponentType) =
        MessagePackSerializer.Serialize(runtime_component, message_pack_options)


module MDBValue =
    let decode (value: MDBValue) =
        value.AsSpan().ToArray()
        |> ReadOnlyMemory
        |> Decoded.from_bytes

module MDBResultCode =

    let succeeded (result_code: MDBResultCode) = result_code = MDBResultCode.Success

    let failed (result_code: MDBResultCode) = result_code <> MDBResultCode.Success

    let fail_if_not_success (operation_name: string) (result_code: MDBResultCode) =
        if result_code <> MDBResultCode.Success then
            failwith $"{operation_name} failed with MDBResultCode: {result_code}"


let next_component_id (transaction: LightningTransaction) (databases: Database_Handles) =
    use cursor = transaction.CreateCursor(databases.component_id_to_component)

    match cursor.Last() with
    | struct (MDBResultCode.Success, id_value, _component_value) ->
        let last_id =
            id_value.AsSpan().ToArray()
            |> Component_Id.from_bytes

        last_id + 1UL

    | _ -> 0UL

module Component_Lookup_Key =

    let from_component_bytes (component_bytes: byte array) =
        use sha256 = System.Security.Cryptography.SHA256.Create()

        sha256.ComputeHash(component_bytes)

let get_or_create_component_id (transaction: LightningTransaction) (databases: Database_Handles) Component =
    let component_bytes = Bytes.from_runtime Component

    match transaction.Get(databases.component_to_component_id, component_bytes) with
    | struct (MDBResultCode.Success, _component_key_value, component_id_value) -> component_id_value.AsSpan().ToArray()

    | _ ->
        let component_id = next_component_id transaction databases

        let component_id_bytes = Component_Id.to_bytes component_id

        transaction.Put(databases.component_id_to_component, component_id_bytes, component_bytes)
        |> MDBResultCode.fail_if_not_success "put component id -> component"

        let component_lookup_key_bytes =
            Component_Lookup_Key.from_component_bytes component_bytes

        transaction.Put(databases.component_to_component_id, component_lookup_key_bytes, component_id_bytes)
        |> MDBResultCode.fail_if_not_success "put component lookup key -> component id"

        component_id_bytes

let open_databases (environment: LightningEnvironment) =
    use transaction = environment.BeginTransaction()

    let entity_to_component_id =
        transaction.OpenDatabase(
            "entity_to_component_id",
            DatabaseConfiguration(
                Flags =
                    (DatabaseOpenFlags.Create
                     ||| DatabaseOpenFlags.DuplicatesSort)
            )
        )

    let component_id_to_component =
        transaction.OpenDatabase("component_id_to_component", DatabaseConfiguration(Flags = DatabaseOpenFlags.Create))

    let component_to_component_id =
        transaction.OpenDatabase("component_to_component_id", DatabaseConfiguration(Flags = DatabaseOpenFlags.Create))

    transaction.Commit() |> ignore

    { entity_to_component_id = entity_to_component_id
      component_id_to_component = component_id_to_component
      component_to_component_id = component_to_component_id }

module Write =

    let Entity'Components (entity'components: Entity'Component array) (transaction_context: Transaction_Context) =

        let stopwatch = Stopwatch.StartNew()

        let mutable written = 0

        for entity'component_batch in entity'components |> Array.chunkBySize batch_size do

            LMDB.Transaction.write transaction_context (fun transaction databases ->

                for entity'component in entity'component_batch do
                    let entity_bytes = Encoding.UTF8.GetBytes(entity'component.Entity)

                    let Component = entity'component.Component

                    let component_id_bytes = get_or_create_component_id transaction databases Component

                    transaction.Put(databases.entity_to_component_id, entity_bytes, component_id_bytes)
                    |> MDBResultCode.fail_if_not_success "put entity -> component id"

                entity'component_batch.Length)
            |> ignore

            written <- written + entity'component_batch.Length

            let rate = float written / stopwatch.Elapsed.TotalSeconds

            printfn
                "written=%i/%i rate=%.0f components/sec elapsed=%O"
                written
                entity'components.Length
                rate
                stopwatch.Elapsed

        stopwatch.Stop()

        printfn
            "done written=%i elapsed=%O average-rate=%.0f components/sec"
            written
            stopwatch.Elapsed
            (float written / stopwatch.Elapsed.TotalSeconds)

module Read =

    let Component_By_Id
        (component_id_bytes: byte array)
        (transaction: LightningTransaction)
        (databases: Database_Handles)
        =

        match transaction.Get(databases.component_id_to_component, component_id_bytes) with
        | struct (MDBResultCode.Success, _component_id_value, component_value) -> MDBValue.decode component_value

        | result -> failwith $"component id lookup failed: {result}"

    let Entity'Components (transaction_context: Transaction_Context) =

        LMDB.Transaction.read transaction_context (fun transaction databases ->

            use cursor = transaction.CreateCursor(databases.entity_to_component_id)

            cursor.AsEnumerable()
            |> Seq.map (fun struct (entity_value, component_id_value) ->

                let entity = Encoding.UTF8.GetString(entity_value.AsSpan())

                let component_id_bytes = component_id_value.AsSpan().ToArray()

                let Component = Component_By_Id component_id_bytes transaction databases

                { Entity = entity
                  Component = Component }: Entity'Component)
            |> Seq.toArray)


    let Components_for_Entity (entity: string) (transaction_context: Transaction_Context) =

        LMDB.Transaction.read transaction_context (fun transaction databases ->

            use cursor = transaction.CreateCursor(databases.entity_to_component_id)

            let requested_entity_bytes = Encoding.UTF8.GetBytes(entity)

            match cursor.Set(requested_entity_bytes), cursor.GetCurrent() with
            | MDBResultCode.Success, struct (MDBResultCode.Success, actual_entity_value, first_component_id_value) ->

                let actual_entity = Encoding.UTF8.GetString(actual_entity_value.AsSpan())

                if actual_entity <> entity then
                    [||]
                else
                    let Components = ResizeArray<Component>()

                    let first_component_id_bytes = first_component_id_value.AsSpan().ToArray()

                    Components.Add(Component_By_Id first_component_id_bytes transaction databases)

                    let mutable keep_reading = true

                    while keep_reading do
                        match cursor.NextDuplicate() with
                        | struct (MDBResultCode.Success, _entity_value, component_id_value) ->
                            let component_id_bytes = component_id_value.AsSpan().ToArray()

                            Components.Add(Component_By_Id component_id_bytes transaction databases)

                        | _ -> keep_reading <- false

                    Components.ToArray()

            | _ -> [||])


module Migrate =

    let Entity (transaction_context: Transaction_Context) (old_entity: string) (new_entity: string) =

        LMDB.Transaction.write transaction_context (fun transaction databases ->

            use cursor = transaction.CreateCursor(databases.entity_to_component_id)

            let old_entity_bytes = Encoding.UTF8.GetBytes(old_entity)

            let new_entity_bytes = Encoding.UTF8.GetBytes(new_entity)

            let component_id_bytes = ResizeArray<byte []>()

            match cursor.Set(old_entity_bytes), cursor.GetCurrent() with
            | MDBResultCode.Success, struct (MDBResultCode.Success, actual_entity_value, first_component_id_value) ->

                let actual_entity = Encoding.UTF8.GetString(actual_entity_value.AsSpan())

                if actual_entity <> old_entity then
                    failwith $"No exact entity key found for old entity: {old_entity}"

                component_id_bytes.Add(first_component_id_value.AsSpan().ToArray())

                let mutable keep_reading = true

                while keep_reading do
                    match cursor.NextDuplicate() with
                    | struct (MDBResultCode.Success, _entity_value, component_id_value) ->
                        component_id_bytes.Add(component_id_value.AsSpan().ToArray())

                    | _ -> keep_reading <- false

            | _ -> failwith $"No components found for old entity key: {old_entity}"

            for component_id in component_id_bytes do
                transaction.Put(databases.entity_to_component_id, new_entity_bytes, component_id)
                |> MDBResultCode.fail_if_not_success "put migrated entity -> component id"

            transaction.Delete(databases.entity_to_component_id, old_entity_bytes)
            |> MDBResultCode.fail_if_not_success "delete old entity key"

            component_id_bytes.Count)
        |> ignore

module Delete =

    let Entity (entity: string) (transaction_context: Transaction_Context) =

        LMDB.Transaction.write transaction_context (fun transaction databases ->

            let entity_bytes = Encoding.UTF8.GetBytes(entity)

            match transaction.Delete(databases.entity_to_component_id, entity_bytes) with
            | MDBResultCode.Success -> 1

            | MDBResultCode.NotFound -> 0

            | result_code -> failwith $"delete entity failed with MDBResultCode: {result_code}")
        |> ignore (*
    let Entity (entity: string) (transaction_context: Transaction_Context) =

        LMDB.Transaction.write "delete entity" transaction_context (fun transaction database ->

            let entity_bytes = Encoding.UTF8.GetBytes(entity)

            let result_code = transaction.Delete(database, entity_bytes)

            MDBResultCode.fail_if_not_success "delete entity" result_code

            1)
        |> ignore

*)

module Update =

    let Components_for_Entity
        (entity: string)
        (transaction_context: Transaction_Context)
        (update_component: Component -> Component)
        =

        LMDB.Transaction.write transaction_context (fun transaction databases ->

            use cursor = transaction.CreateCursor(databases.entity_to_component_id)

            let entity_bytes = Encoding.UTF8.GetBytes(entity)

            let existing_component_id_bytes = ResizeArray<byte []>()

            match cursor.Set(entity_bytes), cursor.GetCurrent() with
            | MDBResultCode.Success, struct (MDBResultCode.Success, actual_entity_value, first_component_id_value) ->

                let actual_entity = Encoding.UTF8.GetString(actual_entity_value.AsSpan())

                if actual_entity <> entity then
                    0
                else
                    existing_component_id_bytes.Add(first_component_id_value.AsSpan().ToArray())

                    let mutable keep_reading = true

                    while keep_reading do
                        match cursor.NextDuplicate() with
                        | struct (MDBResultCode.Success, _entity_value, component_id_value) ->
                            existing_component_id_bytes.Add(component_id_value.AsSpan().ToArray())

                        | _ -> keep_reading <- false

                    transaction.Delete(databases.entity_to_component_id, entity_bytes)
                    |> MDBResultCode.fail_if_not_success "delete old entity -> component ids"

                    for component_id_bytes in existing_component_id_bytes do
                        let existing_Component =
                            Read.Component_By_Id component_id_bytes transaction databases

                        let updated_Component = update_component existing_Component

                        let updated_component_id_bytes =
                            get_or_create_component_id transaction databases updated_Component

                        transaction.Put(databases.entity_to_component_id, entity_bytes, updated_component_id_bytes)
                        |> MDBResultCode.fail_if_not_success "put updated entity -> component id"

                    existing_component_id_bytes.Count

            | _ -> 0)
        |> ignore

    let Entities_with_Component
        (transaction_context: Transaction_Context)
        (update_entity'component: Entity'Component -> Entity'Component)
        =

        LMDB.Transaction.write transaction_context (fun transaction databases ->

            use cursor = transaction.CreateCursor(databases.entity_to_component_id)

            let existing_entity'components =
                cursor.AsEnumerable()
                |> Seq.map (fun struct (entity_value, component_id_value) ->

                    let entity = Encoding.UTF8.GetString(entity_value.AsSpan())

                    let component_id_bytes = component_id_value.AsSpan().ToArray()

                    let Component = Read.Component_By_Id component_id_bytes transaction databases

                    { Entity = entity
                      Component = Component }: Entity'Component)
                |> Seq.toArray

            let updated_entity'components =
                existing_entity'components
                |> Array.map update_entity'component

            let entities_to_delete =
                existing_entity'components
                |> Array.map (fun entity'component -> entity'component.Entity)
                |> Array.distinct

            for entity in entities_to_delete do
                let entity_bytes = Encoding.UTF8.GetBytes(entity)

                match transaction.Delete(databases.entity_to_component_id, entity_bytes) with
                | MDBResultCode.Success
                | MDBResultCode.NotFound -> ()

                | result_code -> failwith $"delete old entity index entries failed with MDBResultCode: {result_code}"

            for entity'component in updated_entity'components do
                let entity_bytes = Encoding.UTF8.GetBytes(entity'component.Entity)

                let component_id_bytes =
                    get_or_create_component_id transaction databases entity'component.Component

                transaction.Put(databases.entity_to_component_id, entity_bytes, component_id_bytes)
                |> MDBResultCode.fail_if_not_success "put updated entity -> component id"

            updated_entity'components.Length)
        |> ignore
