open System
open System.Xml
open System.Text
open System.Diagnostics
open System.Globalization
open System.IO

#r "nuget: LightningDB"
open LightningDB

#r "nuget: MessagePack"
#r "nuget: MessagePack.FSharpExtensions"

open MessagePack
open MessagePack.Resolvers
open MessagePack.FSharp

#r "nuget: Blake3"
open Blake3

let message_pack_options =
    MessagePackSerializerOptions.Standard.WithResolver(
        CompositeResolver.Create(FSharpResolver.Instance, StandardResolver.Instance)
    )





let GiB = 1024L * 1024L * 1024L
let map_size = int64 2 * GiB
let environment_directory_path = @"D:\Persistence\LMDB"

System.IO.Directory.CreateDirectory(environment_directory_path)
|> ignore

let mutable batch_size = 250_000


let environment = new LightningEnvironment(environment_directory_path)
environment.MapSize <- map_size
environment.MaxDatabases <- 4


environment.Open()

module MDBResultCode =

    let succeeded (result_code: MDBResultCode) = result_code = MDBResultCode.Success

    let failed (result_code: MDBResultCode) = result_code <> MDBResultCode.Success

    let fail_if_not_success (operation_name: string) (result_code: MDBResultCode) =
        if result_code <> MDBResultCode.Success then
            failwith $"{operation_name} failed with MDBResultCode: {result_code}"

type ID = private ID of uint64



type Entity = private Entity of byte array

type Component = private Component of byte array
//    private
//    | StringComponent of byte array
//    | IntComponent of byte array


module Bytes =
    let from_string (string_value: string) = Encoding.UTF8.GetBytes(string_value)
    let to_string (bytes: byte array) = Encoding.UTF8.GetString(bytes)
    let from_int (int_value: int) = BitConverter.GetBytes(int_value)
    let to_int (bytes: byte array) = BitConverter.ToInt32(bytes, 0)
    let from_entity (Entity bytes) = bytes
    let from_component (Component bytes) = bytes
    let from_id (ID bytes) = bytes



[<MessagePackObject>]
type Attribute_Value =
    { [<Key(0)>]
      Attribute_ID: int
      [<Key(1)>]
      Value_ID: int }

module Entity =
    let from_raw_bytes (raw_bytes: byte array) =
        Blake3.Hasher.Hash(raw_bytes).AsSpan().ToArray()
        |> Entity

    let from_trusted_bytes (bytes: byte array) = Entity bytes

    let from_string (raw_entity: string) =
        Bytes.from_string raw_entity |> from_raw_bytes

    let bytes (Entity bytes) = bytes


module Component =
    let from_string (value: string) =
        Encoding.UTF8.GetBytes(value) |> Component

    let from_int (value: int) =
        BitConverter.GetBytes(value) |> Component

    let from_bytes (bytes: byte array) = bytes |> Component


    let to_string (Component bytes) = Encoding.UTF8.GetString(bytes)
    let to_int (Component bytes) = BitConverter.ToInt32(bytes, 0)
(*
module Component =

    let from_string (string_value: string) = string_value |> Bytes.from_string
    let to_string (bytes: byte array) = Encoding.UTF8.GetString(bytes)



*)




type Memory_Map =
    {

      name: string
      handle: LightningDatabase

     }


module Memory_Map =
    let from_name_flags (name: string) (flags: DatabaseOpenFlags) =
        use transaction = environment.BeginTransaction()

        let handle =
            transaction.OpenDatabase(
                name,
                DatabaseConfiguration(
                    Flags = flags

                )
            )

        transaction.Commit() |> ignore
        { name = name; handle = handle }

module ID =

    let from_uint64 (value: uint64) = ID value

    let value (ID value) = value

    let to_bytes (ID value) =
        let bytes = BitConverter.GetBytes(value)

        if BitConverter.IsLittleEndian then
            Array.Reverse(bytes)

        bytes

    let from_bytes (bytes: byte array) =
        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0) |> ID

module Database_ID =

    let next_by_memory_map (memory_map: Memory_Map) (transaction: LightningTransaction) =
        use cursor = transaction.CreateCursor(memory_map.handle)

        match cursor.Last() with
        | struct (MDBResultCode.Success, id_key, _component_value) ->
            id_key.AsSpan().ToArray()
            |> ID.from_bytes
            |> ID.value
            |> fun value -> value + 1UL
            |> ID.from_uint64

        | _ -> ID.from_uint64 0UL

