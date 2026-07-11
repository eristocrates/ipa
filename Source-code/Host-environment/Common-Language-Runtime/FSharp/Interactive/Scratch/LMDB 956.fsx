open System
open System.Collections.Generic
open System.Diagnostics

#r "nuget: LightningDB"
open LightningDB

#r "nuget: MessagePack"
#r "nuget: MessagePack.FSharpExtensions"

open MessagePack
open MessagePack.Resolvers
open MessagePack.FSharp

#r "nuget: Blake3"

open Blake3
open System.Text


let message_pack_options =
    MessagePackSerializerOptions.Standard.WithResolver(
        CompositeResolver.Create(FSharpResolver.Instance, StandardResolver.Instance)
    )


let GiB = 1024L * 1024L * 1024L
let bytes_to_gib (bytes: int64) = float bytes / 1024.0 / 1024.0 / 1024.0
let map_size = int64 40 * GiB
let environment_directory_path = @"D:\Persistence\LMDB"

System.IO.Directory.CreateDirectory(environment_directory_path)
|> ignore

let mutable batch_size = 250_000


let environment = new LightningEnvironment(environment_directory_path)
environment.MapSize <- map_size
environment.MaxDatabases <- 30


environment.Open()



let print_environment_stats () =

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


module MDBResultCode =

    let succeeded (result_code: MDBResultCode) = result_code = MDBResultCode.Success

    let failed (result_code: MDBResultCode) = result_code <> MDBResultCode.Success

    let fail_if_not_success (operation_name: string) (result_code: MDBResultCode) =
        if result_code <> MDBResultCode.Success then
            failwith $"{operation_name} failed with MDBResultCode: {result_code}"


type MDBValue with
    member this.to_encoding = this.AsSpan().ToArray()

























type Persistent_Map =
    {

      name: string
      handle: LightningDatabase

     }


module Persistent_Map =
    let private lightning_database (name: string) (flags: DatabaseOpenFlags) =
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

    let Context_to_Context_ID =
        lightning_database "Context_to_Context_ID" DatabaseOpenFlags.Create

    let Context_ID_to_Context =
        lightning_database "Context_ID_to_Context" DatabaseOpenFlags.Create

    let Triple_ID_to_Context_IDs =
        lightning_database
            "Triple_ID_to_Context_IDs"
            (DatabaseOpenFlags.Create
             ||| DatabaseOpenFlags.DuplicatesSort)

    let Context_ID_to_Triple_IDs =
        lightning_database
            "Context_ID_to_Triple_IDs"
            (DatabaseOpenFlags.Create
             ||| DatabaseOpenFlags.DuplicatesSort)

    let Digest_to_Form_ID =
        lightning_database "Digest_to_Form_ID" DatabaseOpenFlags.Create

    let Form_ID_to_Encoding =
        lightning_database "Form_ID_to_Encoding" DatabaseOpenFlags.Create

    let Term_ID_to_Term = lightning_database "Term_ID_to_Term" DatabaseOpenFlags.Create
    let Term_to_Term_ID = lightning_database "Term_to_Term_ID" DatabaseOpenFlags.Create

    let Term_ID_to_Attribute_Values =
        lightning_database
            "Term_ID_to_Attribute_Values"
            (DatabaseOpenFlags.Create
             ||| DatabaseOpenFlags.DuplicatesSort)


    let SPO = lightning_database "SPO" DatabaseOpenFlags.Create
    let SOP = lightning_database "SOP" DatabaseOpenFlags.Create
    let PSO = lightning_database "PSO" DatabaseOpenFlags.Create
    let POS = lightning_database "POS" DatabaseOpenFlags.Create
    let OSP = lightning_database "OSP" DatabaseOpenFlags.Create
    let OPS = lightning_database "OPS" DatabaseOpenFlags.Create




























type String with

    member this.encoding = Encoding.UTF8.GetBytes(this)

    member this.to_digest =
        Blake3
            .Hasher
            .Hash(this.encoding)
            .AsSpan()
            .ToArray()

module String =

    let from_encoding (bytes: byte array) = Encoding.UTF8.GetString(bytes)

type UInt64 with

    member this.to_encoding =
        let bytes = BitConverter.GetBytes(this)


        if BitConverter.IsLittleEndian then
            Array.Reverse(bytes)

        bytes

module UInt64 =
    let from_encoding (bytes: byte array) =

        let copy = Array.copy bytes

        if BitConverter.IsLittleEndian then
            Array.Reverse(copy)

        BitConverter.ToUInt64(copy, 0)




























