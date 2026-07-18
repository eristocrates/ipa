namespace http.eulersharp.sourceforge.net._2003._03swap.foster.hash

open DoxAletheia.Rdf_Vocabulary

module swap_foster =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/foster#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Code"></see>
    /// </summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Compound"></see></summary>
    let Compound = Namespaced_IRI.parse _namespace_name "Compound" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#ConfidentialityCode"></see>
    /// </summary>
    let ConfidentialityCode =
        Namespaced_IRI.parse _namespace_name "ConfidentialityCode" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Group"></see>
    /// </summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasMember"></see>
    /// </summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Language"></see>
    /// </summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Level"></see>
    /// </summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Nationality"></see>
    /// </summary>
    let Nationality =
        Namespaced_IRI.parse _namespace_name "Nationality" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Specimen"></see></summary>
    let Specimen = Namespaced_IRI.parse _namespace_name "Specimen" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Summary"></see>
    /// </summary>
    let Summary = Namespaced_IRI.parse _namespace_name "Summary" |> NamespacedName
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#codes"></see></summary>
    let codes = Namespaced_IRI.parse _namespace_name "codes" |> NamespacedName
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCode"></see></summary>
    let hasCode = Namespaced_IRI.parse _namespace_name "hasCode" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#complexityOf"></see></summary>
    let complexityOf =
        Namespaced_IRI.parse _namespace_name "complexityOf" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasComplexity"></see></summary>
    let hasComplexity =
        Namespaced_IRI.parse _namespace_name "hasComplexity" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/space&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#containedBy"></see></summary>
    let containedBy =
        Namespaced_IRI.parse _namespace_name "containedBy" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/space&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasBrandName"></see>
    /// </summary>
    let hasBrandName =
        Namespaced_IRI.parse _namespace_name "hasBrandName" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasBroaderCode"></see></summary>
    let hasBroaderCode =
        Namespaced_IRI.parse _namespace_name "hasBroaderCode" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeAuthority"></see></summary>
    let hasCodeAuthority =
        Namespaced_IRI.parse _namespace_name "hasCodeAuthority" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeExpirationDateTime"></see></summary>
    let hasCodeExpirationDateTime =
        Namespaced_IRI.parse _namespace_name "hasCodeExpirationDateTime" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeSystem"></see></summary>
    let hasCodeSystem =
        Namespaced_IRI.parse _namespace_name "hasCodeSystem" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeValue"></see></summary>
    let hasCodeValue =
        Namespaced_IRI.parse _namespace_name "hasCodeValue" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeVersion"></see></summary>
    let hasCodeVersion =
        Namespaced_IRI.parse _namespace_name "hasCodeVersion" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasConfidentialityCode"></see></summary>
    let hasConfidentialityCode =
        Namespaced_IRI.parse _namespace_name "hasConfidentialityCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCountry"></see>
    /// </summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasLanguage"></see>
    /// </summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasLevel"></see>
    /// </summary>
    let hasLevel = Namespaced_IRI.parse _namespace_name "hasLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasNationality"></see>
    /// </summary>
    let hasNationality =
        Namespaced_IRI.parse _namespace_name "hasNationality" |> NamespacedName

    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasSKOSCode"></see></summary>
    let hasSKOSCode =
        Namespaced_IRI.parse _namespace_name "hasSKOSCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#memberOf"></see>
    /// </summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#refersTo"></see>
    /// </summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#summaryOf"></see>
    /// </summary>
    let summaryOf = Namespaced_IRI.parse _namespace_name "summaryOf" |> NamespacedName
