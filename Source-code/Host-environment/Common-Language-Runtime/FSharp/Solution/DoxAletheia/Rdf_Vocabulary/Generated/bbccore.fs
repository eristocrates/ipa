namespace http.www.bbc.co.uk.ontologies.coreconcepts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bbccore =
    let _namespace_iri = Namespace_Iri bbccore |> NamespaceIRI
    /// <summary>
    ///   <para>bbccore:1.11</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/1.11">http://www.bbc.co.uk/ontologies/coreconcepts/1.11</seealso>
    let ``_1.11`` = Prefixed_Name(bbccore, "1.11") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:1.12</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/1.12">http://www.bbc.co.uk/ontologies/coreconcepts/1.12</seealso>
    let ``_1.12`` = Prefixed_Name(bbccore, "1.12") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of events in the BBC. This is a generic class to represent events (music events, historic events, sports events, politics events, e.t.c.)."</para>
    ///   <para>"Music events, historic events, sports events, politics events, e.t.c."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/Event">http://www.bbc.co.uk/ontologies/coreconcepts/Event</seealso>
    let Event = Prefixed_Name(bbccore, "Event") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"E.g., Businesses."</para>
    ///   <para>"The class of organisations in the BBC. E.g., Businesses."</para>
    /// labels<para>"Organisation"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/Organisation">http://www.bbc.co.uk/ontologies/coreconcepts/Organisation</seealso>
    let Organisation = Prefixed_Name(bbccore, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"all types of people such as politicians, athletes, historic figures, contributors in programmes e.t.c."</para>
    ///   <para>"The class of people in the BBC. Subclasses of this can be all types of people such as politicians, athletes, historic figures, contributors in programmes e.t.c."</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/Person">http://www.bbc.co.uk/ontologies/coreconcepts/Person</seealso>
    let Person = Prefixed_Name(bbccore, "Person") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of places in the BBC."</para>
    ///   <para>"Another type of location."</para>
    /// labels<para>"Place"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/Place">http://www.bbc.co.uk/ontologies/coreconcepts/Place</seealso>
    let Place = Prefixed_Name(bbccore, "Place") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:Theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This concept is used to represent intangible things or abstract concepts.  For example, Financial Crisis, Midwifery, Happiness."</para>
    ///   <para>"This concept is used to represent intangible things or abstract concepts. For example, Financial Crisis, Midwifery, Happiness."</para>
    /// labels<para>"Theme"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/Theme">http://www.bbc.co.uk/ontologies/coreconcepts/Theme</seealso>
    let Theme = Prefixed_Name(bbccore, "Theme") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The superclass of all things the BBC creates or talks about."</para>
    /// labels<para>"Thing"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/Thing">http://www.bbc.co.uk/ontologies/coreconcepts/Thing</seealso>
    let Thing = Prefixed_Name(bbccore, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:dateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when a Contact/Person is born."</para>
    ///   <para>"A person's date of birth."</para>
    /// labels<para>"Date of birth"</para><para>"dateOfBirth"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfBirth">http://www.bbc.co.uk/ontologies/coreconcepts/dateOfBirth</seealso>
    let dateOfBirth = Prefixed_Name(bbccore, "dateOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:dateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when a Contact/Person has passed away."</para>
    ///   <para>"A person's date of death."</para>
    /// labels<para>"Date of death"</para><para>"dateOfDeath"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfDeath">http://www.bbc.co.uk/ontologies/coreconcepts/dateOfDeath</seealso>
    let dateOfDeath = Prefixed_Name(bbccore, "dateOfDeath") |> PrefixedName

    /// <summary>
    ///   <para>bbccore:disambiguationHint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"One or two words to distinguish between entities that have similar labels - often displayed to both internal and external audiences."</para>
    /// labels<para>"disambiguationHint"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/disambiguationHint">http://www.bbc.co.uk/ontologies/coreconcepts/disambiguationHint</seealso>
    let disambiguationHint =
        Prefixed_Name(bbccore, "disambiguationHint") |> PrefixedName

    /// <summary>
    ///   <para>bbccore:eventOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"organisation as agent in an event"</para>
    /// labels<para>"eventOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/eventOrganisation">http://www.bbc.co.uk/ontologies/coreconcepts/eventOrganisation</seealso>
    let eventOrganisation = Prefixed_Name(bbccore, "eventOrganisation") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:eventPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"person as agent in an event"</para>
    /// labels<para>"eventPerson"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPerson">http://www.bbc.co.uk/ontologies/coreconcepts/eventPerson</seealso>
    let eventPerson = Prefixed_Name(bbccore, "eventPerson") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:eventPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"place as location of an event"</para>
    /// labels<para>"eventPlace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPlace">http://www.bbc.co.uk/ontologies/coreconcepts/eventPlace</seealso>
    let eventPlace = Prefixed_Name(bbccore, "eventPlace") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:eventTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"theme as factor in an event"</para>
    /// labels<para>"eventTheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/eventTheme">http://www.bbc.co.uk/ontologies/coreconcepts/eventTheme</seealso>
    let eventTheme = Prefixed_Name(bbccore, "eventTheme") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is required to distinguish people by gender."</para>
    ///   <para>"The gender of a person e.g. male or female."</para>
    /// labels<para>"gender"</para><para>"Gender"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/gender">http://www.bbc.co.uk/ontologies/coreconcepts/gender</seealso>
    let gender = Prefixed_Name(bbccore, "gender") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:knownFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short summary of what a person is notably known for"</para>
    /// labels<para>"knownFor"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/knownFor">http://www.bbc.co.uk/ontologies/coreconcepts/knownFor</seealso>
    let knownFor = Prefixed_Name(bbccore, "knownFor") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The a label for a thing. A thing may have one label per language."</para>
    /// labels<para>"label"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/label">http://www.bbc.co.uk/ontologies/coreconcepts/label</seealso>
    let label = Prefixed_Name(bbccore, "label") |> PrefixedName

    /// <summary>
    ///   <para>bbccore:notablyAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is a high level property aiming to associate any core thing to any other core thing. For example that Tom Daley is notablyAssociatedWith diving or Glastonbury is notablyAssociatedWith music."</para>
    /// labels<para>"notablyAssociatedWith"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/notablyAssociatedWith">http://www.bbc.co.uk/ontologies/coreconcepts/notablyAssociatedWith</seealso>
    let notablyAssociatedWith =
        Prefixed_Name(bbccore, "notablyAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>bbccore:occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property associates a person with a thematic area he or she worked in, for example Annie Lennox with Music."</para>
    /// labels<para>"occupation"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/occupation">http://www.bbc.co.uk/ontologies/coreconcepts/occupation</seealso>
    let occupation = Prefixed_Name(bbccore, "occupation") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:placeOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The place where a person is born."</para>
    ///   <para>"A person's place of birth."</para>
    /// labels<para>"Place of birth"</para><para>"placeOfBirth"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfBirth">http://www.bbc.co.uk/ontologies/coreconcepts/placeOfBirth</seealso>
    let placeOfBirth = Prefixed_Name(bbccore, "placeOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:placeOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A person's place of death"</para>
    ///   <para>"The place where a person has passed away."</para>
    /// labels<para>"Place of death"</para><para>"placeOfDeath"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfDeath">http://www.bbc.co.uk/ontologies/coreconcepts/placeOfDeath</seealso>
    let placeOfDeath = Prefixed_Name(bbccore, "placeOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:preferredLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The BBC editorially preferred label for a thing. A thing may have one and only one preferredLabel"</para>
    /// labels<para>"preferredLabel"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/preferredLabel">http://www.bbc.co.uk/ontologies/coreconcepts/preferredLabel</seealso>
    let preferredLabel = Prefixed_Name(bbccore, "preferredLabel") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:primaryTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document."</para>
    ///   <para>"The main subject of interest."</para>
    /// labels<para>"primaryTopic"</para><para>"Primary topic"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopic">http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopic</seealso>
    let primaryTopic = Prefixed_Name(bbccore, "primaryTopic") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:primaryTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document."</para>
    /// labels<para>"primaryTopicOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopicOf">http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopicOf</seealso>
    let primaryTopicOf = Prefixed_Name(bbccore, "primaryTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:sameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that something is the same as something else, but in a way that is slightly weaker than owl:sameAs. It's purpose is to connect separate identities of the same thing, whilst keeping separation between the original statements of each."</para>
    /// labels<para>"sameAs"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/sameAs">http://www.bbc.co.uk/ontologies/coreconcepts/sameAs</seealso>
    let sameAs = Prefixed_Name(bbccore, "sameAs") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:shortLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short label for a thing usually needed for presentation purposes."</para>
    /// labels<para>"shortLabel"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/shortLabel">http://www.bbc.co.uk/ontologies/coreconcepts/shortLabel</seealso>
    let shortLabel = Prefixed_Name(bbccore, "shortLabel") |> PrefixedName
    /// <summary>
    ///   <para>bbccore:slug</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"One or more keywords."</para>
    ///   <para>"Human readable keywords that may be used in a programmatic fashion e.g., manchester-city."</para>
    /// labels<para>"slug"</para><para>"Slug"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/coreconcepts/slug">http://www.bbc.co.uk/ontologies/coreconcepts/slug</seealso>
    let slug = Prefixed_Name(bbccore, "slug") |> PrefixedName
