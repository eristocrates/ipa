namespace http.eulersharp.sourceforge.net._2003._03swap.foster.hash

open DoxAletheia

module swap_foster =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/foster#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Code"></see>
    /// </summary>
    let Code = _prefix "Code"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Compound"></see></summary>
    let Compound = _prefix "Compound"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#ConfidentialityCode"></see>
    /// </summary>
    let ConfidentialityCode = _prefix "ConfidentialityCode"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Group"></see>
    /// </summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasMember"></see>
    /// </summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Language"></see>
    /// </summary>
    let Language = _prefix "Language"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Level"></see>
    /// </summary>
    let Level = _prefix "Level"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Nationality"></see>
    /// </summary>
    let Nationality = _prefix "Nationality"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Specimen"></see></summary>
    let Specimen = _prefix "Specimen"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#Summary"></see>
    /// </summary>
    let Summary = _prefix "Summary"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#codes"></see></summary>
    let codes = _prefix "codes"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCode"></see></summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#complexityOf"></see></summary>
    let complexityOf = _prefix "complexityOf"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/physicalResource&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasComplexity"></see></summary>
    let hasComplexity = _prefix "hasComplexity"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/space&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#containedBy"></see></summary>
    let containedBy = _prefix "containedBy"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/space&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasBrandName"></see>
    /// </summary>
    let hasBrandName = _prefix "hasBrandName"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasBroaderCode"></see></summary>
    let hasBroaderCode = _prefix "hasBroaderCode"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeAuthority"></see></summary>
    let hasCodeAuthority = _prefix "hasCodeAuthority"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeExpirationDateTime"></see></summary>
    let hasCodeExpirationDateTime = _prefix "hasCodeExpirationDateTime"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeSystem"></see></summary>
    let hasCodeSystem = _prefix "hasCodeSystem"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeValue"></see></summary>
    let hasCodeValue = _prefix "hasCodeValue"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCodeVersion"></see></summary>
    let hasCodeVersion = _prefix "hasCodeVersion"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasConfidentialityCode"></see></summary>
    let hasConfidentialityCode = _prefix "hasConfidentialityCode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasCountry"></see>
    /// </summary>
    let hasCountry = _prefix "hasCountry"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasLanguage"></see>
    /// </summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasLevel"></see>
    /// </summary>
    let hasLevel = _prefix "hasLevel"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasNationality"></see>
    /// </summary>
    let hasNationality = _prefix "hasNationality"
    /// <summary>
    /// Declared in &lt;http://eulersharp.sourceforge.net/2003/03swap/coding&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#hasSKOSCode"></see></summary>
    let hasSKOSCode = _prefix "hasSKOSCode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#memberOf"></see>
    /// </summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#refersTo"></see>
    /// </summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/foster#summaryOf"></see>
    /// </summary>
    let summaryOf = _prefix "summaryOf"
