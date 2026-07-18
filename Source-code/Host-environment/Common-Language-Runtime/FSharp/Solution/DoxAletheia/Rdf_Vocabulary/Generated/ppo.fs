namespace http.vocab.deri.ie.ppo.hash

open DoxAletheia.Rdf_Vocabulary

module ppo =
    let _namespace_name = "http://vocab.deri.ie/ppo#"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#alepas"></see>
    /// </summary>
    let alepas = Namespaced_IRI.parse _namespace_name "alepas" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#owesac"></see>
    /// </summary>
    let owesac = Namespaced_IRI.parse _namespace_name "owesac" |> NamespacedName

    /// <summary>
    /// A space which contains ASK queries that test certain requirements which a requester must have
    /// <see href="http://vocab.deri.ie/ppo#AccessSpace"></see></summary>
    let AccessSpace =
        Namespaced_IRI.parse _namespace_name "AccessSpace" |> NamespacedName

    /// <summary>
    /// Logical conjuction
    /// <see href="http://vocab.deri.ie/ppo#And"></see></summary>
    let And = Namespaced_IRI.parse _namespace_name "And" |> NamespacedName
    /// <summary>
    /// The parent logical operator class
    /// <see href="http://vocab.deri.ie/ppo#Operator"></see></summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName
    /// <summary>
    /// A condition contains properties that denote restrictions to the data being protected.
    /// <see href="http://vocab.deri.ie/ppo#Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    /// The Create access control privilege for creating new data elements
    /// <see href="http://vocab.deri.ie/ppo#Create"></see></summary>
    let Create = Namespaced_IRI.parse _namespace_name "Create" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` =
        Namespaced_IRI.parse _namespace_name "DERI%2C%20NUI%20Galway" |> NamespacedName

    /// <summary>
    /// The Delete access control privilege for deleting data elements
    /// <see href="http://vocab.deri.ie/ppo#Delete"></see></summary>
    let Delete = Namespaced_IRI.parse _namespace_name "Delete" |> NamespacedName
    /// <summary>
    /// Logical Negation
    /// <see href="http://vocab.deri.ie/ppo#Not"></see></summary>
    let Not = Namespaced_IRI.parse _namespace_name "Not" |> NamespacedName
    /// <summary>
    /// Logical disjunction
    /// <see href="http://vocab.deri.ie/ppo#Or"></see></summary>
    let Or = Namespaced_IRI.parse _namespace_name "Or" |> NamespacedName

    /// <summary>
    /// A privacy preference contains statements about restricting RDF data
    /// <see href="http://vocab.deri.ie/ppo#PrivacyPreference"></see></summary>
    let PrivacyPreference =
        Namespaced_IRI.parse _namespace_name "PrivacyPreference" |> NamespacedName

    /// <summary>
    /// The Update access control privilege for updating data elements
    /// <see href="http://vocab.deri.ie/ppo#Update"></see></summary>
    let Update = Namespaced_IRI.parse _namespace_name "Update" |> NamespacedName

    /// <summary>
    /// A privacy preference that applies to a context in a quad (as specified by N-Quads http://sw.deri.org/2008/07/n-quads/)
    /// <see href="http://vocab.deri.ie/ppo#appliesToContext"></see></summary>
    let appliesToContext =
        Namespaced_IRI.parse _namespace_name "appliesToContext" |> NamespacedName

    /// <summary>
    ///  A privacy preference that applies to a void:Dataset.
    /// <see href="http://vocab.deri.ie/ppo#appliesToDataset"></see></summary>
    let appliesToDataset =
        Namespaced_IRI.parse _namespace_name "appliesToDataset" |> NamespacedName

    /// <summary>
    /// A privacy preference that applies to a trix:Graph. When a privacy preference has this property it means that the privacy conditions apply to a named graph.
    /// <see href="http://vocab.deri.ie/ppo#appliesToNamedGraph"></see></summary>
    let appliesToNamedGraph =
        Namespaced_IRI.parse _namespace_name "appliesToNamedGraph" |> NamespacedName

    /// <summary>
    /// A privacy preference that applies to an rdfs:Resource. When a privacy preference has this property it means that the privacy conditions apply to a resource.
    /// <see href="http://vocab.deri.ie/ppo#appliesToResource"></see></summary>
    let appliesToResource =
        Namespaced_IRI.parse _namespace_name "appliesToResource" |> NamespacedName

    /// <summary>
    /// A privacy preference that applies to an rdf:Statement. When a privacy preference has this property it means that the privacy conditions apply to a statement.
    /// <see href="http://vocab.deri.ie/ppo#appliesToStatement"></see></summary>
    let appliesToStatement =
        Namespaced_IRI.parse _namespace_name "appliesToStatement" |> NamespacedName

    /// <summary>
    /// A condition that applies to an instance of a class when it is as an object of a resource.
    /// <see href="http://vocab.deri.ie/ppo#classAsObject"></see></summary>
    let classAsObject =
        Namespaced_IRI.parse _namespace_name "classAsObject" |> NamespacedName

    /// <summary>
    /// A condition that applies to an instance of a class when it is as a subject of a resource.
    /// <see href="http://vocab.deri.ie/ppo#classAsSubject"></see></summary>
    let classAsSubject =
        Namespaced_IRI.parse _namespace_name "classAsSubject" |> NamespacedName

    /// <summary>
    /// The access control privilege which is granted to the user. The access control is described using the Web Access Control vocabulary.
    /// <see href="http://vocab.deri.ie/ppo#hasAccess"></see></summary>
    let hasAccess = Namespaced_IRI.parse _namespace_name "hasAccess" |> NamespacedName

    /// <summary>
    /// An agent who is granted or denied the access control privilege(s)
    /// <see href="http://vocab.deri.ie/ppo#hasAccessAgent"></see></summary>
    let hasAccessAgent =
        Namespaced_IRI.parse _namespace_name "hasAccessAgent" |> NamespacedName

    /// <summary>
    /// An ASK query that denotes a pattern which requesters must satisfy
    /// <see href="http://vocab.deri.ie/ppo#hasAccessQuery"></see></summary>
    let hasAccessQuery =
        Namespaced_IRI.parse _namespace_name "hasAccessQuery" |> NamespacedName

    /// <summary>
    /// An access space which a privacy preference has
    /// <see href="http://vocab.deri.ie/ppo#hasAccessSpace"></see></summary>
    let hasAccessSpace =
        Namespaced_IRI.parse _namespace_name "hasAccessSpace" |> NamespacedName

    /// <summary>
    /// Nested Conditions
    /// <see href="http://vocab.deri.ie/ppo#hasChildCondition"></see></summary>
    let hasChildCondition =
        Namespaced_IRI.parse _namespace_name "hasChildCondition" |> NamespacedName

    /// <summary>
    /// The conditions which a privacy preference has
    /// <see href="http://vocab.deri.ie/ppo#hasCondition"></see></summary>
    let hasCondition =
        Namespaced_IRI.parse _namespace_name "hasCondition" |> NamespacedName

    /// <summary>
    /// A condition that applies to an rdfs:Literal.
    /// <see href="http://vocab.deri.ie/ppo#hasLiteral"></see></summary>
    let hasLiteral = Namespaced_IRI.parse _namespace_name "hasLiteral" |> NamespacedName

    /// <summary>
    /// The logical operator which a Condition has
    /// <see href="http://vocab.deri.ie/ppo#hasLogicalOperator"></see></summary>
    let hasLogicalOperator =
        Namespaced_IRI.parse _namespace_name "hasLogicalOperator" |> NamespacedName

    /// <summary>
    /// The access control privilege which is not granted to the user. The access control is described using the Web Access Control vocabulary.
    /// <see href="http://vocab.deri.ie/ppo#hasNoAccess"></see></summary>
    let hasNoAccess =
        Namespaced_IRI.parse _namespace_name "hasNoAccess" |> NamespacedName

    /// <summary>
    /// A weighted value that specifies the priority (rank) of a privacy preference
    /// <see href="http://vocab.deri.ie/ppo#hasPriority"></see></summary>
    let hasPriority =
        Namespaced_IRI.parse _namespace_name "hasPriority" |> NamespacedName

    /// <summary>
    /// A condition that applies to an rdf:Property.
    /// <see href="http://vocab.deri.ie/ppo#hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName

    /// <summary>
    /// A condition that applies to a URI when it is an object of an rdfs:Resource.
    /// <see href="http://vocab.deri.ie/ppo#resourceAsObject"></see></summary>
    let resourceAsObject =
        Namespaced_IRI.parse _namespace_name "resourceAsObject" |> NamespacedName

    /// <summary>
    /// A condition that applies to a URI when it is a subject of an rdfs:Resource.
    /// <see href="http://vocab.deri.ie/ppo#resourceAsSubject"></see></summary>
    let resourceAsSubject =
        Namespaced_IRI.parse _namespace_name "resourceAsSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/ppo#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