module ID =
    let initial = 0UL

    let next (memory_map: Persistent_Map) =
        use transaction = environment.BeginTransaction()

        use cursor = transaction.CreateCursor(memory_map.handle)

        match cursor.Last() with
        | struct (MDBResultCode.Success, id_key, _component_value) ->
            let id =
                UInt64.from_encoding (id_key.AsSpan().ToArray())
                + 1UL

            id.to_encoding

        | _ -> initial.to_encoding

    let next_mid_transaction (memory_map: Persistent_Map) (transaction: LightningTransaction) =
        use cursor = transaction.CreateCursor(memory_map.handle)

        match cursor.Last() with
        | struct (MDBResultCode.Success, id_key, _component_value) ->
            let id =
                UInt64.from_encoding (id_key.AsSpan().ToArray())
                + 1UL

            id.to_encoding

        | _ -> initial.to_encoding

type Form_ID = private FormID of byte array

type Form_ID with
    static member from_encoding(bytes: byte array) = FormID bytes

    member this.to_encoding =
        let (FormID bytes) = this
        bytes


type Lexical_Form =
    {

      string_value: string
      form_id: Form_ID

     }




[<MessagePackObject>]
type RDF_Term_Data =
    | ResolvedIRI of form_id: byte array
    | RelativeIRI of form_id: byte array
    | SkolemIRI of form_id: byte array
    | QuestionVariable of form_id: byte array
    | DollarVariable of form_id: byte array
    | SimpleLiteral of form_id: byte array
    | DatatypedLiteral of form_id: byte array * datatype_id: byte array
    | LanguageString of form_id: byte array * language_id: byte array
    | LanguageRegionString of form_id: byte array * language_id: byte array * region_id: byte array
    | DirectedLanguageString of form_id: byte array * language_id: byte array * direction: byte array
    | DirectedLanguageRegionString of
        form_id: byte array *
        language_id: byte array *
        region: byte array *
        direction: byte array

module RDF_Term_Data =
    let to_encoding (rdf_term_data: RDF_Term_Data) =
        MessagePackSerializer.Serialize(rdf_term_data, message_pack_options)

    let from_encoding (term_encoding: byte array) =
        MessagePackSerializer.Deserialize<RDF_Term_Data>(term_encoding, message_pack_options)

    let lexical_form_id rdf_term_data =
        match rdf_term_data with
        | ResolvedIRI form_id -> Form_ID.from_encoding form_id
        | RelativeIRI form_id -> Form_ID.from_encoding form_id
        | SkolemIRI form_id -> Form_ID.from_encoding form_id
        | QuestionVariable form_id -> Form_ID.from_encoding form_id
        | DollarVariable form_id -> Form_ID.from_encoding form_id
        | SimpleLiteral form_id -> Form_ID.from_encoding form_id
        | DatatypedLiteral (form_id, _) -> Form_ID.from_encoding form_id
        | LanguageString (form_id, _) -> Form_ID.from_encoding form_id
        | LanguageRegionString (form_id, _, _) -> Form_ID.from_encoding form_id
        | DirectedLanguageString (form_id, _, _) -> Form_ID.from_encoding form_id
        | DirectedLanguageRegionString (form_id, _, _, _) -> Form_ID.from_encoding form_id


type RDF_Term_ID = private TermID of byte array

type RDF_Term_ID with
    static member from_encoding(bytes: byte array) = TermID bytes

    member this.to_encoding =
        let (TermID bytes) = this
        bytes

type RDF_Term =
    {

      rdf_term_data: RDF_Term_Data
      rdf_term_id: RDF_Term_ID

     }

[<MessagePackObject>]
type Triple_Slot =
    | S
    | P
    | O

[<MessagePackObject>]
type Triple_Permutation =
    { permutation_map: Persistent_Map
      order: Triple_Slot array }

module Triple_Permutation =

    let spo =
        { permutation_map = Persistent_Map.SPO
          order = [| S; P; O |] }

    let sop =
        { permutation_map = Persistent_Map.SOP
          order = [| S; O; P |] }

    let pso =
        { permutation_map = Persistent_Map.PSO
          order = [| P; S; O |] }

    let pos =
        { permutation_map = Persistent_Map.POS
          order = [| P; O; S |] }

    let osp =
        { permutation_map = Persistent_Map.OSP
          order = [| O; S; P |] }

    let ops =
        { permutation_map = Persistent_Map.OPS
          order = [| O; P; S |] }

    let all =
        [| spo
           sop
           pso
           pos
           osp
           ops


           |]


