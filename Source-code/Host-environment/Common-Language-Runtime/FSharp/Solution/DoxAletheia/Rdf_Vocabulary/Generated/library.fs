namespace http.purl.org.library.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module library =
    let _namespace_iri = Namespace_Iri library |> NamespaceIRI
    /// <summary>
    ///   <para>library:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/library/">http://purl.org/library/</seealso>
    let _prefix_iri = Prefixed_Name(library, "") |> PrefixedName
    /// <summary>
    ///   <para>library:Audiobook</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:BookFormatType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Audio Book</para></remarks>
    /// <seealso href="http://purl.org/library/Audiobook">http://purl.org/library/Audiobook</seealso>
    let Audiobook = Prefixed_Name(library, "Audiobook") |> PrefixedName
    /// <summary>
    ///   <para>library:CD</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Compact Disk</para></remarks>
    /// <seealso href="http://purl.org/library/CD">http://purl.org/library/CD</seealso>
    let CD = Prefixed_Name(library, "CD") |> PrefixedName
    /// <summary>
    ///   <para>library:Game</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Game</para></remarks>
    /// <seealso href="http://purl.org/library/Game">http://purl.org/library/Game</seealso>
    let Game = Prefixed_Name(library, "Game") |> PrefixedName
    /// <summary>
    ///   <para>library:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://purl.org/library/Image">http://purl.org/library/Image</seealso>
    let Image = Prefixed_Name(library, "Image") |> PrefixedName
    /// <summary>
    ///   <para>library:LP</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>LP</para></remarks>
    /// <seealso href="http://purl.org/library/LP">http://purl.org/library/LP</seealso>
    let LP = Prefixed_Name(library, "LP") |> PrefixedName
    /// <summary>
    ///   <para>library:MusicalScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Musical Score</para></remarks>
    /// <seealso href="http://purl.org/library/MusicalScore">http://purl.org/library/MusicalScore</seealso>
    let MusicalScore = Prefixed_Name(library, "MusicalScore") |> PrefixedName
    /// <summary>
    ///   <para>library:BlurayDisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>library:Carrier</para>
    ///
    /// labels<para>Bluray Disk</para></remarks>
    /// <seealso href="http://purl.org/library/BlurayDisk">http://purl.org/library/BlurayDisk</seealso>
    let BlurayDisk = Prefixed_Name(library, "BlurayDisk") |> PrefixedName
    /// <summary>
    ///   <para>library:ComputerFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Computer File</para></remarks>
    /// <seealso href="http://purl.org/library/ComputerFile">http://purl.org/library/ComputerFile</seealso>
    let ComputerFile = Prefixed_Name(library, "ComputerFile") |> PrefixedName

    /// <summary>
    ///   <para>library:placeOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the place where the schema:CreativeWork was published.</para>
    /// labels<para>place of publication</para></remarks>
    /// <seealso href="http://purl.org/library/placeOfPublication">http://purl.org/library/placeOfPublication</seealso>
    let placeOfPublication =
        Prefixed_Name(library, "placeOfPublication") |> PrefixedName

    /// <summary>
    ///   <para>library:Carrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class contains a controlled list of "carriers" that can be used to contain a schema:CreativeWork.</para>
    /// labels<para>Carrier</para></remarks>
    /// <seealso href="http://purl.org/library/Carrier">http://purl.org/library/Carrier</seealso>
    let Carrier = Prefixed_Name(library, "Carrier") |> PrefixedName
    /// <summary>
    ///   <para>library:CassetteTape</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Cassette Tape</para></remarks>
    /// <seealso href="http://purl.org/library/CassetteTape">http://purl.org/library/CassetteTape</seealso>
    let CassetteTape = Prefixed_Name(library, "CassetteTape") |> PrefixedName
    /// <summary>
    ///   <para>library:DVD</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>DVD</para></remarks>
    /// <seealso href="http://purl.org/library/DVD">http://purl.org/library/DVD</seealso>
    let DVD = Prefixed_Name(library, "DVD") |> PrefixedName

    /// <summary>
    ///   <para>library:ContinuallyUpdatedBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:BookFormatType</para>
    ///
    /// labels<para>Continually Updated Book</para></remarks>
    /// <seealso href="http://purl.org/library/ContinuallyUpdatedBook">http://purl.org/library/ContinuallyUpdatedBook</seealso>
    let ContinuallyUpdatedBook =
        Prefixed_Name(library, "ContinuallyUpdatedBook") |> PrefixedName

    /// <summary>
    ///   <para>library:FilmReel</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Film Reel</para></remarks>
    /// <seealso href="http://purl.org/library/FilmReel">http://purl.org/library/FilmReel</seealso>
    let FilmReel = Prefixed_Name(library, "FilmReel") |> PrefixedName
    /// <summary>
    ///   <para>library:LargePrintBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:BookFormatType</para>
    ///
    /// labels<para>Large Print Book</para></remarks>
    /// <seealso href="http://purl.org/library/LargePrintBook">http://purl.org/library/LargePrintBook</seealso>
    let LargePrintBook = Prefixed_Name(library, "LargePrintBook") |> PrefixedName

    /// <summary>
    ///   <para>library:InteractiveMultimedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Interactive Multimedia</para></remarks>
    /// <seealso href="http://purl.org/library/InteractiveMultimedia">http://purl.org/library/InteractiveMultimedia</seealso>
    let InteractiveMultimedia =
        Prefixed_Name(library, "InteractiveMultimedia") |> PrefixedName

    /// <summary>
    ///   <para>library:Microform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>library:Carrier</para>
    ///
    /// labels<para>Microform</para></remarks>
    /// <seealso href="http://purl.org/library/Microform">http://purl.org/library/Microform</seealso>
    let Microform = Prefixed_Name(library, "Microform") |> PrefixedName
    /// <summary>
    ///   <para>library:VHSTape</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>VHS Tape</para></remarks>
    /// <seealso href="http://purl.org/library/VHSTape">http://purl.org/library/VHSTape</seealso>
    let VHSTape = Prefixed_Name(library, "VHSTape") |> PrefixedName
    /// <summary>
    ///   <para>library:VideoGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>VideoGame</para></remarks>
    /// <seealso href="http://purl.org/library/VideoGame">http://purl.org/library/VideoGame</seealso>
    let VideoGame = Prefixed_Name(library, "VideoGame") |> PrefixedName
    /// <summary>
    ///   <para>library:WWW</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>World Wide Web</para></remarks>
    /// <seealso href="http://purl.org/library/WWW">http://purl.org/library/WWW</seealso>
    let WWW = Prefixed_Name(library, "WWW") |> PrefixedName
    /// <summary>
    ///   <para>library:hasCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has carrier</para></remarks>
    /// <seealso href="http://purl.org/library/hasCarrier">http://purl.org/library/hasCarrier</seealso>
    let hasCarrier = Prefixed_Name(library, "hasCarrier") |> PrefixedName
    /// <summary>
    ///   <para>library:oclcnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>oclcnum</para></remarks>
    /// <seealso href="http://purl.org/library/oclcnum">http://purl.org/library/oclcnum</seealso>
    let oclcnum = Prefixed_Name(library, "oclcnum") |> PrefixedName
    /// <summary>
    ///   <para>library:Kit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a mixture of various components issued as a unit and intended primarily for instructional purposes. No one component is identifiable as the predominant component of the item. Examples are packages of assorted materials, such as a set of K-12 social studies curriculum material (books, workbooks, guides, activities, etc.), or packages of educational test materials (tests, answer sheets, scoring guides, score charts, interpretative manuals, etc.).</para>
    /// labels<para>Kit</para></remarks>
    /// <seealso href="http://purl.org/library/Kit">http://purl.org/library/Kit</seealso>
    let Kit = Prefixed_Name(library, "Kit") |> PrefixedName
    /// <summary>
    ///   <para>library:Newspaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Newspaper</para></remarks>
    /// <seealso href="http://purl.org/library/Newspaper">http://purl.org/library/Newspaper</seealso>
    let Newspaper = Prefixed_Name(library, "Newspaper") |> PrefixedName
    /// <summary>
    ///   <para>library:Periodical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Periodical</para></remarks>
    /// <seealso href="http://purl.org/library/Periodical">http://purl.org/library/Periodical</seealso>
    let Periodical = Prefixed_Name(library, "Periodical") |> PrefixedName
    /// <summary>
    ///   <para>library:Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thesis</para></remarks>
    /// <seealso href="http://purl.org/library/Thesis">http://purl.org/library/Thesis</seealso>
    let Thesis = Prefixed_Name(library, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>library:Toy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Toy</para></remarks>
    /// <seealso href="http://purl.org/library/Toy">http://purl.org/library/Toy</seealso>
    let Toy = Prefixed_Name(library, "Toy") |> PrefixedName
    /// <summary>
    ///   <para>library:VisualMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Visual Material</para></remarks>
    /// <seealso href="http://purl.org/library/VisualMaterial">http://purl.org/library/VisualMaterial</seealso>
    let VisualMaterial = Prefixed_Name(library, "VisualMaterial") |> PrefixedName
    /// <summary>
    ///   <para>library:Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>library:Carrier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Volume</para></remarks>
    /// <seealso href="http://purl.org/library/Volume">http://purl.org/library/Volume</seealso>
    let Volume = Prefixed_Name(library, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>library:WebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Web Site</para></remarks>
    /// <seealso href="http://purl.org/library/WebSite">http://purl.org/library/WebSite</seealso>
    let WebSite = Prefixed_Name(library, "WebSite") |> PrefixedName
    /// <summary>
    ///   <para>library:holdingsCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This is the number of identifiable "library" collections that "hold" one or more exemplars (aka copies or "Items").</para>
    /// labels<para>holdings count</para></remarks>
    /// <seealso href="http://purl.org/library/holdingsCount">http://purl.org/library/holdingsCount</seealso>
    let holdingsCount = Prefixed_Name(library, "holdingsCount") |> PrefixedName
    /// <summary>
    ///   <para>library:ArchiveMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ArchiveMaterial</para></remarks>
    /// <seealso href="http://purl.org/library/ArchiveMaterial">http://purl.org/library/ArchiveMaterial</seealso>
    let ArchiveMaterial = Prefixed_Name(library, "ArchiveMaterial") |> PrefixedName
    /// <summary>
    ///   <para>library:BrailleBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:BookFormatType</para>
    ///
    /// labels<para>Braille Book</para></remarks>
    /// <seealso href="http://purl.org/library/BrailleBook">http://purl.org/library/BrailleBook</seealso>
    let BrailleBook = Prefixed_Name(library, "BrailleBook") |> PrefixedName
    /// <summary>
    ///   <para>library:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Video</para></remarks>
    /// <seealso href="http://purl.org/library/Video">http://purl.org/library/Video</seealso>
    let Video = Prefixed_Name(library, "Video") |> PrefixedName
