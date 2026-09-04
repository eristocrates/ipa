#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cbo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://comicmeta.org/cbo/" "cbo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A person, organization, or intelligence in a comic universe.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Agent">cbo:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Original comic artwork.</para>
    ///   <para>rdfs:label : Artwork</para>
    ///   <a href="http://comicmeta.org/cbo/Artwork">cbo:Artwork</a>
    /// </summary>
    let Artwork = _prefixId.prefix "Artwork"
    /// <summary>
    ///   <para>rdfs:comment : A word balloon containing dialogue or thought.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://dcl.slis.indiana.edu/cbml/schema/cbml.html#TEI.balloon^^xsd:string</para>
    ///   <para>rdfs:label : Balloon</para>
    ///   <a href="http://comicmeta.org/cbo/Balloon">cbo:Balloon</a>
    /// </summary>
    let Balloon = _prefixId.prefix "Balloon"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A binding method or material used to bind the pages of a comic.</para>
    ///   <para>rdfs:label : Binding</para>
    ///   <a href="http://comicmeta.org/cbo/Binding">cbo:Binding</a>
    /// </summary>
    let Binding = _prefixId.prefix "Binding"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A box that contains comic books.</para>
    ///   <para>rdfs:label : Box</para>
    ///   <a href="http://comicmeta.org/cbo/Box">cbo:Box</a>
    /// </summary>
    let Box = _prefixId.prefix "Box"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : A building in a comic universe.</para>
    ///   <para>rdfs:label : Building</para>
    ///   <a href="http://comicmeta.org/cbo/Building">cbo:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:comment : A caption containing narration.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://dcl.slis.indiana.edu/cbml/schema/cbml.html#TEI.caption^^xsd:string</para>
    ///   <para>rdfs:label : Caption</para>
    ///   <a href="http://comicmeta.org/cbo/Caption">cbo:Caption</a>
    /// </summary>
    let Caption = _prefixId.prefix "Caption"
    /// <summary>
    ///   <para>rdfs:comment : A comic character.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Character</para>
    ///   <a href="http://comicmeta.org/cbo/Character">cbo:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    /// <summary>
    ///   <para>rdfs:comment : A collection of comic books and related resources.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Collection</para>
    ///   <a href="http://comicmeta.org/cbo/Collection">cbo:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:comment : A comic book collector.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Collector</para>
    ///   <a href="http://comicmeta.org/cbo/Collector">cbo:Collector</a>
    /// </summary>
    let Collector = _prefixId.prefix "Collector"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A visual and literary work of sequential art.</para>
    ///   <para>rdfs:label : Comic</para>
    ///   <a href="http://comicmeta.org/cbo/Comic">cbo:Comic</a>
    /// </summary>
    let Comic = _prefixId.prefix "Comic"
    /// <summary>
    ///   <para>rdfs:comment : A period of comic book history.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Comic Age</para>
    ///   <a href="http://comicmeta.org/cbo/ComicAge">cbo:ComicAge</a>
    /// </summary>
    let ComicAge = _prefixId.prefix "ComicAge"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A comic universe.</para>
    ///   <para>rdfs:label : Comic Universe</para>
    ///   <a href="http://comicmeta.org/cbo/ComicUniverse">cbo:ComicUniverse</a>
    /// </summary>
    let ComicUniverse = _prefixId.prefix "ComicUniverse"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A physical condition describing an object.</para>
    ///   <para>rdfs:label : Condition</para>
    ///   <a href="http://comicmeta.org/cbo/Condition">cbo:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An object containing comic books.</para>
    ///   <para>rdfs:label : Container</para>
    ///   <a href="http://comicmeta.org/cbo/Container">cbo:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    /// <summary>
    ///   <para>rdfs:comment : An agent contributing to the creation of a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Contributor</para>
    ///   <a href="http://comicmeta.org/cbo/Contributor">cbo:Contributor</a>
    /// </summary>
    let Contributor = _prefixId.prefix "Contributor"
    /// <summary>
    ///   <para>rdfs:comment : A copy of a comic issue.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Copy</para>
    ///   <a href="http://comicmeta.org/cbo/Copy">cbo:Copy</a>
    /// </summary>
    let Copy = _prefixId.prefix "Copy"
    /// <summary>
    ///   <para>rdfs:comment : A comic character's costume.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Costume</para>
    ///   <a href="http://comicmeta.org/cbo/Costume">cbo:Costume</a>
    /// </summary>
    let Costume = _prefixId.prefix "Costume"
    /// <summary>
    ///   <para>rdfs:comment : An agent primarily responsible for the creation of a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Creator</para>
    ///   <a href="http://comicmeta.org/cbo/Creator">cbo:Creator</a>
    /// </summary>
    let Creator = _prefixId.prefix "Creator"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An agent responsible for the distribution of a comic publication.</para>
    ///   <para>rdfs:label : Distributor^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Distributor">cbo:Distributor</a>
    /// </summary>
    let Distributor = _prefixId.prefix "Distributor"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A document composed of the pages in a comic publication.</para>
    ///   <para>rdfs:label : Document</para>
    ///   <a href="http://comicmeta.org/cbo/Document">cbo:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:comment : An edition of a comic issue.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Edition</para>
    ///   <a href="http://comicmeta.org/cbo/Edition">cbo:Edition</a>
    /// </summary>
    let Edition = _prefixId.prefix "Edition"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An event in a comic universe.</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://comicmeta.org/cbo/Event">cbo:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A format in which a comic is embodied.</para>
    ///   <para>rdfs:label : Format</para>
    ///   <a href="http://comicmeta.org/cbo/Format">cbo:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>rdfs:comment : A frequency with which a comic is published.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <a href="http://comicmeta.org/cbo/Frequency">cbo:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A comics genre.</para>
    ///   <para>rdfs:label : Genre</para>
    ///   <a href="http://comicmeta.org/cbo/Genre">cbo:Genre</a>
    /// </summary>
    let Genre = _prefixId.prefix "Genre"
    /// <summary>
    ///   <para>rdfs:comment : A grade assigned to a comic item that represents a summary of its condition.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Grade</para>
    ///   <a href="http://comicmeta.org/cbo/Grade">cbo:Grade</a>
    /// </summary>
    let Grade = _prefixId.prefix "Grade"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An organization that guarantees the stated condition of a comic book.</para>
    ///   <para>rdfs:label : Guarantor</para>
    ///   <a href="http://comicmeta.org/cbo/Guarantor">cbo:Guarantor</a>
    /// </summary>
    let Guarantor = _prefixId.prefix "Guarantor"
    /// <summary>
    ///   <para>rdfs:comment : An imprint or tradename of a comic publisher.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Imprint</para>
    ///   <a href="http://comicmeta.org/cbo/Imprint">cbo:Imprint</a>
    /// </summary>
    let Imprint = _prefixId.prefix "Imprint"
    /// <summary>
    ///   <para>rdfs:comment : An issue of a comic publication.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Issue</para>
    ///   <a href="http://comicmeta.org/cbo/Issue">cbo:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A physical or digital item.</para>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Item">cbo:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:comment : A physical or digital library containing a collection of comic resources.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Library^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Library">cbo:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A location in a comic universe.</para>
    ///   <para>rdfs:label : Location</para>
    ///   <a href="http://comicmeta.org/cbo/Location">cbo:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A material or medium of which an object is composed.</para>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Material">cbo:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:comment : A physical or digital museum exhibiting a collection of comic resources.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Museum</para>
    ///   <a href="http://comicmeta.org/cbo/Museum">cbo:Museum</a>
    /// </summary>
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>rdfs:comment : An object in a comic universe.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://comicmeta.org/cbo/Object">cbo:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : One or more pages in a comic document.</para>
    ///   <para>rdfs:label : Page</para>
    ///   <a href="http://comicmeta.org/cbo/Page">cbo:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A type of page appearing in a comic document.</para>
    ///   <para>rdfs:label : Page Type</para>
    ///   <a href="http://comicmeta.org/cbo/PageType">cbo:PageType</a>
    /// </summary>
    let PageType = _prefixId.prefix "PageType"
    /// <summary>
    ///   <para>rdfs:comment : A visual frame containing part of a sequence.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://dcl.slis.indiana.edu/cbml/schema/cbml.html#TEI.panel^^xsd:string</para>
    ///   <para>rdfs:label : Panel</para>
    ///   <a href="http://comicmeta.org/cbo/Panel">cbo:Panel</a>
    /// </summary>
    let Panel = _prefixId.prefix "Panel"
    /// <summary>
    ///   <para>rdfs:comment : A paper stock on which a comic is printed.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Paper</para>
    ///   <a href="http://comicmeta.org/cbo/Paper">cbo:Paper</a>
    /// </summary>
    let Paper = _prefixId.prefix "Paper"
    /// <summary>
    ///   <para>rdfs:comment : An exceptional original owner collection of high quality, vintage comic books often containing copies that are considered exemplars of key issues.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Pedigree</para>
    ///   <a href="http://comicmeta.org/cbo/Pedigree">cbo:Pedigree</a>
    /// </summary>
    let Pedigree = _prefixId.prefix "Pedigree"
    /// <summary>
    ///   <para>rdfs:comment : An physical attribute or property of an item.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Attribute</para>
    ///   <a href="http://comicmeta.org/cbo/PhysicalAttribute">cbo:PhysicalAttribute</a>
    /// </summary>
    let PhysicalAttribute = _prefixId.prefix "PhysicalAttribute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A planetary body in a comic universe.</para>
    ///   <para>rdfs:label : Planet</para>
    ///   <a href="http://comicmeta.org/cbo/Planet">cbo:Planet</a>
    /// </summary>
    let Planet = _prefixId.prefix "Planet"
    /// <summary>
    ///   <para>rdfs:comment : A plastic of which a supply item is composed.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Plastic</para>
    ///   <a href="http://comicmeta.org/cbo/Plastic">cbo:Plastic</a>
    /// </summary>
    let Plastic = _prefixId.prefix "Plastic"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A comics publication.</para>
    ///   <para>rdfs:label : Publication</para>
    ///   <a href="http://comicmeta.org/cbo/Publication">cbo:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An agent responsible for the publication of a comic.</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <a href="http://comicmeta.org/cbo/Publisher">cbo:Publisher</a>
    /// </summary>
    let Publisher = _prefixId.prefix "Publisher"
    /// <summary>
    ///   <para>rdfs:comment : A distinctive quality belonging to an object.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Quality^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Quality">cbo:Quality</a>
    /// </summary>
    let Quality = _prefixId.prefix "Quality"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A creative role in the production of a comic work.</para>
    ///   <para>rdfs:label : Role</para>
    ///   <a href="http://comicmeta.org/cbo/Role">cbo:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A visual sequence of juxtaposed panels and pictorial elements.</para>
    ///   <para>rdfs:label : Sequence</para>
    ///   <a href="http://comicmeta.org/cbo/Sequence">cbo:Sequence</a>
    /// </summary>
    let Sequence = _prefixId.prefix "Sequence"
    /// <summary>
    ///   <para>rdfs:comment : A comic publication containing one or more volumes and issues.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Series</para>
    ///   <a href="http://comicmeta.org/cbo/Series">cbo:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A physical state describing an object.</para>
    ///   <para>rdfs:label : State</para>
    ///   <a href="http://comicmeta.org/cbo/State">cbo:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A comic story.</para>
    ///   <para>rdfs:label : Story</para>
    ///   <a href="http://comicmeta.org/cbo/Story">cbo:Story</a>
    /// </summary>
    let Story = _prefixId.prefix "Story"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A group of comic characters.</para>
    ///   <para>rdfs:label : Team^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Team">cbo:Team</a>
    /// </summary>
    let Team = _prefixId.prefix "Team"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A thing in a comic universe.</para>
    ///   <para>rdfs:label : Thing^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Thing">cbo:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A vehicle in a comic universe.^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/Vehicle">cbo:Vehicle</a>
    /// </summary>
    let Vehicle = _prefixId.prefix "Vehicle"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A single issue or group of issues published in a comic series.</para>
    ///   <para>rdfs:label : Volume</para>
    ///   <a href="http://comicmeta.org/cbo/Volume">cbo:Volume</a>
    /// </summary>
    let Volume = _prefixId.prefix "Volume"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic to an adaptation.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : adaptation</para>
    ///   <a href="http://comicmeta.org/cbo/adaptation">cbo:adaptation</a>
    /// </summary>
    let adaptation = _prefixId.prefix "adaptation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a work to the comic work it is an adaptation of.</para>
    ///   <para>rdfs:label : adaptation of</para>
    ///   <a href="http://comicmeta.org/cbo/adaptationOf">cbo:adaptationOf</a>
    /// </summary>
    let adaptationOf = _prefixId.prefix "adaptationOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An alternative title for any comic work.</para>
    ///   <para>rdfs:label : alternative title</para>
    ///   <a href="http://comicmeta.org/cbo/alternativeTitle">cbo:alternativeTitle</a>
    /// </summary>
    let alternativeTitle = _prefixId.prefix "alternativeTitle"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the appearance of a comic universe element within a comic work.</para>
    ///   <para>rdfs:label : appearance</para>
    ///   <a href="http://comicmeta.org/cbo/appearance">cbo:appearance</a>
    /// </summary>
    let appearance = _prefixId.prefix "appearance"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an artist with a comic work.</para>
    ///   <para>rdfs:label : artist</para>
    ///   <a href="http://comicmeta.org/cbo/artist">cbo:artist</a>
    /// </summary>
    let artist = _prefixId.prefix "artist"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic page to its original artwork.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : artwork</para>
    ///   <a href="http://comicmeta.org/cbo/artwork">cbo:artwork</a>
    /// </summary>
    let artwork = _prefixId.prefix "artwork"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links orginal comic artwork to a page.</para>
    ///   <para>rdfs:label : artwork of</para>
    ///   <a href="http://comicmeta.org/cbo/artworkOf">cbo:artworkOf</a>
    /// </summary>
    let artworkOf = _prefixId.prefix "artworkOf"
    /// <summary>
    ///   <para>rdfs:comment : Describes the artwork type of one or more pages of comic art.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : artwork type</para>
    ///   <a href="http://comicmeta.org/cbo/artworkType">cbo:artworkType</a>
    /// </summary>
    let artworkType = _prefixId.prefix "artworkType"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a physical attribute of a comic item.</para>
    ///   <para>rdfs:label : attribute</para>
    ///   <a href="http://comicmeta.org/cbo/attribute">cbo:attribute</a>
    /// </summary>
    let attribute = _prefixId.prefix "attribute"
    /// <summary>
    ///   <para>dce:description : Having this property implies that the comic is bagged.</para>
    ///   <para>rdfs:comment : Describes the bag in which a comic is contained.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : bagged</para>
    ///   <a href="http://comicmeta.org/cbo/bagged">cbo:bagged</a>
    /// </summary>
    let bagged = _prefixId.prefix "bagged"
    /// <summary>
    ///   <para>rdfs:comment : Links a panel to a word balloon.</para>
    ///   <para>rdfs:label : balloon</para>
    ///   <a href="http://comicmeta.org/cbo/balloon">cbo:balloon</a>
    /// </summary>
    let balloon = _prefixId.prefix "balloon"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the binding of a comic issue.</para>
    ///   <para>rdfs:label : binding</para>
    ///   <a href="http://comicmeta.org/cbo/binding">cbo:binding</a>
    /// </summary>
    let binding = _prefixId.prefix "binding"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:description : Having this property implies that the comic is boarded.</para>
    ///   <para>rdfs:comment : Describes the backing board of a comic.</para>
    ///   <para>rdfs:label : boarded</para>
    ///   <a href="http://comicmeta.org/cbo/boarded">cbo:boarded</a>
    /// </summary>
    let boarded = _prefixId.prefix "boarded"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a box with a comic book collection.</para>
    ///   <para>rdfs:label : box</para>
    ///   <a href="http://comicmeta.org/cbo/box">cbo:box</a>
    /// </summary>
    let box = _prefixId.prefix "box"
    /// <summary>
    ///   <para>rdfs:comment : Describes a cameo appearance by a comic character in a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : cameo</para>
    ///   <a href="http://comicmeta.org/cbo/cameo">cbo:cameo</a>
    /// </summary>
    let cameo = _prefixId.prefix "cameo"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a panel to a caption.</para>
    ///   <para>rdfs:label : caption</para>
    ///   <a href="http://comicmeta.org/cbo/caption">cbo:caption</a>
    /// </summary>
    let caption = _prefixId.prefix "caption"
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:comment : Comics Code Authority (CCA) approved.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : CCA^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/cca">cbo:cca</a>
    /// </summary>
    let cca = _prefixId.prefix "cca"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The certificate number assigned to a graded copy of a comic by a guarantor.</para>
    ///   <para>rdfs:label : certificate number</para>
    ///   <a href="http://comicmeta.org/cbo/certNumber">cbo:certNumber</a>
    /// </summary>
    let certNumber = _prefixId.prefix "certNumber"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the appearance of a comic character in a comic work.</para>
    ///   <para>rdfs:label : character</para>
    ///   <a href="http://comicmeta.org/cbo/character">cbo:character</a>
    /// </summary>
    let character = _prefixId.prefix "character"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic work to another work that reprints it as part of a comprehensive collection of reprinted material.</para>
    ///   <para>rdfs:label : collected in</para>
    ///   <a href="http://comicmeta.org/cbo/collectedIn">cbo:collectedIn</a>
    /// </summary>
    let collectedIn = _prefixId.prefix "collectedIn"
    /// <summary>
    ///   <para>rdfs:comment : Links a collector to a collection.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : collection</para>
    ///   <a href="http://comicmeta.org/cbo/collection">cbo:collection</a>
    /// </summary>
    let collection = _prefixId.prefix "collection"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic issue to another work that reprints it as part of a comprehensive collection of reprinted material.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : collects^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/collects">cbo:collects</a>
    /// </summary>
    let collects = _prefixId.prefix "collects"
    /// <summary>
    ///   <para>rdfs:comment : Associates a colorist with a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : colorist</para>
    ///   <a href="http://comicmeta.org/cbo/colorist">cbo:colorist</a>
    /// </summary>
    let colorist = _prefixId.prefix "colorist"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Associates a comic with an era of comic book history.</para>
    ///   <para>rdfs:label : comic age</para>
    ///   <a href="http://comicmeta.org/cbo/comicAge">cbo:comicAge</a>
    /// </summary>
    let comicAge = _prefixId.prefix "comicAge"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the physical condition of a comic item.</para>
    ///   <para>rdfs:label : condition</para>
    ///   <a href="http://comicmeta.org/cbo/condition">cbo:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:comment : Describes the contents of a box of comics.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : contains</para>
    ///   <a href="http://comicmeta.org/cbo/contains">cbo:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:comment : Associates a contributor with a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : contributor</para>
    ///   <a href="http://comicmeta.org/cbo/contributor">cbo:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic issue to a specific copy.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : copy</para>
    ///   <a href="http://comicmeta.org/cbo/copy">cbo:copy</a>
    /// </summary>
    let copy = _prefixId.prefix "copy"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a specific copy to a comic issue.</para>
    ///   <para>rdfs:label : copy of</para>
    ///   <a href="http://comicmeta.org/cbo/copyOf">cbo:copyOf</a>
    /// </summary>
    let copyOf = _prefixId.prefix "copyOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the physical state of a copy of a comic issue.</para>
    ///   <para>rdfs:label : copy state</para>
    ///   <a href="http://comicmeta.org/cbo/copyState">cbo:copyState</a>
    /// </summary>
    let copyState = _prefixId.prefix "copyState"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The copyright date of a comic issue.</para>
    ///   <para>rdfs:label : copyright date</para>
    ///   <a href="http://comicmeta.org/cbo/copyrightDate">cbo:copyrightDate</a>
    /// </summary>
    let copyrightDate = _prefixId.prefix "copyrightDate"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic series to its country of origin.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : country</para>
    ///   <a href="http://comicmeta.org/cbo/country">cbo:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:comment : Describes the cover art of a comic issue.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : cover art</para>
    ///   <a href="http://comicmeta.org/cbo/coverArt">cbo:coverArt</a>
    /// </summary>
    let coverArt = _prefixId.prefix "coverArt"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Associates an artist with cover artwork for a comic.</para>
    ///   <para>rdfs:label : cover artist</para>
    ///   <a href="http://comicmeta.org/cbo/coverArtist">cbo:coverArtist</a>
    /// </summary>
    let coverArtist = _prefixId.prefix "coverArtist"
    /// <summary>
    ///   <para>rdfs:comment : The cover date of a comic issue.</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : cover date</para>
    ///   <a href="http://comicmeta.org/cbo/coverDate">cbo:coverDate</a>
    /// </summary>
    let coverDate = _prefixId.prefix "coverDate"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The cover price of a comic issue.</para>
    ///   <para>rdfs:label : coverPrice</para>
    ///   <a href="http://comicmeta.org/cbo/coverPrice">cbo:coverPrice</a>
    /// </summary>
    let coverPrice = _prefixId.prefix "coverPrice"
    /// <summary>
    ///   <para>rdfs:comment : Associates a creator with a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : creator</para>
    ///   <a href="http://comicmeta.org/cbo/creator">cbo:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:comment : A Diamond Comic Distributors code.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Diamond code</para>
    ///   <a href="http://comicmeta.org/cbo/diamondCode">cbo:diamondCode</a>
    /// </summary>
    let diamondCode = _prefixId.prefix "diamondCode"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic series to a distributor.</para>
    ///   <para>rdfs:label : distributed by</para>
    ///   <a href="http://comicmeta.org/cbo/distributedBy">cbo:distributedBy</a>
    /// </summary>
    let distributedBy = _prefixId.prefix "distributedBy"
    /// <summary>
    ///   <para>rdfs:comment : The distributor code associated with a comics publication.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : distributor code^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/distributorCode">cbo:distributorCode</a>
    /// </summary>
    let distributorCode = _prefixId.prefix "distributorCode"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the edition of a comic issue.</para>
    ///   <para>rdfs:label : edition</para>
    ///   <a href="http://comicmeta.org/cbo/edition">cbo:edition</a>
    /// </summary>
    let edition = _prefixId.prefix "edition"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an editor with a comic work.</para>
    ///   <para>rdfs:label : editor</para>
    ///   <a href="http://comicmeta.org/cbo/editor">cbo:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dce:description : Having this property implies that the comic is encapsulated.</para>
    ///   <para>rdfs:comment : Describes the case in which a comic is encapsulated.</para>
    ///   <para>rdfs:label : encased</para>
    ///   <a href="http://comicmeta.org/cbo/encased">cbo:encased</a>
    /// </summary>
    let encased = _prefixId.prefix "encased"
    /// <summary>
    ///   <para>rdfs:comment : The date a comic ended publication.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : end year</para>
    ///   <a href="http://comicmeta.org/cbo/endDate">cbo:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:comment : Describes a comic universe event depicted in a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : event</para>
    ///   <a href="http://comicmeta.org/cbo/event">cbo:event</a>
    /// </summary>
    let event_ = _prefixId.prefix "event"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Describes the feature or primary focus of a comic work.</para>
    ///   <para>rdfs:label : feature</para>
    ///   <a href="http://comicmeta.org/cbo/feature">cbo:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:comment : Describes the format of a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : format</para>
    ///   <a href="http://comicmeta.org/cbo/format">cbo:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:comment : Describes the genre of a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : genre</para>
    ///   <a href="http://comicmeta.org/cbo/genre">cbo:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>rdfs:comment : Describes the grade assigned to a comic item by a guarantor.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : grade</para>
    ///   <a href="http://comicmeta.org/cbo/grade">cbo:grade</a>
    /// </summary>
    let grade = _prefixId.prefix "grade"
    /// <summary>
    ///   <para>rdfs:comment : Links a graded copy of a comic issue to a guarantor.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : guaranteed by</para>
    ///   <a href="http://comicmeta.org/cbo/guaranteedBy">cbo:guaranteedBy</a>
    /// </summary>
    let guaranteedBy = _prefixId.prefix "guaranteedBy"
    /// <summary>
    ///   <para>rdfs:comment : Associates a comic publisher with an imprint.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : imprint</para>
    ///   <a href="http://comicmeta.org/cbo/imprint">cbo:imprint</a>
    /// </summary>
    let imprint = _prefixId.prefix "imprint"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a comic imprint.</para>
    ///   <para>rdfs:label : imprint name</para>
    ///   <a href="http://comicmeta.org/cbo/imprintName">cbo:imprintName</a>
    /// </summary>
    let imprintName = _prefixId.prefix "imprintName"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an imprint with a comic publisher.</para>
    ///   <para>rdfs:label : imprint of</para>
    ///   <a href="http://comicmeta.org/cbo/imprintOf">cbo:imprintOf</a>
    /// </summary>
    let imprintOf = _prefixId.prefix "imprintOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic item to a box.</para>
    ///   <para>rdfs:label : in box</para>
    ///   <a href="http://comicmeta.org/cbo/inBox">cbo:inBox</a>
    /// </summary>
    let inBox = _prefixId.prefix "inBox"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The publication frequency of a comic as printed in the indicia of an issue.</para>
    ///   <para>rdfs:label : indicia frequency</para>
    ///   <a href="http://comicmeta.org/cbo/indiciaFrequency">cbo:indiciaFrequency</a>
    /// </summary>
    let indiciaFrequency = _prefixId.prefix "indiciaFrequency"
    /// <summary>
    ///   <para>rdfs:comment : The publisher name as printed in the indicia of a comic issue.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : indicia publisher</para>
    ///   <a href="http://comicmeta.org/cbo/indiciaPublisher">cbo:indiciaPublisher</a>
    /// </summary>
    let indiciaPublisher = _prefixId.prefix "indiciaPublisher"
    /// <summary>
    ///   <para>rdfs:comment : Associates an inker with a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : inker</para>
    ///   <a href="http://comicmeta.org/cbo/inker">cbo:inker</a>
    /// </summary>
    let inker = _prefixId.prefix "inker"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The ISBN of a comic publication.</para>
    ///   <para>rdfs:label : ISBN^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/isbn">cbo:isbn</a>
    /// </summary>
    let isbn = _prefixId.prefix "isbn"
    /// <summary>
    ///   <para>rdfs:comment : Links a volume of comics to an issue.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : issue</para>
    ///   <a href="http://comicmeta.org/cbo/issue">cbo:issue</a>
    /// </summary>
    let issue = _prefixId.prefix "issue"
    /// <summary>
    ///   <para>rdfs:comment : The total number of issues in a volume of comics.</para>
    ///   <para>rdfs:label : issue count</para>
    ///   <a href="http://comicmeta.org/cbo/issueCount">cbo:issueCount</a>
    /// </summary>
    let issueCount = _prefixId.prefix "issueCount"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The number of a comic issue.</para>
    ///   <para>rdfs:label : issueNumber</para>
    ///   <a href="http://comicmeta.org/cbo/issueNumber">cbo:issueNumber</a>
    /// </summary>
    let issueNumber = _prefixId.prefix "issueNumber"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic book collection to an item.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : item</para>
    ///   <a href="http://comicmeta.org/cbo/item">cbo:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : An unique identifier assigned to a comic item.</para>
    ///   <para>rdfs:label : item number</para>
    ///   <a href="http://comicmeta.org/cbo/itemNumber">cbo:itemNumber</a>
    /// </summary>
    let itemNumber = _prefixId.prefix "itemNumber"
    /// <summary>
    ///   <para>rdfs:comment : Links an item to a comic book collection.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : item of</para>
    ///   <a href="http://comicmeta.org/cbo/itemOf">cbo:itemOf</a>
    /// </summary>
    let itemOf = _prefixId.prefix "itemOf"
    /// <summary>
    ///   <para>rdfs:comment : Decribes the language of a comic series.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : language</para>
    ///   <a href="http://comicmeta.org/cbo/language">cbo:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : Associates a letterer with a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : letterer</para>
    ///   <a href="http://comicmeta.org/cbo/letterer">cbo:letterer</a>
    /// </summary>
    let letterer = _prefixId.prefix "letterer"
    /// <summary>
    ///   <para>rdfs:comment : The level of description associated with a term.</para>
    ///   <para>rdfs:label : level</para>
    ///   <a href="http://comicmeta.org/cbo/level">cbo:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>rdfs:comment : Describes the material of which a physical item is composed.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : material</para>
    ///   <a href="http://comicmeta.org/cbo/material">cbo:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A note.</para>
    ///   <para>rdfs:label : note^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/note">cbo:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the appearance of a comic object in a comic work.</para>
    ///   <para>rdfs:label : object</para>
    ///   <a href="http://comicmeta.org/cbo/object">cbo:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : The date of availability of a comic issue.</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : on-sale date</para>
    ///   <a href="http://comicmeta.org/cbo/onSaleDate">cbo:onSaleDate</a>
    /// </summary>
    let onSaleDate = _prefixId.prefix "onSaleDate"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links an item or collection to the agent that owns it.</para>
    ///   <para>rdfs:label : owner</para>
    ///   <a href="http://comicmeta.org/cbo/owner">cbo:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:comment : Links an agent to an owned item or collection.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : owner of</para>
    ///   <a href="http://comicmeta.org/cbo/ownerOf">cbo:ownerOf</a>
    /// </summary>
    let ownerOf = _prefixId.prefix "ownerOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic page to a document.</para>
    ///   <para>rdfs:label : page</para>
    ///   <a href="http://comicmeta.org/cbo/page">cbo:page</a>
    /// </summary>
    let page = _prefixId.prefix "page"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The number of pages in a comic issue.</para>
    ///   <para>rdfs:label : page count</para>
    ///   <a href="http://comicmeta.org/cbo/pageCount">cbo:pageCount</a>
    /// </summary>
    let pageCount = _prefixId.prefix "pageCount"
    /// <summary>
    ///   <para>rdfs:comment : The page number of a comic.</para>
    ///   <para>rdfs:label : page count</para>
    ///   <a href="http://comicmeta.org/cbo/pageNumber">cbo:pageNumber</a>
    /// </summary>
    let pageNumber = _prefixId.prefix "pageNumber"
    /// <summary>
    ///   <para>rdfs:comment : Describes the type of one or more comic pages.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : page type</para>
    ///   <a href="http://comicmeta.org/cbo/pageType">cbo:pageType</a>
    /// </summary>
    let pageType = _prefixId.prefix "pageType"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sequence to a comic panel.</para>
    ///   <para>rdfs:label : panel</para>
    ///   <a href="http://comicmeta.org/cbo/panel">cbo:panel</a>
    /// </summary>
    let panel = _prefixId.prefix "panel"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the paper stock of a comic issue.</para>
    ///   <para>rdfs:label : paper</para>
    ///   <a href="http://comicmeta.org/cbo/paper">cbo:paper</a>
    /// </summary>
    let paper = _prefixId.prefix "paper"
    /// <summary>
    ///   <para>rdfs:comment : Associates a penciller with a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : penciller</para>
    ///   <a href="http://comicmeta.org/cbo/penciller">cbo:penciller</a>
    /// </summary>
    let penciller = _prefixId.prefix "penciller"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a plotter with a comic work.</para>
    ///   <para>rdfs:label : plotter</para>
    ///   <a href="http://comicmeta.org/cbo/plotter">cbo:plotter</a>
    /// </summary>
    let plotter = _prefixId.prefix "plotter"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic issue to a preview or sample of that work.</para>
    ///   <para>rdfs:label : preview</para>
    ///   <a href="http://comicmeta.org/cbo/preview">cbo:preview</a>
    /// </summary>
    let preview = _prefixId.prefix "preview"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A general price.</para>
    ///   <para>rdfs:label : price</para>
    ///   <a href="http://comicmeta.org/cbo/price">cbo:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The numerical print run of a comic issue.</para>
    ///   <para>rdfs:label : printing</para>
    ///   <a href="http://comicmeta.org/cbo/printing">cbo:printing</a>
    /// </summary>
    let printing = _prefixId.prefix "printing"
    /// <summary>
    ///   <para>rdfs:comment : The date a comic issue was published.</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : publication date</para>
    ///   <a href="http://comicmeta.org/cbo/publicationDate">cbo:publicationDate</a>
    /// </summary>
    let publicationDate = _prefixId.prefix "publicationDate"
    /// <summary>
    ///   <para>rdfs:comment : The publication frequency of a comic.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : publication frequency</para>
    ///   <a href="http://comicmeta.org/cbo/publicationFrequency">cbo:publicationFrequency</a>
    /// </summary>
    let publicationFrequency = _prefixId.prefix "publicationFrequency"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a publisher to a comic publication.</para>
    ///   <para>rdfs:label : publisher</para>
    ///   <a href="http://comicmeta.org/cbo/publisher">cbo:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a comic publisher.</para>
    ///   <para>rdfs:label : publisher name</para>
    ///   <a href="http://comicmeta.org/cbo/publisherName">cbo:publisherName</a>
    /// </summary>
    let publisherName = _prefixId.prefix "publisherName"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The purchase price of a comic item.</para>
    ///   <para>rdfs:label : purchase price</para>
    ///   <a href="http://comicmeta.org/cbo/purchasePrice">cbo:purchasePrice</a>
    /// </summary>
    let purchasePrice = _prefixId.prefix "purchasePrice"
    let qlabel = _prefixId.prefix "qlabel"
    /// <summary>
    ///   <para>rdfs:comment : Describes a distinctive quality of an object.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : quality</para>
    ///   <a href="http://comicmeta.org/cbo/quality">cbo:quality</a>
    /// </summary>
    let quality = _prefixId.prefix "quality"
    /// <summary>
    ///   <para>rdfs:comment : The rating of a comics publication.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : rating</para>
    ///   <a href="http://comicmeta.org/cbo/rating">cbo:rating</a>
    /// </summary>
    let rating = _prefixId.prefix "rating"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic to a related object.</para>
    ///   <para>rdfs:label : related^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/related">cbo:related</a>
    /// </summary>
    let related = _prefixId.prefix "related"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic issue to a work that reprints it.</para>
    ///   <para>rdfs:label : reprinted in</para>
    ///   <a href="http://comicmeta.org/cbo/reprintedIn">cbo:reprintedIn</a>
    /// </summary>
    let reprintedIn = _prefixId.prefix "reprintedIn"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic to the original work it reprints.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : reprints</para>
    ///   <a href="http://comicmeta.org/cbo/reprints">cbo:reprints</a>
    /// </summary>
    let reprints = _prefixId.prefix "reprints"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the role of a contributor in the creation of a comic work.</para>
    ///   <para>rdfs:label : role</para>
    ///   <a href="http://comicmeta.org/cbo/role">cbo:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The sale price of a comic item.</para>
    ///   <para>rdfs:label : sale price</para>
    ///   <a href="http://comicmeta.org/cbo/salePrice">cbo:salePrice</a>
    /// </summary>
    let salePrice = _prefixId.prefix "salePrice"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sequence to a page.</para>
    ///   <para>rdfs:label : sequence</para>
    ///   <a href="http://comicmeta.org/cbo/sequence">cbo:sequence</a>
    /// </summary>
    let sequence = _prefixId.prefix "sequence"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic to a series.</para>
    ///   <para>rdfs:label : series</para>
    ///   <a href="http://comicmeta.org/cbo/series">cbo:series</a>
    /// </summary>
    let series = _prefixId.prefix "series"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a series to a comic work.</para>
    ///   <para>rdfs:label : series of</para>
    ///   <a href="http://comicmeta.org/cbo/seriesOf">cbo:seriesOf</a>
    /// </summary>
    let seriesOf = _prefixId.prefix "seriesOf"
    /// <summary>
    ///   <para>rdfs:comment : The title of a comic series.</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : series title</para>
    ///   <a href="http://comicmeta.org/cbo/seriesTitle">cbo:seriesTitle</a>
    /// </summary>
    let seriesTitle = _prefixId.prefix "seriesTitle"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The year a comic series began publication.</para>
    ///   <para>rdfs:label : series year^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/seriesYear">cbo:seriesYear</a>
    /// </summary>
    let seriesYear = _prefixId.prefix "seriesYear"
    /// <summary>
    ///   <para>rdfs:comment : A recommended encoding standard or guidelines.</para>
    ///   <para>rdfs:label : standard</para>
    ///   <a href="http://comicmeta.org/cbo/standard">cbo:standard</a>
    /// </summary>
    let standard = _prefixId.prefix "standard"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The date a comic began publication.</para>
    ///   <para>rdfs:label : start year</para>
    ///   <a href="http://comicmeta.org/cbo/startDate">cbo:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the physical state of a comic item.</para>
    ///   <para>rdfs:label : state</para>
    ///   <a href="http://comicmeta.org/cbo/state">cbo:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic issue to a story.</para>
    ///   <para>rdfs:label : story</para>
    ///   <a href="http://comicmeta.org/cbo/story">cbo:story</a>
    /// </summary>
    let story = _prefixId.prefix "story"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic story to a story arc.</para>
    ///   <para>rdfs:label : story arc^^xsd:string</para>
    ///   <a href="http://comicmeta.org/cbo/storyArc">cbo:storyArc</a>
    /// </summary>
    let storyArc = _prefixId.prefix "storyArc"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Connects an individual story to the story arc it is a part of.</para>
    ///   <para>rdfs:label : has story</para>
    ///   <a href="http://comicmeta.org/cbo/storyOf">cbo:storyOf</a>
    /// </summary>
    let storyOf = _prefixId.prefix "storyOf"
    /// <summary>
    ///   <para>rdfs:comment : The title of a comic story.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : story title</para>
    ///   <a href="http://comicmeta.org/cbo/storyTitle">cbo:storyTitle</a>
    /// </summary>
    let storyTitle = _prefixId.prefix "storyTitle"
    /// <summary>
    ///   <para>rdfs:comment : The subject of a comic story.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://comicmeta.org/cbo/subject">cbo:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : The synopsis of a comic story.</para>
    ///   <para>rdfs:label : synopsis</para>
    ///   <a href="http://comicmeta.org/cbo/synopsis">cbo:synopsis</a>
    /// </summary>
    let synopsis = _prefixId.prefix "synopsis"
    /// <summary>
    ///   <para>rdfs:comment : Describes the appearance of a team of comic characters in a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : team</para>
    ///   <a href="http://comicmeta.org/cbo/team">cbo:team</a>
    /// </summary>
    let team = _prefixId.prefix "team"
    /// <summary>
    ///   <para>rdfs:comment : Describes the tracking or numbering between comic series.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : tracking</para>
    ///   <a href="http://comicmeta.org/cbo/tracking">cbo:tracking</a>
    /// </summary>
    let tracking = _prefixId.prefix "tracking"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic issue to a translation.</para>
    ///   <para>rdfs:label : translation</para>
    ///   <a href="http://comicmeta.org/cbo/translation">cbo:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>rdfs:comment : Links a comic issue to the issue it is a translation of.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : translation of</para>
    ///   <a href="http://comicmeta.org/cbo/translationOf">cbo:translationOf</a>
    /// </summary>
    let translationOf = _prefixId.prefix "translationOf"
    /// <summary>
    ///   <para>rdfs:comment : Links a thing to a comic universe.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : universe</para>
    ///   <a href="http://comicmeta.org/cbo/universe">cbo:universe</a>
    /// </summary>
    let universe = _prefixId.prefix "universe"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Links a comic universe to the universe from which it originates.</para>
    ///   <para>rdfs:label : universe of</para>
    ///   <a href="http://comicmeta.org/cbo/universeOf">cbo:universeOf</a>
    /// </summary>
    let universeOf = _prefixId.prefix "universeOf"
    /// <summary>
    ///   <para>rdfs:comment : The UPC of a comic publication.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : UPC</para>
    ///   <a href="http://comicmeta.org/cbo/upc">cbo:upc</a>
    /// </summary>
    let upc = _prefixId.prefix "upc"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The estimated value of a comic item.</para>
    ///   <para>rdfs:label : value</para>
    ///   <a href="http://comicmeta.org/cbo/value">cbo:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Any variance to the regular manifestation of a comic issue.</para>
    ///   <para>rdfs:label : variance</para>
    ///   <a href="http://comicmeta.org/cbo/variance">cbo:variance</a>
    /// </summary>
    let variance = _prefixId.prefix "variance"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Links a comic issue to a variant.</para>
    ///   <para>rdfs:label : variant</para>
    ///   <a href="http://comicmeta.org/cbo/variant">cbo:variant</a>
    /// </summary>
    let variant = _prefixId.prefix "variant"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a comic issue to the issue it is a variant of.</para>
    ///   <para>rdfs:label : variant of</para>
    ///   <a href="http://comicmeta.org/cbo/variantOf">cbo:variantOf</a>
    /// </summary>
    let variantOf = _prefixId.prefix "variantOf"
    /// <summary>
    ///   <para>rdfs:comment : Links a series to a comic volume.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : volume</para>
    ///   <a href="http://comicmeta.org/cbo/volume">cbo:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The unique identifier of a comic volume.</para>
    ///   <para>rdfs:label : volumeNumber</para>
    ///   <a href="http://comicmeta.org/cbo/volumeNumber">cbo:volumeNumber</a>
    /// </summary>
    let volumeNumber = _prefixId.prefix "volumeNumber"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a volume to a comic series.</para>
    ///   <para>rdfs:label : volume of</para>
    ///   <a href="http://comicmeta.org/cbo/volumeOf">cbo:volumeOf</a>
    /// </summary>
    let volumeOf = _prefixId.prefix "volumeOf"
    /// <summary>
    ///   <para>rdfs:comment : Associates a writer with a comic work.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : writer</para>
    ///   <a href="http://comicmeta.org/cbo/writer">cbo:writer</a>
    /// </summary>
    let writer = _prefixId.prefix "writer"
