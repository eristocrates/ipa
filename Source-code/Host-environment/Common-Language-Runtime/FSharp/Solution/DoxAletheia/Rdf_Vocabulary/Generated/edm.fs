namespace http.www.europeana.eu.schemas.edm.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module edm =
    let _namespace_iri = Namespace_Iri edm |> NamespaceIRI
    /// <summary>
    ///   <para>edm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"The present specification is based on the document "Definition of the Europeana Data Model elements", originally edited by Carlo Meghini. It is aligned with the version 5.2.4 of these EDM Definitions."</para>
    /// </remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/">http://www.europeana.eu/schemas/edm/</seealso>
    let _prefix_iri = Prefixed_Name(edm, "") |> PrefixedName
    /// <summary>
    ///   <para>edm:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/Agent">http://www.europeana.eu/schemas/edm/Agent</seealso>
    let Agent = Prefixed_Name(edm, "Agent") |> PrefixedName

    /// <summary>
    ///   <para>edm:EuropeanaAggregation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Europeana Aggregation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/EuropeanaAggregation">http://www.europeana.eu/schemas/edm/EuropeanaAggregation</seealso>
    let EuropeanaAggregation =
        Prefixed_Name(edm, "EuropeanaAggregation") |> PrefixedName

    /// <summary>
    ///   <para>edm:EuropeanaObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Europeana Object"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/EuropeanaObject">http://www.europeana.eu/schemas/edm/EuropeanaObject</seealso>
    let EuropeanaObject = Prefixed_Name(edm, "EuropeanaObject") |> PrefixedName
    /// <summary>
    ///   <para>edm:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/Event">http://www.europeana.eu/schemas/edm/Event</seealso>
    let Event = Prefixed_Name(edm, "Event") |> PrefixedName
    /// <summary>
    ///   <para>edm:InformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Resource"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/InformationResource">http://www.europeana.eu/schemas/edm/InformationResource</seealso>
    let InformationResource = Prefixed_Name(edm, "InformationResource") |> PrefixedName

    /// <summary>
    ///   <para>edm:NonInformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Non-Information Resource"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/NonInformationResource">http://www.europeana.eu/schemas/edm/NonInformationResource</seealso>
    let NonInformationResource =
        Prefixed_Name(edm, "NonInformationResource") |> PrefixedName

    /// <summary>
    ///   <para>edm:PhysicalThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physical Thing"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/PhysicalThing">http://www.europeana.eu/schemas/edm/PhysicalThing</seealso>
    let PhysicalThing = Prefixed_Name(edm, "PhysicalThing") |> PrefixedName
    /// <summary>
    ///   <para>edm:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Place"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/Place">http://www.europeana.eu/schemas/edm/Place</seealso>
    let Place = Prefixed_Name(edm, "Place") |> PrefixedName
    /// <summary>
    ///   <para>edm:ProvidedCHO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Provided CHO"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/ProvidedCHO">http://www.europeana.eu/schemas/edm/ProvidedCHO</seealso>
    let ProvidedCHO = Prefixed_Name(edm, "ProvidedCHO") |> PrefixedName
    /// <summary>
    ///   <para>edm:TimeSpan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Time Span"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/TimeSpan">http://www.europeana.eu/schemas/edm/TimeSpan</seealso>
    let TimeSpan = Prefixed_Name(edm, "TimeSpan") |> PrefixedName
    /// <summary>
    ///   <para>edm:WebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Web Resource"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/WebResource">http://www.europeana.eu/schemas/edm/WebResource</seealso>
    let WebResource = Prefixed_Name(edm, "WebResource") |> PrefixedName
    /// <summary>
    ///   <para>edm:aggregatedCHO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Aggregated Cultural Heritage Object"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/aggregatedCHO">http://www.europeana.eu/schemas/edm/aggregatedCHO</seealso>
    let aggregatedCHO = Prefixed_Name(edm, "aggregatedCHO") |> PrefixedName
    /// <summary>
    ///   <para>edm:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Begin"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/begin">http://www.europeana.eu/schemas/edm/begin</seealso>
    let begin_ = Prefixed_Name(edm, "begin") |> PrefixedName
    /// <summary>
    ///   <para>edm:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/country">http://www.europeana.eu/schemas/edm/country</seealso>
    let country = Prefixed_Name(edm, "country") |> PrefixedName
    /// <summary>
    ///   <para>edm:currentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Current Location"</para><para>"currentLocation"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/currentLocation">http://www.europeana.eu/schemas/edm/currentLocation</seealso>
    let currentLocation = Prefixed_Name(edm, "currentLocation") |> PrefixedName
    /// <summary>
    ///   <para>edm:dataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Europeana Data Provider"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/dataProvider">http://www.europeana.eu/schemas/edm/dataProvider</seealso>
    let dataProvider = Prefixed_Name(edm, "dataProvider") |> PrefixedName
    /// <summary>
    ///   <para>edm:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"End"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/end">http://www.europeana.eu/schemas/edm/end</seealso>
    let end_ = Prefixed_Name(edm, "end") |> PrefixedName
    /// <summary>
    ///   <para>edm:formerLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"formerLocation"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/formerLocation">http://www.europeana.eu/schemas/edm/formerLocation</seealso>
    let formerLocation = Prefixed_Name(edm, "formerLocation") |> PrefixedName
    /// <summary>
    ///   <para>edm:happenedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Happened At"</para><para>"happenedAt"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/happenedAt">http://www.europeana.eu/schemas/edm/happenedAt</seealso>
    let happenedAt = Prefixed_Name(edm, "happenedAt") |> PrefixedName
    /// <summary>
    ///   <para>edm:hasMet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Has Met"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/hasMet">http://www.europeana.eu/schemas/edm/hasMet</seealso>
    let hasMet = Prefixed_Name(edm, "hasMet") |> PrefixedName
    /// <summary>
    ///   <para>edm:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Has Type"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/hasType">http://www.europeana.eu/schemas/edm/hasType</seealso>
    let hasType = Prefixed_Name(edm, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>edm:hasView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Has View"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/hasView">http://www.europeana.eu/schemas/edm/hasView</seealso>
    let hasView = Prefixed_Name(edm, "hasView") |> PrefixedName
    /// <summary>
    ///   <para>edm:incorporates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Incorporates"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/incorporates">http://www.europeana.eu/schemas/edm/incorporates</seealso>
    let incorporates = Prefixed_Name(edm, "incorporates") |> PrefixedName
    /// <summary>
    ///   <para>edm:isAnnotationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Is Annotation Of"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isAnnotationOf">http://www.europeana.eu/schemas/edm/isAnnotationOf</seealso>
    let isAnnotationOf = Prefixed_Name(edm, "isAnnotationOf") |> PrefixedName
    /// <summary>
    ///   <para>edm:isDerivativeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDerivativeOf"</para><para>"Is Derivative Of"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isDerivativeOf">http://www.europeana.eu/schemas/edm/isDerivativeOf</seealso>
    let isDerivativeOf = Prefixed_Name(edm, "isDerivativeOf") |> PrefixedName
    /// <summary>
    ///   <para>edm:isNextInSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Is Next In Sequence Of"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isNextInSequence">http://www.europeana.eu/schemas/edm/isNextInSequence</seealso>
    let isNextInSequence = Prefixed_Name(edm, "isNextInSequence") |> PrefixedName
    /// <summary>
    ///   <para>edm:isNextInSequenceTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isNextInSequenceTo"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isNextInSequenceTo">http://www.europeana.eu/schemas/edm/isNextInSequenceTo</seealso>
    let isNextInSequenceTo = Prefixed_Name(edm, "isNextInSequenceTo") |> PrefixedName
    /// <summary>
    ///   <para>edm:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isRelatedTo"</para><para>"Is Related To"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isRelatedTo">http://www.europeana.eu/schemas/edm/isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(edm, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>edm:isRepresentationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Is Representation Of"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isRepresentationOf">http://www.europeana.eu/schemas/edm/isRepresentationOf</seealso>
    let isRepresentationOf = Prefixed_Name(edm, "isRepresentationOf") |> PrefixedName
    /// <summary>
    ///   <para>edm:isShownAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isShownAt"</para><para>"Is Shown At"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isShownAt">http://www.europeana.eu/schemas/edm/isShownAt</seealso>
    let isShownAt = Prefixed_Name(edm, "isShownAt") |> PrefixedName
    /// <summary>
    ///   <para>edm:isShownBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Is Shown By"</para><para>"isShownBy"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isShownBy">http://www.europeana.eu/schemas/edm/isShownBy</seealso>
    let isShownBy = Prefixed_Name(edm, "isShownBy") |> PrefixedName
    /// <summary>
    ///   <para>edm:isSimilarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Is Similar To"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isSimilarTo">http://www.europeana.eu/schemas/edm/isSimilarTo</seealso>
    let isSimilarTo = Prefixed_Name(edm, "isSimilarTo") |> PrefixedName
    /// <summary>
    ///   <para>edm:isSuccessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isSuccessorOf"</para><para>"Is Successor Of"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/isSuccessorOf">http://www.europeana.eu/schemas/edm/isSuccessorOf</seealso>
    let isSuccessorOf = Prefixed_Name(edm, "isSuccessorOf") |> PrefixedName
    /// <summary>
    ///   <para>edm:landingPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Landing Page"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/landingPage">http://www.europeana.eu/schemas/edm/landingPage</seealso>
    let landingPage = Prefixed_Name(edm, "landingPage") |> PrefixedName
    /// <summary>
    ///   <para>edm:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The recommended best practice is to use a controlled vocabulary such as
    /// RFC 4646 (http://www.rfc-archive.org/getrfc.php?rfc=4646) which, in
    /// conjunction with ISO 639, defines two- and three-letter primary language tags. Either a coded value or text string can be represented here."</para>
    /// labels<para>"Europeana Language"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/language">http://www.europeana.eu/schemas/edm/language</seealso>
    let language = Prefixed_Name(edm, "language") |> PrefixedName
    /// <summary>
    ///   <para>edm:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/object">http://www.europeana.eu/schemas/edm/object</seealso>
    let object = Prefixed_Name(edm, "object") |> PrefixedName
    /// <summary>
    ///   <para>edm:occurredAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Occured At"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/occurredAt">http://www.europeana.eu/schemas/edm/occurredAt</seealso>
    let occurredAt = Prefixed_Name(edm, "occurredAt") |> PrefixedName
    /// <summary>
    ///   <para>edm:preview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Preview"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/preview">http://www.europeana.eu/schemas/edm/preview</seealso>
    let preview = Prefixed_Name(edm, "preview") |> PrefixedName
    /// <summary>
    ///   <para>edm:provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Europeana Provider"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/provider">http://www.europeana.eu/schemas/edm/provider</seealso>
    let provider = Prefixed_Name(edm, "provider") |> PrefixedName
    /// <summary>
    ///   <para>edm:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Realizes"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/realizes">http://www.europeana.eu/schemas/edm/realizes</seealso>
    let realizes = Prefixed_Name(edm, "realizes") |> PrefixedName
    /// <summary>
    ///   <para>edm:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Europeana Rights"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/rights">http://www.europeana.eu/schemas/edm/rights</seealso>
    let rights = Prefixed_Name(edm, "rights") |> PrefixedName
    /// <summary>
    ///   <para>edm:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Europeana Type"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/type">http://www.europeana.eu/schemas/edm/type</seealso>
    let type_ = Prefixed_Name(edm, "type") |> PrefixedName
    /// <summary>
    ///   <para>edm:ugc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"UGC"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/ugc">http://www.europeana.eu/schemas/edm/ugc</seealso>
    let ugc = Prefixed_Name(edm, "ugc") |> PrefixedName
    /// <summary>
    ///   <para>edm:unstored</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Unstored"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/unstored">http://www.europeana.eu/schemas/edm/unstored</seealso>
    let unstored = Prefixed_Name(edm, "unstored") |> PrefixedName
    /// <summary>
    ///   <para>edm:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Europeana URI"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/uri">http://www.europeana.eu/schemas/edm/uri</seealso>
    let uri = Prefixed_Name(edm, "uri") |> PrefixedName
    /// <summary>
    ///   <para>edm:userTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"User Tag"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/userTag">http://www.europeana.eu/schemas/edm/userTag</seealso>
    let userTag = Prefixed_Name(edm, "userTag") |> PrefixedName
    /// <summary>
    ///   <para>edm:wasPresentAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Was Present At"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/wasPresentAt">http://www.europeana.eu/schemas/edm/wasPresentAt</seealso>
    let wasPresentAt = Prefixed_Name(edm, "wasPresentAt") |> PrefixedName
    /// <summary>
    ///   <para>edm:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Europeana Year"</para></remarks>
    /// <seealso href="http://www.europeana.eu/schemas/edm/year">http://www.europeana.eu/schemas/edm/year</seealso>
    let year = Prefixed_Name(edm, "year") |> PrefixedName
