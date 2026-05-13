open System
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
let map_size = int64 2 * GiB
let environment_directory_path = @"D:\Persistence\LMDB"

System.IO.Directory.CreateDirectory(environment_directory_path)
|> ignore

let mutable batch_size = 250_000


let environment = new LightningEnvironment(environment_directory_path)
environment.MapSize <- map_size
environment.MaxDatabases <- 30


environment.Open()

module MDBResultCode =

    let succeeded (result_code: MDBResultCode) = result_code = MDBResultCode.Success

    let failed (result_code: MDBResultCode) = result_code <> MDBResultCode.Success

    let fail_if_not_success (operation_name: string) (result_code: MDBResultCode) =
        if result_code <> MDBResultCode.Success then
            failwith $"{operation_name} failed with MDBResultCode: {result_code}"

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

    let Quads_to_Attribute_Values =
        lightning_database
            "Quads_to_Attribute_Values"
            (DatabaseOpenFlags.Create
             ||| DatabaseOpenFlags.DuplicatesSort)

    let SPOC = lightning_database "SPOC" DatabaseOpenFlags.Create
    let SPCO = lightning_database "SPCO" DatabaseOpenFlags.Create
    let SOPC = lightning_database "SOPC" DatabaseOpenFlags.Create
    let SOCP = lightning_database "SOCP" DatabaseOpenFlags.Create
    let SCPO = lightning_database "SCPO" DatabaseOpenFlags.Create
    let SCOP = lightning_database "SCOP" DatabaseOpenFlags.Create
    let PSOC = lightning_database "PSOC" DatabaseOpenFlags.Create
    let PSCO = lightning_database "PSCO" DatabaseOpenFlags.Create
    let POSC = lightning_database "POSC" DatabaseOpenFlags.Create
    let POCS = lightning_database "POCS" DatabaseOpenFlags.Create
    let PCSO = lightning_database "PCSO" DatabaseOpenFlags.Create
    let PCOS = lightning_database "PCOS" DatabaseOpenFlags.Create
    let OSPC = lightning_database "OSPC" DatabaseOpenFlags.Create
    let OSCP = lightning_database "OSCP" DatabaseOpenFlags.Create
    let OPSC = lightning_database "OPSC" DatabaseOpenFlags.Create
    let OPCS = lightning_database "OPCS" DatabaseOpenFlags.Create
    let OCSP = lightning_database "OCSP" DatabaseOpenFlags.Create
    let OCPS = lightning_database "OCPS" DatabaseOpenFlags.Create
    let CSPO = lightning_database "CSPO" DatabaseOpenFlags.Create
    let CSOP = lightning_database "CSOP" DatabaseOpenFlags.Create
    let CPSO = lightning_database "CPSO" DatabaseOpenFlags.Create
    let CPOS = lightning_database "CPOS" DatabaseOpenFlags.Create
    let COSP = lightning_database "COSP" DatabaseOpenFlags.Create
    let COPS = lightning_database "COPS" DatabaseOpenFlags.Create


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

type MDBValue with
    member this.to_encoding = this.AsSpan().ToArray()

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



type Lexical_Form =
    {

      string_value: string
      form_id: byte array

     }




[<MessagePackObject>]
type Persistent_Term =
    | ResolvedIRI of id: byte array
    | RelativeIRI of id: byte array
    | SkolemIRI of id: byte array
    | Variable of id: byte array
    | SimpleLiteral of id: byte array
    | DatatypedLiteral of id: byte array * datatype_id: byte array
    | LanguageString of id: byte array * language_id: byte array
    | LanguageRegionString of id: byte array * language_id: byte array * region_id: byte array
    | DirectedLanguageString of id: byte array * language_id: byte array * direction: byte array
    | DirectedLanguageRegionString of
        id: byte array *
        language_id: byte array *
        region: byte array *
        direction: byte array

