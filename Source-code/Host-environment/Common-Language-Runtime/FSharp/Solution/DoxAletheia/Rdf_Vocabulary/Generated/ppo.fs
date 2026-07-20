namespace http.vocab.deri.ie.ppo.hash

open DoxAletheia

module ppo =
    let _namespace_name = "http://vocab.deri.ie/ppo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#alepas"></see>
    /// </summary>
    let alepas = _prefix "alepas"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#owesac"></see>
    /// </summary>
    let owesac = _prefix "owesac"
    /// <summary>
    /// A space which contains ASK queries that test certain requirements which a requester must have
    /// <see href="http://vocab.deri.ie/ppo#AccessSpace"></see></summary>
    let AccessSpace = _prefix "AccessSpace"
    /// <summary>
    /// Logical conjuction
    /// <see href="http://vocab.deri.ie/ppo#And"></see></summary>
    let And = _prefix "And"
    /// <summary>
    /// The parent logical operator class
    /// <see href="http://vocab.deri.ie/ppo#Operator"></see></summary>
    let Operator = _prefix "Operator"
    /// <summary>
    /// A condition contains properties that denote restrictions to the data being protected.
    /// <see href="http://vocab.deri.ie/ppo#Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// The Create access control privilege for creating new data elements
    /// <see href="http://vocab.deri.ie/ppo#Create"></see></summary>
    let Create = _prefix "Create"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` = _prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    /// The Delete access control privilege for deleting data elements
    /// <see href="http://vocab.deri.ie/ppo#Delete"></see></summary>
    let Delete = _prefix "Delete"
    /// <summary>
    /// Logical Negation
    /// <see href="http://vocab.deri.ie/ppo#Not"></see></summary>
    let Not = _prefix "Not"
    /// <summary>
    /// Logical disjunction
    /// <see href="http://vocab.deri.ie/ppo#Or"></see></summary>
    let Or = _prefix "Or"
    /// <summary>
    /// A privacy preference contains statements about restricting RDF data
    /// <see href="http://vocab.deri.ie/ppo#PrivacyPreference"></see></summary>
    let PrivacyPreference = _prefix "PrivacyPreference"
    /// <summary>
    /// The Update access control privilege for updating data elements
    /// <see href="http://vocab.deri.ie/ppo#Update"></see></summary>
    let Update = _prefix "Update"
    /// <summary>
    /// A privacy preference that applies to a context in a quad (as specified by N-Quads http://sw.deri.org/2008/07/n-quads/)
    /// <see href="http://vocab.deri.ie/ppo#appliesToContext"></see></summary>
    let appliesToContext = _prefix "appliesToContext"
    /// <summary>
    ///  A privacy preference that applies to a void:Dataset.
    /// <see href="http://vocab.deri.ie/ppo#appliesToDataset"></see></summary>
    let appliesToDataset = _prefix "appliesToDataset"
    /// <summary>
    /// A privacy preference that applies to a trix:Graph. When a privacy preference has this property it means that the privacy conditions apply to a named graph.
    /// <see href="http://vocab.deri.ie/ppo#appliesToNamedGraph"></see></summary>
    let appliesToNamedGraph = _prefix "appliesToNamedGraph"
    /// <summary>
    /// A privacy preference that applies to an rdfs:Resource. When a privacy preference has this property it means that the privacy conditions apply to a resource.
    /// <see href="http://vocab.deri.ie/ppo#appliesToResource"></see></summary>
    let appliesToResource = _prefix "appliesToResource"
    /// <summary>
    /// A privacy preference that applies to an rdf:Statement. When a privacy preference has this property it means that the privacy conditions apply to a statement.
    /// <see href="http://vocab.deri.ie/ppo#appliesToStatement"></see></summary>
    let appliesToStatement = _prefix "appliesToStatement"
    /// <summary>
    /// A condition that applies to an instance of a class when it is as an object of a resource.
    /// <see href="http://vocab.deri.ie/ppo#classAsObject"></see></summary>
    let classAsObject = _prefix "classAsObject"
    /// <summary>
    /// A condition that applies to an instance of a class when it is as a subject of a resource.
    /// <see href="http://vocab.deri.ie/ppo#classAsSubject"></see></summary>
    let classAsSubject = _prefix "classAsSubject"
    /// <summary>
    /// The access control privilege which is granted to the user. The access control is described using the Web Access Control vocabulary.
    /// <see href="http://vocab.deri.ie/ppo#hasAccess"></see></summary>
    let hasAccess = _prefix "hasAccess"
    /// <summary>
    /// An agent who is granted or denied the access control privilege(s)
    /// <see href="http://vocab.deri.ie/ppo#hasAccessAgent"></see></summary>
    let hasAccessAgent = _prefix "hasAccessAgent"
    /// <summary>
    /// An ASK query that denotes a pattern which requesters must satisfy
    /// <see href="http://vocab.deri.ie/ppo#hasAccessQuery"></see></summary>
    let hasAccessQuery = _prefix "hasAccessQuery"
    /// <summary>
    /// An access space which a privacy preference has
    /// <see href="http://vocab.deri.ie/ppo#hasAccessSpace"></see></summary>
    let hasAccessSpace = _prefix "hasAccessSpace"
    /// <summary>
    /// Nested Conditions
    /// <see href="http://vocab.deri.ie/ppo#hasChildCondition"></see></summary>
    let hasChildCondition = _prefix "hasChildCondition"
    /// <summary>
    /// The conditions which a privacy preference has
    /// <see href="http://vocab.deri.ie/ppo#hasCondition"></see></summary>
    let hasCondition = _prefix "hasCondition"
    /// <summary>
    /// A condition that applies to an rdfs:Literal.
    /// <see href="http://vocab.deri.ie/ppo#hasLiteral"></see></summary>
    let hasLiteral = _prefix "hasLiteral"
    /// <summary>
    /// The logical operator which a Condition has
    /// <see href="http://vocab.deri.ie/ppo#hasLogicalOperator"></see></summary>
    let hasLogicalOperator = _prefix "hasLogicalOperator"
    /// <summary>
    /// The access control privilege which is not granted to the user. The access control is described using the Web Access Control vocabulary.
    /// <see href="http://vocab.deri.ie/ppo#hasNoAccess"></see></summary>
    let hasNoAccess = _prefix "hasNoAccess"
    /// <summary>
    /// A weighted value that specifies the priority (rank) of a privacy preference
    /// <see href="http://vocab.deri.ie/ppo#hasPriority"></see></summary>
    let hasPriority = _prefix "hasPriority"
    /// <summary>
    /// A condition that applies to an rdf:Property.
    /// <see href="http://vocab.deri.ie/ppo#hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    /// A condition that applies to a URI when it is an object of an rdfs:Resource.
    /// <see href="http://vocab.deri.ie/ppo#resourceAsObject"></see></summary>
    let resourceAsObject = _prefix "resourceAsObject"
    /// <summary>
    /// A condition that applies to a URI when it is a subject of an rdfs:Resource.
    /// <see href="http://vocab.deri.ie/ppo#resourceAsSubject"></see></summary>
    let resourceAsSubject = _prefix "resourceAsSubject"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