type Triple_ID = private TripleID of byte array


type Triple_ID with
    static member from_encoding(bytes: byte array) = TripleID bytes

    member this.to_encoding =
        let (TripleID bytes) = this
        bytes




[<MessagePackObject>]
type Triple =
    {

      [<Key(0)>]
      subject_id: RDF_Term_ID
      [<Key(1)>]
      predicate_id: RDF_Term_ID
      [<Key(2)>]
      object_id: RDF_Term_ID

     }




module Triple =
    let spo (curSubject: RDF_Term) (curPredicate: RDF_Term) (curObject: RDF_Term) =

        {

          subject_id = curSubject.rdf_term_id
          predicate_id = curPredicate.rdf_term_id
          object_id = curObject.rdf_term_id

        }


    let to_encoding (triple: Triple) =
        MessagePackSerializer.Serialize(triple, message_pack_options)

    let from_encoding (triple_encoding: byte array) =
        MessagePackSerializer.Deserialize<Triple>(triple_encoding, message_pack_options)

    let slot_value slot quad =
        match slot with
        | S -> quad.subject_id
        | P -> quad.predicate_id
        | O -> quad.object_id


type Context_ID = private ContextID of byte array

type Context_ID with

    member this.to_encoding =
        let (ContextID bytes) = this
        bytes

    static member from_encoding(bytes: byte array) = ContextID bytes





[<MessagePackObject>]
type Persistent_Context =
    | NamedGraph of term_id: RDF_Term_ID
    | ParallelEdge of term_id: RDF_Term_ID

module Persistent_Context =

    let to_encoding (context: Persistent_Context) =
        MessagePackSerializer.Serialize(context, message_pack_options)

    let from_encoding (context_encoding: byte array) =
        MessagePackSerializer.Deserialize<Persistent_Context>(context_encoding, message_pack_options)

type Quad =
    { triple_id: Triple_ID
      context_id: Context_ID }


module Permutation_Key =

    let slot_value_from_triple (slot: Triple_Slot) (triple: Triple) =
        match slot with
        | S -> triple.subject_id.to_encoding
        | P -> triple.predicate_id.to_encoding
        | O -> triple.object_id.to_encoding

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



type Byte_Map =
    { key_bytes: byte array
      value_bytes: byte array }

module Byte_Map =
    let from_string (string_value: string) =
        { key_bytes = string_value.to_digest
          value_bytes = string_value.encoding }


