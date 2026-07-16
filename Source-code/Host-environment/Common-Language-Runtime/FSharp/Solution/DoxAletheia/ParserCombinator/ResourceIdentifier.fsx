#time on

open System
open System.IO
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Threading.Tasks
open System.Diagnostics
open Microsoft.FSharp.Collections
#r "nuget: UUIDNext"
open UUIDNext
#r "nuget: XParsec"
open XParsec
#r "nuget: BitFaster.Caching"
open BitFaster.Caching
#r "nuget: LightningDB"
open LightningDB
#r "nuget: Blake3"
open Blake3
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0"
#r "Ergonomic_Extensions.dll"
#r "Unicodepoint.dll"
#r "Interval_Range.dll"
#r "NeatIntervals.dll"
#r "FRange.dll"
open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open ByteExtensions
open Interval_Range
open BitFaster.Caching.Lfu






let url_uuid_namespace = new Guid("6ba7b811-9dad-11d1-80b4-00c04fd430c8")
let url_uuid local_name =
    Uuid.NewNameBased(url_uuid_namespace, local_name)

(*




let legisign_uuid_namespace =
    Uuid.NewNameBased(url_uuid_namespace, "https://eristocrates.dev/ontology/legisign/")

let legisign_uuid_v5 legisign =
    Uuid.NewNameBased(legisign_uuid_namespace, legisign)

*)









type Hash with 
    member this.as_bytes = this.AsSpan().ToArray()

type String with 
    member this.as_bytes = Encoding.UTF8.GetBytes this
type MDBValue with 
    member this.as_bytes = this.AsSpan().ToArray() 




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





let lmdb_directory_path = @"D:\Persistence\LMDB\DoxAletheia"

let GiB = 1024L * 1024L * 1024L
let bytes_to_gib (bytes: int64) = float bytes / 1024.0 / 1024.0 / 1024.0
let map_size = int64 4 * GiB

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



































