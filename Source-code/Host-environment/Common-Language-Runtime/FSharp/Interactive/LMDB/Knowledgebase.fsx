open System
open System.Buffers
open System.Text
open System.Collections.Generic
open System.Diagnostics

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
type Variable_Sigil =
    | QuestionMark
    | DollarSign

[<MessagePackObject>]
type RDF_Variable =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      sigil: Variable_Sigil }


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
      Language: Language_Subtag }

[<MessagePackObject>]
type Region_String =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      Language: Language_Subtag
      [<Key(2)>]
      region: Region_Subtag }

[<MessagePackObject>]
type Directed_Language_String =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      Language: Language_Subtag
      [<Key(2)>]
      direction: Language_Base_Direction }

[<MessagePackObject>]
type Directed_Region_String =
    { [<Key(0)>]
      lexical_form_id: Lexical_Form_ID
      [<Key(1)>]
      Language: Language_Subtag
      [<Key(2)>]
      region: Region_Subtag
      [<Key(3)>]
      direction: Language_Base_Direction }






























[<MessagePackObject>]
type Triple =
    { [<Key(0)>]
      triple_id: Triple_ID
      [<Key(1)>]
      subject: RDF_Subject
      [<Key(2)>]
      predicate: RDF_Predicate
      [<Key(3)>]
      object: RDF_Object }

and [<MessagePackObject; RequireQualifiedAccess>] RDF_Subject =
    | FromNamespacedIRI of Namespaced_IRI
    | FromAtomicIRI of Atomic_IRI
    | FromSkolemIRI of Skolem_IRI

and [<MessagePackObject; RequireQualifiedAccess>] RDF_Predicate =
    | FromNamespacedIRI of Namespaced_IRI
    | FromAtomicIRI of Atomic_IRI

and [<MessagePackObject; RequireQualifiedAccess>] RDF_Object =
    | FromNamespacedIRI of Namespaced_IRI
    | FromAtomicIRI of Atomic_IRI
    | FromSkolemIRI of Skolem_IRI
    | FromSimpleLiteral of Simple_Literal
    | FromDatatypedLiteral of Datatyped_Literal
    | FromLanguageString of Language_String
    | FromRegionString of Region_String
    | FromDirectedLanguageString of Directed_Language_String
    | FromDirectedRegionString of Directed_Region_String
    | FromTripleTerm of Triple_ID

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
    | FromVariable of term_id: Term_ID * term: RDF_Variable


[<MessagePackObject>]
type Quad_Context =
    | DefaultGraph
    | FromNamespacedIRI of Namespaced_IRI
    | FromAtomicIRI of Atomic_IRI
    | FromSkolemIRI of Skolem_IRI


[<MessagePackObject>]
type Quad =
    { [<Key(0)>]
      triple_id: Triple_ID
      [<Key(1)>]
      context: Quad_Context }

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
    let Term'Term_ID = key'value "Term'Term_ID" DatabaseOpenFlags.Create
    let Triple_ID'Triple = key'value "Triple_ID'Triple" DatabaseOpenFlags.Create
    let Triple'Triple_ID = key'value "Triple'Triple_ID" DatabaseOpenFlags.Create
    let ID_Kind'Next_ID = key'value "ID_Kind'Next_ID" DatabaseOpenFlags.Create

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

    let next_triple_id (transaction: LightningTransaction) =
        let id = Triple_ID.from_uint64 initial |> ID.FromTripleID
        next_by_id id transaction


module Lexical_Form_ID =

    let to_uint64 (LexicalFormID bytes) =

        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

    let to_byte_array (LexicalFormID bytes) = bytes

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
                Lexical_Form_ID.from_byte_array [||]
// failwith "Expected bytes for Lexical_Form_ID."


module Message_Pack =

    let options =
        MessagePackSerializerOptions.Standard.WithResolver(
            CompositeResolver.Create(
                [| Lexical_Form_ID_Formatter() :> IMessagePackFormatter |],
                [| FSharpResolver.Instance
                   StandardResolver.Instance :> IFormatterResolver |]
            )
        )

    let serialize<'ObjectType> (message_pack_object: 'ObjectType) =
        MessagePackSerializer.Serialize(message_pack_object, options)

    let deserialize<'ObjectType> (message_pack_object_bytes: byte array) =
        MessagePackSerializer.Deserialize<'ObjectType>(message_pack_object_bytes, options)