module Database =

    module Put =

        let Triples (triples: Triple array) : Triple_ID array =

            let stopwatch = Stopwatch.StartNew()
            let mutable written = 0
            use transaction = environment.BeginTransaction()

            let triple_ids =
                triples
                |> Array.map (fun triple ->

                    for permutation in Triple_Permutation.all do
                        let permutation_key = Permutation_Key.from_triple permutation triple

                        transaction.Put(permutation.permutation_map.handle, permutation_key, [||])
                        |> MDBResultCode.fail_if_not_success
                            $"Put triple permutation {permutation.permutation_map.name}"

                        written <- written + 1

                    Triple_ID.from_triple triple)

            transaction.Commit() |> ignore

            printfn "triples=%i index_entries=%i elapsed=%O" triples.Length written stopwatch.Elapsed

            stopwatch.Stop()

            triple_ids

        let Quads (quads: Quad array) =

            let stopwatch = Stopwatch.StartNew()
            let mutable written = 0
            use transaction = environment.BeginTransaction()

            for quad in quads do
                transaction.Put(
                    Persistent_Map.Triple_ID_to_Context_IDs.handle,
                    quad.triple_id.to_encoding,
                    quad.context_id.to_encoding
                )
                |> MDBResultCode.fail_if_not_success "Put Triple_ID_to_Context_IDs"

                transaction.Put(
                    Persistent_Map.Context_ID_to_Triple_IDs.handle,
                    quad.context_id.to_encoding,
                    quad.triple_id.to_encoding
                )
                |> MDBResultCode.fail_if_not_success "Put Context_ID_to_Triple_IDs"

                written <- written + 2

            transaction.Commit() |> ignore

            printfn "quads=%i index_entries=%i elapsed=%O" quads.Length written stopwatch.Elapsed

            stopwatch.Stop()




    module Count =


        let Keys (persistent_map: Persistent_Map) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            use cursor = transaction.CreateCursor(persistent_map.handle)

            let mutable count = 0L

            let struct (first_result, _, _) = cursor.First()

            let mutable keep_reading = first_result = MDBResultCode.Success

            while keep_reading do
                count <- count + 1L

                let struct (next_result, _, _) = cursor.Next()

                keep_reading <- next_result = MDBResultCode.Success

            count


    module Get =
        let Keys_by_Persistent_Map_Prefix (persistent_map: Persistent_Map) (prefix: byte array) =

            let results = ResizeArray<byte array>()

            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            use cursor = transaction.CreateCursor(persistent_map.handle)

            let set_result = cursor.SetRange(prefix)

            if set_result = MDBResultCode.Success then

                let mutable keep_reading = true

                while keep_reading do
                    let struct (current_result, current_key, _current_value) = cursor.GetCurrent()

                    if current_result = MDBResultCode.Success then
                        let key_bytes = current_key.CopyToNewArray()

                        if Permutation_Key.Prefix.starts_with prefix key_bytes then
                            results.Add key_bytes

                            let struct (next_result, _, _) = cursor.Next()

                            if next_result <> MDBResultCode.Success then
                                keep_reading <- false
                        else
                            keep_reading <- false
                    else
                        keep_reading <- false

            results.ToArray()



        let Lexical_Forms_from_Strings (strings: string array) =
            let stopwatch = Stopwatch.StartNew()
            let mutable written = 0
            let byte_maps = strings |> Array.map Byte_Map.from_string

            let batched_ids =

                [|

                   for byte_map_batch in byte_maps |> Array.chunkBySize batch_size do
                       use transaction = environment.BeginTransaction()

                       let form_ids =

                           [|

                              for byte_map in byte_map_batch do
                                  let digest = byte_map.key_bytes

                                  match transaction.Get(Persistent_Map.Digest_to_Form_ID.handle, digest) with
                                  | struct (MDBResultCode.Success, _, mdb_form_id) ->
                                      Form_ID.from_encoding mdb_form_id.to_encoding

                                  | struct (MDBResultCode.NotFound, _, _) ->
                                      let form_id =
                                          ID.next_mid_transaction Persistent_Map.Form_ID_to_Encoding transaction


                                      transaction.Put(
                                          Persistent_Map.Form_ID_to_Encoding.handle,
                                          form_id,
                                          byte_map.value_bytes
                                      )
                                      |> MDBResultCode.fail_if_not_success "Put Form ID -> Encoding"

                                      transaction.Put(Persistent_Map.Digest_to_Form_ID.handle, digest, form_id)
                                      |> MDBResultCode.fail_if_not_success "Put Digest -> Form ID"

                                      Form_ID.from_encoding form_id

                                  | struct (result_code, _, _) ->
                                      failwith $"Get Digest -> Form ID failed with MDBResultCode: {result_code}"

                              |]

                       transaction.Commit() |> ignore

                       written <- written + byte_map_batch.Length

                       printfn "written=%i/%i elapsed=%O" written byte_maps.Length stopwatch.Elapsed
                       yield form_ids

                   |]

            stopwatch.Stop()

            let form_ids =
                batched_ids
                |> Array.collect (fun form_ids -> form_ids)

            Array.zip strings form_ids
            |> Array.map (fun (string_value, form_id) ->
                { string_value = string_value
                  form_id = form_id })


        let RDF_Terms_From_RDF_Term_Data (rdf_term_data: RDF_Term_Data array) =
            let stopwatch = Stopwatch.StartNew()
            let mutable written = 0

            let term_encodings =
                rdf_term_data
                |> Array.map RDF_Term_Data.to_encoding

            let batched_ids =
                [|


                   for term_encoding_batch in term_encodings |> Array.chunkBySize batch_size do
                       use transaction = environment.BeginTransaction()

                       let term_ids =
                           [|

                              for term_encoding in term_encoding_batch do

                                  match transaction.Get(Persistent_Map.Term_to_Term_ID.handle, term_encoding) with
                                  | struct (MDBResultCode.Success, _, mdb_term_id) ->
                                      RDF_Term_ID.from_encoding mdb_term_id.to_encoding

                                  | struct (MDBResultCode.NotFound, _, _) ->
                                      let term_id = ID.next_mid_transaction Persistent_Map.Term_ID_to_Term transaction


                                      transaction.Put(Persistent_Map.Term_ID_to_Term.handle, term_id, term_encoding)
                                      |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

                                      transaction.Put(Persistent_Map.Term_to_Term_ID.handle, term_encoding, term_id)
                                      |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

                                      RDF_Term_ID.from_encoding term_id

                                  | struct (result_code, _, _) ->
                                      failwith $"Get Term -> Term ID failed with MDBResultCode: {result_code}"

                              |]



                       transaction.Commit() |> ignore

                       written <- written + term_encoding_batch.Length

                       printfn "written=%i/%i elapsed=%O" written term_encoding_batch.Length stopwatch.Elapsed
                       yield term_ids

                   |]

            stopwatch.Stop()

            let term_ids =
                batched_ids
                |> Array.collect (fun term_ids -> term_ids)

            Array.zip rdf_term_data term_ids
            |> Array.map (fun (rdf_term_data, term_id) ->
                { rdf_term_data = rdf_term_data
                  rdf_term_id = term_id })

        let Keys_by_Persistent_Map (persistent_map: Persistent_Map) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            use cursor = transaction.CreateCursor(persistent_map.handle)

            cursor.AsEnumerable()
            |> Seq.map (fun struct (key_bytes, _) -> key_bytes.AsSpan().ToArray())
            |> Seq.toArray

        let Values_by_Persistent_Map (persistent_map: Persistent_Map) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            use cursor = transaction.CreateCursor(persistent_map.handle)

            cursor.AsEnumerable()
            |> Seq.map (fun struct (_, value_bytes) -> value_bytes.AsSpan().ToArray())
            |> Seq.toArray

        let Value_by_Persistent_Map (persistent_map: Persistent_Map) (key_bytes: byte array) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            match transaction.Get(persistent_map.handle, key_bytes) with
            | struct (MDBResultCode.Success, _key, value_bytes) -> Some(value_bytes.AsSpan().ToArray())

            | struct (MDBResultCode.NotFound, _, _) -> None

            | struct (result_code, _, _) -> failwith $"Get key -> value failed with MDBResultCode: {result_code}"

        let Form_ID_by_String (string_value: string) =
            Value_by_Persistent_Map Persistent_Map.Digest_to_Form_ID string_value.to_digest

        let Encoding_by_Form_ID (FormID form_id) =
            Value_by_Persistent_Map Persistent_Map.Form_ID_to_Encoding form_id


        let Context_ID_From_Persistent_Context (persistent_context: Persistent_Context) =
            let context_encoding = Persistent_Context.to_encoding persistent_context

            match Value_by_Persistent_Map Persistent_Map.Context_to_Context_ID context_encoding with
            | Some context_id_encoding -> Context_ID.from_encoding context_id_encoding

            | None ->
                use transaction = environment.BeginTransaction()

                let context_id =
                    ID.next_mid_transaction Persistent_Map.Context_ID_to_Context transaction
                    |> Context_ID.from_encoding

                transaction.Put(Persistent_Map.Context_to_Context_ID.handle, context_encoding, context_id.to_encoding)
                |> MDBResultCode.fail_if_not_success "Put Context_to_Context_ID"

                transaction.Put(Persistent_Map.Context_ID_to_Context.handle, context_id.to_encoding, context_encoding)
                |> MDBResultCode.fail_if_not_success "Put Context_ID_to_Context"

                transaction.Commit() |> ignore

                context_id

    module Exists =

        let Triple (triple: Triple) =
            let key = Permutation_Key.from_triple Triple_Permutation.spo triple

            Get.Value_by_Persistent_Map Persistent_Map.SPO key
            |> Option.isSome



    module Validate =

        let Triple_Permutation_Presence (triple: Triple) =
            Triple_Permutation.all
            |> Array.map (fun permutation ->
                let key = Permutation_Key.from_triple permutation triple

                let exists =
                    Get.Value_by_Persistent_Map permutation.permutation_map key
                    |> Option.isSome

                permutation.permutation_map, exists)






