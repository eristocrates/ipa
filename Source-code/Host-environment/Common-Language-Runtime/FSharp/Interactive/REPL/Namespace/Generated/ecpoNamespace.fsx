#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ecpo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/ecpo#" "ecpo"
    /// <summary>
    ///   <para>rdfs:label : enumeration and chronologyrdfs:label : Bestandsverlauf</para>
    ///   <para>rdfs:comment : A Chronology is the description of enumeration and chronology of a periodical.</para>
    ///   <a href="http://purl.org/ontology/ecpo#Chronology">ecpo:Chronology</a>
    /// </summary>
    let Chronology = _prefixId.prefix "Chronology"
    let Closed = _prefixId.prefix "Closed"
    /// <summary>
    ///   <para>rdfs:label : closed chronologyrdfs:label : Bestandsverlauf abgeschlossen</para>
    ///   <para>rdfs:comment : A Chronology having an ending group.</para>
    ///   <a href="http://purl.org/ontology/ecpo#ClosedChronology">ecpo:ClosedChronology</a>
    /// </summary>
    let ClosedChronology = _prefixId.prefix "ClosedChronology"
    let Current = _prefixId.prefix "Current"
    /// <summary>
    ///   <para>rdfs:label : current chronologyrdfs:label : Bestandsverlauf laufend</para>
    ///   <para>rdfs:comment : A Chronology without an ending group.</para>
    ///   <a href="http://purl.org/ontology/ecpo#CurrentChronology">ecpo:CurrentChronology</a>
    /// </summary>
    let CurrentChronology = _prefixId.prefix "CurrentChronology"
    /// <summary>
    ///   <para>rdfs:label : has begin</para>
    ///   <para>rdfs:comment : Super-property to all properties of the beginning group</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBegin">ecpo:hasBegin</a>
    /// </summary>
    let hasBegin = _prefixId.prefix "hasBegin"
    /// <summary>
    ///   <para>rdfs:label : hat beginnende Ausgabenbeschriftungrdfs:label : has begin issue caption</para>
    ///   <para>rdfs:comment : The caption of the beginning issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginIssueCaption">ecpo:hasBeginIssueCaption</a>
    /// </summary>
    let hasBeginIssueCaption = _prefixId.prefix "hasBeginIssueCaption"
    /// <summary>
    ///   <para>rdfs:label : hat beginnende Ausgabenergänzungrdfs:label : has begin issue extension</para>
    ///   <para>rdfs:comment : A textual descrimination of the beginning issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginIssueExtension">ecpo:hasBeginIssueExtension</a>
    /// </summary>
    let hasBeginIssueExtension = _prefixId.prefix "hasBeginIssueExtension"
    /// <summary>
    ///   <para>rdfs:label : hat beginnende Ausgabenzählungrdfs:label : has begin issue numbering</para>
    ///   <para>rdfs:comment : The numbering of the beginning issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginIssueNumbering">ecpo:hasBeginIssueNumbering</a>
    /// </summary>
    let hasBeginIssueNumbering = _prefixId.prefix "hasBeginIssueNumbering"
    /// <summary>
    ///   <para>rdfs:label : hat beginnende Zeitrdfs:label : has begin temporal</para>
    ///   <para>rdfs:comment : A temporal information for the beginning group, like a year, a season, a month or a day</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginTemporal">ecpo:hasBeginTemporal</a>
    /// </summary>
    let hasBeginTemporal = _prefixId.prefix "hasBeginTemporal"
    /// <summary>
    ///   <para>rdfs:label : hat beginnende Zeit Ergänzungrdfs:label : has begin temporal extension</para>
    ///   <para>rdfs:comment : Refines the value of the property hasBeginTemporal</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginTemporalExtension">ecpo:hasBeginTemporalExtension</a>
    /// </summary>
    let hasBeginTemporalExtension = _prefixId.prefix "hasBeginTemporalExtension"
    /// <summary>
    ///   <para>rdfs:label : hat beginnende Bandbeschriftungrdfs:label : has begin volume caption</para>
    ///   <para>rdfs:comment : The caption of the beginning volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginVolumeCaption">ecpo:hasBeginVolumeCaption</a>
    /// </summary>
    let hasBeginVolumeCaption = _prefixId.prefix "hasBeginVolumeCaption"
    /// <summary>
    ///   <para>rdfs:label : has beginnende Bandergänzungrdfs:label : has begin volume extension</para>
    ///   <para>rdfs:comment : A textual descrimination of the beginning volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginVolumeExtension">ecpo:hasBeginVolumeExtension</a>
    /// </summary>
    let hasBeginVolumeExtension = _prefixId.prefix "hasBeginVolumeExtension"
    /// <summary>
    ///   <para>rdfs:label : hat beginnende Bandzählungrdfs:label : has begin volume numbering</para>
    ///   <para>rdfs:comment : The numbering of the beginning volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasBeginVolumeNumbering">ecpo:hasBeginVolumeNumbering</a>
    /// </summary>
    let hasBeginVolumeNumbering = _prefixId.prefix "hasBeginVolumeNumbering"
    /// <summary>
    ///   <para>rdfs:label : hat Bestandsverlaufrdfs:label : has chronology</para>
    ///   <para>rdfs:comment : Relation between an item and a Chronology</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasChronology">ecpo:hasChronology</a>
    /// </summary>
    let hasChronology = _prefixId.prefix "hasChronology"
    /// <summary>
    ///   <para>rdfs:label : hat Bestandsverlauflückerdfs:label : has chronology gap</para>
    ///   <para>rdfs:comment : Relation between an item and a Chronology, indicating the Chronology is a gap</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasChronologyGap">ecpo:hasChronologyGap</a>
    /// </summary>
    let hasChronologyGap = _prefixId.prefix "hasChronologyGap"
    /// <summary>
    ///   <para>rdfs:label : has end</para>
    ///   <para>rdfs:comment : Super-property to all properties of the ending group</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEnd">ecpo:hasEnd</a>
    /// </summary>
    let hasEnd = _prefixId.prefix "hasEnd"
    /// <summary>
    ///   <para>rdfs:label : hat endende Ausgabenbeschriftungrdfs:label : has end issue caption</para>
    ///   <para>rdfs:comment : The caption of the ending issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndIssueCaption">ecpo:hasEndIssueCaption</a>
    /// </summary>
    let hasEndIssueCaption = _prefixId.prefix "hasEndIssueCaption"
    /// <summary>
    ///   <para>rdfs:label : hat endende Ausgabenergänzungrdfs:label : has end issue extension</para>
    ///   <para>rdfs:comment : A textual descrimination of the ending issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndIssueExtension">ecpo:hasEndIssueExtension</a>
    /// </summary>
    let hasEndIssueExtension = _prefixId.prefix "hasEndIssueExtension"
    /// <summary>
    ///   <para>rdfs:label : hat endende Ausgabenzählungrdfs:label : has end issue numbering</para>
    ///   <para>rdfs:comment : The numbering of the ending issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndIssueNumbering">ecpo:hasEndIssueNumbering</a>
    /// </summary>
    let hasEndIssueNumbering = _prefixId.prefix "hasEndIssueNumbering"
    /// <summary>
    ///   <para>rdfs:label : has endende Zeitrdfs:label : has end temporal</para>
    ///   <para>rdfs:comment : A temporal information for the ending group, like a year, a season, a month or a day</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndTemporal">ecpo:hasEndTemporal</a>
    /// </summary>
    let hasEndTemporal = _prefixId.prefix "hasEndTemporal"
    /// <summary>
    ///   <para>rdfs:label : hat endende Zeit Ergänzungrdfs:label : has end temporal extension</para>
    ///   <para>rdfs:comment : Refines the value of the property hasEndTemporal</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndTemporalExtension">ecpo:hasEndTemporalExtension</a>
    /// </summary>
    let hasEndTemporalExtension = _prefixId.prefix "hasEndTemporalExtension"
    /// <summary>
    ///   <para>rdfs:label : hat endende Bandbeschriftungrdfs:label : has end volume caption</para>
    ///   <para>rdfs:comment : The caption of the ending volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndVolumeCaption">ecpo:hasEndVolumeCaption</a>
    /// </summary>
    let hasEndVolumeCaption = _prefixId.prefix "hasEndVolumeCaption"
    /// <summary>
    ///   <para>rdfs:label : hat endende Bandergänzungrdfs:label : has end volume extension</para>
    ///   <para>rdfs:comment : A textual descrimination of the endning volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndVolumeExtension">ecpo:hasEndVolumeExtension</a>
    /// </summary>
    let hasEndVolumeExtension = _prefixId.prefix "hasEndVolumeExtension"
    /// <summary>
    ///   <para>rdfs:label : hat endende Bandzählungrdfs:label : has end volume numbering</para>
    ///   <para>rdfs:comment : The numbering of the ending volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasEndVolumeNumbering">ecpo:hasEndVolumeNumbering</a>
    /// </summary>
    let hasEndVolumeNumbering = _prefixId.prefix "hasEndVolumeNumbering"
    /// <summary>
    ///   <para>rdfs:label : hat einzelnerdfs:label : has itemized</para>
    ///   <para>rdfs:comment : Super-property to all properties of a itemized Chronology</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemized">ecpo:hasItemized</a>
    /// </summary>
    let hasItemized = _prefixId.prefix "hasItemized"
    /// <summary>
    ///   <para>rdfs:label : hat einzelne Ausgabenbeschriftungrdfs:label : has itemized issue caption</para>
    ///   <para>rdfs:comment : The caption of the issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedIssueCaption">ecpo:hasItemizedIssueCaption</a>
    /// </summary>
    let hasItemizedIssueCaption = _prefixId.prefix "hasItemizedIssueCaption"
    /// <summary>
    ///   <para>rdfs:label : hat einzelne Ausgabenergänzungrdfs:label : has itemized issue extension</para>
    ///   <para>rdfs:comment : A textual descrimination of the issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedIssueExtension">ecpo:hasItemizedIssueExtension</a>
    /// </summary>
    let hasItemizedIssueExtension = _prefixId.prefix "hasItemizedIssueExtension"
    /// <summary>
    ///   <para>rdfs:label : hat einzelne Ausgabenzählungrdfs:label : has itemized issue numbering</para>
    ///   <para>rdfs:comment : The numbering of the issue</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedIssueNumbering">ecpo:hasItemizedIssueNumbering</a>
    /// </summary>
    let hasItemizedIssueNumbering = _prefixId.prefix "hasItemizedIssueNumbering"
    /// <summary>
    ///   <para>rdfs:label : has itemized temporalrdfs:label : has einzelne Zeit</para>
    ///   <para>rdfs:comment : A temporal information, like a year, a season, a month or a day</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedTemporal">ecpo:hasItemizedTemporal</a>
    /// </summary>
    let hasItemizedTemporal = _prefixId.prefix "hasItemizedTemporal"
    /// <summary>
    ///   <para>rdfs:label : hat Zeit Ergänzungrdfs:label : has temporal extension</para>
    ///   <para>rdfs:comment : Refines the value of the property hasItemizedTemporal</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedTemporalExtension">ecpo:hasItemizedTemporalExtension</a>
    /// </summary>
    let hasItemizedTemporalExtension = _prefixId.prefix "hasItemizedTemporalExtension"
    /// <summary>
    ///   <para>rdfs:label : hat einzelne Bandbeschriftungrdfs:label : has itemized volume caption</para>
    ///   <para>rdfs:comment : The caption of the volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedVolumeCaption">ecpo:hasItemizedVolumeCaption</a>
    /// </summary>
    let hasItemizedVolumeCaption = _prefixId.prefix "hasItemizedVolumeCaption"
    /// <summary>
    ///   <para>rdfs:label : hat einzelne Bandergänzungrdfs:label : has itemized volume extension</para>
    ///   <para>rdfs:comment : A textual descrimination of the volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedVolumeExtension">ecpo:hasItemizedVolumeExtension</a>
    /// </summary>
    let hasItemizedVolumeExtension = _prefixId.prefix "hasItemizedVolumeExtension"
    /// <summary>
    ///   <para>rdfs:label : hat einzelne Bandzählungrdfs:label : has itemized volume numbering</para>
    ///   <para>rdfs:comment : The numbering of the volume</para>
    ///   <a href="http://purl.org/ontology/ecpo#hasItemizedVolumeNumbering">ecpo:hasItemizedVolumeNumbering</a>
    /// </summary>
    let hasItemizedVolumeNumbering = _prefixId.prefix "hasItemizedVolumeNumbering"
