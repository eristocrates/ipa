namespace http.d_nb.info.standards.elementset.dnb.hash

open DoxAletheia.Rdf_Vocabulary

module dnbt =
    let _namespace_name = "http://d-nb.info/standards/elementset/dnb#"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/dnb#larsGSvensson"></see>
    /// </summary>
    let larsGSvensson =
        Namespaced_IRI.parse _namespace_name "larsGSvensson" |> NamespacedName

    /// <summary>
    /// An automated activity is an activity performed by a machine with little or no human supervision.
    ///         It can be implied that the agent an automated activity is attributed to is a software agent as in
    /// 		&lt;#anAutomatedActivity&gt; a dnbt:AutomatedActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:SoftwareAgent .
    /// <see href="http://d-nb.info/standards/elementset/dnb#AutomatedActivity"></see></summary>
    let AutomatedActivity =
        Namespaced_IRI.parse _namespace_name "AutomatedActivity" |> NamespacedName

    /// <summary>
    /// An intellectual activity is an activity performed by humans with little or no machine support.
    ///         It can be implied that the agent an intellectual activity is attributed to is a person agent as in
    /// 		&lt;#anIntellectualActivity&gt; a dnbt:IntellectualActivity ;
    /// 			prov:wasAttributedTo :anAgent .
    /// 		:anAgent a prov:Person .
    /// <see href="http://d-nb.info/standards/elementset/dnb#IntellectualActivity"></see></summary>
    let IntellectualActivity =
        Namespaced_IRI.parse _namespace_name "IntellectualActivity" |> NamespacedName

    /// <summary>
    /// An instance of dnbt:QualifiedLanguage provides additional descriptions about
    /// 		the binary dct:language relation from a publication to the language of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedLanguage [
    /// 			a dnbt:QualifiedLanguage;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesLanguage loc:ger ] .
    /// <see href="http://d-nb.info/standards/elementset/dnb#QualifiedLanguage"></see></summary>
    let QualifiedLanguage =
        Namespaced_IRI.parse _namespace_name "QualifiedLanguage" |> NamespacedName

    /// <summary>
    /// An instance of dnbt:QualifiedSubject provides additional descriptions about
    /// 		the binary dct:subject relation from a publication to the subject(s) of that publication.
    /// 		For example &lt;#publication&gt; dnbt:hasQualifiedSubject [
    /// 			a dnbt:QualifiedSubject;
    /// 			prov:wasGeneratedBy &lt;#aPieceOfSoftware&gt; ;
    /// 			ex:confidenceValue 0.6^^xsd:decimal ;
    /// 			dnbt:qualifiesSubject gnd:12345-6 ] .
    /// <see href="http://d-nb.info/standards/elementset/dnb#QualifiedSubject"></see></summary>
    let QualifiedSubject =
        Namespaced_IRI.parse _namespace_name "QualifiedSubject" |> NamespacedName

    /// <summary>
    /// The URI that is the primary identifier for a resource and should be used to reference it.
    /// <see href="http://d-nb.info/standards/elementset/dnb#canonicalUri"></see></summary>
    let canonicalUri =
        Namespaced_IRI.parse _namespace_name "canonicalUri" |> NamespacedName

    /// <summary>
    /// The final modification date of the data
    ///                used to produce the resource. To update the resource, changes
    ///             from this timestamp onwards need to be incorporated.
    /// <see href="http://d-nb.info/standards/elementset/dnb#dateCaptured"></see></summary>
    let dateCaptured =
        Namespaced_IRI.parse _namespace_name "dateCaptured" |> NamespacedName

    /// <summary>
    /// This datatype denotes a subject category based on the Dewey Decimal Classification (DDC).
    /// <see href="http://d-nb.info/standards/elementset/dnb#ddc-subject-category"></see></summary>
    let ``ddc-subject-category`` =
        Namespaced_IRI.parse _namespace_name "ddc-subject-category" |> NamespacedName

    /// <summary>
    /// A URI that is no longer recommended for referencing a resource.
    /// <see href="http://d-nb.info/standards/elementset/dnb#deprecatedUri"></see></summary>
    let deprecatedUri =
        Namespaced_IRI.parse _namespace_name "deprecatedUri" |> NamespacedName

    /// <summary>
    /// Connects a publication with an instance of dnbt:QualifiedLanguage.
    /// <see href="http://d-nb.info/standards/elementset/dnb#hasQualifiedLanguage"></see></summary>
    let hasQualifiedLanguage =
        Namespaced_IRI.parse _namespace_name "hasQualifiedLanguage" |> NamespacedName

    /// <summary>
    /// Connects a publication with an instance of dnbt:QualifiedSubject.
    /// <see href="http://d-nb.info/standards/elementset/dnb#hasQualifiedSubject"></see></summary>
    let hasQualifiedSubject =
        Namespaced_IRI.parse _namespace_name "hasQualifiedSubject" |> NamespacedName

    /// <summary>
    /// An information resource that contains a description of the entity in the subject position.
    /// <see href="http://d-nb.info/standards/elementset/dnb#isDescribedIn"></see></summary>
    let isDescribedIn =
        Namespaced_IRI.parse _namespace_name "isDescribedIn" |> NamespacedName

    /// <summary>
    /// This datatype denotes a notation from the DNB list of literary genres.
    /// <see href="http://d-nb.info/standards/elementset/dnb#literary-genre-notation"></see></summary>
    let ``literary-genre-notation`` =
        Namespaced_IRI.parse _namespace_name "literary-genre-notation" |> NamespacedName

    /// <summary>
    /// Connects an instance of dnbt:QualifiedLanguage with the language it qualifies.
    /// <see href="http://d-nb.info/standards/elementset/dnb#qualifiesLanguage"></see></summary>
    let qualifiesLanguage =
        Namespaced_IRI.parse _namespace_name "qualifiesLanguage" |> NamespacedName

    /// <summary>
    /// Connects an instance of dnbt:QualifiedSubject with the subject it qualifies.
    /// <see href="http://d-nb.info/standards/elementset/dnb#qualifiesSubject"></see></summary>
    let qualifiesSubject =
        Namespaced_IRI.parse _namespace_name "qualifiesSubject" |> NamespacedName

    /// <summary>
    /// This datatype denotes notation from the thema
    /// 		classification system. The thema classification is maintained by Editeur.org.
    /// <see href="http://d-nb.info/standards/elementset/dnb#thema-classification-notation"></see></summary>
    let ``thema-classification-notation`` =
        Namespaced_IRI.parse _namespace_name "thema-classification-notation" |> NamespacedName
