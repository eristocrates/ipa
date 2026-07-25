namespace http.w3id.org.CEON.ontology.resourceODP.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_resourceODP =
    let _namespace_iri = Namespace_Iri ceon_resourceODP |> NamespaceIRI
    /// <summary>
    ///   <para>ceon-resourceODP:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/">http://w3id.org/CEON/ontology/resourceODP/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_resourceODP, "") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:BatchOfObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A batch of objects is a collection of physical objects that are of the same type, e.g. a set of items (product instances) adhering to the same product model.</para>
    /// labels<para>Batch Of Objects</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/BatchOfObjects">http://w3id.org/CEON/ontology/resourceODP/BatchOfObjects</seealso>
    let BatchOfObjects =
        Prefixed_Name(ceon_resourceODP, "BatchOfObjects") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:hasPhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasPhysicalObject intends to represent that a batch of objects or a set of objects can have composing components of physical objects.</para>
    /// labels<para>has physical object</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasPhysicalObject">http://w3id.org/CEON/ontology/resourceODP/hasPhysicalObject</seealso>
    let hasPhysicalObject =
        Prefixed_Name(ceon_resourceODP, "hasPhysicalObject") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:0.5/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/0.5/">http://w3id.org/CEON/ontology/resourceODP/0.5/</seealso>
    let ``_0.5/`` = Prefixed_Name(ceon_resourceODP, "0.5/") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical object is a collection of matter.</para>
    /// labels<para>Physical object</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/PhysicalObject">http://w3id.org/CEON/ontology/resourceODP/PhysicalObject</seealso>
    let PhysicalObject =
        Prefixed_Name(ceon_resourceODP, "PhysicalObject") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:Constituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A constituent is a component of object.</para>
    /// labels<para>Constituent</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/Constituent">http://w3id.org/CEON/ontology/resourceODP/Constituent</seealso>
    let Constituent = Prefixed_Name(ceon_resourceODP, "Constituent") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:batchSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>batchSize intends to repsent how many physical objects are belong to a batch of objects.</para>
    /// labels<para>batch size</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/batchSize">http://w3id.org/CEON/ontology/resourceODP/batchSize</seealso>
    let batchSize = Prefixed_Name(ceon_resourceODP, "batchSize") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Asset from which a solution is created or implemented. Depending on the context, reference to “resource” includes “raw material”, “feedstock”, “material” or “component”. Resource includes any energy type (e.g. the energy content or energy potential of materials). Note 4 to entry: Resources can be considered concerning both stocks and flows.</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/Resource">http://w3id.org/CEON/ontology/resourceODP/Resource</seealso>
    let Resource = Prefixed_Name(ceon_resourceODP, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:DigitalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A digital object, e.g. a computer file, that is located on some server, hard drive, or on the web. Most often the digital object is the realization of some piece of information.</para>
    /// labels<para>Digital object</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/DigitalObject">http://w3id.org/CEON/ontology/resourceODP/DigitalObject</seealso>
    let DigitalObject = Prefixed_Name(ceon_resourceODP, "DigitalObject") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:Matter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A matter is a physical substance.</para>
    /// labels<para>Matter</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/Matter">http://w3id.org/CEON/ontology/resourceODP/Matter</seealso>
    let Matter = Prefixed_Name(ceon_resourceODP, "Matter") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:hasMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasMatter intends to represent that a physical object can have a collection of matter.</para>
    /// labels<para>has matter</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasMatter">http://w3id.org/CEON/ontology/resourceODP/hasMatter</seealso>
    let hasMatter = Prefixed_Name(ceon_resourceODP, "hasMatter") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:ResourceCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of a resource.</para>
    /// labels<para>Resource Condition</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/ResourceCondition">http://w3id.org/CEON/ontology/resourceODP/ResourceCondition</seealso>
    let ResourceCondition =
        Prefixed_Name(ceon_resourceODP, "ResourceCondition") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:hasResourceCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource can has specifc conditions.</para>
    /// labels<para>has resource condition</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasResourceCondition">http://w3id.org/CEON/ontology/resourceODP/hasResourceCondition</seealso>
    let hasResourceCondition =
        Prefixed_Name(ceon_resourceODP, "hasResourceCondition") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:hasResourceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource can has specifc properties.</para>
    /// labels<para>has resource property</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasResourceProperty">http://w3id.org/CEON/ontology/resourceODP/hasResourceProperty</seealso>
    let hasResourceProperty =
        Prefixed_Name(ceon_resourceODP, "hasResourceProperty") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:ResourceQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource quality is derived based on assessments of resources considering the conditions and properties.</para>
    /// labels<para>Resource Quality</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/ResourceQuality">http://w3id.org/CEON/ontology/resourceODP/ResourceQuality</seealso>
    let ResourceQuality =
        Prefixed_Name(ceon_resourceODP, "ResourceQuality") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:SetOfObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of objects is a set of physical objects (items) that can be of different types, i.e. different kinds of items.</para>
    /// labels<para>Set of objects</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/SetOfObjects">http://w3id.org/CEON/ontology/resourceODP/SetOfObjects</seealso>
    let SetOfObjects = Prefixed_Name(ceon_resourceODP, "SetOfObjects") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:hasBatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasBatch intends to represent that a set of objects can be captured by a number of batches where each batch contains a number of physical objects.</para>
    /// labels<para>has batch</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasBatch">http://w3id.org/CEON/ontology/resourceODP/hasBatch</seealso>
    let hasBatch = Prefixed_Name(ceon_resourceODP, "hasBatch") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information is an abstract concept that represents any kind of interpretations. For instance, information can be data generated by software systems or data used by people for communications.</para>
    /// labels<para>Information</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/Information">http://w3id.org/CEON/ontology/resourceODP/Information</seealso>
    let Information = Prefixed_Name(ceon_resourceODP, "Information") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:hasConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasConstitutent intends to represent that a physical object can have a collection of composing components.</para>
    /// labels<para>has constituent</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasConstituent">http://w3id.org/CEON/ontology/resourceODP/hasConstituent</seealso>
    let hasConstituent =
        Prefixed_Name(ceon_resourceODP, "hasConstituent") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:ResourceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The characteristics or attribuets of a resource.</para>
    /// labels<para>Resource Property</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/ResourceProperty">http://w3id.org/CEON/ontology/resourceODP/ResourceProperty</seealso>
    let ResourceProperty =
        Prefixed_Name(ceon_resourceODP, "ResourceProperty") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:hasResourceQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource can has specifc qualities.</para>
    /// labels<para>has resource quality</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasResourceQuality">http://w3id.org/CEON/ontology/resourceODP/hasResourceQuality</seealso>
    let hasResourceQuality =
        Prefixed_Name(ceon_resourceODP, "hasResourceQuality") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:batchID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>identifier for a batch</para>
    /// labels<para>batch ID</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/batchID">http://w3id.org/CEON/ontology/resourceODP/batchID</seealso>
    let batchID = Prefixed_Name(ceon_resourceODP, "batchID") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicating that something is part of or is contained by something else.</para>
    /// labels<para>has part</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasPart">http://w3id.org/CEON/ontology/resourceODP/hasPart</seealso>
    let hasPart = Prefixed_Name(ceon_resourceODP, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:batchLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>label for a batch</para>
    /// labels<para>batch label</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/batchLabel">http://w3id.org/CEON/ontology/resourceODP/batchLabel</seealso>
    let batchLabel = Prefixed_Name(ceon_resourceODP, "batchLabel") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:containsInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicating that some piece of information is contained in a larger collection of information, e.g. a data sheet contains a statement about a certain parameter of a product.</para>
    /// labels<para>contains information</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/containsInformation">http://w3id.org/CEON/ontology/resourceODP/containsInformation</seealso>
    let containsInformation =
        Prefixed_Name(ceon_resourceODP, "containsInformation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:isRealizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a thing, e.g. a digital object, or a physical object, to the information it is a realization of. C.f. a physical book that is the realization of a novel, or a pdf or Excel-file that is a realization of a certain data sheet.</para>
    /// labels<para>is realization of</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/isRealizationOf">http://w3id.org/CEON/ontology/resourceODP/isRealizationOf</seealso>
    let isRealizationOf =
        Prefixed_Name(ceon_resourceODP, "isRealizationOf") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:hasResourceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the location of a resource.</para>
    /// labels<para>has resource location</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/hasResourceLocation">http://w3id.org/CEON/ontology/resourceODP/hasResourceLocation</seealso>
    let hasResourceLocation =
        Prefixed_Name(ceon_resourceODP, "hasResourceLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-resourceODP:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connecting the information to the object (physical, virtual, imaginary) that the information is about.</para>
    /// labels<para>is about</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/isAbout">http://w3id.org/CEON/ontology/resourceODP/isAbout</seealso>
    let isAbout = Prefixed_Name(ceon_resourceODP, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>ceon-resourceODP:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Asset is sth that is valuable and useful to be used in activities, or owned by actors.</para>
    /// labels<para>Asset</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/resourceODP/Asset">http://w3id.org/CEON/ontology/resourceODP/Asset</seealso>
    let Asset = Prefixed_Name(ceon_resourceODP, "Asset") |> PrefixedName
