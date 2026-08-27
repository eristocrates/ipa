namespace https.w3id.org.arco.ontology.catalogue.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ctlog =
    let _namespace_iri = Namespace_Iri ctlog |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/AccessProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il profilo di accesso ai dati contenuti in una scheda catalografica, con cui si forniscono indicazioni circa la diffusione pubblica dei dati catalografici sul web."</para>
    ///   <para>"This class represents the access profile to the data recorded in a catalogue record, giving instructions for public dissemination of data on the web."</para>
    /// labels<para>"Profilo di accesso"</para><para>"Access profile"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/AccessProfile">https://w3id.org/arco/ontology/catalogue/AccessProfile</seealso>
    let AccessProfile = Prefixed_Name(ctlog, "AccessProfile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/AdditionalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an additional form, that describes specific information about a cultural property (epigraphic documents, stratigraphy, unit, wall typology)"</para>
    ///   <para>"Questa classe rappresenta un modulo di approfondimento, utile a trattare secondo un approccio specialistico specifici aspetti del bene in esame (Documenti Epigrafici; Tipi Murari, Unità Stratigrafiche)"</para>
    /// labels<para>"Modulo di approfondimento"</para><para>"Additional form"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/AdditionalForm">https://w3id.org/arco/ontology/catalogue/AdditionalForm</seealso>
    let AdditionalForm = Prefixed_Name(ctlog, "AdditionalForm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/AdditionalFormType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the additional form type (Stratigraphic Unit, Wall Typology, Epigraphy)"</para>
    ///   <para>"Questa classe rappresenta il tipo di modulo di approfondimento (Unità Stratigrafica, Tipo Murario, Epigrafia)"</para>
    /// labels<para>"Additional form type"</para><para>"Tipo di modulo di approfondimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/AdditionalFormType">https://w3id.org/arco/ontology/catalogue/AdditionalFormType</seealso>
    let AdditionalFormType = Prefixed_Name(ctlog, "AdditionalFormType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/AlternativeIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an identifier of a catalogue record in information systems other than ICCD."</para>
    ///   <para>"Questa classe rappresenta un codice che identifica la scheda di catalogo nell'ambito di altri sistemi informativi, assegnato da enti diversi da ICCD."</para>
    /// labels<para>"Codice alternativo"</para><para>"Alternative Identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/AlternativeIdentifier">https://w3id.org/arco/ontology/catalogue/AlternativeIdentifier</seealso>
    let AlternativeIdentifier =
        Prefixed_Name(ctlog, "AlternativeIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/C</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/catalogue/CataloguingLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Detailed Level"</para><para>"Livello di Catalogo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/C">https://w3id.org/arco/ontology/catalogue/C</seealso>
    let C = Prefixed_Name(ctlog, "C") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a catalogue record, that is a descriptive model collecting and organising information on a cultural property, and which can have more than one version (after editing and updating)."</para>
    ///   <para>"Rappresenta una scheda di catalogo, cioè un modello descrittivo che raccoglie in modo organizzato le informazioni sui beni, e che può avere più versioni (in seguito ad aggiornamenti e revisioni)."</para>
    /// labels<para>"Scheda di catalogo"</para><para>"Catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecord">https://w3id.org/arco/ontology/catalogue/CatalogueRecord</seealso>
    let CatalogueRecord = Prefixed_Name(ctlog, "CatalogueRecord") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive architettura."</para>
    ///   <para>"This class represents the catalogue record describing Architecture."</para>
    /// labels<para>"Architecture catalogue record"</para><para>"Scheda Architettura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordA">https://w3id.org/arco/ontology/catalogue/CatalogueRecordA</seealso>
    let CatalogueRecordA = Prefixed_Name(ctlog, "CatalogueRecordA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive reperti antropologici."</para>
    ///   <para>"This class represents the catalogue record describing Anthropological materials."</para>
    /// labels<para>"Anthropological materials catalogue record"</para><para>"Scheda Reperti antropologici"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordAT">https://w3id.org/arco/ontology/catalogue/CatalogueRecordAT</seealso>
    let CatalogueRecordAT = Prefixed_Name(ctlog, "CatalogueRecordAT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBDI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni demoetnoantropologici immateriali."</para>
    ///   <para>"This class represents the catalogue record describing Intangible demo-ethno-anthropological heritage."</para>
    /// labels<para>"Intangible demo-ethno-anthropological heritage catalogue record"</para><para>"Scheda Beni demoetnoantropologici immateriali"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDI">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDI</seealso>
    let CatalogueRecordBDI = Prefixed_Name(ctlog, "CatalogueRecordBDI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBDM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Tangible demo-ethno-anthropological heritage."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni demoetnoantropologici materiali."</para>
    /// labels<para>"Tangible demo-ethno-anthropological heritage catalogue record"</para><para>"Scheda Beni demoetnoantropologici materiali"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDM">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDM</seealso>
    let CatalogueRecordBDM = Prefixed_Name(ctlog, "CatalogueRecordBDM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBNB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - botany."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Botanica."</para>
    /// labels<para>"Scheda Beni naturalistici-Botanica"</para><para>"Natural heritage - botany catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNB">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNB</seealso>
    let CatalogueRecordBNB = Prefixed_Name(ctlog, "CatalogueRecordBNB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBNM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - mineralogy."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Mineralogia."</para>
    /// labels<para>"Scheda Beni naturalistici-Mineralogia"</para><para>"Natural heritage - mineralogy catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNM">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNM</seealso>
    let CatalogueRecordBNM = Prefixed_Name(ctlog, "CatalogueRecordBNM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBNP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Paleontologia."</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - paleontology."</para>
    /// labels<para>"Scheda Beni naturalistici-Paleontologia"</para><para>"Natural heritage - paleontology catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNP">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNP</seealso>
    let CatalogueRecordBNP = Prefixed_Name(ctlog, "CatalogueRecordBNP") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBNPE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Petrologia."</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - petrology."</para>
    /// labels<para>"Scheda Beni naturalistici-Petrologia"</para><para>"Natural heritage - petrology catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPE">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPE</seealso>
    let CatalogueRecordBNPE =
        Prefixed_Name(ctlog, "CatalogueRecordBNPE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBNPL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - planetary science."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Planetologia."</para>
    /// labels<para>"Scheda Beni naturalistici-Planetologia"</para><para>"Natural heritage - planetary science catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPL">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPL</seealso>
    let CatalogueRecordBNPL =
        Prefixed_Name(ctlog, "CatalogueRecordBNPL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordBNZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Zoologia."</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - zoology."</para>
    /// labels<para>"Scheda Beni naturalistici-Zoologia"</para><para>"Natural heritage - zoology catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNZ">https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNZ</seealso>
    let CatalogueRecordBNZ = Prefixed_Name(ctlog, "CatalogueRecordBNZ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordCA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - archaeological complexes."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive complessi archeologici."</para>
    /// labels<para>"Scheda Complessi archeologici"</para><para>"Archaeological complexes catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCA">https://w3id.org/arco/ontology/catalogue/CatalogueRecordCA</seealso>
    let CatalogueRecordCA = Prefixed_Name(ctlog, "CatalogueRecordCA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordCNS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - historic cities / town centres."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive centri/nuclei storici."</para>
    /// labels<para>"Scheda Centri/nuclei storici"</para><para>"Historic cities / town centres catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCNS">https://w3id.org/arco/ontology/catalogue/CatalogueRecordCNS</seealso>
    let CatalogueRecordCNS = Prefixed_Name(ctlog, "CatalogueRecordCNS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive disegni."</para>
    ///   <para>"This class represents the catalogue record describing Natural heritage - drawings."</para>
    /// labels<para>"Scheda Disegni"</para><para>"Drawings catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordD">https://w3id.org/arco/ontology/catalogue/CatalogueRecordD</seealso>
    let CatalogueRecordD = Prefixed_Name(ctlog, "CatalogueRecordD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Ethnology."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive etnologia. Nell'ambito delle normative ICCD, è una scheda considerata obsoleta."</para>
    /// labels<para>"Ethnology catalogue record"</para><para>"Scheda Etnologia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordE">https://w3id.org/arco/ontology/catalogue/CatalogueRecordE</seealso>
    let CatalogueRecordE = Prefixed_Name(ctlog, "CatalogueRecordE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive fotografia."</para>
    ///   <para>"This class represents the catalogue record describing Photography."</para>
    /// labels<para>"Photograph catalogue record"</para><para>"Scheda Fotografia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordF">https://w3id.org/arco/ontology/catalogue/CatalogueRecordF</seealso>
    let CatalogueRecordF = Prefixed_Name(ctlog, "CatalogueRecordF") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordFF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Photographic Fonds."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive fondi fotografici."</para>
    /// labels<para>"Scheda Fondi fotografici"</para><para>"Photographic Fonds catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordFF">https://w3id.org/arco/ontology/catalogue/CatalogueRecordFF</seealso>
    let CatalogueRecordFF = Prefixed_Name(ctlog, "CatalogueRecordFF") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive monumenti archeologici."</para>
    ///   <para>"This class represents the catalogue record describing Archaeological monuments."</para>
    /// labels<para>"Archaeological monuments catalogue record"</para><para>"Scheda Monumenti archeologici"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMA">https://w3id.org/arco/ontology/catalogue/CatalogueRecordMA</seealso>
    let CatalogueRecordMA = Prefixed_Name(ctlog, "CatalogueRecordMA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordMI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive matrici incise."</para>
    ///   <para>"This class represents the catalogue record describing Printing plates."</para>
    /// labels<para>"Printing plates catalogue record"</para><para>"Scheda Matrici incise"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMI">https://w3id.org/arco/ontology/catalogue/CatalogueRecordMI</seealso>
    let CatalogueRecordMI = Prefixed_Name(ctlog, "CatalogueRecordMI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordNU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Numismatic properties."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive beni numismatici."</para>
    /// labels<para>"Scheda Beni numismatici"</para><para>"Numismatic properties catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordNU">https://w3id.org/arco/ontology/catalogue/CatalogueRecordNU</seealso>
    let CatalogueRecordNU = Prefixed_Name(ctlog, "CatalogueRecordNU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordOA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive opere/oggetti d'arte."</para>
    ///   <para>"This class represents the catalogue record describing Artworks."</para>
    /// labels<para>"Artworks catalogue record"</para><para>"Scheda Opere/oggetti d'arte"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOA">https://w3id.org/arco/ontology/catalogue/CatalogueRecordOA</seealso>
    let CatalogueRecordOA = Prefixed_Name(ctlog, "CatalogueRecordOA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordOAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Contemporary artworks."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive opere/oggetti d'arte contemporanea."</para>
    /// labels<para>"Contemporary artworks catalogue record"</para><para>"Scheda opere/oggetti d'arte contemporanea"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOAC">https://w3id.org/arco/ontology/catalogue/CatalogueRecordOAC</seealso>
    let CatalogueRecordOAC = Prefixed_Name(ctlog, "CatalogueRecordOAC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordPG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive parchi/giardini."</para>
    ///   <para>"This class represents the catalogue record describing Parks / Gardens."</para>
    /// labels<para>"Parks/Gardens catalogue record"</para><para>"Scheda Parchi/giardini"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPG">https://w3id.org/arco/ontology/catalogue/CatalogueRecordPG</seealso>
    let CatalogueRecordPG = Prefixed_Name(ctlog, "CatalogueRecordPG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordPST</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Scientific and technological heritage."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive il patrimonio scientifico e tecnologico."</para>
    /// labels<para>"Scientific and technological heritage catalogue record"</para><para>"Scheda Patrimonio scientifico e tecnologico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPST">https://w3id.org/arco/ontology/catalogue/CatalogueRecordPST</seealso>
    let CatalogueRecordPST = Prefixed_Name(ctlog, "CatalogueRecordPST") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordRA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive reperti archeologici."</para>
    ///   <para>"This class represents the catalogue record describing Archaeological objects."</para>
    /// labels<para>"Archaeological objects catalogue record"</para><para>"Scheda Reperti archeologici"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordRA">https://w3id.org/arco/ontology/catalogue/CatalogueRecordRA</seealso>
    let CatalogueRecordRA = Prefixed_Name(ctlog, "CatalogueRecordRA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Prints."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive stampe."</para>
    /// labels<para>"Prints catalogue record"</para><para>"Scheda Stampe"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordS">https://w3id.org/arco/ontology/catalogue/CatalogueRecordS</seealso>
    let CatalogueRecordS = Prefixed_Name(ctlog, "CatalogueRecordS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordSAS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Stratigraphic records."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive saggi stratigrafici."</para>
    /// labels<para>"Stratigraphic records catalogue record"</para><para>"Scheda Saggi stratigrafici"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSAS">https://w3id.org/arco/ontology/catalogue/CatalogueRecordSAS</seealso>
    let CatalogueRecordSAS = Prefixed_Name(ctlog, "CatalogueRecordSAS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Archaeological sites."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive siti archeologici."</para>
    /// labels<para>"Archaeological sites catalogue record"</para><para>"Scheda Siti archeologici"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSI">https://w3id.org/arco/ontology/catalogue/CatalogueRecordSI</seealso>
    let CatalogueRecordSI = Prefixed_Name(ctlog, "CatalogueRecordSI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordSM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Musical instruments."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive strumenti musicali."</para>
    /// labels<para>"Scheda Strumenti musicali"</para><para>"Musical instruments catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSM">https://w3id.org/arco/ontology/catalogue/CatalogueRecordSM</seealso>
    let CatalogueRecordSM = Prefixed_Name(ctlog, "CatalogueRecordSM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordSMO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Organs."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive strumenti musicali-organo."</para>
    /// labels<para>"Scheda Strumenti musicali-Organo"</para><para>"Musical instruments - Organs catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSMO">https://w3id.org/arco/ontology/catalogue/CatalogueRecordSMO</seealso>
    let CatalogueRecordSMO = Prefixed_Name(ctlog, "CatalogueRecordSMO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordTMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive tabella materiali archeologici."</para>
    ///   <para>"This class represents the catalogue record describing Archaeological materials tables."</para>
    /// labels<para>"Scheda Tabella materiali archeologici"</para><para>"Archaeological materials tables catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordTMA">https://w3id.org/arco/ontology/catalogue/CatalogueRecordTMA</seealso>
    let CatalogueRecordTMA = Prefixed_Name(ctlog, "CatalogueRecordTMA") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordVeAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the catalogue record describing Historic and contemporary garments."</para>
    ///   <para>"Questa classe rappresenta la scheda catalografica che descrive vestimenti antichi/contemporanei."</para>
    /// labels<para>"Historic and contemporary garments catalogue record"</para><para>"Scheda Vestimenti antichi/contemporanei"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVeAC">https://w3id.org/arco/ontology/catalogue/CatalogueRecordVeAC</seealso>
    let CatalogueRecordVeAC =
        Prefixed_Name(ctlog, "CatalogueRecordVeAC") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CatalogueRecordVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Rappresenta una versione (relativa a operazioni di redazione, aggiornamento, revisione) di una scheda di catalogo, cioè un modello descrittivo che raccoglie in modo organizzato le informazioni sui beni."</para>
    ///   <para>"This class represents a version (after creation, editing, updating) of a catalogue record on a cultural property."</para>
    /// labels<para>"Catalogue record version"</para><para>"Versione della scheda"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVersion">https://w3id.org/arco/ontology/catalogue/CatalogueRecordVersion</seealso>
    let CatalogueRecordVersion =
        Prefixed_Name(ctlog, "CatalogueRecordVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CataloguingLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the cataloguing level, defining the level of detail of the survey carried out on the cultural property (Minimum, Medium, Detailed)"</para>
    ///   <para>"Questa classe rappresenta il livello catalogazione, cioè la sigla che individua il grado di approfondimento dell'indagine condotta sul bene in esame (I corrisponde al livello di inventario, P al livello di precatalogo, C al livello di catalogo)"</para>
    /// labels<para>"Livello catalogazione"</para><para>"Cataloguing level"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CataloguingLevel">https://w3id.org/arco/ontology/catalogue/CataloguingLevel</seealso>
    let CataloguingLevel = Prefixed_Name(ctlog, "CataloguingLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/ComplexCPCatalogueRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una scheda catalografica che descrive un bene culturale complesso, a prescindere dal trattamento catalografico applicato (scheda unica/scheda d'insieme)."</para>
    ///   <para>"This class represents a catalogue record describing a complex cultural property."</para>
    /// labels<para>"Scheda catalografica su bene culturale complesso"</para><para>"Complex cultural property catalogue record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/ComplexCPCatalogueRecord">https://w3id.org/arco/ontology/catalogue/ComplexCPCatalogueRecord</seealso>
    let ComplexCPCatalogueRecord =
        Prefixed_Name(ctlog, "ComplexCPCatalogueRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/CulturalPropertyRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a record describing a cultural property for purposes other than cataloguing cultural heritage."</para>
    ///   <para>"Questa classe rappresenta una scheda che analizza il bene in esame per finalità diverse da quella specifica della catalogazione del patrimonio culturale."</para>
    /// labels<para>"Catalogue property record"</para><para>"Scheda su bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/CulturalPropertyRecord">https://w3id.org/arco/ontology/catalogue/CulturalPropertyRecord</seealso>
    let CulturalPropertyRecord =
        Prefixed_Name(ctlog, "CulturalPropertyRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/EpigraphyForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/catalogue/AdditionalFormType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Modulo sull'epigrafia"</para><para>"Epigraphy form"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/EpigraphyForm">https://w3id.org/arco/ontology/catalogue/EpigraphyForm</seealso>
    let EpigraphyForm = Prefixed_Name(ctlog, "EpigraphyForm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/I</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/catalogue/CataloguingLevel</para>
    ///
    /// labels<para>"Livello di Inventario"</para><para>"Minimum Level"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/I">https://w3id.org/arco/ontology/catalogue/I</seealso>
    let I = Prefixed_Name(ctlog, "I") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/ICCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta un codice assegnato a un'entità dall'ICCD. Si specializza in sottoproprietà (es.: codice univoco ICCD dell'autore, codice univoco ICCD del riferimento bibliografico, etc.)"</para>
    ///   <para>"This property represents the identifier assigned to a cultural property by ICCD."</para>
    /// labels<para>"codice univoco ICCD"</para><para>"ICCD identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/ICCDIdentifier">https://w3id.org/arco/ontology/catalogue/ICCDIdentifier</seealso>
    let ICCDIdentifier = Prefixed_Name(ctlog, "ICCDIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/InformationForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an information form, an ICCD standard for cultural heritage census and reporting activities, used to acquire information for any type of entity, with a minimum set of mandatory standardized data."</para>
    ///   <para>"Questa classe rappresenta un modulo informativo, uno standard ICCD per attività di censimento e segnalazione di beni culturali, utilizzato per acquisire informazioni per qualsiasi tipo di entità, con un set minimo di dati standardizzati obbligatori."</para>
    /// labels<para>"Information form"</para><para>"Modulo informativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/InformationForm">https://w3id.org/arco/ontology/catalogue/InformationForm</seealso>
    let InformationForm = Prefixed_Name(ctlog, "InformationForm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/MaximumPrivacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/catalogue/PrivacyLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Livello alto di riservatezza"</para><para>"Maximum privacy"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/MaximumPrivacy">https://w3id.org/arco/ontology/catalogue/MaximumPrivacy</seealso>
    let MaximumPrivacy = Prefixed_Name(ctlog, "MaximumPrivacy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/MediumPrivacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/catalogue/PrivacyLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Medium privacy"</para><para>"Livello medio di riservatezza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/MediumPrivacy">https://w3id.org/arco/ontology/catalogue/MediumPrivacy</seealso>
    let MediumPrivacy = Prefixed_Name(ctlog, "MediumPrivacy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/MinimumPrivacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/catalogue/PrivacyLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Livello basso di riservatezza"</para><para>"Minimum privacy"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/MinimumPrivacy">https://w3id.org/arco/ontology/catalogue/MinimumPrivacy</seealso>
    let MinimumPrivacy = Prefixed_Name(ctlog, "MinimumPrivacy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/P</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/catalogue/CataloguingLevel</para>
    ///
    /// labels<para>"Medium Level"</para><para>"Livello di Precatalogo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/P">https://w3id.org/arco/ontology/catalogue/P</seealso>
    let P = Prefixed_Name(ctlog, "P") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/PrivacyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il livello di riservatezza dei dati contenuti in una scheda catalografica (1 livello basso di riservatezza, 2 livello medio di riservatezza, 3 livello alto di riservatezza)"</para>
    ///   <para>"This class represents the privacy level of the data recorded in a catalogue record (Minimum, Medium, Maximum)."</para>
    /// labels<para>"Livello di riservatezza"</para><para>"Privacy level"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/PrivacyLevel">https://w3id.org/arco/ontology/catalogue/PrivacyLevel</seealso>
    let PrivacyLevel = Prefixed_Name(ctlog, "PrivacyLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/PrivacyReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la motivazione che ha determinato l'adozione di un profilo di accesso relativamente ai dati contenuti in una scheda catalografica."</para>
    ///   <para>"This class represents the reason for the adoption of a specific access profile for a catalogue record."</para>
    /// labels<para>"Privacy reason"</para><para>"Motivo di riservatezza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/PrivacyReason">https://w3id.org/arco/ontology/catalogue/PrivacyReason</seealso>
    let PrivacyReason = Prefixed_Name(ctlog, "PrivacyReason") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/StratigraphicUnitForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/catalogue/AdditionalFormType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Stratigraphic Unit form"</para><para>"Modulo sull'Unità Stratigrafica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/StratigraphicUnitForm">https://w3id.org/arco/ontology/catalogue/StratigraphicUnitForm</seealso>
    let StratigraphicUnitForm =
        Prefixed_Name(ctlog, "StratigraphicUnitForm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/WallTypologyForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/catalogue/AdditionalFormType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Modulo sul Tipo Murario"</para><para>"Wall Typology form"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/WallTypologyForm">https://w3id.org/arco/ontology/catalogue/WallTypologyForm</seealso>
    let WallTypologyForm = Prefixed_Name(ctlog, "WallTypologyForm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/additionalFormIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the additional form identifier."</para>
    ///   <para>"Questa proprietà permette di associare un identificativo a un modulo di approfondimento."</para>
    /// labels<para>"additional form identifier"</para><para>"identificativo del modulo di approfondimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/additionalFormIdentifier">https://w3id.org/arco/ontology/catalogue/additionalFormIdentifier</seealso>
    let additionalFormIdentifier =
        Prefixed_Name(ctlog, "additionalFormIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/catalogueRecordIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà permette di associare l'identificativo a una scheda catalografica che descrive un bene culturale."</para>
    ///   <para>"This property represents the identifier of a catalogue record describing a cultural property."</para>
    /// labels<para>"identificativo della scheda di catalogo"</para><para>"catalogue record identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/catalogueRecordIdentifier">https://w3id.org/arco/ontology/catalogue/catalogueRecordIdentifier</seealso>
    let catalogueRecordIdentifier =
        Prefixed_Name(ctlog, "catalogueRecordIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/culturalPropertyRecordIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà permette di associare l'identificativo a una scheda in cui si analizza un bene culturale per finalità diverse da quella specificazione della catalogazione del patrimonio culturale."</para>
    ///   <para>"This property is used to associate the identifier to a catalogue record that analyze the cultural property for reasons other than cataloguing the cultural heritage."</para>
    /// labels<para>"identificativo di scheda su bene culturale"</para><para>"cultural property record identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/culturalPropertyRecordIdentifier">https://w3id.org/arco/ontology/catalogue/culturalPropertyRecordIdentifier</seealso>
    let culturalPropertyRecordIdentifier =
        Prefixed_Name(ctlog, "culturalPropertyRecordIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/deletedICCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the ICCD's identifier deleted for many reasons, used to search for obsolete catalogue records."</para>
    ///   <para>"Questa proprietà rappresenta un codice ICCD eventualmente soppresso per motivi di diversa natura, utile per poter ricercare e consultare le schede pregresse nell'Archivio storico gestito dall'Istituto o da altri Enti."</para>
    /// labels<para>"codice ICCD soppresso"</para><para>"deleted ICCD identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/deletedICCDIdentifier">https://w3id.org/arco/ontology/catalogue/deletedICCDIdentifier</seealso>
    let deletedICCDIdentifier =
        Prefixed_Name(ctlog, "deletedICCDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà è stata creata come proprietà generica di sottoproprietà specifiche, e rappresenta la relazione tra un'entità che descrive un'altra entità."</para>
    ///   <para>"This property was created as a generic property for specific subproperties, and represents the relationship between an entity that describes another entity."</para>
    /// labels<para>"describes"</para><para>"descrive"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/describes">https://w3id.org/arco/ontology/catalogue/describes</seealso>
    let describes = Prefixed_Name(ctlog, "describes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/describesCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che consente di associare la scheda di catalogo al bene culturale che essa descrive."</para>
    ///   <para>"Property used to associate the catalogue record with the cultural property that the catalogue record describes."</para>
    /// labels<para>"descrive"</para><para>"describes"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/describesCulturalProperty">https://w3id.org/arco/ontology/catalogue/describesCulturalProperty</seealso>
    let describesCulturalProperty =
        Prefixed_Name(ctlog, "describesCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/editedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property used to associate a catalogue record version with the time interval in which it was edited."</para>
    ///   <para>"Proprietà che associa una versione di una scheda di catalogo all'intervallo temporale in cui è stata compilata."</para>
    /// labels<para>"compilato al tempo"</para><para>"edited at time"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/editedAtTime">https://w3id.org/arco/ontology/catalogue/editedAtTime</seealso>
    let editedAtTime = Prefixed_Name(ctlog, "editedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/editingTimeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "compilato al tempo"."</para>
    ///   <para>"This is the inverse property of "edited at time"."</para>
    /// labels<para>"editing time of"</para><para>"tempo di compilazione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/editingTimeOf">https://w3id.org/arco/ontology/catalogue/editingTimeOf</seealso>
    let editingTimeOf = Prefixed_Name(ctlog, "editingTimeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasAccessProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una scheda di catalogo al profilo di accesso ai dati (basso, medio, alto)."</para>
    /// labels<para>"has access profile"</para><para>"ha profilo di accesso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasAccessProfile">https://w3id.org/arco/ontology/catalogue/hasAccessProfile</seealso>
    let hasAccessProfile = Prefixed_Name(ctlog, "hasAccessProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasAdditionalFormResponsibleAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un modulo di approfondimento all'ente/il soggetto responsabile nel SIGECweb della redazione del modulo."</para>
    ///   <para>"This property relates an additional form to the responsible agent of that form in the SIGECweb."</para>
    /// labels<para>"has additional form responsible agent"</para><para>"ha responsabile di modulo di approfondimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormResponsibleAgent">https://w3id.org/arco/ontology/catalogue/hasAdditionalFormResponsibleAgent</seealso>
    let hasAdditionalFormResponsibleAgent =
        Prefixed_Name(ctlog, "hasAdditionalFormResponsibleAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasAdditionalFormType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un modulo di approfondimento al tipo di modulo (Unità Stratigrafica, Tipo Murario, Epigrafia)."</para>
    ///   <para>"This property relates an additional form to its type (Stratigraphic Unit, Epigraphy, Wall Typology)."</para>
    /// labels<para>"ha tipo di modulo di approfondimento"</para><para>"has additional form type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormType">https://w3id.org/arco/ontology/catalogue/hasAdditionalFormType</seealso>
    let hasAdditionalFormType =
        Prefixed_Name(ctlog, "hasAdditionalFormType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasAlternativeIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una scheda di catalogo a un codice che identifica la scheda di catalogo nell'ambito di altri sistemi informativi, assegnato da enti diversi da ICCD."</para>
    ///   <para>"Property used to associate a catalogue record with an identifier created in the context of information systems other than ICCD's SIGECweb."</para>
    /// labels<para>"has alternative identifier"</para><para>"ha altro codice identificativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasAlternativeIdentifier">https://w3id.org/arco/ontology/catalogue/hasAlternativeIdentifier</seealso>
    let hasAlternativeIdentifier =
        Prefixed_Name(ctlog, "hasAlternativeIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasCatalogueRecordVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property used to associate a catalogue record to one of its versions (e.g. after update)"</para>
    ///   <para>"Proprietà che permette di collegare una scheda di catalogo, intesa come oggetto informativo che descrive un bene culturale, a una sua versione (corrispondente a un particolare stato dovuto a operazioni di redazione, aggiornamento, revisione)."</para>
    /// labels<para>"has version"</para><para>"ha versione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersion">https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersion</seealso>
    let hasCatalogueRecordVersion =
        Prefixed_Name(ctlog, "hasCatalogueRecordVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasCatalogueRecordVersionRiT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to associate a particular version of a catalogue record to the role in time of an agent that plays a role in updating the catalogue record."</para>
    ///   <para>"Questa proprietà permette di associare una particolare versione di una scheda al ruolo nel tempo che un agente esercita nell'ambito della redazione, dell'aggiornamento o revisione della scheda."</para>
    /// labels<para>"has role in time"</para><para>"ha ruolo nel tempo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersionRiT">https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersionRiT</seealso>
    let hasCatalogueRecordVersionRiT =
        Prefixed_Name(ctlog, "hasCatalogueRecordVersionRiT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasCataloguingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega una versione di una scheda di catalogo a un agente che riveste un ruolo nelle attività di catalogazione di quella scheda. La relazione tra il ruolo e l'agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Questa relazione è poi specializzata da sottoproprietà. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l’ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    ///   <para>"This property is used to associate a catalogue record to an agent playing a role in cataloguing activities."</para>
    /// labels<para>"has cataloguing agent"</para><para>"ha agente coinvolto nella catalogazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasCataloguingAgent">https://w3id.org/arco/ontology/catalogue/hasCataloguingAgent</seealso>
    let hasCataloguingAgent =
        Prefixed_Name(ctlog, "hasCataloguingAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasCataloguingLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà permette di associare una scheda di catalogo al suo livello di catalogazione."</para>
    /// labels<para>"has cataloguing level"</para><para>"ha livello di catalogazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasCataloguingLevel">https://w3id.org/arco/ontology/catalogue/hasCataloguingLevel</seealso>
    let hasCataloguingLevel =
        Prefixed_Name(ctlog, "hasCataloguingLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasCulturalPropertyRecordResponsibleAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property record to the agency or the person that created that record or manages the database where the record is."</para>
    ///   <para>"Questa proprietà collega una scheda in cui si analizza un bene culturale per finalità diverse da quella della catalogazione del patrimonio all'Ente o al soggetto che ha prodotto la scheda o che gestisce la banca dati di cui la scheda fa parte."</para>
    /// labels<para>"has cultural property record responsible agent"</para><para>"ha agente responsabile della scheda su bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasCulturalPropertyRecordResponsibleAgent">https://w3id.org/arco/ontology/catalogue/hasCulturalPropertyRecordResponsibleAgent</seealso>
    let hasCulturalPropertyRecordResponsibleAgent =
        Prefixed_Name(ctlog, "hasCulturalPropertyRecordResponsibleAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasDigitalTranscriptionOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega una versione, relativa a trascrizione per informatizzazione, di una scheda di catalogo al relativo operatore. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"ha operatore di trascrizione per informatizzazione"</para><para>"has digital transcription operator"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionOperator">https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionOperator</seealso>
    let hasDigitalTranscriptionOperator =
        Prefixed_Name(ctlog, "hasDigitalTranscriptionOperator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasDigitalTranscriptionResponsibleAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega una versione, relativa a trascrizione per informatizzazione, di una scheda di catalogo al relativo ente/soggetto responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"ha ente o soggetto responsabile di trascrizione per informatizzazione"</para><para>"has digital transcription responsible agent"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionResponsibleAgent">https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionResponsibleAgent</seealso>
    let hasDigitalTranscriptionResponsibleAgent =
        Prefixed_Name(ctlog, "hasDigitalTranscriptionResponsibleAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasImmediatePreviousVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property used to associate a catalogue record version to its immediate previous version."</para>
    ///   <para>"Questa proprietà associa una versione di una scheda alla sua versione immediatamente precedente."</para>
    /// labels<para>"has immediate previous version"</para><para>"ha la versione precedente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasImmediatePreviousVersion">https://w3id.org/arco/ontology/catalogue/hasImmediatePreviousVersion</seealso>
    let hasImmediatePreviousVersion =
        Prefixed_Name(ctlog, "hasImmediatePreviousVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasOfficialInCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega la prima versione di una scheda di catalogo al relativo funzionario responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"ha funzionario responsabile"</para><para>"has official in charge"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasOfficialInCharge">https://w3id.org/arco/ontology/catalogue/hasOfficialInCharge</seealso>
    let hasOfficialInCharge =
        Prefixed_Name(ctlog, "hasOfficialInCharge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasPreviousVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Property used to associate a catalogue record version to its previous version."</para>
    ///   <para>"Questa proprietà associa una versione di una scheda a una sua versione precedente."</para>
    /// labels<para>"ha versione precedente"</para><para>"has previous version"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasPreviousVersion">https://w3id.org/arco/ontology/catalogue/hasPreviousVersion</seealso>
    let hasPreviousVersion = Prefixed_Name(ctlog, "hasPreviousVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasPrivacyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il profilo di accesso di una scheda catalografica al livello di riservatezza dei dati contenutevi (basso livello di riservatezza, alto livello di riservatezza, medio livello di riservatezza)."</para>
    /// labels<para>"ha livello di riservatezza"</para><para>"has privacy level"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasPrivacyLevel">https://w3id.org/arco/ontology/catalogue/hasPrivacyLevel</seealso>
    let hasPrivacyLevel = Prefixed_Name(ctlog, "hasPrivacyLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasPrivacyReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno specifico profilo d'accesso ai dati di una scheda catalografica alla motivazione che ha determinato l'adozione di quel profilo d'accesso (es.: scheda contenente dati liberamente accessibili, scheda contenente dati personali, scheda di bene di proprietà privata, scheda di bene a rischio, scheda di bene non adeguatamente sorvegliabile)"</para>
    /// labels<para>"has privacy reason"</para><para>"ha motivazione di riservatezza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasPrivacyReason">https://w3id.org/arco/ontology/catalogue/hasPrivacyReason</seealso>
    let hasPrivacyReason = Prefixed_Name(ctlog, "hasPrivacyReason") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasResponsibleResearchAndCompilation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega la prima versione di una scheda di catalogo al relativo responsabile ricerca e redazione. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"ha responsabile ricerca e redazione"</para><para>"has responsible research and compilation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasResponsibleResearchAndCompilation">https://w3id.org/arco/ontology/catalogue/hasResponsibleResearchAndCompilation</seealso>
    let hasResponsibleResearchAndCompilation =
        Prefixed_Name(ctlog, "hasResponsibleResearchAndCompilation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasScientificDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega la prima versione di una scheda di catalogo al relativo referente verifica scientifica. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"ha referente verifica scientifica"</para><para>"has scientific director"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasScientificDirector">https://w3id.org/arco/ontology/catalogue/hasScientificDirector</seealso>
    let hasScientificDirector =
        Prefixed_Name(ctlog, "hasScientificDirector") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasUpdateOfficialInCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo funzionario responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"has update official in charge"</para><para>"ha funzionario responsabile di aggiornamento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasUpdateOfficialInCharge">https://w3id.org/arco/ontology/catalogue/hasUpdateOfficialInCharge</seealso>
    let hasUpdateOfficialInCharge =
        Prefixed_Name(ctlog, "hasUpdateOfficialInCharge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasUpdateResponsibleAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo ente/soggetto responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"has update responsible agency or person"</para><para>"ha ente o soggetto responsabile di aggiornamento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleAgent">https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleAgent</seealso>
    let hasUpdateResponsibleAgent =
        Prefixed_Name(ctlog, "hasUpdateResponsibleAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasUpdateResponsibleResearchAndCompilation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo responsabile ricerca e redazione. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"ha responsabile di ricerca e redazione di aggiornamento"</para><para>"has update responsible research and compilation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleResearchAndCompilation">https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleResearchAndCompilation</seealso>
    let hasUpdateResponsibleResearchAndCompilation =
        Prefixed_Name(ctlog, "hasUpdateResponsibleResearchAndCompilation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/hasUpdateScientificRevisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo referente verifica scientifica. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale."</para>
    /// labels<para>"has update scientific revisor"</para><para>"ha referente verifica scientifica di aggiornamento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/hasUpdateScientificRevisor">https://w3id.org/arco/ontology/catalogue/hasUpdateScientificRevisor</seealso>
    let hasUpdateScientificRevisor =
        Prefixed_Name(ctlog, "hasUpdateScientificRevisor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/iccdNormTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This property annotates the field or the fields of the ICCD regulation to which a specific class or property refers."</para>
    ///   <para>"Questa proprietà permette di annotare il campo o i campi della normativa ICCD corrispondenti a una determinata classe o proprietà dell'ontologia."</para>
    /// labels<para>"ICCD norm tag"</para><para>"acronimo normativa ICCD"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/iccdNormTag">https://w3id.org/arco/ontology/catalogue/iccdNormTag</seealso>
    let iccdNormTag = Prefixed_Name(ctlog, "iccdNormTag") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/informationFormIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà permette di associare l'identificativo a un modulo informativo che è collegato a un bene culturale."</para>
    ///   <para>"This property links an identifier to an information form related to a cultural property."</para>
    /// labels<para>"information form identifier"</para><para>"identificativo del modulo informativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/informationFormIdentifier">https://w3id.org/arco/ontology/catalogue/informationFormIdentifier</seealso>
    let informationFormIdentifier =
        Prefixed_Name(ctlog, "informationFormIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isAccessProfileOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha profilo di accesso"."</para>
    ///   <para>"This is the inverse property of "has access profile"."</para>
    /// labels<para>"is access profile of"</para><para>"è profilo di accesso di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isAccessProfileOf">https://w3id.org/arco/ontology/catalogue/isAccessProfileOf</seealso>
    let isAccessProfileOf = Prefixed_Name(ctlog, "isAccessProfileOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isAdditionalFormResponsibleAgentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha responsabile di modulo di approfondimento"."</para>
    ///   <para>"This is the inverse property of "has additional form responsible agent""</para>
    /// labels<para>"è responsabile di modulo di approfondimento"</para><para>"is additional form responsible agent of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormResponsibleAgentOf">https://w3id.org/arco/ontology/catalogue/isAdditionalFormResponsibleAgentOf</seealso>
    let isAdditionalFormResponsibleAgentOf =
        Prefixed_Name(ctlog, "isAdditionalFormResponsibleAgentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isAdditionalFormTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di modulo di approfondimento"."</para>
    ///   <para>"This is the inverse property of "has additional form type"."</para>
    /// labels<para>"è tipo di modulo di approfondimento di"</para><para>"is additional form type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormTypeOf">https://w3id.org/arco/ontology/catalogue/isAdditionalFormTypeOf</seealso>
    let isAdditionalFormTypeOf =
        Prefixed_Name(ctlog, "isAdditionalFormTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isAlternativeIdentifierOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has alternative identifier"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha altro codice identificativo"."</para>
    /// labels<para>"è altro codice identificativo di"</para><para>"is alternative identifier of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isAlternativeIdentifierOf">https://w3id.org/arco/ontology/catalogue/isAlternativeIdentifierOf</seealso>
    let isAlternativeIdentifierOf =
        Prefixed_Name(ctlog, "isAlternativeIdentifierOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isCatalogueRecordVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà, inversa di "ha versione", che permette di collegare una versione  (corrispondente a un particolare stato dovuto a operazioni di redazione, aggiornamento, revisione) di una scheda di catalogo alla scheda di catalogo intesa come oggetto informativo che descrive un bene culturale."</para>
    ///   <para>"Property, inverse of "has catalogue record version", used to associate a catalogue record version (e.g. after update) to the catalogue record."</para>
    /// labels<para>"è versione di"</para><para>"is catalogue record version of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionOf">https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionOf</seealso>
    let isCatalogueRecordVersionOf =
        Prefixed_Name(ctlog, "isCatalogueRecordVersionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isCatalogueRecordVersionRiTOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property, inverse of "has catalogue record version role in time", used to associate a role in time to the agent playing that role, in the updating of a particular version of a catalogue record."</para>
    ///   <para>"Questa proprietà, inversa a "ha ruolo nel tempo", permette di associare il ruolo nel tempo che un agente esercita nell'ambito della redazione, dell'aggiornamento o revisione della scheda a una particolare versione di una scheda."</para>
    /// labels<para>"is role in time of"</para><para>"è ruolo nel tempo di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionRiTOf">https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionRiTOf</seealso>
    let isCatalogueRecordVersionRiTOf =
        Prefixed_Name(ctlog, "isCatalogueRecordVersionRiTOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isCataloguingAgentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "ha agente coinvolto nella catalogazione", rappresenta la relazione che collega un agente che riveste un ruolo nelle attività di catalogazione di una scheda di catalogo alla scheda stessa."</para>
    ///   <para>"This property, inverse of "has cataloguin agent", is used to associate an agent playing a role in cataloguing activities to the catalogue record."</para>
    /// labels<para>"è agente coinvolto nella catalogazione di"</para><para>"is cataloguing agent of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isCataloguingAgentOf">https://w3id.org/arco/ontology/catalogue/isCataloguingAgentOf</seealso>
    let isCataloguingAgentOf =
        Prefixed_Name(ctlog, "isCataloguingAgentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isCataloguingLevelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha livello di catalogazione"."</para>
    ///   <para>"This is the inverse property of "has cataloguing level"."</para>
    /// labels<para>"is cataloguing level of"</para><para>"è livello di catalogazione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isCataloguingLevelOf">https://w3id.org/arco/ontology/catalogue/isCataloguingLevelOf</seealso>
    let isCataloguingLevelOf =
        Prefixed_Name(ctlog, "isCataloguingLevelOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa della proprietà "descrive", è stata creata come proprietà generica di sottoproprietà specifiche, e rappresenta la relazione tra un'entità descritta da un'altra entità."</para>
    ///   <para>"This property, inverse property of "describes", was created as a generic property for specific subproperties, and represents the relationship between an entity described by another entity."</para>
    /// labels<para>"è descritto da"</para><para>"is described by"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isDescribedBy">https://w3id.org/arco/ontology/catalogue/isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(ctlog, "isDescribedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isDescribedByCatalogueRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property, inverse of "describes", is used to associate a cultural property with the catalogue record that describes it."</para>
    ///   <para>"Questa proprietà, inversa di "descrive", permette di associare un bene culturale alla scheda di catalogo che lo descrive."</para>
    /// labels<para>"is described by"</para><para>"è descritto da"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isDescribedByCatalogueRecord">https://w3id.org/arco/ontology/catalogue/isDescribedByCatalogueRecord</seealso>
    let isDescribedByCatalogueRecord =
        Prefixed_Name(ctlog, "isDescribedByCatalogueRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isDigitalTranscriptionOperatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has digital transcription operator"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha operatore di trascrizione per informatizzazione"."</para>
    /// labels<para>"è operatore di trascrizione per informatizzazione di"</para><para>"is digital transcription operator of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionOperatorOf">https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionOperatorOf</seealso>
    let isDigitalTranscriptionOperatorOf =
        Prefixed_Name(ctlog, "isDigitalTranscriptionOperatorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isDigitalTranscriptionResponsibleAgentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha ente o soggetto responsabile di trascrizione per informatizzazione"."</para>
    ///   <para>"This is the inverse property of "has digital transcription responsible agent"."</para>
    /// labels<para>"è ente o soggetto responsabile di trascrizione per informatizzazione di"</para><para>"is digital transcription responsible agent of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionResponsibleAgentOf">https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionResponsibleAgentOf</seealso>
    let isDigitalTranscriptionResponsibleAgentOf =
        Prefixed_Name(ctlog, "isDigitalTranscriptionResponsibleAgentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isImmediatePreviousVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà associa una versione di una scheda alla sua versione immediatamente successiva."</para>
    ///   <para>"Property used to associate a catalogue record version to its immediate next version."</para>
    /// labels<para>"è la versione precedente di"</para><para>"is immediate previous version of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isImmediatePreviousVersionOf">https://w3id.org/arco/ontology/catalogue/isImmediatePreviousVersionOf</seealso>
    let isImmediatePreviousVersionOf =
        Prefixed_Name(ctlog, "isImmediatePreviousVersionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isOfficialInChargeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has official in charge"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha funzionario responsabile"."</para>
    /// labels<para>"è funzionario responsabile di"</para><para>"is official in charge of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isOfficialInChargeOf">https://w3id.org/arco/ontology/catalogue/isOfficialInChargeOf</seealso>
    let isOfficialInChargeOf =
        Prefixed_Name(ctlog, "isOfficialInChargeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isPreviousVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Questa proprietà associa una versione di una scheda a una sua versione successiva."</para>
    ///   <para>"Property used to associate a catalogue record version one of its next version."</para>
    /// labels<para>"is previous version of"</para><para>"è versione precedente di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isPreviousVersionOf">https://w3id.org/arco/ontology/catalogue/isPreviousVersionOf</seealso>
    let isPreviousVersionOf =
        Prefixed_Name(ctlog, "isPreviousVersionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isPrivacyLevelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has privacy level"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha livello di riservatezza"."</para>
    /// labels<para>"is privacy level of"</para><para>"è livello di riservatezza di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isPrivacyLevelOf">https://w3id.org/arco/ontology/catalogue/isPrivacyLevelOf</seealso>
    let isPrivacyLevelOf = Prefixed_Name(ctlog, "isPrivacyLevelOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isPrivacyReasonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has privacy reason"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha motivazione di riservatezza"."</para>
    /// labels<para>"è motivazione di riservatezza di"</para><para>"is privacy reason of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isPrivacyReasonOf">https://w3id.org/arco/ontology/catalogue/isPrivacyReasonOf</seealso>
    let isPrivacyReasonOf = Prefixed_Name(ctlog, "isPrivacyReasonOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isRelatedToAdditionalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property to an additional form."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un modulo di approfondimento in relazione con il bene in esame."</para>
    /// labels<para>"è collegato a modulo di approfondimento"</para><para>"is related to additional form"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isRelatedToAdditionalForm">https://w3id.org/arco/ontology/catalogue/isRelatedToAdditionalForm</seealso>
    let isRelatedToAdditionalForm =
        Prefixed_Name(ctlog, "isRelatedToAdditionalForm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isRelatedToInformationForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property to an information form."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un modulo informativo in relazione con il bene in esame."</para>
    /// labels<para>"è collegato a modulo informativo"</para><para>"is related to information form"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isRelatedToInformationForm">https://w3id.org/arco/ontology/catalogue/isRelatedToInformationForm</seealso>
    let isRelatedToInformationForm =
        Prefixed_Name(ctlog, "isRelatedToInformationForm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isResponsibleAgentOfCulturalPropertyRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "ha agente responsabile di scheda su bene culturale", collega l'Ente o il soggetto che ha prodotto la scheda o che gestisce la banca dati di cui la scheda fa parte alla scheda stessa."</para>
    ///   <para>"This property, inverse of "has cultural property record responsible agent", relates the agency or the person that created the record or manages the database where the record is to the record itself."</para>
    /// labels<para>"è ente responsabile della scheda su bene culturale"</para><para>"is responsible agent of cultural property record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isResponsibleAgentOfCulturalPropertyRecord">https://w3id.org/arco/ontology/catalogue/isResponsibleAgentOfCulturalPropertyRecord</seealso>
    let isResponsibleAgentOfCulturalPropertyRecord =
        Prefixed_Name(ctlog, "isResponsibleAgentOfCulturalPropertyRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isResponsibleResearchAndCompilationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has responsible research and compilation"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha responsabile ricerca e redazione"."</para>
    /// labels<para>"is responsible research and compilation of"</para><para>"è responsabile ricerca e redazione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isResponsibleResearchAndCompilationOf">https://w3id.org/arco/ontology/catalogue/isResponsibleResearchAndCompilationOf</seealso>
    let isResponsibleResearchAndCompilationOf =
        Prefixed_Name(ctlog, "isResponsibleResearchAndCompilationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isScientificDirectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha referente verifica scientifica"."</para>
    ///   <para>"This is the inverse property of "has scientific director"."</para>
    /// labels<para>"è referente verifica scientifica di"</para><para>"is scientific director of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isScientificDirectorOf">https://w3id.org/arco/ontology/catalogue/isScientificDirectorOf</seealso>
    let isScientificDirectorOf =
        Prefixed_Name(ctlog, "isScientificDirectorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isUpdateOfficialInChargeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha funzionario responsabile di aggiornamento"."</para>
    ///   <para>"This is the inverse property of "has update official in charge"."</para>
    /// labels<para>"is update official in charge of"</para><para>"è funzionario responsabile di aggiornamento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isUpdateOfficialInChargeOf">https://w3id.org/arco/ontology/catalogue/isUpdateOfficialInChargeOf</seealso>
    let isUpdateOfficialInChargeOf =
        Prefixed_Name(ctlog, "isUpdateOfficialInChargeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isUpdateResponsibleAgentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has update responsible agent","</para>
    ///   <para>"Questa è la proprietà inversa a "ha ente o soggetto responsabile di aggiornamento"."</para>
    /// labels<para>"è ente o soggetto responsabile di aggiornamento di"</para><para>"is update responsible agent of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleAgentOf">https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleAgentOf</seealso>
    let isUpdateResponsibleAgentOf =
        Prefixed_Name(ctlog, "isUpdateResponsibleAgentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isUpdateResponsibleResearchAndCompilationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha responsabile di ricerca e redazione di aggiornamento"."</para>
    ///   <para>"This is the inverse property of "has update responsible research and compilation"."</para>
    /// labels<para>"is update responsible research and compilation of"</para><para>"è responsabile di ricerca e redazione di aggiornamento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleResearchAndCompilationOf">https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleResearchAndCompilationOf</seealso>
    let isUpdateResponsibleResearchAndCompilationOf =
        Prefixed_Name(ctlog, "isUpdateResponsibleResearchAndCompilationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/isUpdateScientificRevisorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha referente verifica scientifica di aggiornamento"."</para>
    ///   <para>"This is the inverse property of "has update scientific revisor"."</para>
    /// labels<para>"is update scientific revisor of"</para><para>"è referente verifica scientifica di aggiornamento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/isUpdateScientificRevisorOf">https://w3id.org/arco/ontology/catalogue/isUpdateScientificRevisorOf</seealso>
    let isUpdateScientificRevisorOf =
        Prefixed_Name(ctlog, "isUpdateScientificRevisorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/localIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta un identificativo che individua un'entità in modo univoco nell'ambito di un repertorio locale. Si specializza in sottoproprietà (es.: identificativo dell'autore nell'ambito di un repertorio locale, identificativo dell'indagine archeologica nell'ambito di un repertorio locale, etc.)"</para>
    ///   <para>"This property represents a unique identifier of an entity, within a local inventory."</para>
    /// labels<para>"identificativo di repertorio locale"</para><para>"local identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/localIdentifier">https://w3id.org/arco/ontology/catalogue/localIdentifier</seealso>
    let localIdentifier = Prefixed_Name(ctlog, "localIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/recoveredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents information extracted from versions of a catalogue record using obsolete standards."</para>
    ///   <para>"Questa proprietà rappresenta eventuali informazioni provenienti da schede pregresse redatte sulla base di standard obsoleti, per le quali non è stato possibile effettuare il trasferimento nel tracciato della scheda aggiornato, secondo la sintassi: “acronimocampo: valore; acronimocampo: valore”"</para>
    /// labels<para>"recovered data"</para><para>"dati pregressi recuperati"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/recoveredData">https://w3id.org/arco/ontology/catalogue/recoveredData</seealso>
    let recoveredData = Prefixed_Name(ctlog, "recoveredData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/referenceProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Questa proprietà rappresenta il progetto nell'ambito del quale è stata prodotta una scheda, quella a cui si associa un codice alternativo, assegnato da enti diversi da ICCD, o quella che analizza un bene culturale per finalità diverse da quella specifica della catalogazione del patrimonio culturale."</para>
    ///   <para>"This property represents the reference project of a record about a cultural property."</para>
    /// labels<para>"reference project"</para><para>"progetto di riferimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/referenceProject">https://w3id.org/arco/ontology/catalogue/referenceProject</seealso>
    let referenceProject = Prefixed_Name(ctlog, "referenceProject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue/systemRecordCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta l'identificativo di sistema che viene associato all'interno del sistema Sigec al file xml contenente una scheda di catalogo."</para>
    ///   <para>"This property represents the identifier associated in the context of the SIGECweb to the xml file containing a catalogue record."</para>
    /// labels<para>"identificativo di sistema"</para><para>"system record code"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue/systemRecordCode">https://w3id.org/arco/ontology/catalogue/systemRecordCode</seealso>
    let systemRecordCode = Prefixed_Name(ctlog, "systemRecordCode") |> PrefixedName