module Form_ID =

    let to_string (FormID form_id) =
        Database.Get.Value_by_Persistent_Map Persistent_Map.Form_ID_to_Encoding form_id
        |> Option.get
        |> String.from_encoding

module Lexical_Forms =
    let to_resolved_iris (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun iri_form -> ResolvedIRI iri_form.form_id.to_encoding)

    let to_relative_iris (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun iri_form -> RelativeIRI iri_form.form_id.to_encoding)

module RDF_Term =
    let from_id (term_id: RDF_Term_ID) =
        { rdf_term_data =
            Database.Get.Value_by_Persistent_Map Persistent_Map.Term_ID_to_Term term_id.to_encoding
            |> Option.get
            |> RDF_Term_Data.from_encoding
          rdf_term_id = term_id }

    let to_string rdf_term =
        rdf_term.rdf_term_data
        |> RDF_Term_Data.lexical_form_id
        |> Form_ID.to_string

    let lexical_form_string_from_id term_id =
        Database.Get.Value_by_Persistent_Map Persistent_Map.Term_ID_to_Term term_id
        |> Option.get
        |> RDF_Term_Data.from_encoding
        |> RDF_Term_Data.lexical_form_id
        |> Form_ID.to_string

    let print (rdf_term: RDF_Term) = sprintf "%s" (to_string rdf_term)

    let representation rdf_term =
        match rdf_term.rdf_term_data with
        | ResolvedIRI form_id ->
            $"<{form_id
                |> Form_ID.from_encoding
                |> Form_ID.to_string}>"
        | RelativeIRI form_id ->
            $"<{form_id
                |> Form_ID.from_encoding
                |> Form_ID.to_string}>"
        | SkolemIRI form_id ->
            $"<{form_id
                |> Form_ID.from_encoding
                |> Form_ID.to_string}>"
        | QuestionVariable form_id ->
            $"?{form_id
                |> Form_ID.from_encoding
                |> Form_ID.to_string}"
        | DollarVariable form_id ->
            $"${form_id
                |> Form_ID.from_encoding
                |> Form_ID.to_string}"
        | SimpleLiteral form_id ->
            $"\"{form_id
                 |> Form_ID.from_encoding
                 |> Form_ID.to_string}\""
        | DatatypedLiteral (form_id, datatype_id) ->
            $"\"{form_id
                 |> Form_ID.from_encoding
                 |> Form_ID.to_string}\"^^<{datatype_id
                                            |> Form_ID.from_encoding
                                            |> Form_ID.to_string}>"
        | LanguageString (form_id, language_id) ->
            $"\"{form_id
                 |> Form_ID.from_encoding
                 |> Form_ID.to_string}\"@{language_id
                                          |> Form_ID.from_encoding
                                          |> Form_ID.to_string}"
        | LanguageRegionString (form_id, language_id, region_id) ->
            $"\"{form_id
                 |> Form_ID.from_encoding
                 |> Form_ID.to_string}\"@{language_id
                                          |> Form_ID.from_encoding
                                          |> Form_ID.to_string}-{region_id
                                                                 |> Form_ID.from_encoding
                                                                 |> Form_ID.to_string}"
        | DirectedLanguageString (form_id, language_id, direction_id) ->
            $"\"{form_id
                 |> Form_ID.from_encoding
                 |> Form_ID.to_string}\"@{language_id
                                          |> Form_ID.from_encoding
                                          |> Form_ID.to_string}-{direction_id
                                                                 |> Form_ID.from_encoding
                                                                 |> Form_ID.to_string}"
        | DirectedLanguageRegionString (form_id, language_id, region_id, direction_id) ->
            $"\"{form_id
                 |> Form_ID.from_encoding
                 |> Form_ID.to_string}\"@{language_id
                                          |> Form_ID.from_encoding
                                          |> Form_ID.to_string}-{region_id
                                                                 |> Form_ID.from_encoding
                                                                 |> Form_ID.to_string}-{direction_id
                                                                                        |> Form_ID.from_encoding
                                                                                        |> Form_ID.to_string}"

    let to_transient_map (terms: RDF_Term array) =
        let dictionary = Dictionary<string, RDF_Term>()

        for term in terms do
            let key = to_string term

            if not (dictionary.ContainsKey key) then
                dictionary.Add(key, term)

        dictionary

