namespace http.sparql.cwrc.ca.ontologies.cwrc.hash

open DoxAletheia.Rdf_Vocabulary

module cwrc =
    let _namespace_name = "http://sparql.cwrc.ca/ontologies/cwrc#"

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#originalOrlandoAuthor"></see>
    /// </summary>
    let originalOrlandoAuthor =
        Namespaced_IRI.parse _namespace_name "originalOrlandoAuthor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ConstanceCrompton"></see>
    /// </summary>
    let ConstanceCrompton =
        Namespaced_IRI.parse _namespace_name "ConstanceCrompton" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sshrc"></see>
    /// </summary>
    let sshrc = Namespaced_IRI.parse _namespace_name "sshrc" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SusanBrown"></see>
    /// </summary>
    let SusanBrown = Namespaced_IRI.parse _namespace_name "SusanBrown" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ColinFaulkner"></see>
    /// </summary>
    let ColinFaulkner =
        Namespaced_IRI.parse _namespace_name "ColinFaulkner" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#KimMartin"></see>
    /// </summary>
    let KimMartin = Namespaced_IRI.parse _namespace_name "KimMartin" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#JohnSimpson"></see>
    /// </summary>
    let JohnSimpson =
        Namespaced_IRI.parse _namespace_name "JohnSimpson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#DebStacey"></see>
    /// </summary>
    let DebStacey = Namespaced_IRI.parse _namespace_name "DebStacey" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#JoelCummings"></see>
    /// </summary>
    let JoelCummings =
        Namespaced_IRI.parse _namespace_name "JoelCummings" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#AlliyyaMo"></see>
    /// </summary>
    let AlliyyaMo = Namespaced_IRI.parse _namespace_name "AlliyyaMo" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#JasmineDrudgeWillson"></see>
    /// </summary>
    let JasmineDrudgeWillson =
        Namespaced_IRI.parse _namespace_name "JasmineDrudgeWillson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#JadePenancier"></see>
    /// </summary>
    let JadePenancier =
        Namespaced_IRI.parse _namespace_name "JadePenancier" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#RobWarren"></see>
    /// </summary>
    let RobWarren = Namespaced_IRI.parse _namespace_name "RobWarren" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#AbigelLemak"></see>
    /// </summary>
    let AbigelLemak =
        Namespaced_IRI.parse _namespace_name "AbigelLemak" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#GurjapSingh"></see>
    /// </summary>
    let GurjapSingh =
        Namespaced_IRI.parse _namespace_name "GurjapSingh" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cwrc"></see>
    /// </summary>
    let cwrc = Namespaced_IRI.parse _namespace_name "cwrc" |> NamespacedName

    /// <summary>
    /// The CWRC Ontology is the ontology of the Canadian Writing Research Collaboratory.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#datasetdefinition"></see></summary>
    let datasetdefinition =
        Namespaced_IRI.parse _namespace_name "datasetdefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646"></see>
    /// </summary>
    let ``_04b840aa-9c38-4e36-8d7c-21b38e192646`` =
        Namespaced_IRI.parse _namespace_name "04b840aa-9c38-4e36-8d7c-21b38e192646" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2"></see>
    /// </summary>
    let ``_04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2`` =
        Namespaced_IRI.parse _namespace_name "04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76"></see>
    /// </summary>
    let ``_04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76`` =
        Namespaced_IRI.parse _namespace_name "04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2"></see>
    /// </summary>
    let ``_04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2`` =
        Namespaced_IRI.parse _namespace_name "04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a"></see>
    /// </summary>
    let ``_06e019b1-2bad-4fc2-8666-6f374a2e246a`` =
        Namespaced_IRI.parse _namespace_name "06e019b1-2bad-4fc2-8666-6f374a2e246a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8"></see>
    /// </summary>
    let ``_06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8`` =
        Namespaced_IRI.parse _namespace_name "06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a-partof"></see>
    /// </summary>
    let ``_06e019b1-2bad-4fc2-8666-6f374a2e246a-partof`` =
        Namespaced_IRI.parse _namespace_name "06e019b1-2bad-4fc2-8666-6f374a2e246a-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9"></see>
    /// </summary>
    let ``_2002eb96-4775-4ae0-ba0f-6704c30264a9`` =
        Namespaced_IRI.parse _namespace_name "2002eb96-4775-4ae0-ba0f-6704c30264a9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881"></see>
    /// </summary>
    let ``_2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881`` =
        Namespaced_IRI.parse _namespace_name "2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063"></see>
    /// </summary>
    let ``_2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063`` =
        Namespaced_IRI.parse _namespace_name "2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f"></see>
    /// </summary>
    let ``_20b2549d-ee16-45e2-8f42-5e369da2ae0f`` =
        Namespaced_IRI.parse _namespace_name "20b2549d-ee16-45e2-8f42-5e369da2ae0f" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096"></see>
    /// </summary>
    let ``_20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096`` =
        Namespaced_IRI.parse _namespace_name "20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211"></see>
    /// </summary>
    let ``_20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211`` =
        Namespaced_IRI.parse _namespace_name "20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b"></see>
    /// </summary>
    let ``_20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b`` =
        Namespaced_IRI.parse _namespace_name "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691"></see>
    /// </summary>
    let ``_20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691`` =
        Namespaced_IRI.parse _namespace_name "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942"></see>
    /// </summary>
    let ``_20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942`` =
        Namespaced_IRI.parse _namespace_name "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8"></see>
    /// </summary>
    let ``_21bad544-af11-4b8d-869f-2d26f53943c8`` =
        Namespaced_IRI.parse _namespace_name "21bad544-af11-4b8d-869f-2d26f53943c8" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8-027917040a"></see>
    /// </summary>
    let ``_21bad544-af11-4b8d-869f-2d26f53943c8-027917040a`` =
        Namespaced_IRI.parse _namespace_name "21bad544-af11-4b8d-869f-2d26f53943c8-027917040a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8-partof"></see>
    /// </summary>
    let ``_21bad544-af11-4b8d-869f-2d26f53943c8-partof`` =
        Namespaced_IRI.parse _namespace_name "21bad544-af11-4b8d-869f-2d26f53943c8-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58"></see>
    /// </summary>
    let ``_2237f8bc-6be9-44b5-8fe9-f531c6a44a58`` =
        Namespaced_IRI.parse _namespace_name "2237f8bc-6be9-44b5-8fe9-f531c6a44a58" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55"></see>
    /// </summary>
    let ``_2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55`` =
        Namespaced_IRI.parse _namespace_name "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf"></see>
    /// </summary>
    let ``_2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf`` =
        Namespaced_IRI.parse _namespace_name "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8"></see>
    /// </summary>
    let ``_2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8`` =
        Namespaced_IRI.parse _namespace_name "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea"></see>
    /// </summary>
    let ``_23ad5d2a-605e-4116-8f81-7db6b95395ea`` =
        Namespaced_IRI.parse _namespace_name "23ad5d2a-605e-4116-8f81-7db6b95395ea" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9"></see>
    /// </summary>
    let ``_23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9`` =
        Namespaced_IRI.parse _namespace_name "23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2"></see>
    /// </summary>
    let ``_23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2`` =
        Namespaced_IRI.parse _namespace_name "23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96"></see>
    /// </summary>
    let ``_23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96`` =
        Namespaced_IRI.parse _namespace_name "23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6"></see>
    /// </summary>
    let ``_26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6`` =
        Namespaced_IRI.parse _namespace_name "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47"></see>
    /// </summary>
    let ``_26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47`` =
        Namespaced_IRI.parse _namespace_name "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof"></see>
    /// </summary>
    let ``_26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof`` =
        Namespaced_IRI.parse _namespace_name "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373"></see>
    /// </summary>
    let ``_26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373`` =
        Namespaced_IRI.parse _namespace_name "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef"></see>
    /// </summary>
    let ``_26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef`` =
        Namespaced_IRI.parse _namespace_name "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4"></see>
    /// </summary>
    let ``_26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4`` =
        Namespaced_IRI.parse _namespace_name "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9"></see>
    /// </summary>
    let ``_26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9`` =
        Namespaced_IRI.parse _namespace_name "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb"></see>
    /// </summary>
    let ``_26cf15ba-5650-43ef-9a55-229c7ce3bbbb`` =
        Namespaced_IRI.parse _namespace_name "26cf15ba-5650-43ef-9a55-229c7ce3bbbb" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9"></see>
    /// </summary>
    let ``_26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9`` =
        Namespaced_IRI.parse _namespace_name "26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52"></see>
    /// </summary>
    let ``_26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52`` =
        Namespaced_IRI.parse _namespace_name "26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9"></see>
    /// </summary>
    let ``_27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9`` =
        Namespaced_IRI.parse _namespace_name "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76"></see>
    /// </summary>
    let ``_27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76`` =
        Namespaced_IRI.parse _namespace_name "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571"></see>
    /// </summary>
    let ``_27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571`` =
        Namespaced_IRI.parse _namespace_name "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc"></see>
    /// </summary>
    let ``_3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc`` =
        Namespaced_IRI.parse _namespace_name "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976"></see>
    /// </summary>
    let ``_3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976`` =
        Namespaced_IRI.parse _namespace_name "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f"></see>
    /// </summary>
    let ``_3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f`` =
        Namespaced_IRI.parse _namespace_name "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb"></see>
    /// </summary>
    let ``_366c694c-b5bd-47b4-80a9-2dead4f7a7cb`` =
        Namespaced_IRI.parse _namespace_name "366c694c-b5bd-47b4-80a9-2dead4f7a7cb" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236"></see>
    /// </summary>
    let ``_366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236`` =
        Namespaced_IRI.parse _namespace_name "366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3"></see>
    /// </summary>
    let ``_366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3`` =
        Namespaced_IRI.parse _namespace_name "366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf"></see>
    /// </summary>
    let ``_3d49dc32-ac97-4abd-a252-573c52b463cf`` =
        Namespaced_IRI.parse _namespace_name "3d49dc32-ac97-4abd-a252-573c52b463cf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034"></see>
    /// </summary>
    let ``_3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034`` =
        Namespaced_IRI.parse _namespace_name "3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83"></see>
    /// </summary>
    let ``_3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83`` =
        Namespaced_IRI.parse _namespace_name "3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174"></see>
    /// </summary>
    let ``_3f1dd1b1-411b-45a9-a860-7b45bf0a1174`` =
        Namespaced_IRI.parse _namespace_name "3f1dd1b1-411b-45a9-a860-7b45bf0a1174" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de"></see>
    /// </summary>
    let ``_3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de`` =
        Namespaced_IRI.parse _namespace_name "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4"></see>
    /// </summary>
    let ``_3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4`` =
        Namespaced_IRI.parse _namespace_name "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e"></see>
    /// </summary>
    let ``_3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e`` =
        Namespaced_IRI.parse _namespace_name "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123"></see>
    /// </summary>
    let ``_40523fef-509d-4802-900d-4f230fe50123`` =
        Namespaced_IRI.parse _namespace_name "40523fef-509d-4802-900d-4f230fe50123" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3"></see>
    /// </summary>
    let ``_40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3`` =
        Namespaced_IRI.parse _namespace_name "40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123-769103a942"></see>
    /// </summary>
    let ``_40523fef-509d-4802-900d-4f230fe50123-769103a942`` =
        Namespaced_IRI.parse _namespace_name "40523fef-509d-4802-900d-4f230fe50123-769103a942" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67"></see>
    /// </summary>
    let ``_4dc5ff8c-d908-4377-bca8-9394408b7b67`` =
        Namespaced_IRI.parse _namespace_name "4dc5ff8c-d908-4377-bca8-9394408b7b67" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164"></see>
    /// </summary>
    let ``_4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164`` =
        Namespaced_IRI.parse _namespace_name "4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67-partof"></see>
    /// </summary>
    let ``_4dc5ff8c-d908-4377-bca8-9394408b7b67-partof`` =
        Namespaced_IRI.parse _namespace_name "4dc5ff8c-d908-4377-bca8-9394408b7b67-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8"></see>
    /// </summary>
    let ``_4f4d7ca6-5625-46d9-bd88-17847ee076d8`` =
        Namespaced_IRI.parse _namespace_name "4f4d7ca6-5625-46d9-bd88-17847ee076d8" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465"></see>
    /// </summary>
    let ``_4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465`` =
        Namespaced_IRI.parse _namespace_name "4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9"></see>
    /// </summary>
    let ``_4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9`` =
        Namespaced_IRI.parse _namespace_name "4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec"></see>
    /// </summary>
    let ``_59f48ef6-ebc7-4a58-ac43-2025deb369ec`` =
        Namespaced_IRI.parse _namespace_name "59f48ef6-ebc7-4a58-ac43-2025deb369ec" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd"></see>
    /// </summary>
    let ``_59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd`` =
        Namespaced_IRI.parse _namespace_name "59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof"></see>
    /// </summary>
    let ``_59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof`` =
        Namespaced_IRI.parse _namespace_name "59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28"></see>
    /// </summary>
    let ``_5e3f3ab7-be20-4dc5-91ec-f41946e05e28`` =
        Namespaced_IRI.parse _namespace_name "5e3f3ab7-be20-4dc5-91ec-f41946e05e28" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b"></see>
    /// </summary>
    let ``_5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b`` =
        Namespaced_IRI.parse _namespace_name "5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9"></see>
    /// </summary>
    let ``_5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9`` =
        Namespaced_IRI.parse _namespace_name "5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249"></see>
    /// </summary>
    let ``_5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249`` =
        Namespaced_IRI.parse _namespace_name "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3"></see>
    /// </summary>
    let ``_5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3`` =
        Namespaced_IRI.parse _namespace_name "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7"></see>
    /// </summary>
    let ``_5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7`` =
        Namespaced_IRI.parse _namespace_name "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc"></see>
    /// </summary>
    let ``_62208dcb-ed1f-4612-8433-d6e4e5e0b7fc`` =
        Namespaced_IRI.parse _namespace_name "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4"></see>
    /// </summary>
    let ``_62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4`` =
        Namespaced_IRI.parse _namespace_name "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c"></see>
    /// </summary>
    let ``_62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c`` =
        Namespaced_IRI.parse _namespace_name "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof"></see>
    /// </summary>
    let ``_62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof`` =
        Namespaced_IRI.parse _namespace_name "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814"></see>
    /// </summary>
    let ``_62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814`` =
        Namespaced_IRI.parse _namespace_name "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea"></see>
    /// </summary>
    let ``_65424c4e-5257-4e6c-962f-de12a7f11aea`` =
        Namespaced_IRI.parse _namespace_name "65424c4e-5257-4e6c-962f-de12a7f11aea" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9"></see>
    /// </summary>
    let ``_65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof"></see>
    /// </summary>
    let ``_65424c4e-5257-4e6c-962f-de12a7f11aea-partof`` =
        Namespaced_IRI.parse _namespace_name "65424c4e-5257-4e6c-962f-de12a7f11aea-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9"></see>
    /// </summary>
    let ``_65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456"></see>
    /// </summary>
    let ``_65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456`` =
        Namespaced_IRI.parse _namespace_name "65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6"></see>
    /// </summary>
    let ``_6addf580-24e2-4750-9d2a-aa6dd66032a6`` =
        Namespaced_IRI.parse _namespace_name "6addf580-24e2-4750-9d2a-aa6dd66032a6" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9"></see>
    /// </summary>
    let ``_6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6-partof"></see>
    /// </summary>
    let ``_6addf580-24e2-4750-9d2a-aa6dd66032a6-partof`` =
        Namespaced_IRI.parse _namespace_name "6addf580-24e2-4750-9d2a-aa6dd66032a6-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119"></see>
    /// </summary>
    let ``_713873c7-011a-4b34-b5dc-d6d147575119`` =
        Namespaced_IRI.parse _namespace_name "713873c7-011a-4b34-b5dc-d6d147575119" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7"></see>
    /// </summary>
    let ``_713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7`` =
        Namespaced_IRI.parse _namespace_name "713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119-partof"></see>
    /// </summary>
    let ``_713873c7-011a-4b34-b5dc-d6d147575119-partof`` =
        Namespaced_IRI.parse _namespace_name "713873c7-011a-4b34-b5dc-d6d147575119-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#727d97bc-af78-4122-94be-aa78b2e97d5a"></see>
    /// </summary>
    let ``_727d97bc-af78-4122-94be-aa78b2e97d5a`` =
        Namespaced_IRI.parse _namespace_name "727d97bc-af78-4122-94be-aa78b2e97d5a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c"></see>
    /// </summary>
    let ``_727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c`` =
        Namespaced_IRI.parse _namespace_name "727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1"></see>
    /// </summary>
    let ``_72ce1f91-b3d5-4b7b-8b76-dc674513bec1`` =
        Namespaced_IRI.parse _namespace_name "72ce1f91-b3d5-4b7b-8b76-dc674513bec1" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e"></see>
    /// </summary>
    let ``_72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e`` =
        Namespaced_IRI.parse _namespace_name "72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826"></see>
    /// </summary>
    let ``_72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826`` =
        Namespaced_IRI.parse _namespace_name "72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#734cd035-459b-407e-8a08-b68cd2bb743a"></see>
    /// </summary>
    let ``_734cd035-459b-407e-8a08-b68cd2bb743a`` =
        Namespaced_IRI.parse _namespace_name "734cd035-459b-407e-8a08-b68cd2bb743a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c"></see>
    /// </summary>
    let ``_734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c`` =
        Namespaced_IRI.parse _namespace_name "734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6"></see>
    /// </summary>
    let ``_75660bb0-b804-428e-8efb-c139bc7a63d6`` =
        Namespaced_IRI.parse _namespace_name "75660bb0-b804-428e-8efb-c139bc7a63d6" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5"></see>
    /// </summary>
    let ``_75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5`` =
        Namespaced_IRI.parse _namespace_name "75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b"></see>
    /// </summary>
    let ``_75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b`` =
        Namespaced_IRI.parse _namespace_name "75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-partof"></see>
    /// </summary>
    let ``_75660bb0-b804-428e-8efb-c139bc7a63d6-partof`` =
        Namespaced_IRI.parse _namespace_name "75660bb0-b804-428e-8efb-c139bc7a63d6-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8"></see>
    /// </summary>
    let ``_772b1b45-8046-46b0-a746-bbdc8849a6c8`` =
        Namespaced_IRI.parse _namespace_name "772b1b45-8046-46b0-a746-bbdc8849a6c8" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94"></see>
    /// </summary>
    let ``_772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94`` =
        Namespaced_IRI.parse _namespace_name "772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4"></see>
    /// </summary>
    let ``_772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4`` =
        Namespaced_IRI.parse _namespace_name "772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf"></see>
    /// </summary>
    let ``_772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf`` =
        Namespaced_IRI.parse _namespace_name "772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db"></see>
    /// </summary>
    let ``_772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db`` =
        Namespaced_IRI.parse _namespace_name "772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950"></see>
    /// </summary>
    let ``_772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950`` =
        Namespaced_IRI.parse _namespace_name "772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-partof"></see>
    /// </summary>
    let ``_772b1b45-8046-46b0-a746-bbdc8849a6c8-partof`` =
        Namespaced_IRI.parse _namespace_name "772b1b45-8046-46b0-a746-bbdc8849a6c8-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca"></see>
    /// </summary>
    let ``_775357d1-e547-4674-9467-50b0308354ca`` =
        Namespaced_IRI.parse _namespace_name "775357d1-e547-4674-9467-50b0308354ca" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db"></see>
    /// </summary>
    let ``_775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db`` =
        Namespaced_IRI.parse _namespace_name "775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-42d9d30d94"></see>
    /// </summary>
    let ``_775357d1-e547-4674-9467-50b0308354ca-42d9d30d94`` =
        Namespaced_IRI.parse _namespace_name "775357d1-e547-4674-9467-50b0308354ca-42d9d30d94" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-706552b3f4"></see>
    /// </summary>
    let ``_775357d1-e547-4674-9467-50b0308354ca-706552b3f4`` =
        Namespaced_IRI.parse _namespace_name "775357d1-e547-4674-9467-50b0308354ca-706552b3f4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf"></see>
    /// </summary>
    let ``_775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf`` =
        Namespaced_IRI.parse _namespace_name "775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-ab964c6950"></see>
    /// </summary>
    let ``_775357d1-e547-4674-9467-50b0308354ca-ab964c6950`` =
        Namespaced_IRI.parse _namespace_name "775357d1-e547-4674-9467-50b0308354ca-ab964c6950" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-partof"></see>
    /// </summary>
    let ``_775357d1-e547-4674-9467-50b0308354ca-partof`` =
        Namespaced_IRI.parse _namespace_name "775357d1-e547-4674-9467-50b0308354ca-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7b624412-74a3-4560-a038-d59b747ee9c7"></see>
    /// </summary>
    let ``_7b624412-74a3-4560-a038-d59b747ee9c7`` =
        Namespaced_IRI.parse _namespace_name "7b624412-74a3-4560-a038-d59b747ee9c7" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7b624412-74a3-4560-a038-d59b747ee9c7-partof"></see>
    /// </summary>
    let ``_7b624412-74a3-4560-a038-d59b747ee9c7-partof`` =
        Namespaced_IRI.parse _namespace_name "7b624412-74a3-4560-a038-d59b747ee9c7-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7c123714-5956-4ce5-bf15-39f3f7c5deed"></see>
    /// </summary>
    let ``_7c123714-5956-4ce5-bf15-39f3f7c5deed`` =
        Namespaced_IRI.parse _namespace_name "7c123714-5956-4ce5-bf15-39f3f7c5deed" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6"></see>
    /// </summary>
    let ``_7d891586-52df-49f4-9cef-77e26f1a0ed6`` =
        Namespaced_IRI.parse _namespace_name "7d891586-52df-49f4-9cef-77e26f1a0ed6" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a"></see>
    /// </summary>
    let ``_7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a`` =
        Namespaced_IRI.parse _namespace_name "7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4"></see>
    /// </summary>
    let ``_7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4`` =
        Namespaced_IRI.parse _namespace_name "7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab"></see>
    /// </summary>
    let ``_7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab`` =
        Namespaced_IRI.parse _namespace_name "7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227"></see>
    /// </summary>
    let ``_7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227`` =
        Namespaced_IRI.parse _namespace_name "7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-partof"></see>
    /// </summary>
    let ``_7d891586-52df-49f4-9cef-77e26f1a0ed6-partof`` =
        Namespaced_IRI.parse _namespace_name "7d891586-52df-49f4-9cef-77e26f1a0ed6-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e"></see>
    /// </summary>
    let ``_7faf2c87-1064-43d7-81b9-90f16068587e`` =
        Namespaced_IRI.parse _namespace_name "7faf2c87-1064-43d7-81b9-90f16068587e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e"></see>
    /// </summary>
    let ``_7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e`` =
        Namespaced_IRI.parse _namespace_name "7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd"></see>
    /// </summary>
    let ``_7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd`` =
        Namespaced_IRI.parse _namespace_name "7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd"></see>
    /// </summary>
    let ``_7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd`` =
        Namespaced_IRI.parse _namespace_name "7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21"></see>
    /// </summary>
    let ``_7fb45454-7271-48b3-bd57-7a2b4572fc21`` =
        Namespaced_IRI.parse _namespace_name "7fb45454-7271-48b3-bd57-7a2b4572fc21" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532"></see>
    /// </summary>
    let ``_7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532`` =
        Namespaced_IRI.parse _namespace_name "7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9"></see>
    /// </summary>
    let ``_7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466"></see>
    /// </summary>
    let ``_8049540f-3673-4ca0-920c-cb5326d7c466`` =
        Namespaced_IRI.parse _namespace_name "8049540f-3673-4ca0-920c-cb5326d7c466" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9"></see>
    /// </summary>
    let ``_8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443"></see>
    /// </summary>
    let ``_8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443`` =
        Namespaced_IRI.parse _namespace_name "8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78"></see>
    /// </summary>
    let ``_825995b3-3b66-4e0a-a62d-d8649aaead78`` =
        Namespaced_IRI.parse _namespace_name "825995b3-3b66-4e0a-a62d-d8649aaead78" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c"></see>
    /// </summary>
    let ``_825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c`` =
        Namespaced_IRI.parse _namespace_name "825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9"></see>
    /// </summary>
    let ``_825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9`` =
        Namespaced_IRI.parse _namespace_name "825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5"></see>
    /// </summary>
    let ``_842ffbb4-11de-4212-8e6e-9d4d8d28d3a5`` =
        Namespaced_IRI.parse _namespace_name "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9"></see>
    /// </summary>
    let ``_842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof"></see>
    /// </summary>
    let ``_842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof`` =
        Namespaced_IRI.parse _namespace_name "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9"></see>
    /// </summary>
    let ``_842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77"></see>
    /// </summary>
    let ``_8f9744a7-4861-4bd3-a956-e4aab75b7e77`` =
        Namespaced_IRI.parse _namespace_name "8f9744a7-4861-4bd3-a956-e4aab75b7e77" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97"></see>
    /// </summary>
    let ``_8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97`` =
        Namespaced_IRI.parse _namespace_name "8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0"></see>
    /// </summary>
    let ``_8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0`` =
        Namespaced_IRI.parse _namespace_name "8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c"></see>
    /// </summary>
    let ``_8fd7cfcc-7613-4c1c-af44-798d6a3dca4c`` =
        Namespaced_IRI.parse _namespace_name "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be"></see>
    /// </summary>
    let ``_8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be`` =
        Namespaced_IRI.parse _namespace_name "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99"></see>
    /// </summary>
    let ``_8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99`` =
        Namespaced_IRI.parse _namespace_name "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a"></see>
    /// </summary>
    let ``_9144c07e-d14f-4371-8d28-7545b7337a4a`` =
        Namespaced_IRI.parse _namespace_name "9144c07e-d14f-4371-8d28-7545b7337a4a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9"></see>
    /// </summary>
    let ``_9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b"></see>
    /// </summary>
    let ``_9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b`` =
        Namespaced_IRI.parse _namespace_name "9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06"></see>
    /// </summary>
    let ``_9f8246db-bb73-4ad1-ab02-693da46dbd06`` =
        Namespaced_IRI.parse _namespace_name "9f8246db-bb73-4ad1-ab02-693da46dbd06" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259"></see>
    /// </summary>
    let ``_9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259`` =
        Namespaced_IRI.parse _namespace_name "9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06-partof"></see>
    /// </summary>
    let ``_9f8246db-bb73-4ad1-ab02-693da46dbd06-partof`` =
        Namespaced_IRI.parse _namespace_name "9f8246db-bb73-4ad1-ab02-693da46dbd06-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#NaturalPerson"></see>
    /// </summary>
    let NaturalPerson =
        Namespaced_IRI.parse _namespace_name "NaturalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#AbusiveName"></see>
    /// </summary>
    let AbusiveName =
        Namespaced_IRI.parse _namespace_name "AbusiveName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#NameType"></see>
    /// </summary>
    let NameType = Namespaced_IRI.parse _namespace_name "NameType" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Actor"></see>
    /// </summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#AdditionalName"></see>
    /// </summary>
    let AdditionalName =
        Namespaced_IRI.parse _namespace_name "AdditionalName" |> NamespacedName

    /// <summary>
    /// CWRC address is the equivalent of a schema.org Postal Address and uses the predicates from schema Postal Address.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#Address"></see></summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Androgynous"></see>
    /// </summary>
    let Androgynous =
        Namespaced_IRI.parse _namespace_name "Androgynous" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Gender"></see>
    /// </summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#AuthorialName"></see>
    /// </summary>
    let AuthorialName =
        Namespaced_IRI.parse _namespace_name "AuthorialName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#BiographyContext"></see>
    /// </summary>
    let BiographyContext =
        Namespaced_IRI.parse _namespace_name "BiographyContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#BirthContext"></see>
    /// </summary>
    let BirthContext =
        Namespaced_IRI.parse _namespace_name "BirthContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#BirthPosition"></see>
    /// </summary>
    let BirthPosition =
        Namespaced_IRI.parse _namespace_name "BirthPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Birthname"></see>
    /// </summary>
    let Birthname = Namespaced_IRI.parse _namespace_name "Birthname" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#BoardingSchool"></see></summary>
    let BoardingSchool =
        Namespaced_IRI.parse _namespace_name "BoardingSchool" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalOrganization"></see></summary>
    let EducationalOrganization =
        Namespaced_IRI.parse _namespace_name "EducationalOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#BritishWomenLiteraryClimate"></see>
    /// </summary>
    let BritishWomenLiteraryClimate =
        Namespaced_IRI.parse _namespace_name "BritishWomenLiteraryClimate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#LiteraryClimate"></see>
    /// </summary>
    let LiteraryClimate =
        Namespaced_IRI.parse _namespace_name "LiteraryClimate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Bursary"></see>
    /// </summary>
    let Bursary = Namespaced_IRI.parse _namespace_name "Bursary" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalAward"></see>
    /// </summary>
    let EducationalAward =
        Namespaced_IRI.parse _namespace_name "EducationalAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Certainty"></see>
    /// </summary>
    let Certainty = Namespaced_IRI.parse _namespace_name "Certainty" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ChangeSet"></see>
    /// </summary>
    let ChangeSet = Namespaced_IRI.parse _namespace_name "ChangeSet" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#CoEducationalSchool"></see></summary>
    let CoEducationalSchool =
        Namespaced_IRI.parse _namespace_name "CoEducationalSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#CompetencyQuestion"></see>
    /// </summary>
    let CompetencyQuestion =
        Namespaced_IRI.parse _namespace_name "CompetencyQuestion" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#ComprehensiveSchool"></see></summary>
    let ComprehensiveSchool =
        Namespaced_IRI.parse _namespace_name "ComprehensiveSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Credential"></see>
    /// </summary>
    let Credential = Namespaced_IRI.parse _namespace_name "Credential" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#CrypticName"></see>
    /// </summary>
    let CrypticName =
        Namespaced_IRI.parse _namespace_name "CrypticName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalForm"></see>
    /// </summary>
    let CulturalForm =
        Namespaced_IRI.parse _namespace_name "CulturalForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalFormContext"></see>
    /// </summary>
    let CulturalFormContext =
        Namespaced_IRI.parse _namespace_name "CulturalFormContext" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalFormation"></see></summary>
    let CulturalFormation =
        Namespaced_IRI.parse _namespace_name "CulturalFormation" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#DameSchool"></see></summary>
    let DameSchool = Namespaced_IRI.parse _namespace_name "DameSchool" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#DaySchool"></see></summary>
    let DaySchool = Namespaced_IRI.parse _namespace_name "DaySchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#DeathContext"></see>
    /// </summary>
    let DeathContext =
        Namespaced_IRI.parse _namespace_name "DeathContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#DecadeSignficance"></see>
    /// </summary>
    let DecadeSignficance =
        Namespaced_IRI.parse _namespace_name "DecadeSignficance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Distinction"></see>
    /// </summary>
    let Distinction =
        Namespaced_IRI.parse _namespace_name "Distinction" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#DomesticEducationContext"></see>
    /// </summary>
    let DomesticEducationContext =
        Namespaced_IRI.parse _namespace_name "DomesticEducationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#EducationContext"></see>
    /// </summary>
    let EducationContext =
        Namespaced_IRI.parse _namespace_name "EducationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalPrize"></see>
    /// </summary>
    let EducationalPrize =
        Namespaced_IRI.parse _namespace_name "EducationalPrize" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalSubject"></see>
    /// </summary>
    let EducationalSubject =
        Namespaced_IRI.parse _namespace_name "EducationalSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalText"></see>
    /// </summary>
    let EducationalText =
        Namespaced_IRI.parse _namespace_name "EducationalText" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of foreign instance &lt;a href="http://id.loc.gov/vocabulary/languages/eng"&gt;eng&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#EnglishLanguage"></see></summary>
    let EnglishLanguage =
        Namespaced_IRI.parse _namespace_name "EnglishLanguage" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#englishNationalHeritage" title="#englishNationalHeritage"&gt;English&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#EnglishNationalHeritage"></see></summary>
    let EnglishNationalHeritage =
        Namespaced_IRI.parse _namespace_name "EnglishNationalHeritage" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of foreign instance ISO 3166-2:GB-ENG.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#englishNationalHeritage"></see></summary>
    let englishNationalHeritage =
        Namespaced_IRI.parse _namespace_name "englishNationalHeritage" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance ISO 3166-2:GB-ENG.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#EnglishNationalIdentity"></see></summary>
    let EnglishNationalIdentity =
        Namespaced_IRI.parse _namespace_name "EnglishNationalIdentity" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of foreign instance ISO 3166-2:GB-ENG.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#englishNationalIdentity"></see></summary>
    let englishNationalIdentity =
        Namespaced_IRI.parse _namespace_name "englishNationalIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#EssayAward"></see>
    /// </summary>
    let EssayAward = Namespaced_IRI.parse _namespace_name "EssayAward" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Ethnicity"></see>
    /// </summary>
    let Ethnicity = Namespaced_IRI.parse _namespace_name "Ethnicity" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#EthnicityContext"></see></summary>
    let EthnicityContext =
        Namespaced_IRI.parse _namespace_name "EthnicityContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#RaceEthnicityContext"></see>
    /// </summary>
    let RaceEthnicityContext =
        Namespaced_IRI.parse _namespace_name "RaceEthnicityContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#RaceColour"></see>
    /// </summary>
    let RaceColour = Namespaced_IRI.parse _namespace_name "RaceColour" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Exhibition"></see>
    /// </summary>
    let Exhibition = Namespaced_IRI.parse _namespace_name "Exhibition" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#FamiliarName"></see>
    /// </summary>
    let FamiliarName =
        Namespaced_IRI.parse _namespace_name "FamiliarName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#FamilyContext"></see>
    /// </summary>
    let FamilyContext =
        Namespaced_IRI.parse _namespace_name "FamilyContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Fellowship"></see>
    /// </summary>
    let Fellowship = Namespaced_IRI.parse _namespace_name "Fellowship" |> NamespacedName

    /// <summary>
    /// Deprecated with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#FemaleLabel"></see></summary>
    let FemaleLabel =
        Namespaced_IRI.parse _namespace_name "FemaleLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#TextLabels"></see>
    /// </summary>
    let TextLabels = Namespaced_IRI.parse _namespace_name "TextLabels" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#woman" title="#woman"&gt;woman&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#genderWomanFemale"></see></summary>
    let genderWomanFemale =
        Namespaced_IRI.parse _namespace_name "genderWomanFemale" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#genderWomanFemale" title="#genderWomanFemale"&gt;Woman/Female&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#femaleSex"></see></summary>
    let femaleSex = Namespaced_IRI.parse _namespace_name "femaleSex" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#FictionalPerson"></see>
    /// </summary>
    let FictionalPerson =
        Namespaced_IRI.parse _namespace_name "FictionalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Forename"></see>
    /// </summary>
    let Forename = Namespaced_IRI.parse _namespace_name "Forename" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of foreign instance &lt;a href="http://id.loc.gov/vocabulary/languages/fre"&gt;fre&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#FrenchLanguage"></see></summary>
    let FrenchLanguage =
        Namespaced_IRI.parse _namespace_name "FrenchLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#FriendsAndAssociatesContext"></see>
    /// </summary>
    let FriendsAndAssociatesContext =
        Namespaced_IRI.parse _namespace_name "FriendsAndAssociatesContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#GenderContext"></see>
    /// </summary>
    let GenderContext =
        Namespaced_IRI.parse _namespace_name "GenderContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#GenderQueer"></see>
    /// </summary>
    let GenderQueer =
        Namespaced_IRI.parse _namespace_name "GenderQueer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#representedBy"></see>
    /// </summary>
    let representedBy =
        Namespaced_IRI.parse _namespace_name "representedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#queerLabel"></see>
    /// </summary>
    let queerLabel = Namespaced_IRI.parse _namespace_name "queerLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#GenerationalName"></see>
    /// </summary>
    let GenerationalName =
        Namespaced_IRI.parse _namespace_name "GenerationalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#GeographicHeritage"></see>
    /// </summary>
    let GeographicHeritage =
        Namespaced_IRI.parse _namespace_name "GeographicHeritage" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#GeographicalHeritage"></see></summary>
    let GeographicalHeritage =
        Namespaced_IRI.parse _namespace_name "GeographicalHeritage" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#GrammarSchool"></see></summary>
    let GrammarSchool =
        Namespaced_IRI.parse _namespace_name "GrammarSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#HealthContext"></see>
    /// </summary>
    let HealthContext =
        Namespaced_IRI.parse _namespace_name "HealthContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#HistoricSignificance"></see>
    /// </summary>
    let HistoricSignificance =
        Namespaced_IRI.parse _namespace_name "HistoricSignificance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#HonorificName"></see>
    /// </summary>
    let HonorificName =
        Namespaced_IRI.parse _namespace_name "HonorificName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#IndexedName"></see>
    /// </summary>
    let IndexedName =
        Namespaced_IRI.parse _namespace_name "IndexedName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#IndividualSignificance"></see>
    /// </summary>
    let IndividualSignificance =
        Namespaced_IRI.parse _namespace_name "IndividualSignificance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#InstitutionalEducationContext"></see>
    /// </summary>
    let InstitutionalEducationContext =
        Namespaced_IRI.parse _namespace_name "InstitutionalEducationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#IntervalTime"></see>
    /// </summary>
    let IntervalTime =
        Namespaced_IRI.parse _namespace_name "IntervalTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#IntimateRelationshipsContext"></see>
    /// </summary>
    let IntimateRelationshipsContext =
        Namespaced_IRI.parse _namespace_name "IntimateRelationshipsContext" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#jewishEthnicity" title="#jewishEthnicity"&gt;Jewish&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#JewishEthnicity"></see></summary>
    let JewishEthnicity =
        Namespaced_IRI.parse _namespace_name "JewishEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishEthnicity"></see></summary>
    let jewishEthnicity =
        Namespaced_IRI.parse _namespace_name "jewishEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishLabel"></see>
    /// </summary>
    let jewishLabel =
        Namespaced_IRI.parse _namespace_name "jewishLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Language"></see>
    /// </summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#LanguageContext"></see></summary>
    let LanguageContext =
        Namespaced_IRI.parse _namespace_name "LanguageContext" |> NamespacedName

    /// <summary>
    /// Deprecated, with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#LinguisticAbility"></see></summary>
    let LinguisticAbility =
        Namespaced_IRI.parse _namespace_name "LinguisticAbility" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#LeisureContext"></see>
    /// </summary>
    let LeisureContext =
        Namespaced_IRI.parse _namespace_name "LeisureContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#LiteraryName"></see>
    /// </summary>
    let LiteraryName =
        Namespaced_IRI.parse _namespace_name "LiteraryName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#LocalName"></see>
    /// </summary>
    let LocalName = Namespaced_IRI.parse _namespace_name "LocalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#MarriedName"></see>
    /// </summary>
    let MarriedName =
        Namespaced_IRI.parse _namespace_name "MarriedName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#MentalHealthContext"></see>
    /// </summary>
    let MentalHealthContext =
        Namespaced_IRI.parse _namespace_name "MentalHealthContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#NameContext"></see>
    /// </summary>
    let NameContext =
        Namespaced_IRI.parse _namespace_name "NameContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#NameLink"></see>
    /// </summary>
    let NameLink = Namespaced_IRI.parse _namespace_name "NameLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PersonalName"></see>
    /// </summary>
    let PersonalName =
        Namespaced_IRI.parse _namespace_name "PersonalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#NationalHeritage"></see>
    /// </summary>
    let NationalHeritage =
        Namespaced_IRI.parse _namespace_name "NationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#NationalIdentity"></see>
    /// </summary>
    let NationalIdentity =
        Namespaced_IRI.parse _namespace_name "NationalIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#NationalityContext"></see>
    /// </summary>
    let NationalityContext =
        Namespaced_IRI.parse _namespace_name "NationalityContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Nickname"></see>
    /// </summary>
    let Nickname = Namespaced_IRI.parse _namespace_name "Nickname" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Occupation"></see>
    /// </summary>
    let Occupation = Namespaced_IRI.parse _namespace_name "Occupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#OccupationContext"></see>
    /// </summary>
    let OccupationContext =
        Namespaced_IRI.parse _namespace_name "OccupationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Oeuvre"></see>
    /// </summary>
    let Oeuvre = Namespaced_IRI.parse _namespace_name "Oeuvre" |> NamespacedName

    /// <summary>
    ///
    /// Deprecated in favour of class &lt;a href="https://www.w3.org/TR/vocab-org/#class-formalorganization"&gt;org:formalOrganization&lt;/a&gt;
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#EventElement" title="#EventElement"&gt;[http://sparql.cwrc.ca/ontologies/cwrc#EventElement]&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#Performance"></see></summary>
    let Performance =
        Namespaced_IRI.parse _namespace_name "Performance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasElement"></see>
    /// </summary>
    let hasElement = Namespaced_IRI.parse _namespace_name "hasElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#EventElement"></see>
    /// </summary>
    let EventElement =
        Namespaced_IRI.parse _namespace_name "EventElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PeriodSignificance"></see>
    /// </summary>
    let PeriodSignificance =
        Namespaced_IRI.parse _namespace_name "PeriodSignificance" |> NamespacedName

    /// <summary>
    /// This definition is indebted to the Text Encoding Initiative's definition of the "persona" element. See &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persona.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persona.html"&gt;TEI element persona &lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#Persona"></see></summary>
    let Persona = Namespaced_IRI.parse _namespace_name "Persona" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PhysicalHealthContext"></see>
    /// </summary>
    let PhysicalHealthContext =
        Namespaced_IRI.parse _namespace_name "PhysicalHealthContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalAffiliation"></see>
    /// </summary>
    let PoliticalAffiliation =
        Namespaced_IRI.parse _namespace_name "PoliticalAffiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalClimate"></see>
    /// </summary>
    let PoliticalClimate =
        Namespaced_IRI.parse _namespace_name "PoliticalClimate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalContext"></see>
    /// </summary>
    let PoliticalContext =
        Namespaced_IRI.parse _namespace_name "PoliticalContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalOrganization"></see>
    /// </summary>
    let PoliticalOrganization =
        Namespaced_IRI.parse _namespace_name "PoliticalOrganization" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#PostSecondarySchool"></see></summary>
    let PostSecondarySchool =
        Namespaced_IRI.parse _namespace_name "PostSecondarySchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PreferredName"></see>
    /// </summary>
    let PreferredName =
        Namespaced_IRI.parse _namespace_name "PreferredName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#rangeIncludes"></see>
    /// </summary>
    let rangeIncludes =
        Namespaced_IRI.parse _namespace_name "rangeIncludes" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PrepSchool"></see>
    /// </summary>
    let PrepSchool = Namespaced_IRI.parse _namespace_name "PrepSchool" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#PrimarySchool"></see></summary>
    let PrimarySchool =
        Namespaced_IRI.parse _namespace_name "PrimarySchool" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#PrivateSchool"></see></summary>
    let PrivateSchool =
        Namespaced_IRI.parse _namespace_name "PrivateSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ProfessionalTitle"></see>
    /// </summary>
    let ProfessionalTitle =
        Namespaced_IRI.parse _namespace_name "ProfessionalTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#RoleName"></see>
    /// </summary>
    let RoleName = Namespaced_IRI.parse _namespace_name "RoleName" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Pseudonym"></see>
    /// </summary>
    let Pseudonym = Namespaced_IRI.parse _namespace_name "Pseudonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#PunctiveTime"></see>
    /// </summary>
    let PunctiveTime =
        Namespaced_IRI.parse _namespace_name "PunctiveTime" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#RaceColour" title="#RaceColour"&gt;race or colour&lt;/a&gt; and &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicity&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#RaceEthnicity"></see></summary>
    let RaceEthnicity =
        Namespaced_IRI.parse _namespace_name "RaceEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Religion"></see>
    /// </summary>
    let Religion = Namespaced_IRI.parse _namespace_name "Religion" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ReligionContext"></see>
    /// </summary>
    let ReligionContext =
        Namespaced_IRI.parse _namespace_name "ReligionContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ReligiousOrganization"></see>
    /// </summary>
    let ReligiousOrganization =
        Namespaced_IRI.parse _namespace_name "ReligiousOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ReligiousSchool"></see>
    /// </summary>
    let ReligiousSchool =
        Namespaced_IRI.parse _namespace_name "ReligiousSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ReligousName"></see>
    /// </summary>
    let ReligousName =
        Namespaced_IRI.parse _namespace_name "ReligousName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ReproductiveHistory"></see>
    /// </summary>
    let ReproductiveHistory =
        Namespaced_IRI.parse _namespace_name "ReproductiveHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#RomanceName"></see>
    /// </summary>
    let RomanceName =
        Namespaced_IRI.parse _namespace_name "RomanceName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#RoyalName"></see>
    /// </summary>
    let RoyalName = Namespaced_IRI.parse _namespace_name "RoyalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Scholarship"></see>
    /// </summary>
    let Scholarship =
        Namespaced_IRI.parse _namespace_name "Scholarship" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#SecondaryModernSchool"></see></summary>
    let SecondaryModernSchool =
        Namespaced_IRI.parse _namespace_name "SecondaryModernSchool" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#SecondarySchool"></see></summary>
    let SecondarySchool =
        Namespaced_IRI.parse _namespace_name "SecondarySchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SecularSchool"></see>
    /// </summary>
    let SecularSchool =
        Namespaced_IRI.parse _namespace_name "SecularSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SelfConstructedName"></see>
    /// </summary>
    let SelfConstructedName =
        Namespaced_IRI.parse _namespace_name "SelfConstructedName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SelfTaughtEducationContext"></see>
    /// </summary>
    let SelfTaughtEducationContext =
        Namespaced_IRI.parse _namespace_name "SelfTaughtEducationContext" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#Gender" title="#Gender"&gt;gender&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#SexIdentity"></see></summary>
    let SexIdentity =
        Namespaced_IRI.parse _namespace_name "SexIdentity" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#Sexuality" title="#Sexuality"&gt;sexuality&lt;/a&gt;.
    /// Deprecated in favour of &lt;a href="#Sexuality" title="#Sexuality"&gt;sexuality&lt;/a&gt; term.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#SexualIdentity"></see></summary>
    let SexualIdentity =
        Namespaced_IRI.parse _namespace_name "SexualIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Sexuality"></see>
    /// </summary>
    let Sexuality = Namespaced_IRI.parse _namespace_name "Sexuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SexualityContext"></see>
    /// </summary>
    let SexualityContext =
        Namespaced_IRI.parse _namespace_name "SexualityContext" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#SingleSexSchool"></see></summary>
    let SingleSexSchool =
        Namespaced_IRI.parse _namespace_name "SingleSexSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClass"></see>
    /// </summary>
    let SocialClass =
        Namespaced_IRI.parse _namespace_name "SocialClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClassContext"></see>
    /// </summary>
    let SocialClassContext =
        Namespaced_IRI.parse _namespace_name "SocialClassContext" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of class &lt;a href="#SocialClass" title="#SocialClass"&gt;social class&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClassIdentity"></see></summary>
    let SocialClassIdentity =
        Namespaced_IRI.parse _namespace_name "SocialClassIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClimate"></see>
    /// </summary>
    let SocialClimate =
        Namespaced_IRI.parse _namespace_name "SocialClimate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SpatialContext"></see>
    /// </summary>
    let SpatialContext =
        Namespaced_IRI.parse _namespace_name "SpatialContext" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#StateSchool"></see></summary>
    let StateSchool =
        Namespaced_IRI.parse _namespace_name "StateSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Studentship"></see>
    /// </summary>
    let Studentship =
        Namespaced_IRI.parse _namespace_name "Studentship" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#StyledName"></see>
    /// </summary>
    let StyledName = Namespaced_IRI.parse _namespace_name "StyledName" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Surname"></see>
    /// </summary>
    let Surname = Namespaced_IRI.parse _namespace_name "Surname" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#SystemName"></see>
    /// </summary>
    let SystemName = Namespaced_IRI.parse _namespace_name "SystemName" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#TitledName"></see>
    /// </summary>
    let TitledName = Namespaced_IRI.parse _namespace_name "TitledName" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#TradeSchool"></see></summary>
    let TradeSchool =
        Namespaced_IRI.parse _namespace_name "TradeSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ViolenceContext"></see>
    /// </summary>
    let ViolenceContext =
        Namespaced_IRI.parse _namespace_name "ViolenceContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#WealthContext"></see>
    /// </summary>
    let WealthContext =
        Namespaced_IRI.parse _namespace_name "WealthContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#WomensHealthContext"></see>
    /// </summary>
    let WomensHealthContext =
        Namespaced_IRI.parse _namespace_name "WomensHealthContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-588ae315d6"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899-588ae315d6`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899-588ae315d6" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-9856975261"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899-9856975261`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899-9856975261" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-dc53f66118"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899-dc53f66118`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899-dc53f66118" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-partof"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899-partof`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92"></see>
    /// </summary>
    let ``a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92`` =
        Namespaced_IRI.parse _namespace_name "a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e"></see>
    /// </summary>
    let ``a647a149-3420-4a0d-8462-03900131060e`` =
        Namespaced_IRI.parse _namespace_name "a647a149-3420-4a0d-8462-03900131060e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-d623563918"></see>
    /// </summary>
    let ``a647a149-3420-4a0d-8462-03900131060e-d623563918`` =
        Namespaced_IRI.parse _namespace_name "a647a149-3420-4a0d-8462-03900131060e-d623563918" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-67d1668522"></see>
    /// </summary>
    let ``a647a149-3420-4a0d-8462-03900131060e-67d1668522`` =
        Namespaced_IRI.parse _namespace_name "a647a149-3420-4a0d-8462-03900131060e-67d1668522" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-62fc70c238"></see>
    /// </summary>
    let ``a647a149-3420-4a0d-8462-03900131060e-62fc70c238`` =
        Namespaced_IRI.parse _namespace_name "a647a149-3420-4a0d-8462-03900131060e-62fc70c238" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe"></see>
    /// </summary>
    let ``a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe`` =
        Namespaced_IRI.parse _namespace_name "a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36"></see>
    /// </summary>
    let ``aa8dae29-558b-4bda-9859-9ed43faede36`` =
        Namespaced_IRI.parse _namespace_name "aa8dae29-558b-4bda-9859-9ed43faede36" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c"></see>
    /// </summary>
    let ``aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c`` =
        Namespaced_IRI.parse _namespace_name "aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c"></see>
    /// </summary>
    let ``aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c`` =
        Namespaced_IRI.parse _namespace_name "aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746"></see>
    /// </summary>
    let ``aaa909f5-ffb5-4995-8245-b169d3c64746`` =
        Namespaced_IRI.parse _namespace_name "aaa909f5-ffb5-4995-8245-b169d3c64746" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4"></see>
    /// </summary>
    let ``aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4`` =
        Namespaced_IRI.parse _namespace_name "aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c"></see>
    /// </summary>
    let ``aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c`` =
        Namespaced_IRI.parse _namespace_name "aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-partof"></see>
    /// </summary>
    let ``aaa909f5-ffb5-4995-8245-b169d3c64746-partof`` =
        Namespaced_IRI.parse _namespace_name "aaa909f5-ffb5-4995-8245-b169d3c64746-partof" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#abolitionism"></see></summary>
    let abolitionism =
        Namespaced_IRI.parse _namespace_name "abolitionism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#contraryTo"></see>
    /// </summary>
    let contraryTo = Namespaced_IRI.parse _namespace_name "contraryTo" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pro-Slavery"></see></summary>
    let ``pro-Slavery`` =
        Namespaced_IRI.parse _namespace_name "pro-Slavery" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#humanRights"></see></summary>
    let humanRights =
        Namespaced_IRI.parse _namespace_name "humanRights" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#civilRights"></see></summary>
    let civilRights =
        Namespaced_IRI.parse _namespace_name "civilRights" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#racialEquality"></see></summary>
    let racialEquality =
        Namespaced_IRI.parse _namespace_name "racialEquality" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#abolitionist"></see>
    /// </summary>
    let abolitionist =
        Namespaced_IRI.parse _namespace_name "abolitionist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#activist"></see>
    /// </summary>
    let activist = Namespaced_IRI.parse _namespace_name "activist" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#abortion"></see>
    /// </summary>
    let abortion = Namespaced_IRI.parse _namespace_name "abortion" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#abrahamicReligions"></see></summary>
    let abrahamicReligions =
        Namespaced_IRI.parse _namespace_name "abrahamicReligions" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#academic"></see>
    /// </summary>
    let academic = Namespaced_IRI.parse _namespace_name "academic" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#education"></see>
    /// </summary>
    let education = Namespaced_IRI.parse _namespace_name "education" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#accountant"></see>
    /// </summary>
    let accountant = Namespaced_IRI.parse _namespace_name "accountant" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#finance"></see>
    /// </summary>
    let finance = Namespaced_IRI.parse _namespace_name "finance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#actorManager"></see>
    /// </summary>
    let actorManager =
        Namespaced_IRI.parse _namespace_name "actorManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#theatreWork"></see>
    /// </summary>
    let theatreWork =
        Namespaced_IRI.parse _namespace_name "theatreWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#adjudicator"></see>
    /// </summary>
    let adjudicator =
        Namespaced_IRI.parse _namespace_name "adjudicator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#administrator"></see>
    /// </summary>
    let administrator =
        Namespaced_IRI.parse _namespace_name "administrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#adoption"></see>
    /// </summary>
    let adoption = Namespaced_IRI.parse _namespace_name "adoption" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#adventism"></see></summary>
    let adventism = Namespaced_IRI.parse _namespace_name "adventism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#protestantism"></see></summary>
    let protestantism =
        Namespaced_IRI.parse _namespace_name "protestantism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#advertising"></see>
    /// </summary>
    let advertising =
        Namespaced_IRI.parse _namespace_name "advertising" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#advocate"></see>
    /// </summary>
    let advocate = Namespaced_IRI.parse _namespace_name "advocate" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#politics"></see>
    /// </summary>
    let politics = Namespaced_IRI.parse _namespace_name "politics" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9"></see>
    /// </summary>
    let ``aec674cf-2108-4977-be3a-9317efe35aa9`` =
        Namespaced_IRI.parse _namespace_name "aec674cf-2108-4977-be3a-9317efe35aa9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd"></see>
    /// </summary>
    let ``aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd`` =
        Namespaced_IRI.parse _namespace_name "aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9-partof"></see>
    /// </summary>
    let ``aec674cf-2108-4977-be3a-9317efe35aa9-partof`` =
        Namespaced_IRI.parse _namespace_name "aec674cf-2108-4977-be3a-9317efe35aa9-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#affectedEntity"></see>
    /// </summary>
    let affectedEntity =
        Namespaced_IRI.parse _namespace_name "affectedEntity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#african-AmericanEthnicity"></see></summary>
    let ``african-AmericanEthnicity`` =
        Namespaced_IRI.parse _namespace_name "african-AmericanEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#blackLabel"></see>
    /// </summary>
    let blackLabel = Namespaced_IRI.parse _namespace_name "blackLabel" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#africanEthnicity"></see></summary>
    let africanEthnicity =
        Namespaced_IRI.parse _namespace_name "africanEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#africanNationalHeritage"></see></summary>
    let africanNationalHeritage =
        Namespaced_IRI.parse _namespace_name "africanNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#africanNationalIdentity"></see>
    /// </summary>
    let africanNationalIdentity =
        Namespaced_IRI.parse _namespace_name "africanNationalIdentity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#afro-CaribbeanRaceColour"></see></summary>
    let ``afro-CaribbeanRaceColour`` =
        Namespaced_IRI.parse _namespace_name "afro-CaribbeanRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#agent"></see>
    /// </summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#agnosticism"></see></summary>
    let agnosticism =
        Namespaced_IRI.parse _namespace_name "agnosticism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#aidsActivism"></see></summary>
    let aidsActivism =
        Namespaced_IRI.parse _namespace_name "aidsActivism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialReform"></see></summary>
    let socialReform =
        Namespaced_IRI.parse _namespace_name "socialReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#airForce"></see>
    /// </summary>
    let airForce = Namespaced_IRI.parse _namespace_name "airForce" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#airRaidWarden"></see>
    /// </summary>
    let airRaidWarden =
        Namespaced_IRI.parse _namespace_name "airRaidWarden" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#warWork"></see>
    /// </summary>
    let warWork = Namespaced_IRI.parse _namespace_name "warWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aircraftIndustry"></see>
    /// </summary>
    let aircraftIndustry =
        Namespaced_IRI.parse _namespace_name "aircraftIndustry" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#airman"></see>
    /// </summary>
    let airman = Namespaced_IRI.parse _namespace_name "airman" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pilot"></see>
    /// </summary>
    let pilot = Namespaced_IRI.parse _namespace_name "pilot" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#military"></see>
    /// </summary>
    let military = Namespaced_IRI.parse _namespace_name "military" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#alteredBy"></see>
    /// </summary>
    let alteredBy = Namespaced_IRI.parse _namespace_name "alteredBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#alternativeMedicine"></see>
    /// </summary>
    let alternativeMedicine =
        Namespaced_IRI.parse _namespace_name "alternativeMedicine" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ambulanceWorker"></see>
    /// </summary>
    let ambulanceWorker =
        Namespaced_IRI.parse _namespace_name "ambulanceWorker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#americanNationalism"></see>
    /// </summary>
    let americanNationalism =
        Namespaced_IRI.parse _namespace_name "americanNationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#nationalism"></see></summary>
    let nationalism =
        Namespaced_IRI.parse _namespace_name "nationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anarchism"></see></summary>
    let anarchism = Namespaced_IRI.parse _namespace_name "anarchism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Monarchism"></see></summary>
    let ``anti-Monarchism`` =
        Namespaced_IRI.parse _namespace_name "anti-Monarchism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ancestorOf"></see>
    /// </summary>
    let ancestorOf = Namespaced_IRI.parse _namespace_name "ancestorOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#relativeOf"></see>
    /// </summary>
    let relativeOf = Namespaced_IRI.parse _namespace_name "relativeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasAncestor"></see>
    /// </summary>
    let hasAncestor =
        Namespaced_IRI.parse _namespace_name "hasAncestor" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anglicanism"></see></summary>
    let anglicanism =
        Namespaced_IRI.parse _namespace_name "anglicanism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#christianity"></see></summary>
    let christianity =
        Namespaced_IRI.parse _namespace_name "christianity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IndianNationalIdentity"></see>
    /// </summary>
    let ``anglo-IndianNationalIdentity`` =
        Namespaced_IRI.parse _namespace_name "anglo-IndianNationalIdentity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishEthnicity"></see></summary>
    let ``anglo-IrishEthnicity`` =
        Namespaced_IRI.parse _namespace_name "anglo-IrishEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#europeanEthnicity"></see></summary>
    let europeanEthnicity =
        Namespaced_IRI.parse _namespace_name "europeanEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishNationalHeritage"></see></summary>
    let ``anglo-IrishNationalHeritage`` =
        Namespaced_IRI.parse _namespace_name "anglo-IrishNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishNationalIdentity"></see>
    /// </summary>
    let ``anglo-IrishNationalIdentity`` =
        Namespaced_IRI.parse _namespace_name "anglo-IrishNationalIdentity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishRaceColour"></see></summary>
    let ``anglo-IrishRaceColour`` =
        Namespaced_IRI.parse _namespace_name "anglo-IrishRaceColour" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-NormanEthnicity"></see></summary>
    let ``anglo-NormanEthnicity`` =
        Namespaced_IRI.parse _namespace_name "anglo-NormanEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#animalWelfareAdvocacy"></see></summary>
    let animalWelfareAdvocacy =
        Namespaced_IRI.parse _namespace_name "animalWelfareAdvocacy" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#feminism"></see></summary>
    let feminism = Namespaced_IRI.parse _namespace_name "feminism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-American"></see></summary>
    let ``anti-American`` =
        Namespaced_IRI.parse _namespace_name "anti-American" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pro-American"></see>
    /// </summary>
    let ``pro-American`` =
        Namespaced_IRI.parse _namespace_name "pro-American" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Antisemitism"></see></summary>
    let ``anti-Antisemitism`` =
        Namespaced_IRI.parse _namespace_name "anti-Antisemitism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#antisemitism"></see></summary>
    let antisemitism =
        Namespaced_IRI.parse _namespace_name "antisemitism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Fascism"></see></summary>
    let ``anti-Fascism`` =
        Namespaced_IRI.parse _namespace_name "anti-Fascism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Apartheid"></see></summary>
    let ``anti-Apartheid`` =
        Namespaced_IRI.parse _namespace_name "anti-Apartheid" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Boer"></see></summary>
    let ``anti-Boer`` =
        Namespaced_IRI.parse _namespace_name "anti-Boer" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pro-BoerWar"></see></summary>
    let ``pro-BoerWar`` =
        Namespaced_IRI.parse _namespace_name "pro-BoerWar" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-War"></see></summary>
    let ``anti-War`` = Namespaced_IRI.parse _namespace_name "anti-War" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Bolshevism"></see></summary>
    let ``anti-Bolshevism`` =
        Namespaced_IRI.parse _namespace_name "anti-Bolshevism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bolshevism"></see></summary>
    let bolshevism = Namespaced_IRI.parse _namespace_name "bolshevism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Communism"></see></summary>
    let ``anti-Communism`` =
        Namespaced_IRI.parse _namespace_name "anti-Communism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Bonapartism"></see></summary>
    let ``anti-Bonapartism`` =
        Namespaced_IRI.parse _namespace_name "anti-Bonapartism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bonapartism"></see></summary>
    let bonapartism =
        Namespaced_IRI.parse _namespace_name "bonapartism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-British"></see></summary>
    let ``anti-British`` =
        Namespaced_IRI.parse _namespace_name "anti-British" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-CapitalPunishment"></see></summary>
    let ``anti-CapitalPunishment`` =
        Namespaced_IRI.parse _namespace_name "anti-CapitalPunishment" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Capitalism"></see></summary>
    let ``anti-Capitalism`` =
        Namespaced_IRI.parse _namespace_name "anti-Capitalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#communism"></see></summary>
    let communism = Namespaced_IRI.parse _namespace_name "communism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Caste"></see></summary>
    let ``anti-Caste`` =
        Namespaced_IRI.parse _namespace_name "anti-Caste" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Catholicism"></see></summary>
    let ``anti-Catholicism`` =
        Namespaced_IRI.parse _namespace_name "anti-Catholicism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pro-Catholicism"></see></summary>
    let ``pro-Catholicism`` =
        Namespaced_IRI.parse _namespace_name "pro-Catholicism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Censorship"></see></summary>
    let ``anti-Censorship`` =
        Namespaced_IRI.parse _namespace_name "anti-Censorship" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Conscriptionism"></see></summary>
    let ``anti-Conscriptionism`` =
        Namespaced_IRI.parse _namespace_name "anti-Conscriptionism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-ContagiousDiseasesAct"></see></summary>
    let ``anti-ContagiousDiseasesAct`` =
        Namespaced_IRI.parse _namespace_name "anti-ContagiousDiseasesAct" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-CorporalPunishment"></see></summary>
    let ``anti-CorporalPunishment`` =
        Namespaced_IRI.parse _namespace_name "anti-CorporalPunishment" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Dreyfusard"></see></summary>
    let ``anti-Dreyfusard`` =
        Namespaced_IRI.parse _namespace_name "anti-Dreyfusard" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#dreyfusard"></see></summary>
    let dreyfusard = Namespaced_IRI.parse _namespace_name "dreyfusard" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-European"></see></summary>
    let ``anti-European`` =
        Namespaced_IRI.parse _namespace_name "anti-European" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pro-European"></see></summary>
    let ``pro-European`` =
        Namespaced_IRI.parse _namespace_name "pro-European" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#fascism"></see></summary>
    let fascism = Namespaced_IRI.parse _namespace_name "fascism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Federalism"></see></summary>
    let ``anti-Federalism`` =
        Namespaced_IRI.parse _namespace_name "anti-Federalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Feminism"></see></summary>
    let ``anti-Feminism`` =
        Namespaced_IRI.parse _namespace_name "anti-Feminism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#suffrage"></see></summary>
    let suffrage = Namespaced_IRI.parse _namespace_name "suffrage" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Globalism"></see></summary>
    let ``anti-Globalism`` =
        Namespaced_IRI.parse _namespace_name "anti-Globalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Imperialism"></see></summary>
    let ``anti-Imperialism`` =
        Namespaced_IRI.parse _namespace_name "anti-Imperialism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#imperialism"></see></summary>
    let imperialism =
        Namespaced_IRI.parse _namespace_name "imperialism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Jacobin"></see></summary>
    let ``anti-Jacobin`` =
        Namespaced_IRI.parse _namespace_name "anti-Jacobin" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Jacobite"></see></summary>
    let ``anti-Jacobite`` =
        Namespaced_IRI.parse _namespace_name "anti-Jacobite" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jacobitism"></see></summary>
    let jacobitism = Namespaced_IRI.parse _namespace_name "jacobitism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-LandLeague"></see></summary>
    let ``anti-LandLeague`` =
        Namespaced_IRI.parse _namespace_name "anti-LandLeague" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#irishUnionism"></see></summary>
    let irishUnionism =
        Namespaced_IRI.parse _namespace_name "irishUnionism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#monarchism"></see></summary>
    let monarchism = Namespaced_IRI.parse _namespace_name "monarchism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-NuclearMovement"></see></summary>
    let ``anti-NuclearMovement`` =
        Namespaced_IRI.parse _namespace_name "anti-NuclearMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#environmentalism"></see></summary>
    let environmentalism =
        Namespaced_IRI.parse _namespace_name "environmentalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Pacifism"></see></summary>
    let ``anti-Pacifism`` =
        Namespaced_IRI.parse _namespace_name "anti-Pacifism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pacifism"></see></summary>
    let pacifism = Namespaced_IRI.parse _namespace_name "pacifism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-PovertyMovement"></see></summary>
    let ``anti-PovertyMovement`` =
        Namespaced_IRI.parse _namespace_name "anti-PovertyMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Racism"></see></summary>
    let ``anti-Racism`` =
        Namespaced_IRI.parse _namespace_name "anti-Racism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#racism"></see></summary>
    let racism = Namespaced_IRI.parse _namespace_name "racism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#blackAnti-Oppression"></see></summary>
    let ``blackAnti-Oppression`` =
        Namespaced_IRI.parse _namespace_name "blackAnti-Oppression" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Socialism"></see></summary>
    let ``anti-Socialism`` =
        Namespaced_IRI.parse _namespace_name "anti-Socialism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialism"></see></summary>
    let socialism = Namespaced_IRI.parse _namespace_name "socialism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Suffrage"></see></summary>
    let ``anti-Suffrage`` =
        Namespaced_IRI.parse _namespace_name "anti-Suffrage" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Trade-Unionism"></see></summary>
    let ``anti-Trade-Unionism`` =
        Namespaced_IRI.parse _namespace_name "anti-Trade-Unionism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#labourMovement"></see></summary>
    let labourMovement =
        Namespaced_IRI.parse _namespace_name "labourMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Urbanism"></see></summary>
    let ``anti-Urbanism`` =
        Namespaced_IRI.parse _namespace_name "anti-Urbanism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Vaccination"></see></summary>
    let ``anti-Vaccination`` =
        Namespaced_IRI.parse _namespace_name "anti-Vaccination" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Vivisection"></see></summary>
    let ``anti-Vivisection`` =
        Namespaced_IRI.parse _namespace_name "anti-Vivisection" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Zionism"></see></summary>
    let ``anti-Zionism`` =
        Namespaced_IRI.parse _namespace_name "anti-Zionism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#zionism"></see></summary>
    let zionism = Namespaced_IRI.parse _namespace_name "zionism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#anti-masonry"></see></summary>
    let ``anti-masonry`` =
        Namespaced_IRI.parse _namespace_name "anti-masonry" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#antiClericalism"></see></summary>
    let antiClericalism =
        Namespaced_IRI.parse _namespace_name "antiClericalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#methodism"></see>
    /// </summary>
    let methodism = Namespaced_IRI.parse _namespace_name "methodism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#antidisestablishmentarianism"></see></summary>
    let antidisestablishmentarianism =
        Namespaced_IRI.parse _namespace_name "antidisestablishmentarianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#disestablishmentarianism"></see></summary>
    let disestablishmentarianism =
        Namespaced_IRI.parse _namespace_name "disestablishmentarianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#appeasement"></see></summary>
    let appeasement =
        Namespaced_IRI.parse _namespace_name "appeasement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#appraiser"></see>
    /// </summary>
    let appraiser = Namespaced_IRI.parse _namespace_name "appraiser" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#arabEthnicity"></see></summary>
    let arabEthnicity =
        Namespaced_IRI.parse _namespace_name "arabEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#archaeologist"></see>
    /// </summary>
    let archaeologist =
        Namespaced_IRI.parse _namespace_name "archaeologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#architecture"></see>
    /// </summary>
    let architecture =
        Namespaced_IRI.parse _namespace_name "architecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#archivist"></see>
    /// </summary>
    let archivist = Namespaced_IRI.parse _namespace_name "archivist" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#librarian"></see>
    /// </summary>
    let librarian = Namespaced_IRI.parse _namespace_name "librarian" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#aristocrat"></see>
    /// </summary>
    let aristocrat = Namespaced_IRI.parse _namespace_name "aristocrat" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#army"></see>
    /// </summary>
    let army = Namespaced_IRI.parse _namespace_name "army" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#artsAdministrator"></see>
    /// </summary>
    let artsAdministrator =
        Namespaced_IRI.parse _namespace_name "artsAdministrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#manager"></see>
    /// </summary>
    let manager = Namespaced_IRI.parse _namespace_name "manager" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#artsAdvocacy"></see></summary>
    let artsAdvocacy =
        Namespaced_IRI.parse _namespace_name "artsAdvocacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#artsAdvocate"></see>
    /// </summary>
    let artsAdvocate =
        Namespaced_IRI.parse _namespace_name "artsAdvocate" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#asceticism"></see></summary>
    let asceticism = Namespaced_IRI.parse _namespace_name "asceticism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#ashkenaziJewishEthnicity"></see></summary>
    let ashkenaziJewishEthnicity =
        Namespaced_IRI.parse _namespace_name "ashkenaziJewishEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#asianRaceColour"></see></summary>
    let asianRaceColour =
        Namespaced_IRI.parse _namespace_name "asianRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#assistant"></see>
    /// </summary>
    let assistant = Namespaced_IRI.parse _namespace_name "assistant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#associationInvolvement"></see>
    /// </summary>
    let associationInvolvement =
        Namespaced_IRI.parse _namespace_name "associationInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#astronomer"></see>
    /// </summary>
    let astronomer = Namespaced_IRI.parse _namespace_name "astronomer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#scientist"></see>
    /// </summary>
    let scientist = Namespaced_IRI.parse _namespace_name "scientist" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#atheism"></see></summary>
    let atheism = Namespaced_IRI.parse _namespace_name "atheism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#attends"></see>
    /// </summary>
    let attends = Namespaced_IRI.parse _namespace_name "attends" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#School"></see>
    /// </summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStudent"></see>
    /// </summary>
    let hasStudent = Namespaced_IRI.parse _namespace_name "hasStudent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#attendsPostSecondarySchool"></see>
    /// </summary>
    let attendsPostSecondarySchool =
        Namespaced_IRI.parse _namespace_name "attendsPostSecondarySchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#attendsPrimarySchool"></see>
    /// </summary>
    let attendsPrimarySchool =
        Namespaced_IRI.parse _namespace_name "attendsPrimarySchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#attendsSecondarySchool"></see>
    /// </summary>
    let attendsSecondarySchool =
        Namespaced_IRI.parse _namespace_name "attendsSecondarySchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#attorneyGeneral"></see>
    /// </summary>
    let attorneyGeneral =
        Namespaced_IRI.parse _namespace_name "attorneyGeneral" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#governmentOfficial"></see>
    /// </summary>
    let governmentOfficial =
        Namespaced_IRI.parse _namespace_name "governmentOfficial" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#auctioneer"></see>
    /// </summary>
    let auctioneer = Namespaced_IRI.parse _namespace_name "auctioneer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#auntOf"></see>
    /// </summary>
    let auntOf = Namespaced_IRI.parse _namespace_name "auntOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasAunt"></see>
    /// </summary>
    let hasAunt = Namespaced_IRI.parse _namespace_name "hasAunt" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#automobileIndustry"></see>
    /// </summary>
    let automobileIndustry =
        Namespaced_IRI.parse _namespace_name "automobileIndustry" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#transportationWork"></see>
    /// </summary>
    let transportationWork =
        Namespaced_IRI.parse _namespace_name "transportationWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#awardedTo"></see>
    /// </summary>
    let awardedTo = Namespaced_IRI.parse _namespace_name "awardedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e"></see>
    /// </summary>
    let ``b69cb6a0-ac73-4219-bfb0-e4804ff1403e`` =
        Namespaced_IRI.parse _namespace_name "b69cb6a0-ac73-4219-bfb0-e4804ff1403e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214"></see>
    /// </summary>
    let ``b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214`` =
        Namespaced_IRI.parse _namespace_name "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251"></see>
    /// </summary>
    let ``b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251`` =
        Namespaced_IRI.parse _namespace_name "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8"></see>
    /// </summary>
    let ``b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8`` =
        Namespaced_IRI.parse _namespace_name "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a"></see>
    /// </summary>
    let ``b736fb3c-dcde-49f3-aa07-67ce6a42100a`` =
        Namespaced_IRI.parse _namespace_name "b736fb3c-dcde-49f3-aa07-67ce6a42100a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1"></see>
    /// </summary>
    let ``b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1`` =
        Namespaced_IRI.parse _namespace_name "b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof"></see>
    /// </summary>
    let ``b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof`` =
        Namespaced_IRI.parse _namespace_name "b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9"></see>
    /// </summary>
    let ``b95a3e61-23f6-4603-bb6b-06703aceb3c9`` =
        Namespaced_IRI.parse _namespace_name "b95a3e61-23f6-4603-bb6b-06703aceb3c9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51"></see>
    /// </summary>
    let ``b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51`` =
        Namespaced_IRI.parse _namespace_name "b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9"></see>
    /// </summary>
    let ``b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9`` =
        Namespaced_IRI.parse _namespace_name "b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c"></see>
    /// </summary>
    let ``b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c`` =
        Namespaced_IRI.parse _namespace_name "b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909"></see>
    /// </summary>
    let ``b9eeccf9-9380-4341-99dc-a83f5ee32909`` =
        Namespaced_IRI.parse _namespace_name "b9eeccf9-9380-4341-99dc-a83f5ee32909" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604"></see>
    /// </summary>
    let ``b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604`` =
        Namespaced_IRI.parse _namespace_name "b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909-partof"></see>
    /// </summary>
    let ``b9eeccf9-9380-4341-99dc-a83f5ee32909-partof`` =
        Namespaced_IRI.parse _namespace_name "b9eeccf9-9380-4341-99dc-a83f5ee32909-partof" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bachelorOfArts"></see></summary>
    let bachelorOfArts =
        Namespaced_IRI.parse _namespace_name "bachelorOfArts" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#undergraduateDegree"></see></summary>
    let undergraduateDegree =
        Namespaced_IRI.parse _namespace_name "undergraduateDegree" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bachelorOfScience"></see></summary>
    let bachelorOfScience =
        Namespaced_IRI.parse _namespace_name "bachelorOfScience" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#baker"></see>
    /// </summary>
    let baker = Namespaced_IRI.parse _namespace_name "baker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#skilledTrade"></see>
    /// </summary>
    let skilledTrade =
        Namespaced_IRI.parse _namespace_name "skilledTrade" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bankrupt"></see>
    /// </summary>
    let bankrupt = Namespaced_IRI.parse _namespace_name "bankrupt" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#baptistChristianity"></see></summary>
    let baptistChristianity =
        Namespaced_IRI.parse _namespace_name "baptistChristianity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#dissentProtestant"></see>
    /// </summary>
    let dissentProtestant =
        Namespaced_IRI.parse _namespace_name "dissentProtestant" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// Deprecated in favour of instance &lt;a href="#baptistChristianity" title="#baptistChristianity"&gt;Baptist Christianity&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#baptistChurch"></see></summary>
    let baptistChurch =
        Namespaced_IRI.parse _namespace_name "baptistChurch" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d"></see>
    /// </summary>
    let ``bd6e0e18-2543-4310-94da-aae6557df17d`` =
        Namespaced_IRI.parse _namespace_name "bd6e0e18-2543-4310-94da-aae6557df17d" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1"></see>
    /// </summary>
    let ``bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1`` =
        Namespaced_IRI.parse _namespace_name "bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a"></see>
    /// </summary>
    let ``bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a`` =
        Namespaced_IRI.parse _namespace_name "bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2"></see>
    /// </summary>
    let ``bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2`` =
        Namespaced_IRI.parse _namespace_name "bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf"></see>
    /// </summary>
    let ``bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf`` =
        Namespaced_IRI.parse _namespace_name "bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38"></see>
    /// </summary>
    let ``bdfac2f5-ae45-4af7-941c-ec37b12f1a38`` =
        Namespaced_IRI.parse _namespace_name "bdfac2f5-ae45-4af7-941c-ec37b12f1a38" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3"></see>
    /// </summary>
    let ``bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3`` =
        Namespaced_IRI.parse _namespace_name "bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217"></see>
    /// </summary>
    let ``bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217`` =
        Namespaced_IRI.parse _namespace_name "bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#beautician"></see>
    /// </summary>
    let beautician = Namespaced_IRI.parse _namespace_name "beautician" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#beauty"></see>
    /// </summary>
    let beauty = Namespaced_IRI.parse _namespace_name "beauty" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#beggar"></see>
    /// </summary>
    let beggar = Namespaced_IRI.parse _namespace_name "beggar" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#indigent"></see>
    /// </summary>
    let indigent = Namespaced_IRI.parse _namespace_name "indigent" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#behemenism"></see></summary>
    let behemenism = Namespaced_IRI.parse _namespace_name "behemenism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#benedictineOrder"></see></summary>
    let benedictineOrder =
        Namespaced_IRI.parse _namespace_name "benedictineOrder" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#catholicism"></see></summary>
    let catholicism =
        Namespaced_IRI.parse _namespace_name "catholicism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bengaliEthnicity"></see></summary>
    let bengaliEthnicity =
        Namespaced_IRI.parse _namespace_name "bengaliEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bengaliNationalHeritage"></see></summary>
    let bengaliNationalHeritage =
        Namespaced_IRI.parse _namespace_name "bengaliNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bibliography"></see>
    /// </summary>
    let bibliography =
        Namespaced_IRI.parse _namespace_name "bibliography" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bibliophile"></see>
    /// </summary>
    let bibliophile =
        Namespaced_IRI.parse _namespace_name "bibliophile" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#billCollector"></see>
    /// </summary>
    let billCollector =
        Namespaced_IRI.parse _namespace_name "billCollector" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#biologist"></see>
    /// </summary>
    let biologist = Namespaced_IRI.parse _namespace_name "biologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lifeScientist"></see>
    /// </summary>
    let lifeScientist =
        Namespaced_IRI.parse _namespace_name "lifeScientist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#birthControl"></see>
    /// </summary>
    let birthControl =
        Namespaced_IRI.parse _namespace_name "birthControl" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#birthControlActivism"></see></summary>
    let birthControlActivism =
        Namespaced_IRI.parse _namespace_name "birthControlActivism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualReform"></see></summary>
    let sexualReform =
        Namespaced_IRI.parse _namespace_name "sexualReform" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pro-Choice"></see></summary>
    let ``pro-Choice`` =
        Namespaced_IRI.parse _namespace_name "pro-Choice" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#birthDateOf"></see>
    /// </summary>
    let birthDateOf =
        Namespaced_IRI.parse _namespace_name "birthDateOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthDate"></see>
    /// </summary>
    let hasBirthDate =
        Namespaced_IRI.parse _namespace_name "hasBirthDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#birthPlaceOf"></see>
    /// </summary>
    let birthPlaceOf =
        Namespaced_IRI.parse _namespace_name "birthPlaceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPlace"></see>
    /// </summary>
    let hasBirthPlace =
        Namespaced_IRI.parse _namespace_name "hasBirthPlace" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#blackRaceColour" title="#blackRaceColour"&gt;black&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#black"></see></summary>
    let black = Namespaced_IRI.parse _namespace_name "black" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#blackRaceColour"></see></summary>
    let blackRaceColour =
        Namespaced_IRI.parse _namespace_name "blackRaceColour" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#blackEthnicity"></see></summary>
    let blackEthnicity =
        Namespaced_IRI.parse _namespace_name "blackEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#represents"></see>
    /// </summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#blackNationalism"></see></summary>
    let blackNationalism =
        Namespaced_IRI.parse _namespace_name "blackNationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#blackWomanRaceColour"></see>
    /// </summary>
    let blackWomanRaceColour =
        Namespaced_IRI.parse _namespace_name "blackWomanRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#blacksmith"></see>
    /// </summary>
    let blacksmith = Namespaced_IRI.parse _namespace_name "blacksmith" |> NamespacedName

    /// <summary>
    /// Deprecated, with no current equivalence, in favour of definition of family relationships as more fluid and expansive than blood relations.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bloodRelativeOf"></see></summary>
    let bloodRelativeOf =
        Namespaced_IRI.parse _namespace_name "bloodRelativeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#boardMember"></see>
    /// </summary>
    let boardMember =
        Namespaced_IRI.parse _namespace_name "boardMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#boardingHouseKeeper"></see>
    /// </summary>
    let boardingHouseKeeper =
        Namespaced_IRI.parse _namespace_name "boardingHouseKeeper" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#housekeeper"></see>
    /// </summary>
    let housekeeper =
        Namespaced_IRI.parse _namespace_name "housekeeper" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bohemianism"></see>
    /// </summary>
    let bohemianism =
        Namespaced_IRI.parse _namespace_name "bohemianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bookProduction"></see>
    /// </summary>
    let bookProduction =
        Namespaced_IRI.parse _namespace_name "bookProduction" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#publishing"></see>
    /// </summary>
    let publishing = Namespaced_IRI.parse _namespace_name "publishing" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bookbinder"></see>
    /// </summary>
    let bookbinder = Namespaced_IRI.parse _namespace_name "bookbinder" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bookclubParticipatant"></see>
    /// </summary>
    let bookclubParticipatant =
        Namespaced_IRI.parse _namespace_name "bookclubParticipatant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryGroupParticipant"></see>
    /// </summary>
    let literaryGroupParticipant =
        Namespaced_IRI.parse _namespace_name "literaryGroupParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#botanist"></see>
    /// </summary>
    let botanist = Namespaced_IRI.parse _namespace_name "botanist" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#boulangism"></see></summary>
    let boulangism = Namespaced_IRI.parse _namespace_name "boulangism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#brahmin"></see>
    /// </summary>
    let brahmin = Namespaced_IRI.parse _namespace_name "brahmin" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#brewer"></see>
    /// </summary>
    let brewer = Namespaced_IRI.parse _namespace_name "brewer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#britishNationalIdentity"></see>
    /// </summary>
    let britishNationalIdentity =
        Namespaced_IRI.parse _namespace_name "britishNationalIdentity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#britishNationalism"></see></summary>
    let britishNationalism =
        Namespaced_IRI.parse _namespace_name "britishNationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#broadcasting"></see>
    /// </summary>
    let broadcasting =
        Namespaced_IRI.parse _namespace_name "broadcasting" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#brotherOf"></see>
    /// </summary>
    let brotherOf = Namespaced_IRI.parse _namespace_name "brotherOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#siblingOf"></see>
    /// </summary>
    let siblingOf = Namespaced_IRI.parse _namespace_name "siblingOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasBrother"></see>
    /// </summary>
    let hasBrother = Namespaced_IRI.parse _namespace_name "hasBrother" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#buddhism"></see></summary>
    let buddhism = Namespaced_IRI.parse _namespace_name "buddhism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bullionCarrier"></see>
    /// </summary>
    let bullionCarrier =
        Namespaced_IRI.parse _namespace_name "bullionCarrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#burialPlaceOf"></see>
    /// </summary>
    let burialPlaceOf =
        Namespaced_IRI.parse _namespace_name "burialPlaceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasBurialPlace"></see>
    /// </summary>
    let hasBurialPlace =
        Namespaced_IRI.parse _namespace_name "hasBurialPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#bursar"></see>
    /// </summary>
    let bursar = Namespaced_IRI.parse _namespace_name "bursar" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#bushido"></see></summary>
    let bushido = Namespaced_IRI.parse _namespace_name "bushido" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#business"></see>
    /// </summary>
    let business = Namespaced_IRI.parse _namespace_name "business" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#businessOwner"></see>
    /// </summary>
    let businessOwner =
        Namespaced_IRI.parse _namespace_name "businessOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#butcher"></see>
    /// </summary>
    let butcher = Namespaced_IRI.parse _namespace_name "butcher" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c1583789-0dad-41d3-8a42-94d7a8e6d451"></see>
    /// </summary>
    let ``c1583789-0dad-41d3-8a42-94d7a8e6d451`` =
        Namespaced_IRI.parse _namespace_name "c1583789-0dad-41d3-8a42-94d7a8e6d451" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a"></see>
    /// </summary>
    let ``c3a52178-f054-494c-9afd-7421ddcb384a`` =
        Namespaced_IRI.parse _namespace_name "c3a52178-f054-494c-9afd-7421ddcb384a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9"></see>
    /// </summary>
    let ``c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a-partof"></see>
    /// </summary>
    let ``c3a52178-f054-494c-9afd-7421ddcb384a-partof`` =
        Namespaced_IRI.parse _namespace_name "c3a52178-f054-494c-9afd-7421ddcb384a-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c5e7bace-95bb-4820-bd7d-6bb97c1badc5"></see>
    /// </summary>
    let ``c5e7bace-95bb-4820-bd7d-6bb97c1badc5`` =
        Namespaced_IRI.parse _namespace_name "c5e7bace-95bb-4820-bd7d-6bb97c1badc5" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e"></see>
    /// </summary>
    let ``c6a678e5-8fc6-41bc-8631-7cfb7116017e`` =
        Namespaced_IRI.parse _namespace_name "c6a678e5-8fc6-41bc-8631-7cfb7116017e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9"></see>
    /// </summary>
    let ``c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109"></see>
    /// </summary>
    let ``c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109`` =
        Namespaced_IRI.parse _namespace_name "c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe"></see>
    /// </summary>
    let ``c7fcb056-415f-4700-8a9b-d228c9b969fe`` =
        Namespaced_IRI.parse _namespace_name "c7fcb056-415f-4700-8a9b-d228c9b969fe" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9"></see>
    /// </summary>
    let ``c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-partof"></see>
    /// </summary>
    let ``c7fcb056-415f-4700-8a9b-d228c9b969fe-partof`` =
        Namespaced_IRI.parse _namespace_name "c7fcb056-415f-4700-8a9b-d228c9b969fe-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329"></see>
    /// </summary>
    let ``c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329`` =
        Namespaced_IRI.parse _namespace_name "c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e"></see>
    /// </summary>
    let ``c808aed0-eb7b-4c84-9863-63da43401f8e`` =
        Namespaced_IRI.parse _namespace_name "c808aed0-eb7b-4c84-9863-63da43401f8e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762"></see>
    /// </summary>
    let ``c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762`` =
        Namespaced_IRI.parse _namespace_name "c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05"></see>
    /// </summary>
    let ``c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05`` =
        Namespaced_IRI.parse _namespace_name "c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#calligraphy"></see>
    /// </summary>
    let calligraphy =
        Namespaced_IRI.parse _namespace_name "calligraphy" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#calvinism"></see></summary>
    let calvinism = Namespaced_IRI.parse _namespace_name "calvinism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#camisards"></see></summary>
    let camisards = Namespaced_IRI.parse _namespace_name "camisards" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#huguenotNationalHeritage"></see></summary>
    let huguenotNationalHeritage =
        Namespaced_IRI.parse _namespace_name "huguenotNationalHeritage" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#capitalism"></see></summary>
    let capitalism = Namespaced_IRI.parse _namespace_name "capitalism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#captain"></see>
    /// </summary>
    let captain = Namespaced_IRI.parse _namespace_name "captain" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#careGiver"></see>
    /// </summary>
    let careGiver = Namespaced_IRI.parse _namespace_name "careGiver" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#cartesianism"></see></summary>
    let cartesianism =
        Namespaced_IRI.parse _namespace_name "cartesianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#rationalism"></see></summary>
    let rationalism =
        Namespaced_IRI.parse _namespace_name "rationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cartoonist"></see>
    /// </summary>
    let cartoonist = Namespaced_IRI.parse _namespace_name "cartoonist" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#catering"></see>
    /// </summary>
    let catering = Namespaced_IRI.parse _namespace_name "catering" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cooking"></see>
    /// </summary>
    let cooking = Namespaced_IRI.parse _namespace_name "cooking" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// Deprecated in favour of instance &lt;a href="#catholicism" title="#catholicism"&gt;Roman Catholicism&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#catholicChurch"></see></summary>
    let catholicChurch =
        Namespaced_IRI.parse _namespace_name "catholicChurch" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#catholicEmancipation"></see></summary>
    let catholicEmancipation =
        Namespaced_IRI.parse _namespace_name "catholicEmancipation" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#celticEthnicity"></see></summary>
    let celticEthnicity =
        Namespaced_IRI.parse _namespace_name "celticEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#censor"></see>
    /// </summary>
    let censor = Namespaced_IRI.parse _namespace_name "censor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#certaintyOf"></see>
    /// </summary>
    let certaintyOf =
        Namespaced_IRI.parse _namespace_name "certaintyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCertainty"></see>
    /// </summary>
    let hasCertainty =
        Namespaced_IRI.parse _namespace_name "hasCertainty" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#certificate"></see>
    /// </summary>
    let certificate =
        Namespaced_IRI.parse _namespace_name "certificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#chairperson"></see>
    /// </summary>
    let chairperson =
        Namespaced_IRI.parse _namespace_name "chairperson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#chaperone"></see>
    /// </summary>
    let chaperone = Namespaced_IRI.parse _namespace_name "chaperone" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#charityWorker"></see>
    /// </summary>
    let charityWorker =
        Namespaced_IRI.parse _namespace_name "charityWorker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#philanthropist"></see>
    /// </summary>
    let philanthropist =
        Namespaced_IRI.parse _namespace_name "philanthropist" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#chartism"></see></summary>
    let chartism = Namespaced_IRI.parse _namespace_name "chartism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#chemist"></see>
    /// </summary>
    let chemist = Namespaced_IRI.parse _namespace_name "chemist" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#chess"></see>
    /// </summary>
    let chess = Namespaced_IRI.parse _namespace_name "chess" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#childOf"></see>
    /// </summary>
    let childOf = Namespaced_IRI.parse _namespace_name "childOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasChild"></see>
    /// </summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#childcare"></see>
    /// </summary>
    let childcare = Namespaced_IRI.parse _namespace_name "childcare" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#childcareWork"></see>
    /// </summary>
    let childcareWork =
        Namespaced_IRI.parse _namespace_name "childcareWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#childlessness"></see>
    /// </summary>
    let childlessness =
        Namespaced_IRI.parse _namespace_name "childlessness" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#childrensWelfare"></see></summary>
    let childrensWelfare =
        Namespaced_IRI.parse _namespace_name "childrensWelfare" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#chineseEthnicity"></see></summary>
    let chineseEthnicity =
        Namespaced_IRI.parse _namespace_name "chineseEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#christianPacifism"></see></summary>
    let christianPacifism =
        Namespaced_IRI.parse _namespace_name "christianPacifism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#christianScience"></see></summary>
    let christianScience =
        Namespaced_IRI.parse _namespace_name "christianScience" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#christianSocialism"></see></summary>
    let christianSocialism =
        Namespaced_IRI.parse _namespace_name "christianSocialism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// Deprecated in favour of instance &lt;a href="#christianScience" title="#christianScience"&gt;Christian Science&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#churchOfChristianScience"></see></summary>
    let churchOfChristianScience =
        Namespaced_IRI.parse _namespace_name "churchOfChristianScience" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#anglicanism" title="#anglicanism"&gt;Anglicanism&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#churchOfEngland"></see></summary>
    let churchOfEngland =
        Namespaced_IRI.parse _namespace_name "churchOfEngland" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#anglicanism" title="#anglicanism"&gt;Anglicanism&lt;/a&gt;.
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#churchOfIreland"></see></summary>
    let churchOfIreland =
        Namespaced_IRI.parse _namespace_name "churchOfIreland" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cisGender"></see>
    /// </summary>
    let cisGender = Namespaced_IRI.parse _namespace_name "cisGender" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cisMan"></see>
    /// </summary>
    let cisMan = Namespaced_IRI.parse _namespace_name "cisMan" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#manLabel"></see>
    /// </summary>
    let manLabel = Namespaced_IRI.parse _namespace_name "manLabel" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cisWoman"></see>
    /// </summary>
    let cisWoman = Namespaced_IRI.parse _namespace_name "cisWoman" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#womanLabel"></see>
    /// </summary>
    let womanLabel = Namespaced_IRI.parse _namespace_name "womanLabel" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#civilLibertarianism"></see></summary>
    let civilLibertarianism =
        Namespaced_IRI.parse _namespace_name "civilLibertarianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#libertarianism"></see></summary>
    let libertarianism =
        Namespaced_IRI.parse _namespace_name "libertarianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#classicist"></see>
    /// </summary>
    let classicist = Namespaced_IRI.parse _namespace_name "classicist" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cleaner"></see>
    /// </summary>
    let cleaner = Namespaced_IRI.parse _namespace_name "cleaner" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#domesticServant"></see>
    /// </summary>
    let domesticServant =
        Namespaced_IRI.parse _namespace_name "domesticServant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#clericalWork"></see>
    /// </summary>
    let clericalWork =
        Namespaced_IRI.parse _namespace_name "clericalWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#clothingProduction"></see>
    /// </summary>
    let clothingProduction =
        Namespaced_IRI.parse _namespace_name "clothingProduction" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#clothworker"></see>
    /// </summary>
    let clothworker =
        Namespaced_IRI.parse _namespace_name "clothworker" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#co-operativeMovement"></see></summary>
    let ``co-operativeMovement`` =
        Namespaced_IRI.parse _namespace_name "co-operativeMovement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#coach"></see>
    /// </summary>
    let coach = Namespaced_IRI.parse _namespace_name "coach" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sports"></see>
    /// </summary>
    let sports = Namespaced_IRI.parse _namespace_name "sports" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#coastGuard"></see>
    /// </summary>
    let coastGuard = Namespaced_IRI.parse _namespace_name "coastGuard" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lawEnforcement"></see>
    /// </summary>
    let lawEnforcement =
        Namespaced_IRI.parse _namespace_name "lawEnforcement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cobbler"></see>
    /// </summary>
    let cobbler = Namespaced_IRI.parse _namespace_name "cobbler" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#collector"></see>
    /// </summary>
    let collector = Namespaced_IRI.parse _namespace_name "collector" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#colonialOfficial"></see>
    /// </summary>
    let colonialOfficial =
        Namespaced_IRI.parse _namespace_name "colonialOfficial" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#government"></see>
    /// </summary>
    let government = Namespaced_IRI.parse _namespace_name "government" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#commissioner"></see>
    /// </summary>
    let commissioner =
        Namespaced_IRI.parse _namespace_name "commissioner" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#committeeMember"></see>
    /// </summary>
    let committeeMember =
        Namespaced_IRI.parse _namespace_name "committeeMember" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#communalism"></see></summary>
    let communalism =
        Namespaced_IRI.parse _namespace_name "communalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#communeOrganizer"></see>
    /// </summary>
    let communeOrganizer =
        Namespaced_IRI.parse _namespace_name "communeOrganizer" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#liberalism"></see></summary>
    let liberalism = Namespaced_IRI.parse _namespace_name "liberalism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#marxism"></see></summary>
    let marxism = Namespaced_IRI.parse _namespace_name "marxism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#maoism"></see></summary>
    let maoism = Namespaced_IRI.parse _namespace_name "maoism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#companion"></see>
    /// </summary>
    let companion = Namespaced_IRI.parse _namespace_name "companion" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#composer"></see>
    /// </summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#music"></see>
    /// </summary>
    let music = Namespaced_IRI.parse _namespace_name "music" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#computerScientist"></see>
    /// </summary>
    let computerScientist =
        Namespaced_IRI.parse _namespace_name "computerScientist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#computerWork"></see>
    /// </summary>
    let computerWork =
        Namespaced_IRI.parse _namespace_name "computerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#dataProcessing"></see>
    /// </summary>
    let dataProcessing =
        Namespaced_IRI.parse _namespace_name "dataProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#confectioner"></see>
    /// </summary>
    let confectioner =
        Namespaced_IRI.parse _namespace_name "confectioner" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#congregationalism" title="#congregationalism"&gt;Congregationalism&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#congregationalChurch"></see></summary>
    let congregationalChurch =
        Namespaced_IRI.parse _namespace_name "congregationalChurch" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#congregationalism"></see></summary>
    let congregationalism =
        Namespaced_IRI.parse _namespace_name "congregationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#connoisseur"></see>
    /// </summary>
    let connoisseur =
        Namespaced_IRI.parse _namespace_name "connoisseur" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#conscientiousObjection"></see></summary>
    let conscientiousObjection =
        Namespaced_IRI.parse _namespace_name "conscientiousObjection" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#conservationist"></see>
    /// </summary>
    let conservationist =
        Namespaced_IRI.parse _namespace_name "conservationist" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#conservatism"></see></summary>
    let conservatism =
        Namespaced_IRI.parse _namespace_name "conservatism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#neo-Conservatism"></see></summary>
    let ``neo-Conservatism`` =
        Namespaced_IRI.parse _namespace_name "neo-Conservatism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#conservativeFeminism"></see></summary>
    let conservativeFeminism =
        Namespaced_IRI.parse _namespace_name "conservativeFeminism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#conservativePartyUk"></see></summary>
    let conservativePartyUk =
        Namespaced_IRI.parse _namespace_name "conservativePartyUk" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#constitutionalism"></see></summary>
    let constitutionalism =
        Namespaced_IRI.parse _namespace_name "constitutionalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#construction"></see>
    /// </summary>
    let construction =
        Namespaced_IRI.parse _namespace_name "construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#consultant"></see>
    /// </summary>
    let consultant = Namespaced_IRI.parse _namespace_name "consultant" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#contractor"></see>
    /// </summary>
    let contractor = Namespaced_IRI.parse _namespace_name "contractor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#coopOrganizer"></see>
    /// </summary>
    let coopOrganizer =
        Namespaced_IRI.parse _namespace_name "coopOrganizer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cooper"></see>
    /// </summary>
    let cooper = Namespaced_IRI.parse _namespace_name "cooper" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#copyist"></see>
    /// </summary>
    let copyist = Namespaced_IRI.parse _namespace_name "copyist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#transcriber"></see>
    /// </summary>
    let transcriber =
        Namespaced_IRI.parse _namespace_name "transcriber" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#cornishNationalHeritage"></see></summary>
    let cornishNationalHeritage =
        Namespaced_IRI.parse _namespace_name "cornishNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#corporateDirector"></see>
    /// </summary>
    let corporateDirector =
        Namespaced_IRI.parse _namespace_name "corporateDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#counsellor"></see>
    /// </summary>
    let counsellor = Namespaced_IRI.parse _namespace_name "counsellor" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#courtier"></see>
    /// </summary>
    let courtier = Namespaced_IRI.parse _namespace_name "courtier" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cousinOf"></see>
    /// </summary>
    let cousinOf = Namespaced_IRI.parse _namespace_name "cousinOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCousin"></see>
    /// </summary>
    let hasCousin = Namespaced_IRI.parse _namespace_name "hasCousin" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#covenanters"></see></summary>
    let covenanters =
        Namespaced_IRI.parse _namespace_name "covenanters" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#craftsperson"></see>
    /// </summary>
    let craftsperson =
        Namespaced_IRI.parse _namespace_name "craftsperson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#credentialHeldBy"></see>
    /// </summary>
    let credentialHeldBy =
        Namespaced_IRI.parse _namespace_name "credentialHeldBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialIn"></see>
    /// </summary>
    let hasCredentialIn =
        Namespaced_IRI.parse _namespace_name "hasCredentialIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#credentialSubjectOf"></see>
    /// </summary>
    let credentialSubjectOf =
        Namespaced_IRI.parse _namespace_name "credentialSubjectOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialSubject"></see>
    /// </summary>
    let hasCredentialSubject =
        Namespaced_IRI.parse _namespace_name "hasCredentialSubject" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#creoleEthnicity"></see></summary>
    let creoleEthnicity =
        Namespaced_IRI.parse _namespace_name "creoleEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#creoleRaceColour"></see>
    /// </summary>
    let creoleRaceColour =
        Namespaced_IRI.parse _namespace_name "creoleRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cricket"></see>
    /// </summary>
    let cricket = Namespaced_IRI.parse _namespace_name "cricket" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#criminal"></see>
    /// </summary>
    let criminal = Namespaced_IRI.parse _namespace_name "criminal" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#critic"></see>
    /// </summary>
    let critic = Namespaced_IRI.parse _namespace_name "critic" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#writer"></see>
    /// </summary>
    let writer = Namespaced_IRI.parse _namespace_name "writer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#culturalFormOf"></see>
    /// </summary>
    let culturalFormOf =
        Namespaced_IRI.parse _namespace_name "culturalFormOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCulturalForm"></see>
    /// </summary>
    let hasCulturalForm =
        Namespaced_IRI.parse _namespace_name "hasCulturalForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#curator"></see>
    /// </summary>
    let curator = Namespaced_IRI.parse _namespace_name "curator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#exhibitions"></see>
    /// </summary>
    let exhibitions =
        Namespaced_IRI.parse _namespace_name "exhibitions" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#cyclist"></see>
    /// </summary>
    let cyclist = Namespaced_IRI.parse _namespace_name "cyclist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d53c6644-df5c-43d7-86d3-2954c0d5a656"></see>
    /// </summary>
    let ``d53c6644-df5c-43d7-86d3-2954c0d5a656`` =
        Namespaced_IRI.parse _namespace_name "d53c6644-df5c-43d7-86d3-2954c0d5a656" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176"></see>
    /// </summary>
    let ``d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176`` =
        Namespaced_IRI.parse _namespace_name "d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7"></see>
    /// </summary>
    let ``d596c4a0-ecaf-4739-8a58-3e0af7dba4c7`` =
        Namespaced_IRI.parse _namespace_name "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf"></see>
    /// </summary>
    let ``d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf`` =
        Namespaced_IRI.parse _namespace_name "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4"></see>
    /// </summary>
    let ``d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4`` =
        Namespaced_IRI.parse _namespace_name "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94"></see>
    /// </summary>
    let ``d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94`` =
        Namespaced_IRI.parse _namespace_name "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174"></see>
    /// </summary>
    let ``d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174`` =
        Namespaced_IRI.parse _namespace_name "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f"></see>
    /// </summary>
    let ``d95dce89-623d-4226-afd5-c602db0b6c7f`` =
        Namespaced_IRI.parse _namespace_name "d95dce89-623d-4226-afd5-c602db0b6c7f" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9"></see>
    /// </summary>
    let ``d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f-partof"></see>
    /// </summary>
    let ``d95dce89-623d-4226-afd5-c602db0b6c7f-partof`` =
        Namespaced_IRI.parse _namespace_name "d95dce89-623d-4226-afd5-c602db0b6c7f-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#dairyWork"></see>
    /// </summary>
    let dairyWork = Namespaced_IRI.parse _namespace_name "dairyWork" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#farming"></see>
    /// </summary>
    let farming = Namespaced_IRI.parse _namespace_name "farming" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#dance"></see>
    /// </summary>
    let dance = Namespaced_IRI.parse _namespace_name "dance" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#darwinism"></see></summary>
    let darwinism = Namespaced_IRI.parse _namespace_name "darwinism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#secularism"></see></summary>
    let secularism = Namespaced_IRI.parse _namespace_name "secularism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#AbiLemak"></see>
    /// </summary>
    let AbiLemak = Namespaced_IRI.parse _namespace_name "AbiLemak" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#daughterOf"></see>
    /// </summary>
    let daughterOf = Namespaced_IRI.parse _namespace_name "daughterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasDaughter"></see>
    /// </summary>
    let hasDaughter =
        Namespaced_IRI.parse _namespace_name "hasDaughter" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#db2f8571-a773-4068-a35f-34262950bb8f"></see>
    /// </summary>
    let ``db2f8571-a773-4068-a35f-34262950bb8f`` =
        Namespaced_IRI.parse _namespace_name "db2f8571-a773-4068-a35f-34262950bb8f" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#db2f8571-a773-4068-a35f-34262950bb8f-9841babf77"></see>
    /// </summary>
    let ``db2f8571-a773-4068-a35f-34262950bb8f-9841babf77`` =
        Namespaced_IRI.parse _namespace_name "db2f8571-a773-4068-a35f-34262950bb8f-9841babf77" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07"></see>
    /// </summary>
    let ``db3de175-7d4a-4860-908b-a905b9cc9b07`` =
        Namespaced_IRI.parse _namespace_name "db3de175-7d4a-4860-908b-a905b9cc9b07" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76"></see>
    /// </summary>
    let ``db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76`` =
        Namespaced_IRI.parse _namespace_name "db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d"></see>
    /// </summary>
    let ``db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d`` =
        Namespaced_IRI.parse _namespace_name "db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#deathDateOf"></see>
    /// </summary>
    let deathDateOf =
        Namespaced_IRI.parse _namespace_name "deathDateOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasDeathDate"></see>
    /// </summary>
    let hasDeathDate =
        Namespaced_IRI.parse _namespace_name "hasDeathDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#deathPlaceOf"></see>
    /// </summary>
    let deathPlaceOf =
        Namespaced_IRI.parse _namespace_name "deathPlaceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasDeathPlace"></see>
    /// </summary>
    let hasDeathPlace =
        Namespaced_IRI.parse _namespace_name "hasDeathPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#decoder"></see>
    /// </summary>
    let decoder = Namespaced_IRI.parse _namespace_name "decoder" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#deism"></see></summary>
    let deism = Namespaced_IRI.parse _namespace_name "deism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#deliveryPerson"></see>
    /// </summary>
    let deliveryPerson =
        Namespaced_IRI.parse _namespace_name "deliveryPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#democrat"></see>
    /// </summary>
    let democrat = Namespaced_IRI.parse _namespace_name "democrat" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#dentist"></see>
    /// </summary>
    let dentist = Namespaced_IRI.parse _namespace_name "dentist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#healthCareProvider"></see>
    /// </summary>
    let healthCareProvider =
        Namespaced_IRI.parse _namespace_name "healthCareProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#designer"></see>
    /// </summary>
    let designer = Namespaced_IRI.parse _namespace_name "designer" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#determinism"></see></summary>
    let determinism =
        Namespaced_IRI.parse _namespace_name "determinism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad"></see>
    /// </summary>
    let ``df029fed-c7f8-4438-97a4-33d9ff712cad`` =
        Namespaced_IRI.parse _namespace_name "df029fed-c7f8-4438-97a4-33d9ff712cad" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51"></see>
    /// </summary>
    let ``df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51`` =
        Namespaced_IRI.parse _namespace_name "df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9"></see>
    /// </summary>
    let ``df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9`` =
        Namespaced_IRI.parse _namespace_name "df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#diploma"></see>
    /// </summary>
    let diploma = Namespaced_IRI.parse _namespace_name "diploma" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#diplomat"></see>
    /// </summary>
    let diplomat = Namespaced_IRI.parse _namespace_name "diplomat" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#director"></see>
    /// </summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName
    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#dissentProtestant" title="#dissentProtestant"&gt;Dissent (Protestant)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#dissenters"></see></summary>
    let dissenters = Namespaced_IRI.parse _namespace_name "dissenters" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#dissentingChristianity"></see></summary>
    let dissentingChristianity =
        Namespaced_IRI.parse _namespace_name "dissentingChristianity" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#dissentProtestant" title="#dissentProtestant"&gt;Dissent (Protestant)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#dissentingChurches"></see></summary>
    let dissentingChurches =
        Namespaced_IRI.parse _namespace_name "dissentingChurches" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#diver"></see>
    /// </summary>
    let diver = Namespaced_IRI.parse _namespace_name "diver" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#dockyardWork"></see>
    /// </summary>
    let dockyardWork =
        Namespaced_IRI.parse _namespace_name "dockyardWork" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#doctorOfPhilosophy"></see></summary>
    let doctorOfPhilosophy =
        Namespaced_IRI.parse _namespace_name "doctorOfPhilosophy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#postgraduateDegree"></see>
    /// </summary>
    let postgraduateDegree =
        Namespaced_IRI.parse _namespace_name "postgraduateDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#domainIncludes"></see>
    /// </summary>
    let domainIncludes =
        Namespaced_IRI.parse _namespace_name "domainIncludes" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#servant"></see>
    /// </summary>
    let servant = Namespaced_IRI.parse _namespace_name "servant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#domesticWork"></see>
    /// </summary>
    let domesticWork =
        Namespaced_IRI.parse _namespace_name "domesticWork" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#dominicanOrder"></see></summary>
    let dominicanOrder =
        Namespaced_IRI.parse _namespace_name "dominicanOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#draper"></see>
    /// </summary>
    let draper = Namespaced_IRI.parse _namespace_name "draper" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#dressReform"></see></summary>
    let dressReform =
        Namespaced_IRI.parse _namespace_name "dressReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#dressmaking"></see>
    /// </summary>
    let dressmaking =
        Namespaced_IRI.parse _namespace_name "dressmaking" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#tailor"></see>
    /// </summary>
    let tailor = Namespaced_IRI.parse _namespace_name "tailor" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#drinking"></see>
    /// </summary>
    let drinking = Namespaced_IRI.parse _namespace_name "drinking" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#drugUse"></see>
    /// </summary>
    let drugUse = Namespaced_IRI.parse _namespace_name "drugUse" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#dutchNationalHeritage"></see></summary>
    let dutchNationalHeritage =
        Namespaced_IRI.parse _namespace_name "dutchNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e"></see>
    /// </summary>
    let ``e053e9f1-37ea-407d-b0cd-caaf413c142e`` =
        Namespaced_IRI.parse _namespace_name "e053e9f1-37ea-407d-b0cd-caaf413c142e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd"></see>
    /// </summary>
    let ``e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd`` =
        Namespaced_IRI.parse _namespace_name "e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9"></see>
    /// </summary>
    let ``e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9`` =
        Namespaced_IRI.parse _namespace_name "e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7"></see>
    /// </summary>
    let ``e1f710d3-6ebd-4181-be61-bf931282a8b7`` =
        Namespaced_IRI.parse _namespace_name "e1f710d3-6ebd-4181-be61-bf931282a8b7" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9"></see>
    /// </summary>
    let ``e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9`` =
        Namespaced_IRI.parse _namespace_name "e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e"></see>
    /// </summary>
    let ``e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e`` =
        Namespaced_IRI.parse _namespace_name "e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036"></see>
    /// </summary>
    let ``e2c7e804-1fa1-4575-b2a1-bf284412e036`` =
        Namespaced_IRI.parse _namespace_name "e2c7e804-1fa1-4575-b2a1-bf284412e036" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526"></see>
    /// </summary>
    let ``e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526`` =
        Namespaced_IRI.parse _namespace_name "e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816"></see>
    /// </summary>
    let ``e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816`` =
        Namespaced_IRI.parse _namespace_name "e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07"></see>
    /// </summary>
    let ``ea282bf0-da27-4ecc-98bd-e1aff595fc07`` =
        Namespaced_IRI.parse _namespace_name "ea282bf0-da27-4ecc-98bd-e1aff595fc07" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a"></see>
    /// </summary>
    let ``ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a`` =
        Namespaced_IRI.parse _namespace_name "ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d"></see>
    /// </summary>
    let ``ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d`` =
        Namespaced_IRI.parse _namespace_name "ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#easternReligions"></see></summary>
    let easternReligions =
        Namespaced_IRI.parse _namespace_name "easternReligions" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314"></see>
    /// </summary>
    let ``ebbb5e23-2c34-4810-b921-1d72694af314`` =
        Namespaced_IRI.parse _namespace_name "ebbb5e23-2c34-4810-b921-1d72694af314" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b"></see>
    /// </summary>
    let ``ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b`` =
        Namespaced_IRI.parse _namespace_name "ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799"></see>
    /// </summary>
    let ``ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799`` =
        Namespaced_IRI.parse _namespace_name "ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077"></see>
    /// </summary>
    let ``ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077`` =
        Namespaced_IRI.parse _namespace_name "ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-partof"></see>
    /// </summary>
    let ``ebbb5e23-2c34-4810-b921-1d72694af314-partof`` =
        Namespaced_IRI.parse _namespace_name "ebbb5e23-2c34-4810-b921-1d72694af314-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4"></see>
    /// </summary>
    let ``ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4`` =
        Namespaced_IRI.parse _namespace_name "ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470"></see>
    /// </summary>
    let ``ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470`` =
        Namespaced_IRI.parse _namespace_name "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c"></see>
    /// </summary>
    let ``ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c`` =
        Namespaced_IRI.parse _namespace_name "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f"></see>
    /// </summary>
    let ``ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f`` =
        Namespaced_IRI.parse _namespace_name "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#ecumenism"></see></summary>
    let ecumenism = Namespaced_IRI.parse _namespace_name "ecumenism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#editing"></see>
    /// </summary>
    let editing = Namespaced_IRI.parse _namespace_name "editing" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#educationReform"></see></summary>
    let educationReform =
        Namespaced_IRI.parse _namespace_name "educationReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#educationalAdministration"></see>
    /// </summary>
    let educationalAdministration =
        Namespaced_IRI.parse _namespace_name "educationalAdministration" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#educationalAwardPrize"></see>
    /// </summary>
    let educationalAwardPrize =
        Namespaced_IRI.parse _namespace_name "educationalAwardPrize" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#educationalAwardScholarship"></see>
    /// </summary>
    let educationalAwardScholarship =
        Namespaced_IRI.parse _namespace_name "educationalAwardScholarship" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#egalitarianism"></see></summary>
    let egalitarianism =
        Namespaced_IRI.parse _namespace_name "egalitarianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#egyptianNationalism"></see></summary>
    let egyptianNationalism =
        Namespaced_IRI.parse _namespace_name "egyptianNationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#elderRights"></see></summary>
    let elderRights =
        Namespaced_IRI.parse _namespace_name "elderRights" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#eldestChild"></see>
    /// </summary>
    let eldestChild =
        Namespaced_IRI.parse _namespace_name "eldestChild" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#elevatorOperator"></see>
    /// </summary>
    let elevatorOperator =
        Namespaced_IRI.parse _namespace_name "elevatorOperator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#elocutionist"></see>
    /// </summary>
    let elocutionist =
        Namespaced_IRI.parse _namespace_name "elocutionist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#employer"></see>
    /// </summary>
    let employer = Namespaced_IRI.parse _namespace_name "employer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#employmentAgent"></see>
    /// </summary>
    let employmentAgent =
        Namespaced_IRI.parse _namespace_name "employmentAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#engineering"></see>
    /// </summary>
    let engineering =
        Namespaced_IRI.parse _namespace_name "engineering" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#englishGeographicHeritage" title="#englishGeographicHeritage"&gt;England&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#england"></see></summary>
    let england = Namespaced_IRI.parse _namespace_name "england" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#englishGeographicHeritage"></see>
    /// </summary>
    let englishGeographicHeritage =
        Namespaced_IRI.parse _namespace_name "englishGeographicHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#englishLabel"></see>
    /// </summary>
    let englishLabel =
        Namespaced_IRI.parse _namespace_name "englishLabel" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#englishLabel" title="#englishLabel"&gt;English identity&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#englandLabel"></see></summary>
    let englandLabel =
        Namespaced_IRI.parse _namespace_name "englandLabel" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#englishEthnicity"></see></summary>
    let englishEthnicity =
        Namespaced_IRI.parse _namespace_name "englishEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#englishRaceColour"></see></summary>
    let englishRaceColour =
        Namespaced_IRI.parse _namespace_name "englishRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#engraver"></see>
    /// </summary>
    let engraver = Namespaced_IRI.parse _namespace_name "engraver" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#entrepreneurial-industrialist" title="#entrepreneurial-industrialist"&gt;entrepreneurial&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#entrepreneurial-industrialism"></see></summary>
    let ``entrepreneurial-industrialism`` =
        Namespaced_IRI.parse _namespace_name "entrepreneurial-industrialism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#entrepreneurial-industrialist"></see>
    /// </summary>
    let ``entrepreneurial-industrialist`` =
        Namespaced_IRI.parse _namespace_name "entrepreneurial-industrialist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#equineActivity"></see>
    /// </summary>
    let equineActivity =
        Namespaced_IRI.parse _namespace_name "equineActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicityOf"></see>
    /// </summary>
    let ethnicityOf =
        Namespaced_IRI.parse _namespace_name "ethnicityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicityReportedOf"></see>
    /// </summary>
    let ethnicityReportedOf =
        Namespaced_IRI.parse _namespace_name "ethnicityReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicitySelfReportedOf"></see>
    /// </summary>
    let ethnicitySelfReportedOf =
        Namespaced_IRI.parse _namespace_name "ethnicitySelfReportedOf" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#eugenics"></see></summary>
    let eugenics = Namespaced_IRI.parse _namespace_name "eugenics" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#eurasianLabel"></see>
    /// </summary>
    let eurasianLabel =
        Namespaced_IRI.parse _namespace_name "eurasianLabel" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#eurasianRaceColour"></see></summary>
    let eurasianRaceColour =
        Namespaced_IRI.parse _namespace_name "eurasianRaceColour" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// Deprecated in favour of instance &lt;a href="#eurasianRaceColour" title="#eurasianRaceColour"&gt;eurasian&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#eurasianRace"></see></summary>
    let eurasianRace =
        Namespaced_IRI.parse _namespace_name "eurasianRace" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#europeanNationalHeritage"></see>
    /// </summary>
    let europeanNationalHeritage =
        Namespaced_IRI.parse _namespace_name "europeanNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#europeanNationalIdentity"></see>
    /// </summary>
    let europeanNationalIdentity =
        Namespaced_IRI.parse _namespace_name "europeanNationalIdentity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#evangelicalism"></see></summary>
    let evangelicalism =
        Namespaced_IRI.parse _namespace_name "evangelicalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#eventOf"></see>
    /// </summary>
    let eventOf = Namespaced_IRI.parse _namespace_name "eventOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEvent"></see>
    /// </summary>
    let hasEvent = Namespaced_IRI.parse _namespace_name "hasEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#eventOrganizer"></see>
    /// </summary>
    let eventOrganizer =
        Namespaced_IRI.parse _namespace_name "eventOrganizer" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#existentialism"></see></summary>
    let existentialism =
        Namespaced_IRI.parse _namespace_name "existentialism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#explorer"></see>
    /// </summary>
    let explorer = Namespaced_IRI.parse _namespace_name "explorer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35"></see>
    /// </summary>
    let ``f3666ac1-4f95-4f12-a02e-88ed27197d35`` =
        Namespaced_IRI.parse _namespace_name "f3666ac1-4f95-4f12-a02e-88ed27197d35" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127"></see>
    /// </summary>
    let ``f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127`` =
        Namespaced_IRI.parse _namespace_name "f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86"></see>
    /// </summary>
    let ``f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86`` =
        Namespaced_IRI.parse _namespace_name "f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d"></see>
    /// </summary>
    let ``f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d`` =
        Namespaced_IRI.parse _namespace_name "f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376"></see>
    /// </summary>
    let ``f62e94d6-bd04-494c-9282-53af0a3f3376`` =
        Namespaced_IRI.parse _namespace_name "f62e94d6-bd04-494c-9282-53af0a3f3376" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794"></see>
    /// </summary>
    let ``f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794`` =
        Namespaced_IRI.parse _namespace_name "f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376-partof"></see>
    /// </summary>
    let ``f62e94d6-bd04-494c-9282-53af0a3f3376-partof`` =
        Namespaced_IRI.parse _namespace_name "f62e94d6-bd04-494c-9282-53af0a3f3376-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96"></see>
    /// </summary>
    let ``f77171be-f937-4067-8dbe-fd9982822a96`` =
        Namespaced_IRI.parse _namespace_name "f77171be-f937-4067-8dbe-fd9982822a96" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b"></see>
    /// </summary>
    let ``f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b`` =
        Namespaced_IRI.parse _namespace_name "f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea"></see>
    /// </summary>
    let ``f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea`` =
        Namespaced_IRI.parse _namespace_name "f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d"></see>
    /// </summary>
    let ``fab56e35-9796-4e6d-861d-a6b626f5714d`` =
        Namespaced_IRI.parse _namespace_name "fab56e35-9796-4e6d-861d-a6b626f5714d" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86"></see>
    /// </summary>
    let ``fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86`` =
        Namespaced_IRI.parse _namespace_name "fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof"></see>
    /// </summary>
    let ``fab56e35-9796-4e6d-861d-a6b626f5714d-partof`` =
        Namespaced_IRI.parse _namespace_name "fab56e35-9796-4e6d-861d-a6b626f5714d-partof" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc"></see>
    /// </summary>
    let ``fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc`` =
        Namespaced_IRI.parse _namespace_name "fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352"></see>
    /// </summary>
    let ``fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352`` =
        Namespaced_IRI.parse _namespace_name "fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#factoryWorker"></see>
    /// </summary>
    let factoryWorker =
        Namespaced_IRI.parse _namespace_name "factoryWorker" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#faithHealing"></see></summary>
    let faithHealing =
        Namespaced_IRI.parse _namespace_name "faithHealing" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#familyBasedOccupationOf"></see>
    /// </summary>
    let familyBasedOccupationOf =
        Namespaced_IRI.parse _namespace_name "familyBasedOccupationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#occupationOf"></see>
    /// </summary>
    let occupationOf =
        Namespaced_IRI.parse _namespace_name "occupationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fashion"></see>
    /// </summary>
    let fashion = Namespaced_IRI.parse _namespace_name "fashion" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#fatalism"></see></summary>
    let fatalism = Namespaced_IRI.parse _namespace_name "fatalism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fatherOf"></see>
    /// </summary>
    let fatherOf = Namespaced_IRI.parse _namespace_name "fatherOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#parentOf"></see>
    /// </summary>
    let parentOf = Namespaced_IRI.parse _namespace_name "parentOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasFather"></see>
    /// </summary>
    let hasFather = Namespaced_IRI.parse _namespace_name "hasFather" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fellow"></see>
    /// </summary>
    let fellow = Namespaced_IRI.parse _namespace_name "fellow" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#feministAnti-ViolenceActivism"></see></summary>
    let ``feministAnti-ViolenceActivism`` =
        Namespaced_IRI.parse _namespace_name "feministAnti-ViolenceActivism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#feministInternationalism"></see></summary>
    let feministInternationalism =
        Namespaced_IRI.parse _namespace_name "feministInternationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#internationalism"></see></summary>
    let internationalism =
        Namespaced_IRI.parse _namespace_name "internationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#feministPacifism"></see></summary>
    let feministPacifism =
        Namespaced_IRI.parse _namespace_name "feministPacifism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1"></see>
    /// </summary>
    let ``ffd10388-4cd6-429c-9ca0-b4d9476496a1`` =
        Namespaced_IRI.parse _namespace_name "ffd10388-4cd6-429c-9ca0-b4d9476496a1" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311"></see>
    /// </summary>
    let ``ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311`` =
        Namespaced_IRI.parse _namespace_name "ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c"></see>
    /// </summary>
    let ``ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c`` =
        Namespaced_IRI.parse _namespace_name "ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#fifthMonarchists"></see></summary>
    let fifthMonarchists =
        Namespaced_IRI.parse _namespace_name "fifthMonarchists" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#millenarianism"></see></summary>
    let millenarianism =
        Namespaced_IRI.parse _namespace_name "millenarianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#filmIndustry"></see>
    /// </summary>
    let filmIndustry =
        Namespaced_IRI.parse _namespace_name "filmIndustry" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#investor"></see>
    /// </summary>
    let investor = Namespaced_IRI.parse _namespace_name "investor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#firefighter"></see>
    /// </summary>
    let firefighter =
        Namespaced_IRI.parse _namespace_name "firefighter" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#firstAid"></see>
    /// </summary>
    let firstAid = Namespaced_IRI.parse _namespace_name "firstAid" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fisherman"></see>
    /// </summary>
    let fisherman = Namespaced_IRI.parse _namespace_name "fisherman" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fishmonger"></see>
    /// </summary>
    let fishmonger = Namespaced_IRI.parse _namespace_name "fishmonger" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#flemishNationalHeritage"></see></summary>
    let flemishNationalHeritage =
        Namespaced_IRI.parse _namespace_name "flemishNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#florentineNationalIdentity"></see>
    /// </summary>
    let florentineNationalIdentity =
        Namespaced_IRI.parse _namespace_name "florentineNationalIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#foodDistribution"></see>
    /// </summary>
    let foodDistribution =
        Namespaced_IRI.parse _namespace_name "foodDistribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#merchant"></see>
    /// </summary>
    let merchant = Namespaced_IRI.parse _namespace_name "merchant" |> NamespacedName
    /// <summary>
    /// Deprecated, with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#forebearOf"></see></summary>
    let forebearOf = Namespaced_IRI.parse _namespace_name "forebearOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fosterParent"></see>
    /// </summary>
    let fosterParent =
        Namespaced_IRI.parse _namespace_name "fosterParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#founder"></see>
    /// </summary>
    let founder = Namespaced_IRI.parse _namespace_name "founder" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#freeTradeMovement"></see></summary>
    let freeTradeMovement =
        Namespaced_IRI.parse _namespace_name "freeTradeMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#freemasonry"></see></summary>
    let freemasonry =
        Namespaced_IRI.parse _namespace_name "freemasonry" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#freethought"></see></summary>
    let freethought =
        Namespaced_IRI.parse _namespace_name "freethought" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#frenchNationalism"></see></summary>
    let frenchNationalism =
        Namespaced_IRI.parse _namespace_name "frenchNationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#fundraiser"></see>
    /// </summary>
    let fundraiser = Namespaced_IRI.parse _namespace_name "fundraiser" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#gaelEthnicity"></see></summary>
    let gaelEthnicity =
        Namespaced_IRI.parse _namespace_name "gaelEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#scottishEthnicity"></see></summary>
    let scottishEthnicity =
        Namespaced_IRI.parse _namespace_name "scottishEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#gambling"></see>
    /// </summary>
    let gambling = Namespaced_IRI.parse _namespace_name "gambling" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#gardener"></see>
    /// </summary>
    let gardener = Namespaced_IRI.parse _namespace_name "gardener" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#gastronome"></see>
    /// </summary>
    let gastronome = Namespaced_IRI.parse _namespace_name "gastronome" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#gayRights"></see></summary>
    let gayRights = Namespaced_IRI.parse _namespace_name "gayRights" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#man" title="#man"&gt;man&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#genderManMale"></see></summary>
    let genderManMale =
        Namespaced_IRI.parse _namespace_name "genderManMale" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#man"></see>
    /// </summary>
    let man = Namespaced_IRI.parse _namespace_name "man" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#genderOf"></see>
    /// </summary>
    let genderOf = Namespaced_IRI.parse _namespace_name "genderOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#genderReportedOf"></see>
    /// </summary>
    let genderReportedOf =
        Namespaced_IRI.parse _namespace_name "genderReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#genderSelfReportedOf"></see>
    /// </summary>
    let genderSelfReportedOf =
        Namespaced_IRI.parse _namespace_name "genderSelfReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#transMan" title="#transMan"&gt;transman/transmale&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#genderTransMan"></see></summary>
    let genderTransMan =
        Namespaced_IRI.parse _namespace_name "genderTransMan" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#transMan"></see>
    /// </summary>
    let transMan = Namespaced_IRI.parse _namespace_name "transMan" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#transWoman" title="#transWoman"&gt;transwoman/transfemale&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#genderTransWoman"></see></summary>
    let genderTransWoman =
        Namespaced_IRI.parse _namespace_name "genderTransWoman" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#transWoman"></see>
    /// </summary>
    let transWoman = Namespaced_IRI.parse _namespace_name "transWoman" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#woman"></see>
    /// </summary>
    let woman = Namespaced_IRI.parse _namespace_name "woman" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#genealogist"></see>
    /// </summary>
    let genealogist =
        Namespaced_IRI.parse _namespace_name "genealogist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#gentleman"></see>
    /// </summary>
    let gentleman = Namespaced_IRI.parse _namespace_name "gentleman" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#gentry"></see>
    /// </summary>
    let gentry = Namespaced_IRI.parse _namespace_name "gentry" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#geographer"></see>
    /// </summary>
    let geographer = Namespaced_IRI.parse _namespace_name "geographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageOf"></see>
    /// </summary>
    let geographicHeritageOf =
        Namespaced_IRI.parse _namespace_name "geographicHeritageOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageReportedOf"></see>
    /// </summary>
    let geographicHeritageReportedOf =
        Namespaced_IRI.parse _namespace_name "geographicHeritageReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageSelfReportedOf"></see>
    /// </summary>
    let geographicHeritageSelfReportedOf =
        Namespaced_IRI.parse _namespace_name "geographicHeritageSelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#geologist"></see>
    /// </summary>
    let geologist = Namespaced_IRI.parse _namespace_name "geologist" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#germanNationalism"></see></summary>
    let germanNationalism =
        Namespaced_IRI.parse _namespace_name "germanNationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#girondin"></see></summary>
    let girondin = Namespaced_IRI.parse _namespace_name "girondin" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jacobinism"></see></summary>
    let jacobinism = Namespaced_IRI.parse _namespace_name "jacobinism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#glassWorker"></see>
    /// </summary>
    let glassWorker =
        Namespaced_IRI.parse _namespace_name "glassWorker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#glover"></see>
    /// </summary>
    let glover = Namespaced_IRI.parse _namespace_name "glover" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#gnosticism"></see></summary>
    let gnosticism = Namespaced_IRI.parse _namespace_name "gnosticism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#goldsmith"></see>
    /// </summary>
    let goldsmith = Namespaced_IRI.parse _namespace_name "goldsmith" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#jeweller"></see>
    /// </summary>
    let jeweller = Namespaced_IRI.parse _namespace_name "jeweller" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#governess"></see>
    /// </summary>
    let governess = Namespaced_IRI.parse _namespace_name "governess" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#governorGeneral"></see>
    /// </summary>
    let governorGeneral =
        Namespaced_IRI.parse _namespace_name "governorGeneral" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#higherGovernment"></see>
    /// </summary>
    let higherGovernment =
        Namespaced_IRI.parse _namespace_name "higherGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#grandChildOf"></see>
    /// </summary>
    let grandChildOf =
        Namespaced_IRI.parse _namespace_name "grandChildOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandChild"></see>
    /// </summary>
    let hasGrandChild =
        Namespaced_IRI.parse _namespace_name "hasGrandChild" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#grandDaughterOf"></see>
    /// </summary>
    let grandDaughterOf =
        Namespaced_IRI.parse _namespace_name "grandDaughterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandDaughter"></see>
    /// </summary>
    let hasGrandDaughter =
        Namespaced_IRI.parse _namespace_name "hasGrandDaughter" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#grandFatherOf"></see>
    /// </summary>
    let grandFatherOf =
        Namespaced_IRI.parse _namespace_name "grandFatherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#grandParentOf"></see>
    /// </summary>
    let grandParentOf =
        Namespaced_IRI.parse _namespace_name "grandParentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandFather"></see>
    /// </summary>
    let hasGrandFather =
        Namespaced_IRI.parse _namespace_name "hasGrandFather" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#grandMotherOf"></see>
    /// </summary>
    let grandMotherOf =
        Namespaced_IRI.parse _namespace_name "grandMotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandMother"></see>
    /// </summary>
    let hasGrandMother =
        Namespaced_IRI.parse _namespace_name "hasGrandMother" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandParent"></see>
    /// </summary>
    let hasGrandParent =
        Namespaced_IRI.parse _namespace_name "hasGrandParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#grandSonOf"></see>
    /// </summary>
    let grandSonOf = Namespaced_IRI.parse _namespace_name "grandSonOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandSon"></see>
    /// </summary>
    let hasGrandSon =
        Namespaced_IRI.parse _namespace_name "hasGrandSon" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#greekNationalist"></see></summary>
    let greekNationalist =
        Namespaced_IRI.parse _namespace_name "greekNationalist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#grocer"></see>
    /// </summary>
    let grocer = Namespaced_IRI.parse _namespace_name "grocer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#guardian"></see>
    /// </summary>
    let guardian = Namespaced_IRI.parse _namespace_name "guardian" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#guardianOf"></see>
    /// </summary>
    let guardianOf = Namespaced_IRI.parse _namespace_name "guardianOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasInterpersonalRelationshipWith"></see>
    /// </summary>
    let hasInterpersonalRelationshipWith =
        Namespaced_IRI.parse _namespace_name "hasInterpersonalRelationshipWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGuardian"></see>
    /// </summary>
    let hasGuardian =
        Namespaced_IRI.parse _namespace_name "hasGuardian" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#guelphPartyFlorence"></see></summary>
    let guelphPartyFlorence =
        Namespaced_IRI.parse _namespace_name "guelphPartyFlorence" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#haberdasher"></see>
    /// </summary>
    let haberdasher =
        Namespaced_IRI.parse _namespace_name "haberdasher" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#halfBrotherOf"></see>
    /// </summary>
    let halfBrotherOf =
        Namespaced_IRI.parse _namespace_name "halfBrotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasHalfBrother"></see>
    /// </summary>
    let hasHalfBrother =
        Namespaced_IRI.parse _namespace_name "hasHalfBrother" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#halfSisterOf"></see>
    /// </summary>
    let halfSisterOf =
        Namespaced_IRI.parse _namespace_name "halfSisterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sisterOf"></see>
    /// </summary>
    let sisterOf = Namespaced_IRI.parse _namespace_name "sisterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasHalfSister"></see>
    /// </summary>
    let hasHalfSister =
        Namespaced_IRI.parse _namespace_name "hasHalfSister" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#handwritingExpert"></see>
    /// </summary>
    let handwritingExpert =
        Namespaced_IRI.parse _namespace_name "handwritingExpert" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hanoverian"></see></summary>
    let hanoverian = Namespaced_IRI.parse _namespace_name "hanoverian" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hanoverianNationalIdentity"></see>
    /// </summary>
    let hanoverianNationalIdentity =
        Namespaced_IRI.parse _namespace_name "hanoverianNationalIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementFrom"></see>
    /// </summary>
    let hasActivistInvolvementFrom =
        Namespaced_IRI.parse _namespace_name "hasActivistInvolvementFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipFrom"></see>
    /// </summary>
    let hasPoliticalMembershipFrom =
        Namespaced_IRI.parse _namespace_name "hasPoliticalMembershipFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementIn"></see>
    /// </summary>
    let hasActivistInvolvementIn =
        Namespaced_IRI.parse _namespace_name "hasActivistInvolvementIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipIn"></see>
    /// </summary>
    let hasPoliticalMembershipIn =
        Namespaced_IRI.parse _namespace_name "hasPoliticalMembershipIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasRelative"></see>
    /// </summary>
    let hasRelative =
        Namespaced_IRI.parse _namespace_name "hasRelative" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasAward"></see>
    /// </summary>
    let hasAward = Namespaced_IRI.parse _namespace_name "hasAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPosition"></see>
    /// </summary>
    let hasBirthPosition =
        Namespaced_IRI.parse _namespace_name "hasBirthPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSibling"></see>
    /// </summary>
    let hasSibling = Namespaced_IRI.parse _namespace_name "hasSibling" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCauseOfDeath"></see>
    /// </summary>
    let hasCauseOfDeath =
        Namespaced_IRI.parse _namespace_name "hasCauseOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasChildren"></see>
    /// </summary>
    let hasChildren =
        Namespaced_IRI.parse _namespace_name "hasChildren" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasReproductiveHistory"></see>
    /// </summary>
    let hasReproductiveHistory =
        Namespaced_IRI.parse _namespace_name "hasReproductiveHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCohabitant"></see>
    /// </summary>
    let hasCohabitant =
        Namespaced_IRI.parse _namespace_name "hasCohabitant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCompanion"></see>
    /// </summary>
    let hasCompanion =
        Namespaced_IRI.parse _namespace_name "hasCompanion" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasContestedBehaviour"></see>
    /// </summary>
    let hasContestedBehaviour =
        Namespaced_IRI.parse _namespace_name "hasContestedBehaviour" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of object property &lt;a href="#hasCulturalForm" title="#hasCulturalForm"&gt;has a cultural form&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasCulturalForms"></see></summary>
    let hasCulturalForms =
        Namespaced_IRI.parse _namespace_name "hasCulturalForms" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEducation"></see>
    /// </summary>
    let hasEducation =
        Namespaced_IRI.parse _namespace_name "hasEducation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmigrant"></see>
    /// </summary>
    let hasEmigrant =
        Namespaced_IRI.parse _namespace_name "hasEmigrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasInhabitant"></see>
    /// </summary>
    let hasInhabitant =
        Namespaced_IRI.parse _namespace_name "hasInhabitant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmployee"></see>
    /// </summary>
    let hasEmployee =
        Namespaced_IRI.parse _namespace_name "hasEmployee" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmployer"></see>
    /// </summary>
    let hasEmployer =
        Namespaced_IRI.parse _namespace_name "hasEmployer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasOccupation"></see>
    /// </summary>
    let hasOccupation =
        Namespaced_IRI.parse _namespace_name "hasOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEroticRelationshipWith"></see>
    /// </summary>
    let hasEroticRelationshipWith =
        Namespaced_IRI.parse _namespace_name "hasEroticRelationshipWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasIntimateRelationshipWith"></see>
    /// </summary>
    let hasIntimateRelationshipWith =
        Namespaced_IRI.parse _namespace_name "hasIntimateRelationshipWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicity"></see>
    /// </summary>
    let hasEthnicity =
        Namespaced_IRI.parse _namespace_name "hasEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicityReported"></see>
    /// </summary>
    let hasEthnicityReported =
        Namespaced_IRI.parse _namespace_name "hasEthnicityReported" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasEthnicitySelfReported" title="#hasEthnicitySelfReported"&gt;has ethnic identity (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicitySelfDefined"></see></summary>
    let hasEthnicitySelfDefined =
        Namespaced_IRI.parse _namespace_name "hasEthnicitySelfDefined" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicitySelfReported"></see>
    /// </summary>
    let hasEthnicitySelfReported =
        Namespaced_IRI.parse _namespace_name "hasEthnicitySelfReported" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#personalPropertySelfReported" title="#personalPropertySelfReported"&gt;personal property self-reported&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#personalPropertySelfDeclared"></see></summary>
    let personalPropertySelfDeclared =
        Namespaced_IRI.parse _namespace_name "personalPropertySelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasFamilyBasedOccupation"></see>
    /// </summary>
    let hasFamilyBasedOccupation =
        Namespaced_IRI.parse _namespace_name "hasFamilyBasedOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasParent"></see>
    /// </summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasFunctionalRelation"></see>
    /// </summary>
    let hasFunctionalRelation =
        Namespaced_IRI.parse _namespace_name "hasFunctionalRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGender"></see>
    /// </summary>
    let hasGender = Namespaced_IRI.parse _namespace_name "hasGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderReported"></see>
    /// </summary>
    let hasGenderReported =
        Namespaced_IRI.parse _namespace_name "hasGenderReported" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasGenderSelfReported" title="#hasGenderSelfReported"&gt;has gender identity (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderSelfDeclared"></see></summary>
    let hasGenderSelfDeclared =
        Namespaced_IRI.parse _namespace_name "hasGenderSelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderSelfReported"></see>
    /// </summary>
    let hasGenderSelfReported =
        Namespaced_IRI.parse _namespace_name "hasGenderSelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivity"></see>
    /// </summary>
    let hasGenderedPoliticalActivity =
        Namespaced_IRI.parse _namespace_name "hasGenderedPoliticalActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliation"></see>
    /// </summary>
    let hasPoliticalAffiliation =
        Namespaced_IRI.parse _namespace_name "hasPoliticalAffiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivityFrom"></see>
    /// </summary>
    let hasGenderedPoliticalActivityFrom =
        Namespaced_IRI.parse _namespace_name "hasGenderedPoliticalActivityFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationOf"></see>
    /// </summary>
    let politicalAffiliationOf =
        Namespaced_IRI.parse _namespace_name "politicalAffiliationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritage"></see>
    /// </summary>
    let hasGeographicHeritage =
        Namespaced_IRI.parse _namespace_name "hasGeographicHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageReported"></see>
    /// </summary>
    let hasGeographicHeritageReported =
        Namespaced_IRI.parse _namespace_name "hasGeographicHeritageReported" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasGeographicHeritageSelfReported" title="#hasGeographicHeritageSelfReported"&gt;has geographic heritage (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageSelfDeclared"></see></summary>
    let hasGeographicHeritageSelfDeclared =
        Namespaced_IRI.parse _namespace_name "hasGeographicHeritageSelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageSelfReported"></see>
    /// </summary>
    let hasGeographicHeritageSelfReported =
        Namespaced_IRI.parse _namespace_name "hasGeographicHeritageSelfReported" |> NamespacedName

    /// <summary>
    /// Deprecated, with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#personalProperty"></see></summary>
    let personalProperty =
        Namespaced_IRI.parse _namespace_name "personalProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSister"></see>
    /// </summary>
    let hasSister = Namespaced_IRI.parse _namespace_name "hasSister" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasHusband"></see>
    /// </summary>
    let hasHusband = Namespaced_IRI.parse _namespace_name "hasHusband" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPartner"></see>
    /// </summary>
    let hasPartner = Namespaced_IRI.parse _namespace_name "hasPartner" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasIDependencyOn"></see>
    /// </summary>
    let hasIDependencyOn =
        Namespaced_IRI.parse _namespace_name "hasIDependencyOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasImmigrant"></see>
    /// </summary>
    let hasImmigrant =
        Namespaced_IRI.parse _namespace_name "hasImmigrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasTraveller"></see>
    /// </summary>
    let hasTraveller =
        Namespaced_IRI.parse _namespace_name "hasTraveller" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#relatesSpatiallyTo"></see>
    /// </summary>
    let relatesSpatiallyTo =
        Namespaced_IRI.parse _namespace_name "relatesSpatiallyTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasInstructor"></see>
    /// </summary>
    let hasInstructor =
        Namespaced_IRI.parse _namespace_name "hasInstructor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialRelationshipWith"></see>
    /// </summary>
    let hasSocialRelationshipWith =
        Namespaced_IRI.parse _namespace_name "hasSocialRelationshipWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbility"></see>
    /// </summary>
    let hasLinguisticAbility =
        Namespaced_IRI.parse _namespace_name "hasLinguisticAbility" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityOf"></see>
    /// </summary>
    let linguisticAbilityOf =
        Namespaced_IRI.parse _namespace_name "linguisticAbilityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilityReported"></see>
    /// </summary>
    let hasLinguisticAbilityReported =
        Namespaced_IRI.parse _namespace_name "hasLinguisticAbilityReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityReportedOf"></see>
    /// </summary>
    let linguisticAbilityReportedOf =
        Namespaced_IRI.parse _namespace_name "linguisticAbilityReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasLinguisticAbilitySelfReported" title="#hasLinguisticAbilitySelfReported"&gt;language known (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilitySelfDeclared"></see></summary>
    let hasLinguisticAbilitySelfDeclared =
        Namespaced_IRI.parse _namespace_name "hasLinguisticAbilitySelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilitySelfReported"></see>
    /// </summary>
    let hasLinguisticAbilitySelfReported =
        Namespaced_IRI.parse _namespace_name "hasLinguisticAbilitySelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilitySelfReportedOf"></see>
    /// </summary>
    let linguisticAbilitySelfReportedOf =
        Namespaced_IRI.parse _namespace_name "linguisticAbilitySelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasLocation"></see>
    /// </summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasMother"></see>
    /// </summary>
    let hasMother = Namespaced_IRI.parse _namespace_name "hasMother" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNamePart"></see>
    /// </summary>
    let hasNamePart =
        Namespaced_IRI.parse _namespace_name "hasNamePart" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritage"></see>
    /// </summary>
    let hasNationalHeritage =
        Namespaced_IRI.parse _namespace_name "hasNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageOf"></see>
    /// </summary>
    let nationalHeritageOf =
        Namespaced_IRI.parse _namespace_name "nationalHeritageOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageReported"></see>
    /// </summary>
    let hasNationalHeritageReported =
        Namespaced_IRI.parse _namespace_name "hasNationalHeritageReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageReportedOf"></see>
    /// </summary>
    let nationalHeritageReportedOf =
        Namespaced_IRI.parse _namespace_name "nationalHeritageReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageSelfReported"></see>
    /// </summary>
    let hasNationalHeritageSelfReported =
        Namespaced_IRI.parse _namespace_name "hasNationalHeritageSelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageSelfReportedOf"></see>
    /// </summary>
    let nationalHeritageSelfReportedOf =
        Namespaced_IRI.parse _namespace_name "nationalHeritageSelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationality"></see>
    /// </summary>
    let hasNationality =
        Namespaced_IRI.parse _namespace_name "hasNationality" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nationalityOf"></see>
    /// </summary>
    let nationalityOf =
        Namespaced_IRI.parse _namespace_name "nationalityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalityReported"></see>
    /// </summary>
    let hasNationalityReported =
        Namespaced_IRI.parse _namespace_name "hasNationalityReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nationalityReportedOf"></see>
    /// </summary>
    let nationalityReportedOf =
        Namespaced_IRI.parse _namespace_name "nationalityReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasNationalitySelfReported" title="#hasNationalitySelfReported"&gt;has national identity (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalitySelfDeclared"></see></summary>
    let hasNationalitySelfDeclared =
        Namespaced_IRI.parse _namespace_name "hasNationalitySelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalitySelfReported"></see>
    /// </summary>
    let hasNationalitySelfReported =
        Namespaced_IRI.parse _namespace_name "hasNationalitySelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nationalitySelfReportedOf"></see>
    /// </summary>
    let nationalitySelfReportedOf =
        Namespaced_IRI.parse _namespace_name "nationalitySelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbility"></see>
    /// </summary>
    let hasNativeLinguisticAbility =
        Namespaced_IRI.parse _namespace_name "hasNativeLinguisticAbility" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityOf"></see>
    /// </summary>
    let nativeLinguisticAbilityOf =
        Namespaced_IRI.parse _namespace_name "nativeLinguisticAbilityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilityReported"></see>
    /// </summary>
    let hasNativeLinguisticAbilityReported =
        Namespaced_IRI.parse _namespace_name "hasNativeLinguisticAbilityReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityReportedOf"></see>
    /// </summary>
    let nativeLinguisticAbilityReportedOf =
        Namespaced_IRI.parse _namespace_name "nativeLinguisticAbilityReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasLinguisticAbilitySelfReported" title="#hasLinguisticAbilitySelfReported"&gt;language known (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilitySelfDeclared"></see></summary>
    let hasNativeLinguisticAbilitySelfDeclared =
        Namespaced_IRI.parse _namespace_name "hasNativeLinguisticAbilitySelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilitySelfReported"></see>
    /// </summary>
    let hasNativeLinguisticAbilitySelfReported =
        Namespaced_IRI.parse _namespace_name "hasNativeLinguisticAbilitySelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilitySelfReportedOf"></see>
    /// </summary>
    let nativeLinguisticAbilitySelfReportedOf =
        Namespaced_IRI.parse _namespace_name "nativeLinguisticAbilitySelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNephew"></see>
    /// </summary>
    let hasNephew = Namespaced_IRI.parse _namespace_name "hasNephew" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNiece"></see>
    /// </summary>
    let hasNiece = Namespaced_IRI.parse _namespace_name "hasNiece" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasNonEroticRelationshipWith"></see>
    /// </summary>
    let hasNonEroticRelationshipWith =
        Namespaced_IRI.parse _namespace_name "hasNonEroticRelationshipWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasOccupationIncome"></see>
    /// </summary>
    let hasOccupationIncome =
        Namespaced_IRI.parse _namespace_name "hasOccupationIncome" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#occupationIncomeOf"></see>
    /// </summary>
    let occupationIncomeOf =
        Namespaced_IRI.parse _namespace_name "occupationIncomeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasOrganization"></see>
    /// </summary>
    let hasOrganization =
        Namespaced_IRI.parse _namespace_name "hasOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPaidOccupation"></see>
    /// </summary>
    let hasPaidOccupation =
        Namespaced_IRI.parse _namespace_name "hasPaidOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#paidOccupationOf"></see>
    /// </summary>
    let paidOccupationOf =
        Namespaced_IRI.parse _namespace_name "paidOccupationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasParticipant"></see>
    /// </summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#partnerOf"></see>
    /// </summary>
    let partnerOf = Namespaced_IRI.parse _namespace_name "partnerOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of property &lt;a href="#hasEventElement" title="#hasEventElement"&gt;[http://sparql.cwrc.ca/ontologies/cwrc#hasEventElement]&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPeformance"></see></summary>
    let hasPeformance =
        Namespaced_IRI.parse _namespace_name "hasPeformance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasEventElement"></see>
    /// </summary>
    let hasEventElement =
        Namespaced_IRI.parse _namespace_name "hasEventElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPersona"></see>
    /// </summary>
    let hasPersona = Namespaced_IRI.parse _namespace_name "hasPersona" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationReported"></see>
    /// </summary>
    let hasPoliticalAffiliationReported =
        Namespaced_IRI.parse _namespace_name "hasPoliticalAffiliationReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationReportedOf"></see>
    /// </summary>
    let politicalAffiliationReportedOf =
        Namespaced_IRI.parse _namespace_name "politicalAffiliationReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationSelfReported"></see>
    /// </summary>
    let hasPoliticalAffiliationSelfReported =
        Namespaced_IRI.parse _namespace_name "hasPoliticalAffiliationSelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationSelfReportedOf"></see>
    /// </summary>
    let politicalAffiliationSelfReportedOf =
        Namespaced_IRI.parse _namespace_name "politicalAffiliationSelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementFrom"></see>
    /// </summary>
    let hasPoliticalInvolvementFrom =
        Namespaced_IRI.parse _namespace_name "hasPoliticalInvolvementFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementIn"></see>
    /// </summary>
    let hasPoliticalInvolvementIn =
        Namespaced_IRI.parse _namespace_name "hasPoliticalInvolvementIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasPossiblyEroticRelationshipWith"></see>
    /// </summary>
    let hasPossiblyEroticRelationshipWith =
        Namespaced_IRI.parse _namespace_name "hasPossiblyEroticRelationshipWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColour"></see>
    /// </summary>
    let hasRaceColour =
        Namespaced_IRI.parse _namespace_name "hasRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourOf"></see>
    /// </summary>
    let raceColourOf =
        Namespaced_IRI.parse _namespace_name "raceColourOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourReported"></see>
    /// </summary>
    let hasRaceColourReported =
        Namespaced_IRI.parse _namespace_name "hasRaceColourReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourReportedOf"></see>
    /// </summary>
    let raceColourReportedOf =
        Namespaced_IRI.parse _namespace_name "raceColourReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasNationalitySelfReported" title="#hasNationalitySelfReported"&gt;has national identity (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourSelfDeclared"></see></summary>
    let hasRaceColourSelfDeclared =
        Namespaced_IRI.parse _namespace_name "hasRaceColourSelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#Race"></see>
    /// </summary>
    let Race = Namespaced_IRI.parse _namespace_name "Race" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourSelfReported"></see>
    /// </summary>
    let hasRaceColourSelfReported =
        Namespaced_IRI.parse _namespace_name "hasRaceColourSelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourSelfReportedOf"></see>
    /// </summary>
    let raceColourSelfReportedOf =
        Namespaced_IRI.parse _namespace_name "raceColourSelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligion"></see>
    /// </summary>
    let hasReligion =
        Namespaced_IRI.parse _namespace_name "hasReligion" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#religionOf"></see>
    /// </summary>
    let religionOf = Namespaced_IRI.parse _namespace_name "religionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionReported"></see>
    /// </summary>
    let hasReligionReported =
        Namespaced_IRI.parse _namespace_name "hasReligionReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#religionReportedOf"></see>
    /// </summary>
    let religionReportedOf =
        Namespaced_IRI.parse _namespace_name "religionReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasReligionSelfReported" title="#hasReligionSelfReported"&gt;has religious affiliation (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionSelfDefined"></see></summary>
    let hasReligionSelfDefined =
        Namespaced_IRI.parse _namespace_name "hasReligionSelfDefined" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionSelfReported"></see>
    /// </summary>
    let hasReligionSelfReported =
        Namespaced_IRI.parse _namespace_name "hasReligionSelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#religionSelfReportedOf"></see>
    /// </summary>
    let religionSelfReportedOf =
        Namespaced_IRI.parse _namespace_name "religionSelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasRelocatee"></see>
    /// </summary>
    let hasRelocatee =
        Namespaced_IRI.parse _namespace_name "hasRelocatee" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasRole"></see>
    /// </summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexuality"></see>
    /// </summary>
    let hasSexuality =
        Namespaced_IRI.parse _namespace_name "hasSexuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityOf"></see>
    /// </summary>
    let sexualityOf =
        Namespaced_IRI.parse _namespace_name "sexualityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualityReported"></see>
    /// </summary>
    let hasSexualityReported =
        Namespaced_IRI.parse _namespace_name "hasSexualityReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityReportedOf"></see>
    /// </summary>
    let sexualityReportedOf =
        Namespaced_IRI.parse _namespace_name "sexualityReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasSexualitySelfReported" title="#hasSexualitySelfReported"&gt;has sexual identity (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualitySelfDeclared"></see></summary>
    let hasSexualitySelfDeclared =
        Namespaced_IRI.parse _namespace_name "hasSexualitySelfDeclared" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualitySelfReported"></see>
    /// </summary>
    let hasSexualitySelfReported =
        Namespaced_IRI.parse _namespace_name "hasSexualitySelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualitySelfReportedOf"></see>
    /// </summary>
    let sexualitySelfReportedOf =
        Namespaced_IRI.parse _namespace_name "sexualitySelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClass"></see>
    /// </summary>
    let hasSocialClass =
        Namespaced_IRI.parse _namespace_name "hasSocialClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassOf"></see>
    /// </summary>
    let socialClassOf =
        Namespaced_IRI.parse _namespace_name "socialClassOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassReported"></see>
    /// </summary>
    let hasSocialClassReported =
        Namespaced_IRI.parse _namespace_name "hasSocialClassReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassReportedOf"></see>
    /// </summary>
    let socialClassReportedOf =
        Namespaced_IRI.parse _namespace_name "socialClassReportedOf" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasSocialClassSelfReported" title="#hasSocialClassSelfReported"&gt;has class identity (self-reported)&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassSelfDefined"></see></summary>
    let hasSocialClassSelfDefined =
        Namespaced_IRI.parse _namespace_name "hasSocialClassSelfDefined" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassSelfReported"></see>
    /// </summary>
    let hasSocialClassSelfReported =
        Namespaced_IRI.parse _namespace_name "hasSocialClassSelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassSelfReportedOf"></see>
    /// </summary>
    let socialClassSelfReportedOf =
        Namespaced_IRI.parse _namespace_name "socialClassSelfReportedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSon"></see>
    /// </summary>
    let hasSon = Namespaced_IRI.parse _namespace_name "hasSon" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasSortOrder"></see>
    /// </summary>
    let hasSortOrder =
        Namespaced_IRI.parse _namespace_name "hasSortOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepBrother"></see>
    /// </summary>
    let hasStepBrother =
        Namespaced_IRI.parse _namespace_name "hasStepBrother" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepChild"></see>
    /// </summary>
    let hasStepChild =
        Namespaced_IRI.parse _namespace_name "hasStepChild" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepDaughter"></see>
    /// </summary>
    let hasStepDaughter =
        Namespaced_IRI.parse _namespace_name "hasStepDaughter" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepFather"></see>
    /// </summary>
    let hasStepFather =
        Namespaced_IRI.parse _namespace_name "hasStepFather" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepParent"></see>
    /// </summary>
    let hasStepParent =
        Namespaced_IRI.parse _namespace_name "hasStepParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepMother"></see>
    /// </summary>
    let hasStepMother =
        Namespaced_IRI.parse _namespace_name "hasStepMother" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepMotherOf"></see>
    /// </summary>
    let stepMotherOf =
        Namespaced_IRI.parse _namespace_name "stepMotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepSister"></see>
    /// </summary>
    let hasStepSister =
        Namespaced_IRI.parse _namespace_name "hasStepSister" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepSon"></see>
    /// </summary>
    let hasStepSon = Namespaced_IRI.parse _namespace_name "hasStepSon" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasTimeCertainty"></see>
    /// </summary>
    let hasTimeCertainty =
        Namespaced_IRI.parse _namespace_name "hasTimeCertainty" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasUncle"></see>
    /// </summary>
    let hasUncle = Namespaced_IRI.parse _namespace_name "hasUncle" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasVistor"></see>
    /// </summary>
    let hasVistor = Namespaced_IRI.parse _namespace_name "hasVistor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasVolunteerOccupation"></see>
    /// </summary>
    let hasVolunteerOccupation =
        Namespaced_IRI.parse _namespace_name "hasVolunteerOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#volunteerOccupationOf"></see>
    /// </summary>
    let volunteerOccupationOf =
        Namespaced_IRI.parse _namespace_name "volunteerOccupationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hasWife"></see>
    /// </summary>
    let hasWife = Namespaced_IRI.parse _namespace_name "hasWife" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#headOfState"></see>
    /// </summary>
    let headOfState =
        Namespaced_IRI.parse _namespace_name "headOfState" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hermeticism"></see></summary>
    let hermeticism =
        Namespaced_IRI.parse _namespace_name "hermeticism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#heterosexual"></see>
    /// </summary>
    let heterosexual =
        Namespaced_IRI.parse _namespace_name "heterosexual" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#highCertainty"></see>
    /// </summary>
    let highCertainty =
        Namespaced_IRI.parse _namespace_name "highCertainty" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#highChurchParty"></see></summary>
    let highChurchParty =
        Namespaced_IRI.parse _namespace_name "highChurchParty" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#highToryism"></see></summary>
    let highToryism =
        Namespaced_IRI.parse _namespace_name "highToryism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#hinduism"></see></summary>
    let hinduism = Namespaced_IRI.parse _namespace_name "hinduism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#historian"></see>
    /// </summary>
    let historian = Namespaced_IRI.parse _namespace_name "historian" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#homeRule"></see></summary>
    let homeRule = Namespaced_IRI.parse _namespace_name "homeRule" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#homosexual"></see>
    /// </summary>
    let homosexual = Namespaced_IRI.parse _namespace_name "homosexual" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#honoraryDegree"></see></summary>
    let honoraryDegree =
        Namespaced_IRI.parse _namespace_name "honoraryDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hospitality"></see>
    /// </summary>
    let hospitality =
        Namespaced_IRI.parse _namespace_name "hospitality" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hostess"></see>
    /// </summary>
    let hostess = Namespaced_IRI.parse _namespace_name "hostess" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#housePainter"></see>
    /// </summary>
    let housePainter =
        Namespaced_IRI.parse _namespace_name "housePainter" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#houseSitter"></see>
    /// </summary>
    let houseSitter =
        Namespaced_IRI.parse _namespace_name "houseSitter" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#housework"></see>
    /// </summary>
    let housework = Namespaced_IRI.parse _namespace_name "housework" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#housingMovement"></see></summary>
    let housingMovement =
        Namespaced_IRI.parse _namespace_name "housingMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#humanism"></see></summary>
    let humanism = Namespaced_IRI.parse _namespace_name "humanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#humanitarianWork"></see>
    /// </summary>
    let humanitarianWork =
        Namespaced_IRI.parse _namespace_name "humanitarianWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hunter"></see>
    /// </summary>
    let hunter = Namespaced_IRI.parse _namespace_name "hunter" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#husbandOf"></see>
    /// </summary>
    let husbandOf = Namespaced_IRI.parse _namespace_name "husbandOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#hypnotist"></see>
    /// </summary>
    let hypnotist = Namespaced_IRI.parse _namespace_name "hypnotist" |> NamespacedName
    /// <summary>
    /// Deprecated from previous Orlando Ontology design.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#identity"></see></summary>
    let identity = Namespaced_IRI.parse _namespace_name "identity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#igboEthnicity"></see></summary>
    let igboEthnicity =
        Namespaced_IRI.parse _namespace_name "igboEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#illustrator"></see>
    /// </summary>
    let illustrator =
        Namespaced_IRI.parse _namespace_name "illustrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#immunologist"></see>
    /// </summary>
    let immunologist =
        Namespaced_IRI.parse _namespace_name "immunologist" |> NamespacedName

    /// <summary>
    /// Deprecated from previous Orlando Ontology design.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#inRole"></see></summary>
    let inRole = Namespaced_IRI.parse _namespace_name "inRole" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#independentMethodistConnexion"></see></summary>
    let independentMethodistConnexion =
        Namespaced_IRI.parse _namespace_name "independentMethodistConnexion" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#indexedBy"></see>
    /// </summary>
    let indexedBy = Namespaced_IRI.parse _namespace_name "indexedBy" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#indianIndependence"></see></summary>
    let indianIndependence =
        Namespaced_IRI.parse _namespace_name "indianIndependence" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#indianRaceColour"></see></summary>
    let indianRaceColour =
        Namespaced_IRI.parse _namespace_name "indianRaceColour" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#indianUnification"></see></summary>
    let indianUnification =
        Namespaced_IRI.parse _namespace_name "indianUnification" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#indigenousPeoplesOfAmericasEthnicity"></see></summary>
    let indigenousPeoplesOfAmericasEthnicity =
        Namespaced_IRI.parse _namespace_name "indigenousPeoplesOfAmericasEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#indigenousPeoplesOfAmericasRaceColour"></see></summary>
    let indigenousPeoplesOfAmericasRaceColour =
        Namespaced_IRI.parse _namespace_name "indigenousPeoplesOfAmericasRaceColour" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#indigenousRights"></see></summary>
    let indigenousRights =
        Namespaced_IRI.parse _namespace_name "indigenousRights" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#individualism"></see></summary>
    let individualism =
        Namespaced_IRI.parse _namespace_name "individualism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#inhabits"></see>
    /// </summary>
    let inhabits = Namespaced_IRI.parse _namespace_name "inhabits" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#insurance"></see>
    /// </summary>
    let insurance = Namespaced_IRI.parse _namespace_name "insurance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#intellectual"></see>
    /// </summary>
    let intellectual =
        Namespaced_IRI.parse _namespace_name "intellectual" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#intelligenceWork"></see>
    /// </summary>
    let intelligenceWork =
        Namespaced_IRI.parse _namespace_name "intelligenceWork" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#hasInterpersonalRelationshipWith" title="#hasInterpersonalRelationshipWith"&gt;has interpersonal relationship with&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#interpersonalRelationship"></see></summary>
    let interpersonalRelationship =
        Namespaced_IRI.parse _namespace_name "interpersonalRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#interviewer"></see>
    /// </summary>
    let interviewer =
        Namespaced_IRI.parse _namespace_name "interviewer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#inventor"></see>
    /// </summary>
    let inventor = Namespaced_IRI.parse _namespace_name "inventor" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#irishEthnicity"></see></summary>
    let irishEthnicity =
        Namespaced_IRI.parse _namespace_name "irishEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#irishHomeRuleMovement"></see></summary>
    let irishHomeRuleMovement =
        Namespaced_IRI.parse _namespace_name "irishHomeRuleMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#republicanism"></see></summary>
    let republicanism =
        Namespaced_IRI.parse _namespace_name "republicanism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#irishRepublicanism"></see></summary>
    let irishRepublicanism =
        Namespaced_IRI.parse _namespace_name "irishRepublicanism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#irishNationalism"></see></summary>
    let irishNationalism =
        Namespaced_IRI.parse _namespace_name "irishNationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ironmaster"></see>
    /// </summary>
    let ironmaster = Namespaced_IRI.parse _namespace_name "ironmaster" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#ironmonger"></see>
    /// </summary>
    let ironmonger = Namespaced_IRI.parse _namespace_name "ironmonger" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#iroquoisNationalHeritage"></see></summary>
    let iroquoisNationalHeritage =
        Namespaced_IRI.parse _namespace_name "iroquoisNationalHeritage" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#islam"></see></summary>
    let islam = Namespaced_IRI.parse _namespace_name "islam" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#isolationism"></see></summary>
    let isolationism =
        Namespaced_IRI.parse _namespace_name "isolationism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#italianNationalism"></see></summary>
    let italianNationalism =
        Namespaced_IRI.parse _namespace_name "italianNationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#italianUnification"></see></summary>
    let italianUnification =
        Namespaced_IRI.parse _namespace_name "italianUnification" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#revolutionaryPolitics"></see></summary>
    let revolutionaryPolitics =
        Namespaced_IRI.parse _namespace_name "revolutionaryPolitics" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#jacobinism" title="#jacobinism"&gt;Jacobinism&lt;/a&gt;.
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jacobism"></see></summary>
    let jacobism = Namespaced_IRI.parse _namespace_name "jacobism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jamaicanEthnicity"></see></summary>
    let jamaicanEthnicity =
        Namespaced_IRI.parse _namespace_name "jamaicanEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jansenism"></see></summary>
    let jansenism = Namespaced_IRI.parse _namespace_name "jansenism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishEmancipation"></see></summary>
    let jewishEmancipation =
        Namespaced_IRI.parse _namespace_name "jewishEmancipation" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishGeographicHeritage"></see>
    /// </summary>
    let jewishGeographicHeritage =
        Namespaced_IRI.parse _namespace_name "jewishGeographicHeritage" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishRaceColour"></see></summary>
    let jewishRaceColour =
        Namespaced_IRI.parse _namespace_name "jewishRaceColour" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#judaism"></see></summary>
    let judaism = Namespaced_IRI.parse _namespace_name "judaism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishNationalIdentity"></see>
    /// </summary>
    let jewishNationalIdentity =
        Namespaced_IRI.parse _namespace_name "jewishNationalIdentity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishNationalHeritage"></see></summary>
    let jewishNationalHeritage =
        Namespaced_IRI.parse _namespace_name "jewishNationalHeritage" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// Deprecated in favour of instance &lt;a href="#judaism" title="#judaism"&gt;Judaism&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#jewishReligion"></see></summary>
    let jewishReligion =
        Namespaced_IRI.parse _namespace_name "jewishReligion" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#journalist"></see>
    /// </summary>
    let journalist = Namespaced_IRI.parse _namespace_name "journalist" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#judge"></see>
    /// </summary>
    let judge = Namespaced_IRI.parse _namespace_name "judge" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#knight"></see>
    /// </summary>
    let knight = Namespaced_IRI.parse _namespace_name "knight" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#labourUnion"></see>
    /// </summary>
    let labourUnion =
        Namespaced_IRI.parse _namespace_name "labourUnion" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#ladyLiterateInArts"></see></summary>
    let ladyLiterateInArts =
        Namespaced_IRI.parse _namespace_name "ladyLiterateInArts" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#landReform"></see></summary>
    let landReform = Namespaced_IRI.parse _namespace_name "landReform" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#latitudinarianism"></see></summary>
    let latitudinarianism =
        Namespaced_IRI.parse _namespace_name "latitudinarianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#laundryWorker"></see>
    /// </summary>
    let laundryWorker =
        Namespaced_IRI.parse _namespace_name "laundryWorker" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#lawDegree"></see></summary>
    let lawDegree = Namespaced_IRI.parse _namespace_name "lawDegree" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#professionalDegree"></see></summary>
    let professionalDegree =
        Namespaced_IRI.parse _namespace_name "professionalDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lawyer"></see>
    /// </summary>
    let lawyer = Namespaced_IRI.parse _namespace_name "lawyer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#legalWork"></see>
    /// </summary>
    let legalWork = Namespaced_IRI.parse _namespace_name "legalWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#leatherWorker"></see>
    /// </summary>
    let leatherWorker =
        Namespaced_IRI.parse _namespace_name "leatherWorker" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#left-Wing"></see></summary>
    let ``left-Wing`` =
        Namespaced_IRI.parse _namespace_name "left-Wing" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lesbian"></see>
    /// </summary>
    let lesbian = Namespaced_IRI.parse _namespace_name "lesbian" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#lesbianFeminism"></see></summary>
    let lesbianFeminism =
        Namespaced_IRI.parse _namespace_name "lesbianFeminism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#liaisonOfficer"></see>
    /// </summary>
    let liaisonOfficer =
        Namespaced_IRI.parse _namespace_name "liaisonOfficer" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#liberalUnionistParty"></see></summary>
    let liberalUnionistParty =
        Namespaced_IRI.parse _namespace_name "liberalUnionistParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#linguist"></see>
    /// </summary>
    let linguist = Namespaced_IRI.parse _namespace_name "linguist" |> NamespacedName

    /// <summary>
    /// Deprecated, with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#literalForm"></see></summary>
    let literalForm =
        Namespaced_IRI.parse _namespace_name "literalForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryAgent"></see>
    /// </summary>
    let literaryAgent =
        Namespaced_IRI.parse _namespace_name "literaryAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryAssistant"></see>
    /// </summary>
    let literaryAssistant =
        Namespaced_IRI.parse _namespace_name "literaryAssistant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryConservationist"></see>
    /// </summary>
    let literaryConservationist =
        Namespaced_IRI.parse _namespace_name "literaryConservationist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryExecutor"></see>
    /// </summary>
    let literaryExecutor =
        Namespaced_IRI.parse _namespace_name "literaryExecutor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryForger"></see>
    /// </summary>
    let literaryForger =
        Namespaced_IRI.parse _namespace_name "literaryForger" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryPrizeAdjudicator"></see>
    /// </summary>
    let literaryPrizeAdjudicator =
        Namespaced_IRI.parse _namespace_name "literaryPrizeAdjudicator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#literaryScholar"></see>
    /// </summary>
    let literaryScholar =
        Namespaced_IRI.parse _namespace_name "literaryScholar" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lithographer"></see>
    /// </summary>
    let lithographer =
        Namespaced_IRI.parse _namespace_name "lithographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#litigant"></see>
    /// </summary>
    let litigant = Namespaced_IRI.parse _namespace_name "litigant" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lobbyist"></see>
    /// </summary>
    let lobbyist = Namespaced_IRI.parse _namespace_name "lobbyist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#localGovernment"></see>
    /// </summary>
    let localGovernment =
        Namespaced_IRI.parse _namespace_name "localGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#locationOf"></see>
    /// </summary>
    let locationOf = Namespaced_IRI.parse _namespace_name "locationOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#logger"></see>
    /// </summary>
    let logger = Namespaced_IRI.parse _namespace_name "logger" |> NamespacedName
    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#lollardy" title="#lollardy"&gt;Lollardy&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#lollards"></see></summary>
    let lollards = Namespaced_IRI.parse _namespace_name "lollards" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#lollardy"></see></summary>
    let lollardy = Namespaced_IRI.parse _namespace_name "lollardy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lordChamberlain"></see>
    /// </summary>
    let lordChamberlain =
        Namespaced_IRI.parse _namespace_name "lordChamberlain" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lordChancellor"></see>
    /// </summary>
    let lordChancellor =
        Namespaced_IRI.parse _namespace_name "lordChancellor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lowCertainty"></see>
    /// </summary>
    let lowCertainty =
        Namespaced_IRI.parse _namespace_name "lowCertainty" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#lowerMiddleClass"></see>
    /// </summary>
    let lowerMiddleClass =
        Namespaced_IRI.parse _namespace_name "lowerMiddleClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#middleClass"></see>
    /// </summary>
    let middleClass =
        Namespaced_IRI.parse _namespace_name "middleClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#machineWork"></see>
    /// </summary>
    let machineWork =
        Namespaced_IRI.parse _namespace_name "machineWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#madeAlteration"></see>
    /// </summary>
    let madeAlteration =
        Namespaced_IRI.parse _namespace_name "madeAlteration" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#magistrate"></see>
    /// </summary>
    let magistrate = Namespaced_IRI.parse _namespace_name "magistrate" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#maidOfHonour"></see>
    /// </summary>
    let maidOfHonour =
        Namespaced_IRI.parse _namespace_name "maidOfHonour" |> NamespacedName

    /// <summary>
    /// Deprecated with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#maleLabel"></see></summary>
    let maleLabel = Namespaced_IRI.parse _namespace_name "maleLabel" |> NamespacedName
    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#genderManMale" title="#genderManMale"&gt;man/male&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#maleSex"></see></summary>
    let maleSex = Namespaced_IRI.parse _namespace_name "maleSex" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#malthusianism"></see></summary>
    let malthusianism =
        Namespaced_IRI.parse _namespace_name "malthusianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#managerial"></see>
    /// </summary>
    let managerial = Namespaced_IRI.parse _namespace_name "managerial" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#manservant"></see>
    /// </summary>
    let manservant = Namespaced_IRI.parse _namespace_name "manservant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#manualLabourer"></see>
    /// </summary>
    let manualLabourer =
        Namespaced_IRI.parse _namespace_name "manualLabourer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#manufacturer"></see>
    /// </summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mapping"></see>
    /// </summary>
    let mapping = Namespaced_IRI.parse _namespace_name "mapping" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#marriageLawReform"></see></summary>
    let marriageLawReform =
        Namespaced_IRI.parse _namespace_name "marriageLawReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#martyr"></see>
    /// </summary>
    let martyr = Namespaced_IRI.parse _namespace_name "martyr" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mason"></see>
    /// </summary>
    let mason = Namespaced_IRI.parse _namespace_name "mason" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#masterOfTheRevels"></see>
    /// </summary>
    let masterOfTheRevels =
        Namespaced_IRI.parse _namespace_name "masterOfTheRevels" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#mastersDegree"></see></summary>
    let mastersDegree =
        Namespaced_IRI.parse _namespace_name "mastersDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mathematics"></see>
    /// </summary>
    let mathematics =
        Namespaced_IRI.parse _namespace_name "mathematics" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#matron"></see>
    /// </summary>
    let matron = Namespaced_IRI.parse _namespace_name "matron" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mayor"></see>
    /// </summary>
    let mayor = Namespaced_IRI.parse _namespace_name "mayor" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#medicalDegree"></see></summary>
    let medicalDegree =
        Namespaced_IRI.parse _namespace_name "medicalDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#medicalDoctor"></see>
    /// </summary>
    let medicalDoctor =
        Namespaced_IRI.parse _namespace_name "medicalDoctor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mediumCertainty"></see>
    /// </summary>
    let mediumCertainty =
        Namespaced_IRI.parse _namespace_name "mediumCertainty" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#memberOfParliament"></see>
    /// </summary>
    let memberOfParliament =
        Namespaced_IRI.parse _namespace_name "memberOfParliament" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mentalHealthProfessional"></see>
    /// </summary>
    let mentalHealthProfessional =
        Namespaced_IRI.parse _namespace_name "mentalHealthProfessional" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mentor"></see>
    /// </summary>
    let mentor = Namespaced_IRI.parse _namespace_name "mentor" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mercer"></see>
    /// </summary>
    let mercer = Namespaced_IRI.parse _namespace_name "mercer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#merchantTaylor"></see>
    /// </summary>
    let merchantTaylor =
        Namespaced_IRI.parse _namespace_name "merchantTaylor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#metalWork"></see>
    /// </summary>
    let metalWork = Namespaced_IRI.parse _namespace_name "metalWork" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#metallurgy"></see>
    /// </summary>
    let metallurgy = Namespaced_IRI.parse _namespace_name "metallurgy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#meteorologist"></see>
    /// </summary>
    let meteorologist =
        Namespaced_IRI.parse _namespace_name "meteorologist" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#methodistEpiscopalian"></see></summary>
    let methodistEpiscopalian =
        Namespaced_IRI.parse _namespace_name "methodistEpiscopalian" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#middleChild"></see>
    /// </summary>
    let middleChild =
        Namespaced_IRI.parse _namespace_name "middleChild" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#midwife"></see>
    /// </summary>
    let midwife = Namespaced_IRI.parse _namespace_name "midwife" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#migratesFrom"></see>
    /// </summary>
    let migratesFrom =
        Namespaced_IRI.parse _namespace_name "migratesFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#migratesTo"></see>
    /// </summary>
    let migratesTo = Namespaced_IRI.parse _namespace_name "migratesTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#travelsTo"></see>
    /// </summary>
    let travelsTo = Namespaced_IRI.parse _namespace_name "travelsTo" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#militarism"></see></summary>
    let militarism = Namespaced_IRI.parse _namespace_name "militarism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#miller"></see>
    /// </summary>
    let miller = Namespaced_IRI.parse _namespace_name "miller" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#milliner"></see>
    /// </summary>
    let milliner = Namespaced_IRI.parse _namespace_name "milliner" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#miner"></see>
    /// </summary>
    let miner = Namespaced_IRI.parse _namespace_name "miner" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mining"></see>
    /// </summary>
    let mining = Namespaced_IRI.parse _namespace_name "mining" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#miscarriage"></see>
    /// </summary>
    let miscarriage =
        Namespaced_IRI.parse _namespace_name "miscarriage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#miser"></see>
    /// </summary>
    let miser = Namespaced_IRI.parse _namespace_name "miser" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#missionaryWork"></see>
    /// </summary>
    let missionaryWork =
        Namespaced_IRI.parse _namespace_name "missionaryWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#religious"></see>
    /// </summary>
    let religious = Namespaced_IRI.parse _namespace_name "religious" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mistress"></see>
    /// </summary>
    let mistress = Namespaced_IRI.parse _namespace_name "mistress" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexWorker"></see>
    /// </summary>
    let sexWorker = Namespaced_IRI.parse _namespace_name "sexWorker" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#mixedRaceColour"></see></summary>
    let mixedRaceColour =
        Namespaced_IRI.parse _namespace_name "mixedRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#whiteLabel"></see>
    /// </summary>
    let whiteLabel = Namespaced_IRI.parse _namespace_name "whiteLabel" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#model"></see>
    /// </summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#mohawkNationalHeritage"></see></summary>
    let mohawkNationalHeritage =
        Namespaced_IRI.parse _namespace_name "mohawkNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mohawkNationalIdentity"></see>
    /// </summary>
    let mohawkNationalIdentity =
        Namespaced_IRI.parse _namespace_name "mohawkNationalIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#monarch"></see>
    /// </summary>
    let monarch = Namespaced_IRI.parse _namespace_name "monarch" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#monism"></see></summary>
    let monism = Namespaced_IRI.parse _namespace_name "monism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#moravian"></see></summary>
    let moravian = Namespaced_IRI.parse _namespace_name "moravian" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#motherOf"></see>
    /// </summary>
    let motherOf = Namespaced_IRI.parse _namespace_name "motherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#mountaineering"></see>
    /// </summary>
    let mountaineering =
        Namespaced_IRI.parse _namespace_name "mountaineering" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#multiculturalism"></see></summary>
    let multiculturalism =
        Namespaced_IRI.parse _namespace_name "multiculturalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#multiracialism"></see></summary>
    let multiracialism =
        Namespaced_IRI.parse _namespace_name "multiracialism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#munitionsWorker"></see>
    /// </summary>
    let munitionsWorker =
        Namespaced_IRI.parse _namespace_name "munitionsWorker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#performer"></see>
    /// </summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#musicologist"></see>
    /// </summary>
    let musicologist =
        Namespaced_IRI.parse _namespace_name "musicologist" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#mysticism"></see></summary>
    let mysticism = Namespaced_IRI.parse _namespace_name "mysticism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#patriotism"></see></summary>
    let patriotism = Namespaced_IRI.parse _namespace_name "patriotism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#naturalReligion"></see></summary>
    let naturalReligion =
        Namespaced_IRI.parse _namespace_name "naturalReligion" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#naturalist"></see>
    /// </summary>
    let naturalist = Namespaced_IRI.parse _namespace_name "naturalist" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#navy"></see>
    /// </summary>
    let navy = Namespaced_IRI.parse _namespace_name "navy" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#nazism"></see></summary>
    let nazism = Namespaced_IRI.parse _namespace_name "nazism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#needlework"></see>
    /// </summary>
    let needlework = Namespaced_IRI.parse _namespace_name "needlework" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#neo-thomism"></see>
    /// </summary>
    let ``neo-thomism`` =
        Namespaced_IRI.parse _namespace_name "neo-thomism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nephewOf"></see>
    /// </summary>
    let nephewOf = Namespaced_IRI.parse _namespace_name "nephewOf" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#newDealer"></see></summary>
    let newDealer = Namespaced_IRI.parse _namespace_name "newDealer" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#newThought"></see></summary>
    let newThought = Namespaced_IRI.parse _namespace_name "newThought" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#newUnionism"></see></summary>
    let newUnionism =
        Namespaced_IRI.parse _namespace_name "newUnionism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nieceOf"></see>
    /// </summary>
    let nieceOf = Namespaced_IRI.parse _namespace_name "nieceOf" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#nihilism"></see></summary>
    let nihilism = Namespaced_IRI.parse _namespace_name "nihilism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nobility"></see>
    /// </summary>
    let nobility = Namespaced_IRI.parse _namespace_name "nobility" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#nonjurorsMovement"></see></summary>
    let nonjurorsMovement =
        Namespaced_IRI.parse _namespace_name "nonjurorsMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#normanNationalHeritage"></see></summary>
    let normanNationalHeritage =
        Namespaced_IRI.parse _namespace_name "normanNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#numismatist"></see>
    /// </summary>
    let numismatist =
        Namespaced_IRI.parse _namespace_name "numismatist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nun"></see>
    /// </summary>
    let nun = Namespaced_IRI.parse _namespace_name "nun" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#nursing"></see>
    /// </summary>
    let nursing = Namespaced_IRI.parse _namespace_name "nursing" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#obeah"></see></summary>
    let obeah = Namespaced_IRI.parse _namespace_name "obeah" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#occultism"></see>
    /// </summary>
    let occultism = Namespaced_IRI.parse _namespace_name "occultism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#onlyChild"></see>
    /// </summary>
    let onlyChild = Namespaced_IRI.parse _namespace_name "onlyChild" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#oppositionPolitics"></see></summary>
    let oppositionPolitics =
        Namespaced_IRI.parse _namespace_name "oppositionPolitics" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#optician"></see>
    /// </summary>
    let optician = Namespaced_IRI.parse _namespace_name "optician" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#orderly"></see>
    /// </summary>
    let orderly = Namespaced_IRI.parse _namespace_name "orderly" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#orphanageWork"></see>
    /// </summary>
    let orphanageWork =
        Namespaced_IRI.parse _namespace_name "orphanageWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialWork"></see>
    /// </summary>
    let socialWork = Namespaced_IRI.parse _namespace_name "socialWork" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pacifist"></see>
    /// </summary>
    let pacifist = Namespaced_IRI.parse _namespace_name "pacifist" |> NamespacedName
    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#paganism" title="#paganism"&gt;Paganism&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pagan"></see></summary>
    let pagan = Namespaced_IRI.parse _namespace_name "pagan" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#paganism"></see></summary>
    let paganism = Namespaced_IRI.parse _namespace_name "paganism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pantheism"></see></summary>
    let pantheism = Namespaced_IRI.parse _namespace_name "pantheism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#parishWork"></see>
    /// </summary>
    let parishWork = Namespaced_IRI.parse _namespace_name "parishWork" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#parliamentarianism"></see></summary>
    let parliamentarianism =
        Namespaced_IRI.parse _namespace_name "parliamentarianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#parliamentaryReform"></see></summary>
    let parliamentaryReform =
        Namespaced_IRI.parse _namespace_name "parliamentaryReform" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#parsiEthnicity"></see></summary>
    let parsiEthnicity =
        Namespaced_IRI.parse _namespace_name "parsiEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#participantOf"></see>
    /// </summary>
    let participantOf =
        Namespaced_IRI.parse _namespace_name "participantOf" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#paternalism"></see></summary>
    let paternalism =
        Namespaced_IRI.parse _namespace_name "paternalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#patriot"></see>
    /// </summary>
    let patriot = Namespaced_IRI.parse _namespace_name "patriot" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#patron"></see>
    /// </summary>
    let patron = Namespaced_IRI.parse _namespace_name "patron" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pawnbroker"></see>
    /// </summary>
    let pawnbroker = Namespaced_IRI.parse _namespace_name "pawnbroker" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#pentecostalism"></see></summary>
    let pentecostalism =
        Namespaced_IRI.parse _namespace_name "pentecostalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#personaOf"></see>
    /// </summary>
    let personaOf = Namespaced_IRI.parse _namespace_name "personaOf" |> NamespacedName

    /// <summary>
    /// Deprecated, with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#personalPropertySelfReported"></see></summary>
    let personalPropertySelfReported =
        Namespaced_IRI.parse _namespace_name "personalPropertySelfReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pharmacist"></see>
    /// </summary>
    let pharmacist = Namespaced_IRI.parse _namespace_name "pharmacist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#philanthropicVisitor"></see>
    /// </summary>
    let philanthropicVisitor =
        Namespaced_IRI.parse _namespace_name "philanthropicVisitor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#philosopher"></see>
    /// </summary>
    let philosopher =
        Namespaced_IRI.parse _namespace_name "philosopher" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#philosophicalRadicals"></see></summary>
    let philosophicalRadicals =
        Namespaced_IRI.parse _namespace_name "philosophicalRadicals" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#photography"></see>
    /// </summary>
    let photography =
        Namespaced_IRI.parse _namespace_name "photography" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#physiognomist"></see>
    /// </summary>
    let physiognomist =
        Namespaced_IRI.parse _namespace_name "physiognomist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#plumber"></see>
    /// </summary>
    let plumber = Namespaced_IRI.parse _namespace_name "plumber" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#plymouthBrethren"></see></summary>
    let plymouthBrethren =
        Namespaced_IRI.parse _namespace_name "plymouthBrethren" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#poetLaureate"></see>
    /// </summary>
    let poetLaureate =
        Namespaced_IRI.parse _namespace_name "poetLaureate" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#polishNationalism"></see></summary>
    let polishNationalism =
        Namespaced_IRI.parse _namespace_name "polishNationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#politicalHost"></see>
    /// </summary>
    let politicalHost =
        Namespaced_IRI.parse _namespace_name "politicalHost" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#politicalScience"></see>
    /// </summary>
    let politicalScience =
        Namespaced_IRI.parse _namespace_name "politicalScience" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#politicalSpeaker"></see>
    /// </summary>
    let politicalSpeaker =
        Namespaced_IRI.parse _namespace_name "politicalSpeaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#publicSpeaker"></see>
    /// </summary>
    let publicSpeaker =
        Namespaced_IRI.parse _namespace_name "publicSpeaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pollster"></see>
    /// </summary>
    let pollster = Namespaced_IRI.parse _namespace_name "pollster" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#poorAdvocacy"></see></summary>
    let poorAdvocacy =
        Namespaced_IRI.parse _namespace_name "poorAdvocacy" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#poorLawReform"></see></summary>
    let poorLawReform =
        Namespaced_IRI.parse _namespace_name "poorLawReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pornographer"></see>
    /// </summary>
    let pornographer =
        Namespaced_IRI.parse _namespace_name "pornographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#postalWorker"></see>
    /// </summary>
    let postalWorker =
        Namespaced_IRI.parse _namespace_name "postalWorker" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#pottery"></see>
    /// </summary>
    let pottery = Namespaced_IRI.parse _namespace_name "pottery" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#preferredBy"></see>
    /// </summary>
    let preferredBy =
        Namespaced_IRI.parse _namespace_name "preferredBy" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#presbyterianism"></see></summary>
    let presbyterianism =
        Namespaced_IRI.parse _namespace_name "presbyterianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#printing"></see>
    /// </summary>
    let printing = Namespaced_IRI.parse _namespace_name "printing" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#prisonReform"></see></summary>
    let prisonReform =
        Namespaced_IRI.parse _namespace_name "prisonReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#prisoner"></see>
    /// </summary>
    let prisoner = Namespaced_IRI.parse _namespace_name "prisoner" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#producer"></see>
    /// </summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#professional"></see>
    /// </summary>
    let professional =
        Namespaced_IRI.parse _namespace_name "professional" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#professor"></see>
    /// </summary>
    let professor = Namespaced_IRI.parse _namespace_name "professor" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#propagandist"></see>
    /// </summary>
    let propagandist =
        Namespaced_IRI.parse _namespace_name "propagandist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#propertyAgent"></see>
    /// </summary>
    let propertyAgent =
        Namespaced_IRI.parse _namespace_name "propertyAgent" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#propertyLawReform"></see></summary>
    let propertyLawReform =
        Namespaced_IRI.parse _namespace_name "propertyLawReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#propertyOwner"></see>
    /// </summary>
    let propertyOwner =
        Namespaced_IRI.parse _namespace_name "propertyOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#prophet"></see>
    /// </summary>
    let prophet = Namespaced_IRI.parse _namespace_name "prophet" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#prospector"></see>
    /// </summary>
    let prospector = Namespaced_IRI.parse _namespace_name "prospector" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#protestantRule"></see></summary>
    let protestantRule =
        Namespaced_IRI.parse _namespace_name "protestantRule" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#protoZionism"></see></summary>
    let protoZionism =
        Namespaced_IRI.parse _namespace_name "protoZionism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#publicReader"></see>
    /// </summary>
    let publicReader =
        Namespaced_IRI.parse _namespace_name "publicReader" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#punjabiEthnicity"></see></summary>
    let punjabiEthnicity =
        Namespaced_IRI.parse _namespace_name "punjabiEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#puritanism"></see></summary>
    let puritanism = Namespaced_IRI.parse _namespace_name "puritanism" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#quakerism"></see></summary>
    let quakerism = Namespaced_IRI.parse _namespace_name "quakerism" |> NamespacedName
    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#quakerism" title="#quakerism"&gt;Quakerism&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#quakers"></see></summary>
    let quakers = Namespaced_IRI.parse _namespace_name "quakers" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#radicalism"></see></summary>
    let radicalism = Namespaced_IRI.parse _namespace_name "radicalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#radioIndustry"></see>
    /// </summary>
    let radioIndustry =
        Namespaced_IRI.parse _namespace_name "radioIndustry" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#radioOperator"></see>
    /// </summary>
    let radioOperator =
        Namespaced_IRI.parse _namespace_name "radioOperator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#railwayWork"></see>
    /// </summary>
    let railwayWork =
        Namespaced_IRI.parse _namespace_name "railwayWork" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#dissentingChristianity" title="#dissentingChristianity"&gt;Dissenting Christianity&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#rationalDissenter"></see></summary>
    let rationalDissenter =
        Namespaced_IRI.parse _namespace_name "rationalDissenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#reading"></see>
    /// </summary>
    let reading = Namespaced_IRI.parse _namespace_name "reading" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#rebel"></see>
    /// </summary>
    let rebel = Namespaced_IRI.parse _namespace_name "rebel" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#redCross"></see>
    /// </summary>
    let redCross = Namespaced_IRI.parse _namespace_name "redCross" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#reformer"></see>
    /// </summary>
    let reformer = Namespaced_IRI.parse _namespace_name "reformer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#refugee"></see>
    /// </summary>
    let refugee = Namespaced_IRI.parse _namespace_name "refugee" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#refugeeWork"></see>
    /// </summary>
    let refugeeWork =
        Namespaced_IRI.parse _namespace_name "refugeeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#regionalGovernment"></see>
    /// </summary>
    let regionalGovernment =
        Namespaced_IRI.parse _namespace_name "regionalGovernment" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#reincarnation"></see></summary>
    let reincarnation =
        Namespaced_IRI.parse _namespace_name "reincarnation" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#spiritualism"></see></summary>
    let spiritualism =
        Namespaced_IRI.parse _namespace_name "spiritualism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#reliefWork"></see>
    /// </summary>
    let reliefWork = Namespaced_IRI.parse _namespace_name "reliefWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#religiousOfficial"></see>
    /// </summary>
    let religiousOfficial =
        Namespaced_IRI.parse _namespace_name "religiousOfficial" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#religiousStudies"></see>
    /// </summary>
    let religiousStudies =
        Namespaced_IRI.parse _namespace_name "religiousStudies" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#relocatesTo"></see>
    /// </summary>
    let relocatesTo =
        Namespaced_IRI.parse _namespace_name "relocatesTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#rescueWork"></see>
    /// </summary>
    let rescueWork = Namespaced_IRI.parse _namespace_name "rescueWork" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#researcher"></see>
    /// </summary>
    let researcher = Namespaced_IRI.parse _namespace_name "researcher" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#retail"></see>
    /// </summary>
    let retail = Namespaced_IRI.parse _namespace_name "retail" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#reviewer"></see>
    /// </summary>
    let reviewer = Namespaced_IRI.parse _namespace_name "reviewer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#riding"></see>
    /// </summary>
    let riding = Namespaced_IRI.parse _namespace_name "riding" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#romaniEthnicity"></see></summary>
    let romaniEthnicity =
        Namespaced_IRI.parse _namespace_name "romaniEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#rosicrucianism"></see></summary>
    let rosicrucianism =
        Namespaced_IRI.parse _namespace_name "rosicrucianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#rural-unskilled"></see>
    /// </summary>
    let ``rural-unskilled`` =
        Namespaced_IRI.parse _namespace_name "rural-unskilled" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#sabbatarianism"></see></summary>
    let sabbatarianism =
        Namespaced_IRI.parse _namespace_name "sabbatarianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sailor"></see>
    /// </summary>
    let sailor = Namespaced_IRI.parse _namespace_name "sailor" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#saint"></see>
    /// </summary>
    let saint = Namespaced_IRI.parse _namespace_name "saint" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#salesperson"></see>
    /// </summary>
    let salesperson =
        Namespaced_IRI.parse _namespace_name "salesperson" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#salter"></see>
    /// </summary>
    let salter = Namespaced_IRI.parse _namespace_name "salter" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#sanitaryMovement"></see></summary>
    let sanitaryMovement =
        Namespaced_IRI.parse _namespace_name "sanitaryMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#urbanReform"></see></summary>
    let urbanReform =
        Namespaced_IRI.parse _namespace_name "urbanReform" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#saxonNationalIdentity"></see>
    /// </summary>
    let saxonNationalIdentity =
        Namespaced_IRI.parse _namespace_name "saxonNationalIdentity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#scottishNationalism"></see></summary>
    let scottishNationalism =
        Namespaced_IRI.parse _namespace_name "scottishNationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#scottishRaceColour"></see></summary>
    let scottishRaceColour =
        Namespaced_IRI.parse _namespace_name "scottishRaceColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#seaCaptain"></see>
    /// </summary>
    let seaCaptain = Namespaced_IRI.parse _namespace_name "seaCaptain" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#secondarySchoolDiploma"></see>
    /// </summary>
    let secondarySchoolDiploma =
        Namespaced_IRI.parse _namespace_name "secondarySchoolDiploma" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#seekers"></see></summary>
    let seekers = Namespaced_IRI.parse _namespace_name "seekers" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#separatism"></see></summary>
    let separatism = Namespaced_IRI.parse _namespace_name "separatism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#sephardicJewishEthnicity"></see></summary>
    let sephardicJewishEthnicity =
        Namespaced_IRI.parse _namespace_name "sephardicJewishEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sephardicJewishNationalIdentity"></see>
    /// </summary>
    let sephardicJewishNationalIdentity =
        Namespaced_IRI.parse _namespace_name "sephardicJewishNationalIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#servants"></see>
    /// </summary>
    let servants = Namespaced_IRI.parse _namespace_name "servants" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#server"></see>
    /// </summary>
    let server = Namespaced_IRI.parse _namespace_name "server" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#settlementWork"></see>
    /// </summary>
    let settlementWork =
        Namespaced_IRI.parse _namespace_name "settlementWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#settler"></see>
    /// </summary>
    let settler = Namespaced_IRI.parse _namespace_name "settler" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialPurity"></see></summary>
    let socialPurity =
        Namespaced_IRI.parse _namespace_name "socialPurity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityBisexuality"></see>
    /// </summary>
    let sexualityBisexuality =
        Namespaced_IRI.parse _namespace_name "sexualityBisexuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityCelibacy"></see>
    /// </summary>
    let sexualityCelibacy =
        Namespaced_IRI.parse _namespace_name "sexualityCelibacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityFrigidity"></see>
    /// </summary>
    let sexualityFrigidity =
        Namespaced_IRI.parse _namespace_name "sexualityFrigidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityLibertinism"></see>
    /// </summary>
    let sexualityLibertinism =
        Namespaced_IRI.parse _namespace_name "sexualityLibertinism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityPromiscuity"></see>
    /// </summary>
    let sexualityPromiscuity =
        Namespaced_IRI.parse _namespace_name "sexualityPromiscuity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#shinto"></see></summary>
    let shinto = Namespaced_IRI.parse _namespace_name "shinto" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#shipping"></see>
    /// </summary>
    let shipping = Namespaced_IRI.parse _namespace_name "shipping" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#shopkeepers"></see>
    /// </summary>
    let shopkeepers =
        Namespaced_IRI.parse _namespace_name "shopkeepers" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#singer"></see>
    /// </summary>
    let singer = Namespaced_IRI.parse _namespace_name "singer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#skilledCraftpersonArtisan"></see>
    /// </summary>
    let skilledCraftpersonArtisan =
        Namespaced_IRI.parse _namespace_name "skilledCraftpersonArtisan" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#skinner"></see>
    /// </summary>
    let skinner = Namespaced_IRI.parse _namespace_name "skinner" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#slavEthnicity"></see></summary>
    let slavEthnicity =
        Namespaced_IRI.parse _namespace_name "slavEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#slave"></see>
    /// </summary>
    let slave = Namespaced_IRI.parse _namespace_name "slave" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#slave-forced-labourer"></see>
    /// </summary>
    let ``slave-forced-labourer`` =
        Namespaced_IRI.parse _namespace_name "slave-forced-labourer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#slaveOwner"></see>
    /// </summary>
    let slaveOwner = Namespaced_IRI.parse _namespace_name "slaveOwner" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#slaver"></see>
    /// </summary>
    let slaver = Namespaced_IRI.parse _namespace_name "slaver" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#smuggler"></see>
    /// </summary>
    let smuggler = Namespaced_IRI.parse _namespace_name "smuggler" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialGospel"></see></summary>
    let socialGospel =
        Namespaced_IRI.parse _namespace_name "socialGospel" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#socialScientist"></see>
    /// </summary>
    let socialScientist =
        Namespaced_IRI.parse _namespace_name "socialScientist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#socializer"></see>
    /// </summary>
    let socializer = Namespaced_IRI.parse _namespace_name "socializer" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#societyOfFriends"></see></summary>
    let societyOfFriends =
        Namespaced_IRI.parse _namespace_name "societyOfFriends" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#socinianism"></see></summary>
    let socinianism =
        Namespaced_IRI.parse _namespace_name "socinianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#sonOf"></see>
    /// </summary>
    let sonOf = Namespaced_IRI.parse _namespace_name "sonOf" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#spanishRepublicanism"></see></summary>
    let spanishRepublicanism =
        Namespaced_IRI.parse _namespace_name "spanishRepublicanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#spinner"></see>
    /// </summary>
    let spinner = Namespaced_IRI.parse _namespace_name "spinner" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#stalinism"></see></summary>
    let stalinism = Namespaced_IRI.parse _namespace_name "stalinism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#statelessNationalIdentity"></see></summary>
    let statelessNationalIdentity =
        Namespaced_IRI.parse _namespace_name "statelessNationalIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#statistician"></see>
    /// </summary>
    let statistician =
        Namespaced_IRI.parse _namespace_name "statistician" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepBrotherOf"></see>
    /// </summary>
    let stepBrotherOf =
        Namespaced_IRI.parse _namespace_name "stepBrotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepChildOf"></see>
    /// </summary>
    let stepChildOf =
        Namespaced_IRI.parse _namespace_name "stepChildOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepDaughterOf"></see>
    /// </summary>
    let stepDaughterOf =
        Namespaced_IRI.parse _namespace_name "stepDaughterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepFatherOf"></see>
    /// </summary>
    let stepFatherOf =
        Namespaced_IRI.parse _namespace_name "stepFatherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepParentOf"></see>
    /// </summary>
    let stepParentOf =
        Namespaced_IRI.parse _namespace_name "stepParentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepSisterOf"></see>
    /// </summary>
    let stepSisterOf =
        Namespaced_IRI.parse _namespace_name "stepSisterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stepSonOf"></see>
    /// </summary>
    let stepSonOf = Namespaced_IRI.parse _namespace_name "stepSonOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#stillbirth"></see>
    /// </summary>
    let stillbirth = Namespaced_IRI.parse _namespace_name "stillbirth" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#storyteller"></see>
    /// </summary>
    let storyteller =
        Namespaced_IRI.parse _namespace_name "storyteller" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#student"></see>
    /// </summary>
    let student = Namespaced_IRI.parse _namespace_name "student" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#studiedBy"></see>
    /// </summary>
    let studiedBy = Namespaced_IRI.parse _namespace_name "studiedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#studies"></see>
    /// </summary>
    let studies = Namespaced_IRI.parse _namespace_name "studies" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#sufism"></see></summary>
    let sufism = Namespaced_IRI.parse _namespace_name "sufism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#surveyor"></see>
    /// </summary>
    let surveyor = Namespaced_IRI.parse _namespace_name "surveyor" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#swedenborgianism"></see></summary>
    let swedenborgianism =
        Namespaced_IRI.parse _namespace_name "swedenborgianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#tatarNationalHeritage"></see></summary>
    let tatarNationalHeritage =
        Namespaced_IRI.parse _namespace_name "tatarNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#taxOfficial"></see>
    /// </summary>
    let taxOfficial =
        Namespaced_IRI.parse _namespace_name "taxOfficial" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#taxResistance"></see></summary>
    let taxResistance =
        Namespaced_IRI.parse _namespace_name "taxResistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#teacher"></see>
    /// </summary>
    let teacher = Namespaced_IRI.parse _namespace_name "teacher" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#teachesEducationalSubject"></see>
    /// </summary>
    let teachesEducationalSubject =
        Namespaced_IRI.parse _namespace_name "teachesEducationalSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#teachingQualification"></see>
    /// </summary>
    let teachingQualification =
        Namespaced_IRI.parse _namespace_name "teachingQualification" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#technician"></see>
    /// </summary>
    let technician = Namespaced_IRI.parse _namespace_name "technician" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#telephoneOperator"></see>
    /// </summary>
    let telephoneOperator =
        Namespaced_IRI.parse _namespace_name "telephoneOperator" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#televisionIndustry"></see>
    /// </summary>
    let televisionIndustry =
        Namespaced_IRI.parse _namespace_name "televisionIndustry" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#temperanceMovement"></see></summary>
    let temperanceMovement =
        Namespaced_IRI.parse _namespace_name "temperanceMovement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#textiles"></see>
    /// </summary>
    let textiles = Namespaced_IRI.parse _namespace_name "textiles" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#theism"></see></summary>
    let theism = Namespaced_IRI.parse _namespace_name "theism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#thracianEthnicity"></see></summary>
    let thracianEthnicity =
        Namespaced_IRI.parse _namespace_name "thracianEthnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#timberTrade"></see>
    /// </summary>
    let timberTrade =
        Namespaced_IRI.parse _namespace_name "timberTrade" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#timeCertaintyOf"></see>
    /// </summary>
    let timeCertaintyOf =
        Namespaced_IRI.parse _namespace_name "timeCertaintyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#tinker"></see>
    /// </summary>
    let tinker = Namespaced_IRI.parse _namespace_name "tinker" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#conservativePartyUk" title="#conservativePartyUk"&gt;Conservative Party (UK)&lt;/a&gt;.
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#toryPartyBritain"></see></summary>
    let toryPartyBritain =
        Namespaced_IRI.parse _namespace_name "toryPartyBritain" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#whiggism"></see></summary>
    let whiggism = Namespaced_IRI.parse _namespace_name "whiggism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#tourGuide"></see>
    /// </summary>
    let tourGuide = Namespaced_IRI.parse _namespace_name "tourGuide" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#tractarianMovement"></see></summary>
    let tractarianMovement =
        Namespaced_IRI.parse _namespace_name "tractarianMovement" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#tradeUnionism"></see></summary>
    let tradeUnionism =
        Namespaced_IRI.parse _namespace_name "tradeUnionism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#trader"></see>
    /// </summary>
    let trader = Namespaced_IRI.parse _namespace_name "trader" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#transGender"></see>
    /// </summary>
    let transGender =
        Namespaced_IRI.parse _namespace_name "transGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#translator"></see>
    /// </summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#travelling"></see>
    /// </summary>
    let travelling = Namespaced_IRI.parse _namespace_name "travelling" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#treasurer"></see>
    /// </summary>
    let treasurer = Namespaced_IRI.parse _namespace_name "treasurer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#trustee"></see>
    /// </summary>
    let trustee = Namespaced_IRI.parse _namespace_name "trustee" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#typeSetter"></see>
    /// </summary>
    let typeSetter = Namespaced_IRI.parse _namespace_name "typeSetter" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#uncleOf"></see>
    /// </summary>
    let uncleOf = Namespaced_IRI.parse _namespace_name "uncleOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#undefinedGender"></see>
    /// </summary>
    let undefinedGender =
        Namespaced_IRI.parse _namespace_name "undefinedGender" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#unitarianism" title="#unitarianism"&gt;Unitarianism&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#unitarianChurch"></see></summary>
    let unitarianChurch =
        Namespaced_IRI.parse _namespace_name "unitarianChurch" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#unitarianism"></see></summary>
    let unitarianism =
        Namespaced_IRI.parse _namespace_name "unitarianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#universalist"></see></summary>
    let universalist =
        Namespaced_IRI.parse _namespace_name "universalist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#unknownCertainty"></see>
    /// </summary>
    let unknownCertainty =
        Namespaced_IRI.parse _namespace_name "unknownCertainty" |> NamespacedName

    /// <summary>
    /// Deprecated with no current equivalence.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#unknownSex"></see></summary>
    let unknownSex = Namespaced_IRI.parse _namespace_name "unknownSex" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#unskilledLabourer"></see>
    /// </summary>
    let unskilledLabourer =
        Namespaced_IRI.parse _namespace_name "unskilledLabourer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#unspecifiedReproductiveHistory"></see>
    /// </summary>
    let unspecifiedReproductiveHistory =
        Namespaced_IRI.parse _namespace_name "unspecifiedReproductiveHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#upholsterer"></see>
    /// </summary>
    let upholsterer =
        Namespaced_IRI.parse _namespace_name "upholsterer" |> NamespacedName

    /// <summary>
    /// This term is a CWRC-specific addition not in the original Orlando tag set.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#upper-middleClass"></see></summary>
    let ``upper-middleClass`` =
        Namespaced_IRI.parse _namespace_name "upper-middleClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#urban-industrialUnskilled"></see>
    /// </summary>
    let ``urban-industrialUnskilled`` =
        Namespaced_IRI.parse _namespace_name "urban-industrialUnskilled" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#urbanPlanning"></see>
    /// </summary>
    let urbanPlanning =
        Namespaced_IRI.parse _namespace_name "urbanPlanning" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#utilitarianism"></see></summary>
    let utilitarianism =
        Namespaced_IRI.parse _namespace_name "utilitarianism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#vegetarianism"></see></summary>
    let vegetarianism =
        Namespaced_IRI.parse _namespace_name "vegetarianism" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#venerealDisease"></see>
    /// </summary>
    let venerealDisease =
        Namespaced_IRI.parse _namespace_name "venerealDisease" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#veterinaryWork"></see>
    /// </summary>
    let veterinaryWork =
        Namespaced_IRI.parse _namespace_name "veterinaryWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#vintner"></see>
    /// </summary>
    let vintner = Namespaced_IRI.parse _namespace_name "vintner" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#visits"></see>
    /// </summary>
    let visits = Namespaced_IRI.parse _namespace_name "visits" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#visualArtist"></see>
    /// </summary>
    let visualArtist =
        Namespaced_IRI.parse _namespace_name "visualArtist" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#vitalism"></see></summary>
    let vitalism = Namespaced_IRI.parse _namespace_name "vitalism" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#volunteer"></see>
    /// </summary>
    let volunteer = Namespaced_IRI.parse _namespace_name "volunteer" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#walking"></see>
    /// </summary>
    let walking = Namespaced_IRI.parse _namespace_name "walking" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#warehouseWork"></see>
    /// </summary>
    let warehouseWork =
        Namespaced_IRI.parse _namespace_name "warehouseWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#watchmaker"></see>
    /// </summary>
    let watchmaker = Namespaced_IRI.parse _namespace_name "watchmaker" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#weaver"></see>
    /// </summary>
    let weaver = Namespaced_IRI.parse _namespace_name "weaver" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#welder"></see>
    /// </summary>
    let welder = Namespaced_IRI.parse _namespace_name "welder" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of foreign instance ISO 3166-2:GB-WLS.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#welshNationalHeritage"></see></summary>
    let welshNationalHeritage =
        Namespaced_IRI.parse _namespace_name "welshNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#welshLabel"></see>
    /// </summary>
    let welshLabel = Namespaced_IRI.parse _namespace_name "welshLabel" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#welshNationalism"></see></summary>
    let welshNationalism =
        Namespaced_IRI.parse _namespace_name "welshNationalism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#wendishEthnicity"></see></summary>
    let wendishEthnicity =
        Namespaced_IRI.parse _namespace_name "wendishEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#wesleyanism"></see></summary>
    let wesleyanism =
        Namespaced_IRI.parse _namespace_name "wesleyanism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#westIndianEthnicity"></see></summary>
    let westIndianEthnicity =
        Namespaced_IRI.parse _namespace_name "westIndianEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#westIndianNationalHeritage"></see></summary>
    let westIndianNationalHeritage =
        Namespaced_IRI.parse _namespace_name "westIndianNationalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#wetNurse"></see>
    /// </summary>
    let wetNurse = Namespaced_IRI.parse _namespace_name "wetNurse" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#whaler"></see>
    /// </summary>
    let whaler = Namespaced_IRI.parse _namespace_name "whaler" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#whiteEthnicity"></see></summary>
    let whiteEthnicity =
        Namespaced_IRI.parse _namespace_name "whiteEthnicity" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#whiteRaceColour"></see></summary>
    let whiteRaceColour =
        Namespaced_IRI.parse _namespace_name "whiteRaceColour" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of instance &lt;a href="#whiteRaceColour" title="#whiteRaceColour"&gt;white&lt;/a&gt;.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#whiteRace"></see></summary>
    let whiteRace = Namespaced_IRI.parse _namespace_name "whiteRace" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#wife"></see>
    /// </summary>
    let wife = Namespaced_IRI.parse _namespace_name "wife" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#wifeOf"></see>
    /// </summary>
    let wifeOf = Namespaced_IRI.parse _namespace_name "wifeOf" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#wilkite"></see></summary>
    let wilkite = Namespaced_IRI.parse _namespace_name "wilkite" |> NamespacedName
    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#witness"></see>
    /// </summary>
    let witness = Namespaced_IRI.parse _namespace_name "witness" |> NamespacedName
    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#womanism"></see></summary>
    let womanism = Namespaced_IRI.parse _namespace_name "womanism" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#womensEducationReform"></see></summary>
    let womensEducationReform =
        Namespaced_IRI.parse _namespace_name "womensEducationReform" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#womensEmploymentReform"></see></summary>
    let womensEmploymentReform =
        Namespaced_IRI.parse _namespace_name "womensEmploymentReform" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#womensEnfranchisement"></see></summary>
    let womensEnfranchisement =
        Namespaced_IRI.parse _namespace_name "womensEnfranchisement" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#workingClass"></see>
    /// </summary>
    let workingClass =
        Namespaced_IRI.parse _namespace_name "workingClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#writerInResidence"></see>
    /// </summary>
    let writerInResidence =
        Namespaced_IRI.parse _namespace_name "writerInResidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#writingGroupParticipant"></see>
    /// </summary>
    let writingGroupParticipant =
        Namespaced_IRI.parse _namespace_name "writingGroupParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#yeoman-farmer"></see>
    /// </summary>
    let ``yeoman-farmer`` =
        Namespaced_IRI.parse _namespace_name "yeoman-farmer" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#yorkist"></see>
    /// </summary>
    let yorkist = Namespaced_IRI.parse _namespace_name "yorkist" |> NamespacedName

    /// <summary>
    ///   <see href="http://sparql.cwrc.ca/ontologies/cwrc#youngestChild"></see>
    /// </summary>
    let youngestChild =
        Namespaced_IRI.parse _namespace_name "youngestChild" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#zen"></see></summary>
    let zen = Namespaced_IRI.parse _namespace_name "zen" |> NamespacedName

    /// <summary>
    /// The description for this term is indebted to DBpedia.
    /// <see href="http://sparql.cwrc.ca/ontologies/cwrc#zoroastrianism"></see></summary>
    let zoroastrianism =
        Namespaced_IRI.parse _namespace_name "zoroastrianism" |> NamespacedName
