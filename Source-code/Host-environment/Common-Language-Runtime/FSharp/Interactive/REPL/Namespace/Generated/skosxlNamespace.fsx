#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module skosxl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2008/05/skos-xl#" "skosxl"

    /// <summary>
    ///   <para>skos:definition : A special class of lexical entities.</para>
    ///   <para>rdfs:label : Label</para>
    ///   <a href="http://www.w3.org/2008/05/skos-xl#Label">skosxl:Label</a>
    /// </summary>
    let Label = _prefixId.prefix "Label"
    /// <summary>
    ///   <para>rdfs:comment : If C skosxl:altLabel L and L skosxl:literalForm V, then X skos:altLabel V.</para>
    ///   <para>skos:definition : The property skosxl:altLabel is used to associate an skosxl:Label with a skos:Concept. The property is analogous to skos:altLabel.</para>
    ///   <para>rdfs:label : alternative label</para>
    ///   <a href="http://www.w3.org/2008/05/skos-xl#altLabel">skosxl:altLabel</a>
    /// </summary>
    let altLabel = _prefixId.prefix "altLabel"
    /// <summary>
    ///   <para>rdfs:comment : If C skosxl:hiddenLabel L and L skosxl:literalForm V, then C skos:hiddenLabel V.</para>
    ///   <para>skos:definition : The property skosxl:hiddenLabel is used to associate an skosxl:Label with a skos:Concept. The property is analogous to skos:hiddenLabel.</para>
    ///   <para>rdfs:label : hidden label</para>
    ///   <a href="http://www.w3.org/2008/05/skos-xl#hiddenLabel">skosxl:hiddenLabel</a>
    /// </summary>
    let hiddenLabel = _prefixId.prefix "hiddenLabel"
    /// <summary>
    ///   <para>skos:scopeNote : skosxl:labelRelation is not intended to be used directly, but rather as the basis for a design pattern which can be refined for more specific labeling scenarios.</para>
    ///   <para>skos:definition : The property skosxl:labelRelation is used for representing binary ('direct') relations between instances of the class skosxl:Label.</para>
    ///   <para>rdfs:label : label relation</para>
    ///   <a href="http://www.w3.org/2008/05/skos-xl#labelRelation">skosxl:labelRelation</a>
    /// </summary>
    let labelRelation = _prefixId.prefix "labelRelation"
    /// <summary>
    ///   <para>rdfs:comment : The range of skosxl:literalForm is the class of RDF plain literals.rdfs:comment : If two instances of the class skosxl:Label have the same literal form, they are not necessarily the same resource.</para>
    ///   <para>skos:definition : The property skosxl:literalForm is used to give the literal form of an skosxl:Label.</para>
    ///   <para>rdfs:label : literal form</para>
    ///   <a href="http://www.w3.org/2008/05/skos-xl#literalForm">skosxl:literalForm</a>
    /// </summary>
    let literalForm = _prefixId.prefix "literalForm"
    /// <summary>
    ///   <para>rdfs:comment : If C skosxl:prefLabel L and L skosxl:literalForm V, then X skos:prefLabel V.</para>
    ///   <para>skos:definition : The property skosxl:prefLabel is used to associate an skosxl:Label with a skos:Concept. The property is analogous to skos:prefLabel.</para>
    ///   <para>rdfs:label : preferred label</para>
    ///   <a href="http://www.w3.org/2008/05/skos-xl#prefLabel">skosxl:prefLabel</a>
    /// </summary>
    let prefLabel = _prefixId.prefix "prefLabel"
