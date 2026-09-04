#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lib =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/library/" "lib"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : ArchiveMaterial</para>
    ///   <a href="http://purl.org/library/ArchiveMaterial">lib:ArchiveMaterial</a>
    /// </summary>
    let ArchiveMaterial = _prefixId.prefix "ArchiveMaterial"
    let Audiobook = _prefixId.prefix "Audiobook"
    let BlurayDisk = _prefixId.prefix "BlurayDisk"
    let BrailleBook = _prefixId.prefix "BrailleBook"
    let CD = _prefixId.prefix "CD"
    /// <summary>
    ///   <para>rdfs:comment : This class contains a controlled list of "carriers" that can be used to contain a schema:CreativeWork.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Carrier</para>
    ///   <a href="http://purl.org/library/Carrier">lib:Carrier</a>
    /// </summary>
    let Carrier = _prefixId.prefix "Carrier"
    let CassetteTape = _prefixId.prefix "CassetteTape"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Computer File</para>
    ///   <a href="http://purl.org/library/ComputerFile">lib:ComputerFile</a>
    /// </summary>
    let ComputerFile = _prefixId.prefix "ComputerFile"
    let ContinuallyUpdatedBook = _prefixId.prefix "ContinuallyUpdatedBook"
    let DVD = _prefixId.prefix "DVD"
    let FilmReel = _prefixId.prefix "FilmReel"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Game</para>
    ///   <a href="http://purl.org/library/Game">lib:Game</a>
    /// </summary>
    let Game = _prefixId.prefix "Game"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Image</para>
    ///   <a href="http://purl.org/library/Image">lib:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Interactive Multimedia</para>
    ///   <a href="http://purl.org/library/InteractiveMultimedia">lib:InteractiveMultimedia</a>
    /// </summary>
    let InteractiveMultimedia = _prefixId.prefix "InteractiveMultimedia"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : a mixture of various components issued as a unit and intended primarily for instructional purposes. No one component is identifiable as the predominant component of the item. Examples are packages of assorted materials, such as a set of K-12 social studies curriculum material (books, workbooks, guides, activities, etc.), or packages of educational test materials (tests, answer sheets, scoring guides, score charts, interpretative manuals, etc.).</para>
    ///   <para>rdfs:label : Kit</para>
    ///   <a href="http://purl.org/library/Kit">lib:Kit</a>
    /// </summary>
    let Kit = _prefixId.prefix "Kit"
    let LP = _prefixId.prefix "LP"
    let LargePrintBook = _prefixId.prefix "LargePrintBook"
    let Microform = _prefixId.prefix "Microform"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Musical Score</para>
    ///   <a href="http://purl.org/library/MusicalScore">lib:MusicalScore</a>
    /// </summary>
    let MusicalScore = _prefixId.prefix "MusicalScore"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Newspaper</para>
    ///   <a href="http://purl.org/library/Newspaper">lib:Newspaper</a>
    /// </summary>
    let Newspaper = _prefixId.prefix "Newspaper"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Periodical</para>
    ///   <a href="http://purl.org/library/Periodical">lib:Periodical</a>
    /// </summary>
    let Periodical = _prefixId.prefix "Periodical"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Thesis</para>
    ///   <a href="http://purl.org/library/Thesis">lib:Thesis</a>
    /// </summary>
    let Thesis = _prefixId.prefix "Thesis"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Toy</para>
    ///   <a href="http://purl.org/library/Toy">lib:Toy</a>
    /// </summary>
    let Toy = _prefixId.prefix "Toy"
    let VHSTape = _prefixId.prefix "VHSTape"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Video</para>
    ///   <a href="http://purl.org/library/Video">lib:Video</a>
    /// </summary>
    let Video = _prefixId.prefix "Video"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : VideoGame</para>
    ///   <a href="http://purl.org/library/VideoGame">lib:VideoGame</a>
    /// </summary>
    let VideoGame = _prefixId.prefix "VideoGame"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Visual Material</para>
    ///   <a href="http://purl.org/library/VisualMaterial">lib:VisualMaterial</a>
    /// </summary>
    let VisualMaterial = _prefixId.prefix "VisualMaterial"
    let Volume = _prefixId.prefix "Volume"
    let WWW = _prefixId.prefix "WWW"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Web Site</para>
    ///   <a href="http://purl.org/library/WebSite">lib:WebSite</a>
    /// </summary>
    let WebSite = _prefixId.prefix "WebSite"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : has carrier</para>
    ///   <a href="http://purl.org/library/hasCarrier">lib:hasCarrier</a>
    /// </summary>
    let hasCarrier = _prefixId.prefix "hasCarrier"
    /// <summary>
    ///   <para>rdfs:comment : This is the number of identifiable "library" collections that "hold" one or more exemplars (aka copies or "Items").^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : holdings count^^xsd:string</para>
    ///   <a href="http://purl.org/library/holdingsCount">lib:holdingsCount</a>
    /// </summary>
    let holdingsCount = _prefixId.prefix "holdingsCount"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : oclcnum</para>
    ///   <a href="http://purl.org/library/oclcnum">lib:oclcnum</a>
    /// </summary>
    let oclcnum = _prefixId.prefix "oclcnum"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : This is the place where the schema:CreativeWork was published.</para>
    ///   <para>rdfs:label : place of publication</para>
    ///   <a href="http://purl.org/library/placeOfPublication">lib:placeOfPublication</a>
    /// </summary>
    let placeOfPublication = _prefixId.prefix "placeOfPublication"
