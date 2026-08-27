namespace http.rdvocab.info.uri.schema.FRBRentitiesRDA.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdafrbr =
    let _namespace_iri = Namespace_Iri rdafrbr |> NamespaceIRI
    /// <summary>
    ///   <para>rdafrbr:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Agent">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Agent</seealso>
    let Agent = Prefixed_Name(rdafrbr, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Concept"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Concept">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Concept</seealso>
    let Concept = Prefixed_Name(rdafrbr, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:CorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Corporate Body"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/CorporateBody">http://rdvocab.info/uri/schema/FRBRentitiesRDA/CorporateBody</seealso>
    let CorporateBody = Prefixed_Name(rdafrbr, "CorporateBody") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Event">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Event</seealso>
    let Event = Prefixed_Name(rdafrbr, "Event") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Expression"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Expression">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Expression</seealso>
    let Expression = Prefixed_Name(rdafrbr, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Family">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Family</seealso>
    let Family = Prefixed_Name(rdafrbr, "Family") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Item"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Item">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Item</seealso>
    let Item = Prefixed_Name(rdafrbr, "Item") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Manifestation"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Manifestation">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Manifestation</seealso>
    let Manifestation = Prefixed_Name(rdafrbr, "Manifestation") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Name">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Name</seealso>
    let Name = Prefixed_Name(rdafrbr, "Name") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Object">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Object</seealso>
    let Object = Prefixed_Name(rdafrbr, "Object") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Person">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Person</seealso>
    let Person = Prefixed_Name(rdafrbr, "Person") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Place"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Place">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Place</seealso>
    let Place = Prefixed_Name(rdafrbr, "Place") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Subject"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Subject">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Subject</seealso>
    let Subject = Prefixed_Name(rdafrbr, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>rdafrbr:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Work"</para></remarks>
    /// <seealso href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Work">http://rdvocab.info/uri/schema/FRBRentitiesRDA/Work</seealso>
    let Work = Prefixed_Name(rdafrbr, "Work") |> PrefixedName