fsi.AddPrinter<RDF_Term>(fun rdf_term -> sprintf "%s" (RDF_Term.representation rdf_term))







module Assert =
    let spo (curSubject: RDF_Term) (curPredicate: RDF_Term) (curObject: RDF_Term) =

        Database.Put.Triples [| Triple.spo curSubject curPredicate curObject |]

    let Triples triples = Database.Put.Triples triples

    let spoc (curSubject: RDF_Term) (curPredicate: RDF_Term) (curObject: RDF_Term) (context_id: Context_ID) =
        let triple = Triple.spo curSubject curPredicate curObject


        let quads =
            [| triple |]
            |> Array.map (fun triple ->
                { triple_id = Triple_ID.from_triple triple
                  context_id = context_id })

        Database.Put.Quads quads

    let Triples_In_Context (context_id: Context_ID) (triples: Triple array) =
        Triples triples

        let quads =
            triples
            |> Array.map (fun triple ->
                { triple_id = Triple_ID.from_triple triple
                  context_id = context_id })

        Database.Put.Quads quads


type Triple_Pattern =
    { ground_subject: RDF_Term_ID option
      ground_predicate: RDF_Term_ID option
      ground_object: RDF_Term_ID option }

module Triple_Pattern =
    let print (triple_pattern: Triple_Pattern) =
        let s =
            match triple_pattern.ground_subject with
            | Some _ -> "s"
            | None -> "_"

        let p =
            match triple_pattern.ground_predicate with
            | Some _ -> "p"
            | None -> "_"

        let o =
            match triple_pattern.ground_object with
            | Some _ -> "o"
            | None -> "_"


        $"{s}{p}{o}"


    let bound_slot pattern slot =
        match slot with
        | S -> pattern.ground_subject
        | P -> pattern.ground_predicate
        | O -> pattern.ground_object

    let grounded_slots_in_canonical_order pattern =
        [| S; P; O |]
        |> Array.filter (fun slot -> bound_slot pattern slot |> Option.isSome)


    let permutation_covers_pattern pattern (permutation: Triple_Permutation) =
        let grounded = grounded_slots_in_canonical_order pattern

        let candidate_prefix = permutation.order |> Array.take grounded.Length

        grounded
        |> Array.forall (fun grounded_slot -> candidate_prefix |> Array.contains grounded_slot)

    let choose_permutation pattern =
        Triple_Permutation.all
        |> Array.tryFind (fun permutation -> permutation_covers_pattern pattern permutation)

    let permutation_prefix pattern (permutation: Triple_Permutation) =
        permutation.order
        |> Array.takeWhile (fun slot -> bound_slot pattern slot |> Option.isSome)
        |> Array.map (fun slot -> bound_slot pattern slot |> Option.get)
        |> Array.map (fun term_id -> term_id.to_encoding)
        |> Array.collect id




