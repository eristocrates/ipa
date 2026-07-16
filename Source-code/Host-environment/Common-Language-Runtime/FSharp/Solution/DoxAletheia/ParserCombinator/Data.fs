module DoxAletheia.ParserCombinator.Data

open System
open System.IO
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Numerics
open System.Threading.Tasks
open System.Diagnostics
open LightningDB
open Blake3
open BitFaster.Caching
open BitFaster.Caching.Lfu
open FSharp.Configuration


open XParsec
open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open ByteExtensions
open Interval_Range

let lmdb_directory_path = @"D:\Persistence\LMDB\DoxAletheia"



let blake3_hash (string_input:string) = 
    string_input
    |> Encoding.UTF8.GetBytes
    |> Blake3.Hasher.Hash


type String_Index =
    private
    | StringIndex of uint64
    member this.unwrap  =
        match this with 
        | StringIndex value -> value

    member this.as_bytes  =
        BitConverter.GetBytes this.unwrap
    static member wrap_bytes (bytes:byte array) = bytes |> BitConverter.ToUInt64 |> StringIndex
    static member wrap_mdb(mdb_string_index:MDBValue)  = String_Index.wrap_bytes mdb_string_index.as_bytes 
    static member some_mdb(mdb_string_index:MDBValue)  = Some (String_Index.wrap_mdb mdb_string_index)









let batch_size = 250_000
let cache_capacity = 250









let GiB = 1024L * 1024L * 1024L
let bytes_to_gib (bytes: int64) = float bytes / 1024.0 / 1024.0 / 1024.0
// TODO figure out how to let this be configurable without recompiling
let map_size = 5

Directory.CreateDirectory(lmdb_directory_path)
|> ignore


let environment = new LightningEnvironment(lmdb_directory_path)


environment.MapSize <- map_size
environment.MaxDatabases <- 30


environment.Open()

let print_stats () =


    let info = environment.Info
    let stat = environment.EnvironmentStats

    let page_size = int64 stat.PageSize

    let used_bytes = (int64 info.LastPageNumber + 1L) * page_size

    let map_size = info.MapSize

    let remaining_bytes = map_size - used_bytes

    let used_percent = (float used_bytes / float map_size) * 100.0

    printfn ""
    printfn "LMDB Environment"
    printfn "----------------"
    printfn "Page Size:        %i bytes" page_size
    printfn "Last Page Number: %i" info.LastPageNumber
    printfn "Map Size:         %.2f GiB" (bytes_to_gib map_size)
    printfn "Used:             %.2f GiB" (bytes_to_gib used_bytes)
    printfn "Remaining:        %.2f GiB" (bytes_to_gib remaining_bytes)
    printfn "Usage:            %.2f%%" used_percent
    printfn ""



module Transaction = 
    let read() = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)
    let write() = environment.BeginTransaction()
    let commit (transaction:LightningTransaction) = transaction.Commit() |> ignore



