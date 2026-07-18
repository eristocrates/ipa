namespace http.purl.org.vocab.frbr.core.hash

open DoxAletheia.Rdf_Vocabulary

module frbrcore =
    let _namespace_name = "http://purl.org/vocab/frbr/core#"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#ClassicalWork"></see>
    /// </summary>
    let ClassicalWork =
        Namespaced_IRI.parse _namespace_name "ClassicalWork" |> NamespacedName

    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Work'.
    /// <see href="http://purl.org/vocab/frbr/core#Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Concept'.
    /// <see href="http://purl.org/vocab/frbr/core#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName
    /// <summary>
    /// This class represents any of the FRBR group three entities.
    /// <see href="http://purl.org/vocab/frbr/core#Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Place'.
    /// <see href="http://purl.org/vocab/frbr/core#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Object'.
    /// <see href="http://purl.org/vocab/frbr/core#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// This class corresponds to the FRBR group three entity 'Event'.
    /// <see href="http://purl.org/vocab/frbr/core#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// This class corresponds to the FRBR group two entity 'Corporate Body'.
    /// <see href="http://purl.org/vocab/frbr/core#CorporateBody"></see></summary>
    let CorporateBody =
        Namespaced_IRI.parse _namespace_name "CorporateBody" |> NamespacedName

    /// <summary>
    /// This class represents any of the FRBR group two entities.
    /// <see href="http://purl.org/vocab/frbr/core#ResponsibleEntity"></see></summary>
    let ResponsibleEntity =
        Namespaced_IRI.parse _namespace_name "ResponsibleEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Expression'.
    /// <see href="http://purl.org/vocab/frbr/core#Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName
    /// <summary>
    /// This class represents any one of the FRBR group one entities.
    /// <see href="http://purl.org/vocab/frbr/core#Endeavour"></see></summary>
    let Endeavour = Namespaced_IRI.parse _namespace_name "Endeavour" |> NamespacedName
    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Item'.
    /// <see href="http://purl.org/vocab/frbr/core#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    /// This class corresponds to the FRBR group one entity 'Manifestation'.
    /// <see href="http://purl.org/vocab/frbr/core#Manifestation"></see></summary>
    let Manifestation =
        Namespaced_IRI.parse _namespace_name "Manifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#LegalWork"></see>
    /// </summary>
    let LegalWork = Namespaced_IRI.parse _namespace_name "LegalWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#LiteraryWork"></see>
    /// </summary>
    let LiteraryWork =
        Namespaced_IRI.parse _namespace_name "LiteraryWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#MovingImage"></see>
    /// </summary>
    let MovingImage =
        Namespaced_IRI.parse _namespace_name "MovingImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Performance"></see>
    /// </summary>
    let Performance =
        Namespaced_IRI.parse _namespace_name "Performance" |> NamespacedName

    /// <summary>
    /// This class corresponds to the FRBR group two entity 'Person'.
    /// <see href="http://purl.org/vocab/frbr/core#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#ScholarlyWork"></see>
    /// </summary>
    let ScholarlyWork =
        Namespaced_IRI.parse _namespace_name "ScholarlyWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Sound"></see>
    /// </summary>
    let Sound = Namespaced_IRI.parse _namespace_name "Sound" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#Text"></see>
    /// </summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#abridgement"></see>
    /// </summary>
    let abridgement =
        Namespaced_IRI.parse _namespace_name "abridgement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#relatedEndeavour"></see>
    /// </summary>
    let relatedEndeavour =
        Namespaced_IRI.parse _namespace_name "relatedEndeavour" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#abridgementOf"></see>
    /// </summary>
    let abridgementOf =
        Namespaced_IRI.parse _namespace_name "abridgementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#adaption"></see>
    /// </summary>
    let adaption = Namespaced_IRI.parse _namespace_name "adaption" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#adaptionOf"></see>
    /// </summary>
    let adaptionOf = Namespaced_IRI.parse _namespace_name "adaptionOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#alternate"></see>
    /// </summary>
    let alternate = Namespaced_IRI.parse _namespace_name "alternate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#alternateOf"></see>
    /// </summary>
    let alternateOf =
        Namespaced_IRI.parse _namespace_name "alternateOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#arrangement"></see>
    /// </summary>
    let arrangement =
        Namespaced_IRI.parse _namespace_name "arrangement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#arrangementOf"></see>
    /// </summary>
    let arrangementOf =
        Namespaced_IRI.parse _namespace_name "arrangementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#complement"></see>
    /// </summary>
    let complement = Namespaced_IRI.parse _namespace_name "complement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#complementOf"></see>
    /// </summary>
    let complementOf =
        Namespaced_IRI.parse _namespace_name "complementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#creator"></see>
    /// </summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#responsibleEntity"></see>
    /// </summary>
    let responsibleEntity =
        Namespaced_IRI.parse _namespace_name "responsibleEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#creatorOf"></see>
    /// </summary>
    let creatorOf = Namespaced_IRI.parse _namespace_name "creatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#responsibleEntityOf"></see>
    /// </summary>
    let responsibleEntityOf =
        Namespaced_IRI.parse _namespace_name "responsibleEntityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#embodiment"></see>
    /// </summary>
    let embodiment = Namespaced_IRI.parse _namespace_name "embodiment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#embodimentOf"></see>
    /// </summary>
    let embodimentOf =
        Namespaced_IRI.parse _namespace_name "embodimentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#exemplar"></see>
    /// </summary>
    let exemplar = Namespaced_IRI.parse _namespace_name "exemplar" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#exemplarOf"></see>
    /// </summary>
    let exemplarOf = Namespaced_IRI.parse _namespace_name "exemplarOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#imitation"></see>
    /// </summary>
    let imitation = Namespaced_IRI.parse _namespace_name "imitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#imitationOf"></see>
    /// </summary>
    let imitationOf =
        Namespaced_IRI.parse _namespace_name "imitationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#ownerOf"></see>
    /// </summary>
    let ownerOf = Namespaced_IRI.parse _namespace_name "ownerOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#part"></see>
    /// </summary>
    let part = Namespaced_IRI.parse _namespace_name "part" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#partOf"></see>
    /// </summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#producer"></see>
    /// </summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#producerOf"></see>
    /// </summary>
    let producerOf = Namespaced_IRI.parse _namespace_name "producerOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realization"></see>
    /// </summary>
    let realization =
        Namespaced_IRI.parse _namespace_name "realization" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realizationOf"></see>
    /// </summary>
    let realizationOf =
        Namespaced_IRI.parse _namespace_name "realizationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realizer"></see>
    /// </summary>
    let realizer = Namespaced_IRI.parse _namespace_name "realizer" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#realizerOf"></see>
    /// </summary>
    let realizerOf = Namespaced_IRI.parse _namespace_name "realizerOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reconfiguration"></see>
    /// </summary>
    let reconfiguration =
        Namespaced_IRI.parse _namespace_name "reconfiguration" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reconfigurationOf"></see>
    /// </summary>
    let reconfigurationOf =
        Namespaced_IRI.parse _namespace_name "reconfigurationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reproduction"></see>
    /// </summary>
    let reproduction =
        Namespaced_IRI.parse _namespace_name "reproduction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#reproductionOf"></see>
    /// </summary>
    let reproductionOf =
        Namespaced_IRI.parse _namespace_name "reproductionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#revision"></see>
    /// </summary>
    let revision = Namespaced_IRI.parse _namespace_name "revision" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#revisionOf"></see>
    /// </summary>
    let revisionOf = Namespaced_IRI.parse _namespace_name "revisionOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#successor"></see>
    /// </summary>
    let successor = Namespaced_IRI.parse _namespace_name "successor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#successorOf"></see>
    /// </summary>
    let successorOf =
        Namespaced_IRI.parse _namespace_name "successorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#summarization"></see>
    /// </summary>
    let summarization =
        Namespaced_IRI.parse _namespace_name "summarization" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#summarizationOf"></see>
    /// </summary>
    let summarizationOf =
        Namespaced_IRI.parse _namespace_name "summarizationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#supplement"></see>
    /// </summary>
    let supplement = Namespaced_IRI.parse _namespace_name "supplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#supplementOf"></see>
    /// </summary>
    let supplementOf =
        Namespaced_IRI.parse _namespace_name "supplementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#transformation"></see>
    /// </summary>
    let transformation =
        Namespaced_IRI.parse _namespace_name "transformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#transformationOf"></see>
    /// </summary>
    let transformationOf =
        Namespaced_IRI.parse _namespace_name "transformationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#translation"></see>
    /// </summary>
    let translation =
        Namespaced_IRI.parse _namespace_name "translation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/core#translationOf"></see>
    /// </summary>
    let translationOf =
        Namespaced_IRI.parse _namespace_name "translationOf" |> NamespacedName
