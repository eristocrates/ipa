namespace http.d_nb.info.standards.elementset.dnb.hash

open DoxAletheia

module dnbt =
    let _namespace_name = "http://d-nb.info/standards/elementset/dnb#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/dnb#larsGSvensson"></see>
    /// </summary>
    let larsGSvensson = _prefix "larsGSvensson"
    /// <summary>
    /// An automated activity is an activity performed by a machine with little or no human supervision.
    ///         It can be implied that the agent an automated activity is attributed to is a software agent as in
    /// 		&lt;#anAutomatedActivity&gt; a dnbt:AutomatedActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:SoftwareAgent .
    /// <see href="http://d-nb.info/standards/elementset/dnb#AutomatedActivity"></see></summary>
    let AutomatedActivity = _prefix "AutomatedActivity"
    /// <summary>
    /// An intellectual activity is an activity performed by humans with little or no machine support.
    ///         It can be implied that the agent an intellectual activity is attributed to is a person agent as in
    /// 		&lt;#anIntellectualActivity&gt; a dnbt:IntellectualActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:Person .
    /// <see href="http://d-nb.info/standards/elementset/dnb#IntellectualActivity"></see></summary>
    let IntellectualActivity = _prefix "IntellectualActivity"
    /// <summary>
    /// An instance of dnbt:QualifiedLanguage provides additional descriptions about
    /// 		the binary dct:language relation from a publication to the language of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedLanguage [
    /// 			a dnbt:QualifiedLanguage;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesLanguage loc:ger ] .
    /// <see href="http://d-nb.info/standards/elementset/dnb#QualifiedLanguage"></see></summary>
    let QualifiedLanguage = _prefix "QualifiedLanguage"
    /// <summary>
    /// An instance of dnbt:QualifiedSubject provides additional descriptions about
    /// 		the binary dct:subject relation from a publication to the subject(s) of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedSubject [
    /// 			a dnbt:QualifiedSubject;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesSubject gnd:12345-6 ] .
    /// <see href="http://d-nb.info/standards/elementset/dnb#QualifiedSubject"></see></summary>
    let QualifiedSubject = _prefix "QualifiedSubject"
    /// <summary>
    /// The URI that is the primary identifier for a resource and should be used to reference it.
    /// <see href="http://d-nb.info/standards/elementset/dnb#canonicalUri"></see></summary>
    let canonicalUri = _prefix "canonicalUri"
    /// <summary>
    /// The final modification date of the data
    ///                used to produce the resource. To update the resource, changes
    ///             from this timestamp onwards need to be incorporated.
    /// <see href="http://d-nb.info/standards/elementset/dnb#dateCaptured"></see></summary>
    let dateCaptured = _prefix "dateCaptured"
    /// <summary>
    /// This datatype denotes a subject category based on the Dewey Decimal Classification (DDC).
    /// <see href="http://d-nb.info/standards/elementset/dnb#ddc-subject-category"></see></summary>
    let ``ddc-subject-category`` = _prefix "ddc-subject-category"
    /// <summary>
    /// A URI that is no longer recommended for referencing a resource.
    /// <see href="http://d-nb.info/standards/elementset/dnb#deprecatedUri"></see></summary>
    let deprecatedUri = _prefix "deprecatedUri"
    /// <summary>
    /// Connects a publication with an instance of dnbt:QualifiedLanguage.
    /// <see href="http://d-nb.info/standards/elementset/dnb#hasQualifiedLanguage"></see></summary>
    let hasQualifiedLanguage = _prefix "hasQualifiedLanguage"
    /// <summary>
    /// Connects a publication with an instance of dnbt:QualifiedSubject.
    /// <see href="http://d-nb.info/standards/elementset/dnb#hasQualifiedSubject"></see></summary>
    let hasQualifiedSubject = _prefix "hasQualifiedSubject"
    /// <summary>
    /// An information resource that contains a description of the entity in the subject position.
    /// <see href="http://d-nb.info/standards/elementset/dnb#isDescribedIn"></see></summary>
    let isDescribedIn = _prefix "isDescribedIn"
    /// <summary>
    /// This datatype denotes a notation from the DNB list of literary genres.
    /// <see href="http://d-nb.info/standards/elementset/dnb#literary-genre-notation"></see></summary>
    let ``literary-genre-notation`` = _prefix "literary-genre-notation"
    /// <summary>
    /// Connects an instance of dnbt:QualifiedLanguage with the language it qualifies.
    /// <see href="http://d-nb.info/standards/elementset/dnb#qualifiesLanguage"></see></summary>
    let qualifiesLanguage = _prefix "qualifiesLanguage"
    /// <summary>
    /// Connects an instance of dnbt:QualifiedSubject with the subject it qualifies.
    /// <see href="http://d-nb.info/standards/elementset/dnb#qualifiesSubject"></see></summary>
    let qualifiesSubject = _prefix "qualifiesSubject"
    /// <summary>
    /// This datatype denotes notation from the thema
    /// 		classification system. The thema classification is maintained by Editeur.org.
    /// <see href="http://d-nb.info/standards/elementset/dnb#thema-classification-notation"></see></summary>
    let ``thema-classification-notation`` = _prefix "thema-classification-notation"
