namespace http.purl.org.ontology.ecpo.hash

open DoxAletheia

module ecpo =
    let _namespace_name = "http://purl.org/ontology/ecpo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Super-property to all properties of the beginning group
    /// <see href="http://purl.org/ontology/ecpo#hasBegin"></see></summary>
    let hasBegin = _prefix "hasBegin"
    /// <summary>
    /// A Chronology is the description of enumeration and chronology of a periodical.
    /// <see href="http://purl.org/ontology/ecpo#Chronology"></see></summary>
    let Chronology = _prefix "Chronology"
    /// <summary>
    /// Super-property to all properties of the ending group
    /// <see href="http://purl.org/ontology/ecpo#hasEnd"></see></summary>
    let hasEnd = _prefix "hasEnd"
    /// <summary>
    /// A closed Chronology.
    /// <see href="http://purl.org/ontology/ecpo#Closed"></see></summary>
    let Closed = _prefix "Closed"
    /// <summary>
    /// A current Chronology.
    /// <see href="http://purl.org/ontology/ecpo#Current"></see></summary>
    let Current = _prefix "Current"
    /// <summary>
    /// Super-property to all properties of a itemized Chronology
    /// <see href="http://purl.org/ontology/ecpo#hasItemized"></see></summary>
    let hasItemized = _prefix "hasItemized"
    /// <summary>
    /// A Chronology having an ending group.
    /// <see href="http://purl.org/ontology/ecpo#ClosedChronology"></see></summary>
    let ClosedChronology = _prefix "ClosedChronology"
    /// <summary>
    /// A Chronology without an ending group.
    /// <see href="http://purl.org/ontology/ecpo#CurrentChronology"></see></summary>
    let CurrentChronology = _prefix "CurrentChronology"
    /// <summary>
    /// The caption of the beginning issue
    /// <see href="http://purl.org/ontology/ecpo#hasBeginIssueCaption"></see></summary>
    let hasBeginIssueCaption = _prefix "hasBeginIssueCaption"
    /// <summary>
    /// A textual descrimination of the beginning issue
    /// <see href="http://purl.org/ontology/ecpo#hasBeginIssueExtension"></see></summary>
    let hasBeginIssueExtension = _prefix "hasBeginIssueExtension"
    /// <summary>
    /// The numbering of the beginning issue
    /// <see href="http://purl.org/ontology/ecpo#hasBeginIssueNumbering"></see></summary>
    let hasBeginIssueNumbering = _prefix "hasBeginIssueNumbering"
    /// <summary>
    /// A temporal information for the beginning group, like a year, a season, a month or a day
    /// <see href="http://purl.org/ontology/ecpo#hasBeginTemporal"></see></summary>
    let hasBeginTemporal = _prefix "hasBeginTemporal"
    /// <summary>
    /// Refines the value of the property hasBeginTemporal
    /// <see href="http://purl.org/ontology/ecpo#hasBeginTemporalExtension"></see></summary>
    let hasBeginTemporalExtension = _prefix "hasBeginTemporalExtension"
    /// <summary>
    /// The caption of the beginning volume
    /// <see href="http://purl.org/ontology/ecpo#hasBeginVolumeCaption"></see></summary>
    let hasBeginVolumeCaption = _prefix "hasBeginVolumeCaption"
    /// <summary>
    /// A textual descrimination of the beginning volume
    /// <see href="http://purl.org/ontology/ecpo#hasBeginVolumeExtension"></see></summary>
    let hasBeginVolumeExtension = _prefix "hasBeginVolumeExtension"
    /// <summary>
    /// The numbering of the beginning volume
    /// <see href="http://purl.org/ontology/ecpo#hasBeginVolumeNumbering"></see></summary>
    let hasBeginVolumeNumbering = _prefix "hasBeginVolumeNumbering"
    /// <summary>
    /// Relation between an item and a Chronology
    /// <see href="http://purl.org/ontology/ecpo#hasChronology"></see></summary>
    let hasChronology = _prefix "hasChronology"
    /// <summary>
    /// Relation between an item and a Chronology, indicating the Chronology is a gap
    /// <see href="http://purl.org/ontology/ecpo#hasChronologyGap"></see></summary>
    let hasChronologyGap = _prefix "hasChronologyGap"
    /// <summary>
    /// The caption of the ending issue
    /// <see href="http://purl.org/ontology/ecpo#hasEndIssueCaption"></see></summary>
    let hasEndIssueCaption = _prefix "hasEndIssueCaption"
    /// <summary>
    /// A textual descrimination of the ending issue
    /// <see href="http://purl.org/ontology/ecpo#hasEndIssueExtension"></see></summary>
    let hasEndIssueExtension = _prefix "hasEndIssueExtension"
    /// <summary>
    /// The numbering of the ending issue
    /// <see href="http://purl.org/ontology/ecpo#hasEndIssueNumbering"></see></summary>
    let hasEndIssueNumbering = _prefix "hasEndIssueNumbering"
    /// <summary>
    /// A temporal information for the ending group, like a year, a season, a month or a day
    /// <see href="http://purl.org/ontology/ecpo#hasEndTemporal"></see></summary>
    let hasEndTemporal = _prefix "hasEndTemporal"
    /// <summary>
    /// Refines the value of the property hasEndTemporal
    /// <see href="http://purl.org/ontology/ecpo#hasEndTemporalExtension"></see></summary>
    let hasEndTemporalExtension = _prefix "hasEndTemporalExtension"
    /// <summary>
    /// The caption of the ending volume
    /// <see href="http://purl.org/ontology/ecpo#hasEndVolumeCaption"></see></summary>
    let hasEndVolumeCaption = _prefix "hasEndVolumeCaption"
    /// <summary>
    /// A textual descrimination of the endning volume
    /// <see href="http://purl.org/ontology/ecpo#hasEndVolumeExtension"></see></summary>
    let hasEndVolumeExtension = _prefix "hasEndVolumeExtension"
    /// <summary>
    /// The numbering of the ending volume
    /// <see href="http://purl.org/ontology/ecpo#hasEndVolumeNumbering"></see></summary>
    let hasEndVolumeNumbering = _prefix "hasEndVolumeNumbering"
    /// <summary>
    /// The caption of the issue
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedIssueCaption"></see></summary>
    let hasItemizedIssueCaption = _prefix "hasItemizedIssueCaption"
    /// <summary>
    /// A textual descrimination of the issue
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedIssueExtension"></see></summary>
    let hasItemizedIssueExtension = _prefix "hasItemizedIssueExtension"
    /// <summary>
    /// The numbering of the issue
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedIssueNumbering"></see></summary>
    let hasItemizedIssueNumbering = _prefix "hasItemizedIssueNumbering"
    /// <summary>
    /// A temporal information, like a year, a season, a month or a day
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedTemporal"></see></summary>
    let hasItemizedTemporal = _prefix "hasItemizedTemporal"
    /// <summary>
    /// Refines the value of the property hasItemizedTemporal
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedTemporalExtension"></see></summary>
    let hasItemizedTemporalExtension = _prefix "hasItemizedTemporalExtension"
    /// <summary>
    /// The caption of the volume
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedVolumeCaption"></see></summary>
    let hasItemizedVolumeCaption = _prefix "hasItemizedVolumeCaption"
    /// <summary>
    /// A textual descrimination of the volume
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedVolumeExtension"></see></summary>
    let hasItemizedVolumeExtension = _prefix "hasItemizedVolumeExtension"
    /// <summary>
    /// The numbering of the volume
    /// <see href="http://purl.org/ontology/ecpo#hasItemizedVolumeNumbering"></see></summary>
    let hasItemizedVolumeNumbering = _prefix "hasItemizedVolumeNumbering"
