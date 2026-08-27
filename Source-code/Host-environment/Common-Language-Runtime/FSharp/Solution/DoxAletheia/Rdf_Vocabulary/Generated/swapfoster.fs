namespace http.eulersharp.sourceforge.net._2003._03swap.foster.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapfoster =
    let _namespace_iri = Namespace_Iri swapfoster |> NamespaceIRI
    /// <summary>
    ///   <para>swapfoster:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#">http://eulersharp.sourceforge.net/2003/03swap/foster#</seealso>
    let _prefix_iri = Prefixed_Name(swapfoster, "") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>"code"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Code">http://eulersharp.sourceforge.net/2003/03swap/foster#Code</seealso>
    let Code = Prefixed_Name(swapfoster, "Code") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;"</para>
    /// labels<para>"compound"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Compound">http://eulersharp.sourceforge.net/2003/03swap/foster#Compound</seealso>
    let Compound = Prefixed_Name(swapfoster, "Compound") |> PrefixedName

    /// <summary>
    ///   <para>swapfoster:ConfidentialityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>"confidentiality code"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#ConfidentialityCode">http://eulersharp.sourceforge.net/2003/03swap/foster#ConfidentialityCode</seealso>
    let ConfidentialityCode =
        Prefixed_Name(swapfoster, "ConfidentialityCode") |> PrefixedName

    /// <summary>
    ///   <para>swapfoster:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;"</para>
    /// labels<para>"device"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Device">http://eulersharp.sourceforge.net/2003/03swap/foster#Device</seealso>
    let Device = Prefixed_Name(swapfoster, "Device") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"group"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Group">http://eulersharp.sourceforge.net/2003/03swap/foster#Group</seealso>
    let Group = Prefixed_Name(swapfoster, "Group") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Language">http://eulersharp.sourceforge.net/2003/03swap/foster#Language</seealso>
    let Language = Prefixed_Name(swapfoster, "Language") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"level"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Level">http://eulersharp.sourceforge.net/2003/03swap/foster#Level</seealso>
    let Level = Prefixed_Name(swapfoster, "Level") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Nationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"nationality"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Nationality">http://eulersharp.sourceforge.net/2003/03swap/foster#Nationality</seealso>
    let Nationality = Prefixed_Name(swapfoster, "Nationality") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;"</para>
    /// labels<para>"product"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Product">http://eulersharp.sourceforge.net/2003/03swap/foster#Product</seealso>
    let Product = Prefixed_Name(swapfoster, "Product") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Specimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;"</para>
    /// labels<para>"specimen"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Specimen">http://eulersharp.sourceforge.net/2003/03swap/foster#Specimen</seealso>
    let Specimen = Prefixed_Name(swapfoster, "Specimen") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:Summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#Summary">http://eulersharp.sourceforge.net/2003/03swap/foster#Summary</seealso>
    let Summary = Prefixed_Name(swapfoster, "Summary") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:codes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#codes">http://eulersharp.sourceforge.net/2003/03swap/foster#codes</seealso>
    let codes = Prefixed_Name(swapfoster, "codes") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:complexityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#complexityOf">http://eulersharp.sourceforge.net/2003/03swap/foster#complexityOf</seealso>
    let complexityOf = Prefixed_Name(swapfoster, "complexityOf") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:containedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/space&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#containedBy">http://eulersharp.sourceforge.net/2003/03swap/foster#containedBy</seealso>
    let containedBy = Prefixed_Name(swapfoster, "containedBy") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/space&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#contains">http://eulersharp.sourceforge.net/2003/03swap/foster#contains</seealso>
    let contains = Prefixed_Name(swapfoster, "contains") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasBrandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"brand name"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasBrandName">http://eulersharp.sourceforge.net/2003/03swap/foster#hasBrandName</seealso>
    let hasBrandName = Prefixed_Name(swapfoster, "hasBrandName") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasBroaderCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasBroaderCode">http://eulersharp.sourceforge.net/2003/03swap/foster#hasBroaderCode</seealso>
    let hasBroaderCode = Prefixed_Name(swapfoster, "hasBroaderCode") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCode">http://eulersharp.sourceforge.net/2003/03swap/foster#hasCode</seealso>
    let hasCode = Prefixed_Name(swapfoster, "hasCode") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasCodeAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeAuthority">http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeAuthority</seealso>
    let hasCodeAuthority = Prefixed_Name(swapfoster, "hasCodeAuthority") |> PrefixedName

    /// <summary>
    ///   <para>swapfoster:hasCodeExpirationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeExpirationDateTime">http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeExpirationDateTime</seealso>
    let hasCodeExpirationDateTime =
        Prefixed_Name(swapfoster, "hasCodeExpirationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>swapfoster:hasCodeSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeSystem">http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeSystem</seealso>
    let hasCodeSystem = Prefixed_Name(swapfoster, "hasCodeSystem") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasCodeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeValue">http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeValue</seealso>
    let hasCodeValue = Prefixed_Name(swapfoster, "hasCodeValue") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasCodeVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeVersion">http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeVersion</seealso>
    let hasCodeVersion = Prefixed_Name(swapfoster, "hasCodeVersion") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasComplexity">http://eulersharp.sourceforge.net/2003/03swap/foster#hasComplexity</seealso>
    let hasComplexity = Prefixed_Name(swapfoster, "hasComplexity") |> PrefixedName

    /// <summary>
    ///   <para>swapfoster:hasConfidentialityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasConfidentialityCode">http://eulersharp.sourceforge.net/2003/03swap/foster#hasConfidentialityCode</seealso>
    let hasConfidentialityCode =
        Prefixed_Name(swapfoster, "hasConfidentialityCode") |> PrefixedName

    /// <summary>
    ///   <para>swapfoster:hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCountry">http://eulersharp.sourceforge.net/2003/03swap/foster#hasCountry</seealso>
    let hasCountry = Prefixed_Name(swapfoster, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasLanguage">http://eulersharp.sourceforge.net/2003/03swap/foster#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(swapfoster, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasLevel">http://eulersharp.sourceforge.net/2003/03swap/foster#hasLevel</seealso>
    let hasLevel = Prefixed_Name(swapfoster, "hasLevel") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasMember">http://eulersharp.sourceforge.net/2003/03swap/foster#hasMember</seealso>
    let hasMember = Prefixed_Name(swapfoster, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasNationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasNationality">http://eulersharp.sourceforge.net/2003/03swap/foster#hasNationality</seealso>
    let hasNationality = Prefixed_Name(swapfoster, "hasNationality") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:hasSKOSCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;"</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasSKOSCode">http://eulersharp.sourceforge.net/2003/03swap/foster#hasSKOSCode</seealso>
    let hasSKOSCode = Prefixed_Name(swapfoster, "hasSKOSCode") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#memberOf">http://eulersharp.sourceforge.net/2003/03swap/foster#memberOf</seealso>
    let memberOf = Prefixed_Name(swapfoster, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#refersTo">http://eulersharp.sourceforge.net/2003/03swap/foster#refersTo</seealso>
    let refersTo = Prefixed_Name(swapfoster, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>swapfoster:summaryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/foster#summaryOf">http://eulersharp.sourceforge.net/2003/03swap/foster#summaryOf</seealso>
    let summaryOf = Prefixed_Name(swapfoster, "summaryOf") |> PrefixedName
