namespace http.data.press.net.ontology._event.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pne =
    let _namespace_iri = Namespace_Iri pne |> NamespaceIRI
    /// <summary>
    ///   <para>pne:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic Event Class, a subclass of event:Event. The Event class also subclasses pnt:Stuff as it is a Compound domain entity, this inheritance means news assets can be tagged with Events</para>
    /// labels<para>Generic Event Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/event/Event">http://data.press.net/ontology/event/Event</seealso>
    let Event = Prefixed_Name(pne, "Event") |> PrefixedName
    /// <summary>
    ///   <para>pne:subEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Transitive Property defining a parent-child relationship between events. Event Y is a sub event of Event X</para>
    /// labels<para>Transitive Property defining a parent-child relationship between events</para></remarks>
    /// <seealso href="http://data.press.net/ontology/event/subEventOf">http://data.press.net/ontology/event/subEventOf</seealso>
    let subEventOf = Prefixed_Name(pne, "subEventOf") |> PrefixedName
    /// <summary>
    ///   <para>pne:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property for expressing an event summary. Datatype is String</para>
    /// labels<para>An Event summary</para></remarks>
    /// <seealso href="http://data.press.net/ontology/event/summary">http://data.press.net/ontology/event/summary</seealso>
    let summary = Prefixed_Name(pne, "summary") |> PrefixedName
    /// <summary>
    ///   <para>pne:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property for expressing the theme of an event, its range is pns:Intangible</para>
    /// labels<para>Associates an Event with an intangible theme</para></remarks>
    /// <seealso href="http://data.press.net/ontology/event/theme">http://data.press.net/ontology/event/theme</seealso>
    let theme = Prefixed_Name(pne, "theme") |> PrefixedName
    /// <summary>
    ///   <para>pne:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property for expressing an event title. Datatype is String</para>
    /// labels<para>An Event title</para></remarks>
    /// <seealso href="http://data.press.net/ontology/event/title">http://data.press.net/ontology/event/title</seealso>
    let title = Prefixed_Name(pne, "title") |> PrefixedName
    /// <summary>
    ///   <para>pne:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The Event Ontology models news-worthy events and their relationship to news assets and stuff (simple entities) in the world.</para>
    /// </remarks>
    /// <seealso href="http://data.press.net/ontology/event/">http://data.press.net/ontology/event/</seealso>
    let _prefix_iri = Prefixed_Name(pne, "") |> PrefixedName