module Persistent_Term =
    let to_encoding (persistent_term: Persistent_Term) =
        MessagePackSerializer.Serialize(persistent_term, message_pack_options)

    let from_encoding (term_encoding: byte array) =
        MessagePackSerializer.Deserialize<Persistent_Term>(term_encoding, message_pack_options)

type Transient_Term =
    {

      persistent_term: Persistent_Term
      term_id: byte array

     }

[<MessagePackObject>]
type Quad_Slot =
    | S
    | P
    | O
    | C

[<MessagePackObject>]
type Quad_Permutation =
    { permutation_map: Persistent_Map
      order: Quad_Slot array }

module Quad_Permutation =
    let spoc =
        { permutation_map = Persistent_Map.SPOC
          order = [| S; P; O; C |] }

    let spco =
        { permutation_map = Persistent_Map.SPCO
          order = [| S; P; C; O |] }

    let sopc =
        { permutation_map = Persistent_Map.SOPC
          order = [| S; O; P; C |] }

    let socp =
        { permutation_map = Persistent_Map.SOCP
          order = [| S; O; C; P |] }

    let scpo =
        { permutation_map = Persistent_Map.SCPO
          order = [| S; C; P; O |] }

    let scop =
        { permutation_map = Persistent_Map.SCOP
          order = [| S; C; O; P |] }

    let psoc =
        { permutation_map = Persistent_Map.PSOC
          order = [| P; S; O; C |] }

    let psco =
        { permutation_map = Persistent_Map.PSCO
          order = [| P; S; C; O |] }

    let posc =
        { permutation_map = Persistent_Map.POSC
          order = [| P; O; S; C |] }

    let pocs =
        { permutation_map = Persistent_Map.POCS
          order = [| P; O; C; S |] }

    let pcso =
        { permutation_map = Persistent_Map.PCSO
          order = [| P; C; S; O |] }

    let pcos =
        { permutation_map = Persistent_Map.PCOS
          order = [| P; C; O; S |] }

    let ospc =
        { permutation_map = Persistent_Map.OSPC
          order = [| O; S; P; C |] }

    let oscp =
        { permutation_map = Persistent_Map.OSCP
          order = [| O; S; C; P |] }

    let opsc =
        { permutation_map = Persistent_Map.OPSC
          order = [| O; P; S; C |] }

    let opcs =
        { permutation_map = Persistent_Map.OPCS
          order = [| O; P; C; S |] }

    let ocsp =
        { permutation_map = Persistent_Map.OCSP
          order = [| O; C; S; P |] }

    let ocps =
        { permutation_map = Persistent_Map.OCPS
          order = [| O; C; P; S |] }

    let cspo =
        { permutation_map = Persistent_Map.CSPO
          order = [| C; S; P; O |] }

    let csop =
        { permutation_map = Persistent_Map.CSOP
          order = [| C; S; O; P |] }

    let cpso =
        { permutation_map = Persistent_Map.CPSO
          order = [| C; P; S; O |] }

    let cpos =
        { permutation_map = Persistent_Map.CPOS
          order = [| C; P; O; S |] }

    let cosp =
        { permutation_map = Persistent_Map.COSP
          order = [| C; O; S; P |] }

    let cops =
        { permutation_map = Persistent_Map.COPS
          order = [| C; O; P; S |] }

    let all =
        [| spoc
           spco
           sopc
           socp
           scpo
           scop
           psoc
           psco
           posc
           pocs
           pcso
           pcos
           ospc
           oscp
           opsc
           opcs
           ocsp
           ocps
           cspo
           csop
           cpso
           cpos
           cosp
           cops |]

[<MessagePackObject>]
type Quad =
    {

      [<Key(0)>]
      subject_id: byte array
      [<Key(1)>]
      predicate_id: byte array
      [<Key(2)>]
      object_id: byte array
      [<Key(3)>]
      context_id: byte array

     }

