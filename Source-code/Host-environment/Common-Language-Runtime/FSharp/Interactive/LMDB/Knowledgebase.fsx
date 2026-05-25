open System
open System.IO
open System.Xml
open System.Globalization
open System.Buffers
open System.Text
open System.Collections.Generic
open System.Diagnostics

#r "nuget: Unquote"
open Swensen.Unquote.Assertions
#r "nuget: ObjectLayoutInspector"
open ObjectLayoutInspector

#r "nuget: LightningDB"
open LightningDB

#r "nuget: Blake3"

open Blake3


#r "nuget: MessagePack"
#r "nuget: MessagePack.FSharpExtensions"

open MessagePack
open MessagePack.Resolvers
open MessagePack.Formatters
open MessagePack.FSharp

#r "nuget: UUIDNext"

open UUIDNext
open UUIDNext.Tools


#r "nuget: dotNetRdf"

open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq


















let well_known_prefix = "https://eristocrates.dev/.well-known/genid/"

[<MessagePackObject>]
type Lexical_Form_ID = private LexicalFormID of byte array

type Lexical_Form =
    {

      string_value: string
      lexical_form_id: Lexical_Form_ID

     }


type String_Digest = private StringDigest of byte array


[<MessagePackObject>]
type Term_ID = private TermID of byte array

[<MessagePackObject>]
type Triple_ID = private TripleID of byte array



type Variable_ID = VariableID of Guid

type RDF_Variable =
    | FreeVariable of variable_id: Variable_ID
    | GroundVariable of variable_id: Variable_ID * term_id: Term_ID

type Graph_Pattern =
    { subject_variable: RDF_Variable
      predicate_variable: RDF_Variable
      object_variable: RDF_Variable
      graph_variable: RDF_Variable }

[<RequireQualifiedAccess>]
type ID =
    | FromLexicalFormID of Lexical_Form_ID
    | FromTermID of Term_ID
    | FromTripleID of Triple_ID
    member this.to_byte_array =
        match this with
        | FromLexicalFormID (LexicalFormID bytes) -> bytes
        | FromTermID (TermID bytes) -> bytes
        | FromTripleID (TripleID bytes) -> bytes

[<MessagePackObject>]
type Namespaced_IRI =
    { [<Key(0)>]
      namespace_name_id: Lexical_Form_ID
      [<Key(1)>]
      local_name_id: Lexical_Form_ID }

[<MessagePackObject>]
type Atomic_IRI =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID }


[<MessagePackObject>]
type Skolem_IRI =
    { [<Key(0)>]
      well_known_id: Lexical_Form_ID
      [<Key(1)>]
      uuidv7_id: Lexical_Form_ID }


[<MessagePackObject>]
type Simple_Literal =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID }

[<MessagePackObject>]
type Datatyped_Literal =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      datatype_id: Term_ID }

/// https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry
[<MessagePackObject>]
[<RequireQualifiedAccess>]
type Language_Subtag =
    | en
    | es

/// https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry
[<MessagePackObject>]
[<RequireQualifiedAccess>]
type Region_Subtag =
    | US
    | GB
    | MX

/// https://www.w3.org/TR/rdf12-concepts/#dfn-base-direction
[<MessagePackObject>]
[<RequireQualifiedAccess>]
type Language_Base_Direction =
    | ltr
    | rtl

[<MessagePackObject>]
type Language_String =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      language: Language_Subtag }


[<MessagePackObject>]
type Region_String =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      language: Language_Subtag
      [<Key(2)>]
      region: Region_Subtag }

[<MessagePackObject>]
type Directed_Language_String =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      language: Language_Subtag
      [<Key(2)>]
      direction: Language_Base_Direction }

[<MessagePackObject>]
type Directed_Region_String =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      language: Language_Subtag
      [<Key(2)>]
      region: Region_Subtag
      [<Key(3)>]
      direction: Language_Base_Direction }



























[<MessagePackObject>]
type Default_Graph = DefaultGraph of unit


[<MessagePackObject>]
type Triple =
    { [<Key(0)>]
      subject: RDF_Subject
      [<Key(1)>]
      predicate: RDF_Predicate
      [<Key(2)>]
      object: RDF_Object }

and [<MessagePackObject; RequireQualifiedAccess>] RDF_Subject =
    | FromNamespacedIRI of term_id: Term_ID * term: Namespaced_IRI
    | FromAtomicIRI of term_id: Term_ID * term: Atomic_IRI
    | FromSkolemIRI of term_id: Term_ID * term: Skolem_IRI

and [<MessagePackObject; RequireQualifiedAccess>] RDF_Predicate =
    | FromNamespacedIRI of term_id: Term_ID * term: Namespaced_IRI
    | FromAtomicIRI of term_id: Term_ID * term: Atomic_IRI

and [<MessagePackObject; RequireQualifiedAccess>] RDF_Object =
    | FromNamespacedIRI of term_id: Term_ID * term: Namespaced_IRI
    | FromAtomicIRI of term_id: Term_ID * term: Atomic_IRI
    | FromSkolemIRI of term_id: Term_ID * term: Skolem_IRI
    | FromSimpleLiteral of term_id: Term_ID * term: Simple_Literal
    | FromDatatypedLiteral of term_id: Term_ID * term: Datatyped_Literal
    | FromLanguageString of term_id: Term_ID * term: Language_String
    | FromRegionString of term_id: Term_ID * term: Region_String
    | FromDirectedLanguageString of term_id: Term_ID * term: Directed_Language_String
    | FromDirectedRegionString of term_id: Term_ID * term: Directed_Region_String
    | FromTripleTerm of term_id: Term_ID * triple_id: Triple_ID

and [<MessagePackObject; RequireQualifiedAccess>] RDF_Term =
    | FromNamespacedIRI of term_id: Term_ID * term: Namespaced_IRI
    | FromAtomicIRI of term_id: Term_ID * term: Atomic_IRI
    | FromSkolemIRI of term_id: Term_ID * term: Skolem_IRI
    | FromSimpleLiteral of term_id: Term_ID * term: Simple_Literal
    | FromDatatypedLiteral of term_id: Term_ID * term: Datatyped_Literal
    | FromLanguageString of term_id: Term_ID * term: Language_String
    | FromRegionString of term_id: Term_ID * term: Region_String
    | FromDirectedLanguageString of term_id: Term_ID * term: Directed_Language_String
    | FromDirectedRegionString of term_id: Term_ID * term: Directed_Region_String
    | FromTripleTerm of term_id: Term_ID * triple_id: Triple_ID
    | FromGraphName of term_id: Term_ID * term: Graph_Name

and [<MessagePackObject; RequireQualifiedAccess>] Graph_Name =
    | DefaultGraph
    | FromNamespacedIRI of Namespaced_IRI
    | FromAtomicIRI of Atomic_IRI
    | FromSkolemIRI of Skolem_IRI


[<MessagePackObject>]
type Quad =
    { [<Key(0)>]
      subject: RDF_Subject
      [<Key(1)>]
      predicate: RDF_Predicate
      [<Key(2)>]
      object: RDF_Object
      [<Key(3)>]
      graph_name: Graph_Name }

// module Triple_Form =
// TODO deal with normative vs symmetric vs generalized term validation
// https://www.w3.org/TR/rdf12-concepts/#section-generalizations-of-rdf

// https://www.w3.org/TR/rdf12-concepts/#section-symmetric-rdf
// https://www.w3.org/TR/rdf12-concepts/#section-generalized-rdf



















let directory_path = @"D:\Persistence\LMDB"

let GiB = 1024L * 1024L * 1024L
let bytes_to_gib (bytes: int64) = float bytes / 1024.0 / 1024.0 / 1024.0
let map_size = int64 20 * GiB
let mutable batch_size = 250_000

System.IO.Directory.CreateDirectory(directory_path)
|> ignore

let environment = new LightningEnvironment(directory_path)


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


type LMDB_Transaction_Mode =
    { begin_transaction: LightningEnvironment -> LightningTransaction
      commit: LightningTransaction -> unit }

module LMDB_Transaction_Mode =

    let read_write =
        { begin_transaction = fun environment -> environment.BeginTransaction()
          commit = fun transaction -> transaction.Commit() |> ignore }

    let read_only =
        { begin_transaction = fun environment -> environment.BeginTransaction(TransactionBeginFlags.ReadOnly)
          commit = fun _transaction -> () }