module Query =

    let triples_by_pattern pattern =
        let permutation =
            match Triple_Pattern.choose_permutation pattern with
            | Some permutation -> permutation
            | _ -> failwith $"No permutation in active profile covers pattern {Triple_Pattern.print pattern}."

        let prefix = Triple_Pattern.permutation_prefix pattern permutation

        Database.Get.Keys_by_Persistent_Map_Prefix permutation.permutation_map prefix
        |> Array.map (fun permutation_key -> Permutation_Key.to_triple permutation permutation_key)

    let terms_for_slot slot pattern =
        triples_by_pattern pattern
        |> Array.map (fun triple -> Triple.slot_value slot triple |> RDF_Term.from_id)



    // ------------------------------------------------------------
    // 0 FREE VARIABLES
    // ------------------------------------------------------------

    let spo subject predicate object =
        { ground_subject = Some subject.rdf_term_id
          ground_predicate = Some predicate.rdf_term_id
          ground_object = Some object.rdf_term_id }
        |> triples_by_pattern


    // ------------------------------------------------------------
    // 1 FREE VARIABLE
    // ------------------------------------------------------------

    let _po predicate object =
        { ground_subject = None
          ground_predicate = Some predicate.rdf_term_id
          ground_object = Some object.rdf_term_id }
        |> terms_for_slot S

    let s_o subject object =
        { ground_subject = Some subject.rdf_term_id
          ground_predicate = None
          ground_object = Some object.rdf_term_id }
        |> terms_for_slot P

    let sp_ subject predicate =
        { ground_subject = Some subject.rdf_term_id
          ground_predicate = Some predicate.rdf_term_id
          ground_object = None }
        |> terms_for_slot O



    // ------------------------------------------------------------
    // 2 FREE VARIABLES
    // ------------------------------------------------------------


    let s__ subject =
        { ground_subject = Some subject.rdf_term_id
          ground_predicate = None
          ground_object = None }
        |> triples_by_pattern
        |> Array.map (fun triple -> RDF_Term.from_id triple.predicate_id, RDF_Term.from_id triple.object_id)

    let _p_ predicate =
        { ground_subject = None
          ground_predicate = Some predicate.rdf_term_id
          ground_object = None }
        |> triples_by_pattern
        |> Array.map (fun triple -> RDF_Term.from_id triple.subject_id, RDF_Term.from_id triple.object_id)


    let __o object =
        { ground_subject = None
          ground_predicate = None
          ground_object = Some object.rdf_term_id }
        |> triples_by_pattern
        |> Array.map (fun triple -> RDF_Term.from_id triple.subject_id, RDF_Term.from_id triple.predicate_id)


    // ------------------------------------------------------------
    // 3 FREE VARIABLES
    // ------------------------------------------------------------


    let ___ () =
        { ground_subject = None
          ground_predicate = None
          ground_object = None }
        |> triples_by_pattern


























