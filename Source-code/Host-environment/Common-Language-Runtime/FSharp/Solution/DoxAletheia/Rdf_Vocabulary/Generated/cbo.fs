namespace http.comicmeta.org.cbo.slash

open DoxAletheia.Rdf_Vocabulary

module cbo =
    let _namespace_name = "http://comicmeta.org/cbo/"
    /// <summary>
    /// A person, organization, or intelligence in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// A thing in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName
    /// <summary>
    /// Original comic artwork.
    /// <see href="http://comicmeta.org/cbo/Artwork"></see></summary>
    let Artwork = Namespaced_IRI.parse _namespace_name "Artwork" |> NamespacedName
    /// <summary>
    /// A physical or digital item.
    /// <see href="http://comicmeta.org/cbo/Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// A word balloon containing dialogue or thought.
    /// <see href="http://comicmeta.org/cbo/Balloon"></see></summary>
    let Balloon = Namespaced_IRI.parse _namespace_name "Balloon" |> NamespacedName
    /// <summary>
    /// A visual sequence of juxtaposed panels and pictorial elements.
    /// <see href="http://comicmeta.org/cbo/Sequence"></see></summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName
    /// <summary>
    /// A binding method or material used to bind the pages of a comic.
    /// <see href="http://comicmeta.org/cbo/Binding"></see></summary>
    let Binding = Namespaced_IRI.parse _namespace_name "Binding" |> NamespacedName
    /// <summary>
    /// A material or medium of which an object is composed.
    /// <see href="http://comicmeta.org/cbo/Material"></see></summary>
    let Material = Namespaced_IRI.parse _namespace_name "Material" |> NamespacedName
    /// <summary>
    /// A box that contains comic books.
    /// <see href="http://comicmeta.org/cbo/Box"></see></summary>
    let Box = Namespaced_IRI.parse _namespace_name "Box" |> NamespacedName
    /// <summary>
    /// An object containing comic books.
    /// <see href="http://comicmeta.org/cbo/Container"></see></summary>
    let Container = Namespaced_IRI.parse _namespace_name "Container" |> NamespacedName
    /// <summary>
    /// A building in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    /// An object in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// A caption containing narration.
    /// <see href="http://comicmeta.org/cbo/Caption"></see></summary>
    let Caption = Namespaced_IRI.parse _namespace_name "Caption" |> NamespacedName
    /// <summary>
    /// A comic character.
    /// <see href="http://comicmeta.org/cbo/Character"></see></summary>
    let Character = Namespaced_IRI.parse _namespace_name "Character" |> NamespacedName
    /// <summary>
    /// A collection of comic books and related resources.
    /// <see href="http://comicmeta.org/cbo/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// A comic book collector.
    /// <see href="http://comicmeta.org/cbo/Collector"></see></summary>
    let Collector = Namespaced_IRI.parse _namespace_name "Collector" |> NamespacedName
    /// <summary>
    /// A visual and literary work of sequential art.
    /// <see href="http://comicmeta.org/cbo/Comic"></see></summary>
    let Comic = Namespaced_IRI.parse _namespace_name "Comic" |> NamespacedName
    /// <summary>
    /// A period of comic book history.
    /// <see href="http://comicmeta.org/cbo/ComicAge"></see></summary>
    let ComicAge = Namespaced_IRI.parse _namespace_name "ComicAge" |> NamespacedName

    /// <summary>
    /// A comic universe.
    /// <see href="http://comicmeta.org/cbo/ComicUniverse"></see></summary>
    let ComicUniverse =
        Namespaced_IRI.parse _namespace_name "ComicUniverse" |> NamespacedName

    /// <summary>
    /// A physical condition describing an object.
    /// <see href="http://comicmeta.org/cbo/Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName

    /// <summary>
    /// An physical attribute or property of an item.
    /// <see href="http://comicmeta.org/cbo/PhysicalAttribute"></see></summary>
    let PhysicalAttribute =
        Namespaced_IRI.parse _namespace_name "PhysicalAttribute" |> NamespacedName

    /// <summary>
    /// An agent contributing to the creation of a comic work.
    /// <see href="http://comicmeta.org/cbo/Contributor"></see></summary>
    let Contributor =
        Namespaced_IRI.parse _namespace_name "Contributor" |> NamespacedName

    /// <summary>
    /// A copy of a comic issue.
    /// <see href="http://comicmeta.org/cbo/Copy"></see></summary>
    let Copy = Namespaced_IRI.parse _namespace_name "Copy" |> NamespacedName
    /// <summary>
    /// An issue of a comic publication.
    /// <see href="http://comicmeta.org/cbo/Issue"></see></summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName
    /// <summary>
    /// A comic character's costume.
    /// <see href="http://comicmeta.org/cbo/Costume"></see></summary>
    let Costume = Namespaced_IRI.parse _namespace_name "Costume" |> NamespacedName
    /// <summary>
    /// An agent primarily responsible for the creation of a comic work.
    /// <see href="http://comicmeta.org/cbo/Creator"></see></summary>
    let Creator = Namespaced_IRI.parse _namespace_name "Creator" |> NamespacedName

    /// <summary>
    /// An agent responsible for the distribution of a comic publication.
    /// <see href="http://comicmeta.org/cbo/Distributor"></see></summary>
    let Distributor =
        Namespaced_IRI.parse _namespace_name "Distributor" |> NamespacedName

    /// <summary>
    /// A document composed of the pages in a comic publication.
    /// <see href="http://comicmeta.org/cbo/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// An edition of a comic issue.
    /// <see href="http://comicmeta.org/cbo/Edition"></see></summary>
    let Edition = Namespaced_IRI.parse _namespace_name "Edition" |> NamespacedName
    /// <summary>
    /// An event in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// A format in which a comic is embodied.
    /// <see href="http://comicmeta.org/cbo/Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName
    /// <summary>
    /// A frequency with which a comic is published.
    /// <see href="http://comicmeta.org/cbo/Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    /// A comics genre.
    /// <see href="http://comicmeta.org/cbo/Genre"></see></summary>
    let Genre = Namespaced_IRI.parse _namespace_name "Genre" |> NamespacedName
    /// <summary>
    /// A grade assigned to a comic item that represents a summary of its condition.
    /// <see href="http://comicmeta.org/cbo/Grade"></see></summary>
    let Grade = Namespaced_IRI.parse _namespace_name "Grade" |> NamespacedName
    /// <summary>
    /// An organization that guarantees the stated condition of a comic book.
    /// <see href="http://comicmeta.org/cbo/Guarantor"></see></summary>
    let Guarantor = Namespaced_IRI.parse _namespace_name "Guarantor" |> NamespacedName
    /// <summary>
    /// An imprint or tradename of a comic publisher.
    /// <see href="http://comicmeta.org/cbo/Imprint"></see></summary>
    let Imprint = Namespaced_IRI.parse _namespace_name "Imprint" |> NamespacedName
    /// <summary>
    /// An agent responsible for the publication of a comic.
    /// <see href="http://comicmeta.org/cbo/Publisher"></see></summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName

    /// <summary>
    /// A comics publication.
    /// <see href="http://comicmeta.org/cbo/Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// A physical or digital library containing a collection of comic resources.
    /// <see href="http://comicmeta.org/cbo/Library"></see></summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName
    /// <summary>
    /// A location in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// A physical or digital museum exhibiting a collection of comic resources.
    /// <see href="http://comicmeta.org/cbo/Museum"></see></summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName
    /// <summary>
    /// One or more pages in a comic document.
    /// <see href="http://comicmeta.org/cbo/Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName
    /// <summary>
    /// A type of page appearing in a comic document.
    /// <see href="http://comicmeta.org/cbo/PageType"></see></summary>
    let PageType = Namespaced_IRI.parse _namespace_name "PageType" |> NamespacedName
    /// <summary>
    /// A visual frame containing part of a sequence.
    /// <see href="http://comicmeta.org/cbo/Panel"></see></summary>
    let Panel = Namespaced_IRI.parse _namespace_name "Panel" |> NamespacedName
    /// <summary>
    /// A paper stock on which a comic is printed.
    /// <see href="http://comicmeta.org/cbo/Paper"></see></summary>
    let Paper = Namespaced_IRI.parse _namespace_name "Paper" |> NamespacedName
    /// <summary>
    /// An exceptional original owner collection of high quality, vintage comic books often containing copies that are considered exemplars of key issues.
    /// <see href="http://comicmeta.org/cbo/Pedigree"></see></summary>
    let Pedigree = Namespaced_IRI.parse _namespace_name "Pedigree" |> NamespacedName
    /// <summary>
    /// A planetary body in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Planet"></see></summary>
    let Planet = Namespaced_IRI.parse _namespace_name "Planet" |> NamespacedName
    /// <summary>
    /// A plastic of which a supply item is composed.
    /// <see href="http://comicmeta.org/cbo/Plastic"></see></summary>
    let Plastic = Namespaced_IRI.parse _namespace_name "Plastic" |> NamespacedName
    /// <summary>
    /// A distinctive quality belonging to an object.
    /// <see href="http://comicmeta.org/cbo/Quality"></see></summary>
    let Quality = Namespaced_IRI.parse _namespace_name "Quality" |> NamespacedName
    /// <summary>
    /// A creative role in the production of a comic work.
    /// <see href="http://comicmeta.org/cbo/Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// A comic publication containing one or more volumes and issues.
    /// <see href="http://comicmeta.org/cbo/Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
    /// <summary>
    /// A physical state describing an object.
    /// <see href="http://comicmeta.org/cbo/State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// A comic story.
    /// <see href="http://comicmeta.org/cbo/Story"></see></summary>
    let Story = Namespaced_IRI.parse _namespace_name "Story" |> NamespacedName
    /// <summary>
    /// A group of comic characters.
    /// <see href="http://comicmeta.org/cbo/Team"></see></summary>
    let Team = Namespaced_IRI.parse _namespace_name "Team" |> NamespacedName
    /// <summary>
    /// A vehicle in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Vehicle"></see></summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName
    /// <summary>
    /// A single issue or group of issues published in a comic series.
    /// <see href="http://comicmeta.org/cbo/Volume"></see></summary>
    let Volume = Namespaced_IRI.parse _namespace_name "Volume" |> NamespacedName
    /// <summary>
    /// Links a comic to an adaptation.
    /// <see href="http://comicmeta.org/cbo/adaptation"></see></summary>
    let adaptation = Namespaced_IRI.parse _namespace_name "adaptation" |> NamespacedName

    /// <summary>
    /// Links a work to the comic work it is an adaptation of.
    /// <see href="http://comicmeta.org/cbo/adaptationOf"></see></summary>
    let adaptationOf =
        Namespaced_IRI.parse _namespace_name "adaptationOf" |> NamespacedName

    /// <summary>
    /// An alternative title for any comic work.
    /// <see href="http://comicmeta.org/cbo/alternativeTitle"></see></summary>
    let alternativeTitle =
        Namespaced_IRI.parse _namespace_name "alternativeTitle" |> NamespacedName

    /// <summary>
    /// Describes the appearance of a comic universe element within a comic work.
    /// <see href="http://comicmeta.org/cbo/appearance"></see></summary>
    let appearance = Namespaced_IRI.parse _namespace_name "appearance" |> NamespacedName
    /// <summary>
    /// Associates an artist with a comic work.
    /// <see href="http://comicmeta.org/cbo/artist"></see></summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName

    /// <summary>
    /// Associates a contributor with a comic work.
    /// <see href="http://comicmeta.org/cbo/contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// Links a comic page to its original artwork.
    /// <see href="http://comicmeta.org/cbo/artwork"></see></summary>
    let artwork = Namespaced_IRI.parse _namespace_name "artwork" |> NamespacedName
    /// <summary>
    /// Links orginal comic artwork to a page.
    /// <see href="http://comicmeta.org/cbo/artworkOf"></see></summary>
    let artworkOf = Namespaced_IRI.parse _namespace_name "artworkOf" |> NamespacedName

    /// <summary>
    /// Describes the artwork type of one or more pages of comic art.
    /// <see href="http://comicmeta.org/cbo/artworkType"></see></summary>
    let artworkType =
        Namespaced_IRI.parse _namespace_name "artworkType" |> NamespacedName

    /// <summary>
    /// Describes a physical attribute of a comic item.
    /// <see href="http://comicmeta.org/cbo/attribute"></see></summary>
    let attribute = Namespaced_IRI.parse _namespace_name "attribute" |> NamespacedName
    /// <summary>
    /// Describes the bag in which a comic is contained.
    /// <see href="http://comicmeta.org/cbo/bagged"></see></summary>
    let bagged = Namespaced_IRI.parse _namespace_name "bagged" |> NamespacedName
    /// <summary>
    /// Links a panel to a word balloon.
    /// <see href="http://comicmeta.org/cbo/balloon"></see></summary>
    let balloon = Namespaced_IRI.parse _namespace_name "balloon" |> NamespacedName
    /// <summary>
    /// Links a sequence to a page.
    /// <see href="http://comicmeta.org/cbo/sequence"></see></summary>
    let sequence = Namespaced_IRI.parse _namespace_name "sequence" |> NamespacedName
    /// <summary>
    /// Describes the binding of a comic issue.
    /// <see href="http://comicmeta.org/cbo/binding"></see></summary>
    let binding = Namespaced_IRI.parse _namespace_name "binding" |> NamespacedName
    /// <summary>
    /// Describes the material of which a physical item is composed.
    /// <see href="http://comicmeta.org/cbo/material"></see></summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName
    /// <summary>
    /// Describes the backing board of a comic.
    /// <see href="http://comicmeta.org/cbo/boarded"></see></summary>
    let boarded = Namespaced_IRI.parse _namespace_name "boarded" |> NamespacedName
    /// <summary>
    /// Associates a box with a comic book collection.
    /// <see href="http://comicmeta.org/cbo/box"></see></summary>
    let box = Namespaced_IRI.parse _namespace_name "box" |> NamespacedName
    /// <summary>
    /// Describes a cameo appearance by a comic character in a comic work.
    /// <see href="http://comicmeta.org/cbo/cameo"></see></summary>
    let cameo = Namespaced_IRI.parse _namespace_name "cameo" |> NamespacedName
    /// <summary>
    /// Describes the appearance of a comic character in a comic work.
    /// <see href="http://comicmeta.org/cbo/character"></see></summary>
    let character = Namespaced_IRI.parse _namespace_name "character" |> NamespacedName
    /// <summary>
    /// Links a panel to a caption.
    /// <see href="http://comicmeta.org/cbo/caption"></see></summary>
    let caption = Namespaced_IRI.parse _namespace_name "caption" |> NamespacedName
    /// <summary>
    ///   <see href="http://comicmeta.org/cbo/category"></see>
    /// </summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    /// Comics Code Authority (CCA) approved.
    /// <see href="http://comicmeta.org/cbo/cca"></see></summary>
    let cca = Namespaced_IRI.parse _namespace_name "cca" |> NamespacedName
    /// <summary>
    /// The certificate number assigned to a graded copy of a comic by a guarantor.
    /// <see href="http://comicmeta.org/cbo/certNumber"></see></summary>
    let certNumber = Namespaced_IRI.parse _namespace_name "certNumber" |> NamespacedName

    /// <summary>
    /// Links a comic work to another work that reprints it as part of a comprehensive collection of reprinted material.
    /// <see href="http://comicmeta.org/cbo/collectedIn"></see></summary>
    let collectedIn =
        Namespaced_IRI.parse _namespace_name "collectedIn" |> NamespacedName

    /// <summary>
    /// Links a comic issue to a work that reprints it.
    /// <see href="http://comicmeta.org/cbo/reprintedIn"></see></summary>
    let reprintedIn =
        Namespaced_IRI.parse _namespace_name "reprintedIn" |> NamespacedName

    /// <summary>
    /// Links a comic issue to another work that reprints it as part of a comprehensive collection of reprinted material.
    /// <see href="http://comicmeta.org/cbo/collects"></see></summary>
    let collects = Namespaced_IRI.parse _namespace_name "collects" |> NamespacedName
    /// <summary>
    /// Links a collector to a collection.
    /// <see href="http://comicmeta.org/cbo/collection"></see></summary>
    let collection = Namespaced_IRI.parse _namespace_name "collection" |> NamespacedName
    /// <summary>
    /// Links a comic to the original work it reprints.
    /// <see href="http://comicmeta.org/cbo/reprints"></see></summary>
    let reprints = Namespaced_IRI.parse _namespace_name "reprints" |> NamespacedName
    /// <summary>
    /// Associates a colorist with a comic work.
    /// <see href="http://comicmeta.org/cbo/colorist"></see></summary>
    let colorist = Namespaced_IRI.parse _namespace_name "colorist" |> NamespacedName
    /// <summary>
    /// Associates a comic with an era of comic book history.
    /// <see href="http://comicmeta.org/cbo/comicAge"></see></summary>
    let comicAge = Namespaced_IRI.parse _namespace_name "comicAge" |> NamespacedName
    /// <summary>
    /// Describes the physical condition of a comic item.
    /// <see href="http://comicmeta.org/cbo/condition"></see></summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName
    /// <summary>
    /// Describes the contents of a box of comics.
    /// <see href="http://comicmeta.org/cbo/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// Links a comic issue to a specific copy.
    /// <see href="http://comicmeta.org/cbo/copy"></see></summary>
    let copy = Namespaced_IRI.parse _namespace_name "copy" |> NamespacedName
    /// <summary>
    /// Links a specific copy to a comic issue.
    /// <see href="http://comicmeta.org/cbo/copyOf"></see></summary>
    let copyOf = Namespaced_IRI.parse _namespace_name "copyOf" |> NamespacedName
    /// <summary>
    /// Describes the physical state of a copy of a comic issue.
    /// <see href="http://comicmeta.org/cbo/copyState"></see></summary>
    let copyState = Namespaced_IRI.parse _namespace_name "copyState" |> NamespacedName

    /// <summary>
    /// The copyright date of a comic issue.
    /// <see href="http://comicmeta.org/cbo/copyrightDate"></see></summary>
    let copyrightDate =
        Namespaced_IRI.parse _namespace_name "copyrightDate" |> NamespacedName

    /// <summary>
    /// Links a comic series to its country of origin.
    /// <see href="http://comicmeta.org/cbo/country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    /// Describes the cover art of a comic issue.
    /// <see href="http://comicmeta.org/cbo/coverArt"></see></summary>
    let coverArt = Namespaced_IRI.parse _namespace_name "coverArt" |> NamespacedName

    /// <summary>
    /// Associates an artist with cover artwork for a comic.
    /// <see href="http://comicmeta.org/cbo/coverArtist"></see></summary>
    let coverArtist =
        Namespaced_IRI.parse _namespace_name "coverArtist" |> NamespacedName

    /// <summary>
    /// The cover date of a comic issue.
    /// <see href="http://comicmeta.org/cbo/coverDate"></see></summary>
    let coverDate = Namespaced_IRI.parse _namespace_name "coverDate" |> NamespacedName
    /// <summary>
    /// The cover price of a comic issue.
    /// <see href="http://comicmeta.org/cbo/coverPrice"></see></summary>
    let coverPrice = Namespaced_IRI.parse _namespace_name "coverPrice" |> NamespacedName
    /// <summary>
    /// A general price.
    /// <see href="http://comicmeta.org/cbo/price"></see></summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName
    /// <summary>
    /// Associates a creator with a comic work.
    /// <see href="http://comicmeta.org/cbo/creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName

    /// <summary>
    /// A Diamond Comic Distributors code.
    /// <see href="http://comicmeta.org/cbo/diamondCode"></see></summary>
    let diamondCode =
        Namespaced_IRI.parse _namespace_name "diamondCode" |> NamespacedName

    /// <summary>
    /// The distributor code associated with a comics publication.
    /// <see href="http://comicmeta.org/cbo/distributorCode"></see></summary>
    let distributorCode =
        Namespaced_IRI.parse _namespace_name "distributorCode" |> NamespacedName

    /// <summary>
    /// Links a comic series to a distributor.
    /// <see href="http://comicmeta.org/cbo/distributedBy"></see></summary>
    let distributedBy =
        Namespaced_IRI.parse _namespace_name "distributedBy" |> NamespacedName

    /// <summary>
    /// Describes the edition of a comic issue.
    /// <see href="http://comicmeta.org/cbo/edition"></see></summary>
    let edition = Namespaced_IRI.parse _namespace_name "edition" |> NamespacedName
    /// <summary>
    /// Associates an editor with a comic work.
    /// <see href="http://comicmeta.org/cbo/editor"></see></summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName
    /// <summary>
    /// Describes the case in which a comic is encapsulated.
    /// <see href="http://comicmeta.org/cbo/encased"></see></summary>
    let encased = Namespaced_IRI.parse _namespace_name "encased" |> NamespacedName
    /// <summary>
    /// The date a comic ended publication.
    /// <see href="http://comicmeta.org/cbo/endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    /// Describes a comic universe event depicted in a comic work.
    /// <see href="http://comicmeta.org/cbo/event"></see></summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName
    /// <summary>
    /// Describes the feature or primary focus of a comic work.
    /// <see href="http://comicmeta.org/cbo/feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    /// Describes the format of a comic work.
    /// <see href="http://comicmeta.org/cbo/format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    /// Describes the genre of a comic work.
    /// <see href="http://comicmeta.org/cbo/genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName
    /// <summary>
    /// Describes the grade assigned to a comic item by a guarantor.
    /// <see href="http://comicmeta.org/cbo/grade"></see></summary>
    let grade = Namespaced_IRI.parse _namespace_name "grade" |> NamespacedName

    /// <summary>
    /// Links a graded copy of a comic issue to a guarantor.
    /// <see href="http://comicmeta.org/cbo/guaranteedBy"></see></summary>
    let guaranteedBy =
        Namespaced_IRI.parse _namespace_name "guaranteedBy" |> NamespacedName

    /// <summary>
    /// Associates a comic publisher with an imprint.
    /// <see href="http://comicmeta.org/cbo/imprint"></see></summary>
    let imprint = Namespaced_IRI.parse _namespace_name "imprint" |> NamespacedName
    /// <summary>
    /// Associates an imprint with a comic publisher.
    /// <see href="http://comicmeta.org/cbo/imprintOf"></see></summary>
    let imprintOf = Namespaced_IRI.parse _namespace_name "imprintOf" |> NamespacedName

    /// <summary>
    /// The name of a comic imprint.
    /// <see href="http://comicmeta.org/cbo/imprintName"></see></summary>
    let imprintName =
        Namespaced_IRI.parse _namespace_name "imprintName" |> NamespacedName

    /// <summary>
    /// Links a comic item to a box.
    /// <see href="http://comicmeta.org/cbo/inBox"></see></summary>
    let inBox = Namespaced_IRI.parse _namespace_name "inBox" |> NamespacedName

    /// <summary>
    /// The publication frequency of a comic as printed in the indicia of an issue.
    /// <see href="http://comicmeta.org/cbo/indiciaFrequency"></see></summary>
    let indiciaFrequency =
        Namespaced_IRI.parse _namespace_name "indiciaFrequency" |> NamespacedName

    /// <summary>
    /// The publisher name as printed in the indicia of a comic issue.
    /// <see href="http://comicmeta.org/cbo/indiciaPublisher"></see></summary>
    let indiciaPublisher =
        Namespaced_IRI.parse _namespace_name "indiciaPublisher" |> NamespacedName

    /// <summary>
    /// Associates an inker with a comic work.
    /// <see href="http://comicmeta.org/cbo/inker"></see></summary>
    let inker = Namespaced_IRI.parse _namespace_name "inker" |> NamespacedName
    /// <summary>
    /// The ISBN of a comic publication.
    /// <see href="http://comicmeta.org/cbo/isbn"></see></summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    /// Links a volume of comics to an issue.
    /// <see href="http://comicmeta.org/cbo/issue"></see></summary>
    let issue = Namespaced_IRI.parse _namespace_name "issue" |> NamespacedName
    /// <summary>
    /// The total number of issues in a volume of comics.
    /// <see href="http://comicmeta.org/cbo/issueCount"></see></summary>
    let issueCount = Namespaced_IRI.parse _namespace_name "issueCount" |> NamespacedName

    /// <summary>
    /// The number of a comic issue.
    /// <see href="http://comicmeta.org/cbo/issueNumber"></see></summary>
    let issueNumber =
        Namespaced_IRI.parse _namespace_name "issueNumber" |> NamespacedName

    /// <summary>
    /// Links a comic book collection to an item.
    /// <see href="http://comicmeta.org/cbo/item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    /// Links an item to a comic book collection.
    /// <see href="http://comicmeta.org/cbo/itemOf"></see></summary>
    let itemOf = Namespaced_IRI.parse _namespace_name "itemOf" |> NamespacedName
    /// <summary>
    /// An unique identifier assigned to a comic item.
    /// <see href="http://comicmeta.org/cbo/itemNumber"></see></summary>
    let itemNumber = Namespaced_IRI.parse _namespace_name "itemNumber" |> NamespacedName
    /// <summary>
    /// Decribes the language of a comic series.
    /// <see href="http://comicmeta.org/cbo/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// Associates a letterer with a comic work.
    /// <see href="http://comicmeta.org/cbo/letterer"></see></summary>
    let letterer = Namespaced_IRI.parse _namespace_name "letterer" |> NamespacedName
    /// <summary>
    /// The level of description associated with a term.
    /// <see href="http://comicmeta.org/cbo/level"></see></summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName
    /// <summary>
    /// A note.
    /// <see href="http://comicmeta.org/cbo/note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// Describes the appearance of a comic object in a comic work.
    /// <see href="http://comicmeta.org/cbo/object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// The date of availability of a comic issue.
    /// <see href="http://comicmeta.org/cbo/onSaleDate"></see></summary>
    let onSaleDate = Namespaced_IRI.parse _namespace_name "onSaleDate" |> NamespacedName
    /// <summary>
    /// Links an item or collection to the agent that owns it.
    /// <see href="http://comicmeta.org/cbo/owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    /// Links an agent to an owned item or collection.
    /// <see href="http://comicmeta.org/cbo/ownerOf"></see></summary>
    let ownerOf = Namespaced_IRI.parse _namespace_name "ownerOf" |> NamespacedName
    /// <summary>
    /// Links a comic page to a document.
    /// <see href="http://comicmeta.org/cbo/page"></see></summary>
    let page = Namespaced_IRI.parse _namespace_name "page" |> NamespacedName
    /// <summary>
    /// The number of pages in a comic issue.
    /// <see href="http://comicmeta.org/cbo/pageCount"></see></summary>
    let pageCount = Namespaced_IRI.parse _namespace_name "pageCount" |> NamespacedName
    /// <summary>
    /// The page number of a comic.
    /// <see href="http://comicmeta.org/cbo/pageNumber"></see></summary>
    let pageNumber = Namespaced_IRI.parse _namespace_name "pageNumber" |> NamespacedName
    /// <summary>
    /// Describes the type of one or more comic pages.
    /// <see href="http://comicmeta.org/cbo/pageType"></see></summary>
    let pageType = Namespaced_IRI.parse _namespace_name "pageType" |> NamespacedName
    /// <summary>
    /// Links a sequence to a comic panel.
    /// <see href="http://comicmeta.org/cbo/panel"></see></summary>
    let panel = Namespaced_IRI.parse _namespace_name "panel" |> NamespacedName
    /// <summary>
    /// Describes the paper stock of a comic issue.
    /// <see href="http://comicmeta.org/cbo/paper"></see></summary>
    let paper = Namespaced_IRI.parse _namespace_name "paper" |> NamespacedName
    /// <summary>
    /// Associates a penciller with a comic work.
    /// <see href="http://comicmeta.org/cbo/penciller"></see></summary>
    let penciller = Namespaced_IRI.parse _namespace_name "penciller" |> NamespacedName
    /// <summary>
    /// Associates a plotter with a comic work.
    /// <see href="http://comicmeta.org/cbo/plotter"></see></summary>
    let plotter = Namespaced_IRI.parse _namespace_name "plotter" |> NamespacedName
    /// <summary>
    /// Links a comic issue to a preview or sample of that work.
    /// <see href="http://comicmeta.org/cbo/preview"></see></summary>
    let preview = Namespaced_IRI.parse _namespace_name "preview" |> NamespacedName
    /// <summary>
    /// The numerical print run of a comic issue.
    /// <see href="http://comicmeta.org/cbo/printing"></see></summary>
    let printing = Namespaced_IRI.parse _namespace_name "printing" |> NamespacedName

    /// <summary>
    /// The date a comic issue was published.
    /// <see href="http://comicmeta.org/cbo/publicationDate"></see></summary>
    let publicationDate =
        Namespaced_IRI.parse _namespace_name "publicationDate" |> NamespacedName

    /// <summary>
    /// The publication frequency of a comic.
    /// <see href="http://comicmeta.org/cbo/publicationFrequency"></see></summary>
    let publicationFrequency =
        Namespaced_IRI.parse _namespace_name "publicationFrequency" |> NamespacedName

    /// <summary>
    /// Links a publisher to a comic publication.
    /// <see href="http://comicmeta.org/cbo/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    /// The name of a comic publisher.
    /// <see href="http://comicmeta.org/cbo/publisherName"></see></summary>
    let publisherName =
        Namespaced_IRI.parse _namespace_name "publisherName" |> NamespacedName

    /// <summary>
    /// The purchase price of a comic item.
    /// <see href="http://comicmeta.org/cbo/purchasePrice"></see></summary>
    let purchasePrice =
        Namespaced_IRI.parse _namespace_name "purchasePrice" |> NamespacedName

    /// <summary>
    ///   <see href="http://comicmeta.org/cbo/qlabel"></see>
    /// </summary>
    let qlabel = Namespaced_IRI.parse _namespace_name "qlabel" |> NamespacedName
    /// <summary>
    /// Describes a distinctive quality of an object.
    /// <see href="http://comicmeta.org/cbo/quality"></see></summary>
    let quality = Namespaced_IRI.parse _namespace_name "quality" |> NamespacedName
    /// <summary>
    /// The rating of a comics publication.
    /// <see href="http://comicmeta.org/cbo/rating"></see></summary>
    let rating = Namespaced_IRI.parse _namespace_name "rating" |> NamespacedName
    /// <summary>
    /// Links a comic to a related object.
    /// <see href="http://comicmeta.org/cbo/related"></see></summary>
    let related = Namespaced_IRI.parse _namespace_name "related" |> NamespacedName
    /// <summary>
    /// Describes the role of a contributor in the creation of a comic work.
    /// <see href="http://comicmeta.org/cbo/role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// The sale price of a comic item.
    /// <see href="http://comicmeta.org/cbo/salePrice"></see></summary>
    let salePrice = Namespaced_IRI.parse _namespace_name "salePrice" |> NamespacedName
    /// <summary>
    /// Links a comic to a series.
    /// <see href="http://comicmeta.org/cbo/series"></see></summary>
    let series = Namespaced_IRI.parse _namespace_name "series" |> NamespacedName
    /// <summary>
    /// Links a series to a comic work.
    /// <see href="http://comicmeta.org/cbo/seriesOf"></see></summary>
    let seriesOf = Namespaced_IRI.parse _namespace_name "seriesOf" |> NamespacedName

    /// <summary>
    /// The title of a comic series.
    /// <see href="http://comicmeta.org/cbo/seriesTitle"></see></summary>
    let seriesTitle =
        Namespaced_IRI.parse _namespace_name "seriesTitle" |> NamespacedName

    /// <summary>
    /// The year a comic series began publication.
    /// <see href="http://comicmeta.org/cbo/seriesYear"></see></summary>
    let seriesYear = Namespaced_IRI.parse _namespace_name "seriesYear" |> NamespacedName
    /// <summary>
    /// The date a comic began publication.
    /// <see href="http://comicmeta.org/cbo/startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    /// A recommended encoding standard or guidelines.
    /// <see href="http://comicmeta.org/cbo/standard"></see></summary>
    let standard = Namespaced_IRI.parse _namespace_name "standard" |> NamespacedName
    /// <summary>
    /// Describes the physical state of a comic item.
    /// <see href="http://comicmeta.org/cbo/state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName
    /// <summary>
    /// Links a comic issue to a story.
    /// <see href="http://comicmeta.org/cbo/story"></see></summary>
    let story = Namespaced_IRI.parse _namespace_name "story" |> NamespacedName
    /// <summary>
    /// Links a comic story to a story arc.
    /// <see href="http://comicmeta.org/cbo/storyArc"></see></summary>
    let storyArc = Namespaced_IRI.parse _namespace_name "storyArc" |> NamespacedName
    /// <summary>
    /// Connects an individual story to the story arc it is a part of.
    /// <see href="http://comicmeta.org/cbo/storyOf"></see></summary>
    let storyOf = Namespaced_IRI.parse _namespace_name "storyOf" |> NamespacedName
    /// <summary>
    /// The title of a comic story.
    /// <see href="http://comicmeta.org/cbo/storyTitle"></see></summary>
    let storyTitle = Namespaced_IRI.parse _namespace_name "storyTitle" |> NamespacedName
    /// <summary>
    /// The subject of a comic story.
    /// <see href="http://comicmeta.org/cbo/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// The synopsis of a comic story.
    /// <see href="http://comicmeta.org/cbo/synopsis"></see></summary>
    let synopsis = Namespaced_IRI.parse _namespace_name "synopsis" |> NamespacedName
    /// <summary>
    /// Describes the appearance of a team of comic characters in a comic work.
    /// <see href="http://comicmeta.org/cbo/team"></see></summary>
    let team = Namespaced_IRI.parse _namespace_name "team" |> NamespacedName
    /// <summary>
    /// Describes the tracking or numbering between comic series.
    /// <see href="http://comicmeta.org/cbo/tracking"></see></summary>
    let tracking = Namespaced_IRI.parse _namespace_name "tracking" |> NamespacedName

    /// <summary>
    /// Links a comic issue to a translation.
    /// <see href="http://comicmeta.org/cbo/translation"></see></summary>
    let translation =
        Namespaced_IRI.parse _namespace_name "translation" |> NamespacedName

    /// <summary>
    /// Links a comic issue to the issue it is a translation of.
    /// <see href="http://comicmeta.org/cbo/translationOf"></see></summary>
    let translationOf =
        Namespaced_IRI.parse _namespace_name "translationOf" |> NamespacedName

    /// <summary>
    /// Links a thing to a comic universe.
    /// <see href="http://comicmeta.org/cbo/universe"></see></summary>
    let universe = Namespaced_IRI.parse _namespace_name "universe" |> NamespacedName
    /// <summary>
    /// Links a comic universe to the universe from which it originates.
    /// <see href="http://comicmeta.org/cbo/universeOf"></see></summary>
    let universeOf = Namespaced_IRI.parse _namespace_name "universeOf" |> NamespacedName
    /// <summary>
    /// The UPC of a comic publication.
    /// <see href="http://comicmeta.org/cbo/upc"></see></summary>
    let upc = Namespaced_IRI.parse _namespace_name "upc" |> NamespacedName
    /// <summary>
    /// The estimated value of a comic item.
    /// <see href="http://comicmeta.org/cbo/value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// Any variance to the regular manifestation of a comic issue.
    /// <see href="http://comicmeta.org/cbo/variance"></see></summary>
    let variance = Namespaced_IRI.parse _namespace_name "variance" |> NamespacedName
    /// <summary>
    /// Links a comic issue to a variant.
    /// <see href="http://comicmeta.org/cbo/variant"></see></summary>
    let variant = Namespaced_IRI.parse _namespace_name "variant" |> NamespacedName
    /// <summary>
    /// Links a comic issue to the issue it is a variant of.
    /// <see href="http://comicmeta.org/cbo/variantOf"></see></summary>
    let variantOf = Namespaced_IRI.parse _namespace_name "variantOf" |> NamespacedName
    /// <summary>
    /// Links a series to a comic volume.
    /// <see href="http://comicmeta.org/cbo/volume"></see></summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName

    /// <summary>
    /// The unique identifier of a comic volume.
    /// <see href="http://comicmeta.org/cbo/volumeNumber"></see></summary>
    let volumeNumber =
        Namespaced_IRI.parse _namespace_name "volumeNumber" |> NamespacedName

    /// <summary>
    /// Links a volume to a comic series.
    /// <see href="http://comicmeta.org/cbo/volumeOf"></see></summary>
    let volumeOf = Namespaced_IRI.parse _namespace_name "volumeOf" |> NamespacedName
    /// <summary>
    /// Associates a writer with a comic work.
    /// <see href="http://comicmeta.org/cbo/writer"></see></summary>
    let writer = Namespaced_IRI.parse _namespace_name "writer" |> NamespacedName
