namespace http.sparql.cwrc.ca.ontologies.cwrc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cwrc =
    let _namespace_iri = Namespace_Iri cwrc |> NamespaceIRI
    /// <summary>
    ///   <para>cwrc:ConstanceCrompton</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ConstanceCrompton">http://sparql.cwrc.ca/ontologies/cwrc#ConstanceCrompton</seealso>
    let ConstanceCrompton = Prefixed_Name(cwrc, "ConstanceCrompton") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:JohnSimpson</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#JohnSimpson">http://sparql.cwrc.ca/ontologies/cwrc#JohnSimpson</seealso>
    let JohnSimpson = Prefixed_Name(cwrc, "JohnSimpson") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:JasmineDrudgeWillson</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#JasmineDrudgeWillson">http://sparql.cwrc.ca/ontologies/cwrc#JasmineDrudgeWillson</seealso>
    let JasmineDrudgeWillson =
        Prefixed_Name(cwrc, "JasmineDrudgeWillson") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:RobWarren</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#RobWarren">http://sparql.cwrc.ca/ontologies/cwrc#RobWarren</seealso>
    let RobWarren = Prefixed_Name(cwrc, "RobWarren") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:datasetdefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Dataset</para>
    ///   <para>L'Ontologie CWRC est l'ontologie du Collaboratoire scientifique des écrits du Canada.</para>
    ///   <para>The CWRC Ontology is the ontology of the Canadian Writing Research Collaboratory.</para>
    /// labels<para>The CWRC Ontology</para><para>L'Ontologie CWRC</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#datasetdefinition">http://sparql.cwrc.ca/ontologies/cwrc#datasetdefinition</seealso>
    let datasetdefinition = Prefixed_Name(cwrc, "datasetdefinition") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571">http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571</seealso>
    let _27faa9ed_1d5c_44c4_b3f3_e6ac3f57e5f9_5f1ecef571 =
        Prefixed_Name(cwrc, "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976">http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976</seealso>
    let _3238e1a7_6d28_49ed_a48a_cb2cb5e3d1cc_e3d3563976 =
        Prefixed_Name(cwrc, "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f">http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f</seealso>
    let _3238e1a7_6d28_49ed_a48a_cb2cb5e3d1cc_5cdc250d3f =
        Prefixed_Name(cwrc, "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236">http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236</seealso>
    let _366c694c_b5bd_47b4_80a9_2dead4f7a7cb_fe3a497236 =
        Prefixed_Name(cwrc, "366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c">http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c</seealso>
    let aaa909f5_ffb5_4995_8245_b169d3c64746_352a867f1c =
        Prefixed_Name(cwrc, "aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aaa909f5-ffb5-4995-8245-b169d3c64746-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Proceedings</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-partof">http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-partof</seealso>
    let aaa909f5_ffb5_4995_8245_b169d3c64746_partof =
        Prefixed_Name(cwrc, "aaa909f5-ffb5-4995-8245-b169d3c64746-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:pro-Slavery</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>pro-esclavagisme</para><para>pro-slavery</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pro-Slavery">http://sparql.cwrc.ca/ontologies/cwrc#pro-Slavery</seealso>
    let pro_Slavery = Prefixed_Name(cwrc, "pro-Slavery") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:humanRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>droits de l'homme</para><para>human rights</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#humanRights">http://sparql.cwrc.ca/ontologies/cwrc#humanRights</seealso>
    let humanRights = Prefixed_Name(cwrc, "humanRights") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:civilRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>civil rights movement</para><para>droits civiques</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#civilRights">http://sparql.cwrc.ca/ontologies/cwrc#civilRights</seealso>
    let civilRights = Prefixed_Name(cwrc, "civilRights") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:racialEquality</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>racial equality</para><para>équité raciale</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#racialEquality">http://sparql.cwrc.ca/ontologies/cwrc#racialEquality</seealso>
    let racialEquality = Prefixed_Name(cwrc, "racialEquality") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:abrahamicReligions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Religions abrahamiques</para><para>Abrahamic religions</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#abrahamicReligions">http://sparql.cwrc.ca/ontologies/cwrc#abrahamicReligions</seealso>
    let abrahamicReligions = Prefixed_Name(cwrc, "abrahamicReligions") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:education</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>education</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#education">http://sparql.cwrc.ca/ontologies/cwrc#education</seealso>
    let education = Prefixed_Name(cwrc, "education") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:finance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>finance</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#finance">http://sparql.cwrc.ca/ontologies/cwrc#finance</seealso>
    let finance = Prefixed_Name(cwrc, "finance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:actorManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>actor manager</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#actorManager">http://sparql.cwrc.ca/ontologies/cwrc#actorManager</seealso>
    let actorManager = Prefixed_Name(cwrc, "actorManager") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:theatreWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>theatre work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#theatreWork">http://sparql.cwrc.ca/ontologies/cwrc#theatreWork</seealso>
    let theatreWork = Prefixed_Name(cwrc, "theatreWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:adjudicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>adjudicator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#adjudicator">http://sparql.cwrc.ca/ontologies/cwrc#adjudicator</seealso>
    let adjudicator = Prefixed_Name(cwrc, "adjudicator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:adoption</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>adoption</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#adoption">http://sparql.cwrc.ca/ontologies/cwrc#adoption</seealso>
    let adoption = Prefixed_Name(cwrc, "adoption") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:adventism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Adventisme</para><para>Adventism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#adventism">http://sparql.cwrc.ca/ontologies/cwrc#adventism</seealso>
    let adventism = Prefixed_Name(cwrc, "adventism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:advertising</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>advertising</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#advertising">http://sparql.cwrc.ca/ontologies/cwrc#advertising</seealso>
    let advertising = Prefixed_Name(cwrc, "advertising") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b69cb6a0-ac73-4219-bfb0-e4804ff1403e</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e">http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e</seealso>
    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e =
        Prefixed_Name(cwrc, "b69cb6a0-ac73-4219-bfb0-e4804ff1403e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214">http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214</seealso>
    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e_f478fff214 =
        Prefixed_Name(cwrc, "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251">http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251</seealso>
    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e_00295cd251 =
        Prefixed_Name(cwrc, "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8">http://sparql.cwrc.ca/ontologies/cwrc#b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8</seealso>
    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e_d3cf0482b8 =
        Prefixed_Name(cwrc, "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:construction</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>construction</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#construction">http://sparql.cwrc.ca/ontologies/cwrc#construction</seealso>
    let construction = Prefixed_Name(cwrc, "construction") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:egyptianNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>nationalisme égyptien</para><para>Egyptian nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#egyptianNationalism">http://sparql.cwrc.ca/ontologies/cwrc#egyptianNationalism</seealso>
    let egyptianNationalism = Prefixed_Name(cwrc, "egyptianNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:elderRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>droit des personnes âgées</para><para>elder rights</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#elderRights">http://sparql.cwrc.ca/ontologies/cwrc#elderRights</seealso>
    let elderRights = Prefixed_Name(cwrc, "elderRights") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:eldestChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:BirthPosition</para>
    ///
    /// labels<para>eldest</para><para>aîné·e</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#eldestChild">http://sparql.cwrc.ca/ontologies/cwrc#eldestChild</seealso>
    let eldestChild = Prefixed_Name(cwrc, "eldestChild") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:employer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>employer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#employer">http://sparql.cwrc.ca/ontologies/cwrc#employer</seealso>
    let employer = Prefixed_Name(cwrc, "employer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:employmentAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>employment agent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#employmentAgent">http://sparql.cwrc.ca/ontologies/cwrc#employmentAgent</seealso>
    let employmentAgent = Prefixed_Name(cwrc, "employmentAgent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:engineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>engineering</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#engineering">http://sparql.cwrc.ca/ontologies/cwrc#engineering</seealso>
    let engineering = Prefixed_Name(cwrc, "engineering") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:england</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#englishGeographicHeritage" title="#englishGeographicHeritage"&gt;England&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#englishGeographicHeritage" title="#englishGeographicHeritage"&gt;Angleterre&lt;/a&gt;.</para>
    /// labels<para>Angleterre</para><para>England</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#england">http://sparql.cwrc.ca/ontologies/cwrc#england</seealso>
    let england = Prefixed_Name(cwrc, "england") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:englishGeographicHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:GeographicHeritage</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Angleterre</para><para>England</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#englishGeographicHeritage">http://sparql.cwrc.ca/ontologies/cwrc#englishGeographicHeritage</seealso>
    let englishGeographicHeritage =
        Prefixed_Name(cwrc, "englishGeographicHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:englishLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:TextLabels</para>
    ///
    /// labels<para>identité anglais</para><para>English identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#englishLabel">http://sparql.cwrc.ca/ontologies/cwrc#englishLabel</seealso>
    let englishLabel = Prefixed_Name(cwrc, "englishLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:englandLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:TextLabels</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#englishLabel" title="#englishLabel"&gt;English identity&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#englishLabel" title="#englishLabel"&gt;identité anglais&lt;/a&gt;.</para>
    /// labels<para>Angleterre</para><para>England</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#englandLabel">http://sparql.cwrc.ca/ontologies/cwrc#englandLabel</seealso>
    let englandLabel = Prefixed_Name(cwrc, "englandLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:englishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>English</para><para>Anglais</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#englishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#englishEthnicity</seealso>
    let englishEthnicity = Prefixed_Name(cwrc, "englishEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasGrandMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has grandmother</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandMother">http://sparql.cwrc.ca/ontologies/cwrc#hasGrandMother</seealso>
    let hasGrandMother = Prefixed_Name(cwrc, "hasGrandMother") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasGrandParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has grandparent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandParent">http://sparql.cwrc.ca/ontologies/cwrc#hasGrandParent</seealso>
    let hasGrandParent = Prefixed_Name(cwrc, "hasGrandParent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:grandSonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>petit fils de</para><para>grandson of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#grandSonOf">http://sparql.cwrc.ca/ontologies/cwrc#grandSonOf</seealso>
    let grandSonOf = Prefixed_Name(cwrc, "grandSonOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasGrandSon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has grandson</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandSon">http://sparql.cwrc.ca/ontologies/cwrc#hasGrandSon</seealso>
    let hasGrandSon = Prefixed_Name(cwrc, "hasGrandSon") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:greekNationalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Greek nationalism</para><para>nationliste grec</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#greekNationalist">http://sparql.cwrc.ca/ontologies/cwrc#greekNationalist</seealso>
    let greekNationalist = Prefixed_Name(cwrc, "greekNationalist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:grocer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>grocer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#grocer">http://sparql.cwrc.ca/ontologies/cwrc#grocer</seealso>
    let grocer = Prefixed_Name(cwrc, "grocer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:guardian</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>guardian</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#guardian">http://sparql.cwrc.ca/ontologies/cwrc#guardian</seealso>
    let guardian = Prefixed_Name(cwrc, "guardian") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:guardianOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>tuteur (‑trice) / gardien (ne)</para><para>guardian of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#guardianOf">http://sparql.cwrc.ca/ontologies/cwrc#guardianOf</seealso>
    let guardianOf = Prefixed_Name(cwrc, "guardianOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasInterpersonalRelationshipWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has interpersonal relationship with</para><para>a relation interpersonnelle avec</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasInterpersonalRelationshipWith">http://sparql.cwrc.ca/ontologies/cwrc#hasInterpersonalRelationshipWith</seealso>
    let hasInterpersonalRelationshipWith =
        Prefixed_Name(cwrc, "hasInterpersonalRelationshipWith") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGuardian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has guardian</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGuardian">http://sparql.cwrc.ca/ontologies/cwrc#hasGuardian</seealso>
    let hasGuardian = Prefixed_Name(cwrc, "hasGuardian") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:guelphPartyFlorence</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Guelph party (Florence)</para><para>Guelfes et gibelins</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#guelphPartyFlorence">http://sparql.cwrc.ca/ontologies/cwrc#guelphPartyFlorence</seealso>
    let guelphPartyFlorence = Prefixed_Name(cwrc, "guelphPartyFlorence") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:haberdasher</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>haberdasher</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#haberdasher">http://sparql.cwrc.ca/ontologies/cwrc#haberdasher</seealso>
    let haberdasher = Prefixed_Name(cwrc, "haberdasher") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:halfBrotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>half-brother of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#halfBrotherOf">http://sparql.cwrc.ca/ontologies/cwrc#halfBrotherOf</seealso>
    let halfBrotherOf = Prefixed_Name(cwrc, "halfBrotherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasHalfBrother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has half-brother</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasHalfBrother">http://sparql.cwrc.ca/ontologies/cwrc#hasHalfBrother</seealso>
    let hasHalfBrother = Prefixed_Name(cwrc, "hasHalfBrother") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:halfSisterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>half-sister of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#halfSisterOf">http://sparql.cwrc.ca/ontologies/cwrc#halfSisterOf</seealso>
    let halfSisterOf = Prefixed_Name(cwrc, "halfSisterOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sisterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sister of</para><para>soeur de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sisterOf">http://sparql.cwrc.ca/ontologies/cwrc#sisterOf</seealso>
    let sisterOf = Prefixed_Name(cwrc, "sisterOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasHalfSister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has half-sister</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasHalfSister">http://sparql.cwrc.ca/ontologies/cwrc#hasHalfSister</seealso>
    let hasHalfSister = Prefixed_Name(cwrc, "hasHalfSister") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:handwritingExpert</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>handwriting expert</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#handwritingExpert">http://sparql.cwrc.ca/ontologies/cwrc#handwritingExpert</seealso>
    let handwritingExpert = Prefixed_Name(cwrc, "handwritingExpert") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hanoverian</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Maison de Hanovre</para><para>Hanoverian</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hanoverian">http://sparql.cwrc.ca/ontologies/cwrc#hanoverian</seealso>
    let hanoverian = Prefixed_Name(cwrc, "hanoverian") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:heterosexual</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Sexuality</para>
    ///
    /// labels<para>heterosexuality</para><para>hétérosexualité</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#heterosexual">http://sparql.cwrc.ca/ontologies/cwrc#heterosexual</seealso>
    let heterosexual = Prefixed_Name(cwrc, "heterosexual") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:highCertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Certainty</para>
    ///
    /// labels<para>forte probabilité</para><para>high certainty</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#highCertainty">http://sparql.cwrc.ca/ontologies/cwrc#highCertainty</seealso>
    let highCertainty = Prefixed_Name(cwrc, "highCertainty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nephewOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>nephew of</para><para>neveu de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nephewOf">http://sparql.cwrc.ca/ontologies/cwrc#nephewOf</seealso>
    let nephewOf = Prefixed_Name(cwrc, "nephewOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:newDealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>défenseur du New Deal</para><para>new dealer</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#newDealer">http://sparql.cwrc.ca/ontologies/cwrc#newDealer</seealso>
    let newDealer = Prefixed_Name(cwrc, "newDealer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:newThought</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Nouvelle Pensée</para><para>New Thought</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#newThought">http://sparql.cwrc.ca/ontologies/cwrc#newThought</seealso>
    let newThought = Prefixed_Name(cwrc, "newThought") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:reliefWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>relief work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#reliefWork">http://sparql.cwrc.ca/ontologies/cwrc#reliefWork</seealso>
    let reliefWork = Prefixed_Name(cwrc, "reliefWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:religiousOfficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>religiousOfficial</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#religiousOfficial">http://sparql.cwrc.ca/ontologies/cwrc#religiousOfficial</seealso>
    let religiousOfficial = Prefixed_Name(cwrc, "religiousOfficial") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:religiousStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>religious studies</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#religiousStudies">http://sparql.cwrc.ca/ontologies/cwrc#religiousStudies</seealso>
    let religiousStudies = Prefixed_Name(cwrc, "religiousStudies") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:relocatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>moved to</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#relocatesTo">http://sparql.cwrc.ca/ontologies/cwrc#relocatesTo</seealso>
    let relocatesTo = Prefixed_Name(cwrc, "relocatesTo") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:whiteRace</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#whiteRaceColour" title="#whiteRaceColour"&gt;blanc&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#whiteRaceColour" title="#whiteRaceColour"&gt;white&lt;/a&gt;.</para>
    /// labels<para>blanc</para><para>white</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#whiteRace">http://sparql.cwrc.ca/ontologies/cwrc#whiteRace</seealso>
    let whiteRace = Prefixed_Name(cwrc, "whiteRace") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:wife</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>wife</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#wife">http://sparql.cwrc.ca/ontologies/cwrc#wife</seealso>
    let wife = Prefixed_Name(cwrc, "wife") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:wifeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>femme de</para><para>wife of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#wifeOf">http://sparql.cwrc.ca/ontologies/cwrc#wifeOf</seealso>
    let wifeOf = Prefixed_Name(cwrc, "wifeOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:wilkite</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Wilkite</para><para>Wilkite</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#wilkite">http://sparql.cwrc.ca/ontologies/cwrc#wilkite</seealso>
    let wilkite = Prefixed_Name(cwrc, "wilkite") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:witness</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>witness</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#witness">http://sparql.cwrc.ca/ontologies/cwrc#witness</seealso>
    let witness = Prefixed_Name(cwrc, "witness") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:womanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>féminisme africain</para><para>womanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#womanism">http://sparql.cwrc.ca/ontologies/cwrc#womanism</seealso>
    let womanism = Prefixed_Name(cwrc, "womanism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:womensEducationReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme de l'éducation des filles</para><para>women's education reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#womensEducationReform">http://sparql.cwrc.ca/ontologies/cwrc#womensEducationReform</seealso>
    let womensEducationReform =
        Prefixed_Name(cwrc, "womensEducationReform") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:womensEmploymentReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme du travail des femmes</para><para>women's employment reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#womensEmploymentReform">http://sparql.cwrc.ca/ontologies/cwrc#womensEmploymentReform</seealso>
    let womensEmploymentReform =
        Prefixed_Name(cwrc, "womensEmploymentReform") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:womensEnfranchisement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Women's Enfranchisement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#womensEnfranchisement">http://sparql.cwrc.ca/ontologies/cwrc#womensEnfranchisement</seealso>
    let womensEnfranchisement =
        Prefixed_Name(cwrc, "womensEnfranchisement") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:writerInResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>writer In residence</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#writerInResidence">http://sparql.cwrc.ca/ontologies/cwrc#writerInResidence</seealso>
    let writerInResidence = Prefixed_Name(cwrc, "writerInResidence") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:writingGroupParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>writing group participant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#writingGroupParticipant">http://sparql.cwrc.ca/ontologies/cwrc#writingGroupParticipant</seealso>
    let writingGroupParticipant =
        Prefixed_Name(cwrc, "writingGroupParticipant") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:yeoman-farmer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>paysanne yeoman</para><para>yeoman farmer</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#yeoman-farmer">http://sparql.cwrc.ca/ontologies/cwrc#yeoman-farmer</seealso>
    let yeoman_farmer = Prefixed_Name(cwrc, "yeoman-farmer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:yorkist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Maison d'York</para><para>Yorkist</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#yorkist">http://sparql.cwrc.ca/ontologies/cwrc#yorkist</seealso>
    let yorkist = Prefixed_Name(cwrc, "yorkist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:youngestChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:BirthPosition</para>
    ///
    /// labels<para>benjamin·e</para><para>youngest</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#youngestChild">http://sparql.cwrc.ca/ontologies/cwrc#youngestChild</seealso>
    let youngestChild = Prefixed_Name(cwrc, "youngestChild") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sshrc</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sshrc">http://sparql.cwrc.ca/ontologies/cwrc#sshrc</seealso>
    let sshrc = Prefixed_Name(cwrc, "sshrc") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:KimMartin</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#KimMartin">http://sparql.cwrc.ca/ontologies/cwrc#KimMartin</seealso>
    let KimMartin = Prefixed_Name(cwrc, "KimMartin") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:JoelCummings</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#JoelCummings">http://sparql.cwrc.ca/ontologies/cwrc#JoelCummings</seealso>
    let JoelCummings = Prefixed_Name(cwrc, "JoelCummings") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:GurjapSingh</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#GurjapSingh">http://sparql.cwrc.ca/ontologies/cwrc#GurjapSingh</seealso>
    let GurjapSingh = Prefixed_Name(cwrc, "GurjapSingh") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e">http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e</seealso>
    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174_dbafaea23e =
        Prefixed_Name(cwrc, "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>évènement</para><para>event</para><para>event</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Event">http://sparql.cwrc.ca/ontologies/cwrc#Event</seealso>
    let Event = Prefixed_Name(cwrc, "Event") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:FamilyContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>family context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#FamilyContext">http://sparql.cwrc.ca/ontologies/cwrc#FamilyContext</seealso>
    let FamilyContext = Prefixed_Name(cwrc, "FamilyContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:administrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>administrator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#administrator">http://sparql.cwrc.ca/ontologies/cwrc#administrator</seealso>
    let administrator = Prefixed_Name(cwrc, "administrator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:protestantism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    /// labels<para>protestantisme</para><para>protestantismo</para><para>protestantisme</para><para>Protestantism</para><para>protestant</para><para>hsin chiao</para><para>xīn jiāo</para><para>xin jiao</para><para>抗羅宗</para><para>新教</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#protestantism">http://sparql.cwrc.ca/ontologies/cwrc#protestantism</seealso>
    let protestantism = Prefixed_Name(cwrc, "protestantism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:transportationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>transportation work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#transportationWork">http://sparql.cwrc.ca/ontologies/cwrc#transportationWork</seealso>
    let transportationWork = Prefixed_Name(cwrc, "transportationWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:awardedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>awarded to</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#awardedTo">http://sparql.cwrc.ca/ontologies/cwrc#awardedTo</seealso>
    let awardedTo = Prefixed_Name(cwrc, "awardedTo") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:connoisseur</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>connoisseur</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#connoisseur">http://sparql.cwrc.ca/ontologies/cwrc#connoisseur</seealso>
    let connoisseur = Prefixed_Name(cwrc, "connoisseur") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gaelEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Gael</para><para>Gael</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gaelEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#gaelEthnicity</seealso>
    let gaelEthnicity = Prefixed_Name(cwrc, "gaelEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:religionSelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>religious affiliation (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#religionSelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#religionSelfReportedOf</seealso>
    let religionSelfReportedOf =
        Prefixed_Name(cwrc, "religionSelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasRelocatee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has relocatee</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasRelocatee">http://sparql.cwrc.ca/ontologies/cwrc#hasRelocatee</seealso>
    let hasRelocatee = Prefixed_Name(cwrc, "hasRelocatee") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:landReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>land reform</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#landReform">http://sparql.cwrc.ca/ontologies/cwrc#landReform</seealso>
    let landReform = Prefixed_Name(cwrc, "landReform") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:latitudinarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Latitudinarianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#latitudinarianism">http://sparql.cwrc.ca/ontologies/cwrc#latitudinarianism</seealso>
    let latitudinarianism = Prefixed_Name(cwrc, "latitudinarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:patriotism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Patriotisme</para><para>patriotism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#patriotism">http://sparql.cwrc.ca/ontologies/cwrc#patriotism</seealso>
    let patriotism = Prefixed_Name(cwrc, "patriotism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:naturalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>naturalist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#naturalist">http://sparql.cwrc.ca/ontologies/cwrc#naturalist</seealso>
    let naturalist = Prefixed_Name(cwrc, "naturalist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:navy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>naval rating</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#navy">http://sparql.cwrc.ca/ontologies/cwrc#navy</seealso>
    let navy = Prefixed_Name(cwrc, "navy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nazism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Nazisme</para><para>Nazism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nazism">http://sparql.cwrc.ca/ontologies/cwrc#nazism</seealso>
    let nazism = Prefixed_Name(cwrc, "nazism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:needlework</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>needlework</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#needlework">http://sparql.cwrc.ca/ontologies/cwrc#needlework</seealso>
    let needlework = Prefixed_Name(cwrc, "needlework") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:neo-thomism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>néothomisme</para><para>Neo-thomism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#neo-thomism">http://sparql.cwrc.ca/ontologies/cwrc#neo-thomism</seealso>
    let neo_thomism = Prefixed_Name(cwrc, "neo-thomism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:watchmaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>watchmaker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#watchmaker">http://sparql.cwrc.ca/ontologies/cwrc#watchmaker</seealso>
    let watchmaker = Prefixed_Name(cwrc, "watchmaker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:weaver</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>weaver</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#weaver">http://sparql.cwrc.ca/ontologies/cwrc#weaver</seealso>
    let weaver = Prefixed_Name(cwrc, "weaver") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:welder</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>welder</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#welder">http://sparql.cwrc.ca/ontologies/cwrc#welder</seealso>
    let welder = Prefixed_Name(cwrc, "welder") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:welshNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance ISO 3166-2:GB-WLS.</para>
    ///   <para>Deprecated in favour of foreign instance ISO 3166-2:GB-WLS.</para>
    /// labels<para>Gallois</para><para>Welsh</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#welshNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#welshNationalHeritage</seealso>
    let welshNationalHeritage =
        Prefixed_Name(cwrc, "welshNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:welshLabel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#welshLabel">http://sparql.cwrc.ca/ontologies/cwrc#welshLabel</seealso>
    let welshLabel = Prefixed_Name(cwrc, "welshLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:AlliyyaMo</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#AlliyyaMo">http://sparql.cwrc.ca/ontologies/cwrc#AlliyyaMo</seealso>
    let AlliyyaMo = Prefixed_Name(cwrc, "AlliyyaMo") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:06e019b1-2bad-4fc2-8666-6f374a2e246a</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a">http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a</seealso>
    let _06e019b1_2bad_4fc2_8666_6f374a2e246a =
        Prefixed_Name(cwrc, "06e019b1-2bad-4fc2-8666-6f374a2e246a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8">http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8</seealso>
    let _06e019b1_2bad_4fc2_8666_6f374a2e246a_3fb34a38c8 =
        Prefixed_Name(cwrc, "06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:2002eb96-4775-4ae0-ba0f-6704c30264a9</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9">http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9</seealso>
    let _2002eb96_4775_4ae0_ba0f_6704c30264a9 =
        Prefixed_Name(cwrc, "2002eb96-4775-4ae0-ba0f-6704c30264a9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94">http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94</seealso>
    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_42d9d30d94 =
        Prefixed_Name(cwrc, "772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4">http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4</seealso>
    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_706552b3f4 =
        Prefixed_Name(cwrc, "772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:IndexedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>indexed name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#IndexedName">http://sparql.cwrc.ca/ontologies/cwrc#IndexedName</seealso>
    let IndexedName = Prefixed_Name(cwrc, "IndexedName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Monarchism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-monarchism</para><para>antimonarchisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Monarchism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Monarchism</seealso>
    let anti_Monarchism = Prefixed_Name(cwrc, "anti-Monarchism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ancestorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ancestor de</para><para>ancestor of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ancestorOf">http://sparql.cwrc.ca/ontologies/cwrc#ancestorOf</seealso>
    let ancestorOf = Prefixed_Name(cwrc, "ancestorOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasBirthPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has birth place</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPlace">http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPlace</seealso>
    let hasBirthPlace = Prefixed_Name(cwrc, "hasBirthPlace") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:black</para>
    /// </summary>
    /// <remarks>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#blackRaceColour" title="#blackRaceColour"&gt;noir&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#blackRaceColour" title="#blackRaceColour"&gt;black&lt;/a&gt;.</para>
    /// labels<para>black (race)</para><para>noir (race)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#black">http://sparql.cwrc.ca/ontologies/cwrc#black</seealso>
    let black = Prefixed_Name(cwrc, "black") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:blackRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>black</para><para>noir</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#blackRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#blackRaceColour</seealso>
    let blackRaceColour = Prefixed_Name(cwrc, "blackRaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:corporateDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>corporate or organizational director</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#corporateDirector">http://sparql.cwrc.ca/ontologies/cwrc#corporateDirector</seealso>
    let corporateDirector = Prefixed_Name(cwrc, "corporateDirector") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cousinOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>cousin de</para><para>cousin of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cousinOf">http://sparql.cwrc.ca/ontologies/cwrc#cousinOf</seealso>
    let cousinOf = Prefixed_Name(cwrc, "cousinOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasCousin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has cousin</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCousin">http://sparql.cwrc.ca/ontologies/cwrc#hasCousin</seealso>
    let hasCousin = Prefixed_Name(cwrc, "hasCousin") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:credentialHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>credential held by</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#credentialHeldBy">http://sparql.cwrc.ca/ontologies/cwrc#credentialHeldBy</seealso>
    let credentialHeldBy = Prefixed_Name(cwrc, "credentialHeldBy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasCredentialIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has credential in</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialIn">http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialIn</seealso>
    let hasCredentialIn = Prefixed_Name(cwrc, "hasCredentialIn") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasCredentialSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has credential subject</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialSubject">http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialSubject</seealso>
    let hasCredentialSubject =
        Prefixed_Name(cwrc, "hasCredentialSubject") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:creoleEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Creole</para><para>Créole</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#creoleEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#creoleEthnicity</seealso>
    let creoleEthnicity = Prefixed_Name(cwrc, "creoleEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:creoleRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Créole</para><para>Creole</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#creoleRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#creoleRaceColour</seealso>
    let creoleRaceColour = Prefixed_Name(cwrc, "creoleRaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:criminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>criminal</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#criminal">http://sparql.cwrc.ca/ontologies/cwrc#criminal</seealso>
    let criminal = Prefixed_Name(cwrc, "criminal") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>writer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#writer">http://sparql.cwrc.ca/ontologies/cwrc#writer</seealso>
    let writer = Prefixed_Name(cwrc, "writer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:curator</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>curator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#curator">http://sparql.cwrc.ca/ontologies/cwrc#curator</seealso>
    let curator = Prefixed_Name(cwrc, "curator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:exhibitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>exhibitions</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#exhibitions">http://sparql.cwrc.ca/ontologies/cwrc#exhibitions</seealso>
    let exhibitions = Prefixed_Name(cwrc, "exhibitions") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d53c6644-df5c-43d7-86d3-2954c0d5a656</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d53c6644-df5c-43d7-86d3-2954c0d5a656">http://sparql.cwrc.ca/ontologies/cwrc#d53c6644-df5c-43d7-86d3-2954c0d5a656</seealso>
    let d53c6644_df5c_43d7_86d3_2954c0d5a656 =
        Prefixed_Name(cwrc, "d53c6644-df5c-43d7-86d3-2954c0d5a656") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176">http://sparql.cwrc.ca/ontologies/cwrc#d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176</seealso>
    let d53c6644_df5c_43d7_86d3_2954c0d5a656_cb4c10a176 =
        Prefixed_Name(cwrc, "d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:entrepreneurial-industrialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#entrepreneurial-industrialist" title="#entrepreneurial-industrialist"&gt;entrepreneurial&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#entrepreneurial-industrialist" title="#entrepreneurial-industrialist"&gt;entreprenariat&lt;/a&gt;.</para>
    /// labels<para>entrepreneurial industrialism</para><para>entrepreneuriat industriel</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#entrepreneurial-industrialism">http://sparql.cwrc.ca/ontologies/cwrc#entrepreneurial-industrialism</seealso>
    let entrepreneurial_industrialism =
        Prefixed_Name(cwrc, "entrepreneurial-industrialism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:entrepreneurial-industrialist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>entrepreneurial</para><para>entreprenariat</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#entrepreneurial-industrialist">http://sparql.cwrc.ca/ontologies/cwrc#entrepreneurial-industrialist</seealso>
    let entrepreneurial_industrialist =
        Prefixed_Name(cwrc, "entrepreneurial-industrialist") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ethnicityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ethnic identity of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicityOf">http://sparql.cwrc.ca/ontologies/cwrc#ethnicityOf</seealso>
    let ethnicityOf = Prefixed_Name(cwrc, "ethnicityOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ethnicityReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ethnic identity (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicityReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#ethnicityReportedOf</seealso>
    let ethnicityReportedOf = Prefixed_Name(cwrc, "ethnicityReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ethnicitySelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ethnic identity (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicitySelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#ethnicitySelfReportedOf</seealso>
    let ethnicitySelfReportedOf =
        Prefixed_Name(cwrc, "ethnicitySelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:eugenics</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Eugénisme</para><para>eugenics</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#eugenics">http://sparql.cwrc.ca/ontologies/cwrc#eugenics</seealso>
    let eugenics = Prefixed_Name(cwrc, "eugenics") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasBirthPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has birth position</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPosition">http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPosition</seealso>
    let hasBirthPosition = Prefixed_Name(cwrc, "hasBirthPosition") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasSibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has sibling</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSibling">http://sparql.cwrc.ca/ontologies/cwrc#hasSibling</seealso>
    let hasSibling = Prefixed_Name(cwrc, "hasSibling") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasChildren</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has children</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasChildren">http://sparql.cwrc.ca/ontologies/cwrc#hasChildren</seealso>
    let hasChildren = Prefixed_Name(cwrc, "hasChildren") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasReproductiveHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has reproductive history</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasReproductiveHistory">http://sparql.cwrc.ca/ontologies/cwrc#hasReproductiveHistory</seealso>
    let hasReproductiveHistory =
        Prefixed_Name(cwrc, "hasReproductiveHistory") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasCohabitant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>has cohabitant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCohabitant">http://sparql.cwrc.ca/ontologies/cwrc#hasCohabitant</seealso>
    let hasCohabitant = Prefixed_Name(cwrc, "hasCohabitant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasCompanion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a un·e camarade</para><para>has companion</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCompanion">http://sparql.cwrc.ca/ontologies/cwrc#hasCompanion</seealso>
    let hasCompanion = Prefixed_Name(cwrc, "hasCompanion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasCulturalForms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Deprecated in favour of object property &lt;a href="#hasCulturalForm" title="#hasCulturalForm"&gt;has a cultural form&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de la propriété &lt;a href="#hasCulturalForm" title="#hasCulturalForm"&gt;a une forme culturelle&lt;/a&gt;.</para>
    /// labels<para>a une forme culturelle</para><para>has a cultural form</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCulturalForms">http://sparql.cwrc.ca/ontologies/cwrc#hasCulturalForms</seealso>
    let hasCulturalForms = Prefixed_Name(cwrc, "hasCulturalForms") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une éducation</para><para>has education</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEducation">http://sparql.cwrc.ca/ontologies/cwrc#hasEducation</seealso>
    let hasEducation = Prefixed_Name(cwrc, "hasEducation") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasEmigrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has emigrant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmigrant">http://sparql.cwrc.ca/ontologies/cwrc#hasEmigrant</seealso>
    let hasEmigrant = Prefixed_Name(cwrc, "hasEmigrant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasInhabitant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has inhabitant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasInhabitant">http://sparql.cwrc.ca/ontologies/cwrc#hasInhabitant</seealso>
    let hasInhabitant = Prefixed_Name(cwrc, "hasInhabitant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has employee</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmployee">http://sparql.cwrc.ca/ontologies/cwrc#hasEmployee</seealso>
    let hasEmployee = Prefixed_Name(cwrc, "hasEmployee") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasEmployer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has employer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmployer">http://sparql.cwrc.ca/ontologies/cwrc#hasEmployer</seealso>
    let hasEmployer = Prefixed_Name(cwrc, "hasEmployer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has occupation</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasOccupation">http://sparql.cwrc.ca/ontologies/cwrc#hasOccupation</seealso>
    let hasOccupation = Prefixed_Name(cwrc, "hasOccupation") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasEroticRelationshipWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has erotic relationship with</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEroticRelationshipWith">http://sparql.cwrc.ca/ontologies/cwrc#hasEroticRelationshipWith</seealso>
    let hasEroticRelationshipWith =
        Prefixed_Name(cwrc, "hasEroticRelationshipWith") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasIntimateRelationshipWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has intimate relationship with</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasIntimateRelationshipWith">http://sparql.cwrc.ca/ontologies/cwrc#hasIntimateRelationshipWith</seealso>
    let hasIntimateRelationshipWith =
        Prefixed_Name(cwrc, "hasIntimateRelationshipWith") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ethnic identity</para><para>d'ethnicité</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicity</seealso>
    let hasEthnicity = Prefixed_Name(cwrc, "hasEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:indianUnification</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Indian unification</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indianUnification">http://sparql.cwrc.ca/ontologies/cwrc#indianUnification</seealso>
    let indianUnification = Prefixed_Name(cwrc, "indianUnification") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:indigenousPeoplesOfAmericasEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Indigenous (of the Americas)</para><para>Indigenous/Amérindiens</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indigenousPeoplesOfAmericasEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#indigenousPeoplesOfAmericasEthnicity</seealso>
    let indigenousPeoplesOfAmericasEthnicity =
        Prefixed_Name(cwrc, "indigenousPeoplesOfAmericasEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:indigenousPeoplesOfAmericasRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Indigenous (of the Americas)</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indigenousPeoplesOfAmericasRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#indigenousPeoplesOfAmericasRaceColour</seealso>
    let indigenousPeoplesOfAmericasRaceColour =
        Prefixed_Name(cwrc, "indigenousPeoplesOfAmericasRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:indigenousRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>droit des peuples autochtones</para><para>Indigenous rights movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indigenousRights">http://sparql.cwrc.ca/ontologies/cwrc#indigenousRights</seealso>
    let indigenousRights = Prefixed_Name(cwrc, "indigenousRights") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:individualism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Individualisme</para><para>individualism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#individualism">http://sparql.cwrc.ca/ontologies/cwrc#individualism</seealso>
    let individualism = Prefixed_Name(cwrc, "individualism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:inhabits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inhabited</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#inhabits">http://sparql.cwrc.ca/ontologies/cwrc#inhabits</seealso>
    let inhabits = Prefixed_Name(cwrc, "inhabits") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:insurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>insurance</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#insurance">http://sparql.cwrc.ca/ontologies/cwrc#insurance</seealso>
    let insurance = Prefixed_Name(cwrc, "insurance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:intellectual</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>public intellectual</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#intellectual">http://sparql.cwrc.ca/ontologies/cwrc#intellectual</seealso>
    let intellectual = Prefixed_Name(cwrc, "intellectual") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:intelligenceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>intelligence work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#intelligenceWork">http://sparql.cwrc.ca/ontologies/cwrc#intelligenceWork</seealso>
    let intelligenceWork = Prefixed_Name(cwrc, "intelligenceWork") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:interpersonalRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasInterpersonalRelationshipWith" title="#hasInterpersonalRelationshipWith"&gt;a relation interpersonnelle avec&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasInterpersonalRelationshipWith" title="#hasInterpersonalRelationshipWith"&gt;has interpersonal relationship with&lt;/a&gt;.</para>
    /// labels<para>interpersonal relationship</para><para>relation interpersonnelle</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#interpersonalRelationship">http://sparql.cwrc.ca/ontologies/cwrc#interpersonalRelationship</seealso>
    let interpersonalRelationship =
        Prefixed_Name(cwrc, "interpersonalRelationship") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:interviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>interviewer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#interviewer">http://sparql.cwrc.ca/ontologies/cwrc#interviewer</seealso>
    let interviewer = Prefixed_Name(cwrc, "interviewer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:inventor</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>inventor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#inventor">http://sparql.cwrc.ca/ontologies/cwrc#inventor</seealso>
    let inventor = Prefixed_Name(cwrc, "inventor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>manufacturer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#manufacturer">http://sparql.cwrc.ca/ontologies/cwrc#manufacturer</seealso>
    let manufacturer = Prefixed_Name(cwrc, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>mapping</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mapping">http://sparql.cwrc.ca/ontologies/cwrc#mapping</seealso>
    let mapping = Prefixed_Name(cwrc, "mapping") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:marriageLawReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>marriage law reform</para><para>réforme du mariage</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#marriageLawReform">http://sparql.cwrc.ca/ontologies/cwrc#marriageLawReform</seealso>
    let marriageLawReform = Prefixed_Name(cwrc, "marriageLawReform") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:martyr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>martyr</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#martyr">http://sparql.cwrc.ca/ontologies/cwrc#martyr</seealso>
    let martyr = Prefixed_Name(cwrc, "martyr") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mason</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>mason</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mason">http://sparql.cwrc.ca/ontologies/cwrc#mason</seealso>
    let mason = Prefixed_Name(cwrc, "mason") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:masterOfTheRevels</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>master or mistress of the revels</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#masterOfTheRevels">http://sparql.cwrc.ca/ontologies/cwrc#masterOfTheRevels</seealso>
    let masterOfTheRevels = Prefixed_Name(cwrc, "masterOfTheRevels") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mastersDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Master (diplôme ou grade universitaire)</para><para>master's degree</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mastersDegree">http://sparql.cwrc.ca/ontologies/cwrc#mastersDegree</seealso>
    let mastersDegree = Prefixed_Name(cwrc, "mastersDegree") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:skilledCraftpersonArtisan</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>artisane qualifiée</para><para>artisan</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#skilledCraftpersonArtisan">http://sparql.cwrc.ca/ontologies/cwrc#skilledCraftpersonArtisan</seealso>
    let skilledCraftpersonArtisan =
        Prefixed_Name(cwrc, "skilledCraftpersonArtisan") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:skinner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>skinner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#skinner">http://sparql.cwrc.ca/ontologies/cwrc#skinner</seealso>
    let skinner = Prefixed_Name(cwrc, "skinner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:slavEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Slave</para><para>Slav</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#slavEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#slavEthnicity</seealso>
    let slavEthnicity = Prefixed_Name(cwrc, "slavEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:slave</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>slave</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#slave">http://sparql.cwrc.ca/ontologies/cwrc#slave</seealso>
    let slave = Prefixed_Name(cwrc, "slave") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:slave-forced-labourer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>slave or forced labourer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#slave-forced-labourer">http://sparql.cwrc.ca/ontologies/cwrc#slave-forced-labourer</seealso>
    let slave_forced_labourer =
        Prefixed_Name(cwrc, "slave-forced-labourer") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:slaveOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>slave owner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#slaveOwner">http://sparql.cwrc.ca/ontologies/cwrc#slaveOwner</seealso>
    let slaveOwner = Prefixed_Name(cwrc, "slaveOwner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:slaver</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>slaver</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#slaver">http://sparql.cwrc.ca/ontologies/cwrc#slaver</seealso>
    let slaver = Prefixed_Name(cwrc, "slaver") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socialGospel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Évangile social</para><para>Social Gospel</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialGospel">http://sparql.cwrc.ca/ontologies/cwrc#socialGospel</seealso>
    let socialGospel = Prefixed_Name(cwrc, "socialGospel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socialScientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>social scientist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialScientist">http://sparql.cwrc.ca/ontologies/cwrc#socialScientist</seealso>
    let socialScientist = Prefixed_Name(cwrc, "socialScientist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socializer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>socializer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socializer">http://sparql.cwrc.ca/ontologies/cwrc#socializer</seealso>
    let socializer = Prefixed_Name(cwrc, "socializer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:societyOfFriends</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Société religieuse des Amis</para><para>Society of Friends</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#societyOfFriends">http://sparql.cwrc.ca/ontologies/cwrc#societyOfFriends</seealso>
    let societyOfFriends = Prefixed_Name(cwrc, "societyOfFriends") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socinianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>socinianisme</para><para>Socinianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socinianism">http://sparql.cwrc.ca/ontologies/cwrc#socinianism</seealso>
    let socinianism = Prefixed_Name(cwrc, "socinianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>son of</para><para>fil de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sonOf">http://sparql.cwrc.ca/ontologies/cwrc#sonOf</seealso>
    let sonOf = Prefixed_Name(cwrc, "sonOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:spanishRepublicanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>républicanisme Espagnol</para><para>Spanish republicanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#spanishRepublicanism">http://sparql.cwrc.ca/ontologies/cwrc#spanishRepublicanism</seealso>
    let spanishRepublicanism =
        Prefixed_Name(cwrc, "spanishRepublicanism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:stalinism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Stalinisme</para><para>Stalinism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stalinism">http://sparql.cwrc.ca/ontologies/cwrc#stalinism</seealso>
    let stalinism = Prefixed_Name(cwrc, "stalinism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:statelessNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>stateless</para><para>apatride</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#statelessNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#statelessNationalIdentity</seealso>
    let statelessNationalIdentity =
        Prefixed_Name(cwrc, "statelessNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:JadePenancier</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#JadePenancier">http://sparql.cwrc.ca/ontologies/cwrc#JadePenancier</seealso>
    let JadePenancier = Prefixed_Name(cwrc, "JadePenancier") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf">http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf</seealso>
    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58_9796ffdebf =
        Prefixed_Name(cwrc, "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9">http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9</seealso>
    let _23ad5d2a_605e_4116_8f81_7db6b95395ea_35ae67fab9 =
        Prefixed_Name(cwrc, "23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2">http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2</seealso>
    let _23ad5d2a_605e_4116_8f81_7db6b95395ea_86b08955b2 =
        Prefixed_Name(cwrc, "23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:BookSection</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6">http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6</seealso>
    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6 =
        Prefixed_Name(cwrc, "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373">http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373</seealso>
    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_7e070c5373 =
        Prefixed_Name(cwrc, "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef">http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef</seealso>
    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_327d5213ef =
        Prefixed_Name(cwrc, "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:indianRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Indian</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indianRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#indianRaceColour</seealso>
    let indianRaceColour = Prefixed_Name(cwrc, "indianRaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cwrc</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cwrc">http://sparql.cwrc.ca/ontologies/cwrc#cwrc</seealso>
    let cwrc_ = Prefixed_Name(cwrc, "cwrc") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cartesianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Cartésianisme</para><para>Cartesianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cartesianism">http://sparql.cwrc.ca/ontologies/cwrc#cartesianism</seealso>
    let cartesianism = Prefixed_Name(cwrc, "cartesianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:catering</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>catering</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#catering">http://sparql.cwrc.ca/ontologies/cwrc#catering</seealso>
    let catering = Prefixed_Name(cwrc, "catering") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:db3de175-7d4a-4860-908b-a905b9cc9b07</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07">http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07</seealso>
    let db3de175_7d4a_4860_908b_a905b9cc9b07 =
        Prefixed_Name(cwrc, "db3de175-7d4a-4860-908b-a905b9cc9b07") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76">http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76</seealso>
    let db3de175_7d4a_4860_908b_a905b9cc9b07_84fe24be76 =
        Prefixed_Name(cwrc, "db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:deathPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>death place of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#deathPlaceOf">http://sparql.cwrc.ca/ontologies/cwrc#deathPlaceOf</seealso>
    let deathPlaceOf = Prefixed_Name(cwrc, "deathPlaceOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasDeathPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has death place</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasDeathPlace">http://sparql.cwrc.ca/ontologies/cwrc#hasDeathPlace</seealso>
    let hasDeathPlace = Prefixed_Name(cwrc, "hasDeathPlace") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:decoder</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>decoder</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#decoder">http://sparql.cwrc.ca/ontologies/cwrc#decoder</seealso>
    let decoder = Prefixed_Name(cwrc, "decoder") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dentist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>dentist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dentist">http://sparql.cwrc.ca/ontologies/cwrc#dentist</seealso>
    let dentist = Prefixed_Name(cwrc, "dentist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:factoryWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>factory worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#factoryWorker">http://sparql.cwrc.ca/ontologies/cwrc#factoryWorker</seealso>
    let factoryWorker = Prefixed_Name(cwrc, "factoryWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasGenderReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has gender identity (reported)</para><para>est de genre (déclaré)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderReported">http://sparql.cwrc.ca/ontologies/cwrc#hasGenderReported</seealso>
    let hasGenderReported = Prefixed_Name(cwrc, "hasGenderReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGenderSelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasGenderSelfReported" title="#hasGenderSelfReported"&gt;est de genre (autodéclaré)&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasGenderSelfReported" title="#hasGenderSelfReported"&gt;has gender identity (self-reported)&lt;/a&gt;.</para>
    /// labels<para>est de genre (autodéclaré)</para><para>has gender (self declared)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderSelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#hasGenderSelfDeclared</seealso>
    let hasGenderSelfDeclared =
        Prefixed_Name(cwrc, "hasGenderSelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:manualLabourer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>manual labourer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#manualLabourer">http://sparql.cwrc.ca/ontologies/cwrc#manualLabourer</seealso>
    let manualLabourer = Prefixed_Name(cwrc, "manualLabourer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:personaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>persona of</para><para>persona de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#personaOf">http://sparql.cwrc.ca/ontologies/cwrc#personaOf</seealso>
    let personaOf = Prefixed_Name(cwrc, "personaOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socialPurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>abolition de la prostitution (Royaume-Uni)</para><para>social purity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialPurity">http://sparql.cwrc.ca/ontologies/cwrc#socialPurity</seealso>
    let socialPurity = Prefixed_Name(cwrc, "socialPurity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sexualityFrigidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Sexuality</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>frigidité</para><para>frigidity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityFrigidity">http://sparql.cwrc.ca/ontologies/cwrc#sexualityFrigidity</seealso>
    let sexualityFrigidity = Prefixed_Name(cwrc, "sexualityFrigidity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexualityPromiscuity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Sexuality</para>
    ///
    /// labels<para>promiscuity</para><para>promiscuité</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityPromiscuity">http://sparql.cwrc.ca/ontologies/cwrc#sexualityPromiscuity</seealso>
    let sexualityPromiscuity =
        Prefixed_Name(cwrc, "sexualityPromiscuity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:shinto</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Shintoïsme</para><para>Shinto</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#shinto">http://sparql.cwrc.ca/ontologies/cwrc#shinto</seealso>
    let shinto = Prefixed_Name(cwrc, "shinto") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:shopkeepers</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>shopkeepers</para><para>commerçants</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#shopkeepers">http://sparql.cwrc.ca/ontologies/cwrc#shopkeepers</seealso>
    let shopkeepers = Prefixed_Name(cwrc, "shopkeepers") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:singer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>singer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#singer">http://sparql.cwrc.ca/ontologies/cwrc#singer</seealso>
    let singer = Prefixed_Name(cwrc, "singer") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:06e019b1-2bad-4fc2-8666-6f374a2e246a-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a-partof">http://sparql.cwrc.ca/ontologies/cwrc#06e019b1-2bad-4fc2-8666-6f374a2e246a-partof</seealso>
    let _06e019b1_2bad_4fc2_8666_6f374a2e246a_partof =
        Prefixed_Name(cwrc, "06e019b1-2bad-4fc2-8666-6f374a2e246a-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:713873c7-011a-4b34-b5dc-d6d147575119</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Webpage</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119">http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119</seealso>
    let _713873c7_011a_4b34_b5dc_d6d147575119 =
        Prefixed_Name(cwrc, "713873c7-011a-4b34-b5dc-d6d147575119") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7">http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7</seealso>
    let _713873c7_011a_4b34_b5dc_d6d147575119_37765af5b7 =
        Prefixed_Name(cwrc, "713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c">http://sparql.cwrc.ca/ontologies/cwrc#727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c</seealso>
    let _727d97bc_af78_4122_94be_aa78b2e97d5a_17b91d1c8c =
        Prefixed_Name(cwrc, "727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:734cd035-459b-407e-8a08-b68cd2bb743a</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#734cd035-459b-407e-8a08-b68cd2bb743a">http://sparql.cwrc.ca/ontologies/cwrc#734cd035-459b-407e-8a08-b68cd2bb743a</seealso>
    let _734cd035_459b_407e_8a08_b68cd2bb743a =
        Prefixed_Name(cwrc, "734cd035-459b-407e-8a08-b68cd2bb743a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5">http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5</seealso>
    let _75660bb0_b804_428e_8efb_c139bc7a63d6_9341b4f3e5 =
        Prefixed_Name(cwrc, "75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b">http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b</seealso>
    let _75660bb0_b804_428e_8efb_c139bc7a63d6_8471bb905b =
        Prefixed_Name(cwrc, "75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf">http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf</seealso>
    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_cf7aa6a7bf =
        Prefixed_Name(cwrc, "772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db">http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db</seealso>
    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_9f43ebd6db =
        Prefixed_Name(cwrc, "772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:airman</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>airman</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#airman">http://sparql.cwrc.ca/ontologies/cwrc#airman</seealso>
    let airman = Prefixed_Name(cwrc, "airman") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pilot</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>pilot</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pilot">http://sparql.cwrc.ca/ontologies/cwrc#pilot</seealso>
    let pilot = Prefixed_Name(cwrc, "pilot") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ambulanceWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ambulance worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ambulanceWorker">http://sparql.cwrc.ca/ontologies/cwrc#ambulanceWorker</seealso>
    let ambulanceWorker = Prefixed_Name(cwrc, "ambulanceWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:beautician</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>beautician</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#beautician">http://sparql.cwrc.ca/ontologies/cwrc#beautician</seealso>
    let beautician = Prefixed_Name(cwrc, "beautician") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cooper</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>cooper</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cooper">http://sparql.cwrc.ca/ontologies/cwrc#cooper</seealso>
    let cooper = Prefixed_Name(cwrc, "cooper") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:copyist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>copyist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#copyist">http://sparql.cwrc.ca/ontologies/cwrc#copyist</seealso>
    let copyist = Prefixed_Name(cwrc, "copyist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasGrandChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has grandchild</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandChild">http://sparql.cwrc.ca/ontologies/cwrc#hasGrandChild</seealso>
    let hasGrandChild = Prefixed_Name(cwrc, "hasGrandChild") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:grandDaughterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>granddaughter of</para><para>petite fille de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#grandDaughterOf">http://sparql.cwrc.ca/ontologies/cwrc#grandDaughterOf</seealso>
    let grandDaughterOf = Prefixed_Name(cwrc, "grandDaughterOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hermeticism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Hermeticism</para><para>Hermétisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hermeticism">http://sparql.cwrc.ca/ontologies/cwrc#hermeticism</seealso>
    let hermeticism = Prefixed_Name(cwrc, "hermeticism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lesbian</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Sexuality</para>
    ///
    /// labels<para>lesbianisme</para><para>lesbianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lesbian">http://sparql.cwrc.ca/ontologies/cwrc#lesbian</seealso>
    let lesbian = Prefixed_Name(cwrc, "lesbian") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lesbianFeminism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>lesbian feminism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lesbianFeminism">http://sparql.cwrc.ca/ontologies/cwrc#lesbianFeminism</seealso>
    let lesbianFeminism = Prefixed_Name(cwrc, "lesbianFeminism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:liaisonOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>liaison officer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#liaisonOfficer">http://sparql.cwrc.ca/ontologies/cwrc#liaisonOfficer</seealso>
    let liaisonOfficer = Prefixed_Name(cwrc, "liaisonOfficer") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:liberalUnionistParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Parti libéral unioniste</para><para>Liberal Unionist Party</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#liberalUnionistParty">http://sparql.cwrc.ca/ontologies/cwrc#liberalUnionistParty</seealso>
    let liberalUnionistParty =
        Prefixed_Name(cwrc, "liberalUnionistParty") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>nobility</para><para>noblesse</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nobility">http://sparql.cwrc.ca/ontologies/cwrc#nobility</seealso>
    let nobility = Prefixed_Name(cwrc, "nobility") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:wesleyanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Wesleyanisme</para><para>Wesleyanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#wesleyanism">http://sparql.cwrc.ca/ontologies/cwrc#wesleyanism</seealso>
    let wesleyanism = Prefixed_Name(cwrc, "wesleyanism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:04b840aa-9c38-4e36-8d7c-21b38e192646</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646">http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646</seealso>
    let _04b840aa_9c38_4e36_8d7c_21b38e192646 =
        Prefixed_Name(cwrc, "04b840aa-9c38-4e36-8d7c-21b38e192646") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:62208dcb-ed1f-4612-8433-d6e4e5e0b7fc</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc">http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc</seealso>
    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc =
        Prefixed_Name(cwrc, "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aec674cf-2108-4977-be3a-9317efe35aa9-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9-partof">http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9-partof</seealso>
    let aec674cf_2108_4977_be3a_9317efe35aa9_partof =
        Prefixed_Name(cwrc, "aec674cf-2108-4977-be3a-9317efe35aa9-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>sex worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexWorker">http://sparql.cwrc.ca/ontologies/cwrc#sexWorker</seealso>
    let sexWorker = Prefixed_Name(cwrc, "sexWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mixedRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mixed-race</para><para>métis</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mixedRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#mixedRaceColour</seealso>
    let mixedRaceColour = Prefixed_Name(cwrc, "mixedRaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:whiteLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:TextLabels</para>
    ///
    /// labels<para>identité blanche</para><para>white identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#whiteLabel">http://sparql.cwrc.ca/ontologies/cwrc#whiteLabel</seealso>
    let whiteLabel = Prefixed_Name(cwrc, "whiteLabel") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2">http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2</seealso>
    let _04b840aa_9c38_4e36_8d7c_21b38e192646_5d410f84e2 =
        Prefixed_Name(cwrc, "04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof">http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof</seealso>
    let _59f48ef6_ebc7_4a58_ac43_2025deb369ec_partof =
        Prefixed_Name(cwrc, "59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249">http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249</seealso>
    let _5e45242f_0c2e_4aaa_8ddb_ac54dd0e6249 =
        Prefixed_Name(cwrc, "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3">http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3</seealso>
    let _5e45242f_0c2e_4aaa_8ddb_ac54dd0e6249_43b2d638e3 =
        Prefixed_Name(cwrc, "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4">http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4</seealso>
    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_706552b3f4 =
        Prefixed_Name(cwrc, "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c">http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c</seealso>
    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_352a867f1c =
        Prefixed_Name(cwrc, "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9</seealso>
    let _65424c4e_5257_4e6c_962f_de12a7f11aea_partof_215ee9c7d9 =
        Prefixed_Name(cwrc, "65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:6addf580-24e2-4750-9d2a-aa6dd66032a6</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6">http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6</seealso>
    let _6addf580_24e2_4750_9d2a_aa6dd66032a6 =
        Prefixed_Name(cwrc, "6addf580-24e2-4750-9d2a-aa6dd66032a6") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9</seealso>
    let _6addf580_24e2_4750_9d2a_aa6dd66032a6_215ee9c7d9 =
        Prefixed_Name(cwrc, "6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:6addf580-24e2-4750-9d2a-aa6dd66032a6-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6-partof">http://sparql.cwrc.ca/ontologies/cwrc#6addf580-24e2-4750-9d2a-aa6dd66032a6-partof</seealso>
    let _6addf580_24e2_4750_9d2a_aa6dd66032a6_partof =
        Prefixed_Name(cwrc, "6addf580-24e2-4750-9d2a-aa6dd66032a6-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:713873c7-011a-4b34-b5dc-d6d147575119-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119-partof">http://sparql.cwrc.ca/ontologies/cwrc#713873c7-011a-4b34-b5dc-d6d147575119-partof</seealso>
    let _713873c7_011a_4b34_b5dc_d6d147575119_partof =
        Prefixed_Name(cwrc, "713873c7-011a-4b34-b5dc-d6d147575119-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:72ce1f91-b3d5-4b7b-8b76-dc674513bec1</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1">http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1</seealso>
    let _72ce1f91_b3d5_4b7b_8b76_dc674513bec1 =
        Prefixed_Name(cwrc, "72ce1f91-b3d5-4b7b-8b76-dc674513bec1") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e">http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e</seealso>
    let _72ce1f91_b3d5_4b7b_8b76_dc674513bec1_4c365f6a6e =
        Prefixed_Name(cwrc, "72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826">http://sparql.cwrc.ca/ontologies/cwrc#72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826</seealso>
    let _72ce1f91_b3d5_4b7b_8b76_dc674513bec1_f1c3424826 =
        Prefixed_Name(cwrc, "72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:75660bb0-b804-428e-8efb-c139bc7a63d6</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6">http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6</seealso>
    let _75660bb0_b804_428e_8efb_c139bc7a63d6 =
        Prefixed_Name(cwrc, "75660bb0-b804-428e-8efb-c139bc7a63d6") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:772b1b45-8046-46b0-a746-bbdc8849a6c8</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8">http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8</seealso>
    let _772b1b45_8046_46b0_a746_bbdc8849a6c8 =
        Prefixed_Name(cwrc, "772b1b45-8046-46b0-a746-bbdc8849a6c8") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:772b1b45-8046-46b0-a746-bbdc8849a6c8-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-partof">http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-partof</seealso>
    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_partof =
        Prefixed_Name(cwrc, "772b1b45-8046-46b0-a746-bbdc8849a6c8-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:775357d1-e547-4674-9467-50b0308354ca-706552b3f4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-706552b3f4">http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-706552b3f4</seealso>
    let _775357d1_e547_4674_9467_50b0308354ca_706552b3f4 =
        Prefixed_Name(cwrc, "775357d1-e547-4674-9467-50b0308354ca-706552b3f4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf">http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf</seealso>
    let _775357d1_e547_4674_9467_50b0308354ca_cf7aa6a7bf =
        Prefixed_Name(cwrc, "775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:775357d1-e547-4674-9467-50b0308354ca-ab964c6950</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-ab964c6950">http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-ab964c6950</seealso>
    let _775357d1_e547_4674_9467_50b0308354ca_ab964c6950 =
        Prefixed_Name(cwrc, "775357d1-e547-4674-9467-50b0308354ca-ab964c6950") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:775357d1-e547-4674-9467-50b0308354ca-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-partof">http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-partof</seealso>
    let _775357d1_e547_4674_9467_50b0308354ca_partof =
        Prefixed_Name(cwrc, "775357d1-e547-4674-9467-50b0308354ca-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7b624412-74a3-4560-a038-d59b747ee9c7</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7b624412-74a3-4560-a038-d59b747ee9c7">http://sparql.cwrc.ca/ontologies/cwrc#7b624412-74a3-4560-a038-d59b747ee9c7</seealso>
    let _7b624412_74a3_4560_a038_d59b747ee9c7 =
        Prefixed_Name(cwrc, "7b624412-74a3-4560-a038-d59b747ee9c7") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7c123714-5956-4ce5-bf15-39f3f7c5deed</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7c123714-5956-4ce5-bf15-39f3f7c5deed">http://sparql.cwrc.ca/ontologies/cwrc#7c123714-5956-4ce5-bf15-39f3f7c5deed</seealso>
    let _7c123714_5956_4ce5_bf15_39f3f7c5deed =
        Prefixed_Name(cwrc, "7c123714-5956-4ce5-bf15-39f3f7c5deed") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7d891586-52df-49f4-9cef-77e26f1a0ed6</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6">http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6</seealso>
    let _7d891586_52df_49f4_9cef_77e26f1a0ed6 =
        Prefixed_Name(cwrc, "7d891586-52df-49f4-9cef-77e26f1a0ed6") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a">http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a</seealso>
    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_ff77f5d24a =
        Prefixed_Name(cwrc, "7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227">http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227</seealso>
    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_3cddc7f227 =
        Prefixed_Name(cwrc, "7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7d891586-52df-49f4-9cef-77e26f1a0ed6-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Proceedings</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-partof">http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-partof</seealso>
    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_partof =
        Prefixed_Name(cwrc, "7d891586-52df-49f4-9cef-77e26f1a0ed6-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7faf2c87-1064-43d7-81b9-90f16068587e</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e">http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e</seealso>
    let _7faf2c87_1064_43d7_81b9_90f16068587e =
        Prefixed_Name(cwrc, "7faf2c87-1064-43d7-81b9-90f16068587e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e">http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e</seealso>
    let _7faf2c87_1064_43d7_81b9_90f16068587e_7c9776f33e =
        Prefixed_Name(cwrc, "7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd">http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd</seealso>
    let _7faf2c87_1064_43d7_81b9_90f16068587e_06e80bcecd =
        Prefixed_Name(cwrc, "7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd">http://sparql.cwrc.ca/ontologies/cwrc#7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd</seealso>
    let _7faf2c87_1064_43d7_81b9_90f16068587e_ad9e6833cd =
        Prefixed_Name(cwrc, "7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Nickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>nickname</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Nickname">http://sparql.cwrc.ca/ontologies/cwrc#Nickname</seealso>
    let Nickname = Prefixed_Name(cwrc, "Nickname") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:feminism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Féminisme</para><para>feminism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#feminism">http://sparql.cwrc.ca/ontologies/cwrc#feminism</seealso>
    let feminism = Prefixed_Name(cwrc, "feminism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-American</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-American politics</para><para>anti-américanisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-American">http://sparql.cwrc.ca/ontologies/cwrc#anti-American</seealso>
    let anti_American = Prefixed_Name(cwrc, "anti-American") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pro-American</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>pro-américain</para><para>pro-American</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pro-American">http://sparql.cwrc.ca/ontologies/cwrc#pro-American</seealso>
    let pro_American = Prefixed_Name(cwrc, "pro-American") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Apartheid</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-apartheid</para><para>anti-apartheid</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Apartheid">http://sparql.cwrc.ca/ontologies/cwrc#anti-Apartheid</seealso>
    let anti_Apartheid = Prefixed_Name(cwrc, "anti-Apartheid") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Boer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-Boer politics</para><para>anti-boer</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Boer">http://sparql.cwrc.ca/ontologies/cwrc#anti-Boer</seealso>
    let anti_Boer = Prefixed_Name(cwrc, "anti-Boer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Bonapartism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-bonapartisme</para><para>anti-Bonapartism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Bonapartism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Bonapartism</seealso>
    let anti_Bonapartism = Prefixed_Name(cwrc, "anti-Bonapartism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bonapartism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Bonapartisme</para><para>Bonapartism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bonapartism">http://sparql.cwrc.ca/ontologies/cwrc#bonapartism</seealso>
    let bonapartism = Prefixed_Name(cwrc, "bonapartism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-British</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-British politics</para><para>anglophobie</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-British">http://sparql.cwrc.ca/ontologies/cwrc#anti-British</seealso>
    let anti_British = Prefixed_Name(cwrc, "anti-British") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-CapitalPunishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-capital punishment</para><para>Peine de mort</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-CapitalPunishment">http://sparql.cwrc.ca/ontologies/cwrc#anti-CapitalPunishment</seealso>
    let anti_CapitalPunishment =
        Prefixed_Name(cwrc, "anti-CapitalPunishment") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:communism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>communisme</para><para>communism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#communism">http://sparql.cwrc.ca/ontologies/cwrc#communism</seealso>
    let communism = Prefixed_Name(cwrc, "communism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Caste</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement contre le système de castes</para><para>anti-caste movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Caste">http://sparql.cwrc.ca/ontologies/cwrc#anti-Caste</seealso>
    let anti_Caste = Prefixed_Name(cwrc, "anti-Caste") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Catholicism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>anti-catholicism</para><para>Anticatholicisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Catholicism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Catholicism</seealso>
    let anti_Catholicism = Prefixed_Name(cwrc, "anti-Catholicism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pro-Catholicism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>procatholicisme</para><para>pro-Catholicism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pro-Catholicism">http://sparql.cwrc.ca/ontologies/cwrc#pro-Catholicism</seealso>
    let pro_Catholicism = Prefixed_Name(cwrc, "pro-Catholicism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Censorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-censorship movement</para><para>lutte contre la censure</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Censorship">http://sparql.cwrc.ca/ontologies/cwrc#anti-Censorship</seealso>
    let anti_Censorship = Prefixed_Name(cwrc, "anti-Censorship") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-Conscriptionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>lutte contre la conscription militaire</para><para>anti-conscriptionism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Conscriptionism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Conscriptionism</seealso>
    let anti_Conscriptionism =
        Prefixed_Name(cwrc, "anti-Conscriptionism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-ContagiousDiseasesAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-Contagious Diseases Acte</para><para>anti-Contagious Diseases Act</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-ContagiousDiseasesAct">http://sparql.cwrc.ca/ontologies/cwrc#anti-ContagiousDiseasesAct</seealso>
    let anti_ContagiousDiseasesAct =
        Prefixed_Name(cwrc, "anti-ContagiousDiseasesAct") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-CorporalPunishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>lutte contre les châtiments corporels</para><para>anti-corporal punishment</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-CorporalPunishment">http://sparql.cwrc.ca/ontologies/cwrc#anti-CorporalPunishment</seealso>
    let anti_CorporalPunishment =
        Prefixed_Name(cwrc, "anti-CorporalPunishment") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-Dreyfusard</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-Dreyfusard</para><para>antidreyfusard</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Dreyfusard">http://sparql.cwrc.ca/ontologies/cwrc#anti-Dreyfusard</seealso>
    let anti_Dreyfusard = Prefixed_Name(cwrc, "anti-Dreyfusard") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dreyfusard</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Dreyfusard</para><para>Dreyfusard</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dreyfusard">http://sparql.cwrc.ca/ontologies/cwrc#dreyfusard</seealso>
    let dreyfusard = Prefixed_Name(cwrc, "dreyfusard") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-European</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-European politics</para><para>Euroscepticisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-European">http://sparql.cwrc.ca/ontologies/cwrc#anti-European</seealso>
    let anti_European = Prefixed_Name(cwrc, "anti-European") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pro-European</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>pro-European</para><para>europhile</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pro-European">http://sparql.cwrc.ca/ontologies/cwrc#pro-European</seealso>
    let pro_European = Prefixed_Name(cwrc, "pro-European") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fascism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Fascisme</para><para>fascism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fascism">http://sparql.cwrc.ca/ontologies/cwrc#fascism</seealso>
    let fascism = Prefixed_Name(cwrc, "fascism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Feminism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-feminism</para><para>Antiféminisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Feminism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Feminism</seealso>
    let anti_Feminism = Prefixed_Name(cwrc, "anti-Feminism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:suffrage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>suffrage movement</para><para>Droit de vote</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#suffrage">http://sparql.cwrc.ca/ontologies/cwrc#suffrage</seealso>
    let suffrage = Prefixed_Name(cwrc, "suffrage") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Imperialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Anti-impérialisme</para><para>Anti-imperialism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Imperialism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Imperialism</seealso>
    let anti_Imperialism = Prefixed_Name(cwrc, "anti-Imperialism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:imperialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Impérialisme</para><para>imperialism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#imperialism">http://sparql.cwrc.ca/ontologies/cwrc#imperialism</seealso>
    let imperialism = Prefixed_Name(cwrc, "imperialism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Jacobite</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-Jacobite</para><para>anti-Jacobite</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Jacobite">http://sparql.cwrc.ca/ontologies/cwrc#anti-Jacobite</seealso>
    let anti_Jacobite = Prefixed_Name(cwrc, "anti-Jacobite") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jacobitism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Jacobitisme</para><para>Jacobitism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jacobitism">http://sparql.cwrc.ca/ontologies/cwrc#jacobitism</seealso>
    let jacobitism = Prefixed_Name(cwrc, "jacobitism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-LandLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Anti-Irish National Land League</para><para>Anti-Irish National Land League</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-LandLeague">http://sparql.cwrc.ca/ontologies/cwrc#anti-LandLeague</seealso>
    let anti_LandLeague = Prefixed_Name(cwrc, "anti-LandLeague") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:irishUnionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Unionisme en Irlande</para><para>Irish unionism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#irishUnionism">http://sparql.cwrc.ca/ontologies/cwrc#irishUnionism</seealso>
    let irishUnionism = Prefixed_Name(cwrc, "irishUnionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:monarchism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Monarchisme</para><para>monarchism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#monarchism">http://sparql.cwrc.ca/ontologies/cwrc#monarchism</seealso>
    let monarchism = Prefixed_Name(cwrc, "monarchism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-NuclearMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement antinucléaire</para><para>anti-nuclear movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-NuclearMovement">http://sparql.cwrc.ca/ontologies/cwrc#anti-NuclearMovement</seealso>
    let anti_NuclearMovement =
        Prefixed_Name(cwrc, "anti-NuclearMovement") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:environmentalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>environmentalism</para><para>Écologisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#environmentalism">http://sparql.cwrc.ca/ontologies/cwrc#environmentalism</seealso>
    let environmentalism = Prefixed_Name(cwrc, "environmentalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Pacifism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-pacifism</para><para>antipacifisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Pacifism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Pacifism</seealso>
    let anti_Pacifism = Prefixed_Name(cwrc, "anti-Pacifism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pacifism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Pacifisme</para><para>pacifism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pacifism">http://sparql.cwrc.ca/ontologies/cwrc#pacifism</seealso>
    let pacifism = Prefixed_Name(cwrc, "pacifism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Racism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>anti-racism</para><para>antiracisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Racism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Racism</seealso>
    let anti_Racism = Prefixed_Name(cwrc, "anti-Racism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:racism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Racisme</para><para>racism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#racism">http://sparql.cwrc.ca/ontologies/cwrc#racism</seealso>
    let racism = Prefixed_Name(cwrc, "racism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:blackAnti-Oppression</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement contre l'oppression des Noirs</para><para>black anti-oppression movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#blackAnti-Oppression">http://sparql.cwrc.ca/ontologies/cwrc#blackAnti-Oppression</seealso>
    let blackAnti_Oppression =
        Prefixed_Name(cwrc, "blackAnti-Oppression") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-Socialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Critiques du socialisme</para><para>anti-socialism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Socialism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Socialism</seealso>
    let anti_Socialism = Prefixed_Name(cwrc, "anti-Socialism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>socialisme</para><para>socialism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialism">http://sparql.cwrc.ca/ontologies/cwrc#socialism</seealso>
    let socialism = Prefixed_Name(cwrc, "socialism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Suffrage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>opposition au suffrage universel</para><para>anti-suffrage</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Suffrage">http://sparql.cwrc.ca/ontologies/cwrc#anti-Suffrage</seealso>
    let anti_Suffrage = Prefixed_Name(cwrc, "anti-Suffrage") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Urbanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-urbanism</para><para>antiurbain</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Urbanism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Urbanism</seealso>
    let anti_Urbanism = Prefixed_Name(cwrc, "anti-Urbanism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Vaccination</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement contre la vaccination</para><para>anti-vaccination movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Vaccination">http://sparql.cwrc.ca/ontologies/cwrc#anti-Vaccination</seealso>
    let anti_Vaccination = Prefixed_Name(cwrc, "anti-Vaccination") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Vivisection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-vivisection</para><para>antivivisection</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Vivisection">http://sparql.cwrc.ca/ontologies/cwrc#anti-Vivisection</seealso>
    let anti_Vivisection = Prefixed_Name(cwrc, "anti-Vivisection") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:tailor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>tailor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#tailor">http://sparql.cwrc.ca/ontologies/cwrc#tailor</seealso>
    let tailor = Prefixed_Name(cwrc, "tailor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:drinking</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>drinking</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#drinking">http://sparql.cwrc.ca/ontologies/cwrc#drinking</seealso>
    let drinking = Prefixed_Name(cwrc, "drinking") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:drugUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>drug abuse</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#drugUse">http://sparql.cwrc.ca/ontologies/cwrc#drugUse</seealso>
    let drugUse = Prefixed_Name(cwrc, "drugUse") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:dutchNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Néerlandais</para><para>Dutch</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dutchNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#dutchNationalHeritage</seealso>
    let dutchNationalHeritage =
        Prefixed_Name(cwrc, "dutchNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e053e9f1-37ea-407d-b0cd-caaf413c142e</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e">http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e</seealso>
    let e053e9f1_37ea_407d_b0cd_caaf413c142e =
        Prefixed_Name(cwrc, "e053e9f1-37ea-407d-b0cd-caaf413c142e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9</seealso>
    let e1f710d3_6ebd_4181_be61_bf931282a8b7_215ee9c7d9 =
        Prefixed_Name(cwrc, "e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e">http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e</seealso>
    let e1f710d3_6ebd_4181_be61_bf931282a8b7_47d7a4164e =
        Prefixed_Name(cwrc, "e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e2c7e804-1fa1-4575-b2a1-bf284412e036</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036">http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036</seealso>
    let e2c7e804_1fa1_4575_b2a1_bf284412e036 =
        Prefixed_Name(cwrc, "e2c7e804-1fa1-4575-b2a1-bf284412e036") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526">http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526</seealso>
    let e2c7e804_1fa1_4575_b2a1_bf284412e036_d0d3bac526 =
        Prefixed_Name(cwrc, "e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816">http://sparql.cwrc.ca/ontologies/cwrc#e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816</seealso>
    let e2c7e804_1fa1_4575_b2a1_bf284412e036_a1a376d816 =
        Prefixed_Name(cwrc, "e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ea282bf0-da27-4ecc-98bd-e1aff595fc07</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07">http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07</seealso>
    let ea282bf0_da27_4ecc_98bd_e1aff595fc07 =
        Prefixed_Name(cwrc, "ea282bf0-da27-4ecc-98bd-e1aff595fc07") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a">http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a</seealso>
    let ea282bf0_da27_4ecc_98bd_e1aff595fc07_a73943684a =
        Prefixed_Name(cwrc, "ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d">http://sparql.cwrc.ca/ontologies/cwrc#ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d</seealso>
    let ea282bf0_da27_4ecc_98bd_e1aff595fc07_a70e175b3d =
        Prefixed_Name(cwrc, "ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:easternReligions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>eastern religions</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#easternReligions">http://sparql.cwrc.ca/ontologies/cwrc#easternReligions</seealso>
    let easternReligions = Prefixed_Name(cwrc, "easternReligions") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbb5e23-2c34-4810-b921-1d72694af314</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314">http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314</seealso>
    let ebbb5e23_2c34_4810_b921_1d72694af314 =
        Prefixed_Name(cwrc, "ebbb5e23-2c34-4810-b921-1d72694af314") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b">http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b</seealso>
    let ebbb5e23_2c34_4810_b921_1d72694af314_fb3b58e90b =
        Prefixed_Name(cwrc, "ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799">http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799</seealso>
    let ebbb5e23_2c34_4810_b921_1d72694af314_d5a62f9799 =
        Prefixed_Name(cwrc, "ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077">http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077</seealso>
    let ebbb5e23_2c34_4810_b921_1d72694af314_225e6db077 =
        Prefixed_Name(cwrc, "ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbb5e23-2c34-4810-b921-1d72694af314-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-partof">http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-partof</seealso>
    let ebbb5e23_2c34_4810_b921_1d72694af314_partof =
        Prefixed_Name(cwrc, "ebbb5e23-2c34-4810-b921-1d72694af314-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:florentineNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalIdentity</para>
    ///
    /// labels<para>Florentine</para><para>Florentin</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#florentineNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#florentineNationalIdentity</seealso>
    let florentineNationalIdentity =
        Prefixed_Name(cwrc, "florentineNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:foodDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>food distribution</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#foodDistribution">http://sparql.cwrc.ca/ontologies/cwrc#foodDistribution</seealso>
    let foodDistribution = Prefixed_Name(cwrc, "foodDistribution") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:merchant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>merchant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#merchant">http://sparql.cwrc.ca/ontologies/cwrc#merchant</seealso>
    let merchant = Prefixed_Name(cwrc, "merchant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:forebearOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Deprecated, with no current equivalence.</para>
    ///   <para>Désapprouver sans équivalence.</para>
    /// labels<para>forebear of</para><para>ancêtre de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#forebearOf">http://sparql.cwrc.ca/ontologies/cwrc#forebearOf</seealso>
    let forebearOf = Prefixed_Name(cwrc, "forebearOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fosterParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>foster-parent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fosterParent">http://sparql.cwrc.ca/ontologies/cwrc#fosterParent</seealso>
    let fosterParent = Prefixed_Name(cwrc, "fosterParent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:founder</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>founder</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#founder">http://sparql.cwrc.ca/ontologies/cwrc#founder</seealso>
    let founder = Prefixed_Name(cwrc, "founder") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:jewishGeographicHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:GeographicHeritage</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Jewish</para><para>Juif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishGeographicHeritage">http://sparql.cwrc.ca/ontologies/cwrc#jewishGeographicHeritage</seealso>
    let jewishGeographicHeritage =
        Prefixed_Name(cwrc, "jewishGeographicHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:jewishRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Jewish</para><para>Juif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#jewishRaceColour</seealso>
    let jewishRaceColour = Prefixed_Name(cwrc, "jewishRaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:judaism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    /// labels<para>yu t'ai chiao</para><para>you tai jiao</para><para>yóu tài jiāo</para><para>Judaísmo</para><para>Judaïsme</para><para>Jodendom</para><para>Judaism</para><para>Joods</para><para>猶太教</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#judaism">http://sparql.cwrc.ca/ontologies/cwrc#judaism</seealso>
    let judaism = Prefixed_Name(cwrc, "judaism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:jewishNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalIdentity</para>
    ///
    /// labels<para>Jewish</para><para>Juif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#jewishNationalIdentity</seealso>
    let jewishNationalIdentity =
        Prefixed_Name(cwrc, "jewishNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:jewishNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Jewish</para><para>Juif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#jewishNationalHeritage</seealso>
    let jewishNationalHeritage =
        Prefixed_Name(cwrc, "jewishNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:jewishReligion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#judaism" title="#judaism"&gt;Judaïsme&lt;/a&gt;.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#judaism" title="#judaism"&gt;Judaism&lt;/a&gt;.</para>
    /// labels<para>yu t'ai chiao</para><para>yóu tài jiāo</para><para>you tai jiao</para><para>Judaïsme</para><para>Judaísmo</para><para>Jodendom</para><para>Jewish</para><para>Joods</para><para>猶太教</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishReligion">http://sparql.cwrc.ca/ontologies/cwrc#jewishReligion</seealso>
    let jewishReligion = Prefixed_Name(cwrc, "jewishReligion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:milliner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>milliner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#milliner">http://sparql.cwrc.ca/ontologies/cwrc#milliner</seealso>
    let milliner = Prefixed_Name(cwrc, "milliner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:miner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>miner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#miner">http://sparql.cwrc.ca/ontologies/cwrc#miner</seealso>
    let miner = Prefixed_Name(cwrc, "miner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mining</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>mining</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mining">http://sparql.cwrc.ca/ontologies/cwrc#mining</seealso>
    let mining = Prefixed_Name(cwrc, "mining") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:miscarriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>miscarriage</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#miscarriage">http://sparql.cwrc.ca/ontologies/cwrc#miscarriage</seealso>
    let miscarriage = Prefixed_Name(cwrc, "miscarriage") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:miser</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>miser</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#miser">http://sparql.cwrc.ca/ontologies/cwrc#miser</seealso>
    let miser = Prefixed_Name(cwrc, "miser") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:missionaryWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>missionary work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#missionaryWork">http://sparql.cwrc.ca/ontologies/cwrc#missionaryWork</seealso>
    let missionaryWork = Prefixed_Name(cwrc, "missionaryWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:religious</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>religious</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#religious">http://sparql.cwrc.ca/ontologies/cwrc#religious</seealso>
    let religious = Prefixed_Name(cwrc, "religious") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mistress</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>mistress</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mistress">http://sparql.cwrc.ca/ontologies/cwrc#mistress</seealso>
    let mistress = Prefixed_Name(cwrc, "mistress") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>model</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#model">http://sparql.cwrc.ca/ontologies/cwrc#model</seealso>
    let model = Prefixed_Name(cwrc, "model") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:mohawkNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Mohawks</para><para>Mohawk</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mohawkNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#mohawkNationalHeritage</seealso>
    let mohawkNationalHeritage =
        Prefixed_Name(cwrc, "mohawkNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:mohawkNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalIdentity</para>
    ///
    /// labels<para>mohawk</para><para>Mohawk</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mohawkNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#mohawkNationalIdentity</seealso>
    let mohawkNationalIdentity =
        Prefixed_Name(cwrc, "mohawkNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:monarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>monarch</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#monarch">http://sparql.cwrc.ca/ontologies/cwrc#monarch</seealso>
    let monarch = Prefixed_Name(cwrc, "monarch") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:monism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>monisme</para><para>monism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#monism">http://sparql.cwrc.ca/ontologies/cwrc#monism</seealso>
    let monism = Prefixed_Name(cwrc, "monism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:moravian</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Frères moraves</para><para>Moravian</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#moravian">http://sparql.cwrc.ca/ontologies/cwrc#moravian</seealso>
    let moravian = Prefixed_Name(cwrc, "moravian") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:motherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>mother of</para><para>mère de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#motherOf">http://sparql.cwrc.ca/ontologies/cwrc#motherOf</seealso>
    let motherOf = Prefixed_Name(cwrc, "motherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mountaineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>mountaineering</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mountaineering">http://sparql.cwrc.ca/ontologies/cwrc#mountaineering</seealso>
    let mountaineering = Prefixed_Name(cwrc, "mountaineering") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:multiculturalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Multiculturalisme</para><para>multiculturalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#multiculturalism">http://sparql.cwrc.ca/ontologies/cwrc#multiculturalism</seealso>
    let multiculturalism = Prefixed_Name(cwrc, "multiculturalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:protoZionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Proto-Zionism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#protoZionism">http://sparql.cwrc.ca/ontologies/cwrc#protoZionism</seealso>
    let protoZionism = Prefixed_Name(cwrc, "protoZionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:publicReader</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>public reader</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#publicReader">http://sparql.cwrc.ca/ontologies/cwrc#publicReader</seealso>
    let publicReader = Prefixed_Name(cwrc, "publicReader") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:punjabiEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Pendjabis</para><para>Punjabi</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#punjabiEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#punjabiEthnicity</seealso>
    let punjabiEthnicity = Prefixed_Name(cwrc, "punjabiEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:puritanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>puritanisme</para><para>Puritanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#puritanism">http://sparql.cwrc.ca/ontologies/cwrc#puritanism</seealso>
    let puritanism = Prefixed_Name(cwrc, "puritanism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:transGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///
    /// labels<para>transgender</para><para>transgenre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#transGender">http://sparql.cwrc.ca/ontologies/cwrc#transGender</seealso>
    let transGender = Prefixed_Name(cwrc, "transGender") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>translator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#translator">http://sparql.cwrc.ca/ontologies/cwrc#translator</seealso>
    let translator = Prefixed_Name(cwrc, "translator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:travelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>travelling</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#travelling">http://sparql.cwrc.ca/ontologies/cwrc#travelling</seealso>
    let travelling = Prefixed_Name(cwrc, "travelling") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:treasurer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>treasurer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#treasurer">http://sparql.cwrc.ca/ontologies/cwrc#treasurer</seealso>
    let treasurer = Prefixed_Name(cwrc, "treasurer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:trustee</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>trustee</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#trustee">http://sparql.cwrc.ca/ontologies/cwrc#trustee</seealso>
    let trustee = Prefixed_Name(cwrc, "trustee") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:typeSetter</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>type setter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#typeSetter">http://sparql.cwrc.ca/ontologies/cwrc#typeSetter</seealso>
    let typeSetter = Prefixed_Name(cwrc, "typeSetter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:uncleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uncle of</para><para>oncle de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#uncleOf">http://sparql.cwrc.ca/ontologies/cwrc#uncleOf</seealso>
    let uncleOf = Prefixed_Name(cwrc, "uncleOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:undefinedGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///
    /// labels<para>genre indéterminé</para><para>undefined</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#undefinedGender">http://sparql.cwrc.ca/ontologies/cwrc#undefinedGender</seealso>
    let undefinedGender = Prefixed_Name(cwrc, "undefinedGender") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76">http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76</seealso>
    let _04b840aa_9c38_4e36_8d7c_21b38e192646_1e19da2a76 =
        Prefixed_Name(cwrc, "04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2">http://sparql.cwrc.ca/ontologies/cwrc#04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2</seealso>
    let _04b840aa_9c38_4e36_8d7c_21b38e192646_dd5a878fc2 =
        Prefixed_Name(cwrc, "04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456">http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456</seealso>
    let _65424c4e_5257_4e6c_962f_de12a7f11aea_partof_712daeb456 =
        Prefixed_Name(cwrc, "65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:727d97bc-af78-4122-94be-aa78b2e97d5a</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#727d97bc-af78-4122-94be-aa78b2e97d5a">http://sparql.cwrc.ca/ontologies/cwrc#727d97bc-af78-4122-94be-aa78b2e97d5a</seealso>
    let _727d97bc_af78_4122_94be_aa78b2e97d5a =
        Prefixed_Name(cwrc, "727d97bc-af78-4122-94be-aa78b2e97d5a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c">http://sparql.cwrc.ca/ontologies/cwrc#734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c</seealso>
    let _734cd035_459b_407e_8a08_b68cd2bb743a_b79efa6e1c =
        Prefixed_Name(cwrc, "734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:75660bb0-b804-428e-8efb-c139bc7a63d6-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Proceedings</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-partof">http://sparql.cwrc.ca/ontologies/cwrc#75660bb0-b804-428e-8efb-c139bc7a63d6-partof</seealso>
    let _75660bb0_b804_428e_8efb_c139bc7a63d6_partof =
        Prefixed_Name(cwrc, "75660bb0-b804-428e-8efb-c139bc7a63d6-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950">http://sparql.cwrc.ca/ontologies/cwrc#772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950</seealso>
    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_ab964c6950 =
        Prefixed_Name(cwrc, "772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:775357d1-e547-4674-9467-50b0308354ca</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca">http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca</seealso>
    let _775357d1_e547_4674_9467_50b0308354ca =
        Prefixed_Name(cwrc, "775357d1-e547-4674-9467-50b0308354ca") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db">http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db</seealso>
    let _775357d1_e547_4674_9467_50b0308354ca_9f43ebd6db =
        Prefixed_Name(cwrc, "775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:775357d1-e547-4674-9467-50b0308354ca-42d9d30d94</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-42d9d30d94">http://sparql.cwrc.ca/ontologies/cwrc#775357d1-e547-4674-9467-50b0308354ca-42d9d30d94</seealso>
    let _775357d1_e547_4674_9467_50b0308354ca_42d9d30d94 =
        Prefixed_Name(cwrc, "775357d1-e547-4674-9467-50b0308354ca-42d9d30d94") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:IntervalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>sem:TimeType</para>
    ///
    /// labels<para>interval time</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#IntervalTime">http://sparql.cwrc.ca/ontologies/cwrc#IntervalTime</seealso>
    let IntervalTime = Prefixed_Name(cwrc, "IntervalTime") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:JewishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#jewishEthnicity" title="#jewishEthnicity"&gt;Juif&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#jewishEthnicity" title="#jewishEthnicity"&gt;Jewish&lt;/a&gt;.</para>
    /// labels<para>Jewish</para><para>Juif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#JewishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#JewishEthnicity</seealso>
    let JewishEthnicity = Prefixed_Name(cwrc, "JewishEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jewishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Jewish</para><para>Juif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#jewishEthnicity</seealso>
    let jewishEthnicity = Prefixed_Name(cwrc, "jewishEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jewishLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:TextLabels</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Jewish identity</para><para>identité Juif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishLabel">http://sparql.cwrc.ca/ontologies/cwrc#jewishLabel</seealso>
    let jewishLabel = Prefixed_Name(cwrc, "jewishLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:LeisureContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>leisure context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#LeisureContext">http://sparql.cwrc.ca/ontologies/cwrc#LeisureContext</seealso>
    let LeisureContext = Prefixed_Name(cwrc, "LeisureContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anglo-IndianNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Anglo-Indienne</para><para>Anglo-Indian</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IndianNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#anglo-IndianNationalIdentity</seealso>
    let anglo_IndianNationalIdentity =
        Prefixed_Name(cwrc, "anglo-IndianNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:blackEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>black</para><para>noir</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#blackEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#blackEthnicity</seealso>
    let blackEthnicity = Prefixed_Name(cwrc, "blackEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:counsellor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>counsellor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#counsellor">http://sparql.cwrc.ca/ontologies/cwrc#counsellor</seealso>
    let counsellor = Prefixed_Name(cwrc, "counsellor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:courtier</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>courtier</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#courtier">http://sparql.cwrc.ca/ontologies/cwrc#courtier</seealso>
    let courtier = Prefixed_Name(cwrc, "courtier") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:covenanters</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Covenantaire</para><para>Covenanters</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#covenanters">http://sparql.cwrc.ca/ontologies/cwrc#covenanters</seealso>
    let covenanters = Prefixed_Name(cwrc, "covenanters") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:craftsperson</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>craftsperson</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#craftsperson">http://sparql.cwrc.ca/ontologies/cwrc#craftsperson</seealso>
    let craftsperson = Prefixed_Name(cwrc, "craftsperson") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:engraver</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>engraver</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#engraver">http://sparql.cwrc.ca/ontologies/cwrc#engraver</seealso>
    let engraver = Prefixed_Name(cwrc, "engraver") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPoliticalMembershipIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has political membership in</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipIn">http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipIn</seealso>
    let hasPoliticalMembershipIn =
        Prefixed_Name(cwrc, "hasPoliticalMembershipIn") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has relative</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasRelative">http://sparql.cwrc.ca/ontologies/cwrc#hasRelative</seealso>
    let hasRelative = Prefixed_Name(cwrc, "hasRelative") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hostess</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>hostess</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hostess">http://sparql.cwrc.ca/ontologies/cwrc#hostess</seealso>
    let hostess = Prefixed_Name(cwrc, "hostess") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:housePainter</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>house painter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#housePainter">http://sparql.cwrc.ca/ontologies/cwrc#housePainter</seealso>
    let housePainter = Prefixed_Name(cwrc, "housePainter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:houseSitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>house sitter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#houseSitter">http://sparql.cwrc.ca/ontologies/cwrc#houseSitter</seealso>
    let houseSitter = Prefixed_Name(cwrc, "houseSitter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:housework</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>housework</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#housework">http://sparql.cwrc.ca/ontologies/cwrc#housework</seealso>
    let housework = Prefixed_Name(cwrc, "housework") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:housingMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement pour le droit au logement</para><para>housing movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#housingMovement">http://sparql.cwrc.ca/ontologies/cwrc#housingMovement</seealso>
    let housingMovement = Prefixed_Name(cwrc, "housingMovement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:humanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Humanisme</para><para>humanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#humanism">http://sparql.cwrc.ca/ontologies/cwrc#humanism</seealso>
    let humanism = Prefixed_Name(cwrc, "humanism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:humanitarianWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>humanitarian work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#humanitarianWork">http://sparql.cwrc.ca/ontologies/cwrc#humanitarianWork</seealso>
    let humanitarianWork = Prefixed_Name(cwrc, "humanitarianWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:husbandOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>husband of</para><para>mari de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#husbandOf">http://sparql.cwrc.ca/ontologies/cwrc#husbandOf</seealso>
    let husbandOf = Prefixed_Name(cwrc, "husbandOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hypnotist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>hypnotist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hypnotist">http://sparql.cwrc.ca/ontologies/cwrc#hypnotist</seealso>
    let hypnotist = Prefixed_Name(cwrc, "hypnotist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:identity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Deprecated from previous Orlando Ontology design.</para>
    ///   <para>Désapprouver de l'ancienne ontology Orlando.</para>
    /// labels<para>identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#identity">http://sparql.cwrc.ca/ontologies/cwrc#identity</seealso>
    let identity = Prefixed_Name(cwrc, "identity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:illustrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>illustrator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#illustrator">http://sparql.cwrc.ca/ontologies/cwrc#illustrator</seealso>
    let illustrator = Prefixed_Name(cwrc, "illustrator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:immunologist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>immunologist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#immunologist">http://sparql.cwrc.ca/ontologies/cwrc#immunologist</seealso>
    let immunologist = Prefixed_Name(cwrc, "immunologist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:inRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver de l'ancienne ontologie Orlando.</para>
    ///   <para>Deprecated from previous Orlando Ontology design.</para>
    /// labels<para>in role</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#inRole">http://sparql.cwrc.ca/ontologies/cwrc#inRole</seealso>
    let inRole = Prefixed_Name(cwrc, "inRole") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:independentMethodistConnexion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Independent Methodist Connexion</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#independentMethodistConnexion">http://sparql.cwrc.ca/ontologies/cwrc#independentMethodistConnexion</seealso>
    let independentMethodistConnexion =
        Prefixed_Name(cwrc, "independentMethodistConnexion") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:indexedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>indexed by</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indexedBy">http://sparql.cwrc.ca/ontologies/cwrc#indexedBy</seealso>
    let indexedBy = Prefixed_Name(cwrc, "indexedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:indianIndependence</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Mouvement pour l'indépendance de l'Inde</para><para>Indian independence movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indianIndependence">http://sparql.cwrc.ca/ontologies/cwrc#indianIndependence</seealso>
    let indianIndependence = Prefixed_Name(cwrc, "indianIndependence") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:parsiEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Parsi</para><para>Parsi</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#parsiEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#parsiEthnicity</seealso>
    let parsiEthnicity = Prefixed_Name(cwrc, "parsiEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:participantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>participant of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#participantOf">http://sparql.cwrc.ca/ontologies/cwrc#participantOf</seealso>
    let participantOf = Prefixed_Name(cwrc, "participantOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:paternalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>paternalisme</para><para>paternalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#paternalism">http://sparql.cwrc.ca/ontologies/cwrc#paternalism</seealso>
    let paternalism = Prefixed_Name(cwrc, "paternalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:patriot</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>patriot</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#patriot">http://sparql.cwrc.ca/ontologies/cwrc#patriot</seealso>
    let patriot = Prefixed_Name(cwrc, "patriot") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:zen</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>zen</para><para>Zen</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#zen">http://sparql.cwrc.ca/ontologies/cwrc#zen</seealso>
    let zen = Prefixed_Name(cwrc, "zen") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:zoroastrianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Zoroastrianism</para><para>Zoroastrisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#zoroastrianism">http://sparql.cwrc.ca/ontologies/cwrc#zoroastrianism</seealso>
    let zoroastrianism = Prefixed_Name(cwrc, "zoroastrianism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:20b2549d-ee16-45e2-8f42-5e369da2ae0f</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f">http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f</seealso>
    let _20b2549d_ee16_45e2_8f42_5e369da2ae0f =
        Prefixed_Name(cwrc, "20b2549d-ee16-45e2-8f42-5e369da2ae0f") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096">http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096</seealso>
    let _20b2549d_ee16_45e2_8f42_5e369da2ae0f_c18718c096 =
        Prefixed_Name(cwrc, "20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b">http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b</seealso>
    let _20f0c9a2_4cc1_4838_87a5_3b6df3b0a24b =
        Prefixed_Name(cwrc, "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4">http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4</seealso>
    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_706552b3f4 =
        Prefixed_Name(cwrc, "7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab">http://sparql.cwrc.ca/ontologies/cwrc#7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab</seealso>
    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_4d944811ab =
        Prefixed_Name(cwrc, "7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:literaryGroupParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>literary group participant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryGroupParticipant">http://sparql.cwrc.ca/ontologies/cwrc#literaryGroupParticipant</seealso>
    let literaryGroupParticipant =
        Prefixed_Name(cwrc, "literaryGroupParticipant") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:botanist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>botanist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#botanist">http://sparql.cwrc.ca/ontologies/cwrc#botanist</seealso>
    let botanist = Prefixed_Name(cwrc, "botanist") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasActivistInvolvementFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has activist involvement from</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementFrom">http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementFrom</seealso>
    let hasActivistInvolvementFrom =
        Prefixed_Name(cwrc, "hasActivistInvolvementFrom") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPoliticalMembershipFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has political membership from</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipFrom">http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipFrom</seealso>
    let hasPoliticalMembershipFrom =
        Prefixed_Name(cwrc, "hasPoliticalMembershipFrom") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasActivistInvolvementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has activist involvement in</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementIn">http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementIn</seealso>
    let hasActivistInvolvementIn =
        Prefixed_Name(cwrc, "hasActivistInvolvementIn") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasCauseOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une cause de décès</para><para>has cause of death</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCauseOfDeath">http://sparql.cwrc.ca/ontologies/cwrc#hasCauseOfDeath</seealso>
    let hasCauseOfDeath = Prefixed_Name(cwrc, "hasCauseOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hunter</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>hunter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hunter">http://sparql.cwrc.ca/ontologies/cwrc#hunter</seealso>
    let hunter = Prefixed_Name(cwrc, "hunter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:madeAlteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>made alteration</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#madeAlteration">http://sparql.cwrc.ca/ontologies/cwrc#madeAlteration</seealso>
    let madeAlteration = Prefixed_Name(cwrc, "madeAlteration") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:maidOfHonour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>maid of honour</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#maidOfHonour">http://sparql.cwrc.ca/ontologies/cwrc#maidOfHonour</seealso>
    let maidOfHonour = Prefixed_Name(cwrc, "maidOfHonour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:maleLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:TextLabels</para>
    ///   <para>Deprecated with no current equivalence.</para>
    ///   <para>Désapprouver sans équivalence.</para>
    /// labels<para>male</para><para>male</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#maleLabel">http://sparql.cwrc.ca/ontologies/cwrc#maleLabel</seealso>
    let maleLabel = Prefixed_Name(cwrc, "maleLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:maleSex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#genderManMale" title="#genderManMale"&gt;homme/mâle&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#genderManMale" title="#genderManMale"&gt;man/male&lt;/a&gt;.</para>
    /// labels<para>Mâle</para><para>Male</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#maleSex">http://sparql.cwrc.ca/ontologies/cwrc#maleSex</seealso>
    let maleSex = Prefixed_Name(cwrc, "maleSex") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:malthusianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Malthusianisme</para><para>Malthusianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#malthusianism">http://sparql.cwrc.ca/ontologies/cwrc#malthusianism</seealso>
    let malthusianism = Prefixed_Name(cwrc, "malthusianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:managerial</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>managerial</para><para>cadre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#managerial">http://sparql.cwrc.ca/ontologies/cwrc#managerial</seealso>
    let managerial = Prefixed_Name(cwrc, "managerial") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:manservant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>manservant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#manservant">http://sparql.cwrc.ca/ontologies/cwrc#manservant</seealso>
    let manservant = Prefixed_Name(cwrc, "manservant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pawnbroker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>pawnbroker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pawnbroker">http://sparql.cwrc.ca/ontologies/cwrc#pawnbroker</seealso>
    let pawnbroker = Prefixed_Name(cwrc, "pawnbroker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pentecostalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Pentecostalism</para><para>Pentecôtisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pentecostalism">http://sparql.cwrc.ca/ontologies/cwrc#pentecostalism</seealso>
    let pentecostalism = Prefixed_Name(cwrc, "pentecostalism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexualityBisexuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Sexuality</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>bisexualité</para><para>bisexuality</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityBisexuality">http://sparql.cwrc.ca/ontologies/cwrc#sexualityBisexuality</seealso>
    let sexualityBisexuality =
        Prefixed_Name(cwrc, "sexualityBisexuality") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexualityCelibacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Sexuality</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>celibacy</para><para>célibat</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityCelibacy">http://sparql.cwrc.ca/ontologies/cwrc#sexualityCelibacy</seealso>
    let sexualityCelibacy = Prefixed_Name(cwrc, "sexualityCelibacy") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexualityLibertinism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Sexuality</para>
    ///
    /// labels<para>libertinism</para><para>libertinage</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityLibertinism">http://sparql.cwrc.ca/ontologies/cwrc#sexualityLibertinism</seealso>
    let sexualityLibertinism =
        Prefixed_Name(cwrc, "sexualityLibertinism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881">http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881</seealso>
    let _2002eb96_4775_4ae0_ba0f_6704c30264a9_48185cb881 =
        Prefixed_Name(cwrc, "2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211">http://sparql.cwrc.ca/ontologies/cwrc#20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211</seealso>
    let _20b2549d_ee16_45e2_8f42_5e369da2ae0f_058f6f7211 =
        Prefixed_Name(cwrc, "20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691">http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691</seealso>
    let _20f0c9a2_4cc1_4838_87a5_3b6df3b0a24b_ecfae99691 =
        Prefixed_Name(cwrc, "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942">http://sparql.cwrc.ca/ontologies/cwrc#20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942</seealso>
    let _20f0c9a2_4cc1_4838_87a5_3b6df3b0a24b_769103a942 =
        Prefixed_Name(cwrc, "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7fb45454-7271-48b3-bd57-7a2b4572fc21</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21">http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21</seealso>
    let _7fb45454_7271_48b3_bd57_7a2b4572fc21 =
        Prefixed_Name(cwrc, "7fb45454-7271-48b3-bd57-7a2b4572fc21") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532">http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532</seealso>
    let _7fb45454_7271_48b3_bd57_7a2b4572fc21_afbfc72532 =
        Prefixed_Name(cwrc, "7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8049540f-3673-4ca0-920c-cb5326d7c466</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466">http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466</seealso>
    let _8049540f_3673_4ca0_920c_cb5326d7c466 =
        Prefixed_Name(cwrc, "8049540f-3673-4ca0-920c-cb5326d7c466") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9</seealso>
    let _8049540f_3673_4ca0_920c_cb5326d7c466_215ee9c7d9 =
        Prefixed_Name(cwrc, "8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9">http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9</seealso>
    let _825995b3_3b66_4e0a_a62d_d8649aaead78_63a2ae33d9 =
        Prefixed_Name(cwrc, "825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9</seealso>
    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5_215ee9c7d9 =
        Prefixed_Name(cwrc, "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof">http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof</seealso>
    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5_partof =
        Prefixed_Name(cwrc, "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9</seealso>
    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5_partof_215ee9c7d9 =
        Prefixed_Name(cwrc, "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8fd7cfcc-7613-4c1c-af44-798d6a3dca4c</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c">http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c</seealso>
    let _8fd7cfcc_7613_4c1c_af44_798d6a3dca4c =
        Prefixed_Name(cwrc, "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be">http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be</seealso>
    let _8fd7cfcc_7613_4c1c_af44_798d6a3dca4c_109da887be =
        Prefixed_Name(cwrc, "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:9144c07e-d14f-4371-8d28-7545b7337a4a</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Webpage</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a">http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a</seealso>
    let _9144c07e_d14f_4371_8d28_7545b7337a4a =
        Prefixed_Name(cwrc, "9144c07e-d14f-4371-8d28-7545b7337a4a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9</seealso>
    let _9144c07e_d14f_4371_8d28_7545b7337a4a_215ee9c7d9 =
        Prefixed_Name(cwrc, "9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b">http://sparql.cwrc.ca/ontologies/cwrc#9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b</seealso>
    let _9144c07e_d14f_4371_8d28_7545b7337a4a_80d754989b =
        Prefixed_Name(cwrc, "9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:9f8246db-bb73-4ad1-ab02-693da46dbd06</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06">http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06</seealso>
    let _9f8246db_bb73_4ad1_ab02_693da46dbd06 =
        Prefixed_Name(cwrc, "9f8246db-bb73-4ad1-ab02-693da46dbd06") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259">http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259</seealso>
    let _9f8246db_bb73_4ad1_ab02_693da46dbd06_5d348c3259 =
        Prefixed_Name(cwrc, "9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:9f8246db-bb73-4ad1-ab02-693da46dbd06-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06-partof">http://sparql.cwrc.ca/ontologies/cwrc#9f8246db-bb73-4ad1-ab02-693da46dbd06-partof</seealso>
    let _9f8246db_bb73_4ad1_ab02_693da46dbd06_partof =
        Prefixed_Name(cwrc, "9f8246db-bb73-4ad1-ab02-693da46dbd06-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:AbusiveName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>abusive name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#AbusiveName">http://sparql.cwrc.ca/ontologies/cwrc#AbusiveName</seealso>
    let AbusiveName = Prefixed_Name(cwrc, "AbusiveName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:NameType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>name type</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#NameType">http://sparql.cwrc.ca/ontologies/cwrc#NameType</seealso>
    let NameType = Prefixed_Name(cwrc, "NameType") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Role</para>
    ///
    /// labels<para>actor</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Actor">http://sparql.cwrc.ca/ontologies/cwrc#Actor</seealso>
    let Actor = Prefixed_Name(cwrc, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rôle</para><para>role</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Role">http://sparql.cwrc.ca/ontologies/cwrc#Role</seealso>
    let Role = Prefixed_Name(cwrc, "Role") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>endroit</para><para>place</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Place">http://sparql.cwrc.ca/ontologies/cwrc#Place</seealso>
    let Place = Prefixed_Name(cwrc, "Place") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Androgynous</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///
    /// labels<para>androgynous</para><para>androgyne</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Androgynous">http://sparql.cwrc.ca/ontologies/cwrc#Androgynous</seealso>
    let Androgynous = Prefixed_Name(cwrc, "Androgynous") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:AuthorialName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>authorial name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#AuthorialName">http://sparql.cwrc.ca/ontologies/cwrc#AuthorialName</seealso>
    let AuthorialName = Prefixed_Name(cwrc, "AuthorialName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:BiographyContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>biography context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#BiographyContext">http://sparql.cwrc.ca/ontologies/cwrc#BiographyContext</seealso>
    let BiographyContext = Prefixed_Name(cwrc, "BiographyContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:BirthPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ordre de naissance</para><para>birth position</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#BirthPosition">http://sparql.cwrc.ca/ontologies/cwrc#BirthPosition</seealso>
    let BirthPosition = Prefixed_Name(cwrc, "BirthPosition") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:BoardingSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>boarding school</para><para>internat</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#BoardingSchool">http://sparql.cwrc.ca/ontologies/cwrc#BoardingSchool</seealso>
    let BoardingSchool = Prefixed_Name(cwrc, "BoardingSchool") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:BritishWomenLiteraryClimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>british women writers literary climate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#BritishWomenLiteraryClimate">http://sparql.cwrc.ca/ontologies/cwrc#BritishWomenLiteraryClimate</seealso>
    let BritishWomenLiteraryClimate =
        Prefixed_Name(cwrc, "BritishWomenLiteraryClimate") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:LiteraryClimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>literary climate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#LiteraryClimate">http://sparql.cwrc.ca/ontologies/cwrc#LiteraryClimate</seealso>
    let LiteraryClimate = Prefixed_Name(cwrc, "LiteraryClimate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Bursary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>bursary</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Bursary">http://sparql.cwrc.ca/ontologies/cwrc#Bursary</seealso>
    let Bursary = Prefixed_Name(cwrc, "Bursary") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:EducationalAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>récompenses scolaires</para><para>educational award</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalAward">http://sparql.cwrc.ca/ontologies/cwrc#EducationalAward</seealso>
    let EducationalAward = Prefixed_Name(cwrc, "EducationalAward") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ChangeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>&lt;https://www.w3.org/2006/time#Instant&gt;</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>change set</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ChangeSet">http://sparql.cwrc.ca/ontologies/cwrc#ChangeSet</seealso>
    let ChangeSet = Prefixed_Name(cwrc, "ChangeSet") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SexualityContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>sexualité en contexte</para><para>sexuality context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SexualityContext">http://sparql.cwrc.ca/ontologies/cwrc#SexualityContext</seealso>
    let SexualityContext = Prefixed_Name(cwrc, "SexualityContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SingleSexSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>éducation non mixte</para><para>single-sex school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SingleSexSchool">http://sparql.cwrc.ca/ontologies/cwrc#SingleSexSchool</seealso>
    let SingleSexSchool = Prefixed_Name(cwrc, "SingleSexSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:christianSocialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>socialisme chrétien</para><para>Christian socialism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#christianSocialism">http://sparql.cwrc.ca/ontologies/cwrc#christianSocialism</seealso>
    let christianSocialism = Prefixed_Name(cwrc, "christianSocialism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:churchOfChristianScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#christianScience" title="#christianScience"&gt;Science Chrétienne&lt;/a&gt;.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#christianScience" title="#christianScience"&gt;Christian Science&lt;/a&gt;.</para>
    /// labels<para>Christenwetenschap</para><para>Science CHRÉTIENNE</para><para>Ciencia Cristiana</para><para>Christian Science</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#churchOfChristianScience">http://sparql.cwrc.ca/ontologies/cwrc#churchOfChristianScience</seealso>
    let churchOfChristianScience =
        Prefixed_Name(cwrc, "churchOfChristianScience") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:churchOfEngland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>foaf:Organization</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#anglicanism" title="#anglicanism"&gt;Anglicanism&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#anglicanism" title="#anglicanism"&gt;Église d'Angleterre&lt;/a&gt;.</para>
    /// labels<para>Church of England</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#churchOfEngland">http://sparql.cwrc.ca/ontologies/cwrc#churchOfEngland</seealso>
    let churchOfEngland = Prefixed_Name(cwrc, "churchOfEngland") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:churchOfIreland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>foaf:Organization</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#anglicanism" title="#anglicanism"&gt;Église d'Angleterre&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#anglicanism" title="#anglicanism"&gt;Anglicanism&lt;/a&gt;.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Church of Ireland</para><para>Église d'Irlande</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#churchOfIreland">http://sparql.cwrc.ca/ontologies/cwrc#churchOfIreland</seealso>
    let churchOfIreland = Prefixed_Name(cwrc, "churchOfIreland") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cisGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///
    /// labels<para>cisgender</para><para>cisgenre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cisGender">http://sparql.cwrc.ca/ontologies/cwrc#cisGender</seealso>
    let cisGender = Prefixed_Name(cwrc, "cisGender") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cisMan</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Gender</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>homme cisgenre</para><para>cisman</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cisMan">http://sparql.cwrc.ca/ontologies/cwrc#cisMan</seealso>
    let cisMan = Prefixed_Name(cwrc, "cisMan") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:manLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:TextLabels</para>
    ///
    /// labels<para>homme</para><para>man</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#manLabel">http://sparql.cwrc.ca/ontologies/cwrc#manLabel</seealso>
    let manLabel = Prefixed_Name(cwrc, "manLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cisWoman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///
    /// labels<para>femme cisgenre</para><para>ciswoman</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cisWoman">http://sparql.cwrc.ca/ontologies/cwrc#cisWoman</seealso>
    let cisWoman = Prefixed_Name(cwrc, "cisWoman") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:womanLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:TextLabels</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>woman</para><para>femme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#womanLabel">http://sparql.cwrc.ca/ontologies/cwrc#womanLabel</seealso>
    let womanLabel = Prefixed_Name(cwrc, "womanLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:civilLibertarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement libertaire</para><para>civil libertarianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#civilLibertarianism">http://sparql.cwrc.ca/ontologies/cwrc#civilLibertarianism</seealso>
    let civilLibertarianism = Prefixed_Name(cwrc, "civilLibertarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:classicist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>classicist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#classicist">http://sparql.cwrc.ca/ontologies/cwrc#classicist</seealso>
    let classicist = Prefixed_Name(cwrc, "classicist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cleaner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>cleaner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cleaner">http://sparql.cwrc.ca/ontologies/cwrc#cleaner</seealso>
    let cleaner = Prefixed_Name(cwrc, "cleaner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:clericalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>clerical work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#clericalWork">http://sparql.cwrc.ca/ontologies/cwrc#clericalWork</seealso>
    let clericalWork = Prefixed_Name(cwrc, "clericalWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:clothingProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>clothing production</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#clothingProduction">http://sparql.cwrc.ca/ontologies/cwrc#clothingProduction</seealso>
    let clothingProduction = Prefixed_Name(cwrc, "clothingProduction") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:clothworker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>clothworker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#clothworker">http://sparql.cwrc.ca/ontologies/cwrc#clothworker</seealso>
    let clothworker = Prefixed_Name(cwrc, "clothworker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:coach</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>coach</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#coach">http://sparql.cwrc.ca/ontologies/cwrc#coach</seealso>
    let coach = Prefixed_Name(cwrc, "coach") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sports</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>sports</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sports">http://sparql.cwrc.ca/ontologies/cwrc#sports</seealso>
    let sports = Prefixed_Name(cwrc, "sports") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:coastGuard</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>coastguard</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#coastGuard">http://sparql.cwrc.ca/ontologies/cwrc#coastGuard</seealso>
    let coastGuard = Prefixed_Name(cwrc, "coastGuard") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lawEnforcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>law enforcement</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lawEnforcement">http://sparql.cwrc.ca/ontologies/cwrc#lawEnforcement</seealso>
    let lawEnforcement = Prefixed_Name(cwrc, "lawEnforcement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cobbler</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>cobbler</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cobbler">http://sparql.cwrc.ca/ontologies/cwrc#cobbler</seealso>
    let cobbler = Prefixed_Name(cwrc, "cobbler") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:collector</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>collector</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#collector">http://sparql.cwrc.ca/ontologies/cwrc#collector</seealso>
    let collector = Prefixed_Name(cwrc, "collector") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:colonialOfficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>colonial official</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#colonialOfficial">http://sparql.cwrc.ca/ontologies/cwrc#colonialOfficial</seealso>
    let colonialOfficial = Prefixed_Name(cwrc, "colonialOfficial") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:commissioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>commissioner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#commissioner">http://sparql.cwrc.ca/ontologies/cwrc#commissioner</seealso>
    let commissioner = Prefixed_Name(cwrc, "commissioner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:committeeMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>committee member</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#committeeMember">http://sparql.cwrc.ca/ontologies/cwrc#committeeMember</seealso>
    let committeeMember = Prefixed_Name(cwrc, "committeeMember") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:communalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>municipalisme libertaire</para><para>communalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#communalism">http://sparql.cwrc.ca/ontologies/cwrc#communalism</seealso>
    let communalism = Prefixed_Name(cwrc, "communalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:communeOrganizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>commune organizer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#communeOrganizer">http://sparql.cwrc.ca/ontologies/cwrc#communeOrganizer</seealso>
    let communeOrganizer = Prefixed_Name(cwrc, "communeOrganizer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:liberalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Libéralisme</para><para>liberalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#liberalism">http://sparql.cwrc.ca/ontologies/cwrc#liberalism</seealso>
    let liberalism = Prefixed_Name(cwrc, "liberalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:editing</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>editing</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#editing">http://sparql.cwrc.ca/ontologies/cwrc#editing</seealso>
    let editing = Prefixed_Name(cwrc, "editing") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:freeTradeMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement pour le libre-échange</para><para>free trade movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#freeTradeMovement">http://sparql.cwrc.ca/ontologies/cwrc#freeTradeMovement</seealso>
    let freeTradeMovement = Prefixed_Name(cwrc, "freeTradeMovement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:freemasonry</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>franc-maçonnerie</para><para>Freemasonry</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#freemasonry">http://sparql.cwrc.ca/ontologies/cwrc#freemasonry</seealso>
    let freemasonry = Prefixed_Name(cwrc, "freemasonry") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:freethought</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>libre-pensée</para><para>freethought</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#freethought">http://sparql.cwrc.ca/ontologies/cwrc#freethought</seealso>
    let freethought = Prefixed_Name(cwrc, "freethought") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:frenchNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Nationalisme en France</para><para>French nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#frenchNationalism">http://sparql.cwrc.ca/ontologies/cwrc#frenchNationalism</seealso>
    let frenchNationalism = Prefixed_Name(cwrc, "frenchNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fundraiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>fundraiser</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fundraiser">http://sparql.cwrc.ca/ontologies/cwrc#fundraiser</seealso>
    let fundraiser = Prefixed_Name(cwrc, "fundraiser") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:scottishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Scottish</para><para>Écossais</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#scottishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#scottishEthnicity</seealso>
    let scottishEthnicity = Prefixed_Name(cwrc, "scottishEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gambling</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>gambling</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gambling">http://sparql.cwrc.ca/ontologies/cwrc#gambling</seealso>
    let gambling = Prefixed_Name(cwrc, "gambling") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gardener</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>gardener</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gardener">http://sparql.cwrc.ca/ontologies/cwrc#gardener</seealso>
    let gardener = Prefixed_Name(cwrc, "gardener") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gastronome</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>gastronome</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gastronome">http://sparql.cwrc.ca/ontologies/cwrc#gastronome</seealso>
    let gastronome = Prefixed_Name(cwrc, "gastronome") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gayRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>gay rights movement</para><para>Mouvement LGBT</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gayRights">http://sparql.cwrc.ca/ontologies/cwrc#gayRights</seealso>
    let gayRights = Prefixed_Name(cwrc, "gayRights") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:genderManMale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#man" title="#man"&gt;man&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#man" title="#man"&gt;homme&lt;/a&gt;.</para>
    /// labels<para>homme/mâle</para><para>man/male</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genderManMale">http://sparql.cwrc.ca/ontologies/cwrc#genderManMale</seealso>
    let genderManMale = Prefixed_Name(cwrc, "genderManMale") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:man</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///
    /// labels<para>homme</para><para>man</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#man">http://sparql.cwrc.ca/ontologies/cwrc#man</seealso>
    let man = Prefixed_Name(cwrc, "man") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:woman</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Gender</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>woman</para><para>femme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#woman">http://sparql.cwrc.ca/ontologies/cwrc#woman</seealso>
    let woman = Prefixed_Name(cwrc, "woman") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:genealogist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>genealogist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genealogist">http://sparql.cwrc.ca/ontologies/cwrc#genealogist</seealso>
    let genealogist = Prefixed_Name(cwrc, "genealogist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gentleman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>gentleman</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gentleman">http://sparql.cwrc.ca/ontologies/cwrc#gentleman</seealso>
    let gentleman = Prefixed_Name(cwrc, "gentleman") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gentry</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>aristocratie</para><para>gentry</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gentry">http://sparql.cwrc.ca/ontologies/cwrc#gentry</seealso>
    let gentry = Prefixed_Name(cwrc, "gentry") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:geographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>geographer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#geographer">http://sparql.cwrc.ca/ontologies/cwrc#geographer</seealso>
    let geographer = Prefixed_Name(cwrc, "geographer") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:geographicHeritageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographic heritage of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageOf">http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageOf</seealso>
    let geographicHeritageOf =
        Prefixed_Name(cwrc, "geographicHeritageOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:geographicHeritageReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographic heritage (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageReportedOf</seealso>
    let geographicHeritageReportedOf =
        Prefixed_Name(cwrc, "geographicHeritageReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:geographicHeritageSelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographic heritage (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageSelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageSelfReportedOf</seealso>
    let geographicHeritageSelfReportedOf =
        Prefixed_Name(cwrc, "geographicHeritageSelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:geologist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>geologist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#geologist">http://sparql.cwrc.ca/ontologies/cwrc#geologist</seealso>
    let geologist = Prefixed_Name(cwrc, "geologist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:glover</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>glover</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#glover">http://sparql.cwrc.ca/ontologies/cwrc#glover</seealso>
    let glover = Prefixed_Name(cwrc, "glover") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:gnosticism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>gnosticisme</para><para>Gnosticism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#gnosticism">http://sparql.cwrc.ca/ontologies/cwrc#gnosticism</seealso>
    let gnosticism = Prefixed_Name(cwrc, "gnosticism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:goldsmith</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>goldsmith</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#goldsmith">http://sparql.cwrc.ca/ontologies/cwrc#goldsmith</seealso>
    let goldsmith = Prefixed_Name(cwrc, "goldsmith") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jeweller</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>jeweller</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jeweller">http://sparql.cwrc.ca/ontologies/cwrc#jeweller</seealso>
    let jeweller = Prefixed_Name(cwrc, "jeweller") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:governess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>governess</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#governess">http://sparql.cwrc.ca/ontologies/cwrc#governess</seealso>
    let governess = Prefixed_Name(cwrc, "governess") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasSocialClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une classe sociale</para><para>has class identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClass">http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClass</seealso>
    let hasSocialClass = Prefixed_Name(cwrc, "hasSocialClass") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socialClassOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>class identity of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassOf">http://sparql.cwrc.ca/ontologies/cwrc#socialClassOf</seealso>
    let socialClassOf = Prefixed_Name(cwrc, "socialClassOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSocialClassReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has class identity (reported)</para><para>a classe sociale déclarée</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassReported">http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassReported</seealso>
    let hasSocialClassReported =
        Prefixed_Name(cwrc, "hasSocialClassReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:socialClassReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>class identity (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#socialClassReportedOf</seealso>
    let socialClassReportedOf =
        Prefixed_Name(cwrc, "socialClassReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSocialClassSelfDefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasSocialClassSelfReported" title="#hasSocialClassSelfReported"&gt;a classe sociale autodéclarée&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasSocialClassSelfReported" title="#hasSocialClassSelfReported"&gt;has class identity (self-reported)&lt;/a&gt;.</para>
    /// labels<para>de classe sociale (autodéclarés)</para><para>has social class (self defined)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassSelfDefined">http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassSelfDefined</seealso>
    let hasSocialClassSelfDefined =
        Prefixed_Name(cwrc, "hasSocialClassSelfDefined") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSocialClassSelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has class identity (self-reported)</para><para>a classe sociale autodéclarée</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassSelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassSelfReported</seealso>
    let hasSocialClassSelfReported =
        Prefixed_Name(cwrc, "hasSocialClassSelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:socialClassSelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>class identity (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassSelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#socialClassSelfReportedOf</seealso>
    let socialClassSelfReportedOf =
        Prefixed_Name(cwrc, "socialClassSelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has son</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSon">http://sparql.cwrc.ca/ontologies/cwrc#hasSon</seealso>
    let hasSon = Prefixed_Name(cwrc, "hasSon") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasSortOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has sort order</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSortOrder">http://sparql.cwrc.ca/ontologies/cwrc#hasSortOrder</seealso>
    let hasSortOrder = Prefixed_Name(cwrc, "hasSortOrder") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepfather</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepFather">http://sparql.cwrc.ca/ontologies/cwrc#hasStepFather</seealso>
    let hasStepFather = Prefixed_Name(cwrc, "hasStepFather") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepparent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepParent">http://sparql.cwrc.ca/ontologies/cwrc#hasStepParent</seealso>
    let hasStepParent = Prefixed_Name(cwrc, "hasStepParent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepmother</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepMother">http://sparql.cwrc.ca/ontologies/cwrc#hasStepMother</seealso>
    let hasStepMother = Prefixed_Name(cwrc, "hasStepMother") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepMotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>stepmother of</para><para>belle-mère de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepMotherOf">http://sparql.cwrc.ca/ontologies/cwrc#stepMotherOf</seealso>
    let stepMotherOf = Prefixed_Name(cwrc, "stepMotherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepSister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepsister</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepSister">http://sparql.cwrc.ca/ontologies/cwrc#hasStepSister</seealso>
    let hasStepSister = Prefixed_Name(cwrc, "hasStepSister") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepSon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepson</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepSon">http://sparql.cwrc.ca/ontologies/cwrc#hasStepSon</seealso>
    let hasStepSon = Prefixed_Name(cwrc, "hasStepSon") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasTimeCertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>has time certainty</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasTimeCertainty">http://sparql.cwrc.ca/ontologies/cwrc#hasTimeCertainty</seealso>
    let hasTimeCertainty = Prefixed_Name(cwrc, "hasTimeCertainty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasUncle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has uncle</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasUncle">http://sparql.cwrc.ca/ontologies/cwrc#hasUncle</seealso>
    let hasUncle = Prefixed_Name(cwrc, "hasUncle") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasVistor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has vistor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasVistor">http://sparql.cwrc.ca/ontologies/cwrc#hasVistor</seealso>
    let hasVistor = Prefixed_Name(cwrc, "hasVistor") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasVolunteerOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has volunteer occupation</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasVolunteerOccupation">http://sparql.cwrc.ca/ontologies/cwrc#hasVolunteerOccupation</seealso>
    let hasVolunteerOccupation =
        Prefixed_Name(cwrc, "hasVolunteerOccupation") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:volunteerOccupationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>volunteer occupation of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#volunteerOccupationOf">http://sparql.cwrc.ca/ontologies/cwrc#volunteerOccupationOf</seealso>
    let volunteerOccupationOf =
        Prefixed_Name(cwrc, "volunteerOccupationOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasWife</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has wife</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasWife">http://sparql.cwrc.ca/ontologies/cwrc#hasWife</seealso>
    let hasWife = Prefixed_Name(cwrc, "hasWife") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:headOfState</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>head of state</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#headOfState">http://sparql.cwrc.ca/ontologies/cwrc#headOfState</seealso>
    let headOfState = Prefixed_Name(cwrc, "headOfState") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:highChurchParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>High Church Party</para><para>Haute Église</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#highChurchParty">http://sparql.cwrc.ca/ontologies/cwrc#highChurchParty</seealso>
    let highChurchParty = Prefixed_Name(cwrc, "highChurchParty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:highToryism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>High Toryism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#highToryism">http://sparql.cwrc.ca/ontologies/cwrc#highToryism</seealso>
    let highToryism = Prefixed_Name(cwrc, "highToryism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hinduism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>yin tu chiao</para><para>yin du jiao</para><para>yìn dù jiào</para><para>hindouisme</para><para>Hindoeïsme</para><para>Hinduismo</para><para>Hinduism</para><para>Hindou</para><para>印度教</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hinduism">http://sparql.cwrc.ca/ontologies/cwrc#hinduism</seealso>
    let hinduism = Prefixed_Name(cwrc, "hinduism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:historian</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>historian</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#historian">http://sparql.cwrc.ca/ontologies/cwrc#historian</seealso>
    let historian = Prefixed_Name(cwrc, "historian") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:homeRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Home Rule</para><para>Home rule</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#homeRule">http://sparql.cwrc.ca/ontologies/cwrc#homeRule</seealso>
    let homeRule = Prefixed_Name(cwrc, "homeRule") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:homosexual</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Sexuality</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>homosexualité</para><para>homosexuality</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#homosexual">http://sparql.cwrc.ca/ontologies/cwrc#homosexual</seealso>
    let homosexual = Prefixed_Name(cwrc, "homosexual") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:honoraryDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Doctorat honoris causa</para><para>honorary degree</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#honoraryDegree">http://sparql.cwrc.ca/ontologies/cwrc#honoraryDegree</seealso>
    let honoraryDegree = Prefixed_Name(cwrc, "honoraryDegree") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hospitality</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>hospitality</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hospitality">http://sparql.cwrc.ca/ontologies/cwrc#hospitality</seealso>
    let hospitality = Prefixed_Name(cwrc, "hospitality") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:linguist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>linguist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#linguist">http://sparql.cwrc.ca/ontologies/cwrc#linguist</seealso>
    let linguist = Prefixed_Name(cwrc, "linguist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:literalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver sans équivalence.</para>
    ///   <para>Deprecated, with no current equivalence.</para>
    /// labels<para>a une forme littérale</para><para>has literal form</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literalForm">http://sparql.cwrc.ca/ontologies/cwrc#literalForm</seealso>
    let literalForm = Prefixed_Name(cwrc, "literalForm") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:literaryAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>literary agent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryAgent">http://sparql.cwrc.ca/ontologies/cwrc#literaryAgent</seealso>
    let literaryAgent = Prefixed_Name(cwrc, "literaryAgent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:literaryAssistant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>literary assistant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryAssistant">http://sparql.cwrc.ca/ontologies/cwrc#literaryAssistant</seealso>
    let literaryAssistant = Prefixed_Name(cwrc, "literaryAssistant") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:literaryConservationist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>literary conservationist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryConservationist">http://sparql.cwrc.ca/ontologies/cwrc#literaryConservationist</seealso>
    let literaryConservationist =
        Prefixed_Name(cwrc, "literaryConservationist") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:literaryExecutor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>literary executor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryExecutor">http://sparql.cwrc.ca/ontologies/cwrc#literaryExecutor</seealso>
    let literaryExecutor = Prefixed_Name(cwrc, "literaryExecutor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:literaryForger</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>literary forger</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryForger">http://sparql.cwrc.ca/ontologies/cwrc#literaryForger</seealso>
    let literaryForger = Prefixed_Name(cwrc, "literaryForger") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:literaryPrizeAdjudicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>literary prize adjudicator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryPrizeAdjudicator">http://sparql.cwrc.ca/ontologies/cwrc#literaryPrizeAdjudicator</seealso>
    let literaryPrizeAdjudicator =
        Prefixed_Name(cwrc, "literaryPrizeAdjudicator") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:lithographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>lithographer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lithographer">http://sparql.cwrc.ca/ontologies/cwrc#lithographer</seealso>
    let lithographer = Prefixed_Name(cwrc, "lithographer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:litigant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>litigant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#litigant">http://sparql.cwrc.ca/ontologies/cwrc#litigant</seealso>
    let litigant = Prefixed_Name(cwrc, "litigant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lobbyist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>lobbyist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lobbyist">http://sparql.cwrc.ca/ontologies/cwrc#lobbyist</seealso>
    let lobbyist = Prefixed_Name(cwrc, "lobbyist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:localGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>local government</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#localGovernment">http://sparql.cwrc.ca/ontologies/cwrc#localGovernment</seealso>
    let localGovernment = Prefixed_Name(cwrc, "localGovernment") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:locationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>location Of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#locationOf">http://sparql.cwrc.ca/ontologies/cwrc#locationOf</seealso>
    let locationOf = Prefixed_Name(cwrc, "locationOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:logger</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>logger</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#logger">http://sparql.cwrc.ca/ontologies/cwrc#logger</seealso>
    let logger = Prefixed_Name(cwrc, "logger") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lollards</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#lollardy" title="#lollardy"&gt;Lollardy&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#lollardy" title="#lollardy"&gt;Lollardy&lt;/a&gt;.</para>
    /// labels<para>Lollards</para><para>Lollards</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lollards">http://sparql.cwrc.ca/ontologies/cwrc#lollards</seealso>
    let lollards = Prefixed_Name(cwrc, "lollards") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lollardy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Lollardy</para><para>Lollardy</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lollardy">http://sparql.cwrc.ca/ontologies/cwrc#lollardy</seealso>
    let lollardy = Prefixed_Name(cwrc, "lollardy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lordChamberlain</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>lord chamberlain</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lordChamberlain">http://sparql.cwrc.ca/ontologies/cwrc#lordChamberlain</seealso>
    let lordChamberlain = Prefixed_Name(cwrc, "lordChamberlain") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lordChancellor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>lord chancellor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lordChancellor">http://sparql.cwrc.ca/ontologies/cwrc#lordChancellor</seealso>
    let lordChancellor = Prefixed_Name(cwrc, "lordChancellor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lowCertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Certainty</para>
    ///
    /// labels<para>faible probabilité</para><para>low certainty</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lowCertainty">http://sparql.cwrc.ca/ontologies/cwrc#lowCertainty</seealso>
    let lowCertainty = Prefixed_Name(cwrc, "lowCertainty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lowerMiddleClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>classe moyenne inférieure</para><para>lower-middle class</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lowerMiddleClass">http://sparql.cwrc.ca/ontologies/cwrc#lowerMiddleClass</seealso>
    let lowerMiddleClass = Prefixed_Name(cwrc, "lowerMiddleClass") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:middleClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>classe moyenne</para><para>middle class</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#middleClass">http://sparql.cwrc.ca/ontologies/cwrc#middleClass</seealso>
    let middleClass = Prefixed_Name(cwrc, "middleClass") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:machineWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>machineWork</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#machineWork">http://sparql.cwrc.ca/ontologies/cwrc#machineWork</seealso>
    let machineWork = Prefixed_Name(cwrc, "machineWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:optician</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>optician</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#optician">http://sparql.cwrc.ca/ontologies/cwrc#optician</seealso>
    let optician = Prefixed_Name(cwrc, "optician") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:orderly</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>orderly</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#orderly">http://sparql.cwrc.ca/ontologies/cwrc#orderly</seealso>
    let orderly = Prefixed_Name(cwrc, "orderly") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:orphanageWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>orphanage work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#orphanageWork">http://sparql.cwrc.ca/ontologies/cwrc#orphanageWork</seealso>
    let orphanageWork = Prefixed_Name(cwrc, "orphanageWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socialWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>social work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialWork">http://sparql.cwrc.ca/ontologies/cwrc#socialWork</seealso>
    let socialWork = Prefixed_Name(cwrc, "socialWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pacifist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>pacifist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pacifist">http://sparql.cwrc.ca/ontologies/cwrc#pacifist</seealso>
    let pacifist = Prefixed_Name(cwrc, "pacifist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pagan</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#paganism" title="#paganism"&gt;Paganism&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#paganism" title="#paganism"&gt;Paganisme&lt;/a&gt;.</para>
    /// labels<para>païen (ou payen)</para><para>Pagan</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pagan">http://sparql.cwrc.ca/ontologies/cwrc#pagan</seealso>
    let pagan = Prefixed_Name(cwrc, "pagan") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:paganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Paganisme</para><para>Paganism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#paganism">http://sparql.cwrc.ca/ontologies/cwrc#paganism</seealso>
    let paganism = Prefixed_Name(cwrc, "paganism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pantheism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>panthéisme</para><para>pantheism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pantheism">http://sparql.cwrc.ca/ontologies/cwrc#pantheism</seealso>
    let pantheism = Prefixed_Name(cwrc, "pantheism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:parishWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>parish work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#parishWork">http://sparql.cwrc.ca/ontologies/cwrc#parishWork</seealso>
    let parishWork = Prefixed_Name(cwrc, "parishWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:parliamentarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>parliamentarianism</para><para>parlementarisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#parliamentarianism">http://sparql.cwrc.ca/ontologies/cwrc#parliamentarianism</seealso>
    let parliamentarianism = Prefixed_Name(cwrc, "parliamentarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sailor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>sailor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sailor">http://sparql.cwrc.ca/ontologies/cwrc#sailor</seealso>
    let sailor = Prefixed_Name(cwrc, "sailor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:saint</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>saint</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#saint">http://sparql.cwrc.ca/ontologies/cwrc#saint</seealso>
    let saint = Prefixed_Name(cwrc, "saint") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:salesperson</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>salesperson</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#salesperson">http://sparql.cwrc.ca/ontologies/cwrc#salesperson</seealso>
    let salesperson = Prefixed_Name(cwrc, "salesperson") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:salter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>salter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#salter">http://sparql.cwrc.ca/ontologies/cwrc#salter</seealso>
    let salter = Prefixed_Name(cwrc, "salter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sanitaryMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement pour l'assainissement</para><para>sanitary movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sanitaryMovement">http://sparql.cwrc.ca/ontologies/cwrc#sanitaryMovement</seealso>
    let sanitaryMovement = Prefixed_Name(cwrc, "sanitaryMovement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:urbanReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>renouvellement urbain</para><para>urban reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#urbanReform">http://sparql.cwrc.ca/ontologies/cwrc#urbanReform</seealso>
    let urbanReform = Prefixed_Name(cwrc, "urbanReform") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:saxonNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalIdentity</para>
    ///
    /// labels<para>Saxon</para><para>Saxon</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#saxonNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#saxonNationalIdentity</seealso>
    let saxonNationalIdentity =
        Prefixed_Name(cwrc, "saxonNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:scottishNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Nationalisme écossais</para><para>Scottish nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#scottishNationalism">http://sparql.cwrc.ca/ontologies/cwrc#scottishNationalism</seealso>
    let scottishNationalism = Prefixed_Name(cwrc, "scottishNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:scottishRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Scottish</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#scottishRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#scottishRaceColour</seealso>
    let scottishRaceColour = Prefixed_Name(cwrc, "scottishRaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:seaCaptain</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>sea captain</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#seaCaptain">http://sparql.cwrc.ca/ontologies/cwrc#seaCaptain</seealso>
    let seaCaptain = Prefixed_Name(cwrc, "seaCaptain") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:secondarySchoolDiploma</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///
    /// labels<para>secondary school diploma</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#secondarySchoolDiploma">http://sparql.cwrc.ca/ontologies/cwrc#secondarySchoolDiploma</seealso>
    let secondarySchoolDiploma =
        Prefixed_Name(cwrc, "secondarySchoolDiploma") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:seekers</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Seekers</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#seekers">http://sparql.cwrc.ca/ontologies/cwrc#seekers</seealso>
    let seekers = Prefixed_Name(cwrc, "seekers") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:separatism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>indépendantisme</para><para>separatism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#separatism">http://sparql.cwrc.ca/ontologies/cwrc#separatism</seealso>
    let separatism = Prefixed_Name(cwrc, "separatism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sephardicJewishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Sephardic Jewish</para><para>Juif séfarade</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sephardicJewishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#sephardicJewishEthnicity</seealso>
    let sephardicJewishEthnicity =
        Prefixed_Name(cwrc, "sephardicJewishEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sephardicJewishNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sephardic Jewish</para><para>Séfarade</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sephardicJewishNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#sephardicJewishNationalIdentity</seealso>
    let sephardicJewishNationalIdentity =
        Prefixed_Name(cwrc, "sephardicJewishNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:servants</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>domestique</para><para>servant</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#servants">http://sparql.cwrc.ca/ontologies/cwrc#servants</seealso>
    let servants = Prefixed_Name(cwrc, "servants") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:server</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>server</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#server">http://sparql.cwrc.ca/ontologies/cwrc#server</seealso>
    let server = Prefixed_Name(cwrc, "server") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063">http://sparql.cwrc.ca/ontologies/cwrc#2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063</seealso>
    let _2002eb96_4775_4ae0_ba0f_6704c30264a9_8d87593063 =
        Prefixed_Name(cwrc, "2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7b624412-74a3-4560-a038-d59b747ee9c7-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7b624412-74a3-4560-a038-d59b747ee9c7-partof">http://sparql.cwrc.ca/ontologies/cwrc#7b624412-74a3-4560-a038-d59b747ee9c7-partof</seealso>
    let _7b624412_74a3_4560_a038_d59b747ee9c7_partof =
        Prefixed_Name(cwrc, "7b624412-74a3-4560-a038-d59b747ee9c7-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anglo-IrishRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Anglo-irlandais</para><para>Anglo-Irish</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishRaceColour</seealso>
    let anglo_IrishRaceColour =
        Prefixed_Name(cwrc, "anglo-IrishRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:credentialSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>credential subject of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#credentialSubjectOf">http://sparql.cwrc.ca/ontologies/cwrc#credentialSubjectOf</seealso>
    let credentialSubjectOf = Prefixed_Name(cwrc, "credentialSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cricket</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>cricket</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cricket">http://sparql.cwrc.ca/ontologies/cwrc#cricket</seealso>
    let cricket = Prefixed_Name(cwrc, "cricket") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:critic</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>critic</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#critic">http://sparql.cwrc.ca/ontologies/cwrc#critic</seealso>
    let critic = Prefixed_Name(cwrc, "critic") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:culturalFormOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>cultural form of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#culturalFormOf">http://sparql.cwrc.ca/ontologies/cwrc#culturalFormOf</seealso>
    let culturalFormOf = Prefixed_Name(cwrc, "culturalFormOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasCulturalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une forme culturelle</para><para>has a cultural form</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCulturalForm">http://sparql.cwrc.ca/ontologies/cwrc#hasCulturalForm</seealso>
    let hasCulturalForm = Prefixed_Name(cwrc, "hasCulturalForm") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cyclist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>bicyclist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cyclist">http://sparql.cwrc.ca/ontologies/cwrc#cyclist</seealso>
    let cyclist = Prefixed_Name(cwrc, "cyclist") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d596c4a0-ecaf-4739-8a58-3e0af7dba4c7</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7">http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7</seealso>
    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7 =
        Prefixed_Name(cwrc, "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf">http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf</seealso>
    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_cf7aa6a7bf =
        Prefixed_Name(cwrc, "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4">http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4</seealso>
    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_706552b3f4 =
        Prefixed_Name(cwrc, "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94">http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94</seealso>
    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_42d9d30d94 =
        Prefixed_Name(cwrc, "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:equineActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>equine activity</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#equineActivity">http://sparql.cwrc.ca/ontologies/cwrc#equineActivity</seealso>
    let equineActivity = Prefixed_Name(cwrc, "equineActivity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une récompense</para><para>has award</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasAward">http://sparql.cwrc.ca/ontologies/cwrc#hasAward</seealso>
    let hasAward = Prefixed_Name(cwrc, "hasAward") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:literaryScholar</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>literary scholar</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#literaryScholar">http://sparql.cwrc.ca/ontologies/cwrc#literaryScholar</seealso>
    let literaryScholar = Prefixed_Name(cwrc, "literaryScholar") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:obeah</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Obeah</para><para>Obeah</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#obeah">http://sparql.cwrc.ca/ontologies/cwrc#obeah</seealso>
    let obeah = Prefixed_Name(cwrc, "obeah") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:occultism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>occultism/theosophism</para><para>occultisme</para><para>occultism</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#occultism">http://sparql.cwrc.ca/ontologies/cwrc#occultism</seealso>
    let occultism = Prefixed_Name(cwrc, "occultism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:onlyChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:BirthPosition</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>enfant unique</para><para>only child</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#onlyChild">http://sparql.cwrc.ca/ontologies/cwrc#onlyChild</seealso>
    let onlyChild = Prefixed_Name(cwrc, "onlyChild") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:oppositionPolitics</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>opposition (politique)</para><para>opposition politics</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#oppositionPolitics">http://sparql.cwrc.ca/ontologies/cwrc#oppositionPolitics</seealso>
    let oppositionPolitics = Prefixed_Name(cwrc, "oppositionPolitics") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:workingClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>classe ouvrière</para><para>working class</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#workingClass">http://sparql.cwrc.ca/ontologies/cwrc#workingClass</seealso>
    let workingClass = Prefixed_Name(cwrc, "workingClass") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:consultant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>consultant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#consultant">http://sparql.cwrc.ca/ontologies/cwrc#consultant</seealso>
    let consultant = Prefixed_Name(cwrc, "consultant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:coopOrganizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>co-op organizer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#coopOrganizer">http://sparql.cwrc.ca/ontologies/cwrc#coopOrganizer</seealso>
    let coopOrganizer = Prefixed_Name(cwrc, "coopOrganizer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepBrother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepbrother</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepBrother">http://sparql.cwrc.ca/ontologies/cwrc#hasStepBrother</seealso>
    let hasStepBrother = Prefixed_Name(cwrc, "hasStepBrother") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:naturalReligion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Natural Religion</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#naturalReligion">http://sparql.cwrc.ca/ontologies/cwrc#naturalReligion</seealso>
    let naturalReligion = Prefixed_Name(cwrc, "naturalReligion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:rationalDissenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#dissentingChristianity" title="#dissentingChristianity"&gt;Dissidence anglaise&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#dissentingChristianity" title="#dissentingChristianity"&gt;Dissenting Christianity&lt;/a&gt;.</para>
    /// labels<para>Rational Dissenter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#rationalDissenter">http://sparql.cwrc.ca/ontologies/cwrc#rationalDissenter</seealso>
    let rationalDissenter = Prefixed_Name(cwrc, "rationalDissenter") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:21bad544-af11-4b8d-869f-2d26f53943c8</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8">http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8</seealso>
    let _21bad544_af11_4b8d_869f_2d26f53943c8 =
        Prefixed_Name(cwrc, "21bad544-af11-4b8d-869f-2d26f53943c8") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8">http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8</seealso>
    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58_cdc9f758b8 =
        Prefixed_Name(cwrc, "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96">http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96</seealso>
    let _23ad5d2a_605e_4116_8f81_7db6b95395ea_7d8f197f96 =
        Prefixed_Name(cwrc, "23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof">http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof</seealso>
    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof =
        Prefixed_Name(cwrc, "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ComprehensiveSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>comprehensive school</para><para>école</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ComprehensiveSchool">http://sparql.cwrc.ca/ontologies/cwrc#ComprehensiveSchool</seealso>
    let ComprehensiveSchool = Prefixed_Name(cwrc, "ComprehensiveSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Credential</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>credential</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Credential">http://sparql.cwrc.ca/ontologies/cwrc#Credential</seealso>
    let Credential = Prefixed_Name(cwrc, "Credential") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:CulturalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>forme culturelle</para><para>cultural form</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalForm">http://sparql.cwrc.ca/ontologies/cwrc#CulturalForm</seealso>
    let CulturalForm = Prefixed_Name(cwrc, "CulturalForm") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:WomensHealthContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>women's health context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#WomensHealthContext">http://sparql.cwrc.ca/ontologies/cwrc#WomensHealthContext</seealso>
    let WomensHealthContext = Prefixed_Name(cwrc, "WomensHealthContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Trade-Unionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>opposition au syndicalisme</para><para>anti-trade-unionism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Trade-Unionism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Trade-Unionism</seealso>
    let anti_Trade_Unionism = Prefixed_Name(cwrc, "anti-Trade-Unionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:labourMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Mouvement ouvrier</para><para>labour movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#labourMovement">http://sparql.cwrc.ca/ontologies/cwrc#labourMovement</seealso>
    let labourMovement = Prefixed_Name(cwrc, "labourMovement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:libertarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Libertarianisme</para><para>Libertarianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#libertarianism">http://sparql.cwrc.ca/ontologies/cwrc#libertarianism</seealso>
    let libertarianism = Prefixed_Name(cwrc, "libertarianism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd">http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd</seealso>
    let e053e9f1_37ea_407d_b0cd_caaf413c142e_a521eafbdd =
        Prefixed_Name(cwrc, "e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9">http://sparql.cwrc.ca/ontologies/cwrc#e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9</seealso>
    let e053e9f1_37ea_407d_b0cd_caaf413c142e_63a2ae33d9 =
        Prefixed_Name(cwrc, "e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:feministInternationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>féminisme internationaliste</para><para>feminist internationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#feministInternationalism">http://sparql.cwrc.ca/ontologies/cwrc#feministInternationalism</seealso>
    let feministInternationalism =
        Prefixed_Name(cwrc, "feministInternationalism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:internationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Internationalisme institutionnel</para><para>internationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#internationalism">http://sparql.cwrc.ca/ontologies/cwrc#internationalism</seealso>
    let internationalism = Prefixed_Name(cwrc, "internationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fifthMonarchists</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Cinquièmes Monarchistes</para><para>Fifth Monarchists</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fifthMonarchists">http://sparql.cwrc.ca/ontologies/cwrc#fifthMonarchists</seealso>
    let fifthMonarchists = Prefixed_Name(cwrc, "fifthMonarchists") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:millenarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>millénarisme, ou chiliasme</para><para>millenarianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#millenarianism">http://sparql.cwrc.ca/ontologies/cwrc#millenarianism</seealso>
    let millenarianism = Prefixed_Name(cwrc, "millenarianism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNationalitySelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has national identity (self-reported)</para><para>de nationalité (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalitySelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasNationalitySelfReported</seealso>
    let hasNationalitySelfReported =
        Prefixed_Name(cwrc, "hasNationalitySelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nationalitySelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>national identity (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nationalitySelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#nationalitySelfReportedOf</seealso>
    let nationalitySelfReportedOf =
        Prefixed_Name(cwrc, "nationalitySelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNativeLinguisticAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>natively known language</para><para>langue native</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbility">http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbility</seealso>
    let hasNativeLinguisticAbility =
        Prefixed_Name(cwrc, "hasNativeLinguisticAbility") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nativeLinguisticAbilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>natively known language of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityOf">http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityOf</seealso>
    let nativeLinguisticAbilityOf =
        Prefixed_Name(cwrc, "nativeLinguisticAbilityOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNativeLinguisticAbilityReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>natively known language (reported)</para><para>langue native (déclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilityReported">http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilityReported</seealso>
    let hasNativeLinguisticAbilityReported =
        Prefixed_Name(cwrc, "hasNativeLinguisticAbilityReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:metalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>metal work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#metalWork">http://sparql.cwrc.ca/ontologies/cwrc#metalWork</seealso>
    let metalWork = Prefixed_Name(cwrc, "metalWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:plymouthBrethren</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Frères de Schwarzenau</para><para>Assemblées de Frères</para><para>Plymouth Brethren</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#plymouthBrethren">http://sparql.cwrc.ca/ontologies/cwrc#plymouthBrethren</seealso>
    let plymouthBrethren = Prefixed_Name(cwrc, "plymouthBrethren") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:poetLaureate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>poet laureate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#poetLaureate">http://sparql.cwrc.ca/ontologies/cwrc#poetLaureate</seealso>
    let poetLaureate = Prefixed_Name(cwrc, "poetLaureate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:spinner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>spinner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#spinner">http://sparql.cwrc.ca/ontologies/cwrc#spinner</seealso>
    let spinner = Prefixed_Name(cwrc, "spinner") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:21bad544-af11-4b8d-869f-2d26f53943c8-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8-partof">http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8-partof</seealso>
    let _21bad544_af11_4b8d_869f_2d26f53943c8_partof =
        Prefixed_Name(cwrc, "21bad544-af11-4b8d-869f-2d26f53943c8-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:825995b3-3b66-4e0a-a62d-d8649aaead78</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78">http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78</seealso>
    let _825995b3_3b66_4e0a_a62d_d8649aaead78 =
        Prefixed_Name(cwrc, "825995b3-3b66-4e0a-a62d-d8649aaead78") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8f9744a7-4861-4bd3-a956-e4aab75b7e77</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77">http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77</seealso>
    let _8f9744a7_4861_4bd3_a956_e4aab75b7e77 =
        Prefixed_Name(cwrc, "8f9744a7-4861-4bd3-a956-e4aab75b7e77") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97">http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97</seealso>
    let _8f9744a7_4861_4bd3_a956_e4aab75b7e77_010dabac97 =
        Prefixed_Name(cwrc, "8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99">http://sparql.cwrc.ca/ontologies/cwrc#8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99</seealso>
    let _8fd7cfcc_7613_4c1c_af44_798d6a3dca4c_e2ba549b99 =
        Prefixed_Name(cwrc, "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:businessOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>business owner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#businessOwner">http://sparql.cwrc.ca/ontologies/cwrc#businessOwner</seealso>
    let businessOwner = Prefixed_Name(cwrc, "businessOwner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:butcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>butcher</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#butcher">http://sparql.cwrc.ca/ontologies/cwrc#butcher</seealso>
    let butcher = Prefixed_Name(cwrc, "butcher") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:secularism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>secularism</para><para>Laïcité</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#secularism">http://sparql.cwrc.ca/ontologies/cwrc#secularism</seealso>
    let secularism = Prefixed_Name(cwrc, "secularism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:AbiLemak</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#AbiLemak">http://sparql.cwrc.ca/ontologies/cwrc#AbiLemak</seealso>
    let AbiLemak = Prefixed_Name(cwrc, "AbiLemak") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:daughterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>daughter of</para><para>fille de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#daughterOf">http://sparql.cwrc.ca/ontologies/cwrc#daughterOf</seealso>
    let daughterOf = Prefixed_Name(cwrc, "daughterOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasDaughter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has daughter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasDaughter">http://sparql.cwrc.ca/ontologies/cwrc#hasDaughter</seealso>
    let hasDaughter = Prefixed_Name(cwrc, "hasDaughter") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:db2f8571-a773-4068-a35f-34262950bb8f</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#db2f8571-a773-4068-a35f-34262950bb8f">http://sparql.cwrc.ca/ontologies/cwrc#db2f8571-a773-4068-a35f-34262950bb8f</seealso>
    let db2f8571_a773_4068_a35f_34262950bb8f =
        Prefixed_Name(cwrc, "db2f8571-a773-4068-a35f-34262950bb8f") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:db2f8571-a773-4068-a35f-34262950bb8f-9841babf77</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#db2f8571-a773-4068-a35f-34262950bb8f-9841babf77">http://sparql.cwrc.ca/ontologies/cwrc#db2f8571-a773-4068-a35f-34262950bb8f-9841babf77</seealso>
    let db2f8571_a773_4068_a35f_34262950bb8f_9841babf77 =
        Prefixed_Name(cwrc, "db2f8571-a773-4068-a35f-34262950bb8f-9841babf77") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d">http://sparql.cwrc.ca/ontologies/cwrc#db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d</seealso>
    let db3de175_7d4a_4860_908b_a905b9cc9b07_9eccf82c6d =
        Prefixed_Name(cwrc, "db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:deathDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>death date of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#deathDateOf">http://sparql.cwrc.ca/ontologies/cwrc#deathDateOf</seealso>
    let deathDateOf = Prefixed_Name(cwrc, "deathDateOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasDeathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has death date</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasDeathDate">http://sparql.cwrc.ca/ontologies/cwrc#hasDeathDate</seealso>
    let hasDeathDate = Prefixed_Name(cwrc, "hasDeathDate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:deism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>déisme</para><para>deism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#deism">http://sparql.cwrc.ca/ontologies/cwrc#deism</seealso>
    let deism = Prefixed_Name(cwrc, "deism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:deliveryPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>delivery person</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#deliveryPerson">http://sparql.cwrc.ca/ontologies/cwrc#deliveryPerson</seealso>
    let deliveryPerson = Prefixed_Name(cwrc, "deliveryPerson") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:democrat</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>democrat</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#democrat">http://sparql.cwrc.ca/ontologies/cwrc#democrat</seealso>
    let democrat = Prefixed_Name(cwrc, "democrat") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc">http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc</seealso>
    let fab56e35_9796_4e6d_861d_a6b626f5714d_partof_534915cfcc =
        Prefixed_Name(cwrc, "fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352">http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352</seealso>
    let fab56e35_9796_4e6d_861d_a6b626f5714d_partof_1dda925352 =
        Prefixed_Name(cwrc, "fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:faithHealing</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>faith healing</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#faithHealing">http://sparql.cwrc.ca/ontologies/cwrc#faithHealing</seealso>
    let faithHealing = Prefixed_Name(cwrc, "faithHealing") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:familyBasedOccupationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>family-based occupation of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#familyBasedOccupationOf">http://sparql.cwrc.ca/ontologies/cwrc#familyBasedOccupationOf</seealso>
    let familyBasedOccupationOf =
        Prefixed_Name(cwrc, "familyBasedOccupationOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:occupationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>occupation of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#occupationOf">http://sparql.cwrc.ca/ontologies/cwrc#occupationOf</seealso>
    let occupationOf = Prefixed_Name(cwrc, "occupationOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fashion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>fashion</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fashion">http://sparql.cwrc.ca/ontologies/cwrc#fashion</seealso>
    let fashion = Prefixed_Name(cwrc, "fashion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fatalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>fatalisme</para><para>fatalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fatalism">http://sparql.cwrc.ca/ontologies/cwrc#fatalism</seealso>
    let fatalism = Prefixed_Name(cwrc, "fatalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fatherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>father of</para><para>père de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fatherOf">http://sparql.cwrc.ca/ontologies/cwrc#fatherOf</seealso>
    let fatherOf = Prefixed_Name(cwrc, "fatherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:parentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>parent de</para><para>parent of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#parentOf">http://sparql.cwrc.ca/ontologies/cwrc#parentOf</seealso>
    let parentOf = Prefixed_Name(cwrc, "parentOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has father</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasFather">http://sparql.cwrc.ca/ontologies/cwrc#hasFather</seealso>
    let hasFather = Prefixed_Name(cwrc, "hasFather") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fellow</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>fellow</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fellow">http://sparql.cwrc.ca/ontologies/cwrc#fellow</seealso>
    let fellow = Prefixed_Name(cwrc, "fellow") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:feministAnti-ViolenceActivism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>feminist anti-violence activism</para><para>féminisme contre la violence</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#feministAnti-ViolenceActivism">http://sparql.cwrc.ca/ontologies/cwrc#feministAnti-ViolenceActivism</seealso>
    let feministAnti_ViolenceActivism =
        Prefixed_Name(cwrc, "feministAnti-ViolenceActivism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:feministPacifism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>féminisme pacifiste</para><para>feminist pacifism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#feministPacifism">http://sparql.cwrc.ca/ontologies/cwrc#feministPacifism</seealso>
    let feministPacifism = Prefixed_Name(cwrc, "feministPacifism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ffd10388-4cd6-429c-9ca0-b4d9476496a1</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1">http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1</seealso>
    let ffd10388_4cd6_429c_9ca0_b4d9476496a1 =
        Prefixed_Name(cwrc, "ffd10388-4cd6-429c-9ca0-b4d9476496a1") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311">http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311</seealso>
    let ffd10388_4cd6_429c_9ca0_b4d9476496a1_e7a6810311 =
        Prefixed_Name(cwrc, "ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c">http://sparql.cwrc.ca/ontologies/cwrc#ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c</seealso>
    let ffd10388_4cd6_429c_9ca0_b4d9476496a1_16ff462e2c =
        Prefixed_Name(cwrc, "ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:filmIndustry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>film industry</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#filmIndustry">http://sparql.cwrc.ca/ontologies/cwrc#filmIndustry</seealso>
    let filmIndustry = Prefixed_Name(cwrc, "filmIndustry") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:investor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>investor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#investor">http://sparql.cwrc.ca/ontologies/cwrc#investor</seealso>
    let investor = Prefixed_Name(cwrc, "investor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:firefighter</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>firefighter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#firefighter">http://sparql.cwrc.ca/ontologies/cwrc#firefighter</seealso>
    let firefighter = Prefixed_Name(cwrc, "firefighter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:firstAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>first aid</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#firstAid">http://sparql.cwrc.ca/ontologies/cwrc#firstAid</seealso>
    let firstAid = Prefixed_Name(cwrc, "firstAid") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fisherman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>fisherman</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fisherman">http://sparql.cwrc.ca/ontologies/cwrc#fisherman</seealso>
    let fisherman = Prefixed_Name(cwrc, "fisherman") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:fishmonger</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>fishmonger</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fishmonger">http://sparql.cwrc.ca/ontologies/cwrc#fishmonger</seealso>
    let fishmonger = Prefixed_Name(cwrc, "fishmonger") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:flemishNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Flemish</para><para>Flandre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#flemishNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#flemishNationalHeritage</seealso>
    let flemishNationalHeritage =
        Prefixed_Name(cwrc, "flemishNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNativeLinguisticAbilitySelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasLinguisticAbilitySelfReported" title="#hasLinguisticAbilitySelfReported"&gt;maîtrise une langue (autodéclaré)&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasLinguisticAbilitySelfReported" title="#hasLinguisticAbilitySelfReported"&gt;language known (self-reported)&lt;/a&gt;.</para>
    /// labels<para>natively known language (self declared)</para><para>a une langue maternelle (autodéclaré)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilitySelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilitySelfDeclared</seealso>
    let hasNativeLinguisticAbilitySelfDeclared =
        Prefixed_Name(cwrc, "hasNativeLinguisticAbilitySelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNativeLinguisticAbilitySelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>natively known language (self-reported)</para><para>langue native (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilitySelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilitySelfReported</seealso>
    let hasNativeLinguisticAbilitySelfReported =
        Prefixed_Name(cwrc, "hasNativeLinguisticAbilitySelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nativeLinguisticAbilitySelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>natively known language (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilitySelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilitySelfReportedOf</seealso>
    let nativeLinguisticAbilitySelfReportedOf =
        Prefixed_Name(cwrc, "nativeLinguisticAbilitySelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNephew</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has nephew</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNephew">http://sparql.cwrc.ca/ontologies/cwrc#hasNephew</seealso>
    let hasNephew = Prefixed_Name(cwrc, "hasNephew") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasNiece</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has niece</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNiece">http://sparql.cwrc.ca/ontologies/cwrc#hasNiece</seealso>
    let hasNiece = Prefixed_Name(cwrc, "hasNiece") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNonEroticRelationshipWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has non-erotic relationship with</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNonEroticRelationshipWith">http://sparql.cwrc.ca/ontologies/cwrc#hasNonEroticRelationshipWith</seealso>
    let hasNonEroticRelationshipWith =
        Prefixed_Name(cwrc, "hasNonEroticRelationshipWith") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasOccupationIncome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has occupation income</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasOccupationIncome">http://sparql.cwrc.ca/ontologies/cwrc#hasOccupationIncome</seealso>
    let hasOccupationIncome = Prefixed_Name(cwrc, "hasOccupationIncome") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:occupationIncomeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>occupation income of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#occupationIncomeOf">http://sparql.cwrc.ca/ontologies/cwrc#occupationIncomeOf</seealso>
    let occupationIncomeOf = Prefixed_Name(cwrc, "occupationIncomeOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has organization</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasOrganization">http://sparql.cwrc.ca/ontologies/cwrc#hasOrganization</seealso>
    let hasOrganization = Prefixed_Name(cwrc, "hasOrganization") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasPaidOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has paid occupation</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPaidOccupation">http://sparql.cwrc.ca/ontologies/cwrc#hasPaidOccupation</seealso>
    let hasPaidOccupation = Prefixed_Name(cwrc, "hasPaidOccupation") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:paidOccupationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>paid occupation of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#paidOccupationOf">http://sparql.cwrc.ca/ontologies/cwrc#paidOccupationOf</seealso>
    let paidOccupationOf = Prefixed_Name(cwrc, "paidOccupationOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasPersona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has persona</para><para>a persona</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPersona">http://sparql.cwrc.ca/ontologies/cwrc#hasPersona</seealso>
    let hasPersona = Prefixed_Name(cwrc, "hasPersona") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPoliticalAffiliationReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has political affiliation (reported)</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationReported">http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationReported</seealso>
    let hasPoliticalAffiliationReported =
        Prefixed_Name(cwrc, "hasPoliticalAffiliationReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:politicalAffiliationReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>political affiliation (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationReportedOf</seealso>
    let politicalAffiliationReportedOf =
        Prefixed_Name(cwrc, "politicalAffiliationReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPoliticalAffiliationSelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une appartenance politique (autodéclarée)</para><para>has political affiliation (self-reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationSelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationSelfReported</seealso>
    let hasPoliticalAffiliationSelfReported =
        Prefixed_Name(cwrc, "hasPoliticalAffiliationSelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:politicalAffiliationSelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>political affiliation (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationSelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationSelfReportedOf</seealso>
    let politicalAffiliationSelfReportedOf =
        Prefixed_Name(cwrc, "politicalAffiliationSelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPoliticalInvolvementFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has political involvement from</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementFrom">http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementFrom</seealso>
    let hasPoliticalInvolvementFrom =
        Prefixed_Name(cwrc, "hasPoliticalInvolvementFrom") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPoliticalInvolvementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has political involvement in</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementIn">http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementIn</seealso>
    let hasPoliticalInvolvementIn =
        Prefixed_Name(cwrc, "hasPoliticalInvolvementIn") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPossiblyEroticRelationshipWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>has possibly erotic relationship with</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPossiblyEroticRelationshipWith">http://sparql.cwrc.ca/ontologies/cwrc#hasPossiblyEroticRelationshipWith</seealso>
    let hasPossiblyEroticRelationshipWith =
        Prefixed_Name(cwrc, "hasPossiblyEroticRelationshipWith") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has race or colour identity</para><para>est de race our couleur</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColour</seealso>
    let hasRaceColour = Prefixed_Name(cwrc, "hasRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:raceColourReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>race or colour identity (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#raceColourReportedOf</seealso>
    let raceColourReportedOf =
        Prefixed_Name(cwrc, "raceColourReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasRaceColourSelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasNationalitySelfReported" title="#hasNationalitySelfReported"&gt;de nationalité (autodéclarée)&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasNationalitySelfReported" title="#hasNationalitySelfReported"&gt;has national identity (self-reported)&lt;/a&gt;.</para>
    /// labels<para>est de race (autodéclarée)</para><para>has race (self declared)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourSelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourSelfDeclared</seealso>
    let hasRaceColourSelfDeclared =
        Prefixed_Name(cwrc, "hasRaceColourSelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Race</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Race">http://sparql.cwrc.ca/ontologies/cwrc#Race</seealso>
    let Race = Prefixed_Name(cwrc, "Race") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasRaceColourSelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has race or colour identity (self-reported)</para><para>race ou couleur (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourSelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourSelfReported</seealso>
    let hasRaceColourSelfReported =
        Prefixed_Name(cwrc, "hasRaceColourSelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:raceColourSelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>race or colour identity (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourSelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#raceColourSelfReportedOf</seealso>
    let raceColourSelfReportedOf =
        Prefixed_Name(cwrc, "raceColourSelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasReligion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has religious affiliation</para><para>est de confession</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligion">http://sparql.cwrc.ca/ontologies/cwrc#hasReligion</seealso>
    let hasReligion = Prefixed_Name(cwrc, "hasReligion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:religionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>religious affiliation of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#religionOf">http://sparql.cwrc.ca/ontologies/cwrc#religionOf</seealso>
    let religionOf = Prefixed_Name(cwrc, "religionOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasReligionReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has religious affiliation (reported)</para><para>religion (déclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionReported">http://sparql.cwrc.ca/ontologies/cwrc#hasReligionReported</seealso>
    let hasReligionReported = Prefixed_Name(cwrc, "hasReligionReported") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:religionReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>religious affiliation (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#religionReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#religionReportedOf</seealso>
    let religionReportedOf = Prefixed_Name(cwrc, "religionReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasReligionSelfDefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasReligionSelfReported" title="#hasReligionSelfReported"&gt;religion (autodéclarée)&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasReligionSelfReported" title="#hasReligionSelfReported"&gt;has religious affiliation (self-reported)&lt;/a&gt;.</para>
    /// labels<para>has religious affilication (self defined)</para><para>religion (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionSelfDefined">http://sparql.cwrc.ca/ontologies/cwrc#hasReligionSelfDefined</seealso>
    let hasReligionSelfDefined =
        Prefixed_Name(cwrc, "hasReligionSelfDefined") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasReligionSelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has religious affiliation (self-reported)</para><para>religion (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionSelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasReligionSelfReported</seealso>
    let hasReligionSelfReported =
        Prefixed_Name(cwrc, "hasReligionSelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:labourUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>labour union</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#labourUnion">http://sparql.cwrc.ca/ontologies/cwrc#labourUnion</seealso>
    let labourUnion = Prefixed_Name(cwrc, "labourUnion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ladyLiterateInArts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Lady Literate in the Arts</para><para>Lady Literate in Arts</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ladyLiterateInArts">http://sparql.cwrc.ca/ontologies/cwrc#ladyLiterateInArts</seealso>
    let ladyLiterateInArts = Prefixed_Name(cwrc, "ladyLiterateInArts") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:munitionsWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>munitions worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#munitionsWorker">http://sparql.cwrc.ca/ontologies/cwrc#munitionsWorker</seealso>
    let munitionsWorker = Prefixed_Name(cwrc, "munitionsWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>performer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#performer">http://sparql.cwrc.ca/ontologies/cwrc#performer</seealso>
    let performer = Prefixed_Name(cwrc, "performer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:musicologist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>musicologist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#musicologist">http://sparql.cwrc.ca/ontologies/cwrc#musicologist</seealso>
    let musicologist = Prefixed_Name(cwrc, "musicologist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mysticism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>mysticism</para><para>mystique</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mysticism">http://sparql.cwrc.ca/ontologies/cwrc#mysticism</seealso>
    let mysticism = Prefixed_Name(cwrc, "mysticism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:quakerism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Quakerism</para><para>quaker</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#quakerism">http://sparql.cwrc.ca/ontologies/cwrc#quakerism</seealso>
    let quakerism = Prefixed_Name(cwrc, "quakerism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:quakers</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#quakerism" title="#quakerism"&gt;Quakerism&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#quakerism" title="#quakerism"&gt;quaker&lt;/a&gt;.</para>
    /// labels<para>Quaker</para><para>quaker</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#quakers">http://sparql.cwrc.ca/ontologies/cwrc#quakers</seealso>
    let quakers = Prefixed_Name(cwrc, "quakers") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:unitarianChurch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#unitarianism" title="#unitarianism"&gt;Unitarianism&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#unitarianism" title="#unitarianism"&gt;unitarisme&lt;/a&gt;.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Église unitarienne</para><para>Unitarian Church</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#unitarianChurch">http://sparql.cwrc.ca/ontologies/cwrc#unitarianChurch</seealso>
    let unitarianChurch = Prefixed_Name(cwrc, "unitarianChurch") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:unitarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    /// labels<para>Unitarianism</para><para>unitarisme</para><para>unitarismo</para><para>unitarisme</para><para>unitarios</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#unitarianism">http://sparql.cwrc.ca/ontologies/cwrc#unitarianism</seealso>
    let unitarianism = Prefixed_Name(cwrc, "unitarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:universalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Universalist</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#universalist">http://sparql.cwrc.ca/ontologies/cwrc#universalist</seealso>
    let universalist = Prefixed_Name(cwrc, "universalist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:unknownCertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Certainty</para>
    ///
    /// labels<para>probabilité inconnue</para><para>unknown certainty</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#unknownCertainty">http://sparql.cwrc.ca/ontologies/cwrc#unknownCertainty</seealso>
    let unknownCertainty = Prefixed_Name(cwrc, "unknownCertainty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:unknownSex</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated with no current equivalence.</para>
    /// labels<para>Inconnue</para><para>Unknown</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#unknownSex">http://sparql.cwrc.ca/ontologies/cwrc#unknownSex</seealso>
    let unknownSex = Prefixed_Name(cwrc, "unknownSex") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:unskilledLabourer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>unskilled labourer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#unskilledLabourer">http://sparql.cwrc.ca/ontologies/cwrc#unskilledLabourer</seealso>
    let unskilledLabourer = Prefixed_Name(cwrc, "unskilledLabourer") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:unspecifiedReproductiveHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>unspecified</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#unspecifiedReproductiveHistory">http://sparql.cwrc.ca/ontologies/cwrc#unspecifiedReproductiveHistory</seealso>
    let unspecifiedReproductiveHistory =
        Prefixed_Name(cwrc, "unspecifiedReproductiveHistory") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:upholsterer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>upholsterer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#upholsterer">http://sparql.cwrc.ca/ontologies/cwrc#upholsterer</seealso>
    let upholsterer = Prefixed_Name(cwrc, "upholsterer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:upper-middleClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>This term is a CWRC-specific addition not in the original Orlando tag set.</para>
    /// labels<para>classe moyenne supérieure</para><para>upper-middle class</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#upper-middleClass">http://sparql.cwrc.ca/ontologies/cwrc#upper-middleClass</seealso>
    let upper_middleClass = Prefixed_Name(cwrc, "upper-middleClass") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:urban-industrialUnskilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>ouvrier non qualifié</para><para>urban unskilled</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#urban-industrialUnskilled">http://sparql.cwrc.ca/ontologies/cwrc#urban-industrialUnskilled</seealso>
    let urban_industrialUnskilled =
        Prefixed_Name(cwrc, "urban-industrialUnskilled") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:urbanPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>urban planning</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#urbanPlanning">http://sparql.cwrc.ca/ontologies/cwrc#urbanPlanning</seealso>
    let urbanPlanning = Prefixed_Name(cwrc, "urbanPlanning") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:utilitarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>utilitarianism</para><para>Utilitarisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#utilitarianism">http://sparql.cwrc.ca/ontologies/cwrc#utilitarianism</seealso>
    let utilitarianism = Prefixed_Name(cwrc, "utilitarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:vegetarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>vegetarianism</para><para>Végétarisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#vegetarianism">http://sparql.cwrc.ca/ontologies/cwrc#vegetarianism</seealso>
    let vegetarianism = Prefixed_Name(cwrc, "vegetarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:venerealDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>venereal disease</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#venerealDisease">http://sparql.cwrc.ca/ontologies/cwrc#venerealDisease</seealso>
    let venerealDisease = Prefixed_Name(cwrc, "venerealDisease") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:veterinaryWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>veterinary work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#veterinaryWork">http://sparql.cwrc.ca/ontologies/cwrc#veterinaryWork</seealso>
    let veterinaryWork = Prefixed_Name(cwrc, "veterinaryWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:vintner</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>vintner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#vintner">http://sparql.cwrc.ca/ontologies/cwrc#vintner</seealso>
    let vintner = Prefixed_Name(cwrc, "vintner") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:21bad544-af11-4b8d-869f-2d26f53943c8-027917040a</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8-027917040a">http://sparql.cwrc.ca/ontologies/cwrc#21bad544-af11-4b8d-869f-2d26f53943c8-027917040a</seealso>
    let _21bad544_af11_4b8d_869f_2d26f53943c8_027917040a =
        Prefixed_Name(cwrc, "21bad544-af11-4b8d-869f-2d26f53943c8-027917040a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:NaturalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>personne physique</para><para>natural person</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#NaturalPerson">http://sparql.cwrc.ca/ontologies/cwrc#NaturalPerson</seealso>
    let NaturalPerson = Prefixed_Name(cwrc, "NaturalPerson") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>CWRC address is the equivalent of a schema.org Postal Address and uses the predicates from schema Postal Address.</para>
    /// labels<para>address</para><para>adresse</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Address">http://sparql.cwrc.ca/ontologies/cwrc#Address</seealso>
    let Address = Prefixed_Name(cwrc, "Address") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>gender</para><para>genre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Gender">http://sparql.cwrc.ca/ontologies/cwrc#Gender</seealso>
    let Gender = Prefixed_Name(cwrc, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:BirthContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>naissance en contexte</para><para>birth context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#BirthContext">http://sparql.cwrc.ca/ontologies/cwrc#BirthContext</seealso>
    let BirthContext = Prefixed_Name(cwrc, "BirthContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Birthname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>birthname</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Birthname">http://sparql.cwrc.ca/ontologies/cwrc#Birthname</seealso>
    let Birthname = Prefixed_Name(cwrc, "Birthname") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:EducationalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>educational organization</para><para>établissement éducatif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalOrganization">http://sparql.cwrc.ca/ontologies/cwrc#EducationalOrganization</seealso>
    let EducationalOrganization =
        Prefixed_Name(cwrc, "EducationalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Certainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>probabilité</para><para>certainty</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Certainty">http://sparql.cwrc.ca/ontologies/cwrc#Certainty</seealso>
    let Certainty = Prefixed_Name(cwrc, "Certainty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:CoEducationalSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>éducation mixte</para><para>co-ed school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#CoEducationalSchool">http://sparql.cwrc.ca/ontologies/cwrc#CoEducationalSchool</seealso>
    let CoEducationalSchool = Prefixed_Name(cwrc, "CoEducationalSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:CompetencyQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>competency question</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#CompetencyQuestion">http://sparql.cwrc.ca/ontologies/cwrc#CompetencyQuestion</seealso>
    let CompetencyQuestion = Prefixed_Name(cwrc, "CompetencyQuestion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:CrypticName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>cryptic name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#CrypticName">http://sparql.cwrc.ca/ontologies/cwrc#CrypticName</seealso>
    let CrypticName = Prefixed_Name(cwrc, "CrypticName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:CulturalFormContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>forme culturelle en contexte</para><para>cultural form context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalFormContext">http://sparql.cwrc.ca/ontologies/cwrc#CulturalFormContext</seealso>
    let CulturalFormContext = Prefixed_Name(cwrc, "CulturalFormContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:CulturalFormation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Deprecated in favour of class &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt;.</para>
    /// labels<para>formation culturelle</para><para>cultural formation </para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalFormation">http://sparql.cwrc.ca/ontologies/cwrc#CulturalFormation</seealso>
    let CulturalFormation = Prefixed_Name(cwrc, "CulturalFormation") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:DameSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>dame school</para><para>dame school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#DameSchool">http://sparql.cwrc.ca/ontologies/cwrc#DameSchool</seealso>
    let DameSchool = Prefixed_Name(cwrc, "DameSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:DaySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>école externe</para><para>day school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#DaySchool">http://sparql.cwrc.ca/ontologies/cwrc#DaySchool</seealso>
    let DaySchool = Prefixed_Name(cwrc, "DaySchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:DeathContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>décès en contexte</para><para>death context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#DeathContext">http://sparql.cwrc.ca/ontologies/cwrc#DeathContext</seealso>
    let DeathContext = Prefixed_Name(cwrc, "DeathContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Distinction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>distinction</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Distinction">http://sparql.cwrc.ca/ontologies/cwrc#Distinction</seealso>
    let Distinction = Prefixed_Name(cwrc, "Distinction") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:DomesticEducationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>contexte éducatif domestique</para><para>domestic education context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#DomesticEducationContext">http://sparql.cwrc.ca/ontologies/cwrc#DomesticEducationContext</seealso>
    let DomesticEducationContext =
        Prefixed_Name(cwrc, "DomesticEducationContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:EducationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>education context</para><para>contexte éducatif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EducationContext">http://sparql.cwrc.ca/ontologies/cwrc#EducationContext</seealso>
    let EducationContext = Prefixed_Name(cwrc, "EducationContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:EducationalPrize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>educational prize</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalPrize">http://sparql.cwrc.ca/ontologies/cwrc#EducationalPrize</seealso>
    let EducationalPrize = Prefixed_Name(cwrc, "EducationalPrize") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:EducationalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>educational subject</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalSubject">http://sparql.cwrc.ca/ontologies/cwrc#EducationalSubject</seealso>
    let EducationalSubject = Prefixed_Name(cwrc, "EducationalSubject") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:EducationalText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>educational text</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalText">http://sparql.cwrc.ca/ontologies/cwrc#EducationalText</seealso>
    let EducationalText = Prefixed_Name(cwrc, "EducationalText") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:EnglishNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#englishNationalHeritage" title="#englishNationalHeritage"&gt;Anglais&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#englishNationalHeritage" title="#englishNationalHeritage"&gt;English&lt;/a&gt;.</para>
    /// labels<para>Anglais</para><para>English</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EnglishNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#EnglishNationalHeritage</seealso>
    let EnglishNationalHeritage =
        Prefixed_Name(cwrc, "EnglishNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:englishNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of foreign instance ISO 3166-2:GB-ENG.</para>
    ///   <para>Désapprouver en faveur de l'instance ISO 3166-2:GB-ENG.</para>
    /// labels<para>English</para><para>Anglais</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#englishNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#englishNationalHeritage</seealso>
    let englishNationalHeritage =
        Prefixed_Name(cwrc, "englishNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:EssayAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>essay award</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EssayAward">http://sparql.cwrc.ca/ontologies/cwrc#EssayAward</seealso>
    let EssayAward = Prefixed_Name(cwrc, "EssayAward") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Ethnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>ethnicité</para><para>ethnicity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Ethnicity">http://sparql.cwrc.ca/ontologies/cwrc#Ethnicity</seealso>
    let Ethnicity = Prefixed_Name(cwrc, "Ethnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:EthnicityContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of class &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt;.</para>
    /// labels<para>contexte racial, de couleur de peau ou d'ethnicité</para><para>racial, colour or ethnicity context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EthnicityContext">http://sparql.cwrc.ca/ontologies/cwrc#EthnicityContext</seealso>
    let EthnicityContext = Prefixed_Name(cwrc, "EthnicityContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:RaceEthnicityContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>contexte ethnique ou racial</para><para>race or ethnicity context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#RaceEthnicityContext">http://sparql.cwrc.ca/ontologies/cwrc#RaceEthnicityContext</seealso>
    let RaceEthnicityContext =
        Prefixed_Name(cwrc, "RaceEthnicityContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:RaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>race ou couleur</para><para>race or colour</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#RaceColour">http://sparql.cwrc.ca/ontologies/cwrc#RaceColour</seealso>
    let RaceColour = Prefixed_Name(cwrc, "RaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:marxism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Marxisme</para><para>Marxism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#marxism">http://sparql.cwrc.ca/ontologies/cwrc#marxism</seealso>
    let marxism = Prefixed_Name(cwrc, "marxism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:maoism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Maoïsme</para><para>Maoism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#maoism">http://sparql.cwrc.ca/ontologies/cwrc#maoism</seealso>
    let maoism = Prefixed_Name(cwrc, "maoism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:companion</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>companion</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#companion">http://sparql.cwrc.ca/ontologies/cwrc#companion</seealso>
    let companion = Prefixed_Name(cwrc, "companion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>composer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#composer">http://sparql.cwrc.ca/ontologies/cwrc#composer</seealso>
    let composer = Prefixed_Name(cwrc, "composer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dataProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>data processing</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dataProcessing">http://sparql.cwrc.ca/ontologies/cwrc#dataProcessing</seealso>
    let dataProcessing = Prefixed_Name(cwrc, "dataProcessing") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:confectioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>confectioner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#confectioner">http://sparql.cwrc.ca/ontologies/cwrc#confectioner</seealso>
    let confectioner = Prefixed_Name(cwrc, "confectioner") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:congregationalChurch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#congregationalism" title="#congregationalism"&gt;Congregationalism&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#congregationalism" title="#congregationalism"&gt;Églises congrégationalistes&lt;/a&gt;.</para>
    /// labels<para>Églises congrégationalistes</para><para>Congregational Church</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#congregationalChurch">http://sparql.cwrc.ca/ontologies/cwrc#congregationalChurch</seealso>
    let congregationalChurch =
        Prefixed_Name(cwrc, "congregationalChurch") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:congregationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Églises congrégationalistes</para><para>Congregationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#congregationalism">http://sparql.cwrc.ca/ontologies/cwrc#congregationalism</seealso>
    let congregationalism = Prefixed_Name(cwrc, "congregationalism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:conscientiousObjection</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>conscientious objection</para><para>objection de conscience</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#conscientiousObjection">http://sparql.cwrc.ca/ontologies/cwrc#conscientiousObjection</seealso>
    let conscientiousObjection =
        Prefixed_Name(cwrc, "conscientiousObjection") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:conservationist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>conservationist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#conservationist">http://sparql.cwrc.ca/ontologies/cwrc#conservationist</seealso>
    let conservationist = Prefixed_Name(cwrc, "conservationist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:conservatism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>conservatisme</para><para>conservatism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#conservatism">http://sparql.cwrc.ca/ontologies/cwrc#conservatism</seealso>
    let conservatism = Prefixed_Name(cwrc, "conservatism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:neo-Conservatism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Néo-conservatisme</para><para>neo-conservatism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#neo-Conservatism">http://sparql.cwrc.ca/ontologies/cwrc#neo-Conservatism</seealso>
    let neo_Conservatism = Prefixed_Name(cwrc, "neo-Conservatism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:conservativeFeminism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>féminisme conservateur</para><para>conservative feminism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#conservativeFeminism">http://sparql.cwrc.ca/ontologies/cwrc#conservativeFeminism</seealso>
    let conservativeFeminism =
        Prefixed_Name(cwrc, "conservativeFeminism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:conservativePartyUk</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Parti Conservateur (Royaume-Uni)</para><para>Conservative Party (UK)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#conservativePartyUk">http://sparql.cwrc.ca/ontologies/cwrc#conservativePartyUk</seealso>
    let conservativePartyUk = Prefixed_Name(cwrc, "conservativePartyUk") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:constitutionalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Constitutionnalisme</para><para>constitutionalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#constitutionalism">http://sparql.cwrc.ca/ontologies/cwrc#constitutionalism</seealso>
    let constitutionalism = Prefixed_Name(cwrc, "constitutionalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:genderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>gender identity of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genderOf">http://sparql.cwrc.ca/ontologies/cwrc#genderOf</seealso>
    let genderOf = Prefixed_Name(cwrc, "genderOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:genderReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>gender identity (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genderReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#genderReportedOf</seealso>
    let genderReportedOf = Prefixed_Name(cwrc, "genderReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:genderSelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>gender identity (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genderSelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#genderSelfReportedOf</seealso>
    let genderSelfReportedOf =
        Prefixed_Name(cwrc, "genderSelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:genderTransMan</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#transMan" title="#transMan"&gt;transman/transmale&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#transMan" title="#transMan"&gt;homme trans&lt;/a&gt;.</para>
    /// labels<para>Transman/Transmale</para><para>Homme Trans</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genderTransMan">http://sparql.cwrc.ca/ontologies/cwrc#genderTransMan</seealso>
    let genderTransMan = Prefixed_Name(cwrc, "genderTransMan") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:transMan</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///
    /// labels<para>transman/transmale</para><para>homme trans</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#transMan">http://sparql.cwrc.ca/ontologies/cwrc#transMan</seealso>
    let transMan = Prefixed_Name(cwrc, "transMan") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:genderTransWoman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#transWoman" title="#transWoman"&gt;femme trans&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#transWoman" title="#transWoman"&gt;transwoman/transfemale&lt;/a&gt;.</para>
    /// labels<para>Transwoman/Transfemale</para><para>Femme Trans</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genderTransWoman">http://sparql.cwrc.ca/ontologies/cwrc#genderTransWoman</seealso>
    let genderTransWoman = Prefixed_Name(cwrc, "genderTransWoman") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:transWoman</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Gender</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>transwoman/transfemale</para><para>femme trans</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#transWoman">http://sparql.cwrc.ca/ontologies/cwrc#transWoman</seealso>
    let transWoman = Prefixed_Name(cwrc, "transWoman") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a un rôle</para><para>has role</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasRole">http://sparql.cwrc.ca/ontologies/cwrc#hasRole</seealso>
    let hasRole = Prefixed_Name(cwrc, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasSexuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une orientation sexuelle</para><para>has sexual identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexuality">http://sparql.cwrc.ca/ontologies/cwrc#hasSexuality</seealso>
    let hasSexuality = Prefixed_Name(cwrc, "hasSexuality") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sexualityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sexual identity of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityOf">http://sparql.cwrc.ca/ontologies/cwrc#sexualityOf</seealso>
    let sexualityOf = Prefixed_Name(cwrc, "sexualityOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSexualityReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une orientation sexuelle (déclarée)</para><para>has sexual identity (reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualityReported">http://sparql.cwrc.ca/ontologies/cwrc#hasSexualityReported</seealso>
    let hasSexualityReported =
        Prefixed_Name(cwrc, "hasSexualityReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexualityReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sexual identity (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#sexualityReportedOf</seealso>
    let sexualityReportedOf = Prefixed_Name(cwrc, "sexualityReportedOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:laundryWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>laundry worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#laundryWorker">http://sparql.cwrc.ca/ontologies/cwrc#laundryWorker</seealso>
    let laundryWorker = Prefixed_Name(cwrc, "laundryWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lawDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>law degree</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lawDegree">http://sparql.cwrc.ca/ontologies/cwrc#lawDegree</seealso>
    let lawDegree = Prefixed_Name(cwrc, "lawDegree") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:professionalDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Credential</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>professional degree</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#professionalDegree">http://sparql.cwrc.ca/ontologies/cwrc#professionalDegree</seealso>
    let professionalDegree = Prefixed_Name(cwrc, "professionalDegree") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:radicalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>radicalisme</para><para>radicalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#radicalism">http://sparql.cwrc.ca/ontologies/cwrc#radicalism</seealso>
    let radicalism = Prefixed_Name(cwrc, "radicalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:radioIndustry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>radio industry</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#radioIndustry">http://sparql.cwrc.ca/ontologies/cwrc#radioIndustry</seealso>
    let radioIndustry = Prefixed_Name(cwrc, "radioIndustry") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:radioOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>radio operator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#radioOperator">http://sparql.cwrc.ca/ontologies/cwrc#radioOperator</seealso>
    let radioOperator = Prefixed_Name(cwrc, "radioOperator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:railwayWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>railway work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#railwayWork">http://sparql.cwrc.ca/ontologies/cwrc#railwayWork</seealso>
    let railwayWork = Prefixed_Name(cwrc, "railwayWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:reading</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>reading</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#reading">http://sparql.cwrc.ca/ontologies/cwrc#reading</seealso>
    let reading = Prefixed_Name(cwrc, "reading") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:rebel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>rebel</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#rebel">http://sparql.cwrc.ca/ontologies/cwrc#rebel</seealso>
    let rebel = Prefixed_Name(cwrc, "rebel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:redCross</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>red cross</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#redCross">http://sparql.cwrc.ca/ontologies/cwrc#redCross</seealso>
    let redCross = Prefixed_Name(cwrc, "redCross") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:reformer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>reformer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#reformer">http://sparql.cwrc.ca/ontologies/cwrc#reformer</seealso>
    let reformer = Prefixed_Name(cwrc, "reformer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:visits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>visits</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#visits">http://sparql.cwrc.ca/ontologies/cwrc#visits</seealso>
    let visits = Prefixed_Name(cwrc, "visits") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:visualArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>visual artist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#visualArtist">http://sparql.cwrc.ca/ontologies/cwrc#visualArtist</seealso>
    let visualArtist = Prefixed_Name(cwrc, "visualArtist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:vitalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>vitalisme</para><para>vitalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#vitalism">http://sparql.cwrc.ca/ontologies/cwrc#vitalism</seealso>
    let vitalism = Prefixed_Name(cwrc, "vitalism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:2237f8bc-6be9-44b5-8fe9-f531c6a44a58</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58">http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58</seealso>
    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58 =
        Prefixed_Name(cwrc, "2237f8bc-6be9-44b5-8fe9-f531c6a44a58") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55">http://sparql.cwrc.ca/ontologies/cwrc#2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55</seealso>
    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58_da81d2bb55 =
        Prefixed_Name(cwrc, "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:PoliticalAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>appartenance politique</para><para>political affiliation</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalAffiliation">http://sparql.cwrc.ca/ontologies/cwrc#PoliticalAffiliation</seealso>
    let PoliticalAffiliation =
        Prefixed_Name(cwrc, "PoliticalAffiliation") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-Federalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Antifédéralisme</para><para>Anti-Federalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Federalism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Federalism</seealso>
    let anti_Federalism = Prefixed_Name(cwrc, "anti-Federalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Globalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Mouvement antimondialisation</para><para>anti-globalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Globalism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Globalism</seealso>
    let anti_Globalism = Prefixed_Name(cwrc, "anti-Globalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Jacobin</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-Jacobin</para><para>anti-Jacobin</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Jacobin">http://sparql.cwrc.ca/ontologies/cwrc#anti-Jacobin</seealso>
    let anti_Jacobin = Prefixed_Name(cwrc, "anti-Jacobin") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:philanthropist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>philanthropist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#philanthropist">http://sparql.cwrc.ca/ontologies/cwrc#philanthropist</seealso>
    let philanthropist = Prefixed_Name(cwrc, "philanthropist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:chartism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Chartist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#chartism">http://sparql.cwrc.ca/ontologies/cwrc#chartism</seealso>
    let chartism = Prefixed_Name(cwrc, "chartism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:healthCareProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>healthcare provider</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#healthCareProvider">http://sparql.cwrc.ca/ontologies/cwrc#healthCareProvider</seealso>
    let healthCareProvider = Prefixed_Name(cwrc, "healthCareProvider") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:designer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>designer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#designer">http://sparql.cwrc.ca/ontologies/cwrc#designer</seealso>
    let designer = Prefixed_Name(cwrc, "designer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:patron</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>patron</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#patron">http://sparql.cwrc.ca/ontologies/cwrc#patron</seealso>
    let patron = Prefixed_Name(cwrc, "patron") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:settlementWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>settlement work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#settlementWork">http://sparql.cwrc.ca/ontologies/cwrc#settlementWork</seealso>
    let settlementWork = Prefixed_Name(cwrc, "settlementWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:settler</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>settler</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#settler">http://sparql.cwrc.ca/ontologies/cwrc#settler</seealso>
    let settler = Prefixed_Name(cwrc, "settler") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9</seealso>
    let _7fb45454_7271_48b3_bd57_7a2b4572fc21_215ee9c7d9 =
        Prefixed_Name(cwrc, "7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443">http://sparql.cwrc.ca/ontologies/cwrc#8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443</seealso>
    let _8049540f_3673_4ca0_920c_cb5326d7c466_bedac43443 =
        Prefixed_Name(cwrc, "8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c">http://sparql.cwrc.ca/ontologies/cwrc#825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c</seealso>
    let _825995b3_3b66_4e0a_a62d_d8649aaead78_5336e1be2c =
        Prefixed_Name(cwrc, "825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:842ffbb4-11de-4212-8e6e-9d4d8d28d3a5</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5">http://sparql.cwrc.ca/ontologies/cwrc#842ffbb4-11de-4212-8e6e-9d4d8d28d3a5</seealso>
    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5 =
        Prefixed_Name(cwrc, "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0">http://sparql.cwrc.ca/ontologies/cwrc#8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0</seealso>
    let _8f9744a7_4861_4bd3_a956_e4aab75b7e77_10865207d0 =
        Prefixed_Name(cwrc, "8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#EventElement" title="#EventElement"&gt;[http://sparql.cwrc.ca/ontologies/cwrc#EventElement]&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of class &lt;a href="#EventElement" title="#EventElement"&gt;[http://sparql.cwrc.ca/ontologies/cwrc#EventElement]&lt;/a&gt;.</para>
    /// labels<para>interprétation</para><para>performance</para><para>Leistung</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Performance">http://sparql.cwrc.ca/ontologies/cwrc#Performance</seealso>
    let Performance = Prefixed_Name(cwrc, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasElement">http://sparql.cwrc.ca/ontologies/cwrc#hasElement</seealso>
    let hasElement = Prefixed_Name(cwrc, "hasElement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:farming</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>farming</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#farming">http://sparql.cwrc.ca/ontologies/cwrc#farming</seealso>
    let farming = Prefixed_Name(cwrc, "farming") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>dance</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dance">http://sparql.cwrc.ca/ontologies/cwrc#dance</seealso>
    let dance = Prefixed_Name(cwrc, "dance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:darwinism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Darwinisme</para><para>Darwinism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#darwinism">http://sparql.cwrc.ca/ontologies/cwrc#darwinism</seealso>
    let darwinism = Prefixed_Name(cwrc, "darwinism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:eventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>event of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#eventOf">http://sparql.cwrc.ca/ontologies/cwrc#eventOf</seealso>
    let eventOf = Prefixed_Name(cwrc, "eventOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has event</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEvent">http://sparql.cwrc.ca/ontologies/cwrc#hasEvent</seealso>
    let hasEvent = Prefixed_Name(cwrc, "hasEvent") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasContestedBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has nonconformant behaviour</para><para>comportement contesté</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasContestedBehaviour">http://sparql.cwrc.ca/ontologies/cwrc#hasContestedBehaviour</seealso>
    let hasContestedBehaviour =
        Prefixed_Name(cwrc, "hasContestedBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:igboEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Igbo</para><para>Igbo</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#igboEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#igboEthnicity</seealso>
    let igboEthnicity = Prefixed_Name(cwrc, "igboEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:magistrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>magistrate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#magistrate">http://sparql.cwrc.ca/ontologies/cwrc#magistrate</seealso>
    let magistrate = Prefixed_Name(cwrc, "magistrate") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:23ad5d2a-605e-4116-8f81-7db6b95395ea</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea">http://sparql.cwrc.ca/ontologies/cwrc#23ad5d2a-605e-4116-8f81-7db6b95395ea</seealso>
    let _23ad5d2a_605e_4116_8f81_7db6b95395ea =
        Prefixed_Name(cwrc, "23ad5d2a-605e-4116-8f81-7db6b95395ea") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:AdditionalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>additional name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#AdditionalName">http://sparql.cwrc.ca/ontologies/cwrc#AdditionalName</seealso>
    let AdditionalName = Prefixed_Name(cwrc, "AdditionalName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:rationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Rationalisme</para><para>rationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#rationalism">http://sparql.cwrc.ca/ontologies/cwrc#rationalism</seealso>
    let rationalism = Prefixed_Name(cwrc, "rationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cartoonist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>cartoonist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cartoonist">http://sparql.cwrc.ca/ontologies/cwrc#cartoonist</seealso>
    let cartoonist = Prefixed_Name(cwrc, "cartoonist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:cooking</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>cooking</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cooking">http://sparql.cwrc.ca/ontologies/cwrc#cooking</seealso>
    let cooking = Prefixed_Name(cwrc, "cooking") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47">http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47</seealso>
    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_cdc669be47 =
        Prefixed_Name(cwrc, "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>oa:Annotation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>contexte</para><para>context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Context">http://sparql.cwrc.ca/ontologies/cwrc#Context</seealso>
    let Context = Prefixed_Name(cwrc, "Context") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:catholicChurch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#catholicism" title="#catholicism"&gt;Roman Catholicism&lt;/a&gt;.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#catholicism" title="#catholicism"&gt;Catholicisme&lt;/a&gt;.</para>
    /// labels<para>Rooms-Katholicisme</para><para>Catolicismo Romano</para><para>Roman Catholic</para><para>Katholicisme</para><para>Catholicisme</para><para>Catolicismo</para><para>Katholiek</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#catholicChurch">http://sparql.cwrc.ca/ontologies/cwrc#catholicChurch</seealso>
    let catholicChurch = Prefixed_Name(cwrc, "catholicChurch") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d">http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d</seealso>
    let f3666ac1_4f95_4f12_a02e_88ed27197d35_2eb3e2ce3d =
        Prefixed_Name(cwrc, "f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:parliamentaryReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme parlementaire</para><para>parliamentary reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#parliamentaryReform">http://sparql.cwrc.ca/ontologies/cwrc#parliamentaryReform</seealso>
    let parliamentaryReform = Prefixed_Name(cwrc, "parliamentaryReform") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4">http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4</seealso>
    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_2a0b3739d4 =
        Prefixed_Name(cwrc, "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26cf15ba-5650-43ef-9a55-229c7ce3bbbb</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb">http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb</seealso>
    let _26cf15ba_5650_43ef_9a55_229c7ce3bbbb =
        Prefixed_Name(cwrc, "26cf15ba-5650-43ef-9a55-229c7ce3bbbb") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9">http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9</seealso>
    let _26cf15ba_5650_43ef_9a55_229c7ce3bbbb_318cb143c9 =
        Prefixed_Name(cwrc, "26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-PovertyMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement de lutte contre la pauvreté</para><para>anti-poverty movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-PovertyMovement">http://sparql.cwrc.ca/ontologies/cwrc#anti-PovertyMovement</seealso>
    let anti_PovertyMovement =
        Prefixed_Name(cwrc, "anti-PovertyMovement") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:irishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Irlandais</para><para>Irish</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#irishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#irishEthnicity</seealso>
    let irishEthnicity = Prefixed_Name(cwrc, "irishEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:irishHomeRuleMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement Irish Home Rule</para><para>Irish Home Rule Movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#irishHomeRuleMovement">http://sparql.cwrc.ca/ontologies/cwrc#irishHomeRuleMovement</seealso>
    let irishHomeRuleMovement =
        Prefixed_Name(cwrc, "irishHomeRuleMovement") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:philanthropicVisitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>philanthropic visitor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#philanthropicVisitor">http://sparql.cwrc.ca/ontologies/cwrc#philanthropicVisitor</seealso>
    let philanthropicVisitor =
        Prefixed_Name(cwrc, "philanthropicVisitor") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:philosopher</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>philosopher</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#philosopher">http://sparql.cwrc.ca/ontologies/cwrc#philosopher</seealso>
    let philosopher = Prefixed_Name(cwrc, "philosopher") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:smuggler</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>smuggler</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#smuggler">http://sparql.cwrc.ca/ontologies/cwrc#smuggler</seealso>
    let smuggler = Prefixed_Name(cwrc, "smuggler") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9">http://sparql.cwrc.ca/ontologies/cwrc#26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9</seealso>
    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_63a2ae33d9 =
        Prefixed_Name(cwrc, "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9">http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9</seealso>
    let _27faa9ed_1d5c_44c4_b3f3_e6ac3f57e5f9 =
        Prefixed_Name(cwrc, "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:DecadeSignficance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>decade significance</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#DecadeSignficance">http://sparql.cwrc.ca/ontologies/cwrc#DecadeSignficance</seealso>
    let DecadeSignficance = Prefixed_Name(cwrc, "DecadeSignficance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dressmaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>dressmaking</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dressmaking">http://sparql.cwrc.ca/ontologies/cwrc#dressmaking</seealso>
    let dressmaking = Prefixed_Name(cwrc, "dressmaking") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSocialRelationshipWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has social relationship with</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialRelationshipWith">http://sparql.cwrc.ca/ontologies/cwrc#hasSocialRelationshipWith</seealso>
    let hasSocialRelationshipWith =
        Prefixed_Name(cwrc, "hasSocialRelationshipWith") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:republicanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Républicanisme</para><para>republicanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#republicanism">http://sparql.cwrc.ca/ontologies/cwrc#republicanism</seealso>
    let republicanism = Prefixed_Name(cwrc, "republicanism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:matron</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>matron</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#matron">http://sparql.cwrc.ca/ontologies/cwrc#matron</seealso>
    let matron = Prefixed_Name(cwrc, "matron") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mayor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>mayor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mayor">http://sparql.cwrc.ca/ontologies/cwrc#mayor</seealso>
    let mayor = Prefixed_Name(cwrc, "mayor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:medicalDoctor</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>medical doctor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#medicalDoctor">http://sparql.cwrc.ca/ontologies/cwrc#medicalDoctor</seealso>
    let medicalDoctor = Prefixed_Name(cwrc, "medicalDoctor") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:philosophicalRadicals</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Philosophical Radicals</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#philosophicalRadicals">http://sparql.cwrc.ca/ontologies/cwrc#philosophicalRadicals</seealso>
    let philosophicalRadicals =
        Prefixed_Name(cwrc, "philosophicalRadicals") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:physiognomist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>physiognomist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#physiognomist">http://sparql.cwrc.ca/ontologies/cwrc#physiognomist</seealso>
    let physiognomist = Prefixed_Name(cwrc, "physiognomist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:plumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>plumber</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#plumber">http://sparql.cwrc.ca/ontologies/cwrc#plumber</seealso>
    let plumber = Prefixed_Name(cwrc, "plumber") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Studentship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>studentship</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Studentship">http://sparql.cwrc.ca/ontologies/cwrc#Studentship</seealso>
    let Studentship = Prefixed_Name(cwrc, "Studentship") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dissenters</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#dissentProtestant" title="#dissentProtestant"&gt;Dissent (Protestant)&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#dissentProtestant" title="#dissentProtestant"&gt;dissidents (ou non-conformistes)&lt;/a&gt;.</para>
    /// labels<para>dissidents (ou non-conformistes)</para><para>Dissenters</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dissenters">http://sparql.cwrc.ca/ontologies/cwrc#dissenters</seealso>
    let dissenters = Prefixed_Name(cwrc, "dissenters") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:personalPropertySelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver sans équivalence.</para>
    ///   <para>Deprecated, with no current equivalence.</para>
    /// labels<para>propriété personnelle autodéclarée</para><para>personal property self-reported</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#personalPropertySelfReported">http://sparql.cwrc.ca/ontologies/cwrc#personalPropertySelfReported</seealso>
    let personalPropertySelfReported =
        Prefixed_Name(cwrc, "personalPropertySelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:pharmacist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>pharmacist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pharmacist">http://sparql.cwrc.ca/ontologies/cwrc#pharmacist</seealso>
    let pharmacist = Prefixed_Name(cwrc, "pharmacist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:shipping</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>shipping</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#shipping">http://sparql.cwrc.ca/ontologies/cwrc#shipping</seealso>
    let shipping = Prefixed_Name(cwrc, "shipping") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52">http://sparql.cwrc.ca/ontologies/cwrc#26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52</seealso>
    let _26cf15ba_5650_43ef_9a55_229c7ce3bbbb_8b8a0c6d52 =
        Prefixed_Name(cwrc, "26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76">http://sparql.cwrc.ca/ontologies/cwrc#27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76</seealso>
    let _27faa9ed_1d5c_44c4_b3f3_e6ac3f57e5f9_84fe24be76 =
        Prefixed_Name(cwrc, "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a647a149-3420-4a0d-8462-03900131060e-62fc70c238</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-62fc70c238">http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-62fc70c238</seealso>
    let a647a149_3420_4a0d_8462_03900131060e_62fc70c238 =
        Prefixed_Name(cwrc, "a647a149-3420-4a0d-8462-03900131060e-62fc70c238") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe">http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe</seealso>
    let a647a149_3420_4a0d_8462_03900131060e_d9d06e8cbe =
        Prefixed_Name(cwrc, "a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c">http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c</seealso>
    let aa8dae29_558b_4bda_9859_9ed43faede36_04b657798c =
        Prefixed_Name(cwrc, "aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c">http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c</seealso>
    let aa8dae29_558b_4bda_9859_9ed43faede36_45528df81c =
        Prefixed_Name(cwrc, "aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:antidisestablishmentarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>opposition à l'Establismhment</para><para>antidisestablishmentarianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#antidisestablishmentarianism">http://sparql.cwrc.ca/ontologies/cwrc#antidisestablishmentarianism</seealso>
    let antidisestablishmentarianism =
        Prefixed_Name(cwrc, "antidisestablishmentarianism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:co-operativeMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement pour l'économie sociale</para><para>co-operative movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#co-operativeMovement">http://sparql.cwrc.ca/ontologies/cwrc#co-operativeMovement</seealso>
    let co_operativeMovement =
        Prefixed_Name(cwrc, "co-operativeMovement") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4">http://sparql.cwrc.ca/ontologies/cwrc#ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4</seealso>
    let ebbb5e23_2c34_4810_b921_1d72694af314_partof_33254c3df4 =
        Prefixed_Name(cwrc, "ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ecumenism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>œcuménisme</para><para>ecumenism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ecumenism">http://sparql.cwrc.ca/ontologies/cwrc#ecumenism</seealso>
    let ecumenism = Prefixed_Name(cwrc, "ecumenism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:raceColourOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>race or colour identity of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourOf">http://sparql.cwrc.ca/ontologies/cwrc#raceColourOf</seealso>
    let raceColourOf = Prefixed_Name(cwrc, "raceColourOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasRaceColourReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has race or colour identity (reported)</para><para>race ou couleur (déclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourReported">http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourReported</seealso>
    let hasRaceColourReported =
        Prefixed_Name(cwrc, "hasRaceColourReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sufism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Soufisme</para><para>Sufism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sufism">http://sparql.cwrc.ca/ontologies/cwrc#sufism</seealso>
    let sufism = Prefixed_Name(cwrc, "sufism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a647a149-3420-4a0d-8462-03900131060e-67d1668522</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-67d1668522">http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-67d1668522</seealso>
    let a647a149_3420_4a0d_8462_03900131060e_67d1668522 =
        Prefixed_Name(cwrc, "a647a149-3420-4a0d-8462-03900131060e-67d1668522") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aa8dae29-558b-4bda-9859-9ed43faede36</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36">http://sparql.cwrc.ca/ontologies/cwrc#aa8dae29-558b-4bda-9859-9ed43faede36</seealso>
    let aa8dae29_558b_4bda_9859_9ed43faede36 =
        Prefixed_Name(cwrc, "aa8dae29-558b-4bda-9859-9ed43faede36") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aaa909f5-ffb5-4995-8245-b169d3c64746</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746">http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746</seealso>
    let aaa909f5_ffb5_4995_8245_b169d3c64746 =
        Prefixed_Name(cwrc, "aaa909f5-ffb5-4995-8245-b169d3c64746") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4">http://sparql.cwrc.ca/ontologies/cwrc#aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4</seealso>
    let aaa909f5_ffb5_4995_8245_b169d3c64746_706552b3f4 =
        Prefixed_Name(cwrc, "aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:abolitionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Abolitionnisme</para><para>abolitionism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#abolitionism">http://sparql.cwrc.ca/ontologies/cwrc#abolitionism</seealso>
    let abolitionism = Prefixed_Name(cwrc, "abolitionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:contraryTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>contrary to</para><para>contraire à</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#contraryTo">http://sparql.cwrc.ca/ontologies/cwrc#contraryTo</seealso>
    let contraryTo = Prefixed_Name(cwrc, "contraryTo") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:abolitionist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>abolitionist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#abolitionist">http://sparql.cwrc.ca/ontologies/cwrc#abolitionist</seealso>
    let abolitionist = Prefixed_Name(cwrc, "abolitionist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:activist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>activist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#activist">http://sparql.cwrc.ca/ontologies/cwrc#activist</seealso>
    let activist = Prefixed_Name(cwrc, "activist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:abortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///
    /// labels<para>abortion</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#abortion">http://sparql.cwrc.ca/ontologies/cwrc#abortion</seealso>
    let abortion = Prefixed_Name(cwrc, "abortion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:academic</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>academic</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#academic">http://sparql.cwrc.ca/ontologies/cwrc#academic</seealso>
    let academic = Prefixed_Name(cwrc, "academic") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:accountant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>accountant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#accountant">http://sparql.cwrc.ca/ontologies/cwrc#accountant</seealso>
    let accountant = Prefixed_Name(cwrc, "accountant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:assistant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>assistant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#assistant">http://sparql.cwrc.ca/ontologies/cwrc#assistant</seealso>
    let assistant = Prefixed_Name(cwrc, "assistant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:music</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>music</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#music">http://sparql.cwrc.ca/ontologies/cwrc#music</seealso>
    let music = Prefixed_Name(cwrc, "music") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:computerScientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>computer scientist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#computerScientist">http://sparql.cwrc.ca/ontologies/cwrc#computerScientist</seealso>
    let computerScientist = Prefixed_Name(cwrc, "computerScientist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:computerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>computer work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#computerWork">http://sparql.cwrc.ca/ontologies/cwrc#computerWork</seealso>
    let computerWork = Prefixed_Name(cwrc, "computerWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:educationReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme de l'éducation</para><para>education reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#educationReform">http://sparql.cwrc.ca/ontologies/cwrc#educationReform</seealso>
    let educationReform = Prefixed_Name(cwrc, "educationReform") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:educationalAdministration</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>educational administration</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#educationalAdministration">http://sparql.cwrc.ca/ontologies/cwrc#educationalAdministration</seealso>
    let educationalAdministration =
        Prefixed_Name(cwrc, "educationalAdministration") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:educationalAwardPrize</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:EducationalAward</para>
    ///
    /// labels<para>educational award prize</para><para>prix éducatif</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#educationalAwardPrize">http://sparql.cwrc.ca/ontologies/cwrc#educationalAwardPrize</seealso>
    let educationalAwardPrize =
        Prefixed_Name(cwrc, "educationalAwardPrize") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:educationalAwardScholarship</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:EducationalAward</para>
    ///
    /// labels<para>educational award scholarship</para><para>bourse d'étude</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#educationalAwardScholarship">http://sparql.cwrc.ca/ontologies/cwrc#educationalAwardScholarship</seealso>
    let educationalAwardScholarship =
        Prefixed_Name(cwrc, "educationalAwardScholarship") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:egalitarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>egalitarianism</para><para>Égalitarisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#egalitarianism">http://sparql.cwrc.ca/ontologies/cwrc#egalitarianism</seealso>
    let egalitarianism = Prefixed_Name(cwrc, "egalitarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:germanNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>nationalisme allemand</para><para>German nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#germanNationalism">http://sparql.cwrc.ca/ontologies/cwrc#germanNationalism</seealso>
    let germanNationalism = Prefixed_Name(cwrc, "germanNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:girondin</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Gironde (Révolution française)</para><para>Girondin</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#girondin">http://sparql.cwrc.ca/ontologies/cwrc#girondin</seealso>
    let girondin = Prefixed_Name(cwrc, "girondin") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jacobinism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Jacobinisme</para><para>Jacobinism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jacobinism">http://sparql.cwrc.ca/ontologies/cwrc#jacobinism</seealso>
    let jacobinism = Prefixed_Name(cwrc, "jacobinism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:glassWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>glass worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#glassWorker">http://sparql.cwrc.ca/ontologies/cwrc#glassWorker</seealso>
    let glassWorker = Prefixed_Name(cwrc, "glassWorker") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSexualitySelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasSexualitySelfReported" title="#hasSexualitySelfReported"&gt;has sexual identity (self-reported)&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasSexualitySelfReported" title="#hasSexualitySelfReported"&gt;a une orientation sexuelle (autodéclarée)&lt;/a&gt;.</para>
    /// labels<para>a une orientation sexuelle (autodéclarée)</para><para>has sexual orientation (self declared)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualitySelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#hasSexualitySelfDeclared</seealso>
    let hasSexualitySelfDeclared =
        Prefixed_Name(cwrc, "hasSexualitySelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasSexualitySelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une orientation sexuelle (autodéclarée)</para><para>has sexual identity (self-reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualitySelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasSexualitySelfReported</seealso>
    let hasSexualitySelfReported =
        Prefixed_Name(cwrc, "hasSexualitySelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexualitySelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sexual identity (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualitySelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#sexualitySelfReportedOf</seealso>
    let sexualitySelfReportedOf =
        Prefixed_Name(cwrc, "sexualitySelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:lawyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>lawyer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lawyer">http://sparql.cwrc.ca/ontologies/cwrc#lawyer</seealso>
    let lawyer = Prefixed_Name(cwrc, "lawyer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:legalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>legal work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#legalWork">http://sparql.cwrc.ca/ontologies/cwrc#legalWork</seealso>
    let legalWork = Prefixed_Name(cwrc, "legalWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:leatherWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>leather worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#leatherWorker">http://sparql.cwrc.ca/ontologies/cwrc#leatherWorker</seealso>
    let leatherWorker = Prefixed_Name(cwrc, "leatherWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:refugee</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>refugee</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#refugee">http://sparql.cwrc.ca/ontologies/cwrc#refugee</seealso>
    let refugee = Prefixed_Name(cwrc, "refugee") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:refugeeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>refugee work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#refugeeWork">http://sparql.cwrc.ca/ontologies/cwrc#refugeeWork</seealso>
    let refugeeWork = Prefixed_Name(cwrc, "refugeeWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:volunteer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>volunteer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#volunteer">http://sparql.cwrc.ca/ontologies/cwrc#volunteer</seealso>
    let volunteer = Prefixed_Name(cwrc, "volunteer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:walking</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>walking</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#walking">http://sparql.cwrc.ca/ontologies/cwrc#walking</seealso>
    let walking = Prefixed_Name(cwrc, "walking") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:warehouseWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>warehouse work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#warehouseWork">http://sparql.cwrc.ca/ontologies/cwrc#warehouseWork</seealso>
    let warehouseWork = Prefixed_Name(cwrc, "warehouseWork") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc">http://sparql.cwrc.ca/ontologies/cwrc#3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc</seealso>
    let _3238e1a7_6d28_49ed_a48a_cb2cb5e3d1cc =
        Prefixed_Name(cwrc, "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:366c694c-b5bd-47b4-80a9-2dead4f7a7cb</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb">http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb</seealso>
    let _366c694c_b5bd_47b4_80a9_2dead4f7a7cb =
        Prefixed_Name(cwrc, "366c694c-b5bd-47b4-80a9-2dead4f7a7cb") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:domesticServant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>domestic servant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#domesticServant">http://sparql.cwrc.ca/ontologies/cwrc#domesticServant</seealso>
    let domesticServant = Prefixed_Name(cwrc, "domesticServant") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:e1f710d3-6ebd-4181-be61-bf931282a8b7</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7">http://sparql.cwrc.ca/ontologies/cwrc#e1f710d3-6ebd-4181-be61-bf931282a8b7</seealso>
    let e1f710d3_6ebd_4181_be61_bf931282a8b7 =
        Prefixed_Name(cwrc, "e1f710d3-6ebd-4181-be61-bf931282a8b7") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNationalitySelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasNationalitySelfReported" title="#hasNationalitySelfReported"&gt;de nationalité (autodéclarée)&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasNationalitySelfReported" title="#hasNationalitySelfReported"&gt;has national identity (self-reported)&lt;/a&gt;.</para>
    /// labels<para>has nationality (self declared)</para><para>de nationalité (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalitySelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#hasNationalitySelfDeclared</seealso>
    let hasNationalitySelfDeclared =
        Prefixed_Name(cwrc, "hasNationalitySelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:mathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>mathematics</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mathematics">http://sparql.cwrc.ca/ontologies/cwrc#mathematics</seealso>
    let mathematics = Prefixed_Name(cwrc, "mathematics") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:medicalDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>medical degree</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#medicalDegree">http://sparql.cwrc.ca/ontologies/cwrc#medicalDegree</seealso>
    let medicalDegree = Prefixed_Name(cwrc, "medicalDegree") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mediumCertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Certainty</para>
    ///
    /// labels<para>probabilité moyenne</para><para>medium certainty</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mediumCertainty">http://sparql.cwrc.ca/ontologies/cwrc#mediumCertainty</seealso>
    let mediumCertainty = Prefixed_Name(cwrc, "mediumCertainty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:photography</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>photography</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#photography">http://sparql.cwrc.ca/ontologies/cwrc#photography</seealso>
    let photography = Prefixed_Name(cwrc, "photography") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3">http://sparql.cwrc.ca/ontologies/cwrc#366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3</seealso>
    let _366c694c_b5bd_47b4_80a9_2dead4f7a7cb_d59f1c99c3 =
        Prefixed_Name(cwrc, "366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83">http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83</seealso>
    let _3d49dc32_ac97_4abd_a252_573c52b463cf_d0e255da83 =
        Prefixed_Name(cwrc, "3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:40523fef-509d-4802-900d-4f230fe50123</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123">http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123</seealso>
    let _40523fef_509d_4802_900d_4f230fe50123 =
        Prefixed_Name(cwrc, "40523fef-509d-4802-900d-4f230fe50123") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:4dc5ff8c-d908-4377-bca8-9394408b7b67-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67-partof">http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67-partof</seealso>
    let _4dc5ff8c_d908_4377_bca8_9394408b7b67_partof =
        Prefixed_Name(cwrc, "4dc5ff8c-d908-4377-bca8-9394408b7b67-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:4f4d7ca6-5625-46d9-bd88-17847ee076d8</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8">http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8</seealso>
    let _4f4d7ca6_5625_46d9_bd88_17847ee076d8 =
        Prefixed_Name(cwrc, "4f4d7ca6-5625-46d9-bd88-17847ee076d8") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:59f48ef6-ebc7-4a58-ac43-2025deb369ec</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec">http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec</seealso>
    let _59f48ef6_ebc7_4a58_ac43_2025deb369ec =
        Prefixed_Name(cwrc, "59f48ef6-ebc7-4a58-ac43-2025deb369ec") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:5e3f3ab7-be20-4dc5-91ec-f41946e05e28</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28">http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28</seealso>
    let _5e3f3ab7_be20_4dc5_91ec_f41946e05e28 =
        Prefixed_Name(cwrc, "5e3f3ab7-be20-4dc5-91ec-f41946e05e28") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b">http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b</seealso>
    let _5e3f3ab7_be20_4dc5_91ec_f41946e05e28_5618f6070b =
        Prefixed_Name(cwrc, "5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9">http://sparql.cwrc.ca/ontologies/cwrc#5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9</seealso>
    let _5e3f3ab7_be20_4dc5_91ec_f41946e05e28_63a2ae33d9 =
        Prefixed_Name(cwrc, "5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7">http://sparql.cwrc.ca/ontologies/cwrc#5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7</seealso>
    let _5e45242f_0c2e_4aaa_8ddb_ac54dd0e6249_13cadb9dc7 =
        Prefixed_Name(cwrc, "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Proceedings</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof">http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof</seealso>
    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_partof =
        Prefixed_Name(cwrc, "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814">http://sparql.cwrc.ca/ontologies/cwrc#62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814</seealso>
    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_partof_72abfae814 =
        Prefixed_Name(cwrc, "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:65424c4e-5257-4e6c-962f-de12a7f11aea</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea">http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea</seealso>
    let _65424c4e_5257_4e6c_962f_de12a7f11aea =
        Prefixed_Name(cwrc, "65424c4e-5257-4e6c-962f-de12a7f11aea") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9</seealso>
    let _65424c4e_5257_4e6c_962f_de12a7f11aea_215ee9c7d9 =
        Prefixed_Name(cwrc, "65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:65424c4e-5257-4e6c-962f-de12a7f11aea-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof">http://sparql.cwrc.ca/ontologies/cwrc#65424c4e-5257-4e6c-962f-de12a7f11aea-partof</seealso>
    let _65424c4e_5257_4e6c_962f_de12a7f11aea_partof =
        Prefixed_Name(cwrc, "65424c4e-5257-4e6c-962f-de12a7f11aea-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:GenderContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>genre en contexte</para><para>gender context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#GenderContext">http://sparql.cwrc.ca/ontologies/cwrc#GenderContext</seealso>
    let GenderContext = Prefixed_Name(cwrc, "GenderContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:GenerationalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>generational name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#GenerationalName">http://sparql.cwrc.ca/ontologies/cwrc#GenerationalName</seealso>
    let GenerationalName = Prefixed_Name(cwrc, "GenerationalName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:GeographicHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>héritage géographique</para><para>geographic heritage</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#GeographicHeritage">http://sparql.cwrc.ca/ontologies/cwrc#GeographicHeritage</seealso>
    let GeographicHeritage = Prefixed_Name(cwrc, "GeographicHeritage") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:GrammarSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>grammar school</para><para>grammar school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#GrammarSchool">http://sparql.cwrc.ca/ontologies/cwrc#GrammarSchool</seealso>
    let GrammarSchool = Prefixed_Name(cwrc, "GrammarSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:HealthContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>health context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#HealthContext">http://sparql.cwrc.ca/ontologies/cwrc#HealthContext</seealso>
    let HealthContext = Prefixed_Name(cwrc, "HealthContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:HistoricSignificance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>historic significance</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#HistoricSignificance">http://sparql.cwrc.ca/ontologies/cwrc#HistoricSignificance</seealso>
    let HistoricSignificance =
        Prefixed_Name(cwrc, "HistoricSignificance") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:HonorificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>honorific name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#HonorificName">http://sparql.cwrc.ca/ontologies/cwrc#HonorificName</seealso>
    let HonorificName = Prefixed_Name(cwrc, "HonorificName") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:IndividualSignificance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>individual significance</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#IndividualSignificance">http://sparql.cwrc.ca/ontologies/cwrc#IndividualSignificance</seealso>
    let IndividualSignificance =
        Prefixed_Name(cwrc, "IndividualSignificance") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:InstitutionalEducationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>contexte éducatif institutionnel</para><para>institutional education context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#InstitutionalEducationContext">http://sparql.cwrc.ca/ontologies/cwrc#InstitutionalEducationContext</seealso>
    let InstitutionalEducationContext =
        Prefixed_Name(cwrc, "InstitutionalEducationContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:IntimateRelationshipsContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>intimate relationships context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#IntimateRelationshipsContext">http://sparql.cwrc.ca/ontologies/cwrc#IntimateRelationshipsContext</seealso>
    let IntimateRelationshipsContext =
        Prefixed_Name(cwrc, "IntimateRelationshipsContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>language</para><para>langue</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Language">http://sparql.cwrc.ca/ontologies/cwrc#Language</seealso>
    let Language = Prefixed_Name(cwrc, "Language") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:LanguageContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of class &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;forme culturelle en contexte&lt;/a&gt;.</para>
    /// labels<para>contexte linguistique</para><para>language context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#LanguageContext">http://sparql.cwrc.ca/ontologies/cwrc#LanguageContext</seealso>
    let LanguageContext = Prefixed_Name(cwrc, "LanguageContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:LinguisticAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Désapprouver sans équivalence.</para>
    ///   <para>Deprecated, with no current equivalence.</para>
    /// labels<para>linguistic ability (spoken and/or writen)</para><para>aptitude linguistique (écrit ou parlé)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#LinguisticAbility">http://sparql.cwrc.ca/ontologies/cwrc#LinguisticAbility</seealso>
    let LinguisticAbility = Prefixed_Name(cwrc, "LinguisticAbility") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:LiteraryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>literary name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#LiteraryName">http://sparql.cwrc.ca/ontologies/cwrc#LiteraryName</seealso>
    let LiteraryName = Prefixed_Name(cwrc, "LiteraryName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:LocalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>local name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#LocalName">http://sparql.cwrc.ca/ontologies/cwrc#LocalName</seealso>
    let LocalName = Prefixed_Name(cwrc, "LocalName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:MarriedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>married name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#MarriedName">http://sparql.cwrc.ca/ontologies/cwrc#MarriedName</seealso>
    let MarriedName = Prefixed_Name(cwrc, "MarriedName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:MentalHealthContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>mental health context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#MentalHealthContext">http://sparql.cwrc.ca/ontologies/cwrc#MentalHealthContext</seealso>
    let MentalHealthContext = Prefixed_Name(cwrc, "MentalHealthContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:NameContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>name context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#NameContext">http://sparql.cwrc.ca/ontologies/cwrc#NameContext</seealso>
    let NameContext = Prefixed_Name(cwrc, "NameContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:NameLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>name link</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#NameLink">http://sparql.cwrc.ca/ontologies/cwrc#NameLink</seealso>
    let NameLink = Prefixed_Name(cwrc, "NameLink") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PersonalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>personal name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PersonalName">http://sparql.cwrc.ca/ontologies/cwrc#PersonalName</seealso>
    let PersonalName = Prefixed_Name(cwrc, "PersonalName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:NationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>héritage national</para><para>national heritage</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#NationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#NationalHeritage</seealso>
    let NationalHeritage = Prefixed_Name(cwrc, "NationalHeritage") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:NationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>identité nationale</para><para>national identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#NationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#NationalIdentity</seealso>
    let NationalIdentity = Prefixed_Name(cwrc, "NationalIdentity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:NationalityContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>nationality context</para><para>contexte national</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#NationalityContext">http://sparql.cwrc.ca/ontologies/cwrc#NationalityContext</seealso>
    let NationalityContext = Prefixed_Name(cwrc, "NationalityContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>occupation</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Occupation">http://sparql.cwrc.ca/ontologies/cwrc#Occupation</seealso>
    let Occupation = Prefixed_Name(cwrc, "Occupation") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:OccupationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>occupation context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#OccupationContext">http://sparql.cwrc.ca/ontologies/cwrc#OccupationContext</seealso>
    let OccupationContext = Prefixed_Name(cwrc, "OccupationContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Oeuvre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>oeuvre</para><para>oeuvre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Oeuvre">http://sparql.cwrc.ca/ontologies/cwrc#Oeuvre</seealso>
    let Oeuvre = Prefixed_Name(cwrc, "Oeuvre") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Deprecated in favour of class &lt;a href="https://www.w3.org/TR/vocab-org/#class-formalorganization"&gt;org:formalOrganization&lt;/a&gt; </para>
    ///   <para></para>
    ///   <para></para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="https://www.w3.org/TR/vocab-org/#class-formalorganization"&gt;org:formalOrganization&lt;/a&gt;.</para>
    /// labels<para>organization</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Organization">http://sparql.cwrc.ca/ontologies/cwrc#Organization</seealso>
    let Organization = Prefixed_Name(cwrc, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:EventElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EventElement">http://sparql.cwrc.ca/ontologies/cwrc#EventElement</seealso>
    let EventElement = Prefixed_Name(cwrc, "EventElement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PeriodSignificance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>period significance</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PeriodSignificance">http://sparql.cwrc.ca/ontologies/cwrc#PeriodSignificance</seealso>
    let PeriodSignificance = Prefixed_Name(cwrc, "PeriodSignificance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Persona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>This definition is indebted to the Text Encoding Initiative's definition of the "persona" element. See &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persona.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persona.html"&gt;TEI element persona &lt;/a&gt;.</para>
    /// labels<para>persona</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Persona">http://sparql.cwrc.ca/ontologies/cwrc#Persona</seealso>
    let Persona = Prefixed_Name(cwrc, "Persona") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:PhysicalHealthContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>physical health context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PhysicalHealthContext">http://sparql.cwrc.ca/ontologies/cwrc#PhysicalHealthContext</seealso>
    let PhysicalHealthContext =
        Prefixed_Name(cwrc, "PhysicalHealthContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:PoliticalClimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>political climate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalClimate">http://sparql.cwrc.ca/ontologies/cwrc#PoliticalClimate</seealso>
    let PoliticalClimate = Prefixed_Name(cwrc, "PoliticalClimate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PoliticalContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>contexte politique</para><para>politics context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalContext">http://sparql.cwrc.ca/ontologies/cwrc#PoliticalContext</seealso>
    let PoliticalContext = Prefixed_Name(cwrc, "PoliticalContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:PoliticalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>political organization</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalOrganization">http://sparql.cwrc.ca/ontologies/cwrc#PoliticalOrganization</seealso>
    let PoliticalOrganization =
        Prefixed_Name(cwrc, "PoliticalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:PostSecondarySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>post-secondary school</para><para>post-secondary school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PostSecondarySchool">http://sparql.cwrc.ca/ontologies/cwrc#PostSecondarySchool</seealso>
    let PostSecondarySchool = Prefixed_Name(cwrc, "PostSecondarySchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PreferredName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>preferred name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PreferredName">http://sparql.cwrc.ca/ontologies/cwrc#PreferredName</seealso>
    let PreferredName = Prefixed_Name(cwrc, "PreferredName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:rangeIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>range includes</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#rangeIncludes">http://sparql.cwrc.ca/ontologies/cwrc#rangeIncludes</seealso>
    let rangeIncludes = Prefixed_Name(cwrc, "rangeIncludes") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PrepSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>école préparatoire</para><para>prep school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PrepSchool">http://sparql.cwrc.ca/ontologies/cwrc#PrepSchool</seealso>
    let PrepSchool = Prefixed_Name(cwrc, "PrepSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PrimarySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>primary school</para><para>école primaire</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PrimarySchool">http://sparql.cwrc.ca/ontologies/cwrc#PrimarySchool</seealso>
    let PrimarySchool = Prefixed_Name(cwrc, "PrimarySchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PrivateSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>private school</para><para>école privée</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PrivateSchool">http://sparql.cwrc.ca/ontologies/cwrc#PrivateSchool</seealso>
    let PrivateSchool = Prefixed_Name(cwrc, "PrivateSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ProfessionalTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>professional title</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ProfessionalTitle">http://sparql.cwrc.ca/ontologies/cwrc#ProfessionalTitle</seealso>
    let ProfessionalTitle = Prefixed_Name(cwrc, "ProfessionalTitle") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:RoleName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>role name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#RoleName">http://sparql.cwrc.ca/ontologies/cwrc#RoleName</seealso>
    let RoleName = Prefixed_Name(cwrc, "RoleName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Pseudonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pseudonym</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Pseudonym">http://sparql.cwrc.ca/ontologies/cwrc#Pseudonym</seealso>
    let Pseudonym = Prefixed_Name(cwrc, "Pseudonym") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:PunctiveTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>sem:TimeType</para>
    ///
    /// labels<para>punctive time</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#PunctiveTime">http://sparql.cwrc.ca/ontologies/cwrc#PunctiveTime</seealso>
    let PunctiveTime = Prefixed_Name(cwrc, "PunctiveTime") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:RaceEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Deprecated in favour of class &lt;a href="#RaceColour" title="#RaceColour"&gt;race or colour&lt;/a&gt; and &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicity&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#RaceColour" title="#RaceColour"&gt;race ou couleur&lt;/a&gt; et &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicité&lt;/a&gt;.</para>
    /// labels<para>race or ethnicity</para><para>race ou ethnicité</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#RaceEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#RaceEthnicity</seealso>
    let RaceEthnicity = Prefixed_Name(cwrc, "RaceEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Religion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>religion</para><para>religion</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Religion">http://sparql.cwrc.ca/ontologies/cwrc#Religion</seealso>
    let Religion = Prefixed_Name(cwrc, "Religion") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ReligionContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>contexte religieux</para><para>religious context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ReligionContext">http://sparql.cwrc.ca/ontologies/cwrc#ReligionContext</seealso>
    let ReligionContext = Prefixed_Name(cwrc, "ReligionContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ReligiousOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>religious organization</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ReligiousOrganization">http://sparql.cwrc.ca/ontologies/cwrc#ReligiousOrganization</seealso>
    let ReligiousOrganization =
        Prefixed_Name(cwrc, "ReligiousOrganization") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ReligiousSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>école non laïque</para><para>religious school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ReligiousSchool">http://sparql.cwrc.ca/ontologies/cwrc#ReligiousSchool</seealso>
    let ReligiousSchool = Prefixed_Name(cwrc, "ReligiousSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ReligousName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>religious name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ReligousName">http://sparql.cwrc.ca/ontologies/cwrc#ReligousName</seealso>
    let ReligousName = Prefixed_Name(cwrc, "ReligousName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ReproductiveHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reproductive history</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ReproductiveHistory">http://sparql.cwrc.ca/ontologies/cwrc#ReproductiveHistory</seealso>
    let ReproductiveHistory = Prefixed_Name(cwrc, "ReproductiveHistory") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:RomanceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>romance name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#RomanceName">http://sparql.cwrc.ca/ontologies/cwrc#RomanceName</seealso>
    let RomanceName = Prefixed_Name(cwrc, "RomanceName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:RoyalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>royal name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#RoyalName">http://sparql.cwrc.ca/ontologies/cwrc#RoyalName</seealso>
    let RoyalName = Prefixed_Name(cwrc, "RoyalName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Scholarship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>scholarship</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Scholarship">http://sparql.cwrc.ca/ontologies/cwrc#Scholarship</seealso>
    let Scholarship = Prefixed_Name(cwrc, "Scholarship") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:SecondaryModernSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>école secondaire moderne</para><para>secondary modern school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SecondaryModernSchool">http://sparql.cwrc.ca/ontologies/cwrc#SecondaryModernSchool</seealso>
    let SecondaryModernSchool =
        Prefixed_Name(cwrc, "SecondaryModernSchool") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:SecondarySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>secondary school</para><para>collège</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SecondarySchool">http://sparql.cwrc.ca/ontologies/cwrc#SecondarySchool</seealso>
    let SecondarySchool = Prefixed_Name(cwrc, "SecondarySchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SecularSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>secular school</para><para>école laïque</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SecularSchool">http://sparql.cwrc.ca/ontologies/cwrc#SecularSchool</seealso>
    let SecularSchool = Prefixed_Name(cwrc, "SecularSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SelfConstructedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>self constructed name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SelfConstructedName">http://sparql.cwrc.ca/ontologies/cwrc#SelfConstructedName</seealso>
    let SelfConstructedName = Prefixed_Name(cwrc, "SelfConstructedName") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:SelfTaughtEducationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>contexte éducatif autodidacte</para><para>self taught education context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SelfTaughtEducationContext">http://sparql.cwrc.ca/ontologies/cwrc#SelfTaughtEducationContext</seealso>
    let SelfTaughtEducationContext =
        Prefixed_Name(cwrc, "SelfTaughtEducationContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:SexIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Deprecated in favour of class &lt;a href="#Gender" title="#Gender"&gt;gender&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#Gender" title="#Gender"&gt;genre&lt;/a&gt;.</para>
    /// labels<para>identité sexe</para><para>sex identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SexIdentity">http://sparql.cwrc.ca/ontologies/cwrc#SexIdentity</seealso>
    let SexIdentity = Prefixed_Name(cwrc, "SexIdentity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SexualIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of &lt;a href="#Sexuality" title="#Sexuality"&gt;sexuality&lt;/a&gt; term.</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#Sexuality" title="#Sexuality"&gt;sexualité&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of class &lt;a href="#Sexuality" title="#Sexuality"&gt;sexuality&lt;/a&gt;.</para>
    /// labels<para>Identité Sexuelle</para><para>Sexual Identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SexualIdentity">http://sparql.cwrc.ca/ontologies/cwrc#SexualIdentity</seealso>
    let SexualIdentity = Prefixed_Name(cwrc, "SexualIdentity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Sexuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>sexuality</para><para>sexualité</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Sexuality">http://sparql.cwrc.ca/ontologies/cwrc#Sexuality</seealso>
    let Sexuality = Prefixed_Name(cwrc, "Sexuality") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SocialClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>classe sociale</para><para>social class</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClass">http://sparql.cwrc.ca/ontologies/cwrc#SocialClass</seealso>
    let SocialClass = Prefixed_Name(cwrc, "SocialClass") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SocialClassContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>social class context</para><para>contexte social</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClassContext">http://sparql.cwrc.ca/ontologies/cwrc#SocialClassContext</seealso>
    let SocialClassContext = Prefixed_Name(cwrc, "SocialClassContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SocialClassIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Deprecated in favour of class &lt;a href="#SocialClass" title="#SocialClass"&gt;social class&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#SocialClass" title="#SocialClass"&gt;classe sociale&lt;/a&gt;.</para>
    /// labels<para>identité classe sociale</para><para>social class identity</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClassIdentity">http://sparql.cwrc.ca/ontologies/cwrc#SocialClassIdentity</seealso>
    let SocialClassIdentity = Prefixed_Name(cwrc, "SocialClassIdentity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SocialClimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>social climate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClimate">http://sparql.cwrc.ca/ontologies/cwrc#SocialClimate</seealso>
    let SocialClimate = Prefixed_Name(cwrc, "SocialClimate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SpatialContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>spatial context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SpatialContext">http://sparql.cwrc.ca/ontologies/cwrc#SpatialContext</seealso>
    let SpatialContext = Prefixed_Name(cwrc, "SpatialContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:StateSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>state school</para><para>state school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#StateSchool">http://sparql.cwrc.ca/ontologies/cwrc#StateSchool</seealso>
    let StateSchool = Prefixed_Name(cwrc, "StateSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:StyledName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>styled name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#StyledName">http://sparql.cwrc.ca/ontologies/cwrc#StyledName</seealso>
    let StyledName = Prefixed_Name(cwrc, "StyledName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Surname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>surname</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Surname">http://sparql.cwrc.ca/ontologies/cwrc#Surname</seealso>
    let Surname = Prefixed_Name(cwrc, "Surname") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:SystemName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>system name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SystemName">http://sparql.cwrc.ca/ontologies/cwrc#SystemName</seealso>
    let SystemName = Prefixed_Name(cwrc, "SystemName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:TitledName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>titled name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#TitledName">http://sparql.cwrc.ca/ontologies/cwrc#TitledName</seealso>
    let TitledName = Prefixed_Name(cwrc, "TitledName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:TradeSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>lycée professionnel</para><para>trade school</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#TradeSchool">http://sparql.cwrc.ca/ontologies/cwrc#TradeSchool</seealso>
    let TradeSchool = Prefixed_Name(cwrc, "TradeSchool") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ViolenceContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>violence context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ViolenceContext">http://sparql.cwrc.ca/ontologies/cwrc#ViolenceContext</seealso>
    let ViolenceContext = Prefixed_Name(cwrc, "ViolenceContext") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:WealthContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>wealth context</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#WealthContext">http://sparql.cwrc.ca/ontologies/cwrc#WealthContext</seealso>
    let WealthContext = Prefixed_Name(cwrc, "WealthContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899 =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899_4ee64522b2 =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899-588ae315d6</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-588ae315d6">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-588ae315d6</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899_588ae315d6 =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899-588ae315d6") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899-9856975261</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-9856975261">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-9856975261</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899_9856975261 =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899-9856975261") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899_b3f841f5c0 =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899-dc53f66118</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-dc53f66118">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-dc53f66118</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899_dc53f66118 =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899-dc53f66118") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Proceedings</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-partof">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-partof</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899_partof =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92">http://sparql.cwrc.ca/ontologies/cwrc#a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92</seealso>
    let a5686049_f450_415c_9ca6_deee26e30899_partof_79e6794d92 =
        Prefixed_Name(cwrc, "a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a647a149-3420-4a0d-8462-03900131060e</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e">http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e</seealso>
    let a647a149_3420_4a0d_8462_03900131060e =
        Prefixed_Name(cwrc, "a647a149-3420-4a0d-8462-03900131060e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:a647a149-3420-4a0d-8462-03900131060e-d623563918</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-d623563918">http://sparql.cwrc.ca/ontologies/cwrc#a647a149-3420-4a0d-8462-03900131060e-d623563918</seealso>
    let a647a149_3420_4a0d_8462_03900131060e_d623563918 =
        Prefixed_Name(cwrc, "a647a149-3420-4a0d-8462-03900131060e-d623563918") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-Zionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>anti-Zionism</para><para>Antisionisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Zionism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Zionism</seealso>
    let anti_Zionism = Prefixed_Name(cwrc, "anti-Zionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:zionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Sionisme</para><para>Zionism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#zionism">http://sparql.cwrc.ca/ontologies/cwrc#zionism</seealso>
    let zionism = Prefixed_Name(cwrc, "zionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-masonry</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>antimaçonnisme</para><para>anti-masonry</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-masonry">http://sparql.cwrc.ca/ontologies/cwrc#anti-masonry</seealso>
    let anti_masonry = Prefixed_Name(cwrc, "anti-masonry") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:antiClericalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>anticléricalisme</para><para>anti-clericalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#antiClericalism">http://sparql.cwrc.ca/ontologies/cwrc#antiClericalism</seealso>
    let antiClericalism = Prefixed_Name(cwrc, "antiClericalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:methodism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///
    /// labels<para>Église méthodiste</para><para>Methodism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#methodism">http://sparql.cwrc.ca/ontologies/cwrc#methodism</seealso>
    let methodism = Prefixed_Name(cwrc, "methodism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:disestablishmentarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>disestablishmentarianism</para><para>sécularisme anglais</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#disestablishmentarianism">http://sparql.cwrc.ca/ontologies/cwrc#disestablishmentarianism</seealso>
    let disestablishmentarianism =
        Prefixed_Name(cwrc, "disestablishmentarianism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:appeasement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>politique d'apaisement</para><para>appeasement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#appeasement">http://sparql.cwrc.ca/ontologies/cwrc#appeasement</seealso>
    let appeasement = Prefixed_Name(cwrc, "appeasement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:appraiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>appraiser</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#appraiser">http://sparql.cwrc.ca/ontologies/cwrc#appraiser</seealso>
    let appraiser = Prefixed_Name(cwrc, "appraiser") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:arabEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Arabe</para><para>Arab</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#arabEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#arabEthnicity</seealso>
    let arabEthnicity = Prefixed_Name(cwrc, "arabEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:archaeologist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>archaeologist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#archaeologist">http://sparql.cwrc.ca/ontologies/cwrc#archaeologist</seealso>
    let archaeologist = Prefixed_Name(cwrc, "archaeologist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:archivist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>archivist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#archivist">http://sparql.cwrc.ca/ontologies/cwrc#archivist</seealso>
    let archivist = Prefixed_Name(cwrc, "archivist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:librarian</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>librarian</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#librarian">http://sparql.cwrc.ca/ontologies/cwrc#librarian</seealso>
    let librarian = Prefixed_Name(cwrc, "librarian") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:aristocrat</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>aristocrat</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aristocrat">http://sparql.cwrc.ca/ontologies/cwrc#aristocrat</seealso>
    let aristocrat = Prefixed_Name(cwrc, "aristocrat") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:army</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>army</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#army">http://sparql.cwrc.ca/ontologies/cwrc#army</seealso>
    let army = Prefixed_Name(cwrc, "army") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:artsAdministrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>arts manager</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#artsAdministrator">http://sparql.cwrc.ca/ontologies/cwrc#artsAdministrator</seealso>
    let artsAdministrator = Prefixed_Name(cwrc, "artsAdministrator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>manager</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#manager">http://sparql.cwrc.ca/ontologies/cwrc#manager</seealso>
    let manager = Prefixed_Name(cwrc, "manager") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:artsAdvocacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>défense des arts</para><para>arts advocacy</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#artsAdvocacy">http://sparql.cwrc.ca/ontologies/cwrc#artsAdvocacy</seealso>
    let artsAdvocacy = Prefixed_Name(cwrc, "artsAdvocacy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:artsAdvocate</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>literature advocate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#artsAdvocate">http://sparql.cwrc.ca/ontologies/cwrc#artsAdvocate</seealso>
    let artsAdvocate = Prefixed_Name(cwrc, "artsAdvocate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:asceticism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>asceticism</para><para>ascèse</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#asceticism">http://sparql.cwrc.ca/ontologies/cwrc#asceticism</seealso>
    let asceticism = Prefixed_Name(cwrc, "asceticism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ashkenaziJewishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Ashkenazi Jewish</para><para>Juif ashkénaze</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ashkenaziJewishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#ashkenaziJewishEthnicity</seealso>
    let ashkenaziJewishEthnicity =
        Prefixed_Name(cwrc, "ashkenaziJewishEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:asianRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Asiatique</para><para>Asian</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#asianRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#asianRaceColour</seealso>
    let asianRaceColour = Prefixed_Name(cwrc, "asianRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:associationInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>association involvement</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#associationInvolvement">http://sparql.cwrc.ca/ontologies/cwrc#associationInvolvement</seealso>
    let associationInvolvement =
        Prefixed_Name(cwrc, "associationInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:astronomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>astronomer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#astronomer">http://sparql.cwrc.ca/ontologies/cwrc#astronomer</seealso>
    let astronomer = Prefixed_Name(cwrc, "astronomer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:scientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>scientist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#scientist">http://sparql.cwrc.ca/ontologies/cwrc#scientist</seealso>
    let scientist = Prefixed_Name(cwrc, "scientist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:atheism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>athéisme</para><para>atheism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#atheism">http://sparql.cwrc.ca/ontologies/cwrc#atheism</seealso>
    let atheism = Prefixed_Name(cwrc, "atheism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:attends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>scolarisation</para><para>attends</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#attends">http://sparql.cwrc.ca/ontologies/cwrc#attends</seealso>
    let attends = Prefixed_Name(cwrc, "attends") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:School</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#School">http://sparql.cwrc.ca/ontologies/cwrc#School</seealso>
    let School = Prefixed_Name(cwrc, "School") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a un·e étudiant·e</para><para>has student</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStudent">http://sparql.cwrc.ca/ontologies/cwrc#hasStudent</seealso>
    let hasStudent = Prefixed_Name(cwrc, "hasStudent") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:attendsPostSecondarySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>attends post-secondary school</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#attendsPostSecondarySchool">http://sparql.cwrc.ca/ontologies/cwrc#attendsPostSecondarySchool</seealso>
    let attendsPostSecondarySchool =
        Prefixed_Name(cwrc, "attendsPostSecondarySchool") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:attendsPrimarySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>attends primary school</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#attendsPrimarySchool">http://sparql.cwrc.ca/ontologies/cwrc#attendsPrimarySchool</seealso>
    let attendsPrimarySchool =
        Prefixed_Name(cwrc, "attendsPrimarySchool") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:attendsSecondarySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>attends secondary school</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#attendsSecondarySchool">http://sparql.cwrc.ca/ontologies/cwrc#attendsSecondarySchool</seealso>
    let attendsSecondarySchool =
        Prefixed_Name(cwrc, "attendsSecondarySchool") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:attorneyGeneral</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>attorney general</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#attorneyGeneral">http://sparql.cwrc.ca/ontologies/cwrc#attorneyGeneral</seealso>
    let attorneyGeneral = Prefixed_Name(cwrc, "attorneyGeneral") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:governmentOfficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>government official</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#governmentOfficial">http://sparql.cwrc.ca/ontologies/cwrc#governmentOfficial</seealso>
    let governmentOfficial = Prefixed_Name(cwrc, "governmentOfficial") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:auctioneer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>auctioneer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#auctioneer">http://sparql.cwrc.ca/ontologies/cwrc#auctioneer</seealso>
    let auctioneer = Prefixed_Name(cwrc, "auctioneer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:auntOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>tante de</para><para>aunt of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#auntOf">http://sparql.cwrc.ca/ontologies/cwrc#auntOf</seealso>
    let auntOf = Prefixed_Name(cwrc, "auntOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasAunt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has aunt</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasAunt">http://sparql.cwrc.ca/ontologies/cwrc#hasAunt</seealso>
    let hasAunt = Prefixed_Name(cwrc, "hasAunt") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:automobileIndustry</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>automobileIndustry</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#automobileIndustry">http://sparql.cwrc.ca/ontologies/cwrc#automobileIndustry</seealso>
    let automobileIndustry = Prefixed_Name(cwrc, "automobileIndustry") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b736fb3c-dcde-49f3-aa07-67ce6a42100a</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a">http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a</seealso>
    let b736fb3c_dcde_49f3_aa07_67ce6a42100a =
        Prefixed_Name(cwrc, "b736fb3c-dcde-49f3-aa07-67ce6a42100a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1">http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1</seealso>
    let b736fb3c_dcde_49f3_aa07_67ce6a42100a_1ca90e57c1 =
        Prefixed_Name(cwrc, "b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof">http://sparql.cwrc.ca/ontologies/cwrc#b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof</seealso>
    let b736fb3c_dcde_49f3_aa07_67ce6a42100a_partof =
        Prefixed_Name(cwrc, "b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b95a3e61-23f6-4603-bb6b-06703aceb3c9</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9">http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9</seealso>
    let b95a3e61_23f6_4603_bb6b_06703aceb3c9 =
        Prefixed_Name(cwrc, "b95a3e61-23f6-4603-bb6b-06703aceb3c9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51">http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51</seealso>
    let b95a3e61_23f6_4603_bb6b_06703aceb3c9_b531d0ad51 =
        Prefixed_Name(cwrc, "b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9">http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9</seealso>
    let b95a3e61_23f6_4603_bb6b_06703aceb3c9_318cb143c9 =
        Prefixed_Name(cwrc, "b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c">http://sparql.cwrc.ca/ontologies/cwrc#b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c</seealso>
    let b95a3e61_23f6_4603_bb6b_06703aceb3c9_16ff462e2c =
        Prefixed_Name(cwrc, "b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b9eeccf9-9380-4341-99dc-a83f5ee32909</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909">http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909</seealso>
    let b9eeccf9_9380_4341_99dc_a83f5ee32909 =
        Prefixed_Name(cwrc, "b9eeccf9-9380-4341-99dc-a83f5ee32909") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604">http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604</seealso>
    let b9eeccf9_9380_4341_99dc_a83f5ee32909_f7b703e604 =
        Prefixed_Name(cwrc, "b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:b9eeccf9-9380-4341-99dc-a83f5ee32909-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909-partof">http://sparql.cwrc.ca/ontologies/cwrc#b9eeccf9-9380-4341-99dc-a83f5ee32909-partof</seealso>
    let b9eeccf9_9380_4341_99dc_a83f5ee32909_partof =
        Prefixed_Name(cwrc, "b9eeccf9-9380-4341-99dc-a83f5ee32909-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bachelorOfArts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Baccalauréat universitaire ès lettres</para><para>B.A.</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bachelorOfArts">http://sparql.cwrc.ca/ontologies/cwrc#bachelorOfArts</seealso>
    let bachelorOfArts = Prefixed_Name(cwrc, "bachelorOfArts") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bachelorOfScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Credential</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Baccalauréat universitaire en sciences</para><para>B.Sc.</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bachelorOfScience">http://sparql.cwrc.ca/ontologies/cwrc#bachelorOfScience</seealso>
    let bachelorOfScience = Prefixed_Name(cwrc, "bachelorOfScience") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:baker</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>baker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#baker">http://sparql.cwrc.ca/ontologies/cwrc#baker</seealso>
    let baker = Prefixed_Name(cwrc, "baker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:skilledTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>skilled trade</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#skilledTrade">http://sparql.cwrc.ca/ontologies/cwrc#skilledTrade</seealso>
    let skilledTrade = Prefixed_Name(cwrc, "skilledTrade") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bankrupt</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>bankrupt</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bankrupt">http://sparql.cwrc.ca/ontologies/cwrc#bankrupt</seealso>
    let bankrupt = Prefixed_Name(cwrc, "bankrupt") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:baptistChristianity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Baptist Christianity</para><para>chin li tsung</para><para>jìn lǐ zōng</para><para>jin li zong</para><para>Baptistas</para><para>Baptisme</para><para>Baptisme</para><para>Baptismo</para><para>浸信會</para><para>浸禮宗</para><para>浸禮派</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#baptistChristianity">http://sparql.cwrc.ca/ontologies/cwrc#baptistChristianity</seealso>
    let baptistChristianity = Prefixed_Name(cwrc, "baptistChristianity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dissentProtestant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>dissidents (ou non-conformistes)</para><para>Dissent (Protestant)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dissentProtestant">http://sparql.cwrc.ca/ontologies/cwrc#dissentProtestant</seealso>
    let dissentProtestant = Prefixed_Name(cwrc, "dissentProtestant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:baptistChurch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#baptistChristianity" title="#baptistChristianity"&gt;Baptist Christianity&lt;/a&gt;.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#baptistChristianity" title="#baptistChristianity"&gt;Baptisme&lt;/a&gt;.</para>
    /// labels<para>chin li tsung</para><para>jìn lǐ zōng</para><para>jin li zong</para><para>Baptistas</para><para>Baptisme</para><para>Baptismo</para><para>Baptisme</para><para>Baptist</para><para>浸信會</para><para>浸禮宗</para><para>浸禮派</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#baptistChurch">http://sparql.cwrc.ca/ontologies/cwrc#baptistChurch</seealso>
    let baptistChurch = Prefixed_Name(cwrc, "baptistChurch") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bd6e0e18-2543-4310-94da-aae6557df17d</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d">http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d</seealso>
    let bd6e0e18_2543_4310_94da_aae6557df17d =
        Prefixed_Name(cwrc, "bd6e0e18-2543-4310-94da-aae6557df17d") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1">http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1</seealso>
    let bd6e0e18_2543_4310_94da_aae6557df17d_a4adea3de1 =
        Prefixed_Name(cwrc, "bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a">http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a</seealso>
    let bd6e0e18_2543_4310_94da_aae6557df17d_696c1e861a =
        Prefixed_Name(cwrc, "bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2">http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2</seealso>
    let bd6e0e18_2543_4310_94da_aae6557df17d_8a2569e7f2 =
        Prefixed_Name(cwrc, "bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf">http://sparql.cwrc.ca/ontologies/cwrc#bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf</seealso>
    let bd6e0e18_2543_4310_94da_aae6557df17d_7bc3557dcf =
        Prefixed_Name(cwrc, "bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bdfac2f5-ae45-4af7-941c-ec37b12f1a38</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38">http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38</seealso>
    let bdfac2f5_ae45_4af7_941c_ec37b12f1a38 =
        Prefixed_Name(cwrc, "bdfac2f5-ae45-4af7-941c-ec37b12f1a38") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:indigent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>indigent•e•s</para><para>indigent</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#indigent">http://sparql.cwrc.ca/ontologies/cwrc#indigent</seealso>
    let indigent = Prefixed_Name(cwrc, "indigent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:behemenism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Behemenism</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#behemenism">http://sparql.cwrc.ca/ontologies/cwrc#behemenism</seealso>
    let behemenism = Prefixed_Name(cwrc, "behemenism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:benedictineOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Ordre de Saint-Benoît</para><para>Benedictine Order</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#benedictineOrder">http://sparql.cwrc.ca/ontologies/cwrc#benedictineOrder</seealso>
    let benedictineOrder = Prefixed_Name(cwrc, "benedictineOrder") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:catholicism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    /// labels<para>Rooms-Katholicisme</para><para>Catolicismo Romano</para><para>Roman Catholicism</para><para>Katholicisme</para><para>Catholicisme</para><para>Catolicismo</para><para>Katholiek</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#catholicism">http://sparql.cwrc.ca/ontologies/cwrc#catholicism</seealso>
    let catholicism = Prefixed_Name(cwrc, "catholicism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bengaliEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Bengali</para><para>bengali</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bengaliEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#bengaliEthnicity</seealso>
    let bengaliEthnicity = Prefixed_Name(cwrc, "bengaliEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bengaliNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>bengali</para><para>Bengale</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bengaliNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#bengaliNationalHeritage</seealso>
    let bengaliNationalHeritage =
        Prefixed_Name(cwrc, "bengaliNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Collection</para>
    ///
    /// labels<para>La bibliographie de l'ontologie CWRC</para><para>The CWRC ontology bibliography</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bibliography">http://sparql.cwrc.ca/ontologies/cwrc#bibliography</seealso>
    let bibliography = Prefixed_Name(cwrc, "bibliography") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bibliophile</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>bibliophile</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bibliophile">http://sparql.cwrc.ca/ontologies/cwrc#bibliophile</seealso>
    let bibliophile = Prefixed_Name(cwrc, "bibliophile") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:billCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>bill collector</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#billCollector">http://sparql.cwrc.ca/ontologies/cwrc#billCollector</seealso>
    let billCollector = Prefixed_Name(cwrc, "billCollector") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:biologist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>biologist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#biologist">http://sparql.cwrc.ca/ontologies/cwrc#biologist</seealso>
    let biologist = Prefixed_Name(cwrc, "biologist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:lifeScientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>life scientist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#lifeScientist">http://sparql.cwrc.ca/ontologies/cwrc#lifeScientist</seealso>
    let lifeScientist = Prefixed_Name(cwrc, "lifeScientist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:birthControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>birth control</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#birthControl">http://sparql.cwrc.ca/ontologies/cwrc#birthControl</seealso>
    let birthControl = Prefixed_Name(cwrc, "birthControl") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:birthControlActivism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>défense du contrôle des naissances</para><para>birth control activism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#birthControlActivism">http://sparql.cwrc.ca/ontologies/cwrc#birthControlActivism</seealso>
    let birthControlActivism =
        Prefixed_Name(cwrc, "birthControlActivism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:sexualReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>révolution sexuelle</para><para>sexual reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sexualReform">http://sparql.cwrc.ca/ontologies/cwrc#sexualReform</seealso>
    let sexualReform = Prefixed_Name(cwrc, "sexualReform") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pro-Choice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Mouvement pro-choix</para><para>pro-choice</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pro-Choice">http://sparql.cwrc.ca/ontologies/cwrc#pro-Choice</seealso>
    let pro_Choice = Prefixed_Name(cwrc, "pro-Choice") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:birthDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>birth date of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#birthDateOf">http://sparql.cwrc.ca/ontologies/cwrc#birthDateOf</seealso>
    let birthDateOf = Prefixed_Name(cwrc, "birthDateOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasBirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has birth date</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthDate">http://sparql.cwrc.ca/ontologies/cwrc#hasBirthDate</seealso>
    let hasBirthDate = Prefixed_Name(cwrc, "hasBirthDate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:birthPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>birth place of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#birthPlaceOf">http://sparql.cwrc.ca/ontologies/cwrc#birthPlaceOf</seealso>
    let birthPlaceOf = Prefixed_Name(cwrc, "birthPlaceOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>represents</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#represents">http://sparql.cwrc.ca/ontologies/cwrc#represents</seealso>
    let represents = Prefixed_Name(cwrc, "represents") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:blackNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>nationalisme Noir</para><para>Black nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#blackNationalism">http://sparql.cwrc.ca/ontologies/cwrc#blackNationalism</seealso>
    let blackNationalism = Prefixed_Name(cwrc, "blackNationalism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:blackWomanRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Gender</para>
    ///   <para>cwrc:RaceColour</para>
    ///
    /// labels<para>femme noire</para><para>blackwoman</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#blackWomanRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#blackWomanRaceColour</seealso>
    let blackWomanRaceColour =
        Prefixed_Name(cwrc, "blackWomanRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:blacksmith</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>blacksmith</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#blacksmith">http://sparql.cwrc.ca/ontologies/cwrc#blacksmith</seealso>
    let blacksmith = Prefixed_Name(cwrc, "blacksmith") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bloodRelativeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver sans équivalence.</para>
    ///   <para>Deprecated, with no current equivalence, in favour of definition of family relationships as more fluid and expansive than blood relations.</para>
    /// labels<para>blood relative of</para><para>liens de sang</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bloodRelativeOf">http://sparql.cwrc.ca/ontologies/cwrc#bloodRelativeOf</seealso>
    let bloodRelativeOf = Prefixed_Name(cwrc, "bloodRelativeOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:boardMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>board member</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#boardMember">http://sparql.cwrc.ca/ontologies/cwrc#boardMember</seealso>
    let boardMember = Prefixed_Name(cwrc, "boardMember") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:boardingHouseKeeper</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>boarding house keeper</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#boardingHouseKeeper">http://sparql.cwrc.ca/ontologies/cwrc#boardingHouseKeeper</seealso>
    let boardingHouseKeeper = Prefixed_Name(cwrc, "boardingHouseKeeper") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:housekeeper</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>housekeeper</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#housekeeper">http://sparql.cwrc.ca/ontologies/cwrc#housekeeper</seealso>
    let housekeeper = Prefixed_Name(cwrc, "housekeeper") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bohemianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Bohemianism</para><para>Bohème</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bohemianism">http://sparql.cwrc.ca/ontologies/cwrc#bohemianism</seealso>
    let bohemianism = Prefixed_Name(cwrc, "bohemianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bookProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>book production</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bookProduction">http://sparql.cwrc.ca/ontologies/cwrc#bookProduction</seealso>
    let bookProduction = Prefixed_Name(cwrc, "bookProduction") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:publishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>publishing</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#publishing">http://sparql.cwrc.ca/ontologies/cwrc#publishing</seealso>
    let publishing = Prefixed_Name(cwrc, "publishing") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bookbinder</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>bookbinder</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bookbinder">http://sparql.cwrc.ca/ontologies/cwrc#bookbinder</seealso>
    let bookbinder = Prefixed_Name(cwrc, "bookbinder") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bookclubParticipatant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>bookclub participation</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bookclubParticipatant">http://sparql.cwrc.ca/ontologies/cwrc#bookclubParticipatant</seealso>
    let bookclubParticipatant =
        Prefixed_Name(cwrc, "bookclubParticipatant") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:brewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>brewer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#brewer">http://sparql.cwrc.ca/ontologies/cwrc#brewer</seealso>
    let brewer = Prefixed_Name(cwrc, "brewer") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:britishNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Brittaniques</para><para>British</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#britishNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#britishNationalIdentity</seealso>
    let britishNationalIdentity =
        Prefixed_Name(cwrc, "britishNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:britishNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>nationalisme anglais</para><para>British nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#britishNationalism">http://sparql.cwrc.ca/ontologies/cwrc#britishNationalism</seealso>
    let britishNationalism = Prefixed_Name(cwrc, "britishNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:broadcasting</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>broadcaster</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#broadcasting">http://sparql.cwrc.ca/ontologies/cwrc#broadcasting</seealso>
    let broadcasting = Prefixed_Name(cwrc, "broadcasting") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:brotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>brother of</para><para>frère de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#brotherOf">http://sparql.cwrc.ca/ontologies/cwrc#brotherOf</seealso>
    let brotherOf = Prefixed_Name(cwrc, "brotherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:siblingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frères et soeurs de</para><para>sibling of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#siblingOf">http://sparql.cwrc.ca/ontologies/cwrc#siblingOf</seealso>
    let siblingOf = Prefixed_Name(cwrc, "siblingOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasBrother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has brother</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasBrother">http://sparql.cwrc.ca/ontologies/cwrc#hasBrother</seealso>
    let hasBrother = Prefixed_Name(cwrc, "hasBrother") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:buddhism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Bouddhisme</para><para>Boeddhisme</para><para>Buddhism</para><para>fo chiao</para><para>fó jiào</para><para>fo jiao</para><para>Budismo</para><para>佛教</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#buddhism">http://sparql.cwrc.ca/ontologies/cwrc#buddhism</seealso>
    let buddhism = Prefixed_Name(cwrc, "buddhism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bullionCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>bullion carrier</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bullionCarrier">http://sparql.cwrc.ca/ontologies/cwrc#bullionCarrier</seealso>
    let bullionCarrier = Prefixed_Name(cwrc, "bullionCarrier") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:burialPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>burial place of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#burialPlaceOf">http://sparql.cwrc.ca/ontologies/cwrc#burialPlaceOf</seealso>
    let burialPlaceOf = Prefixed_Name(cwrc, "burialPlaceOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasBurialPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has burial place</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasBurialPlace">http://sparql.cwrc.ca/ontologies/cwrc#hasBurialPlace</seealso>
    let hasBurialPlace = Prefixed_Name(cwrc, "hasBurialPlace") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bursar</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>bursar</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bursar">http://sparql.cwrc.ca/ontologies/cwrc#bursar</seealso>
    let bursar = Prefixed_Name(cwrc, "bursar") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bushido</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Bushido</para><para>Bushido</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bushido">http://sparql.cwrc.ca/ontologies/cwrc#bushido</seealso>
    let bushido = Prefixed_Name(cwrc, "bushido") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:business</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>business</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#business">http://sparql.cwrc.ca/ontologies/cwrc#business</seealso>
    let business = Prefixed_Name(cwrc, "business") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c1583789-0dad-41d3-8a42-94d7a8e6d451</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c1583789-0dad-41d3-8a42-94d7a8e6d451">http://sparql.cwrc.ca/ontologies/cwrc#c1583789-0dad-41d3-8a42-94d7a8e6d451</seealso>
    let c1583789_0dad_41d3_8a42_94d7a8e6d451 =
        Prefixed_Name(cwrc, "c1583789-0dad-41d3-8a42-94d7a8e6d451") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c3a52178-f054-494c-9afd-7421ddcb384a</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a">http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a</seealso>
    let c3a52178_f054_494c_9afd_7421ddcb384a =
        Prefixed_Name(cwrc, "c3a52178-f054-494c-9afd-7421ddcb384a") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9</seealso>
    let c3a52178_f054_494c_9afd_7421ddcb384a_215ee9c7d9 =
        Prefixed_Name(cwrc, "c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c3a52178-f054-494c-9afd-7421ddcb384a-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Proceedings</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a-partof">http://sparql.cwrc.ca/ontologies/cwrc#c3a52178-f054-494c-9afd-7421ddcb384a-partof</seealso>
    let c3a52178_f054_494c_9afd_7421ddcb384a_partof =
        Prefixed_Name(cwrc, "c3a52178-f054-494c-9afd-7421ddcb384a-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c5e7bace-95bb-4820-bd7d-6bb97c1badc5">http://sparql.cwrc.ca/ontologies/cwrc#c5e7bace-95bb-4820-bd7d-6bb97c1badc5</seealso>
    let c5e7bace_95bb_4820_bd7d_6bb97c1badc5 =
        Prefixed_Name(cwrc, "c5e7bace-95bb-4820-bd7d-6bb97c1badc5") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c6a678e5-8fc6-41bc-8631-7cfb7116017e</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e">http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e</seealso>
    let c6a678e5_8fc6_41bc_8631_7cfb7116017e =
        Prefixed_Name(cwrc, "c6a678e5-8fc6-41bc-8631-7cfb7116017e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9</seealso>
    let c6a678e5_8fc6_41bc_8631_7cfb7116017e_215ee9c7d9 =
        Prefixed_Name(cwrc, "c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109">http://sparql.cwrc.ca/ontologies/cwrc#c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109</seealso>
    let c6a678e5_8fc6_41bc_8631_7cfb7116017e_5c65118109 =
        Prefixed_Name(cwrc, "c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c7fcb056-415f-4700-8a9b-d228c9b969fe</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe">http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe</seealso>
    let c7fcb056_415f_4700_8a9b_d228c9b969fe =
        Prefixed_Name(cwrc, "c7fcb056-415f-4700-8a9b-d228c9b969fe") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9</seealso>
    let c7fcb056_415f_4700_8a9b_d228c9b969fe_215ee9c7d9 =
        Prefixed_Name(cwrc, "c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c7fcb056-415f-4700-8a9b-d228c9b969fe-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Document</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-partof">http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-partof</seealso>
    let c7fcb056_415f_4700_8a9b_d228c9b969fe_partof =
        Prefixed_Name(cwrc, "c7fcb056-415f-4700-8a9b-d228c9b969fe-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329">http://sparql.cwrc.ca/ontologies/cwrc#c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329</seealso>
    let c7fcb056_415f_4700_8a9b_d228c9b969fe_partof_8b553ee329 =
        Prefixed_Name(cwrc, "c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c808aed0-eb7b-4c84-9863-63da43401f8e</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e">http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e</seealso>
    let c808aed0_eb7b_4c84_9863_63da43401f8e =
        Prefixed_Name(cwrc, "c808aed0-eb7b-4c84-9863-63da43401f8e") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762">http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762</seealso>
    let c808aed0_eb7b_4c84_9863_63da43401f8e_d76b887762 =
        Prefixed_Name(cwrc, "c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05">http://sparql.cwrc.ca/ontologies/cwrc#c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05</seealso>
    let c808aed0_eb7b_4c84_9863_63da43401f8e_0204e54c05 =
        Prefixed_Name(cwrc, "c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:calligraphy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>calligraphy</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#calligraphy">http://sparql.cwrc.ca/ontologies/cwrc#calligraphy</seealso>
    let calligraphy = Prefixed_Name(cwrc, "calligraphy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:calvinism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>calvinisme</para><para>Calvinism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#calvinism">http://sparql.cwrc.ca/ontologies/cwrc#calvinism</seealso>
    let calvinism = Prefixed_Name(cwrc, "calvinism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:camisards</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Camisards</para><para>Camisard</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#camisards">http://sparql.cwrc.ca/ontologies/cwrc#camisards</seealso>
    let camisards = Prefixed_Name(cwrc, "camisards") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:huguenotNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Huguenot</para><para>Huguenot</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#huguenotNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#huguenotNationalHeritage</seealso>
    let huguenotNationalHeritage =
        Prefixed_Name(cwrc, "huguenotNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:capitalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>capitalisme</para><para>capitalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#capitalism">http://sparql.cwrc.ca/ontologies/cwrc#capitalism</seealso>
    let capitalism = Prefixed_Name(cwrc, "capitalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:captain</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>captain</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#captain">http://sparql.cwrc.ca/ontologies/cwrc#captain</seealso>
    let captain = Prefixed_Name(cwrc, "captain") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:careGiver</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>care giver</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#careGiver">http://sparql.cwrc.ca/ontologies/cwrc#careGiver</seealso>
    let careGiver = Prefixed_Name(cwrc, "careGiver") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:catholicEmancipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>émancipation des catholiques</para><para>Catholic emancipation</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#catholicEmancipation">http://sparql.cwrc.ca/ontologies/cwrc#catholicEmancipation</seealso>
    let catholicEmancipation =
        Prefixed_Name(cwrc, "catholicEmancipation") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:celticEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Celtic</para><para>Celte</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#celticEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#celticEthnicity</seealso>
    let celticEthnicity = Prefixed_Name(cwrc, "celticEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:censor</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>censor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#censor">http://sparql.cwrc.ca/ontologies/cwrc#censor</seealso>
    let censor = Prefixed_Name(cwrc, "censor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:certaintyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>certainty of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#certaintyOf">http://sparql.cwrc.ca/ontologies/cwrc#certaintyOf</seealso>
    let certaintyOf = Prefixed_Name(cwrc, "certaintyOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasCertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has certainty</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasCertainty">http://sparql.cwrc.ca/ontologies/cwrc#hasCertainty</seealso>
    let hasCertainty = Prefixed_Name(cwrc, "hasCertainty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Credential</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>certificate</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#certificate">http://sparql.cwrc.ca/ontologies/cwrc#certificate</seealso>
    let certificate = Prefixed_Name(cwrc, "certificate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:chairperson</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>chairperson</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#chairperson">http://sparql.cwrc.ca/ontologies/cwrc#chairperson</seealso>
    let chairperson = Prefixed_Name(cwrc, "chairperson") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:chaperone</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>chaperone</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#chaperone">http://sparql.cwrc.ca/ontologies/cwrc#chaperone</seealso>
    let chaperone = Prefixed_Name(cwrc, "chaperone") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:charityWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>charity worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#charityWorker">http://sparql.cwrc.ca/ontologies/cwrc#charityWorker</seealso>
    let charityWorker = Prefixed_Name(cwrc, "charityWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:chemist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>chemist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#chemist">http://sparql.cwrc.ca/ontologies/cwrc#chemist</seealso>
    let chemist = Prefixed_Name(cwrc, "chemist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:chess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>chess</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#chess">http://sparql.cwrc.ca/ontologies/cwrc#chess</seealso>
    let chess = Prefixed_Name(cwrc, "chess") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:childOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>enfant de</para><para>child of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#childOf">http://sparql.cwrc.ca/ontologies/cwrc#childOf</seealso>
    let childOf = Prefixed_Name(cwrc, "childOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has child</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasChild">http://sparql.cwrc.ca/ontologies/cwrc#hasChild</seealso>
    let hasChild = Prefixed_Name(cwrc, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:childcare</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>childcare</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#childcare">http://sparql.cwrc.ca/ontologies/cwrc#childcare</seealso>
    let childcare = Prefixed_Name(cwrc, "childcare") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:childcareWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>childcare work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#childcareWork">http://sparql.cwrc.ca/ontologies/cwrc#childcareWork</seealso>
    let childcareWork = Prefixed_Name(cwrc, "childcareWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:childlessness</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///
    /// labels<para>childlessness</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#childlessness">http://sparql.cwrc.ca/ontologies/cwrc#childlessness</seealso>
    let childlessness = Prefixed_Name(cwrc, "childlessness") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:childrensWelfare</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>défense des droits des enfants</para><para>children's welfare</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#childrensWelfare">http://sparql.cwrc.ca/ontologies/cwrc#childrensWelfare</seealso>
    let childrensWelfare = Prefixed_Name(cwrc, "childrensWelfare") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:chineseEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Chinese</para><para>Chinois</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#chineseEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#chineseEthnicity</seealso>
    let chineseEthnicity = Prefixed_Name(cwrc, "chineseEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:christianPacifism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Pacifisme chrétien</para><para>Christian pacifism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#christianPacifism">http://sparql.cwrc.ca/ontologies/cwrc#christianPacifism</seealso>
    let christianPacifism = Prefixed_Name(cwrc, "christianPacifism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:christianScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    /// labels<para>Science Chrétienne</para><para>Christenwetenschap</para><para>Christian Science</para><para>Ciencia Cristiana</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#christianScience">http://sparql.cwrc.ca/ontologies/cwrc#christianScience</seealso>
    let christianScience = Prefixed_Name(cwrc, "christianScience") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:determinism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>déterminisme</para><para>determinism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#determinism">http://sparql.cwrc.ca/ontologies/cwrc#determinism</seealso>
    let determinism = Prefixed_Name(cwrc, "determinism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:df029fed-c7f8-4438-97a4-33d9ff712cad</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad">http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad</seealso>
    let df029fed_c7f8_4438_97a4_33d9ff712cad =
        Prefixed_Name(cwrc, "df029fed-c7f8-4438-97a4-33d9ff712cad") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51">http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51</seealso>
    let df029fed_c7f8_4438_97a4_33d9ff712cad_b531d0ad51 =
        Prefixed_Name(cwrc, "df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9">http://sparql.cwrc.ca/ontologies/cwrc#df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9</seealso>
    let df029fed_c7f8_4438_97a4_33d9ff712cad_63a2ae33d9 =
        Prefixed_Name(cwrc, "df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:diploma</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Credential</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>diploma</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#diploma">http://sparql.cwrc.ca/ontologies/cwrc#diploma</seealso>
    let diploma = Prefixed_Name(cwrc, "diploma") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:diplomat</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>diplomat</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#diplomat">http://sparql.cwrc.ca/ontologies/cwrc#diplomat</seealso>
    let diplomat = Prefixed_Name(cwrc, "diplomat") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>director</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#director">http://sparql.cwrc.ca/ontologies/cwrc#director</seealso>
    let director = Prefixed_Name(cwrc, "director") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:dissentingChristianity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Dissenting Christianity</para><para>Dissidence anglaise</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dissentingChristianity">http://sparql.cwrc.ca/ontologies/cwrc#dissentingChristianity</seealso>
    let dissentingChristianity =
        Prefixed_Name(cwrc, "dissentingChristianity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:dissentingChurches</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#dissentProtestant" title="#dissentProtestant"&gt;Dissent (Protestant)&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#dissentProtestant" title="#dissentProtestant"&gt;dissidents (ou non-conformistes)&lt;/a&gt;.</para>
    /// labels<para>Églises dissidentes</para><para>Dissenting Churches</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dissentingChurches">http://sparql.cwrc.ca/ontologies/cwrc#dissentingChurches</seealso>
    let dissentingChurches = Prefixed_Name(cwrc, "dissentingChurches") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:diver</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>diver</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#diver">http://sparql.cwrc.ca/ontologies/cwrc#diver</seealso>
    let diver = Prefixed_Name(cwrc, "diver") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dockyardWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>dockyard work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dockyardWork">http://sparql.cwrc.ca/ontologies/cwrc#dockyardWork</seealso>
    let dockyardWork = Prefixed_Name(cwrc, "dockyardWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:doctorOfPhilosophy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Philosophiæ doctor</para><para>Ph.D.</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#doctorOfPhilosophy">http://sparql.cwrc.ca/ontologies/cwrc#doctorOfPhilosophy</seealso>
    let doctorOfPhilosophy = Prefixed_Name(cwrc, "doctorOfPhilosophy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:postgraduateDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///
    /// labels<para>postgraduate degree</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#postgraduateDegree">http://sparql.cwrc.ca/ontologies/cwrc#postgraduateDegree</seealso>
    let postgraduateDegree = Prefixed_Name(cwrc, "postgraduateDegree") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:domainIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>domain includes</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#domainIncludes">http://sparql.cwrc.ca/ontologies/cwrc#domainIncludes</seealso>
    let domainIncludes = Prefixed_Name(cwrc, "domainIncludes") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:servant</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>servant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#servant">http://sparql.cwrc.ca/ontologies/cwrc#servant</seealso>
    let servant = Prefixed_Name(cwrc, "servant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:domesticWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>domestic work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#domesticWork">http://sparql.cwrc.ca/ontologies/cwrc#domesticWork</seealso>
    let domesticWork = Prefixed_Name(cwrc, "domesticWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dominicanOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Ordre des Prêcheurs</para><para>Dominican</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dominicanOrder">http://sparql.cwrc.ca/ontologies/cwrc#dominicanOrder</seealso>
    let dominicanOrder = Prefixed_Name(cwrc, "dominicanOrder") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:draper</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>draper</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#draper">http://sparql.cwrc.ca/ontologies/cwrc#draper</seealso>
    let draper = Prefixed_Name(cwrc, "draper") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:dressReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme vestimentaire</para><para>dress reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dressReform">http://sparql.cwrc.ca/ontologies/cwrc#dressReform</seealso>
    let dressReform = Prefixed_Name(cwrc, "dressReform") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasLinguisticAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>maîtrise une langue</para><para>language known</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbility">http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbility</seealso>
    let hasLinguisticAbility =
        Prefixed_Name(cwrc, "hasLinguisticAbility") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:linguisticAbilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>language known of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityOf">http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityOf</seealso>
    let linguisticAbilityOf = Prefixed_Name(cwrc, "linguisticAbilityOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasLinguisticAbilityReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>maîtrise une langue (déclaré)</para><para>language known (reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilityReported">http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilityReported</seealso>
    let hasLinguisticAbilityReported =
        Prefixed_Name(cwrc, "hasLinguisticAbilityReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:linguisticAbilityReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>language known (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityReportedOf</seealso>
    let linguisticAbilityReportedOf =
        Prefixed_Name(cwrc, "linguisticAbilityReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasLinguisticAbilitySelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasLinguisticAbilitySelfReported" title="#hasLinguisticAbilitySelfReported"&gt;maîtrise une langue (autodéclaré)&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasLinguisticAbilitySelfReported" title="#hasLinguisticAbilitySelfReported"&gt;language known (self-reported)&lt;/a&gt;.</para>
    /// labels<para>connait la langue (autodéclaré)</para><para>language known (self declared)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilitySelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilitySelfDeclared</seealso>
    let hasLinguisticAbilitySelfDeclared =
        Prefixed_Name(cwrc, "hasLinguisticAbilitySelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasLinguisticAbilitySelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>maîtrise une langue (autodéclaré)</para><para>language known (self-reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilitySelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilitySelfReported</seealso>
    let hasLinguisticAbilitySelfReported =
        Prefixed_Name(cwrc, "hasLinguisticAbilitySelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:linguisticAbilitySelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>language known (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilitySelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilitySelfReportedOf</seealso>
    let linguisticAbilitySelfReportedOf =
        Prefixed_Name(cwrc, "linguisticAbilitySelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has location</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasLocation">http://sparql.cwrc.ca/ontologies/cwrc#hasLocation</seealso>
    let hasLocation = Prefixed_Name(cwrc, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has mother</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasMother">http://sparql.cwrc.ca/ontologies/cwrc#hasMother</seealso>
    let hasMother = Prefixed_Name(cwrc, "hasMother") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasName">http://sparql.cwrc.ca/ontologies/cwrc#hasName</seealso>
    let hasName = Prefixed_Name(cwrc, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasNamePart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has name part</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNamePart">http://sparql.cwrc.ca/ontologies/cwrc#hasNamePart</seealso>
    let hasNamePart = Prefixed_Name(cwrc, "hasNamePart") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has national heritage</para><para>de héritage national</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritage</seealso>
    let hasNationalHeritage = Prefixed_Name(cwrc, "hasNationalHeritage") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nationalHeritageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>national heritage of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageOf">http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageOf</seealso>
    let nationalHeritageOf = Prefixed_Name(cwrc, "nationalHeritageOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNationalHeritageReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has national heritage (reported)</para><para>de héritage national (déclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageReported">http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageReported</seealso>
    let hasNationalHeritageReported =
        Prefixed_Name(cwrc, "hasNationalHeritageReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nationalHeritageReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>national heritage (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageReportedOf</seealso>
    let nationalHeritageReportedOf =
        Prefixed_Name(cwrc, "nationalHeritageReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNationalHeritageSelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has national heritage (self-reported)</para><para>de héritage national (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageSelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageSelfReported</seealso>
    let hasNationalHeritageSelfReported =
        Prefixed_Name(cwrc, "hasNationalHeritageSelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nationalHeritageSelfReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>national heritage (self-reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageSelfReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageSelfReportedOf</seealso>
    let nationalHeritageSelfReportedOf =
        Prefixed_Name(cwrc, "nationalHeritageSelfReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has national identity</para><para>de nationalité</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationality">http://sparql.cwrc.ca/ontologies/cwrc#hasNationality</seealso>
    let hasNationality = Prefixed_Name(cwrc, "hasNationality") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nationalityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>national identity of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nationalityOf">http://sparql.cwrc.ca/ontologies/cwrc#nationalityOf</seealso>
    let nationalityOf = Prefixed_Name(cwrc, "nationalityOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasNationalityReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has national identity (reported)</para><para>de nationalité (déclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalityReported">http://sparql.cwrc.ca/ontologies/cwrc#hasNationalityReported</seealso>
    let hasNationalityReported =
        Prefixed_Name(cwrc, "hasNationalityReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nationalityReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>national identity (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nationalityReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#nationalityReportedOf</seealso>
    let nationalityReportedOf =
        Prefixed_Name(cwrc, "nationalityReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:memberOfParliament</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>member of parliament</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#memberOfParliament">http://sparql.cwrc.ca/ontologies/cwrc#memberOfParliament</seealso>
    let memberOfParliament = Prefixed_Name(cwrc, "memberOfParliament") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:mentalHealthProfessional</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>mental health professional</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mentalHealthProfessional">http://sparql.cwrc.ca/ontologies/cwrc#mentalHealthProfessional</seealso>
    let mentalHealthProfessional =
        Prefixed_Name(cwrc, "mentalHealthProfessional") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:mentor</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>mentor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mentor">http://sparql.cwrc.ca/ontologies/cwrc#mentor</seealso>
    let mentor = Prefixed_Name(cwrc, "mentor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:mercer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>mercer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#mercer">http://sparql.cwrc.ca/ontologies/cwrc#mercer</seealso>
    let mercer = Prefixed_Name(cwrc, "mercer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:merchantTaylor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>merchant taylor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#merchantTaylor">http://sparql.cwrc.ca/ontologies/cwrc#merchantTaylor</seealso>
    let merchantTaylor = Prefixed_Name(cwrc, "merchantTaylor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:metallurgy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>metallurgy</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#metallurgy">http://sparql.cwrc.ca/ontologies/cwrc#metallurgy</seealso>
    let metallurgy = Prefixed_Name(cwrc, "metallurgy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:meteorologist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>meteorologist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#meteorologist">http://sparql.cwrc.ca/ontologies/cwrc#meteorologist</seealso>
    let meteorologist = Prefixed_Name(cwrc, "meteorologist") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:methodistEpiscopalian</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Methodist Episcopalian</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#methodistEpiscopalian">http://sparql.cwrc.ca/ontologies/cwrc#methodistEpiscopalian</seealso>
    let methodistEpiscopalian =
        Prefixed_Name(cwrc, "methodistEpiscopalian") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:middleChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:BirthPosition</para>
    ///
    /// labels<para>cadet·te</para><para>middle</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#middleChild">http://sparql.cwrc.ca/ontologies/cwrc#middleChild</seealso>
    let middleChild = Prefixed_Name(cwrc, "middleChild") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:midwife</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>midwife</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#midwife">http://sparql.cwrc.ca/ontologies/cwrc#midwife</seealso>
    let midwife = Prefixed_Name(cwrc, "midwife") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:migratesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>emigrated from</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#migratesFrom">http://sparql.cwrc.ca/ontologies/cwrc#migratesFrom</seealso>
    let migratesFrom = Prefixed_Name(cwrc, "migratesFrom") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:migratesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>immigrated to</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#migratesTo">http://sparql.cwrc.ca/ontologies/cwrc#migratesTo</seealso>
    let migratesTo = Prefixed_Name(cwrc, "migratesTo") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:travelsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>travelled to</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#travelsTo">http://sparql.cwrc.ca/ontologies/cwrc#travelsTo</seealso>
    let travelsTo = Prefixed_Name(cwrc, "travelsTo") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:militarism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>militarisme</para><para>militarism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#militarism">http://sparql.cwrc.ca/ontologies/cwrc#militarism</seealso>
    let militarism = Prefixed_Name(cwrc, "militarism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:poorLawReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme de la Poor Law</para><para>poor law reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#poorLawReform">http://sparql.cwrc.ca/ontologies/cwrc#poorLawReform</seealso>
    let poorLawReform = Prefixed_Name(cwrc, "poorLawReform") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pornographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>pornographer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pornographer">http://sparql.cwrc.ca/ontologies/cwrc#pornographer</seealso>
    let pornographer = Prefixed_Name(cwrc, "pornographer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:postalWorker</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>postal worker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#postalWorker">http://sparql.cwrc.ca/ontologies/cwrc#postalWorker</seealso>
    let postalWorker = Prefixed_Name(cwrc, "postalWorker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pottery</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>pottery</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pottery">http://sparql.cwrc.ca/ontologies/cwrc#pottery</seealso>
    let pottery = Prefixed_Name(cwrc, "pottery") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:preferredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>preferred by</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#preferredBy">http://sparql.cwrc.ca/ontologies/cwrc#preferredBy</seealso>
    let preferredBy = Prefixed_Name(cwrc, "preferredBy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:presbyterianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Presbiterianismo</para><para>Presbytarianisme</para><para>Presbyterianisme</para><para>Presbyterianism</para><para>chang lao tsung</para><para>zhang lao zong</para><para>zhǎng lǎo zōng</para><para>Prebyteriaan</para><para>長老教會</para><para>長老宗</para><para>長老制</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#presbyterianism">http://sparql.cwrc.ca/ontologies/cwrc#presbyterianism</seealso>
    let presbyterianism = Prefixed_Name(cwrc, "presbyterianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:printing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>printing</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#printing">http://sparql.cwrc.ca/ontologies/cwrc#printing</seealso>
    let printing = Prefixed_Name(cwrc, "printing") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:prisonReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme pénitentiaire</para><para>prison reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#prisonReform">http://sparql.cwrc.ca/ontologies/cwrc#prisonReform</seealso>
    let prisonReform = Prefixed_Name(cwrc, "prisonReform") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>producer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#producer">http://sparql.cwrc.ca/ontologies/cwrc#producer</seealso>
    let producer = Prefixed_Name(cwrc, "producer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:professional</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:SocialClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>professionelle</para><para>professional</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#professional">http://sparql.cwrc.ca/ontologies/cwrc#professional</seealso>
    let professional = Prefixed_Name(cwrc, "professional") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:professor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>professor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#professor">http://sparql.cwrc.ca/ontologies/cwrc#professor</seealso>
    let professor = Prefixed_Name(cwrc, "professor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:propagandist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>propagandist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#propagandist">http://sparql.cwrc.ca/ontologies/cwrc#propagandist</seealso>
    let propagandist = Prefixed_Name(cwrc, "propagandist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:propertyAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>land agent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#propertyAgent">http://sparql.cwrc.ca/ontologies/cwrc#propertyAgent</seealso>
    let propertyAgent = Prefixed_Name(cwrc, "propertyAgent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:propertyLawReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme des droits à la propriété</para><para>property law reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#propertyLawReform">http://sparql.cwrc.ca/ontologies/cwrc#propertyLawReform</seealso>
    let propertyLawReform = Prefixed_Name(cwrc, "propertyLawReform") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:propertyOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>property owner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#propertyOwner">http://sparql.cwrc.ca/ontologies/cwrc#propertyOwner</seealso>
    let propertyOwner = Prefixed_Name(cwrc, "propertyOwner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:prophet</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>prophet</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#prophet">http://sparql.cwrc.ca/ontologies/cwrc#prophet</seealso>
    let prophet = Prefixed_Name(cwrc, "prophet") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:prospector</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>prospector</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#prospector">http://sparql.cwrc.ca/ontologies/cwrc#prospector</seealso>
    let prospector = Prefixed_Name(cwrc, "prospector") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:protestantRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>gouvernement protestant</para><para>Protestant rule</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#protestantRule">http://sparql.cwrc.ca/ontologies/cwrc#protestantRule</seealso>
    let protestantRule = Prefixed_Name(cwrc, "protestantRule") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:theism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>théisme</para><para>theism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#theism">http://sparql.cwrc.ca/ontologies/cwrc#theism</seealso>
    let theism = Prefixed_Name(cwrc, "theism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:thracianEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Thracian</para><para>thrace</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#thracianEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#thracianEthnicity</seealso>
    let thracianEthnicity = Prefixed_Name(cwrc, "thracianEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:timberTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>timber trade</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#timberTrade">http://sparql.cwrc.ca/ontologies/cwrc#timberTrade</seealso>
    let timberTrade = Prefixed_Name(cwrc, "timberTrade") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:timeCertaintyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>time certainty of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#timeCertaintyOf">http://sparql.cwrc.ca/ontologies/cwrc#timeCertaintyOf</seealso>
    let timeCertaintyOf = Prefixed_Name(cwrc, "timeCertaintyOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:tinker</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>tinker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#tinker">http://sparql.cwrc.ca/ontologies/cwrc#tinker</seealso>
    let tinker = Prefixed_Name(cwrc, "tinker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:toryPartyBritain</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#conservativePartyUk" title="#conservativePartyUk"&gt;Parti Conservateur (Royaume-Uni)&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#conservativePartyUk" title="#conservativePartyUk"&gt;Conservative Party (UK)&lt;/a&gt;.</para>
    /// labels<para>Parti Tory (Royaume-Uni)</para><para>Tory Party (Britain)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#toryPartyBritain">http://sparql.cwrc.ca/ontologies/cwrc#toryPartyBritain</seealso>
    let toryPartyBritain = Prefixed_Name(cwrc, "toryPartyBritain") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:whiggism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>whiggisme</para><para>whiggism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#whiggism">http://sparql.cwrc.ca/ontologies/cwrc#whiggism</seealso>
    let whiggism = Prefixed_Name(cwrc, "whiggism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:tourGuide</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>tour guide</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#tourGuide">http://sparql.cwrc.ca/ontologies/cwrc#tourGuide</seealso>
    let tourGuide = Prefixed_Name(cwrc, "tourGuide") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:tractarianMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Tractarian Movement</para><para>tractarianisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#tractarianMovement">http://sparql.cwrc.ca/ontologies/cwrc#tractarianMovement</seealso>
    let tractarianMovement = Prefixed_Name(cwrc, "tractarianMovement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:tradeUnionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>trade unionism</para><para>syndicalisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#tradeUnionism">http://sparql.cwrc.ca/ontologies/cwrc#tradeUnionism</seealso>
    let tradeUnionism = Prefixed_Name(cwrc, "tradeUnionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:trader</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>trader</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#trader">http://sparql.cwrc.ca/ontologies/cwrc#trader</seealso>
    let trader = Prefixed_Name(cwrc, "trader") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034">http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034</seealso>
    let _3d49dc32_ac97_4abd_a252_573c52b463cf_c743e92034 =
        Prefixed_Name(cwrc, "3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3f1dd1b1-411b-45a9-a860-7b45bf0a1174</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174">http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174</seealso>
    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174 =
        Prefixed_Name(cwrc, "3f1dd1b1-411b-45a9-a860-7b45bf0a1174") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de">http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de</seealso>
    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174_a4e96325de =
        Prefixed_Name(cwrc, "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3">http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3</seealso>
    let _40523fef_509d_4802_900d_4f230fe50123_ff80d41ff3 =
        Prefixed_Name(cwrc, "40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9">http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9</seealso>
    let _4f4d7ca6_5625_46d9_bd88_17847ee076d8_63a2ae33d9 =
        Prefixed_Name(cwrc, "4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd">http://sparql.cwrc.ca/ontologies/cwrc#59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd</seealso>
    let _59f48ef6_ebc7_4a58_ac43_2025deb369ec_842232a3cd =
        Prefixed_Name(cwrc, "59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:TextLabels</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>étiquettes textuelles</para><para>textual label</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#TextLabels">http://sparql.cwrc.ca/ontologies/cwrc#TextLabels</seealso>
    let TextLabels = Prefixed_Name(cwrc, "TextLabels") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:advocate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>advocate</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#advocate">http://sparql.cwrc.ca/ontologies/cwrc#advocate</seealso>
    let advocate = Prefixed_Name(cwrc, "advocate") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:politics</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>politics</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#politics">http://sparql.cwrc.ca/ontologies/cwrc#politics</seealso>
    let politics = Prefixed_Name(cwrc, "politics") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aec674cf-2108-4977-be3a-9317efe35aa9</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9">http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9</seealso>
    let aec674cf_2108_4977_be3a_9317efe35aa9 =
        Prefixed_Name(cwrc, "aec674cf-2108-4977-be3a-9317efe35aa9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:african-AmericanEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>African-American</para><para>Afro-américain</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#african-AmericanEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#african-AmericanEthnicity</seealso>
    let african_AmericanEthnicity =
        Prefixed_Name(cwrc, "african-AmericanEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:blackLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:TextLabels</para>
    ///
    /// labels<para>black identity</para><para>identité noir</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#blackLabel">http://sparql.cwrc.ca/ontologies/cwrc#blackLabel</seealso>
    let blackLabel = Prefixed_Name(cwrc, "blackLabel") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:africanNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Africain</para><para>African</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#africanNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#africanNationalHeritage</seealso>
    let africanNationalHeritage =
        Prefixed_Name(cwrc, "africanNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:afro-CaribbeanRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Afro-Caribbean</para><para>Afro-Caribéens</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#afro-CaribbeanRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#afro-CaribbeanRaceColour</seealso>
    let afro_CaribbeanRaceColour =
        Prefixed_Name(cwrc, "afro-CaribbeanRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>agent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#agent">http://sparql.cwrc.ca/ontologies/cwrc#agent</seealso>
    let agent = Prefixed_Name(cwrc, "agent") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:airRaidWarden</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>air raid warden</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#airRaidWarden">http://sparql.cwrc.ca/ontologies/cwrc#airRaidWarden</seealso>
    let airRaidWarden = Prefixed_Name(cwrc, "airRaidWarden") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:warWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>war work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#warWork">http://sparql.cwrc.ca/ontologies/cwrc#warWork</seealso>
    let warWork = Prefixed_Name(cwrc, "warWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:aircraftIndustry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>aircraft industry</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aircraftIndustry">http://sparql.cwrc.ca/ontologies/cwrc#aircraftIndustry</seealso>
    let aircraftIndustry = Prefixed_Name(cwrc, "aircraftIndustry") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:military</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>military</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#military">http://sparql.cwrc.ca/ontologies/cwrc#military</seealso>
    let military = Prefixed_Name(cwrc, "military") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:alteredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>altered by</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#alteredBy">http://sparql.cwrc.ca/ontologies/cwrc#alteredBy</seealso>
    let alteredBy = Prefixed_Name(cwrc, "alteredBy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:alternativeMedicine</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>alternative medicine</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#alternativeMedicine">http://sparql.cwrc.ca/ontologies/cwrc#alternativeMedicine</seealso>
    let alternativeMedicine = Prefixed_Name(cwrc, "alternativeMedicine") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:americanNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>nationalisme américain</para><para>American nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#americanNationalism">http://sparql.cwrc.ca/ontologies/cwrc#americanNationalism</seealso>
    let americanNationalism = Prefixed_Name(cwrc, "americanNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Nationalisme</para><para>nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nationalism">http://sparql.cwrc.ca/ontologies/cwrc#nationalism</seealso>
    let nationalism = Prefixed_Name(cwrc, "nationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anarchism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Anarchisme</para><para>anarchism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anarchism">http://sparql.cwrc.ca/ontologies/cwrc#anarchism</seealso>
    let anarchism = Prefixed_Name(cwrc, "anarchism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:relativeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>liens de famille</para><para>relative of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#relativeOf">http://sparql.cwrc.ca/ontologies/cwrc#relativeOf</seealso>
    let relativeOf = Prefixed_Name(cwrc, "relativeOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasAncestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ancestor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasAncestor">http://sparql.cwrc.ca/ontologies/cwrc#hasAncestor</seealso>
    let hasAncestor = Prefixed_Name(cwrc, "hasAncestor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anglicanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>foaf:Organization</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    /// labels<para>Anglicaans (kerk van Engeland)</para><para>ying kuo sheng kung hui</para><para>ying guo sheng gong hui</para><para>yīng guó shèng gōng huì</para><para>Iglesia de Inglaterra</para><para>Église d'Angleterre</para><para>Anglicanismo</para><para>英國聖公會 (英國國教)</para><para>Anglicanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anglicanism">http://sparql.cwrc.ca/ontologies/cwrc#anglicanism</seealso>
    let anglicanism = Prefixed_Name(cwrc, "anglicanism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:christianity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Christianisme</para><para>chi tu chiao</para><para>Cristianismo</para><para>Christianity</para><para>Christendom</para><para>Christelijk</para><para>ji du jiao</para><para>jī dū jiāo</para><para>基督教</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#christianity">http://sparql.cwrc.ca/ontologies/cwrc#christianity</seealso>
    let christianity = Prefixed_Name(cwrc, "christianity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anglo-IrishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Anglo-irlandais</para><para>Anglo-Irish</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishEthnicity</seealso>
    let anglo_IrishEthnicity =
        Prefixed_Name(cwrc, "anglo-IrishEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:europeanEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Européen</para><para>European</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#europeanEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#europeanEthnicity</seealso>
    let europeanEthnicity = Prefixed_Name(cwrc, "europeanEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anglo-IrishNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Anglo-irlandais</para><para>Anglo-Irish</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishNationalHeritage</seealso>
    let anglo_IrishNationalHeritage =
        Prefixed_Name(cwrc, "anglo-IrishNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anglo-IrishNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Anglo-Irlandaise</para><para>Anglo-Irish</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#anglo-IrishNationalIdentity</seealso>
    let anglo_IrishNationalIdentity =
        Prefixed_Name(cwrc, "anglo-IrishNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anglo-NormanEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Baronnage anglo-normand</para><para>Anglo-Norman</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anglo-NormanEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#anglo-NormanEthnicity</seealso>
    let anglo_NormanEthnicity =
        Prefixed_Name(cwrc, "anglo-NormanEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:animalWelfareAdvocacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>défense du bien-être animal</para><para>animal welfare advocacy</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#animalWelfareAdvocacy">http://sparql.cwrc.ca/ontologies/cwrc#animalWelfareAdvocacy</seealso>
    let animalWelfareAdvocacy =
        Prefixed_Name(cwrc, "animalWelfareAdvocacy") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:anti-Antisemitism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-antisémitisme</para><para>anti-antisemitism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Antisemitism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Antisemitism</seealso>
    let anti_Antisemitism = Prefixed_Name(cwrc, "anti-Antisemitism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:antisemitism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Antisémitisme</para><para>antisemitism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#antisemitism">http://sparql.cwrc.ca/ontologies/cwrc#antisemitism</seealso>
    let antisemitism = Prefixed_Name(cwrc, "antisemitism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Fascism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Antifascisme</para><para>anti-fascism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Fascism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Fascism</seealso>
    let anti_Fascism = Prefixed_Name(cwrc, "anti-Fascism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pro-BoerWar</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>pro-guerre des Boers</para><para>pro-Boer War</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pro-BoerWar">http://sparql.cwrc.ca/ontologies/cwrc#pro-BoerWar</seealso>
    let pro_BoerWar = Prefixed_Name(cwrc, "pro-BoerWar") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-War</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>anti-war movement</para><para>Antiguerre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-War">http://sparql.cwrc.ca/ontologies/cwrc#anti-War</seealso>
    let anti_War = Prefixed_Name(cwrc, "anti-War") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Bolshevism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>anti-Bolshevism</para><para>Anticommunisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Bolshevism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Bolshevism</seealso>
    let anti_Bolshevism = Prefixed_Name(cwrc, "anti-Bolshevism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:bolshevism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Bolcheviks</para><para>Bolshevism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bolshevism">http://sparql.cwrc.ca/ontologies/cwrc#bolshevism</seealso>
    let bolshevism = Prefixed_Name(cwrc, "bolshevism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Communism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Anticommunisme</para><para>anti-communism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Communism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Communism</seealso>
    let anti_Communism = Prefixed_Name(cwrc, "anti-Communism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:anti-Capitalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>anti-capitalism</para><para>Anticapitalisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#anti-Capitalism">http://sparql.cwrc.ca/ontologies/cwrc#anti-Capitalism</seealso>
    let anti_Capitalism = Prefixed_Name(cwrc, "anti-Capitalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:boulangism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Boulangisme</para><para>boulangism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#boulangism">http://sparql.cwrc.ca/ontologies/cwrc#boulangism</seealso>
    let boulangism = Prefixed_Name(cwrc, "boulangism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:brahmin</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>Brahmane</para><para>Brahmin</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#brahmin">http://sparql.cwrc.ca/ontologies/cwrc#brahmin</seealso>
    let brahmin = Prefixed_Name(cwrc, "brahmin") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174">http://sparql.cwrc.ca/ontologies/cwrc#d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174</seealso>
    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_e523623174 =
        Prefixed_Name(cwrc, "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d95dce89-623d-4226-afd5-c602db0b6c7f</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f">http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f</seealso>
    let d95dce89_623d_4226_afd5_c602db0b6c7f =
        Prefixed_Name(cwrc, "d95dce89-623d-4226-afd5-c602db0b6c7f") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9">http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9</seealso>
    let d95dce89_623d_4226_afd5_c602db0b6c7f_215ee9c7d9 =
        Prefixed_Name(cwrc, "d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:d95dce89-623d-4226-afd5-c602db0b6c7f-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f-partof">http://sparql.cwrc.ca/ontologies/cwrc#d95dce89-623d-4226-afd5-c602db0b6c7f-partof</seealso>
    let d95dce89_623d_4226_afd5_c602db0b6c7f_partof =
        Prefixed_Name(cwrc, "d95dce89-623d-4226-afd5-c602db0b6c7f-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:dairyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>dairy work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#dairyWork">http://sparql.cwrc.ca/ontologies/cwrc#dairyWork</seealso>
    let dairyWork = Prefixed_Name(cwrc, "dairyWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:eurasianLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:TextLabels</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Eurasian identity</para><para>identité Eurasian</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#eurasianLabel">http://sparql.cwrc.ca/ontologies/cwrc#eurasianLabel</seealso>
    let eurasianLabel = Prefixed_Name(cwrc, "eurasianLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:eurasianRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>eurasien</para><para>eurasian</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#eurasianRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#eurasianRaceColour</seealso>
    let eurasianRaceColour = Prefixed_Name(cwrc, "eurasianRaceColour") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:eurasianRace</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#eurasianRaceColour" title="#eurasianRaceColour"&gt;eurasien&lt;/a&gt;.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#eurasianRaceColour" title="#eurasianRaceColour"&gt;eurasian&lt;/a&gt;.</para>
    /// labels<para>eurasian</para><para>eurasien</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#eurasianRace">http://sparql.cwrc.ca/ontologies/cwrc#eurasianRace</seealso>
    let eurasianRace = Prefixed_Name(cwrc, "eurasianRace") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:europeanNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///
    /// labels<para>European</para><para>Européen</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#europeanNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#europeanNationalHeritage</seealso>
    let europeanNationalHeritage =
        Prefixed_Name(cwrc, "europeanNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:europeanNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>European</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#europeanNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#europeanNationalIdentity</seealso>
    let europeanNationalIdentity =
        Prefixed_Name(cwrc, "europeanNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:evangelicalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Evangelicalism</para><para>évangélisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#evangelicalism">http://sparql.cwrc.ca/ontologies/cwrc#evangelicalism</seealso>
    let evangelicalism = Prefixed_Name(cwrc, "evangelicalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:eventOrganizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>event organizer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#eventOrganizer">http://sparql.cwrc.ca/ontologies/cwrc#eventOrganizer</seealso>
    let eventOrganizer = Prefixed_Name(cwrc, "eventOrganizer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:existentialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Existentialisme</para><para>existentialism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#existentialism">http://sparql.cwrc.ca/ontologies/cwrc#existentialism</seealso>
    let existentialism = Prefixed_Name(cwrc, "existentialism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:explorer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>explorer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#explorer">http://sparql.cwrc.ca/ontologies/cwrc#explorer</seealso>
    let explorer = Prefixed_Name(cwrc, "explorer") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f3666ac1-4f95-4f12-a02e-88ed27197d35</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35">http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35</seealso>
    let f3666ac1_4f95_4f12_a02e_88ed27197d35 =
        Prefixed_Name(cwrc, "f3666ac1-4f95-4f12-a02e-88ed27197d35") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127">http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127</seealso>
    let f3666ac1_4f95_4f12_a02e_88ed27197d35_212cf56127 =
        Prefixed_Name(cwrc, "f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86">http://sparql.cwrc.ca/ontologies/cwrc#f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86</seealso>
    let f3666ac1_4f95_4f12_a02e_88ed27197d35_8066d74e86 =
        Prefixed_Name(cwrc, "f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f62e94d6-bd04-494c-9282-53af0a3f3376</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376">http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376</seealso>
    let f62e94d6_bd04_494c_9282_53af0a3f3376 =
        Prefixed_Name(cwrc, "f62e94d6-bd04-494c-9282-53af0a3f3376") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794">http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794</seealso>
    let f62e94d6_bd04_494c_9282_53af0a3f3376_f16cfae794 =
        Prefixed_Name(cwrc, "f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f62e94d6-bd04-494c-9282-53af0a3f3376-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376-partof">http://sparql.cwrc.ca/ontologies/cwrc#f62e94d6-bd04-494c-9282-53af0a3f3376-partof</seealso>
    let f62e94d6_bd04_494c_9282_53af0a3f3376_partof =
        Prefixed_Name(cwrc, "f62e94d6-bd04-494c-9282-53af0a3f3376-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f77171be-f937-4067-8dbe-fd9982822a96</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96">http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96</seealso>
    let f77171be_f937_4067_8dbe_fd9982822a96 =
        Prefixed_Name(cwrc, "f77171be-f937-4067-8dbe-fd9982822a96") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b">http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b</seealso>
    let f77171be_f937_4067_8dbe_fd9982822a96_fd4dbf406b =
        Prefixed_Name(cwrc, "f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea">http://sparql.cwrc.ca/ontologies/cwrc#f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea</seealso>
    let f77171be_f937_4067_8dbe_fd9982822a96_e9e89595ea =
        Prefixed_Name(cwrc, "f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:fab56e35-9796-4e6d-861d-a6b626f5714d</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d">http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d</seealso>
    let fab56e35_9796_4e6d_861d_a6b626f5714d =
        Prefixed_Name(cwrc, "fab56e35-9796-4e6d-861d-a6b626f5714d") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86">http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86</seealso>
    let fab56e35_9796_4e6d_861d_a6b626f5714d_9871ba1d86 =
        Prefixed_Name(cwrc, "fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:fab56e35-9796-4e6d-861d-a6b626f5714d-partof</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof">http://sparql.cwrc.ca/ontologies/cwrc#fab56e35-9796-4e6d-861d-a6b626f5714d-partof</seealso>
    let fab56e35_9796_4e6d_861d_a6b626f5714d_partof =
        Prefixed_Name(cwrc, "fab56e35-9796-4e6d-861d-a6b626f5714d-partof") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasEthnicityReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ethnic identity (reported)</para><para>d'ethnicité (déclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicityReported">http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicityReported</seealso>
    let hasEthnicityReported =
        Prefixed_Name(cwrc, "hasEthnicityReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasEthnicitySelfDefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasEthnicitySelfReported" title="#hasEthnicitySelfReported"&gt;has ethnic identity (self-reported)&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasEthnicitySelfReported" title="#hasEthnicitySelfReported"&gt;d'ethnicité (autodéclarée)&lt;/a&gt;.</para>
    /// labels<para>has ethnicity (self defined)</para><para>d'ethnicité (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicitySelfDefined">http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicitySelfDefined</seealso>
    let hasEthnicitySelfDefined =
        Prefixed_Name(cwrc, "hasEthnicitySelfDefined") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasEthnicitySelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ethnic identity (self-reported)</para><para>d'ethnicité (autodéclarée)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicitySelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicitySelfReported</seealso>
    let hasEthnicitySelfReported =
        Prefixed_Name(cwrc, "hasEthnicitySelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:personalPropertySelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#personalPropertySelfReported" title="#personalPropertySelfReported"&gt;propriété personnelle autodéclarée&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#personalPropertySelfReported" title="#personalPropertySelfReported"&gt;personal property self-reported&lt;/a&gt;.</para>
    /// labels<para>propriété de la personne (autodéclarée)</para><para>personal property (self-reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#personalPropertySelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#personalPropertySelfDeclared</seealso>
    let personalPropertySelfDeclared =
        Prefixed_Name(cwrc, "personalPropertySelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasFamilyBasedOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has family-based occupation</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasFamilyBasedOccupation">http://sparql.cwrc.ca/ontologies/cwrc#hasFamilyBasedOccupation</seealso>
    let hasFamilyBasedOccupation =
        Prefixed_Name(cwrc, "hasFamilyBasedOccupation") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has parent</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasParent">http://sparql.cwrc.ca/ontologies/cwrc#hasParent</seealso>
    let hasParent = Prefixed_Name(cwrc, "hasParent") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasFunctionalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has functional relation</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasFunctionalRelation">http://sparql.cwrc.ca/ontologies/cwrc#hasFunctionalRelation</seealso>
    let hasFunctionalRelation =
        Prefixed_Name(cwrc, "hasFunctionalRelation") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has gender identity</para><para>est de genre</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGender">http://sparql.cwrc.ca/ontologies/cwrc#hasGender</seealso>
    let hasGender = Prefixed_Name(cwrc, "hasGender") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGenderSelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has gender identity (self-reported)</para><para>est de genre (autodéclaré)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderSelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasGenderSelfReported</seealso>
    let hasGenderSelfReported =
        Prefixed_Name(cwrc, "hasGenderSelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGenderedPoliticalActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has gendered political activity</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivity">http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivity</seealso>
    let hasGenderedPoliticalActivity =
        Prefixed_Name(cwrc, "hasGenderedPoliticalActivity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasPoliticalAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a une appartenance politique</para><para>has political affiliation</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliation">http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliation</seealso>
    let hasPoliticalAffiliation =
        Prefixed_Name(cwrc, "hasPoliticalAffiliation") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGenderedPoliticalActivityFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has gendered political activity from</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivityFrom">http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivityFrom</seealso>
    let hasGenderedPoliticalActivityFrom =
        Prefixed_Name(cwrc, "hasGenderedPoliticalActivityFrom") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:politicalAffiliationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>political affiliation of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationOf">http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationOf</seealso>
    let politicalAffiliationOf =
        Prefixed_Name(cwrc, "politicalAffiliationOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGeographicHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>A un héritage géographique</para><para>has geographic heritage</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritage">http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritage</seealso>
    let hasGeographicHeritage =
        Prefixed_Name(cwrc, "hasGeographicHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGeographicHeritageReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a un héritage géographique (déclaré)</para><para>has geographic heritage (reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageReported">http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageReported</seealso>
    let hasGeographicHeritageReported =
        Prefixed_Name(cwrc, "hasGeographicHeritageReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGeographicHeritageSelfDeclared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#hasGeographicHeritageSelfReported" title="#hasGeographicHeritageSelfReported"&gt;has geographic heritage (self-reported)&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#hasGeographicHeritageSelfReported" title="#hasGeographicHeritageSelfReported"&gt;a un héritage géographique (autodéclaré)&lt;/a&gt;.</para>
    /// labels<para>a un héritage géographique (autodéclaré)</para><para>has geographic heritage (self declared)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageSelfDeclared">http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageSelfDeclared</seealso>
    let hasGeographicHeritageSelfDeclared =
        Prefixed_Name(cwrc, "hasGeographicHeritageSelfDeclared") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasGeographicHeritageSelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a un héritage géographique (autodéclaré)</para><para>has geographic heritage (self-reported)</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageSelfReported">http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageSelfReported</seealso>
    let hasGeographicHeritageSelfReported =
        Prefixed_Name(cwrc, "hasGeographicHeritageSelfReported") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:personalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Deprecated, with no current equivalence.</para>
    ///   <para>Désapprouver sans équivalence.</para>
    /// labels<para>propriété personnelle</para><para>personal property</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#personalProperty">http://sparql.cwrc.ca/ontologies/cwrc#personalProperty</seealso>
    let personalProperty = Prefixed_Name(cwrc, "personalProperty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasSister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has sister</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasSister">http://sparql.cwrc.ca/ontologies/cwrc#hasSister</seealso>
    let hasSister = Prefixed_Name(cwrc, "hasSister") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasHusband</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has husband</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasHusband">http://sparql.cwrc.ca/ontologies/cwrc#hasHusband</seealso>
    let hasHusband = Prefixed_Name(cwrc, "hasHusband") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasPartner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has partner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPartner">http://sparql.cwrc.ca/ontologies/cwrc#hasPartner</seealso>
    let hasPartner = Prefixed_Name(cwrc, "hasPartner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasIDependencyOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ID dependency on</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasIDependencyOn">http://sparql.cwrc.ca/ontologies/cwrc#hasIDependencyOn</seealso>
    let hasIDependencyOn = Prefixed_Name(cwrc, "hasIDependencyOn") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasImmigrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has immigrant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasImmigrant">http://sparql.cwrc.ca/ontologies/cwrc#hasImmigrant</seealso>
    let hasImmigrant = Prefixed_Name(cwrc, "hasImmigrant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasTraveller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has traveller</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasTraveller">http://sparql.cwrc.ca/ontologies/cwrc#hasTraveller</seealso>
    let hasTraveller = Prefixed_Name(cwrc, "hasTraveller") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:relatesSpatiallyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>related spatially to</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#relatesSpatiallyTo">http://sparql.cwrc.ca/ontologies/cwrc#relatesSpatiallyTo</seealso>
    let relatesSpatiallyTo = Prefixed_Name(cwrc, "relatesSpatiallyTo") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasInstructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a un instructeur·ice</para><para>has instructor</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasInstructor">http://sparql.cwrc.ca/ontologies/cwrc#hasInstructor</seealso>
    let hasInstructor = Prefixed_Name(cwrc, "hasInstructor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:irishRepublicanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Républicanisme irlandais</para><para>Irish republicanism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#irishRepublicanism">http://sparql.cwrc.ca/ontologies/cwrc#irishRepublicanism</seealso>
    let irishRepublicanism = Prefixed_Name(cwrc, "irishRepublicanism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:irishNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Nationalisme irlandais</para><para>Irish nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#irishNationalism">http://sparql.cwrc.ca/ontologies/cwrc#irishNationalism</seealso>
    let irishNationalism = Prefixed_Name(cwrc, "irishNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ironmaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>ironmaster</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ironmaster">http://sparql.cwrc.ca/ontologies/cwrc#ironmaster</seealso>
    let ironmaster = Prefixed_Name(cwrc, "ironmaster") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ironmonger</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ironmonger</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ironmonger">http://sparql.cwrc.ca/ontologies/cwrc#ironmonger</seealso>
    let ironmonger = Prefixed_Name(cwrc, "ironmonger") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:iroquoisNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Iroquois</para><para>Iroquois</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#iroquoisNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#iroquoisNationalHeritage</seealso>
    let iroquoisNationalHeritage =
        Prefixed_Name(cwrc, "iroquoisNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:islam</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to the Getty Art &amp; Architecture Thesaurus.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>i ssu lan chiao</para><para>yi si lan jiao</para><para>yī sī lán jiāo</para><para>Islamismo</para><para>Islamism</para><para>Islam</para><para>islam</para><para>Islam</para><para>伊斯蘭教</para><para>回教</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#islam">http://sparql.cwrc.ca/ontologies/cwrc#islam</seealso>
    let islam = Prefixed_Name(cwrc, "islam") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:isolationism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>isolationnisme</para><para>isolationism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#isolationism">http://sparql.cwrc.ca/ontologies/cwrc#isolationism</seealso>
    let isolationism = Prefixed_Name(cwrc, "isolationism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:italianUnification</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Italian unification</para><para>Risorgimento</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#italianUnification">http://sparql.cwrc.ca/ontologies/cwrc#italianUnification</seealso>
    let italianUnification = Prefixed_Name(cwrc, "italianUnification") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:revolutionaryPolitics</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>révolutionnaire</para><para>revolutionary</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#revolutionaryPolitics">http://sparql.cwrc.ca/ontologies/cwrc#revolutionaryPolitics</seealso>
    let revolutionaryPolitics =
        Prefixed_Name(cwrc, "revolutionaryPolitics") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:jacobism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#jacobinism" title="#jacobinism"&gt;Jacobinism&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#jacobinism" title="#jacobinism"&gt;Jacobinisme&lt;/a&gt;.</para>
    /// labels<para>Club des Jacobins</para><para>Jacobism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jacobism">http://sparql.cwrc.ca/ontologies/cwrc#jacobism</seealso>
    let jacobism = Prefixed_Name(cwrc, "jacobism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jamaicanEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Jamaïcains</para><para>Jamaican</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jamaicanEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#jamaicanEthnicity</seealso>
    let jamaicanEthnicity = Prefixed_Name(cwrc, "jamaicanEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jansenism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Jansénisme</para><para>Jansenism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jansenism">http://sparql.cwrc.ca/ontologies/cwrc#jansenism</seealso>
    let jansenism = Prefixed_Name(cwrc, "jansenism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:jewishEmancipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Émancipation des Juifs</para><para>Jewish emancipation</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#jewishEmancipation">http://sparql.cwrc.ca/ontologies/cwrc#jewishEmancipation</seealso>
    let jewishEmancipation = Prefixed_Name(cwrc, "jewishEmancipation") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:polishNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>nationalisme polonais</para><para>Polish nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#polishNationalism">http://sparql.cwrc.ca/ontologies/cwrc#polishNationalism</seealso>
    let polishNationalism = Prefixed_Name(cwrc, "polishNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:politicalHost</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>politicalHost</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#politicalHost">http://sparql.cwrc.ca/ontologies/cwrc#politicalHost</seealso>
    let politicalHost = Prefixed_Name(cwrc, "politicalHost") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:politicalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>political science</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#politicalScience">http://sparql.cwrc.ca/ontologies/cwrc#politicalScience</seealso>
    let politicalScience = Prefixed_Name(cwrc, "politicalScience") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:politicalSpeaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>political speaker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#politicalSpeaker">http://sparql.cwrc.ca/ontologies/cwrc#politicalSpeaker</seealso>
    let politicalSpeaker = Prefixed_Name(cwrc, "politicalSpeaker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:publicSpeaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>public speaker</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#publicSpeaker">http://sparql.cwrc.ca/ontologies/cwrc#publicSpeaker</seealso>
    let publicSpeaker = Prefixed_Name(cwrc, "publicSpeaker") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:pollster</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>pollster</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#pollster">http://sparql.cwrc.ca/ontologies/cwrc#pollster</seealso>
    let pollster = Prefixed_Name(cwrc, "pollster") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:poorAdvocacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>défense des pauvres</para><para>poor advocacy</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#poorAdvocacy">http://sparql.cwrc.ca/ontologies/cwrc#poorAdvocacy</seealso>
    let poorAdvocacy = Prefixed_Name(cwrc, "poorAdvocacy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:statistician</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>statistician</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#statistician">http://sparql.cwrc.ca/ontologies/cwrc#statistician</seealso>
    let statistician = Prefixed_Name(cwrc, "statistician") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepBrotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>stepbrother of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepBrotherOf">http://sparql.cwrc.ca/ontologies/cwrc#stepBrotherOf</seealso>
    let stepBrotherOf = Prefixed_Name(cwrc, "stepBrotherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepChildOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>enfant d'un autre mariage</para><para>stepchild of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepChildOf">http://sparql.cwrc.ca/ontologies/cwrc#stepChildOf</seealso>
    let stepChildOf = Prefixed_Name(cwrc, "stepChildOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepDaughterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>stepdaughter of</para><para>belle-fille de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepDaughterOf">http://sparql.cwrc.ca/ontologies/cwrc#stepDaughterOf</seealso>
    let stepDaughterOf = Prefixed_Name(cwrc, "stepDaughterOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepFatherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>stepfather of</para><para>beau-père de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepFatherOf">http://sparql.cwrc.ca/ontologies/cwrc#stepFatherOf</seealso>
    let stepFatherOf = Prefixed_Name(cwrc, "stepFatherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepParentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>stepparent of</para><para>stepparent de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepParentOf">http://sparql.cwrc.ca/ontologies/cwrc#stepParentOf</seealso>
    let stepParentOf = Prefixed_Name(cwrc, "stepParentOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepSisterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>stepsister of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepSisterOf">http://sparql.cwrc.ca/ontologies/cwrc#stepSisterOf</seealso>
    let stepSisterOf = Prefixed_Name(cwrc, "stepSisterOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stepSonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>beau-fils de</para><para>stepson of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stepSonOf">http://sparql.cwrc.ca/ontologies/cwrc#stepSonOf</seealso>
    let stepSonOf = Prefixed_Name(cwrc, "stepSonOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:stillbirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:ReproductiveHistory</para>
    ///
    /// labels<para>stillbirth</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#stillbirth">http://sparql.cwrc.ca/ontologies/cwrc#stillbirth</seealso>
    let stillbirth = Prefixed_Name(cwrc, "stillbirth") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:storyteller</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>storyteller</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#storyteller">http://sparql.cwrc.ca/ontologies/cwrc#storyteller</seealso>
    let storyteller = Prefixed_Name(cwrc, "storyteller") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:student</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>student</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#student">http://sparql.cwrc.ca/ontologies/cwrc#student</seealso>
    let student = Prefixed_Name(cwrc, "student") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:studiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>studied by</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#studiedBy">http://sparql.cwrc.ca/ontologies/cwrc#studiedBy</seealso>
    let studiedBy = Prefixed_Name(cwrc, "studiedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>studies</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#studies">http://sparql.cwrc.ca/ontologies/cwrc#studies</seealso>
    let studies = Prefixed_Name(cwrc, "studies") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:surveyor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>surveyor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#surveyor">http://sparql.cwrc.ca/ontologies/cwrc#surveyor</seealso>
    let surveyor = Prefixed_Name(cwrc, "surveyor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:swedenborgianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Swedenborgianism</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#swedenborgianism">http://sparql.cwrc.ca/ontologies/cwrc#swedenborgianism</seealso>
    let swedenborgianism = Prefixed_Name(cwrc, "swedenborgianism") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:tatarNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Tatars</para><para>Tatar</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#tatarNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#tatarNationalHeritage</seealso>
    let tatarNationalHeritage =
        Prefixed_Name(cwrc, "tatarNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:taxOfficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>tax official</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#taxOfficial">http://sparql.cwrc.ca/ontologies/cwrc#taxOfficial</seealso>
    let taxOfficial = Prefixed_Name(cwrc, "taxOfficial") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:taxResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Résistance fiscale</para><para>tax resistance</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#taxResistance">http://sparql.cwrc.ca/ontologies/cwrc#taxResistance</seealso>
    let taxResistance = Prefixed_Name(cwrc, "taxResistance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:teacher</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>teacher</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#teacher">http://sparql.cwrc.ca/ontologies/cwrc#teacher</seealso>
    let teacher = Prefixed_Name(cwrc, "teacher") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:teachesEducationalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>teaches educational subject</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#teachesEducationalSubject">http://sparql.cwrc.ca/ontologies/cwrc#teachesEducationalSubject</seealso>
    let teachesEducationalSubject =
        Prefixed_Name(cwrc, "teachesEducationalSubject") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:teachingQualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Credential</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>teaching qualification</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#teachingQualification">http://sparql.cwrc.ca/ontologies/cwrc#teachingQualification</seealso>
    let teachingQualification =
        Prefixed_Name(cwrc, "teachingQualification") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:technician</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>technician</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#technician">http://sparql.cwrc.ca/ontologies/cwrc#technician</seealso>
    let technician = Prefixed_Name(cwrc, "technician") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:telephoneOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>telephone operator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#telephoneOperator">http://sparql.cwrc.ca/ontologies/cwrc#telephoneOperator</seealso>
    let telephoneOperator = Prefixed_Name(cwrc, "telephoneOperator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:televisionIndustry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>television industry</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#televisionIndustry">http://sparql.cwrc.ca/ontologies/cwrc#televisionIndustry</seealso>
    let televisionIndustry = Prefixed_Name(cwrc, "televisionIndustry") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:temperanceMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>temperance movement</para><para>Ligue de tempérance</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#temperanceMovement">http://sparql.cwrc.ca/ontologies/cwrc#temperanceMovement</seealso>
    let temperanceMovement = Prefixed_Name(cwrc, "temperanceMovement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:textiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>textiles</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#textiles">http://sparql.cwrc.ca/ontologies/cwrc#textiles</seealso>
    let textiles = Prefixed_Name(cwrc, "textiles") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4">http://sparql.cwrc.ca/ontologies/cwrc#3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4</seealso>
    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174_a050f81cb4 =
        Prefixed_Name(cwrc, "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:40523fef-509d-4802-900d-4f230fe50123-769103a942</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123-769103a942">http://sparql.cwrc.ca/ontologies/cwrc#40523fef-509d-4802-900d-4f230fe50123-769103a942</seealso>
    let _40523fef_509d_4802_900d_4f230fe50123_769103a942 =
        Prefixed_Name(cwrc, "40523fef-509d-4802-900d-4f230fe50123-769103a942") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164">http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164</seealso>
    let _4dc5ff8c_d908_4377_bca8_9394408b7b67_f3dac63164 =
        Prefixed_Name(cwrc, "4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:Exhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>exhibition (scholarship)</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Exhibition">http://sparql.cwrc.ca/ontologies/cwrc#Exhibition</seealso>
    let Exhibition = Prefixed_Name(cwrc, "Exhibition") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:FamiliarName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>familiar name</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#FamiliarName">http://sparql.cwrc.ca/ontologies/cwrc#FamiliarName</seealso>
    let FamiliarName = Prefixed_Name(cwrc, "FamiliarName") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Fellowship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>fellowship</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Fellowship">http://sparql.cwrc.ca/ontologies/cwrc#Fellowship</seealso>
    let Fellowship = Prefixed_Name(cwrc, "Fellowship") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:FemaleLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:TextLabels</para>
    ///   <para>Deprecated with no current equivalence.</para>
    ///   <para>Désapprouver sans équivalence.</para>
    /// labels<para>femelle</para><para>female</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#FemaleLabel">http://sparql.cwrc.ca/ontologies/cwrc#FemaleLabel</seealso>
    let FemaleLabel = Prefixed_Name(cwrc, "FemaleLabel") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:genderWomanFemale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#woman" title="#woman"&gt;woman&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#woman" title="#woman"&gt;femme&lt;/a&gt;.</para>
    /// labels<para>Femme/Femelle</para><para>Woman/Female</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#genderWomanFemale">http://sparql.cwrc.ca/ontologies/cwrc#genderWomanFemale</seealso>
    let genderWomanFemale = Prefixed_Name(cwrc, "genderWomanFemale") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:FictionalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>fictional person</para><para>personne fictive</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#FictionalPerson">http://sparql.cwrc.ca/ontologies/cwrc#FictionalPerson</seealso>
    let FictionalPerson = Prefixed_Name(cwrc, "FictionalPerson") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:Forename</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>forename</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#Forename">http://sparql.cwrc.ca/ontologies/cwrc#Forename</seealso>
    let Forename = Prefixed_Name(cwrc, "Forename") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:FrenchLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="http://id.loc.gov/vocabulary/languages/fre"&gt;fre&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of foreign instance &lt;a href="http://id.loc.gov/vocabulary/languages/fre"&gt;fre&lt;/a&gt;.</para>
    /// labels<para>Français</para><para>French</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#FrenchLanguage">http://sparql.cwrc.ca/ontologies/cwrc#FrenchLanguage</seealso>
    let FrenchLanguage = Prefixed_Name(cwrc, "FrenchLanguage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:FriendsAndAssociatesContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>friends and associates context</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#FriendsAndAssociatesContext">http://sparql.cwrc.ca/ontologies/cwrc#FriendsAndAssociatesContext</seealso>
    let FriendsAndAssociatesContext =
        Prefixed_Name(cwrc, "FriendsAndAssociatesContext") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:GenderQueer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Gender</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>genderqueer</para><para>queer</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#GenderQueer">http://sparql.cwrc.ca/ontologies/cwrc#GenderQueer</seealso>
    let GenderQueer = Prefixed_Name(cwrc, "GenderQueer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:representedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>represented by</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#representedBy">http://sparql.cwrc.ca/ontologies/cwrc#representedBy</seealso>
    let representedBy = Prefixed_Name(cwrc, "representedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:queerLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:TextLabels</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>queer identity</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#queerLabel">http://sparql.cwrc.ca/ontologies/cwrc#queerLabel</seealso>
    let queerLabel = Prefixed_Name(cwrc, "queerLabel") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:GeographicalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Deprecated in favour of class &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de la classe &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;héritage géographique&lt;/a&gt;.</para>
    /// labels<para>héritage géographique</para><para>geographic heritage</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#GeographicalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#GeographicalHeritage</seealso>
    let GeographicalHeritage =
        Prefixed_Name(cwrc, "GeographicalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:africanEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Africain</para><para>African</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#africanEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#africanEthnicity</seealso>
    let africanEthnicity = Prefixed_Name(cwrc, "africanEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:africanNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Africain</para><para>African</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#africanNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#africanNationalIdentity</seealso>
    let africanNationalIdentity =
        Prefixed_Name(cwrc, "africanNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:agnosticism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>agnosticisme</para><para>agnosticism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#agnosticism">http://sparql.cwrc.ca/ontologies/cwrc#agnosticism</seealso>
    let agnosticism = Prefixed_Name(cwrc, "agnosticism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:aidsActivism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>lutte contre le sida</para><para>AIDS activism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aidsActivism">http://sparql.cwrc.ca/ontologies/cwrc#aidsActivism</seealso>
    let aidsActivism = Prefixed_Name(cwrc, "aidsActivism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:socialReform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réforme sociale</para><para>social reform</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#socialReform">http://sparql.cwrc.ca/ontologies/cwrc#socialReform</seealso>
    let socialReform = Prefixed_Name(cwrc, "socialReform") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:airForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>airForce</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#airForce">http://sparql.cwrc.ca/ontologies/cwrc#airForce</seealso>
    let airForce = Prefixed_Name(cwrc, "airForce") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3">http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3</seealso>
    let bdfac2f5_ae45_4af7_941c_ec37b12f1a38_4c7d285ea3 =
        Prefixed_Name(cwrc, "bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217">http://sparql.cwrc.ca/ontologies/cwrc#bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217</seealso>
    let bdfac2f5_ae45_4af7_941c_ec37b12f1a38_0ee2efb217 =
        Prefixed_Name(cwrc, "bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:beauty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>beauty</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#beauty">http://sparql.cwrc.ca/ontologies/cwrc#beauty</seealso>
    let beauty = Prefixed_Name(cwrc, "beauty") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:beggar</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>beggar</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#beggar">http://sparql.cwrc.ca/ontologies/cwrc#beggar</seealso>
    let beggar = Prefixed_Name(cwrc, "beggar") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:transcriber</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>transcriber</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#transcriber">http://sparql.cwrc.ca/ontologies/cwrc#transcriber</seealso>
    let transcriber = Prefixed_Name(cwrc, "transcriber") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:cornishNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Corniques</para><para>Cornish</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#cornishNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#cornishNationalHeritage</seealso>
    let cornishNationalHeritage =
        Prefixed_Name(cwrc, "cornishNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:englishRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>English</para><para>Anglais</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#englishRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#englishRaceColour</seealso>
    let englishRaceColour = Prefixed_Name(cwrc, "englishRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hanoverianNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalIdentity</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Hanoverian</para><para>Hanovrien</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hanoverianNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#hanoverianNationalIdentity</seealso>
    let hanoverianNationalIdentity =
        Prefixed_Name(cwrc, "hanoverianNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:newUnionism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>New Unionism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#newUnionism">http://sparql.cwrc.ca/ontologies/cwrc#newUnionism</seealso>
    let newUnionism = Prefixed_Name(cwrc, "newUnionism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nieceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>niece of</para><para>nièce de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nieceOf">http://sparql.cwrc.ca/ontologies/cwrc#nieceOf</seealso>
    let nieceOf = Prefixed_Name(cwrc, "nieceOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nihilism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Nihilisme</para><para>nihilism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nihilism">http://sparql.cwrc.ca/ontologies/cwrc#nihilism</seealso>
    let nihilism = Prefixed_Name(cwrc, "nihilism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nonjurorsMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>mouvement du clergé réfractaire</para><para>nonjurors movement</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nonjurorsMovement">http://sparql.cwrc.ca/ontologies/cwrc#nonjurorsMovement</seealso>
    let nonjurorsMovement = Prefixed_Name(cwrc, "nonjurorsMovement") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:normanNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Normand</para><para>Norman</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#normanNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#normanNationalHeritage</seealso>
    let normanNationalHeritage =
        Prefixed_Name(cwrc, "normanNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:numismatist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>numismatist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#numismatist">http://sparql.cwrc.ca/ontologies/cwrc#numismatist</seealso>
    let numismatist = Prefixed_Name(cwrc, "numismatist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nun</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>nun</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nun">http://sparql.cwrc.ca/ontologies/cwrc#nun</seealso>
    let nun = Prefixed_Name(cwrc, "nun") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:nursing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>nursing</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nursing">http://sparql.cwrc.ca/ontologies/cwrc#nursing</seealso>
    let nursing = Prefixed_Name(cwrc, "nursing") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:rescueWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>rescue work</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#rescueWork">http://sparql.cwrc.ca/ontologies/cwrc#rescueWork</seealso>
    let rescueWork = Prefixed_Name(cwrc, "rescueWork") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>researcher</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#researcher">http://sparql.cwrc.ca/ontologies/cwrc#researcher</seealso>
    let researcher = Prefixed_Name(cwrc, "researcher") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:retail</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>retail</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#retail">http://sparql.cwrc.ca/ontologies/cwrc#retail</seealso>
    let retail = Prefixed_Name(cwrc, "retail") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:reviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>reviewer</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#reviewer">http://sparql.cwrc.ca/ontologies/cwrc#reviewer</seealso>
    let reviewer = Prefixed_Name(cwrc, "reviewer") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:riding</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>riding</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#riding">http://sparql.cwrc.ca/ontologies/cwrc#riding</seealso>
    let riding = Prefixed_Name(cwrc, "riding") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:romaniEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Romani</para><para>rom</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#romaniEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#romaniEthnicity</seealso>
    let romaniEthnicity = Prefixed_Name(cwrc, "romaniEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:rosicrucianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Religion</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Rosicrucianism</para><para>Rose-Croix</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#rosicrucianism">http://sparql.cwrc.ca/ontologies/cwrc#rosicrucianism</seealso>
    let rosicrucianism = Prefixed_Name(cwrc, "rosicrucianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:rural-unskilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:SocialClass</para>
    ///
    /// labels<para>ouvrière agricole</para><para>rural unskilled</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#rural-unskilled">http://sparql.cwrc.ca/ontologies/cwrc#rural-unskilled</seealso>
    let rural_unskilled = Prefixed_Name(cwrc, "rural-unskilled") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:sabbatarianism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>Sabbatarianisme</para><para>Sabbatarianism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#sabbatarianism">http://sparql.cwrc.ca/ontologies/cwrc#sabbatarianism</seealso>
    let sabbatarianism = Prefixed_Name(cwrc, "sabbatarianism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>architecture</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#architecture">http://sparql.cwrc.ca/ontologies/cwrc#architecture</seealso>
    let architecture = Prefixed_Name(cwrc, "architecture") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:nativeLinguisticAbilityReportedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>natively known language (reported) of</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityReportedOf">http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityReportedOf</seealso>
    let nativeLinguisticAbilityReportedOf =
        Prefixed_Name(cwrc, "nativeLinguisticAbilityReportedOf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:italianNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>cwrc:Occupation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>nationalisme Italien</para><para>Italian nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#italianNationalism">http://sparql.cwrc.ca/ontologies/cwrc#italianNationalism</seealso>
    let italianNationalism = Prefixed_Name(cwrc, "italianNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:miller</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>miller</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#miller">http://sparql.cwrc.ca/ontologies/cwrc#miller</seealso>
    let miller = Prefixed_Name(cwrc, "miller") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:prisoner</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>prisoner</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#prisoner">http://sparql.cwrc.ca/ontologies/cwrc#prisoner</seealso>
    let prisoner = Prefixed_Name(cwrc, "prisoner") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:4dc5ff8c-d908-4377-bca8-9394408b7b67</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67">http://sparql.cwrc.ca/ontologies/cwrc#4dc5ff8c-d908-4377-bca8-9394408b7b67</seealso>
    let _4dc5ff8c_d908_4377_bca8_9394408b7b67 =
        Prefixed_Name(cwrc, "4dc5ff8c-d908-4377-bca8-9394408b7b67") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465">http://sparql.cwrc.ca/ontologies/cwrc#4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465</seealso>
    let _4f4d7ca6_5625_46d9_bd88_17847ee076d8_9141ebf465 =
        Prefixed_Name(cwrc, "4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:femaleSex</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///   <para>Deprecated in favour of instance &lt;a href="#genderWomanFemale" title="#genderWomanFemale"&gt;Woman/Female&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="#genderWomanFemale" title="#genderWomanFemale"&gt;Femme/Femelle&lt;/a&gt;.</para>
    /// labels<para>Femelle</para><para>Female</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#femaleSex">http://sparql.cwrc.ca/ontologies/cwrc#femaleSex</seealso>
    let femaleSex = Prefixed_Name(cwrc, "femaleSex") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd">http://sparql.cwrc.ca/ontologies/cwrc#aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd</seealso>
    let aec674cf_2108_4977_be3a_9317efe35aa9_b6c5d2bffd =
        Prefixed_Name(cwrc, "aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:affectedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>affected entity</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#affectedEntity">http://sparql.cwrc.ca/ontologies/cwrc#affectedEntity</seealso>
    let affectedEntity = Prefixed_Name(cwrc, "affectedEntity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:undergraduateDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Credential</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>undergraduate degree</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#undergraduateDegree">http://sparql.cwrc.ca/ontologies/cwrc#undergraduateDegree</seealso>
    let undergraduateDegree = Prefixed_Name(cwrc, "undergraduateDegree") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:contractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>contractor</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#contractor">http://sparql.cwrc.ca/ontologies/cwrc#contractor</seealso>
    let contractor = Prefixed_Name(cwrc, "contractor") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:elevatorOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>elevator operator</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#elevatorOperator">http://sparql.cwrc.ca/ontologies/cwrc#elevatorOperator</seealso>
    let elevatorOperator = Prefixed_Name(cwrc, "elevatorOperator") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:elocutionist</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>elucutionist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#elocutionist">http://sparql.cwrc.ca/ontologies/cwrc#elocutionist</seealso>
    let elocutionist = Prefixed_Name(cwrc, "elocutionist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:governorGeneral</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>governor general</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#governorGeneral">http://sparql.cwrc.ca/ontologies/cwrc#governorGeneral</seealso>
    let governorGeneral = Prefixed_Name(cwrc, "governorGeneral") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:higherGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>higher government</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#higherGovernment">http://sparql.cwrc.ca/ontologies/cwrc#higherGovernment</seealso>
    let higherGovernment = Prefixed_Name(cwrc, "higherGovernment") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:grandChildOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>petit enfant de</para><para>grandchild of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#grandChildOf">http://sparql.cwrc.ca/ontologies/cwrc#grandChildOf</seealso>
    let grandChildOf = Prefixed_Name(cwrc, "grandChildOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasGrandDaughter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has granddaughter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandDaughter">http://sparql.cwrc.ca/ontologies/cwrc#hasGrandDaughter</seealso>
    let hasGrandDaughter = Prefixed_Name(cwrc, "hasGrandDaughter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:grandFatherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>grandfather of</para><para>grand-père de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#grandFatherOf">http://sparql.cwrc.ca/ontologies/cwrc#grandFatherOf</seealso>
    let grandFatherOf = Prefixed_Name(cwrc, "grandFatherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:grandParentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>grandparent de</para><para>grandparent of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#grandParentOf">http://sparql.cwrc.ca/ontologies/cwrc#grandParentOf</seealso>
    let grandParentOf = Prefixed_Name(cwrc, "grandParentOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasGrandFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has grandfather</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandFather">http://sparql.cwrc.ca/ontologies/cwrc#hasGrandFather</seealso>
    let hasGrandFather = Prefixed_Name(cwrc, "hasGrandFather") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:grandMotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>grandmother of</para><para>grand-mère de</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#grandMotherOf">http://sparql.cwrc.ca/ontologies/cwrc#grandMotherOf</seealso>
    let grandMotherOf = Prefixed_Name(cwrc, "grandMotherOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepchild</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepChild">http://sparql.cwrc.ca/ontologies/cwrc#hasStepChild</seealso>
    let hasStepChild = Prefixed_Name(cwrc, "hasStepChild") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasStepDaughter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has stepdaughter</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepDaughter">http://sparql.cwrc.ca/ontologies/cwrc#hasStepDaughter</seealso>
    let hasStepDaughter = Prefixed_Name(cwrc, "hasStepDaughter") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:left-Wing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Gauche (politique)</para><para>left-wing</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#left-Wing">http://sparql.cwrc.ca/ontologies/cwrc#left-Wing</seealso>
    let left_Wing = Prefixed_Name(cwrc, "left-Wing") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:regionalGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>regional government</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#regionalGovernment">http://sparql.cwrc.ca/ontologies/cwrc#regionalGovernment</seealso>
    let regionalGovernment = Prefixed_Name(cwrc, "regionalGovernment") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:reincarnation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>réincarnation</para><para>reincarnation</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#reincarnation">http://sparql.cwrc.ca/ontologies/cwrc#reincarnation</seealso>
    let reincarnation = Prefixed_Name(cwrc, "reincarnation") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:spiritualism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Religion</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>spiritualism</para><para>spritisme</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#spiritualism">http://sparql.cwrc.ca/ontologies/cwrc#spiritualism</seealso>
    let spiritualism = Prefixed_Name(cwrc, "spiritualism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:welshNationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Nationalisme gallois</para><para>Welsh nationalism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#welshNationalism">http://sparql.cwrc.ca/ontologies/cwrc#welshNationalism</seealso>
    let welshNationalism = Prefixed_Name(cwrc, "welshNationalism") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:wendishEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>Wendish</para><para>Wende</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#wendishEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#wendishEthnicity</seealso>
    let wendishEthnicity = Prefixed_Name(cwrc, "wendishEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:westIndianEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>West Indian</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#westIndianEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#westIndianEthnicity</seealso>
    let westIndianEthnicity = Prefixed_Name(cwrc, "westIndianEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:westIndianNationalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:NationalHeritage</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>West Indian</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#westIndianNationalHeritage">http://sparql.cwrc.ca/ontologies/cwrc#westIndianNationalHeritage</seealso>
    let westIndianNationalHeritage =
        Prefixed_Name(cwrc, "westIndianNationalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:wetNurse</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>wet nurse</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#wetNurse">http://sparql.cwrc.ca/ontologies/cwrc#wetNurse</seealso>
    let wetNurse = Prefixed_Name(cwrc, "wetNurse") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:whaler</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>whaler</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#whaler">http://sparql.cwrc.ca/ontologies/cwrc#whaler</seealso>
    let whaler = Prefixed_Name(cwrc, "whaler") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:whiteEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Ethnicity</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>blanc</para><para>white</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#whiteEthnicity">http://sparql.cwrc.ca/ontologies/cwrc#whiteEthnicity</seealso>
    let whiteEthnicity = Prefixed_Name(cwrc, "whiteEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:whiteRaceColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:RaceColour</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    ///   <para>La description de ce terme est basée sur celle de DBPedia.</para>
    /// labels<para>white</para><para>blanc</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#whiteRaceColour">http://sparql.cwrc.ca/ontologies/cwrc#whiteRaceColour</seealso>
    let whiteRaceColour = Prefixed_Name(cwrc, "whiteRaceColour") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:originalOrlandoAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Group</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Members of the Orlando Project</para><para>Les membres du projet Orlando</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#originalOrlandoAuthor">http://sparql.cwrc.ca/ontologies/cwrc#originalOrlandoAuthor</seealso>
    let originalOrlandoAuthor =
        Prefixed_Name(cwrc, "originalOrlandoAuthor") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:SusanBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#SusanBrown">http://sparql.cwrc.ca/ontologies/cwrc#SusanBrown</seealso>
    let SusanBrown = Prefixed_Name(cwrc, "SusanBrown") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:ColinFaulkner</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ColinFaulkner">http://sparql.cwrc.ca/ontologies/cwrc#ColinFaulkner</seealso>
    let ColinFaulkner = Prefixed_Name(cwrc, "ColinFaulkner") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:DebStacey</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#DebStacey">http://sparql.cwrc.ca/ontologies/cwrc#DebStacey</seealso>
    let DebStacey = Prefixed_Name(cwrc, "DebStacey") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:AbigelLemak</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:NaturalPerson</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#AbigelLemak">http://sparql.cwrc.ca/ontologies/cwrc#AbigelLemak</seealso>
    let AbigelLemak = Prefixed_Name(cwrc, "AbigelLemak") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:3d49dc32-ac97-4abd-a252-573c52b463cf</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf">http://sparql.cwrc.ca/ontologies/cwrc#3d49dc32-ac97-4abd-a252-573c52b463cf</seealso>
    let _3d49dc32_ac97_4abd_a252_573c52b463cf =
        Prefixed_Name(cwrc, "3d49dc32-ac97-4abd-a252-573c52b463cf") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:EnglishLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of foreign instance &lt;a href="http://id.loc.gov/vocabulary/languages/eng"&gt;eng&lt;/a&gt;.</para>
    ///   <para>Désapprouver en faveur de l'instance &lt;a href="http://id.loc.gov/vocabulary/languages/eng"&gt;eng&lt;/a&gt;.</para>
    /// labels<para>Anglais</para><para>English</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EnglishLanguage">http://sparql.cwrc.ca/ontologies/cwrc#EnglishLanguage</seealso>
    let EnglishLanguage = Prefixed_Name(cwrc, "EnglishLanguage") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:EnglishNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of instance ISO 3166-2:GB-ENG.</para>
    ///   <para>Désapprouver en faveur de l'instance ISO 3166-2:GB-ENG.</para>
    /// labels<para>Anglais</para><para>English</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#EnglishNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#EnglishNationalIdentity</seealso>
    let EnglishNationalIdentity =
        Prefixed_Name(cwrc, "EnglishNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:englishNationalIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>Deprecated in favour of foreign instance ISO 3166-2:GB-ENG.</para>
    ///   <para>Désapprouver en faveur de l'instance ISO 3166-2:GB-ENG.</para>
    /// labels<para>Anglais</para><para>English</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#englishNationalIdentity">http://sparql.cwrc.ca/ontologies/cwrc#englishNationalIdentity</seealso>
    let englishNationalIdentity =
        Prefixed_Name(cwrc, "englishNationalIdentity") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:government</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>government</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#government">http://sparql.cwrc.ca/ontologies/cwrc#government</seealso>
    let government = Prefixed_Name(cwrc, "government") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470">http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470</seealso>
    let ebbbc6b3_1f7b_4b8d_8eb2_003fafec3470 =
        Prefixed_Name(cwrc, "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c">http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c</seealso>
    let ebbbc6b3_1f7b_4b8d_8eb2_003fafec3470_803d6baa7c =
        Prefixed_Name(cwrc, "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f">http://sparql.cwrc.ca/ontologies/cwrc#ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f</seealso>
    let ebbbc6b3_1f7b_4b8d_8eb2_003fafec3470_a76289714f =
        Prefixed_Name(cwrc, "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f") |> PrefixedName

    /// <summary>
    ///   <para>cwrc:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has participant</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasParticipant">http://sparql.cwrc.ca/ontologies/cwrc#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(cwrc, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:partnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>conjoint de</para><para>partner of</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#partnerOf">http://sparql.cwrc.ca/ontologies/cwrc#partnerOf</seealso>
    let partnerOf = Prefixed_Name(cwrc, "partnerOf") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasPeformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Désapprouver en faveur de la propriété &lt;a href="#hasEventElement" title="#hasEventElement"&gt;[http://sparql.cwrc.ca/ontologies/cwrc#hasEventElement]&lt;/a&gt;.</para>
    ///   <para>Deprecated in favour of property &lt;a href="#hasEventElement" title="#hasEventElement"&gt;[http://sparql.cwrc.ca/ontologies/cwrc#hasEventElement]&lt;/a&gt;.</para>
    /// labels<para>a une interprétation</para><para>has Peformance</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasPeformance">http://sparql.cwrc.ca/ontologies/cwrc#hasPeformance</seealso>
    let hasPeformance = Prefixed_Name(cwrc, "hasPeformance") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:hasEventElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#hasEventElement">http://sparql.cwrc.ca/ontologies/cwrc#hasEventElement</seealso>
    let hasEventElement = Prefixed_Name(cwrc, "hasEventElement") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:journalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>journalist</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#journalist">http://sparql.cwrc.ca/ontologies/cwrc#journalist</seealso>
    let journalist = Prefixed_Name(cwrc, "journalist") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:judge</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:Occupation</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>judge</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#judge">http://sparql.cwrc.ca/ontologies/cwrc#judge</seealso>
    let judge = Prefixed_Name(cwrc, "judge") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:knight</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>cwrc:Occupation</para>
    ///
    /// labels<para>knight</para><para></para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#knight">http://sparql.cwrc.ca/ontologies/cwrc#knight</seealso>
    let knight = Prefixed_Name(cwrc, "knight") |> PrefixedName
    /// <summary>
    ///   <para>cwrc:multiracialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwrc:PoliticalAffiliation</para>
    ///   <para>skos:Concept</para>
    ///   <para>The description for this term is indebted to DBpedia.</para>
    /// labels<para>multiracialisme</para><para>multiracialism</para></remarks>
    /// <seealso href="http://sparql.cwrc.ca/ontologies/cwrc#multiracialism">http://sparql.cwrc.ca/ontologies/cwrc#multiracialism</seealso>
    let multiracialism = Prefixed_Name(cwrc, "multiracialism") |> PrefixedName
