namespace http.www.bbc.co.uk.ontologies.coreconcepts.slash

open DoxAletheia

module bbccore =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/coreconcepts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/coreconcepts/1.11"></see>
    /// </summary>
    let ``_1.11`` = _prefix "1.11"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/coreconcepts/1.12"></see>
    /// </summary>
    let ``_1.12`` = _prefix "1.12"
    /// <summary>
    /// The class of events in the BBC. This is a generic class to represent events (music events, historic events, sports events, politics events, e.t.c.).
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The superclass of all things the BBC creates or talks about.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// The class of organisations in the BBC. E.g., Businesses.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// The class of people in the BBC. Subclasses of this can be all types of people such as politicians, athletes, historic figures, contributors in programmes e.t.c.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// The class of places in the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// This concept is used to represent intangible things or abstract concepts.  For example, Financial Crisis, Midwifery, Happiness.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Theme"></see></summary>
    let Theme = _prefix "Theme"
    /// <summary>
    /// A person's date of birth.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfBirth"></see></summary>
    let dateOfBirth = _prefix "dateOfBirth"
    /// <summary>
    /// A person's date of death.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfDeath"></see></summary>
    let dateOfDeath = _prefix "dateOfDeath"
    /// <summary>
    /// One or two words to distinguish between entities that have similar labels - often displayed to both internal and external audiences.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/disambiguationHint"></see></summary>
    let disambiguationHint = _prefix "disambiguationHint"
    /// <summary>
    /// organisation as agent in an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventOrganisation"></see></summary>
    let eventOrganisation = _prefix "eventOrganisation"
    /// <summary>
    /// This is a high level property aiming to associate any core thing to any other core thing. For example that Tom Daley is notablyAssociatedWith diving or Glastonbury is notablyAssociatedWith music.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/notablyAssociatedWith"></see></summary>
    let notablyAssociatedWith = _prefix "notablyAssociatedWith"
    /// <summary>
    /// person as agent in an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPerson"></see></summary>
    let eventPerson = _prefix "eventPerson"
    /// <summary>
    /// place as location of an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPlace"></see></summary>
    let eventPlace = _prefix "eventPlace"
    /// <summary>
    /// theme as factor in an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventTheme"></see></summary>
    let eventTheme = _prefix "eventTheme"
    /// <summary>
    /// This property is required to distinguish people by gender.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/gender"></see></summary>
    let gender = _prefix "gender"
    /// <summary>
    /// A short summary of what a person is notably known for
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/knownFor"></see></summary>
    let knownFor = _prefix "knownFor"
    /// <summary>
    /// The a label for a thing. A thing may have one label per language.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// This property associates a person with a thematic area he or she worked in, for example Annie Lennox with Music.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/occupation"></see></summary>
    let occupation = _prefix "occupation"
    /// <summary>
    /// A person's place of birth.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfBirth"></see></summary>
    let placeOfBirth = _prefix "placeOfBirth"
    /// <summary>
    /// A person's place of death
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfDeath"></see></summary>
    let placeOfDeath = _prefix "placeOfDeath"
    /// <summary>
    /// The BBC editorially preferred label for a thing. A thing may have one and only one preferredLabel
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/preferredLabel"></see></summary>
    let preferredLabel = _prefix "preferredLabel"
    /// <summary>
    /// Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopic"></see></summary>
    let primaryTopic = _prefix "primaryTopic"
    /// <summary>
    /// Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopicOf"></see></summary>
    let primaryTopicOf = _prefix "primaryTopicOf"
    /// <summary>
    /// Indicates that something is the same as something else, but in a way that is slightly weaker than owl:sameAs. It's purpose is to connect separate identities of the same thing, whilst keeping separation between the original statements of each.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/sameAs"></see></summary>
    let sameAs = _prefix "sameAs"
    /// <summary>
    /// A short label for a thing usually needed for presentation purposes.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/shortLabel"></see></summary>
    let shortLabel = _prefix "shortLabel"
    /// <summary>
    /// Human readable keywords that may be used in a programmatic fashion e.g., manchester-city.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/slug"></see></summary>
    let slug = _prefix "slug"
