#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ctlog =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/catalogue/" "ctlog"

    /// <summary>
    ///   <para>rdfs:label : Profilo di accessordfs:label : Access profile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il profilo di accesso ai dati contenuti in una scheda catalografica, con cui si forniscono indicazioni circa la diffusione pubblica dei dati catalografici sul web.rdfs:comment : This class represents the access profile to the data recorded in a catalogue record, giving instructions for public dissemination of data on the web.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AD/ADS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/AccessProfile">ctlog:AccessProfile</a>
    /// </summary>
    let AccessProfile = _prefixId.prefix "AccessProfile"
    /// <summary>
    ///   <para>rdfs:comment : This class represents an additional form, that describes specific information about a cultural property (epigraphic documents, stratigraphy, unit, wall typology)rdfs:comment : Questa classe rappresenta un modulo di approfondimento, utile a trattare secondo un approccio specialistico specifici aspetti del bene in esame (Documenti Epigrafici; Tipi Murari, Unità Stratigrafiche)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Additional formrdfs:label : Modulo di approfondimento</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/APP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/AdditionalForm">ctlog:AdditionalForm</a>
    /// </summary>
    let AdditionalForm = _prefixId.prefix "AdditionalForm"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di modulo di approfondimento (Unità Stratigrafica, Tipo Murario, Epigrafia)rdfs:comment : This class represents the additional form type (Stratigraphic Unit, Wall Typology, Epigraphy)</para>
    ///   <para>rdfs:label : Additional form typerdfs:label : Tipo di modulo di approfondimento</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/APP/APPT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/AdditionalFormType">ctlog:AdditionalFormType</a>
    /// </summary>
    let AdditionalFormType = _prefixId.prefix "AdditionalFormType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/ACC^^xsd:string</para>
    ///   <para>rdfs:label : Codice alternativordfs:label : Alternative Identifier</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un codice che identifica la scheda di catalogo nell'ambito di altri sistemi informativi, assegnato da enti diversi da ICCD.rdfs:comment : This class represents an identifier of a catalogue record in information systems other than ICCD.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/AlternativeIdentifier">ctlog:AlternativeIdentifier</a>
    /// </summary>
    let AlternativeIdentifier = _prefixId.prefix "AlternativeIdentifier"
    let C = _prefixId.prefix "C"
    /// <summary>
    ///   <para>rdfs:label : Scheda di catalogordfs:label : Catalogue record</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Rappresenta una scheda di catalogo, cioè un modello descrittivo che raccoglie in modo organizzato le informazioni sui beni, e che può avere più versioni (in seguito ad aggiornamenti e revisioni).rdfs:comment : This class represents a catalogue record, that is a descriptive model collecting and organising information on a cultural property, and which can have more than one version (after editing and updating).</para>
    ///   <para>dce:description : An example of usage of the class 'Catalogue Record' is the following:
    /// resource:CatalogueRecordS/0500212038
    ///         a           cat:CatalogueRecordS ;
    ///         rdfs:label  "Catalogue record n: 0500212038"@en ;
    ///         cat:catalogueRecordIdentifier "0500212038" ;
    ///         cat:describesCulturalProperty resource:HistoricOrArtisticProperty/0500212038 ;
    ///         cat:hasAccessProfile resource:AccessProfile/0500212038-1 ;
    ///         cat:hasCatalogueRecordVersion resource:CatalogueRecordVersion/0500212038-rvm , resource:CatalogueRecordVersion/0500212038-agg-1 , resource:CatalogueRecordVersion/0500212038-compilation ;
    ///         cat:hasCataloguingLevel
    ///                 cat:C ;
    ///         cat:systemRecordCode "ICCD8403091" ;
    ///         core:note&gt;  "Number of negative by "Museco Civico": MCBas G/ DLXXXIX/ 3775" .dce:description : Un esempio di utilizzo della classe "Scheda di Catalogo" è il seguente:
    /// resource:CatalogueRecordS/0500212038
    ///         a           cat:CatalogueRecordS ;
    ///         rdfs:label  "Scheda catalografica n: 0500212038"@it ;
    ///         cat:catalogueRecordIdentifier "0500212038" ;
    ///         cat:describesCulturalProperty resource:HistoricOrArtisticProperty/0500212038 ;
    ///         cat:hasAccessProfile resource:AccessProfile/0500212038-1 ;
    ///         cat:hasCatalogueRecordVersion resource:CatalogueRecordVersion/0500212038-rvm , resource:CatalogueRecordVersion/0500212038-agg-1 , resource:CatalogueRecordVersion/0500212038-compilation ;
    ///         cat:hasCataloguingLevel
    ///                 cat:C ;
    ///         cat:systemRecordCode "ICCD8403091" ;
    ///         core:note  "Numero di negativo del Museo Civico: MCBas G/ DLXXXIX/ 3775" .</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecord">ctlog:CatalogueRecord</a>
    /// </summary>
    let CatalogueRecord = _prefixId.prefix "CatalogueRecord"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Architecture catalogue recordrdfs:label : Scheda Architettura</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive architettura.rdfs:comment : This class represents the catalogue record describing Architecture.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordA">ctlog:CatalogueRecordA</a>
    /// </summary>
    let CatalogueRecordA = _prefixId.prefix "CatalogueRecordA"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Anthropological materials catalogue recordrdfs:label : Scheda Reperti antropologici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive reperti antropologici.rdfs:comment : This class represents the catalogue record describing Anthropological materials.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordAT">ctlog:CatalogueRecordAT</a>
    /// </summary>
    let CatalogueRecordAT = _prefixId.prefix "CatalogueRecordAT"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Intangible demo-ethno-anthropological heritage catalogue recordrdfs:label : Scheda Beni demoetnoantropologici immateriali</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni demoetnoantropologici immateriali.rdfs:comment : This class represents the catalogue record describing Intangible demo-ethno-anthropological heritage.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDI">ctlog:CatalogueRecordBDI</a>
    /// </summary>
    let CatalogueRecordBDI = _prefixId.prefix "CatalogueRecordBDI"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Scheda Beni demoetnoantropologici materialirdfs:label : Tangible demo-ethno-anthropological heritage catalogue record</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni demoetnoantropologici materiali.rdfs:comment : This class represents the catalogue record describing Tangible demo-ethno-anthropological heritage.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDM">ctlog:CatalogueRecordBDM</a>
    /// </summary>
    let CatalogueRecordBDM = _prefixId.prefix "CatalogueRecordBDM"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Natural heritage - botany catalogue recordrdfs:label : Scheda Beni naturalistici-Botanica</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Botanica.rdfs:comment : This class represents the catalogue record describing Natural heritage - botany.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNB">ctlog:CatalogueRecordBNB</a>
    /// </summary>
    let CatalogueRecordBNB = _prefixId.prefix "CatalogueRecordBNB"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Natural heritage - mineralogy catalogue recordrdfs:label : Scheda Beni naturalistici-Mineralogia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Mineralogia.rdfs:comment : This class represents the catalogue record describing Natural heritage - mineralogy.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNM">ctlog:CatalogueRecordBNM</a>
    /// </summary>
    let CatalogueRecordBNM = _prefixId.prefix "CatalogueRecordBNM"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Natural heritage - paleontology catalogue recordrdfs:label : Scheda Beni naturalistici-Paleontologia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Paleontologia.rdfs:comment : This class represents the catalogue record describing Natural heritage - paleontology.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNP">ctlog:CatalogueRecordBNP</a>
    /// </summary>
    let CatalogueRecordBNP = _prefixId.prefix "CatalogueRecordBNP"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Natural heritage - petrology catalogue recordrdfs:label : Scheda Beni naturalistici-Petrologia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Petrologia.rdfs:comment : This class represents the catalogue record describing Natural heritage - petrology.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPE">ctlog:CatalogueRecordBNPE</a>
    /// </summary>
    let CatalogueRecordBNPE = _prefixId.prefix "CatalogueRecordBNPE"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Natural heritage - planetary science catalogue recordrdfs:label : Scheda Beni naturalistici-Planetologia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Planetologia.rdfs:comment : This class represents the catalogue record describing Natural heritage - planetary science.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPL">ctlog:CatalogueRecordBNPL</a>
    /// </summary>
    let CatalogueRecordBNPL = _prefixId.prefix "CatalogueRecordBNPL"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Natural heritage - zoology catalogue recordrdfs:label : Scheda Beni naturalistici-Zoologia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni naturalistici-Zoologia.rdfs:comment : This class represents the catalogue record describing Natural heritage - zoology.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNZ">ctlog:CatalogueRecordBNZ</a>
    /// </summary>
    let CatalogueRecordBNZ = _prefixId.prefix "CatalogueRecordBNZ"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Archaeological complexes catalogue recordrdfs:label : Scheda Complessi archeologici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive complessi archeologici.rdfs:comment : This class represents the catalogue record describing Natural heritage - archaeological complexes.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCA">ctlog:CatalogueRecordCA</a>
    /// </summary>
    let CatalogueRecordCA = _prefixId.prefix "CatalogueRecordCA"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Historic cities / town centres catalogue recordrdfs:label : Scheda Centri/nuclei storici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive centri/nuclei storici.rdfs:comment : This class represents the catalogue record describing Natural heritage - historic cities / town centres.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCNS">ctlog:CatalogueRecordCNS</a>
    /// </summary>
    let CatalogueRecordCNS = _prefixId.prefix "CatalogueRecordCNS"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Drawings catalogue recordrdfs:label : Scheda Disegni</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive disegni.rdfs:comment : This class represents the catalogue record describing Natural heritage - drawings.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordD">ctlog:CatalogueRecordD</a>
    /// </summary>
    let CatalogueRecordD = _prefixId.prefix "CatalogueRecordD"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Ethnology catalogue recordrdfs:label : Scheda Etnologia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive etnologia. Nell'ambito delle normative ICCD, è una scheda considerata obsoleta.rdfs:comment : This class represents the catalogue record describing Ethnology.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordE">ctlog:CatalogueRecordE</a>
    /// </summary>
    let CatalogueRecordE = _prefixId.prefix "CatalogueRecordE"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Photograph catalogue recordrdfs:label : Scheda Fotografia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive fotografia.rdfs:comment : This class represents the catalogue record describing Photography.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordF">ctlog:CatalogueRecordF</a>
    /// </summary>
    let CatalogueRecordF = _prefixId.prefix "CatalogueRecordF"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Photographic Fonds catalogue recordrdfs:label : Scheda Fondi fotografici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive fondi fotografici.rdfs:comment : This class represents the catalogue record describing Photographic Fonds.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordFF">ctlog:CatalogueRecordFF</a>
    /// </summary>
    let CatalogueRecordFF = _prefixId.prefix "CatalogueRecordFF"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Archaeological monuments catalogue recordrdfs:label : Scheda Monumenti archeologici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive monumenti archeologici.rdfs:comment : This class represents the catalogue record describing Archaeological monuments.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMA">ctlog:CatalogueRecordMA</a>
    /// </summary>
    let CatalogueRecordMA = _prefixId.prefix "CatalogueRecordMA"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Printing plates catalogue recordrdfs:label : Scheda Matrici incise</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive matrici incise.rdfs:comment : This class represents the catalogue record describing Printing plates.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMI">ctlog:CatalogueRecordMI</a>
    /// </summary>
    let CatalogueRecordMI = _prefixId.prefix "CatalogueRecordMI"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Numismatic properties catalogue recordrdfs:label : Scheda Beni numismatici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive beni numismatici.rdfs:comment : This class represents the catalogue record describing Numismatic properties.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordNU">ctlog:CatalogueRecordNU</a>
    /// </summary>
    let CatalogueRecordNU = _prefixId.prefix "CatalogueRecordNU"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Artworks catalogue recordrdfs:label : Scheda Opere/oggetti d'arte</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive opere/oggetti d'arte.rdfs:comment : This class represents the catalogue record describing Artworks.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOA">ctlog:CatalogueRecordOA</a>
    /// </summary>
    let CatalogueRecordOA = _prefixId.prefix "CatalogueRecordOA"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Contemporary artworks catalogue recordrdfs:label : Scheda opere/oggetti d'arte contemporanea</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive opere/oggetti d'arte contemporanea.rdfs:comment : This class represents the catalogue record describing Contemporary artworks.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOAC">ctlog:CatalogueRecordOAC</a>
    /// </summary>
    let CatalogueRecordOAC = _prefixId.prefix "CatalogueRecordOAC"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Parks/Gardens catalogue recordrdfs:label : Scheda Parchi/giardini</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive parchi/giardini.rdfs:comment : This class represents the catalogue record describing Parks / Gardens.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPG">ctlog:CatalogueRecordPG</a>
    /// </summary>
    let CatalogueRecordPG = _prefixId.prefix "CatalogueRecordPG"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Scheda Patrimonio scientifico e tecnologicordfs:label : Scientific and technological heritage catalogue record</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive il patrimonio scientifico e tecnologico.rdfs:comment : This class represents the catalogue record describing Scientific and technological heritage.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPST">ctlog:CatalogueRecordPST</a>
    /// </summary>
    let CatalogueRecordPST = _prefixId.prefix "CatalogueRecordPST"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Archaeological objects catalogue recordrdfs:label : Scheda Reperti archeologici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive reperti archeologici.rdfs:comment : This class represents the catalogue record describing Archaeological objects.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordRA">ctlog:CatalogueRecordRA</a>
    /// </summary>
    let CatalogueRecordRA = _prefixId.prefix "CatalogueRecordRA"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Prints catalogue recordrdfs:label : Scheda Stampe</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive stampe.rdfs:comment : This class represents the catalogue record describing Prints.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordS">ctlog:CatalogueRecordS</a>
    /// </summary>
    let CatalogueRecordS = _prefixId.prefix "CatalogueRecordS"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Scheda Saggi stratigraficirdfs:label : Stratigraphic records catalogue record</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive saggi stratigrafici.rdfs:comment : This class represents the catalogue record describing Stratigraphic records.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSAS">ctlog:CatalogueRecordSAS</a>
    /// </summary>
    let CatalogueRecordSAS = _prefixId.prefix "CatalogueRecordSAS"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Archaeological sites catalogue recordrdfs:label : Scheda Siti archeologici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive siti archeologici.rdfs:comment : This class represents the catalogue record describing Archaeological sites.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSI">ctlog:CatalogueRecordSI</a>
    /// </summary>
    let CatalogueRecordSI = _prefixId.prefix "CatalogueRecordSI"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Musical instruments catalogue recordrdfs:label : Scheda Strumenti musicali</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive strumenti musicali.rdfs:comment : This class represents the catalogue record describing Musical instruments.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSM">ctlog:CatalogueRecordSM</a>
    /// </summary>
    let CatalogueRecordSM = _prefixId.prefix "CatalogueRecordSM"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Musical instruments - Organs catalogue recordrdfs:label : Scheda Strumenti musicali-Organo</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive strumenti musicali-organo.rdfs:comment : This class represents the catalogue record describing Organs.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSMO">ctlog:CatalogueRecordSMO</a>
    /// </summary>
    let CatalogueRecordSMO = _prefixId.prefix "CatalogueRecordSMO"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Archaeological materials tables catalogue recordrdfs:label : Scheda Tabella materiali archeologici</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive tabella materiali archeologici.rdfs:comment : This class represents the catalogue record describing Archaeological materials tables.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordTMA">ctlog:CatalogueRecordTMA</a>
    /// </summary>
    let CatalogueRecordTMA = _prefixId.prefix "CatalogueRecordTMA"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Historic and contemporary garments catalogue recordrdfs:label : Scheda Vestimenti antichi/contemporanei</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la scheda catalografica che descrive vestimenti antichi/contemporanei.rdfs:comment : This class represents the catalogue record describing Historic and contemporary garments.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVeAC">ctlog:CatalogueRecordVeAC</a>
    /// </summary>
    let CatalogueRecordVeAC = _prefixId.prefix "CatalogueRecordVeAC"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : CM/CMP; CM/RVM; CM/AGG^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Versione della schedardfs:label : Catalogue record version</para>
    ///   <para>rdfs:comment : This class represents a version (after creation, editing, updating) of a catalogue record on a cultural property.rdfs:comment : Rappresenta una versione (relativa a operazioni di redazione, aggiornamento, revisione) di una scheda di catalogo, cioè un modello descrittivo che raccoglie in modo organizzato le informazioni sui beni.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVersion">ctlog:CatalogueRecordVersion</a>
    /// </summary>
    let CatalogueRecordVersion = _prefixId.prefix "CatalogueRecordVersion"
    /// <summary>
    ///   <para>rdfs:label : Livello catalogazionerdfs:label : Cataloguing level</para>
    ///   <para>ctlog:iccdNormTag : CD/LIR^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il livello catalogazione, cioè la sigla che individua il grado di approfondimento dell'indagine condotta sul bene in esame (I corrisponde al livello di inventario, P al livello di precatalogo, C al livello di catalogo)rdfs:comment : This class represents the cataloguing level, defining the level of detail of the survey carried out on the cultural property (Minimum, Medium, Detailed)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CataloguingLevel">ctlog:CataloguingLevel</a>
    /// </summary>
    let CataloguingLevel = _prefixId.prefix "CataloguingLevel"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Complex cultural property catalogue recordrdfs:label : Scheda catalografica su bene culturale complesso</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una scheda catalografica che descrive un bene culturale complesso, a prescindere dal trattamento catalografico applicato (scheda unica/scheda d'insieme).rdfs:comment : This class represents a catalogue record describing a complex cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/ComplexCPCatalogueRecord">ctlog:ComplexCPCatalogueRecord</a>
    /// </summary>
    let ComplexCPCatalogueRecord = _prefixId.prefix "ComplexCPCatalogueRecord"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a record describing a cultural property for purposes other than cataloguing cultural heritage.rdfs:comment : Questa classe rappresenta una scheda che analizza il bene in esame per finalità diverse da quella specifica della catalogazione del patrimonio culturale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/ACS^^xsd:string</para>
    ///   <para>rdfs:label : Scheda su bene culturalerdfs:label : Catalogue property record</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/CulturalPropertyRecord">ctlog:CulturalPropertyRecord</a>
    /// </summary>
    let CulturalPropertyRecord = _prefixId.prefix "CulturalPropertyRecord"
    let EpigraphyForm = _prefixId.prefix "EpigraphyForm"
    let I = _prefixId.prefix "I"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta un codice assegnato a un'entità dall'ICCD. Si specializza in sottoproprietà (es.: codice univoco ICCD dell'autore, codice univoco ICCD del riferimento bibliografico, etc.)rdfs:comment : This property represents the identifier assigned to a cultural property by ICCD.</para>
    ///   <para>rdfs:label : ICCD identifierrdfs:label : codice univoco ICCD</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/ICCDIdentifier">ctlog:ICCDIdentifier</a>
    /// </summary>
    let ICCDIdentifier = _prefixId.prefix "ICCDIdentifier"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasvesale 4.00: AC/MOD^^xsd:string</para>
    ///   <para>rdfs:label : Modulo informativordfs:label : Information form</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un modulo informativo, uno standard ICCD per attività di censimento e segnalazione di beni culturali, utilizzato per acquisire informazioni per qualsiasi tipo di entità, con un set minimo di dati standardizzati obbligatori.rdfs:comment : This class represents an information form, an ICCD standard for cultural heritage census and reporting activities, used to acquire information for any type of entity, with a minimum set of mandatory standardized data.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/InformationForm">ctlog:InformationForm</a>
    /// </summary>
    let InformationForm = _prefixId.prefix "InformationForm"
    let MaximumPrivacy = _prefixId.prefix "MaximumPrivacy"
    let MediumPrivacy = _prefixId.prefix "MediumPrivacy"
    let MinimumPrivacy = _prefixId.prefix "MinimumPrivacy"
    let P = _prefixId.prefix "P"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AD/ADS/ADSP^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il livello di riservatezza dei dati contenuti in una scheda catalografica (1 livello basso di riservatezza, 2 livello medio di riservatezza, 3 livello alto di riservatezza)rdfs:comment : This class represents the privacy level of the data recorded in a catalogue record (Minimum, Medium, Maximum).</para>
    ///   <para>rdfs:label : Livello di riservatezzardfs:label : Privacy level</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/PrivacyLevel">ctlog:PrivacyLevel</a>
    /// </summary>
    let PrivacyLevel = _prefixId.prefix "PrivacyLevel"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta la motivazione che ha determinato l'adozione di un profilo di accesso relativamente ai dati contenuti in una scheda catalografica.rdfs:comment : This class represents the reason for the adoption of a specific access profile for a catalogue record.</para>
    ///   <para>rdfs:label : Motivo di riservatezzardfs:label : Privacy reason</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AD/ADS/ADSM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/PrivacyReason">ctlog:PrivacyReason</a>
    /// </summary>
    let PrivacyReason = _prefixId.prefix "PrivacyReason"
    let StratigraphicUnitForm = _prefixId.prefix "StratigraphicUnitForm"
    let WallTypologyForm = _prefixId.prefix "WallTypologyForm"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the additional form identifier.rdfs:comment : Questa proprietà permette di associare un identificativo a un modulo di approfondimento.</para>
    ///   <para>rdfs:label : identificativo del modulo di approfondimentordfs:label : additional form identifier</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/APP/APPC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/additionalFormIdentifier">ctlog:additionalFormIdentifier</a>
    /// </summary>
    let additionalFormIdentifier = _prefixId.prefix "additionalFormIdentifier"
    /// <summary>
    ///   <para>rdfs:label : catalogue record identifierrdfs:label : identificativo della scheda di catalogo</para>
    ///   <para>ctlog:iccdNormTag : Concatenazione dei sottocampi di CD/NCT (NCTR, NCTN, NCTS) e RV/RVE/RVEL</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare l'identificativo a una scheda catalografica che descrive un bene culturale.rdfs:comment : This property represents the identifier of a catalogue record describing a cultural property.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/catalogueRecordIdentifier">ctlog:catalogueRecordIdentifier</a>
    /// </summary>
    let catalogueRecordIdentifier = _prefixId.prefix "catalogueRecordIdentifier"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/ACS/ACSC^^xsd:string</para>
    ///   <para>rdfs:label : identificativo di scheda su bene culturalerdfs:label : cultural property record identifier</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare l'identificativo a una scheda in cui si analizza un bene culturale per finalità diverse da quella specificazione della catalogazione del patrimonio culturale.rdfs:comment : This property is used to associate the identifier to a catalogue record that analyze the cultural property for reasons other than cataloguing the cultural heritage.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/culturalPropertyRecordIdentifier">ctlog:culturalPropertyRecordIdentifier</a>
    /// </summary>
    let culturalPropertyRecordIdentifier =
        _prefixId.prefix "culturalPropertyRecordIdentifier"

    /// <summary>
    ///   <para>rdfs:comment : This property represents the ICCD's identifier deleted for many reasons, used to search for obsolete catalogue records.rdfs:comment : Questa proprietà rappresenta un codice ICCD eventualmente soppresso per motivi di diversa natura, utile per poter ricercare e consultare le schede pregresse nell'Archivio storico gestito dall'Istituto o da altri Enti.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : codice ICCD soppressordfs:label : deleted ICCD identifier</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSP; versioni precedenti: RV/RVE/RVES</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/deletedICCDIdentifier">ctlog:deletedICCDIdentifier</a>
    /// </summary>
    let deletedICCDIdentifier = _prefixId.prefix "deletedICCDIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : This property was created as a generic property for specific subproperties, and represents the relationship between an entity that describes another entity.rdfs:comment : Questa proprietà è stata creata come proprietà generica di sottoproprietà specifiche, e rappresenta la relazione tra un'entità che descrive un'altra entità.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : describesrdfs:label : descrive</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/describes">ctlog:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : describesrdfs:label : descrive</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare la scheda di catalogo al bene culturale che essa descrive.rdfs:comment : Property used to associate the catalogue record with the cultural property that the catalogue record describes.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/describesCulturalProperty">ctlog:describesCulturalProperty</a>
    /// </summary>
    let describesCulturalProperty = _prefixId.prefix "describesCulturalProperty"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : compilato al tempordfs:label : edited at time</para>
    ///   <para>rdfs:comment : Property used to associate a catalogue record version with the time interval in which it was edited.rdfs:comment : Proprietà che associa una versione di una scheda di catalogo all'intervallo temporale in cui è stata compilata.</para>
    ///   <para>ctlog:iccdNormTag : CM/CMP/CMPD; CM/RVM/RVMD; CM/AGG/AGGD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/editedAtTime">ctlog:editedAtTime</a>
    /// </summary>
    let editedAtTime = _prefixId.prefix "editedAtTime"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "compilato al tempo".rdfs:comment : This is the inverse property of "edited at time".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : editing time ofrdfs:label : tempo di compilazione di</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/editingTimeOf">ctlog:editingTimeOf</a>
    /// </summary>
    let editingTimeOf = _prefixId.prefix "editingTimeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega una scheda di catalogo al profilo di accesso ai dati (basso, medio, alto).</para>
    ///   <para>rdfs:label : has access profilerdfs:label : ha profilo di accesso</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AD/ADS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasAccessProfile">ctlog:hasAccessProfile</a>
    /// </summary>
    let hasAccessProfile = _prefixId.prefix "hasAccessProfile"

    /// <summary>
    ///   <para>rdfs:label : ha responsabile di modulo di approfondimentordfs:label : has additional form responsible agent</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/APP/APPE^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega un modulo di approfondimento all'ente/il soggetto responsabile nel SIGECweb della redazione del modulo.rdfs:comment : This property relates an additional form to the responsible agent of that form in the SIGECweb.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormResponsibleAgent">ctlog:hasAdditionalFormResponsibleAgent</a>
    /// </summary>
    let hasAdditionalFormResponsibleAgent =
        _prefixId.prefix "hasAdditionalFormResponsibleAgent"

    /// <summary>
    ///   <para>rdfs:label : has additional form typerdfs:label : ha tipo di modulo di approfondimento</para>
    ///   <para>rdfs:comment : This property relates an additional form to its type (Stratigraphic Unit, Epigraphy, Wall Typology).rdfs:comment : Questa proprietà collega un modulo di approfondimento al tipo di modulo (Unità Stratigrafica, Tipo Murario, Epigrafia).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/APP/APPT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormType">ctlog:hasAdditionalFormType</a>
    /// </summary>
    let hasAdditionalFormType = _prefixId.prefix "hasAdditionalFormType"
    /// <summary>
    ///   <para>rdfs:label : ha altro codice identificativordfs:label : has alternative identifier</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Property used to associate a catalogue record with an identifier created in the context of information systems other than ICCD's SIGECweb.rdfs:comment : Questa proprietà collega una scheda di catalogo a un codice che identifica la scheda di catalogo nell'ambito di altri sistemi informativi, assegnato da enti diversi da ICCD.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/ACC</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasAlternativeIdentifier">ctlog:hasAlternativeIdentifier</a>
    /// </summary>
    let hasAlternativeIdentifier = _prefixId.prefix "hasAlternativeIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha versionerdfs:label : has version</para>
    ///   <para>rdfs:comment : Proprietà che permette di collegare una scheda di catalogo, intesa come oggetto informativo che descrive un bene culturale, a una sua versione (corrispondente a un particolare stato dovuto a operazioni di redazione, aggiornamento, revisione).rdfs:comment : Property used to associate a catalogue record to one of its versions (e.g. after update)</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersion">ctlog:hasCatalogueRecordVersion</a>
    /// </summary>
    let hasCatalogueRecordVersion = _prefixId.prefix "hasCatalogueRecordVersion"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare una particolare versione di una scheda al ruolo nel tempo che un agente esercita nell'ambito della redazione, dell'aggiornamento o revisione della scheda.rdfs:comment : This property is used to associate a particular version of a catalogue record to the role in time of an agent that plays a role in updating the catalogue record.</para>
    ///   <para>rdfs:label : has role in timerdfs:label : ha ruolo nel tempo</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersionRiT">ctlog:hasCatalogueRecordVersionRiT</a>
    /// </summary>
    let hasCatalogueRecordVersionRiT = _prefixId.prefix "hasCatalogueRecordVersionRiT"
    /// <summary>
    ///   <para>rdfs:label : has cataloguing agentrdfs:label : ha agente coinvolto nella catalogazione</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property is used to associate a catalogue record to an agent playing a role in cataloguing activities.rdfs:comment : Questa proprietà rappresenta la relazione che collega una versione di una scheda di catalogo a un agente che riveste un ruolo nelle attività di catalogazione di quella scheda. La relazione tra il ruolo e l'agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Questa relazione è poi specializzata da sottoproprietà. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l’ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasCataloguingAgent">ctlog:hasCataloguingAgent</a>
    /// </summary>
    let hasCataloguingAgent = _prefixId.prefix "hasCataloguingAgent"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : CD/LIR^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare una scheda di catalogo al suo livello di catalogazione.</para>
    ///   <para>rdfs:label : has cataloguing levelrdfs:label : ha livello di catalogazione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasCataloguingLevel">ctlog:hasCataloguingLevel</a>
    /// </summary>
    let hasCataloguingLevel = _prefixId.prefix "hasCataloguingLevel"

    /// <summary>
    ///   <para>rdfs:label : ha agente responsabile della scheda su bene culturalerdfs:label : has cultural property record responsible agent</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/ACS/ACSE^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega una scheda in cui si analizza un bene culturale per finalità diverse da quella della catalogazione del patrimonio all'Ente o al soggetto che ha prodotto la scheda o che gestisce la banca dati di cui la scheda fa parte.rdfs:comment : This property relates a cultural property record to the agency or the person that created that record or manages the database where the record is.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasCulturalPropertyRecordResponsibleAgent">ctlog:hasCulturalPropertyRecordResponsibleAgent</a>
    /// </summary>
    let hasCulturalPropertyRecordResponsibleAgent =
        _prefixId.prefix "hasCulturalPropertyRecordResponsibleAgent"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : CM/RVM/RVMN^^xsd:string</para>
    ///   <para>rdfs:label : has digital transcription operatorrdfs:label : ha operatore di trascrizione per informatizzazione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega una versione, relativa a trascrizione per informatizzazione, di una scheda di catalogo al relativo operatore. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionOperator">ctlog:hasDigitalTranscriptionOperator</a>
    /// </summary>
    let hasDigitalTranscriptionOperator =
        _prefixId.prefix "hasDigitalTranscriptionOperator"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : CM/RVM/RVME^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega una versione, relativa a trascrizione per informatizzazione, di una scheda di catalogo al relativo ente/soggetto responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>rdfs:label : has digital transcription responsible agentrdfs:label : ha ente o soggetto responsabile di trascrizione per informatizzazione</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionResponsibleAgent">ctlog:hasDigitalTranscriptionResponsibleAgent</a>
    /// </summary>
    let hasDigitalTranscriptionResponsibleAgent =
        _prefixId.prefix "hasDigitalTranscriptionResponsibleAgent"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Property used to associate a catalogue record version to its immediate previous version.rdfs:comment : Questa proprietà associa una versione di una scheda alla sua versione immediatamente precedente.</para>
    ///   <para>rdfs:label : ha la versione precedenterdfs:label : has immediate previous version</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasImmediatePreviousVersion">ctlog:hasImmediatePreviousVersion</a>
    /// </summary>
    let hasImmediatePreviousVersion = _prefixId.prefix "hasImmediatePreviousVersion"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has official in chargerdfs:label : ha funzionario responsabile</para>
    ///   <para>ctlog:iccdNormTag : CM/FUR^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega la prima versione di una scheda di catalogo al relativo funzionario responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasOfficialInCharge">ctlog:hasOfficialInCharge</a>
    /// </summary>
    let hasOfficialInCharge = _prefixId.prefix "hasOfficialInCharge"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà associa una versione di una scheda a una sua versione precedente.rdfs:comment : Property used to associate a catalogue record version to its previous version.</para>
    ///   <para>rdfs:label : has previous versionrdfs:label : ha versione precedente</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasPreviousVersion">ctlog:hasPreviousVersion</a>
    /// </summary>
    let hasPreviousVersion = _prefixId.prefix "hasPreviousVersion"
    /// <summary>
    ///   <para>rdfs:label : ha livello di riservatezzardfs:label : has privacy level</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AD/ADS^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega il profilo di accesso di una scheda catalografica al livello di riservatezza dei dati contenutevi (basso livello di riservatezza, alto livello di riservatezza, medio livello di riservatezza).</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasPrivacyLevel">ctlog:hasPrivacyLevel</a>
    /// </summary>
    let hasPrivacyLevel = _prefixId.prefix "hasPrivacyLevel"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno specifico profilo d'accesso ai dati di una scheda catalografica alla motivazione che ha determinato l'adozione di quel profilo d'accesso (es.: scheda contenente dati liberamente accessibili, scheda contenente dati personali, scheda di bene di proprietà privata, scheda di bene a rischio, scheda di bene non adeguatamente sorvegliabile)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AD/ADS/ADSM^^xsd:string</para>
    ///   <para>rdfs:label : has privacy reasonrdfs:label : ha motivazione di riservatezza</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasPrivacyReason">ctlog:hasPrivacyReason</a>
    /// </summary>
    let hasPrivacyReason = _prefixId.prefix "hasPrivacyReason"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : CM/CMP/CMPN^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega la prima versione di una scheda di catalogo al relativo responsabile ricerca e redazione. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>rdfs:label : ha responsabile ricerca e redazionerdfs:label : has responsible research and compilation</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasResponsibleResearchAndCompilation">ctlog:hasResponsibleResearchAndCompilation</a>
    /// </summary>
    let hasResponsibleResearchAndCompilation =
        _prefixId.prefix "hasResponsibleResearchAndCompilation"

    /// <summary>
    ///   <para>rdfs:label : has scientific directorrdfs:label : ha referente verifica scientifica</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega la prima versione di una scheda di catalogo al relativo referente verifica scientifica. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : CM/RSR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasScientificDirector">ctlog:hasScientificDirector</a>
    /// </summary>
    let hasScientificDirector = _prefixId.prefix "hasScientificDirector"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : CM/AGG/AGGF^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo funzionario responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>rdfs:label : has update official in chargerdfs:label : ha funzionario responsabile di aggiornamento</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasUpdateOfficialInCharge">ctlog:hasUpdateOfficialInCharge</a>
    /// </summary>
    let hasUpdateOfficialInCharge = _prefixId.prefix "hasUpdateOfficialInCharge"
    /// <summary>
    ///   <para>rdfs:label : has update responsible agency or personrdfs:label : ha ente o soggetto responsabile di aggiornamento</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo ente/soggetto responsabile. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>ctlog:iccdNormTag : CM/AGG/AGGE^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleAgent">ctlog:hasUpdateResponsibleAgent</a>
    /// </summary>
    let hasUpdateResponsibleAgent = _prefixId.prefix "hasUpdateResponsibleAgent"

    /// <summary>
    ///   <para>rdfs:label : ha responsabile di ricerca e redazione di aggiornamentordfs:label : has update responsible research and compilation</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo responsabile ricerca e redazione. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>ctlog:iccdNormTag : CM/AGG/AGGN^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleResearchAndCompilation">ctlog:hasUpdateResponsibleResearchAndCompilation</a>
    /// </summary>
    let hasUpdateResponsibleResearchAndCompilation =
        _prefixId.prefix "hasUpdateResponsibleResearchAndCompilation"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega una versione aggiornata di una scheda di catalogo al relativo referente verifica scientifica. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>rdfs:label : ha referente verifica scientifica di aggiornamentordfs:label : has update scientific revisor</para>
    ///   <para>ctlog:iccdNormTag : CM/AGG/AGGR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/hasUpdateScientificRevisor">ctlog:hasUpdateScientificRevisor</a>
    /// </summary>
    let hasUpdateScientificRevisor = _prefixId.prefix "hasUpdateScientificRevisor"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ICCD norm tagrdfs:label : acronimo normativa ICCD</para>
    ///   <para>rdfs:comment : Questa proprietà permette di annotare il campo o i campi della normativa ICCD corrispondenti a una determinata classe o proprietà dell'ontologia.rdfs:comment : This property annotates the field or the fields of the ICCD regulation to which a specific class or property refers.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/iccdNormTag">ctlog:iccdNormTag</a>
    /// </summary>
    let iccdNormTag = _prefixId.prefix "iccdNormTag"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : information form identifierrdfs:label : identificativo del modulo informativo</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/MOD/MODI^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare l'identificativo a un modulo informativo che è collegato a un bene culturale.rdfs:comment : This property links an identifier to an information form related to a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/informationFormIdentifier">ctlog:informationFormIdentifier</a>
    /// </summary>
    let informationFormIdentifier = _prefixId.prefix "informationFormIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha profilo di accesso".rdfs:comment : This is the inverse property of "has access profile".</para>
    ///   <para>rdfs:label : è profilo di accesso dirdfs:label : is access profile of</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isAccessProfileOf">ctlog:isAccessProfileOf</a>
    /// </summary>
    let isAccessProfileOf = _prefixId.prefix "isAccessProfileOf"

    /// <summary>
    ///   <para>rdfs:label : è responsabile di modulo di approfondimentordfs:label : is additional form responsible agent of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha responsabile di modulo di approfondimento".rdfs:comment : This is the inverse property of "has additional form responsible agent"</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormResponsibleAgentOf">ctlog:isAdditionalFormResponsibleAgentOf</a>
    /// </summary>
    let isAdditionalFormResponsibleAgentOf =
        _prefixId.prefix "isAdditionalFormResponsibleAgentOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tipo di modulo di approfondimento".rdfs:comment : This is the inverse property of "has additional form type".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is additional form type ofrdfs:label : è tipo di modulo di approfondimento di</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormTypeOf">ctlog:isAdditionalFormTypeOf</a>
    /// </summary>
    let isAdditionalFormTypeOf = _prefixId.prefix "isAdditionalFormTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has alternative identifier".rdfs:comment : Questa è la proprietà inversa di "ha altro codice identificativo".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is alternative identifier ofrdfs:label : è altro codice identificativo di</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isAlternativeIdentifierOf">ctlog:isAlternativeIdentifierOf</a>
    /// </summary>
    let isAlternativeIdentifierOf = _prefixId.prefix "isAlternativeIdentifierOf"
    /// <summary>
    ///   <para>rdfs:comment : Property, inverse of "has catalogue record version", used to associate a catalogue record version (e.g. after update) to the catalogue record.rdfs:comment : Proprietà, inversa di "ha versione", che permette di collegare una versione  (corrispondente a un particolare stato dovuto a operazioni di redazione, aggiornamento, revisione) di una scheda di catalogo alla scheda di catalogo intesa come oggetto informativo che descrive un bene culturale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è versione dirdfs:label : is catalogue record version of</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionOf">ctlog:isCatalogueRecordVersionOf</a>
    /// </summary>
    let isCatalogueRecordVersionOf = _prefixId.prefix "isCatalogueRecordVersionOf"
    /// <summary>
    ///   <para>rdfs:comment : Property, inverse of "has catalogue record version role in time", used to associate a role in time to the agent playing that role, in the updating of a particular version of a catalogue record.rdfs:comment : Questa proprietà, inversa a "ha ruolo nel tempo", permette di associare il ruolo nel tempo che un agente esercita nell'ambito della redazione, dell'aggiornamento o revisione della scheda a una particolare versione di una scheda.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è ruolo nel tempo dirdfs:label : is role in time of</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionRiTOf">ctlog:isCatalogueRecordVersionRiTOf</a>
    /// </summary>
    let isCatalogueRecordVersionRiTOf = _prefixId.prefix "isCatalogueRecordVersionRiTOf"
    /// <summary>
    ///   <para>rdfs:label : è agente coinvolto nella catalogazione dirdfs:label : is cataloguing agent of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property, inverse of "has cataloguin agent", is used to associate an agent playing a role in cataloguing activities to the catalogue record.rdfs:comment : Questa proprietà, inversa a "ha agente coinvolto nella catalogazione", rappresenta la relazione che collega un agente che riveste un ruolo nelle attività di catalogazione di una scheda di catalogo alla scheda stessa.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isCataloguingAgentOf">ctlog:isCataloguingAgentOf</a>
    /// </summary>
    let isCataloguingAgentOf = _prefixId.prefix "isCataloguingAgentOf"
    /// <summary>
    ///   <para>rdfs:label : è livello di catalogazione dirdfs:label : is cataloguing level of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha livello di catalogazione".rdfs:comment : This is the inverse property of "has cataloguing level".</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isCataloguingLevelOf">ctlog:isCataloguingLevelOf</a>
    /// </summary>
    let isCataloguingLevelOf = _prefixId.prefix "isCataloguingLevelOf"
    /// <summary>
    ///   <para>rdfs:comment : This property, inverse property of "describes", was created as a generic property for specific subproperties, and represents the relationship between an entity described by another entity.rdfs:comment : Questa proprietà, inversa della proprietà "descrive", è stata creata come proprietà generica di sottoproprietà specifiche, e rappresenta la relazione tra un'entità descritta da un'altra entità.</para>
    ///   <para>rdfs:label : is described byrdfs:label : è descritto da</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isDescribedBy">ctlog:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa di "descrive", permette di associare un bene culturale alla scheda di catalogo che lo descrive.rdfs:comment : This property, inverse of "describes", is used to associate a cultural property with the catalogue record that describes it.</para>
    ///   <para>rdfs:label : è descritto dardfs:label : is described by</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isDescribedByCatalogueRecord">ctlog:isDescribedByCatalogueRecord</a>
    /// </summary>
    let isDescribedByCatalogueRecord = _prefixId.prefix "isDescribedByCatalogueRecord"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha operatore di trascrizione per informatizzazione".rdfs:comment : This is the inverse property of "has digital transcription operator".</para>
    ///   <para>rdfs:label : is digital transcription operator ofrdfs:label : è operatore di trascrizione per informatizzazione di</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionOperatorOf">ctlog:isDigitalTranscriptionOperatorOf</a>
    /// </summary>
    let isDigitalTranscriptionOperatorOf =
        _prefixId.prefix "isDigitalTranscriptionOperatorOf"

    /// <summary>
    ///   <para>rdfs:label : è ente o soggetto responsabile di trascrizione per informatizzazione dirdfs:label : is digital transcription responsible agent of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has digital transcription responsible agent".rdfs:comment : Questa è la proprietà inversa a "ha ente o soggetto responsabile di trascrizione per informatizzazione".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionResponsibleAgentOf">ctlog:isDigitalTranscriptionResponsibleAgentOf</a>
    /// </summary>
    let isDigitalTranscriptionResponsibleAgentOf =
        _prefixId.prefix "isDigitalTranscriptionResponsibleAgentOf"

    /// <summary>
    ///   <para>rdfs:comment : Property used to associate a catalogue record version to its immediate next version.rdfs:comment : Questa proprietà associa una versione di una scheda alla sua versione immediatamente successiva.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è la versione precedente dirdfs:label : is immediate previous version of</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isImmediatePreviousVersionOf">ctlog:isImmediatePreviousVersionOf</a>
    /// </summary>
    let isImmediatePreviousVersionOf = _prefixId.prefix "isImmediatePreviousVersionOf"
    /// <summary>
    ///   <para>rdfs:label : è funzionario responsabile dirdfs:label : is official in charge of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has official in charge".rdfs:comment : Questa è la proprietà inversa a "ha funzionario responsabile".</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isOfficialInChargeOf">ctlog:isOfficialInChargeOf</a>
    /// </summary>
    let isOfficialInChargeOf = _prefixId.prefix "isOfficialInChargeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà associa una versione di una scheda a una sua versione successiva.rdfs:comment : Property used to associate a catalogue record version one of its next version.</para>
    ///   <para>rdfs:label : è versione precedente dirdfs:label : is previous version of</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isPreviousVersionOf">ctlog:isPreviousVersionOf</a>
    /// </summary>
    let isPreviousVersionOf = _prefixId.prefix "isPreviousVersionOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has privacy level".rdfs:comment : Questa è la proprietà inversa di "ha livello di riservatezza".</para>
    ///   <para>rdfs:label : è livello di riservatezza dirdfs:label : is privacy level of</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isPrivacyLevelOf">ctlog:isPrivacyLevelOf</a>
    /// </summary>
    let isPrivacyLevelOf = _prefixId.prefix "isPrivacyLevelOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è motivazione di riservatezza dirdfs:label : is privacy reason of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has privacy reason".rdfs:comment : Questa è la proprietà inversa di "ha motivazione di riservatezza".</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isPrivacyReasonOf">ctlog:isPrivacyReasonOf</a>
    /// </summary>
    let isPrivacyReasonOf = _prefixId.prefix "isPrivacyReasonOf"
    /// <summary>
    ///   <para>rdfs:label : è collegato a modulo di approfondimentordfs:label : is related to additional form</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un modulo di approfondimento in relazione con il bene in esame.rdfs:comment : This property relates a cultural property to an additional form.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/APP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isRelatedToAdditionalForm">ctlog:isRelatedToAdditionalForm</a>
    /// </summary>
    let isRelatedToAdditionalForm = _prefixId.prefix "isRelatedToAdditionalForm"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un modulo informativo in relazione con il bene in esame.rdfs:comment : This property relates a cultural property to an information form.</para>
    ///   <para>rdfs:label : is related to information formrdfs:label : è collegato a modulo informativo</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasvesale 4.00: AC/MOD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isRelatedToInformationForm">ctlog:isRelatedToInformationForm</a>
    /// </summary>
    let isRelatedToInformationForm = _prefixId.prefix "isRelatedToInformationForm"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/ACS/ACSE^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha agente responsabile di scheda su bene culturale", collega l'Ente o il soggetto che ha prodotto la scheda o che gestisce la banca dati di cui la scheda fa parte alla scheda stessa.rdfs:comment : This property, inverse of "has cultural property record responsible agent", relates the agency or the person that created the record or manages the database where the record is to the record itself.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is responsible agent of cultural property recordrdfs:label : è ente responsabile della scheda su bene culturale</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isResponsibleAgentOfCulturalPropertyRecord">ctlog:isResponsibleAgentOfCulturalPropertyRecord</a>
    /// </summary>
    let isResponsibleAgentOfCulturalPropertyRecord =
        _prefixId.prefix "isResponsibleAgentOfCulturalPropertyRecord"

    /// <summary>
    ///   <para>rdfs:label : è responsabile ricerca e redazione dirdfs:label : is responsible research and compilation of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha responsabile ricerca e redazione".rdfs:comment : This is the inverse property of "has responsible research and compilation".</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isResponsibleResearchAndCompilationOf">ctlog:isResponsibleResearchAndCompilationOf</a>
    /// </summary>
    let isResponsibleResearchAndCompilationOf =
        _prefixId.prefix "isResponsibleResearchAndCompilationOf"

    /// <summary>
    ///   <para>rdfs:label : è referente verifica scientifica dirdfs:label : is scientific director of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has scientific director".rdfs:comment : Questa è la proprietà inversa a "ha referente verifica scientifica".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isScientificDirectorOf">ctlog:isScientificDirectorOf</a>
    /// </summary>
    let isScientificDirectorOf = _prefixId.prefix "isScientificDirectorOf"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has update official in charge".rdfs:comment : Questa è la proprietà inversa a "ha funzionario responsabile di aggiornamento".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is update official in charge ofrdfs:label : è funzionario responsabile di aggiornamento di</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isUpdateOfficialInChargeOf">ctlog:isUpdateOfficialInChargeOf</a>
    /// </summary>
    let isUpdateOfficialInChargeOf = _prefixId.prefix "isUpdateOfficialInChargeOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha ente o soggetto responsabile di aggiornamento".rdfs:comment : This is the inverse property of "has update responsible agent",</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is update responsible agent ofrdfs:label : è ente o soggetto responsabile di aggiornamento di</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleAgentOf">ctlog:isUpdateResponsibleAgentOf</a>
    /// </summary>
    let isUpdateResponsibleAgentOf = _prefixId.prefix "isUpdateResponsibleAgentOf"

    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has update responsible research and compilation".rdfs:comment : Questa è la proprietà inversa a "ha responsabile di ricerca e redazione di aggiornamento".</para>
    ///   <para>rdfs:label : è responsabile di ricerca e redazione di aggiornamento dirdfs:label : is update responsible research and compilation of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleResearchAndCompilationOf">ctlog:isUpdateResponsibleResearchAndCompilationOf</a>
    /// </summary>
    let isUpdateResponsibleResearchAndCompilationOf =
        _prefixId.prefix "isUpdateResponsibleResearchAndCompilationOf"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is update scientific revisor ofrdfs:label : è referente verifica scientifica di aggiornamento di</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha referente verifica scientifica di aggiornamento".rdfs:comment : This is the inverse property of "has update scientific revisor".</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/isUpdateScientificRevisorOf">ctlog:isUpdateScientificRevisorOf</a>
    /// </summary>
    let isUpdateScientificRevisorOf = _prefixId.prefix "isUpdateScientificRevisorOf"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a unique identifier of an entity, within a local inventory.rdfs:comment : Questa proprietà rappresenta un identificativo che individua un'entità in modo univoco nell'ambito di un repertorio locale. Si specializza in sottoproprietà (es.: identificativo dell'autore nell'ambito di un repertorio locale, identificativo dell'indagine archeologica nell'ambito di un repertorio locale, etc.)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : local identifierrdfs:label : identificativo di repertorio locale</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/localIdentifier">ctlog:localIdentifier</a>
    /// </summary>
    let localIdentifier = _prefixId.prefix "localIdentifier"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AN/RDP^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : dati pregressi recuperatirdfs:label : recovered data</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta eventuali informazioni provenienti da schede pregresse redatte sulla base di standard obsoleti, per le quali non è stato possibile effettuare il trasferimento nel tracciato della scheda aggiornato, secondo la sintassi: “acronimocampo: valore; acronimocampo: valore”rdfs:comment : This property represents information extracted from versions of a catalogue record using obsolete standards.</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/recoveredData">ctlog:recoveredData</a>
    /// </summary>
    let recoveredData = _prefixId.prefix "recoveredData"
    /// <summary>
    ///   <para>rdfs:label : reference projectrdfs:label : progetto di riferimento</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il progetto nell'ambito del quale è stata prodotta una scheda, quella a cui si associa un codice alternativo, assegnato da enti diversi da ICCD, o quella che analizza un bene culturale per finalità diverse da quella specifica della catalogazione del patrimonio culturale.rdfs:comment : This property represents the reference project of a record about a cultural property.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AC/ACC/ACCP; AC/ACS/ACSP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/referenceProject">ctlog:referenceProject</a>
    /// </summary>
    let referenceProject = _prefixId.prefix "referenceProject"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the identifier associated in the context of the SIGECweb to the xml file containing a catalogue record.rdfs:comment : Questa proprietà rappresenta l'identificativo di sistema che viene associato all'interno del sistema Sigec al file xml contenente una scheda di catalogo.</para>
    ///   <para>rdfs:label : identificativo di sistemardfs:label : system record code</para>
    ///   <a href="https://w3id.org/arco/ontology/catalogue/systemRecordCode">ctlog:systemRecordCode</a>
    /// </summary>
    let systemRecordCode = _prefixId.prefix "systemRecordCode"
