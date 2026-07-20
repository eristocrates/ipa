namespace http.purl.org.library.slash

open DoxAletheia

module library =
    let _namespace_name = "http://purl.org/library/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/ArchiveMaterial"></see>
    /// </summary>
    let ArchiveMaterial = _prefix "ArchiveMaterial"
    /// <summary>
    ///   <see href="http://purl.org/library/Audiobook"></see>
    /// </summary>
    let Audiobook = _prefix "Audiobook"
    /// <summary>
    ///   <see href="http://purl.org/library/BlurayDisk"></see>
    /// </summary>
    let BlurayDisk = _prefix "BlurayDisk"
    /// <summary>
    /// This class contains a controlled list of "carriers" that can be used to contain a schema:CreativeWork.
    /// <see href="http://purl.org/library/Carrier"></see></summary>
    let Carrier = _prefix "Carrier"
    /// <summary>
    ///   <see href="http://purl.org/library/BrailleBook"></see>
    /// </summary>
    let BrailleBook = _prefix "BrailleBook"
    /// <summary>
    ///   <see href="http://purl.org/library/CD"></see>
    /// </summary>
    let CD = _prefix "CD"
    /// <summary>
    ///   <see href="http://purl.org/library/CassetteTape"></see>
    /// </summary>
    let CassetteTape = _prefix "CassetteTape"
    /// <summary>
    ///   <see href="http://purl.org/library/ComputerFile"></see>
    /// </summary>
    let ComputerFile = _prefix "ComputerFile"
    /// <summary>
    ///   <see href="http://purl.org/library/ContinuallyUpdatedBook"></see>
    /// </summary>
    let ContinuallyUpdatedBook = _prefix "ContinuallyUpdatedBook"
    /// <summary>
    ///   <see href="http://purl.org/library/DVD"></see>
    /// </summary>
    let DVD = _prefix "DVD"
    /// <summary>
    ///   <see href="http://purl.org/library/FilmReel"></see>
    /// </summary>
    let FilmReel = _prefix "FilmReel"
    /// <summary>
    ///   <see href="http://purl.org/library/Game"></see>
    /// </summary>
    let Game = _prefix "Game"
    /// <summary>
    ///   <see href="http://purl.org/library/Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://purl.org/library/InteractiveMultimedia"></see>
    /// </summary>
    let InteractiveMultimedia = _prefix "InteractiveMultimedia"
    /// <summary>
    /// a mixture of various components issued as a unit and intended primarily for instructional purposes. No one component is identifiable as the predominant component of the item. Examples are packages of assorted materials, such as a set of K-12 social studies curriculum material (books, workbooks, guides, activities, etc.), or packages of educational test materials (tests, answer sheets, scoring guides, score charts, interpretative manuals, etc.).
    /// <see href="http://purl.org/library/Kit"></see></summary>
    let Kit = _prefix "Kit"
    /// <summary>
    ///   <see href="http://purl.org/library/LP"></see>
    /// </summary>
    let LP = _prefix "LP"
    /// <summary>
    ///   <see href="http://purl.org/library/LargePrintBook"></see>
    /// </summary>
    let LargePrintBook = _prefix "LargePrintBook"
    /// <summary>
    ///   <see href="http://purl.org/library/Microform"></see>
    /// </summary>
    let Microform = _prefix "Microform"
    /// <summary>
    ///   <see href="http://purl.org/library/MusicalScore"></see>
    /// </summary>
    let MusicalScore = _prefix "MusicalScore"
    /// <summary>
    ///   <see href="http://purl.org/library/Newspaper"></see>
    /// </summary>
    let Newspaper = _prefix "Newspaper"
    /// <summary>
    ///   <see href="http://purl.org/library/Periodical"></see>
    /// </summary>
    let Periodical = _prefix "Periodical"
    /// <summary>
    ///   <see href="http://purl.org/library/Thesis"></see>
    /// </summary>
    let Thesis = _prefix "Thesis"
    /// <summary>
    ///   <see href="http://purl.org/library/Toy"></see>
    /// </summary>
    let Toy = _prefix "Toy"
    /// <summary>
    ///   <see href="http://purl.org/library/VHSTape"></see>
    /// </summary>
    let VHSTape = _prefix "VHSTape"
    /// <summary>
    ///   <see href="http://purl.org/library/Video"></see>
    /// </summary>
    let Video = _prefix "Video"
    /// <summary>
    ///   <see href="http://purl.org/library/VideoGame"></see>
    /// </summary>
    let VideoGame = _prefix "VideoGame"
    /// <summary>
    ///   <see href="http://purl.org/library/VisualMaterial"></see>
    /// </summary>
    let VisualMaterial = _prefix "VisualMaterial"
    /// <summary>
    ///   <see href="http://purl.org/library/Volume"></see>
    /// </summary>
    let Volume = _prefix "Volume"
    /// <summary>
    ///   <see href="http://purl.org/library/WWW"></see>
    /// </summary>
    let WWW = _prefix "WWW"
    /// <summary>
    ///   <see href="http://purl.org/library/WebSite"></see>
    /// </summary>
    let WebSite = _prefix "WebSite"
    /// <summary>
    ///   <see href="http://purl.org/library/hasCarrier"></see>
    /// </summary>
    let hasCarrier = _prefix "hasCarrier"
    /// <summary>
    /// This is the number of identifiable "library" collections that "hold" one or more exemplars (aka copies or "Items").
    /// <see href="http://purl.org/library/holdingsCount"></see></summary>
    let holdingsCount = _prefix "holdingsCount"
    /// <summary>
    ///   <see href="http://purl.org/library/oclcnum"></see>
    /// </summary>
    let oclcnum = _prefix "oclcnum"
    /// <summary>
    /// This is the place where the schema:CreativeWork was published.
    /// <see href="http://purl.org/library/placeOfPublication"></see></summary>
    let placeOfPublication = _prefix "placeOfPublication"
