namespace http.purl.org.library.slash

open DoxAletheia.Rdf_Vocabulary

module library =
    let _namespace_name = "http://purl.org/library/"

    /// <summary>
    ///   <see href="http://purl.org/library/ArchiveMaterial"></see>
    /// </summary>
    let ArchiveMaterial =
        Namespaced_IRI.parse _namespace_name "ArchiveMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/Audiobook"></see>
    /// </summary>
    let Audiobook = Namespaced_IRI.parse _namespace_name "Audiobook" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/BlurayDisk"></see>
    /// </summary>
    let BlurayDisk = Namespaced_IRI.parse _namespace_name "BlurayDisk" |> NamespacedName
    /// <summary>
    /// This class contains a controlled list of "carriers" that can be used to contain a schema:CreativeWork.
    /// <see href="http://purl.org/library/Carrier"></see></summary>
    let Carrier = Namespaced_IRI.parse _namespace_name "Carrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/BrailleBook"></see>
    /// </summary>
    let BrailleBook =
        Namespaced_IRI.parse _namespace_name "BrailleBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/CD"></see>
    /// </summary>
    let CD = Namespaced_IRI.parse _namespace_name "CD" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/CassetteTape"></see>
    /// </summary>
    let CassetteTape =
        Namespaced_IRI.parse _namespace_name "CassetteTape" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/ComputerFile"></see>
    /// </summary>
    let ComputerFile =
        Namespaced_IRI.parse _namespace_name "ComputerFile" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/ContinuallyUpdatedBook"></see>
    /// </summary>
    let ContinuallyUpdatedBook =
        Namespaced_IRI.parse _namespace_name "ContinuallyUpdatedBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/DVD"></see>
    /// </summary>
    let DVD = Namespaced_IRI.parse _namespace_name "DVD" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/FilmReel"></see>
    /// </summary>
    let FilmReel = Namespaced_IRI.parse _namespace_name "FilmReel" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/Game"></see>
    /// </summary>
    let Game = Namespaced_IRI.parse _namespace_name "Game" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/InteractiveMultimedia"></see>
    /// </summary>
    let InteractiveMultimedia =
        Namespaced_IRI.parse _namespace_name "InteractiveMultimedia" |> NamespacedName

    /// <summary>
    /// a mixture of various components issued as a unit and intended primarily for instructional purposes. No one component is identifiable as the predominant component of the item. Examples are packages of assorted materials, such as a set of K-12 social studies curriculum material (books, workbooks, guides, activities, etc.), or packages of educational test materials (tests, answer sheets, scoring guides, score charts, interpretative manuals, etc.).
    /// <see href="http://purl.org/library/Kit"></see></summary>
    let Kit = Namespaced_IRI.parse _namespace_name "Kit" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/LP"></see>
    /// </summary>
    let LP = Namespaced_IRI.parse _namespace_name "LP" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/LargePrintBook"></see>
    /// </summary>
    let LargePrintBook =
        Namespaced_IRI.parse _namespace_name "LargePrintBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/Microform"></see>
    /// </summary>
    let Microform = Namespaced_IRI.parse _namespace_name "Microform" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/MusicalScore"></see>
    /// </summary>
    let MusicalScore =
        Namespaced_IRI.parse _namespace_name "MusicalScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/Newspaper"></see>
    /// </summary>
    let Newspaper = Namespaced_IRI.parse _namespace_name "Newspaper" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/Periodical"></see>
    /// </summary>
    let Periodical = Namespaced_IRI.parse _namespace_name "Periodical" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/Thesis"></see>
    /// </summary>
    let Thesis = Namespaced_IRI.parse _namespace_name "Thesis" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/Toy"></see>
    /// </summary>
    let Toy = Namespaced_IRI.parse _namespace_name "Toy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/VHSTape"></see>
    /// </summary>
    let VHSTape = Namespaced_IRI.parse _namespace_name "VHSTape" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/Video"></see>
    /// </summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/VideoGame"></see>
    /// </summary>
    let VideoGame = Namespaced_IRI.parse _namespace_name "VideoGame" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/VisualMaterial"></see>
    /// </summary>
    let VisualMaterial =
        Namespaced_IRI.parse _namespace_name "VisualMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/Volume"></see>
    /// </summary>
    let Volume = Namespaced_IRI.parse _namespace_name "Volume" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/WWW"></see>
    /// </summary>
    let WWW = Namespaced_IRI.parse _namespace_name "WWW" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/WebSite"></see>
    /// </summary>
    let WebSite = Namespaced_IRI.parse _namespace_name "WebSite" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/library/hasCarrier"></see>
    /// </summary>
    let hasCarrier = Namespaced_IRI.parse _namespace_name "hasCarrier" |> NamespacedName

    /// <summary>
    /// This is the number of identifiable "library" collections that "hold" one or more exemplars (aka copies or "Items").
    /// <see href="http://purl.org/library/holdingsCount"></see></summary>
    let holdingsCount =
        Namespaced_IRI.parse _namespace_name "holdingsCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/library/oclcnum"></see>
    /// </summary>
    let oclcnum = Namespaced_IRI.parse _namespace_name "oclcnum" |> NamespacedName

    /// <summary>
    /// This is the place where the schema:CreativeWork was published.
    /// <see href="http://purl.org/library/placeOfPublication"></see></summary>
    let placeOfPublication =
        Namespaced_IRI.parse _namespace_name "placeOfPublication" |> NamespacedName
