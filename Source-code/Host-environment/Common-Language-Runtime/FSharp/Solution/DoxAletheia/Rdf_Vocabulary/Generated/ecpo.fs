namespace http.purl.org.ontology.ecpo.hash

open DoxAletheia.Rdf_Vocabulary

module ecpo =
    let _namespace_name = "http://purl.org/ontology/ecpo#"
    /// <summary>
    /// Super-property to all properties of the beginning group
    /// <see href="http://purl.org/ontology/ecpo#hasBegin"></see></summary>
    let hasBegin = Namespaced_IRI.parse _namespace_name "hasBegin" |> NamespacedName
    /// <summary>
    /// A Chronology is the description of enumeration and chronology of a periodical.
    /// <see href="http://purl.org/ontology/ecpo#Chronology"></see></summary>
    let Chronology = Namespaced_IRI.parse _namespace_name "Chronology" |> NamespacedName
    /// <summary>
    /// Super-property to all properties of the ending group
    /// <see href="http://purl.org/ontology/ecpo#hasEnd"></see></summary>
    let hasEnd = Namespaced_IRI.parse _namespace_name "hasEnd" |> NamespacedName
    /// <summary>
    /// A closed Chronology.
    /// <see href="http://purl.org/ontology/ecpo#Closed"></see></summary>
    let Closed = Namespaced_IRI.parse _namespace_name "Closed" |> NamespacedName
    /// <summary>
    /// A current Chronology.
    /// <see href="http://purl.org/ontology/ecpo#Current"></see></summary>
    let Current = Namespaced_IRI.parse _namespace_name "Current" |> NamespacedName

    /// <summary>
    /// Super-property to all properties of a itemized Chronology
    /// <see href="http://purl.org/ontology/ecpo#hasItemized"></see></summary>
    let hasItemized =
        Namespaced_IRI.parse _namespace_name "hasItemized" |> NamespacedName

    /// <summary>
    /// A Chronology having an ending group.
    /// <see href="http://purl.org/ontology/ecpo#ClosedChronology"></see></summary>
    let ClosedChronology =
        Namespaced_IRI.parse _namespace_name "ClosedChronology" |> NamespacedName

    /// <summary>
    /// A Chronology without an ending group.
    /// <see href="http://purl.org/ontology/ecpo#CurrentChronology"></see></summary>
    let CurrentChronology =
        Namespaced_IRI.parse _namespace_name "CurrentChronology" |> NamespacedName

    /// <summary>
    /// The caption of the beginning issue
    /// <see href="http://purl.org/ontology/ecpo#hasBeginIssueCaption"></see></summary>
    let hasBeginIssueCaption =
        Namespaced_IRI.parse _namespace_name "hasBeginIssueCaption" |> NamespacedName

    /// <summary>
    /// A textual descrimination of the beginning issue
    /// <see href="http://purl.org/ontology/ecpo#hasBeginIssueExtension"></see></summary>
    let hasBeginIssueExtension =
        Namespaced_IRI.parse _namespace_name "hasBeginIssueExtension" |> NamespacedName

    /// <summary>
    /// The numbering of the beginning issue
    /// <see href="http://purl.org/ontology/ecpo#hasBeginIssueNumbering"></see></summary>
    let hasBeginIssueNumbering =
        Namespaced_IRI.parse _namespace_name "hasBeginIssueNumbering" |> NamespacedName

    /// <summary>
    /// A temporal information for the beginning group, like a year, a season, a month or a day
    /// <see href="http://purl.org/ontology/ecpo#hasBeginTemporal"></see></summary>
    let hasBeginTemporal =
        Namespaced_IRI.parse _namespace_name "hasBeginTemporal" |> NamespacedName

    /// <summary>
    /// Refines the value of the property hasBeginTemporal
    /// <see href="http://purl.org/ontology/ecpo#hasBeginTemporalExtension"></see></summary>
    let hasBeginTemporalExtension =
        Namespaced_IRI.parse _namespace_name "hasBeginTemporalExtension" |> NamespacedName

    /// <summary>
    /// The caption of the beginning volume
    /// <see href="http://purl.org/ontology/ecpo#hasBeginVolumeCaption"></see></summary>
    let hasBeginVolumeCaption =
        Namespaced_IRI.parse _namespace_name "hasBeginVolumeCaption" |> NamespacedName

    /// <summary>
    /// A textual descrimination of the beginning volume
    /// <see href="http://purl.org/ontology/ecpo#hasBeginVolumeExtension"></see></summary>
    let hasBeginVolumeExtension =
        Namespaced_IRI.parse _namespace_name "hasBeginVolumeExtension" |> NamespacedName

    /// <summary>
    /// The numbering of the beginning volume
    /// <see href="http://purl.org/ontology/ecpo#hasBeginVolumeNumbering"></see></summary>
    let hasBeginVolumeNumbering =
        Namespaced_IRI.parse _namespace_name "hasBeginVolumeNumbering" |> NamespacedName

    /// <summary>
    /// Relation between an item and a Chronology
    /// <see href="http://purl.org/ontology/ecpo#hasChronology"></see></summary>
    let hasChronology =
        Namespaced_IRI.parse _namespace_name "hasChronology" |> NamespacedName

    /// <summary>
    /// Relation between an item and a Chronology, indicating the Chronology is a gap
    /// <see href="http://purl.org/ontology/ecpo#hasChronologyGap"></see></summary>
    let hasChronologyGap =
        Namespaced_IRI.parse _namespace_name "hasChronologyGap" |> NamespacedName

    /// <summary>
    /// The caption of the ending issue
    /// <see href="http://purl.org/ontology/ecpo#hasEndIssueCaption"></see></summary>
    let hasEndIssueCaption =
        Namespaced_IRI.parse _namespace_name "hasEndIssueCaption" |> NamespacedName

    /// <summary>
    /// A textual descrimination of the ending issue
    /// <see href="http://purl.org/ontology/ecpo#hasEndIssueExtension"></see></summary>
    let hasEndIssueExtension =
        Namespaced_IRI.parse _namespace_name "hasEndIssueExtension" |> NamespacedName

    /// <summary>
    /// The numbering of the ending issue
    /// <see href="http://purl.org/ontology/ecpo#hasEndIssueNumbering"></see></summary>
    let hasEndIssueNumbering =
        Namespaced_IRI.parse _namespace_name "hasEndIssueNumbering" |> NamespacedName

    /// <summary>
    /// A temporal information for the ending group, like a year, a season, a month or a day
    /// <see href="http://purl.org/ontology/ecpo#hasEndTemporal"></see></summary>
    let hasEndTemporal =
        Namespaced_IRI.parse _namespace_name "hasEndTemporal" |> NamespacedName

    /// <summary>
    /// Refines the value of the property hasEndTemporal
    /// <see href="http://purl.org/ontology/ecpo#hasEndTemporalExtension"></see></summary>
    let hasEndTemporalExtension =
        Namespaced_IRI.parse _namespace_name "hasEndTemporalExtension" |> NamespacedName

    /// <summary>
    /// The caption of the ending volume
    /// <see href="http://purl.org/ontology/ecpo#hasEndVolumeCaption"></see></summary>
    let hasEndVolumeCaption =
        Namespaced_IRI.parse _namespace_name "hasEndVolumeCaption" |> NamespacedName

    /// <summary>
    /// A textual descrimination of the endning volume
    /// <see href="http://purl.org/ontology/ecpo#hasEndVolumeExtension"></see></summary>
    let hasEndVolumeExtension =
        Namespaced_IRI.parse _namespace_name "hasEndVolumeExtension" |> NamespacedName

    /// <summary>
    /// The numbering of the ending volume
    /// <see href="http://purl.org/ontology/ecpo#hasEndVolumeNumbering"></see></summary>
    let hasEndVolumeNumbering =
        Namespaced_IRI.parse _namespace_name "hasEndVolumeNumbering" |> NamespacedName

    /// <summary>
    /// The caption of the issue
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedIssueCaption"></see></summary>
    let hasItemizedIssueCaption =
        Namespaced_IRI.parse _namespace_name "hasItemizedIssueCaption" |> NamespacedName

    /// <summary>
    /// A textual descrimination of the issue
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedIssueExtension"></see></summary>
    let hasItemizedIssueExtension =
        Namespaced_IRI.parse _namespace_name "hasItemizedIssueExtension" |> NamespacedName

    /// <summary>
    /// The numbering of the issue
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedIssueNumbering"></see></summary>
    let hasItemizedIssueNumbering =
        Namespaced_IRI.parse _namespace_name "hasItemizedIssueNumbering" |> NamespacedName

    /// <summary>
    /// A temporal information, like a year, a season, a month or a day
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedTemporal"></see></summary>
    let hasItemizedTemporal =
        Namespaced_IRI.parse _namespace_name "hasItemizedTemporal" |> NamespacedName

    /// <summary>
    /// Refines the value of the property hasItemizedTemporal
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedTemporalExtension"></see></summary>
    let hasItemizedTemporalExtension =
        Namespaced_IRI.parse _namespace_name "hasItemizedTemporalExtension" |> NamespacedName

    /// <summary>
    /// The caption of the volume
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedVolumeCaption"></see></summary>
    let hasItemizedVolumeCaption =
        Namespaced_IRI.parse _namespace_name "hasItemizedVolumeCaption" |> NamespacedName

    /// <summary>
    /// A textual descrimination of the volume
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedVolumeExtension"></see></summary>
    let hasItemizedVolumeExtension =
        Namespaced_IRI.parse _namespace_name "hasItemizedVolumeExtension" |> NamespacedName

    /// <summary>
    /// The numbering of the volume
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedVolumeNumbering"></see></summary>
    let hasItemizedVolumeNumbering =
        Namespaced_IRI.parse _namespace_name "hasItemizedVolumeNumbering" |> NamespacedName
