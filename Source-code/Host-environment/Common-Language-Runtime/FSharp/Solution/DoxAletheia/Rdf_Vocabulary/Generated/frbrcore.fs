namespace http.purl.org.vocab.frbr.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frbrcore =
    let _namespace_iri = Namespace_Iri frbrcore |> NamespaceIRI
    /// <summary>
    ///   <para>frbrcore:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>performance</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Performance">http://purl.org/vocab/frbr/core#Performance</seealso>
    let Performance = Prefixed_Name(frbrcore, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group two entity 'Person'.</para>
    /// labels<para>person</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Person">http://purl.org/vocab/frbr/core#Person</seealso>
    let Person = Prefixed_Name(frbrcore, "Person") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:ScholarlyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>scholarly work</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ScholarlyWork">http://purl.org/vocab/frbr/core#ScholarlyWork</seealso>
    let ScholarlyWork = Prefixed_Name(frbrcore, "ScholarlyWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>sound</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Sound">http://purl.org/vocab/frbr/core#Sound</seealso>
    let Sound = Prefixed_Name(frbrcore, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>text</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Text">http://purl.org/vocab/frbr/core#Text</seealso>
    let Text = Prefixed_Name(frbrcore, "Text") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:abridgement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>abridgement</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#abridgement">http://purl.org/vocab/frbr/core#abridgement</seealso>
    let abridgement = Prefixed_Name(frbrcore, "abridgement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:relatedEndeavour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>related endeavour</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#relatedEndeavour">http://purl.org/vocab/frbr/core#relatedEndeavour</seealso>
    let relatedEndeavour = Prefixed_Name(frbrcore, "relatedEndeavour") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:abridgementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>abridgement of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#abridgementOf">http://purl.org/vocab/frbr/core#abridgementOf</seealso>
    let abridgementOf = Prefixed_Name(frbrcore, "abridgementOf") |> PrefixedName
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
    /// labels<para>classical work</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ClassicalWork">http://purl.org/vocab/frbr/core#ClassicalWork</seealso>
    let ClassicalWork = Prefixed_Name(frbrcore, "ClassicalWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:supplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supplement</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#supplement">http://purl.org/vocab/frbr/core#supplement</seealso>
    let supplement = Prefixed_Name(frbrcore, "supplement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:supplementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supplement of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#supplementOf">http://purl.org/vocab/frbr/core#supplementOf</seealso>
    let supplementOf = Prefixed_Name(frbrcore, "supplementOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>transformation</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#transformation">http://purl.org/vocab/frbr/core#transformation</seealso>
    let transformation = Prefixed_Name(frbrcore, "transformation") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:transformationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>transformation of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#transformationOf">http://purl.org/vocab/frbr/core#transformationOf</seealso>
    let transformationOf = Prefixed_Name(frbrcore, "transformationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>translation</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#translation">http://purl.org/vocab/frbr/core#translation</seealso>
    let translation = Prefixed_Name(frbrcore, "translation") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:translationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>translation of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#translationOf">http://purl.org/vocab/frbr/core#translationOf</seealso>
    let translationOf = Prefixed_Name(frbrcore, "translationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:CorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group two entity 'Corporate Body'.</para>
    /// labels<para>corporate body</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#CorporateBody">http://purl.org/vocab/frbr/core#CorporateBody</seealso>
    let CorporateBody = Prefixed_Name(frbrcore, "CorporateBody") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:alternate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>alternate</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#alternate">http://purl.org/vocab/frbr/core#alternate</seealso>
    let alternate = Prefixed_Name(frbrcore, "alternate") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:alternateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>alternate of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#alternateOf">http://purl.org/vocab/frbr/core#alternateOf</seealso>
    let alternateOf = Prefixed_Name(frbrcore, "alternateOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:arrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>arrangement</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#arrangement">http://purl.org/vocab/frbr/core#arrangement</seealso>
    let arrangement = Prefixed_Name(frbrcore, "arrangement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>complement</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#complement">http://purl.org/vocab/frbr/core#complement</seealso>
    let complement = Prefixed_Name(frbrcore, "complement") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:complementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>complement of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#complementOf">http://purl.org/vocab/frbr/core#complementOf</seealso>
    let complementOf = Prefixed_Name(frbrcore, "complementOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>creator</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#creator">http://purl.org/vocab/frbr/core#creator</seealso>
    let creator = Prefixed_Name(frbrcore, "creator") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:responsibleEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>responsible entity</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#responsibleEntity">http://purl.org/vocab/frbr/core#responsibleEntity</seealso>
    let responsibleEntity = Prefixed_Name(frbrcore, "responsibleEntity") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:creatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>creator of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#creatorOf">http://purl.org/vocab/frbr/core#creatorOf</seealso>
    let creatorOf = Prefixed_Name(frbrcore, "creatorOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:embodiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>embodiment</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#embodiment">http://purl.org/vocab/frbr/core#embodiment</seealso>
    let embodiment = Prefixed_Name(frbrcore, "embodiment") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:embodimentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>embodiment of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#embodimentOf">http://purl.org/vocab/frbr/core#embodimentOf</seealso>
    let embodimentOf = Prefixed_Name(frbrcore, "embodimentOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:exemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>exemplar</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#exemplar">http://purl.org/vocab/frbr/core#exemplar</seealso>
    let exemplar = Prefixed_Name(frbrcore, "exemplar") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:exemplarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>exemplar of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#exemplarOf">http://purl.org/vocab/frbr/core#exemplarOf</seealso>
    let exemplarOf = Prefixed_Name(frbrcore, "exemplarOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:imitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>imitation</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#imitation">http://purl.org/vocab/frbr/core#imitation</seealso>
    let imitation = Prefixed_Name(frbrcore, "imitation") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:imitationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>imitation of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#imitationOf">http://purl.org/vocab/frbr/core#imitationOf</seealso>
    let imitationOf = Prefixed_Name(frbrcore, "imitationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#owner">http://purl.org/vocab/frbr/core#owner</seealso>
    let owner = Prefixed_Name(frbrcore, "owner") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:ownerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>owner of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ownerOf">http://purl.org/vocab/frbr/core#ownerOf</seealso>
    let ownerOf = Prefixed_Name(frbrcore, "ownerOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>part</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#part">http://purl.org/vocab/frbr/core#part</seealso>
    let part = Prefixed_Name(frbrcore, "part") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>part of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#partOf">http://purl.org/vocab/frbr/core#partOf</seealso>
    let partOf = Prefixed_Name(frbrcore, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>producer</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#producer">http://purl.org/vocab/frbr/core#producer</seealso>
    let producer = Prefixed_Name(frbrcore, "producer") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:producerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>producer of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#producerOf">http://purl.org/vocab/frbr/core#producerOf</seealso>
    let producerOf = Prefixed_Name(frbrcore, "producerOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>realization</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realization">http://purl.org/vocab/frbr/core#realization</seealso>
    let realization = Prefixed_Name(frbrcore, "realization") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>realization of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realizationOf">http://purl.org/vocab/frbr/core#realizationOf</seealso>
    let realizationOf = Prefixed_Name(frbrcore, "realizationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>realizer</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realizer">http://purl.org/vocab/frbr/core#realizer</seealso>
    let realizer = Prefixed_Name(frbrcore, "realizer") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:realizerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>realizer of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#realizerOf">http://purl.org/vocab/frbr/core#realizerOf</seealso>
    let realizerOf = Prefixed_Name(frbrcore, "realizerOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reconfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reconfiguration</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reconfiguration">http://purl.org/vocab/frbr/core#reconfiguration</seealso>
    let reconfiguration = Prefixed_Name(frbrcore, "reconfiguration") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reconfigurationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reconfiguration of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reconfigurationOf">http://purl.org/vocab/frbr/core#reconfigurationOf</seealso>
    let reconfigurationOf = Prefixed_Name(frbrcore, "reconfigurationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reproduction</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reproduction">http://purl.org/vocab/frbr/core#reproduction</seealso>
    let reproduction = Prefixed_Name(frbrcore, "reproduction") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:reproductionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reproduction of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#reproductionOf">http://purl.org/vocab/frbr/core#reproductionOf</seealso>
    let reproductionOf = Prefixed_Name(frbrcore, "reproductionOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>revision</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#revision">http://purl.org/vocab/frbr/core#revision</seealso>
    let revision = Prefixed_Name(frbrcore, "revision") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:revisionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>revision of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#revisionOf">http://purl.org/vocab/frbr/core#revisionOf</seealso>
    let revisionOf = Prefixed_Name(frbrcore, "revisionOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#subject">http://purl.org/vocab/frbr/core#subject</seealso>
    let subject = Prefixed_Name(frbrcore, "subject") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Endeavour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents any one of the FRBR group one entities.</para>
    /// labels<para>endeavour</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Endeavour">http://purl.org/vocab/frbr/core#Endeavour</seealso>
    let Endeavour = Prefixed_Name(frbrcore, "Endeavour") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group one entity 'Item'.</para>
    /// labels<para>item</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Item">http://purl.org/vocab/frbr/core#Item</seealso>
    let Item = Prefixed_Name(frbrcore, "Item") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents any of the FRBR group three entities.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Subject">http://purl.org/vocab/frbr/core#Subject</seealso>
    let Subject = Prefixed_Name(frbrcore, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group one entity 'Work'.</para>
    /// labels<para>work</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Work">http://purl.org/vocab/frbr/core#Work</seealso>
    let Work = Prefixed_Name(frbrcore, "Work") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group three entity 'Object'.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Object">http://purl.org/vocab/frbr/core#Object</seealso>
    let Object = Prefixed_Name(frbrcore, "Object") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group three entity 'Place'.</para>
    /// labels<para>place</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Place">http://purl.org/vocab/frbr/core#Place</seealso>
    let Place = Prefixed_Name(frbrcore, "Place") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:ResponsibleEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents any of the FRBR group two entities.</para>
    /// labels<para>responsible entity</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#ResponsibleEntity">http://purl.org/vocab/frbr/core#ResponsibleEntity</seealso>
    let ResponsibleEntity = Prefixed_Name(frbrcore, "ResponsibleEntity") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group one entity 'Expression'.</para>
    /// labels<para>expression</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Expression">http://purl.org/vocab/frbr/core#Expression</seealso>
    let Expression = Prefixed_Name(frbrcore, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:adaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>adaption</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#adaption">http://purl.org/vocab/frbr/core#adaption</seealso>
    let adaption = Prefixed_Name(frbrcore, "adaption") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:adaptionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>adaption of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#adaptionOf">http://purl.org/vocab/frbr/core#adaptionOf</seealso>
    let adaptionOf = Prefixed_Name(frbrcore, "adaptionOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>data</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Data">http://purl.org/vocab/frbr/core#Data</seealso>
    let Data = Prefixed_Name(frbrcore, "Data") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:arrangementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>arrangement of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#arrangementOf">http://purl.org/vocab/frbr/core#arrangementOf</seealso>
    let arrangementOf = Prefixed_Name(frbrcore, "arrangementOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group one entity 'Manifestation'.</para>
    /// labels<para>manifestation</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Manifestation">http://purl.org/vocab/frbr/core#Manifestation</seealso>
    let Manifestation = Prefixed_Name(frbrcore, "Manifestation") |> PrefixedName

    /// <summary>
    ///   <para>frbrcore:responsibleEntityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>responsible entity of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#responsibleEntityOf">http://purl.org/vocab/frbr/core#responsibleEntityOf</seealso>
    let responsibleEntityOf =
        Prefixed_Name(frbrcore, "responsibleEntityOf") |> PrefixedName

    /// <summary>
    ///   <para>frbrcore:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>image</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Image">http://purl.org/vocab/frbr/core#Image</seealso>
    let Image = Prefixed_Name(frbrcore, "Image") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:LegalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>legal work</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#LegalWork">http://purl.org/vocab/frbr/core#LegalWork</seealso>
    let LegalWork = Prefixed_Name(frbrcore, "LegalWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:successor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>successor</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#successor">http://purl.org/vocab/frbr/core#successor</seealso>
    let successor = Prefixed_Name(frbrcore, "successor") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:LiteraryWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>literary work</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#LiteraryWork">http://purl.org/vocab/frbr/core#LiteraryWork</seealso>
    let LiteraryWork = Prefixed_Name(frbrcore, "LiteraryWork") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:successorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>successor of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#successorOf">http://purl.org/vocab/frbr/core#successorOf</seealso>
    let successorOf = Prefixed_Name(frbrcore, "successorOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:MovingImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>moving image</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#MovingImage">http://purl.org/vocab/frbr/core#MovingImage</seealso>
    let MovingImage = Prefixed_Name(frbrcore, "MovingImage") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:summarization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>summarization</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#summarization">http://purl.org/vocab/frbr/core#summarization</seealso>
    let summarization = Prefixed_Name(frbrcore, "summarization") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:summarizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>summarization of</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#summarizationOf">http://purl.org/vocab/frbr/core#summarizationOf</seealso>
    let summarizationOf = Prefixed_Name(frbrcore, "summarizationOf") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group three entity 'Concept'.</para>
    /// labels<para>concept</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Concept">http://purl.org/vocab/frbr/core#Concept</seealso>
    let Concept = Prefixed_Name(frbrcore, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>frbrcore:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class corresponds to the FRBR group three entity 'Event'.</para>
    /// labels<para>event</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/core#Event">http://purl.org/vocab/frbr/core#Event</seealso>
    let Event = Prefixed_Name(frbrcore, "Event") |> PrefixedName
