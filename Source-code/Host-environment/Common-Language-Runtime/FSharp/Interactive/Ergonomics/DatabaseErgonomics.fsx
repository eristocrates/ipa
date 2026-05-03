open System
open System.Text
open System.Diagnostics
open System.Globalization
open System.IO

#r "nuget: LightningDB"
#r "nuget: MessagePack"
#r "nuget: UUIDNext"

open LightningDB
open MessagePack
open UUIDNext.Tools
open UUIDNext


#r "nuget: ObjectLayoutInspector"
open ObjectLayoutInspector


// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

// open Internationalized_Resource_Identifier
// open XParsecErgonomics

let GiB = 1024L * 1024L * 1024L

type Transaction_Context =
    {

      environment: LightningEnvironment
      database_configuration: DatabaseConfiguration

    }

let encode_component<'ComponentType> (runtime_component: 'ComponentType) =
    MessagePackSerializer.Serialize(runtime_component)

let decode_component<'ComponentType> (component_bytes: ReadOnlyMemory<byte>) =
    MessagePackSerializer.Deserialize<'ComponentType>(component_bytes)


module LMDB =
    module Transaction =

        let read
            (operation_name: string)
            (transaction_context: Transaction_Context)
            (operation: LightningTransaction -> LightningDatabase -> 'Result)
            =
            let stopwatch = Stopwatch.StartNew()

            use transaction =
                transaction_context.environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            use database =
                transaction.OpenDatabase(configuration = transaction_context.database_configuration)

            let result = operation transaction database

            stopwatch.Stop()

            printfn "%s elapsed=%O" operation_name stopwatch.Elapsed

            result


        let write
            (operation_name: string)
            (transaction_context: Transaction_Context)
            (operation: LightningTransaction -> LightningDatabase -> 'Result)
            =
            let stopwatch = Stopwatch.StartNew()

            use transaction = transaction_context.environment.BeginTransaction()

            use database =
                transaction.OpenDatabase(configuration = transaction_context.database_configuration)

            let result = operation transaction database

            transaction.Commit() |> ignore

            stopwatch.Stop()

            printfn "%s elapsed=%O" operation_name stopwatch.Elapsed

            result

    /// http://www.lmdb.tech/doc/group__mdb__dbi__open.html#gaea2d873575b7875771ea5296b4c85beb
    module DatabaseConfiguration =


        let use_reverse_string_keys (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <- (database_configuration.Flags ||| DatabaseOpenFlags.ReverseKey)

            database_configuration

        let use_sorted_duplicates (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <- (database_configuration.Flags ||| DatabaseOpenFlags.DuplicatesSort)

            database_configuration

        let use_numeric_keys_in_native_byte_order (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <- (database_configuration.Flags ||| DatabaseOpenFlags.IntegerKey)

            database_configuration

        let use_sorted_duplicates_with_fixed_size (database_configuration: DatabaseConfiguration) =

            database_configuration.Flags <- (database_configuration.Flags ||| DatabaseOpenFlags.DuplicatesFixed)

            database_configuration |> use_sorted_duplicates

        let use_sorted_duplicates_with_numeric_keys_in_native_byte_order
            (database_configuration: DatabaseConfiguration)
            =

            database_configuration.Flags <- (database_configuration.Flags ||| DatabaseOpenFlags.IntegerDuplicates)

            database_configuration |> use_sorted_duplicates

        let use_sorted_duplicates_with_reverse_string_keys (database_configuration: DatabaseConfiguration) =

            database_configuration.Flags <- (database_configuration.Flags ||| DatabaseOpenFlags.ReverseDuplicates)

            database_configuration |> use_sorted_duplicates

        let create_DB_if_not_already_existing (database_configuration: DatabaseConfiguration) =
            database_configuration.Flags <- (database_configuration.Flags ||| DatabaseOpenFlags.Create)

            database_configuration

        let duplicate_key_environment () =
            let database_open_config = DatabaseConfiguration()

            database_open_config.Flags <- (DatabaseOpenFlags.Create ||| DatabaseOpenFlags.DuplicatesSort)

            database_open_config

    module env =
        let create_gigabytes_at_path (gigabites: int) (directory_path: string) =
            System.IO.Directory.CreateDirectory(directory_path) |> ignore

            let environment = new LightningEnvironment(directory_path)
            environment.MapSize <- int64 gigabites * GiB
            environment

module Encoded =
    [<MessagePackObject>]
    type Component =
        { [<Key(0)>]
          component_type: string

          [<Key(1)>]
          component_bytes: byte[] }

    type Entity'Component =
        { Entity: string; Component: Component }



module Decoded =
    type Entity'Component<'ComponentType> =
        { Entity: string
          Component: 'ComponentType }

    let from_bytes<'ComponentType> (component_bytes: ReadOnlyMemory<byte>) =
        MessagePackSerializer.Deserialize<'ComponentType>(component_bytes)



module Bytes =
    let from_runtime<'ComponentType> (runtime_component: 'ComponentType) =
        MessagePackSerializer.Serialize(runtime_component)


module MDBValue =
    let decode<'ComponentType> (value: MDBValue) =
        value.AsSpan().ToArray() |> ReadOnlyMemory |> Decoded.from_bytes<'ComponentType>

module MDBResultCode =

    let succeeded (result_code: MDBResultCode) = result_code = MDBResultCode.Success

    let failed (result_code: MDBResultCode) = result_code <> MDBResultCode.Success

    let fail_if_not_success (operation_name: string) (result_code: MDBResultCode) =
        if result_code <> MDBResultCode.Success then
            failwith $"{operation_name} failed with MDBResultCode: {result_code}"

module Write =

    let Entity'Components<'ComponentType>
        (component_type: string)
        (entity'components: Decoded.Entity'Component<'ComponentType> array)
        (transaction_context: Transaction_Context)
        =

        let batch_size = 250_000
        let stopwatch = Stopwatch.StartNew()

        let mutable written = 0

        for entity'component_batch in entity'components |> Array.chunkBySize batch_size do

            LMDB.Transaction.write "write entity-components batch" transaction_context (fun transaction database ->

                for entity'component in entity'component_batch do
                    let entity_bytes = Encoding.UTF8.GetBytes(entity'component.Entity)

                    let encoded_component: Encoded.Component =
                        { component_type = component_type
                          component_bytes = Bytes.from_runtime entity'component.Component }

                    let encoded_component_bytes = Bytes.from_runtime encoded_component

                    transaction.Put(database, entity_bytes, encoded_component_bytes) |> ignore

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

    let Components_for_Entity (entity: string) (transaction_context: Transaction_Context) =

        LMDB.Transaction.read "read encoded components for entity" transaction_context (fun transaction database ->

            use cursor = transaction.CreateCursor(database)

            let requested_entity_bytes = Encoding.UTF8.GetBytes(entity)

            match cursor.Set(requested_entity_bytes), cursor.GetCurrent() with
            | MDBResultCode.Success, struct (MDBResultCode.Success, actual_entity_value, first_component_value) ->

                let actual_entity = Encoding.UTF8.GetString(actual_entity_value.AsSpan())

                if actual_entity <> entity then
                    [||]
                else
                    let components = ResizeArray<Encoded.Component>()

                    components.Add(MDBValue.decode<Encoded.Component> first_component_value)

                    let mutable keep_reading = true

                    while keep_reading do
                        match cursor.NextDuplicate() with
                        | struct (MDBResultCode.Success, _entity_value, component_value) ->
                            components.Add(MDBValue.decode<Encoded.Component> component_value)

                        | _ -> keep_reading <- false

                    components.ToArray()

            | _ -> [||])

    let Components_for_Entity_with_type<'ComponentType>
        (component_type: string)
        (Entity: string)
        (transaction_context: Transaction_Context)
        =

        LMDB.Transaction.read "read components for entity" transaction_context (fun transaction database ->

            use cursor = transaction.CreateCursor(database)

            let requested_entity_bytes = Encoding.UTF8.GetBytes(Entity)

            let try_decode_matching_component (component_value: MDBValue) =
                let encoded_component = MDBValue.decode<Encoded.Component> component_value

                if encoded_component.component_type = component_type then
                    encoded_component.component_bytes
                    |> ReadOnlyMemory
                    |> Decoded.from_bytes<'ComponentType>
                    |> Some
                else
                    None

            match cursor.Set(requested_entity_bytes), cursor.GetCurrent() with
            | MDBResultCode.Success, struct (MDBResultCode.Success, actual_entity_value, first_component_value) ->

                let actual_entity = Encoding.UTF8.GetString(actual_entity_value.AsSpan())

                if actual_entity <> Entity then
                    [||]
                else
                    let components = ResizeArray<'ComponentType>()

                    match try_decode_matching_component first_component_value with
                    | Some target_component -> components.Add(target_component)
                    | None -> ()

                    let mutable keep_reading = true

                    while keep_reading do
                        match cursor.NextDuplicate() with
                        | struct (MDBResultCode.Success, _entity_value, component_value) ->
                            match try_decode_matching_component component_value with
                            | Some target_component -> components.Add(target_component)
                            | None -> ()

                        | _ -> keep_reading <- false

                    components.ToArray()

            | _ -> [||])

    let Entities_with_Component<'ComponentType> (component_type: string) (transaction_context: Transaction_Context) =

        LMDB.Transaction.read "read entities with component" transaction_context (fun _transaction database ->

            use cursor = _transaction.CreateCursor(database)

            cursor.AsEnumerable()
            |> Seq.choose (fun struct (entity_value, component_value) ->
                let Entity = Encoding.UTF8.GetString(entity_value.AsSpan())

                let encoded_component = MDBValue.decode<Encoded.Component> component_value

                if encoded_component.component_type = component_type then
                    let Component =
                        encoded_component.component_bytes
                        |> ReadOnlyMemory
                        |> Decoded.from_bytes<'ComponentType>

                    Some(
                        { Entity = Entity
                          Component = Component }
                        : Decoded.Entity'Component<'ComponentType>
                    )
                else
                    None)
            |> Seq.toArray)






module Migrate =

    let Entity (transaction_context: Transaction_Context) (old_entity: string) (new_entity: string) =

        LMDB.Transaction.write "migrate entity" transaction_context (fun transaction database ->

            use cursor = transaction.CreateCursor(database)

            let old_entity_bytes = Encoding.UTF8.GetBytes(old_entity)

            let new_entity_bytes = Encoding.UTF8.GetBytes(new_entity)

            let component_bytes = ResizeArray<byte[]>()

            match cursor.Set(old_entity_bytes), cursor.GetCurrent() with
            | MDBResultCode.Success, struct (MDBResultCode.Success, actual_entity_value, first_component_value) ->

                let actual_entity = Encoding.UTF8.GetString(actual_entity_value.AsSpan())

                if actual_entity <> old_entity then
                    failwith $"No exact entity key found for old entity: {old_entity}"

                component_bytes.Add(first_component_value.AsSpan().ToArray())

                let mutable keep_reading = true

                while keep_reading do
                    match cursor.NextDuplicate() with
                    | struct (MDBResultCode.Success, _entity_value, component_value) ->
                        component_bytes.Add(component_value.AsSpan().ToArray())

                    | _ -> keep_reading <- false

            | _ -> failwith $"No components found for old entity key: {old_entity}"

            for Component in component_bytes do
                transaction.Put(database, new_entity_bytes, Component) |> ignore

            transaction.Delete(database, old_entity_bytes) |> ignore

            component_bytes.Count)
        |> ignore


module Delete =

    let Entity (entity: string) (transaction_context: Transaction_Context) =

        LMDB.Transaction.write "delete entity" transaction_context (fun transaction database ->

            let entity_bytes = Encoding.UTF8.GetBytes(entity)

            match transaction.Delete(database, entity_bytes) with
            | MDBResultCode.Success -> 1

            | MDBResultCode.NotFound -> 0

            | result_code -> failwith $"delete entity failed with MDBResultCode: {result_code}")
        |> ignore
(*
    let Entity (entity: string) (transaction_context: Transaction_Context) =

        LMDB.Transaction.write "delete entity" transaction_context (fun transaction database ->

            let entity_bytes = Encoding.UTF8.GetBytes(entity)

            let result_code = transaction.Delete(database, entity_bytes)

            MDBResultCode.fail_if_not_success "delete entity" result_code

            1)
        |> ignore

*)
module Update =

    let Entities_with_Component<'ComponentType>
        (component_type: string)
        (transaction_context: Transaction_Context)
        (update_entity'component: Decoded.Entity'Component<'ComponentType> -> Decoded.Entity'Component<'ComponentType>)
        =

        LMDB.Transaction.write $"update entities with {component_type}" transaction_context (fun transaction database ->

            use cursor = transaction.CreateCursor(database)

            let encoded_entity'components: Encoded.Entity'Component array =
                cursor.AsEnumerable()
                |> Seq.map (fun struct (entity_value, component_value) ->

                    let entity = Encoding.UTF8.GetString(entity_value.AsSpan())

                    let encoded_component = MDBValue.decode<Encoded.Component> component_value

                    let entity'component: Encoded.Entity'Component =
                        { Entity = entity
                          Component = encoded_component }

                    entity'component)
                |> Seq.toArray

            let updated_entity'components: Encoded.Entity'Component array =
                encoded_entity'components
                |> Array.map (fun encoded_entity'component ->

                    if encoded_entity'component.Component.component_type = component_type then
                        let decoded_component =
                            encoded_entity'component.Component.component_bytes
                            |> ReadOnlyMemory
                            |> Decoded.from_bytes<'ComponentType>

                        let decoded_entity'component: Decoded.Entity'Component<'ComponentType> =
                            { Entity = encoded_entity'component.Entity
                              Component = decoded_component }

                        let updated_decoded_entity'component =
                            update_entity'component decoded_entity'component

                        let updated_encoded_component: Encoded.Component =
                            { component_type = component_type
                              component_bytes = Bytes.from_runtime updated_decoded_entity'component.Component }

                        let updated_encoded_entity'component: Encoded.Entity'Component =
                            { Entity = updated_decoded_entity'component.Entity
                              Component = updated_encoded_component }

                        updated_encoded_entity'component

                    else
                        encoded_entity'component)

            let entities_to_delete =
                encoded_entity'components
                |> Array.map (fun entity'component -> entity'component.Entity)
                |> Array.distinct

            for entity in entities_to_delete do
                let entity_bytes = Encoding.UTF8.GetBytes(entity)

                transaction.Delete(database, entity_bytes) |> ignore

            for entity'component in updated_entity'components do
                let entity_bytes = Encoding.UTF8.GetBytes(entity'component.Entity)

                let component_bytes = Bytes.from_runtime entity'component.Component

                transaction.Put(database, entity_bytes, component_bytes) |> ignore

            updated_entity'components.Length)
        |> ignore



    let Components_for_Entity<'ComponentType>
        (component_type: string)
        (entity: string)
        (transaction_context: Transaction_Context)
        (update_component: 'ComponentType -> 'ComponentType)
        =

        LMDB.Transaction.write "update components for entity" transaction_context (fun transaction database ->

            use cursor = transaction.CreateCursor(database)

            let entity_bytes = Encoding.UTF8.GetBytes(entity)

            let encoded_components = ResizeArray<Encoded.Component>()

            match cursor.Set(entity_bytes), cursor.GetCurrent() with
            | MDBResultCode.Success, struct (MDBResultCode.Success, actual_entity_value, first_component_value) ->

                let actual_entity = Encoding.UTF8.GetString(actual_entity_value.AsSpan())

                if actual_entity <> entity then
                    0
                else
                    encoded_components.Add(MDBValue.decode<Encoded.Component> first_component_value)

                    let mutable keep_reading = true

                    while keep_reading do
                        match cursor.NextDuplicate() with
                        | struct (MDBResultCode.Success, _entity_value, component_value) ->
                            encoded_components.Add(MDBValue.decode<Encoded.Component> component_value)

                        | _ -> keep_reading <- false

                    transaction.Delete(database, entity_bytes) |> ignore

                    for encoded_component in encoded_components do
                        let component_to_write =
                            if encoded_component.component_type = component_type then
                                let decoded_component =
                                    encoded_component.component_bytes
                                    |> ReadOnlyMemory
                                    |> Decoded.from_bytes<'ComponentType>

                                let updated_component = update_component decoded_component

                                { encoded_component with
                                    component_bytes = Bytes.from_runtime updated_component }
                            else
                                encoded_component

                        let component_bytes = Bytes.from_runtime component_to_write

                        transaction.Put(database, entity_bytes, component_bytes) |> ignore

                    encoded_components.Count

            | _ -> 0)
        |> ignore