module Term_ID =

    let to_uint64 (TermID bytes) =

        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)

    let to_byte_array (TermID bytes) = bytes
    fsi.AddPrinter<Term_ID>(fun term_id -> sprintf "%u" (term_id |> to_uint64))

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


module Skolem_IRI =


    let new_uuidv7 () = Uuid.NewSequential().ToString("N")

    let mint () =
        lmdb_read_write {

            let! well_known = Lexical_Form.from_string well_known_prefix
            let! uuidv7 = Lexical_Form.from_string (new_uuidv7 ())

            return
                { well_known_id = well_known.lexical_form_id
                  uuidv7_id = uuidv7.lexical_form_id }

        }

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

        | struct (MDBResultCode.NotFound, _, _) -> failwith $"No string found for lexical form ID: {triple_id}"

        | struct (result_code, _, _) -> failwith $"Get Triple_ID -> Triple failed with MDBResultCode: {result_code}"


module RDF_Term =
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
        | RDF_Term.FromVariable (term_id, term) -> term_id


    let from_namespaced_iri (term: Namespaced_IRI) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromNamespacedIRI(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromNamespacedIRI(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_atomic_iri (term: Atomic_IRI) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromAtomicIRI(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromAtomicIRI(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_skolem_iri (term: Skolem_IRI) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromSkolemIRI(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromSkolemIRI(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_simple_literal (term: Simple_Literal) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromSimpleLiteral(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromSimpleLiteral(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_datatyped_literal (term: Datatyped_Literal) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromDatatypedLiteral(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromDatatypedLiteral(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_language_string (term: Language_String) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromLanguageString(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromLanguageString(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_region_string (term: Region_String) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromRegionString(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromRegionString(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_directed_language_string (term: Directed_Language_String) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromDirectedLanguageString(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromDirectedLanguageString(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_directed_region_string (term: Directed_Region_String) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromDirectedRegionString(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromDirectedRegionString(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_triple_id (triple_id: Triple_ID) (transaction: LightningTransaction) =
        let triple = Get.Triple_by_Triple_ID triple_id


        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize triple) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromTripleTerm(term_id, triple_id)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize triple
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize triple,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromTripleTerm(term_id, triple_id)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

    let from_variable (term: RDF_Variable) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term'Term_ID.handle, Message_Pack.serialize term) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id
            RDF_Term.FromVariable(term_id, term)

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64


            transaction.Put(
                Lightning_Memory_Map.Term_ID'Term.handle,
                term_id |> Term_ID.to_byte_array,
                Message_Pack.serialize term
            )
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(
                Lightning_Memory_Map.Term'Term_ID.handle,
                Message_Pack.serialize term,
                term_id |> Term_ID.to_byte_array
            )
            |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

            RDF_Term.FromVariable(term_id, term)

        | struct (result_code, _, _) -> failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

module RDF_Subject =
    let term (rdf_subject: RDF_Subject) =
        match rdf_subject with

        | RDF_Subject.FromNamespacedIRI namespaced_iri ->
            lmdb_read_write { return! RDF_Term.from_namespaced_iri namespaced_iri }
        | RDF_Subject.FromAtomicIRI atomic_iri -> lmdb_read_write { return! RDF_Term.from_atomic_iri atomic_iri }
        | RDF_Subject.FromSkolemIRI skolem_iri -> lmdb_read_write { return! RDF_Term.from_skolem_iri skolem_iri }

module RDF_Predicate =
    let term (rdf_predicate: RDF_Predicate) =
        match rdf_predicate with

        | RDF_Predicate.FromNamespacedIRI namespaced_iri ->
            lmdb_read_write { return! RDF_Term.from_namespaced_iri namespaced_iri }
        | RDF_Predicate.FromAtomicIRI atomic_iri -> lmdb_read_write { return! RDF_Term.from_atomic_iri atomic_iri }

module RDF_Object =
    let term (rdf_object: RDF_Object) =
        match rdf_object with

        | RDF_Object.FromNamespacedIRI namespaced_iri ->
            lmdb_read_write { return! RDF_Term.from_namespaced_iri namespaced_iri }
        | RDF_Object.FromAtomicIRI atomic_iri -> lmdb_read_write { return! RDF_Term.from_atomic_iri atomic_iri }
        | RDF_Object.FromSkolemIRI skolem_iri -> lmdb_read_write { return! RDF_Term.from_skolem_iri skolem_iri }

        | RDF_Object.FromSimpleLiteral simple_literal ->
            lmdb_read_write { return! RDF_Term.from_simple_literal simple_literal }
        | RDF_Object.FromDatatypedLiteral datatyped_literal ->
            lmdb_read_write { return! RDF_Term.from_datatyped_literal datatyped_literal }
        | RDF_Object.FromLanguageString language_string ->
            lmdb_read_write { return! RDF_Term.from_language_string language_string }
        | RDF_Object.FromRegionString region_string ->
            lmdb_read_write { return! RDF_Term.from_region_string region_string }
        | RDF_Object.FromDirectedLanguageString directed_language_string ->
            lmdb_read_write { return! RDF_Term.from_directed_language_string directed_language_string }
        | RDF_Object.FromDirectedRegionString directed_region_string ->
            lmdb_read_write { return! RDF_Term.from_directed_region_string directed_region_string }
        | RDF_Object.FromTripleTerm triple_id -> lmdb_read_write { return! RDF_Term.from_triple_id triple_id }

// TODO deal with actually asserting triples and triple permutations.

(*
module Permutation_Key =

    let slot_value_from_triple (slot: Triple_Slot) (triple: Triple) =
        match slot with
        | S -> RDF_Subject.term triple.subject
        | P -> RDF_Predicate.term triple.predicate
        | O -> RDF_Object.term triple.object

    let from_triple (permutation: Triple_Permutation) (triple: Triple) =
        permutation.order
        |> Array.collect (fun slot -> slot_value_from_triple slot triple)


    let private chunks_of_6 (bytes: byte array) =
        if bytes.Length <> 24 then
            failwithf "Permutation key must be 24 bytes, but was %i bytes." bytes.Length

        [| bytes[0..7]
           bytes[8..15]
           bytes[16..23] |]


    let to_triple (permutation: Triple_Permutation) (permutation_key: byte array) =
        let chunks = chunks_of_6 permutation_key

        let mutable subject_id = None
        let mutable predicate_id = None
        let mutable object_id = None

        for i = 0 to 2 do
            match permutation.order[i] with
            | S -> subject_id <- Some chunks[i]
            | P -> predicate_id <- Some chunks[i]
            | O -> object_id <- Some chunks[i]

        { subject_id = RDF_Term_ID.from_encoding subject_id.Value
          predicate_id = RDF_Term_ID.from_encoding predicate_id.Value
          object_id = RDF_Term_ID.from_encoding object_id.Value }


    module Prefix =
        let concat (arrays: byte array array) = arrays |> Array.collect id

        let starts_with (prefix: byte array) (bytes: byte array) =
            bytes.Length >= prefix.Length
            && prefix
               |> Array.mapi (fun i b -> bytes[i] = b)
               |> Array.forall id

module Triple_ID =
    let from_triple triple =
        Permutation_Key.from_triple Triple_Permutation.spo triple
        |> Triple_ID.from_encoding


module Triple =
    let spo (curSubject: RDF_Subject) (curPredicate: RDF_Predicate) (curObject: RDF_Object) =
        {



        }

*)






















































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

lmdb_read_only { return! Get.All_Keys_by_Memory_Map Lightning_Memory_Map.Lexical_Form_ID'String_Bytes }

TypeLayout.PrintLayout<string>()
TypeLayout.PrintLayout<Lexical_Form>()

let test_string =
    lmdb_read_write {
        let! representation = Lexical_Form.from_string "test"

        return representation
    }




fsi.AddPrinter<Lexical_Form_ID> (fun lexical_form_id ->
    sprintf
        "%u \"%s\""
        (lexical_form_id |> Lexical_Form_ID.to_uint64)
        (lmdb_read_only { return! Get.String_by_Lexical_Form_ID lexical_form_id }))
