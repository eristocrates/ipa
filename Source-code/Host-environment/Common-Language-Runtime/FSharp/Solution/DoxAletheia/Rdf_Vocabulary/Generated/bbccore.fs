namespace http.www.bbc.co.uk.ontologies.coreconcepts.slash

open DoxAletheia.Rdf_Vocabulary

module bbccore =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/coreconcepts/"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/coreconcepts/1.11"></see>
    /// </summary>
    let ``_1.11`` = Namespaced_IRI.parse _namespace_name "1.11" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/coreconcepts/1.12"></see>
    /// </summary>
    let ``_1.12`` = Namespaced_IRI.parse _namespace_name "1.12" |> NamespacedName
    /// <summary>
    /// The class of events in the BBC. This is a generic class to represent events (music events, historic events, sports events, politics events, e.t.c.).
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// The superclass of all things the BBC creates or talks about.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName

    /// <summary>
    /// The class of organisations in the BBC. E.g., Businesses.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// The class of people in the BBC. Subclasses of this can be all types of people such as politicians, athletes, historic figures, contributors in programmes e.t.c.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// The class of places in the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    /// This concept is used to represent intangible things or abstract concepts.  For example, Financial Crisis, Midwifery, Happiness.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/Theme"></see></summary>
    let Theme = Namespaced_IRI.parse _namespace_name "Theme" |> NamespacedName

    /// <summary>
    /// A person's date of birth.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfBirth"></see></summary>
    let dateOfBirth =
        Namespaced_IRI.parse _namespace_name "dateOfBirth" |> NamespacedName

    /// <summary>
    /// A person's date of death.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/dateOfDeath"></see></summary>
    let dateOfDeath =
        Namespaced_IRI.parse _namespace_name "dateOfDeath" |> NamespacedName

    /// <summary>
    /// One or two words to distinguish between entities that have similar labels - often displayed to both internal and external audiences.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/disambiguationHint"></see></summary>
    let disambiguationHint =
        Namespaced_IRI.parse _namespace_name "disambiguationHint" |> NamespacedName

    /// <summary>
    /// organisation as agent in an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventOrganisation"></see></summary>
    let eventOrganisation =
        Namespaced_IRI.parse _namespace_name "eventOrganisation" |> NamespacedName

    /// <summary>
    /// This is a high level property aiming to associate any core thing to any other core thing. For example that Tom Daley is notablyAssociatedWith diving or Glastonbury is notablyAssociatedWith music.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/notablyAssociatedWith"></see></summary>
    let notablyAssociatedWith =
        Namespaced_IRI.parse _namespace_name "notablyAssociatedWith" |> NamespacedName

    /// <summary>
    /// person as agent in an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPerson"></see></summary>
    let eventPerson =
        Namespaced_IRI.parse _namespace_name "eventPerson" |> NamespacedName

    /// <summary>
    /// place as location of an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventPlace"></see></summary>
    let eventPlace = Namespaced_IRI.parse _namespace_name "eventPlace" |> NamespacedName
    /// <summary>
    /// theme as factor in an event
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/eventTheme"></see></summary>
    let eventTheme = Namespaced_IRI.parse _namespace_name "eventTheme" |> NamespacedName
    /// <summary>
    /// This property is required to distinguish people by gender.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/gender"></see></summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName
    /// <summary>
    /// A short summary of what a person is notably known for
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/knownFor"></see></summary>
    let knownFor = Namespaced_IRI.parse _namespace_name "knownFor" |> NamespacedName
    /// <summary>
    /// The a label for a thing. A thing may have one label per language.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// This property associates a person with a thematic area he or she worked in, for example Annie Lennox with Music.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/occupation"></see></summary>
    let occupation = Namespaced_IRI.parse _namespace_name "occupation" |> NamespacedName

    /// <summary>
    /// A person's place of birth.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfBirth"></see></summary>
    let placeOfBirth =
        Namespaced_IRI.parse _namespace_name "placeOfBirth" |> NamespacedName

    /// <summary>
    /// A person's place of death
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/placeOfDeath"></see></summary>
    let placeOfDeath =
        Namespaced_IRI.parse _namespace_name "placeOfDeath" |> NamespacedName

    /// <summary>
    /// The BBC editorially preferred label for a thing. A thing may have one and only one preferredLabel
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/preferredLabel"></see></summary>
    let preferredLabel =
        Namespaced_IRI.parse _namespace_name "preferredLabel" |> NamespacedName

    /// <summary>
    /// Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopic"></see></summary>
    let primaryTopic =
        Namespaced_IRI.parse _namespace_name "primaryTopic" |> NamespacedName

    /// <summary>
    /// Represents the fact that a thing (usually concept, e.g., Tom Daley) is the primary topic of a web document.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/primaryTopicOf"></see></summary>
    let primaryTopicOf =
        Namespaced_IRI.parse _namespace_name "primaryTopicOf" |> NamespacedName

    /// <summary>
    /// Indicates that something is the same as something else, but in a way that is slightly weaker than owl:sameAs. It's purpose is to connect separate identities of the same thing, whilst keeping separation between the original statements of each.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/sameAs"></see></summary>
    let sameAs = Namespaced_IRI.parse _namespace_name "sameAs" |> NamespacedName
    /// <summary>
    /// A short label for a thing usually needed for presentation purposes.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/shortLabel"></see></summary>
    let shortLabel = Namespaced_IRI.parse _namespace_name "shortLabel" |> NamespacedName
    /// <summary>
    /// Human readable keywords that may be used in a programmatic fashion e.g., manchester-city.
    /// <see href="http://www.bbc.co.uk/ontologies/coreconcepts/slug"></see></summary>
    let slug = Namespaced_IRI.parse _namespace_name "slug" |> NamespacedName