module Code_Point_Rule =


    // TODO deal with octet map, since this has more than 255 values
    let ucschar =
        {

          code_points =

              Array.concat [| 0xA0 +-+ 0xD7FF |> Interval_Range.as_array
                              0xF900 +-+ 0xFDCF |> Interval_Range.as_array
                              0xFDF0 +-+ 0xFFEF |> Interval_Range.as_array
                              0x10000 +-+ 0x1FFFD |> Interval_Range.as_array
                              0x20000 +-+ 0x2FFFD |> Interval_Range.as_array
                              0x30000 +-+ 0x3FFFD |> Interval_Range.as_array
                              0x40000 +-+ 0x4FFFD |> Interval_Range.as_array
                              0x50000 +-+ 0x5FFFD |> Interval_Range.as_array
                              0x60000 +-+ 0x6FFFD |> Interval_Range.as_array
                              0x70000 +-+ 0x7FFFD |> Interval_Range.as_array
                              0x80000 +-+ 0x8FFFD |> Interval_Range.as_array
                              0x90000 +-+ 0x9FFFD |> Interval_Range.as_array
                              0xA0000 +-+ 0xAFFFD |> Interval_Range.as_array
                              0xB0000 +-+ 0xBFFFD |> Interval_Range.as_array
                              0xC0000 +-+ 0xCFFFD |> Interval_Range.as_array
                              0xD0000 +-+ 0xDFFFD |> Interval_Range.as_array
                              0xE1000 +-+ 0xEFFFD |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                      ucschar        = %xA0-D7FF / %xF900-FDCF / %xFDF0-FFEF
                                                      / %x10000-1FFFD / %x20000-2FFFD / %x30000-3FFFD
                                                      / %x40000-4FFFD / %x50000-5FFFD / %x60000-6FFFD
                                                      / %x70000-7FFFD / %x80000-8FFFD / %x90000-9FFFD
                                                      / %xA0000-AFFFD / %xB0000-BFFFD / %xC0000-CFFFD
                                                      / %xD0000-DFFFD / %xE1000-EFFFD

                                  """

        }

    let pn_chars_base =
        {

          code_points =

              Array.concat [|

                              Unicodepoint.Partition.Latin_Majuscule
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.Latin_Minuscule
                              |> Interval_Range.as_array
                              0x00C0 +-+ 0x00D6 |> Interval_Range.as_array
                              0x00D8 +-+ 0x00F6 |> Interval_Range.as_array
                              0x00F8 +-+ 0x02FF |> Interval_Range.as_array
                              0x0370 +-+ 0x037D |> Interval_Range.as_array
                              0x037F +-+ 0x1FFF |> Interval_Range.as_array
                              0x200C +-+ 0x200D |> Interval_Range.as_array
                              0x2070 +-+ 0x218F |> Interval_Range.as_array
                              0x2C00 +-+ 0x2FEF |> Interval_Range.as_array
                              0x3001 +-+ 0xD7FF |> Interval_Range.as_array
                              0xF900 +-+ 0xFDCF |> Interval_Range.as_array
                              0xFDF0 +-+ 0xFFFD |> Interval_Range.as_array
                              0x10000 +-+ 0xEFFFF |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                  
                                    PN_CHARS_BASE     ::= ([A-Z]
                                                        | [a-z]
                                                        | [#x00C0-#x00D6]
                                                        | [#x00D8-#x00F6]
                                                        | [#x00F8-#x02FF]
                                                        | [#x0370-#x037D]
                                                        | [#x037F-#x1FFF]
                                                        | [#x200C-#x200D]
                                                        | [#x2070-#x218F]
                                                        | [#x2C00-#x2FEF]
                                                        | [#x3001-#xD7FF]
                                                        | [#xF900-#xFDCF]
                                                        | [#xFDF0-#xFFFD]
                                                        | [#x10000-#xEFFFF])
                                    
                                  """

        }

    let pn_chars_u =
        {

          code_points =

              Array.concat [|

                              pn_chars_base.code_points
                              [| int '_' |]

                               |]
              |> Array.sort

          metasyntax =

              """
                                  
                                        PN_CHARS_U        ::=  PN_CHARS_BASE | '_'                                        
                                  """

        }

    let pn_chars =
        {

          code_points =

              Array.concat [|

                              pn_chars_u.code_points
                              [| int '-' |]
                              Unicodepoint.Partition.Ascii_Digits
                              |> Interval_Range.as_array
                              [| 0x00B7 |]
                              0x0300 +-+ 0x036F |> Interval_Range.as_array
                              0x203F +-+ 0x2040 |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                  
                                        PN_CHARS_U        ::=  PN_CHARS_BASE | '_'                                        
                                  """

        }


    let sub_delims =

        {

          code_points =
              Code_Line.from_chars_sorted [| '!'
                                             '$'
                                             '&'
                                             '''
                                             '('
                                             ')'
                                             '*'
                                             '+'
                                             ','
                                             ';'
                                             '=' |]

          metasyntax =

              """
                                  sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "="
                                  """

        }


    let gen_delims =

        {

          code_points =
              Code_Line.from_chars_sorted [|

                                             ':'
                                             '/'
                                             '?'
                                             '#'
                                             '['
                                             ']'
                                             '@'


                                              |]

          metasyntax =

              """
                                  gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
                                  """

        }


    let reserved =
        {

          code_points =

              Array.concat [|

                              gen_delims.code_points
                              sub_delims.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                                  reserved      = gen-delims / sub-delims
                                  """

        }




    let unreserved =
        {

          code_points =

              Array.concat [|

                              Unicodepoint.Partition.Latin_Majuscule
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.Latin_Minuscule
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.Ascii_Digits
                              |> Interval_Range.as_array
                              (Code_Line.from_chars [| '-'
                                                       '.'
                                                       '_'
                                                       '~' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
                                  """

        }

    let iunreserved =
        {

          code_points =

              Array.concat [|

                              unreserved.code_points
                              ucschar.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                              iunreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" / ucschar
                              """

        }


    let hexdigit =
        {

          code_points =

              Array.concat [|

                              Unicodepoint.Partition.Ascii_Digits
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.A_to_F
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.a_to_f
                              |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                      HEXDIG = DIGIT / "A" / "B" / "C" / "D" / "E" / "F"
                                      overridden to case insensitive
                                      """

        }



    let userinfo =

        {

          code_points =

              Array.concat [|

                              unreserved.code_points
                              sub_delims.code_points
                              [| int ':' |]

                               |]
              |> Array.sort

          metasyntax =

              """
                                        unreserved / pct-encoded / sub-delims / ":"  
                                      """

        }

    let iuserinfo =

        {

          code_points =

              Array.concat [|

                              iunreserved.code_points
                              sub_delims.code_points
                              [| int ':' |]

                               |]
              |> Array.sort

          metasyntax =

              """
                                     iunreserved / pct-encoded / sub-delims / ":"   
                                  """

        }


    let reg_name =
        {

          code_points =

              Array.concat [|

                              unreserved.code_points
                              sub_delims.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                                   unreserved / pct-encoded / sub-delims 
                                  """

        }

    let ireg_name =
        {

          code_points =

              Array.concat [|

                              iunreserved.code_points
                              sub_delims.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                                   iunreserved / pct-encoded / sub-delims 
                                  """

        }

    let pchar_unencoded_noncolon =
        {

          code_points =

              Array.concat [|

                              reg_name.code_points
                              (Code_Line.from_chars [| '@' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  ( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                                  """

        }

    let ipchar_unencoded_noncolon =
        {

          code_points =

              Array.concat [|

                              ireg_name.code_points
                              (Code_Line.from_chars [| '@' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  ( iunreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                                  """

        }

    let pchar_unencoded =
        {

          code_points =

              Array.concat [|

                              pchar_unencoded_noncolon.code_points
                              (Code_Line.from_chars [| ':' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }

    let ipchar_unencoded =
        {

          code_points =

              Array.concat [|

                              ipchar_unencoded_noncolon.code_points
                              (Code_Line.from_chars [| ':' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }


    let iprivate =
        {

          code_points =

              Array.concat [| 0xE000 +-+ 0xF8FF |> Interval_Range.as_array
                              0xF0000 +-+ 0xFFFFD |> Interval_Range.as_array
                              0x100000 +-+ 0x10FFFD |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                   iprivate       = %xE000-F8FF / %xF0000-FFFFD / %x100000-10FFFD 
                                  """

        }


















module Code_Line_Rule =
    open Code_Point_Rule

    let pct_encoded =
        {

          code_line_parser =
              parser {
                  let! sigil = parse_char '%'
                  let! left_digit = hexdigit.code_point_parser
                  let! right_digit = hexdigit.code_point_parser


                  return [| sigil; left_digit; right_digit |]


              }

          metasyntax =

              """
                                  pct-encoded    = "%" HEXDIG HEXDIG
                                  """

        }

    let pchar_encoded =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ pchar_unencoded.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }

    let ipchar_encoded =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ ipchar_unencoded.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }

    let pchar_encoded_noncolon =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ pchar_unencoded_noncolon.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  pchar         = unreserved / pct-encoded / sub-delims / "@"
                                  """

        }

    let ipchar_encoded_noncolon =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ ipchar_unencoded_noncolon.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  ipchar         = iunreserved / pct-encoded / sub-delims / "@"
                                  """

        }


    let query_fragment =
        {

          code_line_parser =
              parser {

                  let! immutable_code_square =

                      many (
                          choice [

                                   pchar_encoded.code_line_parser
                                   parse_char '/'
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '?'
                                   |>> (fun code_point -> [| code_point |])




                                    ]
                      )

                  return Code_Line.from_immutable_code_square immutable_code_square


              }

          metasyntax =

              """
                                  fragment      = *( pchar / "/" / "?" )
                                  """

        }

    let ifragment =
        {

          code_line_parser =
              parser {

                  let! immutable_code_square =

                      many (
                          choice [

                                   ipchar_encoded.code_line_parser
                                   parse_char '/'
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '?'
                                   |>> (fun code_point -> [| code_point |])



                                    ]
                      )

                  return Code_Line.from_immutable_code_square immutable_code_square


              }

          metasyntax =

              """
                                  ifragment      = *( ipchar / "/" / "?" )
                                  """

        }

    let iquery =
        {

          code_line_parser =
              parser {

                  let! immutable_code_square =

                      many (
                          choice [

                                   ipchar_encoded.code_line_parser
                                   iprivate.code_point_parser
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '/'
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '?'
                                   |>> (fun code_point -> [| code_point |])



                                    ]
                      )

                  return Code_Line.from_immutable_code_square immutable_code_square


              }

          metasyntax =

              """
                                  ifragment      = *( ipchar / "/" / "?" )
                                  """

        }





module Rfc_Types =
    open Code_Point_Rule
    open Code_Line_Rule


















    type Octet =
        private
        | Octet of String_Index
        static let interval_0_4 = 0 +-+ 4
        static let interval_0_5 = 0 +-+ 5
        static let interval_1_9 = 1 +-+ 9

        static member parser: Parser<Octet, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! digits =
                    choice [

                             tuple3 (parse_char '2') (parse_char '5') (any_point_from_interval interval_0_5)
                             |>> (fun struct (left_digit, center_digit, right_digit) ->
                                 [| left_digit
                                    center_digit
                                    right_digit |])
                             tuple3
                                 (parse_char '2')
                                 (any_point_from_interval interval_0_4)
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                             |>> (fun struct (left_digit, center_digit, right_digit) ->
                                 [| left_digit
                                    center_digit
                                    right_digit |])
                             tuple3
                                 (parse_char '1')
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                             |>> (fun struct (left_digit, center_digit, right_digit) ->
                                 [| left_digit
                                    center_digit
                                    right_digit |])
                             tuple2
                                 (any_point_from_interval interval_1_9)
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                             |>> (fun struct (left_digit, right_digit) -> [| left_digit; right_digit |])
                             any_point_from_interval Unicodepoint.Partition.Ascii_Digits
                             |>> (fun digit -> [| digit |])

                              ]
                
                return digits |> String.from_code_line |> data_store.ensure_string_index_for_string |> Octet 

            }

        static member metasyntax =
            """
                                        dec-octet     = DIGIT                 ; 0-9
                                                     / %x31-39 DIGIT         ; 10-99
                                                     / "1" 2DIGIT            ; 100-199
                                                     / "2" %x30-34 DIGIT     ; 200-249
                                                     / "25" %x30-35          ; 250-255

                                      """

        static member parse(input_string: string) =
            match Octet.parser input_string.as_parser_input with
            | Ok success ->
                success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line Octet.metasyntax)

        member this.string_index =
            match this with
            | Octet string_index -> string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line

        static member code_line(octet: Octet) = octet.as_code_line
        member this.as_int = int this.as_raw_string


        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%d``" this unames this.as_int




    type IPv4_Address =
        private
        | IPv4 of String_Index * Octet * Octet * Octet * Octet

        static member parser: Parser<IPv4_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! outer_left = Octet.parser
                do! skip_char '.'
                let! inner_left = Octet.parser
                do! skip_char '.'
                let! inner_right = Octet.parser
                do! skip_char '.'
                let! outer_right = Octet.parser
                let ipv4_string = sprintf "%d.%d.%d.%d" outer_left.as_int inner_left.as_int inner_right.as_int outer_right.as_int
                return IPv4(data_store.ensure_string_index_for_string ipv4_string, outer_left, inner_left, inner_right, outer_right)

            }

        static member metasyntax =
            """
                                        IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
                                      """

        static member parse(input_string: string) =
            match IPv4_Address.parser input_string.as_parser_input with
            | Ok success -> 
                  data_store.intern_string input_string
                  success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IPv4_Address.metasyntax)

        member this.as_raw_octets =
            match this with
            | IPv4 (_, outer_left, inner_left, inner_right, outer_right) ->
                [| outer_left
                   inner_left
                   inner_right
                   outer_right |]

        member this.as_code_square: Code_Square =
            this.as_raw_octets |> Array.map Octet.code_line

        member this.outer_left_octet:Octet = this.as_raw_octets[0]
        member this.inner_left_octet:Octet = this.as_raw_octets[1]
        member this.inner_right_octet:Octet = this.as_raw_octets[2]
        member this.outer_right_octet:Octet = this.as_raw_octets[3]

        member this.string_index =
            match this with
            | IPv4 (string_index,_,_,_,_) -> string_index

        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%s``" this unames this.as_rendered_string





    type Hextet =
        private
        | Hextet of String_Index
        static member parser: Parser<Hextet, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! immutable_code_line =

                    choice [

                             parray 4 (hexdigit.code_point_parser)
                             parray 3 (hexdigit.code_point_parser)
                             parray 2 (hexdigit.code_point_parser)
                             parray 1 (hexdigit.code_point_parser)

                              ]


                return 
                    Code_Line.from_immutable_code_line immutable_code_line
                    |> String.from_code_line
                    |> data_store.ensure_string_index_for_string
                    |> Hextet


            }

        static member colon_suffixed_parser: Parser<Hextet, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! h16 = Hextet.parser
                do! skip_char ':'

                return h16


            }

        static member metasyntax =

            """
                                      h16           = 1*4HEXDIG
                                      """

        static member parse(input_string: string) =
            match Hextet.parser input_string.as_parser_input with
            | Ok success ->
                data_store.intern_string success.as_raw_string 

                success

            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Hextet.metasyntax)

        member this.string_index =
            match this with
            | Hextet string_index -> string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line



        static member raw_string(hextet: Hextet) = hextet.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string





    type Least_Significant_32_Bits =
        | LeastSignificantHextets of Hextet * Hextet
        | LeastSignificantIPv4 of IPv4_Address


        static member parser: Parser<Least_Significant_32_Bits, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! ls32 =

                    choice [

                             Hextet.parser .>> skip_char ':' .>>. Hextet.parser
                             |>> (fun struct (left_hextet, right_hextet) ->
                                 LeastSignificantHextets(left_hextet, right_hextet))
                             IPv4_Address.parser |>> LeastSignificantIPv4

                              ]


                return ls32


            }

        static member metasyntax =
            """
                                        ls32          = ( h16 ":" h16 ) / IPv4address
                                        """

        static member parse(input_string: string) =
            match Least_Significant_32_Bits.parser input_string.as_parser_input with
            | Ok success -> 
              success.as_raw_strings |> Array.iter data_store.intern_string  

              success
            | Error failure ->
                failwithf
                    "%A: %s"
                    failure
                    (code_line_message input_string.as_code_line Least_Significant_32_Bits.metasyntax)

        member this.as_code_square:Code_Square =
            match this with
            | LeastSignificantHextets (left_hextet, right_hextet) -> [| left_hextet.as_code_line; right_hextet.as_code_line |]
            | LeastSignificantIPv4 (IPv4 (_, outer_left, inner_left, inner_right, outer_right)) ->
                [| outer_left.as_code_line
                   inner_left.as_code_line
                   inner_right.as_code_line
                   outer_right.as_code_line |]
        member this.as_raw_strings = Strings.from_code_square this.as_code_square

        member this.as_rendered_string =
            match this with
            | LeastSignificantHextets (left_h16, right_h16) ->
                sprintf "%s:%s" left_h16.as_raw_string right_h16.as_raw_string
            | LeastSignificantIPv4 ipv4_address -> ipv4_address.as_rendered_string

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings


    type IPv6_Address =
        private
        | Six_h16__ls32 of String_Index * Hextet array * Least_Significant_32_Bits
        | Five_h16__ls32 of String_Index * Hextet array * Least_Significant_32_Bits
        | Maybe_One_h16__Four_h16__ls32 of String_Index * Hextet voption * Hextet array * Least_Significant_32_Bits
        | Maybe_Two_h16__Three_h16__ls32 of String_Index * Hextet array voption * Hextet array * Least_Significant_32_Bits
        | Maybe_Three_h16__Two_h16__ls32 of String_Index * Hextet array voption * Hextet array * Least_Significant_32_Bits
        | Maybe_Four_h16__One_h16__ls32 of String_Index * Hextet array voption * Hextet * Least_Significant_32_Bits
        | Maybe_Five_h16__ls32 of String_Index * Hextet array voption * Least_Significant_32_Bits
        | Maybe_Six_h16__h16 of String_Index * Hextet array voption * Hextet
        | Maybe_Seven_h16 of String_Index * Hextet array voption



        ///  =                            6( h16 ":" ) ls32
        static member Six_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! hextets =
                    parray 6 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())

                let! ls32 = Least_Significant_32_Bits.parser
                let hextet_string = 
                    hextets
                    |> Array.map (fun hextet -> hextet.as_raw_string)
                    |> String.concat ":"
                let ipv6_string = sprintf "%s:%s" hextet_string ls32.as_rendered_string
                return Six_h16__ls32(data_store.ensure_string_index_for_string ipv6_string, hextets, ls32)

            }

        ///                       "::" 5( h16 ":" ) ls32
        static member Five_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                do! skip_string "::"

                let! hextets =
                    parray 5 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())

                let! ls32 = Least_Significant_32_Bits.parser
                let hextet_string = 
                    "::" + (hextets
                    |> Array.map (fun hextet -> hextet.as_raw_string)
                    |> String.concat ":")
                let ipv6_string = sprintf "%s:%s" hextet_string ls32.as_rendered_string
                return Five_h16__ls32(data_store.ensure_string_index_for_string ipv6_string, hextets, ls32)

            }

        /// [               h16 ] "::" 4( h16 ":" ) ls32
        static member Maybe_One_h16__Four_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_hextet = opt Hextet.parser
                do! skip_string "::"

                let! hextets =
                    parray 4 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser
                let maybe_hextet_string = 
                    match maybe_hextet with 
                    | ValueSome hextet -> sprintf "%s" hextet.as_raw_string
                    | ValueNone -> String.Empty
                let hextet_string = 
                        hextets
                        |> Array.map (fun hextet -> hextet.as_raw_string)
                        |> String.concat ":"


                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string hextet_string ls32.as_rendered_string
                return Maybe_One_h16__Four_h16__ls32(data_store.ensure_string_index_for_string ipv6_string, maybe_hextet, hextets, ls32)

            }



        /// [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
        static member Maybe_Two_h16__Three_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_two_hextets =
                    opt (
                        choice [

                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"

                let! hextets =
                    parray 4 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser

                let maybe_hextet_string = 
                        match maybe_two_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let hextet_string = 
                        hextets
                        |> Array.map (fun hextet -> hextet.as_raw_string)
                        |> String.concat ":"
                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string hextet_string ls32.as_rendered_string
                return Maybe_Two_h16__Three_h16__ls32(data_store.ensure_string_index_for_string ipv6_string, maybe_two_hextets, hextets, ls32)



            }



        /// [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
        static member Maybe_Three_h16__Two_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_three_hextets =
                    opt (
                        choice [

                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"

                let! hextets =
                    parray 2 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser

                let maybe_hextet_string = 
                        match maybe_three_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let hextet_string = 
                        hextets
                        |> Array.map (fun hextet -> hextet.as_raw_string)
                        |> String.concat ":"
                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string hextet_string ls32.as_rendered_string
                return Maybe_Three_h16__Two_h16__ls32(data_store.ensure_string_index_for_string ipv6_string, maybe_three_hextets, hextets, ls32)



            }

        /// [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
        static member Maybe_Four_h16__One_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_four_hextets =
                    opt (
                        choice [

                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let! h16 = Hextet.colon_suffixed_parser
                let! ls32 = Least_Significant_32_Bits.parser

                let maybe_hextet_string = 
                        match maybe_four_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string h16.as_raw_string ls32.as_rendered_string
                return Maybe_Four_h16__One_h16__ls32(data_store.ensure_string_index_for_string ipv6_string, maybe_four_hextets, h16, ls32)



            }

        /// [ *4( h16 ":" ) h16 ] "::"              ls32
        static member Maybe_Five_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_five_hextets =
                    opt (
                        choice [

                                 parray 4 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let! ls32 = Least_Significant_32_Bits.parser
                let maybe_hextet_string = 
                        match maybe_five_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::%s" maybe_hextet_string  ls32.as_rendered_string
                return Maybe_Five_h16__ls32(data_store.ensure_string_index_for_string ipv6_string, maybe_five_hextets, ls32)



            }

        /// [ *5( h16 ":" ) h16 ] "::"              h16
        static member Maybe_Six_h16__h16_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_six_hextets =
                    opt (
                        choice [

                                 parray 5 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 4 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let! h16 = Hextet.parser
                let maybe_hextet_string = 
                        match maybe_six_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::%s" maybe_hextet_string  h16.as_raw_string
                return Maybe_Six_h16__h16(data_store.ensure_string_index_for_string ipv6_string, maybe_six_hextets, h16)



            }

        /// [ *6( h16 ":" ) h16 ] "::"
        static member Maybe_Seven_h16_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_seven_hextets =
                    opt (
                        choice [

                                 parray 5 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 4 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let maybe_hextet_string = 
                        match maybe_seven_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::" maybe_hextet_string
                return Maybe_Seven_h16(data_store.ensure_string_index_for_string ipv6_string, maybe_seven_hextets)



            }

        static member parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! ipv6 =

                    choice [

                             IPv6_Address.Six_h16__ls32_parser
                             IPv6_Address.Five_h16__ls32_parser
                             IPv6_Address.Maybe_One_h16__Four_h16__ls32_parser
                             IPv6_Address.Maybe_Two_h16__Three_h16__ls32_parser
                             IPv6_Address.Maybe_Three_h16__Two_h16__ls32_parser
                             IPv6_Address.Maybe_Four_h16__One_h16__ls32_parser
                             IPv6_Address.Maybe_Five_h16__ls32_parser
                             IPv6_Address.Maybe_Six_h16__h16_parser
                             IPv6_Address.Maybe_Seven_h16_parser



                              ]


                return ipv6


            }

        static member metasyntax =
            """
            IPv6address   =                            6( h16 ":" ) ls32
                         /                       "::" 5( h16 ":" ) ls32
                         / [               h16 ] "::" 4( h16 ":" ) ls32
                         / [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
                         / [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
                         / [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
                         / [ *4( h16 ":" ) h16 ] "::"              ls32
                         / [ *5( h16 ":" ) h16 ] "::"              h16
                         / [ *6( h16 ":" ) h16 ] "::"
            """

        static member parse(input_string: string) =
            match IPv6_Address.parser input_string.as_parser_input with
            | Ok success -> 
              success.as_raw_strings |> Array.iter data_store.intern_string  
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IPv6_Address.metasyntax)




        // TODO next handle other members like codes and strings


        member this.as_code_square =
            match this with
            | Six_h16__ls32 (_,h16_array, ls32) ->
                h16_array
                |> Array.map (fun h16 -> h16.as_code_line)
                |> Array.append ls32.as_code_square
            | Five_h16__ls32 (_,h16_array, ls32) ->
                h16_array
                |> Array.map (fun h16 -> h16.as_code_line)
                |> Array.append ls32.as_code_square
            | Maybe_One_h16__Four_h16__ls32 (_,maybe_hextet, hextets, ls32) ->
                let prefix_hextets =
                    match maybe_hextet with
                    | ValueSome hextet -> [| hextet.as_code_line |]
                    | ValueNone -> [||]

                let hextet_code_lines =
                    hextets
                    |> Array.map (fun hextet -> hextet.as_code_line)

                prefix_hextets
                |> Array.append hextet_code_lines
                |> Array.append ls32.as_code_square
            | Maybe_Two_h16__Three_h16__ls32 (_,maybe_two_hextets, hextets, ls32) ->
                let prefix_hextets =
                    match maybe_two_hextets with
                    | ValueSome hextets ->
                        hextets
                        |> Array.map (fun hextet -> hextet.as_code_line)
                    | ValueNone -> [||]

                let hextet_code_lines =
                    hextets
                    |> Array.map (fun hextet -> hextet.as_code_line)

                prefix_hextets
                |> Array.append hextet_code_lines
                |> Array.append ls32.as_code_square
            | Maybe_Three_h16__Two_h16__ls32 (_,maybe_three_hextets, hextets, ls32) ->
                let prefix_hextets =
                    match maybe_three_hextets with
                    | ValueSome hextets ->
                        hextets
                        |> Array.map (fun hextet -> hextet.as_code_line)
                    | ValueNone -> [||]

                let hextet_code_lines =
                    hextets
                    |> Array.map (fun hextet -> hextet.as_code_line)

                prefix_hextets
                |> Array.append hextet_code_lines
                |> Array.append ls32.as_code_square
            | Maybe_Four_h16__One_h16__ls32 (_,maybe_four_hextets, h16, ls32) ->
                let prefix_hextets =
                    match maybe_four_hextets with
                    | ValueSome hextets ->
                        hextets
                        |> Array.map (fun hextet -> hextet.as_code_line)
                    | ValueNone -> [||]

                let hextet_code_lines =
                    prefix_hextets
                    |> Array.append [| h16.as_code_line |]

                hextet_code_lines
                |> Array.append ls32.as_code_square
            | Maybe_Five_h16__ls32 (_,maybe_five_hextets, ls32) ->
                let prefix_hextets =
                    match maybe_five_hextets with
                    | ValueSome hextets ->
                        hextets
                        |> Array.map (fun hextet -> hextet.as_code_line)
                    | ValueNone -> [||]

                prefix_hextets |> Array.append ls32.as_code_square
            | Maybe_Six_h16__h16 (_,maybe_six_hextets, h16) ->
                let prefix_hextets =
                    match maybe_six_hextets with
                    | ValueSome hextets ->
                        hextets
                        |> Array.map (fun hextet -> hextet.as_code_line)
                    | ValueNone -> [||]

                prefix_hextets
                |> Array.append [| h16.as_code_line |]
            | Maybe_Seven_h16 (_, maybe_seven_hextets) ->
                match maybe_seven_hextets with
                | ValueSome hextets ->
                    hextets
                    |> Array.map (fun hextet -> hextet.as_code_line)
                | ValueNone -> [||]


        member this.as_raw_strings =
            Strings.from_code_square this.as_code_square
        member this.as_raw_string =
            this.as_raw_strings
            |> String.concat ""

        member this.string_index = 
            match this with
            | Six_h16__ls32 (string_index ,h16_array, ls32) -> string_index
            | Five_h16__ls32 (string_index ,h16_array, ls32) -> string_index
            | Maybe_One_h16__Four_h16__ls32 (string_index ,maybe_hextet, hextets, ls32) -> string_index
            | Maybe_Two_h16__Three_h16__ls32 (string_index ,maybe_two_hextets, hextets, ls32) -> string_index
            | Maybe_Three_h16__Two_h16__ls32 (string_index ,maybe_three_hextets, hextets, ls32) -> string_index
            | Maybe_Four_h16__One_h16__ls32 (string_index ,maybe_four_hextets, h16, ls32) -> string_index
            | Maybe_Five_h16__ls32 (string_index ,maybe_five_hextets, ls32) -> string_index
            | Maybe_Six_h16__h16 (string_index ,maybe_six_hextets, h16) -> string_index
            | Maybe_Seven_h16 (string_index , maybe_seven_hextets) -> string_index
        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%s``" this unames this.as_raw_string

    type IPvFuture =
        private
        | IPvFuture of String_Index * Code_Line * Code_Line


        static member parser: Parser<IPvFuture, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_any_from_string "vV"

                let! hexdigits =
                    many1 hexdigit.code_point_parser
                    |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)

                do! skip_char '.'

                let! address =
                    many1 (userinfo.code_point_parser)
                    |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)
                let ipvfuture_string = sprintf "%s.%s" (String.from_code_line hexdigits) (String.from_code_line address)


                return IPvFuture(data_store.ensure_string_index_for_string ipvfuture_string, hexdigits, address)


            }

        static member metasyntax =
            """
                                IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
                                """

        static member parse(input_string: string) =
            match IPvFuture.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IPvFuture.metasyntax)

        member this.as_code_square =
            match this with
            | IPvFuture (_, hexdigits, address) -> [| hexdigits; address |]
        member this.string_index =
            match this with
            | IPvFuture (string_index, hexdigits, address) -> string_index


        member this.as_raw_strings = Strings.from_code_square this.as_code_square

        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings


    type IP_Literal =
        private
        | IPv6Literal of IPv6_Address
        | IPvFutureLiteral of IPvFuture


        static member parser: Parser<IP_Literal, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '['

                let! literal =
                    choice [ IPv6_Address.parser |>> IPv6Literal
                             IPvFuture.parser |>> IPvFutureLiteral ]

                do! skip_char ']'
                return literal


            }

        static member metasyntax =
            """
            IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
            """

        static member parse(input_string: string) =
            match IP_Literal.parser input_string.as_parser_input with
            | Ok success -> 
              success.as_raw_strings |> Array.iter data_store.intern_string  
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IP_Literal.metasyntax)

        member this.as_code_square =
            match this with
            | IPv6Literal ipv6_address -> ipv6_address.as_code_square
            | IPvFutureLiteral ipvfuture -> ipvfuture.as_code_square

        member this.as_raw_strings =
            match this with
            | IPv6Literal ipv6_address -> [| ipv6_address.as_raw_string |]
            | IPvFutureLiteral ipvfuture -> ipvfuture.as_raw_strings
        member this.string_index = 
                match this with
                | IPv6Literal ipv6_address -> ipv6_address.string_index
                | IPvFutureLiteral ipvfuture -> ipvfuture.string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_rendered_string = sprintf "[%s]" this.as_raw_string

            

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings


    type Port =
        private
        | Port of String_Index
        static member parser: Parser<Port, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char ':'

                let! digits =
                    many (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                    |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)
                let port_string = String.from_code_line digits

                return data_store.ensure_string_index_for_string port_string |> Port

            }

        static member metasyntax =
            """
                                      ":" port
                                      port          = *DIGIT
                                      """

        static member parse(input_string: string) =
            match Port.parser input_string.as_parser_input with
            | Ok success -> 
              data_store.intern_string success.as_raw_string 
              success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line Port.metasyntax)

        member this.string_index =
            match this with 
            | Port string_index ->  string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line

        member this.as_int = int this.as_raw_string
        member this.as_rendered_string = sprintf ":%s" this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string

    // TODO consider pairing with iana scheme
    type Scheme =
        private
        | Scheme of String_Index
        static member parser: Parser<Scheme, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! scheme_head =
                    choice [

                             Unicodepoint.Partition.Latin_Majuscule
                             |> any_point_from_interval
                             Unicodepoint.Partition.Latin_Minuscule
                             |> any_point_from_interval

                              ]

                let! scheme_tail =

                    many (
                        choice [


                                 Unicodepoint.Partition.Latin_Majuscule
                                 |> any_point_from_interval
                                 Unicodepoint.Partition.Latin_Minuscule
                                 |> any_point_from_interval
                                 Unicodepoint.Partition.Ascii_Digits
                                 |> any_point_from_interval
                                 parse_char '+'
                                 parse_char '-'
                                 parse_char '.'



                                  ]
                    )
                let scheme:Code_Line = 
                    Array.concat [| [| scheme_head |]
                                    scheme_tail.AsMemory().ToArray() |]

                return scheme |> String.from_code_line |> data_store.ensure_string_index_for_string |> Scheme


            }

        static member metasyntax =
            """
                                      scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
                                      """

        static member parse(input_string: string) =
            match Scheme.parser input_string.as_parser_input with
            | Ok success -> 
              data_store.intern_string success.as_raw_string 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Scheme.metasyntax)

        member this.string_index =
            match this with 
            | Scheme string_index -> string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line


        member this.as_rendered_string = this.as_raw_string.ToLowerInvariant()

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string





    type Fragment =
        private
        | UniformFragment of String_Index
        | InternationalizedFragment of String_Index
        static member parser: Parser<Fragment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '#'

                let! fragment =
                    choice [ ifragment.code_line_parser
                             |>> (fun code_line -> code_line |> String.from_code_line |> data_store.ensure_string_index_for_string |> InternationalizedFragment)
                             query_fragment.code_line_parser
                             |>> (fun code_line -> code_line |> String.from_code_line |> data_store.ensure_string_index_for_string |> UniformFragment) ]

                return fragment

            }

        static member metasyntax =
            """
                                      ifragment      = *( ipchar / "/" / "?" )
                                      fragment      = *( pchar / "/" / "?" )
                                      """

        static member parse(input_string: string) =
            match Fragment.parser input_string.as_parser_input with
            | Ok success -> 
              data_store.intern_string success.as_raw_string 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Fragment.metasyntax)

        member this.string_index =
            match this with 
            | InternationalizedFragment string_index -> string_index
            | UniformFragment string_index -> string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line
        member this.as_rendered_string = sprintf "#%s" this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string


    type Query =
        private
        | InternationalizedQuery of String_Index
        | UniformQuery of String_Index
        static member parser: Parser<Query, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '?'

                return!
                    choice [ iquery.code_line_parser |>> (fun code_line -> code_line |> String.from_code_line |> data_store.ensure_string_index_for_string |> InternationalizedQuery)
                             query_fragment.code_line_parser |>> (fun code_line -> code_line |> String.from_code_line |> data_store.ensure_string_index_for_string |> UniformQuery) ]

            }

        static member metasyntax =
            """
                                      iquery         = *( ipchar / iprivate / "/" / "?" )
                                      query         = *( pchar / "/" / "?" )
                                      """

        static member parse(input_string: string) =
            match Query.parser input_string.as_parser_input with
            | Ok success -> 
              data_store.intern_string success.as_raw_string 
              success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line Query.metasyntax)

        member this.string_index =
            match this with 
            | InternationalizedQuery string_index -> string_index
            | UniformQuery string_index -> string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line
        member this.as_rendered_string = sprintf "?%s" this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string

    type Userinfo =
        private
        | InternationalizedUserinfo of String_Index
        | UniformUserinfo of String_Index
        static member parser: Parser<Userinfo, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! userinfo =
                    choice [ many iuserinfo.code_point_parser
                             |>> (fun immutable_code_line ->
                                 Code_Line.from_immutable_code_line immutable_code_line |> String.from_code_line |> data_store.ensure_string_index_for_string |> InternationalizedUserinfo)
                             many userinfo.code_point_parser
                             |>> (fun immutable_code_line ->
                                 Code_Line.from_immutable_code_line immutable_code_line |> String.from_code_line |> data_store.ensure_string_index_for_string |> UniformUserinfo) ]

                do! skip_char '@'
                return userinfo

            }

        static member metasyntax =
            """
                                      iuserinfo      = *( iunreserved / pct-encoded / sub-delims / ":" )
                                      userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )
                                      iuserinfo "@"
                                      userinfo "@"
                                      """

        static member parse(input_string: string) =
            match Userinfo.parser input_string.as_parser_input with
            | Ok success -> 
                data_store.intern_string success.as_raw_string 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Userinfo.metasyntax)

        member this.string_index =
            match this with 
            | InternationalizedUserinfo string_index -> string_index
            | UniformUserinfo string_index -> string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line
        member this.as_rendered_string = sprintf "%s@" this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string


    type Segment =
        private
        | UniformSegment of String_Index
        | UniformSegmentFromUniformNonZeroSegment of String_Index
        | UniformSegmentFromUniformNonzeroNoncolonSegment of String_Index
        | InternationalizedSegment of String_Index
        | InternationalizedSegmentFromInternationalizedNonZeroSegment of String_Index
        | InternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment of String_Index
        // TODO next implement isegment into parser as choice
        static member parser: Parser<Segment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [ many ipchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String.from_code_line |> data_store.ensure_string_index_for_string 
                                 |> InternationalizedSegment)
                             many pchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String.from_code_line |> data_store.ensure_string_index_for_string
                                 |> UniformSegment) ]


            }

        static member metasyntax =
            """
                    isegment       = *ipchar
                    segment       = *pchar
                    """

        static member parse(input_string: string) =
            match Segment.parser input_string.as_parser_input with
            | Ok success -> 
                data_store.intern_string success.as_raw_string 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Segment.metasyntax)

        member this.string_index =
            match this with
            | UniformSegment string_index -> string_index
            | UniformSegmentFromUniformNonZeroSegment string_index -> string_index
            | UniformSegmentFromUniformNonzeroNoncolonSegment string_index -> string_index
            | InternationalizedSegment string_index -> string_index
            | InternationalizedSegmentFromInternationalizedNonZeroSegment string_index -> string_index
            | InternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment string_index -> string_index

        member this.as_raw_string = data_store.get_string_for_string_index this.string_index

        member this.as_code_line = this.as_raw_string.as_code_line
        static member code_line(segment: Segment) = segment.as_code_line
        static member raw_string(segment: Segment) = segment.as_raw_string
        member this.as_rendered_string = this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string

    type Nonzero_Segment =
        private
        | InternationalizedNonzeroSegment of String_Index
        | UniformNonzeroSegment of String_Index

        static member parser: Parser<Nonzero_Segment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [

                             many1 ipchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String.from_code_line |> data_store.ensure_string_index_for_string 
                                 |> InternationalizedNonzeroSegment)
                             many1 pchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String.from_code_line |> data_store.ensure_string_index_for_string
                                 |> UniformNonzeroSegment)

                              ]

            }

        static member metasyntax =
            """
                    isegment-nz    = 1*ipchar
                    segment-nz    = 1*pchar
                    """

        static member parse(input_string: string) =
            match Nonzero_Segment.parser input_string.as_parser_input with
            | Ok success -> 
                data_store.intern_string success.as_raw_string 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Nonzero_Segment.metasyntax)

        member this.string_index =
            match this with
            | UniformNonzeroSegment string_index -> string_index
            | InternationalizedNonzeroSegment string_index -> string_index


        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line
        member this.as_rendered_string = this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string

    type Nonzero_Noncolon_Segment =
        private
        | InternationalizedNonzeroNoncolonSegment of String_Index
        | UniformNonzeroNoncolonSegment of String_Index
        static member parser: Parser<Nonzero_Noncolon_Segment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [ many1 ipchar_encoded_noncolon.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String.from_code_line |> data_store.ensure_string_index_for_string
                                 |> InternationalizedNonzeroNoncolonSegment)
                             many1 pchar_encoded_noncolon.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String.from_code_line |> data_store.ensure_string_index_for_string
                                 |> UniformNonzeroNoncolonSegment) ]

            }

        static member metasyntax =
            """
                    isegment-nz-nc = 1*( iunreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                    segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                    """

        static member parse(input_string: string) =
            match Segment.parser input_string.as_parser_input with
            | Ok success -> 
                data_store.intern_string success.as_raw_string 
                success
            | Error failure ->
                failwithf
                    "%A: %s"
                    failure
                    (code_line_message input_string.as_code_line Nonzero_Noncolon_Segment.metasyntax)

        member this.string_index =
            match this with
            | UniformNonzeroNoncolonSegment string_index -> string_index
            | InternationalizedNonzeroNoncolonSegment string_index -> string_index


        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line
        member this.as_rendered_string = this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string

    type Path_Abempty =
        private
        | UniformPathAbempty of String_Index * Segment array
        | InternationalizedPathAbempty of String_Index * Segment array
        static member parser: Parser<Path_Abempty, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! segments =
                    many (skip_char '/' >>. Segment.parser)
                    |>> (fun immutable_segments -> immutable_segments.AsSpan().ToArray())

                let is_internationalized =
                    segments
                    |> Array.exists (fun segment ->
                        segment.IsInternationalizedSegment
                        || segment.IsInternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment
                        || segment.IsInternationalizedSegmentFromInternationalizedNonZeroSegment

                    )
                let path_string = 
                    "/" + (segments |> Array.map (fun segment -> segment.as_raw_string) |> String.concat "/")

                return
                    if is_internationalized then
                         InternationalizedPathAbempty(data_store.ensure_string_index_for_string path_string, segments)
                    else
                        UniformPathAbempty(data_store.ensure_string_index_for_string path_string, segments)

            }

        static member metasyntax =
            """
                    ipath-abempty  = *( "/" isegment )
                    path-abempty  = *( "/" segment )
                    """

        static member parse(input_string: string) =
            match Path_Abempty.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Abempty.metasyntax)

        member this.as_raw_segments =
            match this with
            | UniformPathAbempty (_,segments) -> segments
            | InternationalizedPathAbempty (_,segments) -> segments

        member this.as_code_square =
            match this with
            | UniformPathAbempty (_,segments) ->
                segments
                |> Array.map (fun segment -> segment.as_code_line)
            | InternationalizedPathAbempty (_,segments) ->
                segments
                |> Array.map (fun segment -> segment.as_code_line)


        member this.as_string_segments =
            this.as_raw_segments
            |> Array.map Segment.raw_string
        member this.string_index = 

            match this with
            | UniformPathAbempty (string_index,segments) -> string_index
            | InternationalizedPathAbempty (string_index,segments) -> string_index
        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames =
                this.as_raw_segments
                |> Array.map Segment.code_line
                |> Code_Square.Unames

            sprintf "%A %A ``%A``" this unames this.as_string_segments

    type Path_Rootless =
        private
        | UniformPathRootless of String_Index * Nonzero_Segment * Path_Abempty
        | InternationalizedPathRootless of String_Index * Nonzero_Segment * Path_Abempty

        static member parser: Parser<Path_Rootless, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! segment_nz = Nonzero_Segment.parser
                let! abempty = Path_Abempty.parser
                let path_string =  segment_nz.as_rendered_string + abempty.as_rendered_string

                return
                    if segment_nz.IsInternationalizedNonzeroSegment
                       || abempty.IsInternationalizedPathAbempty then
                        InternationalizedPathRootless(data_store.ensure_string_index_for_string path_string, segment_nz, abempty)
                    else
                        UniformPathRootless(data_store.ensure_string_index_for_string path_string, segment_nz, abempty)

            }

        static member metasyntax =
            """
                    ipath-rootless = isegment-nz *( "/" isegment )
                    path-rootless = segment-nz *( "/" segment )
                    """

        static member parse(input_string: string) =
            match Path_Rootless.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Rootless.metasyntax)


        member this.as_raw_segments =
            match this with
            | UniformPathRootless (_, segment_nz, path_abempty) ->
                Array.concat [| [| (Segment.UniformSegmentFromUniformNonZeroSegment segment_nz.string_index) |]
                                path_abempty.as_raw_segments |]
            | InternationalizedPathRootless (_,segment_nz, path_abempty) ->
                Array.concat [| [| (Segment.InternationalizedSegmentFromInternationalizedNonZeroSegment
                                       segment_nz.string_index) |]
                                path_abempty.as_raw_segments |]

        member this.as_code_square =
            match this with
            | UniformPathRootless (_, segment_nz, path_abempty) ->
                Array.concat [| [| segment_nz.as_code_line |]
                                path_abempty.as_code_square

                                 |]

            | InternationalizedPathRootless (_, segment_nz, path_abempty) ->

                Array.concat [| [| segment_nz.as_code_line |]
                                path_abempty.as_code_square

                                 |]


        member this.as_string_segments =
            this.as_raw_segments
            |> Array.map Segment.raw_string
        member this.as_raw_strings = Strings.from_code_square this.as_code_square

        member this.string_index =
            match this with
            | UniformPathRootless (string_index, segment_nz, path_abempty) -> string_index
            | InternationalizedPathRootless (string_index,segment_nz, path_abempty) -> string_index
        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames =
                this.as_raw_segments
                |> Array.map Segment.code_line
                |> Code_Square.Unames

            sprintf "%A %A ``%A``" this unames this.as_string_segments

    type Path_Absolute =
        private
        | UniformAbsoluteRootPath of String_Index * Path_Rootless
        | InternationalizedAbsoluteRootPath of String_Index * Path_Rootless
        | AbsoluteRoot of String_Index


        static member parser: Parser<Path_Absolute, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '/'
                let! maybe_path = opt Path_Rootless.parser
                let path_string = 
                    "/" + (
                        match maybe_path with 
                        | ValueSome path -> path.as_rendered_string
                        | ValueNone -> String.Empty
                    )

                return
                    match maybe_path with
                    | ValueSome path when path.IsInternationalizedPathRootless -> InternationalizedAbsoluteRootPath(data_store.ensure_string_index_for_string path_string, path)
                    | ValueSome path -> UniformAbsoluteRootPath (data_store.ensure_string_index_for_string path_string, path)
                    | ValueNone ->  data_store.ensure_string_index_for_string path_string |> AbsoluteRoot

            }

        static member metasyntax =
            """
                    ipath-absolute = "/" [ isegment-nz *( "/" isegment ) ]
                    path-absolute = "/" [ segment-nz *( "/" segment ) ]
                    """

        static member parse(input_string: string) =
            match Path_Absolute.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Absolute.metasyntax)

        member this.as_code_square =
            match this with
            | UniformAbsoluteRootPath (_, path_rootless) -> path_rootless.as_code_square
            | InternationalizedAbsoluteRootPath (_, path_rootless) -> path_rootless.as_code_square
            | AbsoluteRoot _ -> [||]


        member this.as_raw_segments =
            match this with
            | UniformAbsoluteRootPath (_, path_rootless) -> path_rootless.as_raw_segments
            | InternationalizedAbsoluteRootPath (_, path_rootless) -> path_rootless.as_raw_segments
            | AbsoluteRoot _ -> [||]

        static member code_line(segment: Segment) = segment.as_code_line

        member this.as_string_segments =
            this.as_raw_segments
            |> Array.map Segment.raw_string
        member this.as_raw_strings = Strings.from_code_square this.as_code_square
        member this.string_index =
            match this with
            | UniformAbsoluteRootPath (string_index, path_rootless) -> string_index
            | InternationalizedAbsoluteRootPath (string_index, path_rootless) -> string_index
            | AbsoluteRoot string_index -> string_index
        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames =
                this.as_raw_segments
                |> Array.map Segment.code_line
                |> Code_Square.Unames

            sprintf "%A %A ``%A``" this unames this.as_string_segments

    type Path_Noscheme =
        private
        | UniformPathNoscheme of String_Index * Nonzero_Noncolon_Segment * Path_Abempty
        | InternationalizedPathNoscheme of String_Index * Nonzero_Noncolon_Segment * Path_Abempty


        static member parser: Parser<Path_Noscheme, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! segment_nz_nc = Nonzero_Noncolon_Segment.parser
                let! abempty = Path_Abempty.parser
                let path_string =  segment_nz_nc.as_rendered_string + abempty.as_rendered_string

                return
                    if segment_nz_nc.IsInternationalizedNonzeroNoncolonSegment then
                        InternationalizedPathNoscheme(data_store.ensure_string_index_for_string path_string, segment_nz_nc, abempty)
                    else
                        UniformPathNoscheme(data_store.ensure_string_index_for_string path_string, segment_nz_nc, abempty)

            }

        static member metasyntax =
            """
                    ipath-noscheme = isegment-nz-nc *( "/" isegment )
                    path-noscheme = segment-nz *( "/" segment )
                    """

        static member parse(input_string: string) =
            match Path_Noscheme.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Noscheme.metasyntax)

        member this.as_raw_segments =
            match this with
            | UniformPathNoscheme (_, segment_nz_nc, path_abempty) ->
                Array.concat [| [| Segment.UniformSegmentFromUniformNonzeroNoncolonSegment segment_nz_nc.string_index |]
                                path_abempty.as_raw_segments |]

            | InternationalizedPathNoscheme (_, segment_nz_nc, path_abempty) ->
                Array.concat [| [| Segment.InternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment
                                       segment_nz_nc.string_index |]
                                path_abempty.as_raw_segments |]

        member this.as_code_square =
            match this with
            | UniformPathNoscheme (_, segment_nz_nc, path_abempty) ->
                Array.concat [| [| segment_nz_nc.as_code_line |]
                                path_abempty.as_code_square |]
            | InternationalizedPathNoscheme (_, segment_nz_nc, path_abempty) ->
                Array.concat [| [| segment_nz_nc.as_code_line |]
                                path_abempty.as_code_square |]


        member this.as_string_segments =
            this.as_raw_segments
            |> Array.map Segment.raw_string
        member this.as_raw_strings = Strings.from_code_square this.as_code_square

        member this.string_index =
            match this with
            | UniformPathNoscheme (string_index, segment_nz_nc, path_abempty) -> string_index
            | InternationalizedPathNoscheme (string_index,segment_nz_nc, path_abempty) -> string_index
        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames =
                this.as_raw_segments
                |> Array.map Segment.code_line
                |> Code_Square.Unames

            sprintf "%A %A ``%A``" this unames this.as_string_segments



    type Registered_Name =
        private
        | UniformRegisteredName of String_Index
        | InternationalizedRegisteredName of String_Index
        static member parser: Parser<Registered_Name, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [ many ireg_name.code_point_parser
                             |>> (fun immutable_code_line ->
                                 immutable_code_line.AsSpan().ToArray() |> String.from_code_line |> data_store.ensure_string_index_for_string
                                 |> UniformRegisteredName)
                             many reg_name.code_point_parser
                             |>> (fun immutable_code_line ->
                                 immutable_code_line.AsSpan().ToArray() |> String.from_code_line |> data_store.ensure_string_index_for_string
                                 |> InternationalizedRegisteredName) ]

            }

        static member metasyntax =
            """
                                      ireg-name      = *( iunreserved / pct-encoded / sub-delims )
                                      reg-name      = *( unreserved / pct-encoded / sub-delims )
                                      """

        static member parse(input_string: string) =
            match Registered_Name.parser input_string.as_parser_input with
            | Ok success -> 
            
              data_store.intern_string success.as_raw_string 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Registered_Name.metasyntax)


        member this.string_index =
            match this with
            | UniformRegisteredName string_index -> string_index
            | InternationalizedRegisteredName string_index -> string_index


        member this.as_raw_string = data_store.get_string_for_string_index this.string_index
        member this.as_code_line = this.as_raw_string.as_code_line
        member this.as_rendered_string = this.as_raw_string

        member this.fsi_printer =
            let unames = Code_Line.Unames this.as_code_line
            sprintf "%A %A ``%s``" this unames this.as_raw_string




    type Host =
        | IPLiteralHost of IP_Literal
        | IPv4Host of IPv4_Address
        | UniformRegisteredNameHost of Registered_Name
        | InternationalizedRegisteredNameHost of Registered_Name


        static member parser: Parser<Host, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! host =
                    choice [ IP_Literal.parser |>> IPLiteralHost
                             IPv4_Address.parser |>> IPv4Host
                             Registered_Name.parser
                             |>> (fun reg_name ->
                                 if reg_name.IsInternationalizedRegisteredName then
                                     InternationalizedRegisteredNameHost reg_name
                                 else
                                     UniformRegisteredNameHost reg_name

                                 ) ]

                return host


            }

        static member metasyntax =
            """
            ihost          = IP-literal / IPv4address / ireg-name
            host          = IP-literal / IPv4address / reg-name
            """

        static member parse(input_string: string) =
            match Host.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IP_Literal.metasyntax)

        member this.as_code_square =
            match this with
            | IPLiteralHost ip_literal -> ip_literal.as_code_square
            | IPv4Host ipv4_address -> ipv4_address.as_code_square
            | UniformRegisteredNameHost registered_name -> [| registered_name.as_code_line |]
            | InternationalizedRegisteredNameHost registered_name -> [| registered_name.as_code_line |]

        member this.as_raw_strings = Strings.from_code_square this.as_code_square
        member this.string_index = 
            match this with
            | IPLiteralHost ip_literal -> ip_literal.string_index
            | IPv4Host ipv4_address -> ipv4_address.string_index
            | UniformRegisteredNameHost registered_name -> registered_name.string_index
            | InternationalizedRegisteredNameHost registered_name -> registered_name.string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index 

        member this.as_rendered_string =
            match this with
            | IPLiteralHost ip_literal -> ip_literal.as_rendered_string
            | IPv4Host ipv4_address -> ipv4_address.as_rendered_string
            | UniformRegisteredNameHost registered_name -> registered_name.as_rendered_string
            | InternationalizedRegisteredNameHost registered_name -> registered_name.as_rendered_string

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings

    type Authority =
        | HostAuthority of String_Index *  Host
        | UserinfoHostAuthority of String_Index *  Userinfo * Host
        | HostPortAuthority of String_Index *  Host * Port
        | UserinfoHostPortAuthority of String_Index *  Userinfo * Host * Port


        static member parser: Parser<Authority, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_userinfo = opt Userinfo.parser
                let! host = Host.parser
                let! maybe_port = opt Port.parser

                return
                    match maybe_userinfo, host, maybe_port with
                    | ValueNone, host, ValueNone -> HostAuthority(host.string_index , host)
                    | ValueSome userinfo, host, ValueNone -> 
                        let authority_string = userinfo.as_rendered_string + host.as_rendered_string
                        UserinfoHostAuthority(data_store.ensure_string_index_for_string authority_string, userinfo, host)
                    | ValueNone, host, ValueSome port -> 
                        let authority_string = host.as_rendered_string + port.as_rendered_string
                        HostPortAuthority(data_store.ensure_string_index_for_string authority_string, host, port)
                    | ValueSome userinfo, host, ValueSome port -> 
                        let authority_string = userinfo.as_rendered_string + host.as_rendered_string + port.as_rendered_string
                        UserinfoHostPortAuthority(data_store.ensure_string_index_for_string authority_string, userinfo, host, port)

            }

        static member metasyntax =
            """
            iauthority     = [ iuserinfo "@" ] ihost [ ":" port ]
            authority     = [ userinfo "@" ] host [ ":" port ]
            """

        static member parse(input_string: string) =
            match Authority.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Authority.metasyntax)

        member this.as_code_square =
            match this with
            | HostAuthority (_, host) -> host.as_code_square
            | UserinfoHostAuthority (_, userinfo, host) ->
                Array.concat [| [| userinfo.as_code_line |]
                                host.as_code_square

                                 |]

            | HostPortAuthority (_, host, port) ->
                Array.concat [| [| port.as_code_line |]
                                host.as_code_square

                                 |]
            | UserinfoHostPortAuthority (_, userinfo, host, port) ->
                Array.concat [|

                                [| userinfo.as_code_line |]
                                host.as_code_square
                                [| port.as_code_line |]

                                 |]

        member this.as_raw_strings = Strings.from_code_square this.as_code_square
        member this.string_index = 
        
            match this with
            | HostAuthority (string_index , host) ->  string_index 
            | UserinfoHostAuthority (string_index , userinfo, host) -> string_index 
            | HostPortAuthority (string_index , host, port) -> string_index 
            | UserinfoHostPortAuthority (string_index , userinfo, host, port) -> string_index 

        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index


        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings





    type Relative_Part =
        | RelativeAuthorityAbemptyPart of String_Index * Authority * Path_Abempty
        | RelativeAbsolutePart of String_Index * Path_Absolute
        | RelativeNoschemePart of String_Index * Path_Noscheme
        | RelativeEmptyPart of String_Index
        static member parser: Parser<Relative_Part, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_part =
                    opt (
                        choice [

                                 skip_string "//" >>. Authority.parser
                                 .>>. Path_Abempty.parser
                                 |>> (fun struct (authority, abempty) ->
                                     let relative_string = authority.as_rendered_string + abempty.as_rendered_string
                                     RelativeAuthorityAbemptyPart(data_store.ensure_string_index_for_string relative_string, authority, abempty))
                                 Path_Absolute.parser |>> (fun path -> RelativeAbsolutePart(path.string_index, path))
                                 Path_Noscheme.parser |>> (fun path -> RelativeNoschemePart(path.string_index, path))

                                  ]
                    )

                return
                    match maybe_part with
                    | ValueSome part -> part
                    | ValueNone -> RelativeEmptyPart(data_store.ensure_string_index_for_string "")

            }

        static member metasyntax =
            """
            relative-part = "//" authority path-abempty
                 / path-absolute
                 / path-noscheme
                 / path-empty

           irelative-part = "//" iauthority ipath-abempty
                              / ipath-absolute
                              / ipath-noscheme
                              / ipath-empty
            """

        static member parse(input_string: string) =
            match Relative_Part.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Authority.metasyntax)

        member this.as_code_square =
            match this with
            | RelativeAuthorityAbemptyPart (_, authority, abempty) ->
                Array.concat [| authority.as_code_square
                                abempty.as_code_square |]
            | RelativeAbsolutePart (_, absolute) -> absolute.as_code_square
            | RelativeNoschemePart (_, noscheme) -> noscheme.as_code_square
            | RelativeEmptyPart _ -> [||]

        member this.as_raw_strings = Strings.from_code_square this.as_code_square
        member this.string_index = 
            match this with 
            | RelativeAuthorityAbemptyPart (string_index, authority, abempty) -> string_index
            | RelativeAbsolutePart (string_index, absolute) ->  string_index
            | RelativeNoschemePart (string_index,_) ->  string_index
            | RelativeEmptyPart string_index -> string_index
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index


        member this.as_rendered_string =
            match this with
            | RelativeAuthorityAbemptyPart (_, authority, abempty) -> "//" + this.as_raw_string
            | RelativeAbsolutePart (_, absolute_)  -> this.as_raw_string
            | RelativeNoschemePart (_, noscheme_)  -> this.as_raw_string
            | RelativeEmptyPart _ -> this.as_raw_string


        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings


    type Hierarchical_Part =
        | HierarchicalAuthorityAbemptyPart of String_Index * Authority * Path_Abempty
        | HierarchicalAbsolutePart of String_Index * Path_Absolute
        | HierarchicalRootlessPart of String_Index * Path_Rootless
        | HierarchicalEmptyPart of String_Index
        static member parser: Parser<Hierarchical_Part, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_part =
                    opt (
                        choice [

                                 skip_string "//" >>. Authority.parser
                                 .>>. Path_Abempty.parser
                                 |>> (fun struct (authority, abempty) ->
                                     let hierarchical_string = authority.as_rendered_string + abempty.as_rendered_string
                                     HierarchicalAuthorityAbemptyPart(data_store.ensure_string_index_for_string hierarchical_string, authority, abempty))
                                 Path_Absolute.parser |>> (fun path -> HierarchicalAbsolutePart(path.string_index, path))
                                 Path_Rootless.parser |>> (fun path -> HierarchicalRootlessPart(path.string_index, path))

                                  ]
                    )

                return
                    match maybe_part with
                    | ValueSome part -> part
                    | ValueNone -> HierarchicalEmptyPart(data_store.ensure_string_index_for_string "")

            }

        static member metasyntax =
            """
            hier-part     = "//" authority path-abempty
                         / path-absolute
                         / path-rootless
                         / path-empty
           ihier-part     = "//" iauthority ipath-abempty
                              / ipath-absolute
                              / ipath-rootless
                              / ipath-empty
            """

        static member parse(input_string: string) =
            match Hierarchical_Part.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Authority.metasyntax)

        member this.as_code_square =
            match this with
            | HierarchicalAuthorityAbemptyPart (_, authority, abempty) ->
                Array.concat [| authority.as_code_square
                                abempty.as_code_square |]
            | HierarchicalAbsolutePart (_, absolute) -> absolute.as_code_square
            | HierarchicalRootlessPart (_, rootless) -> rootless.as_code_square
            | HierarchicalEmptyPart _ -> [||]

        member this.as_raw_strings = Strings.from_code_square this.as_code_square

        member this.string_index = 
            match this with 
            | HierarchicalAuthorityAbemptyPart (string_index, authority, abempty) -> string_index
            | HierarchicalAbsolutePart (string_index, absolute) ->  string_index
            | HierarchicalRootlessPart (string_index,_) ->  string_index
            | HierarchicalEmptyPart string_index -> string_index

            
        member this.as_raw_string = data_store.get_string_for_string_index this.string_index

        member this.as_rendered_string =
            match this with
            | HierarchicalAuthorityAbemptyPart (_, authority, abempty) -> "//" + this.as_raw_string
            | HierarchicalAbsolutePart (_, absolute_)  -> this.as_raw_string
            | HierarchicalRootlessPart (_, noscheme_)  -> this.as_raw_string
            | HierarchicalEmptyPart _ -> this.as_raw_string


        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings

    type Relative_Reference =
        | RelativeReference of String_Index *  Relative_Part
        | RelativeQueryReference of String_Index *  Relative_Part * Query
        | RelativeFragmentReference of String_Index *  Relative_Part * Fragment
        | RelativeQueryFragmentReference of String_Index *  Relative_Part * Query * Fragment



        static member parser: Parser<Relative_Reference, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! relative_part = Relative_Part.parser
                let! maybe_query = opt Query.parser
                let! maybe_fragment = opt Fragment.parser

                return
                    match relative_part, maybe_query, maybe_fragment with
                    | part, ValueNone, ValueNone -> RelativeReference(part.string_index, part)
                    | part, ValueSome query_, ValueNone -> 
                        let relative_string = part.as_rendered_string + query_.as_rendered_string
                        RelativeQueryReference(data_store.ensure_string_index_for_string relative_string, part, query_)
                    | part, ValueNone, ValueSome fragment -> 
                        let relative_string = part.as_rendered_string + fragment.as_rendered_string
                        RelativeFragmentReference(data_store.ensure_string_index_for_string relative_string, part, fragment)
                    | part, ValueSome query_, ValueSome fragment ->
                        let relative_string = part.as_rendered_string + query_.as_rendered_string + fragment.as_rendered_string
                        RelativeQueryFragmentReference(data_store.ensure_string_index_for_string relative_string, part, query_, fragment)

            }

        static member metasyntax =
            """
                irelative-ref  = irelative-part [ "?" iquery ] [ "#" ifragment ]
                relative-ref  = relative-part [ "?" query ] [ "#" fragment ]

            """

        static member parse(input_string: string) =
            match Relative_Reference.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Relative_Reference.metasyntax)

        member this.as_code_square =
            match this with
            | RelativeReference (_, part) -> part.as_code_square
            | RelativeQueryReference (_, part, query_) ->
                part.as_code_square
                |> Array.append [| query_.as_code_line |]
            | RelativeFragmentReference (_, part, fragment) ->
                part.as_code_square
                |> Array.append [| fragment.as_code_line |]
            | RelativeQueryFragmentReference (_, part, query_, fragment) ->
                Array.concat [|

                                part.as_code_square
                                [| query_.as_code_line |]
                                [| fragment.as_code_line |]

                                 |]

        member this.as_raw_strings = Strings.from_code_square this.as_code_square


        member this.string_index = 
            match this with 
            | RelativeReference (string_index, part) ->  string_index
            | RelativeQueryReference (string_index, part, query_) -> string_index
            | RelativeFragmentReference (string_index, part, fragment) -> string_index
            | RelativeQueryFragmentReference (string_index, part, querystring_index, fragment) -> string_index

        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings


    type Absolute_IRI =
        | AbsoluteIRI of String_Index * Scheme * Hierarchical_Part
        | AbsoluteQueryIRI of String_Index * Scheme * Hierarchical_Part * Query
        member this.scheme =
            match this with
            | AbsoluteIRI (_, scheme, hier_part) -> scheme
            | AbsoluteQueryIRI (_, scheme, hier_part, query_) -> scheme

        static member parser: Parser<Absolute_IRI, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! scheme = Scheme.parser
                do! skip_char ':'
                let! hier_part = Hierarchical_Part.parser
                let! maybe_query = opt Query.parser

                return
                    match maybe_query with
                    | ValueSome query_ -> 
                        let absolute_string = scheme.as_rendered_string + hier_part.as_rendered_string + query_.as_rendered_string
                        AbsoluteQueryIRI(data_store.ensure_string_index_for_string absolute_string, scheme, hier_part, query_)
                    | ValueNone -> 
                        let absolute_string = scheme.as_rendered_string + hier_part.as_rendered_string

                        AbsoluteIRI(data_store.ensure_string_index_for_string absolute_string, scheme, hier_part)

            }

        static member metasyntax =
            """
                absolute-IRI   = scheme ":" ihier-part [ "?" iquery ]
                absolute-URI  = scheme ":" hier-part [ "?" query ]

            """

        static member parse(input_string: string) =
            match Absolute_IRI.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Absolute_IRI.metasyntax)

        member this.as_code_square =
            match this with
            | AbsoluteIRI (_, scheme, hier_part) ->
                Array.concat [|

                                [| scheme.as_code_line |]
                                hier_part.as_code_square

                                 |]
            | AbsoluteQueryIRI (_, scheme, hier_part, query_) ->
                Array.concat [|

                                [| scheme.as_code_line |]
                                hier_part.as_code_square
                                [| query_.as_code_line |]

                                 |]

        member this.as_raw_strings = Strings.from_code_square this.as_code_square
        member this.string_index = 
            match this with
            | AbsoluteIRI (string_index, scheme, hier_part) -> string_index
            | AbsoluteQueryIRI (string_index, scheme, hier_part, query_) -> string_index

        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings



    type IRI =
        | IRI of String_Index * Scheme * Hierarchical_Part
        | QueryIRI of String_Index * Scheme * Hierarchical_Part * Query
        | FragmentIRI of String_Index * Scheme * Hierarchical_Part * Fragment
        | QueryFragmentIRI of String_Index * Scheme * Hierarchical_Part * Query * Fragment
        member this.scheme =
            match this with
            | IRI (_, scheme, hier_part) -> scheme
            | QueryIRI (_, scheme, hier_part, query_) -> scheme
            | FragmentIRI (_, scheme, hier_part, fragment) -> scheme
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> scheme

        member this.hierarchical_part =
            match this with
            | IRI (_, scheme, hier_part) -> hier_part
            | QueryIRI (_, scheme, hier_part, query_) -> hier_part
            | FragmentIRI (_, scheme, hier_part, fragment) -> hier_part
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> hier_part

        member this.maybe_query =
            match this with
            | IRI (_, scheme, hier_part) -> None
            | QueryIRI (_, scheme, hier_part, query_) -> Some query_
            | FragmentIRI (_, scheme, hier_part, fragment) -> None
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> Some query_

        member this.maybe_fragment =
            match this with
            | IRI (_, scheme, hier_part) -> None
            | QueryIRI (_, scheme, hier_part, query_) -> None
            | FragmentIRI (_, scheme, hier_part, fragment) -> Some fragment
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> Some fragment


        static member parser: Parser<IRI, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! scheme = Scheme.parser
                do! skip_char ':'
                let! hier_part = Hierarchical_Part.parser
                let! maybe_query = opt Query.parser
                let! maybe_fragment = opt Fragment.parser

                return
                    match maybe_query, maybe_fragment with
                    | ValueNone, ValueNone -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string
                        IRI(data_store.ensure_string_index_for_string iri_string, scheme, hier_part)
                    | ValueSome query_, ValueNone -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string + query_.as_rendered_string
                        QueryIRI(data_store.ensure_string_index_for_string iri_string, scheme, hier_part, query_)
                    | ValueNone, ValueSome fragment -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string + fragment.as_rendered_string
                        FragmentIRI(data_store.ensure_string_index_for_string iri_string, scheme, hier_part, fragment)
                    | ValueSome query_, ValueSome fragment -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string + fragment.as_rendered_string
                        QueryFragmentIRI(data_store.ensure_string_index_for_string iri_string, scheme, hier_part, query_, fragment)

            }

        static member metasyntax =
            """
                IRI            = scheme ":" ihier-part [ "?" iquery ] [ "#" ifragment ]
                URI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ]

            """

        static member parse(input_string: string) =
            match IRI.parser input_string.as_parser_input with
            | Ok success -> 
                success.as_raw_strings |> Array.iter data_store.intern_string  
                success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line IRI.metasyntax)

        member this.as_code_square =
            match this with
            | IRI (_, scheme, hier_part) ->
                Array.concat [|

                                [| scheme.as_code_line |]
                                hier_part.as_code_square

                                 |]
            | QueryIRI (_, scheme, hier_part, query_) ->
                Array.concat [|

                                [| scheme.as_code_line |]
                                hier_part.as_code_square
                                [| query_.as_code_line |]

                                 |]

            | FragmentIRI (_, scheme, hier_part, fragment) ->

                Array.concat [|

                                [| scheme.as_code_line |]
                                hier_part.as_code_square
                                [| fragment.as_code_line |]

                                 |]
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) ->

                Array.concat [|

                                [| scheme.as_code_line |]
                                hier_part.as_code_square
                                [| fragment.as_code_line |]

                                 |]


        member this.as_raw_strings = Strings.from_code_square this.as_code_square

        member this.string_index =
            match this with
            | IRI (string_index, scheme, hier_part) -> string_index
            | QueryIRI (string_index, scheme, hier_part, query_) -> string_index
            | FragmentIRI (string_index, scheme, hier_part, fragment) -> string_index
            | QueryFragmentIRI (string_index, scheme, hier_part, querystring_index, fragment) -> string_index

        member this.as_rendered_string = data_store.get_string_for_string_index this.string_index

        member this.fsi_printer =
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames this.as_raw_strings




    fsi.AddPrinter<Absolute_IRI>(fun absolute_iri -> absolute_iri.fsi_printer)
    fsi.AddPrinter<Authority>(fun authority -> authority.fsi_printer)
    fsi.AddPrinter<Fragment>(fun fragment -> fragment.fsi_printer)
    fsi.AddPrinter<Hextet>(fun hextet -> hextet.fsi_printer)
    fsi.AddPrinter<Hierarchical_Part>(fun hierarchical_part -> hierarchical_part.fsi_printer)
    fsi.AddPrinter<Host>(fun host -> host.fsi_printer)
    fsi.AddPrinter<IP_Literal>(fun ip_literal -> ip_literal.fsi_printer)
    fsi.AddPrinter<IPv4_Address>(fun ipv4_address -> ipv4_address.fsi_printer)
    fsi.AddPrinter<IPv6_Address>(fun ipv6_address -> ipv6_address.fsi_printer)
    fsi.AddPrinter<IPvFuture>(fun ipvfuture -> ipvfuture.fsi_printer)
    fsi.AddPrinter<IRI>(fun iri -> iri.fsi_printer)
    fsi.AddPrinter<Least_Significant_32_Bits>(fun least_significant_32_bits -> least_significant_32_bits.fsi_printer)
    fsi.AddPrinter<Nonzero_Noncolon_Segment>(fun nonzero_noncolon_segment -> nonzero_noncolon_segment.fsi_printer)
    fsi.AddPrinter<Nonzero_Segment>(fun nonzero_segment -> nonzero_segment.fsi_printer)
    fsi.AddPrinter<Octet>(fun octet -> octet.fsi_printer)
    fsi.AddPrinter<Path_Abempty>(fun path_abempty -> path_abempty.fsi_printer)
    fsi.AddPrinter<Path_Absolute>(fun path_absolute -> path_absolute.fsi_printer)
    fsi.AddPrinter<Path_Noscheme>(fun path_noscheme -> path_noscheme.fsi_printer)
    fsi.AddPrinter<Path_Rootless>(fun path_rootless -> path_rootless.fsi_printer)
    fsi.AddPrinter<Query>(fun query -> query.fsi_printer)
    fsi.AddPrinter<Registered_Name>(fun registered_name -> registered_name.fsi_printer)
    fsi.AddPrinter<Relative_Part>(fun relative_part -> relative_part.fsi_printer)
    fsi.AddPrinter<Relative_Reference>(fun relative_reference -> relative_reference.fsi_printer)
    fsi.AddPrinter<Scheme>(fun scheme -> scheme.fsi_printer)
    fsi.AddPrinter<Segment>(fun segment -> segment.fsi_printer)
    fsi.AddPrinter<Userinfo>(fun userinfo -> userinfo.fsi_printer)

open Rfc_Types








let test_string = "https"
let test_string_index = data_store.intern_string "eristocrates.dev"


let test_scheme =  Scheme.parse test_string
print_stats()

let test_iri = IRI.parse "https://eristocrates.dev/ontology/dbug/"
