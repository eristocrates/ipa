namespace http.purl.org.vocab.frbr.core.hash

open DoxAletheia

module frbrcore =
    let _namespace_name = "http://purl.org/vocab/frbr/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#ClassicalWork"></see>
    /// </summary>
    let ClassicalWork = _prefix "ClassicalWork"
    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Work'.
    /// <see href="http://purl.org/vocab/frbr/core#Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Concept'.
    /// <see href="http://purl.org/vocab/frbr/core#Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// This class represents any of the FRBR group three entities.
    /// <see href="http://purl.org/vocab/frbr/core#Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Place'.
    /// <see href="http://purl.org/vocab/frbr/core#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Object'.
    /// <see href="http://purl.org/vocab/frbr/core#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Event'.
    /// <see href="http://purl.org/vocab/frbr/core#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// This class corresponds to the FRBR group two entity 'Corporate Body'.
    /// <see href="http://purl.org/vocab/frbr/core#CorporateBody"></see></summary>
    let CorporateBody = _prefix "CorporateBody"
    /// <summary>
    /// This class represents any of the FRBR group two entities.
    /// <see href="http://purl.org/vocab/frbr/core#ResponsibleEntity"></see></summary>
    let ResponsibleEntity = _prefix "ResponsibleEntity"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Expression'.
    /// <see href="http://purl.org/vocab/frbr/core#Expression"></see></summary>
    let Expression = _prefix "Expression"
    /// <summary>
    /// This class represents any one of the FRBR group one entities.
    /// <see href="http://purl.org/vocab/frbr/core#Endeavour"></see></summary>
    let Endeavour = _prefix "Endeavour"
    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Item'.
    /// <see href="http://purl.org/vocab/frbr/core#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Manifestation'.
    /// <see href="http://purl.org/vocab/frbr/core#Manifestation"></see></summary>
    let Manifestation = _prefix "Manifestation"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#LegalWork"></see>
    /// </summary>
    let LegalWork = _prefix "LegalWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#LiteraryWork"></see>
    /// </summary>
    let LiteraryWork = _prefix "LiteraryWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#MovingImage"></see>
    /// </summary>
    let MovingImage = _prefix "MovingImage"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Performance"></see>
    /// </summary>
    let Performance = _prefix "Performance"
    /// <summary>
    /// This class corresponds to the FRBR group two entity 'Person'.
    /// <see href="http://purl.org/vocab/frbr/core#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#ScholarlyWork"></see>
    /// </summary>
    let ScholarlyWork = _prefix "ScholarlyWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Sound"></see>
    /// </summary>
    let Sound = _prefix "Sound"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Text"></see>
    /// </summary>
    let Text = _prefix "Text"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#abridgement"></see>
    /// </summary>
    let abridgement = _prefix "abridgement"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#relatedEndeavour"></see>
    /// </summary>
    let relatedEndeavour = _prefix "relatedEndeavour"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#abridgementOf"></see>
    /// </summary>
    let abridgementOf = _prefix "abridgementOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#adaption"></see>
    /// </summary>
    let adaption = _prefix "adaption"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#adaptionOf"></see>
    /// </summary>
    let adaptionOf = _prefix "adaptionOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#alternate"></see>
    /// </summary>
    let alternate = _prefix "alternate"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#alternateOf"></see>
    /// </summary>
    let alternateOf = _prefix "alternateOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#arrangement"></see>
    /// </summary>
    let arrangement = _prefix "arrangement"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#arrangementOf"></see>
    /// </summary>
    let arrangementOf = _prefix "arrangementOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#complement"></see>
    /// </summary>
    let complement = _prefix "complement"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#complementOf"></see>
    /// </summary>
    let complementOf = _prefix "complementOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#creator"></see>
    /// </summary>
    let creator = _prefix "creator"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#responsibleEntity"></see>
    /// </summary>
    let responsibleEntity = _prefix "responsibleEntity"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#creatorOf"></see>
    /// </summary>
    let creatorOf = _prefix "creatorOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#responsibleEntityOf"></see>
    /// </summary>
    let responsibleEntityOf = _prefix "responsibleEntityOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#embodiment"></see>
    /// </summary>
    let embodiment = _prefix "embodiment"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#embodimentOf"></see>
    /// </summary>
    let embodimentOf = _prefix "embodimentOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#exemplar"></see>
    /// </summary>
    let exemplar = _prefix "exemplar"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#exemplarOf"></see>
    /// </summary>
    let exemplarOf = _prefix "exemplarOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#imitation"></see>
    /// </summary>
    let imitation = _prefix "imitation"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#imitationOf"></see>
    /// </summary>
    let imitationOf = _prefix "imitationOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#ownerOf"></see>
    /// </summary>
    let ownerOf = _prefix "ownerOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#part"></see>
    /// </summary>
    let part = _prefix "part"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#partOf"></see>
    /// </summary>
    let partOf = _prefix "partOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#producer"></see>
    /// </summary>
    let producer = _prefix "producer"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#producerOf"></see>
    /// </summary>
    let producerOf = _prefix "producerOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realization"></see>
    /// </summary>
    let realization = _prefix "realization"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realizationOf"></see>
    /// </summary>
    let realizationOf = _prefix "realizationOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realizer"></see>
    /// </summary>
    let realizer = _prefix "realizer"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realizerOf"></see>
    /// </summary>
    let realizerOf = _prefix "realizerOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reconfiguration"></see>
    /// </summary>
    let reconfiguration = _prefix "reconfiguration"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reconfigurationOf"></see>
    /// </summary>
    let reconfigurationOf = _prefix "reconfigurationOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reproduction"></see>
    /// </summary>
    let reproduction = _prefix "reproduction"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reproductionOf"></see>
    /// </summary>
    let reproductionOf = _prefix "reproductionOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#revision"></see>
    /// </summary>
    let revision = _prefix "revision"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#revisionOf"></see>
    /// </summary>
    let revisionOf = _prefix "revisionOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#successor"></see>
    /// </summary>
    let successor = _prefix "successor"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#successorOf"></see>
    /// </summary>
    let successorOf = _prefix "successorOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#summarization"></see>
    /// </summary>
    let summarization = _prefix "summarization"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#summarizationOf"></see>
    /// </summary>
    let summarizationOf = _prefix "summarizationOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#supplement"></see>
    /// </summary>
    let supplement = _prefix "supplement"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#supplementOf"></see>
    /// </summary>
    let supplementOf = _prefix "supplementOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#transformation"></see>
    /// </summary>
    let transformation = _prefix "transformation"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#transformationOf"></see>
    /// </summary>
    let transformationOf = _prefix "transformationOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#translation"></see>
    /// </summary>
    let translation = _prefix "translation"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#translationOf"></see>
    /// </summary>
    let translationOf = _prefix "translationOf"