type LMDB_Transaction_Builder(environment: LightningEnvironment, mode: LMDB_Transaction_Mode) =
    member _.Current_Transaction: LightningTransaction -> LightningTransaction =
        fun (transaction: LightningTransaction) -> transaction

    member _.Return(value: 'OutputType) : LightningTransaction -> 'OutputType =
        fun (_transaction: LightningTransaction) -> value

    member _.ReturnFrom(operation: LightningTransaction -> 'OutputType) : LightningTransaction -> 'OutputType =
        operation

    member _.Bind
        (
            operation: LightningTransaction -> 'InputType,
            continuation: 'InputType -> LightningTransaction -> 'OutputType
        ) : LightningTransaction -> 'OutputType =

        fun (transaction: LightningTransaction) ->
            let value: 'InputType = operation transaction
            let next_operation: LightningTransaction -> 'OutputType = continuation value
            next_operation transaction

    member _.Delay(generator: unit -> LightningTransaction -> 'OutputType) : LightningTransaction -> 'OutputType =
        fun (transaction: LightningTransaction) ->
            let operation: LightningTransaction -> 'OutputType = generator ()
            operation transaction

    member _.Run(operation: LightningTransaction -> 'OutputType) : 'OutputType =
        use transaction: LightningTransaction = mode.begin_transaction environment

        let result: 'OutputType = operation transaction

        mode.commit transaction

        result

let lmdb_read_write =
    LMDB_Transaction_Builder(environment, LMDB_Transaction_Mode.read_write)

let lmdb_read_only =
    LMDB_Transaction_Builder(environment, LMDB_Transaction_Mode.read_only)

module MDBResultCode =

    let succeeded (result_code: MDBResultCode) = result_code = MDBResultCode.Success

    let failed (result_code: MDBResultCode) = result_code <> MDBResultCode.Success

    let fail_if_not_success (operation_name: string) (result_code: MDBResultCode) =
        if result_code <> MDBResultCode.Success then
            failwith $"{operation_name} failed with MDBResultCode: {result_code}"



type MDBValue with
    member this.to_byte_array = this.AsSpan().ToArray()


type Lightning_Memory_Map =
    {

      name: string
      handle: LightningDatabase

     }

module Lightning_Memory_Map =
    let private key'value (name: string) (flags: DatabaseOpenFlags) =
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

    let String_Digest'Lexical_Form_ID =
        key'value "String_Digest'Lexical_Form_ID" DatabaseOpenFlags.Create

    let Lexical_Form_ID'String_Bytes =
        key'value "Lexical_Form_ID'String_Bytes" DatabaseOpenFlags.Create

    let Term_ID'Term = key'value "Term_ID'Term" DatabaseOpenFlags.Create
    let Term_Case'Term_ID = key'value "Term_Case'Term_ID" DatabaseOpenFlags.Create
    let Term_ID'Triple_ID = key'value "Term_ID'Triple_ID" DatabaseOpenFlags.Create
    let Triple_ID'Term_ID = key'value "Triple_ID'Term_ID" DatabaseOpenFlags.Create
    let Triple_ID'Triple = key'value "Triple_ID'Triple" DatabaseOpenFlags.Create
    let Triple'Triple_ID = key'value "Triple'Triple_ID" DatabaseOpenFlags.Create
    let ID_Kind'Next_ID = key'value "ID_Kind'Next_ID" DatabaseOpenFlags.Create
    let SPO = key'value "SPO" DatabaseOpenFlags.Create
    let SOP = key'value "SOP" DatabaseOpenFlags.Create
    let PSO = key'value "PSO" DatabaseOpenFlags.Create
    let POS = key'value "POS" DatabaseOpenFlags.Create
    let OSP = key'value "OSP" DatabaseOpenFlags.Create
    let OPS = key'value "OPS" DatabaseOpenFlags.Create
    let TG'Presence = key'value "TG'Presence" DatabaseOpenFlags.Create
    let GT'Presence = key'value "GT'Presence" DatabaseOpenFlags.Create

    let GVertex'InEdges =
        key'value
            "GVertex'InEdges"
            (DatabaseOpenFlags.Create
             ||| DatabaseOpenFlags.DuplicatesSort
             ||| DatabaseOpenFlags.DuplicatesFixed)

    let GVertex'OutEdges =
        key'value
            "GVertex'OutEdges"
            (DatabaseOpenFlags.Create
             ||| DatabaseOpenFlags.DuplicatesSort
             ||| DatabaseOpenFlags.DuplicatesFixed)










































type String with
    member this.to_byte_array = Encoding.UTF8.GetBytes(this)

module String =
    let from_byte_array (bytes: byte array) = Encoding.UTF8.GetString bytes


type String_Digest with
    static member from_string(input: string) =
        Blake3
            .Hasher
            .Hash(input.to_byte_array)
            .AsSpan()
            .ToArray()
        |> StringDigest

    member this.to_byte_array =
        let (StringDigest bytes) = this
        bytes

type String with
    member this.digest = String_Digest.from_string this

type UInt64 with

    member this.to_byte_array =
        let bytes = BitConverter.GetBytes(this)


        if BitConverter.IsLittleEndian then
            Array.Reverse(bytes)

        bytes



module UInt64 =
    let from_id (id: ID) =

        let copy = Array.copy id.to_byte_array

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

    let from_mdb_value (mdb_value: MDBValue) =

        let copy = Array.copy mdb_value.to_byte_array

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

type MDBValue with
    member this.to_uint64 = UInt64.from_mdb_value this

type ID with
    member this.to_uint64 = UInt64.from_id this


type Lexical_Form_ID with
    static member from_uint64(input: uint64) = LexicalFormID input.to_byte_array
    static member from_mdb_value(input: MDBValue) = LexicalFormID input.to_byte_array
    static member from_byte_array(input: byte array) = LexicalFormID input

type Term_ID with
    static member from_uint64(input: uint64) = TermID input.to_byte_array
    static member from_mdb_value(input: MDBValue) = TermID input.to_byte_array
    static member from_byte_array(input: byte array) = TermID input

type Triple_ID with
    static member from_uint64(input: uint64) = TripleID input.to_byte_array
    static member from_mdb_value(input: MDBValue) = TripleID input.to_byte_array
    static member from_byte_array(input: byte array) = TripleID input

module ID =
    let initial = 0UL

    let kind_key (id: ID) =
        match id with
        | ID.FromLexicalFormID _ -> "Lexical_Form_ID"
        | ID.FromTermID _ -> "Term_ID"
        | ID.FromTripleID _ -> "Triple_ID"
        |> Encoding.UTF8.GetBytes

    let next_by_id (id: ID) (transaction: LightningTransaction) =
        let key = kind_key id

        let current =
            match transaction.Get(Lightning_Memory_Map.ID_Kind'Next_ID.handle, key) with
            | struct (MDBResultCode.Success, _, next_id_value) -> next_id_value.to_uint64

            | struct (MDBResultCode.NotFound, _, _) -> initial

            | struct (result_code, _, _) -> failwith $"Get next ID failed: {result_code}"

        transaction.Put(Lightning_Memory_Map.ID_Kind'Next_ID.handle, key, (current + 1UL).to_byte_array)
        |> MDBResultCode.fail_if_not_success "Put next ID"

        current

    let next_lexical_form_id (transaction: LightningTransaction) =
        let id =
            Lexical_Form_ID.from_uint64 initial
            |> ID.FromLexicalFormID

        next_by_id id transaction

    let next_term_id (transaction: LightningTransaction) =
        let id = Term_ID.from_uint64 initial |> ID.FromTermID
        next_by_id id transaction



module Lexical_Form_ID =

    let to_uint64 (LexicalFormID bytes) =

        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

    let to_byte_array (LexicalFormID bytes) = bytes

module Term_ID =

    let to_uint64 (TermID bytes) =

        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

    let to_byte_array (TermID bytes) = bytes

module Triple_ID =

    let to_uint64 (TripleID bytes) =

        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

    let to_byte_array (TripleID bytes) = bytes

type Lexical_Form_ID_Formatter() =
    interface IMessagePackFormatter<Lexical_Form_ID> with

        member _.Serialize
            (
                writer: byref<MessagePackWriter>,
                value: Lexical_Form_ID,
                options: MessagePackSerializerOptions
            ) =
            writer.Write(Lexical_Form_ID.to_byte_array value)

        member _.Deserialize(reader: byref<MessagePackReader>, options: MessagePackSerializerOptions) =
            let nullable_sequence = reader.ReadBytes()

            if nullable_sequence.HasValue then
                nullable_sequence.Value.ToArray()
                |> Lexical_Form_ID.from_byte_array
            else
                failwith "Expected bytes for Lexical_Form_ID."

type Term_ID_Formatter() =
    interface IMessagePackFormatter<Term_ID> with

        member _.Serialize(writer: byref<MessagePackWriter>, value: Term_ID, options: MessagePackSerializerOptions) =
            writer.Write(Term_ID.to_byte_array value)

        member _.Deserialize(reader: byref<MessagePackReader>, options: MessagePackSerializerOptions) =
            let nullable_sequence = reader.ReadBytes()

            if nullable_sequence.HasValue then
                nullable_sequence.Value.ToArray()
                |> Term_ID.from_byte_array
            else
                failwith "Expected bytes for Term_ID."
//Lexical_Form_ID.from_byte_array [||]


module Message_Pack =

    let options =
        MessagePackSerializerOptions.Standard.WithResolver(
            CompositeResolver.Create(
                [| Lexical_Form_ID_Formatter() :> IMessagePackFormatter
                   Term_ID_Formatter() :> IMessagePackFormatter |],
                [| FSharpResolver.Instance
                   StandardResolver.Instance :> IFormatterResolver |]
            )
        )

    let serialize<'ObjectType> (message_pack_object: 'ObjectType) =
        MessagePackSerializer.Serialize(message_pack_object, options)

    let deserialize<'ObjectType> (message_pack_object_bytes: byte array) =
        MessagePackSerializer.Deserialize<'ObjectType>(message_pack_object_bytes, options)




module Lexical_Form =
    let from_string (string_value: string) (transaction: LightningTransaction) =

        match
            transaction.Get
                (
                    Lightning_Memory_Map.String_Digest'Lexical_Form_ID.handle,
                    string_value.digest.to_byte_array
                )
            with
        | struct (MDBResultCode.Success, _, mdb_lexical_form_id) ->
            { string_value = string_value
              lexical_form_id = Lexical_Form_ID.from_mdb_value mdb_lexical_form_id }

        | struct (MDBResultCode.NotFound, _, _) ->
            let lexical_form_id =
                ID.next_lexical_form_id transaction
                |> Lexical_Form_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Lexical_Form_ID'String_Bytes.handle,
                lexical_form_id |> Lexical_Form_ID.to_byte_array,
                string_value.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Lexical_Form_ID -> String Bytes"

            transaction.Put(
                Lightning_Memory_Map.String_Digest'Lexical_Form_ID.handle,
                string_value.digest.to_byte_array,
                lexical_form_id |> Lexical_Form_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put String Digest -> Lexical_Form_ID"

            { string_value = string_value
              lexical_form_id = lexical_form_id }

        | struct (result_code, _, _) ->
            failwith $"Get Digest -> Lexical_Form_ID failed with MDBResultCode: {result_code}"



type String with
    member this.to_lexical_form = Lexical_Form.from_string this




module Get =

    let All_Keys_by_Memory_Map (memory_map: Lightning_Memory_Map) (transaction: LightningTransaction) =

        use cursor = transaction.CreateCursor(memory_map.handle)

        cursor.AsEnumerable()
        |> Seq.map (fun struct (mdb_key, _) -> mdb_key.to_byte_array)
        |> Seq.toArray

    let Fold_Keys_by_Memory_Map
        (memory_map: Lightning_Memory_Map)
        (folder: 'State -> byte array -> 'State)
        (initial_state: 'State)
        =
        fun (transaction: LightningTransaction) ->

            use cursor = transaction.CreateCursor(memory_map.handle)

            cursor.AsEnumerable()
            |> Seq.fold (fun state struct (mdb_key, _) -> folder state mdb_key.to_byte_array) initial_state

    let String_by_Lexical_Form_ID (lexical_form_id: Lexical_Form_ID) (transaction: LightningTransaction) =

        match
            transaction.Get
                (
                    Lightning_Memory_Map.Lexical_Form_ID'String_Bytes.handle,
                    lexical_form_id |> Lexical_Form_ID.to_byte_array
                )
            with
        | struct (MDBResultCode.Success, _, value) -> value.to_byte_array |> String.from_byte_array

        | struct (MDBResultCode.NotFound, _, _) -> failwith $"No string found for lexical form ID: {lexical_form_id}"

        | struct (result_code, _, _) ->
            failwith $"Get Lexical_Form_ID -> String failed with MDBResultCode: {result_code}"

    let Triple_by_Triple_ID (triple_id: Triple_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Triple_ID'Triple.handle, triple_id |> Triple_ID.to_byte_array) with
        | struct (MDBResultCode.Success, _, value) ->
            value.to_byte_array
            |> Message_Pack.deserialize<Triple>

        | struct (MDBResultCode.NotFound, _, _) -> failwith $"No triple found for triple ID: {triple_id}"

        | struct (result_code, _, _) -> failwith $"Get Triple_ID -> Triple failed with MDBResultCode: {result_code}"



module Skolem_IRI =


    let new_uuidv7 () = Uuid.NewSequential().ToString("N")

    let mint (transaction: LightningTransaction) =

        let well_known = Lexical_Form.from_string well_known_prefix transaction
        let uuidv7 = Lexical_Form.from_string (new_uuidv7 ()) transaction

        { well_known_id = well_known.lexical_form_id
          uuidv7_id = uuidv7.lexical_form_id }

    let nq (skolem_iri: Skolem_IRI) =
        lmdb_read_only {

            let! well_known_base = Get.String_by_Lexical_Form_ID skolem_iri.well_known_id
            let! uuidv7 = Get.String_by_Lexical_Form_ID skolem_iri.uuidv7_id
            return $"<{well_known_base}{uuidv7}>"

        }









































module RDF_Term =
    let is_named_resource (rdf_term: RDF_Term) =
        match rdf_term with

        | RDF_Term.FromNamespacedIRI (term_id, term) -> true
        | RDF_Term.FromAtomicIRI (term_id, term) -> true
        | RDF_Term.FromSkolemIRI (term_id, term) -> false
        | RDF_Term.FromSimpleLiteral (term_id, term) -> false
        | RDF_Term.FromDatatypedLiteral (term_id, term) -> false
        | RDF_Term.FromLanguageString (term_id, term) -> false
        | RDF_Term.FromRegionString (term_id, term) -> false
        | RDF_Term.FromDirectedLanguageString (term_id, term) -> false
        | RDF_Term.FromDirectedRegionString (term_id, term) -> false
        | RDF_Term.FromTripleTerm (term_id, triple_id) -> false
        | RDF_Term.FromGraphName (term_id, graph_term) ->
            match graph_term with
            | Graph_Name.DefaultGraph -> false
            | Graph_Name.FromNamespacedIRI namespaced_iri -> true
            | Graph_Name.FromAtomicIRI atomic_iri -> true
            | Graph_Name.FromSkolemIRI skolem_iri -> false

    let term_id (rdf_term: RDF_Term) =
        match rdf_term with

        | RDF_Term.FromNamespacedIRI (term_id, term) -> term_id
        | RDF_Term.FromAtomicIRI (term_id, term) -> term_id
        | RDF_Term.FromSkolemIRI (term_id, term) -> term_id
        | RDF_Term.FromSimpleLiteral (term_id, term) -> term_id
        | RDF_Term.FromDatatypedLiteral (term_id, term) -> term_id
        | RDF_Term.FromLanguageString (term_id, term) -> term_id
        | RDF_Term.FromRegionString (term_id, term) -> term_id
        | RDF_Term.FromDirectedLanguageString (term_id, term) -> term_id
        | RDF_Term.FromDirectedRegionString (term_id, term) -> term_id
        | RDF_Term.FromTripleTerm (term_id, triple_id) -> term_id
        | RDF_Term.FromGraphName (term_id, term) -> term_id


    let from_id (term_id: Term_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term_ID'Term.handle, term_id |> Term_ID.to_byte_array) with
        | struct (MDBResultCode.Success, _, mdb_term) -> Message_Pack.deserialize<RDF_Term> mdb_term.to_byte_array
        | struct (MDBResultCode.NotFound, _, _) ->
            failwith
                $"Get Term ID -> Term  with term id {term_id} not found in memory map {Lightning_Memory_Map.Term_ID'Term.name}"
        | struct (result_code, _, _) -> failwith $"Get Term ID -> Term  failed with MDBResultCode: {result_code}"

    let try_from_id (term_id: Term_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term_ID'Term.handle, term_id |> Term_ID.to_byte_array) with
        | struct (MDBResultCode.Success, _, mdb_term) -> Some(Message_Pack.deserialize<RDF_Term> mdb_term.to_byte_array)
        | struct (MDBResultCode.NotFound, _, _) -> None
        | struct (result_code, _, _) -> failwith $"Get Term ID -> Term  failed with MDBResultCode: {result_code}"

    let private intern_term_case
        (term_case: 'TermCase)
        (make_term: Term_ID -> 'TermCase -> RDF_Term)
        (transaction: LightningTransaction)
        =
        let term_case_encoding = Message_Pack.serialize term_case

        match transaction.Get(Lightning_Memory_Map.Term_Case'Term_ID.handle, term_case_encoding) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id

            make_term term_id term_case

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64

            let term = make_term term_id term_case

            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term_Case'Term_ID.handle,
                term_case_encoding,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term Case -> Term ID"

            term

        | struct (result_code, _, _) -> failwith $"Get Term Case -> Term ID failed with MDBResultCode: {result_code}"

    let private make_graph_name term_id term_case =
        RDF_Term.FromGraphName(term_id, term_case)

    let private make_namespaced_iri term_id term_case =
        RDF_Term.FromNamespacedIRI(term_id, term_case)

    let private make_atomic_iri term_id term_case =
        RDF_Term.FromAtomicIRI(term_id, term_case)

    let private make_skolem_iri term_id term_case =
        RDF_Term.FromSkolemIRI(term_id, term_case)

    let private make_simple_literal term_id term_case =
        RDF_Term.FromSimpleLiteral(term_id, term_case)

    let private make_datatyped_literal term_id term_case =
        RDF_Term.FromDatatypedLiteral(term_id, term_case)

    let private make_language_string term_id term_case =
        RDF_Term.FromLanguageString(term_id, term_case)

    let private make_region_string term_id term_case =
        RDF_Term.FromRegionString(term_id, term_case)

    let private make_directed_language_string term_id term_case =
        RDF_Term.FromDirectedLanguageString(term_id, term_case)

    let private make_directed_region_string term_id term_case =
        RDF_Term.FromDirectedRegionString(term_id, term_case)

    let private make_triple_id term_id term_case =
        RDF_Term.FromTripleTerm(term_id, term_case)


    let from_graph_name term_case =
        intern_term_case term_case make_graph_name

    let from_namespaced_iri term_case =
        intern_term_case term_case make_namespaced_iri

    let from_atomic_iri term_case =
        intern_term_case term_case make_atomic_iri

    let from_skolem_iri term_case =
        intern_term_case term_case make_skolem_iri

    let from_simple_literal term_case =
        intern_term_case term_case make_simple_literal

    let from_datatyped_literal term_case =
        intern_term_case term_case make_datatyped_literal

    let from_language_string term_case =
        intern_term_case term_case make_language_string

    let from_region_string term_case =
        intern_term_case term_case make_region_string

    let from_directed_language_string term_case =
        intern_term_case term_case make_directed_language_string

    let from_directed_region_string term_case =
        intern_term_case term_case make_directed_region_string

    let from_triple_id term_case =
        intern_term_case term_case make_triple_id


module Namespaced_IRI =
    let nq (namespaced_iri: Namespaced_IRI) =

        lmdb_read_only {

            let! namespace_name = Get.String_by_Lexical_Form_ID namespaced_iri.namespace_name_id
            let! local_name = Get.String_by_Lexical_Form_ID namespaced_iri.local_name_id
            return $"<{namespace_name}{local_name}>"

        }

module Atomic_IRI =
    let nq (atomic_iri: Atomic_IRI) =
        lmdb_read_only {

            let! lexical_form = Get.String_by_Lexical_Form_ID atomic_iri.lexical_form_id
            return $"<{lexical_form}>"

        }

module Simple_Literal =
    let nq (simple_literal: Simple_Literal) =
        lmdb_read_only {

            let! lexical_form = Get.String_by_Lexical_Form_ID simple_literal.lexical_form_id
            return $"\"{lexical_form}\"^^<http://www.w3.org/2001/XMLSchema#string>"

        }

module Datatyped_Literal =
    let nq (datatyped_literal: Datatyped_Literal) =
        lmdb_read_only {

            let! lexical_form = Get.String_by_Lexical_Form_ID datatyped_literal.lexical_form_id
            let! datatype_term = RDF_Term.from_id datatyped_literal.datatype_id

            let datatype_nq =
                match datatype_term with
                | RDF_Term.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term
                | RDF_Term.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term
                | RDF_Term.FromSkolemIRI (term_id, term) -> Skolem_IRI.nq term
                | _ -> failwith $"datatyped literal {datatyped_literal} must have iri datatype"


            return $"\"{lexical_form}\"^^{datatype_nq}"

        }

module Language_String =
    let nq (lang_string: Language_String) =
        lmdb_read_only {

            let! lexical_form = Get.String_by_Lexical_Form_ID lang_string.lexical_form_id


            return $"\"{lexical_form}\"@{lang_string.language.ToString()}"

        }

    module Directed =
        let nq (dirlang_string: Directed_Language_String) =
            lmdb_read_only {

                let! lexical_form = Get.String_by_Lexical_Form_ID dirlang_string.lexical_form_id


                return $"\"{lexical_form}\"@{dirlang_string.language.ToString()}-{dirlang_string.direction.ToString()}"

            }

module Region_String =
    let nq (lang_string: Region_String) =
        lmdb_read_only {

            let! lexical_form = Get.String_by_Lexical_Form_ID lang_string.lexical_form_id


            return $"\"{lexical_form}\"@{lang_string.language.ToString()}-{lang_string.region.ToString()}"

        }

    module Directed =
        let nq (dirreg_string: Directed_Region_String) =
            lmdb_read_only {

                let! lexical_form = Get.String_by_Lexical_Form_ID dirreg_string.lexical_form_id


                return
                    $"\"{lexical_form}\"@{dirreg_string.language.ToString()}-{dirreg_string.region.ToString()}-{dirreg_string.direction.ToString()}"

            }

module RDF_Subject =
    let from_term (subject_term: RDF_Term) =
        match subject_term with
        | RDF_Term.FromNamespacedIRI (term_id, term) -> RDF_Subject.FromNamespacedIRI(term_id, term)
        | RDF_Term.FromAtomicIRI (term_id, term) -> RDF_Subject.FromAtomicIRI(term_id, term)
        | RDF_Term.FromSkolemIRI (term_id, term) -> RDF_Subject.FromSkolemIRI(term_id, term)
        | _ -> failwith $"{subject_term} is not a normative subject for an rdf triple "

    let term_id (subject: RDF_Subject) =
        match subject with
        | RDF_Subject.FromNamespacedIRI (term_id, term) -> term_id
        | RDF_Subject.FromAtomicIRI (term_id, term) -> term_id
        | RDF_Subject.FromSkolemIRI (term_id, term) -> term_id

    let nq (subject: RDF_Subject) =
        match subject with
        | RDF_Subject.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term
        | RDF_Subject.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term
        | RDF_Subject.FromSkolemIRI (term_id, term) -> Skolem_IRI.nq term

module RDF_Predicate =
    let from_term (predicate_term: RDF_Term) =
        match predicate_term with

        | RDF_Term.FromNamespacedIRI (term_id, term) -> RDF_Predicate.FromNamespacedIRI(term_id, term)
        | RDF_Term.FromAtomicIRI (term_id, term) -> RDF_Predicate.FromAtomicIRI(term_id, term)
        | _ -> failwith $"{predicate_term} is not a normative predicate for an rdf triple "

    let term_id (predicate: RDF_Predicate) =
        match predicate with
        | RDF_Predicate.FromNamespacedIRI (term_id, term) -> term_id
        | RDF_Predicate.FromAtomicIRI (term_id, term) -> term_id

    let nq (predicate: RDF_Predicate) =
        match predicate with
        | RDF_Predicate.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term
        | RDF_Predicate.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term

module RDF_Object =
    let from_term (object_term: RDF_Term) =
        match object_term with
        | RDF_Term.FromNamespacedIRI (term_id, term) -> RDF_Object.FromNamespacedIRI(term_id, term)
        | RDF_Term.FromAtomicIRI (term_id, term) -> RDF_Object.FromAtomicIRI(term_id, term)
        | RDF_Term.FromSkolemIRI (term_id, term) -> RDF_Object.FromSkolemIRI(term_id, term)
        | RDF_Term.FromSimpleLiteral (term_id, term) -> RDF_Object.FromSimpleLiteral(term_id, term)
        | RDF_Term.FromDatatypedLiteral (term_id, term) -> RDF_Object.FromDatatypedLiteral(term_id, term)
        | RDF_Term.FromLanguageString (term_id, term) -> RDF_Object.FromLanguageString(term_id, term)
        | RDF_Term.FromRegionString (term_id, term) -> RDF_Object.FromRegionString(term_id, term)
        | RDF_Term.FromDirectedLanguageString (term_id, term) -> RDF_Object.FromDirectedLanguageString(term_id, term)
        | RDF_Term.FromDirectedRegionString (term_id, term) -> RDF_Object.FromDirectedRegionString(term_id, term)
        | RDF_Term.FromTripleTerm (term_id, triple_id) -> RDF_Object.FromTripleTerm(term_id, triple_id)
        | _ -> failwith $"{object_term} is not a normative object for an rdf triple "

    let term_id (object: RDF_Object) =
        match object with
        | RDF_Object.FromNamespacedIRI (term_id, term) -> term_id
        | RDF_Object.FromAtomicIRI (term_id, term) -> term_id
        | RDF_Object.FromSkolemIRI (term_id, term) -> term_id
        | RDF_Object.FromSimpleLiteral (term_id, term) -> term_id
        | RDF_Object.FromDatatypedLiteral (term_id, term) -> term_id
        | RDF_Object.FromLanguageString (term_id, term) -> term_id
        | RDF_Object.FromRegionString (term_id, term) -> term_id
        | RDF_Object.FromDirectedLanguageString (term_id, term) -> term_id
        | RDF_Object.FromDirectedRegionString (term_id, term) -> term_id
        | RDF_Object.FromTripleTerm (term_id, triple_id) -> term_id

    let rec nq (object: RDF_Object) =
        match object with
        | RDF_Object.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term
        | RDF_Object.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term
        | RDF_Object.FromSkolemIRI (term_id, term) -> Skolem_IRI.nq term
        | RDF_Object.FromSimpleLiteral (term_id, term) -> Simple_Literal.nq term
        | RDF_Object.FromDatatypedLiteral (term_id, term) -> Datatyped_Literal.nq term
        | RDF_Object.FromLanguageString (term_id, term) -> Language_String.nq term
        | RDF_Object.FromRegionString (term_id, term) -> Region_String.nq term
        | RDF_Object.FromDirectedLanguageString (term_id, term) -> Language_String.Directed.nq term
        | RDF_Object.FromDirectedRegionString (term_id, term) -> Region_String.Directed.nq term
        | RDF_Object.FromTripleTerm (term_id, triple_id) ->
            let triple = lmdb_read_only { return! Get.Triple_by_Triple_ID triple_id }
            $"<<({RDF_Subject.nq triple.subject} {RDF_Predicate.nq triple.predicate} {nq triple.object})>>"


// TODO deal with actually asserting triples and triple permutations.
// TODO datatypes via unit of measure extension


type Triple_Slot =
    | SubjectSlot
    | PredicateSlot
    | ObjectSlot

type Triple_Permutation =
    { memory_map: Lightning_Memory_Map
      order: Triple_Slot array }

module Triple_Permutation =

    let spo =
        { memory_map = Lightning_Memory_Map.SPO
          order =
            [| SubjectSlot
               PredicateSlot
               ObjectSlot |] }

    let sop =
        { memory_map = Lightning_Memory_Map.SOP
          order =
            [| SubjectSlot
               ObjectSlot
               PredicateSlot |] }

    let pso =
        { memory_map = Lightning_Memory_Map.PSO
          order =
            [| PredicateSlot
               SubjectSlot
               ObjectSlot |] }

    let pos =
        { memory_map = Lightning_Memory_Map.POS
          order =
            [| PredicateSlot
               ObjectSlot
               SubjectSlot |] }

    let osp =
        { memory_map = Lightning_Memory_Map.OSP
          order =
            [| ObjectSlot
               SubjectSlot
               PredicateSlot |] }

    let ops =
        { memory_map = Lightning_Memory_Map.OPS
          order =
            [| ObjectSlot
               PredicateSlot
               SubjectSlot |] }

    let profile = [| spo; sop; pso; pos; osp; ops |]

module Permutation_Key =

    let slot_value_from_triple (slot: Triple_Slot) (triple: Triple) =
        match slot with
        | SubjectSlot ->
            triple.subject
            |> RDF_Subject.term_id
            |> Term_ID.to_byte_array
        | PredicateSlot ->
            triple.predicate
            |> RDF_Predicate.term_id
            |> Term_ID.to_byte_array
        | ObjectSlot ->
            triple.object
            |> RDF_Object.term_id
            |> Term_ID.to_byte_array

    let from_triple (permutation: Triple_Permutation) (triple: Triple) =
        permutation.order
        |> Array.collect (fun slot -> slot_value_from_triple slot triple)

    let chunks_of_8 (bytes: byte array) =
        if bytes.Length <> 24 then
            failwithf "Permutation key must be 24 bytes, but was %i bytes." bytes.Length

        [| bytes[0..7]
           bytes[8..15]
           bytes[16..23] |]

    let to_triple (permutation: Triple_Permutation) (permutation_key: byte array) (transaction: LightningTransaction) =
        let chunks = chunks_of_8 permutation_key

        let mutable subject = None
        let mutable predicate = None
        let mutable object = None

        for slot_index = 0 to 2 do
            let term_id = Term_ID.from_byte_array chunks[slot_index]
            let term = RDF_Term.from_id term_id transaction

            match permutation.order[slot_index] with
            | SubjectSlot -> subject <- Some(RDF_Subject.from_term term)
            | PredicateSlot -> predicate <- Some(RDF_Predicate.from_term term)
            | ObjectSlot -> object <- Some(RDF_Object.from_term term)

        { subject = subject.Value
          predicate = predicate.Value
          object = object.Value }

    module Prefix =
        let concat (arrays: byte array array) = arrays |> Array.collect id

        let starts_with (prefix: byte array) (bytes: byte array) =
            bytes.Length >= prefix.Length
            && prefix
               |> Array.mapi (fun i b -> bytes[i] = b)
               |> Array.forall id



module Presence =

    let asserted = [| 1uy |]

    let retracted = [| 0uy |]

    let is_asserted (bytes: byte array) = bytes.Length = 1 && bytes[0] = 1uy

module Triple =
    let id_for_triple triple =
        Permutation_Key.from_triple Triple_Permutation.spo triple
        |> Triple_ID.from_byte_array

    let from_terms
        (subject_term: RDF_Term)
        (predicate_term: RDF_Term)
        (object_term: RDF_Term)

        =
        let curSubject = RDF_Subject.from_term subject_term

        let curPredicate = RDF_Predicate.from_term predicate_term

        let curObject = RDF_Object.from_term object_term

        { subject = curSubject
          predicate = curPredicate
          object = curObject }

    let nq (triple: Triple) =
        $"{RDF_Subject.nq triple.subject} {RDF_Predicate.nq triple.predicate} {RDF_Object.nq triple.object}"

module Graph_Name =
    let default_graph_term =
        lmdb_read_write { return! RDF_Term.from_graph_name Graph_Name.DefaultGraph }

    let from_term (graph_term: RDF_Term) =
        match graph_term with
        | RDF_Term.FromNamespacedIRI (term_id, term) -> term_id, Graph_Name.FromNamespacedIRI(term)
        | RDF_Term.FromAtomicIRI (term_id, term) -> term_id, Graph_Name.FromAtomicIRI(term)
        | RDF_Term.FromSkolemIRI (term_id, term) -> term_id, Graph_Name.FromSkolemIRI(term)
        | RDF_Term.FromGraphName (term_id, Graph_Name.DefaultGraph) -> term_id, Graph_Name.DefaultGraph
        | RDF_Term.FromGraphName (term_id, Graph_Name.FromNamespacedIRI term) ->
            term_id, Graph_Name.FromNamespacedIRI term
        | RDF_Term.FromGraphName (term_id, Graph_Name.FromAtomicIRI term) -> term_id, Graph_Name.FromAtomicIRI term
        | RDF_Term.FromGraphName (term_id, Graph_Name.FromSkolemIRI term) -> term_id, Graph_Name.FromSkolemIRI term
        | _ -> failwith $"{graph_term} is not a normative graph for an rdf triple "

    let nq (graph_name: Graph_Name) =
        match graph_name with
        | Graph_Name.DefaultGraph -> String.Empty
        | Graph_Name.FromNamespacedIRI term -> Namespaced_IRI.nq term
        | Graph_Name.FromAtomicIRI term -> Atomic_IRI.nq term
        | Graph_Name.FromSkolemIRI term -> Skolem_IRI.nq term

module Quad_Key =

    let tg (triple_id: Triple_ID) (graph_name_id: Term_ID) =
        Array.concat [| Triple_ID.to_byte_array triple_id
                        Term_ID.to_byte_array graph_name_id |]

    let gt (graph_name_id: Term_ID) (triple_id: Triple_ID) =
        Array.concat [| Term_ID.to_byte_array graph_name_id
                        Triple_ID.to_byte_array triple_id |]

    let from_tg_key (key: byte array) =
        if key.Length <> 16 then
            failwith $"TG key must be 16 bytes, but was {key.Length} bytes."

        let triple_id = key[0..7] |> Triple_ID.from_byte_array

        let graph_name_id = key[8..15] |> Term_ID.from_byte_array

        triple_id, graph_name_id

    let from_gt_key (key: byte array) =
        if key.Length <> 16 then
            failwith $"GT key must be 16 bytes, but was {key.Length} bytes."

        let graph_name_id = key[0..7] |> Term_ID.from_byte_array

        let triple_id = key[8..15] |> Triple_ID.from_byte_array

        graph_name_id, triple_id



























module rdf =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/1999/02/22-rdf-syntax-ns#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    /// The class of containers of alternatives.
    let Alt = _prefix "Alt"


    /// The class of unordered containers.
    let Bag = _prefix "Bag"


    /// A class representing a compound literal.
    let CompoundLiteral = _prefix "CompoundLiteral"


    /// The datatype of RDF literals storing fragments of HTML content
    let HTML = _prefix "HTML"


    /// The datatype of RDF literals storing JSON content.
    let JSON = _prefix "JSON"


    /// The class of RDF Lists.
    let List = _prefix "List"


    /// The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    let PlainLiteral = _prefix "PlainLiteral"


    /// The class of RDF properties.
    let Property = _prefix "Property"


    /// The class of ordered containers.
    let Seq = _prefix "Seq"


    /// The class of RDF statements.
    let Statement = _prefix "Statement"


    /// The datatype of XML literal values.
    let XMLLiteral = _prefix "XMLLiteral"


    /// The base direction component of a CompoundLiteral.
    let direction = _prefix "direction"


    /// The first item in the subject RDF list.
    let first = _prefix "first"


    /// The datatype of language-tagged string values
    let langString = _prefix "langString"


    /// The language component of a CompoundLiteral.
    let language = _prefix "language"


    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    let nil = _prefix "nil"


    /// The object of the subject RDF statement.
    let object = _prefix "object"


    /// The predicate of the subject RDF statement.
    let predicate = _prefix "predicate"


    /// The rest of the subject RDF list after the first item.
    let rest = _prefix "rest"


    /// The subject of the subject RDF statement.
    let subject = _prefix "subject"


    /// The subject is an instance of a class.
    let ``type`` = _prefix "type"


    /// Idiomatic property used for structured values.
    let value = _prefix "value"

let a = rdf.``type``





module rdfs =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2000/01/rdf-schema#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    /// The class of classes.
    let Class = _prefix "Class"


    /// The class of RDF containers.
    let Container = _prefix "Container"


    /// The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.
    let ContainerMembershipProperty = _prefix "ContainerMembershipProperty"


    /// The class of RDF datatypes.
    let Datatype = _prefix "Datatype"


    /// The class of literal values, eg. textual strings and integers.
    let Literal = _prefix "Literal"


    /// The class resource, everything.
    let Resource = _prefix "Resource"


    /// A description of the subject resource.
    let comment = _prefix "comment"


    /// A domain of the subject property.
    let domain = _prefix "domain"


    /// The defininition of the subject resource.
    let isDefinedBy = _prefix "isDefinedBy"


    /// A human-readable name for the subject.
    let label = _prefix "label"


    /// A member of the subject resource.
    let ``member`` = _prefix "member"


    /// A range of the subject property.
    let range = _prefix "range"


    /// Further information about the subject resource.
    let seeAlso = _prefix "seeAlso"


    /// The subject is a subclass of a class.
    let subClassOf = _prefix "subClassOf"


    /// The subject is a subproperty of a property.
    let subPropertyOf = _prefix "subPropertyOf"


module owl =

    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2002/07/owl#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    /// The class of collections of pairwise different individuals.
    let AllDifferent = _prefix "AllDifferent"


    /// The class of collections of pairwise disjoint classes.
    let AllDisjointClasses = _prefix "AllDisjointClasses"


    /// The class of collections of pairwise disjoint properties.
    let AllDisjointProperties = _prefix "AllDisjointProperties"


    /// The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    let Annotation = _prefix "Annotation"


    /// The class of annotation properties.
    let AnnotationProperty = _prefix "AnnotationProperty"


    /// The class of asymmetric properties.
    let AsymmetricProperty = _prefix "AsymmetricProperty"


    /// The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    let Axiom = _prefix "Axiom"


    /// The class of OWL classes.
    let Class = _prefix "Class"


    /// The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    let DataRange = _prefix "DataRange"


    /// The class of data properties.
    let DatatypeProperty = _prefix "DatatypeProperty"


    /// The class of deprecated classes.
    let DeprecatedClass = _prefix "DeprecatedClass"


    /// The class of deprecated properties.
    let DeprecatedProperty = _prefix "DeprecatedProperty"


    /// The class of functional properties.
    let FunctionalProperty = _prefix "FunctionalProperty"


    /// The class of inverse-functional properties.
    let InverseFunctionalProperty = _prefix "InverseFunctionalProperty"


    /// The class of irreflexive properties.
    let IrreflexiveProperty = _prefix "IrreflexiveProperty"


    /// The class of named individuals.
    let NamedIndividual = _prefix "NamedIndividual"


    /// The class of negative property assertions.
    let NegativePropertyAssertion = _prefix "NegativePropertyAssertion"


    /// This is the empty class.
    let Nothing = _prefix "Nothing"


    /// The class of object properties.
    let ObjectProperty = _prefix "ObjectProperty"


    /// The class of ontologies.
    let Ontology = _prefix "Ontology"


    /// The class of ontology properties.
    let OntologyProperty = _prefix "OntologyProperty"


    /// The class of reflexive properties.
    let ReflexiveProperty = _prefix "ReflexiveProperty"


    /// The class of property restrictions.
    let Restriction = _prefix "Restriction"


    /// The class of symmetric properties.
    let SymmetricProperty = _prefix "SymmetricProperty"


    /// The class of OWL individuals.
    let Thing = _prefix "Thing"


    /// The class of transitive properties.
    let TransitiveProperty = _prefix "TransitiveProperty"


    /// The property that determines the class that a universal property restriction refers to.
    let allValuesFrom = _prefix "allValuesFrom"


    /// The property that determines the predicate of an annotated axiom or annotated annotation.
    let annotatedProperty = _prefix "annotatedProperty"


    /// The property that determines the subject of an annotated axiom or annotated annotation.
    let annotatedSource = _prefix "annotatedSource"


    /// The property that determines the object of an annotated axiom or annotated annotation.
    let annotatedTarget = _prefix "annotatedTarget"


    /// The property that determines the predicate of a negative property assertion.
    let assertionProperty = _prefix "assertionProperty"


    /// The annotation property that indicates that a given ontology is backward compatible with another ontology.
    let backwardCompatibleWith = _prefix "backwardCompatibleWith"


    /// The data property that does not relate any individual to any data value.
    let bottomDataProperty = _prefix "bottomDataProperty"


    /// The object property that does not relate any two individuals.
    let bottomObjectProperty = _prefix "bottomObjectProperty"


    /// The property that determines the cardinality of an exact cardinality restriction.
    let cardinality = _prefix "cardinality"


    /// The property that determines that a given class is the complement of another class.
    let complementOf = _prefix "complementOf"


    /// The property that determines that a given data range is the complement of another data range with respect to the data domain.
    let datatypeComplementOf = _prefix "datatypeComplementOf"


    /// The annotation property that indicates that a given entity has been deprecated.
    let deprecated = _prefix "deprecated"


    /// The property that determines that two given individuals are different.
    let differentFrom = _prefix "differentFrom"


    /// The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    let disjointUnionOf = _prefix "disjointUnionOf"


    /// The property that determines that two given classes are disjoint.
    let disjointWith = _prefix "disjointWith"


    /// The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    let distinctMembers = _prefix "distinctMembers"


    /// The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    let equivalentClass = _prefix "equivalentClass"


    /// The property that determines that two given properties are equivalent.
    let equivalentProperty = _prefix "equivalentProperty"


    /// The property that determines the collection of properties that jointly build a key.
    let hasKey = _prefix "hasKey"


    /// The property that determines the property that a self restriction refers to.
    let hasSelf = _prefix "hasSelf"


    /// The property that determines the individual that a has-value restriction refers to.
    let hasValue = _prefix "hasValue"


    /// The property that is used for importing other ontologies into a given ontology.
    let imports = _prefix "imports"


    /// The annotation property that indicates that a given ontology is incompatible with another ontology.
    let incompatibleWith = _prefix "incompatibleWith"


    /// The property that determines the collection of classes or data ranges that build an intersection.
    let intersectionOf = _prefix "intersectionOf"


    /// The property that determines that two given properties are inverse.
    let inverseOf = _prefix "inverseOf"


    /// The property that determines the cardinality of a maximum cardinality restriction.
    let maxCardinality = _prefix "maxCardinality"


    /// The property that determines the cardinality of a maximum qualified cardinality restriction.
    let maxQualifiedCardinality = _prefix "maxQualifiedCardinality"


    /// The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    let members = _prefix "members"


    /// The property that determines the cardinality of a minimum cardinality restriction.
    let minCardinality = _prefix "minCardinality"


    /// The property that determines the cardinality of a minimum qualified cardinality restriction.
    let minQualifiedCardinality = _prefix "minQualifiedCardinality"


    /// The property that determines the class that a qualified object cardinality restriction refers to.
    let onClass = _prefix "onClass"


    /// The property that determines the data range that a qualified data cardinality restriction refers to.
    let onDataRange = _prefix "onDataRange"


    /// The property that determines the datatype that a datatype restriction refers to.
    let onDatatype = _prefix "onDatatype"


    /// The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    let onProperties = _prefix "onProperties"


    /// The property that determines the property that a property restriction refers to.
    let onProperty = _prefix "onProperty"


    /// The property that determines the collection of individuals or data values that build an enumeration.
    let oneOf = _prefix "oneOf"


    /// The annotation property that indicates the predecessor ontology of a given ontology.
    let priorVersion = _prefix "priorVersion"


    /// The property that determines the n-tuple of properties that build a sub property chain of a given property.
    let propertyChainAxiom = _prefix "propertyChainAxiom"


    /// The property that determines that two given properties are disjoint.
    let propertyDisjointWith = _prefix "propertyDisjointWith"


    /// The property that determines the cardinality of an exact qualified cardinality restriction.
    let qualifiedCardinality = _prefix "qualifiedCardinality"


    /// The property that determines that two given individuals are equal.
    let sameAs = _prefix "sameAs"


    /// The property that determines the class that an existential property restriction refers to.
    let someValuesFrom = _prefix "someValuesFrom"


    /// The property that determines the subject of a negative property assertion.
    let sourceIndividual = _prefix "sourceIndividual"


    /// The property that determines the object of a negative object property assertion.
    let targetIndividual = _prefix "targetIndividual"


    /// The property that determines the value of a negative data property assertion.
    let targetValue = _prefix "targetValue"


    /// The data property that relates every individual to every data value.
    let topDataProperty = _prefix "topDataProperty"


    /// The object property that relates every two individuals.
    let topObjectProperty = _prefix "topObjectProperty"


    /// The property that determines the collection of classes or data ranges that build a union.
    let unionOf = _prefix "unionOf"


    /// The property that identifies the version IRI of an ontology.
    let versionIRI = _prefix "versionIRI"


    /// The annotation property that provides version information for an ontology or another OWL construct.
    let versionInfo = _prefix "versionInfo"


    /// The property that determines the collection of facet-value pairs that define a datatype restriction.
    let withRestrictions = _prefix "withRestrictions"





module owl_time =

    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2006/time#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.
    let DateTimeDescription = _prefix "DateTimeDescription"


    /// DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.
    let DateTimeInterval = _prefix "DateTimeInterval"


    /// The day of week
    let DayOfWeek = _prefix "DayOfWeek"


    /// Duration of a temporal extent expressed as a number scaled by a temporal unit
    let Duration = _prefix "Duration"


    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal
    let DurationDescription = _prefix "DurationDescription"



    let Friday = _prefix "Friday"


    /// Description of date and time structured with separate values for the various elements of a calendar-clock system
    let GeneralDateTimeDescription = _prefix "GeneralDateTimeDescription"


    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system.
    let GeneralDurationDescription = _prefix "GeneralDurationDescription"


    /// A temporal entity with zero extent or duration
    let Instant = _prefix "Instant"


    /// A temporal entity with an extent or duration
    let Interval = _prefix "Interval"



    let January = _prefix "January"



    let Monday = _prefix "Monday"


    /// The month of the year
    let MonthOfYear = _prefix "MonthOfYear"


    /// A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different
    let ProperInterval = _prefix "ProperInterval"



    let Saturday = _prefix "Saturday"



    let Sunday = _prefix "Sunday"


    /// A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.
    let TRS = _prefix "TRS"


    /// Time extent; duration of a time interval separate from its particular start position
    let TemporalDuration = _prefix "TemporalDuration"


    /// A temporal interval or instant.
    let TemporalEntity = _prefix "TemporalEntity"


    /// A position on a time-line
    let TemporalPosition = _prefix "TemporalPosition"


    /// A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.
    let TemporalUnit = _prefix "TemporalUnit"



    let Thursday = _prefix "Thursday"


    /// A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system.
    let TimePosition = _prefix "TimePosition"


    /// A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.
    let TimeZone = _prefix "TimeZone"



    let Tuesday = _prefix "Tuesday"



    let Wednesday = _prefix "Wednesday"


    /// Year duration
    let Year = _prefix "Year"


    /// Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.
    let after = _prefix "after"


    /// Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.
    let before = _prefix "before"


    /// Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar.
    let day = _prefix "day"


    /// The day of week, whose value is a member of the class time:DayOfWeek
    let dayOfWeek = _prefix "dayOfWeek"


    /// The number of the day within the year
    let dayOfYear = _prefix "dayOfYear"


    /// length of, or element of the length of, a temporal extent expressed in days
    let days = _prefix "days"


    /// Day of month - formulated as a text string with a pattern constraint to reproduce the same lexical form as gDay, except that values up to 99 are permitted, in order to support calendars with more than 31 days in a month.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalDay = _prefix "generalDay"


    /// Month of year - formulated as a text string with a pattern constraint to reproduce the same lexical form as gMonth, except that values up to 20 are permitted, in order to support calendars with more than 12 months in the year.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalMonth = _prefix "generalMonth"


    /// Year number - formulated as a text string with a pattern constraint to reproduce the same lexical form as gYear, but not restricted to values from the Gregorian calendar.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalYear = _prefix "generalYear"


    /// Beginning of a temporal entity
    let hasBeginning = _prefix "hasBeginning"


    /// Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.
    let hasDateTimeDescription = _prefix "hasDateTimeDescription"


    /// Duration of a temporal entity, expressed as a scaled value or nominal value
    let hasDuration = _prefix "hasDuration"


    /// Duration of a temporal entity, expressed using a structured description
    let hasDurationDescription = _prefix "hasDurationDescription"


    /// End of a temporal entity.
    let hasEnd = _prefix "hasEnd"


    /// The temporal reference system used by a temporal position or extent description.
    let hasTRS = _prefix "hasTRS"


    /// Duration of a temporal entity.
    let hasTemporalDuration = _prefix "hasTemporalDuration"


    /// Supports the association of a temporal entity (instant or interval) to any thing
    let hasTime = _prefix "hasTime"


    /// Extent of a temporal entity, expressed using xsd:duration
    let hasXSDDuration = _prefix "hasXSDDuration"


    /// Hour position in a calendar-clock system.
    let hour = _prefix "hour"


    /// length of, or element of the length of, a temporal extent expressed in hours
    let hours = _prefix "hours"


    /// Position of an instant, expressed using a structured description
    let inDateTime = _prefix "inDateTime"


    /// Position of a time instant
    let inTemporalPosition = _prefix "inTemporalPosition"


    /// Position of an instant, expressed as a temporal coordinate or nominal value
    let inTimePosition = _prefix "inTimePosition"


    /// Position of an instant, expressed using xsd:date
    let inXSDDate = _prefix "inXSDDate"


    /// Position of an instant, expressed using xsd:dateTime
    let inXSDDateTime = _prefix "inXSDDateTime"


    /// Position of an instant, expressed using xsd:dateTimeStamp
    let inXSDDateTimeStamp = _prefix "inXSDDateTimeStamp"


    /// Position of an instant, expressed using xsd:gYear
    let inXSDgYear = _prefix "inXSDgYear"


    /// Position of an instant, expressed using xsd:gYearMonth
    let inXSDgYearMonth = _prefix "inXSDgYearMonth"


    /// An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.
    let inside = _prefix "inside"


    /// If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.
    let intervalAfter = _prefix "intervalAfter"


    /// If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.
    let intervalBefore = _prefix "intervalBefore"


    /// If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.
    let intervalContains = _prefix "intervalContains"


    /// If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.
    let intervalDisjoint = _prefix "intervalDisjoint"


    /// If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    let intervalDuring = _prefix "intervalDuring"


    /// If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalEquals = _prefix "intervalEquals"


    /// If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalFinishedBy = _prefix "intervalFinishedBy"


    /// If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalFinishes = _prefix "intervalFinishes"


    /// If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.
    let intervalIn = _prefix "intervalIn"


    /// If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.
    let intervalMeets = _prefix "intervalMeets"


    /// If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.
    let intervalMetBy = _prefix "intervalMetBy"


    /// If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.
    let intervalOverlappedBy = _prefix "intervalOverlappedBy"


    /// If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    let intervalOverlaps = _prefix "intervalOverlaps"


    /// If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.
    let intervalStartedBy = _prefix "intervalStartedBy"


    /// If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.
    let intervalStarts = _prefix "intervalStarts"


    /// Minute position in a calendar-clock system.
    let minute = _prefix "minute"


    /// length, or element of, a temporal extent expressed in minutes
    let minutes = _prefix "minutes"


    /// Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar.
    let month = _prefix "month"


    /// The month of the year, whose value is a member of the class time:MonthOfYear
    let monthOfYear = _prefix "monthOfYear"


    /// length of, or element of the length of, a temporal extent expressed in months
    let months = _prefix "months"


    /// The (nominal) value indicating temporal position in an ordinal reference system
    let nominalPosition = _prefix "nominalPosition"


    /// Value of a temporal extent expressed as a decimal number scaled by a temporal unit
    let numericDuration = _prefix "numericDuration"


    /// The (numeric) value indicating position within a temporal coordinate system
    let numericPosition = _prefix "numericPosition"


    /// Second position in a calendar-clock system.
    let second = _prefix "second"


    /// length of, or element of the length of, a temporal extent expressed in seconds
    let seconds = _prefix "seconds"


    /// The time zone for clock elements in the temporal position
    let timeZone = _prefix "timeZone"



    let unitDay = _prefix "unitDay"



    let unitHour = _prefix "unitHour"



    let unitMinute = _prefix "unitMinute"



    let unitMonth = _prefix "unitMonth"



    let unitSecond = _prefix "unitSecond"


    /// The temporal unit which provides the precision of a date-time value or scale of a temporal extent
    let unitType = _prefix "unitType"



    let unitWeek = _prefix "unitWeek"



    let unitYear = _prefix "unitYear"


    /// Week number within the year.
    let week = _prefix "week"


    /// length of, or element of the length of, a temporal extent expressed in weeks
    let weeks = _prefix "weeks"


    /// Value of DateTimeInterval expressed as a compact value.
    let xsdDateTime = _prefix "xsdDateTime"


    /// Year position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar year from any calendar.
    let year = _prefix "year"


    /// length of, or element of the length of, a temporal extent expressed in years
    let years = _prefix "years"
// TODO add all of xsi
module xsi =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2001/XMLSchema-instance#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let nil = _prefix "nil"
    let ``type`` = _prefix "type"



module xdt =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "https://www.w3.org/2003/05/xpath-datatypes#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    /// The datatype xdt:untyped denotes the dynamic type of an element node that has not been validated, or has been validated in skip mode. No predefined types are derived from xdt:untyped.
    let untyped = _prefix "untyped"
    /// The datatype xdt:untypedAtomic denotes untyped atomic data, such as text that has not been assigned a more specific type. An attribute that has been validated in skip mode is represented in the Data Model by an attribute node with the type xdt:untypedAtomic. No predefined types are derived from xdt:untypedAtomic.
    let untypedAtomic = _prefix "untypedAtomic"
    /// The datatype xdt:anyAtomicType is an atomic type that includes all atomic values (and no values that are not atomic). Its base type is xs:anySimpleType from which all simple types, including atomic, list, and union types are derived. All primitive atomic types, such as xs:integer and xs:string, have xdt:anyAtomicType as their base type.
    let anyAtomicType = _prefix "anyAtomicType"
    /// The type xdt:dayTimeDuration is derived from xs:duration by restricting its lexical representation to contain only the days, hours, minutes and seconds components. The value space of xdt:dayTimeDuration is the set of fractional second values. The components of xdt:dayTimeDuration correspond to the day, hour, minute and second components defined in Section 5.5.3.2 of ISO 8601, , respectively. xdt:dayTimeDuration is derived from xs:duration as follows:
    let dayTimeDuration = _prefix "dayTimeDuration"

    /// The type xdt:yearMonthDuration is derived from xs:duration by restricting its lexical representation to contain only the year and month components. The value space of xdt:yearMonthDuration is the set of xs:integer month values. The year and month components of xdt:yearMonthDuration correspond to the Gregorian year and month components defined in section 5.5.3.2 of ISO 8601, respectively.
    let yearMonthDuration = _prefix "yearMonthDuration"

module xsd =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2001/XMLSchema#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let anyURI = _prefix "anyURI"
    let anyAtomicType = _prefix "anyAtomicType"
    let anySimpleType = _prefix "anySimpleType"
    let base64Binary = _prefix "base64Binary"
    let boolean = _prefix "boolean"
    let byte = _prefix "byte"
    let date = _prefix "date"
    let dateTime = _prefix "dateTime"
    let dateTimeStamp = _prefix "dateTimeStamp"
    let dayTimeDuration = _prefix "dayTimeDuration"
    let decimal = _prefix "decimal"
    let double = _prefix "double"
    let duration = _prefix "duration"
    let ENTITIES = _prefix "ENTITIES"
    let ENTITY = _prefix "ENTITY"
    let float = _prefix "float"
    let gDay = _prefix "gDay"
    let gMonth = _prefix "gMonth"
    let gMonthDay = _prefix "gMonthDay"
    let gYear = _prefix "gYear"
    let gYearMonth = _prefix "gYearMonth"
    let hexBinary = _prefix "hexBinary"
    let ID = _prefix "ID"
    let IDREF = _prefix "IDREF"
    let IDREFS = _prefix "IDREFS"
    let int = _prefix "int"
    let integer = _prefix "integer"
    let language = _prefix "language"
    let long = _prefix "long"
    let Name = _prefix "Name"
    let NCName = _prefix "NCName"
    let negativeInteger = _prefix "negativeInteger"
    let NMTOKEN = _prefix "NMTOKEN"
    let NMTOKENS = _prefix "NMTOKENS"
    let nonNegativeInteger = _prefix "nonNegativeInteger"
    let nonPositiveInteger = _prefix "nonPositiveInteger"
    let normalizedString = _prefix "normalizedString"
    let NOTATION = _prefix "NOTATION"
    let positiveInteger = _prefix "positiveInteger"
    let precisionDecimal = _prefix "precisionDecimal"
    let QName = _prefix "QName"
    let short = _prefix "short"
    let string = _prefix "string"
    let time = _prefix "time"
    let token = _prefix "token"
    let unsignedByte = _prefix "unsignedByte"
    let unsignedInt = _prefix "unsignedInt"
    let unsignedLong = _prefix "unsignedLong"
    let unsignedShort = _prefix "unsignedShort"
    let yearMonthDuration = _prefix "yearMonthDuration"








































module Quad =
    let from_terms (subject_term: RDF_Term) (predicate_term: RDF_Term) (object_term: RDF_Term) (graph_term: RDF_Term) =
        let triple = Triple.from_terms subject_term predicate_term object_term

        let curGraph = snd (Graph_Name.from_term graph_term)

        { subject = triple.subject
          predicate = triple.predicate
          object = triple.object
          graph_name = curGraph }

    let nq (quad: Quad) =
        let subject = RDF_Subject.nq quad.subject
        let predicate = RDF_Predicate.nq quad.predicate
        let object = RDF_Object.nq quad.object
        let graph_name = Graph_Name.nq quad.graph_name

        match graph_name with
        | _ when String.IsNullOrWhiteSpace graph_name -> $"{subject} {predicate} {object} ."
        | _ -> $"{subject} {predicate} {object} {graph_name} ."



module Ordered_Keyspace =

    let starts_with (prefix: byte array) (bytes: byte array) =
        bytes.Length >= prefix.Length
        && prefix
           |> Array.mapi (fun index byte -> bytes[index] = byte)
           |> Array.forall id

    let entries_with_prefix
        (memory_map: Lightning_Memory_Map)
        (prefix: byte array)
        (transaction: LightningTransaction)
        =

        use cursor = transaction.CreateCursor(memory_map.handle)

        let rec collect entries =
            let struct (result_code, key, value) = cursor.GetCurrent()

            match result_code with
            | MDBResultCode.Success ->
                let key_bytes = key.to_byte_array

                if starts_with prefix key_bytes then
                    let value_bytes = value.to_byte_array

                    match cursor.Next() with
                    | struct (MDBResultCode.Success, _, _) -> collect ((key_bytes, value_bytes) :: entries)

                    | struct (MDBResultCode.NotFound, _, _) -> (key_bytes, value_bytes) :: entries

                    | struct (result_code, _, _) -> failwith $"Cursor Next failed: {result_code}"
                else
                    entries

            | result_code -> failwith $"Cursor GetCurrent failed: {result_code}"

        match cursor.SetRange(prefix) with
        | MDBResultCode.Success -> collect [] |> List.rev |> List.toArray

        | MDBResultCode.NotFound -> [||]

        | result_code -> failwith $"Cursor SetRange failed: {result_code}"

module Graph_Presence =

    let is_asserted (triple_id: Triple_ID) (graph_name_id: Term_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.TG'Presence.handle, Quad_Key.tg triple_id graph_name_id) with
        | struct (MDBResultCode.Success, _, value) -> value.to_byte_array |> Presence.is_asserted

        | struct (MDBResultCode.NotFound, _, _) -> false

        | struct (result_code, _, _) -> failwith $"Get TG'Presence failed with MDBResultCode: {result_code}"

    let asserted_triple_ids_in_graph (graph_name_id: Term_ID) (transaction: LightningTransaction) =

        Ordered_Keyspace.entries_with_prefix
            Lightning_Memory_Map.GT'Presence
            (Term_ID.to_byte_array graph_name_id)
            transaction
        |> Array.choose (fun (key, value) ->
            if Presence.is_asserted value then
                let _graph_name_id, triple_id = Quad_Key.from_gt_key key

                Some triple_id
            else
                None)

    let asserted_graph_ids_for_triple (triple_id: Triple_ID) (transaction: LightningTransaction) =

        Ordered_Keyspace.entries_with_prefix
            Lightning_Memory_Map.TG'Presence
            (Triple_ID.to_byte_array triple_id)
            transaction
        |> Array.choose (fun (key, value) ->
            if Presence.is_asserted value then
                let _triple_id, graph_name_id = Quad_Key.from_tg_key key

                Some graph_name_id
            else
                None)

type Quad_ID =
    { triple_id: Triple_ID
      graph_name_id: Term_ID }

module Quad_ID =

    let from_graph_bound_triple_candidates
        (graph_name_id: Term_ID)
        (triple_ids: Triple_ID array)
        (transaction: LightningTransaction)
        =

        triple_ids
        |> Array.filter (fun triple_id -> Graph_Presence.is_asserted triple_id graph_name_id transaction)
        |> Array.map (fun triple_id ->
            { triple_id = triple_id
              graph_name_id = graph_name_id })

    let from_triple_bound_graph_candidates (triple_id: Triple_ID) (transaction: LightningTransaction) =

        Graph_Presence.asserted_graph_ids_for_triple triple_id transaction
        |> Array.map (fun graph_name_id ->
            { triple_id = triple_id
              graph_name_id = graph_name_id })

    let to_triple (quad_id: Quad_ID) (transaction: LightningTransaction) =

        Get.Triple_by_Triple_ID quad_id.triple_id transaction

    let to_graph_name (quad_id: Quad_ID) (transaction: LightningTransaction) =

        let graph_term = RDF_Term.from_id quad_id.graph_name_id transaction

        let _, graph_name = Graph_Name.from_term graph_term

        graph_name

    let to_quad (quad_id: Quad_ID) (transaction: LightningTransaction) =

        let triple = to_triple quad_id transaction

        let graph_name = to_graph_name quad_id transaction

        { subject = triple.subject
          predicate = triple.predicate
          object = triple.object
          graph_name = graph_name }

    let to_quads (quad_ids: Quad_ID array) (transaction: LightningTransaction) =

        quad_ids
        |> Array.map (fun quad_id -> to_quad quad_id transaction)


    let to_byte_array (quad_id: Quad_ID) =
        Array.concat [| Triple_ID.to_byte_array quad_id.triple_id
                        Term_ID.to_byte_array quad_id.graph_name_id |]

    let from_byte_array (bytes: byte array) =
        if bytes.Length <> 32 then
            failwith $"Quad_ID must be 32 bytes, but was {bytes.Length}."

        { triple_id = bytes[0..23] |> Triple_ID.from_byte_array

          graph_name_id = bytes[24..31] |> Term_ID.from_byte_array }

let graph_vertex_key (graph_name_id: Term_ID) (vertex_id: Term_ID) =
    Array.concat [| Term_ID.to_byte_array graph_name_id
                    Term_ID.to_byte_array vertex_id |]

module Assert =

    let private ensure_triple (triple: Triple) (transaction: LightningTransaction) =
        let triple_id = Triple.id_for_triple triple

        match transaction.Get(Lightning_Memory_Map.Triple_ID'Triple.handle, Triple_ID.to_byte_array triple_id) with
        | struct (MDBResultCode.Success, _, _) -> triple_id

        | struct (MDBResultCode.NotFound, _, _) ->

            transaction.Put(
                Lightning_Memory_Map.Triple_ID'Triple.handle,
                Triple_ID.to_byte_array triple_id,
                Message_Pack.serialize triple
            )
            |> MDBResultCode.fail_if_not_success "Put Triple ID -> Triple"

            transaction.Put(
                Lightning_Memory_Map.Triple'Triple_ID.handle,
                Message_Pack.serialize triple,
                Triple_ID.to_byte_array triple_id
            )
            |> MDBResultCode.fail_if_not_success "Put Triple -> Triple ID"

            for permutation in Triple_Permutation.profile do
                transaction.Put(permutation.memory_map.handle, Permutation_Key.from_triple permutation triple, [||])
                |> MDBResultCode.fail_if_not_success $"Put triple permutation {permutation.memory_map.name}"

            transaction.Put(
                Triple_Permutation.spo.memory_map.handle,
                Permutation_Key.from_triple Triple_Permutation.spo triple,
                [||]
            )
            |> MDBResultCode.fail_if_not_success "Put triple permutation SPO"

            triple_id

        | struct (result_code, _, _) -> failwith $"Get Triple ID -> Triple failed with MDBResultCode: {result_code}"


    let private assert_triple_in_graph
        (triple: Triple)
        (triple_id: Triple_ID)
        (graph_name_id: Term_ID)
        (transaction: LightningTransaction)
        =

        let quad_id =
            { triple_id = triple_id
              graph_name_id = graph_name_id }

        transaction.Put(Lightning_Memory_Map.TG'Presence.handle, Quad_Key.tg triple_id graph_name_id, Presence.asserted)
        |> MDBResultCode.fail_if_not_success "Put TG'Presence"

        transaction.Put(Lightning_Memory_Map.GT'Presence.handle, Quad_Key.gt graph_name_id triple_id, Presence.asserted)
        |> MDBResultCode.fail_if_not_success "Put GT'Presence"

        transaction.Put(
            Lightning_Memory_Map.GVertex'OutEdges.handle,
            graph_vertex_key graph_name_id (RDF_Subject.term_id triple.subject),
            Quad_ID.to_byte_array quad_id
        )
        |> MDBResultCode.fail_if_not_success "Put GVertex'OutEdges"

        transaction.Put(
            Lightning_Memory_Map.GVertex'InEdges.handle,
            graph_vertex_key graph_name_id (RDF_Object.term_id triple.object),
            Quad_ID.to_byte_array quad_id
        )
        |> MDBResultCode.fail_if_not_success "Put GVertex'InEdges"

    let spog
        (subject_term: RDF_Term)
        (predicate_term: RDF_Term)
        (object_term: RDF_Term)
        (graph_term: RDF_Term)
        (transaction: LightningTransaction)
        =

        let triple = Triple.from_terms subject_term predicate_term object_term

        let triple_id = ensure_triple triple transaction
        let graph_name_id, graph_name = Graph_Name.from_term graph_term

        assert_triple_in_graph triple triple_id graph_name_id transaction

    let spod
        (subject_term: RDF_Term)
        (predicate_term: RDF_Term)
        (object_term: RDF_Term)
        (transaction: LightningTransaction)
        =

        spog subject_term predicate_term object_term Graph_Name.default_graph_term transaction

module Retract =

    let private retract_triple_in_graph
        (triple: Triple)
        (triple_id: Triple_ID)
        (graph_name_id: Term_ID)
        (transaction: LightningTransaction)
        =

        let quad_id =
            { triple_id = triple_id
              graph_name_id = graph_name_id }

        transaction.Put(
            Lightning_Memory_Map.TG'Presence.handle,
            Quad_Key.tg triple_id graph_name_id,
            Presence.retracted
        )
        |> MDBResultCode.fail_if_not_success "Put TG'Presence retracted"

        transaction.Put(
            Lightning_Memory_Map.GT'Presence.handle,
            Quad_Key.gt graph_name_id triple_id,
            Presence.retracted
        )
        |> MDBResultCode.fail_if_not_success "Put GT'Presence retracted"

        transaction.Delete(
            Lightning_Memory_Map.GVertex'OutEdges.handle,
            graph_vertex_key graph_name_id (RDF_Subject.term_id triple.subject),
            Quad_ID.to_byte_array quad_id
        )
        |> MDBResultCode.fail_if_not_success "Delete GVertex'OutEdges"

        transaction.Delete(
            Lightning_Memory_Map.GVertex'InEdges.handle,
            graph_vertex_key graph_name_id (RDF_Object.term_id triple.object),
            Quad_ID.to_byte_array quad_id
        )
        |> MDBResultCode.fail_if_not_success "Delete GVertex'InEdges"

    let spog
        (subject_term: RDF_Term)
        (predicate_term: RDF_Term)
        (object_term: RDF_Term)
        (graph_term: RDF_Term)
        (transaction: LightningTransaction)
        =

        let triple = Triple.from_terms subject_term predicate_term object_term

        let triple_id = Triple.id_for_triple triple

        let graph_name_id, graph_name = Graph_Name.from_term graph_term

        retract_triple_in_graph triple triple_id graph_name_id transaction

        { subject = triple.subject
          predicate = triple.predicate
          object = triple.object
          graph_name = graph_name }

    let spod
        (subject_term: RDF_Term)
        (predicate_term: RDF_Term)
        (object_term: RDF_Term)
        (transaction: LightningTransaction)
        =

        spog subject_term predicate_term object_term Graph_Name.default_graph_term transaction

module Revise =

    let spog
        (old_subject_term: RDF_Term)
        (old_predicate_term: RDF_Term)
        (old_object_term: RDF_Term)
        (old_graph_term: RDF_Term)
        (new_subject_term: RDF_Term)
        (new_predicate_term: RDF_Term)
        (new_object_term: RDF_Term)
        (new_graph_term: RDF_Term)
        (transaction: LightningTransaction)
        =

        Retract.spog old_subject_term old_predicate_term old_object_term old_graph_term transaction
        |> ignore

        Assert.spog new_subject_term new_predicate_term new_object_term new_graph_term transaction

    let spod
        (old_subject_term: RDF_Term)
        (old_predicate_term: RDF_Term)
        (old_object_term: RDF_Term)
        (new_subject_term: RDF_Term)
        (new_predicate_term: RDF_Term)
        (new_object_term: RDF_Term)
        (transaction: LightningTransaction)
        =

        spog
            old_subject_term
            old_predicate_term
            old_object_term
            Graph_Name.default_graph_term
            new_subject_term
            new_predicate_term
            new_object_term
            Graph_Name.default_graph_term
            transaction




module Logical_Trie =

    let private starts_with (prefix: byte array) (bytes: byte array) =
        bytes.Length >= prefix.Length
        && prefix
           |> Array.mapi (fun index byte -> bytes[index] = byte)
           |> Array.forall id

    let private component_at_depth (depth: int) (key: byte array) =
        let offset = depth * 8

        key[offset .. offset + 7]
        |> Term_ID.from_byte_array

    let distinct_children
        (permutation: Triple_Permutation)
        (prefix: byte array)
        (depth: int)
        (transaction: LightningTransaction)
        =

        if prefix.Length <> depth * 8 then
            failwith $"Prefix length {prefix.Length} does not match depth {depth}."

        if depth < 0 || depth > 2 then
            failwith $"Triple trie depth must be 0, 1, or 2. Got {depth}."

        use cursor = transaction.CreateCursor(permutation.memory_map.handle)

        let rec collect_children (previous_child: Term_ID option) (children: Term_ID list) =

            let struct (result_code, key, _value) = cursor.GetCurrent()

            match result_code with
            | MDBResultCode.Success ->

                let key_bytes = key.to_byte_array

                if starts_with prefix key_bytes then

                    let child = component_at_depth depth key_bytes

                    let next_children =
                        match previous_child with
                        | Some previous when previous = child -> children

                        | _ -> child :: children

                    match cursor.Next() with
                    | struct (MDBResultCode.Success, _, _) -> collect_children (Some child) next_children

                    | struct (MDBResultCode.NotFound, _, _) -> next_children

                    | struct (result_code, _, _) -> failwith $"Logical trie cursor Next failed: {result_code}"

                else
                    children

            | result_code -> failwith $"Logical trie cursor GetCurrent failed: {result_code}"

        match cursor.SetRange(prefix) with
        | MDBResultCode.Success ->
            collect_children None []
            |> List.rev
            |> List.toArray

        | MDBResultCode.NotFound -> [||]

        | result_code -> failwith $"Logical trie cursor SetRange failed: {result_code}"
















































module Variable_ID =
    let mint () = Uuid.NewSequential() |> VariableID

module RDF_Variable =

    let term_id (rdf_variable: RDF_Variable) =
        match rdf_variable with
        | FreeVariable _ -> None
        | GroundVariable (_, term_id) -> Some term_id

    let variable_id (rdf_variable: RDF_Variable) =
        match rdf_variable with
        | FreeVariable variable_id -> variable_id
        | GroundVariable (variable_id, _) -> variable_id

    let free () = FreeVariable(Variable_ID.mint ())

    let ground (term: RDF_Term) =
        GroundVariable(Variable_ID.mint (), RDF_Term.term_id term)

    let bind (term: RDF_Term) (rdf_variable: RDF_Variable) =
        match rdf_variable with
        | FreeVariable variable_id -> GroundVariable(variable_id, RDF_Term.term_id term)

        | GroundVariable (variable_id, existing_term_id) ->
            if existing_term_id = RDF_Term.term_id term then
                rdf_variable
            else
                failwith $"Variable {variable_id} is already ground to a different term."

    let bind_term_id term_id rdf_variable =
        match rdf_variable with
        | FreeVariable variable_id -> GroundVariable(variable_id, term_id)

        | GroundVariable (variable_id, existing_term_id) ->
            if existing_term_id = term_id then
                rdf_variable
            else
                failwith $"Variable {variable_id} is already ground to a different term."


module Graph_Pattern =

    let from_variables
        (subject_variable: RDF_Variable)
        (predicate_variable: RDF_Variable)
        (object_variable: RDF_Variable)
        (graph_variable: RDF_Variable)
        =
        { subject_variable = subject_variable
          predicate_variable = predicate_variable
          object_variable = object_variable
          graph_variable = graph_variable }

    let private free () = RDF_Variable.free ()

    let private ground (term: RDF_Term) = RDF_Variable.ground term

    let spog subject predicate object graph_name =
        from_variables (ground subject) (ground predicate) (ground object) (ground graph_name)

    let _pog predicate object graph_name =
        from_variables (free ()) (ground predicate) (ground object) (ground graph_name)

    let s_og subject object graph_name =
        from_variables (ground subject) (free ()) (ground object) (ground graph_name)

    let sp_g subject predicate graph_name =
        from_variables (ground subject) (ground predicate) (free ()) (ground graph_name)

    let spo_ subject predicate object =
        from_variables (ground subject) (ground predicate) (ground object) (free ())

    let __og object graph_name =
        from_variables (free ()) (free ()) (ground object) (ground graph_name)

    let _p_g predicate graph_name =
        from_variables (free ()) (ground predicate) (free ()) (ground graph_name)

    let _po_ predicate object =
        from_variables (free ()) (ground predicate) (ground object) (free ())

    let s__g subject graph_name =
        from_variables (ground subject) (free ()) (free ()) (ground graph_name)

    let s_o_ subject object =
        from_variables (ground subject) (free ()) (ground object) (free ())

    let sp__ subject predicate =
        from_variables (ground subject) (ground predicate) (free ()) (free ())

    let ___g graph_name =
        from_variables (free ()) (free ()) (free ()) (ground graph_name)

    let __o_ object =
        from_variables (free ()) (free ()) (ground object) (free ())

    let _p__ predicate =
        from_variables (free ()) (ground predicate) (free ()) (free ())

    let s___ subject =
        from_variables (ground subject) (free ()) (free ()) (free ())

    let ____ () =
        from_variables (free ()) (free ()) (free ()) (free ())


    let variable_by_triple_slot slot pattern =
        match slot with
        | SubjectSlot -> pattern.subject_variable

        | PredicateSlot -> pattern.predicate_variable

        | ObjectSlot -> pattern.object_variable

    let bind_variable (target_variable_id: Variable_ID) (term_id: Term_ID) (pattern: Graph_Pattern) =

        let bind_if_target rdf_variable =
            if RDF_Variable.variable_id rdf_variable = target_variable_id then
                RDF_Variable.bind_term_id term_id rdf_variable
            else
                rdf_variable

        { subject_variable = bind_if_target pattern.subject_variable
          predicate_variable = bind_if_target pattern.predicate_variable
          object_variable = bind_if_target pattern.object_variable
          graph_variable = bind_if_target pattern.graph_variable }

type Variable_Candidate_View =
    { permutation: Triple_Permutation
      prefix: byte array
      depth: int }

module Variable_Candidate_View =

    let try_from_pattern (target_variable_id: Variable_ID) (pattern: Graph_Pattern) (permutation: Triple_Permutation) =

        let rec build_prefix slot_index prefix_parts =
            if slot_index >= permutation.order.Length then
                None
            else
                let triple_slot = permutation.order[slot_index]


                let rdf_variable = Graph_Pattern.variable_by_triple_slot triple_slot pattern

                let current_variable_id = RDF_Variable.variable_id rdf_variable

                if current_variable_id = target_variable_id then
                    Some
                        { permutation = permutation
                          prefix =
                            prefix_parts
                            |> List.rev
                            |> Array.ofList
                            |> Array.concat
                          depth = slot_index }
                else
                    match RDF_Variable.term_id rdf_variable with
                    | Some term_id -> build_prefix (slot_index + 1) ((Term_ID.to_byte_array term_id) :: prefix_parts)

                    | None -> None

        build_prefix 0 []

module Term_ID_Array =

    let private compare_byte_arrays (left: byte array) (right: byte array) =
        let rec loop index =
            if index >= left.Length && index >= right.Length then
                0
            elif index >= left.Length then
                -1
            elif index >= right.Length then
                1
            elif left[index] < right[index] then
                -1
            elif left[index] > right[index] then
                1
            else
                loop (index + 1)

        loop 0

    let compare (left: Term_ID) (right: Term_ID) =
        compare_byte_arrays (Term_ID.to_byte_array left) (Term_ID.to_byte_array right)

    let intersect_sorted (left: Term_ID array) (right: Term_ID array) =

        let rec loop left_index right_index accumulator =
            if left_index >= left.Length
               || right_index >= right.Length then
                accumulator |> List.rev |> List.toArray
            else
                let comparison = compare left[left_index] right[right_index]

                if comparison = 0 then
                    loop (left_index + 1) (right_index + 1) (left[left_index] :: accumulator)

                elif comparison < 0 then
                    loop (left_index + 1) right_index accumulator

                else
                    loop left_index (right_index + 1) accumulator

        loop 0 0 []


module Variable_Candidates =

    let from_pattern (target_variable_id: Variable_ID) (pattern: Graph_Pattern) (transaction: LightningTransaction) =

        [| Triple_Permutation.spo
           Triple_Permutation.sop
           Triple_Permutation.pso
           Triple_Permutation.pos
           Triple_Permutation.osp
           Triple_Permutation.ops |]
        |> Array.choose (fun permutation ->
            Variable_Candidate_View.try_from_pattern target_variable_id pattern permutation)
        |> Array.tryHead
        |> Option.map (fun view -> Logical_Trie.distinct_children view.permutation view.prefix view.depth transaction)

    let intersect_many (candidate_sets: Term_ID array array) =
        match candidate_sets with
        | [||] -> [||]

        | _ ->
            candidate_sets
            |> Array.reduce Term_ID_Array.intersect_sorted

    let from_patterns
        (target_variable_id: Variable_ID)
        (patterns: Graph_Pattern array)
        (transaction: LightningTransaction)
        =

        let candidate_sets =
            patterns
            |> Array.choose (fun pattern -> from_pattern target_variable_id pattern transaction)

        match candidate_sets with
        | [||] -> None

        | _ -> candidate_sets |> intersect_many |> Some


type Query_Branch = { patterns: Graph_Pattern array }


module Query_Branch =

    let bind_variable target_variable_id term_id branch =
        { patterns =
            branch.patterns
            |> Array.map (Graph_Pattern.bind_variable target_variable_id term_id) }

    let expand_on_variable
        (target_variable_id: Variable_ID)
        (branch: Query_Branch)
        (transaction: LightningTransaction)
        =

        match Variable_Candidates.from_patterns target_variable_id branch.patterns transaction with
        | Some candidates ->
            candidates
            |> Array.map (fun term_id -> bind_variable target_variable_id term_id branch)

        | None -> [||]











type Triple_Candidate_Plan =
    { permutation: Triple_Permutation
      prefix: byte array }

module Triple_Candidate_Plan =

    let private term_id_by_slot (slot: Triple_Slot) (pattern: Graph_Pattern) =
        match slot with
        | SubjectSlot -> pattern.subject_variable |> RDF_Variable.term_id

        | PredicateSlot -> pattern.predicate_variable |> RDF_Variable.term_id

        | ObjectSlot -> pattern.object_variable |> RDF_Variable.term_id

    let private prefix_for_permutation (permutation: Triple_Permutation) (pattern: Graph_Pattern) =
        let rec collect_prefix slot_index prefix_parts =
            if slot_index >= permutation.order.Length then
                prefix_parts
                |> List.rev
                |> Array.ofList
                |> Array.concat
            else
                let slot = permutation.order[slot_index]

                match term_id_by_slot slot pattern with
                | Some term_id -> collect_prefix (slot_index + 1) ((Term_ID.to_byte_array term_id) :: prefix_parts)

                | None ->
                    prefix_parts
                    |> List.rev
                    |> Array.ofList
                    |> Array.concat

        { permutation = permutation
          prefix = collect_prefix 0 [] }

    let from_graph_pattern (pattern: Graph_Pattern) =
        [| Triple_Permutation.spo
           Triple_Permutation.sop
           Triple_Permutation.pso
           Triple_Permutation.pos
           Triple_Permutation.osp
           Triple_Permutation.ops |]
        |> Array.map (fun permutation -> prefix_for_permutation permutation pattern)
        |> Array.maxBy (fun plan -> plan.prefix.Length)




module Structural_Triple_Query =

    let triples_by_plan (plan: Triple_Candidate_Plan) (transaction: LightningTransaction) =

        Ordered_Keyspace.entries_with_prefix plan.permutation.memory_map plan.prefix transaction
        |> Array.map (fun (key, _value) -> Permutation_Key.to_triple plan.permutation key transaction)



module Quad_Query =

    let private quad_ids_for_graph_bound_pattern
        (graph_name_id: Term_ID)
        (triples: Triple array)
        (transaction: LightningTransaction)
        =
        triples
        |> Array.choose (fun triple ->
            let triple_id = Triple.id_for_triple triple

            if Graph_Presence.is_asserted triple_id graph_name_id transaction then
                Some
                    { triple_id = triple_id
                      graph_name_id = graph_name_id }
            else
                None)

    let private quad_ids_for_graph_free_pattern (triples: Triple array) (transaction: LightningTransaction) =
        triples
        |> Array.collect (fun triple ->
            let triple_id = Triple.id_for_triple triple

            Graph_Presence.asserted_graph_ids_for_triple triple_id transaction
            |> Array.map (fun graph_name_id ->
                { triple_id = triple_id
                  graph_name_id = graph_name_id }))

    let quad_ids_by_pattern (pattern: Graph_Pattern) (transaction: LightningTransaction) =

        let plan = Triple_Candidate_Plan.from_graph_pattern pattern

        let structural_triples = Structural_Triple_Query.triples_by_plan plan transaction

        match RDF_Variable.term_id pattern.graph_variable with
        | Some graph_name_id -> quad_ids_for_graph_bound_pattern graph_name_id structural_triples transaction

        | None -> quad_ids_for_graph_free_pattern structural_triples transaction

    let quad_from_quad_id (quad_id: Quad_ID) (transaction: LightningTransaction) =

        let triple = Get.Triple_by_Triple_ID quad_id.triple_id transaction

        let graph_term = RDF_Term.from_id quad_id.graph_name_id transaction

        let _graph_name_id, graph_name = Graph_Name.from_term graph_term

        { subject = triple.subject
          predicate = triple.predicate
          object = triple.object
          graph_name = graph_name }

    let quads_by_pattern (pattern: Graph_Pattern) (transaction: LightningTransaction) =

        quad_ids_by_pattern pattern transaction
        |> Array.map (fun quad_id -> quad_from_quad_id quad_id transaction)




















module Graph_Traversal_Adjacency =

    let graph_vertex_key (graph_name_id: Term_ID) (vertex_id: Term_ID) =
        Array.concat [| Term_ID.to_byte_array graph_name_id
                        Term_ID.to_byte_array vertex_id |]

    let quad_ids_by_graph_vertex
        (memory_map: Lightning_Memory_Map)
        (graph_name_id: Term_ID)
        (vertex_id: Term_ID)
        (transaction: LightningTransaction)
        =

        Ordered_Keyspace.entries_with_prefix memory_map (graph_vertex_key graph_name_id vertex_id) transaction
        |> Array.map (fun (_key, value) -> Quad_ID.from_byte_array value)



















type Vertex = { term_id: Term_ID }

type Edge =
    { quad_id: Quad_ID
      subject_id: Term_ID
      predicate_id: Term_ID
      object_id: Term_ID }

type Graph_Traversal_Source = { graph_name_id: Term_ID }

type Graph_Traverser<'Value> =
    { graph: Graph_Traversal_Source
      value: 'Value }





type Incident_Edge =
    { edge: Edge
      incident_vertex_id: Term_ID option }

type Graph_Traversal<'Value> = LightningTransaction -> Graph_Traverser<'Value> array

fsi.AddPrintTransformer<Graph_Traverser<Incident_Edge>>(fun traverser -> traverser.value)

module Graph_Traversal =

    let traversal_with_graph (graph_term: RDF_Term) =
        let graph_name_id, _graph_name = Graph_Name.from_term graph_term

        { graph_name_id = graph_name_id }

    let private ground_term_id (term_id: Term_ID) =
        GroundVariable(Variable_ID.mint (), term_id)

    let private free_variable () = RDF_Variable.free ()

    let private edge_from_quad_id (quad_id: Quad_ID) (transaction: LightningTransaction) =
        let triple = Get.Triple_by_Triple_ID quad_id.triple_id transaction

        { quad_id = quad_id
          subject_id = RDF_Subject.term_id triple.subject
          predicate_id = RDF_Predicate.term_id triple.predicate
          object_id = RDF_Object.term_id triple.object }

    let private incident_edge_from_quad_id
        (incident_vertex_id: Term_ID option)
        (quad_id: Quad_ID)
        (transaction: LightningTransaction)
        =

        { edge = edge_from_quad_id quad_id transaction
          incident_vertex_id = incident_vertex_id }

    let V (vertices: RDF_Term array) (graph_traversal_source: Graph_Traversal_Source) : Graph_Traversal<Vertex> =

        fun _transaction ->
            vertices
            |> Array.map (fun vertex ->
                { graph = graph_traversal_source
                  value = { term_id = RDF_Term.term_id vertex } })

    let E (graph_traversal_source: Graph_Traversal_Source) : Graph_Traversal<Incident_Edge> =

        fun transaction ->
            Graph_Presence.asserted_triple_ids_in_graph graph_traversal_source.graph_name_id transaction
            |> Array.map (fun triple_id ->
                let quad_id =
                    { triple_id = triple_id
                      graph_name_id = graph_traversal_source.graph_name_id }

                { graph = graph_traversal_source
                  value = incident_edge_from_quad_id None quad_id transaction })

    let outE (label: RDF_Term) (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Incident_Edge> =

        fun transaction ->
            traversal transaction
            |> Array.collect (fun traverser ->

                Graph_Traversal_Adjacency.quad_ids_by_graph_vertex
                    Lightning_Memory_Map.GVertex'OutEdges
                    traverser.graph.graph_name_id
                    traverser.value.term_id
                    transaction
                |> Array.choose (fun quad_id ->
                    let edge = edge_from_quad_id quad_id transaction

                    if edge.predicate_id = RDF_Term.term_id label then
                        Some
                            { graph = traverser.graph
                              value =
                                { edge = edge
                                  incident_vertex_id = Some traverser.value.term_id } }
                    else
                        None))

    let inE (label: RDF_Term) (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Incident_Edge> =

        fun transaction ->
            traversal transaction
            |> Array.collect (fun traverser ->

                Graph_Traversal_Adjacency.quad_ids_by_graph_vertex
                    Lightning_Memory_Map.GVertex'InEdges
                    traverser.graph.graph_name_id
                    traverser.value.term_id
                    transaction
                |> Array.choose (fun quad_id ->
                    let edge = edge_from_quad_id quad_id transaction

                    if edge.predicate_id = RDF_Term.term_id label then
                        Some
                            { graph = traverser.graph
                              value =
                                { edge = edge
                                  incident_vertex_id = Some traverser.value.term_id } }
                    else
                        None))

    let outV (traversal: Graph_Traversal<Incident_Edge>) : Graph_Traversal<Vertex> =

        fun transaction ->
            traversal transaction
            |> Array.map (fun traverser ->
                { graph = traverser.graph
                  value = { term_id = traverser.value.edge.subject_id } })

    let inV (traversal: Graph_Traversal<Incident_Edge>) : Graph_Traversal<Vertex> =

        fun transaction ->
            traversal transaction
            |> Array.map (fun traverser ->
                { graph = traverser.graph
                  value = { term_id = traverser.value.edge.object_id } })

    let out (label: RDF_Term) (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Vertex> =

        traversal |> outE label |> inV

    let in_ (label: RDF_Term) (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Vertex> =

        traversal |> inE label |> outV

    let otherV (traversal: Graph_Traversal<Incident_Edge>) : Graph_Traversal<Vertex> =
        fun transaction ->
            traversal transaction
            |> Array.map (fun traverser ->
                let edge = traverser.value.edge

                match traverser.value.incident_vertex_id with
                | Some previous when previous = edge.subject_id ->
                    { graph = traverser.graph
                      value = { term_id = edge.object_id } }

                | Some previous when previous = edge.object_id ->
                    { graph = traverser.graph
                      value = { term_id = edge.subject_id } }

                | Some previous -> failwith $"Previous vertex {previous} is not incident to this edge."

                | None -> failwith "otherV requires an edge reached from a prior vertex.")

    let to_quads (traversal: Graph_Traversal<Incident_Edge>) =

        fun transaction ->
            traversal transaction
            |> Array.map (fun traverser -> Quad_ID.to_quad traverser.value.edge.quad_id transaction
            // { graph = traverser.graph value = Quad_ID.to_quad traverser.value.edge.quad_id transaction }

            )






































































































































module RDF_Literal =
    let simple (string_value: string) (transaction: LightningTransaction) =

        let lexical_form = Lexical_Form.from_string string_value transaction
        RDF_Term.from_simple_literal { lexical_form_id = lexical_form.lexical_form_id } transaction


    let language (string_value: string) (lang_tag: Language_Subtag) (transaction: LightningTransaction) =

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_language_string
            { lexical_form_id = lexical_form.lexical_form_id
              language = lang_tag }
            transaction

    let en (string_value: string) (transaction: LightningTransaction) =

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_language_string
            { lexical_form_id = lexical_form.lexical_form_id
              language = Language_Subtag.en }
            transaction

    let region
        (string_value: string)
        (lang_tag: Language_Subtag)
        (region_tag: Region_Subtag)
        (transaction: LightningTransaction)
        =

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_region_string
            { lexical_form_id = lexical_form.lexical_form_id
              language = lang_tag
              region = region_tag }
            transaction

    let US (string_value: string) (transaction: LightningTransaction) =

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_region_string
            { lexical_form_id = lexical_form.lexical_form_id
              language = Language_Subtag.en
              region = Region_Subtag.US }
            transaction

    let directed_language
        (string_value: string)
        (lang_tag: Language_Subtag)
        (base_direction: Language_Base_Direction)
        (transaction: LightningTransaction)
        =

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_directed_language_string
            { lexical_form_id = lexical_form.lexical_form_id
              language = lang_tag
              direction = base_direction }
            transaction

    let directed_region
        (string_value: string)
        (lang_tag: Language_Subtag)
        (region_tag: Region_Subtag)
        (base_direction: Language_Base_Direction)
        (transaction: LightningTransaction)
        =

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_directed_region_string
            { lexical_form_id = lexical_form.lexical_form_id
              language = lang_tag
              region = region_tag
              direction = base_direction }
            transaction

    let datatyped (string_value: string) (datatype: RDF_Term) (transaction: LightningTransaction) =
        test <@ datatype |> RDF_Term.is_named_resource @>

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_datatyped_literal
            { lexical_form_id = lexical_form.lexical_form_id
              datatype_id = datatype |> RDF_Term.term_id }
            transaction

    let autotyped<'ValueType> (value: 'ValueType) (transaction: LightningTransaction) =
        let value_string, datatype_iri =
            let invariant_string =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> (if value then "true" else "false"), xsd.boolean
            | :? (Byte array) as value -> Convert.ToBase64String(value), xsd.base64Binary
            | :? Byte as value -> invariant_string, xsd.unsignedByte
            | :? DateOnly as value -> value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), xsd.date
            | :? DateTime as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTime
            | :? DateTimeOffset as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTimeStamp
            | :? Decimal as value -> invariant_string, xsd.decimal
            | :? Double as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.double
            | :? Int16 as value -> invariant_string, xsd.short
            | :? Int32 as value -> invariant_string, xsd.int
            | :? Int64 as value -> invariant_string, xsd.long
            | :? SByte as value -> invariant_string, xsd.byte
            | :? Single as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.float
            | :? TimeOnly as value -> value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture), xsd.time
            | :? TimeSpan as value -> Xml.XmlConvert.ToString(value), xsd.duration
            | :? UInt16 as value -> invariant_string, xsd.unsignedShort
            | :? UInt32 as value -> invariant_string, xsd.unsignedInt
            | :? UInt64 as value -> invariant_string, xsd.unsignedLong
            | :? Uri as value -> value.AbsoluteUri, xsd.anyURI
            | :? XmlQualifiedName as value -> value.ToString(), xsd.QName
            | null -> "true", xsi.nil
            | value when value.GetType() = typeof<Object> -> invariant_string, xdt.anyAtomicType
            | value -> invariant_string, xsd.string

        datatyped value_string datatype_iri transaction




    module Binary =

        let base64 (bytes: Byte array) (transaction: LightningTransaction) =
            let value_string = Convert.ToBase64String(bytes)

            datatyped value_string xsd.base64Binary transaction

        let hex (bytes: Byte array) (transaction: LightningTransaction) =
            let value_string = Convert.ToHexString(bytes)

            datatyped value_string xsd.hexBinary transaction


    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) (transaction: LightningTransaction) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                datatyped value_string xsd.duration transaction

            let dayTimeDuration (timespan: TimeSpan) (transaction: LightningTransaction) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                datatyped value_string xdt.dayTimeDuration transaction


            let yearMonthDuration (years: int) (months: int) (transaction: LightningTransaction) =
                let total_months = years * 12 + months

                let value_string =
                    if total_months = 0 then
                        "P0M"
                    else
                        let absolute_months = abs total_months
                        let years_part = absolute_months / 12
                        let months_part = absolute_months % 12
                        let sign = if total_months < 0 then "-" else ""

                        let year_text =
                            if years_part = 0 then
                                ""
                            else
                                $"{years_part}Y"

                        let month_text =
                            if months_part = 0 then
                                ""
                            else
                                $"{months_part}M"

                        $"{sign}P{year_text}{month_text}"

                datatyped value_string xdt.yearMonthDuration transaction


        module date =

            let only (date: DateOnly) (transaction: LightningTransaction) =
                let value_string = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                datatyped value_string xsd.date transaction

            let from_datetime (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                datatyped value_string xsd.date transaction

            let time (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string = datetime.ToString("o", CultureInfo.InvariantCulture)

                datatyped value_string xsd.dateTime transaction

            let timeStamp (datetime_offset: DateTimeOffset) (transaction: LightningTransaction) =
                let value_string = datetime_offset.ToString("o", CultureInfo.InvariantCulture)

                datatyped value_string xsd.dateTimeStamp transaction



        module time =

            let only (time: TimeOnly) (transaction: LightningTransaction) =
                let value_string = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                datatyped value_string xsd.time transaction

            let from_datetime (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                datatyped value_string xsd.time transaction

        module period =

            let day (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gDay transaction


            let month (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gMonth transaction


            let monthDay (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gMonthDay transaction


            let year (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                datatyped value_string xsd.gYear transaction


            let yearMonth (datetime: DateTime) (transaction: LightningTransaction) =
                let value_string =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gYearMonth transaction

            let generalDay (day: int) (transaction: LightningTransaction) =
                test <@ day >= 1 && day <= 99 @>
                let value_string = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string owl_time.generalDay transaction


            let generalMonth (month: int) (transaction: LightningTransaction) =
                test <@ month >= 1 && month <= 20 @>
                let value_string = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string owl_time.generalMonth transaction


            let generalYear (year: int) (transaction: LightningTransaction) =
                let value_string = year.ToString("0000", CultureInfo.InvariantCulture)

                datatyped value_string owl_time.generalYear transaction


    module Numeric =

        let private bigint_value_string (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) (transaction: LightningTransaction) =
            datatyped (bigint_value_string value) xsd.integer transaction

        let negativeInteger (value: bigint) (transaction: LightningTransaction) =
            test <@ value < 0I @>
            datatyped (bigint_value_string value) xsd.negativeInteger transaction

        let nonNegativeInteger (value: bigint) (transaction: LightningTransaction) =
            test <@ value >= 0I @>
            datatyped (bigint_value_string value) xsd.nonNegativeInteger transaction

        let nonPositiveInteger (value: bigint) (transaction: LightningTransaction) =
            test <@ value <= 0I @>
            datatyped (bigint_value_string value) xsd.nonPositiveInteger transaction

        let positiveInteger (value: bigint) (transaction: LightningTransaction) =
            test <@ value > 0I @>
            datatyped (bigint_value_string value) xsd.positiveInteger transaction















































fsi.AddPrinter<Term_ID>(fun term_id -> sprintf "%u" (term_id |> Term_ID.to_uint64))
fsi.AddPrinter<Triple_ID>(fun term_id -> sprintf "%u" (term_id |> Triple_ID.to_uint64))

fsi.AddPrinter<Lexical_Form_ID> (fun lexical_form_id ->
    sprintf
        "%u \"%s\""
        (lexical_form_id |> Lexical_Form_ID.to_uint64)
        (lmdb_read_only { return! Get.String_by_Lexical_Form_ID lexical_form_id }))

fsi.AddPrinter<Quad>(fun quad -> Quad.nq quad)

fsi.AddPrinter<Incident_Edge> (fun incident ->
    let quad = lmdb_read_only { return! incident.edge.quad_id |> Quad_ID.to_quad }
    Quad.nq quad)





















module adhoc =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "https://eristocrates.dev/ontology/adhoc/" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let knows = _prefix "knows"
    let name = _prefix "name"
    let age = _prefix "age"
    let lang = _prefix "lang"
    let created = _prefix "created"
    let weight = _prefix "weight"

    let Marko = _prefix "Marko"
    let Lop = _prefix "Lop"
    let Java = _prefix "Java"
    let Josh = _prefix "Josh"
    let Vadas = _prefix "Vadas"
    let Peter = _prefix "Peter"
    let Ripple = _prefix "Ripple"

    let Alice = _prefix "Alice"
    let Bob = _prefix "Bob"
    let Charlie = _prefix "Charlie"
    let Person = _prefix "Person"
    let Cat = _prefix "Cat"

































lmdb_read_write {
    let! current_transaction = lmdb_read_write.Current_Transaction
    let! marko = RDF_Literal.simple "marko"
    let! vadas = RDF_Literal.simple "vadas"
    let! lop = RDF_Literal.simple "lop"
    let! java = RDF_Literal.simple "java"
    let! josh = RDF_Literal.simple "josh"
    let! ripple = RDF_Literal.simple "ripple"
    let! peter = RDF_Literal.simple "peter"


    let! _27 = RDF_Literal.autotyped 27
    let! _29 = RDF_Literal.autotyped 29
    let! _32 = RDF_Literal.autotyped 32
    let! _35 = RDF_Literal.autotyped 35

    do! Assert.spod adhoc.Marko adhoc.name marko
    do! Assert.spod adhoc.Marko adhoc.age _29
    do! Assert.spod adhoc.Marko adhoc.knows adhoc.Vadas
    do! Assert.spod adhoc.Marko adhoc.knows adhoc.Josh

    do! Assert.spod adhoc.Vadas adhoc.name vadas
    do! Assert.spod adhoc.Vadas adhoc.age _27

    do! Assert.spod adhoc.Marko adhoc.created adhoc.Lop
    do! Assert.spod adhoc.Lop adhoc.name lop
    do! Assert.spod adhoc.Lop adhoc.lang adhoc.Java

    do! Assert.spod adhoc.Peter adhoc.name peter
    do! Assert.spod adhoc.Peter adhoc.age _35
    do! Assert.spod adhoc.Peter adhoc.created adhoc.Lop

    do! Assert.spod adhoc.Josh adhoc.name josh
    do! Assert.spod adhoc.Josh adhoc.age _32
    do! Assert.spod adhoc.Josh adhoc.created adhoc.Lop
    do! Assert.spod adhoc.Josh adhoc.created adhoc.Ripple

    do! Assert.spod adhoc.Ripple adhoc.name ripple
    do! Assert.spod adhoc.Ripple adhoc.lang adhoc.Java


}



let bgp = Graph_Pattern._p_g adhoc.name Graph_Name.default_graph_term
let g = Graph_Traversal.traversal_with_graph Graph_Name.default_graph_term

let bgp_results = lmdb_read_only { return! bgp |> Quad_Query.quads_by_pattern }

let traversal_results =
    lmdb_read_only {
        return!
            g
            |> Graph_Traversal.V [| adhoc.Marko |]
            |> Graph_Traversal.outE adhoc.knows
            |> Graph_Traversal.to_quads
    }


module NetRdf =
    let triplestore = new VDS.RDF.ThreadSafeTripleStore()
    let graph = new VDS.RDF.ThreadSafeGraph()

    module NQuads =
        let parser = NQuadsParser()

        let parse (quads: Quad array) (triplestore: VDS.RDF.ITripleStore) =

            let text = quads |> Array.map Quad.nq |> String.concat "\n"
            use reader = new StringReader(text)
            parser.Load(triplestore, reader)

    module Turtle =

        let writer =
            let writer = new CompressingTurtleWriter()
            writer.HighSpeedModePermitted <- false
            writer.PrettyPrintMode <- true
            writer

        let write (file_path: string) (graph: VDS.RDF.IGraph) = writer.Save(graph, file_path)

    module Trig =
        let writer =
            let writer = new TriGWriter()
            writer.HighSpeedModePermitted <- false
            writer.PrettyPrintMode <- true
            writer

        let write (file_path: string) (triplestore: VDS.RDF.ITripleStore) = writer.Save(triplestore, file_path)




NetRdf.triplestore
|> NetRdf.NQuads.parse bgp_results

let parent_directory_path =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Scratch\"

let trig_path = Path.Combine(parent_directory_path, "triplestore.trig")

NetRdf.triplestore |> NetRdf.Trig.write trig_path

NetRdf.triplestore.Graphs
|> Seq.iter (fun graph ->

    graph.NamespaceMap.AddNamespace("", new Uri(adhoc._namespace_name.string_value))

    let file_name =
        match graph.Name with
        | null -> "default_graph.ttl"
        | _ -> $"{graph.Name.ToString()}.ttl"

    let ttl_path = Path.Combine(parent_directory_path, file_name)

    graph |> NetRdf.Turtle.write ttl_path

)
