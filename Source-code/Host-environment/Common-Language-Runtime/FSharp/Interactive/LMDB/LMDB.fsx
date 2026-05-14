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

type Form_ID = private FormID of byte array


type Lexical_Form =
    {

      string_value: string
      form_id: byte array

     }




[<MessagePackObject>]
type Persistent_Term =
    | ResolvedIRI of form_id: byte array
    | RelativeIRI of form_id: byte array
    | SkolemIRI of form_id: byte array
    | Variable of form_id: byte array
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

module Persistent_Term =
    let to_encoding (persistent_term: Persistent_Term) =
        MessagePackSerializer.Serialize(persistent_term, message_pack_options)

    let from_encoding (term_encoding: byte array) =
        MessagePackSerializer.Deserialize<Persistent_Term>(term_encoding, message_pack_options)

    let lexical_form_id persistent_term =
        match persistent_term with
        | ResolvedIRI form_id -> form_id
        | RelativeIRI form_id -> form_id
        | SkolemIRI form_id -> form_id
        | Variable form_id -> form_id
        | SimpleLiteral form_id -> form_id
        | DatatypedLiteral (form_id, _) -> form_id
        | LanguageString (form_id, _) -> form_id
        | LanguageRegionString (form_id, _, _) -> form_id
        | DirectedLanguageString (form_id, _, _) -> form_id
        | DirectedLanguageRegionString (form_id, _, _, _) -> form_id




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

    module Profile =

        let minimal = [| spoc |]

        let rdf_triple_core = [| spoc; posc; ospc |]

        let rdf_triple_full = [| spoc; sopc; psoc; posc; ospc; opsc |]

        let context_core = [| cspo; cpos; cosp |]

        let rdf_quad_practical = [| spoc; posc; ospc; cspo; cpos; cosp |]

        let rdf_quad_subject_context = [| spoc; spco; scpo; scop; cspo; csop |]

        let rdf_quad_full =
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

    let permutation_profile = Profile.rdf_quad_practical

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
    let spoc
        (curSubject: Transient_Term)
        (curPredicate: Transient_Term)
        (curObject: Transient_Term)
        (curContext: Transient_Term)
        =

        {

          subject_id = curSubject.term_id
          predicate_id = curPredicate.term_id
          object_id = curObject.term_id
          context_id = curContext.term_id

        }


    let to_encoding (quad: Quad) =
        MessagePackSerializer.Serialize(quad, message_pack_options)

    let from_encoding (quad_encoding: byte array) =
        MessagePackSerializer.Deserialize<Quad>(quad_encoding, message_pack_options)

    let slot_value slot quad =
        match slot with
        | S -> quad.subject_id
        | P -> quad.predicate_id
        | O -> quad.object_id
        | C -> quad.context_id

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
                for permutation in Quad_Permutation.permutation_profile do
                    let permutation_key = Permutation_Key.from_quad permutation quad

                    transaction.Put(permutation.permutation_map.handle, permutation_key, [||])
                    |> MDBResultCode.fail_if_not_success $"Put quad permutation {permutation.permutation_map.name}"

                written <- written + 24





            transaction.Commit() |> ignore


            printfn "quads=%i index_entries=%i elapsed=%O" quads.Length written stopwatch.Elapsed

            stopwatch.Stop()

    module Delete =

        let Quad (quad: Quad) =
            use transaction = environment.BeginTransaction()

            for permutation in Quad_Permutation.permutation_profile do
                let permutation_key = Permutation_Key.from_quad permutation quad

                transaction.Delete(permutation.permutation_map.handle, permutation_key)
                |> MDBResultCode.fail_if_not_success $"Delete quad permutation {permutation.permutation_map}"

            transaction.Commit() |> ignore

        let Quads (quads: Quad array) =
            use transaction = environment.BeginTransaction()

            for quad in quads do
                for permutation in Quad_Permutation.permutation_profile do
                    let permutation_key = Permutation_Key.from_quad permutation quad

                    transaction.Delete(permutation.permutation_map.handle, permutation_key)
                    |> MDBResultCode.fail_if_not_success $"Delete quad permutation {permutation.permutation_map}"

            transaction.Commit() |> ignore

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

    module Backfill =

        let private permutation_has_any_keys (permutation: Quad_Permutation) =
            use transaction = environment.BeginTransaction(TransactionBeginFlags.ReadOnly)

            use cursor = transaction.CreateCursor(permutation.permutation_map.handle)

            let struct (result, _, _) = cursor.First()

            result = MDBResultCode.Success


        let private backfill_permutation_from_spoc (target_permutation: Quad_Permutation) =
            let stopwatch = Stopwatch.StartNew()
            let presence_value = [| 1uy |]
            let mutable read_count = 0L
            let mutable written_count = 0L

            let source_count = Count.Keys Quad_Permutation.spoc.permutation_map

            let progress_interval = 100_000L

            printfn "backfill start target=%A source_count=%i" target_permutation.permutation_map source_count

            Console.Out.Flush()

            use transaction = environment.BeginTransaction()

            use cursor = transaction.CreateCursor(Quad_Permutation.spoc.permutation_map.handle)

            let struct (first_result, _, _) = cursor.First()

            let mutable keep_reading = first_result = MDBResultCode.Success

            while keep_reading do
                let struct (current_result, source_key, _) = cursor.GetCurrent()

                if current_result = MDBResultCode.Success then
                    let source_key_bytes = source_key.CopyToNewArray()

                    let quad = Permutation_Key.to_quad Quad_Permutation.spoc source_key_bytes

                    let target_key = Permutation_Key.from_quad target_permutation quad

                    transaction.Put(target_permutation.permutation_map.handle, target_key, presence_value)
                    |> MDBResultCode.fail_if_not_success $"Backfill {target_permutation.permutation_map}"

                    read_count <- read_count + 1L
                    written_count <- written_count + 1L

                    if read_count % progress_interval = 0L then
                        let elapsed = stopwatch.Elapsed

                        let rate = float read_count / elapsed.TotalSeconds

                        let percent =
                            if source_count = 0L then
                                100.0
                            else
                                (float read_count / float source_count) * 100.0

                        printfn
                            "backfill progress target=%A read=%i/%i written=%i elapsed=%O rate=%.0f keys/sec %.2f%%"
                            target_permutation.permutation_map
                            read_count
                            source_count
                            written_count
                            elapsed
                            rate
                            percent

                        Console.Out.Flush()

                    let struct (next_result, _, _) = cursor.Next()

                    keep_reading <- next_result = MDBResultCode.Success
                else
                    keep_reading <- false

            transaction.Commit()
            |> MDBResultCode.fail_if_not_success $"Commit backfill {target_permutation.permutation_map}"

            stopwatch.Stop()

            printfn
                "backfill complete target=%A read=%i written=%i elapsed=%O"
                target_permutation.permutation_map
                read_count
                written_count
                stopwatch.Elapsed

            Console.Out.Flush()

        let Profile () =
            for permutation in Quad_Permutation.permutation_profile do

                if permutation.permutation_map
                   <> Quad_Permutation.spoc.permutation_map then

                    let has_any_keys = permutation_has_any_keys permutation

                    if not has_any_keys then
                        printfn "permutation %A is empty; backfilling from SPOC" permutation.permutation_map

                        backfill_permutation_from_spoc permutation
                    else
                        printfn "permutation %A already has keys; skipping backfill" permutation.permutation_map

        let DeepProfile () =
            let source_count = Count.Keys Quad_Permutation.spoc.permutation_map

            printfn "canonical SPOC count=%i" source_count
            Console.Out.Flush()

            for permutation in Quad_Permutation.permutation_profile do

                if permutation.permutation_map
                   <> Quad_Permutation.spoc.permutation_map then

                    let target_count = Count.Keys permutation.permutation_map

                    if target_count = source_count then
                        printfn "permutation %A complete count=%i; skipping" permutation.permutation_map target_count

                        Console.Out.Flush()

                    elif target_count = 0L then
                        printfn "permutation %A empty; backfilling from SPOC" permutation.permutation_map

                        Console.Out.Flush()

                        backfill_permutation_from_spoc permutation

                    else
                        failwithf
                            "permutation %A is partially populated: target_count=%i source_count=%i. Clear/rebuild this permutation before continuing."
                            permutation.permutation_map
                            target_count
                            source_count

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

    module Exists =

        let Quad (quad: Quad) =
            let key = Permutation_Key.from_quad Quad_Permutation.spoc quad

            Get.Value_by_Persistent_Map Persistent_Map.SPOC key
            |> Option.isSome


    module Validate =

        let Quad_Permutation_Presence (quad: Quad) =
            Quad_Permutation.permutation_profile
            |> Array.map (fun permutation ->
                let key = Permutation_Key.from_quad permutation quad

                let exists =
                    Get.Value_by_Persistent_Map permutation.permutation_map key
                    |> Option.isSome

                permutation.permutation_map, exists)




