#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dnbt =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://d-nb.info/standards/elementset/dnb#" "dnbt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Automated activityrdfs:label : Automatisierte Aktivität</para>
    ///   <para>rdfs:comment : An automated activity is an activity performed by a machine with little or no human supervision.
    ///         It can be implied that the agent an automated activity is attributed to is a software agent as in
    /// 		&lt;#anAutomatedActivity&gt; a dnbt:AutomatedActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:SoftwareAgent .rdfs:comment : Eine automatisierte Aktivität ist eine Aktivität, die von einer Maschine durchgeführt wird und nur wenig oder
    ///             überhaupt nicht von Menschen überwacht wird. Es kann angenommen werden, dass der Agent, dem eine automatisierte
    ///             Aktivität zugeordnet wird, ein Softwareagent ist, wie in
    /// 		&lt;#anAutomatedActivity&gt; a dnbt:AutomatedActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:SoftwareAgent .</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#AutomatedActivity">dnbt:AutomatedActivity</a>
    /// </summary>
    let AutomatedActivity = _prefixId.prefix "AutomatedActivity"
    /// <summary>
    ///   <para>rdfs:label : Intellectual activityrdfs:label : Intellektuelle Aktivität</para>
    ///   <para>rdfs:comment : An intellectual activity is an activity performed by humans with little or no machine support.
    ///         It can be implied that the agent an intellectual activity is attributed to is a person agent as in
    /// 		&lt;#anIntellectualActivity&gt; a dnbt:IntellectualActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:Person .rdfs:comment : Eine intellektuelle Aktivität ist eine Aktivität, die von einem Menschen durchgeführt wird und nur wenig oder
    ///             überhaupt nicht von Maschinen unterstützt wird. Es kann angenommen werden, dass der Agent, dem eine intellektuelle
    ///             Aktivität zugeordnet wird, eine Person ist, wie in
    /// 		&lt;#anIntellectualActivity&gt; a dnbt:IntellectualActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:Person .</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#IntellectualActivity">dnbt:IntellectualActivity</a>
    /// </summary>
    let IntellectualActivity = _prefixId.prefix "IntellectualActivity"
    /// <summary>
    ///   <para>rdfs:label : Qualified Languagerdfs:label : Qualifizierte Sprache</para>
    ///   <para>rdfs:comment : An instance of dnbt:QualifiedLanguage provides additional descriptions about
    /// 		the binary dct:language relation from a publication to the language of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedLanguage [
    /// 			a dnbt:QualifiedLanguage;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesLanguage loc:ger ] .rdfs:comment : Eine Instanz von dnbt:QualifiedLanguage stellt zusätzliche Beschreibungen über
    /// 		die binäre Beziehung dct:language zwischen einer Publikation und ihrer Sprache bereit.
    /// 		Zum Beispiel &lt;#publication&gt; dnbt:hasQualifiedLanguage [
    /// 			a dnbt:QualifiedLanguage;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesLanguage loc:ger ] .</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#QualifiedLanguage">dnbt:QualifiedLanguage</a>
    /// </summary>
    let QualifiedLanguage = _prefixId.prefix "QualifiedLanguage"
    /// <summary>
    ///   <para>rdfs:label : Qualified subjectrdfs:label : Qualifiziertes Thema</para>
    ///   <para>rdfs:comment : An instance of dnbt:QualifiedSubject provides additional descriptions about
    /// 		the binary dct:subject relation from a publication to the subject(s) of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedSubject [
    /// 			a dnbt:QualifiedSubject;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesSubject gnd:12345-6 ] .rdfs:comment : Eine Instanz von dnbt:QualifiedSubject stellt zusätzliche Beschreibungen über
    /// 		die binäre Beziehung dct:subject zwischen einer Publikation und ihren Themen bereit.
    /// 		Zum Beispiel &lt;#publication&gt; dnbt:hasQualifiedSubject [
    /// 			a dnbt:QualifiedSubject;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesSubject gnd:12345-6 ] .</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#QualifiedSubject">dnbt:QualifiedSubject</a>
    /// </summary>
    let QualifiedSubject = _prefixId.prefix "QualifiedSubject"
    /// <summary>
    ///   <para>rdfs:label : Canonical URIrdfs:label : Kanonischer URI</para>
    ///   <para>rdfs:comment : The URI that is the primary identifier for a resource and should be used to reference it.rdfs:comment : Der URI, der eine Ressource primär identifiziert und zu ihrer Referenzierung verwendet werden sollte.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#canonicalUri">dnbt:canonicalUri</a>
    /// </summary>
    let canonicalUri = _prefixId.prefix "canonicalUri"
    /// <summary>
    ///   <para>rdfs:label : Date capturedrdfs:label : Datum des Datenstandes </para>
    ///   <para>rdfs:comment : The final modification date of the data
    ///                used to produce the resource. To update the resource, changes
    ///             from this timestamp onwards need to be incorporated.rdfs:comment : Das letzte Änderungsdatum der Datengrundlage
    /// 			der Ressource. Um die Ressource zu aktualisieren, müssen Änderungen
    ///             ab diesem Zeitstempel berücksichtigt werden.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#dateCaptured">dnbt:dateCaptured</a>
    /// </summary>
    let dateCaptured = _prefixId.prefix "dateCaptured"
    let ddc_subject_category = _prefixId.prefix "ddc-subject-category"
    /// <summary>
    ///   <para>rdfs:label : Deprecated URIrdfs:label : Abgelöster URI</para>
    ///   <para>rdfs:comment : A URI that is no longer recommended for referencing a resource.rdfs:comment : Ein URI, der nicht mehr für die Referenzierung einer Ressource empfohlen wird.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#deprecatedUri">dnbt:deprecatedUri</a>
    /// </summary>
    let deprecatedUri = _prefixId.prefix "deprecatedUri"
    /// <summary>
    ///   <para>rdfs:label : Has qualified languagerdfs:label : Hat qualifizierte Sprache</para>
    ///   <para>rdfs:comment : Connects a publication with an instance of dnbt:QualifiedLanguage.rdfs:comment : Verbindet eine Publikation mit einer Instanz von dnbt:QualifiedLanguage.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#hasQualifiedLanguage">dnbt:hasQualifiedLanguage</a>
    /// </summary>
    let hasQualifiedLanguage = _prefixId.prefix "hasQualifiedLanguage"
    /// <summary>
    ///   <para>rdfs:label : Has qualified subjectrdfs:label : Hat qualifiziertes Thema</para>
    ///   <para>rdfs:comment : Connects a publication with an instance of dnbt:QualifiedSubject.rdfs:comment : Verbindet eine Publikation mit einer Instanz von dnbt:QualifiedSubject.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#hasQualifiedSubject">dnbt:hasQualifiedSubject</a>
    /// </summary>
    let hasQualifiedSubject = _prefixId.prefix "hasQualifiedSubject"
    /// <summary>
    ///   <para>rdfs:label : Is described inrdfs:label : Wird beschrieben in</para>
    ///   <para>rdfs:comment : An information resource that contains a description of the entity in the subject position.rdfs:comment : Eine Informationsressource, die eine Beschreibung der Entität in der Subjektposition enthält.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#isDescribedIn">dnbt:isDescribedIn</a>
    /// </summary>
    let isDescribedIn = _prefixId.prefix "isDescribedIn"
    let larsGSvensson = _prefixId.prefix "larsGSvensson"
    let literary_genre_notation = _prefixId.prefix "literary-genre-notation"
    /// <summary>
    ///   <para>rdfs:label : Qualifies languagerdfs:label : Qualifiziert Sprache</para>
    ///   <para>rdfs:comment : Connects an instance of dnbt:QualifiedLanguage with the language it qualifies.rdfs:comment : Verbindet eine Instanz von dnbt:QualifiedLanguage mit der Sprache, die sie qualifiziert.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#qualifiesLanguage">dnbt:qualifiesLanguage</a>
    /// </summary>
    let qualifiesLanguage = _prefixId.prefix "qualifiesLanguage"
    /// <summary>
    ///   <para>rdfs:label : Qualifies subjectrdfs:label : Qualifiziert Thema</para>
    ///   <para>rdfs:comment : Connects an instance of dnbt:QualifiedSubject with the subject it qualifies.rdfs:comment : Verbindet eine Instanz von dnbt:QualifiedSubject mit dem Thema, das sie qualifiziert.</para>
    ///   <a href="http://d-nb.info/standards/elementset/dnb#qualifiesSubject">dnbt:qualifiesSubject</a>
    /// </summary>
    let qualifiesSubject = _prefixId.prefix "qualifiesSubject"
    let thema_classification_notation = _prefixId.prefix "thema-classification-notation"
