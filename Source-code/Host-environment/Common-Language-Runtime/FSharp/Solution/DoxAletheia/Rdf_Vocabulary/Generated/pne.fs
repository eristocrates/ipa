namespace http.data.press.net.ontology._event.slash

open DoxAletheia.Rdf_Vocabulary

module pne =
    let _namespace_name = "http://data.press.net/ontology/event/"
    /// <summary>
    /// Generic Event Class, a subclass of event:Event. The Event class also subclasses pnt:Stuff as it is a Compound domain entity, this inheritance means news assets can be tagged with Events
    /// <see href="http://data.press.net/ontology/event/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// Transitive Property defining a parent-child relationship between events. Event Y is a sub event of Event X
    /// <see href="http://data.press.net/ontology/event/subEventOf"></see></summary>
    let subEventOf = Namespaced_IRI.parse _namespace_name "subEventOf" |> NamespacedName
    /// <summary>
    /// Property for expressing an event summary. Datatype is String
    /// <see href="http://data.press.net/ontology/event/summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    /// Property for expressing the theme of an event, its range is pns:Intangible
    /// <see href="http://data.press.net/ontology/event/theme"></see></summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName
    /// <summary>
    /// Property for expressing an event title. Datatype is String
    /// <see href="http://data.press.net/ontology/event/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
