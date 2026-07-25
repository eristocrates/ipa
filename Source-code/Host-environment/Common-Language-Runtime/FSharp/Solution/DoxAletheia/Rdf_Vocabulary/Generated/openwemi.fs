namespace https.ns.dublincore.org.openwemi.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module openwemi =
    let _namespace_iri = Namespace_Iri openwemi |> NamespaceIRI
    /// <summary>
    ///   <para>openwemi:Endeavor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A creation.</para>
    /// labels<para>Endeavor</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/Endeavor">https://ns.dublincore.org/openwemi/Endeavor</seealso>
    let Endeavor = Prefixed_Name(openwemi, "Endeavor") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An exemplar of a creation.</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/Item">https://ns.dublincore.org/openwemi/Item</seealso>
    let Item = Prefixed_Name(openwemi, "Item") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The physical embodiment of a creation.</para>
    /// labels<para>Manifestation</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/Manifestation">https://ns.dublincore.org/openwemi/Manifestation</seealso>
    let Manifestation = Prefixed_Name(openwemi, "Manifestation") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:commonEndeavor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates any two resources that are or contain the same endeavor.</para>
    /// labels<para>common Endeavor</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/commonEndeavor">https://ns.dublincore.org/openwemi/commonEndeavor</seealso>
    let commonEndeavor = Prefixed_Name(openwemi, "commonEndeavor") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:commonItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates any two resources that are or contain the same Item.</para>
    /// labels<para>common Item</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/commonItem">https://ns.dublincore.org/openwemi/commonItem</seealso>
    let commonItem = Prefixed_Name(openwemi, "commonItem") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:expressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression of a Work.</para>
    /// labels<para>expressed by</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/expressedBy">https://ns.dublincore.org/openwemi/expressedBy</seealso>
    let expressedBy = Prefixed_Name(openwemi, "expressedBy") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:instantiatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An instantiation of a Manifestation, an Expression or a Work.</para>
    /// labels<para>instantiated by</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/instantiatedBy">https://ns.dublincore.org/openwemi/instantiatedBy</seealso>
    let instantiatedBy = Prefixed_Name(openwemi, "instantiatedBy") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An abstract notion of an artistic or intellectual creation.</para>
    /// labels<para>Work</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/Work">https://ns.dublincore.org/openwemi/Work</seealso>
    let Work = Prefixed_Name(openwemi, "Work") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:expresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Endeavor that expresses a Work.</para>
    /// labels<para>expresses</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/expresses">https://ns.dublincore.org/openwemi/expresses</seealso>
    let expresses = Prefixed_Name(openwemi, "expresses") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:commonExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates any two resources that are or contain the same Expression.</para>
    /// labels<para>common Expression</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/commonExpression">https://ns.dublincore.org/openwemi/commonExpression</seealso>
    let commonExpression = Prefixed_Name(openwemi, "commonExpression") |> PrefixedName

    /// <summary>
    ///   <para>openwemi:commonManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates any two resources that are or contain the same Manifestation.</para>
    /// labels<para>common Manifestation</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/commonManifestation">https://ns.dublincore.org/openwemi/commonManifestation</seealso>
    let commonManifestation =
        Prefixed_Name(openwemi, "commonManifestation") |> PrefixedName

    /// <summary>
    ///   <para>openwemi:commonWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates any two resources that are or contain the same Work.</para>
    /// labels<para>common Work</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/commonWork">https://ns.dublincore.org/openwemi/commonWork</seealso>
    let commonWork = Prefixed_Name(openwemi, "commonWork") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:instantiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Endeavor that instantiates a Manifestation, an Expression or a Work.</para>
    /// labels<para>instantiates</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/instantiates">https://ns.dublincore.org/openwemi/instantiates</seealso>
    let instantiates = Prefixed_Name(openwemi, "instantiates") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:manifests</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Endeavor that manifests an Expression or a Work.</para>
    /// labels<para>manifests</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/manifests">https://ns.dublincore.org/openwemi/manifests</seealso>
    let manifests = Prefixed_Name(openwemi, "manifests") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:relatedItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Item that is related in some way to another Item.</para>
    /// labels<para>related Item</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/relatedItem">https://ns.dublincore.org/openwemi/relatedItem</seealso>
    let relatedItem = Prefixed_Name(openwemi, "relatedItem") |> PrefixedName

    /// <summary>
    ///   <para>openwemi:relatedManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Manifestation that is related in some way to another Manifestation.</para>
    /// labels<para>related Manifestation</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/relatedManifestation">https://ns.dublincore.org/openwemi/relatedManifestation</seealso>
    let relatedManifestation =
        Prefixed_Name(openwemi, "relatedManifestation") |> PrefixedName

    /// <summary>
    ///   <para>openwemi:manifestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Manifestation of a Work or an Expression.</para>
    /// labels<para>manifested by</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/manifestedBy">https://ns.dublincore.org/openwemi/manifestedBy</seealso>
    let manifestedBy = Prefixed_Name(openwemi, "manifestedBy") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:relatedExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression that is related in some way to another Expression.</para>
    /// labels<para>related Expression</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/relatedExpression">https://ns.dublincore.org/openwemi/relatedExpression</seealso>
    let relatedExpression = Prefixed_Name(openwemi, "relatedExpression") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:relatedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Work that is related in some way to another Work.</para>
    /// labels<para>related Work</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/relatedWork">https://ns.dublincore.org/openwemi/relatedWork</seealso>
    let relatedWork = Prefixed_Name(openwemi, "relatedWork") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/">https://ns.dublincore.org/openwemi/</seealso>
    let _prefix_iri = Prefixed_Name(openwemi, "") |> PrefixedName
    /// <summary>
    ///   <para>openwemi:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A perceivable form of the creation.</para>
    /// labels<para>Expression</para></remarks>
    /// <seealso href="https://ns.dublincore.org/openwemi/Expression">https://ns.dublincore.org/openwemi/Expression</seealso>
    let Expression = Prefixed_Name(openwemi, "Expression") |> PrefixedName
