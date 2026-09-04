#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bbccore =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/coreconcepts/" "bbccore"

    let ``_1.11`` = _prefixId.prefix "1.11"
    let ``_1.12`` = _prefixId.prefix "1.12"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : The class of events in the BBC. This is a generic class to represent events (music events, historic events, sports events, politics events, e.t.c.).</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/Event">bbccore:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Organisation</para>
    ///   <para>rdfs:comment : The class of organisations in the BBC. E.g., Businesses.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/Organisation">bbccore:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : The class of people in the BBC. Subclasses of this can be all types of people such as politicians, athletes, historic figures, contributors in programmes e.t.c.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/Person">bbccore:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Place</para>
    ///   <para>rdfs:comment : The class of places in the BBC.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/Place">bbccore:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Theme</para>
    ///   <para>rdfs:comment : This concept is used to represent intangible things or abstract concepts.  For example, Financial Crisis, Midwifery, Happiness.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/Theme">bbccore:Theme</a>
    /// </summary>
    let Theme = _prefixId.prefix "Theme"
    /// <summary>
    ///   <para>rdfs:label : Thing</para>
    ///   <para>rdfs:comment : The superclass of all things the BBC creates or talks about.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/Thing">bbccore:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rdfs:label : dateOfBirth</para>
    ///   <para>rdfs:comment : A person's date of birth.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfBirth">bbccore:dateOfBirth</a>
    /// </summary>
    let dateOfBirth = _prefixId.prefix "dateOfBirth"
    /// <summary>
    ///   <para>rdfs:label : dateOfDeath</para>
    ///   <para>rdfs:comment : A person's date of death.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfDeath">bbccore:dateOfDeath</a>
    /// </summary>
    let dateOfDeath = _prefixId.prefix "dateOfDeath"
    /// <summary>
    ///   <para>rdfs:label : disambiguationHint</para>
    ///   <para>rdfs:comment : One or two words to distinguish between entities that have similar labels - often displayed to both internal and external audiences.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/disambiguationHint">bbccore:disambiguationHint</a>
    /// </summary>
    let disambiguationHint = _prefixId.prefix "disambiguationHint"
    /// <summary>
    ///   <para>rdfs:label : eventOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : organisation as agent in an event</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/eventOrganisation">bbccore:eventOrganisation</a>
    /// </summary>
    let eventOrganisation = _prefixId.prefix "eventOrganisation"
    /// <summary>
    ///   <para>rdfs:label : eventPerson^^xsd:string</para>
    ///   <para>rdfs:comment : person as agent in an event</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPerson">bbccore:eventPerson</a>
    /// </summary>
    let eventPerson = _prefixId.prefix "eventPerson"
    /// <summary>
    ///   <para>rdfs:label : eventPlace^^xsd:string</para>
    ///   <para>rdfs:comment : place as location of an event</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPlace">bbccore:eventPlace</a>
    /// </summary>
    let eventPlace = _prefixId.prefix "eventPlace"
    /// <summary>
    ///   <para>rdfs:label : eventTheme^^xsd:string</para>
    ///   <para>rdfs:comment : theme as factor in an event</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/eventTheme">bbccore:eventTheme</a>
    /// </summary>
    let eventTheme = _prefixId.prefix "eventTheme"
    /// <summary>
    ///   <para>rdfs:label : gender</para>
    ///   <para>rdfs:comment : This property is required to distinguish people by gender.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/gender">bbccore:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>rdfs:label : knownFor</para>
    ///   <para>rdfs:comment : A short summary of what a person is notably known for</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/knownFor">bbccore:knownFor</a>
    /// </summary>
    let knownFor = _prefixId.prefix "knownFor"
    /// <summary>
    ///   <para>rdfs:label : label</para>
    ///   <para>rdfs:comment : The a label for a thing. A thing may have one label per language.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/label">bbccore:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : notablyAssociatedWith</para>
    ///   <para>rdfs:comment : This is a high level property aiming to associate any core thing to any other core thing. For example that Tom Daley is notablyAssociatedWith diving or Glastonbury is notablyAssociatedWith music.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/notablyAssociatedWith">bbccore:notablyAssociatedWith</a>
    /// </summary>
    let notablyAssociatedWith = _prefixId.prefix "notablyAssociatedWith"
    /// <summary>
    ///   <para>rdfs:label : occupation</para>
    ///   <para>rdfs:comment : This property associates a person with a thematic area he or she worked in, for example Annie Lennox with Music.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/occupation">bbccore:occupation</a>
    /// </summary>
    let occupation = _prefixId.prefix "occupation"
    /// <summary>
    ///   <para>rdfs:label : placeOfBirth</para>
    ///   <para>rdfs:comment : A person's place of birth.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfBirth">bbccore:placeOfBirth</a>
    /// </summary>
    let placeOfBirth = _prefixId.prefix "placeOfBirth"
    /// <summary>
    ///   <para>rdfs:label : placeOfDeath</para>
    ///   <para>rdfs:comment : A person's place of death</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfDeath">bbccore:placeOfDeath</a>
    /// </summary>
    let placeOfDeath = _prefixId.prefix "placeOfDeath"
    /// <summary>
    ///   <para>rdfs:label : preferredLabel</para>
    ///   <para>rdfs:comment : The BBC editorially preferred label for a thing. A thing may have one and only one preferredLabel</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/preferredLabel">bbccore:preferredLabel</a>
    /// </summary>
    let preferredLabel = _prefixId.prefix "preferredLabel"
    /// <summary>
    ///   <para>rdfs:label : primaryTopic</para>
    ///   <para>rdfs:comment : Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopic">bbccore:primaryTopic</a>
    /// </summary>
    let primaryTopic = _prefixId.prefix "primaryTopic"
    /// <summary>
    ///   <para>rdfs:label : primaryTopicOf</para>
    ///   <para>rdfs:comment : Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopicOf">bbccore:primaryTopicOf</a>
    /// </summary>
    let primaryTopicOf = _prefixId.prefix "primaryTopicOf"
    /// <summary>
    ///   <para>rdfs:label : sameAs</para>
    ///   <para>rdfs:comment : Indicates that something is the same as something else, but in a way that is slightly weaker than owl:sameAs. It's purpose is to connect separate identities of the same thing, whilst keeping separation between the original statements of each.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/sameAs">bbccore:sameAs</a>
    /// </summary>
    let sameAs = _prefixId.prefix "sameAs"
    /// <summary>
    ///   <para>rdfs:label : shortLabel</para>
    ///   <para>rdfs:comment : A short label for a thing usually needed for presentation purposes.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/shortLabel">bbccore:shortLabel</a>
    /// </summary>
    let shortLabel = _prefixId.prefix "shortLabel"
    /// <summary>
    ///   <para>rdfs:label : slug</para>
    ///   <para>rdfs:comment : Human readable keywords that may be used in a programmatic fashion e.g., manchester-city.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/coreconcepts/slug">bbccore:slug</a>
    /// </summary>
    let slug = _prefixId.prefix "slug"
