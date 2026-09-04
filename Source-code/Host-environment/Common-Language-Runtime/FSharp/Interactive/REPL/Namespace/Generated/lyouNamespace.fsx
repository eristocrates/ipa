#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lyou =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/linkingyou/" "lyou"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : about page</para>
    ///   <a href="http://purl.org/linkingyou/about">lyou:about</a>
    /// </summary>
    let about = _prefixId.prefix "about"
    /// <summary>
    ///   <para>rdfs:comment : Links a group or organisation to a page about the senior staff, be it Microsoft's senior staff or the committee members of a university club. This was not a linkingyou term.</para>
    ///   <para>rdfs:label : executive page</para>
    ///   <a href="http://purl.org/linkingyou/about-executive">lyou:about-executive</a>
    /// </summary>
    let about_executive = _prefixId.prefix "about-executive"
    /// <summary>
    ///   <para>rdfs:comment : Links a group or organisation to a page about the leader of that organisation. This is modified from the linkingyou 'vc' page to make it work for organistations where the leader is not a Vice Chancellor.</para>
    ///   <para>rdfs:label : leader page</para>
    ///   <a href="http://purl.org/linkingyou/about-leader">lyou:about-leader</a>
    /// </summary>
    let about_leader = _prefixId.prefix "about-leader"
    /// <summary>
    ///   <para>rdfs:label : information for parents page</para>
    ///   <a href="http://purl.org/linkingyou/about-parents">lyou:about-parents</a>
    /// </summary>
    let about_parents = _prefixId.prefix "about-parents"
    /// <summary>
    ///   <para>rdfs:comment : Links a group or organisation to a page about the sites or campuses of that organisation. Was about/campuses in linkingyou, but altered here to be less academic-only.</para>
    ///   <para>rdfs:label : sites page</para>
    ///   <a href="http://purl.org/linkingyou/about-sites">lyou:about-sites</a>
    /// </summary>
    let about_sites = _prefixId.prefix "about-sites"
    /// <summary>
    ///   <para>rdfs:label : strategy page</para>
    ///   <a href="http://purl.org/linkingyou/about-strategy">lyou:about-strategy</a>
    /// </summary>
    let about_strategy = _prefixId.prefix "about-strategy"
    let academia = _prefixId.prefix "academia"
    /// <summary>
    ///   <para>rdfs:label : academic departments page</para>
    ///   <a href="http://purl.org/linkingyou/academic-depts">lyou:academic-depts</a>
    /// </summary>
    let academic_depts = _prefixId.prefix "academic-depts"
    /// <summary>
    ///   <para>rdfs:label : business page</para>
    ///   <a href="http://purl.org/linkingyou/business">lyou:business</a>
    /// </summary>
    let business = _prefixId.prefix "business"
    /// <summary>
    ///   <para>rdfs:label : business incubation page</para>
    ///   <a href="http://purl.org/linkingyou/business-incubation">lyou:business-incubation</a>
    /// </summary>
    let business_incubation = _prefixId.prefix "business-incubation"
    /// <summary>
    ///   <para>rdfs:label : business knowlege transfer partnerships page</para>
    ///   <a href="http://purl.org/linkingyou/business-ktp">lyou:business-ktp</a>
    /// </summary>
    let business_ktp = _prefixId.prefix "business-ktp"
    /// <summary>
    ///   <para>rdfs:label : conference facilities page</para>
    ///   <a href="http://purl.org/linkingyou/conference-facilities">lyou:conference-facilities</a>
    /// </summary>
    let conference_facilities = _prefixId.prefix "conference-facilities"
    /// <summary>
    ///   <para>rdfs:label : conferences page</para>
    ///   <a href="http://purl.org/linkingyou/conferences">lyou:conferences</a>
    /// </summary>
    let conferences = _prefixId.prefix "conferences"
    /// <summary>
    ///   <para>rdfs:label : contact page</para>
    ///   <a href="http://purl.org/linkingyou/contact">lyou:contact</a>
    /// </summary>
    let contact = _prefixId.prefix "contact"
    /// <summary>
    ///   <para>rdfs:label : staff contact page</para>
    ///   <para>rdfs:comment : A page giving contact details for staff in the organisation. Generally this is a searchable phonebook.</para>
    ///   <a href="http://purl.org/linkingyou/contact-staff">lyou:contact-staff</a>
    /// </summary>
    let contact_staff = _prefixId.prefix "contact-staff"
    let core = _prefixId.prefix "core"
    /// <summary>
    ///   <para>rdfs:label : courses page</para>
    ///   <a href="http://purl.org/linkingyou/courses">lyou:courses</a>
    /// </summary>
    let courses = _prefixId.prefix "courses"
    /// <summary>
    ///   <para>rdfs:comment : Links a group or organisation to a document describing its parts. This is not a linkingyou term but was added as the existing terms were only applicable to academia.</para>
    ///   <para>rdfs:label : departments page</para>
    ///   <a href="http://purl.org/linkingyou/depts">lyou:depts</a>
    /// </summary>
    let depts = _prefixId.prefix "depts"
    let education = _prefixId.prefix "education"
    /// <summary>
    ///   <para>rdfs:label : events page</para>
    ///   <a href="http://purl.org/linkingyou/events">lyou:events</a>
    /// </summary>
    let events = _prefixId.prefix "events"
    /// <summary>
    ///   <para>rdfs:label : graduation event page</para>
    ///   <a href="http://purl.org/linkingyou/events-graduation">lyou:events-graduation</a>
    /// </summary>
    let events_graduation = _prefixId.prefix "events-graduation"
    let extended = _prefixId.prefix "extended"
    /// <summary>
    ///   <para>rdfs:label : foundation admissions page</para>
    ///   <a href="http://purl.org/linkingyou/foundation">lyou:foundation</a>
    /// </summary>
    let foundation = _prefixId.prefix "foundation"
    /// <summary>
    ///   <para>rdfs:label : foundation courses page</para>
    ///   <a href="http://purl.org/linkingyou/foundation-courses">lyou:foundation-courses</a>
    /// </summary>
    let foundation_courses = _prefixId.prefix "foundation-courses"

    /// <summary>
    ///   <para>rdfs:label : foundation courses entry requirements page</para>
    ///   <a href="http://purl.org/linkingyou/foundation-courses-entry-requirements">lyou:foundation-courses-entry-requirements</a>
    /// </summary>
    let foundation_courses_entry_requirements =
        _prefixId.prefix "foundation-courses-entry-requirements"

    /// <summary>
    ///   <para>rdfs:comment : Link a university, or other degree awarding organisation, to its foundation prospectus. This may be an HTML or PDF document.</para>
    ///   <para>rdfs:label : foundation prospectus page</para>
    ///   <a href="http://purl.org/linkingyou/foundation-prospectus">lyou:foundation-prospectus</a>
    /// </summary>
    let foundation_prospectus = _prefixId.prefix "foundation-prospectus"
    /// <summary>
    ///   <para>rdfs:label : ICT support page</para>
    ///   <a href="http://purl.org/linkingyou/ict-support">lyou:ict-support</a>
    /// </summary>
    let ict_support = _prefixId.prefix "ict-support"
    /// <summary>
    ///   <para>rdfs:label : information for international students page</para>
    ///   <a href="http://purl.org/linkingyou/international-students">lyou:international-students</a>
    /// </summary>
    let international_students = _prefixId.prefix "international-students"
    /// <summary>
    ///   <para>rdfs:label : jobs page</para>
    ///   <a href="http://purl.org/linkingyou/jobs">lyou:jobs</a>
    /// </summary>
    let jobs = _prefixId.prefix "jobs"
    /// <summary>
    ///   <para>rdfs:label : legal page</para>
    ///   <a href="http://purl.org/linkingyou/legal">lyou:legal</a>
    /// </summary>
    let legal = _prefixId.prefix "legal"
    /// <summary>
    ///   <para>rdfs:label : data-protection statement page</para>
    ///   <a href="http://purl.org/linkingyou/legal-data-protection">lyou:legal-data-protection</a>
    /// </summary>
    let legal_data_protection = _prefixId.prefix "legal-data-protection"
    /// <summary>
    ///   <para>rdfs:label : environmental policy page</para>
    ///   <a href="http://purl.org/linkingyou/legal-environment">lyou:legal-environment</a>
    /// </summary>
    let legal_environment = _prefixId.prefix "legal-environment"
    /// <summary>
    ///   <para>rdfs:label : equality policy page</para>
    ///   <a href="http://purl.org/linkingyou/legal-equality">lyou:legal-equality</a>
    /// </summary>
    let legal_equality = _prefixId.prefix "legal-equality"
    /// <summary>
    ///   <para>rdfs:label : ethics policy</para>
    ///   <para>rdfs:comment : Many research organisations have a public ethics policy.</para>
    ///   <a href="http://purl.org/linkingyou/legal-ethics">lyou:legal-ethics</a>
    /// </summary>
    let legal_ethics = _prefixId.prefix "legal-ethics"
    /// <summary>
    ///   <para>rdfs:label : freedom-of-information policy page</para>
    ///   <a href="http://purl.org/linkingyou/legal-foi">lyou:legal-foi</a>
    /// </summary>
    let legal_foi = _prefixId.prefix "legal-foi"
    /// <summary>
    ///   <para>rdfs:label : ICT policy page</para>
    ///   <a href="http://purl.org/linkingyou/legal-ict">lyou:legal-ict</a>
    /// </summary>
    let legal_ict = _prefixId.prefix "legal-ict"
    /// <summary>
    ///   <para>rdfs:label : policies page</para>
    ///   <a href="http://purl.org/linkingyou/legal-policies">lyou:legal-policies</a>
    /// </summary>
    let legal_policies = _prefixId.prefix "legal-policies"
    /// <summary>
    ///   <para>rdfs:label : regulations page</para>
    ///   <a href="http://purl.org/linkingyou/legal-regulations">lyou:legal-regulations</a>
    /// </summary>
    let legal_regulations = _prefixId.prefix "legal-regulations"
    /// <summary>
    ///   <para>rdfs:label : website legal information page</para>
    ///   <a href="http://purl.org/linkingyou/legal-website">lyou:legal-website</a>
    /// </summary>
    let legal_website = _prefixId.prefix "legal-website"
    /// <summary>
    ///   <para>rdfs:label : news page</para>
    ///   <a href="http://purl.org/linkingyou/news">lyou:news</a>
    /// </summary>
    let news = _prefixId.prefix "news"
    /// <summary>
    ///   <para>rdfs:comment : Links a group or organisation to a page (or the homepage of a website) describing open data services from the organisation, eg. http://data.lincoln.ac.uk/</para>
    ///   <para>rdfs:label : open data page</para>
    ///   <a href="http://purl.org/linkingyou/open-data">lyou:open-data</a>
    /// </summary>
    let open_data = _prefixId.prefix "open-data"
    /// <summary>
    ///   <para>rdfs:label : open days page</para>
    ///   <a href="http://purl.org/linkingyou/opendays">lyou:opendays</a>
    /// </summary>
    let opendays = _prefixId.prefix "opendays"
    /// <summary>
    ///   <para>rdfs:comment : covering research and taught postgraduates</para>
    ///   <para>rdfs:label : general postgraduate admissions page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate">lyou:postgraduate</a>
    /// </summary>
    let postgraduate = _prefixId.prefix "postgraduate"
    /// <summary>
    ///   <para>rdfs:label : research postgraduate admissions page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-research">lyou:postgraduate-research</a>
    /// </summary>
    let postgraduate_research = _prefixId.prefix "postgraduate-research"
    /// <summary>
    ///   <para>rdfs:label : research postgraduate courses (or programmes) page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-research-courses">lyou:postgraduate-research-courses</a>
    /// </summary>
    let postgraduate_research_courses = _prefixId.prefix "postgraduate-research-courses"

    /// <summary>
    ///   <para>rdfs:label : research postgraduate entry requirements page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-research-courses-entry-requirements">lyou:postgraduate-research-courses-entry-requirements</a>
    /// </summary>
    let postgraduate_research_courses_entry_requirements =
        _prefixId.prefix "postgraduate-research-courses-entry-requirements"

    /// <summary>
    ///   <para>rdfs:comment : Link a university, or other degree awarding organisation, to its research postgraduate prospectus. This may be an HTML or PDF document.</para>
    ///   <para>rdfs:label : research postgraduate prospectus page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-research-prospectus">lyou:postgraduate-research-prospectus</a>
    /// </summary>
    let postgraduate_research_prospectus =
        _prefixId.prefix "postgraduate-research-prospectus"

    /// <summary>
    ///   <para>rdfs:label : taught postgraduate admissions page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-taught">lyou:postgraduate-taught</a>
    /// </summary>
    let postgraduate_taught = _prefixId.prefix "postgraduate-taught"
    /// <summary>
    ///   <para>rdfs:label : taught postgraduate courses page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-taught-courses">lyou:postgraduate-taught-courses</a>
    /// </summary>
    let postgraduate_taught_courses = _prefixId.prefix "postgraduate-taught-courses"

    /// <summary>
    ///   <para>rdfs:label : taught postgraduate entry requirements page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-taught-courses-entry-requirements">lyou:postgraduate-taught-courses-entry-requirements</a>
    /// </summary>
    let postgraduate_taught_courses_entry_requirements =
        _prefixId.prefix "postgraduate-taught-courses-entry-requirements"

    /// <summary>
    ///   <para>rdfs:comment : Link a university, or other degree awarding organisation, to its taught postgraduate prospectus. This may be an HTML or PDF document.</para>
    ///   <para>rdfs:label : taught postgraduate prospectus page</para>
    ///   <a href="http://purl.org/linkingyou/postgraduate-taught-prospectus">lyou:postgraduate-taught-prospectus</a>
    /// </summary>
    let postgraduate_taught_prospectus =
        _prefixId.prefix "postgraduate-taught-prospectus"

    /// <summary>
    ///   <para>rdfs:label : press page</para>
    ///   <para>rdfs:comment : A page with information specifically aimed at journalists.</para>
    ///   <a href="http://purl.org/linkingyou/press">lyou:press</a>
    /// </summary>
    let press = _prefixId.prefix "press"
    /// <summary>
    ///   <para>rdfs:label : press facts page</para>
    ///   <para>rdfs:comment : A page aimed at the press with a list of useful facts about the organisation.</para>
    ///   <a href="http://purl.org/linkingyou/press-facts">lyou:press-facts</a>
    /// </summary>
    let press_facts = _prefixId.prefix "press-facts"
    /// <summary>
    ///   <para>rdfs:label : public lectures page</para>
    ///   <a href="http://purl.org/linkingyou/public-lectures">lyou:public-lectures</a>
    /// </summary>
    let public_lectures = _prefixId.prefix "public-lectures"
    /// <summary>
    ///   <para>rdfs:label : research page</para>
    ///   <a href="http://purl.org/linkingyou/research">lyou:research</a>
    /// </summary>
    let research = _prefixId.prefix "research"
    /// <summary>
    ///   <para>rdfs:comment : Perhaps this should link to a string with a variable in to indicate how to construct a search?</para>
    ///   <para>rdfs:label : search page</para>
    ///   <a href="http://purl.org/linkingyou/search">lyou:search</a>
    /// </summary>
    let search = _prefixId.prefix "search"
    /// <summary>
    ///   <para>rdfs:comment : Links a group or organisation to a document describing the aspects of the location and environment of this organisation. Generally this will be for the benefit of a visitor with a physical or mental disability. May also be used to link a spatial thing (such as a building, airport, campus, bus) to a description of its accessibility.</para>
    ///   <para>rdfs:label : spatial acessibility</para>
    ///   <a href="http://purl.org/linkingyou/space-accessibility">lyou:space-accessibility</a>
    /// </summary>
    let space_accessibility = _prefixId.prefix "space-accessibility"
    /// <summary>
    ///   <para>rdfs:label : support departments page</para>
    ///   <a href="http://purl.org/linkingyou/support-depts">lyou:support-depts</a>
    /// </summary>
    let support_depts = _prefixId.prefix "support-depts"
    let uk = _prefixId.prefix "uk"
    /// <summary>
    ///   <para>rdfs:comment : [Generally only for UK public sector] A link to the publication scheme for this organisation as described by the UK Information Commissioner's Office. See http://www.ico.org.uk/for_organisations/freedom_of_information/guide/publication_scheme for more information.</para>
    ///   <para>rdfs:label : ICO publication scheme</para>
    ///   <a href="http://purl.org/linkingyou/uk-ico-publication-scheme">lyou:uk-ico-publication-scheme</a>
    /// </summary>
    let uk_ico_publication_scheme = _prefixId.prefix "uk-ico-publication-scheme"
    /// <summary>
    ///   <para>rdfs:label : undergraduate admissions page</para>
    ///   <a href="http://purl.org/linkingyou/undergraduate">lyou:undergraduate</a>
    /// </summary>
    let undergraduate = _prefixId.prefix "undergraduate"
    /// <summary>
    ///   <para>rdfs:label : undergraduate courses page</para>
    ///   <a href="http://purl.org/linkingyou/undergraduate-courses">lyou:undergraduate-courses</a>
    /// </summary>
    let undergraduate_courses = _prefixId.prefix "undergraduate-courses"

    /// <summary>
    ///   <para>rdfs:label : undergraduate courses entry requirements page</para>
    ///   <a href="http://purl.org/linkingyou/undergraduate-courses-entry-requirements">lyou:undergraduate-courses-entry-requirements</a>
    /// </summary>
    let undergraduate_courses_entry_requirements =
        _prefixId.prefix "undergraduate-courses-entry-requirements"

    /// <summary>
    ///   <para>rdfs:comment : Link a university, or other degree awarding organisation, to its undergraduate prospectus. This may be an HTML or PDF document.</para>
    ///   <para>rdfs:label : undergraduate prospectus page</para>
    ///   <a href="http://purl.org/linkingyou/undergraduate-prospectus">lyou:undergraduate-prospectus</a>
    /// </summary>
    let undergraduate_prospectus = _prefixId.prefix "undergraduate-prospectus"
    /// <summary>
    ///   <para>rdfs:comment : Links a group or organisation to a document which describes the accessibility policy of the organisation regarding websites and online resources. May also be used to link the homepage of a website to an accessibility document.</para>
    ///   <para>rdfs:label : web accessibility</para>
    ///   <a href="http://purl.org/linkingyou/web-accessibility">lyou:web-accessibility</a>
    /// </summary>
    let web_accessibility = _prefixId.prefix "web-accessibility"