module Lexical_Form =

    let string_from_form_id form_id =
        Database.Get.Value_by_Persistent_Map Persistent_Map.Form_ID_to_Encoding form_id
        |> Option.get
        |> String.from_encoding




module Transient_Term =
    let from_id (term_id: byte array) =
        { persistent_term =
            Database.Get.Value_by_Persistent_Map Persistent_Map.Term_ID_to_Term term_id
            |> Option.get
            |> Persistent_Term.from_encoding
          term_id = term_id }

    let lexical_form_string transient_term =
        transient_term.persistent_term
        |> Persistent_Term.lexical_form_id
        |> Lexical_Form.string_from_form_id

    let lexical_form_string_from_id term_id =
        Database.Get.Value_by_Persistent_Map Persistent_Map.Term_ID_to_Term term_id
        |> Option.get
        |> Persistent_Term.from_encoding
        |> Persistent_Term.lexical_form_id
        |> Lexical_Form.string_from_form_id

    let print (transient_term: Transient_Term) =
        sprintf "%s" (lexical_form_string transient_term)


fsi.AddPrinter<Transient_Term>(fun transient_term -> sprintf "%s" (Transient_Term.lexical_form_string transient_term))

















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




let simple_literal_terms_from_lexical_forms (lexical_forms: Lexical_Form array) =
    lexical_forms
    |> Array.map (fun simple_literal_form -> SimpleLiteral simple_literal_form.form_id)

