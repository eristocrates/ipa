namespace http.cookingbigdata.com.linkeddata.ccsla.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ccsla =
    let _namespace_iri = Namespace_Iri ccsla |> NamespaceIRI
    /// <summary>
    ///   <para>ccsla:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Service Level Agreement for Cloud Computing"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#">http://cookingbigdata.com/linkeddata/ccsla#</seealso>
    let _prefix_iri = Prefixed_Name(ccsla, "") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:Claim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Claims of the agreement license"</para>
    /// labels<para>"Claims of the agreement"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#Claim">http://cookingbigdata.com/linkeddata/ccsla#Claim</seealso>
    let Claim = Prefixed_Name(ccsla, "Claim") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Conditions and levels of the agreement and compensation"</para>
    /// labels<para>"Conditions of compensation"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#Condition">http://cookingbigdata.com/linkeddata/ccsla#Condition</seealso>
    let Condition = Prefixed_Name(ccsla, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Definitions of the agreement license used in terms"</para>
    /// labels<para>"Definitions of the agreement"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#Definition">http://cookingbigdata.com/linkeddata/ccsla#Definition</seealso>
    let Definition = Prefixed_Name(ccsla, "Definition") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:Limitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Limitations and Exclusions of the agreement license considering Compensations"</para>
    /// labels<para>"Limitations of the agreement"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#Limitation">http://cookingbigdata.com/linkeddata/ccsla#Limitation</seealso>
    let Limitation = Prefixed_Name(ccsla, "Limitation") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:SLA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"SLA Main Class"</para>
    /// labels<para>"SLA Class"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#SLA">http://cookingbigdata.com/linkeddata/ccsla#SLA</seealso>
    let SLA = Prefixed_Name(ccsla, "SLA") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:ServiceCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"ServiceCredits of the agreement license considering Compensations terms"</para>
    /// labels<para>"ServiceCredits of the agreement"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#ServiceCredit">http://cookingbigdata.com/linkeddata/ccsla#ServiceCredit</seealso>
    let ServiceCredit = Prefixed_Name(ccsla, "ServiceCredit") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Term of the SLA"</para>
    /// labels<para>"Term of the agreement"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#Term">http://cookingbigdata.com/linkeddata/ccsla#Term</seealso>
    let Term = Prefixed_Name(ccsla, "Term") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:containsTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"SLA contains Terms of the agreement"</para>
    /// labels<para>"SLA Contains"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#containsTerm">http://cookingbigdata.com/linkeddata/ccsla#containsTerm</seealso>
    let containsTerm = Prefixed_Name(ccsla, "containsTerm") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:cookingbigdata</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#cookingbigdata">http://cookingbigdata.com/linkeddata/ccsla#cookingbigdata</seealso>
    let cookingbigdata = Prefixed_Name(ccsla, "cookingbigdata") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:hasCompensation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Term Compensation of the agreement"</para>
    /// labels<para>"Term Compensation"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#hasCompensation">http://cookingbigdata.com/linkeddata/ccsla#hasCompensation</seealso>
    let hasCompensation = Prefixed_Name(ccsla, "hasCompensation") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:hasDefinitionValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Definition values of an agreement term."</para>
    /// labels<para>"Definition values"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#hasDefinitionValue">http://cookingbigdata.com/linkeddata/ccsla#hasDefinitionValue</seealso>
    let hasDefinitionValue = Prefixed_Name(ccsla, "hasDefinitionValue") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:hasTermValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Definition values of an agreement term."</para>
    /// labels<para>"Terms values"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#hasTermValue">http://cookingbigdata.com/linkeddata/ccsla#hasTermValue</seealso>
    let hasTermValue = Prefixed_Name(ccsla, "hasTermValue") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:hasValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Validity interval of an agreement term."</para>
    /// labels<para>"Validity interval"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#hasValidity">http://cookingbigdata.com/linkeddata/ccsla#hasValidity</seealso>
    let hasValidity = Prefixed_Name(ccsla, "hasValidity") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:includeDefs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Include definitions"</para>
    /// labels<para>"Include Defs"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#includeDefs">http://cookingbigdata.com/linkeddata/ccsla#includeDefs</seealso>
    let includeDefs = Prefixed_Name(ccsla, "includeDefs") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:includeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Values of the condition"</para>
    /// labels<para>"With values"</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#includeValue">http://cookingbigdata.com/linkeddata/ccsla#includeValue</seealso>
    let includeValue = Prefixed_Name(ccsla, "includeValue") |> PrefixedName
    /// <summary>
    ///   <para>ccsla:manuelparra</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccsla#manuelparra">http://cookingbigdata.com/linkeddata/ccsla#manuelparra</seealso>
    let manuelparra = Prefixed_Name(ccsla, "manuelparra") |> PrefixedName
