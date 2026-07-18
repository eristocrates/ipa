namespace https.w3id.org.mdo.provenance.slash

open DoxAletheia.Rdf_Vocabulary

module mdoprov =
    let _namespace_name = "https://w3id.org/mdo/provenance/"

    /// <summary>
    /// SoftwareName represents that a software agent has the name in a string.
    /// <see href="https://w3id.org/mdo/provenance/SoftwareName"></see></summary>
    let SoftwareName =
        Namespaced_IRI.parse _namespace_name "SoftwareName" |> NamespacedName

    /// <summary>
    /// A reference agent is the representation of the reference that the structure or property refer to.
    /// <see href="https://w3id.org/mdo/provenance/ReferenceAgent"></see></summary>
    let ReferenceAgent =
        Namespaced_IRI.parse _namespace_name "ReferenceAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mdo/provenance/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = Namespaced_IRI.parse _namespace_name "1.0/" |> NamespacedName
    /// <summary>
    /// AuthorName represents that a reference agent has the author's name in a string.
    /// <see href="https://w3id.org/mdo/provenance/AuthorName"></see></summary>
    let AuthorName = Namespaced_IRI.parse _namespace_name "AuthorName" |> NamespacedName
    /// <summary>
    /// DOI represents that a reference agent has the DOI in a string.
    /// <see href="https://w3id.org/mdo/provenance/DOI"></see></summary>
    let DOI = Namespaced_IRI.parse _namespace_name "DOI" |> NamespacedName

    /// <summary>
    /// DatabaseName represents that a reference agent has the database's name in a string.
    /// <see href="https://w3id.org/mdo/provenance/DatabaseName"></see></summary>
    let DatabaseName =
        Namespaced_IRI.parse _namespace_name "DatabaseName" |> NamespacedName

    /// <summary>
    /// PublicationDateTime represents that a reference agent has the date time in a dateTime.
    /// <see href="https://w3id.org/mdo/provenance/PublicationDateTime"></see></summary>
    let PublicationDateTime =
        Namespaced_IRI.parse _namespace_name "PublicationDateTime" |> NamespacedName

    /// <summary>
    /// PublicationTitle represents that a reference agent has the publication's title in a string.
    /// <see href="https://w3id.org/mdo/provenance/PublicationTitle"></see></summary>
    let PublicationTitle =
        Namespaced_IRI.parse _namespace_name "PublicationTitle" |> NamespacedName

    /// <summary>
    /// URL represents that a reference agent has the URL in a string.
    /// <see href="https://w3id.org/mdo/provenance/URL"></see></summary>
    let URL = Namespaced_IRI.parse _namespace_name "URL" |> NamespacedName
