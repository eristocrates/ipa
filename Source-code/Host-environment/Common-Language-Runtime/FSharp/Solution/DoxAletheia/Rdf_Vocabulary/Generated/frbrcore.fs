namespace http.purl.org.vocab.frbr.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frbrcore =
    let _namespace_iri = Namespace_Iri frbrcore |> NamespaceIRI
    /// <summary>
    ///   <para>frbrcore:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#">http://purl.org/vocab/frbr/core#</seealso>
    let _prefix_iri = Prefixed_Name(frbrcore, "") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:ClassicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"classical work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ClassicalWork">http://purl.org/vocab/frbr/core#ClassicalWork</seealso>
    let ClassicalWork = Prefixed_Name(frbrcore, "ClassicalWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract notion or idea.
    ///
    /// The entity defined as concept encompasses a comprehensive range of abstractions that may be the subject of a work: fields of knowledge, disciplines, schools of thought (philosophies, religions, political ideologies, etc.), theories, processes, techniques, practices, etc.  A concept may be broad in nature or narrowly defined and precise. "</para>
    ///   <para>"This class corresponds to the FRBR group three entity 'Concept'."</para>
    /// labels<para>"concept"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Concept">http://purl.org/vocab/frbr/core#Concept</seealso>
    let Concept = Prefixed_Name(frbrcore, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:CorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class corresponds to the FRBR group two entity 'Corporate Body'."</para>
    ///   <para>"An organization or group of individuals and/or organizations acting as a unit.
    ///
    /// The entity defined as corporate body encompasses organizations and groups of individuals and/or organizations that are identified by a particular name, including occasional groups and groups that are constituted as meetings, conferences, congresses, expeditions, exhibitions, festivals, fairs, etc."</para>
    /// labels<para>"corporate body"</para><para>"the union of all organizations and groups"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#CorporateBody">http://purl.org/vocab/frbr/core#CorporateBody</seealso>
    let CorporateBody = Prefixed_Name(frbrcore, "CorporateBody") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Data">http://purl.org/vocab/frbr/core#Data</seealso>
    let Data = Prefixed_Name(frbrcore, "Data") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Endeavour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents any one of the FRBR group one entities."</para>
    ///   <para>"It describes different aspects of user interests in the products of intellectual or artistic artifact."</para>
    /// labels<para>"the union of all expressions, items, manifestations and works"</para><para>"endeavour"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Endeavour">http://purl.org/vocab/frbr/core#Endeavour</seealso>
    let Endeavour = Prefixed_Name(frbrcore, "Endeavour") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action or occurrence.
    ///
    /// The entity defined as event encompasses a comprehensive range of actions and occurrences that may be the subject of a work: historical events, epochs, periods of time, etc. "</para>
    ///   <para>"This class corresponds to the FRBR group three entity 'Event'."</para>
    /// labels<para>"event"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Event">http://purl.org/vocab/frbr/core#Event</seealso>
    let Event = Prefixed_Name(frbrcore, "Event") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The intellectual or artistic realization of a work in the form of alpha-numeric, musical, or choreographic notation, sound, image, object, movement, etc., or any combination of such forms.
    ///
    /// An expression is the specific intellectual or artistic form that a work takes each time it is "realized." Expression encompasses, for example, the specific words, sentences, paragraphs, etc. that result from the realization of a work in the form of a text, or the particular sounds, phrasing, etc. resulting from the realization of a musical work."</para>
    ///   <para>"This class corresponds to the FRBR group one entity 'Expression'."</para>
    /// labels<para>"expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Expression">http://purl.org/vocab/frbr/core#Expression</seealso>
    let Expression = Prefixed_Name(frbrcore, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"image"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Image">http://purl.org/vocab/frbr/core#Image</seealso>
    let Image = Prefixed_Name(frbrcore, "Image") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Item is a single instance of a Document. Availability information is directly connected to single items."</para>
    ///   <para>"A single exemplar of a manifestation.
    ///
    /// The entity defined as item is a concrete entity. It is in many instances a single physical object (e.g., a copy of a one-volume monograph, a single audio cassette, etc.). There are instances, however, where the entity defined as item comprises more than one physical object (e.g., a monograph issued as two separately bound volumes, a recording issued on three separate compact discs, etc.). "</para>
    ///   <para>"Every Item is also a document (frbr:Item rdfs:subClassOf bibo:Document."</para>
    ///   <para>"This class corresponds to the FRBR group one entity 'Item'."</para>
    /// labels<para>"item"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Item">http://purl.org/vocab/frbr/core#Item</seealso>
    let Item = Prefixed_Name(frbrcore, "Item") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:LegalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#LegalWork">http://purl.org/vocab/frbr/core#LegalWork</seealso>
    let LegalWork = Prefixed_Name(frbrcore, "LegalWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:LiteraryWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"literary work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#LiteraryWork">http://purl.org/vocab/frbr/core#LiteraryWork</seealso>
    let LiteraryWork = Prefixed_Name(frbrcore, "LiteraryWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class corresponds to the FRBR group one entity 'Manifestation'."</para>
    ///   <para>"The physical embodiment of an expression of a work.
    ///
    /// The entity defined as manifestation encompasses a wide range of materials and formats. As an entity, manifestation represents all the physical objects that bear the same characteristics, in respect to both intellectual content and physical form. "</para>
    /// labels<para>"manifestation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Manifestation">http://purl.org/vocab/frbr/core#Manifestation</seealso>
    let Manifestation = Prefixed_Name(frbrcore, "Manifestation") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:MovingImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"moving image"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#MovingImage">http://purl.org/vocab/frbr/core#MovingImage</seealso>
    let MovingImage = Prefixed_Name(frbrcore, "MovingImage") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class corresponds to the FRBR group three entity 'Object'."</para>
    ///   <para>"A material thing.
    ///
    /// The entity defined as object encompasses a comprehensive range of material things that may be the subject of a work: animate and inanimate objects occurring in nature; fixed, movable, and moving objects that are the product of human creation; objects that no longer exist. "</para>
    /// labels<para>"object"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Object">http://purl.org/vocab/frbr/core#Object</seealso>
    let Object = Prefixed_Name(frbrcore, "Object") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"performance"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Performance">http://purl.org/vocab/frbr/core#Performance</seealso>
    let Performance = Prefixed_Name(frbrcore, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class corresponds to the FRBR group two entity 'Person'."</para>
    ///   <para>"An individual. The entity defined as person encompasses individuals that are deceased as well as those that are living."</para>
    /// labels<para>"person"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Person">http://purl.org/vocab/frbr/core#Person</seealso>
    let Person = Prefixed_Name(frbrcore, "Person") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class corresponds to the FRBR group three entity 'Place'."</para>
    ///   <para>"A location.
    ///
    /// The entity defined as place encompasses a comprehensive range of locations: terrestrial and extra-terrestrial; historical and contemporary; geographic features and geo-political jurisdictions. "</para>
    /// labels<para>"place"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Place">http://purl.org/vocab/frbr/core#Place</seealso>
    let Place = Prefixed_Name(frbrcore, "Place") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:ResponsibleEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents any of the FRBR group two entities."</para>
    ///   <para>"It represents those responsible for the intellectual or artistic content, the physical production and dissemination, or the custodianship of any endeavour."</para>
    /// labels<para>"responsible entity"</para><para>"the union of all people and corporate bodies"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ResponsibleEntity">http://purl.org/vocab/frbr/core#ResponsibleEntity</seealso>
    let ResponsibleEntity = Prefixed_Name(frbrcore, "ResponsibleEntity") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:ScholarlyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scholarly work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ScholarlyWork">http://purl.org/vocab/frbr/core#ScholarlyWork</seealso>
    let ScholarlyWork = Prefixed_Name(frbrcore, "ScholarlyWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sound"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Sound">http://purl.org/vocab/frbr/core#Sound</seealso>
    let Sound = Prefixed_Name(frbrcore, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents an additional set of entities that serve as the subjects of works."</para>
    ///   <para>"This class represents any of the FRBR group three entities."</para>
    /// labels<para>"subject"</para><para>"the union of all events, objects, places and concepts"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Subject">http://purl.org/vocab/frbr/core#Subject</seealso>
    let Subject = Prefixed_Name(frbrcore, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"text"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Text">http://purl.org/vocab/frbr/core#Text</seealso>
    let Text = Prefixed_Name(frbrcore, "Text") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A distinct intellectual or artistic creation.
    ///
    /// A work is an abstract entity; there is no single material object one can point to as the work. We recognize the work through individual realizations or expressions of the work, but the work itself exists only in the commonality of content between and among the various expressions of the work. When we speak of Homer's Iliad as a work, our point of reference is not a particular recitation or text of the work, but the intellectual creation that lies behind all the various expressions of the work. "</para>
    ///   <para>"This class corresponds to the FRBR group one entity 'Work'."</para>
    /// labels<para>"work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Work">http://purl.org/vocab/frbr/core#Work</seealso>
    let Work = Prefixed_Name(frbrcore, "Work") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:abridgement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression abridged in another one.
    ///
    /// In the abridged expression some content of the previous expression is removed, but the result does not alter the content to the extent that it becomes a new work. The expressions resulting from such modification are generally autonomous in nature (i.e., they do not normally require reference to the prior expression in order to be used or understood). "</para>
    /// labels<para>"abridgement"</para><para>"has abridgement"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#abridgement">http://purl.org/vocab/frbr/core#abridgement</seealso>
    let abridgement = Prefixed_Name(frbrcore, "abridgement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:abridgementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the entire expression of an abridged one."</para>
    /// labels<para>"abridgement of"</para><para>"is abridgement of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#abridgementOf">http://purl.org/vocab/frbr/core#abridgementOf</seealso>
    let abridgementOf = Prefixed_Name(frbrcore, "abridgementOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:adaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A work/expression adapted in another one.
    ///
    /// This property describe the modification of an original work that is sufficient in degree to warrant their being considered as new works, rather than simply different expressions of the same work. If there exists a relation of this kind among two different expressions, they always refer to different works."</para>
    /// labels<para>"has adaption"</para><para>"adaption"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#adaption">http://purl.org/vocab/frbr/core#adaption</seealso>
    let adaption = Prefixed_Name(frbrcore, "adaption") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:adaptionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the work/expression of an adapted one."</para>
    /// labels<para>"is adaption of"</para><para>"adaption of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#adaptionOf">http://purl.org/vocab/frbr/core#adaptionOf</seealso>
    let adaptionOf = Prefixed_Name(frbrcore, "adaptionOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:alternate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A manifestation having another one as alternate.
    ///
    /// The alternate relationship involves manifestations that effectively serve as alternates for each other. The alternate relationship obtains, for example, when a publication, sound recording, video, etc. is issued in more than one format or when it is released simultaneously by different publishers in different countries."</para>
    /// labels<para>"alternate"</para><para>"has alternate"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#alternate">http://purl.org/vocab/frbr/core#alternate</seealso>
    let alternate = Prefixed_Name(frbrcore, "alternate") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:alternateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the manifestation of an alternative one."</para>
    /// labels<para>"is alternate of"</para><para>"alternate of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#alternateOf">http://purl.org/vocab/frbr/core#alternateOf</seealso>
    let alternateOf = Prefixed_Name(frbrcore, "alternateOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:arrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression arranged in another one.
    ///
    /// In the arranged expression some content of the previous expression is changed in some way, but the result does not alter the content to the extent that it becomes a new work. The expressions resulting from such modification are generally autonomous in nature (i.e., they do not normally require reference to the prior expression in order to be used or understood)."</para>
    /// labels<para>"arrangement"</para><para>"has arrangement"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#arrangement">http://purl.org/vocab/frbr/core#arrangement</seealso>
    let arrangement = Prefixed_Name(frbrcore, "arrangement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:arrangementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the original expression of an arranged one."</para>
    /// labels<para>"arrangement of"</para><para>"is arrangement of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#arrangementOf">http://purl.org/vocab/frbr/core#arrangementOf</seealso>
    let arrangementOf = Prefixed_Name(frbrcore, "arrangementOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression work/expression having another one as complement.
    ///
    /// This property describes works that are intended to be combined with or inserted into the related work. In other words, they are intended to be integrated in some way with the other work, but were not part of the original conception of that prior work. If there exists a relation of this kind among two different expressions, then they always refer to different works."</para>
    /// labels<para>"has complement"</para><para>"complement"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#complement">http://purl.org/vocab/frbr/core#complement</seealso>
    let complement = Prefixed_Name(frbrcore, "complement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:complementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the work/expression of that is a complement of another one."</para>
    /// labels<para>"is complement of"</para><para>"complement of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#complementOf">http://purl.org/vocab/frbr/core#complementOf</seealso>
    let complementOf = Prefixed_Name(frbrcore, "complementOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A work linked to its creator."</para>
    /// labels<para>"has creator"</para><para>"creator"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#creator">http://purl.org/vocab/frbr/core#creator</seealso>
    let creator = Prefixed_Name(frbrcore, "creator") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:creatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The creator of a particular work."</para>
    /// labels<para>"creator of"</para><para>"is creator of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#creatorOf">http://purl.org/vocab/frbr/core#creatorOf</seealso>
    let creatorOf = Prefixed_Name(frbrcore, "creatorOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:embodiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression embodied in a manifestation."</para>
    ///   <para>"As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#embodiment), a property representing a manifestation that embodies an expression."</para>
    /// labels<para>"embodiment"</para><para>"has embodiment"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#embodiment">http://purl.org/vocab/frbr/core#embodiment</seealso>
    let embodiment = Prefixed_Name(frbrcore, "embodiment") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:embodimentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#embodimentOf), a property representing an expression that is embodied by a manifestation."</para>
    ///   <para>"A manifestation that embodies an expression."</para>
    /// labels<para>"embodiment of"</para><para>"is embodiment of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#embodimentOf">http://purl.org/vocab/frbr/core#embodimentOf</seealso>
    let embodimentOf = Prefixed_Name(frbrcore, "embodimentOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:exemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A manifestation exemplified in an item."</para>
    ///   <para>"As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#exemplar), a property representing an item that exemplifies a manifestation."</para>
    /// labels<para>"exemplar"</para><para>"has exemplar"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#exemplar">http://purl.org/vocab/frbr/core#exemplar</seealso>
    let exemplar = Prefixed_Name(frbrcore, "exemplar") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:exemplarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An item that exemplifies a manifestation."</para>
    ///   <para>"As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#embodimentOf), a property representing a manifestation that is exemplified by an item."</para>
    /// labels<para>"exemplar of"</para><para>"is exemplar of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#exemplarOf">http://purl.org/vocab/frbr/core#exemplarOf</seealso>
    let exemplarOf = Prefixed_Name(frbrcore, "exemplarOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:imitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An work/expression imitated in another one.
    ///
    /// This property describes works that are intended to be an imitation another original work that is sufficient in degree to warrant their being considered as new works, rather than simply different expressions of the same work. If there exists a relation of this kind among two different expressions, then they always refer to different works."</para>
    /// labels<para>"has imitation"</para><para>"imitation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#imitation">http://purl.org/vocab/frbr/core#imitation</seealso>
    let imitation = Prefixed_Name(frbrcore, "imitation") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:imitationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the work/expression of an imitated one."</para>
    /// labels<para>"is imitation of"</para><para>"imitation of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#imitationOf">http://purl.org/vocab/frbr/core#imitationOf</seealso>
    let imitationOf = Prefixed_Name(frbrcore, "imitationOf") |> PrefixedName

    /// <summary>
    ///   <para>frbrcore:isReferentiallyRelatedToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#isReferentiallyRelatedToExpression">http://purl.org/vocab/frbr/core#isReferentiallyRelatedToExpression</seealso>
    let isReferentiallyRelatedToExpression =
        Prefixed_Name(frbrcore, "isReferentiallyRelatedToExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbrcore:isReferentiallyRelatedToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#isReferentiallyRelatedToWork">http://purl.org/vocab/frbr/core#isReferentiallyRelatedToWork</seealso>
    let isReferentiallyRelatedToWork =
        Prefixed_Name(frbrcore, "isReferentiallyRelatedToWork") |> PrefixedName

    /// <summary>
    ///   <para>frbrcore:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An item linked to its owner."</para>
    /// labels<para>"owner"</para><para>"has owner"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#owner">http://purl.org/vocab/frbr/core#owner</seealso>
    let owner = Prefixed_Name(frbrcore, "owner") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:ownerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The owner of a particular item."</para>
    /// labels<para>"is owner of"</para><para>"owner of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ownerOf">http://purl.org/vocab/frbr/core#ownerOf</seealso>
    let ownerOf = Prefixed_Name(frbrcore, "ownerOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Meaning = has part.  As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#part),  a property indicating that one entity includes another entity."</para>
    ///   <para>"A part of an endeavour."</para>
    /// labels<para>"part"</para><para>"has part"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#part">http://purl.org/vocab/frbr/core#part</seealso>
    let part = Prefixed_Name(frbrcore, "part") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Meaning = is part of.  As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#partOf), a property indicating that one entity is a part of another entity."</para>
    ///   <para>"An endeavour incorporating another endeavour."</para>
    /// labels<para>"part of"</para><para>"is part of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#partOf">http://purl.org/vocab/frbr/core#partOf</seealso>
    let partOf = Prefixed_Name(frbrcore, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A manifestation linked to its prodecer."</para>
    /// labels<para>"has producer"</para><para>"producer"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#producer">http://purl.org/vocab/frbr/core#producer</seealso>
    let producer = Prefixed_Name(frbrcore, "producer") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:producerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The producer of a particular manifestation."</para>
    /// labels<para>"producer of"</para><para>"is producer of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#producerOf">http://purl.org/vocab/frbr/core#producerOf</seealso>
    let producerOf = Prefixed_Name(frbrcore, "producerOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#realization), a property representing an expression that is an intellectual or artistic realization of a work."</para>
    ///   <para>"A work realized through an expression."</para>
    /// labels<para>"realization"</para><para>"has realization"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realization">http://purl.org/vocab/frbr/core#realization</seealso>
    let realization = Prefixed_Name(frbrcore, "realization") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"As defined by FRBR (http://www.ifla.org/VII/s13/frbr/frbr1.htm; http://purl.org/vocab/frbr/core#realizationOf), a property representing the work that has been realized by an expression."</para>
    ///   <para>"An expression that realizes a work."</para>
    /// labels<para>"realization of"</para><para>"is realization of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realizationOf">http://purl.org/vocab/frbr/core#realizationOf</seealso>
    let realizationOf = Prefixed_Name(frbrcore, "realizationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression linked to its realizer."</para>
    /// labels<para>"has realizer"</para><para>"realizer"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realizer">http://purl.org/vocab/frbr/core#realizer</seealso>
    let realizer = Prefixed_Name(frbrcore, "realizer") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realizerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The realizer of a particular expression."</para>
    /// labels<para>"realizer of"</para><para>"is realizer of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realizerOf">http://purl.org/vocab/frbr/core#realizerOf</seealso>
    let realizerOf = Prefixed_Name(frbrcore, "realizerOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reconfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An item reconfigured in another one.
    ///
    /// The reconfiguration relationship is one in which one or more items are changed in such a way that a new item or items result. Most commonly, an item of one manifestation is bound with an item of a different manifestation to make a new item. "</para>
    /// labels<para>"has reconfiguration"</para><para>"reconfiguration"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reconfiguration">http://purl.org/vocab/frbr/core#reconfiguration</seealso>
    let reconfiguration = Prefixed_Name(frbrcore, "reconfiguration") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reconfigurationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the manifestation of a reconfigured one."</para>
    /// labels<para>"is reconfiguration of"</para><para>"reconfiguration of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reconfigurationOf">http://purl.org/vocab/frbr/core#reconfigurationOf</seealso>
    let reconfigurationOf = Prefixed_Name(frbrcore, "reconfigurationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:relatedEndeavour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has related endeavour"</para><para>"related endeavour"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#relatedEndeavour">http://purl.org/vocab/frbr/core#relatedEndeavour</seealso>
    let relatedEndeavour = Prefixed_Name(frbrcore, "relatedEndeavour") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A manifestation/item reproduced in another one.
    ///
    /// A reproduction indicates the relationship as it would be drawn from the first manifestation/item in the relationship to the second manifestation/item in the relationship."</para>
    /// labels<para>"reproduction"</para><para>"has reproduction"</para><para>"a manifestation or an item"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reproduction">http://purl.org/vocab/frbr/core#reproduction</seealso>
    let reproduction = Prefixed_Name(frbrcore, "reproduction") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reproductionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the manifestation/item of a reproduced one."</para>
    /// labels<para>"reproduction of"</para><para>"a manifestation or an item"</para><para>"is reproduction of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reproductionOf">http://purl.org/vocab/frbr/core#reproductionOf</seealso>
    let reproductionOf = Prefixed_Name(frbrcore, "reproductionOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:responsibleEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Any endeavour having a particular entity that is responsible of it."</para>
    /// labels<para>"responsible entity"</para><para>"has responsible entity"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#responsibleEntity">http://purl.org/vocab/frbr/core#responsibleEntity</seealso>
    let responsibleEntity = Prefixed_Name(frbrcore, "responsibleEntity") |> PrefixedName

    /// <summary>
    ///   <para>frbrcore:responsibleEntityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An entity that is resposible for a particular endeavour."</para>
    /// labels<para>"is responsible entity of"</para><para>"responsible entity of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#responsibleEntityOf">http://purl.org/vocab/frbr/core#responsibleEntityOf</seealso>
    let responsibleEntityOf =
        Prefixed_Name(frbrcore, "responsibleEntityOf") |> PrefixedName

    /// <summary>
    ///   <para>frbrcore:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression revised in another one.
    ///
    /// A revision has the intent to alter or update the content of the prior expression, but without changing the content so much that it becomes a new work."</para>
    /// labels<para>"revision"</para><para>"has revision"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#revision">http://purl.org/vocab/frbr/core#revision</seealso>
    let revision = Prefixed_Name(frbrcore, "revision") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:revisionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the previous expression of a revised one."</para>
    /// labels<para>"revision of"</para><para>"is revision of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#revisionOf">http://purl.org/vocab/frbr/core#revisionOf</seealso>
    let revisionOf = Prefixed_Name(frbrcore, "revisionOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A work linked to a particular subject it is talking about."</para>
    /// labels<para>"has subject"</para><para>"subject"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#subject">http://purl.org/vocab/frbr/core#subject</seealso>
    let subject = Prefixed_Name(frbrcore, "subject") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:subjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A subject a work talks abbout."</para>
    /// labels<para>"is subject of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#subjectOf">http://purl.org/vocab/frbr/core#subjectOf</seealso>
    let subjectOf = Prefixed_Name(frbrcore, "subjectOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:successor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression work/expression having another one as successor.
    ///
    /// The successor type of relationship involves a kind of linear progression of content from one work/expression to the other. In some cases, the content of the successor may be closely connected to the content of the preceding work, which would result in a work that is referential. In others, such as with loosely connected parts of a trilogy, the successor will be autonomous. Serial publications that result from the merger or split of their predecessors and stand on their own without requiring reference to the predecessor are also examples of autonomous works that fall within the successor relationship type. If there exists a relation of this kind among two different expressions, then they always refer to different works."</para>
    /// labels<para>"has successor"</para><para>"successor"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#successor">http://purl.org/vocab/frbr/core#successor</seealso>
    let successor = Prefixed_Name(frbrcore, "successor") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:successorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"It identifies the previous work/expression of a succeeded one."</para>
    /// labels<para>"successor of"</para><para>"is successor of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#successorOf">http://purl.org/vocab/frbr/core#successorOf</seealso>
    let successorOf = Prefixed_Name(frbrcore, "successorOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:summarization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A work/expression summarized in another one.
    ///
    /// This property describe the summarization of an original work that is sufficient in degree to warrant their being considered as new works, rather than simply different expressions of the same work. If there exists a relation of this kind among two different expressions, they always refer to different works."</para>
    /// labels<para>"summarization"</para><para>"has summarization"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#summarization">http://purl.org/vocab/frbr/core#summarization</seealso>
    let summarization = Prefixed_Name(frbrcore, "summarization") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:summarizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the original work/expression of a summarized one."</para>
    /// labels<para>"is summarization of"</para><para>"summarization of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#summarizationOf">http://purl.org/vocab/frbr/core#summarizationOf</seealso>
    let summarizationOf = Prefixed_Name(frbrcore, "summarizationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:supplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression work/expression having another one as supplement.
    ///
    /// The supplement relationship type involves works/expressions that are intended to be used in conjunction with another work/expression. Some of these, such as indices, concordances, teachers' guides, glosses, and instruction manuals for electronic resources will be so closely associated with the content of the related work/expression that they are useless without the other work/expression."</para>
    /// labels<para>"has supplement"</para><para>"supplement"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#supplement">http://purl.org/vocab/frbr/core#supplement</seealso>
    let supplement = Prefixed_Name(frbrcore, "supplement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:supplementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the work/expression of a particular supplement of it."</para>
    /// labels<para>"is supplement of"</para><para>"supplement of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#supplementOf">http://purl.org/vocab/frbr/core#supplementOf</seealso>
    let supplementOf = Prefixed_Name(frbrcore, "supplementOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An work/expression transformed in another one.
    ///
    /// This property describes the transformation of an original work or expression into another work or expression that is sufficiently different in degree to warrant the product of the transformation being considered as a new work or expression, rather than simply a different expression of the original work. If there exists a frbr:transformation relation between two different expressions, then they always relate to different works."</para>
    /// labels<para>"transformation"</para><para>"has transformation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#transformation">http://purl.org/vocab/frbr/core#transformation</seealso>
    let transformation = Prefixed_Name(frbrcore, "transformation") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:transformationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It identifies the original work/expression of a trasformed one."</para>
    /// labels<para>"is transformation of"</para><para>"transformation of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#transformationOf">http://purl.org/vocab/frbr/core#transformationOf</seealso>
    let transformationOf = Prefixed_Name(frbrcore, "transformationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression translated in another one.
    ///
    /// It allows to refer to a literal translation, in which the intent is to render the intellectual content of the previous expression as accurately as possible."</para>
    /// labels<para>"has translation"</para><para>"translation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#translation">http://purl.org/vocab/frbr/core#translation</seealso>
    let translation = Prefixed_Name(frbrcore, "translation") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:translationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"It identifies the original expression of a translated one."</para>
    /// labels<para>"is translation of"</para><para>"translation of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#translationOf">http://purl.org/vocab/frbr/core#translationOf</seealso>
    let translationOf = Prefixed_Name(frbrcore, "translationOf") |> PrefixedName
