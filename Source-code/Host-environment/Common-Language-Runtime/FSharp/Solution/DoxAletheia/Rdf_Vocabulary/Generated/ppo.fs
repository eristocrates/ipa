namespace http.vocab.deri.ie.ppo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ppo =
    let _namespace_iri = Namespace_Iri ppo |> NamespaceIRI
    /// <summary>
    ///   <para>ppo:AccessSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A space which contains ASK queries that test certain requirements which a requester must have"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Access Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#AccessSpace">http://vocab.deri.ie/ppo#AccessSpace</seealso>
    let AccessSpace = Prefixed_Name(ppo, "AccessSpace") |> PrefixedName
    /// <summary>
    ///   <para>ppo:And</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Logical conjuction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"And"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#And">http://vocab.deri.ie/ppo#And</seealso>
    let And = Prefixed_Name(ppo, "And") |> PrefixedName
    /// <summary>
    ///   <para>ppo:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A condition contains properties that denote restrictions to the data being protected."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#Condition">http://vocab.deri.ie/ppo#Condition</seealso>
    let Condition = Prefixed_Name(ppo, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>ppo:Create</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Create access control privilege for creating new data elements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Create"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#Create">http://vocab.deri.ie/ppo#Create</seealso>
    let Create = Prefixed_Name(ppo, "Create") |> PrefixedName

    /// <summary>
    ///   <para>ppo:DERI%2C%20NUI%20Galway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#DERI%2C%20NUI%20Galway">http://vocab.deri.ie/ppo#DERI%2C%20NUI%20Galway</seealso>
    let ``DERI%2C%20NUI%20Galway`` =
        Prefixed_Name(ppo, "DERI%2C%20NUI%20Galway") |> PrefixedName

    /// <summary>
    ///   <para>ppo:Delete</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Delete access control privilege for deleting data elements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Delete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#Delete">http://vocab.deri.ie/ppo#Delete</seealso>
    let Delete = Prefixed_Name(ppo, "Delete") |> PrefixedName
    /// <summary>
    ///   <para>ppo:Not</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Logical Negation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#Not">http://vocab.deri.ie/ppo#Not</seealso>
    let Not = Prefixed_Name(ppo, "Not") |> PrefixedName
    /// <summary>
    ///   <para>ppo:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The parent logical operator class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#Operator">http://vocab.deri.ie/ppo#Operator</seealso>
    let Operator = Prefixed_Name(ppo, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>ppo:Or</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Logical disjunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Or"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#Or">http://vocab.deri.ie/ppo#Or</seealso>
    let Or = Prefixed_Name(ppo, "Or") |> PrefixedName
    /// <summary>
    ///   <para>ppo:PrivacyPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A privacy preference contains statements about restricting RDF data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Privacy Preference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#PrivacyPreference">http://vocab.deri.ie/ppo#PrivacyPreference</seealso>
    let PrivacyPreference = Prefixed_Name(ppo, "PrivacyPreference") |> PrefixedName
    /// <summary>
    ///   <para>ppo:Update</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Update access control privilege for updating data elements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Update"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#Update">http://vocab.deri.ie/ppo#Update</seealso>
    let Update = Prefixed_Name(ppo, "Update") |> PrefixedName
    /// <summary>
    ///   <para>ppo:alepas</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#alepas">http://vocab.deri.ie/ppo#alepas</seealso>
    let alepas = Prefixed_Name(ppo, "alepas") |> PrefixedName
    /// <summary>
    ///   <para>ppo:appliesToContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A privacy preference that applies to a context in a quad (as specified by N-Quads http://sw.deri.org/2008/07/n-quads/) "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"applies to context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#appliesToContext">http://vocab.deri.ie/ppo#appliesToContext</seealso>
    let appliesToContext = Prefixed_Name(ppo, "appliesToContext") |> PrefixedName
    /// <summary>
    ///   <para>ppo:appliesToDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>" A privacy preference that applies to a void:Dataset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"applies to dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#appliesToDataset">http://vocab.deri.ie/ppo#appliesToDataset</seealso>
    let appliesToDataset = Prefixed_Name(ppo, "appliesToDataset") |> PrefixedName
    /// <summary>
    ///   <para>ppo:appliesToNamedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A privacy preference that applies to a trix:Graph. When a privacy preference has this property it means that the privacy conditions apply to a named graph."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"applies to named graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#appliesToNamedGraph">http://vocab.deri.ie/ppo#appliesToNamedGraph</seealso>
    let appliesToNamedGraph = Prefixed_Name(ppo, "appliesToNamedGraph") |> PrefixedName
    /// <summary>
    ///   <para>ppo:appliesToResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A privacy preference that applies to an rdfs:Resource. When a privacy preference has this property it means that the privacy conditions apply to a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"applies to resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#appliesToResource">http://vocab.deri.ie/ppo#appliesToResource</seealso>
    let appliesToResource = Prefixed_Name(ppo, "appliesToResource") |> PrefixedName
    /// <summary>
    ///   <para>ppo:appliesToStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A privacy preference that applies to an rdf:Statement. When a privacy preference has this property it means that the privacy conditions apply to a statement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"applies to statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#appliesToStatement">http://vocab.deri.ie/ppo#appliesToStatement</seealso>
    let appliesToStatement = Prefixed_Name(ppo, "appliesToStatement") |> PrefixedName
    /// <summary>
    ///   <para>ppo:classAsObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A condition that applies to an instance of a class when it is as an object of a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class as object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#classAsObject">http://vocab.deri.ie/ppo#classAsObject</seealso>
    let classAsObject = Prefixed_Name(ppo, "classAsObject") |> PrefixedName
    /// <summary>
    ///   <para>ppo:classAsSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A condition that applies to an instance of a class when it is as a subject of a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class as subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#classAsSubject">http://vocab.deri.ie/ppo#classAsSubject</seealso>
    let classAsSubject = Prefixed_Name(ppo, "classAsSubject") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The access control privilege which is granted to the user. The access control is described using the Web Access Control vocabulary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasAccess">http://vocab.deri.ie/ppo#hasAccess</seealso>
    let hasAccess = Prefixed_Name(ppo, "hasAccess") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasAccessAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An agent who is granted or denied the access control privilege(s)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has access agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasAccessAgent">http://vocab.deri.ie/ppo#hasAccessAgent</seealso>
    let hasAccessAgent = Prefixed_Name(ppo, "hasAccessAgent") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasAccessQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An ASK query that denotes a pattern which requesters must satisfy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"access query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasAccessQuery">http://vocab.deri.ie/ppo#hasAccessQuery</seealso>
    let hasAccessQuery = Prefixed_Name(ppo, "hasAccessQuery") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasAccessSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An access space which a privacy preference has"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has access space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasAccessSpace">http://vocab.deri.ie/ppo#hasAccessSpace</seealso>
    let hasAccessSpace = Prefixed_Name(ppo, "hasAccessSpace") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasChildCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Nested Conditions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has child condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasChildCondition">http://vocab.deri.ie/ppo#hasChildCondition</seealso>
    let hasChildCondition = Prefixed_Name(ppo, "hasChildCondition") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The conditions which a privacy preference has"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasCondition">http://vocab.deri.ie/ppo#hasCondition</seealso>
    let hasCondition = Prefixed_Name(ppo, "hasCondition") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A condition that applies to an rdfs:Literal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has literal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasLiteral">http://vocab.deri.ie/ppo#hasLiteral</seealso>
    let hasLiteral = Prefixed_Name(ppo, "hasLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasLogicalOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The logical operator which a Condition has"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has logical operator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasLogicalOperator">http://vocab.deri.ie/ppo#hasLogicalOperator</seealso>
    let hasLogicalOperator = Prefixed_Name(ppo, "hasLogicalOperator") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasNoAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The access control privilege which is not granted to the user. The access control is described using the Web Access Control vocabulary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has no access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasNoAccess">http://vocab.deri.ie/ppo#hasNoAccess</seealso>
    let hasNoAccess = Prefixed_Name(ppo, "hasNoAccess") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A weighted value that specifies the priority (rank) of a privacy preference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasPriority">http://vocab.deri.ie/ppo#hasPriority</seealso>
    let hasPriority = Prefixed_Name(ppo, "hasPriority") |> PrefixedName
    /// <summary>
    ///   <para>ppo:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A condition that applies to an rdf:Property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#hasProperty">http://vocab.deri.ie/ppo#hasProperty</seealso>
    let hasProperty = Prefixed_Name(ppo, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>ppo:owesac</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#owesac">http://vocab.deri.ie/ppo#owesac</seealso>
    let owesac = Prefixed_Name(ppo, "owesac") |> PrefixedName
    /// <summary>
    ///   <para>ppo:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#rdf">http://vocab.deri.ie/ppo#rdf</seealso>
    let rdf = Prefixed_Name(ppo, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>ppo:resourceAsObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A condition that applies to a URI when it is an object of an rdfs:Resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource as object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#resourceAsObject">http://vocab.deri.ie/ppo#resourceAsObject</seealso>
    let resourceAsObject = Prefixed_Name(ppo, "resourceAsObject") |> PrefixedName
    /// <summary>
    ///   <para>ppo:resourceAsSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A condition that applies to a URI when it is a subject of an rdfs:Resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource as subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#resourceAsSubject">http://vocab.deri.ie/ppo#resourceAsSubject</seealso>
    let resourceAsSubject = Prefixed_Name(ppo, "resourceAsSubject") |> PrefixedName
    /// <summary>
    ///   <para>ppo:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/ppo#ttl">http://vocab.deri.ie/ppo#ttl</seealso>
    let ttl = Prefixed_Name(ppo, "ttl") |> PrefixedName
