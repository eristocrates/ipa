namespace http.www.semanticdesktop.org.ontologies._2007._11._01.pimo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pimo =
    let _namespace_iri = Namespace_Iri pimo |> NamespaceIRI
    /// <summary>
    ///   <para>pimo:AbstractClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>pimo:ClassRole</para>
    ///
    /// labels<para>"AbstractClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#AbstractClass">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#AbstractClass</seealso>
    let AbstractClass = Prefixed_Name(pimo, "AbstractClass") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An agent (eg. person, group, software or physical artifact). The Agent class is the class of agents; things that do stuff. A well known sub-class is Person, representing people. Other kinds of agents include Organization and Group.
    /// (inspired by FOAF).
    /// Agent is not a subclass of NAO:Party."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Agent">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Agent</seealso>
    let Agent = Prefixed_Name(pimo, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An association between two or more pimo-things. This is used to model n-ary relations and metadata about relations. For example, the asociation of a person being organizational member is only effectual within a period of time (after the person joined the organization and before the person left the organization). There can be multiple periods of time when associations are valid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Association">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Association</seealso>
    let Association = Prefixed_Name(pimo, "Association") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The role of someone attending a social event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attendee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Attendee">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Attendee</seealso>
    let Attendee = Prefixed_Name(pimo, "Attendee") |> PrefixedName
    /// <summary>
    ///   <para>pimo:BlogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A blog note. You just want to write something down right now and need a place to do that. Add a blog-note! This is an example class for a document type, there are more detailled ontologies to model Blog-Posts (like SIOC)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Blog Post"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#BlogPost">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#BlogPost</seealso>
    let BlogPost = Prefixed_Name(pimo, "BlogPost") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A structure that has a roof and walls and stands more or less permanently in one place; "there was a three-story building on the corner"; "it was an imposing edifice". (Definition from SUMO)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Building">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Building</seealso>
    let Building = Prefixed_Name(pimo, "Building") |> PrefixedName
    /// <summary>
    ///   <para>pimo:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A large and densely populated urban area; may include several independent administrative districts; "Ancient Troy was a great city". (Definition from SUMO)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"City"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#City">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#City</seealso>
    let City = Prefixed_Name(pimo, "City") |> PrefixedName
    /// <summary>
    ///   <para>pimo:ClassOrThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Superclass of class and thing. To add properties to both class and thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ClassOrThing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ClassOrThing">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ClassOrThing</seealso>
    let ClassOrThing = Prefixed_Name(pimo, "ClassOrThing") |> PrefixedName

    /// <summary>
    ///   <para>pimo:ClassOrThingOrPropertyOrAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Superclass of resources that can be generated by the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ClassOrThingOrPropertyOrAssociation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ClassOrThingOrPropertyOrAssociation">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ClassOrThingOrPropertyOrAssociation</seealso>
    let ClassOrThingOrPropertyOrAssociation =
        Prefixed_Name(pimo, "ClassOrThingOrPropertyOrAssociation") |> PrefixedName

    /// <summary>
    ///   <para>pimo:ClassRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Roles of classes in PIMO: concrete instances are Abstract and Concrete."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ClassRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ClassRole">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ClassRole</seealso>
    let ClassRole = Prefixed_Name(pimo, "ClassRole") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A collection of Things, independent of their class. The items in the collection share a common property. Which property may be modelled explicitly or mentioned in the description of the Collection. The requirement of explicit modelling the semantic meaning of the collection is not mandatory, as collections can be created ad-hoc. Implizit modelling can be applied by the system by learning the properties. For example, a Collection of "Coworkers" could be defined as that all elements must be of class "Person" and have an attribute "work for the same Organization as the user". Further standards can be used to model these attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Collection">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Collection</seealso>
    let Collection = Prefixed_Name(pimo, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>pimo:ConcreteClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>pimo:ClassRole</para>
    ///
    /// labels<para>"ConcreteClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ConcreteClass">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ConcreteClass</seealso>
    let ConcreteClass = Prefixed_Name(pimo, "ConcreteClass") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A binding agreement between two or more persons that is enforceable by law. (Definition from SUMO). This is an example class for a document type, there are more detailled ontologies to model Contracts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Contract">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Contract</seealso>
    let Contract = Prefixed_Name(pimo, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The territory occupied by a nation; "he returned to the land of his birth"; "he visited several European countries". (Definition from SUMO)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Country">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Country</seealso>
    let Country = Prefixed_Name(pimo, "Country") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A generic document. This is a placeholder class for document-management domain ontologies to subclass. Create more and specified subclasses of pimo:Document for the document types in your domain. Documents are typically instances of both NFO:Document (modeling the information element used to store the document) and a LogicalMediaType subclass. Two examples are given for what to model here: a contract for a business domain, a BlogPost for an informal domain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Document">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Document</seealso>
    let Document = Prefixed_Name(pimo, "Document") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Something that happens
    /// An Event is conceived as compact in time. (Definition from Merriam-Webster)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Event">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Event</seealso>
    let Event = Prefixed_Name(pimo, "Event") |> PrefixedName
    /// <summary>
    ///   <para>pimo:FullPimoView</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:GraphView</para>
    ///
    /// labels<para>"FullPimoView"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#FullPimoView">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#FullPimoView</seealso>
    let FullPimoView = Prefixed_Name(pimo, "FullPimoView") |> PrefixedName
    /// <summary>
    ///   <para>pimo:GroundingClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:GraphView</para>
    ///
    /// labels<para>"GroundingClosure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#GroundingClosure">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#GroundingClosure</seealso>
    let GroundingClosure = Prefixed_Name(pimo, "GroundingClosure") |> PrefixedName
    /// <summary>
    ///   <para>pimo:InferOccurrences</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:GraphView</para>
    ///
    /// labels<para>"InferOccurrences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#InferOccurrences">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#InferOccurrences</seealso>
    let InferOccurrences = Prefixed_Name(pimo, "InferOccurrences") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Locatable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Things that can be at a location. Abstract class, use it as a superclass of things that can be placed in physical space."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Locatable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Locatable">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Locatable</seealso>
    let Locatable = Prefixed_Name(pimo, "Locatable") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A physical location. Subclasses are modeled for the most common locations humans work in: Building, City, Country, Room, State. This selection is intended to be applicable cross-cultural and cross-domain. City is a prototype that can be further refined for villages, etc. Subclass of a WGS84:SpatialThing, can have geo-coordinates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Location">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Location</seealso>
    let Location = Prefixed_Name(pimo, "Location") |> PrefixedName
    /// <summary>
    ///   <para>pimo:LogicalMediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Logical media types represent the content aspect of information elements e.g. a flyer, a contract, a promotional video, a todo list.  The user can create new logical media types dependend on their domain: a salesman will need MarketingFlyer, Offer, Invoice while a student might create Report, Thesis and Homework. This is independent from the information element and data object (NIE/NFO) in which the media type will be stored. The same contract can be stored in a PDF file, a text file, or an HTML website.
    /// The groundingOccurrence of a LogicalMediaType is the Document that stores the content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Logical Media Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#LogicalMediaType">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#LogicalMediaType</seealso>
    let LogicalMediaType = Prefixed_Name(pimo, "LogicalMediaType") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The social act of assembling for some common purpose; "his meeting with the salesman was the high point of his day". (Definition from SUMO)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meeting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Meeting">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Meeting</seealso>
    let Meeting = Prefixed_Name(pimo, "Meeting") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A note. The textual contents of the note should be expressed in the nao:description value of the note."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Note">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Note</seealso>
    let Note = Prefixed_Name(pimo, "Note") |> PrefixedName
    /// <summary>
    ///   <para>pimo:OccurrenceClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:GraphView</para>
    ///
    /// labels<para>"OccurrenceClosure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#OccurrenceClosure">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#OccurrenceClosure</seealso>
    let OccurrenceClosure = Prefixed_Name(pimo, "OccurrenceClosure") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An administrative and functional structure (as a business or a political party). (Definition from Merriam-Webster)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Organization">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Organization</seealso>
    let Organization = Prefixed_Name(pimo, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>pimo:OrganizationMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The role of one or multiple persons being a member in one or multiple organizations. Use pimo:organization and pimo:roleHolder to link to the organizations and persons."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#OrganizationMember">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#OrganizationMember</seealso>
    let OrganizationMember = Prefixed_Name(pimo, "OrganizationMember") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a person. Either living, dead, real or imaginary. (Definition from foaf:Person)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Person">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Person</seealso>
    let Person = Prefixed_Name(pimo, "Person") |> PrefixedName
    /// <summary>
    ///   <para>pimo:PersonGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A group of Persons. They are connected to each other by sharing a common attribute, for example they all belong to the same organization or have a common interest. Refer to pimo:Collection for more information about defining collections."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Group of Persons"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#PersonGroup">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#PersonGroup</seealso>
    let PersonGroup = Prefixed_Name(pimo, "PersonGroup") |> PrefixedName
    /// <summary>
    ///   <para>pimo:PersonRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A person takes a certain role in a given context. The role can be that of "a mentor or another person" or "giving a talk at a meeting", etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role of Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#PersonRole">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#PersonRole</seealso>
    let PersonRole = Prefixed_Name(pimo, "PersonRole") |> PrefixedName

    /// <summary>
    ///   <para>pimo:PersonalInformationModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Personal Information Model (PIMO) of a user. Represents the sum of all information from the personal knowledge workspace (in literature also referred to as Personal Space of Information (PSI)) which a user needs for Personal Information Management (PIM)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personal Information Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#PersonalInformationModel">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#PersonalInformationModel</seealso>
    let PersonalInformationModel =
        Prefixed_Name(pimo, "PersonalInformationModel") |> PrefixedName

    /// <summary>
    ///   <para>pimo:ProcessConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Concepts that relate to a series of actions or operations conducing to an end. Abstract class. Defines optional start and endtime properties, names taken from NCAL."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Process Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ProcessConcept">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#ProcessConcept</seealso>
    let ProcessConcept = Prefixed_Name(pimo, "ProcessConcept") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Any piece of work that is undertaken or attempted (Wordnet). An enterprise carefully planned to achieve a particular aim (Oxford Dictionary)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Project">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Project</seealso>
    let Project = Prefixed_Name(pimo, "Project") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A properPart of a Building which is separated from the exterior of the Building and/or other Rooms of the Building by walls. Some Rooms may have a specific purpose, e.g. sleeping, bathing, cooking, entertainment, etc. (Definition from SUMO)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Room">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Room</seealso>
    let Room = Prefixed_Name(pimo, "Room") |> PrefixedName

    /// <summary>
    ///   <para>pimo:RuleViewSpecificationGroundingClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:RuleViewSpecification</para>
    ///
    /// labels<para>"RuleViewSpecificationGroundingClosure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#RuleViewSpecificationGroundingClosure">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#RuleViewSpecificationGroundingClosure</seealso>
    let RuleViewSpecificationGroundingClosure =
        Prefixed_Name(pimo, "RuleViewSpecificationGroundingClosure") |> PrefixedName

    /// <summary>
    ///   <para>pimo:RuleViewSpecificationInferOccurrences</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:RuleViewSpecification</para>
    ///
    /// labels<para>"RuleViewSpecificationInferOccurrences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#RuleViewSpecificationInferOccurrences">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#RuleViewSpecificationInferOccurrences</seealso>
    let RuleViewSpecificationInferOccurrences =
        Prefixed_Name(pimo, "RuleViewSpecificationInferOccurrences") |> PrefixedName

    /// <summary>
    ///   <para>pimo:RuleViewSpecificationOccurrenceClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:RuleViewSpecification</para>
    ///
    /// labels<para>"RuleViewSpecificationOccurrenceClosure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#RuleViewSpecificationOccurrenceClosure">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#RuleViewSpecificationOccurrenceClosure</seealso>
    let RuleViewSpecificationOccurrenceClosure =
        Prefixed_Name(pimo, "RuleViewSpecificationOccurrenceClosure") |> PrefixedName

    /// <summary>
    ///   <para>pimo:SocialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A social occasion or activity. (Definition from Merriam-Webster)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#SocialEvent">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#SocialEvent</seealso>
    let SocialEvent = Prefixed_Name(pimo, "SocialEvent") |> PrefixedName
    /// <summary>
    ///   <para>pimo:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Administrative subdivisions of a Nation that are broader than any other political subdivisions that may exist. This Class includes the states of the United States, as well as the provinces of Canada and European countries. (Definition from SUMO)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#State">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#State</seealso>
    let State = Prefixed_Name(pimo, "State") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Tags in the context of PIMO. A marker class for Things that are used to categorize documents (or other things). Tags must be a kind of Thing and must have a unique label. Documents should not be Tags by default."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Tag">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Tag</seealso>
    let Tag = Prefixed_Name(pimo, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A (usually assigned) piece of work (often to be finished within a certain time). (Definition from Merriam-Webster)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Task">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Task</seealso>
    let Task = Prefixed_Name(pimo, "Task") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Entities that are in the direct attention of the user when doing knowledge work."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Thing">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Thing</seealso>
    let Thing = Prefixed_Name(pimo, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>pimo:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A topic is the subject of a discussion or document. Topics are distinguished from Things in their taxonomic nature, examples are scientific areas such as "Information Science", "Biology", or categories used in content syndication such as "Sports", "Politics". They are specific to the user's domain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Topic">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#Topic</seealso>
    let Topic = Prefixed_Name(pimo, "Topic") |> PrefixedName

    /// <summary>
    ///   <para>pimo:associationEffectual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"During which time is this association effective? If omitted, the association is always effective. Start time and end-time may be left open, an open start time indicates that the fact is unknown, an open end-time indicates that the end-date is either unknown or the association has not ended.
    /// There can be multiple effectual periods."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"association effectual during"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#associationEffectual">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#associationEffectual</seealso>
    let associationEffectual =
        Prefixed_Name(pimo, "associationEffectual") |> PrefixedName

    /// <summary>
    ///   <para>pimo:associationMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An super-property of all roles that an entity can have in an association. Member is the generic role of a thing in an association. Association subclasses should define sub-properties of this property. Associations can have Things as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"association member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#associationMember">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#associationMember</seealso>
    let associationMember = Prefixed_Name(pimo, "associationMember") |> PrefixedName
    /// <summary>
    ///   <para>pimo:attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A social event is attended by a person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attendee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#attendee">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#attendee</seealso>
    let attendee = Prefixed_Name(pimo, "attendee") |> PrefixedName
    /// <summary>
    ///   <para>pimo:attendingMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"the attended meeting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attending meeting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#attendingMeeting">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#attendingMeeting</seealso>
    let attendingMeeting = Prefixed_Name(pimo, "attendingMeeting") |> PrefixedName
    /// <summary>
    ///   <para>pimo:attends</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A person attends a social event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attends event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#attends">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#attends</seealso>
    let attends = Prefixed_Name(pimo, "attends") |> PrefixedName
    /// <summary>
    ///   <para>pimo:classRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Annotating abstract and concrete classes. Implementations may offer the feature to hide abstract classes. By default, classes are concrete. Classes can be declared abstract by setting their classRole to abstract. Instances should not have an abstract class as type (if not inferred)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#classRole">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#classRole</seealso>
    let classRole = Prefixed_Name(pimo, "classRole") |> PrefixedName
    /// <summary>
    ///   <para>pimo:containsLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject location contains the object location. For example, a building contains a room or a country contains a city."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#containsLocation">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#containsLocation</seealso>
    let containsLocation = Prefixed_Name(pimo, "containsLocation") |> PrefixedName
    /// <summary>
    ///   <para>pimo:createdPimo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The creator of the Personal Information Model. The human being whose mental models are represented in the PIMO."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"created Pimo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#createdPimo">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#createdPimo</seealso>
    let createdPimo = Prefixed_Name(pimo, "createdPimo") |> PrefixedName
    /// <summary>
    ///   <para>pimo:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The creator of the Personal Information Model. A subproperty of NAO:creator. The human being whose mental models are represented in the PIMO. Range is an Agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#creator">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#creator</seealso>
    let creator = Prefixed_Name(pimo, "creator") |> PrefixedName
    /// <summary>
    ///   <para>pimo:datatypeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The object of statements is a literal, resource, or datatype value describing the subject thing. Users should be able to edit statements defined with this property. Abstract super-property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"datatype property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#datatypeProperty">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#datatypeProperty</seealso>
    let datatypeProperty = Prefixed_Name(pimo, "datatypeProperty") |> PrefixedName
    /// <summary>
    ///   <para>pimo:dtend</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property specifies the date and time when a process ends. Inspired by NCAL:dtend."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"end date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#dtend">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#dtend</seealso>
    let dtend = Prefixed_Name(pimo, "dtend") |> PrefixedName
    /// <summary>
    ///   <para>pimo:dtstart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property specifies when the process begins. Inspired by NCAL:dtstart."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"start date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#dtstart">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#dtstart</seealso>
    let dtstart = Prefixed_Name(pimo, "dtstart") |> PrefixedName
    /// <summary>
    ///   <para>pimo:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The duration of the process (meeting, event, etc). Difference between start and end time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#duration">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#duration</seealso>
    let duration = Prefixed_Name(pimo, "duration") |> PrefixedName

    /// <summary>
    ///   <para>pimo:groundingForDeletedThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This NIE Information Element was used as a grounding occurrence for the object Thing. The Thing was then deleted by the user manually, indicating that this Information Element should not cause an automatic creation of another Thing in the future. The object resource has no range to indicate that it was completely removed from the user's PIMO, including the rdf:type statement. Relevant for data alignment and enrichment algorithms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"grounding for deleted thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#groundingForDeletedThing">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#groundingForDeletedThing</seealso>
    let groundingForDeletedThing =
        Prefixed_Name(pimo, "groundingForDeletedThing") |> PrefixedName

    /// <summary>
    ///   <para>pimo:groundingOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>nrl:InverseFunctionalProperty</para>
    ///   <para>"The subject Thing represents the entity that is described in the object InformationElement. The subject Thing is the canonical, unique representation in the personal information model for the entity described in the object. Multiple InformationElements can be the grounding occurrence of the same Thing,  one InformationElement can be the groundingOccurrence of only one Thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"grounding occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#groundingOccurrence">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#groundingOccurrence</seealso>
    let groundingOccurrence = Prefixed_Name(pimo, "groundingOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>pimo:hasDeprecatedRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject Thing was represented previously using the object resource. This indicates that the object resource was a duplicate representation of the subject and merged with the subject. Implementations can use this property to resolve dangling links in distributed system. When encountering resources that are deprecated representations of a Thing, they should be replaced with the Thing. The range is not declared as we assume all knowledge about the object is gone, including its rdf:type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has deprecated representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasDeprecatedRepresentation">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasDeprecatedRepresentation</seealso>
    let hasDeprecatedRepresentation =
        Prefixed_Name(pimo, "hasDeprecatedRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>pimo:hasFolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Folders can be used to store information elements related to a Thing or Class. This property can be used to connect a Class or Thing to existing Folders. Implementations can suggest annotations for documents stored inside these folders or  suggest the folder for new documents related to the Thing or Class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has folder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasFolder">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasFolder</seealso>
    let hasFolder = Prefixed_Name(pimo, "hasFolder") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasGlobalNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The global namespace of this user using the semdesk uri scheme, based on the Global Identifier of the user. Example semdesk://bob@example.com/things/. See http://dev.nepomuk.semanticdesktop.org/repos/trunk/doc/2008_09_semdeskurischeme/index.html"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"global namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasGlobalNamespace">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasGlobalNamespace</seealso>
    let hasGlobalNamespace = Prefixed_Name(pimo, "hasGlobalNamespace") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Marks a pimo:Tag or a pimo:Topic (its subclass) as an interest of a person or a group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasInterest">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasInterest</seealso>
    let hasInterest = Prefixed_Name(pimo, "hasInterest") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasLocalNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The local namespace of this user using the semdesk uri scheme, based on the Local Identifier of the user. Example semdesk://bob@/things/. See http://dev.nepomuk.semanticdesktop.org/repos/trunk/doc/2008_09_semdeskurischeme/index.html"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"local namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasLocalNamespace">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasLocalNamespace</seealso>
    let hasLocalNamespace = Prefixed_Name(pimo, "hasLocalNamespace") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject thing is currently located at the object location."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasLocation">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasLocation</seealso>
    let hasLocation = Prefixed_Name(pimo, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines which agents form part of a given person group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has group member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasMember">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasMember</seealso>
    let hasMember = Prefixed_Name(pimo, "hasMember") |> PrefixedName

    /// <summary>
    ///   <para>pimo:hasOrganizationMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject organization has the object person or organization (Agent) as a member."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organization has member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOrganizationMember">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOrganizationMember</seealso>
    let hasOrganizationMember =
        Prefixed_Name(pimo, "hasOrganizationMember") |> PrefixedName

    /// <summary>
    ///   <para>pimo:hasOtherConceptualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Short: hasOtherRepresentation points from a Class in your PIMO to a class in a domain ontology that represents the same class. Longer: hasOtherConceptualization means that a class of real world objects O represented by a concept C1 in the ontology has additional conceptualizations (as classes C2-Cn in different domain ontologies).
    /// This means: IF (O_i is conceptialized by C_j in Ontology_k) AND (O_l is conceptialized by C_m in Ontology_n) THEN (O_i and O_l is the same set of objects).
    /// hasOtherConceptualization is an transitive relation, but not equivalent (not symmetric nor reflexive)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has other conceptualization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOtherConceptualization">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOtherConceptualization</seealso>
    let hasOtherConceptualization =
        Prefixed_Name(pimo, "hasOtherConceptualization") |> PrefixedName

    /// <summary>
    ///   <para>pimo:hasOtherRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>nrl:TransitiveProperty</para>
    ///   <para>"hasOtherRepresentation points from a Thing in your PIMO to a thing in an ontology that represents the same real world thing.
    /// This means that the real world object O represented by an instance I1 has additional representations (as instances I2-In of different conceptualizations).
    /// This means: IF (I_i represents O_j in Ontology_k) AND (I_m represents O_n in Ontology_o) THEN (O_n and O_j are the same object).
    /// hasOtherRepresentation is a transitive relation, but not equivalent (not symmetric nor reflexive). For example, the URI of a  foaf:Person representation published on the web is a hasOtherRepresentation for the person. This property is inverse functional, two Things from two information models having the same hasOtherRepresentation are considered to be representations of the same entity from the real world."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has other representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOtherRepresentation">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOtherRepresentation</seealso>
    let hasOtherRepresentation =
        Prefixed_Name(pimo, "hasOtherRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>pimo:hasOtherSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"hasOtherSlot points from a clot  in your PIMO to a slot in a domain ontology that represents the same connection idea."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"represented by other slot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOtherSlot">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasOtherSlot</seealso>
    let hasOtherSlot = Prefixed_Name(pimo, "hasOtherSlot") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The object is part of the subject. Like a page is part of a book or an engine is part of a car. You can make sub-properties of this to reflect more detailed relations. The semantics of this relations is the same as skos:narrowerPartitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasPart">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasPart</seealso>
    let hasPart = Prefixed_Name(pimo, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasRootTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The root topics of this PersonalInformationModel's topic hierarchy. Every topic that has no pimo:superTopic is a root topic. Semantically equivalent to skos:hasTopConcept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"root topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasRootTopic">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasRootTopic</seealso>
    let hasRootTopic = Prefixed_Name(pimo, "hasRootTopic") |> PrefixedName
    /// <summary>
    ///   <para>pimo:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject's contents describes the object. Or the subject can be seen as belonging to the thing described by the object.  Similar semantics as skos:subject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasTag">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#hasTag</seealso>
    let hasTag = Prefixed_Name(pimo, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>pimo:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Each element in a PIMO must be connected to the PIMO, to be able to track multiple PIMOs in a distributed scenario. Also, this is the way to find the user that this Thing belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is defined by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isDefinedBy">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(pimo, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>pimo:isInterestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links interests, as instances of pimo:Tag or a pimo:Topic (its subclass), to a person or a group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is interest Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isInterestOf">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isInterestOf</seealso>
    let isInterestOf = Prefixed_Name(pimo, "isInterestOf") |> PrefixedName
    /// <summary>
    ///   <para>pimo:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject location is the current location of the object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is location of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isLocationOf">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(pimo, "isLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>pimo:isOrganizationMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject person or organozation (Agent) is member of the object organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is member of organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isOrganizationMemberOf">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isOrganizationMemberOf</seealso>
    let isOrganizationMemberOf =
        Prefixed_Name(pimo, "isOrganizationMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>pimo:isRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The thing is related to the other thing. Similar in meaning to skos:related. Symmetric but not transitive."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is related"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isRelated">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isRelated</seealso>
    let isRelated = Prefixed_Name(pimo, "isRelated") |> PrefixedName
    /// <summary>
    ///   <para>pimo:isTagFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This thing is described further in the object thing. Similar  semantics as skos:isSubjectOf."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is tag for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isTagFor">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isTagFor</seealso>
    let isTagFor = Prefixed_Name(pimo, "isTagFor") |> PrefixedName
    /// <summary>
    ///   <para>pimo:isWriteable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines if this information model can be modified by the user of the system. This is usually false for imported ontologies and true for the user's own PersonalInformationModel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is writeable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isWriteable">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#isWriteable</seealso>
    let isWriteable = Prefixed_Name(pimo, "isWriteable") |> PrefixedName
    /// <summary>
    ///   <para>pimo:jabberId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Jabber-ID of the user. Used to communicate amongst peers in the social scenario of the semantic desktop. Use the xmpp node identifier as specified by RFC3920, see http://www.xmpp.org/specs/rfc3920.html#addressing-node. The format is the same as e-mail addresses: username@hostname."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"jabber ID of the user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#jabberId">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#jabberId</seealso>
    let jabberId = Prefixed_Name(pimo, "jabberId") |> PrefixedName
    /// <summary>
    ///   <para>pimo:locatedWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject location is contained within the object location. For example, a room is located within a building or a city is located within a country."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"located within"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#locatedWithin">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#locatedWithin</seealso>
    let locatedWithin = Prefixed_Name(pimo, "locatedWithin") |> PrefixedName
    /// <summary>
    ///   <para>pimo:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property can be used to organise agents within groups. Supplemented with an inverse property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"member of group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#memberOf">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#memberOf</seealso>
    let memberOf = Prefixed_Name(pimo, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>pimo:objectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The object of statements is another Thing. Users should be able to edit statements defined with this property. Abstract super-property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#objectProperty">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#objectProperty</seealso>
    let objectProperty = Prefixed_Name(pimo, "objectProperty") |> PrefixedName
    /// <summary>
    ///   <para>pimo:occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject Thing is represented also in the object resource. All facts added to the object resource are valid for the subject thing. The subject is the canonical represtation of the object. In particual, this implies when (?object ?p ?v) -&gt; (?subject ?p ?v) and (?s ?p ?object) -&gt; (?s ?p ?subject). The class of the object is not defined, but should be compatible with the class of the subject. Occurrence relations can be inferred through same identifiers or referencingOccurrence relations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#occurrence">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#occurrence</seealso>
    let occurrence = Prefixed_Name(pimo, "occurrence") |> PrefixedName
    /// <summary>
    ///   <para>pimo:organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"relation to the organization in an OrganizationMember association."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#organization">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#organization</seealso>
    let organization = Prefixed_Name(pimo, "organization") |> PrefixedName
    /// <summary>
    ///   <para>pimo:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This is part of the object. Like a page is part of a book or an engine is part of a car. You can make sub-properties of this to reflect more detailed relations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#partOf">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#partOf</seealso>
    let partOf = Prefixed_Name(pimo, "partOf") |> PrefixedName

    /// <summary>
    ///   <para>pimo:referencingOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject thing is described in the object document. Ideally, the document is public and its primary topic is the thing. Although this property is not inverse-functional (because the Occurrences are not canonical elements of a formal ontology) this property allows to use public documents, such as wikipedia pages, as indicators identity.  The more formal hasOtherRepresentation property can be used when an ontology about the subject exists."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"referencing occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#referencingOccurrence">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#referencingOccurrence</seealso>
    let referencingOccurrence =
        Prefixed_Name(pimo, "referencingOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>pimo:roleContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The context where the role-holder impersonates this role. For example, the company where a person is employed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"role context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#roleContext">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#roleContext</seealso>
    let roleContext = Prefixed_Name(pimo, "roleContext") |> PrefixedName
    /// <summary>
    ///   <para>pimo:roleHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"the person taking the role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"role holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#roleHolder">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#roleHolder</seealso>
    let roleHolder = Prefixed_Name(pimo, "roleHolder") |> PrefixedName
    /// <summary>
    ///   <para>pimo:subTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The object topic is more specific in meaning than the subject topic. Transitive. Similar in meaning to skos:narrower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sub topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#subTopic">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#subTopic</seealso>
    let subTopic = Prefixed_Name(pimo, "subTopic") |> PrefixedName
    /// <summary>
    ///   <para>pimo:superTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>nrl:TransitiveProperty</para>
    ///   <para>"The object topic is more general in meaning than the subject topic. Transitive. Similar to skos:broader."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"broader topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#superTopic">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#superTopic</seealso>
    let superTopic = Prefixed_Name(pimo, "superTopic") |> PrefixedName
    /// <summary>
    ///   <para>pimo:tagLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The unique label of the tag. The label must be unique within the scope of one PersonalInformationModel. It is required and a subproperty of nao:prefLabel. It clarifies the use of nao:personalIdentifier by restricting the scope to tags. Semantically equivalent to skos:prefLabel, where uniqueness of labels is also recommended."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tag label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#tagLabel">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#tagLabel</seealso>
    let tagLabel = Prefixed_Name(pimo, "tagLabel") |> PrefixedName
    /// <summary>
    ///   <para>pimo:taskDueTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"when is this task due? Represented in ISO 8601, example: 2003-11-22T17:00:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"task due time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#taskDueTime">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#taskDueTime</seealso>
    let taskDueTime = Prefixed_Name(pimo, "taskDueTime") |> PrefixedName
    /// <summary>
    ///   <para>pimo:wikiText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A wiki-like free-text description of a Thing or a Class. The text can be formatted using a limited set of HTML elements and can contain links to other Things. The format is described in detail in the WIF specification (http://semanticweb.org/wiki/Wiki_Interchange_Format)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wiki text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#wikiText">http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#wikiText</seealso>
    let wikiText = Prefixed_Name(pimo, "wikiText") |> PrefixedName
