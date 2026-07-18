namespace http.purl.org.xapi.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module xapi =
    let _namespace_name = "http://purl.org/xapi/ontology#"

    /// <summary>
    /// The Activity Type is the identifier of the Activity Definition in an xAPI statement and when dereferenced can provide more information (metadata) about the activity type.
    /// <see href="http://purl.org/xapi/ontology#ActivityType"></see></summary>
    let ActivityType =
        Namespaced_IRI.parse _namespace_name "ActivityType" |> NamespacedName

    /// <summary>
    /// The class for xAPI Statements, mainly for use with Statements in vocabulary examples.
    /// <see href="http://purl.org/xapi/ontology#Statement"></see></summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    /// The Class for a Verb in a controlled vocabulary.
    /// <see href="http://purl.org/xapi/ontology#Verb"></see></summary>
    let Verb = Namespaced_IRI.parse _namespace_name "Verb" |> NamespacedName

    /// <summary>
    /// A property used to connect the xAPI term to a specific sense, or meaning, in natural language that is very closely related. The sense will be identified with Wordnet, a carefully constructed ontology that aids in word sense disambiguation, which has been used with many different languages.
    /// <see href="http://purl.org/xapi/ontology#closelyRelatedNaturalLanguageTerm"></see></summary>
    let closelyRelatedNaturalLanguageTerm =
        Namespaced_IRI.parse _namespace_name "closelyRelatedNaturalLanguageTerm" |> NamespacedName

    /// <summary>
    /// A property used to connects an xapi:Verb or other xAPI term not directly maintained by the vocabulary author to the skos:ConceptScheme that is the xAPI vocabulary referencing the term.
    /// <see href="http://purl.org/xapi/ontology#referenced"></see></summary>
    let referenced = Namespaced_IRI.parse _namespace_name "referenced" |> NamespacedName

    /// <summary>
    /// A property used by people who did not create the original verb, but would like to offer an alternative label for it.
    /// <see href="http://purl.org/xapi/ontology#thirdPartyLabel"></see></summary>
    let thirdPartyLabel =
        Namespaced_IRI.parse _namespace_name "thirdPartyLabel" |> NamespacedName