(*

let Alice = iri "https://www.example.com/Alice"
let knows = iri "https://www.example.com/knows"
let Bob = iri "https://www.example.com/Bob"
let example = iri "https://www.example.com/"
let Charlie = iri "https://www.example.com/Charlie"
let name = iri "https://www.example.com/name"
let Alice_literal = simple_literal "Alice"

Assert.spoc Alice knows Bob example
Assert.spoc Bob knows Charlie example
Assert.spoc Alice name Alice_literal example

Query.sp_c Alice knows example
|> Array.map RDF_Term.lexical_form_string

let results = Query._p__ name

results
|> Array.map (fun (s, o, c) ->
    sprintf
        "%s %s %s %s"
        (RDF_Term.lexical_form_string s)
        (RDF_Term.lexical_form_string name)
        (RDF_Term.lexical_form_string o)
        (RDF_Term.lexical_form_string c))


*)


















(*



let Alice_form = "httpCharlies://www.example.com/Alice"
let knows_form = "https://www.example.com/knows"
let Bob_form = "https://www.example.com/Bob"
let example_form = "https://www.example.com"


let iri_forms =
    Database.Get.Lexical_Forms_from_Strings [|

                                               Alice_form
                                               knows_form
                                               Bob_form
                                               example_form

                                                |]

let iri_terms =
    iri_terms_from_lexical_forms iri_forms
    |> Database.Get.RDF_Terms_From_RDF_Term_Data

let Alice_iri = iri_term_by_string Alice_form iri_terms
let knows_iri = iri_term_by_string knows_form iri_terms
let Bob_iri = iri_term_by_string Bob_form iri_terms
let example_iri = iri_term_by_string example_form iri_terms

let example_quad =
    {

      subject_id = Alice_iri.term_id
      predicate_id = knows_iri.term_id
      object_id = Bob_iri.term_id
      context_id = example_iri.term_id

    }

let Charlie = iri "https://www.example.com/Charlie"

let test_quad =
    { example_quad with
        subject_id = Bob_iri.term_id
        object_id = Charlie.term_id }







Database.Put.Quads [| example_quad
                      test_quad |]

let quad_result =
    Database.Get.Keys_by_Persistent_Map Persistent_Map.SPOC
    |> Array.map (fun permutation_key -> Permutation_Key.to_quad Quad_Permutation.spoc permutation_key)
    |> Array.head

let subject_string = string_from_iri_term_id quad_result.subject_id
let predicate_string = string_from_iri_term_id quad_result.predicate_id
let object_string = string_from_iri_term_id quad_result.object_id
let context_string = string_from_iri_term_id quad_result.context_id

$"<{subject_string}> <{predicate_string}> <{object_string}> <{context_string}>"



let alice_knows_prefix =
    Permutation_Key.Prefix.concat [| Alice_iri.term_id
                                     knows_iri.term_id
                                     example_iri.term_id |]

let alice_knows_results =
    Database.Get.Keys_by_Persistent_Map Persistent_Map.SPCO
    |> Array.filter (Permutation_Key.Prefix.starts_with alice_knows_prefix)
    |> Array.map (fun permutation_key -> Permutation_Key.to_quad Quad_Permutation.spco permutation_key)

let alice_knows_object_strings =
    alice_knows_results
    |> Array.map (fun quad -> string_from_iri_term_id quad.object_id)

alice_knows_object_strings



let bob_knows_prefix =
    Permutation_Key.Prefix.concat [| Bob_iri.term_id
                                     knows_iri.term_id
                                     example_iri.term_id |]

let bob_knows_results =
    Database.Get.Keys_by_Persistent_Map Persistent_Map.SPCO
    |> Array.filter (Permutation_Key.Prefix.starts_with bob_knows_prefix)
    |> Array.map (fun permutation_key -> Permutation_Key.to_quad Quad_Permutation.spco permutation_key)

let bob_knows_object_strings =
    bob_knows_results
    |> Array.map (fun quad -> string_from_iri_term_id quad.object_id)

bob_knows_object_strings






let alice_knows_results_fast =
    Database.Get.Keys_by_Persistent_Map_Prefix Persistent_Map.SPCO alice_knows_prefix
    |> Array.map (fun permutation_key -> Permutation_Key.to_quad Quad_Permutation.spco permutation_key)
    |> Array.map (fun quad -> string_from_iri_term_id quad.object_id)
*)
