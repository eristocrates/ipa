namespace http.comicmeta.org.cbo.slash

open DoxAletheia

module cbo =
    let _namespace_name = "http://comicmeta.org/cbo/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A person, organization, or intelligence in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// A thing in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// Original comic artwork.
    /// <see href="http://comicmeta.org/cbo/Artwork"></see></summary>
    let Artwork = _prefix "Artwork"
    /// <summary>
    /// A physical or digital item.
    /// <see href="http://comicmeta.org/cbo/Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// A word balloon containing dialogue or thought.
    /// <see href="http://comicmeta.org/cbo/Balloon"></see></summary>
    let Balloon = _prefix "Balloon"
    /// <summary>
    /// A visual sequence of juxtaposed panels and pictorial elements.
    /// <see href="http://comicmeta.org/cbo/Sequence"></see></summary>
    let Sequence = _prefix "Sequence"
    /// <summary>
    /// A binding method or material used to bind the pages of a comic.
    /// <see href="http://comicmeta.org/cbo/Binding"></see></summary>
    let Binding = _prefix "Binding"
    /// <summary>
    /// A material or medium of which an object is composed.
    /// <see href="http://comicmeta.org/cbo/Material"></see></summary>
    let Material = _prefix "Material"
    /// <summary>
    /// A box that contains comic books.
    /// <see href="http://comicmeta.org/cbo/Box"></see></summary>
    let Box = _prefix "Box"
    /// <summary>
    /// An object containing comic books.
    /// <see href="http://comicmeta.org/cbo/Container"></see></summary>
    let Container = _prefix "Container"
    /// <summary>
    /// A building in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// An object in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// A caption containing narration.
    /// <see href="http://comicmeta.org/cbo/Caption"></see></summary>
    let Caption = _prefix "Caption"
    /// <summary>
    /// A comic character.
    /// <see href="http://comicmeta.org/cbo/Character"></see></summary>
    let Character = _prefix "Character"
    /// <summary>
    /// A collection of comic books and related resources.
    /// <see href="http://comicmeta.org/cbo/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A comic book collector.
    /// <see href="http://comicmeta.org/cbo/Collector"></see></summary>
    let Collector = _prefix "Collector"
    /// <summary>
    /// A visual and literary work of sequential art.
    /// <see href="http://comicmeta.org/cbo/Comic"></see></summary>
    let Comic = _prefix "Comic"
    /// <summary>
    /// A period of comic book history.
    /// <see href="http://comicmeta.org/cbo/ComicAge"></see></summary>
    let ComicAge = _prefix "ComicAge"
    /// <summary>
    /// A comic universe.
    /// <see href="http://comicmeta.org/cbo/ComicUniverse"></see></summary>
    let ComicUniverse = _prefix "ComicUniverse"
    /// <summary>
    /// A physical condition describing an object.
    /// <see href="http://comicmeta.org/cbo/Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// An physical attribute or property of an item.
    /// <see href="http://comicmeta.org/cbo/PhysicalAttribute"></see></summary>
    let PhysicalAttribute = _prefix "PhysicalAttribute"
    /// <summary>
    /// An agent contributing to the creation of a comic work.
    /// <see href="http://comicmeta.org/cbo/Contributor"></see></summary>
    let Contributor = _prefix "Contributor"
    /// <summary>
    /// A copy of a comic issue.
    /// <see href="http://comicmeta.org/cbo/Copy"></see></summary>
    let Copy = _prefix "Copy"
    /// <summary>
    /// An issue of a comic publication.
    /// <see href="http://comicmeta.org/cbo/Issue"></see></summary>
    let Issue = _prefix "Issue"
    /// <summary>
    /// A comic character's costume.
    /// <see href="http://comicmeta.org/cbo/Costume"></see></summary>
    let Costume = _prefix "Costume"
    /// <summary>
    /// An agent primarily responsible for the creation of a comic work.
    /// <see href="http://comicmeta.org/cbo/Creator"></see></summary>
    let Creator = _prefix "Creator"
    /// <summary>
    /// An agent responsible for the distribution of a comic publication.
    /// <see href="http://comicmeta.org/cbo/Distributor"></see></summary>
    let Distributor = _prefix "Distributor"
    /// <summary>
    /// A document composed of the pages in a comic publication.
    /// <see href="http://comicmeta.org/cbo/Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// An edition of a comic issue.
    /// <see href="http://comicmeta.org/cbo/Edition"></see></summary>
    let Edition = _prefix "Edition"
    /// <summary>
    /// An event in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// A format in which a comic is embodied.
    /// <see href="http://comicmeta.org/cbo/Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// A frequency with which a comic is published.
    /// <see href="http://comicmeta.org/cbo/Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// A comics genre.
    /// <see href="http://comicmeta.org/cbo/Genre"></see></summary>
    let Genre = _prefix "Genre"
    /// <summary>
    /// A grade assigned to a comic item that represents a summary of its condition.
    /// <see href="http://comicmeta.org/cbo/Grade"></see></summary>
    let Grade = _prefix "Grade"
    /// <summary>
    /// An organization that guarantees the stated condition of a comic book.
    /// <see href="http://comicmeta.org/cbo/Guarantor"></see></summary>
    let Guarantor = _prefix "Guarantor"
    /// <summary>
    /// An imprint or tradename of a comic publisher.
    /// <see href="http://comicmeta.org/cbo/Imprint"></see></summary>
    let Imprint = _prefix "Imprint"
    /// <summary>
    /// An agent responsible for the publication of a comic.
    /// <see href="http://comicmeta.org/cbo/Publisher"></see></summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    /// A comics publication.
    /// <see href="http://comicmeta.org/cbo/Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// A physical or digital library containing a collection of comic resources.
    /// <see href="http://comicmeta.org/cbo/Library"></see></summary>
    let Library = _prefix "Library"
    /// <summary>
    /// A location in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// A physical or digital museum exhibiting a collection of comic resources.
    /// <see href="http://comicmeta.org/cbo/Museum"></see></summary>
    let Museum = _prefix "Museum"
    /// <summary>
    /// One or more pages in a comic document.
    /// <see href="http://comicmeta.org/cbo/Page"></see></summary>
    let Page = _prefix "Page"
    /// <summary>
    /// A type of page appearing in a comic document.
    /// <see href="http://comicmeta.org/cbo/PageType"></see></summary>
    let PageType = _prefix "PageType"
    /// <summary>
    /// A visual frame containing part of a sequence.
    /// <see href="http://comicmeta.org/cbo/Panel"></see></summary>
    let Panel = _prefix "Panel"
    /// <summary>
    /// A paper stock on which a comic is printed.
    /// <see href="http://comicmeta.org/cbo/Paper"></see></summary>
    let Paper = _prefix "Paper"
    /// <summary>
    /// An exceptional original owner collection of high quality, vintage comic books often containing copies that are considered exemplars of key issues.
    /// <see href="http://comicmeta.org/cbo/Pedigree"></see></summary>
    let Pedigree = _prefix "Pedigree"
    /// <summary>
    /// A planetary body in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Planet"></see></summary>
    let Planet = _prefix "Planet"
    /// <summary>
    /// A plastic of which a supply item is composed.
    /// <see href="http://comicmeta.org/cbo/Plastic"></see></summary>
    let Plastic = _prefix "Plastic"
    /// <summary>
    /// A distinctive quality belonging to an object.
    /// <see href="http://comicmeta.org/cbo/Quality"></see></summary>
    let Quality = _prefix "Quality"
    /// <summary>
    /// A creative role in the production of a comic work.
    /// <see href="http://comicmeta.org/cbo/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A comic publication containing one or more volumes and issues.
    /// <see href="http://comicmeta.org/cbo/Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// A physical state describing an object.
    /// <see href="http://comicmeta.org/cbo/State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// A comic story.
    /// <see href="http://comicmeta.org/cbo/Story"></see></summary>
    let Story = _prefix "Story"
    /// <summary>
    /// A group of comic characters.
    /// <see href="http://comicmeta.org/cbo/Team"></see></summary>
    let Team = _prefix "Team"
    /// <summary>
    /// A vehicle in a comic universe.
    /// <see href="http://comicmeta.org/cbo/Vehicle"></see></summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    /// A single issue or group of issues published in a comic series.
    /// <see href="http://comicmeta.org/cbo/Volume"></see></summary>
    let Volume = _prefix "Volume"
    /// <summary>
    /// Links a comic to an adaptation.
    /// <see href="http://comicmeta.org/cbo/adaptation"></see></summary>
    let adaptation = _prefix "adaptation"
    /// <summary>
    /// Links a work to the comic work it is an adaptation of.
    /// <see href="http://comicmeta.org/cbo/adaptationOf"></see></summary>
    let adaptationOf = _prefix "adaptationOf"
    /// <summary>
    /// An alternative title for any comic work.
    /// <see href="http://comicmeta.org/cbo/alternativeTitle"></see></summary>
    let alternativeTitle = _prefix "alternativeTitle"
    /// <summary>
    /// Describes the appearance of a comic universe element within a comic work.
    /// <see href="http://comicmeta.org/cbo/appearance"></see></summary>
    let appearance = _prefix "appearance"
    /// <summary>
    /// Associates an artist with a comic work.
    /// <see href="http://comicmeta.org/cbo/artist"></see></summary>
    let artist = _prefix "artist"
    /// <summary>
    /// Associates a contributor with a comic work.
    /// <see href="http://comicmeta.org/cbo/contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// Links a comic page to its original artwork.
    /// <see href="http://comicmeta.org/cbo/artwork"></see></summary>
    let artwork = _prefix "artwork"
    /// <summary>
    /// Links orginal comic artwork to a page.
    /// <see href="http://comicmeta.org/cbo/artworkOf"></see></summary>
    let artworkOf = _prefix "artworkOf"
    /// <summary>
    /// Describes the artwork type of one or more pages of comic art.
    /// <see href="http://comicmeta.org/cbo/artworkType"></see></summary>
    let artworkType = _prefix "artworkType"
    /// <summary>
    /// Describes a physical attribute of a comic item.
    /// <see href="http://comicmeta.org/cbo/attribute"></see></summary>
    let attribute = _prefix "attribute"
    /// <summary>
    /// Describes the bag in which a comic is contained.
    /// <see href="http://comicmeta.org/cbo/bagged"></see></summary>
    let bagged = _prefix "bagged"
    /// <summary>
    /// Links a panel to a word balloon.
    /// <see href="http://comicmeta.org/cbo/balloon"></see></summary>
    let balloon = _prefix "balloon"
    /// <summary>
    /// Links a sequence to a page.
    /// <see href="http://comicmeta.org/cbo/sequence"></see></summary>
    let sequence = _prefix "sequence"
    /// <summary>
    /// Describes the binding of a comic issue.
    /// <see href="http://comicmeta.org/cbo/binding"></see></summary>
    let binding = _prefix "binding"
    /// <summary>
    /// Describes the material of which a physical item is composed.
    /// <see href="http://comicmeta.org/cbo/material"></see></summary>
    let material = _prefix "material"
    /// <summary>
    /// Describes the backing board of a comic.
    /// <see href="http://comicmeta.org/cbo/boarded"></see></summary>
    let boarded = _prefix "boarded"
    /// <summary>
    /// Associates a box with a comic book collection.
    /// <see href="http://comicmeta.org/cbo/box"></see></summary>
    let box = _prefix "box"
    /// <summary>
    /// Describes a cameo appearance by a comic character in a comic work.
    /// <see href="http://comicmeta.org/cbo/cameo"></see></summary>
    let cameo = _prefix "cameo"
    /// <summary>
    /// Describes the appearance of a comic character in a comic work.
    /// <see href="http://comicmeta.org/cbo/character"></see></summary>
    let character = _prefix "character"
    /// <summary>
    /// Links a panel to a caption.
    /// <see href="http://comicmeta.org/cbo/caption"></see></summary>
    let caption = _prefix "caption"
    /// <summary>
    ///   <see href="http://comicmeta.org/cbo/category"></see>
    /// </summary>
    let category = _prefix "category"
    /// <summary>
    /// Comics Code Authority (CCA) approved.
    /// <see href="http://comicmeta.org/cbo/cca"></see></summary>
    let cca = _prefix "cca"
    /// <summary>
    /// The certificate number assigned to a graded copy of a comic by a guarantor.
    /// <see href="http://comicmeta.org/cbo/certNumber"></see></summary>
    let certNumber = _prefix "certNumber"
    /// <summary>
    /// Links a comic work to another work that reprints it as part of a comprehensive collection of reprinted material.
    /// <see href="http://comicmeta.org/cbo/collectedIn"></see></summary>
    let collectedIn = _prefix "collectedIn"
    /// <summary>
    /// Links a comic issue to a work that reprints it.
    /// <see href="http://comicmeta.org/cbo/reprintedIn"></see></summary>
    let reprintedIn = _prefix "reprintedIn"
    /// <summary>
    /// Links a comic issue to another work that reprints it as part of a comprehensive collection of reprinted material.
    /// <see href="http://comicmeta.org/cbo/collects"></see></summary>
    let collects = _prefix "collects"
    /// <summary>
    /// Links a collector to a collection.
    /// <see href="http://comicmeta.org/cbo/collection"></see></summary>
    let collection = _prefix "collection"
    /// <summary>
    /// Links a comic to the original work it reprints.
    /// <see href="http://comicmeta.org/cbo/reprints"></see></summary>
    let reprints = _prefix "reprints"
    /// <summary>
    /// Associates a colorist with a comic work.
    /// <see href="http://comicmeta.org/cbo/colorist"></see></summary>
    let colorist = _prefix "colorist"
    /// <summary>
    /// Associates a comic with an era of comic book history.
    /// <see href="http://comicmeta.org/cbo/comicAge"></see></summary>
    let comicAge = _prefix "comicAge"
    /// <summary>
    /// Describes the physical condition of a comic item.
    /// <see href="http://comicmeta.org/cbo/condition"></see></summary>
    let condition = _prefix "condition"
    /// <summary>
    /// Describes the contents of a box of comics.
    /// <see href="http://comicmeta.org/cbo/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// Links a comic issue to a specific copy.
    /// <see href="http://comicmeta.org/cbo/copy"></see></summary>
    let copy = _prefix "copy"
    /// <summary>
    /// Links a specific copy to a comic issue.
    /// <see href="http://comicmeta.org/cbo/copyOf"></see></summary>
    let copyOf = _prefix "copyOf"
    /// <summary>
    /// Describes the physical state of a copy of a comic issue.
    /// <see href="http://comicmeta.org/cbo/copyState"></see></summary>
    let copyState = _prefix "copyState"
    /// <summary>
    /// The copyright date of a comic issue.
    /// <see href="http://comicmeta.org/cbo/copyrightDate"></see></summary>
    let copyrightDate = _prefix "copyrightDate"
    /// <summary>
    /// Links a comic series to its country of origin.
    /// <see href="http://comicmeta.org/cbo/country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// Describes the cover art of a comic issue.
    /// <see href="http://comicmeta.org/cbo/coverArt"></see></summary>
    let coverArt = _prefix "coverArt"
    /// <summary>
    /// Associates an artist with cover artwork for a comic.
    /// <see href="http://comicmeta.org/cbo/coverArtist"></see></summary>
    let coverArtist = _prefix "coverArtist"
    /// <summary>
    /// The cover date of a comic issue.
    /// <see href="http://comicmeta.org/cbo/coverDate"></see></summary>
    let coverDate = _prefix "coverDate"
    /// <summary>
    /// The cover price of a comic issue.
    /// <see href="http://comicmeta.org/cbo/coverPrice"></see></summary>
    let coverPrice = _prefix "coverPrice"
    /// <summary>
    /// A general price.
    /// <see href="http://comicmeta.org/cbo/price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    /// Associates a creator with a comic work.
    /// <see href="http://comicmeta.org/cbo/creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// A Diamond Comic Distributors code.
    /// <see href="http://comicmeta.org/cbo/diamondCode"></see></summary>
    let diamondCode = _prefix "diamondCode"
    /// <summary>
    /// The distributor code associated with a comics publication.
    /// <see href="http://comicmeta.org/cbo/distributorCode"></see></summary>
    let distributorCode = _prefix "distributorCode"
    /// <summary>
    /// Links a comic series to a distributor.
    /// <see href="http://comicmeta.org/cbo/distributedBy"></see></summary>
    let distributedBy = _prefix "distributedBy"
    /// <summary>
    /// Describes the edition of a comic issue.
    /// <see href="http://comicmeta.org/cbo/edition"></see></summary>
    let edition = _prefix "edition"
    /// <summary>
    /// Associates an editor with a comic work.
    /// <see href="http://comicmeta.org/cbo/editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// Describes the case in which a comic is encapsulated.
    /// <see href="http://comicmeta.org/cbo/encased"></see></summary>
    let encased = _prefix "encased"
    /// <summary>
    /// The date a comic ended publication.
    /// <see href="http://comicmeta.org/cbo/endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// Describes a comic universe event depicted in a comic work.
    /// <see href="http://comicmeta.org/cbo/event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// Describes the feature or primary focus of a comic work.
    /// <see href="http://comicmeta.org/cbo/feature"></see></summary>
    let feature = _prefix "feature"
    /// <summary>
    /// Describes the format of a comic work.
    /// <see href="http://comicmeta.org/cbo/format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// Describes the genre of a comic work.
    /// <see href="http://comicmeta.org/cbo/genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// Describes the grade assigned to a comic item by a guarantor.
    /// <see href="http://comicmeta.org/cbo/grade"></see></summary>
    let grade = _prefix "grade"
    /// <summary>
    /// Links a graded copy of a comic issue to a guarantor.
    /// <see href="http://comicmeta.org/cbo/guaranteedBy"></see></summary>
    let guaranteedBy = _prefix "guaranteedBy"
    /// <summary>
    /// Associates a comic publisher with an imprint.
    /// <see href="http://comicmeta.org/cbo/imprint"></see></summary>
    let imprint = _prefix "imprint"
    /// <summary>
    /// Associates an imprint with a comic publisher.
    /// <see href="http://comicmeta.org/cbo/imprintOf"></see></summary>
    let imprintOf = _prefix "imprintOf"
    /// <summary>
    /// The name of a comic imprint.
    /// <see href="http://comicmeta.org/cbo/imprintName"></see></summary>
    let imprintName = _prefix "imprintName"
    /// <summary>
    /// Links a comic item to a box.
    /// <see href="http://comicmeta.org/cbo/inBox"></see></summary>
    let inBox = _prefix "inBox"
    /// <summary>
    /// The publication frequency of a comic as printed in the indicia of an issue.
    /// <see href="http://comicmeta.org/cbo/indiciaFrequency"></see></summary>
    let indiciaFrequency = _prefix "indiciaFrequency"
    /// <summary>
    /// The publisher name as printed in the indicia of a comic issue.
    /// <see href="http://comicmeta.org/cbo/indiciaPublisher"></see></summary>
    let indiciaPublisher = _prefix "indiciaPublisher"
    /// <summary>
    /// Associates an inker with a comic work.
    /// <see href="http://comicmeta.org/cbo/inker"></see></summary>
    let inker = _prefix "inker"
    /// <summary>
    /// The ISBN of a comic publication.
    /// <see href="http://comicmeta.org/cbo/isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// Links a volume of comics to an issue.
    /// <see href="http://comicmeta.org/cbo/issue"></see></summary>
    let issue = _prefix "issue"
    /// <summary>
    /// The total number of issues in a volume of comics.
    /// <see href="http://comicmeta.org/cbo/issueCount"></see></summary>
    let issueCount = _prefix "issueCount"
    /// <summary>
    /// The number of a comic issue.
    /// <see href="http://comicmeta.org/cbo/issueNumber"></see></summary>
    let issueNumber = _prefix "issueNumber"
    /// <summary>
    /// Links a comic book collection to an item.
    /// <see href="http://comicmeta.org/cbo/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// Links an item to a comic book collection.
    /// <see href="http://comicmeta.org/cbo/itemOf"></see></summary>
    let itemOf = _prefix "itemOf"
    /// <summary>
    /// An unique identifier assigned to a comic item.
    /// <see href="http://comicmeta.org/cbo/itemNumber"></see></summary>
    let itemNumber = _prefix "itemNumber"
    /// <summary>
    /// Decribes the language of a comic series.
    /// <see href="http://comicmeta.org/cbo/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Associates a letterer with a comic work.
    /// <see href="http://comicmeta.org/cbo/letterer"></see></summary>
    let letterer = _prefix "letterer"
    /// <summary>
    /// The level of description associated with a term.
    /// <see href="http://comicmeta.org/cbo/level"></see></summary>
    let level = _prefix "level"
    /// <summary>
    /// A note.
    /// <see href="http://comicmeta.org/cbo/note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// Describes the appearance of a comic object in a comic work.
    /// <see href="http://comicmeta.org/cbo/object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// The date of availability of a comic issue.
    /// <see href="http://comicmeta.org/cbo/onSaleDate"></see></summary>
    let onSaleDate = _prefix "onSaleDate"
    /// <summary>
    /// Links an item or collection to the agent that owns it.
    /// <see href="http://comicmeta.org/cbo/owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// Links an agent to an owned item or collection.
    /// <see href="http://comicmeta.org/cbo/ownerOf"></see></summary>
    let ownerOf = _prefix "ownerOf"
    /// <summary>
    /// Links a comic page to a document.
    /// <see href="http://comicmeta.org/cbo/page"></see></summary>
    let page = _prefix "page"
    /// <summary>
    /// The number of pages in a comic issue.
    /// <see href="http://comicmeta.org/cbo/pageCount"></see></summary>
    let pageCount = _prefix "pageCount"
    /// <summary>
    /// The page number of a comic.
    /// <see href="http://comicmeta.org/cbo/pageNumber"></see></summary>
    let pageNumber = _prefix "pageNumber"
    /// <summary>
    /// Describes the type of one or more comic pages.
    /// <see href="http://comicmeta.org/cbo/pageType"></see></summary>
    let pageType = _prefix "pageType"
    /// <summary>
    /// Links a sequence to a comic panel.
    /// <see href="http://comicmeta.org/cbo/panel"></see></summary>
    let panel = _prefix "panel"
    /// <summary>
    /// Describes the paper stock of a comic issue.
    /// <see href="http://comicmeta.org/cbo/paper"></see></summary>
    let paper = _prefix "paper"
    /// <summary>
    /// Associates a penciller with a comic work.
    /// <see href="http://comicmeta.org/cbo/penciller"></see></summary>
    let penciller = _prefix "penciller"
    /// <summary>
    /// Associates a plotter with a comic work.
    /// <see href="http://comicmeta.org/cbo/plotter"></see></summary>
    let plotter = _prefix "plotter"
    /// <summary>
    /// Links a comic issue to a preview or sample of that work.
    /// <see href="http://comicmeta.org/cbo/preview"></see></summary>
    let preview = _prefix "preview"
    /// <summary>
    /// The numerical print run of a comic issue.
    /// <see href="http://comicmeta.org/cbo/printing"></see></summary>
    let printing = _prefix "printing"
    /// <summary>
    /// The date a comic issue was published.
    /// <see href="http://comicmeta.org/cbo/publicationDate"></see></summary>
    let publicationDate = _prefix "publicationDate"
    /// <summary>
    /// The publication frequency of a comic.
    /// <see href="http://comicmeta.org/cbo/publicationFrequency"></see></summary>
    let publicationFrequency = _prefix "publicationFrequency"
    /// <summary>
    /// Links a publisher to a comic publication.
    /// <see href="http://comicmeta.org/cbo/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// The name of a comic publisher.
    /// <see href="http://comicmeta.org/cbo/publisherName"></see></summary>
    let publisherName = _prefix "publisherName"
    /// <summary>
    /// The purchase price of a comic item.
    /// <see href="http://comicmeta.org/cbo/purchasePrice"></see></summary>
    let purchasePrice = _prefix "purchasePrice"
    /// <summary>
    ///   <see href="http://comicmeta.org/cbo/qlabel"></see>
    /// </summary>
    let qlabel = _prefix "qlabel"
    /// <summary>
    /// Describes a distinctive quality of an object.
    /// <see href="http://comicmeta.org/cbo/quality"></see></summary>
    let quality = _prefix "quality"
    /// <summary>
    /// The rating of a comics publication.
    /// <see href="http://comicmeta.org/cbo/rating"></see></summary>
    let rating = _prefix "rating"
    /// <summary>
    /// Links a comic to a related object.
    /// <see href="http://comicmeta.org/cbo/related"></see></summary>
    let related = _prefix "related"
    /// <summary>
    /// Describes the role of a contributor in the creation of a comic work.
    /// <see href="http://comicmeta.org/cbo/role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// The sale price of a comic item.
    /// <see href="http://comicmeta.org/cbo/salePrice"></see></summary>
    let salePrice = _prefix "salePrice"
    /// <summary>
    /// Links a comic to a series.
    /// <see href="http://comicmeta.org/cbo/series"></see></summary>
    let series = _prefix "series"
    /// <summary>
    /// Links a series to a comic work.
    /// <see href="http://comicmeta.org/cbo/seriesOf"></see></summary>
    let seriesOf = _prefix "seriesOf"
    /// <summary>
    /// The title of a comic series.
    /// <see href="http://comicmeta.org/cbo/seriesTitle"></see></summary>
    let seriesTitle = _prefix "seriesTitle"
    /// <summary>
    /// The year a comic series began publication.
    /// <see href="http://comicmeta.org/cbo/seriesYear"></see></summary>
    let seriesYear = _prefix "seriesYear"
    /// <summary>
    /// The date a comic began publication.
    /// <see href="http://comicmeta.org/cbo/startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// A recommended encoding standard or guidelines.
    /// <see href="http://comicmeta.org/cbo/standard"></see></summary>
    let standard = _prefix "standard"
    /// <summary>
    /// Describes the physical state of a comic item.
    /// <see href="http://comicmeta.org/cbo/state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// Links a comic issue to a story.
    /// <see href="http://comicmeta.org/cbo/story"></see></summary>
    let story = _prefix "story"
    /// <summary>
    /// Links a comic story to a story arc.
    /// <see href="http://comicmeta.org/cbo/storyArc"></see></summary>
    let storyArc = _prefix "storyArc"
    /// <summary>
    /// Connects an individual story to the story arc it is a part of.
    /// <see href="http://comicmeta.org/cbo/storyOf"></see></summary>
    let storyOf = _prefix "storyOf"
    /// <summary>
    /// The title of a comic story.
    /// <see href="http://comicmeta.org/cbo/storyTitle"></see></summary>
    let storyTitle = _prefix "storyTitle"
    /// <summary>
    /// The subject of a comic story.
    /// <see href="http://comicmeta.org/cbo/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// The synopsis of a comic story.
    /// <see href="http://comicmeta.org/cbo/synopsis"></see></summary>
    let synopsis = _prefix "synopsis"
    /// <summary>
    /// Describes the appearance of a team of comic characters in a comic work.
    /// <see href="http://comicmeta.org/cbo/team"></see></summary>
    let team = _prefix "team"
    /// <summary>
    /// Describes the tracking or numbering between comic series.
    /// <see href="http://comicmeta.org/cbo/tracking"></see></summary>
    let tracking = _prefix "tracking"
    /// <summary>
    /// Links a comic issue to a translation.
    /// <see href="http://comicmeta.org/cbo/translation"></see></summary>
    let translation = _prefix "translation"
    /// <summary>
    /// Links a comic issue to the issue it is a translation of.
    /// <see href="http://comicmeta.org/cbo/translationOf"></see></summary>
    let translationOf = _prefix "translationOf"
    /// <summary>
    /// Links a thing to a comic universe.
    /// <see href="http://comicmeta.org/cbo/universe"></see></summary>
    let universe = _prefix "universe"
    /// <summary>
    /// Links a comic universe to the universe from which it originates.
    /// <see href="http://comicmeta.org/cbo/universeOf"></see></summary>
    let universeOf = _prefix "universeOf"
    /// <summary>
    /// The UPC of a comic publication.
    /// <see href="http://comicmeta.org/cbo/upc"></see></summary>
    let upc = _prefix "upc"
    /// <summary>
    /// The estimated value of a comic item.
    /// <see href="http://comicmeta.org/cbo/value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Any variance to the regular manifestation of a comic issue.
    /// <see href="http://comicmeta.org/cbo/variance"></see></summary>
    let variance = _prefix "variance"
    /// <summary>
    /// Links a comic issue to a variant.
    /// <see href="http://comicmeta.org/cbo/variant"></see></summary>
    let variant = _prefix "variant"
    /// <summary>
    /// Links a comic issue to the issue it is a variant of.
    /// <see href="http://comicmeta.org/cbo/variantOf"></see></summary>
    let variantOf = _prefix "variantOf"
    /// <summary>
    /// Links a series to a comic volume.
    /// <see href="http://comicmeta.org/cbo/volume"></see></summary>
    let volume = _prefix "volume"
    /// <summary>
    /// The unique identifier of a comic volume.
    /// <see href="http://comicmeta.org/cbo/volumeNumber"></see></summary>
    let volumeNumber = _prefix "volumeNumber"
    /// <summary>
    /// Links a volume to a comic series.
    /// <see href="http://comicmeta.org/cbo/volumeOf"></see></summary>
    let volumeOf = _prefix "volumeOf"
    /// <summary>
    /// Associates a writer with a comic work.
    /// <see href="http://comicmeta.org/cbo/writer"></see></summary>
    let writer = _prefix "writer"
