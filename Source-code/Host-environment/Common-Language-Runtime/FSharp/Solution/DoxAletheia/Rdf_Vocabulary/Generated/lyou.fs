namespace http.purl.org.linkingyou.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lyou =
    let _namespace_iri = Namespace_Iri lyou |> NamespaceIRI
    /// <summary>
    ///   <para>lyou:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>about page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/about">http://purl.org/linkingyou/about</seealso>
    let about = Prefixed_Name(lyou, "about") |> PrefixedName
    /// <summary>
    ///   <para>lyou:about-executive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links a group or organisation to a page about the senior staff, be it Microsoft's senior staff or the committee members of a university club. This was not a linkingyou term.</para>
    /// labels<para>executive page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/about-executive">http://purl.org/linkingyou/about-executive</seealso>
    let about_executive = Prefixed_Name(lyou, "about-executive") |> PrefixedName
    /// <summary>
    ///   <para>lyou:about-leader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a group or organisation to a page about the leader of that organisation. This is modified from the linkingyou 'vc' page to make it work for organistations where the leader is not a Vice Chancellor.</para>
    /// labels<para>leader page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/about-leader">http://purl.org/linkingyou/about-leader</seealso>
    let about_leader = Prefixed_Name(lyou, "about-leader") |> PrefixedName
    /// <summary>
    ///   <para>lyou:about-parents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>information for parents page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/about-parents">http://purl.org/linkingyou/about-parents</seealso>
    let about_parents = Prefixed_Name(lyou, "about-parents") |> PrefixedName
    /// <summary>
    ///   <para>lyou:about-sites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links a group or organisation to a page about the sites or campuses of that organisation. Was about/campuses in linkingyou, but altered here to be less academic-only.</para>
    /// labels<para>sites page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/about-sites">http://purl.org/linkingyou/about-sites</seealso>
    let about_sites = Prefixed_Name(lyou, "about-sites") |> PrefixedName
    /// <summary>
    ///   <para>lyou:academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>This is used to identify which predicates are related to academia (other than education) so they can be listed separately in the documentation.</para>
    /// labels<para>Academia</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/academia">http://purl.org/linkingyou/academia</seealso>
    let academia = Prefixed_Name(lyou, "academia") |> PrefixedName
    /// <summary>
    ///   <para>lyou:business</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>business page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/business">http://purl.org/linkingyou/business</seealso>
    let business = Prefixed_Name(lyou, "business") |> PrefixedName
    /// <summary>
    ///   <para>lyou:business-incubation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>business incubation page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/business-incubation">http://purl.org/linkingyou/business-incubation</seealso>
    let business_incubation = Prefixed_Name(lyou, "business-incubation") |> PrefixedName

    /// <summary>
    ///   <para>lyou:conference-facilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>conference facilities page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/conference-facilities">http://purl.org/linkingyou/conference-facilities</seealso>
    let conference_facilities =
        Prefixed_Name(lyou, "conference-facilities") |> PrefixedName

    /// <summary>
    ///   <para>lyou:conferences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>conferences page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/conferences">http://purl.org/linkingyou/conferences</seealso>
    let conferences = Prefixed_Name(lyou, "conferences") |> PrefixedName
    /// <summary>
    ///   <para>lyou:contact-staff</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A page giving contact details for staff in the organisation. Generally this is a searchable phonebook.</para>
    /// labels<para>staff contact page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/contact-staff">http://purl.org/linkingyou/contact-staff</seealso>
    let contact_staff = Prefixed_Name(lyou, "contact-staff") |> PrefixedName
    /// <summary>
    ///   <para>lyou:courses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>courses page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/courses">http://purl.org/linkingyou/courses</seealso>
    let courses = Prefixed_Name(lyou, "courses") |> PrefixedName
    /// <summary>
    ///   <para>lyou:depts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links a group or organisation to a document describing its parts. This is not a linkingyou term but was added as the existing terms were only applicable to academia.</para>
    /// labels<para>departments page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/depts">http://purl.org/linkingyou/depts</seealso>
    let depts = Prefixed_Name(lyou, "depts") |> PrefixedName
    /// <summary>
    ///   <para>lyou:foundation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>foundation admissions page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/foundation">http://purl.org/linkingyou/foundation</seealso>
    let foundation = Prefixed_Name(lyou, "foundation") |> PrefixedName
    /// <summary>
    ///   <para>lyou:foundation-courses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>foundation courses page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/foundation-courses">http://purl.org/linkingyou/foundation-courses</seealso>
    let foundation_courses = Prefixed_Name(lyou, "foundation-courses") |> PrefixedName

    /// <summary>
    ///   <para>lyou:foundation-courses-entry-requirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>foundation courses entry requirements page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/foundation-courses-entry-requirements">http://purl.org/linkingyou/foundation-courses-entry-requirements</seealso>
    let foundation_courses_entry_requirements =
        Prefixed_Name(lyou, "foundation-courses-entry-requirements") |> PrefixedName

    /// <summary>
    ///   <para>lyou:foundation-prospectus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Link a university, or other degree awarding organisation, to its foundation prospectus. This may be an HTML or PDF document.</para>
    /// labels<para>foundation prospectus page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/foundation-prospectus">http://purl.org/linkingyou/foundation-prospectus</seealso>
    let foundation_prospectus =
        Prefixed_Name(lyou, "foundation-prospectus") |> PrefixedName

    /// <summary>
    ///   <para>lyou:international-students</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>information for international students page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/international-students">http://purl.org/linkingyou/international-students</seealso>
    let international_students =
        Prefixed_Name(lyou, "international-students") |> PrefixedName

    /// <summary>
    ///   <para>lyou:jobs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>jobs page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/jobs">http://purl.org/linkingyou/jobs</seealso>
    let jobs = Prefixed_Name(lyou, "jobs") |> PrefixedName
    /// <summary>
    ///   <para>lyou:legal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>legal page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal">http://purl.org/linkingyou/legal</seealso>
    let legal = Prefixed_Name(lyou, "legal") |> PrefixedName

    /// <summary>
    ///   <para>lyou:legal-data-protection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>data-protection statement page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-data-protection">http://purl.org/linkingyou/legal-data-protection</seealso>
    let legal_data_protection =
        Prefixed_Name(lyou, "legal-data-protection") |> PrefixedName

    /// <summary>
    ///   <para>lyou:legal-equality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>equality policy page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-equality">http://purl.org/linkingyou/legal-equality</seealso>
    let legal_equality = Prefixed_Name(lyou, "legal-equality") |> PrefixedName
    /// <summary>
    ///   <para>lyou:legal-ethics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Many research organisations have a public ethics policy.</para>
    /// labels<para>ethics policy</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-ethics">http://purl.org/linkingyou/legal-ethics</seealso>
    let legal_ethics = Prefixed_Name(lyou, "legal-ethics") |> PrefixedName
    /// <summary>
    ///   <para>lyou:legal-foi</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>freedom-of-information policy page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-foi">http://purl.org/linkingyou/legal-foi</seealso>
    let legal_foi = Prefixed_Name(lyou, "legal-foi") |> PrefixedName
    /// <summary>
    ///   <para>lyou:legal-website</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>website legal information page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-website">http://purl.org/linkingyou/legal-website</seealso>
    let legal_website = Prefixed_Name(lyou, "legal-website") |> PrefixedName
    /// <summary>
    ///   <para>lyou:news</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>news page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/news">http://purl.org/linkingyou/news</seealso>
    let news = Prefixed_Name(lyou, "news") |> PrefixedName
    /// <summary>
    ///   <para>lyou:open-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links a group or organisation to a page (or the homepage of a website) describing open data services from the organisation, eg. http://data.lincoln.ac.uk/</para>
    /// labels<para>open data page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/open-data">http://purl.org/linkingyou/open-data</seealso>
    let open_data = Prefixed_Name(lyou, "open-data") |> PrefixedName
    /// <summary>
    ///   <para>lyou:postgraduate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>covering research and taught postgraduates</para>
    /// labels<para>general postgraduate admissions page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate">http://purl.org/linkingyou/postgraduate</seealso>
    let postgraduate = Prefixed_Name(lyou, "postgraduate") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-research</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>research postgraduate admissions page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-research">http://purl.org/linkingyou/postgraduate-research</seealso>
    let postgraduate_research =
        Prefixed_Name(lyou, "postgraduate-research") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-research-courses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>research postgraduate courses (or programmes) page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-research-courses">http://purl.org/linkingyou/postgraduate-research-courses</seealso>
    let postgraduate_research_courses =
        Prefixed_Name(lyou, "postgraduate-research-courses") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-research-prospectus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Link a university, or other degree awarding organisation, to its research postgraduate prospectus. This may be an HTML or PDF document.</para>
    /// labels<para>research postgraduate prospectus page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-research-prospectus">http://purl.org/linkingyou/postgraduate-research-prospectus</seealso>
    let postgraduate_research_prospectus =
        Prefixed_Name(lyou, "postgraduate-research-prospectus") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-taught</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>taught postgraduate admissions page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-taught">http://purl.org/linkingyou/postgraduate-taught</seealso>
    let postgraduate_taught = Prefixed_Name(lyou, "postgraduate-taught") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-taught-courses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>taught postgraduate courses page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-taught-courses">http://purl.org/linkingyou/postgraduate-taught-courses</seealso>
    let postgraduate_taught_courses =
        Prefixed_Name(lyou, "postgraduate-taught-courses") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-taught-prospectus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Link a university, or other degree awarding organisation, to its taught postgraduate prospectus. This may be an HTML or PDF document.</para>
    /// labels<para>taught postgraduate prospectus page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-taught-prospectus">http://purl.org/linkingyou/postgraduate-taught-prospectus</seealso>
    let postgraduate_taught_prospectus =
        Prefixed_Name(lyou, "postgraduate-taught-prospectus") |> PrefixedName

    /// <summary>
    ///   <para>lyou:press</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A page with information specifically aimed at journalists.</para>
    /// labels<para>press page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/press">http://purl.org/linkingyou/press</seealso>
    let press = Prefixed_Name(lyou, "press") |> PrefixedName
    /// <summary>
    ///   <para>lyou:press-facts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A page aimed at the press with a list of useful facts about the organisation.</para>
    /// labels<para>press facts page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/press-facts">http://purl.org/linkingyou/press-facts</seealso>
    let press_facts = Prefixed_Name(lyou, "press-facts") |> PrefixedName
    /// <summary>
    ///   <para>lyou:research</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>research page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/research">http://purl.org/linkingyou/research</seealso>
    let research = Prefixed_Name(lyou, "research") |> PrefixedName
    /// <summary>
    ///   <para>lyou:search</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Perhaps this should link to a string with a variable in to indicate how to construct a search?</para>
    /// labels<para>search page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/search">http://purl.org/linkingyou/search</seealso>
    let search = Prefixed_Name(lyou, "search") |> PrefixedName
    /// <summary>
    ///   <para>lyou:space-accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a group or organisation to a document describing the aspects of the location and environment of this organisation. Generally this will be for the benefit of a visitor with a physical or mental disability. May also be used to link a spatial thing (such as a building, airport, campus, bus) to a description of its accessibility.</para>
    /// labels<para>spatial acessibility</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/space-accessibility">http://purl.org/linkingyou/space-accessibility</seealso>
    let space_accessibility = Prefixed_Name(lyou, "space-accessibility") |> PrefixedName

    /// <summary>
    ///   <para>lyou:uk-ico-publication-scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>[Generally only for UK public sector] A link to the publication scheme for this organisation as described by the UK Information Commissioner's Office. See http://www.ico.org.uk/for_organisations/freedom_of_information/guide/publication_scheme for more information.</para>
    /// labels<para>ICO publication scheme</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/uk-ico-publication-scheme">http://purl.org/linkingyou/uk-ico-publication-scheme</seealso>
    let uk_ico_publication_scheme =
        Prefixed_Name(lyou, "uk-ico-publication-scheme") |> PrefixedName

    /// <summary>
    ///   <para>lyou:uk</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linkingyou/uk">http://purl.org/linkingyou/uk</seealso>
    let uk = Prefixed_Name(lyou, "uk") |> PrefixedName
    /// <summary>
    ///   <para>lyou:undergraduate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>undergraduate admissions page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/undergraduate">http://purl.org/linkingyou/undergraduate</seealso>
    let undergraduate = Prefixed_Name(lyou, "undergraduate") |> PrefixedName

    /// <summary>
    ///   <para>lyou:undergraduate-courses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>undergraduate courses page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/undergraduate-courses">http://purl.org/linkingyou/undergraduate-courses</seealso>
    let undergraduate_courses =
        Prefixed_Name(lyou, "undergraduate-courses") |> PrefixedName

    /// <summary>
    ///   <para>lyou:undergraduate-courses-entry-requirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>undergraduate courses entry requirements page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/undergraduate-courses-entry-requirements">http://purl.org/linkingyou/undergraduate-courses-entry-requirements</seealso>
    let undergraduate_courses_entry_requirements =
        Prefixed_Name(lyou, "undergraduate-courses-entry-requirements") |> PrefixedName

    /// <summary>
    ///   <para>lyou:undergraduate-prospectus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Link a university, or other degree awarding organisation, to its undergraduate prospectus. This may be an HTML or PDF document.</para>
    /// labels<para>undergraduate prospectus page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/undergraduate-prospectus">http://purl.org/linkingyou/undergraduate-prospectus</seealso>
    let undergraduate_prospectus =
        Prefixed_Name(lyou, "undergraduate-prospectus") |> PrefixedName

    /// <summary>
    ///   <para>lyou:web-accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a group or organisation to a document which describes the accessibility policy of the organisation regarding websites and online resources. May also be used to link the homepage of a website to an accessibility document.</para>
    /// labels<para>web accessibility</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/web-accessibility">http://purl.org/linkingyou/web-accessibility</seealso>
    let web_accessibility = Prefixed_Name(lyou, "web-accessibility") |> PrefixedName
    /// <summary>
    ///   <para>lyou:core</para>
    /// </summary>
    /// <remarks>
    ///   <para>This is used to identify which predicates represent a simple core of Linking You</para>
    /// labels<para>Core</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/core">http://purl.org/linkingyou/core</seealso>
    let core = Prefixed_Name(lyou, "core") |> PrefixedName
    /// <summary>
    ///   <para>lyou:legal-environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>environmental policy page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-environment">http://purl.org/linkingyou/legal-environment</seealso>
    let legal_environment = Prefixed_Name(lyou, "legal-environment") |> PrefixedName
    /// <summary>
    ///   <para>lyou:legal-ict</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ICT policy page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-ict">http://purl.org/linkingyou/legal-ict</seealso>
    let legal_ict = Prefixed_Name(lyou, "legal-ict") |> PrefixedName
    /// <summary>
    ///   <para>lyou:legal-regulations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>regulations page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-regulations">http://purl.org/linkingyou/legal-regulations</seealso>
    let legal_regulations = Prefixed_Name(lyou, "legal-regulations") |> PrefixedName
    /// <summary>
    ///   <para>lyou:education</para>
    /// </summary>
    /// <remarks>
    ///   <para>This is used to identify which predicates are related to education so they can be listed separately in the documentation.</para>
    /// labels<para>Education</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/education">http://purl.org/linkingyou/education</seealso>
    let education = Prefixed_Name(lyou, "education") |> PrefixedName
    /// <summary>
    ///   <para>lyou:about-strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>strategy page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/about-strategy">http://purl.org/linkingyou/about-strategy</seealso>
    let about_strategy = Prefixed_Name(lyou, "about-strategy") |> PrefixedName
    /// <summary>
    ///   <para>lyou:academic-depts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>academic departments page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/academic-depts">http://purl.org/linkingyou/academic-depts</seealso>
    let academic_depts = Prefixed_Name(lyou, "academic-depts") |> PrefixedName
    /// <summary>
    ///   <para>lyou:business-ktp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>business knowlege transfer partnerships page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/business-ktp">http://purl.org/linkingyou/business-ktp</seealso>
    let business_ktp = Prefixed_Name(lyou, "business-ktp") |> PrefixedName
    /// <summary>
    ///   <para>lyou:opendays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>open days page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/opendays">http://purl.org/linkingyou/opendays</seealso>
    let opendays = Prefixed_Name(lyou, "opendays") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-research-courses-entry-requirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>research postgraduate entry requirements page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-research-courses-entry-requirements">http://purl.org/linkingyou/postgraduate-research-courses-entry-requirements</seealso>
    let postgraduate_research_courses_entry_requirements =
        Prefixed_Name(lyou, "postgraduate-research-courses-entry-requirements") |> PrefixedName

    /// <summary>
    ///   <para>lyou:legal-policies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>policies page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/legal-policies">http://purl.org/linkingyou/legal-policies</seealso>
    let legal_policies = Prefixed_Name(lyou, "legal-policies") |> PrefixedName
    /// <summary>
    ///   <para>lyou:contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>contact page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/contact">http://purl.org/linkingyou/contact</seealso>
    let contact = Prefixed_Name(lyou, "contact") |> PrefixedName

    /// <summary>
    ///   <para>lyou:postgraduate-taught-courses-entry-requirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>taught postgraduate entry requirements page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/postgraduate-taught-courses-entry-requirements">http://purl.org/linkingyou/postgraduate-taught-courses-entry-requirements</seealso>
    let postgraduate_taught_courses_entry_requirements =
        Prefixed_Name(lyou, "postgraduate-taught-courses-entry-requirements") |> PrefixedName

    /// <summary>
    ///   <para>lyou:public-lectures</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>public lectures page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/public-lectures">http://purl.org/linkingyou/public-lectures</seealso>
    let public_lectures = Prefixed_Name(lyou, "public-lectures") |> PrefixedName
    /// <summary>
    ///   <para>lyou:support-depts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>support departments page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/support-depts">http://purl.org/linkingyou/support-depts</seealso>
    let support_depts = Prefixed_Name(lyou, "support-depts") |> PrefixedName
    /// <summary>
    ///   <para>lyou:events</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>events page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/events">http://purl.org/linkingyou/events</seealso>
    let events = Prefixed_Name(lyou, "events") |> PrefixedName
    /// <summary>
    ///   <para>lyou:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linkingyou/">http://purl.org/linkingyou/</seealso>
    let _prefix_iri = Prefixed_Name(lyou, "") |> PrefixedName
    /// <summary>
    ///   <para>lyou:extended</para>
    /// </summary>
    /// <remarks>
    ///   <para>This is used to identify which predicates are outside the the core terms. Still useful but listed in a second section.</para>
    ///   <para>Predicates only useful to UK organisations</para>
    /// labels<para>Extended Terms</para><para>UK</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/extended">http://purl.org/linkingyou/extended</seealso>
    let extended = Prefixed_Name(lyou, "extended") |> PrefixedName
    /// <summary>
    ///   <para>lyou:events-graduation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>graduation event page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/events-graduation">http://purl.org/linkingyou/events-graduation</seealso>
    let events_graduation = Prefixed_Name(lyou, "events-graduation") |> PrefixedName
    /// <summary>
    ///   <para>lyou:ict-support</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ICT support page</para></remarks>
    /// <seealso href="http://purl.org/linkingyou/ict-support">http://purl.org/linkingyou/ict-support</seealso>
    let ict_support = Prefixed_Name(lyou, "ict-support") |> PrefixedName
