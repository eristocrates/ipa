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


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\LMDB\Environment\LCG.fsx"
open LCG

let rdf_directory_path = @"D:\Persistence\RDF\LCG"
let xlsx_directory_path = @"D:\Persistence\XLSX\LCG"
let csv_directory_path = @"D:\Persistence\CSV\LCG"
let html_directory_path = @"D:\Persistence\HTML\LCG"

[|

   rdf_directory_path
   xlsx_directory_path
   csv_directory_path
   html_directory_path

   |]
|> Array.map (fun directory_path -> Directory.CreateDirectory(directory_path))






module Workplace =
    let personal_site =
        "https://leoncountyfl-my.sharepoint.com/personal/collierb_leoncountyfl_gov/Documents"
    // "https://leoncountyfl-my.sharepoint.com/:f:/g/personal/collierb_leoncountyfl_gov"

    let well_known_base = $"{personal_site}/.well-known/genid/"
    let ontology_base = $"{personal_site}/ontology"
// let ontology_base = $"{personal_site}/IgBmh3ED16kbQLMe0b5M14h-AQtayBR3f4R61G1BpewU070?e=h5jTVN"

module Commonplace =
    let personal_site = "https://eristocrates.dev"
    let well_known_base = $"{personal_site}/.well-known/genid/"
    let ontology_base = $"{personal_site}/ontology"

