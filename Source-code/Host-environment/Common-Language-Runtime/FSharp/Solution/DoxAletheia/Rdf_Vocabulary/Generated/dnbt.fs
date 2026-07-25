namespace http.d_nb.info.standards.elementset.dnb.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dnbt =
    let _namespace_iri = Namespace_Iri dnbt |> NamespaceIRI
    /// <summary>
    ///   <para>dnbt:AutomatedActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Eine automatisierte Aktivität ist eine Aktivität, die von einer Maschine durchgeführt wird und nur wenig oder
    ///             überhaupt nicht von Menschen überwacht wird. Es kann angenommen werden, dass der Agent, dem eine automatisierte
    ///             Aktivität zugeordnet wird, ein Softwareagent ist, wie in
    /// 		&lt;#anAutomatedActivity&gt; a dnbt:AutomatedActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:SoftwareAgent .</para>
    ///   <para>An automated activity is an activity performed by a machine with little or no human supervision.
    ///         It can be implied that the agent an automated activity is attributed to is a software agent as in
    /// 		&lt;#anAutomatedActivity&gt; a dnbt:AutomatedActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:SoftwareAgent .</para>
    /// labels<para>Automatisierte Aktivität</para><para>Automated activity</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#AutomatedActivity">http://d-nb.info/standards/elementset/dnb#AutomatedActivity</seealso>
    let AutomatedActivity = Prefixed_Name(dnbt, "AutomatedActivity") |> PrefixedName
    /// <summary>
    ///   <para>dnbt:larsGSvensson</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///
    /// labels<para>Lars G. Svensson</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#larsGSvensson">http://d-nb.info/standards/elementset/dnb#larsGSvensson</seealso>
    let larsGSvensson = Prefixed_Name(dnbt, "larsGSvensson") |> PrefixedName
    /// <summary>
    ///   <para>dnbt:QualifiedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Eine Instanz von dnbt:QualifiedLanguage stellt zusätzliche Beschreibungen über
    /// 		die binäre Beziehung dct:language zwischen einer Publikation und ihrer Sprache bereit.
    /// 		Zum Beispiel &lt;#publication&gt; dnbt:hasQualifiedLanguage [
    /// 			a dnbt:QualifiedLanguage;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesLanguage loc:ger ] .</para>
    ///   <para>An instance of dnbt:QualifiedLanguage provides additional descriptions about
    /// 		the binary dct:language relation from a publication to the language of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedLanguage [
    /// 			a dnbt:QualifiedLanguage;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesLanguage loc:ger ] .</para>
    /// labels<para>Qualifizierte Sprache</para><para>Qualified Language</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#QualifiedLanguage">http://d-nb.info/standards/elementset/dnb#QualifiedLanguage</seealso>
    let QualifiedLanguage = Prefixed_Name(dnbt, "QualifiedLanguage") |> PrefixedName
    /// <summary>
    ///   <para>dnbt:canonicalUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The URI that is the primary identifier for a resource and should be used to reference it.</para>
    ///   <para>Der URI, der eine Ressource primär identifiziert und zu ihrer Referenzierung verwendet werden sollte.</para>
    /// labels<para>Kanonischer URI</para><para>Canonical URI</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#canonicalUri">http://d-nb.info/standards/elementset/dnb#canonicalUri</seealso>
    let canonicalUri = Prefixed_Name(dnbt, "canonicalUri") |> PrefixedName
    /// <summary>
    ///   <para>dnbt:dateCaptured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The final modification date of the data
    ///                used to produce the resource. To update the resource, changes
    ///             from this timestamp onwards need to be incorporated.</para>
    ///   <para>Das letzte Änderungsdatum der Datengrundlage
    /// 			der Ressource. Um die Ressource zu aktualisieren, müssen Änderungen
    ///             ab diesem Zeitstempel berücksichtigt werden.</para>
    /// labels<para>Datum des Datenstandes </para><para>Date captured</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#dateCaptured">http://d-nb.info/standards/elementset/dnb#dateCaptured</seealso>
    let dateCaptured = Prefixed_Name(dnbt, "dateCaptured") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:IntellectualActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An intellectual activity is an activity performed by humans with little or no machine support.
    ///         It can be implied that the agent an intellectual activity is attributed to is a person agent as in
    /// 		&lt;#anIntellectualActivity&gt; a dnbt:IntellectualActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:Person .</para>
    ///   <para>Eine intellektuelle Aktivität ist eine Aktivität, die von einem Menschen durchgeführt wird und nur wenig oder
    ///             überhaupt nicht von Maschinen unterstützt wird. Es kann angenommen werden, dass der Agent, dem eine intellektuelle
    ///             Aktivität zugeordnet wird, eine Person ist, wie in
    /// 		&lt;#anIntellectualActivity&gt; a dnbt:IntellectualActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:Person .</para>
    /// labels<para>Intellektuelle Aktivität</para><para>Intellectual activity</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#IntellectualActivity">http://d-nb.info/standards/elementset/dnb#IntellectualActivity</seealso>
    let IntellectualActivity =
        Prefixed_Name(dnbt, "IntellectualActivity") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:QualifiedSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of dnbt:QualifiedSubject provides additional descriptions about
    /// 		the binary dct:subject relation from a publication to the subject(s) of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedSubject [
    /// 			a dnbt:QualifiedSubject;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesSubject gnd:12345-6 ] .</para>
    ///   <para>Eine Instanz von dnbt:QualifiedSubject stellt zusätzliche Beschreibungen über
    /// 		die binäre Beziehung dct:subject zwischen einer Publikation und ihren Themen bereit.
    /// 		Zum Beispiel &lt;#publication&gt; dnbt:hasQualifiedSubject [
    /// 			a dnbt:QualifiedSubject;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesSubject gnd:12345-6 ] .</para>
    /// labels<para>Qualifiziertes Thema</para><para>Qualified subject</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#QualifiedSubject">http://d-nb.info/standards/elementset/dnb#QualifiedSubject</seealso>
    let QualifiedSubject = Prefixed_Name(dnbt, "QualifiedSubject") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:ddc-subject-category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>This datatype denotes a subject category based on the Dewey Decimal Classification (DDC).</para>
    ///   <para>Dieser Datentyp kennzeichnet eine Sachgruppe, die auf der Dewey-Dezimalklassifikation (DDC) beruht.</para>
    /// labels<para>DDC Subject Category</para><para>DDC-Sachgruppe</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#ddc-subject-category">http://d-nb.info/standards/elementset/dnb#ddc-subject-category</seealso>
    let ddc_subject_category =
        Prefixed_Name(dnbt, "ddc-subject-category") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:hasQualifiedSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Connects a publication with an instance of dnbt:QualifiedSubject.</para>
    ///   <para>Verbindet eine Publikation mit einer Instanz von dnbt:QualifiedSubject.</para>
    /// labels<para>Hat qualifiziertes Thema</para><para>Has qualified subject</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#hasQualifiedSubject">http://d-nb.info/standards/elementset/dnb#hasQualifiedSubject</seealso>
    let hasQualifiedSubject = Prefixed_Name(dnbt, "hasQualifiedSubject") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:hasQualifiedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Connects a publication with an instance of dnbt:QualifiedLanguage.</para>
    ///   <para>Verbindet eine Publikation mit einer Instanz von dnbt:QualifiedLanguage.</para>
    /// labels<para>Hat qualifizierte Sprache</para><para>Has qualified language</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#hasQualifiedLanguage">http://d-nb.info/standards/elementset/dnb#hasQualifiedLanguage</seealso>
    let hasQualifiedLanguage =
        Prefixed_Name(dnbt, "hasQualifiedLanguage") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:deprecatedUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Ein URI, der nicht mehr für die Referenzierung einer Ressource empfohlen wird.</para>
    ///   <para>A URI that is no longer recommended for referencing a resource.</para>
    /// labels<para>Deprecated URI</para><para>Abgelöster URI</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#deprecatedUri">http://d-nb.info/standards/elementset/dnb#deprecatedUri</seealso>
    let deprecatedUri = Prefixed_Name(dnbt, "deprecatedUri") |> PrefixedName
    /// <summary>
    ///   <para>dnbt:isDescribedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An information resource that contains a description of the entity in the subject position.</para>
    ///   <para>Eine Informationsressource, die eine Beschreibung der Entität in der Subjektposition enthält.</para>
    /// labels<para>Wird beschrieben in</para><para>Is described in</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#isDescribedIn">http://d-nb.info/standards/elementset/dnb#isDescribedIn</seealso>
    let isDescribedIn = Prefixed_Name(dnbt, "isDescribedIn") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:literary-genre-notation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>This datatype denotes a notation from the DNB list of literary genres.</para>
    ///   <para>Dieser Datentyp kennzeichnet eine Notation aus der Liste von literarischen Gattungen, gepflegt von der DNB</para>
    /// labels<para>Notation aus der Liste der Literarischen Gattungsbegriffe</para><para>Literary Genre Notation</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#literary-genre-notation">http://d-nb.info/standards/elementset/dnb#literary-genre-notation</seealso>
    let literary_genre_notation =
        Prefixed_Name(dnbt, "literary-genre-notation") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:qualifiesLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an instance of dnbt:QualifiedLanguage with the language it qualifies.</para>
    ///   <para>Verbindet eine Instanz von dnbt:QualifiedLanguage mit der Sprache, die sie qualifiziert.</para>
    /// labels<para>Qualifiziert Sprache</para><para>Qualifies language</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#qualifiesLanguage">http://d-nb.info/standards/elementset/dnb#qualifiesLanguage</seealso>
    let qualifiesLanguage = Prefixed_Name(dnbt, "qualifiesLanguage") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:thema-classification-notation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>This datatype denotes notation from the thema
    /// 		classification system. The thema classification is maintained by Editeur.org.</para>
    ///   <para>Dieser Datentyp kennzeichnet eine Notation aus der
    /// 		thema-Klassifikation. Diese Klassifikation wird gepflegt von Editeur.org.</para>
    /// labels<para>Notation aus der Thema-Klassifikation</para><para>Thema classification notation</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#thema-classification-notation">http://d-nb.info/standards/elementset/dnb#thema-classification-notation</seealso>
    let thema_classification_notation =
        Prefixed_Name(dnbt, "thema-classification-notation") |> PrefixedName

    /// <summary>
    ///   <para>dnbt:qualifiesSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an instance of dnbt:QualifiedSubject with the subject it qualifies.</para>
    ///   <para>Verbindet eine Instanz von dnbt:QualifiedSubject mit dem Thema, das sie qualifiziert.</para>
    /// labels<para>Qualifiziert Thema</para><para>Qualifies subject</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#qualifiesSubject">http://d-nb.info/standards/elementset/dnb#qualifiesSubject</seealso>
    let qualifiesSubject = Prefixed_Name(dnbt, "qualifiesSubject") |> PrefixedName
    /// <summary>
    ///   <para>dnbt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/dnb#">http://d-nb.info/standards/elementset/dnb#</seealso>
    let _prefix_iri = Prefixed_Name(dnbt, "") |> PrefixedName