module Quad =
    let to_encoding (quad: Quad) =
        MessagePackSerializer.Serialize(quad, message_pack_options)

    let from_encoding (quad_encoding: byte array) =
        MessagePackSerializer.Deserialize<Quad>(quad_encoding, message_pack_options)

module Permutation_Key =

    let slot_value_from_quad slot quad =
        match slot with
        | S -> quad.subject_id
        | P -> quad.predicate_id
        | O -> quad.object_id
        | C -> quad.context_id

    let from_quad (permutation: Quad_Permutation) (quad: Quad) =
        permutation.order
        |> Array.collect (fun slot -> slot_value_from_quad slot quad)

    let private chunks_of_8 (bytes: byte array) =
        if bytes.Length <> 32 then
            failwithf "Permutation key must be 32 bytes, but was %i bytes." bytes.Length

        [| bytes[0..7]
           bytes[8..15]
           bytes[16..23]
           bytes[24..31] |]

    let to_quad (permutation: Quad_Permutation) (permutation_key: byte array) =
        let chunks = chunks_of_8 permutation_key

        let mutable subject_id = None
        let mutable predicate_id = None
        let mutable object_id = None
        let mutable context_id = None

        for i = 0 to 3 do
            match permutation.order[i] with
            | S -> subject_id <- Some chunks[i]
            | P -> predicate_id <- Some chunks[i]
            | O -> object_id <- Some chunks[i]
            | C -> context_id <- Some chunks[i]

        { subject_id = subject_id.Value
          predicate_id = predicate_id.Value
          object_id = object_id.Value
          context_id = context_id.Value }

    module Prefix =
        let concat (arrays: byte array array) = arrays |> Array.collect id

        let starts_with (prefix: byte array) (bytes: byte array) =
            bytes.Length >= prefix.Length
            && prefix
               |> Array.mapi (fun i b -> bytes[i] = b)
               |> Array.forall id



type Quad_Pattern =
    { ground_subject: byte array option
      ground_predicate: byte array option
      ground_object: byte array option
      ground_context: byte array option }

module Quad_Pattern =
    let bound_slot pattern slot =
        match slot with
        | S -> pattern.ground_subject
        | P -> pattern.ground_predicate
        | O -> pattern.ground_object
        | C -> pattern.ground_context

    let permutation_prefix pattern permutation =
        permutation.order
        |> Array.takeWhile (fun slot -> bound_slot pattern slot |> Option.isSome)
        |> Array.map (fun slot -> bound_slot pattern slot |> Option.get)
        |> Array.collect id



[<MessagePackObject>]
type Attribute_Value =
    {

      [<Key(0)>]
      attribute: Quad_Slot
      [<Key(1)>]
      value_bytes: byte array

     }

module Attribute_Value =
    let to_encoding (attribute_value: Attribute_Value) =
        MessagePackSerializer.Serialize(attribute_value, message_pack_options)

    let from_encoding (attribute_value_encoding: byte array) =
        MessagePackSerializer.Deserialize<Attribute_Value>(attribute_value_encoding, message_pack_options)

type Byte_Map =
    { key_bytes: byte array
      value_bytes: byte array }

module Byte_Map =
    let from_string (string_value: string) =
        { key_bytes = string_value.to_digest
          value_bytes = string_value.encoding }


