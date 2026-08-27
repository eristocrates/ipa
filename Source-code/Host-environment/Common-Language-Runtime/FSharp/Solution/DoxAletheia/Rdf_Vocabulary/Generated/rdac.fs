namespace http.rdaregistry.info.Elements.c.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdac =
    let _namespace_iri = Namespace_Iri rdac |> NamespaceIRI
    /// <summary>
    ///   <para>rdac:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/">http://rdaregistry.info/Elements/c/</seealso>
    let _prefix_iri = Prefixed_Name(rdac, "") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Agent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Agent">http://rdaregistry.info/Elements/c/Agent</seealso>
    let Agent = Prefixed_Name(rdac, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Agent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Agent.en">http://rdaregistry.info/Elements/c/Agent.en</seealso>
    let ``Agent.en`` = Prefixed_Name(rdac, "Agent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Work"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10001">http://rdaregistry.info/Elements/c/C10001</seealso>
    let C10001 = Prefixed_Name(rdac, "C10001") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10002">http://rdaregistry.info/Elements/c/C10002</seealso>
    let C10002 = Prefixed_Name(rdac, "C10002") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10003">http://rdaregistry.info/Elements/c/C10003</seealso>
    let C10003 = Prefixed_Name(rdac, "C10003") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10004">http://rdaregistry.info/Elements/c/C10004</seealso>
    let C10004 = Prefixed_Name(rdac, "C10004") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Corporate body"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10005">http://rdaregistry.info/Elements/c/C10005</seealso>
    let C10005 = Prefixed_Name(rdac, "C10005") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Expression"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10006">http://rdaregistry.info/Elements/c/C10006</seealso>
    let C10006 = Prefixed_Name(rdac, "C10006") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Manifestation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10007">http://rdaregistry.info/Elements/c/C10007</seealso>
    let C10007 = Prefixed_Name(rdac, "C10007") |> PrefixedName
    /// <summary>
    ///   <para>rdac:C10008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/C10008">http://rdaregistry.info/Elements/c/C10008</seealso>
    let C10008 = Prefixed_Name(rdac, "C10008") |> PrefixedName
    /// <summary>
    ///   <para>rdac:CorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/CorporateBody.en">http://rdaregistry.info/Elements/c/CorporateBody.en</seealso>
    let ``CorporateBody.en`` = Prefixed_Name(rdac, "CorporateBody.en") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Expression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Expression.en">http://rdaregistry.info/Elements/c/Expression.en</seealso>
    let ``Expression.en`` = Prefixed_Name(rdac, "Expression.en") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Family.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Family.en">http://rdaregistry.info/Elements/c/Family.en</seealso>
    let ``Family.en`` = Prefixed_Name(rdac, "Family.en") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Item</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Item">http://rdaregistry.info/Elements/c/Item</seealso>
    let Item = Prefixed_Name(rdac, "Item") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Item.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Item.en">http://rdaregistry.info/Elements/c/Item.en</seealso>
    let ``Item.en`` = Prefixed_Name(rdac, "Item.en") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Manifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Manifestation.en">http://rdaregistry.info/Elements/c/Manifestation.en</seealso>
    let ``Manifestation.en`` = Prefixed_Name(rdac, "Manifestation.en") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Person.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Person.en">http://rdaregistry.info/Elements/c/Person.en</seealso>
    let ``Person.en`` = Prefixed_Name(rdac, "Person.en") |> PrefixedName
    /// <summary>
    ///   <para>rdac:Work.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/c/Work.en">http://rdaregistry.info/Elements/c/Work.en</seealso>
    let ``Work.en`` = Prefixed_Name(rdac, "Work.en") |> PrefixedName
