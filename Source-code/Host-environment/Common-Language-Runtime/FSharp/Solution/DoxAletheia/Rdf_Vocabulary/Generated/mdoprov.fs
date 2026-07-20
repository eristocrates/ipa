namespace https.w3id.org.mdo.provenance.slash

open DoxAletheia

module mdoprov =
    let _namespace_name = "https://w3id.org/mdo/provenance/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// SoftwareName represents that a software agent has the name in a string.
    /// <see href="https://w3id.org/mdo/provenance/SoftwareName"></see></summary>
    let SoftwareName = _prefix "SoftwareName"
    /// <summary>
    /// A reference agent is the representation of the reference that the structure or property refer to.
    /// <see href="https://w3id.org/mdo/provenance/ReferenceAgent"></see></summary>
    let ReferenceAgent = _prefix "ReferenceAgent"
    /// <summary>
    ///   <see href="https://w3id.org/mdo/provenance/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
    /// <summary>
    /// AuthorName represents that a reference agent has the author's name in a string.
    /// <see href="https://w3id.org/mdo/provenance/AuthorName"></see></summary>
    let AuthorName = _prefix "AuthorName"
    /// <summary>
    /// DOI represents that a reference agent has the DOI in a string.
    /// <see href="https://w3id.org/mdo/provenance/DOI"></see></summary>
    let DOI = _prefix "DOI"
    /// <summary>
    /// DatabaseName represents that a reference agent has the database's name in a string.
    /// <see href="https://w3id.org/mdo/provenance/DatabaseName"></see></summary>
    let DatabaseName = _prefix "DatabaseName"
    /// <summary>
    /// PublicationDateTime represents that a reference agent has the date time in a dateTime.
    /// <see href="https://w3id.org/mdo/provenance/PublicationDateTime"></see></summary>
    let PublicationDateTime = _prefix "PublicationDateTime"
    /// <summary>
    /// PublicationTitle represents that a reference agent has the publication's title in a string.
    /// <see href="https://w3id.org/mdo/provenance/PublicationTitle"></see></summary>
    let PublicationTitle = _prefix "PublicationTitle"
    /// <summary>
    /// URL represents that a reference agent has the URL in a string.
    /// <see href="https://w3id.org/mdo/provenance/URL"></see></summary>
    let URL = _prefix "URL"