module Database =

    module Put =
        let Quads (quads: Quad array) =

            let stopwatch = Stopwatch.StartNew()
            let mutable written = 0
            use transaction = environment.BeginTransaction()

            for quad in quads do
                for permutation in Quad_Permutation.all do
                    let permutation_key = Permutation_Key.from_quad permutation quad

                    transaction.Put(permutation.permutation_map.handle, permutation_key, [||])
                    |> ignore

                written <- written + 24





            transaction.Commit() |> ignore


            printfn "quads=%i index_entries=%i elapsed=%O" quads.Length written stopwatch.Elapsed

            stopwatch.Stop()
    (*
        let Quads (quads: Quad array) =

            let stopwatch = Stopwatch.StartNew()
            let mutable written = 0
            use transaction = environment.BeginTransaction()

            for quad in quads do
                let quad_bytes = MessagePackSerializer.Serialize(quad, message_pack_options)

                let S_quad =
                    Attribute_Value.to_encoding
                        { attribute = S
                          value_bytes = quad_bytes }

                let P_quad =
                    Attribute_Value.to_encoding
                        { attribute = P
                          value_bytes = quad_bytes }

                let O_quad =
                    Attribute_Value.to_encoding
                        { attribute = O
                          value_bytes = quad_bytes }

                let C_quad =
                    Attribute_Value.to_encoding
                        { attribute = C
                          value_bytes = quad_bytes }

                let quad_S =
                    Attribute_Value.to_encoding
                        { attribute = S
                          value_bytes = quad.subject_id }

                let quad_P =
                    Attribute_Value.to_encoding
                        { attribute = P
                          value_bytes = quad.predicate_id }

                let quad_O =
                    Attribute_Value.to_encoding
                        { attribute = O
                          value_bytes = quad.object_id }

                let quad_C =
                    Attribute_Value.to_encoding
                        { attribute = C
                          value_bytes = quad.context_id }


                transaction.Put(Persistent_Map.Term_ID_to_Attribute_Values.handle, quad.subject_id, S_quad)
                |> MDBResultCode.fail_if_not_success "Put Term ID -> attribute value"

                transaction.Put(Persistent_Map.Term_ID_to_Attribute_Values.handle, quad.predicate_id, P_quad)
                |> MDBResultCode.fail_if_not_success "Put Term ID -> attribute value"

                transaction.Put(Persistent_Map.Term_ID_to_Attribute_Values.handle, quad.object_id, O_quad)
                |> MDBResultCode.fail_if_not_success "Put Term ID -> attribute value"

                transaction.Put(Persistent_Map.Term_ID_to_Attribute_Values.handle, quad.context_id, C_quad)
                |> MDBResultCode.fail_if_not_success "Put Term ID -> attribute value"

                transaction.Put(Persistent_Map.Quads_to_Attribute_Values.handle, quad_bytes, quad_S)
                |> MDBResultCode.fail_if_not_success "Put Quad -> attribute value"

                transaction.Put(Persistent_Map.Quads_to_Attribute_Values.handle, quad_bytes, quad_P)
                |> MDBResultCode.fail_if_not_success "Put Quad -> attribute value"

                transaction.Put(Persistent_Map.Quads_to_Attribute_Values.handle, quad_bytes, quad_O)
                |> MDBResultCode.fail_if_not_success "Put Quad -> attribute value"

                transaction.Put(Persistent_Map.Quads_to_Attribute_Values.handle, quad_bytes, quad_C)
                |> MDBResultCode.fail_if_not_success "Put Quad -> attribute value"

                written <- written + 8





            transaction.Commit() |> ignore


            printfn "written=%i/%i elapsed=%O" written quads.Length stopwatch.Elapsed

            stopwatch.Stop()

        *)
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
                                  | struct (MDBResultCode.Success, _, mdb_form_id) -> mdb_form_id.to_encoding

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

                                      form_id

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


        let Transient_Terms_From_Persistent_Terms (persistent_terms: Persistent_Term array) =
            let stopwatch = Stopwatch.StartNew()
            let mutable written = 0

            let term_encodings =
                persistent_terms
                |> Array.map Persistent_Term.to_encoding

            let batched_ids =
                [|


                   for term_encoding_batch in term_encodings |> Array.chunkBySize batch_size do
                       use transaction = environment.BeginTransaction()

                       let term_ids =
                           [|

                              for term_encoding in term_encoding_batch do

                                  match transaction.Get(Persistent_Map.Term_to_Term_ID.handle, term_encoding) with
                                  | struct (MDBResultCode.Success, _, mdb_term_id) -> mdb_term_id.to_encoding

                                  | struct (MDBResultCode.NotFound, _, _) ->
                                      let term_id = ID.next_mid_transaction Persistent_Map.Term_ID_to_Term transaction


                                      transaction.Put(Persistent_Map.Term_ID_to_Term.handle, term_id, term_encoding)
                                      |> MDBResultCode.fail_if_not_success "Put Term ID -> Term"

                                      transaction.Put(Persistent_Map.Term_to_Term_ID.handle, term_encoding, term_id)
                                      |> MDBResultCode.fail_if_not_success "Put Term -> Term ID"

                                      term_id

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

            Array.zip persistent_terms term_ids
            |> Array.map (fun (persistent_term, term_id) ->
                { persistent_term = persistent_term
                  term_id = term_id })

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

























let lexical_form_by_string (string_value: string) (lexical_forms: Lexical_Form array) =
    lexical_forms
    |> Array.find (fun lexical_form -> lexical_form.string_value = string_value)

let form_id_by_string (string_value: string) (lexical_forms: Lexical_Form array) =
    let lexical_form = lexical_form_by_string string_value lexical_forms
    lexical_form.form_id

let iri_terms_from_lexical_forms (lexical_forms: Lexical_Form array) =
    lexical_forms
    |> Array.map (fun iri_form -> ResolvedIRI iri_form.form_id)

let iri_term_by_string (string_value: string) (terms: Transient_Term array) =
    terms
    |> Array.filter (fun term -> term.persistent_term.IsResolvedIRI)
    |> Array.pick (fun term ->
        let (ResolvedIRI form_id) = term.persistent_term

        let id_check =
            Database.Get.Value_by_Persistent_Map Persistent_Map.Form_ID_to_Encoding form_id
            |> Option.map (fun string_encoding -> string_value = String.from_encoding string_encoding)

        match id_check with
        | Some true -> Some(term)
        | _ -> None


    )

let simple_literal_term_by_string (string_value: string) (terms: Transient_Term array) =
    terms
    |> Array.filter (fun term -> term.persistent_term.IsSimpleLiteral)
    |> Array.pick (fun term ->
        let (SimpleLiteral form_id) = term.persistent_term

        let id_check =
            Database.Get.Value_by_Persistent_Map Persistent_Map.Form_ID_to_Encoding form_id
            |> Option.map (fun string_encoding -> string_value = String.from_encoding string_encoding)

        match id_check with
        | Some true -> Some(term)
        | _ -> None


    )


let iri (iri_form: string) =
    Database.Get.Lexical_Forms_from_Strings [| iri_form |]
    |> iri_terms_from_lexical_forms
    |> Database.Get.Transient_Terms_From_Persistent_Terms
    |> iri_term_by_string iri_form

let string_from_iri_term_id (iri_term_id: byte array) =
    let (ResolvedIRI form_id) =
        Database.Get.Value_by_Persistent_Map Persistent_Map.Term_ID_to_Term iri_term_id
        |> Option.get
        |> Persistent_Term.from_encoding

    Database.Get.Value_by_Persistent_Map Persistent_Map.Form_ID_to_Encoding form_id
    |> Option.get
    |> String.from_encoding


let Charlie = iri "https://www.example.com/Charlie"

let simple_literal_terms_from_lexical_forms (lexical_forms: Lexical_Form array) =
    lexical_forms
    |> Array.map (fun simple_literal_form -> SimpleLiteral simple_literal_form.form_id)

let simple_literal (literal_form: string) =
    Database.Get.Lexical_Forms_from_Strings [| literal_form |]
    |> simple_literal_terms_from_lexical_forms
    |> Database.Get.Transient_Terms_From_Persistent_Terms
    |> simple_literal_term_by_string literal_form

(*



let Alice_form = "https://www.example.com/Alice"
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
    |> Database.Get.Transient_Terms_From_Persistent_Terms

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
