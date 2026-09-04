#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module frbr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/vocab/frbr/core#" "frbr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : classical work</para>
    ///   <a href="http://purl.org/vocab/frbr/core#ClassicalWork">frbr:ClassicalWork</a>
    /// </summary>
    let ClassicalWork = _prefixId.prefix "ClassicalWork"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group three entity 'Concept'.</para>
    ///   <para>skos:definition : An abstract idea or notion.</para>
    ///   <para>rdfs:label : concept</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Concept">frbr:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An organization or group of individuals and/or other organizations.</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group two entity 'Corporate Body'.</para>
    ///   <para>rdfs:label : corporate body</para>
    ///   <a href="http://purl.org/vocab/frbr/core#CorporateBody">frbr:CorporateBody</a>
    /// </summary>
    let CorporateBody = _prefixId.prefix "CorporateBody"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : data</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Data">frbr:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>skos:definition : Any of the products of artistic or creative endeavour.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents any one of the FRBR group one entities.</para>
    ///   <para>rdfs:label : endeavour</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Endeavour">frbr:Endeavour</a>
    /// </summary>
    let Endeavour = _prefixId.prefix "Endeavour"
    /// <summary>
    ///   <para>skos:definition : An action or occurrence.</para>
    ///   <para>rdfs:label : event</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group three entity 'Event'.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Event">frbr:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>skos:definition : A realization of a single work usually in a physical form.</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group one entity 'Expression'.</para>
    ///   <para>rdfs:label : expression</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Expression">frbr:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : image</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Image">frbr:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>skos:definition : An exemplar of a single manifestation.</para>
    ///   <para>rdfs:label : item</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group one entity 'Item'.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Item">frbr:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : legal work</para>
    ///   <a href="http://purl.org/vocab/frbr/core#LegalWork">frbr:LegalWork</a>
    /// </summary>
    let LegalWork = _prefixId.prefix "LegalWork"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : literary work</para>
    ///   <a href="http://purl.org/vocab/frbr/core#LiteraryWork">frbr:LiteraryWork</a>
    /// </summary>
    let LiteraryWork = _prefixId.prefix "LiteraryWork"
    /// <summary>
    ///   <para>rdfs:label : manifestation</para>
    ///   <para>skos:definition : The physical embodiment of one or more expressions.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group one entity 'Manifestation'.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Manifestation">frbr:Manifestation</a>
    /// </summary>
    let Manifestation = _prefixId.prefix "Manifestation"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : moving image</para>
    ///   <a href="http://purl.org/vocab/frbr/core#MovingImage">frbr:MovingImage</a>
    /// </summary>
    let MovingImage = _prefixId.prefix "MovingImage"
    /// <summary>
    ///   <para>skos:definition : A tangible or material thing.</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group three entity 'Object'.</para>
    ///   <para>rdfs:label : object</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Object">frbr:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : performance</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Performance">frbr:Performance</a>
    /// </summary>
    let Performance = _prefixId.prefix "Performance"
    /// <summary>
    ///   <para>rdfs:label : person</para>
    ///   <para>skos:definition : A living or dead individual.</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group two entity 'Person'.</para>
    ///   <para>dcterms:issued : 2005-08-08^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Person">frbr:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : place</para>
    ///   <para>skos:definition : A location.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group three entity 'Place'.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Place">frbr:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents any of the FRBR group two entities.</para>
    ///   <para>rdfs:label : responsible entity</para>
    ///   <para>skos:definition : One responsible for the creation, production, distribution or maintenance of artistic or creative content.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#ResponsibleEntity">frbr:ResponsibleEntity</a>
    /// </summary>
    let ResponsibleEntity = _prefixId.prefix "ResponsibleEntity"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : scholarly work</para>
    ///   <a href="http://purl.org/vocab/frbr/core#ScholarlyWork">frbr:ScholarlyWork</a>
    /// </summary>
    let ScholarlyWork = _prefixId.prefix "ScholarlyWork"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : sound</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Sound">frbr:Sound</a>
    /// </summary>
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>rdfs:comment : This class represents any of the FRBR group three entities.</para>
    ///   <para>skos:definition : Something that may serve as the subject of a work.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Subject">frbr:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>dcterms:issued : 2005-10-14^^xsd:string</para>
    ///   <para>rdfs:label : text</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Text">frbr:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An abstract notion of an artistic or intellectual creation.</para>
    ///   <para>rdfs:comment : This class corresponds to the FRBR group one entity 'Work'.</para>
    ///   <para>rdfs:label : work</para>
    ///   <a href="http://purl.org/vocab/frbr/core#Work">frbr:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : abridgement</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An abridgment of an expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#abridgement">frbr:abridgement</a>
    /// </summary>
    let abridgement = _prefixId.prefix "abridgement"
    /// <summary>
    ///   <para>rdfs:label : abridgement of</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An expression that is abridged.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#abridgementOf">frbr:abridgementOf</a>
    /// </summary>
    let abridgementOf = _prefixId.prefix "abridgementOf"
    /// <summary>
    ///   <para>rdfs:label : adaption</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An adaption of a work or expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#adaption">frbr:adaption</a>
    /// </summary>
    let adaption = _prefixId.prefix "adaption"
    /// <summary>
    ///   <para>rdfs:label : adaption of</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A work or expression that is adapted.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#adaptionOf">frbr:adaptionOf</a>
    /// </summary>
    let adaptionOf = _prefixId.prefix "adaptionOf"
    /// <summary>
    ///   <para>skos:definition : An alternative to a manifestation.</para>
    ///   <para>dcterms:issued : 2005-08-10^^xsd:string</para>
    ///   <para>rdfs:label : alternate</para>
    ///   <a href="http://purl.org/vocab/frbr/core#alternate">frbr:alternate</a>
    /// </summary>
    let alternate = _prefixId.prefix "alternate"
    /// <summary>
    ///   <para>skos:definition : A manifestation that is alternated.</para>
    ///   <para>dcterms:issued : 2005-08-10^^xsd:string</para>
    ///   <para>rdfs:label : alternate of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#alternateOf">frbr:alternateOf</a>
    /// </summary>
    let alternateOf = _prefixId.prefix "alternateOf"
    /// <summary>
    ///   <para>rdfs:label : arrangement</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An arrangement of an expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#arrangement">frbr:arrangement</a>
    /// </summary>
    let arrangement = _prefixId.prefix "arrangement"
    /// <summary>
    ///   <para>rdfs:label : arrangement of</para>
    ///   <para>skos:definition : An expression that is arranged.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#arrangementOf">frbr:arrangementOf</a>
    /// </summary>
    let arrangementOf = _prefixId.prefix "arrangementOf"
    /// <summary>
    ///   <para>skos:definition : A complement to a work or expression.</para>
    ///   <para>rdfs:label : complement</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#complement">frbr:complement</a>
    /// </summary>
    let complement = _prefixId.prefix "complement"
    /// <summary>
    ///   <para>skos:definition : A work or expression that is complemented.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : complement of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#complementOf">frbr:complementOf</a>
    /// </summary>
    let complementOf = _prefixId.prefix "complementOf"
    /// <summary>
    ///   <para>skos:definition : An entity in some way responsible for the creation of a work.</para>
    ///   <para>rdfs:label : creator</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#creator">frbr:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A work that was in some way created by of an entity.</para>
    ///   <para>rdfs:label : creator of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#creatorOf">frbr:creatorOf</a>
    /// </summary>
    let creatorOf = _prefixId.prefix "creatorOf"
    /// <summary>
    ///   <para>rdfs:label : embodiment</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A manifestation that embodies an expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#embodiment">frbr:embodiment</a>
    /// </summary>
    let embodiment = _prefixId.prefix "embodiment"
    /// <summary>
    ///   <para>skos:definition : An expression that is embodied by a manifestation.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : embodiment of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#embodimentOf">frbr:embodimentOf</a>
    /// </summary>
    let embodimentOf = _prefixId.prefix "embodimentOf"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : exemplar</para>
    ///   <para>skos:definition : An item that is an exemplar of a manifestation.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#exemplar">frbr:exemplar</a>
    /// </summary>
    let exemplar = _prefixId.prefix "exemplar"
    /// <summary>
    ///   <para>skos:definition : The manifestation that is exemplified by a item.</para>
    ///   <para>rdfs:label : exemplar of</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#exemplarOf">frbr:exemplarOf</a>
    /// </summary>
    let exemplarOf = _prefixId.prefix "exemplarOf"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : imitation</para>
    ///   <para>skos:definition : An imitation of a work or expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#imitation">frbr:imitation</a>
    /// </summary>
    let imitation = _prefixId.prefix "imitation"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A work or expression that is imitated.</para>
    ///   <para>rdfs:label : imitation of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#imitationOf">frbr:imitationOf</a>
    /// </summary>
    let imitationOf = _prefixId.prefix "imitationOf"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An entity that owns an item.</para>
    ///   <para>rdfs:label : owner</para>
    ///   <a href="http://purl.org/vocab/frbr/core#owner">frbr:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : owner of</para>
    ///   <para>skos:definition : An item that is in some way owned an entity.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#ownerOf">frbr:ownerOf</a>
    /// </summary>
    let ownerOf = _prefixId.prefix "ownerOf"
    /// <summary>
    ///   <para>skos:definition : A part of an endeavour.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : part</para>
    ///   <a href="http://purl.org/vocab/frbr/core#part">frbr:part</a>
    /// </summary>
    let part = _prefixId.prefix "part"
    /// <summary>
    ///   <para>skos:definition : An endeavour incorporating an endeavour.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : part of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#partOf">frbr:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : producer</para>
    ///   <para>skos:definition : An entity in some way responsible for producing a manifestation.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#producer">frbr:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>rdfs:label : producer of</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A manifestation that was in some way produced an entity.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#producerOf">frbr:producerOf</a>
    /// </summary>
    let producerOf = _prefixId.prefix "producerOf"
    /// <summary>
    ///   <para>skos:definition : An expression that is an intellectual or artistic realization of a work.</para>
    ///   <para>rdfs:label : realization</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#realization">frbr:realization</a>
    /// </summary>
    let realization = _prefixId.prefix "realization"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : realization of</para>
    ///   <para>skos:definition : The work that has been realized by an expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#realizationOf">frbr:realizationOf</a>
    /// </summary>
    let realizationOf = _prefixId.prefix "realizationOf"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : realizer</para>
    ///   <para>skos:definition : An entity in some way responsible for realizing an expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#realizer">frbr:realizer</a>
    /// </summary>
    let realizer = _prefixId.prefix "realizer"
    /// <summary>
    ///   <para>rdfs:label : realizer of</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An expression that was in some way realized by an entity.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#realizerOf">frbr:realizerOf</a>
    /// </summary>
    let realizerOf = _prefixId.prefix "realizerOf"
    /// <summary>
    ///   <para>skos:definition : A recongifuration of an item.</para>
    ///   <para>dcterms:issued : 2005-08-10^^xsd:string</para>
    ///   <para>rdfs:label : reconfiguration</para>
    ///   <a href="http://purl.org/vocab/frbr/core#reconfiguration">frbr:reconfiguration</a>
    /// </summary>
    let reconfiguration = _prefixId.prefix "reconfiguration"
    /// <summary>
    ///   <para>skos:definition : An item that is reconfigured.</para>
    ///   <para>dcterms:issued : 2005-08-10^^xsd:string</para>
    ///   <para>rdfs:label : reconfiguration of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#reconfigurationOf">frbr:reconfigurationOf</a>
    /// </summary>
    let reconfigurationOf = _prefixId.prefix "reconfigurationOf"
    /// <summary>
    ///   <para>skos:definition : Another endeavour that is related in some way to an endeavour.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : related endeavour</para>
    ///   <a href="http://purl.org/vocab/frbr/core#relatedEndeavour">frbr:relatedEndeavour</a>
    /// </summary>
    let relatedEndeavour = _prefixId.prefix "relatedEndeavour"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : reproduction</para>
    ///   <para>skos:definition : A reproduction of a manifestation or item.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#reproduction">frbr:reproduction</a>
    /// </summary>
    let reproduction = _prefixId.prefix "reproduction"
    /// <summary>
    ///   <para>rdfs:label : reproduction of</para>
    ///   <para>skos:definition : A manifestation or item that is reproduced.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#reproductionOf">frbr:reproductionOf</a>
    /// </summary>
    let reproductionOf = _prefixId.prefix "reproductionOf"
    /// <summary>
    ///   <para>skos:definition : An entity in some way responsible for an endeavour.</para>
    ///   <para>rdfs:label : responsible entity</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#responsibleEntity">frbr:responsibleEntity</a>
    /// </summary>
    let responsibleEntity = _prefixId.prefix "responsibleEntity"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : An endeavour that is the responsibility of an entity.</para>
    ///   <para>rdfs:label : responsible entity of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#responsibleEntityOf">frbr:responsibleEntityOf</a>
    /// </summary>
    let responsibleEntityOf = _prefixId.prefix "responsibleEntityOf"
    /// <summary>
    ///   <para>rdfs:label : revision</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A revision of an expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#revision">frbr:revision</a>
    /// </summary>
    let revision = _prefixId.prefix "revision"
    /// <summary>
    ///   <para>skos:definition : An expression that is revised.</para>
    ///   <para>rdfs:label : revision of</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#revisionOf">frbr:revisionOf</a>
    /// </summary>
    let revisionOf = _prefixId.prefix "revisionOf"
    /// <summary>
    ///   <para>skos:definition : The subject of a work.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://purl.org/vocab/frbr/core#subject">frbr:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : successor</para>
    ///   <para>skos:definition : A successor to a work or expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#successor">frbr:successor</a>
    /// </summary>
    let successor = _prefixId.prefix "successor"
    /// <summary>
    ///   <para>skos:definition : A work or expression that is succeeded.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : successor of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#successorOf">frbr:successorOf</a>
    /// </summary>
    let successorOf = _prefixId.prefix "successorOf"
    /// <summary>
    ///   <para>skos:definition : A summarization of a work or expression.</para>
    ///   <para>rdfs:label : summarization</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#summarization">frbr:summarization</a>
    /// </summary>
    let summarization = _prefixId.prefix "summarization"
    /// <summary>
    ///   <para>skos:definition : A work or expression that is summarized.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : summarization of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#summarizationOf">frbr:summarizationOf</a>
    /// </summary>
    let summarizationOf = _prefixId.prefix "summarizationOf"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A supplement to a work or expression.</para>
    ///   <para>rdfs:label : supplement</para>
    ///   <a href="http://purl.org/vocab/frbr/core#supplement">frbr:supplement</a>
    /// </summary>
    let supplement = _prefixId.prefix "supplement"
    /// <summary>
    ///   <para>rdfs:label : supplement of</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A work or expression that is supplemented.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#supplementOf">frbr:supplementOf</a>
    /// </summary>
    let supplementOf = _prefixId.prefix "supplementOf"
    /// <summary>
    ///   <para>rdfs:label : transformation</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A transformation of a work or expression.</para>
    ///   <a href="http://purl.org/vocab/frbr/core#transformation">frbr:transformation</a>
    /// </summary>
    let transformation = _prefixId.prefix "transformation"
    /// <summary>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>skos:definition : A work or expression that is transformed.</para>
    ///   <para>rdfs:label : transformation of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#transformationOf">frbr:transformationOf</a>
    /// </summary>
    let transformationOf = _prefixId.prefix "transformationOf"
    /// <summary>
    ///   <para>skos:definition : A translation of an expression.</para>
    ///   <para>rdfs:label : translation</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/frbr/core#translation">frbr:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>skos:definition : An expression that is translated.</para>
    ///   <para>dcterms:issued : 2005-07-15^^xsd:string</para>
    ///   <para>rdfs:label : translation of</para>
    ///   <a href="http://purl.org/vocab/frbr/core#translationOf">frbr:translationOf</a>
    /// </summary>
    let translationOf = _prefixId.prefix "translationOf"
