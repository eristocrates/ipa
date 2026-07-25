namespace http.comicmeta.org.cbo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cbo =
    let _namespace_iri = Namespace_Iri cbo |> NamespaceIRI
    /// <summary>
    ///   <para>cbo:Balloon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A word balloon containing dialogue or thought.</para>
    /// labels<para>Balloon</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Balloon">http://comicmeta.org/cbo/Balloon</seealso>
    let Balloon = Prefixed_Name(cbo, "Balloon") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A binding method or material used to bind the pages of a comic.</para>
    /// labels<para>Binding</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Binding">http://comicmeta.org/cbo/Binding</seealso>
    let Binding = Prefixed_Name(cbo, "Binding") |> PrefixedName
    /// <summary>
    ///   <para>cbo:reprintedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to a work that reprints it.</para>
    /// labels<para>reprinted in</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/reprintedIn">http://comicmeta.org/cbo/reprintedIn</seealso>
    let reprintedIn = Prefixed_Name(cbo, "reprintedIn") |> PrefixedName
    /// <summary>
    ///   <para>cbo:comicAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a comic with an era of comic book history.</para>
    /// labels<para>comic age</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/comicAge">http://comicmeta.org/cbo/comicAge</seealso>
    let comicAge = Prefixed_Name(cbo, "comicAge") |> PrefixedName
    /// <summary>
    ///   <para>cbo:copyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the physical state of a copy of a comic issue.</para>
    /// labels<para>copy state</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/copyState">http://comicmeta.org/cbo/copyState</seealso>
    let copyState = Prefixed_Name(cbo, "copyState") |> PrefixedName
    /// <summary>
    ///   <para>cbo:coverArt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the cover art of a comic issue.</para>
    /// labels<para>cover art</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/coverArt">http://comicmeta.org/cbo/coverArt</seealso>
    let coverArt = Prefixed_Name(cbo, "coverArt") |> PrefixedName
    /// <summary>
    ///   <para>cbo:coverPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The cover price of a comic issue.</para>
    /// labels<para>coverPrice</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/coverPrice">http://comicmeta.org/cbo/coverPrice</seealso>
    let coverPrice = Prefixed_Name(cbo, "coverPrice") |> PrefixedName
    /// <summary>
    ///   <para>cbo:volumeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The unique identifier of a comic volume.</para>
    /// labels<para>volumeNumber</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/volumeNumber">http://comicmeta.org/cbo/volumeNumber</seealso>
    let volumeNumber = Prefixed_Name(cbo, "volumeNumber") |> PrefixedName
    /// <summary>
    ///   <para>cbo:writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a writer with a comic work.</para>
    /// labels<para>writer</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/writer">http://comicmeta.org/cbo/writer</seealso>
    let writer = Prefixed_Name(cbo, "writer") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A thing in a comic universe.</para>
    /// labels<para>Thing</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Thing">http://comicmeta.org/cbo/Thing</seealso>
    let Thing = Prefixed_Name(cbo, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Team</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of comic characters.</para>
    /// labels<para>Team</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Team">http://comicmeta.org/cbo/Team</seealso>
    let Team = Prefixed_Name(cbo, "Team") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A vehicle in a comic universe.</para>
    /// labels<para>Vehicle</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Vehicle">http://comicmeta.org/cbo/Vehicle</seealso>
    let Vehicle = Prefixed_Name(cbo, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>cbo:adaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic to an adaptation.</para>
    /// labels<para>adaptation</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/adaptation">http://comicmeta.org/cbo/adaptation</seealso>
    let adaptation = Prefixed_Name(cbo, "adaptation") |> PrefixedName
    /// <summary>
    ///   <para>cbo:alternativeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An alternative title for any comic work.</para>
    /// labels<para>alternative title</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/alternativeTitle">http://comicmeta.org/cbo/alternativeTitle</seealso>
    let alternativeTitle = Prefixed_Name(cbo, "alternativeTitle") |> PrefixedName
    /// <summary>
    ///   <para>cbo:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a contributor with a comic work.</para>
    /// labels<para>contributor</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/contributor">http://comicmeta.org/cbo/contributor</seealso>
    let contributor = Prefixed_Name(cbo, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>cbo:artwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic page to its original artwork.</para>
    /// labels<para>artwork</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/artwork">http://comicmeta.org/cbo/artwork</seealso>
    let artwork = Prefixed_Name(cbo, "artwork") |> PrefixedName
    /// <summary>
    ///   <para>cbo:bagged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the bag in which a comic is contained.</para>
    /// labels<para>bagged</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/bagged">http://comicmeta.org/cbo/bagged</seealso>
    let bagged = Prefixed_Name(cbo, "bagged") |> PrefixedName
    /// <summary>
    ///   <para>cbo:sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sequence to a page.</para>
    /// labels<para>sequence</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/sequence">http://comicmeta.org/cbo/sequence</seealso>
    let sequence = Prefixed_Name(cbo, "sequence") |> PrefixedName
    /// <summary>
    ///   <para>cbo:binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the binding of a comic issue.</para>
    /// labels<para>binding</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/binding">http://comicmeta.org/cbo/binding</seealso>
    let binding = Prefixed_Name(cbo, "binding") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Artwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Original comic artwork.</para>
    /// labels<para>Artwork</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Artwork">http://comicmeta.org/cbo/Artwork</seealso>
    let Artwork = Prefixed_Name(cbo, "Artwork") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical or digital item.</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Item">http://comicmeta.org/cbo/Item</seealso>
    let Item = Prefixed_Name(cbo, "Item") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A visual sequence of juxtaposed panels and pictorial elements.</para>
    /// labels<para>Sequence</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Sequence">http://comicmeta.org/cbo/Sequence</seealso>
    let Sequence = Prefixed_Name(cbo, "Sequence") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A material or medium of which an object is composed.</para>
    /// labels<para>Material</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Material">http://comicmeta.org/cbo/Material</seealso>
    let Material = Prefixed_Name(cbo, "Material") |> PrefixedName
    /// <summary>
    ///   <para>cbo:cameo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes a cameo appearance by a comic character in a comic work.</para>
    /// labels<para>cameo</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/cameo">http://comicmeta.org/cbo/cameo</seealso>
    let cameo = Prefixed_Name(cbo, "cameo") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object containing comic books.</para>
    /// labels<para>Container</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Container">http://comicmeta.org/cbo/Container</seealso>
    let Container = Prefixed_Name(cbo, "Container") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comic character.</para>
    /// labels<para>Character</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Character">http://comicmeta.org/cbo/Character</seealso>
    let Character = Prefixed_Name(cbo, "Character") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Comic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A visual and literary work of sequential art.</para>
    /// labels<para>Comic</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Comic">http://comicmeta.org/cbo/Comic</seealso>
    let Comic = Prefixed_Name(cbo, "Comic") |> PrefixedName
    /// <summary>
    ///   <para>cbo:ComicUniverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comic universe.</para>
    /// labels<para>Comic Universe</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/ComicUniverse">http://comicmeta.org/cbo/ComicUniverse</seealso>
    let ComicUniverse = Prefixed_Name(cbo, "ComicUniverse") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent contributing to the creation of a comic work.</para>
    /// labels<para>Contributor</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Contributor">http://comicmeta.org/cbo/Contributor</seealso>
    let Contributor = Prefixed_Name(cbo, "Contributor") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Costume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comic character's costume.</para>
    /// labels<para>Costume</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Costume">http://comicmeta.org/cbo/Costume</seealso>
    let Costume = Prefixed_Name(cbo, "Costume") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent primarily responsible for the creation of a comic work.</para>
    /// labels<para>Creator</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Creator">http://comicmeta.org/cbo/Creator</seealso>
    let Creator = Prefixed_Name(cbo, "Creator") |> PrefixedName
    /// <summary>
    ///   <para>cbo:imprintOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an imprint with a comic publisher.</para>
    /// labels<para>imprint of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/imprintOf">http://comicmeta.org/cbo/imprintOf</seealso>
    let imprintOf = Prefixed_Name(cbo, "imprintOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:imprintName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a comic imprint.</para>
    /// labels<para>imprint name</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/imprintName">http://comicmeta.org/cbo/imprintName</seealso>
    let imprintName = Prefixed_Name(cbo, "imprintName") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Box</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A box that contains comic books.</para>
    /// labels<para>Box</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Box">http://comicmeta.org/cbo/Box</seealso>
    let Box = Prefixed_Name(cbo, "Box") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A building in a comic universe.</para>
    /// labels<para>Building</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Building">http://comicmeta.org/cbo/Building</seealso>
    let Building = Prefixed_Name(cbo, "Building") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object in a comic universe.</para>
    /// labels<para>Object</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Object">http://comicmeta.org/cbo/Object</seealso>
    let Object = Prefixed_Name(cbo, "Object") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of comic books and related resources.</para>
    /// labels<para>Collection</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Collection">http://comicmeta.org/cbo/Collection</seealso>
    let Collection = Prefixed_Name(cbo, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Collector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comic book collector.</para>
    /// labels<para>Collector</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Collector">http://comicmeta.org/cbo/Collector</seealso>
    let Collector = Prefixed_Name(cbo, "Collector") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Caption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A caption containing narration.</para>
    /// labels<para>Caption</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Caption">http://comicmeta.org/cbo/Caption</seealso>
    let Caption = Prefixed_Name(cbo, "Caption") |> PrefixedName
    /// <summary>
    ///   <para>cbo:ComicAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A period of comic book history.</para>
    /// labels<para>Comic Age</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/ComicAge">http://comicmeta.org/cbo/ComicAge</seealso>
    let ComicAge = Prefixed_Name(cbo, "ComicAge") |> PrefixedName
    /// <summary>
    ///   <para>cbo:PhysicalAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An physical attribute or property of an item.</para>
    /// labels<para>Attribute</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/PhysicalAttribute">http://comicmeta.org/cbo/PhysicalAttribute</seealso>
    let PhysicalAttribute = Prefixed_Name(cbo, "PhysicalAttribute") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An issue of a comic publication.</para>
    /// labels<para>Issue</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Issue">http://comicmeta.org/cbo/Issue</seealso>
    let Issue = Prefixed_Name(cbo, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical condition describing an object.</para>
    /// labels<para>Condition</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Condition">http://comicmeta.org/cbo/Condition</seealso>
    let Condition = Prefixed_Name(cbo, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>cbo:edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the edition of a comic issue.</para>
    /// labels<para>edition</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/edition">http://comicmeta.org/cbo/edition</seealso>
    let edition = Prefixed_Name(cbo, "edition") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A copy of a comic issue.</para>
    /// labels<para>Copy</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Copy">http://comicmeta.org/cbo/Copy</seealso>
    let Copy = Prefixed_Name(cbo, "Copy") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent responsible for the distribution of a comic publication.</para>
    /// labels<para>Distributor</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Distributor">http://comicmeta.org/cbo/Distributor</seealso>
    let Distributor = Prefixed_Name(cbo, "Distributor") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document composed of the pages in a comic publication.</para>
    /// labels<para>Document</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Document">http://comicmeta.org/cbo/Document</seealso>
    let Document = Prefixed_Name(cbo, "Document") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An edition of a comic issue.</para>
    /// labels<para>Edition</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Edition">http://comicmeta.org/cbo/Edition</seealso>
    let Edition = Prefixed_Name(cbo, "Edition") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A format in which a comic is embodied.</para>
    /// labels<para>Format</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Format">http://comicmeta.org/cbo/Format</seealso>
    let Format = Prefixed_Name(cbo, "Format") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Guarantor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that guarantees the stated condition of a comic book.</para>
    /// labels<para>Guarantor</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Guarantor">http://comicmeta.org/cbo/Guarantor</seealso>
    let Guarantor = Prefixed_Name(cbo, "Guarantor") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event in a comic universe.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Event">http://comicmeta.org/cbo/Event</seealso>
    let Event = Prefixed_Name(cbo, "Event") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A frequency with which a comic is published.</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Frequency">http://comicmeta.org/cbo/Frequency</seealso>
    let Frequency = Prefixed_Name(cbo, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Grade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A grade assigned to a comic item that represents a summary of its condition.</para>
    /// labels<para>Grade</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Grade">http://comicmeta.org/cbo/Grade</seealso>
    let Grade = Prefixed_Name(cbo, "Grade") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Imprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An imprint or tradename of a comic publisher.</para>
    /// labels<para>Imprint</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Imprint">http://comicmeta.org/cbo/Imprint</seealso>
    let Imprint = Prefixed_Name(cbo, "Imprint") |> PrefixedName
    /// <summary>
    ///   <para>cbo:penciller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a penciller with a comic work.</para>
    /// labels<para>penciller</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/penciller">http://comicmeta.org/cbo/penciller</seealso>
    let penciller = Prefixed_Name(cbo, "penciller") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comics genre.</para>
    /// labels<para>Genre</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Genre">http://comicmeta.org/cbo/Genre</seealso>
    let Genre = Prefixed_Name(cbo, "Genre") |> PrefixedName
    /// <summary>
    ///   <para>cbo:page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic page to a document.</para>
    /// labels<para>page</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/page">http://comicmeta.org/cbo/page</seealso>
    let page = Prefixed_Name(cbo, "page") |> PrefixedName
    /// <summary>
    ///   <para>cbo:itemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an item to a comic book collection.</para>
    /// labels<para>item of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/itemOf">http://comicmeta.org/cbo/itemOf</seealso>
    let itemOf = Prefixed_Name(cbo, "itemOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent responsible for the publication of a comic.</para>
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Publisher">http://comicmeta.org/cbo/Publisher</seealso>
    let Publisher = Prefixed_Name(cbo, "Publisher") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical or digital library containing a collection of comic resources.</para>
    /// labels<para>Library</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Library">http://comicmeta.org/cbo/Library</seealso>
    let Library = Prefixed_Name(cbo, "Library") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Museum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical or digital museum exhibiting a collection of comic resources.</para>
    /// labels<para>Museum</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Museum">http://comicmeta.org/cbo/Museum</seealso>
    let Museum = Prefixed_Name(cbo, "Museum") |> PrefixedName
    /// <summary>
    ///   <para>cbo:PageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of page appearing in a comic document.</para>
    /// labels<para>Page Type</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/PageType">http://comicmeta.org/cbo/PageType</seealso>
    let PageType = Prefixed_Name(cbo, "PageType") |> PrefixedName
    /// <summary>
    ///   <para>cbo:universeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic universe to the universe from which it originates.</para>
    /// labels<para>universe of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/universeOf">http://comicmeta.org/cbo/universeOf</seealso>
    let universeOf = Prefixed_Name(cbo, "universeOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:upc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The UPC of a comic publication.</para>
    /// labels<para>UPC</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/upc">http://comicmeta.org/cbo/upc</seealso>
    let upc = Prefixed_Name(cbo, "upc") |> PrefixedName
    /// <summary>
    ///   <para>cbo:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The estimated value of a comic item.</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/value">http://comicmeta.org/cbo/value</seealso>
    let value = Prefixed_Name(cbo, "value") |> PrefixedName
    /// <summary>
    ///   <para>cbo:rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The rating of a comics publication.</para>
    /// labels<para>rating</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/rating">http://comicmeta.org/cbo/rating</seealso>
    let rating = Prefixed_Name(cbo, "rating") |> PrefixedName
    /// <summary>
    ///   <para>cbo:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic to a related object.</para>
    /// labels<para>related</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/related">http://comicmeta.org/cbo/related</seealso>
    let related = Prefixed_Name(cbo, "related") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comics publication.</para>
    /// labels<para>Publication</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Publication">http://comicmeta.org/cbo/Publication</seealso>
    let Publication = Prefixed_Name(cbo, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location in a comic universe.</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Location">http://comicmeta.org/cbo/Location</seealso>
    let Location = Prefixed_Name(cbo, "Location") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One or more pages in a comic document.</para>
    /// labels<para>Page</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Page">http://comicmeta.org/cbo/Page</seealso>
    let Page = Prefixed_Name(cbo, "Page") |> PrefixedName
    /// <summary>
    ///   <para>cbo:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the physical state of a comic item.</para>
    /// labels<para>state</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/state">http://comicmeta.org/cbo/state</seealso>
    let state = Prefixed_Name(cbo, "state") |> PrefixedName
    /// <summary>
    ///   <para>cbo:variance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Any variance to the regular manifestation of a comic issue.</para>
    /// labels<para>variance</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/variance">http://comicmeta.org/cbo/variance</seealso>
    let variance = Prefixed_Name(cbo, "variance") |> PrefixedName
    /// <summary>
    ///   <para>cbo:variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to a variant.</para>
    /// labels<para>variant</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/variant">http://comicmeta.org/cbo/variant</seealso>
    let variant = Prefixed_Name(cbo, "variant") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Panel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A visual frame containing part of a sequence.</para>
    /// labels<para>Panel</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Panel">http://comicmeta.org/cbo/Panel</seealso>
    let Panel = Prefixed_Name(cbo, "Panel") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A paper stock on which a comic is printed.</para>
    /// labels<para>Paper</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Paper">http://comicmeta.org/cbo/Paper</seealso>
    let Paper = Prefixed_Name(cbo, "Paper") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Planet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A planetary body in a comic universe.</para>
    /// labels<para>Planet</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Planet">http://comicmeta.org/cbo/Planet</seealso>
    let Planet = Prefixed_Name(cbo, "Planet") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Plastic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plastic of which a supply item is composed.</para>
    /// labels<para>Plastic</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Plastic">http://comicmeta.org/cbo/Plastic</seealso>
    let Plastic = Prefixed_Name(cbo, "Plastic") |> PrefixedName
    /// <summary>
    ///   <para>cbo:variantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to the issue it is a variant of.</para>
    /// labels<para>variant of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/variantOf">http://comicmeta.org/cbo/variantOf</seealso>
    let variantOf = Prefixed_Name(cbo, "variantOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a series to a comic volume.</para>
    /// labels<para>volume</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/volume">http://comicmeta.org/cbo/volume</seealso>
    let volume = Prefixed_Name(cbo, "volume") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Pedigree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An exceptional original owner collection of high quality, vintage comic books often containing copies that are considered exemplars of key issues.</para>
    /// labels<para>Pedigree</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Pedigree">http://comicmeta.org/cbo/Pedigree</seealso>
    let Pedigree = Prefixed_Name(cbo, "Pedigree") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A distinctive quality belonging to an object.</para>
    /// labels<para>Quality</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Quality">http://comicmeta.org/cbo/Quality</seealso>
    let Quality = Prefixed_Name(cbo, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A creative role in the production of a comic work.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Role">http://comicmeta.org/cbo/Role</seealso>
    let Role = Prefixed_Name(cbo, "Role") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comic publication containing one or more volumes and issues.</para>
    /// labels<para>Series</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Series">http://comicmeta.org/cbo/Series</seealso>
    let Series = Prefixed_Name(cbo, "Series") |> PrefixedName
    /// <summary>
    ///   <para>cbo:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical state describing an object.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/State">http://comicmeta.org/cbo/State</seealso>
    let State = Prefixed_Name(cbo, "State") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single issue or group of issues published in a comic series.</para>
    /// labels<para>Volume</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Volume">http://comicmeta.org/cbo/Volume</seealso>
    let Volume = Prefixed_Name(cbo, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>cbo:adaptationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a work to the comic work it is an adaptation of.</para>
    /// labels<para>adaptation of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/adaptationOf">http://comicmeta.org/cbo/adaptationOf</seealso>
    let adaptationOf = Prefixed_Name(cbo, "adaptationOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:appearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the appearance of a comic universe element within a comic work.</para>
    /// labels<para>appearance</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/appearance">http://comicmeta.org/cbo/appearance</seealso>
    let appearance = Prefixed_Name(cbo, "appearance") |> PrefixedName
    /// <summary>
    ///   <para>cbo:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an artist with a comic work.</para>
    /// labels<para>artist</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/artist">http://comicmeta.org/cbo/artist</seealso>
    let artist = Prefixed_Name(cbo, "artist") |> PrefixedName
    /// <summary>
    ///   <para>cbo:artworkOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links orginal comic artwork to a page.</para>
    /// labels<para>artwork of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/artworkOf">http://comicmeta.org/cbo/artworkOf</seealso>
    let artworkOf = Prefixed_Name(cbo, "artworkOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:artworkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the artwork type of one or more pages of comic art.</para>
    /// labels<para>artwork type</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/artworkType">http://comicmeta.org/cbo/artworkType</seealso>
    let artworkType = Prefixed_Name(cbo, "artworkType") |> PrefixedName
    /// <summary>
    ///   <para>cbo:attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes a physical attribute of a comic item.</para>
    /// labels<para>attribute</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/attribute">http://comicmeta.org/cbo/attribute</seealso>
    let attribute = Prefixed_Name(cbo, "attribute") |> PrefixedName
    /// <summary>
    ///   <para>cbo:balloon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a panel to a word balloon.</para>
    /// labels<para>balloon</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/balloon">http://comicmeta.org/cbo/balloon</seealso>
    let balloon = Prefixed_Name(cbo, "balloon") |> PrefixedName
    /// <summary>
    ///   <para>cbo:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the material of which a physical item is composed.</para>
    /// labels<para>material</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/material">http://comicmeta.org/cbo/material</seealso>
    let material = Prefixed_Name(cbo, "material") |> PrefixedName
    /// <summary>
    ///   <para>cbo:boarded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the backing board of a comic.</para>
    /// labels<para>boarded</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/boarded">http://comicmeta.org/cbo/boarded</seealso>
    let boarded = Prefixed_Name(cbo, "boarded") |> PrefixedName
    /// <summary>
    ///   <para>cbo:box</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a box with a comic book collection.</para>
    /// labels<para>box</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/box">http://comicmeta.org/cbo/box</seealso>
    let box = Prefixed_Name(cbo, "box") |> PrefixedName
    /// <summary>
    ///   <para>cbo:character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the appearance of a comic character in a comic work.</para>
    /// labels<para>character</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/character">http://comicmeta.org/cbo/character</seealso>
    let character = Prefixed_Name(cbo, "character") |> PrefixedName
    /// <summary>
    ///   <para>cbo:caption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a panel to a caption.</para>
    /// labels<para>caption</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/caption">http://comicmeta.org/cbo/caption</seealso>
    let caption = Prefixed_Name(cbo, "caption") |> PrefixedName
    /// <summary>
    ///   <para>cbo:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://comicmeta.org/cbo/category">http://comicmeta.org/cbo/category</seealso>
    let category = Prefixed_Name(cbo, "category") |> PrefixedName
    /// <summary>
    ///   <para>cbo:cca</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comics Code Authority (CCA) approved.</para>
    /// labels<para>CCA</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/cca">http://comicmeta.org/cbo/cca</seealso>
    let cca = Prefixed_Name(cbo, "cca") |> PrefixedName
    /// <summary>
    ///   <para>cbo:certNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The certificate number assigned to a graded copy of a comic by a guarantor.</para>
    /// labels<para>certificate number</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/certNumber">http://comicmeta.org/cbo/certNumber</seealso>
    let certNumber = Prefixed_Name(cbo, "certNumber") |> PrefixedName
    /// <summary>
    ///   <para>cbo:collectedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic work to another work that reprints it as part of a comprehensive collection of reprinted material.</para>
    /// labels<para>collected in</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/collectedIn">http://comicmeta.org/cbo/collectedIn</seealso>
    let collectedIn = Prefixed_Name(cbo, "collectedIn") |> PrefixedName
    /// <summary>
    ///   <para>cbo:collects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to another work that reprints it as part of a comprehensive collection of reprinted material.</para>
    /// labels<para>collects</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/collects">http://comicmeta.org/cbo/collects</seealso>
    let collects = Prefixed_Name(cbo, "collects") |> PrefixedName
    /// <summary>
    ///   <para>cbo:collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a collector to a collection.</para>
    /// labels<para>collection</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/collection">http://comicmeta.org/cbo/collection</seealso>
    let collection = Prefixed_Name(cbo, "collection") |> PrefixedName
    /// <summary>
    ///   <para>cbo:reprints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic to the original work it reprints.</para>
    /// labels<para>reprints</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/reprints">http://comicmeta.org/cbo/reprints</seealso>
    let reprints = Prefixed_Name(cbo, "reprints") |> PrefixedName
    /// <summary>
    ///   <para>cbo:colorist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a colorist with a comic work.</para>
    /// labels<para>colorist</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/colorist">http://comicmeta.org/cbo/colorist</seealso>
    let colorist = Prefixed_Name(cbo, "colorist") |> PrefixedName
    /// <summary>
    ///   <para>cbo:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the physical condition of a comic item.</para>
    /// labels<para>condition</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/condition">http://comicmeta.org/cbo/condition</seealso>
    let condition = Prefixed_Name(cbo, "condition") |> PrefixedName
    /// <summary>
    ///   <para>cbo:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the contents of a box of comics.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/contains">http://comicmeta.org/cbo/contains</seealso>
    let contains = Prefixed_Name(cbo, "contains") |> PrefixedName
    /// <summary>
    ///   <para>cbo:copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to a specific copy.</para>
    /// labels<para>copy</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/copy">http://comicmeta.org/cbo/copy</seealso>
    let copy = Prefixed_Name(cbo, "copy") |> PrefixedName
    /// <summary>
    ///   <para>cbo:copyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a specific copy to a comic issue.</para>
    /// labels<para>copy of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/copyOf">http://comicmeta.org/cbo/copyOf</seealso>
    let copyOf = Prefixed_Name(cbo, "copyOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:copyrightDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The copyright date of a comic issue.</para>
    /// labels<para>copyright date</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/copyrightDate">http://comicmeta.org/cbo/copyrightDate</seealso>
    let copyrightDate = Prefixed_Name(cbo, "copyrightDate") |> PrefixedName
    /// <summary>
    ///   <para>cbo:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic series to its country of origin.</para>
    /// labels<para>country</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/country">http://comicmeta.org/cbo/country</seealso>
    let country = Prefixed_Name(cbo, "country") |> PrefixedName
    /// <summary>
    ///   <para>cbo:coverArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an artist with cover artwork for a comic.</para>
    /// labels<para>cover artist</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/coverArtist">http://comicmeta.org/cbo/coverArtist</seealso>
    let coverArtist = Prefixed_Name(cbo, "coverArtist") |> PrefixedName
    /// <summary>
    ///   <para>cbo:coverDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The cover date of a comic issue.</para>
    /// labels<para>cover date</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/coverDate">http://comicmeta.org/cbo/coverDate</seealso>
    let coverDate = Prefixed_Name(cbo, "coverDate") |> PrefixedName
    /// <summary>
    ///   <para>cbo:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A general price.</para>
    /// labels<para>price</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/price">http://comicmeta.org/cbo/price</seealso>
    let price = Prefixed_Name(cbo, "price") |> PrefixedName
    /// <summary>
    ///   <para>cbo:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a creator with a comic work.</para>
    /// labels<para>creator</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/creator">http://comicmeta.org/cbo/creator</seealso>
    let creator = Prefixed_Name(cbo, "creator") |> PrefixedName
    /// <summary>
    ///   <para>cbo:diamondCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A Diamond Comic Distributors code.</para>
    /// labels<para>Diamond code</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/diamondCode">http://comicmeta.org/cbo/diamondCode</seealso>
    let diamondCode = Prefixed_Name(cbo, "diamondCode") |> PrefixedName
    /// <summary>
    ///   <para>cbo:distributorCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The distributor code associated with a comics publication.</para>
    /// labels<para>distributor code</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/distributorCode">http://comicmeta.org/cbo/distributorCode</seealso>
    let distributorCode = Prefixed_Name(cbo, "distributorCode") |> PrefixedName
    /// <summary>
    ///   <para>cbo:distributedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic series to a distributor.</para>
    /// labels<para>distributed by</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/distributedBy">http://comicmeta.org/cbo/distributedBy</seealso>
    let distributedBy = Prefixed_Name(cbo, "distributedBy") |> PrefixedName
    /// <summary>
    ///   <para>cbo:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an editor with a comic work.</para>
    /// labels<para>editor</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/editor">http://comicmeta.org/cbo/editor</seealso>
    let editor = Prefixed_Name(cbo, "editor") |> PrefixedName
    /// <summary>
    ///   <para>cbo:encased</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the case in which a comic is encapsulated.</para>
    /// labels<para>encased</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/encased">http://comicmeta.org/cbo/encased</seealso>
    let encased = Prefixed_Name(cbo, "encased") |> PrefixedName
    /// <summary>
    ///   <para>cbo:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date a comic ended publication.</para>
    /// labels<para>end year</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/endDate">http://comicmeta.org/cbo/endDate</seealso>
    let endDate = Prefixed_Name(cbo, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>cbo:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes a comic universe event depicted in a comic work.</para>
    /// labels<para>event</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/event">http://comicmeta.org/cbo/event</seealso>
    let event_ = Prefixed_Name(cbo, "event") |> PrefixedName
    /// <summary>
    ///   <para>cbo:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the feature or primary focus of a comic work.</para>
    /// labels<para>feature</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/feature">http://comicmeta.org/cbo/feature</seealso>
    let feature = Prefixed_Name(cbo, "feature") |> PrefixedName
    /// <summary>
    ///   <para>cbo:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the format of a comic work.</para>
    /// labels<para>format</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/format">http://comicmeta.org/cbo/format</seealso>
    let format = Prefixed_Name(cbo, "format") |> PrefixedName
    /// <summary>
    ///   <para>cbo:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the genre of a comic work.</para>
    /// labels<para>genre</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/genre">http://comicmeta.org/cbo/genre</seealso>
    let genre = Prefixed_Name(cbo, "genre") |> PrefixedName
    /// <summary>
    ///   <para>cbo:grade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the grade assigned to a comic item by a guarantor.</para>
    /// labels<para>grade</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/grade">http://comicmeta.org/cbo/grade</seealso>
    let grade = Prefixed_Name(cbo, "grade") |> PrefixedName
    /// <summary>
    ///   <para>cbo:guaranteedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a graded copy of a comic issue to a guarantor.</para>
    /// labels<para>guaranteed by</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/guaranteedBy">http://comicmeta.org/cbo/guaranteedBy</seealso>
    let guaranteedBy = Prefixed_Name(cbo, "guaranteedBy") |> PrefixedName
    /// <summary>
    ///   <para>cbo:imprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a comic publisher with an imprint.</para>
    /// labels<para>imprint</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/imprint">http://comicmeta.org/cbo/imprint</seealso>
    let imprint = Prefixed_Name(cbo, "imprint") |> PrefixedName
    /// <summary>
    ///   <para>cbo:inBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic item to a box.</para>
    /// labels<para>in box</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/inBox">http://comicmeta.org/cbo/inBox</seealso>
    let inBox = Prefixed_Name(cbo, "inBox") |> PrefixedName
    /// <summary>
    ///   <para>cbo:indiciaFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The publication frequency of a comic as printed in the indicia of an issue.</para>
    /// labels<para>indicia frequency</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/indiciaFrequency">http://comicmeta.org/cbo/indiciaFrequency</seealso>
    let indiciaFrequency = Prefixed_Name(cbo, "indiciaFrequency") |> PrefixedName
    /// <summary>
    ///   <para>cbo:indiciaPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The publisher name as printed in the indicia of a comic issue.</para>
    /// labels<para>indicia publisher</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/indiciaPublisher">http://comicmeta.org/cbo/indiciaPublisher</seealso>
    let indiciaPublisher = Prefixed_Name(cbo, "indiciaPublisher") |> PrefixedName
    /// <summary>
    ///   <para>cbo:inker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an inker with a comic work.</para>
    /// labels<para>inker</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/inker">http://comicmeta.org/cbo/inker</seealso>
    let inker = Prefixed_Name(cbo, "inker") |> PrefixedName
    /// <summary>
    ///   <para>cbo:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ISBN of a comic publication.</para>
    /// labels<para>ISBN</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/isbn">http://comicmeta.org/cbo/isbn</seealso>
    let isbn = Prefixed_Name(cbo, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>cbo:issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a volume of comics to an issue.</para>
    /// labels<para>issue</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/issue">http://comicmeta.org/cbo/issue</seealso>
    let issue = Prefixed_Name(cbo, "issue") |> PrefixedName
    /// <summary>
    ///   <para>cbo:issueCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of issues in a volume of comics.</para>
    /// labels<para>issue count</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/issueCount">http://comicmeta.org/cbo/issueCount</seealso>
    let issueCount = Prefixed_Name(cbo, "issueCount") |> PrefixedName
    /// <summary>
    ///   <para>cbo:issueNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of a comic issue.</para>
    /// labels<para>issueNumber</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/issueNumber">http://comicmeta.org/cbo/issueNumber</seealso>
    let issueNumber = Prefixed_Name(cbo, "issueNumber") |> PrefixedName
    /// <summary>
    ///   <para>cbo:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic book collection to an item.</para>
    /// labels<para>item</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/item">http://comicmeta.org/cbo/item</seealso>
    let item = Prefixed_Name(cbo, "item") |> PrefixedName
    /// <summary>
    ///   <para>cbo:itemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An unique identifier assigned to a comic item.</para>
    /// labels<para>item number</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/itemNumber">http://comicmeta.org/cbo/itemNumber</seealso>
    let itemNumber = Prefixed_Name(cbo, "itemNumber") |> PrefixedName
    /// <summary>
    ///   <para>cbo:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Decribes the language of a comic series.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/language">http://comicmeta.org/cbo/language</seealso>
    let language = Prefixed_Name(cbo, "language") |> PrefixedName
    /// <summary>
    ///   <para>cbo:letterer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a letterer with a comic work.</para>
    /// labels<para>letterer</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/letterer">http://comicmeta.org/cbo/letterer</seealso>
    let letterer = Prefixed_Name(cbo, "letterer") |> PrefixedName
    /// <summary>
    ///   <para>cbo:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The level of description associated with a term.</para>
    /// labels<para>level</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/level">http://comicmeta.org/cbo/level</seealso>
    let level = Prefixed_Name(cbo, "level") |> PrefixedName
    /// <summary>
    ///   <para>cbo:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A note.</para>
    /// labels<para>note</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/note">http://comicmeta.org/cbo/note</seealso>
    let note = Prefixed_Name(cbo, "note") |> PrefixedName
    /// <summary>
    ///   <para>cbo:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the appearance of a comic object in a comic work.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/object">http://comicmeta.org/cbo/object</seealso>
    let object = Prefixed_Name(cbo, "object") |> PrefixedName
    /// <summary>
    ///   <para>cbo:onSaleDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of availability of a comic issue.</para>
    /// labels<para>on-sale date</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/onSaleDate">http://comicmeta.org/cbo/onSaleDate</seealso>
    let onSaleDate = Prefixed_Name(cbo, "onSaleDate") |> PrefixedName
    /// <summary>
    ///   <para>cbo:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an item or collection to the agent that owns it.</para>
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/owner">http://comicmeta.org/cbo/owner</seealso>
    let owner = Prefixed_Name(cbo, "owner") |> PrefixedName
    /// <summary>
    ///   <para>cbo:ownerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an agent to an owned item or collection.</para>
    /// labels<para>owner of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/ownerOf">http://comicmeta.org/cbo/ownerOf</seealso>
    let ownerOf = Prefixed_Name(cbo, "ownerOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:pageCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of pages in a comic issue.</para>
    /// labels<para>page count</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/pageCount">http://comicmeta.org/cbo/pageCount</seealso>
    let pageCount = Prefixed_Name(cbo, "pageCount") |> PrefixedName
    /// <summary>
    ///   <para>cbo:pageNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The page number of a comic.</para>
    /// labels<para>page count</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/pageNumber">http://comicmeta.org/cbo/pageNumber</seealso>
    let pageNumber = Prefixed_Name(cbo, "pageNumber") |> PrefixedName
    /// <summary>
    ///   <para>cbo:pageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the type of one or more comic pages.</para>
    /// labels<para>page type</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/pageType">http://comicmeta.org/cbo/pageType</seealso>
    let pageType = Prefixed_Name(cbo, "pageType") |> PrefixedName
    /// <summary>
    ///   <para>cbo:panel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sequence to a comic panel.</para>
    /// labels<para>panel</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/panel">http://comicmeta.org/cbo/panel</seealso>
    let panel = Prefixed_Name(cbo, "panel") |> PrefixedName
    /// <summary>
    ///   <para>cbo:paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the paper stock of a comic issue.</para>
    /// labels<para>paper</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/paper">http://comicmeta.org/cbo/paper</seealso>
    let paper = Prefixed_Name(cbo, "paper") |> PrefixedName
    /// <summary>
    ///   <para>cbo:plotter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a plotter with a comic work.</para>
    /// labels<para>plotter</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/plotter">http://comicmeta.org/cbo/plotter</seealso>
    let plotter = Prefixed_Name(cbo, "plotter") |> PrefixedName
    /// <summary>
    ///   <para>cbo:preview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to a preview or sample of that work.</para>
    /// labels<para>preview</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/preview">http://comicmeta.org/cbo/preview</seealso>
    let preview = Prefixed_Name(cbo, "preview") |> PrefixedName
    /// <summary>
    ///   <para>cbo:printing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The numerical print run of a comic issue.</para>
    /// labels<para>printing</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/printing">http://comicmeta.org/cbo/printing</seealso>
    let printing = Prefixed_Name(cbo, "printing") |> PrefixedName
    /// <summary>
    ///   <para>cbo:publicationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date a comic issue was published.</para>
    /// labels<para>publication date</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/publicationDate">http://comicmeta.org/cbo/publicationDate</seealso>
    let publicationDate = Prefixed_Name(cbo, "publicationDate") |> PrefixedName

    /// <summary>
    ///   <para>cbo:publicationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The publication frequency of a comic.</para>
    /// labels<para>publication frequency</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/publicationFrequency">http://comicmeta.org/cbo/publicationFrequency</seealso>
    let publicationFrequency =
        Prefixed_Name(cbo, "publicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>cbo:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a publisher to a comic publication.</para>
    /// labels<para>publisher</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/publisher">http://comicmeta.org/cbo/publisher</seealso>
    let publisher = Prefixed_Name(cbo, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>cbo:publisherName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a comic publisher.</para>
    /// labels<para>publisher name</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/publisherName">http://comicmeta.org/cbo/publisherName</seealso>
    let publisherName = Prefixed_Name(cbo, "publisherName") |> PrefixedName
    /// <summary>
    ///   <para>cbo:purchasePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The purchase price of a comic item.</para>
    /// labels<para>purchase price</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/purchasePrice">http://comicmeta.org/cbo/purchasePrice</seealso>
    let purchasePrice = Prefixed_Name(cbo, "purchasePrice") |> PrefixedName
    /// <summary>
    ///   <para>cbo:qlabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://comicmeta.org/cbo/qlabel">http://comicmeta.org/cbo/qlabel</seealso>
    let qlabel = Prefixed_Name(cbo, "qlabel") |> PrefixedName
    /// <summary>
    ///   <para>cbo:quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes a distinctive quality of an object.</para>
    /// labels<para>quality</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/quality">http://comicmeta.org/cbo/quality</seealso>
    let quality = Prefixed_Name(cbo, "quality") |> PrefixedName
    /// <summary>
    ///   <para>cbo:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the role of a contributor in the creation of a comic work.</para>
    /// labels<para>role</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/role">http://comicmeta.org/cbo/role</seealso>
    let role = Prefixed_Name(cbo, "role") |> PrefixedName
    /// <summary>
    ///   <para>cbo:salePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sale price of a comic item.</para>
    /// labels<para>sale price</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/salePrice">http://comicmeta.org/cbo/salePrice</seealso>
    let salePrice = Prefixed_Name(cbo, "salePrice") |> PrefixedName
    /// <summary>
    ///   <para>cbo:series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic to a series.</para>
    /// labels<para>series</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/series">http://comicmeta.org/cbo/series</seealso>
    let series = Prefixed_Name(cbo, "series") |> PrefixedName
    /// <summary>
    ///   <para>cbo:seriesOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a series to a comic work.</para>
    /// labels<para>series of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/seriesOf">http://comicmeta.org/cbo/seriesOf</seealso>
    let seriesOf = Prefixed_Name(cbo, "seriesOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:seriesTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of a comic series.</para>
    /// labels<para>series title</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/seriesTitle">http://comicmeta.org/cbo/seriesTitle</seealso>
    let seriesTitle = Prefixed_Name(cbo, "seriesTitle") |> PrefixedName
    /// <summary>
    ///   <para>cbo:seriesYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year a comic series began publication.</para>
    /// labels<para>series year</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/seriesYear">http://comicmeta.org/cbo/seriesYear</seealso>
    let seriesYear = Prefixed_Name(cbo, "seriesYear") |> PrefixedName
    /// <summary>
    ///   <para>cbo:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date a comic began publication.</para>
    /// labels<para>start year</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/startDate">http://comicmeta.org/cbo/startDate</seealso>
    let startDate = Prefixed_Name(cbo, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>cbo:standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A recommended encoding standard or guidelines.</para>
    /// labels<para>standard</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/standard">http://comicmeta.org/cbo/standard</seealso>
    let standard = Prefixed_Name(cbo, "standard") |> PrefixedName
    /// <summary>
    ///   <para>cbo:story</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to a story.</para>
    /// labels<para>story</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/story">http://comicmeta.org/cbo/story</seealso>
    let story = Prefixed_Name(cbo, "story") |> PrefixedName
    /// <summary>
    ///   <para>cbo:storyArc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic story to a story arc.</para>
    /// labels<para>story arc</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/storyArc">http://comicmeta.org/cbo/storyArc</seealso>
    let storyArc = Prefixed_Name(cbo, "storyArc") |> PrefixedName
    /// <summary>
    ///   <para>cbo:storyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an individual story to the story arc it is a part of.</para>
    /// labels<para>has story</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/storyOf">http://comicmeta.org/cbo/storyOf</seealso>
    let storyOf = Prefixed_Name(cbo, "storyOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:storyTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of a comic story.</para>
    /// labels<para>story title</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/storyTitle">http://comicmeta.org/cbo/storyTitle</seealso>
    let storyTitle = Prefixed_Name(cbo, "storyTitle") |> PrefixedName
    /// <summary>
    ///   <para>cbo:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The subject of a comic story.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/subject">http://comicmeta.org/cbo/subject</seealso>
    let subject = Prefixed_Name(cbo, "subject") |> PrefixedName
    /// <summary>
    ///   <para>cbo:synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The synopsis of a comic story.</para>
    /// labels<para>synopsis</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/synopsis">http://comicmeta.org/cbo/synopsis</seealso>
    let synopsis = Prefixed_Name(cbo, "synopsis") |> PrefixedName
    /// <summary>
    ///   <para>cbo:team</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the appearance of a team of comic characters in a comic work.</para>
    /// labels<para>team</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/team">http://comicmeta.org/cbo/team</seealso>
    let team = Prefixed_Name(cbo, "team") |> PrefixedName
    /// <summary>
    ///   <para>cbo:tracking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the tracking or numbering between comic series.</para>
    /// labels<para>tracking</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/tracking">http://comicmeta.org/cbo/tracking</seealso>
    let tracking = Prefixed_Name(cbo, "tracking") |> PrefixedName
    /// <summary>
    ///   <para>cbo:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to a translation.</para>
    /// labels<para>translation</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/translation">http://comicmeta.org/cbo/translation</seealso>
    let translation = Prefixed_Name(cbo, "translation") |> PrefixedName
    /// <summary>
    ///   <para>cbo:translationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a comic issue to the issue it is a translation of.</para>
    /// labels<para>translation of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/translationOf">http://comicmeta.org/cbo/translationOf</seealso>
    let translationOf = Prefixed_Name(cbo, "translationOf") |> PrefixedName
    /// <summary>
    ///   <para>cbo:universe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a thing to a comic universe.</para>
    /// labels<para>universe</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/universe">http://comicmeta.org/cbo/universe</seealso>
    let universe = Prefixed_Name(cbo, "universe") |> PrefixedName
    /// <summary>
    ///   <para>cbo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://comicmeta.org/cbo/">http://comicmeta.org/cbo/</seealso>
    let _prefix_iri = Prefixed_Name(cbo, "") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person, organization, or intelligence in a comic universe.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Agent">http://comicmeta.org/cbo/Agent</seealso>
    let Agent = Prefixed_Name(cbo, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>cbo:Story</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A comic story.</para>
    /// labels<para>Story</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/Story">http://comicmeta.org/cbo/Story</seealso>
    let Story = Prefixed_Name(cbo, "Story") |> PrefixedName
    /// <summary>
    ///   <para>cbo:volumeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a volume to a comic series.</para>
    /// labels<para>volume of</para></remarks>
    /// <seealso href="http://comicmeta.org/cbo/volumeOf">http://comicmeta.org/cbo/volumeOf</seealso>
    let volumeOf = Prefixed_Name(cbo, "volumeOf") |> PrefixedName
