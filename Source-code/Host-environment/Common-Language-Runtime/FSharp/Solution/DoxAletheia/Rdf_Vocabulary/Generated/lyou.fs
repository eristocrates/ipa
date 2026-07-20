namespace http.purl.org.linkingyou.slash

open DoxAletheia

module lyou =
    let _namespace_name = "http://purl.org/linkingyou/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/about"></see>
    /// </summary>
    let about = _prefix "about"
    /// <summary>
    /// This is used to identify which predicates represent a simple core of Linking You
    /// <see href="http://purl.org/linkingyou/core"></see></summary>
    let core = _prefix "core"
    /// <summary>
    /// Links a group or organisation to a page about the senior staff, be it Microsoft's senior staff or the committee members of a university club. This was not a linkingyou term.
    /// <see href="http://purl.org/linkingyou/about-executive"></see></summary>
    let ``about-executive`` = _prefix "about-executive"
    /// <summary>
    /// Predicates only useful to UK organisations
    /// This is used to identify which predicates are outside the the core terms. Still useful but listed in a second section.
    /// <see href="http://purl.org/linkingyou/extended"></see></summary>
    let extended = _prefix "extended"
    /// <summary>
    /// Links a group or organisation to a page about the leader of that organisation. This is modified from the linkingyou 'vc' page to make it work for organistations where the leader is not a Vice Chancellor.
    /// <see href="http://purl.org/linkingyou/about-leader"></see></summary>
    let ``about-leader`` = _prefix "about-leader"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/about-parents"></see>
    /// </summary>
    let ``about-parents`` = _prefix "about-parents"
    /// <summary>
    /// This is used to identify which predicates are related to education so they can be listed separately in the documentation.
    /// <see href="http://purl.org/linkingyou/education"></see></summary>
    let education = _prefix "education"
    /// <summary>
    /// Links a group or organisation to a page about the sites or campuses of that organisation. Was about/campuses in linkingyou, but altered here to be less academic-only.
    /// <see href="http://purl.org/linkingyou/about-sites"></see></summary>
    let ``about-sites`` = _prefix "about-sites"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/about-strategy"></see>
    /// </summary>
    let ``about-strategy`` = _prefix "about-strategy"
    /// <summary>
    /// This is used to identify which predicates are related to academia (other than education) so they can be listed separately in the documentation.
    /// <see href="http://purl.org/linkingyou/academia"></see></summary>
    let academia = _prefix "academia"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/academic-depts"></see>
    /// </summary>
    let ``academic-depts`` = _prefix "academic-depts"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/business"></see>
    /// </summary>
    let business = _prefix "business"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/business-incubation"></see>
    /// </summary>
    let ``business-incubation`` = _prefix "business-incubation"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/business-ktp"></see>
    /// </summary>
    let ``business-ktp`` = _prefix "business-ktp"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/conference-facilities"></see>
    /// </summary>
    let ``conference-facilities`` = _prefix "conference-facilities"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/conferences"></see>
    /// </summary>
    let conferences = _prefix "conferences"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/contact"></see>
    /// </summary>
    let contact = _prefix "contact"
    /// <summary>
    /// A page giving contact details for staff in the organisation. Generally this is a searchable phonebook.
    /// <see href="http://purl.org/linkingyou/contact-staff"></see></summary>
    let ``contact-staff`` = _prefix "contact-staff"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/courses"></see>
    /// </summary>
    let courses = _prefix "courses"
    /// <summary>
    /// Links a group or organisation to a document describing its parts. This is not a linkingyou term but was added as the existing terms were only applicable to academia.
    /// <see href="http://purl.org/linkingyou/depts"></see></summary>
    let depts = _prefix "depts"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/events"></see>
    /// </summary>
    let events = _prefix "events"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/events-graduation"></see>
    /// </summary>
    let ``events-graduation`` = _prefix "events-graduation"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/foundation"></see>
    /// </summary>
    let foundation = _prefix "foundation"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/foundation-courses"></see>
    /// </summary>
    let ``foundation-courses`` = _prefix "foundation-courses"

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/foundation-courses-entry-requirements"></see>
    /// </summary>
    let ``foundation-courses-entry-requirements`` =
        _prefix "foundation-courses-entry-requirements"

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its foundation prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/foundation-prospectus"></see></summary>
    let ``foundation-prospectus`` = _prefix "foundation-prospectus"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/ict-support"></see>
    /// </summary>
    let ``ict-support`` = _prefix "ict-support"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/international-students"></see>
    /// </summary>
    let ``international-students`` = _prefix "international-students"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/jobs"></see>
    /// </summary>
    let jobs = _prefix "jobs"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal"></see>
    /// </summary>
    let legal = _prefix "legal"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-data-protection"></see>
    /// </summary>
    let ``legal-data-protection`` = _prefix "legal-data-protection"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-environment"></see>
    /// </summary>
    let ``legal-environment`` = _prefix "legal-environment"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-equality"></see>
    /// </summary>
    let ``legal-equality`` = _prefix "legal-equality"
    /// <summary>
    /// Many research organisations have a public ethics policy.
    /// <see href="http://purl.org/linkingyou/legal-ethics"></see></summary>
    let ``legal-ethics`` = _prefix "legal-ethics"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-foi"></see>
    /// </summary>
    let ``legal-foi`` = _prefix "legal-foi"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-ict"></see>
    /// </summary>
    let ``legal-ict`` = _prefix "legal-ict"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-policies"></see>
    /// </summary>
    let ``legal-policies`` = _prefix "legal-policies"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-regulations"></see>
    /// </summary>
    let ``legal-regulations`` = _prefix "legal-regulations"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/legal-website"></see>
    /// </summary>
    let ``legal-website`` = _prefix "legal-website"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/news"></see>
    /// </summary>
    let news = _prefix "news"
    /// <summary>
    /// Links a group or organisation to a page (or the homepage of a website) describing open data services from the organisation, eg. http://data.lincoln.ac.uk/
    /// <see href="http://purl.org/linkingyou/open-data"></see></summary>
    let ``open-data`` = _prefix "open-data"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/opendays"></see>
    /// </summary>
    let opendays = _prefix "opendays"
    /// <summary>
    /// covering research and taught postgraduates
    /// <see href="http://purl.org/linkingyou/postgraduate"></see></summary>
    let postgraduate = _prefix "postgraduate"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-research"></see>
    /// </summary>
    let ``postgraduate-research`` = _prefix "postgraduate-research"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-research-courses"></see>
    /// </summary>
    let ``postgraduate-research-courses`` = _prefix "postgraduate-research-courses"

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-research-courses-entry-requirements"></see>
    /// </summary>
    let ``postgraduate-research-courses-entry-requirements`` =
        _prefix "postgraduate-research-courses-entry-requirements"

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its research postgraduate prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/postgraduate-research-prospectus"></see></summary>
    let ``postgraduate-research-prospectus`` =
        _prefix "postgraduate-research-prospectus"

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-taught"></see>
    /// </summary>
    let ``postgraduate-taught`` = _prefix "postgraduate-taught"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-taught-courses"></see>
    /// </summary>
    let ``postgraduate-taught-courses`` = _prefix "postgraduate-taught-courses"

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/postgraduate-taught-courses-entry-requirements"></see>
    /// </summary>
    let ``postgraduate-taught-courses-entry-requirements`` =
        _prefix "postgraduate-taught-courses-entry-requirements"

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its taught postgraduate prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/postgraduate-taught-prospectus"></see></summary>
    let ``postgraduate-taught-prospectus`` = _prefix "postgraduate-taught-prospectus"
    /// <summary>
    /// A page with information specifically aimed at journalists.
    /// <see href="http://purl.org/linkingyou/press"></see></summary>
    let press = _prefix "press"
    /// <summary>
    /// A page aimed at the press with a list of useful facts about the organisation.
    /// <see href="http://purl.org/linkingyou/press-facts"></see></summary>
    let ``press-facts`` = _prefix "press-facts"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/public-lectures"></see>
    /// </summary>
    let ``public-lectures`` = _prefix "public-lectures"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/research"></see>
    /// </summary>
    let research = _prefix "research"
    /// <summary>
    /// Perhaps this should link to a string with a variable in to indicate how to construct a search?
    /// <see href="http://purl.org/linkingyou/search"></see></summary>
    let search = _prefix "search"
    /// <summary>
    /// Links a group or organisation to a document describing the aspects of the location and environment of this organisation. Generally this will be for the benefit of a visitor with a physical or mental disability. May also be used to link a spatial thing (such as a building, airport, campus, bus) to a description of its accessibility.
    /// <see href="http://purl.org/linkingyou/space-accessibility"></see></summary>
    let ``space-accessibility`` = _prefix "space-accessibility"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/support-depts"></see>
    /// </summary>
    let ``support-depts`` = _prefix "support-depts"
    /// <summary>
    /// [Generally only for UK public sector] A link to the publication scheme for this organisation as described by the UK Information Commissioner's Office. See http://www.ico.org.uk/for_organisations/freedom_of_information/guide/publication_scheme for more information.
    /// <see href="http://purl.org/linkingyou/uk-ico-publication-scheme"></see></summary>
    let ``uk-ico-publication-scheme`` = _prefix "uk-ico-publication-scheme"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/uk"></see>
    /// </summary>
    let uk = _prefix "uk"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/undergraduate"></see>
    /// </summary>
    let undergraduate = _prefix "undergraduate"
    /// <summary>
    ///   <see href="http://purl.org/linkingyou/undergraduate-courses"></see>
    /// </summary>
    let ``undergraduate-courses`` = _prefix "undergraduate-courses"

    /// <summary>
    ///   <see href="http://purl.org/linkingyou/undergraduate-courses-entry-requirements"></see>
    /// </summary>
    let ``undergraduate-courses-entry-requirements`` =
        _prefix "undergraduate-courses-entry-requirements"

    /// <summary>
    /// Link a university, or other degree awarding organisation, to its undergraduate prospectus. This may be an HTML or PDF document.
    /// <see href="http://purl.org/linkingyou/undergraduate-prospectus"></see></summary>
    let ``undergraduate-prospectus`` = _prefix "undergraduate-prospectus"
    /// <summary>
    /// Links a group or organisation to a document which describes the accessibility policy of the organisation regarding websites and online resources. May also be used to link the homepage of a website to an accessibility document.
    /// <see href="http://purl.org/linkingyou/web-accessibility"></see></summary>
    let ``web-accessibility`` = _prefix "web-accessibility"