let simple_literal (literal_form: string) =
    Database.Get.Lexical_Forms_from_Strings [| literal_form |]
    |> simple_literal_terms_from_lexical_forms
    |> Database.Get.Transient_Terms_From_Persistent_Terms
    |> simple_literal_term_by_string literal_form


module Assert =
    let spoc
        (curSubject: Transient_Term)
        (curPredicate: Transient_Term)
        (curObject: Transient_Term)
        (curContext: Transient_Term)
        =

        Database.Put.Quads [| Quad.spoc curSubject curPredicate curObject curContext |]

    let Quads quads = Database.Put.Quads quads

type Quad_Pattern =
    { ground_subject: byte array option
      ground_predicate: byte array option
      ground_object: byte array option
      ground_context: byte array option }


module Quad_Pattern =
    let print (quad_pattern: Quad_Pattern) =
        let s =
            match quad_pattern.ground_subject with
            | Some _ -> "s"
            | None -> "_"

        let p =
            match quad_pattern.ground_predicate with
            | Some _ -> "p"
            | None -> "_"

        let o =
            match quad_pattern.ground_object with
            | Some _ -> "o"
            | None -> "_"

        let c =
            match quad_pattern.ground_context with
            | Some _ -> "c"
            | None -> "_"

        $"{s}{p}{o}{c}"


    let bound_slot pattern slot =
        match slot with
        | S -> pattern.ground_subject
        | P -> pattern.ground_predicate
        | O -> pattern.ground_object
        | C -> pattern.ground_context

    let grounded_slots_in_canonical_order pattern =
        [| S; P; O; C |]
        |> Array.filter (fun slot -> bound_slot pattern slot |> Option.isSome)

    (*
    let permutation_covers_pattern pattern permutation =
        let grounded = grounded_slots_in_canonical_order pattern

        let prefix = permutation.order |> Array.take grounded.Length

        prefix = grounded
    let choose_permutation pattern =
        Quad_Permutation.permutation_profile
        |> Array.find (fun permutation -> permutation_covers_pattern pattern permutation)
*)
    let permutation_covers_pattern pattern permutation =
        let grounded = grounded_slots_in_canonical_order pattern

        let candidate_prefix = permutation.order |> Array.take grounded.Length

        grounded
        |> Array.forall (fun grounded_slot -> candidate_prefix |> Array.contains grounded_slot)

    let choose_permutation pattern =
        Quad_Permutation.permutation_profile
        |> Array.tryFind (fun permutation -> permutation_covers_pattern pattern permutation)

    let permutation_prefix pattern permutation =
        permutation.order
        |> Array.takeWhile (fun slot -> bound_slot pattern slot |> Option.isSome)
        |> Array.map (fun slot -> bound_slot pattern slot |> Option.get)
        |> Array.collect id

