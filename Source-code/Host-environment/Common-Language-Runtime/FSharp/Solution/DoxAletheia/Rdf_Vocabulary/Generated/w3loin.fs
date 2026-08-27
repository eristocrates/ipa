namespace https.w3id.org.loin.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3loin =
    let _namespace_iri = Namespace_Iri w3loin |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:loin#Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actor is a contextual aspect according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Actor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#Actor">https://w3id.org/loin#Actor</seealso>
    let Actor = Prefixed_Name(w3loin, "Actor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#AlphanumericalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Alphanumerical information is a term for specifying the information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Alphanumerical information"</para></remarks>
    /// <seealso href="https://w3id.org/loin#AlphanumericalInformation">https://w3id.org/loin#AlphanumericalInformation</seealso>
    let AlphanumericalInformation =
        Prefixed_Name(w3loin, "AlphanumericalInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Appearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Appearance as a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Appearance"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Appearance">https://w3id.org/loin#Appearance</seealso>
    let Appearance = Prefixed_Name(w3loin, "Appearance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Bounds</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin/v2/ids#RestrictionType</para>
    ///   <para>"Bounds restriction specifies that the value is a number and has to fall within a range of values. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation."</para>
    /// labels<para>"Bounds restriction"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Bounds">https://w3id.org/loin#Bounds</seealso>
    let Bounds = Prefixed_Name(w3loin, "Bounds") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#BreakdownStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Breakdown structure is a term for positioning the object in a structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Breakdown structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#BreakdownStructure">https://w3id.org/loin#BreakdownStructure</seealso>
    let BreakdownStructure = Prefixed_Name(w3loin, "BreakdownStructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#BreakdownStructureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Breakdown structure type is a term to specify the structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Breakdown structure type"</para></remarks>
    /// <seealso href="https://w3id.org/loin#BreakdownStructureType">https://w3id.org/loin#BreakdownStructureType</seealso>
    let BreakdownStructureType =
        Prefixed_Name(w3loin, "BreakdownStructureType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#ClassificationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#BreakdownStructureType</para>
    ///   <para>"An example of breakdown structure type according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Classification system"</para></remarks>
    /// <seealso href="https://w3id.org/loin#ClassificationSystem">https://w3id.org/loin#ClassificationSystem</seealso>
    let ClassificationSystem =
        Prefixed_Name(w3loin, "ClassificationSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Codification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#IdentifierType</para>
    ///   <para>"An example of identifier type from a breakdown structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Codification of an item in a breakdown structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Codification">https://w3id.org/loin#Codification</seealso>
    let Codification = Prefixed_Name(w3loin, "Codification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Detail as a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Detail"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Detail">https://w3id.org/loin#Detail</seealso>
    let Detail = Prefixed_Name(w3loin, "Detail") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Dimensionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dimensionality as a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Dimensionality"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Dimensionality">https://w3id.org/loin#Dimensionality</seealso>
    let Dimensionality = Prefixed_Name(w3loin, "Dimensionality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#DocumentContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document specification for content for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Document content"</para></remarks>
    /// <seealso href="https://w3id.org/loin#DocumentContent">https://w3id.org/loin#DocumentContent</seealso>
    let DocumentContent = Prefixed_Name(w3loin, "DocumentContent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#DocumentFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document specification for format for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Document format"</para></remarks>
    /// <seealso href="https://w3id.org/loin#DocumentFormat">https://w3id.org/loin#DocumentFormat</seealso>
    let DocumentFormat = Prefixed_Name(w3loin, "DocumentFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#DocumentPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document purpose is a extension according to BS EN 17412-1 (2020) 6.4 Document - Example 1. It specifies the use of document"</para>
    /// labels<para>"Document purpose"</para></remarks>
    /// <seealso href="https://w3id.org/loin#DocumentPurpose">https://w3id.org/loin#DocumentPurpose</seealso>
    let DocumentPurpose = Prefixed_Name(w3loin, "DocumentPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#DocumentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Additional specification of document for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Document specification"</para></remarks>
    /// <seealso href="https://w3id.org/loin#DocumentSpecification">https://w3id.org/loin#DocumentSpecification</seealso>
    let DocumentSpecification =
        Prefixed_Name(w3loin, "DocumentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Documentation is a term for specifying the information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Documentation"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Documentation">https://w3id.org/loin#Documentation</seealso>
    let Documentation = Prefixed_Name(w3loin, "Documentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#EngineeringPrinciple</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#BreakdownStructureType</para>
    ///   <para>"An example of breakdown structure type according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Engineering principle"</para></remarks>
    /// <seealso href="https://w3id.org/loin#EngineeringPrinciple">https://w3id.org/loin#EngineeringPrinciple</seealso>
    let EngineeringPrinciple =
        Prefixed_Name(w3loin, "EngineeringPrinciple") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Enumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin/v2/ids#RestrictionType</para>
    ///   <para>"Enumeration restriction specifies that the value must be one of a list of allowed values. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation."</para>
    /// labels<para>"Enumeration restriction"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Enumeration">https://w3id.org/loin#Enumeration</seealso>
    let Enumeration = Prefixed_Name(w3loin, "Enumeration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#FederationStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#BreakdownStructureType</para>
    ///   <para>"An example of breakdown structure type according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Federation strategy"</para></remarks>
    /// <seealso href="https://w3id.org/loin#FederationStrategy">https://w3id.org/loin#FederationStrategy</seealso>
    let FederationStrategy = Prefixed_Name(w3loin, "FederationStrategy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Functional</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#BreakdownStructureType</para>
    ///   <para>"An example of breakdown structure type according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Functional structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Functional">https://w3id.org/loin#Functional</seealso>
    let Functional = Prefixed_Name(w3loin, "Functional") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#GeometricalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geometrical information is a term for specifying the information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Geometrical information"</para></remarks>
    /// <seealso href="https://w3id.org/loin#GeometricalInformation">https://w3id.org/loin#GeometricalInformation</seealso>
    let GeometricalInformation =
        Prefixed_Name(w3loin, "GeometricalInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#GeometrySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Additional specification of geometrical information for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Geometrical information specification"</para></remarks>
    /// <seealso href="https://w3id.org/loin#GeometrySpecification">https://w3id.org/loin#GeometrySpecification</seealso>
    let GeometrySpecification =
        Prefixed_Name(w3loin, "GeometrySpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Handdrawn_Sketches</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentContent</para>
    ///   <para>"Documents such as such as initial sketches, site plans according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Handdrawn sketches"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Handdrawn_Sketches">https://w3id.org/loin#Handdrawn_Sketches</seealso>
    let Handdrawn_Sketches = Prefixed_Name(w3loin, "Handdrawn_Sketches") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Hard_Copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentContent</para>
    ///   <para>"Documents of geometrical information or alphanumerical information can also be considered as documents according to notes of BS EN 17412-1 (2020)."</para>
    /// labels<para>"Hand copy"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Hard_Copy">https://w3id.org/loin#Hard_Copy</seealso>
    let Hard_Copy = Prefixed_Name(w3loin, "Hard_Copy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Identification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identification is a term for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Identification"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Identification">https://w3id.org/loin#Identification</seealso>
    let Identification = Prefixed_Name(w3loin, "Identification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identifier is used to assiging a vaule for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Identifier"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Identifier">https://w3id.org/loin#Identifier</seealso>
    let Identifier = Prefixed_Name(w3loin, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#IdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identifier type is used to specify the identifier in a breakdown structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Identifier type"</para></remarks>
    /// <seealso href="https://w3id.org/loin#IdentifierType">https://w3id.org/loin#IdentifierType</seealso>
    let IdentifierType = Prefixed_Name(w3loin, "IdentifierType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#IdentifierType</para>
    ///   <para>"Index, an identifier type according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Index of an item in a breakdown structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Index">https://w3id.org/loin#Index</seealso>
    let Index = Prefixed_Name(w3loin, "Index") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Proxy class for the three information specifications Alphanumerical Information, Geometrical Information, and Documentation"</para>
    /// labels<para>"Information"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Information">https://w3id.org/loin#Information</seealso>
    let Information = Prefixed_Name(w3loin, "Information") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#InformationContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Alphanumerical information content is a term for specifying the alphanumerical information according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Alphanumerical information content"</para></remarks>
    /// <seealso href="https://w3id.org/loin#InformationContent">https://w3id.org/loin#InformationContent</seealso>
    let InformationContent = Prefixed_Name(w3loin, "InformationContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#InformationDeliveryMilestone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information delivery milestone is a contextual aspect according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Information delivery milestone"</para></remarks>
    /// <seealso href="https://w3id.org/loin#InformationDeliveryMilestone">https://w3id.org/loin#InformationDeliveryMilestone</seealso>
    let InformationDeliveryMilestone =
        Prefixed_Name(w3loin, "InformationDeliveryMilestone") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin/v2/ids#RestrictionType</para>
    ///   <para>"Length restriction specifies the exact number of characters allowed in a value. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation."</para>
    /// labels<para>"Length restriction"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Length">https://w3id.org/loin#Length</seealso>
    let Length = Prefixed_Name(w3loin, "Length") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Location as a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Location">https://w3id.org/loin#Location</seealso>
    let Location = Prefixed_Name(w3loin, "Location") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentContent</para>
    ///   <para>"Documents such as maintenance and user manuals according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Manual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#Manual">https://w3id.org/loin#Manual</seealso>
    let Manual = Prefixed_Name(w3loin, "Manual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#IdentifierType</para>
    ///   <para>"Name, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Name of an item in a breakdown structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Name">https://w3id.org/loin#Name</seealso>
    let Name = Prefixed_Name(w3loin, "Name") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#NotRequested</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#GeometricalInformation</para>
    ///   <para>"Geometry information is not requested"</para>
    /// labels<para>"Geometry not requested"</para></remarks>
    /// <seealso href="https://w3id.org/loin#NotRequested">https://w3id.org/loin#NotRequested</seealso>
    let NotRequested = Prefixed_Name(w3loin, "NotRequested") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Numbering</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#IdentifierType</para>
    ///   <para>"Numbering, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Numbering of an item in a breakdown structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#Numbering">https://w3id.org/loin#Numbering</seealso>
    let Numbering = Prefixed_Name(w3loin, "Numbering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#OntologyDataDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ontology data definition is an extension of BS EN 17412-1 (2020). It is used to specify the alphanumerical information according to a published or customized ontology"</para>
    /// labels<para>"Ontology data definition"</para></remarks>
    /// <seealso href="https://w3id.org/loin#OntologyDataDefinition">https://w3id.org/loin#OntologyDataDefinition</seealso>
    let OntologyDataDefinition =
        Prefixed_Name(w3loin, "OntologyDataDefinition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#ParametricBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametric behaviour as a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Parametric behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/loin#ParametricBehaviour">https://w3id.org/loin#ParametricBehaviour</seealso>
    let ParametricBehaviour =
        Prefixed_Name(w3loin, "ParametricBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin/v2/ids#RestrictionType</para>
    ///   <para>"Pattern restriction with regex method specifies advanced pattern matching. In this ontology, it is defined as a restriction type, which specifies the restriction formulation."</para>
    /// labels<para>"Pattern restriction"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Pattern">https://w3id.org/loin#Pattern</seealso>
    let Pattern = Prefixed_Name(w3loin, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Photograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentContent</para>
    ///   <para>"Documents such as records of work done, records of existing conditions according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Photograph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#Photograph">https://w3id.org/loin#Photograph</seealso>
    let Photograph = Prefixed_Name(w3loin, "Photograph") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Provided_As_Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentPurpose</para>
    ///   <para>"The document delivered by Inquirer as percondition or information"</para>
    /// labels<para>"The document provided as information"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Provided_As_Information">https://w3id.org/loin#Provided_As_Information</seealso>
    let Provided_As_Information =
        Prefixed_Name(w3loin, "Provided_As_Information") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose is a contextual aspect according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#Purpose">https://w3id.org/loin#Purpose</seealso>
    let Purpose = Prefixed_Name(w3loin, "Purpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#ReceivingActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Receiving actor is a party for information delivery according to ISO 19650-1 (2018)"</para>
    /// labels<para>"Receiving actor"</para></remarks>
    /// <seealso href="https://w3id.org/loin#ReceivingActor">https://w3id.org/loin#ReceivingActor</seealso>
    let ReceivingActor = Prefixed_Name(w3loin, "ReceivingActor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#ReferenceOfStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#IdentifierType</para>
    ///   <para>"Reference, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Reference of an item in a breakdown structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#ReferenceOfStructure">https://w3id.org/loin#ReferenceOfStructure</seealso>
    let ReferenceOfStructure =
        Prefixed_Name(w3loin, "ReferenceOfStructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentContent</para>
    ///   <para>"Documents such as geotechnical reports, reports of existing building conditions, soil surveys, pre calculations according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#Report">https://w3id.org/loin#Report</seealso>
    let Report = Prefixed_Name(w3loin, "Report") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#RequiredDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document is a term for specifying the documentation of information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Document"</para></remarks>
    /// <seealso href="https://w3id.org/loin#RequiredDocument">https://w3id.org/loin#RequiredDocument</seealso>
    let RequiredDocument = Prefixed_Name(w3loin, "RequiredDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Required_For_Approval</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentPurpose</para>
    ///   <para>"The document required by deliverer is for getting approval"</para>
    /// labels<para>"document required for approval"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Required_For_Approval">https://w3id.org/loin#Required_For_Approval</seealso>
    let Required_For_Approval =
        Prefixed_Name(w3loin, "Required_For_Approval") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Required_with_Supplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentPurpose</para>
    ///   <para>"The document required by deliverer with supplement of information"</para>
    /// labels<para>"document required with supplement"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Required_with_Supplement">https://w3id.org/loin#Required_with_Supplement</seealso>
    let Required_with_Supplement =
        Prefixed_Name(w3loin, "Required_with_Supplement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#Semantic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#BreakdownStructureType</para>
    ///   <para>"An example of breakdown structure type according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Semantic structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Semantic">https://w3id.org/loin#Semantic</seealso>
    let Semantic = Prefixed_Name(w3loin, "Semantic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#SendingActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sending actor is a party for information delivery according to ISO 19650-1 (2018)"</para>
    /// labels<para>"Sending actor"</para></remarks>
    /// <seealso href="https://w3id.org/loin#SendingActor">https://w3id.org/loin#SendingActor</seealso>
    let SendingActor = Prefixed_Name(w3loin, "SendingActor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Signed_Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentContent</para>
    ///   <para>"Documents such as test certificates, insurance policies, delivery notes according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Signed document"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Signed_Document">https://w3id.org/loin#Signed_Document</seealso>
    let Signed_Document = Prefixed_Name(w3loin, "Signed_Document") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#SimpleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin/v2/ids#RestrictionType</para>
    ///   <para>"Simple value restriction specifies the exact allowed value. In this ontology, it is defined as a restriction type, which specifies the restriction formulation."</para>
    /// labels<para>"Simple value restriction"</para></remarks>
    /// <seealso href="https://w3id.org/loin#SimpleValue">https://w3id.org/loin#SimpleValue</seealso>
    let SimpleValue = Prefixed_Name(w3loin, "SimpleValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#BreakdownStructureType</para>
    ///   <para>"An example of breakdown structure type according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Spatial structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Spatial">https://w3id.org/loin#Spatial</seealso>
    let Spatial = Prefixed_Name(w3loin, "Spatial") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentContent</para>
    ///   <para>"Documents such as technical specifications according to notes according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Specification"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Specification">https://w3id.org/loin#Specification</seealso>
    let Specification = Prefixed_Name(w3loin, "Specification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#SpecificationPerObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SpecificationPerObjectType is a contextual aspect according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"Specification per Object Type"</para></remarks>
    /// <seealso href="https://w3id.org/loin#SpecificationPerObjectType">https://w3id.org/loin#SpecificationPerObjectType</seealso>
    let SpecificationPerObjectType =
        Prefixed_Name(w3loin, "SpecificationPerObjectType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#TypeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#IdentifierType</para>
    ///   <para>"Type name, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)"</para>
    /// labels<para>"Type name of an item in a breakdown structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#TypeName">https://w3id.org/loin#TypeName</seealso>
    let TypeName = Prefixed_Name(w3loin, "TypeName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#Used_As_Template</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#DocumentPurpose</para>
    ///   <para>"The document required by deliverer should be used as template"</para>
    /// labels<para>"The document as template"</para></remarks>
    /// <seealso href="https://w3id.org/loin#Used_As_Template">https://w3id.org/loin#Used_As_Template</seealso>
    let Used_As_Template = Prefixed_Name(w3loin, "Used_As_Template") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#absolute</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Location</para>
    ///   <para>"An example of location according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"Absolute location"</para></remarks>
    /// <seealso href="https://w3id.org/loin#absolute">https://w3id.org/loin#absolute</seealso>
    let absolute = Prefixed_Name(w3loin, "absolute") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#belongsToInformationContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specification of document, that relates with a respective person"</para>
    /// labels<para>"belongs to information content"</para></remarks>
    /// <seealso href="https://w3id.org/loin#belongsToInformationContent">https://w3id.org/loin#belongsToInformationContent</seealso>
    let belongsToInformationContent =
        Prefixed_Name(w3loin, "belongsToInformationContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#constructive</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#ParametricBehaviour</para>
    ///   <para>"An example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"constructive"</para></remarks>
    /// <seealso href="https://w3id.org/loin#constructive">https://w3id.org/loin#constructive</seealso>
    let constructive = Prefixed_Name(w3loin, "constructive") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#coordination</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Purpose</para>
    ///   <para>"coordination, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Coordination"</para></remarks>
    /// <seealso href="https://w3id.org/loin#coordination">https://w3id.org/loin#coordination</seealso>
    let coordination = Prefixed_Name(w3loin, "coordination") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#costEstimation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Purpose</para>
    ///   <para>"Cost estimation, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Cost estimation"</para></remarks>
    /// <seealso href="https://w3id.org/loin#costEstimation">https://w3id.org/loin#costEstimation</seealso>
    let costEstimation = Prefixed_Name(w3loin, "costEstimation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Description provide detail and extend of information derived by Information Delivery Specification (IDS)"</para>
    /// labels<para>"description"</para></remarks>
    /// <seealso href="https://w3id.org/loin#description">https://w3id.org/loin#description</seealso>
    let description = Prefixed_Name(w3loin, "description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#detailed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Detail</para>
    ///   <para>"Detail, an example of detail aspect according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"detailed"</para></remarks>
    /// <seealso href="https://w3id.org/loin#detailed">https://w3id.org/loin#detailed</seealso>
    let detailed = Prefixed_Name(w3loin, "detailed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#detailedDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#InformationDeliveryMilestone</para>
    ///   <para>"Detailed design, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Detailed design"</para></remarks>
    /// <seealso href="https://w3id.org/loin#detailedDesign">https://w3id.org/loin#detailedDesign</seealso>
    let detailedDesign = Prefixed_Name(w3loin, "detailedDesign") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#explicit</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#ParametricBehaviour</para>
    ///   <para>"Explicit, an example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"explicit"</para></remarks>
    /// <seealso href="https://w3id.org/loin#explicit">https://w3id.org/loin#explicit</seealso>
    let explicit = Prefixed_Name(w3loin, "explicit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#finalDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#InformationDeliveryMilestone</para>
    ///   <para>"Final design, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Final design"</para></remarks>
    /// <seealso href="https://w3id.org/loin#finalDesign">https://w3id.org/loin#finalDesign</seealso>
    let finalDesign = Prefixed_Name(w3loin, "finalDesign") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#fireSmokeSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Purpose</para>
    ///   <para>"Fire and smoke simulation, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Fire and smoke simulation"</para></remarks>
    /// <seealso href="https://w3id.org/loin#fireSmokeSimulation">https://w3id.org/loin#fireSmokeSimulation</seealso>
    let fireSmokeSimulation =
        Prefixed_Name(w3loin, "fireSmokeSimulation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information of the information delivery actor defined by foaf ontology mit class foaf:Agent"</para>
    /// labels<para>"has agent"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasAgent">https://w3id.org/loin#hasAgent</seealso>
    let hasAgent = Prefixed_Name(w3loin, "hasAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasAlphanumericalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates an alphanumerical information with a LOIN object according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has alphanumerical information"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasAlphanumericalInformation">https://w3id.org/loin#hasAlphanumericalInformation</seealso>
    let hasAlphanumericalInformation =
        Prefixed_Name(w3loin, "hasAlphanumericalInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasBreakdownStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the identification with a breakdown structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has breakdown structure"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasBreakdownStructure">https://w3id.org/loin#hasBreakdownStructure</seealso>
    let hasBreakdownStructure =
        Prefixed_Name(w3loin, "hasBreakdownStructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasBreakdownStructureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates a specific type with the breakdown structure according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has breakdown structure type"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasBreakdownStructureType">https://w3id.org/loin#hasBreakdownStructureType</seealso>
    let hasBreakdownStructureType =
        Prefixed_Name(w3loin, "hasBreakdownStructureType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasDataTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has data template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasDataTemplate">https://w3id.org/loin#hasDataTemplate</seealso>
    let hasDataTemplate = Prefixed_Name(w3loin, "hasDataTemplate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates a set of documents with documentation according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has document"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasDocument">https://w3id.org/loin#hasDocument</seealso>
    let hasDocument = Prefixed_Name(w3loin, "hasDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasDocumentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the document specifications with a document according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has documentaton specification"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasDocumentSpecification">https://w3id.org/loin#hasDocumentSpecification</seealso>
    let hasDocumentSpecification =
        Prefixed_Name(w3loin, "hasDocumentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the documentation with a LOIN object according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has documentation"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasDocumentation">https://w3id.org/loin#hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(w3loin, "hasDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasGeometricalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the geometrical information with a LOIN object according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has geometrical information"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasGeometricalInformation">https://w3id.org/loin#hasGeometricalInformation</seealso>
    let hasGeometricalInformation =
        Prefixed_Name(w3loin, "hasGeometricalInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasGeometrySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"["Appearance",
    /// "Detail",
    /// "Dimensionality",
    /// "Location",
    /// "ParametricBehaviour"]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The object property relates the specific aspects with geometrical information according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has geometrical information specification"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasGeometrySpecification">https://w3id.org/loin#hasGeometrySpecification</seealso>
    let hasGeometrySpecification =
        Prefixed_Name(w3loin, "hasGeometrySpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the identification of a breakdown structure with an alphanumerical information according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has identification"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasIdentification">https://w3id.org/loin#hasIdentification</seealso>
    let hasIdentification = Prefixed_Name(w3loin, "hasIdentification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates a breakdown structure with its identifier according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has identifier"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasIdentifier">https://w3id.org/loin#hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(w3loin, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates an identifier of breakdown structure with a specific type according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has identifier type"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasIdentifierType">https://w3id.org/loin#hasIdentifierType</seealso>
    let hasIdentifierType = Prefixed_Name(w3loin, "hasIdentifierType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proxy property for the three information specification relationships"</para>
    /// labels<para>"has information"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasInformation">https://w3id.org/loin#hasInformation</seealso>
    let hasInformation = Prefixed_Name(w3loin, "hasInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasInformationContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the detailed content with alphanumerical information according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has alphanumerical informaton content"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasInformationContent">https://w3id.org/loin#hasInformationContent</seealso>
    let hasInformationContent =
        Prefixed_Name(w3loin, "hasInformationContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has object type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasObjectType">https://w3id.org/loin#hasObjectType</seealso>
    let hasObjectType = Prefixed_Name(w3loin, "hasObjectType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the purpose with the information delivery milestone according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has purpose"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasPurpose">https://w3id.org/loin#hasPurpose</seealso>
    let hasPurpose = Prefixed_Name(w3loin, "hasPurpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasReceivingActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the receiver actor with the information delivery milestone according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has receiving actor"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasReceivingActor">https://w3id.org/loin#hasReceivingActor</seealso>
    let hasReceivingActor = Prefixed_Name(w3loin, "hasReceivingActor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasReferenceSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has reference source"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasReferenceSource">https://w3id.org/loin#hasReferenceSource</seealso>
    let hasReferenceSource = Prefixed_Name(w3loin, "hasReferenceSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasRequirementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates the requirement type with the defined requirements in IDS data definition"</para>
    /// labels<para>"has requirement type"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasRequirementType">https://w3id.org/loin#hasRequirementType</seealso>
    let hasRequirementType = Prefixed_Name(w3loin, "hasRequirementType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#hasSendingActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the sending actor with the information delivery milestone according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has has Sending Actor"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasSendingActor">https://w3id.org/loin#hasSendingActor</seealso>
    let hasSendingActor = Prefixed_Name(w3loin, "hasSendingActor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#hasSpecificationPerObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The specification per object type property relates the object type specifications with the information delivery milestone according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"has specification per object type"</para></remarks>
    /// <seealso href="https://w3id.org/loin#hasSpecificationPerObjectType">https://w3id.org/loin#hasSpecificationPerObjectType</seealso>
    let hasSpecificationPerObjectType =
        Prefixed_Name(w3loin, "hasSpecificationPerObjectType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#isRelatedToLoinDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the alphanumerical information content with document according to BS EN 17412-1(2020)"</para>
    /// labels<para>"is related to Loin document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#isRelatedToLoinDocument">https://w3id.org/loin#isRelatedToLoinDocument</seealso>
    let isRelatedToLoinDocument =
        Prefixed_Name(w3loin, "isRelatedToLoinDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#one-dimensional</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Dimensionality</para>
    ///   <para>"one-dimensional, an example of dimensionality according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"one-dimensional"</para></remarks>
    /// <seealso href="https://w3id.org/loin#one-dimensional">https://w3id.org/loin#one-dimensional</seealso>
    let one_dimensional = Prefixed_Name(w3loin, "one-dimensional") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#parametric</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#ParametricBehaviour</para>
    ///   <para>"Parametric, an example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"parametric"</para></remarks>
    /// <seealso href="https://w3id.org/loin#parametric">https://w3id.org/loin#parametric</seealso>
    let parametric = Prefixed_Name(w3loin, "parametric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#preliminaryDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#InformationDeliveryMilestone</para>
    ///   <para>"Preliminary design, an example of IDM information delivery milestone from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Preliminary design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#preliminaryDesign">https://w3id.org/loin#preliminaryDesign</seealso>
    let preliminaryDesign = Prefixed_Name(w3loin, "preliminaryDesign") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#real-world</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Appearance</para>
    ///   <para>"Real-world, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"real-world"</para></remarks>
    /// <seealso href="https://w3id.org/loin#real-world">https://w3id.org/loin#real-world</seealso>
    let real_world = Prefixed_Name(w3loin, "real-world") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#realistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Appearance</para>
    ///   <para>"realistic, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"realistic"</para></remarks>
    /// <seealso href="https://w3id.org/loin#realistic">https://w3id.org/loin#realistic</seealso>
    let realistic = Prefixed_Name(w3loin, "realistic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#relative</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Location</para>
    ///   <para>"Relative, an example of location according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"relative location"</para></remarks>
    /// <seealso href="https://w3id.org/loin#relative">https://w3id.org/loin#relative</seealso>
    let relative = Prefixed_Name(w3loin, "relative") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#requested</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"requested"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"requested as boolean, specifys if Geometrical information is needed according to BS EN 17412-1 (2020)"</para></remarks>
    /// <seealso href="https://w3id.org/loin#requested">https://w3id.org/loin#requested</seealso>
    let requested = Prefixed_Name(w3loin, "requested") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#simplified</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Detail</para>
    ///   <para>"simplified, an example of detail according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"simplified"</para></remarks>
    /// <seealso href="https://w3id.org/loin#simplified">https://w3id.org/loin#simplified</seealso>
    let simplified = Prefixed_Name(w3loin, "simplified") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#specifiedByIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specified by identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#specifiedByIdentifier">https://w3id.org/loin#specifiedByIdentifier</seealso>
    let specifiedByIdentifier =
        Prefixed_Name(w3loin, "specifiedByIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin#structuralAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Purpose</para>
    ///   <para>"Structural analysis, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Structural analysis"</para></remarks>
    /// <seealso href="https://w3id.org/loin#structuralAnalysis">https://w3id.org/loin#structuralAnalysis</seealso>
    let structuralAnalysis = Prefixed_Name(w3loin, "structuralAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#symbolic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Appearance</para>
    ///   <para>"symbolic, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)"</para>
    /// labels<para>"symbolic"</para></remarks>
    /// <seealso href="https://w3id.org/loin#symbolic">https://w3id.org/loin#symbolic</seealso>
    let symbolic = Prefixed_Name(w3loin, "symbolic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#three-dimensional</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Dimensionality</para>
    ///   <para>"Three-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"three-dimensional"</para></remarks>
    /// <seealso href="https://w3id.org/loin#three-dimensional">https://w3id.org/loin#three-dimensional</seealso>
    let three_dimensional = Prefixed_Name(w3loin, "three-dimensional") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#two-dimensional</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Dimensionality</para>
    ///   <para>"Two-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"two-dimensional"</para></remarks>
    /// <seealso href="https://w3id.org/loin#two-dimensional">https://w3id.org/loin#two-dimensional</seealso>
    let two_dimensional = Prefixed_Name(w3loin, "two-dimensional") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"value for general definition"</para>
    /// labels<para>"value"</para></remarks>
    /// <seealso href="https://w3id.org/loin#value">https://w3id.org/loin#value</seealso>
    let value = Prefixed_Name(w3loin, "value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#visualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Purpose</para>
    ///   <para>"Visualization, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B"</para>
    /// labels<para>"Visualization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin#visualization">https://w3id.org/loin#visualization</seealso>
    let visualization = Prefixed_Name(w3loin, "visualization") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin#zero-dimensional</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:loin#Dimensionality</para>
    ///   <para>"zero-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)"</para>
    /// labels<para>"zero-dimensional"</para></remarks>
    /// <seealso href="https://w3id.org/loin#zero-dimensional">https://w3id.org/loin#zero-dimensional</seealso>
    let zero_dimensional = Prefixed_Name(w3loin, "zero-dimensional") |> PrefixedName