type Entity'Component =
    { Entity: Entity
      Component: Component }


module Code_Line =

    let Entity_to_ID =
        Memory_Map.from_name_flags "Code_Line_Entity_to_Code_Line_ID" DatabaseOpenFlags.Create

    let ID_to_Component =
        Memory_Map.from_name_flags "Code_Line_ID_to_Code_Line_Component" DatabaseOpenFlags.Create

    let from_entity'component (entity'component: Entity'Component) =
        entity'component.Component |> Component.to_string






module Database =

    module Put =

        let Entity'Component (entity'component: Entity'Component) =
            use transaction = environment.BeginTransaction()

            let entity_bytes = Entity.bytes entity'component.Entity

            match transaction.Get(Code_Line.Entity_to_ID.handle, entity_bytes) with
            | struct (MDBResultCode.Success, _key, id_value) -> id_value.AsSpan().ToArray() |> ID.from_bytes

            | struct (MDBResultCode.NotFound, _, _) ->

                let id = Database_ID.next_by_memory_map Code_Line.ID_to_Component transaction

                let id_bytes: byte array = ID.to_bytes id

                transaction.Put(
                    Code_Line.ID_to_Component.handle,
                    id_bytes,
                    Bytes.from_component entity'component.Component
                )
                |> MDBResultCode.fail_if_not_success "Put code line ID -> component"

                transaction.Put(Code_Line.Entity_to_ID.handle, entity_bytes, id_bytes)
                |> MDBResultCode.fail_if_not_success "Put code line entity -> ID"

                transaction.Commit() |> ignore

                id

            | struct (result_code, _, _) ->
                failwith $"Get code line entity -> ID failed with MDBResultCode: {result_code}"

    module Get =

        let ID_by_Entity (entity: Entity) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            match transaction.Get(Code_Line.Entity_to_ID.handle, Entity.bytes entity) with
            | struct (MDBResultCode.Success, _key, id_value) -> id_value.AsSpan().ToArray() |> ID.from_bytes

            | struct (MDBResultCode.NotFound, _, _) -> failwith "Code line entity not found."

            | struct (result_code, _, _) ->
                failwith $"Get code line entity -> ID failed with MDBResultCode: {result_code}"


        let Component_by_ID (id: ID) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            match transaction.Get(Code_Line.ID_to_Component.handle, ID.to_bytes id) with
            | struct (MDBResultCode.Success, _key, component_value) ->
                component_value.AsSpan().ToArray()
                |> Component.from_bytes

            | struct (MDBResultCode.NotFound, _, _) -> failwith "Code line ID not found."

            | struct (result_code, _, _) ->
                failwith $"Get code line ID -> component failed with MDBResultCode: {result_code}"


        let Component_by_Entity (entity: Entity) =
            let id = ID_by_Entity entity

            Component_by_ID id

        let Entities_by_Memory_Map (memory_map: Memory_Map) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)
            use cursor = transaction.CreateCursor(memory_map.handle)

            cursor.AsEnumerable()
            |> Seq.map (fun struct (mdb_key, mdb_value) ->
                { Entity =
                    mdb_key.AsSpan().ToArray()
                    |> Entity.from_trusted_bytes
                  Component =
                    mdb_value.AsSpan().ToArray()
                    |> Component.from_bytes }

            )
            |> Seq.toArray


        let Components_by_Entity (memory_map: Memory_Map) (entity: Entity) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            match transaction.Get(memory_map.handle, Entity.bytes entity) with
            | struct (MDBResultCode.Success, _key, value) -> value.AsSpan().ToArray() |> Component.from_bytes

            | struct (MDBResultCode.NotFound, _, _) -> failwith "Entity not found."

            | struct (result_code, _, _) -> failwith $"Get entity failed with MDBResultCode: {result_code}"



let test_Component = Component.from_string "this"

let test_Entity = Entity.from_raw_bytes (Bytes.from_component test_Component)

let test_ID =
    Database.Put.Entity'Component
        { Entity = test_Entity
          Component = test_Component }

let test_read =
    Database.Get.Component_by_Entity test_Entity
    |> Component.to_string