type Memory_Map<'InputType,'OutputType> = 
    {
        name:string
        database:LightningDatabase
        cache:ICache<'InputType, 'OutputType>
        flags:DatabaseOpenFlags
    }
    static member from_name_flags (name:string)(flags:DatabaseOpenFlags) =
        use transaction = environment.BeginTransaction()
        

        let database =
            transaction.OpenDatabase(
                name,
                DatabaseConfiguration(
                    Flags = flags

                )
            )

        transaction.Commit() |> ignore
        {

            name = name 
            database = database
            flags = flags
            cache = 
                    ConcurrentLfuBuilder<'InputType,'OutputType>()
                        .WithAtomicGetOrAdd()
                        .WithCapacity(cache_capacity)
                        .Build()

        }
    member this.Get
        (key_as_bytes: byte array)
        (some_continuation: MDBValue -> 'OutputType option)
        : 'OutputType option =

        use transaction =
            Transaction.read()

        match transaction.Get(this.database, key_as_bytes) with
        | struct (MDBResultCode.Success, _, mdb_value) ->
            some_continuation mdb_value

        | struct (MDBResultCode.NotFound, _, _) ->
            None

        | struct (result_code, _, _) ->
            failwithf
                "%s.Get failed with MDBResultCode: %A"
                this.name
                result_code
    member this.MDBContinuation (transaction: LightningTransaction)(mdb_result:MDBResultCode)   =
                    if mdb_result <> MDBResultCode.Success then
                        failwithf "%s.Put failed: %A" this.name mdb_result
                    else
                        transaction
    member this.MDBCommit (transaction: LightningTransaction) (mdb_result:MDBResultCode)   = 
    
                    if mdb_result <> MDBResultCode.Success then
                        failwithf "%s.Put failed: %A" this.name mdb_result
                    else
                        transaction.Commit() |> ignore

    member this.Put (key_as_bytes:byte array)(value_as_bytes:byte array) (transaction: LightningTransaction) = transaction.Put(this.database, key_as_bytes,value_as_bytes) |> this.MDBContinuation transaction
    member this.Delete (key_as_bytes:byte array) (transaction: LightningTransaction) = transaction.Delete(this.database, key_as_bytes)
module Memory_Map = 
    let string_index_to_string:Memory_Map<String_Index,string> =                 
                    Memory_Map.from_name_flags
                        "String_Index_to_String"
                        (
                            DatabaseOpenFlags.Create
                            ||| DatabaseOpenFlags.IntegerKey
                        )

    let string_hash_to_string_index:Memory_Map<Hash,String_Index> =  Memory_Map.from_name_flags "String_Hash_to_String_Index" DatabaseOpenFlags.Create


type Inbox<'MessageType> = MailboxProcessor<'MessageType>


    
type String_Array_Message =
    | EnsureStringIndex of Blake3.Hash * string * AsyncReplyChannel<String_Index>
        
let rec watch_inbox(inbox:Inbox<'MessageType>) = 
    async{

        let! message = inbox.Receive()

        printfn "\nmessage is: %A\n" message

        return! watch_inbox inbox
        }
    

    
type Data_Store
    (
        string_index_to_string:
            Memory_Map<String_Index, string>,

        string_hash_to_string_index:
            Memory_Map<Hash, String_Index>
    ) =

    let load_string_array () =

        let string_array =
            ResizeArray<string>()

        use transaction =
            Transaction.read()

        use cursor =
            transaction.CreateCursor(
                string_index_to_string.database
            )

        let mutable cursor_result =
            cursor.First()

        let mutable continue_loading =
            true

        while continue_loading do

            match cursor_result with
            | struct (
                MDBResultCode.Success,
                mdb_string_index,
                mdb_string
              ) ->

                let persisted_string_index =
                    String_Index.wrap_mdb mdb_string_index

                let expected_string_index =
                    uint64 string_array.Count

                if
                    persisted_string_index.unwrap
                    <> expected_string_index
                then
                    failwithf
                        "Expected String_Index %i, but LMDB contained String_Index %i."
                        expected_string_index
                        persisted_string_index.unwrap

                let string_value =
                    mdb_string.as_bytes
                    |> Encoding.UTF8.GetString

                string_array.Add string_value

                cursor_result <-
                    cursor.Next()

            | struct (MDBResultCode.NotFound, _, _) ->
                continue_loading <- false

            | struct (result_code, _, _) ->
                failwithf
                    "Initial String_Index_to_String load failed with MDBResultCode: %A"
                    result_code

        string_array


    // Evaluated exactly once while this Data_Store is constructed.
    let string_array =
        load_string_array()


    // Also created exactly once.
    let string_agent =
        MailboxProcessor.Start(fun inbox ->

            let rec loop () =
                async {
                    let! message =
                        inbox.Receive()

                    match message with
                    | EnsureStringIndex(
                        string_hash,
                        string_value,
                        reply
                      ) ->

                        let string_index =
                            uint64 string_array.Count
                            |> StringIndex

                        use transaction =
                            Transaction.write()

                        transaction
                        |> string_hash_to_string_index.Put
                            string_hash.as_bytes
                            string_index.as_bytes
                        |> string_index_to_string.Put
                            string_index.as_bytes
                            string_value.as_bytes
                        |> Transaction.commit

                        string_array.Add string_value

                        reply.Reply string_index

                    return! loop ()
                }

            loop ()
        )


    member _.maybe_string_index_for_hash
        (string_hash: Hash)
        : String_Index option =

        String_Index.some_mdb
        |> string_hash_to_string_index.Get string_hash.as_bytes
            


    member _.get_string_for_string_index
        (string_index: String_Index)
        : string =

        string_index_to_string.Get
            string_index.as_bytes
            (fun mdb_string ->
                mdb_string.as_bytes
                |> Encoding.UTF8.GetString
                |> Some
            )
        |> Option.get


    member this.ensure_string_index_for_string
        (string_value: string)
        : String_Index =

        let string_hash =
            blake3_hash string_value

        string_hash_to_string_index.cache.GetOrAdd(
            string_hash,
            Func<Hash, String_Index>(fun hash ->

                match this.maybe_string_index_for_hash hash with
                | Some extant_index ->
                    extant_index

                | None ->
                    string_agent.PostAndReply(fun reply ->
                        EnsureStringIndex(
                            hash,
                            string_value,
                            reply
                        )
                    )
            )
        )


    member this.intern_string
        (string_value: string)
        : unit =

        this.ensure_string_index_for_string string_value
        |> ignore





let data_store = Data_Store(
    Memory_Map.string_index_to_string,Memory_Map.string_hash_to_string_index
)

data_store.intern_string(String.Empty)   

