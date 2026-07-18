namespace http.purl.org.linkingyou.slash

open DoxAletheia.Rdf_Vocabulary

module lyou =
    let _namespace_name = "http://purl.org/linkingyou/"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/about"></see>
    /// </summary>
    let about = Namespaced_IRI.parse _namespace_name "about" |> NamespacedName
    /// <summary>
    /// This is used to identify which predicates represent a simple core of Linking You
    /// <see href="http://purl.org/linkingyou/core"></see></summary>
    let core = Namespaced_IRI.parse _namespace_name "core" |> NamespacedName

    /// <summary>
    /// Links a group or organisation to a page about the senior staff, be it Microsoft's senior staff or the committee members of a university club. This was not a linkingyou term.
    /// <see href="http://purl.org/linkingyou/about-executive"></see></summary>
    let ``about-executive`` =
        Namespaced_IRI.parse _namespace_name "about-executive" |> NamespacedName

    /// <summary>
    /// Predicates only useful to UK organisations
    /// This is used to identify which predicates are outside the the core terms. Still useful but listed in a second section.
    /// <see href="http://purl.org/linkingyou/extended"></see></summary>
    let extended = Namespaced_IRI.parse _namespace_name "extended" |> NamespacedName

    /// <summary>
    /// Links a group or organisation to a page about the leader of that organisation. This is modified from the linkingyou 'vc' page to make it work for organistations where the leader is not a Vice Chancellor.
    /// <see href="http://purl.org/linkingyou/about-leader"></see></summary>
    let ``about-leader`` =
        Namespaced_IRI.parse _namespace_name "about-leader" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/about-parents"></see>
    /// </summary>
    let ``about-parents`` =
        Namespaced_IRI.parse _namespace_name "about-parents" |> NamespacedName

    /// <summary>
    /// This is used to identify which predicates are related to education so they can be listed separately in the documentation.
    /// <see href="http://purl.org/linkingyou/education"></see></summary>
    let education = Namespaced_IRI.parse _namespace_name "education" |> NamespacedName

    /// <summary>
    /// Links a group or organisation to a page about the sites or campuses of that organisation. Was about/campuses in linkingyou, but altered here to be less academic-only.
    /// <see href="http://purl.org/linkingyou/about-sites"></see></summary>
    let ``about-sites`` =
        Namespaced_IRI.parse _namespace_name "about-sites" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/about-strategy"></see>
    /// </summary>
    let ``about-strategy`` =
        Namespaced_IRI.parse _namespace_name "about-strategy" |> NamespacedName

    /// <summary>
    /// This is used to identify which predicates are related to academia (other than education) so they can be listed separately in the documentation.
    /// <see href="http://purl.org/linkingyou/academia"></see></summary>
    let academia = Namespaced_IRI.parse _namespace_name "academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/academic-depts"></see>
    /// </summary>
    let ``academic-depts`` =
        Namespaced_IRI.parse _namespace_name "academic-depts" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/business"></see>
    /// </summary>
    let business = Namespaced_IRI.parse _namespace_name "business" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/business-incubation"></see>
    /// </summary>
    let ``business-incubation`` =
        Namespaced_IRI.parse _namespace_name "business-incubation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/business-ktp"></see>
    /// </summary>
    let ``business-ktp`` =
        Namespaced_IRI.parse _namespace_name "business-ktp" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/conference-facilities"></see>
    /// </summary>
    let ``conference-facilities`` =
        Namespaced_IRI.parse _namespace_name "conference-facilities" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/conferences"></see>
    /// </summary>
    let conferences =
        Namespaced_IRI.parse _namespace_name "conferences" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/contact"></see>
    /// </summary>
    let contact = Namespaced_IRI.parse _namespace_name "contact" |> NamespacedName

    /// <summary>
    /// A page giving contact details for staff in the organisation. Generally this is a searchable phonebook.
    /// <see href="http://purl.org/linkingyou/contact-staff"></see></summary>
    let ``contact-staff`` =
        Namespaced_IRI.parse _namespace_name "contact-staff" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/courses"></see>
    /// </summary>
    let courses = Namespaced_IRI.parse _namespace_name "courses" |> NamespacedName
    /// <summary>
    /// Links a group or organisation to a document describing its parts. This is not a linkingyou term but was added as the existing terms were only applicable to academia.
    /// <see href="http://purl.org/linkingyou/depts"></see></summary>
    let depts = Namespaced_IRI.parse _namespace_name "depts" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/events"></see>
    /// </summary>
    let events = Namespaced_IRI.parse _namespace_name "events" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/events-graduation"></see>
    /// </summary>
    let ``events-graduation`` =
        Namespaced_IRI.parse _namespace_name "events-graduation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/foundation"></see>
    /// </summary>
    let foundation = Namespaced_IRI.parse _namespace_name "foundation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/foundation-courses"></see>
    /// </summary>
    let ``foundation-courses`` =
        Namespaced_IRI.parse _namespace_name "foundation-courses" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/foundation-courses-entry-requirements"></see>
    /// </summary>
    let ``foundation-courses-entry-requirements`` =
        Namespaced_IRI.parse _namespace_name "foundation-courses-entry-requirements" |> NamespacedName

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its foundation prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/foundation-prospectus"></see></summary>
    let ``foundation-prospectus`` =
        Namespaced_IRI.parse _namespace_name "foundation-prospectus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/ict-support"></see>
    /// </summary>
    let ``ict-support`` =
        Namespaced_IRI.parse _namespace_name "ict-support" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/international-students"></see>
    /// </summary>
    let ``international-students`` =
        Namespaced_IRI.parse _namespace_name "international-students" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/jobs"></see>
    /// </summary>
    let jobs = Namespaced_IRI.parse _namespace_name "jobs" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal"></see>
    /// </summary>
    let legal = Namespaced_IRI.parse _namespace_name "legal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-data-protection"></see>
    /// </summary>
    let ``legal-data-protection`` =
        Namespaced_IRI.parse _namespace_name "legal-data-protection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-environment"></see>
    /// </summary>
    let ``legal-environment`` =
        Namespaced_IRI.parse _namespace_name "legal-environment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-equality"></see>
    /// </summary>
    let ``legal-equality`` =
        Namespaced_IRI.parse _namespace_name "legal-equality" |> NamespacedName

    /// <summary>
    /// Many research organisations have a public ethics policy.
    /// <see href="http://purl.org/linkingyou/legal-ethics"></see></summary>
    let ``legal-ethics`` =
        Namespaced_IRI.parse _namespace_name "legal-ethics" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-foi"></see>
    /// </summary>
    let ``legal-foi`` =
        Namespaced_IRI.parse _namespace_name "legal-foi" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-ict"></see>
    /// </summary>
    let ``legal-ict`` =
        Namespaced_IRI.parse _namespace_name "legal-ict" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-policies"></see>
    /// </summary>
    let ``legal-policies`` =
        Namespaced_IRI.parse _namespace_name "legal-policies" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-regulations"></see>
    /// </summary>
    let ``legal-regulations`` =
        Namespaced_IRI.parse _namespace_name "legal-regulations" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-website"></see>
    /// </summary>
    let ``legal-website`` =
        Namespaced_IRI.parse _namespace_name "legal-website" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/news"></see>
    /// </summary>
    let news = Namespaced_IRI.parse _namespace_name "news" |> NamespacedName

    /// <summary>
    /// Links a group or organisation to a page (or the homepage of a website) describing open data services from the organisation, eg. http://data.lincoln.ac.uk/
    /// <see href="http://purl.org/linkingyou/open-data"></see></summary>
    let ``open-data`` =
        Namespaced_IRI.parse _namespace_name "open-data" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/opendays"></see>
    /// </summary>
    let opendays = Namespaced_IRI.parse _namespace_name "opendays" |> NamespacedName

    /// <summary>
    /// covering research and taught postgraduates
    /// <see href="http://purl.org/linkingyou/postgraduate"></see></summary>
    let postgraduate =
        Namespaced_IRI.parse _namespace_name "postgraduate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-research"></see>
    /// </summary>
    let ``postgraduate-research`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-research" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-research-courses"></see>
    /// </summary>
    let ``postgraduate-research-courses`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-research-courses" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-research-courses-entry-requirements"></see>
    /// </summary>
    let ``postgraduate-research-courses-entry-requirements`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-research-courses-entry-requirements" |> NamespacedName

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its research postgraduate prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/postgraduate-research-prospectus"></see></summary>
    let ``postgraduate-research-prospectus`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-research-prospectus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-taught"></see>
    /// </summary>
    let ``postgraduate-taught`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-taught" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-taught-courses"></see>
    /// </summary>
    let ``postgraduate-taught-courses`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-taught-courses" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-taught-courses-entry-requirements"></see>
    /// </summary>
    let ``postgraduate-taught-courses-entry-requirements`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-taught-courses-entry-requirements" |> NamespacedName

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its taught postgraduate prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/postgraduate-taught-prospectus"></see></summary>
    let ``postgraduate-taught-prospectus`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-taught-prospectus" |> NamespacedName

    /// <summary>
    /// A page with information specifically aimed at journalists.
    /// <see href="http://purl.org/linkingyou/press"></see></summary>
    let press = Namespaced_IRI.parse _namespace_name "press" |> NamespacedName

    /// <summary>
    /// A page aimed at the press with a list of useful facts about the organisation.
    /// <see href="http://purl.org/linkingyou/press-facts"></see></summary>
    let ``press-facts`` =
        Namespaced_IRI.parse _namespace_name "press-facts" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/public-lectures"></see>
    /// </summary>
    let ``public-lectures`` =
        Namespaced_IRI.parse _namespace_name "public-lectures" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/research"></see>
    /// </summary>
    let research = Namespaced_IRI.parse _namespace_name "research" |> NamespacedName
    /// <summary>
    /// Perhaps this should link to a string with a variable in to indicate how to construct a search?
    /// <see href="http://purl.org/linkingyou/search"></see></summary>
    let search = Namespaced_IRI.parse _namespace_name "search" |> NamespacedName

    /// <summary>
    /// Links a group or organisation to a document describing the aspects of the location and environment of this organisation. Generally this will be for the benefit of a visitor with a physical or mental disability. May also be used to link a spatial thing (such as a building, airport, campus, bus) to a description of its accessibility.
    /// <see href="http://purl.org/linkingyou/space-accessibility"></see></summary>
    let ``space-accessibility`` =
        Namespaced_IRI.parse _namespace_name "space-accessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/support-depts"></see>
    /// </summary>
    let ``support-depts`` =
        Namespaced_IRI.parse _namespace_name "support-depts" |> NamespacedName

    /// <summary>
    /// [Generally only for UK public sector] A link to the publication scheme for this organisation as described by the UK Information Commissioner's Office. See http://www.ico.org.uk/for_organisations/freedom_of_information/guide/publication_scheme for more information.
    /// <see href="http://purl.org/linkingyou/uk-ico-publication-scheme"></see></summary>
    let ``uk-ico-publication-scheme`` =
        Namespaced_IRI.parse _namespace_name "uk-ico-publication-scheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/uk"></see>
    /// </summary>
    let uk = Namespaced_IRI.parse _namespace_name "uk" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/undergraduate"></see>
    /// </summary>
    let undergraduate =
        Namespaced_IRI.parse _namespace_name "undergraduate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/undergraduate-courses"></see>
    /// </summary>
    let ``undergraduate-courses`` =
        Namespaced_IRI.parse _namespace_name "undergraduate-courses" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/undergraduate-courses-entry-requirements"></see>
    /// </summary>
    let ``undergraduate-courses-entry-requirements`` =
        Namespaced_IRI.parse _namespace_name "undergraduate-courses-entry-requirements" |> NamespacedName

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its undergraduate prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/undergraduate-prospectus"></see></summary>
    let ``undergraduate-prospectus`` =
        Namespaced_IRI.parse _namespace_name "undergraduate-prospectus" |> NamespacedName

    /// <summary>
    /// Links a group or organisation to a document which describes the accessibility policy of the organisation regarding websites and online resources. May also be used to link the homepage of a website to an accessibility document.
    /// <see href="http://purl.org/linkingyou/web-accessibility"></see></summary>
    let ``web-accessibility`` =
        Namespaced_IRI.parse _namespace_name "web-accessibility" |> NamespacedName
