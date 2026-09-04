#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ppo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/ppo#" "ppo"
    /// <summary>
    ///   <para>rdfs:label : Access Space^^xsd:string</para>
    ///   <para>rdfs:comment : A space which contains ASK queries that test certain requirements which a requester must have^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#AccessSpace">ppo:AccessSpace</a>
    /// </summary>
    let AccessSpace = _prefixId.prefix "AccessSpace"
    /// <summary>
    ///   <para>rdfs:label : And^^xsd:string</para>
    ///   <para>rdfs:comment : Logical conjuction^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#And">ppo:And</a>
    /// </summary>
    let And = _prefixId.prefix "And"
    /// <summary>
    ///   <para>rdfs:label : Condition^^xsd:string</para>
    ///   <para>rdfs:comment : A condition contains properties that denote restrictions to the data being protected.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#Condition">ppo:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:label : Create^^xsd:string</para>
    ///   <para>rdfs:comment : The Create access control privilege for creating new data elements^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#Create">ppo:Create</a>
    /// </summary>
    let Create = _prefixId.prefix "Create"
    let ``DERI%2C%20NUI%20Galway`` = _prefixId.prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    ///   <para>rdfs:label : Delete^^xsd:string</para>
    ///   <para>rdfs:comment : The Delete access control privilege for deleting data elements^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#Delete">ppo:Delete</a>
    /// </summary>
    let Delete = _prefixId.prefix "Delete"
    /// <summary>
    ///   <para>rdfs:label : Not^^xsd:string</para>
    ///   <para>rdfs:comment : Logical Negation^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#Not">ppo:Not</a>
    /// </summary>
    let Not = _prefixId.prefix "Not"
    /// <summary>
    ///   <para>rdfs:label : Operator^^xsd:string</para>
    ///   <para>rdfs:comment : The parent logical operator class^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#Operator">ppo:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>rdfs:label : Or^^xsd:string</para>
    ///   <para>rdfs:comment : Logical disjunction^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#Or">ppo:Or</a>
    /// </summary>
    let Or = _prefixId.prefix "Or"
    /// <summary>
    ///   <para>rdfs:label : Privacy Preference^^xsd:string</para>
    ///   <para>rdfs:comment : A privacy preference contains statements about restricting RDF data^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#PrivacyPreference">ppo:PrivacyPreference</a>
    /// </summary>
    let PrivacyPreference = _prefixId.prefix "PrivacyPreference"
    /// <summary>
    ///   <para>rdfs:label : Update^^xsd:string</para>
    ///   <para>rdfs:comment : The Update access control privilege for updating data elements^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#Update">ppo:Update</a>
    /// </summary>
    let Update = _prefixId.prefix "Update"
    let alepas = _prefixId.prefix "alepas"
    /// <summary>
    ///   <para>rdfs:label : applies to context^^xsd:string</para>
    ///   <para>rdfs:comment : A privacy preference that applies to a context in a quad (as specified by N-Quads http://sw.deri.org/2008/07/n-quads/) ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#appliesToContext">ppo:appliesToContext</a>
    /// </summary>
    let appliesToContext = _prefixId.prefix "appliesToContext"
    /// <summary>
    ///   <para>rdfs:label : applies to dataset^^xsd:string</para>
    ///   <para>rdfs:comment :  A privacy preference that applies to a void:Dataset.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#appliesToDataset">ppo:appliesToDataset</a>
    /// </summary>
    let appliesToDataset = _prefixId.prefix "appliesToDataset"
    /// <summary>
    ///   <para>rdfs:label : applies to named graph^^xsd:string</para>
    ///   <para>rdfs:comment : A privacy preference that applies to a trix:Graph. When a privacy preference has this property it means that the privacy conditions apply to a named graph.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#appliesToNamedGraph">ppo:appliesToNamedGraph</a>
    /// </summary>
    let appliesToNamedGraph = _prefixId.prefix "appliesToNamedGraph"
    /// <summary>
    ///   <para>rdfs:label : applies to resource^^xsd:string</para>
    ///   <para>rdfs:comment : A privacy preference that applies to an rdfs:Resource. When a privacy preference has this property it means that the privacy conditions apply to a resource.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#appliesToResource">ppo:appliesToResource</a>
    /// </summary>
    let appliesToResource = _prefixId.prefix "appliesToResource"
    /// <summary>
    ///   <para>rdfs:label : applies to statement^^xsd:string</para>
    ///   <para>rdfs:comment : A privacy preference that applies to an rdf:Statement. When a privacy preference has this property it means that the privacy conditions apply to a statement.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#appliesToStatement">ppo:appliesToStatement</a>
    /// </summary>
    let appliesToStatement = _prefixId.prefix "appliesToStatement"
    /// <summary>
    ///   <para>rdfs:label : class as object^^xsd:string</para>
    ///   <para>rdfs:comment : A condition that applies to an instance of a class when it is as an object of a resource.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#classAsObject">ppo:classAsObject</a>
    /// </summary>
    let classAsObject = _prefixId.prefix "classAsObject"
    /// <summary>
    ///   <para>rdfs:label : class as subject^^xsd:string</para>
    ///   <para>rdfs:comment : A condition that applies to an instance of a class when it is as a subject of a resource.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#classAsSubject">ppo:classAsSubject</a>
    /// </summary>
    let classAsSubject = _prefixId.prefix "classAsSubject"
    /// <summary>
    ///   <para>rdfs:label : has access^^xsd:string</para>
    ///   <para>rdfs:comment : The access control privilege which is granted to the user. The access control is described using the Web Access Control vocabulary.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasAccess">ppo:hasAccess</a>
    /// </summary>
    let hasAccess = _prefixId.prefix "hasAccess"
    /// <summary>
    ///   <para>rdfs:label : has access agent^^xsd:string</para>
    ///   <para>rdfs:comment : An agent who is granted or denied the access control privilege(s)^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasAccessAgent">ppo:hasAccessAgent</a>
    /// </summary>
    let hasAccessAgent = _prefixId.prefix "hasAccessAgent"
    /// <summary>
    ///   <para>rdfs:label : access query^^xsd:string</para>
    ///   <para>rdfs:comment : An ASK query that denotes a pattern which requesters must satisfy^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasAccessQuery">ppo:hasAccessQuery</a>
    /// </summary>
    let hasAccessQuery = _prefixId.prefix "hasAccessQuery"
    /// <summary>
    ///   <para>rdfs:label : has access space^^xsd:string</para>
    ///   <para>rdfs:comment : An access space which a privacy preference has^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasAccessSpace">ppo:hasAccessSpace</a>
    /// </summary>
    let hasAccessSpace = _prefixId.prefix "hasAccessSpace"
    /// <summary>
    ///   <para>rdfs:label : has child condition^^xsd:string</para>
    ///   <para>rdfs:comment : Nested Conditions^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasChildCondition">ppo:hasChildCondition</a>
    /// </summary>
    let hasChildCondition = _prefixId.prefix "hasChildCondition"
    /// <summary>
    ///   <para>rdfs:label : has condition^^xsd:string</para>
    ///   <para>rdfs:comment : The conditions which a privacy preference has^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasCondition">ppo:hasCondition</a>
    /// </summary>
    let hasCondition = _prefixId.prefix "hasCondition"
    /// <summary>
    ///   <para>rdfs:label : has literal^^xsd:string</para>
    ///   <para>rdfs:comment : A condition that applies to an rdfs:Literal.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasLiteral">ppo:hasLiteral</a>
    /// </summary>
    let hasLiteral = _prefixId.prefix "hasLiteral"
    /// <summary>
    ///   <para>rdfs:label : has logical operator^^xsd:string</para>
    ///   <para>rdfs:comment : The logical operator which a Condition has^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasLogicalOperator">ppo:hasLogicalOperator</a>
    /// </summary>
    let hasLogicalOperator = _prefixId.prefix "hasLogicalOperator"
    /// <summary>
    ///   <para>rdfs:label : has no access^^xsd:string</para>
    ///   <para>rdfs:comment : The access control privilege which is not granted to the user. The access control is described using the Web Access Control vocabulary.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasNoAccess">ppo:hasNoAccess</a>
    /// </summary>
    let hasNoAccess = _prefixId.prefix "hasNoAccess"
    /// <summary>
    ///   <para>rdfs:label : has priority^^xsd:string</para>
    ///   <para>rdfs:comment : A weighted value that specifies the priority (rank) of a privacy preference^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasPriority">ppo:hasPriority</a>
    /// </summary>
    let hasPriority = _prefixId.prefix "hasPriority"
    /// <summary>
    ///   <para>rdfs:label : has property^^xsd:string</para>
    ///   <para>rdfs:comment : A condition that applies to an rdf:Property.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#hasProperty">ppo:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    let owesac = _prefixId.prefix "owesac"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : resource as object^^xsd:string</para>
    ///   <para>rdfs:comment : A condition that applies to a URI when it is an object of an rdfs:Resource.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#resourceAsObject">ppo:resourceAsObject</a>
    /// </summary>
    let resourceAsObject = _prefixId.prefix "resourceAsObject"
    /// <summary>
    ///   <para>rdfs:label : resource as subject^^xsd:string</para>
    ///   <para>rdfs:comment : A condition that applies to a URI when it is a subject of an rdfs:Resource.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/ppo#resourceAsSubject">ppo:resourceAsSubject</a>
    /// </summary>
    let resourceAsSubject = _prefixId.prefix "resourceAsSubject"
    let ttl = _prefixId.prefix "ttl"
