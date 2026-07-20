namespace http.data.press.net.ontology._event.slash

open DoxAletheia

module pne =
    let _namespace_name = "http://data.press.net/ontology/event/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Generic Event Class, a subclass of event:Event. The Event class also subclasses pnt:Stuff as it is a Compound domain entity, this inheritance means news assets can be tagged with Events
    /// <see href="http://data.press.net/ontology/event/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Transitive Property defining a parent-child relationship between events. Event Y is a sub event of Event X
    /// <see href="http://data.press.net/ontology/event/subEventOf"></see></summary>
    let subEventOf = _prefix "subEventOf"
    /// <summary>
    /// Property for expressing an event summary. Datatype is String
    /// <see href="http://data.press.net/ontology/event/summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// Property for expressing the theme of an event, its range is pns:Intangible
    /// <see href="http://data.press.net/ontology/event/theme"></see></summary>
    let theme = _prefix "theme"
    /// <summary>
    /// Property for expressing an event title. Datatype is String
    /// <see href="http://data.press.net/ontology/event/title"></see></summary>
    let title = _prefix "title"