let well_known_base = Workplace.well_known_base



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

    member _.For(sequence: seq<'InputType>, body: 'InputType -> LightningTransaction -> unit) : LightningTransaction -> unit =

        fun (transaction: LightningTransaction) ->
            for item in sequence do
                body item transaction

    member _.Zero() : LightningTransaction -> unit =
        fun (_transaction: LightningTransaction) -> ()

    member _.Combine(first: LightningTransaction -> unit, second: LightningTransaction -> 'OutputType) : LightningTransaction -> 'OutputType =

        fun (transaction: LightningTransaction) ->
            first transaction
            second transaction

    member _.TryWith(operation: LightningTransaction -> 'OutputType, handler: exn -> LightningTransaction -> 'OutputType) : LightningTransaction -> 'OutputType =

        fun (transaction: LightningTransaction) ->
            try
                operation transaction
            with
            | error -> handler error transaction

    member _.TryFinally(operation: LightningTransaction -> 'OutputType, compensation: unit -> unit) : LightningTransaction -> 'OutputType =

        fun (transaction: LightningTransaction) ->
            try
                operation transaction
            finally
                compensation ()

    member _.Using(resource: 'Resource, body: 'Resource -> LightningTransaction -> 'OutputType) : LightningTransaction -> 'OutputType when 'Resource :> IDisposable =

        fun (transaction: LightningTransaction) ->
            use resource = resource
            body resource transaction

    member _.Return(value: 'OutputType) : LightningTransaction -> 'OutputType =
        fun (_transaction: LightningTransaction) -> value

    member _.ReturnFrom(operation: LightningTransaction -> 'OutputType) : LightningTransaction -> 'OutputType = operation

    member _.Bind(operation: LightningTransaction -> 'InputType, continuation: 'InputType -> LightningTransaction -> 'OutputType) : LightningTransaction -> 'OutputType =

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
    member this.low_lined = this.Replace(" ", "_")

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

        let key_text = Encoding.UTF8.GetString key

        let next_bytes = (current + 1UL).to_byte_array
        transaction.Put(Lightning_Memory_Map.ID_Kind'Next_ID.handle, key, (current + 1UL).to_byte_array)
        |> MDBResultCode.fail_if_not_success $"Put next ID with key '{key_text}' ; current '{current}' next '{BitConverter.ToString(next_bytes)}' ; id '{id}'"

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

        member _.Serialize(writer: byref<MessagePackWriter>, value: Lexical_Form_ID, options: MessagePackSerializerOptions) =
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

        match transaction.Get(Lightning_Memory_Map.String_Digest'Lexical_Form_ID.handle, string_value.digest.to_byte_array) with
        | struct (MDBResultCode.Success, _, mdb_lexical_form_id) ->
            { string_value = string_value
              lexical_form_id = Lexical_Form_ID.from_mdb_value mdb_lexical_form_id }

        | struct (MDBResultCode.NotFound, _, _) ->
            let lexical_form_id =
                ID.next_lexical_form_id transaction
                |> Lexical_Form_ID.from_uint64


            transaction.Put(Lightning_Memory_Map.Lexical_Form_ID'String_Bytes.handle, lexical_form_id |> Lexical_Form_ID.to_byte_array, string_value.to_byte_array)
            |> MDBResultCode.fail_if_not_success "Put Lexical_Form_ID -> String Bytes"

            transaction.Put(Lightning_Memory_Map.String_Digest'Lexical_Form_ID.handle, string_value.digest.to_byte_array, lexical_form_id |> Lexical_Form_ID.to_byte_array)
            |> MDBResultCode.fail_if_not_success "Put String Digest -> Lexical_Form_ID"

            { string_value = string_value
              lexical_form_id = lexical_form_id }

        | struct (result_code, _, _) -> failwith $"Get Digest -> Lexical_Form_ID failed with MDBResultCode: {result_code}"



type String with
    member this.to_lexical_form = Lexical_Form.from_string this




module Get =

    let All_Keys_by_Memory_Map (memory_map: Lightning_Memory_Map) (transaction: LightningTransaction) =

        use cursor = transaction.CreateCursor(memory_map.handle)

        cursor.AsEnumerable()
        |> Seq.map (fun struct (mdb_key, _) -> mdb_key.to_byte_array)
        |> Seq.toArray

    let Fold_Keys_by_Memory_Map (memory_map: Lightning_Memory_Map) (folder: 'State -> byte array -> 'State) (initial_state: 'State) =
        fun (transaction: LightningTransaction) ->

            use cursor = transaction.CreateCursor(memory_map.handle)

            cursor.AsEnumerable()
            |> Seq.fold (fun state struct (mdb_key, _) -> folder state mdb_key.to_byte_array) initial_state

    let String_by_Lexical_Form_ID (lexical_form_id: Lexical_Form_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Lexical_Form_ID'String_Bytes.handle, lexical_form_id |> Lexical_Form_ID.to_byte_array) with
        | struct (MDBResultCode.Success, _, value) -> value.to_byte_array |> String.from_byte_array

        | struct (MDBResultCode.NotFound, _, _) -> failwith $"No string found for lexical form ID: {lexical_form_id}"

        | struct (result_code, _, _) -> failwith $"Get Lexical_Form_ID -> String failed with MDBResultCode: {result_code}"

    let Triple_by_Triple_ID (triple_id: Triple_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Triple_ID'Triple.handle, triple_id |> Triple_ID.to_byte_array) with
        | struct (MDBResultCode.Success, _, value) ->
            value.to_byte_array
            |> Message_Pack.deserialize<Triple>

        | struct (MDBResultCode.NotFound, _, _) -> failwith $"No triple found for triple ID: {triple_id}"

        | struct (result_code, _, _) -> failwith $"Get Triple_ID -> Triple failed with MDBResultCode: {result_code}"

    let Term_ID_by_Term (term_case: 'TermCase) (transaction: LightningTransaction) =
        let term_case_encoding = Message_Pack.serialize term_case

        match transaction.Get(Lightning_Memory_Map.Term_Case'Term_ID.handle, term_case_encoding) with
        | struct (MDBResultCode.Success, _, mdb_term_id) -> Term_ID.from_mdb_value mdb_term_id

        | struct (MDBResultCode.NotFound, _, _) -> failwith $"No term id found for term case : {term_case}"

        | struct (result_code, _, _) -> failwith $"Get Term Case -> Term ID failed with MDBResultCode: {result_code}"



module Skolem_IRI =


    let new_uuidv7 () = Uuid.NewSequential().ToString("N")

    let mint (transaction: LightningTransaction) =

        let well_known = Lexical_Form.from_string well_known_base transaction
        let uuidv7 = Lexical_Form.from_string (new_uuidv7 ()) transaction

        { well_known_id = well_known.lexical_form_id
          uuidv7_id = uuidv7.lexical_form_id }

    let nq (skolem_iri: Skolem_IRI) (transaction: LightningTransaction) =

        let well_known_base =
            Get.String_by_Lexical_Form_ID skolem_iri.well_known_id transaction

        let uuidv7 = Get.String_by_Lexical_Form_ID skolem_iri.uuidv7_id transaction
        $"<{well_known_base}{uuidv7}>"










































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
        | struct (MDBResultCode.NotFound, _, _) -> failwith $"Get Term ID -> Term  with term id {term_id} not found in memory map {Lightning_Memory_Map.Term_ID'Term.name}"
        | struct (result_code, _, _) -> failwith $"Get Term ID -> Term  failed with MDBResultCode: {result_code}"

    let try_from_id (term_id: Term_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.Term_ID'Term.handle, term_id |> Term_ID.to_byte_array) with
        | struct (MDBResultCode.Success, _, mdb_term) -> Some(Message_Pack.deserialize<RDF_Term> mdb_term.to_byte_array)
        | struct (MDBResultCode.NotFound, _, _) -> None
        | struct (result_code, _, _) -> failwith $"Get Term ID -> Term  failed with MDBResultCode: {result_code}"

    let private intern_term_case (term_case: 'TermCase) (make_term: Term_ID -> 'TermCase -> RDF_Term) (transaction: LightningTransaction) =
        let term_case_encoding = Message_Pack.serialize term_case

        match transaction.Get(Lightning_Memory_Map.Term_Case'Term_ID.handle, term_case_encoding) with
        | struct (MDBResultCode.Success, _, mdb_term_id) ->
            let term_id = Term_ID.from_mdb_value mdb_term_id

            make_term term_id term_case

        | struct (MDBResultCode.NotFound, _, _) ->
            let term_id = ID.next_term_id transaction |> Term_ID.from_uint64

            let term = make_term term_id term_case

            transaction.Put(Lightning_Memory_Map.Term_ID'Term.handle, term_id |> Term_ID.to_byte_array, Message_Pack.serialize term)
            |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

            transaction.Put(Lightning_Memory_Map.Term_Case'Term_ID.handle, term_case_encoding, term_id |> Term_ID.to_byte_array)
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
    let nq (namespaced_iri: Namespaced_IRI) (transaction: LightningTransaction) =


        let namespace_name =
            Get.String_by_Lexical_Form_ID namespaced_iri.namespace_name_id transaction

        let local_name =
            Get.String_by_Lexical_Form_ID namespaced_iri.local_name_id transaction

        $"<{namespace_name}{local_name}>"


module Atomic_IRI =
    let nq (atomic_iri: Atomic_IRI) (transaction: LightningTransaction) =

        let lexical_form =
            Get.String_by_Lexical_Form_ID atomic_iri.lexical_form_id transaction

        $"<{lexical_form}>"

    let from_string (iri_string: string) (transaction: LightningTransaction) : Atomic_IRI =
        let form = Lexical_Form.from_string iri_string transaction
        { lexical_form_id = form.lexical_form_id }

    let term_from_string (iri_string: string) (transaction: LightningTransaction) : RDF_Term =
        RDF_Term.from_atomic_iri (from_string iri_string transaction) transaction

module Escaped =

    let literal_string (value: string) =
        let builder = StringBuilder(value.Length)

        for character in value do
            match character with
            | '\\' -> builder.Append("\\\\") |> ignore

            | '"' -> builder.Append("\\\"") |> ignore

            | '\n' -> builder.Append("\\n") |> ignore

            | '\r' -> builder.Append("\\r") |> ignore

            | '\t' -> builder.Append("\\t") |> ignore

            | _ -> builder.Append(character) |> ignore

        builder.ToString()

module Simple_Literal =
    let nq (simple_literal: Simple_Literal) (transaction: LightningTransaction) =
        let lexical_form =
            Get.String_by_Lexical_Form_ID simple_literal.lexical_form_id transaction

        let escaped_form = Escaped.literal_string lexical_form
        $"\"{escaped_form}\"^^<http://www.w3.org/2001/XMLSchema#string>"


module Datatyped_Literal =
    let nq (datatyped_literal: Datatyped_Literal) (transaction: LightningTransaction) =

        let lexical_form =
            Get.String_by_Lexical_Form_ID datatyped_literal.lexical_form_id transaction
        let escaped_form = Escaped.literal_string lexical_form
        let datatype_term = RDF_Term.from_id datatyped_literal.datatype_id transaction

        let datatype_nq =
            match datatype_term with
            | RDF_Term.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term transaction
            | RDF_Term.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term transaction
            | RDF_Term.FromSkolemIRI (term_id, term) -> Skolem_IRI.nq term transaction
            | _ -> failwith $"datatyped literal {datatyped_literal} must have iri datatype"


        $"\"{escaped_form}\"^^{datatype_nq}"


module Language_String =
    let nq (language_string: Language_String) (transaction: LightningTransaction) =

        let lexical_form =
            Get.String_by_Lexical_Form_ID language_string.lexical_form_id transaction

        let escaped_form = Escaped.literal_string lexical_form

        $"\"{escaped_form}\"@{language_string.language.ToString()}"


    module Directed =
        let nq (directed_language_string: Directed_Language_String) (transaction: LightningTransaction) =
            let lexical_form =
                Get.String_by_Lexical_Form_ID directed_language_string.lexical_form_id transaction

            let escaped_form = Escaped.literal_string lexical_form

            $"\"{escaped_form}\"@{directed_language_string.language.ToString()}-{directed_language_string.direction.ToString()}"


module Region_String =
    let nq (region_string: Region_String) (transaction: LightningTransaction) =
        let lexical_form =
            Get.String_by_Lexical_Form_ID region_string.lexical_form_id transaction


        let escaped_form = Escaped.literal_string lexical_form
        $"\"{escaped_form}\"@{region_string.language.ToString()}-{region_string.region.ToString()}"


    module Directed =
        let nq (directed_region_string: Directed_Region_String) (transaction: LightningTransaction) =
            let lexical_form =
                Get.String_by_Lexical_Form_ID directed_region_string.lexical_form_id transaction

            let escaped_form = Escaped.literal_string lexical_form
            $"\"{escaped_form}\"@{directed_region_string.language.ToString()}-{directed_region_string.region.ToString()}-{directed_region_string.direction.ToString()}"


module RDF_Subject =
    let from_term (subject_term: RDF_Term) =
        match subject_term with
        | RDF_Term.FromNamespacedIRI (term_id, term) -> RDF_Subject.FromNamespacedIRI(term_id, term)
        | RDF_Term.FromAtomicIRI (term_id, term) -> RDF_Subject.FromAtomicIRI(term_id, term)
        | RDF_Term.FromSkolemIRI (term_id, term) -> RDF_Subject.FromSkolemIRI(term_id, term)
        | _ -> failwith $"{subject_term} is not a normative subject for an rdf triple "

    let term (subject: RDF_Subject) =
        match subject with
        | RDF_Subject.FromNamespacedIRI (term_id, term) -> RDF_Term.FromNamespacedIRI(term_id, term)
        | RDF_Subject.FromAtomicIRI (term_id, term) -> RDF_Term.FromAtomicIRI(term_id, term)
        | RDF_Subject.FromSkolemIRI (term_id, term) -> RDF_Term.FromSkolemIRI(term_id, term)

    let term_id (subject: RDF_Subject) =
        match subject with
        | RDF_Subject.FromNamespacedIRI (term_id, term) -> term_id
        | RDF_Subject.FromAtomicIRI (term_id, term) -> term_id
        | RDF_Subject.FromSkolemIRI (term_id, term) -> term_id

    let nq (subject: RDF_Subject) (transaction: LightningTransaction) =
        match subject with
        | RDF_Subject.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term transaction
        | RDF_Subject.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term transaction
        | RDF_Subject.FromSkolemIRI (term_id, term) -> Skolem_IRI.nq term transaction

    let string_value (subject: RDF_Subject) (transaction: LightningTransaction) =
        match subject with
        | RDF_Subject.FromNamespacedIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.local_name_id transaction
        | RDF_Subject.FromAtomicIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Subject.FromSkolemIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.uuidv7_id transaction

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

    let term (predicate: RDF_Predicate) =
        match predicate with
        | RDF_Predicate.FromNamespacedIRI (term_id, term) -> RDF_Term.FromNamespacedIRI(term_id, term)
        | RDF_Predicate.FromAtomicIRI (term_id, term) -> RDF_Term.FromAtomicIRI(term_id, term)

    let nq (predicate: RDF_Predicate) (transaction: LightningTransaction) =
        match predicate with
        | RDF_Predicate.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term transaction
        | RDF_Predicate.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term transaction

    let string_value (predicate: RDF_Predicate) (transaction: LightningTransaction) =
        match predicate with
        | RDF_Predicate.FromNamespacedIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.local_name_id transaction
        | RDF_Predicate.FromAtomicIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction

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

    let term (object: RDF_Object) =
        match object with
        | RDF_Object.FromNamespacedIRI (term_id, term) -> RDF_Term.FromNamespacedIRI(term_id, term)
        | RDF_Object.FromAtomicIRI (term_id, term) -> RDF_Term.FromAtomicIRI(term_id, term)
        | RDF_Object.FromSkolemIRI (term_id, term) -> RDF_Term.FromSkolemIRI(term_id, term)
        | RDF_Object.FromSimpleLiteral (term_id, term) -> RDF_Term.FromSimpleLiteral(term_id, term)
        | RDF_Object.FromDatatypedLiteral (term_id, term) -> RDF_Term.FromDatatypedLiteral(term_id, term)
        | RDF_Object.FromLanguageString (term_id, term) -> RDF_Term.FromLanguageString(term_id, term)
        | RDF_Object.FromRegionString (term_id, term) -> RDF_Term.FromRegionString(term_id, term)
        | RDF_Object.FromDirectedLanguageString (term_id, term) -> RDF_Term.FromDirectedLanguageString(term_id, term)
        | RDF_Object.FromDirectedRegionString (term_id, term) -> RDF_Term.FromDirectedRegionString(term_id, term)
        | RDF_Object.FromTripleTerm (term_id, triple_id) -> RDF_Term.FromTripleTerm(term_id, triple_id)

    let rec nq (object: RDF_Object) (transaction: LightningTransaction) =
        match object with
        | RDF_Object.FromNamespacedIRI (term_id, term) -> Namespaced_IRI.nq term transaction
        | RDF_Object.FromAtomicIRI (term_id, term) -> Atomic_IRI.nq term transaction
        | RDF_Object.FromSkolemIRI (term_id, term) -> Skolem_IRI.nq term transaction
        | RDF_Object.FromSimpleLiteral (term_id, term) -> Simple_Literal.nq term transaction
        | RDF_Object.FromDatatypedLiteral (term_id, term) -> Datatyped_Literal.nq term transaction
        | RDF_Object.FromLanguageString (term_id, term) -> Language_String.nq term transaction
        | RDF_Object.FromRegionString (term_id, term) -> Region_String.nq term transaction
        | RDF_Object.FromDirectedLanguageString (term_id, term) -> Language_String.Directed.nq term transaction
        | RDF_Object.FromDirectedRegionString (term_id, term) -> Region_String.Directed.nq term transaction
        | RDF_Object.FromTripleTerm (term_id, triple_id) ->
            let triple = Get.Triple_by_Triple_ID triple_id transaction
            let subject = RDF_Subject.nq triple.subject transaction
            let predicate = RDF_Predicate.nq triple.predicate transaction
            let object = nq triple.object transaction
            $"<<({subject} {predicate} {object})>>"

    let rec string_value (object: RDF_Object) (transaction: LightningTransaction) =
        match object with
        | RDF_Object.FromNamespacedIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.local_name_id transaction
        | RDF_Object.FromAtomicIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Object.FromSkolemIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.uuidv7_id transaction
        | RDF_Object.FromSimpleLiteral (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Object.FromDatatypedLiteral (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Object.FromLanguageString (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Object.FromRegionString (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Object.FromDirectedLanguageString (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Object.FromDirectedRegionString (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id transaction
        | RDF_Object.FromTripleTerm (term_id, triple_id) ->
            let triple = Get.Triple_by_Triple_ID triple_id transaction
            let subject = RDF_Subject.string_value triple.subject transaction
            let predicate = RDF_Predicate.string_value triple.predicate transaction
            let object = string_value triple.object transaction
            $"{subject} {predicate} {object}"


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

    let nt (triple: Triple) (transaction: LightningTransaction) =
        $"{RDF_Subject.nq triple.subject transaction} {RDF_Predicate.nq triple.predicate transaction} {RDF_Object.nq triple.object transaction} ."

module Graph_Name =
    let default_graph_term =
        lmdb_read_write { return! RDF_Term.from_graph_name Graph_Name.DefaultGraph }

    let from_term (graph_term: RDF_Term) =
        match graph_term with
        | RDF_Term.FromNamespacedIRI (term_id, term) -> term_id, Graph_Name.FromNamespacedIRI(term)
        | RDF_Term.FromAtomicIRI (term_id, term) -> term_id, Graph_Name.FromAtomicIRI(term)
        | RDF_Term.FromSkolemIRI (term_id, term) -> term_id, Graph_Name.FromSkolemIRI(term)
        | RDF_Term.FromGraphName (term_id, Graph_Name.DefaultGraph) -> term_id, Graph_Name.DefaultGraph
        | RDF_Term.FromGraphName (term_id, Graph_Name.FromNamespacedIRI term) -> term_id, Graph_Name.FromNamespacedIRI term
        | RDF_Term.FromGraphName (term_id, Graph_Name.FromAtomicIRI term) -> term_id, Graph_Name.FromAtomicIRI term
        | RDF_Term.FromGraphName (term_id, Graph_Name.FromSkolemIRI term) -> term_id, Graph_Name.FromSkolemIRI term
        | _ -> failwith $"{graph_term} is not a normative graph for an rdf triple "

    let term (graph_name: Graph_Name) (transaction: LightningTransaction) =
        match graph_name with
        | Graph_Name.FromNamespacedIRI term ->
            let term_id = Get.Term_ID_by_Term term transaction
            RDF_Term.FromNamespacedIRI(term_id, term)
        | Graph_Name.FromAtomicIRI term ->
            let term_id = Get.Term_ID_by_Term term transaction
            RDF_Term.FromAtomicIRI(term_id, term)
        | Graph_Name.FromSkolemIRI term ->
            let term_id = Get.Term_ID_by_Term term transaction
            RDF_Term.FromSkolemIRI(term_id, term)
        | Graph_Name.DefaultGraph -> default_graph_term

    let nq (graph_name: Graph_Name) (transaction: LightningTransaction) =
        match graph_name with
        | Graph_Name.DefaultGraph -> String.Empty
        | Graph_Name.FromNamespacedIRI term -> Namespaced_IRI.nq term transaction
        | Graph_Name.FromAtomicIRI term -> Atomic_IRI.nq term transaction
        | Graph_Name.FromSkolemIRI term -> Skolem_IRI.nq term transaction

module Quad_Key =

    let tg (triple_id: Triple_ID) (graph_name_id: Term_ID) =
        Array.concat [| Triple_ID.to_byte_array triple_id
                        Term_ID.to_byte_array graph_name_id |]

    let gt (graph_name_id: Term_ID) (triple_id: Triple_ID) =
        Array.concat [| Term_ID.to_byte_array graph_name_id
                        Triple_ID.to_byte_array triple_id |]

    let from_tg_key (key: byte array) =
        if key.Length <> 32 then
            failwith $"TG key must be 32 bytes, but was {key.Length} bytes."

        let triple_id = key[0..23] |> Triple_ID.from_byte_array

        let graph_name_id = key[24..31] |> Term_ID.from_byte_array

        triple_id, graph_name_id

    let from_gt_key (key: byte array) =
        if key.Length <> 32 then
            failwith $"GT key must be 32 bytes, but was {key.Length} bytes."

        let graph_name_id = key[0..7] |> Term_ID.from_byte_array

        let triple_id = key[8..31] |> Triple_ID.from_byte_array

        graph_name_id, triple_id


























module rdf =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/1999/02/22-rdf-syntax-ns#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =

        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    /// The class of containers of alternatives.
    let Alt = _vocab "Alt"


    /// The class of unordered containers.
    let Bag = _vocab "Bag"


    /// A class representing a compound literal.
    let CompoundLiteral = _vocab "CompoundLiteral"


    /// The datatype of RDF literals storing fragments of HTML content
    let HTML = _vocab "HTML"


    /// The datatype of RDF literals storing JSON content.
    let JSON = _vocab "JSON"


    /// The class of RDF Lists.
    let List = _vocab "List"


    /// The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    let PlainLiteral = _vocab "PlainLiteral"


    /// The class of RDF properties.
    let Property = _vocab "Property"


    /// The class of ordered containers.
    let Seq = _vocab "Seq"


    /// The class of RDF statements.
    let Statement = _vocab "Statement"


    /// The datatype of XML literal values.
    let XMLLiteral = _vocab "XMLLiteral"


    /// The base direction component of a CompoundLiteral.
    let direction = _vocab "direction"


    /// The first item in the subject RDF list.
    let first = _vocab "first"


    /// The datatype of language-tagged string values
    let langString = _vocab "langString"


    /// The language component of a CompoundLiteral.
    let language = _vocab "language"


    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    let nil = _vocab "nil"


    /// The object of the subject RDF statement.
    let object = _vocab "object"


    /// The predicate of the subject RDF statement.
    let predicate = _vocab "predicate"


    /// The rest of the subject RDF list after the first item.
    let rest = _vocab "rest"


    /// The subject of the subject RDF statement.
    let subject = _vocab "subject"


    /// The subject is an instance of a class.
    let ``type`` = _vocab "type"


    /// Idiomatic property used for structured values.
    let value = _vocab "value"

let is_a = rdf.``type``





module rdfs =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2000/01/rdf-schema#" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

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
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

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
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

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
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

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
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

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
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

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



module skos =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2004/02/skos/core#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let Collection = _vocab "Collection"



    let Concept = _vocab "Concept"



    let ConceptScheme = _vocab "ConceptScheme"



    let OrderedCollection = _vocab "OrderedCollection"



    let broadMatch = _vocab "broadMatch"



    let broaderTransitive = _vocab "broaderTransitive"



    let changeNote = _vocab "changeNote"



    let closeMatch = _vocab "closeMatch"



    let definition = _vocab "definition"



    let editorialNote = _vocab "editorialNote"



    let example = _vocab "example"



    let hasTopConcept = _vocab "hasTopConcept"



    let historyNote = _vocab "historyNote"



    let inScheme = _vocab "inScheme"



    let ``member`` = _vocab "member"



    let narrowMatch = _vocab "narrowMatch"



    let narrowerTransitive = _vocab "narrowerTransitive"



    let notation = _vocab "notation"



    let note = _vocab "note"



    let relatedMatch = _vocab "relatedMatch"



    let scopeNote = _vocab "scopeNote"



    let semanticRelation = _vocab "semanticRelation"



    let topConceptOf = _vocab "topConceptOf"


    /// A resource has no more than one value of skos:prefLabel per language tag, and no more than one value of skos:prefLabel without language tag.
    let prefLabel = _vocab "prefLabel"


    /// Broader concepts are typically rendered as parents in a concept hierarchy (tree).
    let broader = _vocab "broader"


    /// For any resource, every item in the list given as the value of the
    ///       skos:memberList property is also a value of the skos:member property.
    let memberList = _vocab "memberList"


    /// Narrower concepts are typically rendered as children in a concept hierarchy (tree).
    let narrower = _vocab "narrower"


    /// The range of skos:altLabel is the class of RDF plain literals.
    let altLabel = _vocab "altLabel"


    /// The range of skos:hiddenLabel is the class of RDF plain literals.
    let hiddenLabel = _vocab "hiddenLabel"




    /// These concept mapping relations mirror semantic relations, and the data model defined below is similar (with the exception of skos:exactMatch) to the data model defined for semantic relations. A distinct vocabulary is provided for concept mapping relations, to provide a convenient way to differentiate links within a concept scheme from links between concept schemes. However, this pattern of usage is not a formal requirement of the SKOS data model, and relies on informal definitions of best practice.
    let mappingRelation = _vocab "mappingRelation"


    /// skos:exactMatch is disjoint with each of the properties skos:broadMatch and skos:relatedMatch.
    let exactMatch = _vocab "exactMatch"




    /// skos:related is disjoint with skos:broaderTransitive
    let related = _vocab "related"

module skosxl =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2008/05/skos-xl#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let Label = _vocab "Label"

    /// If C skosxl:altLabel L and L skosxl:literalForm V, then X skos:altLabel V.
    let altLabel = _vocab "altLabel"

    /// If C skosxl:hiddenLabel L and L skosxl:literalForm V, then C skos:hiddenLabel V.
    let hiddenLabel = _vocab "hiddenLabel"


    let labelRelation = _vocab "labelRelation"

    /// The range of skosxl:literalForm is the class of RDF plain literals.
    let literalForm = _vocab "literalForm"

    /// If C skosxl:prefLabel L and L skosxl:literalForm V, then X skos:prefLabel V.
    let prefLabel = _vocab "prefLabel"


module dce =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://purl.org/dc/elements/1.1/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let value = _vocab ""

    /// An entity responsible for making contributions to the resource.
    let contributor = _vocab "contributor"

    /// The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.
    let coverage = _vocab "coverage"

    /// An entity primarily responsible for making the resource.
    let creator = _vocab "creator"

    /// A point or period of time associated with an event in the lifecycle of the resource.
    let date = _vocab "date"

    /// An account of the resource.
    let description = _vocab "description"

    /// The file format, physical medium, or dimensions of the resource.
    let format = _vocab "format"

    /// An unambiguous reference to the resource within a given context.
    let identifier = _vocab "identifier"

    /// A language of the resource.
    let language = _vocab "language"

    /// An entity responsible for making the resource available.
    let publisher = _vocab "publisher"

    /// A related resource.
    let relation = _vocab "relation"

    /// Information about rights held in and over the resource.
    let rights = _vocab "rights"

    /// A related resource from which the described resource is derived.
    let source = _vocab "source"

    /// The topic of the resource.
    let subject = _vocab "subject"

    /// A name given to the resource.
    let title = _vocab "title"

    /// The nature or genre of the resource.
    let ``type`` = _vocab "type"

module dcterms =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://purl.org/dc/terms/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let value = _vocab ""

    /// A resource that acts or has the power to act.
    let Agent = _vocab "Agent"

    /// A group of agents.
    let AgentClass = _vocab "AgentClass"

    /// A book, article, or other documentary resource.
    let BibliographicResource = _vocab "BibliographicResource"

    /// The set of regions in space defined by their geographic coordinates according to the DCMI Box Encoding Scheme.
    let Box = _vocab "Box"

    /// The set of classes specified by the DCMI Type Vocabulary, used to categorize the nature or genre of the resource.
    let DCMIType = _vocab "DCMIType"

    /// The set of conceptual resources specified by the Dewey Decimal Classification.
    let DDC = _vocab "DDC"

    /// A digital resource format.
    let FileFormat = _vocab "FileFormat"

    /// A rate at which something recurs.
    let Frequency = _vocab "Frequency"

    /// The set of media types specified by the Internet Assigned Numbers Authority.
    let IMT = _vocab "IMT"

    /// The set of codes listed in ISO 3166-1 for the representation of names of countries.
    let ISO3166 = _vocab "ISO3166"

    /// The three-letter alphabetic codes listed in ISO639-2 for the representation of names of languages.
    let ISO639_2 = _vocab "ISO639-2"

    /// The set of three-letter codes listed in ISO 639-3 for the representation of names of languages.
    let ISO639_3 = _vocab "ISO639-3"

    /// The extent or range of judicial, law enforcement, or other authority.
    let Jurisdiction = _vocab "Jurisdiction"

    /// The set of conceptual resources specified by the Library of Congress Classification.
    let LCC = _vocab "LCC"

    /// The set of labeled concepts specified by the Library of Congress Subject Headings.
    let LCSH = _vocab "LCSH"

    /// A legal document giving official permission to do something with a Resource.
    let LicenseDocument = _vocab "LicenseDocument"

    /// A system of signs, symbols, sounds, gestures, or rules used in communication.
    let LinguisticSystem = _vocab "LinguisticSystem"

    /// A spatial region or named place.
    let Location = _vocab "Location"

    /// A location, period of time, or jurisdiction.
    let LocationPeriodOrJurisdiction = _vocab "LocationPeriodOrJurisdiction"

    /// The set of labeled concepts specified by the Medical Subject Headings.
    let MESH = _vocab "MESH"

    /// A file format or physical medium.
    let MediaType = _vocab "MediaType"

    /// A media type or extent.
    let MediaTypeOrExtent = _vocab "MediaTypeOrExtent"

    /// A method by which resources are added to a collection.
    let MethodOfAccrual = _vocab "MethodOfAccrual"

    /// A process that is used to engender knowledge, attitudes, and skills.
    let MethodOfInstruction = _vocab "MethodOfInstruction"

    /// The set of conceptual resources specified by the National Library of Medicine Classification.
    let NLM = _vocab "NLM"

    /// The set of time intervals defined by their limits according to the DCMI Period Encoding Scheme.
    let Period = _vocab "Period"

    /// An interval of time that is named or defined by its start and end dates.
    let PeriodOfTime = _vocab "PeriodOfTime"

    /// A physical material or carrier.
    let PhysicalMedium = _vocab "PhysicalMedium"

    /// A material thing.
    let PhysicalResource = _vocab "PhysicalResource"

    /// The set of points in space defined by their geographic coordinates according to the DCMI Point Encoding Scheme.
    let Point = _vocab "Point"

    /// A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters.
    let Policy = _vocab "Policy"

    /// A statement of any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation.
    let ProvenanceStatement = _vocab "ProvenanceStatement"

    /// The set of tags, constructed according to RFC 1766, for the identification of languages.
    let RFC1766 = _vocab "RFC1766"

    /// The set of tags constructed according to RFC 3066 for the identification of languages.
    let RFC3066 = _vocab "RFC3066"

    /// The set of tags constructed according to RFC 4646 for the identification of languages.
    let RFC4646 = _vocab "RFC4646"

    /// The set of tags constructed according to RFC 5646 for the identification of languages.
    let RFC5646 = _vocab "RFC5646"

    /// A statement about the intellectual property rights (IPR) held in or over a Resource, a legal document giving official permission to do something with a resource, or a statement about access rights.
    let RightsStatement = _vocab "RightsStatement"

    /// A dimension or extent, or a time taken to play or execute.
    let SizeOrDuration = _vocab "SizeOrDuration"

    /// A basis for comparison; a reference point against which other things can be evaluated.
    let Standard = _vocab "Standard"

    /// The set of places specified by the Getty Thesaurus of Geographic Names.
    let TGN = _vocab "TGN"

    /// The set of conceptual resources specified by the Universal Decimal Classification.
    let UDC = _vocab "UDC"

    /// The set of identifiers constructed according to the generic syntax for Uniform Resource Identifiers as specified by the Internet Engineering Task Force.
    let URI = _vocab "URI"

    /// The set of dates and times constructed according to the W3C Date and Time Formats Specification.
    let W3CDTF = _vocab "W3CDTF"

    /// A summary of the resource.
    let ``abstract`` = _vocab "abstract"

    /// Information about who can access the resource or an indication of its security status.
    let accessRights = _vocab "accessRights"

    /// The method by which items are added to a collection.
    let accrualMethod = _vocab "accrualMethod"

    /// The frequency with which items are added to a collection.
    let accrualPeriodicity = _vocab "accrualPeriodicity"

    /// The policy governing the addition of items to a collection.
    let accrualPolicy = _vocab "accrualPolicy"

    /// An alternative name for the resource.
    let alternative = _vocab "alternative"

    /// A class of entity for whom the resource is intended or useful.
    let audience = _vocab "audience"

    /// Date (often a range) that the resource became or will become available.
    let available = _vocab "available"

    /// A bibliographic reference for the resource.
    let bibliographicCitation = _vocab "bibliographicCitation"

    /// An established standard to which the described resource conforms.
    let conformsTo = _vocab "conformsTo"

    /// An entity responsible for making contributions to the resource.
    let contributor = _vocab "contributor"

    /// The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.
    let coverage = _vocab "coverage"

    /// Date of creation of the resource.
    let created = _vocab "created"

    /// An entity primarily responsible for making the resource.
    let creator = _vocab "creator"

    /// A point or period of time associated with an event in the lifecycle of the resource.
    let date = _vocab "date"

    /// Date of acceptance of the resource.
    let dateAccepted = _vocab "dateAccepted"

    /// Date of copyright.
    let dateCopyrighted = _vocab "dateCopyrighted"

    /// Date of submission of the resource.
    let dateSubmitted = _vocab "dateSubmitted"

    /// An account of the resource.
    let description = _vocab "description"

    /// A class of entity, defined in terms of progression through an educational or training context, for which the described resource is intended.
    let educationLevel = _vocab "educationLevel"

    /// The size or duration of the resource.
    let extent = _vocab "extent"

    /// The file format, physical medium, or dimensions of the resource.
    let format = _vocab "format"

    /// A related resource that is substantially the same as the pre-existing described resource, but in another format.
    let hasFormat = _vocab "hasFormat"

    /// A related resource that is included either physically or logically in the described resource.
    let hasPart = _vocab "hasPart"

    /// A related resource that is a version, edition, or adaptation of the described resource.
    let hasVersion = _vocab "hasVersion"

    /// An unambiguous reference to the resource within a given context.
    let identifier = _vocab "identifier"

    /// A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support.
    let instructionalMethod = _vocab "instructionalMethod"

    /// A related resource that is substantially the same as the described resource, but in another format.
    let isFormatOf = _vocab "isFormatOf"

    /// A related resource in which the described resource is physically or logically included.
    let isPartOf = _vocab "isPartOf"

    /// A related resource that references, cites, or otherwise points to the described resource.
    let isReferencedBy = _vocab "isReferencedBy"

    /// A related resource that supplants, displaces, or supersedes the described resource.
    let isReplacedBy = _vocab "isReplacedBy"

    /// A related resource that requires the described resource to support its function, delivery, or coherence.
    let isRequiredBy = _vocab "isRequiredBy"

    /// A related resource of which the described resource is a version, edition, or adaptation.
    let isVersionOf = _vocab "isVersionOf"

    /// Date of formal issuance (e.g., publication) of the resource.
    let issued = _vocab "issued"

    /// A language of the resource.
    let language = _vocab "language"

    /// A legal document giving official permission to do something with the resource.
    let license = _vocab "license"

    /// An entity that mediates access to the resource and for whom the resource is intended or useful.
    let mediator = _vocab "mediator"

    /// The material or physical carrier of the resource.
    let medium = _vocab "medium"

    /// Date on which the resource was changed.
    let modified = _vocab "modified"

    /// A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation.
    let provenance = _vocab "provenance"

    /// An entity responsible for making the resource available.
    let publisher = _vocab "publisher"

    /// A related resource that is referenced, cited, or otherwise pointed to by the described resource.
    let references = _vocab "references"

    /// A related resource.
    let relation = _vocab "relation"

    /// A related resource that is supplanted, displaced, or superseded by the described resource.
    let replaces = _vocab "replaces"

    /// A related resource that is required by the described resource to support its function, delivery, or coherence.
    let requires = _vocab "requires"

    /// Information about rights held in and over the resource.
    let rights = _vocab "rights"

    /// A person or organization owning or managing rights over the resource.
    let rightsHolder = _vocab "rightsHolder"

    /// A related resource from which the described resource is derived.
    let source = _vocab "source"

    /// Spatial characteristics of the resource.
    let spatial = _vocab "spatial"

    /// The topic of the resource.
    let subject = _vocab "subject"

    /// A list of subunits of the resource.
    let tableOfContents = _vocab "tableOfContents"

    /// Temporal characteristics of the resource.
    let temporal = _vocab "temporal"

    /// A name given to the resource.
    let title = _vocab "title"

    /// The nature or genre of the resource.
    let ``type`` = _vocab "type"

    /// Date (often a range) of validity of a resource.
    let valid = _vocab "valid"



module vartrans =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/lemon/vartrans#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// ????????? ????? ????? ?????????
    let ConceptualRelation = _vocab "ConceptualRelation"

    /// '??????????? ?????????' - ??? ???????-????????????? ?????????, ??????? ???????????? ????? ????????? ????? ????? ?????????? ?????????, ????????????? ????? ??????? ??????? ?????????????, ????????????? ??? ????? ?????????, ????????????? ??????????????? ?????????.
    let LexicalRelation = _vocab "LexicalRelation"

    /// '???????-????????????? ?????????' ???????????? ????? ????? ????? ????? ?????????? ????????? ??? ???????????? ????????, ??????? ??????? ?????? ???????????? ??? ?????????????? ???????????.
    let LexicoSemanticRelation = _vocab "LexicoSemanticRelation"

    /// '????????? ???????' (SenseRelation) - ??? ???????-????????????? ?????????, ??????? ???????????? ????? ????? ????? ????? ???????????? ????????, ???????? ??????? ??????? ????? ?????.
    let SenseRelation = _vocab "SenseRelation"

    /// A 'terminological relation' is a sense relation that relates two lexical senses of terms that are semantically related in the sense that they can be exchanged in most contexts, but their surface forms are not directly related. The variants vary along dimensions that are not captured by the given ontology and are intentionally (pragmatically) caused.
    let TerminologicalRelation = _vocab "TerminologicalRelation"

    /// '???????' ???????????? ????? '????????? ???????', ????????????, ??? ??? ??????????? ??????, ??????????????? ???? ????????? ???????? ? ?????? ??????, ????? ???? ??????? ?????????? ??? ?????-???? ???????????? ????????? ??????.
    let Translation = _vocab "Translation"

    /// '????? ?????????' - ??? ???????????? ?????????, ??????? ????? ????? ????????.
    let TranslationSet = _vocab "TranslationSet"

    /// The 'category' property indicates the specific type of relation by which two lexical entries or two lexical senses are related.
    let category = _vocab "category"

    /// A relationship between two concepts
    let conceptRel = _vocab "conceptRel"


    let imports = _vocab "imports"

    /// The 'lexicalRel' property relates two lexical entries that stand in some lexical relation.
    let lexicalRel = _vocab "lexicalRel"

    /// The 'relates' property links a lexico-semantic relation to the two lexical entries or lexical senses between which it establishes the relation.
    let relates = _vocab "relates"

    /// ???????? '????????? ???????' (senseRel) ????????? ??? ??????????? ??????, ??????? ????????? ? ????????? ????????? ?????.
    let senseRel = _vocab "senseRel"

    /// ???????? '????????' ?????????? ??????????? ????? ??? ????????? ???????, ??????????? ? ???????-????????????? ????????? ??? '????????'.
    let source = _vocab "source"

    /// ???????? '????' ?????????? ??????????? ????? ??? ????????? ???????, ??????????? ? ???????-????????????? ????????? ??? '????'.
    let target = _vocab "target"

    /// ???????? '???????' ????????? ?????????????? ? ????? ?? ??? ?????????.
    let trans = _vocab "trans"

    /// ???????? '??????????? ???' ????????? ????????? ??????? ?? ?????-???? ????? ?? ????????? ???????? ?? ?????? ?????, ?? ??????? ??? ????? ???? ?????????? ??????????????? ??????? ? ??????????? ?? ??????????? ????????? ? ????????????? ??????? ?????? ????????? ??????.
    let translatableAs = _vocab "translatableAs"

    /// The 'translation' property relates two lexical senses of two lexical entries that stand in a translation relation to one another.
    let translation = _vocab "translation"


    let versionInfo = _vocab "versionInfo"

module lime =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/lemon/lime#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// ????? ????????? ???????????? ????? ????? ?????? ????? ?????????? ????????? ? ????????? ? ???????????? ????????? ? ?????? ???????, ??????? ??? ????????.
    let ConceptualizationSet = _vocab "ConceptualizationSet"

    /// ??????????? ????? ?????? ???????????? ????? ????? ?????? ????? ??????? ?????? ? ??????? ??????????? ??????? (????????, synsets of wordnet)
    let LexicalLinkset = _vocab "LexicalLinkset"

    /// A 'lexicalization set' is a dataset that comprises a collection of lexicalizations, that is pairs of lexical entry and corresponding reference in the associated ontology/vocabulary/dataset.
    let LexicalizationSet = _vocab "LexicalizationSet"

    /// ???????? ???????????? ????? ????? ????????? ?????? ??? ????????????? ????? ??? ??????.
    let Lexicon = _vocab "Lexicon"

    /// ???????? '??????? ???????????????' ????????? ??????? ????? ??????????? ???????, ?????????? ?????? ??????/???????????? ?????? ? ?????????.
    let avgAmbiguity = _vocab "avgAmbiguity"

    /// The 'average number of lexicalizations' property indicate the average number of lexicalizations per ontology element. The exact formula for calculating the average is indicated in the specification: https://www.w3.org/community/ontolex/wiki/Final_Model_Specification#LexicalizationSet
    let avgNumOfLexicalizations = _vocab "avgNumOfLexicalizations"

    /// The 'average number of links' property indicates the average number of links for each entity in the conceptual dataset.
    let avgNumOfLinks = _vocab "avgNumOfLinks"

    /// ???????? '??????? ?????????' ????????? ??????? ????? ????????? ??????, ?????????? ?????? ??????????? ??????? ? ?????? ???????.
    let avgSynonymy = _vocab "avgSynonymy"

    /// The 'concepts' property indicates the number of lexical concepts defined in a concept set or involved in either a LexicalLinkset or ConceptualizationSet.
    let concepts = _vocab "concepts"

    /// ???????? '?????????????? ????? ??????' ????????? ????? ??????????? ????? ??? ???????????????? ? ??????????????? ??????? ???????.
    let conceptualDataset = _vocab "conceptualDataset"

    /// The 'conceptualizations' property indicates the number of distinct conceptualizations in a conceptualization set.
    let conceptualizations = _vocab "conceptualizations"

    /// ???????? '??????' ????????? ???????? ? ????? ?? ???????????? ? ??? ????????? ??????.
    let entry = _vocab "entry"

    /// The  'language' property indicates the language of a lexicon, a lexical entry, a concept set or a lexicalization set.
    let language = _vocab "language"

    /// The 'lexical entries' property indicates the number of distinct lexical entries contained in a lexicon or lexicalization set.
    let lexicalEntries = _vocab "lexicalEntries"

    /// The 'lexicalization model' property indicates the model used for representing lexical information. Possible values include (but are not limited to) http://www.w3.org/2000/01/rdf-schema# (for the use of rdfs:label), http://www.w3.org/2004/02/skos/core (for the use of skos:pref/alt/hiddenLabel), http://www.w3.org/2008/05/skos-xl (for the use of skosxl:pref/alt/hiddenLabel) and http://www.w3.org/ns/lemon/all for lemon.
    let lexicalizationModel = _vocab "lexicalizationModel"

    /// The 'lexicalizations' property indicates the total number of lexicalizations in a lexicalization set, that is the number of unique pairs of lexical entry and denoted ontology element.
    let lexicalizations = _vocab "lexicalizations"

    /// The 'lexicon dataset' property indicates the lexicon that contains the entries refered to in a lexicalization set or a conceptualization set.
    let lexiconDataset = _vocab "lexiconDataset"

    /// ???????? '??????????????? ???????' ????????? ??????? ???????? ?????????, ???????????? ? ?????????, ??? ??????????? ??????????????? ??????? ????????? ??????.
    let linguisticCatalog = _vocab "linguisticCatalog"

    /// ???????? '?????' ????????? ?????????? ?????? ????? ????????? ? ?????? ??????? ? ????????? ? ????????? ?????? ??????.
    let links = _vocab "links"

    /// The 'partition' property relates a lexicalization set or lexical linkset to a logical subset that contains lexicalizations for a given ontological type only.
    let partition = _vocab "partition"

    /// The 'percentage' property expresses the percentage of entities in the reference dataset which have at least one lexicalization in a lexicalization set or are linked to a lexical concept in a lexical linkset.
    let percentage = _vocab "percentage"

    /// The 'reference dataset' property indicates the dataset that contains the domain objects or vocabulary elements that are either referenced by a given lexicon, providing the grounding vocabulary for the meaning of the lexical entries, or linked to lexical concepts in a concept set by means of a lexical link set.
    let referenceDataset = _vocab "referenceDataset"

    /// ???????? '??????' ????????? ?????????? ????????? ????????? ??? ????????? ???????, ??????? ???? ??????? ? ???????????? ?????????? ????? ????? ??????????????, ???? ??????? ? ???????????? ????????? ??????????? ?????? ??????????? ?????.
    let references = _vocab "references"

    /// The 'resource type' property indicates the type of ontological entity of a lexicalization set or lexical linkset.
    let resourceType = _vocab "resourceType"

module decomp =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/lemon/decomp#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// A component is a particular realization of a lexical entry that forms part of a compound lexical entry.
    let Component = _vocab "Component"

    /// ???????? '?????????' ????????? ????????? ??????? ??? ????????? ? ???????????, ??????? ?? ????????.
    let constituent = _vocab "constituent"

    /// The property 'correspondsTo' links a component to a corresponding lexical entry or argument.
    let correspondsTo = _vocab "correspondsTo"

    /// The property 'subterm' relates a compound lexical entry to one of the lexical entries it is composed of.
    let subterm = _vocab "subterm"

module ontolex =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/lemon/ontolex#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// An affix is a lexical entry that represents a morpheme (suffix, prefix, infix, circumfix) that is attached to a word stem to form a new word.
    let Affix = _vocab "Affix"

    /// '????? ???????' ???????????? ????? ???????????? ??????????? ???????.
    let ConceptSet = _vocab "ConceptSet"

    /// A form represents one grammatical realization of a lexical entry.
    let Form = _vocab "Form"

    /// '??????????? ???????' ???????????? ??????? ???????????? ????????, ??????? ??? ??????? ?????, ??????? ????? ???? ??????????????? ???????????? ??????? ???????.
    let LexicalConcept = _vocab "LexicalConcept"

    /// A lexical entry represents a unit of analysis of the lexicon that consists of a set of forms that are grammatically related and a set of base meanings that are associated with all of these forms. Thus, a lexical entry is a word, multiword expression or affix with a single part-of-speech, morphological pattern, etymology and set of senses.
    let LexicalEntry = _vocab "LexicalEntry"

    /// A lexical sense represents the lexical meaning of a lexical entry when interpreted as referring to the corresponding ontology element. A lexical sense thus represents a reification of a pair of a uniquely determined lexical entry and a uniquely determined ontology entity it refers to. A link between a lexical entry and an ontology entity via a Lexical Sense object implies that the lexical entry can be used to refer to the ontology entity in question.
    let LexicalSense = _vocab "LexicalSense"

    /// '??????????????' - ??? ????????? ???????, ????????? ?? ???? ??? ????? ????.
    let MultiWordExpression = _vocab "MultiWordExpression"

    /// '?????' - ??? ????????? ???????, ????????????? ????? ????????? ?????????? ???????.
    let Word = _vocab "Word"

    /// ???????? '???????????? ?????' ????????? ????????? ??????? ? ?? ???????????? ??? ????????? ??????. ??? ?????? ?????????? "?????" ????????? ???????.
    let canonicalForm = _vocab "canonicalForm"

    /// The 'concept' property relates an ontological entity to a lexical concept that represents the corresponding meaning.
    let concept = _vocab "concept"

    /// ???????? '??????????' ????????? ????????? ??????? ? ?????????? ? ?????????, ??????? ???????????? ?? ???????? ? ???????? ???????????? ??? ?????????-????????? ??????????.
    let denotes = _vocab "denotes"

    /// ???????? '?????????' ????????? ????????? ??????? ? ????? ?? ??????????? ???????, ??????? ??? ?????????, ?? ???? ???????????? ???????, ??????? ????????? ? ???????? ?????????, ????? ??? ?????? ?????? ????????? ???????.
    let evokes = _vocab "evokes"

    /// ??? ???????? ??????????? ???????? '???????????? ???????', ???????? ??? ? ????????? ????????? ? ?????????.
    let isConceptOf = _vocab "isConceptOf"

    /// The object property isDenotedBy is the inverse of the object property denotes.
    let isDenotedBy = _vocab "isDenotedBy"

    /// The inverse relation to evokes.
    let isEvokedBy = _vocab "isEvokedBy"

    /// The object property isLexicalizedSenseOf is the inverse property of lexicalized sense.
    let isLexicalizedSenseOf = _vocab "isLexicalizedSenseOf"

    /// The object property isReferenceOf is the inverse property of reference.
    let isReferenceOf = _vocab "isReferenceOf"

    /// The property isSenseOf is the inverse property of sense.
    let isSenseOf = _vocab "isSenseOf"

    /// The 'lexical form' property relates a lexical entry to one grammatical form variant of the lexical entry.
    let lexicalForm = _vocab "lexicalForm"

    /// ???????? '????????????????? ?????' ????????? ??????????? ??????? ? ??????????????? ??????????? ???????, ??????? ????????????? ???????.
    let lexicalizedSense = _vocab "lexicalizedSense"

    /// The 'morphological pattern' property indicates the morphological class of a word.
    let morphologicalPattern = _vocab "morphologicalPattern"

    /// The  'other form' property relates a lexical entry to a non-preferred ("non-lemma") form that realizes the given lexical entry.
    let otherForm = _vocab "otherForm"

    /// ???????? '???????????? ?????????????' ?????????? ???????????? ????????????? ???????????? ????? ? ?????????????? ?????-???? ?????, ????????, ?????????????? ????????????? ???????? (IPA, ???).
    let phoneticRep = _vocab "phoneticRep"

    /// ???????? '??????????' ????????? ??????????? ????? ? ?????????? ? ?????????, ??????? ???????? ???????? ???????? (??????????????? ????????? ???????).
    let reference = _vocab "reference"

    /// The 'representation' property indicates a string by which the form is represented according to some orthography.
    let representation = _vocab "representation"

    /// The 'sense' property relates a lexical entry to one of its lexical senses.
    let sense = _vocab "sense"

    /// The 'usage' property indicates usage conditions or pragmatic implications when using the lexical entry to refer to the given ontological meaning.
    let usage = _vocab "usage"

    /// ???????? '?????????? ?????????????' ?????????? ?????????? ????????????? ?????.
    let writtenRep = _vocab "writtenRep"

module synsem =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/lemon/synsem#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// '??????????? ?????????' (OntoMap ??? ?????????) ??????????, ??? ?????????????? ????? ? ??? ?????????????? ????????? ?????????????? ? ??????? ??????? ? ??????? ? ?????????, ??????? ?????? ?????????? ???????? ??????????????? ??????.
    let OntoMap = _vocab "OntoMap"

    /// '?????????????? ????????' ???????????? ????? ????, ??????? ?????????? ????????? ??? ????????? ????????????? ??????????????? ??????. ?????????????? ????????? ?????? ????????? ???????????? ?????????????? ??????? (????????, ???????, ?????? ??????, ????????? ??????, ??????????????? ?????? ? ?.?.).
    let SyntacticArgument = _vocab "SyntacticArgument"

    /// A 'syntactic frame' represents the syntactic behavior of an open class word in terms of the (syntactic) arguments it requires. It essentially describes the so called subcategorization structure of the word in question, in particular the syntactic arguments it requires.
    let SyntacticFrame = _vocab "SyntacticFrame"

    /// The 'condition' property defines an evaluable constraint that derives from using a certain lexical entry to express a given ontological predicate.
    let condition = _vocab "condition"

    /// ???????? '?????????' ???????????? ????????? ???????? ?????? ??? ??????? ????????.
    let isA = _vocab "isA"

    /// The 'marker' property indicates the marker of a syntactic argument; this can be a case marker or some other lexical entry such as a preposition or particle.
    let marker = _vocab "marker"

    /// The 'objOfProp' represents the 2nd argument or object of a binary predicate (property) in the ontology.
    let objOfProp = _vocab "objOfProp"

    /// ???????? '?????????????? ?????????' ????????? ???????? ?????????, ????????????? ? ?????????, ? ?????????????? ??????????, ??????? ????????????? ????????? ???? ????????.
    let ontoCorrespondence = _vocab "ontoCorrespondence"

    /// The 'ontoMapping'  property relates an ontology mapping to its corresponding lexical sense.
    let ontoMapping = _vocab "ontoMapping"

    /// The 'optional' property indicates whether a syntactic argument is optional, that is, it can be syntactically omitted.
    let optional = _vocab "optional"

    /// '???????? ??????' ???????????? ?????????????? ??????????? ?? ??????? ????????, ?? ??????? ????????? ???? ?????.
    let propertyDomain = _vocab "propertyDomain"

    /// 'Property domain' provides a pragmatic restriction on the range of the property referred to by this sense.
    let propertyRange = _vocab "propertyRange"

    /// ???????? 'subjOfProp' ???????????? 1-? ???????? ??? ??????? ????????? ????????? (????????) ? ?????????.
    let subjOfProp = _vocab "subjOfProp"

    /// The 'submap' property relates a (complex) ontological mapping to a set of bindings that together bind the arguments of the involved predicates to a set of syntactic arguments that realize them syntactically.
    let submap = _vocab "submap"

    /// The object property synArg relates a syntactic frame to one of its syntactic arguments.
    let synArg = _vocab "synArg"

    /// ???????? '?????????????? ?????????' ????????? ??????????? ?????? ? ????? ?? ?? ?????????????? ????? ?????????, ??????????? ?????????????? ???????.
    let synBehavior = _vocab "synBehavior"

module frac =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/lemon/frac#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let value = _vocab ""


    let Attestation = _vocab "Attestation"


    let Collocation = _vocab "Collocation"


    let Frequency = _vocab "Frequency"


    let Observable = _vocab "Observable"


    let Observation = _vocab "Observation"


    let attestation = _vocab "attestation"


    let cScore = _vocab "cScore"


    let citation = _vocab "citation"


    let frequency = _vocab "frequency"

    /// An attestation gloss is the representation of the attestation as provided in a lexical resource. This may contain, for example, amendments or additional comments. For the string as found in the original text, use rdf:value.
    let gloss = _vocab "gloss"


    let head = _vocab "head"

    /// Points from an Observation to the exact location in the source material on where it is to be found. This can be, for example, a page in a book, the string URI of a passage in a text, a canonical reference to a passage in piece of literatur, or any Web Annotation selector. We have confirmed name, function and necessity of this property.
    ///     When the locus is provided, it is not necessary to also refer to the source material as a whole. The existence of such a reference is nevertheless implied.
    let locus = _vocab "locus"

    /// For an Observation, the property observedIn defines the URI of the data
    ///     source (or its metadata entry) that this particular observation was made in or derived from.
    ///     This can be, for example, a corpus or a text represented by its access URL, a book
    ///     represented by its bibliographical metadata, etc.
    let observedIn = _vocab "observedIn"


    let total = _vocab "total"

module lexicog =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/lemon/lexicog#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// An entry is a structural element that represents a lexicographic article or record as it is arranged in a source lexicographic resource. As such, it supports the description of lexical entries or senses according to the lexicographic micro-structure, decided upon during a lexicographic resource compilation process.
    let Entry = _vocab "Entry"

    /// Er zijn gevallen waarin een gegeven ontolex:LexicalSense niet voorkomt met alle mogelijke ontolex:Form(s) van de ontolex:LexicalEntry. In zulke gevallen representeert de klasse FormRestriction (een set van) grammaticale kenmerken van de ontolex:Form(s) waarin die zin voorkomt. De zin komt niet voor in de vormen waarvan de kenmerken niet voldoen aan die aangegeven door de vastgelegde set.
    let FormRestriction = _vocab "FormRestriction"

    /// A lexicographic component is a structural element that represents the (sub-)structures of lexicographic articles providing information about lexical entries, senses or sub-entries. If desired, lexicographic components can be arranged in a specific order and/or hierarchy.
    let LexicographicComponent = _vocab "LexicographicComponent"

    /// A lexicographic resource represents a collection of lexicographic entries (lexicog:Entry) in accord with the lexicographic criteria followed in the development of that resource.
    let LexicographicResource = _vocab "LexicographicResource"

    /// De klasse UsageExample representeert een tekstueel voorbeeld van het gebruik van een zin binnen een gegeven lexicografisch item. Een gebruiksvoorbeeld kan verscheidene tekstwaardes groeperen, waarbij deze waardes dezelfde betekenis duiden. Indien zulke waardes in verschillende talen zijn vastgelegd, kunnen ze dus ge�nterpreteerd worden als vertalingen van elkaar.
    let UsageExample = _vocab "UsageExample"

    /// De relatie "describes" relateert een lexicografisch component aan een element dat de daadwerkelijke informatie representeert dat is vastgelegd in het desbetreffende component in het lexicografisch werk. In de meeste gevallen zal deze informatie lexicaal van aard zijn, en zal de relatie dus verwijzen naar een instantie van ontolex:LexicalEntry of ontolex:LexicalSense.
    let describes = _vocab "describes"

    /// De relatie "entry" relateert een lexicografisch werk aan een item (of 'record' in de literatuur).
    let entry = _vocab "entry"

    /// De relatie "restrictedTo" relateert een LexicalSense aan een FormRestriction wanneer een lexicografisch werk informatie verschaft over de specifieke morfologische kenmerken van de ontolex:Form in de desbetreffende zin.
    let restrictedTo = _vocab "restrictedTo"

    /// De relatie "subComponent" relateert een lexicografisch component aan een ander lexicografisch component welke hierarchisch ondergeschikt is.
    let subComponent = _vocab "subComponent"

    /// De relatie usageExample relateert een ontolex:LexicalSense aan een lexciog:UsageExample.
    let usageExample = _vocab "usageExample"

module lexinfo =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.lexinfo.net/ontology/3.0/lexinfo#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let AbbreviatedForm = _vocab "AbbreviatedForm"


    let AccusativePostPositiveArg = _vocab "AccusativePostPositiveArg"


    let AdjectivalComplementFrame = _vocab "AdjectivalComplementFrame"


    let Adjective = _vocab "Adjective"


    let Adjective_i = _vocab "Adjective-i"


    let Adjective_na = _vocab "Adjective-na"


    let AdjectiveAccusativePostPositiveFrame =
        _vocab "AdjectiveAccusativePostPositiveFrame"


    let AdjectiveAttributiveFrame = _vocab "AdjectiveAttributiveFrame"


    let AdjectiveComparativeFrame = _vocab "AdjectiveComparativeFrame"


    let AdjectiveDativePostPositiveFrame = _vocab "AdjectiveDativePostPositiveFrame"


    let AdjectiveFrame = _vocab "AdjectiveFrame"


    let AdjectiveGenitivePostPositiveFrame = _vocab "AdjectiveGenitivePostPositiveFrame"


    let AdjectiveImpersonalFrame = _vocab "AdjectiveImpersonalFrame"


    let AdjectivePOS = _vocab "AdjectivePOS"


    let AdjectivePPFrame = _vocab "AdjectivePPFrame"


    let AdjectivePhrase = _vocab "AdjectivePhrase"


    let AdjectivePostPositiveFrame = _vocab "AdjectivePostPositiveFrame"

    /// Note this frame should be used when both attributive and predicative use of the adjective is allowed
    let AdjectivePredicateFrame = _vocab "AdjectivePredicateFrame"


    let AdjectivePredicativeFrame = _vocab "AdjectivePredicativeFrame"


    let AdjectiveScaleFrame = _vocab "AdjectiveScaleFrame"


    let AdjectiveSuperlativeFrame = _vocab "AdjectiveSuperlativeFrame"


    let Adjunct = _vocab "Adjunct"


    let Adposition = _vocab "Adposition"


    let AdpositionPOS = _vocab "AdpositionPOS"


    let AdpositionalObject = _vocab "AdpositionalObject"


    let Adverb = _vocab "Adverb"


    let AdverbPOS = _vocab "AdverbPOS"


    let AdverbialComplement = _vocab "AdverbialComplement"


    let AdverbialComplementFrame = _vocab "AdverbialComplementFrame"


    let AdverbialPronoun = _vocab "AdverbialPronoun"


    let AffirmativeParticle = _vocab "AffirmativeParticle"


    let AffixedPersonalPronoun = _vocab "AffixedPersonalPronoun"


    let AllusivePronoun = _vocab "AllusivePronoun"


    let Animacy = _vocab "Animacy"

    /// Indicates either the subject or object of the main clause may be the omitted argument of the subclause
    let ArbitraryControl = _vocab "ArbitraryControl"


    let Article = _vocab "Article"


    let ArticlePOS = _vocab "ArticlePOS"


    let Aspect = _vocab "Aspect"


    let AttributiveArg = _vocab "AttributiveArg"


    let Auxiliary = _vocab "Auxiliary"


    let Bullet = _vocab "Bullet"

    /// A lexical unit in a CJKV language that is represented by at least two CJKV characters.
    let CJK_compound = _vocab "CJK_compound"


    let CardinalNumeral = _vocab "CardinalNumeral"


    let Case = _vocab "Case"


    let Circumposition = _vocab "Circumposition"


    let ClausalArg = _vocab "ClausalArg"


    let Cliticness = _vocab "Cliticness"


    let CloseParenthesis = _vocab "CloseParenthesis"


    let CollectivePronoun = _vocab "CollectivePronoun"


    let Colon = _vocab "Colon"


    let Comma = _vocab "Comma"


    let CommonNoun = _vocab "CommonNoun"


    let ComparativeAdjunct = _vocab "ComparativeAdjunct"


    let ComparativeParticle = _vocab "ComparativeParticle"

    /// A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early
    let Complement = _vocab "Complement"


    let CompoundPreposition = _vocab "CompoundPreposition"


    let ConditionalParticle = _vocab "ConditionalParticle"


    let ConditionalPronoun = _vocab "ConditionalPronoun"


    let Conjunction = _vocab "Conjunction"


    let ConjunctionPOS = _vocab "ConjunctionPOS"

    /// Control indicates how a an argument from a main clause will be utilized in a subclause. This class includes both control structures and raising structures
    let Control = _vocab "Control"


    let CoordinatingConjunction = _vocab "CoordinatingConjunction"


    let CoordinationParticle = _vocab "CoordinationParticle"


    let Copula = _vocab "Copula"

    /// Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama
    let CopulativeArg = _vocab "CopulativeArg"

    /// Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him
    let CopulativeSubject = _vocab "CopulativeSubject"


    let Dating = _vocab "Dating"


    let DativePostPositiveArg = _vocab "DativePostPositiveArg"


    let DativeTransitiveFrame = _vocab "DativeTransitiveFrame"


    let DeclarativeClause = _vocab "DeclarativeClause"

    /// Declarative frames take a clause as an argument, this argument is marker with the declarative conjunction (&quot;that&quot; in English)
    let DeclarativeFrame = _vocab "DeclarativeFrame"


    let DeficientVerb = _vocab "DeficientVerb"


    let DefiniteArticle = _vocab "DefiniteArticle"


    let Definiteness = _vocab "Definiteness"


    let Degree = _vocab "Degree"


    let DemonstrativeDeterminer = _vocab "DemonstrativeDeterminer"


    let DemonstrativePronoun = _vocab "DemonstrativePronoun"


    let Determiner = _vocab "Determiner"


    let DeterminerPOS = _vocab "DeterminerPOS"


    let DiminutiveNoun = _vocab "DiminutiveNoun"

    /// relation between a phrase and a verb, in which the relation is central to the verb
    let DirectObject = _vocab "DirectObject"


    let DistinctiveParticle = _vocab "DistinctiveParticle"


    let DitransitiveDoubleAccusativeFrame = _vocab "DitransitiveDoubleAccusativeFrame"


    let DitransitiveFrame = _vocab "DitransitiveFrame"


    let DitransitiveFrame_For = _vocab "DitransitiveFrame_For"


    let DitransitiveFrame_To = _vocab "DitransitiveFrame_To"


    let EmphaticPronoun = _vocab "EmphaticPronoun"


    let ExclamativeDeterminer = _vocab "ExclamativeDeterminer"


    let ExclamativePoint = _vocab "ExclamativePoint"


    let ExclamativePronoun = _vocab "ExclamativePronoun"


    let ExistentialPronoun = _vocab "ExistentialPronoun"


    let Finiteness = _vocab "Finiteness"


    let Frequency = _vocab "Frequency"


    let FusedPreposition = _vocab "FusedPreposition"


    let FusedPrepositionDeterminer = _vocab "FusedPrepositionDeterminer"


    let FusedPrepositionPOS = _vocab "FusedPrepositionPOS"


    let FusedPrepositionPronoun = _vocab "FusedPrepositionPronoun"


    let FusedPronounAuxiliary = _vocab "FusedPronounAuxiliary"


    let FutureParticle = _vocab "FutureParticle"


    let Gender = _vocab "Gender"


    let GeneralAdverb = _vocab "GeneralAdverb"


    let GeneralizationWord = _vocab "GeneralizationWord"


    let GenericNumeral = _vocab "GenericNumeral"


    let GenitiveDitransitiveFrame = _vocab "GenitiveDitransitiveFrame"


    let GenitiveObject = _vocab "GenitiveObject"


    let GenitivePostPositiveArg = _vocab "GenitivePostPositiveArg"


    let GenitiveTransitiveFrame = _vocab "GenitiveTransitiveFrame"


    let GerundACFrame = _vocab "GerundACFrame"


    let GerundClause = _vocab "GerundClause"

    /// Indicates one of the arguments is a gerund clause
    let GerundFrame = _vocab "GerundFrame"


    let GerundOCFrame = _vocab "GerundOCFrame"


    let GerundSCFrame = _vocab "GerundSCFrame"


    let ImpersonalFrame = _vocab "ImpersonalFrame"


    let ImpersonalIntransitiveFrame = _vocab "ImpersonalIntransitiveFrame"


    let ImpersonalIntransitivePPFrame = _vocab "ImpersonalIntransitivePPFrame"


    let ImpersonalPronoun = _vocab "ImpersonalPronoun"


    let ImpersonalTransitiveFrame = _vocab "ImpersonalTransitiveFrame"


    let IndefiniteArticle = _vocab "IndefiniteArticle"


    let IndefiniteCardinalNumeral = _vocab "IndefiniteCardinalNumeral"


    let IndefiniteDeterminer = _vocab "IndefiniteDeterminer"


    let IndefiniteMultiplicativeNumeral = _vocab "IndefiniteMultiplicativeNumeral"


    let IndefiniteOrdinalNumeral = _vocab "IndefiniteOrdinalNumeral"


    let IndefinitePronoun = _vocab "IndefinitePronoun"

    /// An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized
    let IndirectObject = _vocab "IndirectObject"


    let InfinitiveClause = _vocab "InfinitiveClause"

    /// Infinitive frames take an infinitive clause as an argument
    let InfinitiveFrame = _vocab "InfinitiveFrame"


    let InfinitiveParticle = _vocab "InfinitiveParticle"


    let Infix = _vocab "Infix"


    let Interjection = _vocab "Interjection"


    let InterrogativeCardinalNumeral = _vocab "InterrogativeCardinalNumeral"


    let InterrogativeClause = _vocab "InterrogativeClause"


    let InterrogativeDeterminer = _vocab "InterrogativeDeterminer"

    /// Indicates the frame has a subframe indicated with the appropriate interrogative (e.g., &quot;who&quot;, &quot;where&quot;, &quot;how&quot;)
    let InterrogativeFrame = _vocab "InterrogativeFrame"


    let InterrogativeInfinitiveClause = _vocab "InterrogativeInfinitiveClause"

    /// Indicates the frame has an argument that is a clause with both an interrogative and the clause is in the infinitive form
    let InterrogativeInfinitiveFrame = _vocab "InterrogativeInfinitiveFrame"


    let InterrogativeMultiplicativeNumeral = _vocab "InterrogativeMultiplicativeNumeral"


    let InterrogativeOrdinalNumeral = _vocab "InterrogativeOrdinalNumeral"


    let InterrogativeParticle = _vocab "InterrogativeParticle"


    let InterrogativePronoun = _vocab "InterrogativePronoun"


    let InterrogativeRelativePronoun = _vocab "InterrogativeRelativePronoun"


    let IntransitiveAdjectivalComplementFrame =
        _vocab "IntransitiveAdjectivalComplementFrame"


    let IntransitiveAdverbialComplementFrame =
        _vocab "IntransitiveAdverbialComplementFrame"


    let IntransitiveDeclarativeFrame = _vocab "IntransitiveDeclarativeFrame"


    let IntransitiveFrame = _vocab "IntransitiveFrame"


    let IntransitiveInfinitiveACFrame = _vocab "IntransitiveInfinitiveACFrame"


    let IntransitiveInfinitiveRSFrame = _vocab "IntransitiveInfinitiveRSFrame"


    let IntransitiveInfinitiveSCFrame = _vocab "IntransitiveInfinitiveSCFrame"


    let IntransitiveInterrogativeFrame = _vocab "IntransitiveInterrogativeFrame"


    let IntransitiveInterrogativeInfinitiveFrame =
        _vocab "IntransitiveInterrogativeInfinitiveFrame"


    let IntransitiveNominalComplementFrame = _vocab "IntransitiveNominalComplementFrame"


    let IntransitivePPDeclarativeFrame = _vocab "IntransitivePPDeclarativeFrame"


    let IntransitivePPFrame = _vocab "IntransitivePPFrame"


    let IntransitiveSententialFrame = _vocab "IntransitiveSententialFrame"


    let InvertedComma = _vocab "InvertedComma"


    let IrreflexivePersonalPronoun = _vocab "IrreflexivePersonalPronoun"


    let Letter = _vocab "Letter"


    let LightVerb = _vocab "LightVerb"


    let MainVerb = _vocab "MainVerb"


    let Modal = _vocab "Modal"


    let ModificationType = _vocab "ModificationType"


    let Mood = _vocab "Mood"


    let MultiplicativeNumeral = _vocab "MultiplicativeNumeral"


    let Negative = _vocab "Negative"


    let NegativeParticle = _vocab "NegativeParticle"


    let NegativePronoun = _vocab "NegativePronoun"


    let NominalComplementFrame = _vocab "NominalComplementFrame"


    let NormativeAuthorization = _vocab "NormativeAuthorization"


    let Noun = _vocab "Noun"


    let NounFrame = _vocab "NounFrame"


    let NounPOS = _vocab "NounPOS"


    let NounPPFrame = _vocab "NounPPFrame"


    let NounPhrase = _vocab "NounPhrase"


    let NounPossessiveFrame = _vocab "NounPossessiveFrame"


    let NounPredicateFrame = _vocab "NounPredicateFrame"


    let Number = _vocab "Number"


    let Numeral = _vocab "Numeral"


    let NumeralFraction = _vocab "NumeralFraction"


    let NumeralPOS = _vocab "NumeralPOS"


    let Object = _vocab "Object"


    let ObjectComplement = _vocab "ObjectComplement"

    /// Indicates the object of the main clause is also the (omitted) object of the subclause
    let ObjectControl = _vocab "ObjectControl"


    let OpenParenthesis = _vocab "OpenParenthesis"


    let OrdinalAdjective = _vocab "OrdinalAdjective"


    let PPFrame = _vocab "PPFrame"


    let PartOfSpeech = _vocab "PartOfSpeech"


    let ParticipleAdjective = _vocab "ParticipleAdjective"


    let Particle = _vocab "Particle"


    let ParticlePOS = _vocab "ParticlePOS"


    let PartitiveArticle = _vocab "PartitiveArticle"


    let PastParticipleAdjective = _vocab "PastParticipleAdjective"


    let Person = _vocab "Person"


    let PersonalPronoun = _vocab "PersonalPronoun"


    let PlainVerb = _vocab "PlainVerb"


    let Point = _vocab "Point"


    let PossessiveAdjective = _vocab "PossessiveAdjective"


    let PossessiveAdjunct = _vocab "PossessiveAdjunct"


    let PossessiveDeterminer = _vocab "PossessiveDeterminer"


    let PossessiveInfinitiveClause = _vocab "PossessiveInfinitiveClause"


    let PossessiveParticle = _vocab "PossessiveParticle"


    let PossessivePronoun = _vocab "PossessivePronoun"


    let PossessiveRelativePronoun = _vocab "PossessiveRelativePronoun"

    /// Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something
    let PostPositiveArg = _vocab "PostPositiveArg"


    let Postposition = _vocab "Postposition"


    let PredicativeAdjective = _vocab "PredicativeAdjective"


    let PredicativeAdjunct = _vocab "PredicativeAdjunct"


    let PredicativeAdverb = _vocab "PredicativeAdverb"


    let PredicativeNominative = _vocab "PredicativeNominative"


    let Prefix = _vocab "Prefix"


    let Preposition = _vocab "Preposition"


    let PrepositionFrame = _vocab "PrepositionFrame"


    let PrepositionPhrase = _vocab "PrepositionPhrase"


    let PrepositionalAdjunct = _vocab "PrepositionalAdjunct"


    let PrepositionalAdverb = _vocab "PrepositionalAdverb"

    /// Abstract frame for words that take a prepositional phrase as an argument
    let PrepositionalFrame = _vocab "PrepositionalFrame"


    let PrepositionalGerundClause = _vocab "PrepositionalGerundClause"


    let PrepositionalInterrogativeClause = _vocab "PrepositionalInterrogativeClause"


    let PrepositionalInterrogativeFrame = _vocab "PrepositionalInterrogativeFrame"


    let PrepositionalObject = _vocab "PrepositionalObject"


    let PrepositionalPhraseFrame = _vocab "PrepositionalPhraseFrame"


    let PresentParticipleAdjective = _vocab "PresentParticipleAdjective"


    let PresentativePronoun = _vocab "PresentativePronoun"


    let PronominalAdverb = _vocab "PronominalAdverb"


    let Pronoun = _vocab "Pronoun"


    let PronounPOS = _vocab "PronounPOS"


    let ProperNoun = _vocab "ProperNoun"


    let Punctuation = _vocab "Punctuation"


    let QualifierAdjective = _vocab "QualifierAdjective"


    let QuestionMark = _vocab "QuestionMark"


    let RaisableArgument = _vocab "RaisableArgument"


    let RaisableSubject = _vocab "RaisableSubject"

    /// Indicates the syntactic subject of the main clause is in fact the subject of the subclause. The main clause should then be interpreted as being impersonal.
    let RaisingSubject = _vocab "RaisingSubject"


    let ReciprocalFrame = _vocab "ReciprocalFrame"


    let ReciprocalPronoun = _vocab "ReciprocalPronoun"


    let ReferentType = _vocab "ReferentType"


    let ReflexiveDativeTransitiveFrame = _vocab "ReflexiveDativeTransitiveFrame"


    let ReflexiveDeterminer = _vocab "ReflexiveDeterminer"


    let ReflexiveDitransitiveFrame = _vocab "ReflexiveDitransitiveFrame"


    let ReflexiveFrame = _vocab "ReflexiveFrame"


    let ReflexiveObject = _vocab "ReflexiveObject"


    let ReflexivePersonalPronoun = _vocab "ReflexivePersonalPronoun"


    let ReflexivePossessivePronoun = _vocab "ReflexivePossessivePronoun"


    let ReflexiveReciprocalFrame = _vocab "ReflexiveReciprocalFrame"


    let ReflexiveTransitiveFrame = _vocab "ReflexiveTransitiveFrame"


    let ReflexiveTransitivePPFrame = _vocab "ReflexiveTransitivePPFrame"


    let Register = _vocab "Register"


    let RelationNoun = _vocab "RelationNoun"


    let RelativeDeterminer = _vocab "RelativeDeterminer"


    let RelativeParticle = _vocab "RelativeParticle"


    let RelativePronoun = _vocab "RelativePronoun"

    /// A root is the portion of a word that (a) is common to a set of derived or inflected forms, (b) is not further analyzable into meaningful elements, and (c) carries the principle portion of meaning of the words in which it functions (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/root).
    let RootMorph = _vocab "RootMorph"


    let SemiColon = _vocab "SemiColon"


    let SententialClause = _vocab "SententialClause"

    /// Sentential frames take a clause as argument, no conjunction is used and the syntax of the clause is the same as a main clause
    let SententialFrame = _vocab "SententialFrame"

    /// A simulfix is a change or replacement of vowels or consonants (usually vowels) which changes the meaning of a word (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/simulfix). Examples include umlaut in Germanic languages, e.g., in the formation of the English plural feet from the singular foot.
    let SimulfixMorph = _vocab "SimulfixMorph"


    let Slash = _vocab "Slash"

    /// A stem is the root or roots of a word, together with any derivational affixes, to which inflectional affixes are added (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/stem). A stem consists minimally of a root, but may be analyzable into a root plus derivational morphemes.
    let StemMorph = _vocab "StemMorph"


    let StrongPersonalPronoun = _vocab "StrongPersonalPronoun"

    /// relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated
    let Subject = _vocab "Subject"

    /// Indicates the subject of the main clause is the (omitted) subject of the subclause
    let SubjectControl = _vocab "SubjectControl"


    let SubjectlessFrame = _vocab "SubjectlessFrame"


    let SubjectlessIntransitiveFrame = _vocab "SubjectlessIntransitiveFrame"


    let SubjectlessIntransitivePPFrame = _vocab "SubjectlessIntransitivePPFrame"


    let SubjectlessTransitiveFrame = _vocab "SubjectlessTransitiveFrame"


    let SubjectlessTransitivePPFrame = _vocab "SubjectlessTransitivePPFrame"


    let SubjunctiveClause = _vocab "SubjunctiveClause"


    let SubordinatingConjunction = _vocab "SubordinatingConjunction"


    let Suffix = _vocab "Suffix"


    let SuperlativeAdjunct = _vocab "SuperlativeAdjunct"


    let SuperlativeParticle = _vocab "SuperlativeParticle"


    let SuspensionPoints = _vocab "SuspensionPoints"


    let Symbol = _vocab "Symbol"


    let SymbolPOS = _vocab "SymbolPOS"


    let TemporalQualifier = _vocab "TemporalQualifier"


    let Tense = _vocab "Tense"


    let TermElement = _vocab "TermElement"


    let TermType = _vocab "TermType"

    /// A transfix is a discontinuous affix that disrupts the base to which it is attached. The term is reserved for true single affixes, rather than combinations of an infix with an independent prefix or suffix. (Broselow, E., 2000. Transfixation. In G. Booij, et al. (eds.), Ein internationales Handbuch zur Flexion und Wortbildung. 1. Halbband. Mouton De Gruyter, New York, Berlin, p. 552-557.) Examples include discontinuous affixes inserted into a word root, as in root-and-pattern systems of several Semitic languages, e.g., in the Arabic word kitaba "writing" from the root k-t-b.
    let TransfixMorph = _vocab "TransfixMorph"


    let TransitiveAdjectivalComplementFrame =
        _vocab "TransitiveAdjectivalComplementFrame"


    let TransitiveAdverbialComplementFrame = _vocab "TransitiveAdverbialComplementFrame"


    let TransitiveDeclarativeFrame = _vocab "TransitiveDeclarativeFrame"


    let TransitiveFrame = _vocab "TransitiveFrame"


    let TransitiveInfinitiveACFrame = _vocab "TransitiveInfinitiveACFrame"


    let TransitiveInfinitiveOCFrame = _vocab "TransitiveInfinitiveOCFrame"


    let TransitiveInfinitiveSCFrame = _vocab "TransitiveInfinitiveSCFrame"


    let TransitiveInterrogativeFrame = _vocab "TransitiveInterrogativeFrame"


    let TransitiveInterrogativeInfinitiveFrame =
        _vocab "TransitiveInterrogativeInfinitiveFrame"


    let TransitiveNominalComplementFrame = _vocab "TransitiveNominalComplementFrame"


    let TransitivePPFrame = _vocab "TransitivePPFrame"


    let TransitiveSententialFrame = _vocab "TransitiveSententialFrame"


    let UnclassifiedParticle = _vocab "UnclassifiedParticle"


    let Verb = _vocab "Verb"


    let VerbFormMood = _vocab "VerbFormMood"


    let VerbFrame = _vocab "VerbFrame"


    let VerbPOS = _vocab "VerbPOS"


    let VerbPhrase = _vocab "VerbPhrase"


    let Voice = _vocab "Voice"


    let WeakPersonalPronoun = _vocab "WeakPersonalPronoun"

    /// A zero morph is a morph, consisting of no phonetic form, that is proposed in some analyses as an allomorph of a morpheme that is ordinarily realized by a morph having some phonetic form (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/zero-morph). Examples include the English plural sheep along with the singular sheep.
    let ZeroMorph = _vocab "ZeroMorph"

    /// A term or lexeme resulting from the omission of any part of the full term or lexeme while designating the same concept.
    let abbreviatedForm = _vocab "abbreviatedForm"


    let abbreviation = _vocab "abbreviation"

    /// A linking element used to identify a relation between an abbreviation and its full or expanded form.
    let abbreviationFor = _vocab "abbreviationFor"

    /// Case that expresses the lack or absence of the referent of the noun it marks.
    let abessiveCase = _vocab "abessiveCase"


    let abessiveCaseForm = _vocab "abessiveCaseForm"

    /// Case used to typically indicate locative or instrumental function.
    let ablativeCase = _vocab "ablativeCase"


    let ablativeCaseForm = _vocab "ablativeCaseForm"

    /// Case for nouns in ergative-absolute languages that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages such as English.
    let absolutiveCase = _vocab "absolutiveCase"


    let absolutiveCaseForm = _vocab "absolutiveCaseForm"

    /// Case used to indicate direct object.
    let accusativeCase = _vocab "accusativeCase"


    let accusativeCaseForm = _vocab "accusativeCaseForm"

    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced syllabically.
    let acronym = _vocab "acronym"

    /// A linking element used to identify a relation between an acronym and its full or expanded form.
    let acronymFor = _vocab "acronymFor"

    /// Value that expresses the situation where the grammatical subject is also the semantic actor of the verb.
    let activeVoice = _vocab "activeVoice"

    /// Case which expresses the meaning of presence 'at' or 'near' a place.
    let adessiveCase = _vocab "adessiveCase"


    let adessiveCaseForm = _vocab "adessiveCaseForm"

    /// Case expressing &quot;to&quot; in Basque studies.
    let aditiveCase = _vocab "aditiveCase"


    let aditiveCaseForm = _vocab "aditiveCaseForm"

    /// Part of speech related to attributes of noun.
    let adjective = _vocab "adjective"

    /// Deverbal adjective in Japanese ending with the '-i' suffix in dictionary form
    let adjective_i = _vocab "adjective-i"

    /// Denominal adjectives in Japanese formed from a noun plus the particle 'na'
    let adjective_na = _vocab "adjective-na"


    let adjunct = _vocab "adjunct"

    /// A term rated according to the scale of a term acceptability rating as a synonym for a preferred term.
    let admittedTerm = _vocab "admittedTerm"

    /// Part of speech that occurs before/inside/after a complement composed of a noun phrase, noun, pronoun or clause that functions as a noun phrase and form a single structure with the complement to express its grammatical and semantic relation to another unit.
    let adposition = _vocab "adposition"


    let adpositionalObject = _vocab "adpositionalObject"

    /// Part of speech to refer to an heterogeneous group of words whose most frequent function is to specify the mode of action of the verb.
    let adverb = _vocab "adverb"


    let adverbialComplement = _vocab "adverbialComplement"

    /// ()
    let adverbialPronoun = _vocab "adverbialPronoun"

    /// Particle used to express affirmation.
    let affirmativeParticle = _vocab "affirmativeParticle"


    let affix = _vocab "affix"

    /// Personnal pronoun that is affixed, i.e. added as an affix to another word.
    let affixedPersonalPronoun = _vocab "affixedPersonalPronoun"

    /// Case which expresses the meaning of motion 'to' or 'towards' the referent it marks.
    let allativeCase = _vocab "allativeCase"


    let allativeCaseForm = _vocab "allativeCaseForm"

    /// Pronoun that refers to something characterized by allusions.
    let allusivePronoun = _vocab "allusivePronoun"

    /// The characteristic of a word indicating that in a given discourse community, its referent is considered to be alive or to possess a quality of volition or consciousness.
    let animacy = _vocab "animacy"

    /// Perceived as alive.
    let animate = _vocab "animate"

    /// A term or lexeme whose concept or sense constitutes the opposite of the concept represented by a second term or lexeme.
    let antonym = _vocab "antonym"

    /// A designation that represents an individual concept.
    let appellation = _vocab "appellation"

    /// Property used to qualify something similar but not exactly the same
    let approximate = _vocab "approximate"

    /// A synonym that differs in some minor way
    let approximateSynonym = _vocab "approximateSynonym"

    /// A term or lexeme no longer in ordinary use, though retained for special purposes.
    let archaicForm = _vocab "archaicForm"

    /// Term used in the grammatical classification of words referring to a subclass of determiners which displays a primary role in differentiating the uses of nouns.
    let article = _vocab "article"

    /// Category associated to verbs and referring to the way the grammar marks the duration or type of temporal activity.
    let aspect = _vocab "aspect"

    /// A relation between two concepts having a non-hierarchical thematic connection by virtue of experience.
    let associativeRelation = _vocab "associativeRelation"

    /// usage marker which identifies the speaker's subjective point of view, positive or negative, regarding the object referred to by a given lexical unit
    let attitude = _vocab "attitude"


    let attributiveArg = _vocab "attributiveArg"

    /// a verb that adds functional or grammatical meaning to the clause in which it appears, so as to express tense, aspect, modality, voice, emphasis, etc.
    let auxiliary = _vocab "auxiliary"

    /// The root form of a word or term that is used as the formal dictionary entry for the term.
    let baseElement = _vocab "baseElement"

    /// Register of terms used in applications-oriented as opposed to theoretical or academic levels of language. // The register of terms used in applications-oriented as opposed to theoretical or academic levels of language.
    let benchLevelRegister = _vocab "benchLevelRegister"

    /// Case that expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause.
    let benefactiveCase = _vocab "benefactiveCase"


    let benefactiveCaseForm = _vocab "benefactiveCaseForm"

    /// Linked to a particular element.
    let bound = _vocab "bound"

    /// Sign used to mark an item in a list.
    let bullet = _vocab "bullet"

    /// A word denoting a number.
    let cardinalNumeral = _vocab "cardinalNumeral"

    /// In a given sentence, the way in which the form of a word changes in order to express a relationship with one or several words of the sentence. The morphological modification may apply to nouns, pronouns noun phrase constituents, such as adjectives or numerals.
    let case = _vocab "case"

    /// A concept that is related to another concept by virtue of the fact that it plays a causative role with respect to that concept.
    let causallyRelatedConcept = _vocab "causallyRelatedConcept"

    /// Case which expresses that the referent of the noun it marks is the cause of the situation expressed by the clause.
    let causativeCase = _vocab "causativeCase"


    let causativeCaseForm = _vocab "causativeCaseForm"

    /// Aspect that expresses the cessation of an event or state.
    let cessative = _vocab "cessative"

    /// Adposition which consists of two parts which are positioned ahead and after the adpositional foci.
    let circumposition = _vocab "circumposition"


    let clausalArg = _vocab "clausalArg"

    /// An abbreviation formed by truncating a part of a simple term.
    let clippedTerm = _vocab "clippedTerm"

    /// A linking element used to identify a relation between a clipped term and its full or expanded form.
    let clippedTermFor = _vocab "clippedTermFor"

    /// Categorization of the different types of clitics
    let cliticness = _vocab "cliticness"

    /// End of a parenthesis pair.
    let closeParenthesis = _vocab "closeParenthesis"

    /// A collective number is a number referring to 'a set of things'. Languages that have this feature can use it to get a phrase like 'flock of sheeps' by using 'sheep' in collective number.
    let collective = _vocab "collective"


    let collectiveNumberForm = _vocab "collectiveNumberForm"

    /// A pronoun that refers to all elements of a set.
    let collectivePronoun = _vocab "collectivePronoun"

    /// Two terms that occur together far more frequently than chance
    let collocation = _vocab "collocation"

    /// Sign with two vertical points that is used in writing and printing to introduce an explanation, example or quotation.
    let colon = _vocab "colon"

    /// Case which expresses a meaning similar to 'along with' or 'accompagnied by'.
    let comitativeCase = _vocab "comitativeCase"


    let comitativeCaseForm = _vocab "comitativeCaseForm"

    /// Mark (,) used in writing to show a short pause or to separate items in a list.
    let comma = _vocab "comma"

    /// Indistinguished gender for epicenes.
    let commonGender = _vocab "commonGender"

    /// A synonym for an international scientific term that is used in general discourse in a given language.
    let commonName = _vocab "commonName"

    /// A noun or adjective denoting a class of objects. // Noun that signifies a non-specific member of a group.
    let commonNoun = _vocab "commonNoun"

    /// Said of a term that appears frequently.
    let commonlyUsed = _vocab "commonlyUsed"

    /// Comparative is the comparison where only two entites are involved.
    let comparative = _vocab "comparative"


    let comparativeAdjunct = _vocab "comparativeAdjunct"


    let comparativeDegreeForm = _vocab "comparativeDegreeForm"

    /// Particle used to compare.
    let comparativeParticle = _vocab "comparativeParticle"

    /// A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early
    let complement = _vocab "complement"

    /// A lexical unit that combines two or sometimes more different words, frequently such that the sense of the new lexical unit is not clearly derivable from the combination of its parts.
    let compound = _vocab "compound"

    /// Preposition that is a aggregation of words
    let compoundPreposition = _vocab "compoundPreposition"

    /// A conditional relation is a logical relation in which the illocutionary act employing one of a pair of propositions is expressed or implied to be true or in force if the other proposition is true.
    let conditional = _vocab "conditional"

    /// conditional particule
    let conditionalParticle = _vocab "conditionalParticle"

    /// conditional pronoun
    let conditionalPronoun = _vocab "conditionalPronoun"

    /// The confidence in a given relationship.
    let confidence = _vocab "confidence"

    /// Word that syntactically links words or constituents, and expresses a semantic relationship between them.
    let conjunction = _vocab "conjunction"

    /// A lexical unit formed by a shortening of a word, syllable, or word group by omission of a sound or letter.
    let contraction = _vocab "contraction"

    /// The full form that corresponds to a contracted form.
    let contractionFor = _vocab "contractionFor"

    /// A subordinate concept having the same nearest superordinate concept and same criterion of subdivision as some other concept in a given concept system.
    let coordinateConcept = _vocab "coordinateConcept"

    /// Conjunction that links constituents.
    let coordinatingConjunction = _vocab "coordinatingConjunction"

    /// particle for coordination
    let coordinationParticle = _vocab "coordinationParticle"

    /// Special word that combines the subject of a sentence and its description.
    let copula = _vocab "copula"

    /// Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama
    let copulativeArg = _vocab "copulativeArg"

    /// Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him
    let copulativeSubject = _vocab "copulativeSubject"

    /// Indication specifying whether the usage is old or modern.
    let dating = _vocab "dating"

    /// Case that expresses an indirect object relationship or a range of meaning similar to that covered by 'to' or 'for' in English; but there is a great deal of variation between languages in the way this case is used.
    let dativeCase = _vocab "dativeCase"


    let dativeCaseForm = _vocab "dativeCaseForm"


    let declarativeClause = _vocab "declarativeClause"

    /// verb lacking certain morphosyntactic properties
    let deficientVerb = _vocab "deficientVerb"

    /// Value referring to the capacity of identification of an entity.
    let definite = _vocab "definite"

    /// Article that allows the reference to a specific, identifiable entity (or class of entities).
    let definiteArticle = _vocab "definiteArticle"

    /// Property about the possiblity to identify an entity.
    let definiteness = _vocab "definiteness"

    /// Property concerning comparison.
    let degree = _vocab "degree"

    /// Case which expresses motion downward from the referent of the noun it marks.
    let delativeCase = _vocab "delativeCase"


    let delativeCaseForm = _vocab "delativeCaseForm"

    /// Determiner used to point to an entity in the situation or elsewhere in a sentence.
    let demonstrativeDeterminer = _vocab "demonstrativeDeterminer"

    /// Pronoun used to point to an entity in the situation or elsewhere in a sentence.
    let demonstrativePronoun = _vocab "demonstrativePronoun"

    /// A term rated according to the scale of a term acceptability rating as undesired.
    let deprecatedTerm = _vocab "deprecatedTerm"

    /// A form that is derived morphosyntactically from another form
    let derivedForm = _vocab "derivedForm"

    /// A description in general prose text of the issues that are indicated by the context. The description field can occur at many different places in a component and profile.
    let description = _vocab "description"

    /// Word or affix that belongs to a class of noun modifiers that expresses the reference, including quantity, of a noun.
    let determiner = _vocab "determiner"


    let dialectRegister = _vocab "dialectRegister"

    /// diminutive noun
    let diminutiveNoun = _vocab "diminutiveNoun"

    /// An unmarked case which covers the single argument of a one-place verb and the agent and patient arguments of a transitive verb.
    let directCase = _vocab "directCase"


    let directCaseForm = _vocab "directCaseForm"

    /// relation between a phrase and a verb, in which the relation is central to the verb
    let directObject = _vocab "directObject"

    /// distinctive particle
    let distinctiveParticle = _vocab "distinctiveParticle"

    /// usage marker which identifies the specialized field of knowledge in which a lexical unit is mainly used
    let domain = _vocab "domain"

    /// Form used in some languages to designate two persons or things. // The form used in some languages to designate two persons or things.
    let dual = _vocab "dual"


    let dualNumberForm = _vocab "dualNumberForm"

    /// Case which expresses the meaning of motion 'away from' from the referent of the noun it marks.
    let elativeCase = _vocab "elativeCase"


    let elativeCaseForm = _vocab "elativeCaseForm"

    /// An emphatic pronoun is a personal pronoun that is used to emphasize its referent.
    let emphaticPronoun = _vocab "emphaticPronoun"

    /// A term that heads a terminological entry.
    let entryTerm = _vocab "entryTerm"

    /// An expression used to represent a concept based on a statement that two mathematical expressions are, for instance, equal as identified by the equal sign (=), or assigned to one another by a similar sign.
    let equation = _vocab "equation"

    /// Case that expresses likeness or identity to the referent of the noun it marks. It can have meaning, such as: 'as', 'like', or 'in the capacity of'.
    let equativeCase = _vocab "equativeCase"


    let equativeCaseForm = _vocab "equativeCaseForm"

    /// Case assigned to the subject of a transitive verb as opposed to absolutive case.
    let ergativeCase = _vocab "ergativeCase"


    let ergativeCaseForm = _vocab "ergativeCaseForm"

    /// Case which expresses a state of being.
    let essiveCase = _vocab "essiveCase"


    let essiveCaseForm = _vocab "essiveCaseForm"

    /// Morpheme that has a particular status with regards to the word's etymology.
    let etymologicalRoot = _vocab "etymologicalRoot"

    /// Information on the origin of a word and the development of its meaning.
    let etymology = _vocab "etymology"

    /// Completely equal in every detail
    let exact = _vocab "exact"

    /// An example of the usage of a frame
    let example = _vocab "example"

    /// Determiner expressing an emotional utterance and marked with a strong intonation.
    let exclamativeDeterminer = _vocab "exclamativeDeterminer"

    /// Special sign (!) usually used in writing to mark exclamation.
    let exclamativePoint = _vocab "exclamativePoint"

    /// Pronoun marked with an emotional utterance and/or a strong intonation.
    let exclamativePronoun = _vocab "exclamativePronoun"

    /// pronoun that indicates the existence of something or someone
    let existentialPronoun = _vocab "existentialPronoun"

    /// A statement that describes and clarifies a concept and makes it understandable, but does not necessarily differentiate it from other concepts.
    let explanation = _vocab "explanation"

    /// A significant word or phrase.
    let expression = _vocab "expression"


    let facetiousRegister = _vocab "facetiousRegister"

    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to females.
    let feminine = _vocab "feminine"

    /// Property applied to a verb form that can occur on its own in an independent sentence.
    let finite = _vocab "finite"

    /// Property referring to finite and non-finite status of a verbal form.
    let finiteness = _vocab "finiteness"

    /// First person deixis is deictic reference that refers to the speaker, or both the speaker and referents grouped with the speaker
    let firstPerson = _vocab "firstPerson"


    let firstPersonForm = _vocab "firstPersonForm"


    let formCaseVariant = _vocab "formCaseVariant"


    let formDegreeVariant = _vocab "formDegreeVariant"


    let formMoodVariant = _vocab "formMoodVariant"


    let formNegativeVariant = _vocab "formNegativeVariant"


    let formNumberVariant = _vocab "formNumberVariant"


    let formPersonVariant = _vocab "formPersonVariant"


    let formTenseVariant = _vocab "formTenseVariant"


    let formalRegister = _vocab "formalRegister"

    /// Figures, symbols or the like used to express a concept briefly, such as a mathematical or chemical formula.
    let formula = _vocab "formula"

    /// The relative commonness with which a term occurs.
    let frequency = _vocab "frequency"

    /// usage marker which identifies the relative rate of occurrence of a lexical unit in a given textual context
    let frequencyUsage = _vocab "frequencyUsage"

    /// For definiteness, when a specific form is the syntactic subject of the clause.
    let fullArticle = _vocab "fullArticle"

    /// The complete presentation of a term or lexeme for which there is an abbreviated form.
    let fullForm = _vocab "fullForm"

    /// A linking element used to identify a relation between any full form of a term or lexical unit and its abbreviated form.
    let fullFormFor = _vocab "fullFormFor"

    /// Preposition that is the result of a morphological merge from at least two words.
    let fusedPreposition = _vocab "fusedPreposition"

    /// word resulting from the aggregation of a proposition and a determiner
    let fusedPrepositionDeterminer = _vocab "fusedPrepositionDeterminer"

    /// word resulting from the aggregation of a preposition and a pronoun
    let fusedPrepositionPronoun = _vocab "fusedPrepositionPronoun"

    /// word resulting from the aggregation of a pronoun and an auxiliary
    let fusedPronounAuxiliary = _vocab "fusedPronounAuxiliary"

    /// Verb tense that indicates action or state of being in the future.
    let future = _vocab "future"

    /// Particle used in order to express future.
    let futureParticle = _vocab "futureParticle"


    let futureTenseForm = _vocab "futureTenseForm"

    /// A grammatical category that indicates grammatical relationships between words in sentences.
    let gender = _vocab "gender"

    /// Adverb belonging to the general class of adverbs
    let generalAdverb = _vocab "generalAdverb"

    /// A word that does not carry its own meaning but generalizes the meaning of a neighboring word, adding the &quot;etc.&quot; sense.
    let generalizationWord = _vocab "generalizationWord"

    /// A numeral used to indicate the number of sets/kinds of objects.
    let genericNumeral = _vocab "genericNumeral"

    /// Case which expresses a possessive relationship (e.g. the boy's book) or some other similarly close connection (e.g. a summer's day).
    let genitiveCase = _vocab "genitiveCase"


    let genitiveCaseForm = _vocab "genitiveCaseForm"


    let genitiveObject = _vocab "genitiveObject"

    /// usage marker which identifies the place or region where a lexical unit is mainly used
    let geographic = _vocab "geographic"

    /// Description of a specific form used in a certain region as opposed to another form used in another region
    let geographicalVariant = _vocab "geographicalVariant"


    let gerundClause = _vocab "gerundClause"


    let gerundive = _vocab "gerundive"

    /// In TEI: A phrase or word used to provide a gloss or definition for some other word or phrase.
    /// In 1951: Any editorial comment.
    let gloss = _vocab "gloss"

    /// Indicates the head element of a phrase
    let head = _vocab "head"

    /// usage marker which cannot be classified otherwise
    let hint = _vocab "hint"

    /// Indicates that the referenced element is a part of this object
    let holonymTerm = _vocab "holonymTerm"

    /// A word that is spelled like another, but that has a different pronunciation, meaning, and/or origin. // Word that is written like another, but that has a different pronunciation, meaning, and/or origin.
    let homograph = _vocab "homograph"

    /// A word that is pronounced like another word and that can be spelled the same way (homograph) or can merely sound the same (homophone). // Word that sounds the same and is written the same as another word but is different in meaning.
    let homonym = _vocab "homonym"

    /// A word that is pronounced in the same way as another word but that is spelled differently. // Word that sounds like another word, but is different in writiing or meaning.
    let homophone = _vocab "homophone"

    /// A term with a broader meaning
    let hypernym = _vocab "hypernym"

    /// A term with a narrower meaning
    let hyponym = _vocab "hyponym"

    /// A group of words in a fixed order that have a particular meaning that is different from the meanings of each word understood on its own.
    let idiom = _vocab "idiom"

    /// Case which expresses the meaning of 'motion into' or 'direction towards' the referent of the noun it marks.
    let illativeCase = _vocab "illativeCase"


    let illativeCaseForm = _vocab "illativeCaseForm"

    /// Mood used to express an order.
    let imperative = _vocab "imperative"


    let imperativeMoodForm = _vocab "imperativeMoodForm"

    /// Verb tense that refers to action in the past that is incomplete or ongoing.
    let imperfect = _vocab "imperfect"


    let imperfectTenseForm = _vocab "imperfectTenseForm"

    /// Imperfective aspect is an aspect that expresses an event or state, with respect to its internal structure, instead of expressing it as a simple whole.
    let imperfective = _vocab "imperfective"

    /// Pronoun lacking person referent.
    let impersonalPronoun = _vocab "impersonalPronoun"

    /// Register of terms that are company-specific and not readily recognized outside this environment. // The register of terms that are company-specific and not readily recognized outside this environment.
    let inHouseRegister = _vocab "inHouseRegister"

    /// Perceived as not living.
    let inanimate = _vocab "inanimate"

    /// Aspect that expresses the beginning of an event or state.
    let inchoative = _vocab "inchoative"

    /// Value related to an entity in a situation where the identification of this entity is not clear cut.
    let indefinite = _vocab "indefinite"

    /// Article not capable of expressing identification.
    let indefiniteArticle = _vocab "indefiniteArticle"

    /// A word used to express imprecise quantity.
    let indefiniteCardinalNumeral = _vocab "indefiniteCardinalNumeral"

    /// Determiner not capable of identification.
    let indefiniteDeterminer = _vocab "indefiniteDeterminer"

    /// A word indicating imprecise number of times something happened.
    let indefiniteMultiplicativeNumeral = _vocab "indefiniteMultiplicativeNumeral"

    /// A word used to indicate imprecise rank of an object in a sequence.
    let indefiniteOrdinalNumeral = _vocab "indefiniteOrdinalNumeral"

    /// Pronoun that does not allow reference.
    let indefinitePronoun = _vocab "indefinitePronoun"

    /// Mood value used in the expression of statements and questions.
    let indicative = _vocab "indicative"


    let indicativeMoodForm = _vocab "indicativeMoodForm"

    /// Markup to express that there is not any pertinence.
    let indifferent = _vocab "indifferent"

    /// An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized
    let indirectObject = _vocab "indirectObject"

    /// Case which expresses the meaning of location or position within a place.
    let inessiveCase = _vocab "inessiveCase"


    let inessiveCaseForm = _vocab "inessiveCaseForm"

    /// Mood cited as unmarked or base form.
    let infinitive = _vocab "infinitive"


    let infinitiveClause = _vocab "infinitiveClause"

    /// Particle used to express infinitive.
    let infinitiveParticle = _vocab "infinitiveParticle"


    let infix = _vocab "infix"

    /// An element of language used to change the form of a word (noun, adjective) by declension, and (verbs) by conjugation.
    let inflectionElement = _vocab "inflectionElement"

    /// Said of a term that does not appear frequently.
    let infrequentlyUsed = _vocab "infrequentlyUsed"

    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced letter by letter.
    let initialism = _vocab "initialism"

    /// A linking element used to identify a relation between an initialism and its full or expanded form.
    let initialismFor = _vocab "initialismFor"

    /// Case indicating that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause.
    let instrumentalCase = _vocab "instrumentalCase"


    let instrumentalCaseForm = _vocab "instrumentalCaseForm"

    /// Word or sound that expresses an emotion.
    let interjection = _vocab "interjection"

    /// A term that is part of an international scientific nomenclature as adopted by an appropriate scientific body.
    let internationalScientificTerm = _vocab "internationalScientificTerm"

    /// A term that has the same or nearly identical orthographic or phonemic form in many languages.
    let internationalism = _vocab "internationalism"

    /// An interrogative/relative word used to ask about quantity.
    let interrogativeCardinalNumeral = _vocab "interrogativeCardinalNumeral"


    let interrogativeClause = _vocab "interrogativeClause"

    /// Determiner used to express a question.
    let interrogativeDeterminer = _vocab "interrogativeDeterminer"


    let interrogativeInfinitiveClause = _vocab "interrogativeInfinitiveClause"

    /// An interrogative/relative word used to ask about the number of times something happened.
    let interrogativeMultiplicativeNumeral = _vocab "interrogativeMultiplicativeNumeral"

    /// An interrogative/relative word used to ask about numeric ranking.
    let interrogativeOrdinalNumeral = _vocab "interrogativeOrdinalNumeral"

    /// Particle used to express a question.
    let interrogativeParticle = _vocab "interrogativeParticle"

    /// Pronoun used to express a question.
    let interrogativePronoun = _vocab "interrogativePronoun"

    /// pronoun which may act as a relative pronoun or an interrogative one
    let interrogativeRelativePronoun = _vocab "interrogativeRelativePronoun"

    /// Inverted comma.
    let invertedComma = _vocab "invertedComma"


    let ironicRegister = _vocab "ironicRegister"

    /// personal pronoun which is not reflexive
    let irreflexivePersonalPronoun = _vocab "irreflexivePersonalPronoun"


    let languageSpecific = _vocab "languageSpecific"

    /// Case which expresses motion to a location.
    let lativeCase = _vocab "lativeCase"


    let lativeCaseForm = _vocab "lativeCaseForm"

    /// A term that is legally defined and used in legally binding documents.
    let legalTerm = _vocab "legalTerm"


    let letter = _vocab "letter"

    /// verb participating in a complex predication that has little semantic content of its own.
    let lightVerb = _vocab "lightVerb"

    /// Case that indicates a final location of action or a time of the action.
    let locativeCase = _vocab "locativeCase"


    let locativeCaseForm = _vocab "locativeCaseForm"

    /// An expression used to represent a concept based on mathematical or logical relations, such as statements of inequality, set relationships, boolean operations, and the like.
    let logicalExpression = _vocab "logicalExpression"

    /// Main verb in contrast to a modal or an auxiliary.
    let mainVerb = _vocab "mainVerb"

    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to males.
    let masculine = _vocab "masculine"

    /// Designation of a term or word that is not countable and cannot generally be used with the indefinite article or in the plural.
    let massNoun = _vocab "massNoun"


    let massNounNumberForm = _vocab "massNounNumberForm"

    /// usage marker which identifies a semantic extension of the sense of a given lexical unit
    let meaningType = _vocab "meaningType"

    /// Indicates the object is a member of this
    let memberHolonym = _vocab "memberHolonym"

    /// Indicates this is an element of the other
    let memberMeronym = _vocab "memberMeronym"

    /// Indicates this is a part of another concept
    let meronymTerm = _vocab "meronymTerm"

    /// Value for middle voice that expresses that the subject is both the agent and object, or that the subject is separate from the agent or that the receiver is the agent him/herself.
    let middleVoice = _vocab "middleVoice"

    /// Verb form that is usually used with another verb to express ideas such as possibilities, permission, or intention.
    let modal = _vocab "modal"

    /// Currently in use.
    let modern = _vocab "modern"

    /// Refers to the prenominal or postnominal positions of determiners which distinguish different forms.
    let modificationType = _vocab "modificationType"

    /// In TEI: contains information about the grammatical mood of verbs (e.g. indicative, subjunctive, imperative).
    let mood = _vocab "mood"

    /// Unit resulting from the division of words into their smallest meaningful parts.
    /// Note: moved to lexeme element from being an independent element; note that this is currently an independent element in 12620
    let morphologicalElement = _vocab "morphologicalElement"


    let morphosyntacticProperty = _vocab "morphosyntacticProperty"

    /// A word that expresses the number of times something happened.
    let multiplicativeNumeral = _vocab "multiplicativeNumeral"

    /// denotes the negation or the absence
    let negative = _vocab "negative"


    let negativeForm = _vocab "negativeForm"

    /// Particle used to express negation.
    let negativeParticle = _vocab "negativeParticle"

    /// Pronoun used in a context of a negation or for expressing a negation.
    let negativePronoun = _vocab "negativePronoun"

    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to objects that are not characterized as male or female.
    let neuter = _vocab "neuter"

    /// The register appropriate to general texts or discourse.
    let neutralRegister = _vocab "neutralRegister"

    /// Value for negation.
    let no = _vocab "no"

    /// Case used to indicate the subject of a verb.
    let nominativeCase = _vocab "nominativeCase"


    let nominativeCaseForm = _vocab "nominativeCaseForm"

    /// Property related for verb forms occurring on their own only in dependent clauses and lacking tense and mood contrasts.
    let nonFinite = _vocab "nonFinite"

    /// A term status qualifier assigned by an authoritative body, such as a standards body or a governmental entity with a regulatory function.
    let normativeAuthorization = _vocab "normativeAuthorization"

    /// usage marker which identifies the use of a given lexical unit which is in some aspect considered to be non-standard or incorrect
    let normativity = _vocab "normativity"

    /// A statement that provides further information on any part of a language resource entry.
    let note = _vocab "note"

    /// Part of speech used to express the name of a person, place, action or thing.
    let noun = _vocab "noun"

    /// The component of a multiword or multi-morphemic compound term that is determined or modified by the other components making up the term.
    let nucleus = _vocab "nucleus"

    /// Grammatical category for the variation in form of nouns, pronouns, and any words agreeing with them, depending on how many persons or things are referred to. // In many languages, the grammatical distinction that indicates the number of objects referred to by the term or word.
    let number = _vocab "number"

    /// Part of speech that expresses a number or the relation to a number.
    let numeral = _vocab "numeral"

    /// Word used to denote the denominator of a fraction.
    let numeralFraction = _vocab "numeralFraction"


    let object = _vocab "object"


    let objectComplement = _vocab "objectComplement"

    /// Case that is used when a noun is the object of a verb or a proposition, except for nominative and vocative case.
    let obliqueCase = _vocab "obliqueCase"


    let obliqueCaseForm = _vocab "obliqueCaseForm"

    /// A term or lexeme which is no longer in common use.
    let obsoleteForm = _vocab "obsoleteForm"

    /// Used in the past.
    let old = _vocab "old"

    /// Beginning of a pair of parenthesis.
    let openParenthesis = _vocab "openParenthesis"

    /// 1951: An optional part of a headword.
    /// 1951; examples? The question arises whether these are true options or whether the options reflect synonyms or hyponyms (e.g., barrage, barrage de retenue). The question is not whether 1951 should use this markup, but rather how to map this markup in a global environment.
    let optionalElement = _vocab "optionalElement"

    /// Adjective/numeral/number expressing a numeric ranking.
    let ordinalAdjective = _vocab "ordinalAdjective"

    /// Perceived as related to animacy, but without specific reference to the previous items.
    let otherAnimacy = _vocab "otherAnimacy"

    /// A grammatical category that indicates grammatical relationships between words in sentences.
    let otherGender = _vocab "otherGender"

    /// Designation used to classify number-related grammatical information that can differ from the standard European classifications cited above.
    let otherNumber = _vocab "otherNumber"


    let otherNumberForm = _vocab "otherNumberForm"

    /// A term or lexeme that has fallen from fashion, but the meaning of which is readily recognizable.
    let outdatedForm = _vocab "outdatedForm"

    /// Indicates a part of this object
    let partHolonym = _vocab "partHolonym"

    /// Indicates this a component of the other concept
    let partMeronym = _vocab "partMeronym"

    /// A unique alphanumeric designation assigned to an object in a manufacturing system.
    let partNumber = _vocab "partNumber"

    /// A category assigned to a word based on its grammatical and semantic properties. // Term used to describe how a particular word is used in a sentence.
    let partOfSpeech = _vocab "partOfSpeech"

    /// Term referring to a word derived from a verb and used as an adjective.
    let participle = _vocab "participle"

    /// Adjective based on a verb.
    let participleAdjective = _vocab "participleAdjective"

    /// Indicates that one lexical entry is the participle form of another, e.g., the adjective 'reassuring' is the participle of 'to reassure'
    let participleFormOf = _vocab "participleFormOf"

    /// Word that does not belong to one of the main classes of words, is invariable in form, and typically has grammatical or pragmatic meaning.
    let particle = _vocab "particle"

    /// Article expressing a part or quantity.
    let partitiveArticle = _vocab "partitiveArticle"

    /// Case that expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part.
    let partitiveCase = _vocab "partitiveCase"


    let partitiveCaseForm = _vocab "partitiveCaseForm"

    /// A relation between two concepts where one of the concepts constitutes the whole and the other concept a part of that whole.
    let partitiveRelation = _vocab "partitiveRelation"

    /// Term referring to a situation where the grammatical subject is typically the recipient or goal of the action denoted by the verb.
    let passiveVoice = _vocab "passiveVoice"

    /// Past tense is an absolute tense that refers to a time before the moment of utterance.
    let past = _vocab "past"

    /// Adjective based on a past participle.
    let pastParticipleAdjective = _vocab "pastParticipleAdjective"


    let pastTenseForm = _vocab "pastTenseForm"

    /// Number that specifies 'a few' things.
    let paucal = _vocab "paucal"


    let paucalNumberForm = _vocab "paucalNumberForm"

    /// Perfective aspect is an aspect that expresses a temporal view of an event or state as a simple whole, apart from the consideration of the internal structure of the time in which it occurs.
    let perfective = _vocab "perfective"

    /// Indication of grammatical person (1st, 2nd, 3rd, etc.) associated with a given inflected form.
    let person = _vocab "person"

    /// Property that refers to the person.
    let personal = _vocab "personal"

    /// Pronoun referring a person.
    let personalPronoun = _vocab "personalPronoun"

    /// Indicates that a term is the adjectival form of a word with a meaning of 'of or pertaining to X'
    let pertainsTo = _vocab "pertainsTo"

    /// Any group of two or more words that form a unit, the meaning of which frequently cannot be deduced based on the combined sense of the words making up the phrase.
    let phraseologicalUnit = _vocab "phraseologicalUnit"

    /// verb which has its own semantics
    let plainVerb = _vocab "plainVerb"

    /// The form of a term or word (usually of a noun) used to designate more than one object. // Value that expresses more than one element.
    let plural = _vocab "plural"


    let pluralNumberForm = _vocab "pluralNumberForm"

    /// Sign (.) used to expresses the end of a sentence or an abbreviation.
    let point = _vocab "point"

    /// Value used in a comparison relationship when no comparison is involved.
    let positive = _vocab "positive"


    let positiveDegreeForm = _vocab "positiveDegreeForm"


    let positiveForm = _vocab "positiveForm"

    /// Relative to the possession or association.
    let possessive = _vocab "possessive"

    /// An adjective derived from a noun and denoting possession by the object described by the noun.
    let possessiveAdjective = _vocab "possessiveAdjective"


    let possessiveAdjunct = _vocab "possessiveAdjunct"

    /// Determiner that expresses ownership.
    let possessiveDeterminer = _vocab "possessiveDeterminer"


    let possessiveInfinitiveClause = _vocab "possessiveInfinitiveClause"

    /// Particle expressing ownship.
    let possessiveParticle = _vocab "possessiveParticle"

    /// Pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association.
    let possessivePronoun = _vocab "possessivePronoun"

    /// A relative pronoun whose antecedent is the possessor of the subject or object in the relative clause.
    let possessiveRelativePronoun = _vocab "possessiveRelativePronoun"

    /// Situation where the modifier is after the modified.
    let postModifier = _vocab "postModifier"

    /// Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something
    let postPositiveArg = _vocab "postPositiveArg"

    /// Adposition that appears at the end of the noun phrase.
    let postposition = _vocab "postposition"

    /// Situation where the modifier is before the modified.
    let preModifier = _vocab "preModifier"


    let predicativeAdjective = _vocab "predicativeAdjective"


    let predicativeAdjunct = _vocab "predicativeAdjunct"


    let predicativeAdverb = _vocab "predicativeAdverb"


    let predicativeNominative = _vocab "predicativeNominative"

    /// A term rated according to the scale of a term acceptability rating as the primary term for a given concept.
    let preferredTerm = _vocab "preferredTerm"


    let prefix = _vocab "prefix"

    /// Adposition placed at the beginning of a noun phrase.
    let preposition = _vocab "preposition"


    let prepositionalAdjunct = _vocab "prepositionalAdjunct"

    /// adverb which is very similar in its form to a preposition
    let prepositionalAdverb = _vocab "prepositionalAdverb"


    let prepositionalGerundClause = _vocab "prepositionalGerundClause"


    let prepositionalInterrogativeClause = _vocab "prepositionalInterrogativeClause"


    let prepositionalObject = _vocab "prepositionalObject"

    /// Verb tense that indicates action or state of being in the present.
    let present = _vocab "present"

    /// Adjective based on a present participle.
    let presentParticipleAdjective = _vocab "presentParticipleAdjective"


    let presentTenseForm = _vocab "presentTenseForm"

    /// pronoun that identify the current locative or temporal situation
    let presentativePronoun = _vocab "presentativePronoun"

    /// The simple past or preterite as distinct from the perfect form, e.g,, "showed" not "shown"
    let preterite = _vocab "preterite"


    let preteriteTenseForm = _vocab "preteriteTenseForm"

    /// An attribute assigned to a term indicating that that term is the official designator for a product.
    let productName = _vocab "productName"

    /// Case for a noun or a pronoun that expresses motion within a place or a period of time needed for an event.
    let prolativeCase = _vocab "prolativeCase"


    let prolativeCaseForm = _vocab "prolativeCaseForm"

    /// adverb formed in replacement of a preposition and a pronoun
    let pronominalAdverb = _vocab "pronominalAdverb"

    /// Word used in place of a noun or a noun phrase.
    let pronoun = _vocab "pronoun"

    /// The representation of the manner by which a term or word is articulated.
    let pronunciation = _vocab "pronunciation"

    /// A noun or adjective denoting a single object. // Noun that is the name of a specific individual, place, or object.
    let properNoun = _vocab "properNoun"

    /// A brief popular axiom or saying.
    let proverb = _vocab "proverb"

    /// Graphical mark used either at word level to indicate an abbreviation or at a text level to separate phrases or sentences.
    let punctuation = _vocab "punctuation"

    /// Property related to four elements.
    let quadrial = _vocab "quadrial"


    let quadrialNumberForm = _vocab "quadrialNumberForm"

    /// Adjective used to qualify.
    let qualifierAdjective = _vocab "qualifierAdjective"

    /// A term that is very similar but with some differences
    let quasiEquivalent = _vocab "quasiEquivalent"

    /// Sign used to express a question.
    let questionMark = _vocab "questionMark"

    /// A basic identifiable component of every CJKV character, often found on the left side of the character, that sometimes gives a rough indication of meaning and is used for collating lexical and terminological resources.
    let radical = _vocab "radical"

    /// Said of a term that is almost never used.
    let rarelyUsed = _vocab "rarelyUsed"

    /// Pronoun expressing mutual relationship.
    let reciprocalPronoun = _vocab "reciprocalPronoun"

    /// Type of concrete object or concept (the referent) that an expression represents (the reference).
    let referentType = _vocab "referentType"

    /// Determiner that refers to the same entity.
    let reflexiveDeterminer = _vocab "reflexiveDeterminer"


    let reflexiveObject = _vocab "reflexiveObject"

    /// personal pronoun which is reflexive
    let reflexivePersonalPronoun = _vocab "reflexivePersonalPronoun"

    /// A possessive pronoun that refers to the subject as the possessor.
    let reflexivePossessivePronoun = _vocab "reflexivePossessivePronoun"

    /// Classification indicating the relative level of language individually assigned to a lexeme or term or to a text type.
    let register = _vocab "register"

    /// A term defined by law or government regulation.
    let regulatedTerm = _vocab "regulatedTerm"

    /// A term connected to another term by a coordinate or associative relation.
    let relatedTerm = _vocab "relatedTerm"

    /// relation noun
    let relationNoun = _vocab "relationNoun"

    /// Determiner related to a referent.
    let relativeDeterminer = _vocab "relativeDeterminer"

    /// relative particle
    let relativeParticle = _vocab "relativeParticle"

    /// Pronoun which introduces a relative clause and refers to something that has been said before.
    let relativePronoun = _vocab "relativePronoun"

    /// Transcription or transliteration from non-Latin script into Latin script.
    let romanization = _vocab "romanization"

    /// base of a word
    let root = _vocab "root"

    /// Second person deixis is deictic reference to a person or persons identified as addressee.
    let secondPerson = _vocab "secondPerson"


    let secondPersonForm = _vocab "secondPersonForm"

    /// Specification of the pointers in time or sequence that indicates the segmentation process.
    let segmentation = _vocab "segmentation"

    /// Sign (;) usually used to separate phrases.
    let semiColon = _vocab "semiColon"

    /// Descriptive material that provides a sample of an object or entity defined in the entry.
    let senseExample = _vocab "senseExample"

    /// A label for this sense in another language
    let senseTranslation = _vocab "senseTranslation"


    let sententialClause = _vocab "sententialClause"

    /// A fixed, lexicalized phrase.
    let setPhrase = _vocab "setPhrase"

    /// For definiteness, when a specific form is not the syntactic subject of the clause.
    let shortArticle = _vocab "shortArticle"

    /// A variant of a multiword term or lexeme that includes fewer words than the full form.
    let shortForm = _vocab "shortForm"

    /// A linking element used to identify a relation between a short form and its full or expanded form.
    let shortFormFor = _vocab "shortFormFor"

    /// The form of a term or word (usually of a noun) used to designate one object. // Value that expresses one element.
    let singular = _vocab "singular"


    let singularNumberForm = _vocab "singularNumberForm"

    /// An inventory item identified by a unique alphanumeric designation assigned to an object in an inventory control system.
    let sku = _vocab "sku"

    /// An extremely informal register of a word, term, or text that is used in spoken and everyday language and less commonly in documents.
    let slangRegister = _vocab "slangRegister"

    /// The punctuation sign /
    let slash = _vocab "slash"

    /// Case related to the person in whose company the action is carried out, or to any belongings of people which take part in the action.
    let sociativeCase = _vocab "sociativeCase"


    let sociativeCaseForm = _vocab "sociativeCaseForm"

    /// usage marker which identifies the use of a given lexical unit by particular social groups and/or in certain types of communicative situations depending on their level of formality
    let socioCultural = _vocab "socioCultural"

    /// A fixed chunk of recurring text.
    let standardText = _vocab "standardText"

    /// A term that has been standardized by a standardizing body.
    let standardizedTerm = _vocab "standardizedTerm"

    /// A chunk of text used in a software interface, documentation, help file, or the like.
    let string = _vocab "string"

    /// A type value assigned to a string.
    let stringCategory = _vocab "stringCategory"

    /// Personal pronoun that can occupy the position after a preposition and/or reinforce a weak personal pronoun.
    let strongPersonalPronoun = _vocab "strongPersonalPronoun"

    /// relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated
    let subject = _vocab "subject"

    /// Mood often used to express uncertainty, whishes or desires.
    let subjunctive = _vocab "subjunctive"


    let subjunctiveClause = _vocab "subjunctiveClause"


    let subjunctiveMoodForm = _vocab "subjunctiveMoodForm"

    /// Case for a move of something to the surface of another object.
    let sublativeCase = _vocab "sublativeCase"


    let sublativeCaseForm = _vocab "sublativeCaseForm"

    /// Conjunction that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent.
    let subordinatingConjunction = _vocab "subordinatingConjunction"

    /// Indicates what this is composed of
    let substanceHolonym = _vocab "substanceHolonym"

    /// Indicates this is a substance that composes the other
    let substanceMeronym = _vocab "substanceMeronym"


    let suffix = _vocab "suffix"

    /// Case indicating location on top of something or on the surface of something.
    let superessiveCase = _vocab "superessiveCase"


    let superessiveCaseForm = _vocab "superessiveCaseForm"

    /// Value used in a comparison between more than two entities.
    let superlative = _vocab "superlative"


    let superlativeAdjunct = _vocab "superlativeAdjunct"


    let superlativeDegreeForm = _vocab "superlativeDegreeForm"

    /// Particle expressing superlative degree. Superlative is the comparison between more than two entities and contrasts with comparative where only two entities are involved and positive where no comparison is implied.
    let superlativeParticle = _vocab "superlativeParticle"

    /// A term that is no longer preferred or admitted.
    let supersededTerm = _vocab "supersededTerm"

    /// Sequence of three dots having the same meaning as &quot;et cetera&quot; (full form) or &quot;etc&quot; (abbreviated form).
    let suspensionPoints = _vocab "suspensionPoints"

    /// A unit of spoken language that is next bigger than a speech sound and consists of one or more vowel sounds alone or of a syllabic consonant alone or of either with one or more consonant sounds preceding or following.
    let syllable = _vocab "syllable"

    /// A character or glyph representing an idea, concept or object
    let symbol = _vocab "symbol"

    /// Indicates the the terms have the same meaning lexicographically
    let synonym = _vocab "synonym"


    let tabooRegister = _vocab "tabooRegister"

    /// The register appropriate to scientific texts or special languages.
    let technicalRegister = _vocab "technicalRegister"

    /// An attribution of a term or lexeme with respect to its use over time.
    let temporalQualifier = _vocab "temporalQualifier"

    /// Property referring to the way the grammar marks the time at which the action denoted by the verb took place.
    let tense = _vocab "tense"

    /// Any logically significant portion of a larger term or lexeme.
    let termElement = _vocab "termElement"

    /// An attribute assigned to a lexeme or a term.
    let termType = _vocab "termType"

    /// Case that indicates to what or where something ends.
    let terminativeCase = _vocab "terminativeCase"


    let terminativeCaseForm = _vocab "terminativeCaseForm"

    /// usage marker which identifies the typical use of a lexical unit in a particular discourse type or genre
    let textType = _vocab "textType"

    /// Third person deixis is deictic reference to a referent(s) not identified as the speaker or addressee.
    let thirdPerson = _vocab "thirdPerson"


    let thirdPersonForm = _vocab "thirdPersonForm"

    /// A form of a term or lexeme resulting from an operation whereby the characters of one writing system are represented by characters from another writing system, taking into account the pronunciation of the characters converted.
    let transcribedForm = _vocab "transcribedForm"

    /// Indicates that two terms are translations of one another; this is the same as interlingual synonymy
    let translation = _vocab "translation"

    /// The confidence in a given translation.
    let translationConfidence = _vocab "translationConfidence"

    /// Case indicating that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change.
    let translativeCase = _vocab "translativeCase"


    let translativeCaseForm = _vocab "translativeCaseForm"

    /// Form resulting from the conversion of one writing system into another
    let transliteration = _vocab "transliteration"

    /// Grammatical number referring to 'three things', as opposed to 'singular' and 'plural'.
    let trial = _vocab "trial"


    let trialNumberForm = _vocab "trialNumberForm"

    /// aspect that expresses an event or state that is not finished.
    let unaccomplished = _vocab "unaccomplished"

    /// Particle that is not covered by other sorts of particle definitions.
    let unclassifiedParticle = _vocab "unclassifiedParticle"

    /// A note containing information on the usage of the associated word or term.
    let usageNote = _vocab "usageNote"

    /// Element which, singly or in combination with other verbs is used as the minimal predicate of a sentence, co-occurring with a subject. If the predicate contains other elements (e.g. object, complement), then it is the verb which more than any other is the unit which influences the choice and extent of these elements.
    let verb = _vocab "verb"

    /// One of a set of distinctive forms that are used to signal modality. Modality is a facet of illocutionary point or general intent of a speaker, or a speaker's degree of commitment to the expressed proposition's believability, obligatoriness, desirability or reality.
    let verbFormMood = _vocab "verbFormMood"

    /// Case used to indicate direct address.
    let vocativeCase = _vocab "vocativeCase"


    let vocativeCaseForm = _vocab "vocativeCaseForm"

    /// Way sentences may alter the relationship between the subject and object of a verb, without changing the meaning of the sentence.
    let voice = _vocab "voice"

    /// Register of a term or text type that can be characterized as profane or socially unacceptable. // The register of a term or text type that can be characterized as profane or socially unacceptable.
    let vulgarRegister = _vocab "vulgarRegister"

    /// Personal pronoun that cannot occupy the position after a preposition and/or reinforce a strong personal pronoun.
    let weakPersonalPronoun = _vocab "weakPersonalPronoun"

    /// Any lexeme element in a compound lexical unit that is itself a word.
    let wordElement = _vocab "wordElement"

    /// Positive value
    let yes = _vocab "yes"

module termlex =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "https://termlex.oeg.fi.upm.es/termlex#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    let _1 = _vocab "1"


    let _2 = _vocab "2"


    let _3 = _vocab "3"


    let _4 = _vocab "4"


    let _5 = _vocab "5"


    /// The Definition class represents the description of a resource, may it be a concept, a term or any other entity. Additional information can be attached to it, such as the source and authorship of the definition.
    let Definition = _vocab "Definition"

    /// The Note class represents additional information given about a resource, may it be a concept, a term or any other entity. Oher data can be attached to it, such as the source and authorship of the note.
    let Note = _vocab "Note"

    /// The ReliabilityCode class represents the trustworthiness degree of a determined resource, may it be a concept, a term or any other entity. This class points at a fixed set of values, from 1 to 5, for standardisation purposes.
    ///
    let ReliabilityCode = _vocab "ReliabilityCode"

    /// The Source class represents the provenance information of an element, may it be the authorship, notes or other sources.
    let Source = _vocab "Source"

    /// The TerminologicalConcept class represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries, that refer to the same lexical sense, thus, belong to the same area of epertise.
    let TerminologicalConcept = _vocab "TerminologicalConcept"

    /// The Usage class represents usage notes, advices or indications regarding the lexical sense of a given terminological concept.
    let Usage = _vocab "Usage"

    /// The concept property relates an ontological entity to a terminological concept that represents the corresponding meaning.
    let concept = _vocab "concept"

    /// The evokes property relates a lexical entry to the terminological concepts it evokes.
    let evokes = _vocab "evokes"

    /// The isConceptOf property relates the meaning of a Terminological Concept by linking it to a particular ontological meaning.
    let isConceptOf = _vocab "isConceptOf"

    /// The isEvokedBy property relates a terminological concept to one of the lexical entries that evoke it.
    let isEvokedBy = _vocab "isEvokedBy"

    /// The isLexicalizedSense property relates a lexical sense to a unique corresponding terminological concept.
    let isLexicalizedSenseOf = _vocab "isLexicalizedSenseOf"

    /// The lexicalizedSense property relates a terminological concept to a unique corresponding lexical sense.
    let lexicalizedSense = _vocab "lexicalizedSense"

    /// The reliabilityCode property relates a lexical sense to the the reliability code class.
    let reliabilityCode = _vocab "reliabilityCode"



module prov =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/prov#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    /// This document is published by the Provenance Working Group (http://www.w3.org/2011/prov/wiki/Main_Page).
    ///
    /// If you wish to make comments regarding this document, please send them to public-prov-comments@w3.org (subscribe public-prov-comments-request@w3.org, archives http://lists.w3.org/
    /// Archives/Public/public-prov-comments/). All feedback is welcome.
    let value = _vocab ""


    let Accept = _vocab "Accept"


    let Activity = _vocab "Activity"

    /// It is not recommended that the type ActivityInfluence be asserted without also asserting one of its more specific subclasses.
    let ActivityInfluence = _vocab "ActivityInfluence"


    let Agent = _vocab "Agent"

    /// AgentInfluence provides additional descriptions of an Agent's binary influence upon any other kind of resource. Instances of AgentInfluence use the prov:agent property to cite the influencing Agent.
    let AgentInfluence = _vocab "AgentInfluence"

    /// An instance of prov:Association provides additional descriptions about the binary prov:wasAssociatedWith relation from an prov:Activity to some prov:Agent that had some responsiblity for it. For example, :baking prov:wasAssociatedWith :baker; prov:qualifiedAssociation [ a prov:Association; prov:agent :baker; :foo :bar ].
    let Association = _vocab "Association"

    /// An instance of prov:Attribution provides additional descriptions about the binary prov:wasAttributedTo relation from an prov:Entity to some prov:Agent that had some responsible for it. For example, :cake prov:wasAttributedTo :baker; prov:qualifiedAttribution [ a prov:Attribution; prov:entity :baker; :foo :bar ].
    let Attribution = _vocab "Attribution"

    /// Note that there are kinds of bundles (e.g. handwritten letters, audio recordings, etc.) that are not expressed in PROV-O, but can be still be described by PROV-O.
    let Bundle = _vocab "Bundle"


    let Collection = _vocab "Collection"

    /// An instance of prov:Communication provides additional descriptions about the binary prov:wasInformedBy relation from an informed prov:Activity to the prov:Activity that informed it. For example, :you_jumping_off_bridge prov:wasInformedBy :everyone_else_jumping_off_bridge; prov:qualifiedCommunication [ a prov:Communication; prov:activity :everyone_else_jumping_off_bridge; :foo :bar ].
    let Communication = _vocab "Communication"


    let Contribute = _vocab "Contribute"


    let Contributor = _vocab "Contributor"


    let Copyright = _vocab "Copyright"


    let Create = _vocab "Create"


    let Creator = _vocab "Creator"

    /// An instance of prov:Delegation provides additional descriptions about the binary prov:actedOnBehalfOf relation from a performing prov:Agent to some prov:Agent for whom it was performed. For example, :mixing prov:wasAssociatedWith :toddler . :toddler prov:actedOnBehalfOf :mother; prov:qualifiedDelegation [ a prov:Delegation; prov:entity :mother; :foo :bar ].
    let Delegation = _vocab "Delegation"

    /// An instance of prov:Derivation provides additional descriptions about the binary prov:wasDerivedFrom relation from some derived prov:Entity to another prov:Entity from which it was derived. For example, :chewed_bubble_gum prov:wasDerivedFrom :unwrapped_bubble_gum; prov:qualifiedDerivation [ a prov:Derivation; prov:entity :unwrapped_bubble_gum; :foo :bar ].
    let Derivation = _vocab "Derivation"

    /// This concept allows for the provenance of the dictionary, but also of its constituents to be expressed. Such a notion of dictionary corresponds to a wide variety of concrete data structures, such as a maps or associative arrays.
    let Dictionary = _vocab "Dictionary"

    /// Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.
    let DirectQueryService = _vocab "DirectQueryService"


    let EmptyCollection = _vocab "EmptyCollection"


    let EmptyDictionary = _vocab "EmptyDictionary"

    /// An instance of prov:End provides additional descriptions about the binary prov:wasEndedBy relation from some ended prov:Activity to an prov:Entity that ended it. For example, :ball_game prov:wasEndedBy :buzzer; prov:qualifiedEnd [ a prov:End; prov:entity :buzzer; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ].
    let End = _vocab "End"


    let Entity = _vocab "Entity"

    /// EntityInfluence provides additional descriptions of an Entity's binary influence upon any other kind of resource. Instances of EntityInfluence use the prov:entity property to cite the influencing Entity.
    let EntityInfluence = _vocab "EntityInfluence"

    /// An instance of prov:Generation provides additional descriptions about the binary prov:wasGeneratedBy relation from a generated prov:Entity to the prov:Activity that generated it. For example, :cake prov:wasGeneratedBy :baking; prov:qualifiedGeneration [ a prov:Generation; prov:activity :baking; :foo :bar ].
    let Generation = _vocab "Generation"

    /// An instance of prov:Influence provides additional descriptions about the binary prov:wasInfluencedBy relation from some influenced Activity, Entity, or Agent to the influencing Activity, Entity, or Agent. For example, :stomach_ache prov:wasInfluencedBy :spoon; prov:qualifiedInfluence [ a prov:Influence; prov:entity :spoon; :foo :bar ] . Because prov:Influence is a broad relation, the more specific relations (Communication, Delegation, End, etc.) should be used when applicable.
    let Influence = _vocab "Influence"


    let Insertion = _vocab "Insertion"

    /// An instantaneous event, or event for short, happens in the world and marks a change in the world, in its activities and in its entities. The term 'event' is commonly used in process algebra with a similar meaning. Events represent communications or interactions; they are assumed to be atomic and instantaneous.
    let InstantaneousEvent = _vocab "InstantaneousEvent"

    /// An instance of prov:Invalidation provides additional descriptions about the binary prov:wasInvalidatedBy relation from an invalidated prov:Entity to the prov:Activity that invalidated it. For example, :uncracked_egg prov:wasInvalidatedBy :baking; prov:qualifiedInvalidation [ a prov:Invalidation; prov:activity :baking; :foo :bar ].
    let Invalidation = _vocab "Invalidation"


    let KeyEntityPair = _vocab "KeyEntityPair"


    let Location = _vocab "Location"


    let Modify = _vocab "Modify"


    let Organization = _vocab "Organization"


    let Person = _vocab "Person"

    /// There exist no prescriptive requirement on the nature of plans, their representation, the actions or steps they consist of, or their intended goals. Since plans may evolve over time, it may become necessary to track their provenance, so plans themselves are entities. Representing the plan explicitly in the provenance can be useful for various tasks: for example, to validate the execution as represented in the provenance record, to manage expectation failures, or to provide explanations.
    let Plan = _vocab "Plan"

    /// An instance of prov:PrimarySource provides additional descriptions about the binary prov:hadPrimarySource relation from some secondary prov:Entity to an earlier, primary prov:Entity. For example, :blog prov:hadPrimarySource :newsArticle; prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :newsArticle; :foo :bar ] .
    let PrimarySource = _vocab "PrimarySource"


    let Publish = _vocab "Publish"


    let Publisher = _vocab "Publisher"

    /// An instance of prov:Quotation provides additional descriptions about the binary prov:wasQuotedFrom relation from some taken prov:Entity from an earlier, larger prov:Entity. For example, :here_is_looking_at_you_kid prov:wasQuotedFrom :casablanca_script; prov:qualifiedQuotation [ a prov:Quotation; prov:entity :casablanca_script; :foo :bar ].
    let Quotation = _vocab "Quotation"


    let Removal = _vocab "Removal"


    let Replace = _vocab "Replace"

    /// An instance of prov:Revision provides additional descriptions about the binary prov:wasRevisionOf relation from some newer prov:Entity to an earlier prov:Entity. For example, :draft_2 prov:wasRevisionOf :draft_1; prov:qualifiedRevision [ a prov:Revision; prov:entity :draft_1; :foo :bar ].
    let Revision = _vocab "Revision"


    let RightsAssignment = _vocab "RightsAssignment"


    let RightsHolder = _vocab "RightsHolder"


    let Role = _vocab "Role"

    /// Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.
    let ServiceDescription = _vocab "ServiceDescription"


    let SoftwareAgent = _vocab "SoftwareAgent"

    /// An instance of prov:Start provides additional descriptions about the binary prov:wasStartedBy relation from some started prov:Activity to an prov:Entity that started it. For example, :foot_race prov:wasStartedBy :bang; prov:qualifiedStart [ a prov:Start; prov:entity :bang; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ] .
    let Start = _vocab "Start"


    let Submit = _vocab "Submit"

    /// An instance of prov:Usage provides additional descriptions about the binary prov:used relation from some prov:Activity to an prov:Entity that it used. For example, :keynote prov:used :podium; prov:qualifiedUsage [ a prov:Usage; prov:entity :podium; :foo :bar ].
    let Usage = _vocab "Usage"

    /// An object property to express the accountability of an agent towards another agent. The subordinate agent acted on behalf of the responsible agent in an actual activity.
    let actedOnBehalfOf = _vocab "actedOnBehalfOf"


    let activity = _vocab "activity"


    let activityOfInfluence = _vocab "activityOfInfluence"


    let agent = _vocab "agent"


    let agentOfInfluence = _vocab "agentOfInfluence"


    let alternateOf = _vocab "alternateOf"


    let aq = _vocab "aq"

    /// prov:asInBundle is used to specify which bundle the general entity of a prov:mentionOf property is described.
    ///
    /// When :x prov:mentionOf :y and :y is described in Bundle :b, the triple :x prov:asInBundle :b is also asserted to cite the Bundle in which :y was described.
    let asInBundle = _vocab "asInBundle"

    /// The Location of any resource.
    let atLocation = _vocab "atLocation"

    /// The time at which an InstantaneousEvent occurred, in the form of xsd:dateTime.
    let atTime = _vocab "atTime"

    /// Classify prov-o terms into three categories, including 'starting-point', 'qualifed', and 'extended'. This classification is used by the prov-o html document to gently introduce prov-o terms to its users.
    let category = _vocab "category"

    /// Classify prov-o terms into six components according to prov-dm, including 'agents-responsibility', 'alternate', 'annotations', 'collections', 'derivations', and 'entities-activities'. This classification is used so that readers of prov-o specification can find its correspondence with the prov-dm specification.
    let component = _vocab "component"

    /// A reference to the principal section of the PROV-CONSTRAINTS document that describes this concept.
    let constraints = _vocab "constraints"


    let contributed = _vocab "contributed"

    /// A definition quoted from PROV-DM or PROV-CONSTRAINTS that describes the concept expressed with this OWL term.
    let definition = _vocab "definition"


    let derivedByInsertionFrom = _vocab "derivedByInsertionFrom"


    let derivedByRemovalFrom = _vocab "derivedByRemovalFrom"

    /// relates a generic provenance query service resource (type prov:ServiceDescription) to a specific query service description (e.g. a prov:DirectQueryService or a sd:Service).
    let describesService = _vocab "describesService"


    let dictionary = _vocab "dictionary"

    /// A reference to the principal section of the PROV-DM document that describes this concept.
    let dm = _vocab "dm"

    /// A note by the OWL development team about how this term expresses the PROV-DM concept, or how it should be used in context of semantic web or linked data.
    let editorialNote = _vocab "editorialNote"

    /// When the prov-o term does not have a definition drawn from prov-dm, and the prov-o editor provides one.
    let editorsDefinition = _vocab "editorsDefinition"


    let ended = _vocab "ended"

    /// The time at which an activity ended. See also prov:startedAtTime.
    let endedAtTime = _vocab "endedAtTime"


    let entity = _vocab "entity"


    let entityOfInfluence = _vocab "entityOfInfluence"


    let generalizationOf = _vocab "generalizationOf"


    let generated = _vocab "generated"


    let generatedAsDerivation = _vocab "generatedAsDerivation"

    /// The time at which an entity was completely created and is available for use.
    let generatedAtTime = _vocab "generatedAtTime"

    /// The _optional_ Activity of an Influence, which used, generated, invalidated, or was the responsibility of some Entity. This property is _not_ used by ActivityInfluence (use prov:activity instead).
    let hadActivity = _vocab "hadActivity"


    let hadDelegate = _vocab "hadDelegate"


    let hadDerivation = _vocab "hadDerivation"


    let hadDictionaryMember = _vocab "hadDictionaryMember"

    /// The _optional_ Generation involved in an Entity's Derivation.
    let hadGeneration = _vocab "hadGeneration"


    let hadInfluence = _vocab "hadInfluence"


    let hadMember = _vocab "hadMember"

    /// The _optional_ Plan adopted by an Agent in Association with some Activity. Plan specifications are out of the scope of this specification.
    let hadPlan = _vocab "hadPlan"


    let hadPrimarySource = _vocab "hadPrimarySource"


    let hadRevision = _vocab "hadRevision"

    /// The _optional_ Role that an Entity assumed in the context of an Activity. For example, :baking prov:used :spoon; prov:qualified [ a prov:Usage; prov:entity :spoon; prov:hadRole roles:mixing_implement ].
    let hadRole = _vocab "hadRole"

    /// The _optional_ Usage involved in an Entity's Derivation.
    let hadUsage = _vocab "hadUsage"

    /// Indicates anchor URI for a potentially dynamic resource instance.
    let has_anchor = _vocab "has_anchor"

    /// Indicates a provenance-URI for a resource; the resource identified by this property presents a provenance record about its subject or anchor resource.
    let has_provenance = _vocab "has_provenance"

    /// Indicates a provenance query service that can access provenance related to its subject or anchor resource.
    let has_query_service = _vocab "has_query_service"


    let influenced = _vocab "influenced"

    /// Subproperties of prov:influencer are used to cite the object of an unqualified PROV-O triple whose predicate is a subproperty of prov:wasInfluencedBy (e.g. prov:used, prov:wasGeneratedBy). prov:influencer is used much like rdf:object is used.
    let influencer = _vocab "influencer"


    let informed = _vocab "informed"


    let insertedKeyEntityPair = _vocab "insertedKeyEntityPair"


    let invalidated = _vocab "invalidated"

    /// The time at which an entity was invalidated (i.e., no longer usable).
    let invalidatedAtTime = _vocab "invalidatedAtTime"

    /// PROV-O does not define all property inverses. The directionalities defined in PROV-O should be given preference over those not defined. However, if users wish to name the inverse of a PROV-O property, the local name given by prov:inverse should be used.
    let inverse = _vocab "inverse"


    let locationOf = _vocab "locationOf"

    /// prov:mentionOf is used to specialize an entity as described in another bundle. It is to be used in conjuction with prov:asInBundle.
    ///
    /// prov:asInBundle is used to cite the Bundle in which the generalization was mentioned.
    let mentionOf = _vocab "mentionOf"

    /// A reference to the principal section of the PROV-DM document that describes this concept.
    let n = _vocab "n"

    /// The position that this OWL term should be listed within documentation. The scope of the documentation (e.g., among all terms, among terms within a prov:category, among properties applying to a particular class, etc.) is unspecified.
    let order = _vocab "order"


    let pairEntity = _vocab "pairEntity"


    let pairKey = _vocab "pairKey"

    /// Relates a resource to a provenance pingback service that may receive additional provenance links about the resource.
    let pingback = _vocab "pingback"

    /// Relates a provenance service to a URI template string for constructing provenance-URIs.
    let provenanceUriTemplate = _vocab "provenanceUriTemplate"

    /// If this Activity prov:wasAssociatedWith Agent :ag, then it can qualify the Association using prov:qualifiedAssociation [ a prov:Association;  prov:agent :ag; :foo :bar ].
    let qualifiedAssociation = _vocab "qualifiedAssociation"


    let qualifiedAssociationOf = _vocab "qualifiedAssociationOf"

    /// If this Entity prov:wasAttributedTo Agent :ag, then it can qualify how it was influenced using prov:qualifiedAttribution [ a prov:Attribution;  prov:agent :ag; :foo :bar ].
    let qualifiedAttribution = _vocab "qualifiedAttribution"


    let qualifiedAttributionOf = _vocab "qualifiedAttributionOf"

    /// If this Activity prov:wasInformedBy Activity :a, then it can qualify how it was influenced using prov:qualifiedCommunication [ a prov:Communication;  prov:activity :a; :foo :bar ].
    let qualifiedCommunication = _vocab "qualifiedCommunication"


    let qualifiedCommunicationOf = _vocab "qualifiedCommunicationOf"

    /// If this Agent prov:actedOnBehalfOf Agent :ag, then it can qualify how with prov:qualifiedResponsibility [ a prov:Responsibility;  prov:agent :ag; :foo :bar ].
    let qualifiedDelegation = _vocab "qualifiedDelegation"


    let qualifiedDelegationOf = _vocab "qualifiedDelegationOf"

    /// If this Entity prov:wasDerivedFrom Entity :e, then it can qualify how it was derived using prov:qualifiedDerivation [ a prov:Derivation;  prov:entity :e; :foo :bar ].
    let qualifiedDerivation = _vocab "qualifiedDerivation"


    let qualifiedDerivationOf = _vocab "qualifiedDerivationOf"

    /// If this Activity prov:wasEndedBy Entity :e1, then it can qualify how it was ended using prov:qualifiedEnd [ a prov:End;  prov:entity :e1; :foo :bar ].
    let qualifiedEnd = _vocab "qualifiedEnd"


    let qualifiedEndOf = _vocab "qualifiedEndOf"

    /// This annotation property links a subproperty of prov:wasInfluencedBy with the subclass of prov:Influence and the qualifying property that are used to qualify it.
    ///
    /// Example annotation:
    ///
    ///     prov:wasGeneratedBy prov:qualifiedForm prov:qualifiedGeneration, prov:Generation .
    ///
    /// Then this unqualified assertion:
    ///
    ///     :entity1 prov:wasGeneratedBy :activity1 .
    ///
    /// can be qualified by adding:
    ///
    ///    :entity1 prov:qualifiedGeneration :entity1Gen .
    ///    :entity1Gen
    ///        a prov:Generation, prov:Influence;
    ///        prov:activity :activity1;
    ///        :customValue 1337 .
    ///
    /// Note how the value of the unqualified influence (prov:wasGeneratedBy :activity1) is mirrored as the value of the prov:activity (or prov:entity, or prov:agent) property on the influence class.
    let qualifiedForm = _vocab "qualifiedForm"

    /// If this Activity prov:generated Entity :e, then it can qualify how it performed the Generation using prov:qualifiedGeneration [ a prov:Generation;  prov:entity :e; :foo :bar ].
    let qualifiedGeneration = _vocab "qualifiedGeneration"


    let qualifiedGenerationOf = _vocab "qualifiedGenerationOf"

    /// Because prov:qualifiedInfluence is a broad relation, the more specific relations (qualifiedCommunication, qualifiedDelegation, qualifiedEnd, etc.) should be used when applicable.
    let qualifiedInfluence = _vocab "qualifiedInfluence"


    let qualifiedInfluenceOf = _vocab "qualifiedInfluenceOf"


    let qualifiedInsertion = _vocab "qualifiedInsertion"

    /// If this Entity prov:wasInvalidatedBy Activity :a, then it can qualify how it was invalidated using prov:qualifiedInvalidation [ a prov:Invalidation;  prov:activity :a; :foo :bar ].
    let qualifiedInvalidation = _vocab "qualifiedInvalidation"


    let qualifiedInvalidationOf = _vocab "qualifiedInvalidationOf"

    /// If this Entity prov:hadPrimarySource Entity :e, then it can qualify how using prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :e; :foo :bar ].
    let qualifiedPrimarySource = _vocab "qualifiedPrimarySource"

    /// If this Entity prov:wasQuotedFrom Entity :e, then it can qualify how using prov:qualifiedQuotation [ a prov:Quotation;  prov:entity :e; :foo :bar ].
    let qualifiedQuotation = _vocab "qualifiedQuotation"


    let qualifiedQuotationOf = _vocab "qualifiedQuotationOf"


    let qualifiedRemoval = _vocab "qualifiedRemoval"

    /// If this Entity prov:wasRevisionOf Entity :e, then it can qualify how it was revised using prov:qualifiedRevision [ a prov:Revision;  prov:entity :e; :foo :bar ].
    let qualifiedRevision = _vocab "qualifiedRevision"


    let qualifiedSourceOf = _vocab "qualifiedSourceOf"

    /// If this Activity prov:wasStartedBy Entity :e1, then it can qualify how it was started using prov:qualifiedStart [ a prov:Start;  prov:entity :e1; :foo :bar ].
    let qualifiedStart = _vocab "qualifiedStart"


    let qualifiedStartOf = _vocab "qualifiedStartOf"

    /// If this Activity prov:used Entity :e, then it can qualify how it used it using prov:qualifiedUsage [ a prov:Usage; prov:entity :e; :foo :bar ].
    let qualifiedUsage = _vocab "qualifiedUsage"


    let qualifiedUsingActivity = _vocab "qualifiedUsingActivity"


    let quotedAs = _vocab "quotedAs"


    let removedKey = _vocab "removedKey"


    let revisedEntity = _vocab "revisedEntity"


    let sharesDefinitionWith = _vocab "sharesDefinitionWith"


    let specializationOf = _vocab "specializationOf"


    let started = _vocab "started"

    /// The time at which an activity started. See also prov:endedAtTime.
    let startedAtTime = _vocab "startedAtTime"


    let todo = _vocab "todo"

    /// Classes and properties used to qualify relationships are annotated with prov:unqualifiedForm to indicate the property used to assert an unqualified provenance relation.
    let unqualifiedForm = _vocab "unqualifiedForm"

    /// A prov:Entity that was used by this prov:Activity. For example, :baking prov:used :spoon, :egg, :oven .
    let used = _vocab "used"


    let wasActivityOfInfluence = _vocab "wasActivityOfInfluence"


    let wasAssociateFor = _vocab "wasAssociateFor"

    /// An prov:Agent that had some (unspecified) responsibility for the occurrence of this prov:Activity.
    let wasAssociatedWith = _vocab "wasAssociatedWith"

    /// Attribution is the ascribing of an entity to an agent.
    let wasAttributedTo = _vocab "wasAttributedTo"

    /// The more specific subproperties of prov:wasDerivedFrom (i.e., prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource) should be used when applicable.
    let wasDerivedFrom = _vocab "wasDerivedFrom"

    /// End is when an activity is deemed to have ended. An end may refer to an entity, known as trigger, that terminated the activity.
    let wasEndedBy = _vocab "wasEndedBy"


    let wasGeneratedBy = _vocab "wasGeneratedBy"

    /// This property has multiple RDFS domains to suit multiple OWL Profiles. See <a href="#owl-profile">PROV-O OWL Profile</a>.
    let wasInfluencedBy = _vocab "wasInfluencedBy"

    /// An activity a2 is dependent on or informed by another activity a1, by way of some unspecified entity that is generated by a1 and used by a2.
    let wasInformedBy = _vocab "wasInformedBy"


    let wasInvalidatedBy = _vocab "wasInvalidatedBy"


    let wasMemberOf = _vocab "wasMemberOf"


    let wasPlanOf = _vocab "wasPlanOf"


    let wasPrimarySourceOf = _vocab "wasPrimarySourceOf"

    /// An entity is derived from an original entity by copying, or 'quoting', some or all of it.
    let wasQuotedFrom = _vocab "wasQuotedFrom"

    /// A revision is a derivation that revises an entity into a revised version.
    let wasRevisionOf = _vocab "wasRevisionOf"


    let wasRoleIn = _vocab "wasRoleIn"

    /// Start is when an activity is deemed to have started. A start may refer to an entity, known as trigger, that initiated the activity.
    let wasStartedBy = _vocab "wasStartedBy"


    let wasUsedBy = _vocab "wasUsedBy"


    let wasUsedInDerivation = _vocab "wasUsedInDerivation"





module foaf =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://xmlns.com/foaf/0.1/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let value = _vocab ""

    /// An agent (eg. person, group, software or physical artifact).
    let Agent = _vocab "Agent"

    /// A document.
    let Document = _vocab "Document"

    /// A class of Agents.
    let Group = _vocab "Group"

    /// An image.
    let Image = _vocab "Image"

    /// A foaf:LabelProperty is any RDF property with texual values that serve as labels.
    let LabelProperty = _vocab "LabelProperty"

    /// An online account.
    let OnlineAccount = _vocab "OnlineAccount"

    /// An online chat account.
    let OnlineChatAccount = _vocab "OnlineChatAccount"

    /// An online e-commerce account.
    let OnlineEcommerceAccount = _vocab "OnlineEcommerceAccount"

    /// An online gaming account.
    let OnlineGamingAccount = _vocab "OnlineGamingAccount"

    /// An organization.
    let Organization = _vocab "Organization"

    /// A person.
    let Person = _vocab "Person"

    /// A personal profile RDF document.
    let PersonalProfileDocument = _vocab "PersonalProfileDocument"

    /// A project (a collective endeavour of some kind).
    let Project = _vocab "Project"

    /// Indicates an account held by this agent.
    let account = _vocab "account"

    /// Indicates the name (identifier) associated with this online account.
    let accountName = _vocab "accountName"

    /// Indicates a homepage of the service provide for this online account.
    let accountServiceHomepage = _vocab "accountServiceHomepage"

    /// The age in years of some agent.
    let age = _vocab "age"

    /// An AIM chat ID
    let aimChatID = _vocab "aimChatID"

    /// A location that something is based near, for some broadly human notion of near.
    let based_near = _vocab "based_near"

    /// The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.
    let birthday = _vocab "birthday"

    /// A current project this person works on.
    let currentProject = _vocab "currentProject"

    /// A depiction of some thing.
    let depiction = _vocab "depiction"

    /// A thing depicted in this representation.
    let depicts = _vocab "depicts"

    /// A checksum for the DNA of some thing. Joke.
    let dnaChecksum = _vocab "dnaChecksum"

    /// The family name of some person.
    let familyName = _vocab "familyName"

    /// The family name of some person.
    let family_name = _vocab "family_name"

    /// The first name of a person.
    let firstName = _vocab "firstName"

    /// The underlying or 'focal' entity associated with some SKOS-described concept.
    let focus = _vocab "focus"

    /// An organization funding a project or person.
    let fundedBy = _vocab "fundedBy"

    /// A textual geekcode for this person, see http://www.geekcode.com/geek.html
    let geekcode = _vocab "geekcode"

    /// The gender of this Agent (typically but not necessarily 'male' or 'female').
    let gender = _vocab "gender"

    /// The given name of some person.
    let givenName = _vocab "givenName"

    /// The given name of some person.
    let givenname = _vocab "givenname"

    /// Indicates an account held by this agent.
    let holdsAccount = _vocab "holdsAccount"

    /// A homepage for some thing.
    let homepage = _vocab "homepage"

    /// An ICQ chat ID
    let icqChatID = _vocab "icqChatID"

    /// An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).
    let img = _vocab "img"

    /// A page about a topic of interest to this person.
    let interest = _vocab "interest"

    /// A document that this thing is the primary topic of.
    let isPrimaryTopicOf = _vocab "isPrimaryTopicOf"

    /// A jabber ID for something.
    let jabberID = _vocab "jabberID"

    /// A person known by this person (indicating some level of reciprocated interaction between the parties).
    let knows = _vocab "knows"

    /// The last name of a person.
    let lastName = _vocab "lastName"

    /// A logo representing some thing.
    let logo = _vocab "logo"

    /// Something that was made by this agent.
    let made = _vocab "made"

    /// An agent that  made this thing.
    let maker = _vocab "maker"

    /// A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.
    let mbox = _vocab "mbox"

    /// The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.
    let mbox_sha1sum = _vocab "mbox_sha1sum"

    /// Indicates a member of a Group
    let ``member`` = _vocab "member"

    /// Indicates the class of individuals that are a member of a Group
    let membershipClass = _vocab "membershipClass"

    /// An MSN chat ID
    let msnChatID = _vocab "msnChatID"

    /// A Myers Briggs (MBTI) personality classification.
    let myersBriggs = _vocab "myersBriggs"

    /// A name for some thing.
    let name = _vocab "name"

    /// A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).
    let nick = _vocab "nick"

    /// An OpenID for an Agent.
    let openid = _vocab "openid"

    /// A page or document about this thing.
    let page = _vocab "page"

    /// A project this person has previously worked on.
    let pastProject = _vocab "pastProject"

    /// A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).
    let phone = _vocab "phone"

    /// A .plan comment, in the tradition of finger and '.plan' files.
    let plan = _vocab "plan"

    /// The primary topic of some page or document.
    let primaryTopic = _vocab "primaryTopic"

    /// A link to the publications of this person.
    let publications = _vocab "publications"

    /// A homepage of a school attended by the person.
    let schoolHomepage = _vocab "schoolHomepage"

    /// A sha1sum hash, in hex.
    let sha1 = _vocab "sha1"

    /// A Skype ID
    let skypeID = _vocab "skypeID"

    /// A string expressing what the user is happy for the general public (normally) to know about their current activity.
    let status = _vocab "status"

    /// The surname of some person.
    let surname = _vocab "surname"

    /// A theme.
    let theme = _vocab "theme"

    /// A derived thumbnail image.
    let thumbnail = _vocab "thumbnail"

    /// A tipjar document for this agent, describing means for payment and reward.
    let tipjar = _vocab "tipjar"

    /// Title (Mr, Mrs, Ms, Dr. etc)
    let title = _vocab "title"

    /// A topic of some page or document.
    let topic = _vocab "topic"

    /// A thing of interest to this person.
    let topic_interest = _vocab "topic_interest"

    /// A weblog of some thing (whether person, group, company etc.).
    let weblog = _vocab "weblog"

    /// A work info homepage of some person; a page about their work for some organization.
    let workInfoHomepage = _vocab "workInfoHomepage"

    /// A workplace homepage of some person; the homepage of an organization they work for.
    let workplaceHomepage = _vocab "workplaceHomepage"

    /// A Yahoo chat ID
    let yahooChatID = _vocab "yahooChatID"



module dcat =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/dcat#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let Catalog = _vocab "Catalog"


    let DataService = _vocab "DataService"


    let Dataset = _vocab "Dataset"


    let Distribution = _vocab "Distribution"


    let accessService = _vocab "accessService"


    let accessURL = _vocab "accessURL"


    let catalog = _vocab "catalog"


    let dataset = _vocab "dataset"


    let distribution = _vocab "distribution"


    let endpointURL = _vocab "endpointURL"


    let keyword = _vocab "keyword"


    let mediaType = _vocab "mediaType"


    let servesDataset = _vocab "servesDataset"


    let service = _vocab "service"


    let theme = _vocab "theme"


    let themeTaxonomy = _vocab "themeTaxonomy"


module rr =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/ns/r2rml#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let value = _vocab "value"

    let BaseTableOrView = _vocab "BaseTableOrView"

    /// Denotes a blank node, used with termType
    let BlankNode = _vocab "BlankNode"

    /// Represents a graph map.
    let GraphMap = _vocab "GraphMap"

    /// Denotes an IRI, used with termpType.
    let IRI = _vocab "IRI"

    /// Represents a join condition.
    let Join = _vocab "Join"

    /// Denotes a Literal, used with termType.
    let Literal = _vocab "Literal"

    /// Represents a logical table.
    let LogicalTable = _vocab "LogicalTable"

    /// Represents an object map.
    let ObjectMap = _vocab "ObjectMap"

    /// Represents a predicate map.
    let PredicateMap = _vocab "PredicateMap"

    /// Represents a predicate-object map.
    let PredicateObjectMap = _vocab "PredicateObjectMap"

    let R2RMLView = _vocab "R2RMLView"

    /// Denotes a reference to an object map.
    let RefObjectMap = _vocab "RefObjectMap"

    /// Core SQL 2008
    let SQL2008 = _vocab "SQL2008"

    /// Represents a subject map.
    let SubjectMap = _vocab "SubjectMap"

    /// A function that generates an RDF term from a logical table row.
    let TermMap = _vocab "TermMap"

    /// Represents a triples map.
    let TriplesMap = _vocab "TriplesMap"

    /// Names a column in the child table of a join.
    let child = _vocab "child"

    /// The subject value generated for a logical table row will be asserted as an instance of this RDFS class.
    let ``class`` = _vocab "class"

    /// Name of a column in the logical table. When generating RDF triples from a logical table row, value from the specified column is used as the subject, predicate, or object (based upon the specific domain).
    let column = _vocab "column"

    let constant = _vocab "constant"

    /// Specifies the datatype of the object component for the generated triple from a logical table row.
    let datatype = _vocab "datatype"

    /// Denotes a default graph
    let defaultGraph = _vocab "defaultGraph"

    /// An IRI reference for use as the graph name of all triples generated with the GraphMap.
    let graph = _vocab "graph"

    /// Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph.
    let graphMap = _vocab "graphMap"

    /// An expression that allows, at query processing time, use of index-based access to the the (underlying) relational tables, instead of simply retrieving the table rows first and then applying a filter. This property is useful for retrieval based on conditions involving subject, predicate, or object generated from logical table column(s) and involves some transformation.
    let inverseExpression = _vocab "inverseExpression"

    /// Specifies the join condition for joining the child logical table with the parent logical table of the foreign key constraint.
    let joinCondition = _vocab "joinCondition"

    /// Specified the language for the object component for the generated triple from a logical table row.
    let language = _vocab "language"

    /// Definition of logical table to be mapped.
    let logicalTable = _vocab "logicalTable"

    /// Specifies the object for the generated triple from the logical table row.
    let object = _vocab "object"

    /// An ObjectMap element to generate the object component of the (predicate, object) pair from a logical table row.
    let objectMap = _vocab "objectMap"

    /// Names a column in the parent table of a join.
    let parent = _vocab "parent"

    /// Specifies the TriplesMap element corresponding to the parent logical table of the foreign key constraint.
    let parentTriplesMap = _vocab "parentTriplesMap"

    /// Specifies the predicate for the generated triple from the logical table row.
    let predicate = _vocab "predicate"

    /// A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical table row.
    let predicateMap = _vocab "predicateMap"

    /// A PredicateObjectMap element to generate (predicate, object) pair from a logical table row.
    let predicateObjectMap = _vocab "predicateObjectMap"

    /// A valid SQL query.
    let sqlQuery = _vocab "sqlQuery"

    /// An identifier for a SQL version.
    let sqlVersion = _vocab "sqlVersion"

    /// An IRI reference for use as subject for all the RDF triples generated from a logical table row.
    let subject = _vocab "subject"

    /// A SubjectMap element to generate a subject from a logical table row.
    let subjectMap = _vocab "subjectMap"

    /// Schema-qualified name of a table or view.
    let tableName = _vocab "tableName"

    /// A template (format string) to specify how to generate a value for a subject, predicate, or object, using one or more columns from a logical table row.
    let template = _vocab "template"

    /// A string indicating whether subject or object generated using the value from column name specified for rr:column should be an IRI reference, blank node, or a literal.
    let termType = _vocab "termType"


module om =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "https://open-metadata.org/ontology/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }



    let value = _vocab ""

    /// AI system such as a chatbot, agent, copilot, RAG application or multi-agent pipeline that may use multiple LLM models and tools
    let AIApplication = _vocab "AIApplication"

    /// Policy rules for AI/LLM usage, compliance, and risk management (model approval, data access, bias thresholds, cost controls, etc.)
    let AIGovernancePolicy = _vocab "AIGovernancePolicy"

    /// Collection of API endpoints
    let APICollection = _vocab "APICollection"

    /// Documentation for API endpoints
    let APIDocumentation = _vocab "APIDocumentation"

    /// API endpoint providing data access service
    let APIEndpoint = _vocab "APIEndpoint"


    let APIService = _vocab "APIService"

    /// Single execution run of an AI agent, tracking inputs, outputs, lineage, metrics and errors for observability and governance
    let AgentExecution = _vocab "AgentExecution"

    /// Certification status of an asset
    let AssetCertification = _vocab "AssetCertification"


    let Bot = _vocab "Bot"

    /// Curated collection of metadata about resources
    let Catalog = _vocab "Catalog"

    /// Metadata about when/how an entity was cataloged
    let CatalogRecord = _vocab "CatalogRecord"

    /// Description of changes that led to a version of an entity
    let ChangeDescription = _vocab "ChangeDescription"


    let Chart = _vocab "Chart"

    /// Tag Category
    let Classification = _vocab "Classification"

    /// Column in a table
    let Column = _vocab "Column"

    /// Storage container organizing multiple datasets
    let Container = _vocab "Container"

    /// Dashboard for data visualization
    let Dashboard = _vocab "Dashboard"

    /// Dashboard Data Model entity to capture the data models used by dashboards
    let DashboardDataModel = _vocab "DashboardDataModel"

    /// Dashboard data model column context type used to attach custom properties to columns of a DashboardDataModel
    let DashboardDataModelColumn = _vocab "DashboardDataModelColumn"


    let DashboardService = _vocab "DashboardService"

    /// Base class for all data assets
    let DataAsset = _vocab "DataAsset"


    let DataContract = _vocab "DataContract"


    let DataProduct = _vocab "DataProduct"

    /// Service Level Agreement for a data product
    let DataProductSLA = _vocab "DataProductSLA"

    /// Service that provides access to data
    let DataService = _vocab "DataService"


    let Database = _vocab "Database"


    let DatabaseSchema = _vocab "DatabaseSchema"


    let DatabaseService = _vocab "DatabaseService"

    /// Collection of related datasets, e.g., time series or versions
    let DatasetSeries = _vocab "DatasetSeries"

    /// File system directory
    let Directory = _vocab "Directory"

    /// Specific representation of a dataset
    let Distribution = _vocab "Distribution"


    let Domain = _vocab "Domain"

    /// File and document storage service
    let DriveService = _vocab "DriveService"

    /// Base class for all OpenMetadata entities
    let Entity = _vocab "Entity"

    /// Current status of an entity (Active, Deleted, Draft)
    let EntityStatus = _vocab "EntityStatus"

    /// Individual file
    let File = _vocab "File"

    /// Update frequency specification
    let Frequency = _vocab "Frequency"


    let Glossary = _vocab "Glossary"


    let GlossaryTerm = _vocab "GlossaryTerm"

    /// Input port of a data product for consuming data
    let InputPort = _vocab "InputPort"

    /// Registered Large Language Model deployment, fine-tune, or base model referenced by AI applications and agents
    let LLMModel = _vocab "LLMModel"

    /// Service managing Large Language Model providers (OpenAI, Anthropic, Bedrock, VertexAI, Ollama, etc.)
    let LLMService = _vocab "LLMService"

    /// Learning resource such as an in-product tutorial, Storylane walkthrough, video or article contextualized for product surfaces
    let LearningResource = _vocab "LearningResource"

    /// Legal document giving permissions
    let LicenseDocument = _vocab "LicenseDocument"

    /// Life cycle properties of an entity including created, updated, accessed timestamps
    let LifeCycle = _vocab "LifeCycle"

    /// Spatial region or location
    let Location = _vocab "Location"

    /// Single execution session of an MCP server, tracking tool calls, resource accesses, prompt uses and data lineage for audit and compliance
    let MCPExecution = _vocab "MCPExecution"

    /// Model Context Protocol server deployment that exposes tools, resources and prompts to AI applications
    let MCPServer = _vocab "MCPServer"

    /// Service for discovering and managing MCP (Model Context Protocol) servers
    let MCPService = _vocab "MCPService"

    /// Machine learning model providing inference service
    let MLModel = _vocab "MLModel"


    let MLModelService = _vocab "MLModelService"

    /// Media type or format
    let MediaType = _vocab "MediaType"


    let MessagingService = _vocab "MessagingService"


    let MetadataService = _vocab "MetadataService"


    let Metric = _vocab "Metric"


    let ObservabilityService = _vocab "ObservabilityService"

    /// Organization entity
    let Organization = _vocab "Organization"

    /// Output port of a data product for exposing data
    let OutputPort = _vocab "OutputPort"

    /// Time period specification
    let PeriodOfTime = _vocab "PeriodOfTime"


    let Pipeline = _vocab "Pipeline"

    /// ETL Service
    let PipelineService = _vocab "PipelineService"

    /// Status of a pipeline execution
    let PipelineStatus = _vocab "PipelineStatus"


    let Policy = _vocab "Policy"


    let Post = _vocab "Post"

    /// Configuration for table profiling
    let ProfilerConfig = _vocab "ProfilerConfig"

    /// Reusable prompt template with variables, system prompts and examples for consistent AI behavior
    let PromptTemplate = _vocab "PromptTemplate"

    /// Relationship with additional context like role, time, etc.
    let QualifiedRelationship = _vocab "QualifiedRelationship"


    let QualityService = _vocab "QualityService"


    let Query = _vocab "Query"

    /// Report as a specific representation of data
    let Report = _vocab "Report"


    let ReportingService = _vocab "ReportingService"

    /// Any resource cataloged in OpenMetadata
    let Resource = _vocab "Resource"

    /// Statement about intellectual property rights
    let RightsStatement = _vocab "RightsStatement"


    let Role = _vocab "Role"


    let SearchIndex = _vocab "SearchIndex"


    let SearchService = _vocab "SearchService"

    /// Base class for all services
    let Service = _vocab "Service"

    /// Spreadsheet document
    let Spreadsheet = _vocab "Spreadsheet"

    /// Technical standard or specification
    let Standard = _vocab "Standard"


    let StorageService = _vocab "StorageService"


    let StoredProcedure = _vocab "StoredProcedure"


    let Table = _vocab "Table"

    /// Table column context type used to attach custom properties to columns of a Table
    let TableColumn = _vocab "TableColumn"

    /// Profile data for a table including statistics
    let TableProfile = _vocab "TableProfile"


    let Tag = _vocab "Tag"


    let Task = _vocab "Task"


    let Team = _vocab "Team"


    let TestCase = _vocab "TestCase"

    /// Parameter definition for a test case
    let TestCaseParameter = _vocab "TestCaseParameter"


    let TestDefinition = _vocab "TestDefinition"


    let TestSuite = _vocab "TestSuite"


    let Thread = _vocab "Thread"

    /// Message topic providing streaming data access
    let Topic = _vocab "Topic"


    let User = _vocab "User"

    /// Votes on an entity (upvotes and downvotes)
    let Votes = _vocab "Votes"

    /// Worksheet within a spreadsheet
    let Worksheet = _vocab "Worksheet"

    /// Information about access restrictions
    let accessRights = _vocab "accessRights"

    /// URL to access the distribution
    let accessURL = _vocab "accessURL"

    /// Frequency of dataset updates
    let accrualPeriodicity = _vocab "accrualPeriodicity"

    /// Degree of data accuracy
    let accuracy = _vocab "accuracy"


    let addressedTo = _vocab "addressedTo"

    /// Link to API documentation
    let apiDocumentation = _vocab "apiDocumentation"

    /// Type of AI application (Chatbot, Agent, Copilot, Assistant, RAG, CodeGenerator, DataAnalyst, AutomationBot, MultiAgent, Custom)
    let applicationType = _vocab "applicationType"

    /// Tag or classification applied to entity
    let appliedTo = _vocab "appliedTo"

    /// Base model this model was trained or fine-tuned from
    let baseModel = _vocab "baseModel"

    /// Geographic bounding box
    let bbox = _vocab "bbox"


    let belongsToDatabase = _vocab "belongsToDatabase"


    let belongsToSchema = _vocab "belongsToSchema"


    let belongsToService = _vocab "belongsToService"

    /// Size in bytes
    let byteSize = _vocab "byteSize"

    /// Sub-catalog
    let catalog = _vocab "catalog"

    /// Date when entity was added to catalog
    let cataloged = _vocab "cataloged"

    /// Geographic center point
    let centroid = _vocab "centroid"

    /// Tag label for the certification
    let certificationTagLabel = _vocab "certificationTagLabel"

    /// Checksum for data integrity verification
    let checksum = _vocab "checksum"

    /// Number of columns in the table
    let columnCount = _vocab "columnCount"

    /// Data type of the column
    let columnDataType = _vocab "columnDataType"

    /// Description of what the column contains
    let columnDescription = _vocab "columnDescription"

    /// Degree of data completeness
    let completeness = _vocab "completeness"

    /// Compression format of the distribution
    let compressFormat = _vocab "compressFormat"

    /// Concurrency level of the pipeline
    let concurrency = _vocab "concurrency"

    /// Standard or schema that the resource conforms to
    let conformsTo = _vocab "conformsTo"

    /// Standard the dataset conforms to
    let conformsToStandard = _vocab "conformsToStandard"

    /// Degree of data consistency
    let consistency = _vocab "consistency"

    /// Data products that this product consumes data from
    let consumesFrom = _vocab "consumesFrom"

    /// Contact information for the dataset
    let contactPoint = _vocab "contactPoint"

    /// Hierarchical containment relationship
    let contains = _vocab "contains"


    let containsPosts = _vocab "containsPosts"

    /// Entity responsible for contributions to the dataset
    let contributor = _vocab "contributor"


    let created = _vocab "created"


    let createdBy = _vocab "createdBy"


    let creates = _vocab "creates"

    /// Entity primarily responsible for creating the dataset
    let creator = _vocab "creator"

    /// Type of data model (TableauDataModel, SupersetDataModel, MetabaseDataModel, LookMlView, LookMlExplore, PowerBIDataModel, QlikDataModel)
    let dataModelType = _vocab "dataModelType"

    /// Assets that are part of this data product
    let dataProductAssets = _vocab "dataProductAssets"

    /// Domain this data product belongs to
    let dataProductDomain = _vocab "dataProductDomain"

    /// Expert for this data product
    let dataProductExpert = _vocab "dataProductExpert"

    /// Owner of the data product
    let dataProductOwner = _vocab "dataProductOwner"

    /// Data quality dimension (Completeness, Accuracy, Consistency, Validity, Uniqueness, Integrity, SQL)
    let dataQualityDimension = _vocab "dataQualityDimension"

    /// Dataset that is part of the catalog
    let dataset = _vocab "dataset"

    /// Default value relationship
    let defaultsTo = _vocab "defaultsTo"

    /// Whether the entity has been soft deleted
    let deleted = _vocab "deleted"


    let description = _vocab "description"


    let developmentStage = _vocab "developmentStage"

    /// Dimension represented in the dataset
    let dimension = _vocab "dimension"

    /// Available distribution of the dataset
    let distribution = _vocab "distribution"

    /// Number of down votes
    let downVotes = _vocab "downVotes"

    /// Direct download URL
    let downloadURL = _vocab "downloadURL"

    /// Data lineage downstream relationship
    let downstream = _vocab "downstream"


    let editedBy = _vocab "editedBy"

    /// End of the temporal period
    let endDate = _vocab "endDate"


    let endpointDescription = _vocab "endpointDescription"


    let endpointURL = _vocab "endpointURL"

    /// Agent execution was an execution of this AI application
    let executedAgent = _vocab "executedAgent"

    /// MCP execution was an execution of this MCP server
    let executedMCPServer = _vocab "executedMCPServer"

    /// Status of an agent or MCP execution (Running, Success, Failed, Timeout, Cancelled, PartialSuccess)
    let executionStatus = _vocab "executionStatus"

    /// User is expert on entity
    let expert = _vocab "expert"

    /// First dataset in a series
    let first = _vocab "first"


    let follows = _vocab "follows"

    /// File format of the distribution
    let format = _vocab "format"

    /// Source column used in transformation
    let fromColumn = _vocab "fromColumn"

    /// Unique identifier for the entity within OpenMetadata
    let fullyQualifiedName = _vocab "fullyQualifiedName"

    /// Geometry of the spatial area
    let geometry = _vocab "geometry"

    /// AI application, LLM model or MCP server is governed by an AI governance policy
    let governedBy = _vocab "governedBy"

    /// Role in a qualified relationship
    let hadRole = _vocab "hadRole"

    /// General possession relationship
    let has = _vocab "has"

    /// Beginning instant of the temporal period
    let hasBeginning = _vocab "hasBeginning"

    /// Certification status of the asset
    let hasCertification = _vocab "hasCertification"

    /// Change that led to this version of the entity
    let hasChangeDescription = _vocab "hasChangeDescription"


    let hasColumn = _vocab "hasColumn"

    /// Data products this entity is part of
    let hasDataProducts = _vocab "hasDataProducts"

    /// Domains the entity belongs to
    let hasDomains = _vocab "hasDomains"

    /// Ending instant of the temporal period
    let hasEnd = _vocab "hasEnd"

    /// Current status of the entity
    let hasEntityStatus = _vocab "hasEntityStatus"

    /// Users who follow this entity
    let hasFollowers = _vocab "hasFollowers"

    /// Incremental change that led to this version
    let hasIncrementalChangeDescription = _vocab "hasIncrementalChangeDescription"

    /// Input port of the data product
    let hasInputPort = _vocab "hasInputPort"

    /// Life cycle properties of the entity
    let hasLifeCycle = _vocab "hasLifeCycle"

    /// Output port of the data product
    let hasOutputPort = _vocab "hasOutputPort"

    /// Agent responsible for the entity
    let hasOwner = _vocab "hasOwner"

    /// Owners of this entity (plural)
    let hasOwners = _vocab "hasOwners"

    /// Parameter definitions for a test
    let hasParameterDefinition = _vocab "hasParameterDefinition"

    /// Latest status of the pipeline
    let hasPipelineStatus = _vocab "hasPipelineStatus"

    /// ODRL policy associated with the dataset
    let hasPolicy = _vocab "hasPolicy"

    /// Latest profile data for the table
    let hasProfile = _vocab "hasProfile"

    /// Profiler configuration for the table
    let hasProfilerConfig = _vocab "hasProfilerConfig"

    /// Quality annotation for the dataset
    let hasQualityAnnotation = _vocab "hasQualityAnnotation"

    /// Quality measurement for the dataset
    let hasQualityMeasurement = _vocab "hasQualityMeasurement"

    /// Service Level Agreement for the data product
    let hasSLA = _vocab "hasSLA"


    let hasTag = _vocab "hasTag"


    let hasVersion = _vocab "hasVersion"

    /// Votes on the entity
    let hasVotes = _vocab "hasVotes"

    /// Homepage of the catalog
    let homepage = _vocab "homepage"

    /// Unique identifier of the dataset
    let identifier = _vocab "identifier"

    /// Bot user that performed the action on behalf of the actual user
    let impersonatedBy = _vocab "impersonatedBy"

    /// Links a dataset to its series
    let inSeries = _vocab "inSeries"

    /// Thread or post is about an entity
    let isAbout = _vocab "isAbout"

    /// Whether this column can contain null values
    let isNullable = _vocab "isNullable"

    /// Whether this column is a primary key
    let isPrimaryKey = _vocab "isPrimaryKey"

    /// Related resource that references this dataset
    let isReferencedBy = _vocab "isReferencedBy"

    /// Links to the non-versioned or abstract dataset
    let isVersionOf = _vocab "isVersionOf"

    /// Date of formal issuance
    let issued = _vocab "issued"

    /// Join relationship between tables
    let joinedWith = _vocab "joinedWith"

    /// Keywords describing the dataset
    let keyword = _vocab "keyword"

    /// Web page providing access and information
    let landingPage = _vocab "landingPage"

    /// Language of the dataset
    let language = _vocab "language"

    /// Last dataset in a series
    let last = _vocab "last"

    /// License under which the dataset is available
    let license = _vocab "license"

    /// Access details when entity was last accessed
    let lifeCycleAccessed = _vocab "lifeCycleAccessed"

    /// Access details when entity was created
    let lifeCycleCreated = _vocab "lifeCycleCreated"

    /// Access details when entity was last updated
    let lifeCycleUpdated = _vocab "lifeCycleUpdated"

    /// Current lifecycle stage (IDEATION, DESIGN, DEVELOPMENT, TESTING, PRODUCTION, DEPRECATED, RETIRED)
    let lifecycleStage = _vocab "lifecycleStage"

    /// When the lineage was created
    let lineageCreatedAt = _vocab "lineageCreatedAt"

    /// User who created the lineage
    let lineageCreatedBy = _vocab "lineageCreatedBy"

    /// How the lineage was created (Manual, Pipeline, Query, etc.)
    let lineageSource = _vocab "lineageSource"

    /// Measure represented in the dataset
    let measure = _vocab "measure"

    /// Media type of the distribution
    let mediaType = _vocab "mediaType"


    let memberOf = _vocab "memberOf"

    /// Entity is mentioned in a post or thread
    let mentionedIn = _vocab "mentionedIn"

    /// Capability exposed by the LLM model (TextGeneration, CodeGeneration, Embeddings, Chat, Vision, Audio, FunctionCalling, ToolUse)
    let modelCapability = _vocab "modelCapability"

    /// Type of LLM model (BaseModel, FineTuned, Quantized, Distilled, Adapter, Custom)
    let modelType = _vocab "modelType"


    let modified = _vocab "modified"

    /// Next dataset in a series
    let next = _vocab "next"

    /// Number of columns in the dataset
    let numberOfColumns = _vocab "numberOfColumns"

    /// Number of records in the dataset
    let numberOfRecords = _vocab "numberOfRecords"


    let owns = _vocab "owns"

    /// Package format of the distribution
    let packageFormat = _vocab "packageFormat"

    /// Hierarchical parent relationship
    let parentOf = _vocab "parentOf"

    /// Pipeline that processes the data
    let pipeline = _vocab "pipeline"

    /// Pipeline code location
    let pipelineLocation = _vocab "pipelineLocation"

    /// Type of AI governance policy (ModelApproval, DataAccess, BiasThreshold, ComplianceCheck, CostControl, PerformanceStandard, SecurityControl)
    let policyType = _vocab "policyType"

    /// Data asset exposed through this port
    let portDataAsset = _vocab "portDataAsset"

    /// Endpoint URL or connection string for the port
    let portEndpoint = _vocab "portEndpoint"

    /// Data format supported by the port (JSON, CSV, PARQUET, etc.)
    let portFormat = _vocab "portFormat"

    /// Name of the port
    let portName = _vocab "portName"

    /// Protocol used by the port (REST, GRPC, KAFKA, etc.)
    let portProtocol = _vocab "portProtocol"

    /// Previous dataset in a series
    let prev = _vocab "prev"

    /// Link to previous version
    let previousVersion = _vocab "previousVersion"

    /// Main entity described by this record
    let primaryTopic = _vocab "primaryTopic"

    /// Whether lineage has been processed for this entity
    let processedLineage = _vocab "processedLineage"

    /// Provenance statement
    let provenance = _vocab "provenance"

    /// Data products that consume data from this product
    let providesTo = _vocab "providesTo"

    /// Entity responsible for making the dataset available
    let publisher = _vocab "publisher"

    /// Qualified access information including authentication and authorization
    let qualifiedAccess = _vocab "qualifiedAccess"

    /// Detailed attribution with roles
    let qualifiedAttribution = _vocab "qualifiedAttribution"

    /// Detailed derivation with transformation info
    let qualifiedDerivation = _vocab "qualifiedDerivation"

    /// Link to a qualified relationship
    let qualifiedRelation = _vocab "qualifiedRelation"


    let reactedTo = _vocab "reactedTo"

    /// Links catalog to its records
    let record = _vocab "record"

    /// General relationship between entities
    let relatedTo = _vocab "relatedTo"

    /// Alternative spelling of relatedTo
    let relatesTo = _vocab "relatesTo"

    /// Related resource
    let relation = _vocab "relation"


    let repliedTo = _vocab "repliedTo"

    /// Primary topic grouping (Discovery, Administration, DataGovernance, DataQuality, Observability, AI)
    let resourceCategory = _vocab "resourceCategory"

    /// Suggested proficiency tier (Intro, Intermediate, Advanced)
    let resourceDifficulty = _vocab "resourceDifficulty"

    /// Kind of learning asset (Storylane, Video, Article)
    let resourceType = _vocab "resourceType"

    /// Retention period of the data in ISO 8601 duration format
    let retentionPeriod = _vocab "retentionPeriod"


    let reviews = _vocab "reviews"

    /// Rights statement for the dataset
    let rights = _vocab "rights"

    /// Number of rows in the table
    let rowCount = _vocab "rowCount"

    /// Sample data from the table
    let sampleData = _vocab "sampleData"

    /// Scheduler interval in cron format
    let scheduleInterval = _vocab "scheduleInterval"

    /// DDL schema definition for the table
    let schemaDefinition = _vocab "schemaDefinition"

    /// Type of MCP server (DataAccess, FileSystem, WebAPI, Database, Cloud, Security, Development, Communication, Custom)
    let serverType = _vocab "serverType"

    /// Links a data service to datasets it serves
    let servesDataset = _vocab "servesDataset"

    /// Service that is part of the catalog
    let service = _vocab "service"

    /// Endpoint for accessing the service
    let serviceEndpoint = _vocab "serviceEndpoint"

    /// Service level agreement details
    let serviceLevel = _vocab "serviceLevel"

    /// Operational status of the service
    let serviceStatus = _vocab "serviceStatus"


    let serviceType = _vocab "serviceType"

    /// Expected availability percentage
    let slaAvailability = _vocab "slaAvailability"

    /// Maximum data staleness in minutes
    let slaDataFreshness = _vocab "slaDataFreshness"

    /// Minimum data quality score
    let slaDataQuality = _vocab "slaDataQuality"

    /// Expected response time in milliseconds
    let slaResponseTime = _vocab "slaResponseTime"

    /// SLA tier level (GOLD, SILVER, BRONZE)
    let slaTier = _vocab "slaTier"

    /// Source of the dataset
    let source = _vocab "source"

    /// Source hash of the entity for change detection
    let sourceHash = _vocab "sourceHash"

    /// URL to visit/manage the entity in the source system
    let sourceUrl = _vocab "sourceUrl"

    /// Spatial area covered by the dataset
    let spatial = _vocab "spatial"

    /// Minimum spatial separation resolvable in the dataset
    let spatialResolution = _vocab "spatialResolution"

    /// SQL query used in transformation
    let sqlQuery = _vocab "sqlQuery"

    /// Start of the temporal period
    let startDate = _vocab "startDate"

    /// Unit of observation in the dataset
    let statisticalUnit = _vocab "statisticalUnit"

    /// Data types supported by this test definition
    let supportedDataTypes = _vocab "supportedDataTypes"

    /// Whether the test case supports dynamic assertions
    let supportsDynamicAssertion = _vocab "supportsDynamicAssertion"

    /// Whether the test case supports row level passed/failed
    let supportsRowLevelPassedFailed = _vocab "supportsRowLevelPassedFailed"

    /// Type of table (Regular, External, View, MaterializedView, etc.)
    let tableType = _vocab "tableType"


    let templateVariable = _vocab "templateVariable"

    /// Temporal period covered by the dataset
    let temporal = _vocab "temporal"

    /// Minimum time period resolvable in the dataset
    let temporalResolution = _vocab "temporalResolution"

    /// Platform where tests are defined (OpenMetadata, GreatExpectations, dbt, Deequ, Soda, Other)
    let testPlatform = _vocab "testPlatform"


    let testedBy = _vocab "testedBy"

    /// Main category of the dataset
    let theme = _vocab "theme"

    /// Knowledge organization system for categorizing datasets
    let themeTaxonomy = _vocab "themeTaxonomy"

    /// How current the data is
    let timeliness = _vocab "timeliness"

    /// Title of the dataset
    let title = _vocab "title"

    /// Target column created by transformation
    let toColumn = _vocab "toColumn"

    /// Function applied to transform data
    let transformationFunction = _vocab "transformationFunction"

    /// Transport protocol used by the MCP server
    let transportType = _vocab "transportType"

    /// Nature or genre of the dataset
    let ``type`` = _vocab "type"

    /// Degree of uniqueness in the data
    let uniqueness = _vocab "uniqueness"

    /// Number of up votes
    let upVotes = _vocab "upVotes"

    /// Last update time in Unix epoch milliseconds
    let updatedAt = _vocab "updatedAt"

    /// User who made the update
    let updatedBy = _vocab "updatedBy"

    /// Data lineage upstream relationship
    let upstream = _vocab "upstream"

    /// Latest usage information for the entity
    let usageSummary = _vocab "usageSummary"


    let uses = _vocab "uses"

    /// AI application uses an MCP server for tools, resources or prompts
    let usesMCPServer = _vocab "usesMCPServer"

    /// AI application or agent execution uses an LLM model
    let usesModel = _vocab "usesModel"


    let usesPromptTemplate = _vocab "usesPromptTemplate"

    /// Degree to which data conforms to defined rules
    let validity = _vocab "validity"

    /// Version identifier
    let version = _vocab "version"

    /// Notes about this version
    let versionNotes = _vocab "versionNotes"


    let voted = _vocab "voted"

    /// Source dataset this was derived from
    let wasDerivedFrom = _vocab "wasDerivedFrom"

    /// Activity that generated the dataset
    let wasGeneratedBy = _vocab "wasGeneratedBy"







































module Quad =
    let from_terms (subject_term: RDF_Term) (predicate_term: RDF_Term) (object_term: RDF_Term) (graph_term: RDF_Term) =
        let triple = Triple.from_terms subject_term predicate_term object_term

        let curGraph = snd (Graph_Name.from_term graph_term)

        { subject = triple.subject
          predicate = triple.predicate
          object = triple.object
          graph_name = curGraph }

    let nq (quad: Quad) (transaction: LightningTransaction) =
        let subject = RDF_Subject.nq quad.subject transaction
        let predicate = RDF_Predicate.nq quad.predicate transaction
        let object = RDF_Object.nq quad.object transaction
        let graph_name = Graph_Name.nq quad.graph_name transaction

        match graph_name with
        | _ when String.IsNullOrWhiteSpace graph_name -> $"{subject} {predicate} {object} ."
        | _ -> $"{subject} {predicate} {object} {graph_name} ."


    let to_Triple (quad: Quad) =
        { subject = quad.subject
          predicate = quad.predicate
          object = quad.object }



module Ordered_Keyspace =

    let starts_with (prefix: byte array) (bytes: byte array) =
        bytes.Length >= prefix.Length
        && prefix
           |> Array.mapi (fun index byte -> bytes[index] = byte)
           |> Array.forall id

    let entries_with_prefix (memory_map: Lightning_Memory_Map) (prefix: byte array) (transaction: LightningTransaction) =

        use cursor = transaction.CreateCursor(memory_map.handle)

        let rec collect entries =
            let struct (result_code, key, value) = cursor.GetCurrent()

            match result_code with
            | MDBResultCode.Success ->
                let key_bytes = key.to_byte_array

                if prefix.Length = 0 || starts_with prefix key_bytes then
                    let value_bytes = value.to_byte_array

                    match cursor.Next() with
                    | struct (MDBResultCode.Success, _, _) -> collect ((key_bytes, value_bytes) :: entries)

                    | struct (MDBResultCode.NotFound, _, _) -> (key_bytes, value_bytes) :: entries

                    | struct (result_code, _, _) -> failwith $"Cursor Next failed: {result_code}"
                else
                    entries

            | result_code -> failwith $"Cursor GetCurrent failed: {result_code}"

        let start_result =
            if prefix.Length = 0 then
                let struct (MDBResultCode, _, _) = cursor.First()
                MDBResultCode
            else
                cursor.SetRange(prefix)

        match start_result with
        | MDBResultCode.Success -> collect [] |> List.rev |> List.toArray

        | MDBResultCode.NotFound -> [||]

        | result_code -> failwith $"Cursor start failed: {result_code}"

module Graph_Presence =

    let is_asserted (triple_id: Triple_ID) (graph_name_id: Term_ID) (transaction: LightningTransaction) =

        match transaction.Get(Lightning_Memory_Map.TG'Presence.handle, Quad_Key.tg triple_id graph_name_id) with
        | struct (MDBResultCode.Success, _, value) -> value.to_byte_array |> Presence.is_asserted

        | struct (MDBResultCode.NotFound, _, _) -> false

        | struct (result_code, _, _) -> failwith $"Get TG'Presence failed with MDBResultCode: {result_code}"

    let asserted_triple_ids_in_graph (graph_name_id: Term_ID) (transaction: LightningTransaction) =

        Ordered_Keyspace.entries_with_prefix Lightning_Memory_Map.GT'Presence (Term_ID.to_byte_array graph_name_id) transaction
        |> Array.choose (fun (key, value) ->
            if Presence.is_asserted value then
                let _graph_name_id, triple_id = Quad_Key.from_gt_key key

                Some triple_id
            else
                None)

    let asserted_graph_ids_for_triple (triple_id: Triple_ID) (transaction: LightningTransaction) =

        Ordered_Keyspace.entries_with_prefix Lightning_Memory_Map.TG'Presence (Triple_ID.to_byte_array triple_id) transaction
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

    let from_graph_bound_triple_candidates (graph_name_id: Term_ID) (triple_ids: Triple_ID array) (transaction: LightningTransaction) =

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

            transaction.Put(Lightning_Memory_Map.Triple_ID'Triple.handle, Triple_ID.to_byte_array triple_id, Message_Pack.serialize triple)
            |> MDBResultCode.fail_if_not_success "Put Triple ID -> Triple"

            transaction.Put(Lightning_Memory_Map.Triple'Triple_ID.handle, Message_Pack.serialize triple, Triple_ID.to_byte_array triple_id)
            |> MDBResultCode.fail_if_not_success "Put Triple -> Triple ID"

            for permutation in Triple_Permutation.profile do
                transaction.Put(permutation.memory_map.handle, Permutation_Key.from_triple permutation triple, [||])
                |> MDBResultCode.fail_if_not_success $"Put triple permutation {permutation.memory_map.name}"

            transaction.Put(Triple_Permutation.spo.memory_map.handle, Permutation_Key.from_triple Triple_Permutation.spo triple, [||])
            |> MDBResultCode.fail_if_not_success "Put triple permutation SPO"

            triple_id

        | struct (result_code, _, _) -> failwith $"Get Triple ID -> Triple failed with MDBResultCode: {result_code}"


    let Triple_in_Graph (triple: Triple) (triple_id: Triple_ID) (graph_name_id: Term_ID) (transaction: LightningTransaction) =

        let quad_id =
            { triple_id = triple_id
              graph_name_id = graph_name_id }

        transaction.Put(Lightning_Memory_Map.TG'Presence.handle, Quad_Key.tg triple_id graph_name_id, Presence.asserted)
        |> MDBResultCode.fail_if_not_success "Put TG'Presence"

        transaction.Put(Lightning_Memory_Map.GT'Presence.handle, Quad_Key.gt graph_name_id triple_id, Presence.asserted)
        |> MDBResultCode.fail_if_not_success "Put GT'Presence"

        transaction.Put(Lightning_Memory_Map.GVertex'OutEdges.handle, graph_vertex_key graph_name_id (RDF_Subject.term_id triple.subject), Quad_ID.to_byte_array quad_id)
        |> MDBResultCode.fail_if_not_success "Put GVertex'OutEdges"

        transaction.Put(Lightning_Memory_Map.GVertex'InEdges.handle, graph_vertex_key graph_name_id (RDF_Object.term_id triple.object), Quad_ID.to_byte_array quad_id)
        |> MDBResultCode.fail_if_not_success "Put GVertex'InEdges"

    let Triple_in_Graphs (triple: Triple) (triple_id: Triple_ID) (graph_name_ids: Term_ID array) (transaction: LightningTransaction) =
        graph_name_ids
        |> Array.iter (fun graph_name_id -> Triple_in_Graph triple triple_id graph_name_id transaction)

    let spog (subject_term: RDF_Term) (predicate_term: RDF_Term) (object_term: RDF_Term) (graph_term: RDF_Term) (transaction: LightningTransaction) =

        let triple = Triple.from_terms subject_term predicate_term object_term

        let triple_id = ensure_triple triple transaction
        let graph_name_id, graph_name = Graph_Name.from_term graph_term

        Triple_in_Graph triple triple_id graph_name_id transaction

    let spod (subject_term: RDF_Term) (predicate_term: RDF_Term) (object_term: RDF_Term) (transaction: LightningTransaction) =

        spog subject_term predicate_term object_term Graph_Name.default_graph_term transaction

    let Quad (quad: Quad) (transaction: LightningTransaction) =
        let subject_term = RDF_Subject.term quad.subject
        let predicate_term = RDF_Predicate.term quad.predicate
        let object_term = RDF_Object.term quad.object
        let graph_term = lmdb_read_only { return! Graph_Name.term quad.graph_name }
        spog subject_term predicate_term object_term graph_term transaction

module Retract =

    let Triple_in_Graph (triple: Triple) (triple_id: Triple_ID) (graph_name_id: Term_ID) (transaction: LightningTransaction) =

        let quad_id =
            { triple_id = triple_id
              graph_name_id = graph_name_id }

        transaction.Put(Lightning_Memory_Map.TG'Presence.handle, Quad_Key.tg triple_id graph_name_id, Presence.retracted)
        |> MDBResultCode.fail_if_not_success "Put TG'Presence retracted"

        transaction.Put(Lightning_Memory_Map.GT'Presence.handle, Quad_Key.gt graph_name_id triple_id, Presence.retracted)
        |> MDBResultCode.fail_if_not_success "Put GT'Presence retracted"

        transaction.Delete(Lightning_Memory_Map.GVertex'OutEdges.handle, graph_vertex_key graph_name_id (RDF_Subject.term_id triple.subject), Quad_ID.to_byte_array quad_id)
        |> MDBResultCode.fail_if_not_success "Delete GVertex'OutEdges"

        transaction.Delete(Lightning_Memory_Map.GVertex'InEdges.handle, graph_vertex_key graph_name_id (RDF_Object.term_id triple.object), Quad_ID.to_byte_array quad_id)
        |> MDBResultCode.fail_if_not_success "Delete GVertex'InEdges"

    let spog (subject_term: RDF_Term) (predicate_term: RDF_Term) (object_term: RDF_Term) (graph_term: RDF_Term) (transaction: LightningTransaction) =

        let triple = Triple.from_terms subject_term predicate_term object_term

        let triple_id = Triple.id_for_triple triple

        let graph_name_id, graph_name = Graph_Name.from_term graph_term

        Triple_in_Graph triple triple_id graph_name_id transaction


    let spod (subject_term: RDF_Term) (predicate_term: RDF_Term) (object_term: RDF_Term) (transaction: LightningTransaction) =

        spog subject_term predicate_term object_term Graph_Name.default_graph_term transaction

    let Quad (quad: Quad) (transaction: LightningTransaction) =
        let subject_term = RDF_Subject.term quad.subject
        let predicate_term = RDF_Predicate.term quad.predicate
        let object_term = RDF_Object.term quad.object
        let graph_term = lmdb_read_only { return! Graph_Name.term quad.graph_name }
        spog subject_term predicate_term object_term graph_term transaction


module Revise =

    let spog (old_subject_term: RDF_Term) (old_predicate_term: RDF_Term) (old_object_term: RDF_Term) (old_graph_term: RDF_Term) (new_subject_term: RDF_Term) (new_predicate_term: RDF_Term) (new_object_term: RDF_Term) (new_graph_term: RDF_Term) (transaction: LightningTransaction) =

        Retract.spog old_subject_term old_predicate_term old_object_term old_graph_term transaction
        |> ignore

        Assert.spog new_subject_term new_predicate_term new_object_term new_graph_term transaction

    let spod (old_subject_term: RDF_Term) (old_predicate_term: RDF_Term) (old_object_term: RDF_Term) (new_subject_term: RDF_Term) (new_predicate_term: RDF_Term) (new_object_term: RDF_Term) (transaction: LightningTransaction) =

        spog old_subject_term old_predicate_term old_object_term Graph_Name.default_graph_term new_subject_term new_predicate_term new_object_term Graph_Name.default_graph_term transaction

    let Triple_in_Graph (old_triple: Triple) (new_triple: Triple) (graph_term: RDF_Term) (transaction: LightningTransaction) =
        let old_id = Triple.id_for_triple old_triple
        let new_id = Triple.id_for_triple new_triple
        let graph_name_id, graph_name = Graph_Name.from_term graph_term


        Retract.Triple_in_Graph old_triple old_id graph_name_id transaction
        Assert.Triple_in_Graph new_triple new_id graph_name_id transaction





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

    let distinct_children (permutation: Triple_Permutation) (prefix: byte array) (depth: int) (transaction: LightningTransaction) =

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

    let from_variables (subject_variable: RDF_Variable) (predicate_variable: RDF_Variable) (object_variable: RDF_Variable) (graph_variable: RDF_Variable) =
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
        |> Array.choose (fun permutation -> Variable_Candidate_View.try_from_pattern target_variable_id pattern permutation)
        |> Array.tryHead
        |> Option.map (fun view -> Logical_Trie.distinct_children view.permutation view.prefix view.depth transaction)

    let intersect_many (candidate_sets: Term_ID array array) =
        match candidate_sets with
        | [||] -> [||]

        | _ ->
            candidate_sets
            |> Array.reduce Term_ID_Array.intersect_sorted

    let from_patterns (target_variable_id: Variable_ID) (patterns: Graph_Pattern array) (transaction: LightningTransaction) =

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

    let expand_on_variable (target_variable_id: Variable_ID) (branch: Query_Branch) (transaction: LightningTransaction) =

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

    let private quad_ids_for_graph_bound_pattern (graph_name_id: Term_ID) (triples: Triple array) (transaction: LightningTransaction) =
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

    let private has_triple_constraint (pattern: Graph_Pattern) =
        [| pattern.subject_variable
           pattern.predicate_variable
           pattern.object_variable |]
        |> Array.exists (fun variable -> RDF_Variable.term_id variable |> Option.isSome)

    let quad_ids_by_pattern (pattern: Graph_Pattern) (transaction: LightningTransaction) =

        match RDF_Variable.term_id pattern.graph_variable with
        | Some graph_name_id when not (has_triple_constraint pattern) ->
            Graph_Presence.asserted_triple_ids_in_graph graph_name_id transaction
            |> Array.map (fun triple_id ->
                { triple_id = triple_id
                  graph_name_id = graph_name_id })

        | Some graph_name_id ->
            let plan = Triple_Candidate_Plan.from_graph_pattern pattern
            let structural_triples = Structural_Triple_Query.triples_by_plan plan transaction
            quad_ids_for_graph_bound_pattern graph_name_id structural_triples transaction

        | None ->
            let plan = Triple_Candidate_Plan.from_graph_pattern pattern
            let structural_triples = Structural_Triple_Query.triples_by_plan plan transaction
            quad_ids_for_graph_free_pattern structural_triples transaction

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

    let quad_ids_by_graph_vertex (memory_map: Lightning_Memory_Map) (graph_name_id: Term_ID) (vertex_id: Term_ID) (transaction: LightningTransaction) =

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

    let private incident_edge_from_quad_id (incident_vertex_id: Term_ID option) (quad_id: Quad_ID) (transaction: LightningTransaction) =

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

                Graph_Traversal_Adjacency.quad_ids_by_graph_vertex Lightning_Memory_Map.GVertex'OutEdges traverser.graph.graph_name_id traverser.value.term_id transaction
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

                Graph_Traversal_Adjacency.quad_ids_by_graph_vertex Lightning_Memory_Map.GVertex'InEdges traverser.graph.graph_name_id traverser.value.term_id transaction
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

    let outE_all (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Incident_Edge> =
        fun transaction ->
            traversal transaction
            |> Array.collect (fun traverser ->
                Graph_Traversal_Adjacency.quad_ids_by_graph_vertex Lightning_Memory_Map.GVertex'OutEdges traverser.graph.graph_name_id traverser.value.term_id transaction
                |> Array.map (fun quad_id ->
                    { graph = traverser.graph
                      value = incident_edge_from_quad_id (Some traverser.value.term_id) quad_id transaction }))

    let inE_all (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Incident_Edge> =
        fun transaction ->
            traversal transaction
            |> Array.collect (fun traverser ->
                Graph_Traversal_Adjacency.quad_ids_by_graph_vertex Lightning_Memory_Map.GVertex'InEdges traverser.graph.graph_name_id traverser.value.term_id transaction
                |> Array.map (fun quad_id ->
                    { graph = traverser.graph
                      value = incident_edge_from_quad_id (Some traverser.value.term_id) quad_id transaction }))

    let bothE (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Incident_Edge> =
        fun transaction -> Array.append (outE_all traversal transaction) (inE_all traversal transaction)

    let bothE_label (label: RDF_Term) (traversal: Graph_Traversal<Vertex>) : Graph_Traversal<Incident_Edge> =
        fun transaction -> Array.append (outE label traversal transaction) (inE label traversal transaction)

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

    let region (string_value: string) (lang_tag: Language_Subtag) (region_tag: Region_Subtag) (transaction: LightningTransaction) =

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

    let directed_language (string_value: string) (lang_tag: Language_Subtag) (base_direction: Language_Base_Direction) (transaction: LightningTransaction) =

        let lexical_form = Lexical_Form.from_string string_value transaction

        RDF_Term.from_directed_language_string
            { lexical_form_id = lexical_form.lexical_form_id
              language = lang_tag
              direction = base_direction }
            transaction

    let directed_region (string_value: string) (lang_tag: Language_Subtag) (region_tag: Region_Subtag) (base_direction: Language_Base_Direction) (transaction: LightningTransaction) =

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
            | :? Guid as value -> value.ToString(), xsd.ID
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


let RDF_true = lmdb_read_write { return! RDF_Literal.autotyped true }
let RDF_false = lmdb_read_write { return! RDF_Literal.autotyped false }












































fsi.AddPrinter<Term_ID>(fun term_id -> sprintf "%u" (term_id |> Term_ID.to_uint64))
fsi.AddPrinter<Triple_ID>(fun term_id -> sprintf "%u" (term_id |> Triple_ID.to_uint64))

fsi.AddPrinter<Lexical_Form_ID>(fun lexical_form_id -> sprintf "%u \"%s\"" (lexical_form_id |> Lexical_Form_ID.to_uint64) (lmdb_read_only { return! Get.String_by_Lexical_Form_ID lexical_form_id }))

fsi.AddPrinter<Quad>(fun quad -> lmdb_read_only { return! Quad.nq quad })

fsi.AddPrinter<Incident_Edge> (fun incident ->
    lmdb_read_only {

        let! quad = incident.edge.quad_id |> Quad_ID.to_quad
        return! Quad.nq quad

    }

)












(*



module adhoc =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "https://eristocrates.dev/ontology/adhoc/" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ","_"))

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

*)
