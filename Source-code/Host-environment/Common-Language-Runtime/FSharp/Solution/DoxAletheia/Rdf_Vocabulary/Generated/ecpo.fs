namespace http.purl.org.ontology.ecpo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ecpo =
    let _namespace_iri = Namespace_Iri ecpo |> NamespaceIRI
    /// <summary>
    ///   <para>ecpo:hasBegin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Super-property to all properties of the beginning group</para>
    /// labels<para>has begin</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBegin">http://purl.org/ontology/ecpo#hasBegin</seealso>
    let hasBegin = Prefixed_Name(ecpo, "hasBegin") |> PrefixedName
    /// <summary>
    ///   <para>ecpo:hasEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Super-property to all properties of the ending group</para>
    /// labels<para>has end</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEnd">http://purl.org/ontology/ecpo#hasEnd</seealso>
    let hasEnd = Prefixed_Name(ecpo, "hasEnd") |> PrefixedName
    /// <summary>
    ///   <para>ecpo:hasItemized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Super-property to all properties of a itemized Chronology</para>
    /// labels<para>has itemized</para><para>hat einzelne</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemized">http://purl.org/ontology/ecpo#hasItemized</seealso>
    let hasItemized = Prefixed_Name(ecpo, "hasItemized") |> PrefixedName
    /// <summary>
    ///   <para>ecpo:Closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ecpo:ClosedChronology</para>
    ///   <para>A closed Chronology.</para>
    /// labels<para>abgeschlossen</para><para>closed</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#Closed">http://purl.org/ontology/ecpo#Closed</seealso>
    let Closed = Prefixed_Name(ecpo, "Closed") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginIssueCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The caption of the beginning issue</para>
    /// labels<para>hat beginnende Ausgabenbeschriftung</para><para>has begin issue caption</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginIssueCaption">http://purl.org/ontology/ecpo#hasBeginIssueCaption</seealso>
    let hasBeginIssueCaption =
        Prefixed_Name(ecpo, "hasBeginIssueCaption") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndTemporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A temporal information for the ending group, like a year, a season, a month or a day</para>
    /// labels<para>has endende Zeit</para><para>has end temporal</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndTemporal">http://purl.org/ontology/ecpo#hasEndTemporal</seealso>
    let hasEndTemporal = Prefixed_Name(ecpo, "hasEndTemporal") |> PrefixedName
    /// <summary>
    ///   <para>ecpo:ClosedChronology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Chronology having an ending group.</para>
    /// labels<para>Bestandsverlauf abgeschlossen</para><para>closed chronology</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#ClosedChronology">http://purl.org/ontology/ecpo#ClosedChronology</seealso>
    let ClosedChronology = Prefixed_Name(ecpo, "ClosedChronology") |> PrefixedName
    /// <summary>
    ///   <para>ecpo:CurrentChronology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Chronology without an ending group.</para>
    /// labels<para>Bestandsverlauf laufend</para><para>current chronology</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#CurrentChronology">http://purl.org/ontology/ecpo#CurrentChronology</seealso>
    let CurrentChronology = Prefixed_Name(ecpo, "CurrentChronology") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginIssueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual descrimination of the beginning issue</para>
    /// labels<para>hat beginnende Ausgabenergänzung</para><para>has begin issue extension</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginIssueExtension">http://purl.org/ontology/ecpo#hasBeginIssueExtension</seealso>
    let hasBeginIssueExtension =
        Prefixed_Name(ecpo, "hasBeginIssueExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginTemporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A temporal information for the beginning group, like a year, a season, a month or a day</para>
    /// labels<para>hat beginnende Zeit</para><para>has begin temporal</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginTemporal">http://purl.org/ontology/ecpo#hasBeginTemporal</seealso>
    let hasBeginTemporal = Prefixed_Name(ecpo, "hasBeginTemporal") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginVolumeCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The caption of the beginning volume</para>
    /// labels<para>hat beginnende Bandbeschriftung</para><para>has begin volume caption</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginVolumeCaption">http://purl.org/ontology/ecpo#hasBeginVolumeCaption</seealso>
    let hasBeginVolumeCaption =
        Prefixed_Name(ecpo, "hasBeginVolumeCaption") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginVolumeNumbering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numbering of the beginning volume</para>
    /// labels<para>hat beginnende Bandzählung</para><para>has begin volume numbering</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginVolumeNumbering">http://purl.org/ontology/ecpo#hasBeginVolumeNumbering</seealso>
    let hasBeginVolumeNumbering =
        Prefixed_Name(ecpo, "hasBeginVolumeNumbering") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasChronology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an item and a Chronology</para>
    /// labels<para>hat Bestandsverlauf</para><para>has chronology</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasChronology">http://purl.org/ontology/ecpo#hasChronology</seealso>
    let hasChronology = Prefixed_Name(ecpo, "hasChronology") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginIssueNumbering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numbering of the beginning issue</para>
    /// labels<para>hat beginnende Ausgabenzählung</para><para>has begin issue numbering</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginIssueNumbering">http://purl.org/ontology/ecpo#hasBeginIssueNumbering</seealso>
    let hasBeginIssueNumbering =
        Prefixed_Name(ecpo, "hasBeginIssueNumbering") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginTemporalExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Refines the value of the property hasBeginTemporal</para>
    /// labels<para>hat beginnende Zeit Ergänzung</para><para>has begin temporal extension</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginTemporalExtension">http://purl.org/ontology/ecpo#hasBeginTemporalExtension</seealso>
    let hasBeginTemporalExtension =
        Prefixed_Name(ecpo, "hasBeginTemporalExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasBeginVolumeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual descrimination of the beginning volume</para>
    /// labels<para>has beginnende Bandergänzung</para><para>has begin volume extension</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasBeginVolumeExtension">http://purl.org/ontology/ecpo#hasBeginVolumeExtension</seealso>
    let hasBeginVolumeExtension =
        Prefixed_Name(ecpo, "hasBeginVolumeExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasChronologyGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an item and a Chronology, indicating the Chronology is a gap</para>
    /// labels<para>hat Bestandsverlauflücke</para><para>has chronology gap</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasChronologyGap">http://purl.org/ontology/ecpo#hasChronologyGap</seealso>
    let hasChronologyGap = Prefixed_Name(ecpo, "hasChronologyGap") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndIssueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual descrimination of the ending issue</para>
    /// labels<para>hat endende Ausgabenergänzung</para><para>has end issue extension</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndIssueExtension">http://purl.org/ontology/ecpo#hasEndIssueExtension</seealso>
    let hasEndIssueExtension =
        Prefixed_Name(ecpo, "hasEndIssueExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndIssueNumbering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numbering of the ending issue</para>
    /// labels<para>hat endende Ausgabenzählung</para><para>has end issue numbering</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndIssueNumbering">http://purl.org/ontology/ecpo#hasEndIssueNumbering</seealso>
    let hasEndIssueNumbering =
        Prefixed_Name(ecpo, "hasEndIssueNumbering") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndVolumeCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The caption of the ending volume</para>
    /// labels<para>hat endende Bandbeschriftung</para><para>has end volume caption</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndVolumeCaption">http://purl.org/ontology/ecpo#hasEndVolumeCaption</seealso>
    let hasEndVolumeCaption = Prefixed_Name(ecpo, "hasEndVolumeCaption") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndVolumeNumbering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numbering of the ending volume</para>
    /// labels<para>has end volume numbering</para><para>hat endende Bandzählung</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndVolumeNumbering">http://purl.org/ontology/ecpo#hasEndVolumeNumbering</seealso>
    let hasEndVolumeNumbering =
        Prefixed_Name(ecpo, "hasEndVolumeNumbering") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedIssueNumbering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numbering of the issue</para>
    /// labels<para>hat einzelne Ausgabenzählung</para><para>has itemized issue numbering</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedIssueNumbering">http://purl.org/ontology/ecpo#hasItemizedIssueNumbering</seealso>
    let hasItemizedIssueNumbering =
        Prefixed_Name(ecpo, "hasItemizedIssueNumbering") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedTemporalExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Refines the value of the property hasItemizedTemporal</para>
    /// labels<para>has temporal extension</para><para>hat Zeit Ergänzung</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedTemporalExtension">http://purl.org/ontology/ecpo#hasItemizedTemporalExtension</seealso>
    let hasItemizedTemporalExtension =
        Prefixed_Name(ecpo, "hasItemizedTemporalExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedVolumeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual descrimination of the volume</para>
    /// labels<para>has itemized volume extension</para><para>hat einzelne Bandergänzung</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedVolumeExtension">http://purl.org/ontology/ecpo#hasItemizedVolumeExtension</seealso>
    let hasItemizedVolumeExtension =
        Prefixed_Name(ecpo, "hasItemizedVolumeExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndIssueCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The caption of the ending issue</para>
    /// labels<para>hat endende Ausgabenbeschriftung</para><para>has end issue caption</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndIssueCaption">http://purl.org/ontology/ecpo#hasEndIssueCaption</seealso>
    let hasEndIssueCaption = Prefixed_Name(ecpo, "hasEndIssueCaption") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndTemporalExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Refines the value of the property hasEndTemporal</para>
    /// labels<para>hat endende Zeit Ergänzung</para><para>has end temporal extension</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndTemporalExtension">http://purl.org/ontology/ecpo#hasEndTemporalExtension</seealso>
    let hasEndTemporalExtension =
        Prefixed_Name(ecpo, "hasEndTemporalExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasEndVolumeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual descrimination of the endning volume</para>
    /// labels<para>hat endende Bandergänzung</para><para>has end volume extension</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasEndVolumeExtension">http://purl.org/ontology/ecpo#hasEndVolumeExtension</seealso>
    let hasEndVolumeExtension =
        Prefixed_Name(ecpo, "hasEndVolumeExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedIssueCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The caption of the issue</para>
    /// labels<para>hat einzelne Ausgabenbeschriftung</para><para>has itemized issue caption</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedIssueCaption">http://purl.org/ontology/ecpo#hasItemizedIssueCaption</seealso>
    let hasItemizedIssueCaption =
        Prefixed_Name(ecpo, "hasItemizedIssueCaption") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedIssueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual descrimination of the issue</para>
    /// labels<para>hat einzelne Ausgabenergänzung</para><para>has itemized issue extension</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedIssueExtension">http://purl.org/ontology/ecpo#hasItemizedIssueExtension</seealso>
    let hasItemizedIssueExtension =
        Prefixed_Name(ecpo, "hasItemizedIssueExtension") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedTemporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A temporal information, like a year, a season, a month or a day</para>
    /// labels<para>has itemized temporal</para><para>has einzelne Zeit</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedTemporal">http://purl.org/ontology/ecpo#hasItemizedTemporal</seealso>
    let hasItemizedTemporal = Prefixed_Name(ecpo, "hasItemizedTemporal") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedVolumeCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The caption of the volume</para>
    /// labels<para>hat einzelne Bandbeschriftung</para><para>has itemized volume caption</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedVolumeCaption">http://purl.org/ontology/ecpo#hasItemizedVolumeCaption</seealso>
    let hasItemizedVolumeCaption =
        Prefixed_Name(ecpo, "hasItemizedVolumeCaption") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:hasItemizedVolumeNumbering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numbering of the volume</para>
    /// labels<para>has itemized volume numbering</para><para>hat einzelne Bandzählung</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#hasItemizedVolumeNumbering">http://purl.org/ontology/ecpo#hasItemizedVolumeNumbering</seealso>
    let hasItemizedVolumeNumbering =
        Prefixed_Name(ecpo, "hasItemizedVolumeNumbering") |> PrefixedName

    /// <summary>
    ///   <para>ecpo:Chronology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Chronology is the description of enumeration and chronology of a periodical.</para>
    /// labels<para>enumeration and chronology</para><para>Bestandsverlauf</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#Chronology">http://purl.org/ontology/ecpo#Chronology</seealso>
    let Chronology = Prefixed_Name(ecpo, "Chronology") |> PrefixedName
    /// <summary>
    ///   <para>ecpo:Current</para>
    /// </summary>
    /// <remarks>
    ///   <para>ecpo:CurrentChronology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A current Chronology.</para>
    /// labels<para>current</para><para>laufend</para></remarks>
    /// <seealso href="http://purl.org/ontology/ecpo#Current">http://purl.org/ontology/ecpo#Current</seealso>
    let Current = Prefixed_Name(ecpo, "Current") |> PrefixedName