module Query =

    let quads_by_pattern pattern =
        let permutation =
            match Quad_Pattern.choose_permutation pattern with
            | Some permutation -> permutation
            | _ -> failwith $"No permutation in active profile covers pattern {Quad_Pattern.print pattern}."

        let prefix = Quad_Pattern.permutation_prefix pattern permutation

        Database.Get.Keys_by_Persistent_Map_Prefix permutation.permutation_map prefix
        |> Array.map (fun permutation_key -> Permutation_Key.to_quad permutation permutation_key)

    let terms_for_slot slot pattern =
        quads_by_pattern pattern
        |> Array.map (fun quad ->
            Quad.slot_value slot quad
            |> Transient_Term.from_id)

    // ------------------------------------------------------------
    // 0 FREE VARIABLES
    // ------------------------------------------------------------

    let spoc subject predicate object context =
        { ground_subject = Some subject.term_id
          ground_predicate = Some predicate.term_id
          ground_object = Some object.term_id
          ground_context = Some context.term_id }
        |> quads_by_pattern


    // ------------------------------------------------------------
    // 1 FREE VARIABLE
    // ------------------------------------------------------------

    let _poc predicate object context =
        { ground_subject = None
          ground_predicate = Some predicate.term_id
          ground_object = Some object.term_id
          ground_context = Some context.term_id }
        |> terms_for_slot S

    let s_oc subject object context =
        { ground_subject = Some subject.term_id
          ground_predicate = None
          ground_object = Some object.term_id
          ground_context = Some context.term_id }
        |> terms_for_slot P

    let sp_c subject predicate context =
        { ground_subject = Some subject.term_id
          ground_predicate = Some predicate.term_id
          ground_object = None
          ground_context = Some context.term_id }
        |> terms_for_slot O

    let spo_ subject predicate object =
        { ground_subject = Some subject.term_id
          ground_predicate = Some predicate.term_id
          ground_object = Some object.term_id
          ground_context = None }
        |> terms_for_slot C


    // ------------------------------------------------------------
    // 2 FREE VARIABLES
    // ------------------------------------------------------------

    let __oc object context =
        { ground_subject = None
          ground_predicate = None
          ground_object = Some object.term_id
          ground_context = Some context.term_id }
        |> quads_by_pattern
        |> Array.map (fun quad -> Transient_Term.from_id quad.subject_id, Transient_Term.from_id quad.predicate_id)

    let _p_c predicate context =
        { ground_subject = None
          ground_predicate = Some predicate.term_id
          ground_object = None
          ground_context = Some context.term_id }
        |> quads_by_pattern
        |> Array.map (fun quad -> Transient_Term.from_id quad.subject_id, Transient_Term.from_id quad.object_id)

    let _po_ predicate object =
        { ground_subject = None
          ground_predicate = Some predicate.term_id
          ground_object = Some object.term_id
          ground_context = None }
        |> quads_by_pattern
        |> Array.map (fun quad -> Transient_Term.from_id quad.subject_id, Transient_Term.from_id quad.context_id)

    let s__c subject context =
        { ground_subject = Some subject.term_id
          ground_predicate = None
          ground_object = None
          ground_context = Some context.term_id }
        |> quads_by_pattern
        |> Array.map (fun quad -> Transient_Term.from_id quad.predicate_id, Transient_Term.from_id quad.object_id)

    let s_o_ subject object =
        { ground_subject = Some subject.term_id
          ground_predicate = None
          ground_object = Some object.term_id
          ground_context = None }
        |> quads_by_pattern
        |> Array.map (fun quad -> Transient_Term.from_id quad.predicate_id, Transient_Term.from_id quad.context_id)

    let sp__ subject predicate =
        { ground_subject = Some subject.term_id
          ground_predicate = Some predicate.term_id
          ground_object = None
          ground_context = None }
        |> quads_by_pattern
        |> Array.map (fun quad -> Transient_Term.from_id quad.object_id, Transient_Term.from_id quad.context_id)


    // ------------------------------------------------------------
    // 3 FREE VARIABLES
    // ------------------------------------------------------------

    let ___c context =
        { ground_subject = None
          ground_predicate = None
          ground_object = None
          ground_context = Some context.term_id }
        |> quads_by_pattern
        |> Array.map (fun quad ->
            Transient_Term.from_id quad.subject_id,
            Transient_Term.from_id quad.predicate_id,
            Transient_Term.from_id quad.object_id)

    let __o_ object =
        { ground_subject = None
          ground_predicate = None
          ground_object = Some object.term_id
          ground_context = None }
        |> quads_by_pattern
        |> Array.map (fun quad ->
            Transient_Term.from_id quad.subject_id,
            Transient_Term.from_id quad.predicate_id,
            Transient_Term.from_id quad.context_id)

    let _p__ predicate =
        { ground_subject = None
          ground_predicate = Some predicate.term_id
          ground_object = None
          ground_context = None }
        |> quads_by_pattern
        |> Array.map (fun quad ->
            Transient_Term.from_id quad.subject_id,
            Transient_Term.from_id quad.object_id,
            Transient_Term.from_id quad.context_id)

    let s___ subject =
        { ground_subject = Some subject.term_id
          ground_predicate = None
          ground_object = None
          ground_context = None }
        |> quads_by_pattern
        |> Array.map (fun quad ->
            Transient_Term.from_id quad.predicate_id,
            Transient_Term.from_id quad.object_id,
            Transient_Term.from_id quad.context_id)


    // ------------------------------------------------------------
    // 4 FREE VARIABLES
    // ------------------------------------------------------------

    let ____ () =
        { ground_subject = None
          ground_predicate = None
          ground_object = None
          ground_context = None }
        |> quads_by_pattern

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
|> Array.map Transient_Term.lexical_form_string

let results = Query._p__ name

results
|> Array.map (fun (s, o, c) ->
    sprintf
        "%s %s %s %s"
        (Transient_Term.lexical_form_string s)
        (Transient_Term.lexical_form_string name)
        (Transient_Term.lexical_form_string o)
        (Transient_Term.lexical_form_string c))


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
