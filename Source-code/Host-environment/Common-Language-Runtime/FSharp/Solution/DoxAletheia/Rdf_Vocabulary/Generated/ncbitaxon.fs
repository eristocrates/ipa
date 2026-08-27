namespace http.purl.obolibrary.org.obo.NCBITaxon_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ncbitaxon =
    let _namespace_iri = Namespace_Iri ncbitaxon |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:NCBITaxon_10090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mus musculus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_10090">http://purl.obolibrary.org/obo/NCBITaxon_10090</seealso>
    let Mus_musculus = Prefixed_Name(ncbitaxon, "10090") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_10116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rattus norvegicus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_10116">http://purl.obolibrary.org/obo/NCBITaxon_10116</seealso>
    let Rattus_norvegicus = Prefixed_Name(ncbitaxon, "10116") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_10239</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Viruses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_10239">http://purl.obolibrary.org/obo/NCBITaxon_10239</seealso>
    let Viruses = Prefixed_Name(ncbitaxon, "10239") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_10292</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Herpesviridae"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_10292">http://purl.obolibrary.org/obo/NCBITaxon_10292</seealso>
    let Herpesviridae = Prefixed_Name(ncbitaxon, "10292") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_10358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cytomegalovirus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_10358">http://purl.obolibrary.org/obo/NCBITaxon_10358</seealso>
    let Cytomegalovirus = Prefixed_Name(ncbitaxon, "10358") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_10376</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Human gammaherpesvirus 4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_10376">http://purl.obolibrary.org/obo/NCBITaxon_10376</seealso>
    let Human_gammaherpesvirus_4 = Prefixed_Name(ncbitaxon, "10376") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_10407</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hepatitis B virus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_10407">http://purl.obolibrary.org/obo/NCBITaxon_10407</seealso>
    let Hepatitis_B_virus = Prefixed_Name(ncbitaxon, "10407") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_11103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hepatitis C virus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_11103">http://purl.obolibrary.org/obo/NCBITaxon_11103</seealso>
    let Hepatitis_C_virus = Prefixed_Name(ncbitaxon, "11103") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_11652</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Primate lentivirus group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_11652">http://purl.obolibrary.org/obo/NCBITaxon_11652</seealso>
    let Primate_lentivirus_group = Prefixed_Name(ncbitaxon, "11652") |> PrefixedName

    /// <summary>
    ///   <para>cdao:NCBITaxon_11676</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Human immunodeficiency virus 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_11676">http://purl.obolibrary.org/obo/NCBITaxon_11676</seealso>
    let Human_immunodeficiency_virus_1 =
        Prefixed_Name(ncbitaxon, "11676") |> PrefixedName

    /// <summary>
    ///   <para>cdao:NCBITaxon_11709</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Human immunodeficiency virus 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_11709">http://purl.obolibrary.org/obo/NCBITaxon_11709</seealso>
    let Human_immunodeficiency_virus_2 =
        Prefixed_Name(ncbitaxon, "11709") |> PrefixedName

    /// <summary>
    ///   <para>cdao:NCBITaxon_117571</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Euteleostomi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_117571">http://purl.obolibrary.org/obo/NCBITaxon_117571</seealso>
    let Euteleostomi = Prefixed_Name(ncbitaxon, "117571") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_1206794</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ecdysozoa"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_1206794">http://purl.obolibrary.org/obo/NCBITaxon_1206794</seealso>
    let Ecdysozoa = Prefixed_Name(ncbitaxon, "1206794") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_160</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Treponema pallidum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_160">http://purl.obolibrary.org/obo/NCBITaxon_160</seealso>
    let Treponema_pallidum = Prefixed_Name(ncbitaxon, "160") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_197562</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pancrustacea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_197562">http://purl.obolibrary.org/obo/NCBITaxon_197562</seealso>
    let Pancrustacea = Prefixed_Name(ncbitaxon, "197562") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bacteria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_2">http://purl.obolibrary.org/obo/NCBITaxon_2</seealso>
    let Bacteria = Prefixed_Name(ncbitaxon, "2") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_2157</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Archaea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_2157">http://purl.obolibrary.org/obo/NCBITaxon_2157</seealso>
    let Archaea = Prefixed_Name(ncbitaxon, "2157") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_2759</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Eukaryota"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_2759">http://purl.obolibrary.org/obo/NCBITaxon_2759</seealso>
    let Eukaryota = Prefixed_Name(ncbitaxon, "2759") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_314146</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Euarchontoglires"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_314146">http://purl.obolibrary.org/obo/NCBITaxon_314146</seealso>
    let Euarchontoglires = Prefixed_Name(ncbitaxon, "314146") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_32523</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tetrapoda"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_32523">http://purl.obolibrary.org/obo/NCBITaxon_32523</seealso>
    let Tetrapoda = Prefixed_Name(ncbitaxon, "32523") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_32524</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amniota"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_32524">http://purl.obolibrary.org/obo/NCBITaxon_32524</seealso>
    let Amniota = Prefixed_Name(ncbitaxon, "32524") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_33154</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Opisthokonta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_33154">http://purl.obolibrary.org/obo/NCBITaxon_33154</seealso>
    let Opisthokonta = Prefixed_Name(ncbitaxon, "33154") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_33213</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bilateria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_33213">http://purl.obolibrary.org/obo/NCBITaxon_33213</seealso>
    let Bilateria = Prefixed_Name(ncbitaxon, "33213") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_35268</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Retro-transcribing viruses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_35268">http://purl.obolibrary.org/obo/NCBITaxon_35268</seealso>
    let Retro_transcribing_viruses = Prefixed_Name(ncbitaxon, "35268") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_3702</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Arabidopsis thaliana"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_3702">http://purl.obolibrary.org/obo/NCBITaxon_3702</seealso>
    let Arabidopsis_thaliana = Prefixed_Name(ncbitaxon, "3702") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_388799</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HIV-1 group O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_388799">http://purl.obolibrary.org/obo/NCBITaxon_388799</seealso>
    let HIV_1_group_O = Prefixed_Name(ncbitaxon, "388799") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_39107</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Murinae"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_39107">http://purl.obolibrary.org/obo/NCBITaxon_39107</seealso>
    let Murinae = Prefixed_Name(ncbitaxon, "39107") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_40674</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mammalia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_40674">http://purl.obolibrary.org/obo/NCBITaxon_40674</seealso>
    let Mammalia = Prefixed_Name(ncbitaxon, "40674") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_44689</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dictyostelium discoideum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_44689">http://purl.obolibrary.org/obo/NCBITaxon_44689</seealso>
    let Dictyostelium_discoideum = Prefixed_Name(ncbitaxon, "44689") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_4890</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ascomycota"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_4890">http://purl.obolibrary.org/obo/NCBITaxon_4890</seealso>
    let Ascomycota = Prefixed_Name(ncbitaxon, "4890") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_4896</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Schizosaccharomyces pombe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_4896">http://purl.obolibrary.org/obo/NCBITaxon_4896</seealso>
    let Schizosaccharomyces_pombe = Prefixed_Name(ncbitaxon, "4896") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_4932</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Saccharomyces cerevisiae"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_4932">http://purl.obolibrary.org/obo/NCBITaxon_4932</seealso>
    let Saccharomyces_cerevisiae = Prefixed_Name(ncbitaxon, "4932") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_5140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Neurospora"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_5140">http://purl.obolibrary.org/obo/NCBITaxon_5140</seealso>
    let Neurospora = Prefixed_Name(ncbitaxon, "5140") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_6239</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Caenorhabditis elegans"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_6239">http://purl.obolibrary.org/obo/NCBITaxon_6239</seealso>
    let Caenorhabditis_elegans = Prefixed_Name(ncbitaxon, "6239") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_6668</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Daphnia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_6668">http://purl.obolibrary.org/obo/NCBITaxon_6668</seealso>
    let Daphnia = Prefixed_Name(ncbitaxon, "6668") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_716545</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"saccharomyceta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_716545">http://purl.obolibrary.org/obo/NCBITaxon_716545</seealso>
    let saccharomyceta = Prefixed_Name(ncbitaxon, "716545") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_7227</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Drosophila melanogaster"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_7227">http://purl.obolibrary.org/obo/NCBITaxon_7227</seealso>
    let Drosophila_melanogaster = Prefixed_Name(ncbitaxon, "7227") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_7742</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vertebrata &lt;Metazoa&gt;"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_7742">http://purl.obolibrary.org/obo/NCBITaxon_7742</seealso>
    let ``Vertebrata_<Metazoa>`` = Prefixed_Name(ncbitaxon, "7742") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_7955</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Danio rerio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_7955">http://purl.obolibrary.org/obo/NCBITaxon_7955</seealso>
    let Danio_rerio = Prefixed_Name(ncbitaxon, "7955") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_8353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Xenopus &lt;genus&gt;"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_8353">http://purl.obolibrary.org/obo/NCBITaxon_8353</seealso>
    let ``Xenopus_<genus>`` = Prefixed_Name(ncbitaxon, "8353") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_9031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gallus gallus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_9031">http://purl.obolibrary.org/obo/NCBITaxon_9031</seealso>
    let Gallus_gallus = Prefixed_Name(ncbitaxon, "9031") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_9606</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Homo sapiens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_9606">http://purl.obolibrary.org/obo/NCBITaxon_9606</seealso>
    let Homo_sapiens = Prefixed_Name(ncbitaxon, "9606") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_9989</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rodentia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_9989">http://purl.obolibrary.org/obo/NCBITaxon_9989</seealso>
    let Rodentia = Prefixed_Name(ncbitaxon, "9989") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_class">http://purl.obolibrary.org/obo/NCBITaxon_class</seealso>
    let class_ = Prefixed_Name(ncbitaxon, "class") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_family</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_family">http://purl.obolibrary.org/obo/NCBITaxon_family</seealso>
    let family = Prefixed_Name(ncbitaxon, "family") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_forma</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_forma">http://purl.obolibrary.org/obo/NCBITaxon_forma</seealso>
    let forma = Prefixed_Name(ncbitaxon, "forma") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_genus</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_genus">http://purl.obolibrary.org/obo/NCBITaxon_genus</seealso>
    let genus = Prefixed_Name(ncbitaxon, "genus") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_infraclass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_infraclass">http://purl.obolibrary.org/obo/NCBITaxon_infraclass</seealso>
    let infraclass = Prefixed_Name(ncbitaxon, "infraclass") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_infraorder</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_infraorder">http://purl.obolibrary.org/obo/NCBITaxon_infraorder</seealso>
    let infraorder = Prefixed_Name(ncbitaxon, "infraorder") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_kingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_kingdom">http://purl.obolibrary.org/obo/NCBITaxon_kingdom</seealso>
    let kingdom = Prefixed_Name(ncbitaxon, "kingdom") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_order</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_order">http://purl.obolibrary.org/obo/NCBITaxon_order</seealso>
    let order = Prefixed_Name(ncbitaxon, "order") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_phylum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_phylum">http://purl.obolibrary.org/obo/NCBITaxon_phylum</seealso>
    let phylum = Prefixed_Name(ncbitaxon, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_species</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_species">http://purl.obolibrary.org/obo/NCBITaxon_species</seealso>
    let species = Prefixed_Name(ncbitaxon, "species") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_subclass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_subclass">http://purl.obolibrary.org/obo/NCBITaxon_subclass</seealso>
    let subclass = Prefixed_Name(ncbitaxon, "subclass") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_subfamily</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_subfamily">http://purl.obolibrary.org/obo/NCBITaxon_subfamily</seealso>
    let subfamily = Prefixed_Name(ncbitaxon, "subfamily") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_subgenus</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_subgenus">http://purl.obolibrary.org/obo/NCBITaxon_subgenus</seealso>
    let subgenus = Prefixed_Name(ncbitaxon, "subgenus") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_subkingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_subkingdom">http://purl.obolibrary.org/obo/NCBITaxon_subkingdom</seealso>
    let subkingdom = Prefixed_Name(ncbitaxon, "subkingdom") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_suborder</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_suborder">http://purl.obolibrary.org/obo/NCBITaxon_suborder</seealso>
    let suborder = Prefixed_Name(ncbitaxon, "suborder") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_subphylum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_subphylum">http://purl.obolibrary.org/obo/NCBITaxon_subphylum</seealso>
    let subphylum = Prefixed_Name(ncbitaxon, "subphylum") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_subspecies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_subspecies">http://purl.obolibrary.org/obo/NCBITaxon_subspecies</seealso>
    let subspecies = Prefixed_Name(ncbitaxon, "subspecies") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_subtribe</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_subtribe">http://purl.obolibrary.org/obo/NCBITaxon_subtribe</seealso>
    let subtribe = Prefixed_Name(ncbitaxon, "subtribe") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_superclass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_superclass">http://purl.obolibrary.org/obo/NCBITaxon_superclass</seealso>
    let superclass = Prefixed_Name(ncbitaxon, "superclass") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_superfamily</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_superfamily">http://purl.obolibrary.org/obo/NCBITaxon_superfamily</seealso>
    let superfamily = Prefixed_Name(ncbitaxon, "superfamily") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_superkingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_superkingdom">http://purl.obolibrary.org/obo/NCBITaxon_superkingdom</seealso>
    let superkingdom = Prefixed_Name(ncbitaxon, "superkingdom") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_superorder</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_superorder">http://purl.obolibrary.org/obo/NCBITaxon_superorder</seealso>
    let superorder = Prefixed_Name(ncbitaxon, "superorder") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_tribe</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_tribe">http://purl.obolibrary.org/obo/NCBITaxon_tribe</seealso>
    let tribe = Prefixed_Name(ncbitaxon, "tribe") |> PrefixedName
    /// <summary>
    ///   <para>cdao:NCBITaxon_varietas</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/NCBITaxon_varietas">http://purl.obolibrary.org/obo/NCBITaxon_varietas</seealso>
    let varietas = Prefixed_Name(ncbitaxon, "varietas") |> PrefixedName
