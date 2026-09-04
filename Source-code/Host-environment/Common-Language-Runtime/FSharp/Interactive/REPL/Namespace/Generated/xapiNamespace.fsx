#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module xapi =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/xapi/ontology#" "xapi"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The Activity Type is the identifier of the Activity Definition in an xAPI statement and when dereferenced can provide more information (metadata) about the activity type.</para>
    ///   <para>rdfs:label : ActivityType</para>
    ///   <a href="http://purl.org/xapi/ontology#ActivityType">xapi:ActivityType</a>
    /// </summary>
    let ActivityType = _prefixId.prefix "ActivityType"
    /// <summary>
    ///   <para>rdfs:comment : The class for xAPI Statements, mainly for use with Statements in vocabulary examples.</para>
    ///   <para>rdfs:label : Statement</para>
    ///   <a href="http://purl.org/xapi/ontology#Statement">xapi:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    /// <summary>
    ///   <para>rdfs:comment : The Class for a Verb in a controlled vocabulary.</para>
    ///   <para>rdfs:label : Verb</para>
    ///   <a href="http://purl.org/xapi/ontology#Verb">xapi:Verb</a>
    /// </summary>
    let Verb = _prefixId.prefix "Verb"

    /// <summary>
    ///   <para>rdfs:comment : A property used to connect the xAPI term to a specific sense, or meaning, in natural language that is very closely related. The sense will be identified with Wordnet, a carefully constructed ontology that aids in word sense disambiguation, which has been used with many different languages.</para>
    ///   <para>rdfs:label : closelyRelatedNaturalLanguageTerm</para>
    ///   <a href="http://purl.org/xapi/ontology#closelyRelatedNaturalLanguageTerm">xapi:closelyRelatedNaturalLanguageTerm</a>
    /// </summary>
    let closelyRelatedNaturalLanguageTerm =
        _prefixId.prefix "closelyRelatedNaturalLanguageTerm"

    /// <summary>
    ///   <para>rdfs:comment : A property used to connects an xapi:Verb or other xAPI term not directly maintained by the vocabulary author to the skos:ConceptScheme that is the xAPI vocabulary referencing the term.</para>
    ///   <para>rdfs:label : referenced</para>
    ///   <a href="http://purl.org/xapi/ontology#referenced">xapi:referenced</a>
    /// </summary>
    let referenced = _prefixId.prefix "referenced"
    /// <summary>
    ///   <para>rdfs:comment : A property used by people who did not create the original verb, but would like to offer an alternative label for it.</para>
    ///   <para>rdfs:label : thirdPartyLabel</para>
    ///   <a href="http://purl.org/xapi/ontology#thirdPartyLabel">xapi:thirdPartyLabel</a>
    /// </summary>
    let thirdPartyLabel = _prefixId.prefix "thirdPartyLabel"
