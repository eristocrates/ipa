namespace http.www.aktors.org.ontology.portal.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module akt =
    let _namespace_iri = Namespace_Iri akt |> NamespaceIRI
    /// <summary>
    ///   <para>akt:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>HPKB says that genders are intangible..Uhm...</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Gender">http://www.aktors.org/ontology/portal#Gender</seealso>
    let Gender = Prefixed_Name(akt, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>akt:Full-Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Work-Status</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Full-Time">http://www.aktors.org/ontology/portal#Full-Time</seealso>
    let Full_Time = Prefixed_Name(akt, "Full-Time") |> PrefixedName
    /// <summary>
    ///   <para>akt:Work-Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Work-Status">http://www.aktors.org/ontology/portal#Work-Status</seealso>
    let Work_Status = Prefixed_Name(akt, "Work-Status") |> PrefixedName
    /// <summary>
    ///   <para>akt:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic class for locations.  It includes both real and fantastic places</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Location">http://www.aktors.org/ontology/portal#Location</seealso>
    let Location = Prefixed_Name(akt, "Location") |> PrefixedName

    /// <summary>
    ///   <para>akt:Information-Transfer-Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generalized transfer in which information is passed from main agent to one or more recipient agents.  Examples include giving a tutorial.</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Information-Transfer-Event">http://www.aktors.org/ontology/portal#Information-Transfer-Event</seealso>
    let Information_Transfer_Event =
        Prefixed_Name(akt, "Information-Transfer-Event") |> PrefixedName

    /// <summary>
    ///   <para>akt:Government</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Government">http://www.aktors.org/ontology/portal#Government</seealso>
    let Government = Prefixed_Name(akt, "Government") |> PrefixedName
    /// <summary>
    ///   <para>akt:Hardware-Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Hardware-Technology">http://www.aktors.org/ontology/portal#Hardware-Technology</seealso>
    let Hardware_Technology = Prefixed_Name(akt, "Hardware-Technology") |> PrefixedName

    /// <summary>
    ///   <para>akt:Human-Computer-Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Human-Computer-Interaction">http://www.aktors.org/ontology/portal#Human-Computer-Interaction</seealso>
    let Human_Computer_Interaction =
        Prefixed_Name(akt, "Human-Computer-Interaction") |> PrefixedName

    /// <summary>
    ///   <para>akt:Industrial-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Industrial-Organization">http://www.aktors.org/ontology/portal#Industrial-Organization</seealso>
    let Industrial_Organization =
        Prefixed_Name(akt, "Industrial-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-author">http://www.aktors.org/ontology/portal#has-author</seealso>
    let has_author = Prefixed_Name(akt, "has-author") |> PrefixedName

    /// <summary>
    ///   <para>akt:Information-Extraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Information-Extraction">http://www.aktors.org/ontology/portal#Information-Extraction</seealso>
    let Information_Extraction =
        Prefixed_Name(akt, "Information-Extraction") |> PrefixedName

    /// <summary>
    ///   <para>akt:Information-Retrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Information-Retrieval">http://www.aktors.org/ontology/portal#Information-Retrieval</seealso>
    let Information_Retrieval =
        Prefixed_Name(akt, "Information-Retrieval") |> PrefixedName

    /// <summary>
    ///   <para>akt:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Journal">http://www.aktors.org/ontology/portal#Journal</seealso>
    let Journal = Prefixed_Name(akt, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>akt:Knowledge-Lifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Lifecycle">http://www.aktors.org/ontology/portal#Knowledge-Lifecycle</seealso>
    let Knowledge_Lifecycle = Prefixed_Name(akt, "Knowledge-Lifecycle") |> PrefixedName

    /// <summary>
    ///   <para>akt:Knowledge-Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Maintenance">http://www.aktors.org/ontology/portal#Knowledge-Maintenance</seealso>
    let Knowledge_Maintenance =
        Prefixed_Name(akt, "Knowledge-Maintenance") |> PrefixedName

    /// <summary>
    ///   <para>akt:Knowledge-Modelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Modelling">http://www.aktors.org/ontology/portal#Knowledge-Modelling</seealso>
    let Knowledge_Modelling = Prefixed_Name(akt, "Knowledge-Modelling") |> PrefixedName

    /// <summary>
    ///   <para>akt:Knowledge-Publishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Publishing">http://www.aktors.org/ontology/portal#Knowledge-Publishing</seealso>
    let Knowledge_Publishing =
        Prefixed_Name(akt, "Knowledge-Publishing") |> PrefixedName

    /// <summary>
    ///   <para>akt:Letter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Letter">http://www.aktors.org/ontology/portal#Letter</seealso>
    let Letter = Prefixed_Name(akt, "Letter") |> PrefixedName
    /// <summary>
    ///   <para>akt:Local-District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Local-District">http://www.aktors.org/ontology/portal#Local-District</seealso>
    let Local_District = Prefixed_Name(akt, "Local-District") |> PrefixedName
    /// <summary>
    ///   <para>akt:Social-Gathering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Social-Gathering">http://www.aktors.org/ontology/portal#Social-Gathering</seealso>
    let Social_Gathering = Prefixed_Name(akt, "Social-Gathering") |> PrefixedName
    /// <summary>
    ///   <para>akt:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Merrian-Webster has a good set of definitions for a method. They say it is 'a systematic procedure, technique, or mode of inquiry employed by or proper to a particular discipline or art;  a systematic plan followed in presenting material for instruction; a way, technique, or process of or for doing something; a body of skills or techniques'. This is very much also what we mean by method.</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Method">http://www.aktors.org/ontology/portal#Method</seealso>
    let Method = Prefixed_Name(akt, "Method") |> PrefixedName
    /// <summary>
    ///   <para>akt:Miss</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Miss">http://www.aktors.org/ontology/portal#Miss</seealso>
    let Miss = Prefixed_Name(akt, "Miss") |> PrefixedName
    /// <summary>
    ///   <para>akt:Mr</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Mr">http://www.aktors.org/ontology/portal#Mr</seealso>
    let Mr = Prefixed_Name(akt, "Mr") |> PrefixedName
    /// <summary>
    ///   <para>akt:Mrs</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Mrs">http://www.aktors.org/ontology/portal#Mrs</seealso>
    let Mrs = Prefixed_Name(akt, "Mrs") |> PrefixedName
    /// <summary>
    ///   <para>akt:News-Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#News-Item">http://www.aktors.org/ontology/portal#News-Item</seealso>
    let News_Item = Prefixed_Name(akt, "News-Item") |> PrefixedName
    /// <summary>
    ///   <para>akt:contains-news-item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#contains-news-item">http://www.aktors.org/ontology/portal#contains-news-item</seealso>
    let contains_news_item = Prefixed_Name(akt, "contains-news-item") |> PrefixedName

    /// <summary>
    ///   <para>akt:Periodical-Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This comes from the ontolingua library. A periodical-publication is published regularly, such as once every week.  Strictly speaking, the noun 'periodical' is used by librarians to refer to things published at intervals of greater than a day.  We use the phase periodical-publication to include newspapers and other daily publications, since they share many bibliographic features. The periodicity indicates how often the publication comes out. Note that this is a duration, rather than a time interval. A time interval indicates a specific time interval on the time continuum, so we need to model periodicity as a time quantity</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Periodical-Publication">http://www.aktors.org/ontology/portal#Periodical-Publication</seealso>
    let Periodical_Publication =
        Prefixed_Name(akt, "Periodical-Publication") |> PrefixedName

    /// <summary>
    ///   <para>akt:Operating-System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Operating-System">http://www.aktors.org/ontology/portal#Operating-System</seealso>
    let Operating_System = Prefixed_Name(akt, "Operating-System") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-size">http://www.aktors.org/ontology/portal#has-size</seealso>
    let has_size = Prefixed_Name(akt, "has-size") |> PrefixedName
    /// <summary>
    ///   <para>akt:headed-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#headed-by">http://www.aktors.org/ontology/portal#headed-by</seealso>
    let headed_by = Prefixed_Name(akt, "headed-by") |> PrefixedName
    /// <summary>
    ///   <para>akt:very-large-size</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Organization-Size</para>
    ///   <para>An organization with over 10000 employees</para>
    /// labels<para>very large</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#very-large-size">http://www.aktors.org/ontology/portal#very-large-size</seealso>
    let very_large_size = Prefixed_Name(akt, "very-large-size") |> PrefixedName
    /// <summary>
    ///   <para>akt:large-size</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Organization-Size</para>
    ///   <para>An organization with more than 250 employees</para>
    /// labels<para>large</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#large-size">http://www.aktors.org/ontology/portal#large-size</seealso>
    let large_size = Prefixed_Name(akt, "large-size") |> PrefixedName
    /// <summary>
    ///   <para>akt:medium-size</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Organization-Size</para>
    ///   <para>An organization with no more than 250 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of medium-sized enterprise. Finally, either the turnover total must be less than 40M Euros or the balance sheet total must be less than 27M Euros.</para>
    /// labels<para>medium</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#medium-size">http://www.aktors.org/ontology/portal#medium-size</seealso>
    let medium_size = Prefixed_Name(akt, "medium-size") |> PrefixedName

    /// <summary>
    ///   <para>akt:Organizational-Learning</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Organizational-Learning">http://www.aktors.org/ontology/portal#Organizational-Learning</seealso>
    let Organizational_Learning =
        Prefixed_Name(akt, "Organizational-Learning") |> PrefixedName

    /// <summary>
    ///   <para>akt:Part-Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Work-Status</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Part-Time">http://www.aktors.org/ontology/portal#Part-Time</seealso>
    let Part_Time = Prefixed_Name(akt, "Part-Time") |> PrefixedName
    /// <summary>
    ///   <para>akt:Partnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A partnership is not necessarily a company, e.g. a consultancy firm is not a company</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Partnership">http://www.aktors.org/ontology/portal#Partnership</seealso>
    let Partnership = Prefixed_Name(akt, "Partnership") |> PrefixedName
    /// <summary>
    ///   <para>akt:PhD-Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#PhD-Student">http://www.aktors.org/ontology/portal#PhD-Student</seealso>
    let PhD_Student = Prefixed_Name(akt, "PhD-Student") |> PrefixedName
    /// <summary>
    ///   <para>akt:studies-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#studies-at">http://www.aktors.org/ontology/portal#studies-at</seealso>
    let studies_at = Prefixed_Name(akt, "studies-at") |> PrefixedName
    /// <summary>
    ///   <para>akt:Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Student">http://www.aktors.org/ontology/portal#Student</seealso>
    let Student = Prefixed_Name(akt, "Student") |> PrefixedName

    /// <summary>
    ///   <para>akt:Political-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization which has a political connotation</para>
    /// labels<para>Political Organization</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Political-Organization">http://www.aktors.org/ontology/portal#Political-Organization</seealso>
    let Political_Organization =
        Prefixed_Name(akt, "Political-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Postal-Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Modified to allow addresses to be given as strings, with no structure</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Postal-Address">http://www.aktors.org/ontology/portal#Postal-Address</seealso>
    let Postal_Address = Prefixed_Name(akt, "Postal-Address") |> PrefixedName

    /// <summary>
    ///   <para>akt:Proceedings-Paper-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Proceedings-Paper-Reference">http://www.aktors.org/ontology/portal#Proceedings-Paper-Reference</seealso>
    let Proceedings_Paper_Reference =
        Prefixed_Name(akt, "Proceedings-Paper-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:Prof</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Prof">http://www.aktors.org/ontology/portal#Prof</seealso>
    let Prof = Prefixed_Name(akt, "Prof") |> PrefixedName

    /// <summary>
    ///   <para>akt:Professor-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Professor-In-Academia">http://www.aktors.org/ontology/portal#Professor-In-Academia</seealso>
    let Professor_In_Academia =
        Prefixed_Name(akt, "Professor-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:Programming-Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Programming-Environment">http://www.aktors.org/ontology/portal#Programming-Environment</seealso>
    let Programming_Environment =
        Prefixed_Name(akt, "Programming-Environment") |> PrefixedName

    /// <summary>
    ///   <para>akt:Programming-Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Programming-Language">http://www.aktors.org/ontology/portal#Programming-Language</seealso>
    let Programming_Language =
        Prefixed_Name(akt, "Programming-Language") |> PrefixedName

    /// <summary>
    ///   <para>akt:supports-language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#supports-language">http://www.aktors.org/ontology/portal#supports-language</seealso>
    let supports_language = Prefixed_Name(akt, "supports-language") |> PrefixedName

    /// <summary>
    ///   <para>akt:Specification-Or-Computing-Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Specification-Or-Computing-Language">http://www.aktors.org/ontology/portal#Specification-Or-Computing-Language</seealso>
    let Specification_Or_Computing_Language =
        Prefixed_Name(akt, "Specification-Or-Computing-Language") |> PrefixedName

    /// <summary>
    ///   <para>akt:Public-Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Public-Company">http://www.aktors.org/ontology/portal#Public-Company</seealso>
    let Public_Company = Prefixed_Name(akt, "Public-Company") |> PrefixedName

    /// <summary>
    ///   <para>akt:cites-publication-reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#cites-publication-reference">http://www.aktors.org/ontology/portal#cites-publication-reference</seealso>
    let cites_publication_reference =
        Prefixed_Name(akt, "cites-publication-reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-date">http://www.aktors.org/ontology/portal#has-date</seealso>
    let has_date = Prefixed_Name(akt, "has-date") |> PrefixedName
    /// <summary>
    ///   <para>akt:event-product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#event-product">http://www.aktors.org/ontology/portal#event-product</seealso>
    let event_product = Prefixed_Name(akt, "event-product") |> PrefixedName
    /// <summary>
    ///   <para>akt:R-And-D-Institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#R-And-D-Institute">http://www.aktors.org/ontology/portal#R-And-D-Institute</seealso>
    let R_And_D_Institute = Prefixed_Name(akt, "R-And-D-Institute") |> PrefixedName

    /// <summary>
    ///   <para>akt:R-And-D-Institute-Within-Larger-Institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#R-And-D-Institute-Within-Larger-Institute">http://www.aktors.org/ontology/portal#R-And-D-Institute-Within-Larger-Institute</seealso>
    let R_And_D_Institute_Within_Larger_Institute =
        Prefixed_Name(akt, "R-And-D-Institute-Within-Larger-Institute") |> PrefixedName

    /// <summary>
    ///   <para>akt:Reader-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Reader-In-Academia">http://www.aktors.org/ontology/portal#Reader-In-Academia</seealso>
    let Reader_In_Academia = Prefixed_Name(akt, "Reader-In-Academia") |> PrefixedName
    /// <summary>
    ///   <para>akt:Recorded-Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any kind of recorded video, which is tangible.  This also includes a mpeg file on a machine</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Recorded-Video">http://www.aktors.org/ontology/portal#Recorded-Video</seealso>
    let Recorded_Video = Prefixed_Name(akt, "Recorded-Video") |> PrefixedName
    /// <summary>
    ///   <para>akt:Released-Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Software-Status</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Released-Version">http://www.aktors.org/ontology/portal#Released-Version</seealso>
    let Released_Version = Prefixed_Name(akt, "Released-Version") |> PrefixedName

    /// <summary>
    ///   <para>akt:Research-Assistant-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Research-Assistant-In-Academia">http://www.aktors.org/ontology/portal#Research-Assistant-In-Academia</seealso>
    let Research_Assistant_In_Academia =
        Prefixed_Name(akt, "Research-Assistant-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:Researcher-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Researcher-In-Academia">http://www.aktors.org/ontology/portal#Researcher-In-Academia</seealso>
    let Researcher_In_Academia =
        Prefixed_Name(akt, "Researcher-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:Research-Fellow-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Research-Fellow-In-Academia">http://www.aktors.org/ontology/portal#Research-Fellow-In-Academia</seealso>
    let Research_Fellow_In_Academia =
        Prefixed_Name(akt, "Research-Fellow-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:Scripting-Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Scripting-Language">http://www.aktors.org/ontology/portal#Scripting-Language</seealso>
    let Scripting_Language = Prefixed_Name(akt, "Scripting-Language") |> PrefixedName
    /// <summary>
    ///   <para>akt:Secretary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Secretary">http://www.aktors.org/ontology/portal#Secretary</seealso>
    let Secretary = Prefixed_Name(akt, "Secretary") |> PrefixedName

    /// <summary>
    ///   <para>akt:Self-Employed-Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Self-Employed-Person">http://www.aktors.org/ontology/portal#Self-Employed-Person</seealso>
    let Self_Employed_Person =
        Prefixed_Name(akt, "Self-Employed-Person") |> PrefixedName

    /// <summary>
    ///   <para>akt:Semantic-Web-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Semantic-Web-Area">http://www.aktors.org/ontology/portal#Semantic-Web-Area</seealso>
    let Semantic_Web_Area = Prefixed_Name(akt, "Semantic-Web-Area") |> PrefixedName
    /// <summary>
    ///   <para>akt:Web-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Web-Research-Area">http://www.aktors.org/ontology/portal#Web-Research-Area</seealso>
    let Web_Research_Area = Prefixed_Name(akt, "Web-Research-Area") |> PrefixedName
    /// <summary>
    ///   <para>akt:Sending-An-Email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a generalized transfer in which information is passed from main agent to one or more recipient agents.  examples include giving a tutorial.</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Sending-An-Email">http://www.aktors.org/ontology/portal#Sending-An-Email</seealso>
    let Sending_An_Email = Prefixed_Name(akt, "Sending-An-Email") |> PrefixedName

    /// <summary>
    ///   <para>akt:information-transfer-medium-used</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#information-transfer-medium-used">http://www.aktors.org/ontology/portal#information-transfer-medium-used</seealso>
    let information_transfer_medium_used =
        Prefixed_Name(akt, "information-transfer-medium-used") |> PrefixedName

    /// <summary>
    ///   <para>akt:information-object-being-transferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#information-object-being-transferred">http://www.aktors.org/ontology/portal#information-object-being-transferred</seealso>
    let information_object_being_transferred =
        Prefixed_Name(akt, "information-object-being-transferred") |> PrefixedName

    /// <summary>
    ///   <para>akt:Senior-Lecturer-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Senior-Lecturer-In-Academia">http://www.aktors.org/ontology/portal#Senior-Lecturer-In-Academia</seealso>
    let Senior_Lecturer_In_Academia =
        Prefixed_Name(akt, "Senior-Lecturer-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:Senior-Research-Fellow-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Senior-Research-Fellow-In-Academia">http://www.aktors.org/ontology/portal#Senior-Research-Fellow-In-Academia</seealso>
    let Senior_Research_Fellow_In_Academia =
        Prefixed_Name(akt, "Senior-Research-Fellow-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:location-at-start</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#location-at-start">http://www.aktors.org/ontology/portal#location-at-start</seealso>
    let location_at_start = Prefixed_Name(akt, "location-at-start") |> PrefixedName
    /// <summary>
    ///   <para>akt:Financial-Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Financial-Award">http://www.aktors.org/ontology/portal#Financial-Award</seealso>
    let Financial_Award = Prefixed_Name(akt, "Financial-Award") |> PrefixedName

    /// <summary>
    ///   <para>akt:Generalised-Means-Of-Transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a generic class to catch all sorts of borderline and metaphorical ways to carry things from A to B</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Generalised-Means-Of-Transport">http://www.aktors.org/ontology/portal#Generalised-Means-Of-Transport</seealso>
    let Generalised_Means_Of_Transport =
        Prefixed_Name(akt, "Generalised-Means-Of-Transport") |> PrefixedName

    /// <summary>
    ///   <para>akt:Generic-Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a generic notion, an agent can be an organization, a person an animal, a software agent, etc</para>
    /// labels<para>Generic Agent</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Generic-Agent">http://www.aktors.org/ontology/portal#Generic-Agent</seealso>
    let Generic_Agent = Prefixed_Name(akt, "Generic-Agent") |> PrefixedName
    /// <summary>
    ///   <para>akt:Geographical-Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'Real' geographical regions</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Geographical-Region">http://www.aktors.org/ontology/portal#Geographical-Region</seealso>
    let Geographical_Region = Prefixed_Name(akt, "Geographical-Region") |> PrefixedName
    /// <summary>
    ///   <para>akt:Giving-A-Talk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Giving-A-Talk">http://www.aktors.org/ontology/portal#Giving-A-Talk</seealso>
    let Giving_A_Talk = Prefixed_Name(akt, "Giving-A-Talk") |> PrefixedName
    /// <summary>
    ///   <para>akt:issued-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#issued-by">http://www.aktors.org/ontology/portal#issued-by</seealso>
    let issued_by = Prefixed_Name(akt, "issued-by") |> PrefixedName
    /// <summary>
    ///   <para>akt:meeting-organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#meeting-organizer">http://www.aktors.org/ontology/portal#meeting-organizer</seealso>
    let meeting_organizer = Prefixed_Name(akt, "meeting-organizer") |> PrefixedName
    /// <summary>
    ///   <para>akt:method-builds-on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#method-builds-on">http://www.aktors.org/ontology/portal#method-builds-on</seealso>
    let method_builds_on = Prefixed_Name(akt, "method-builds-on") |> PrefixedName

    /// <summary>
    ///   <para>akt:organization-unit-being-visited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#organization-unit-being-visited">http://www.aktors.org/ontology/portal#organization-unit-being-visited</seealso>
    let organization_unit_being_visited =
        Prefixed_Name(akt, "organization-unit-being-visited") |> PrefixedName

    /// <summary>
    ///   <para>akt:project-involves-organization-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It is sufficient that somebody in unit ?u works in project ?p</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#project-involves-organization-unit">http://www.aktors.org/ontology/portal#project-involves-organization-unit</seealso>
    let project_involves_organization_unit =
        Prefixed_Name(akt, "project-involves-organization-unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:requires-hardware-platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#requires-hardware-platform">http://www.aktors.org/ontology/portal#requires-hardware-platform</seealso>
    let requires_hardware_platform =
        Prefixed_Name(akt, "requires-hardware-platform") |> PrefixedName

    /// <summary>
    ///   <para>akt:requires-hardware-platform-on-client-side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#requires-hardware-platform-on-client-side">http://www.aktors.org/ontology/portal#requires-hardware-platform-on-client-side</seealso>
    let requires_hardware_platform_on_client_side =
        Prefixed_Name(akt, "requires-hardware-platform-on-client-side") |> PrefixedName

    /// <summary>
    ///   <para>akt:Educational-Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Educational-Employee">http://www.aktors.org/ontology/portal#Educational-Employee</seealso>
    let Educational_Employee =
        Prefixed_Name(akt, "Educational-Employee") |> PrefixedName

    /// <summary>
    ///   <para>akt:Educational-Organization-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Educational-Organization-Unit">http://www.aktors.org/ontology/portal#Educational-Organization-Unit</seealso>
    let Educational_Organization_Unit =
        Prefixed_Name(akt, "Educational-Organization-Unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:Adaptive-Hypermedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Adaptive-Hypermedia">http://www.aktors.org/ontology/portal#Adaptive-Hypermedia</seealso>
    let Adaptive_Hypermedia = Prefixed_Name(akt, "Adaptive-Hypermedia") |> PrefixedName
    /// <summary>
    ///   <para>akt:Affiliated-Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person which has an affiliation with some organization. For instance employees are affiliated to the organization they work for, students to the institution where they are studying, etc. A person can have multiple affiliations, which means that there is no constraint relating the values of slot has-affiliation-to-unit to the values of slot has-affiliation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Affiliated-Person">http://www.aktors.org/ontology/portal#Affiliated-Person</seealso>
    let Affiliated_Person = Prefixed_Name(akt, "Affiliated-Person") |> PrefixedName
    /// <summary>
    ///   <para>akt:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Person">http://www.aktors.org/ontology/portal#Person</seealso>
    let Person = Prefixed_Name(akt, "Person") |> PrefixedName

    /// <summary>
    ///   <para>akt:Agent-Based-Computing</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Agent-Based-Computing">http://www.aktors.org/ontology/portal#Agent-Based-Computing</seealso>
    let Agent_Based_Computing =
        Prefixed_Name(akt, "Agent-Based-Computing") |> PrefixedName

    /// <summary>
    ///   <para>akt:Article-In-A-Composite-Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Article-In-A-Composite-Publication">http://www.aktors.org/ontology/portal#Article-In-A-Composite-Publication</seealso>
    let Article_In_A_Composite_Publication =
        Prefixed_Name(akt, "Article-In-A-Composite-Publication") |> PrefixedName

    /// <summary>
    ///   <para>akt:Article-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Article-Reference">http://www.aktors.org/ontology/portal#Article-Reference</seealso>
    let Article_Reference = Prefixed_Name(akt, "Article-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:Publication-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>we have decided that a publication reference is an intangible, abstract information</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Publication-Reference">http://www.aktors.org/ontology/portal#Publication-Reference</seealso>
    let Publication_Reference =
        Prefixed_Name(akt, "Publication-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:event-attended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#event-attended">http://www.aktors.org/ontology/portal#event-attended</seealso>
    let event_attended = Prefixed_Name(akt, "event-attended") |> PrefixedName
    /// <summary>
    ///   <para>akt:Attending-An-Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Attending-An-Event">http://www.aktors.org/ontology/portal#Attending-An-Event</seealso>
    let Attending_An_Event = Prefixed_Name(akt, "Attending-An-Event") |> PrefixedName
    /// <summary>
    ///   <para>akt:Awarding-Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Legal agents can be either organizations or people. An awarding body is normally an organization, an individual, or a bunch of people</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Awarding-Body">http://www.aktors.org/ontology/portal#Awarding-Body</seealso>
    let Awarding_Body = Prefixed_Name(akt, "Awarding-Body") |> PrefixedName
    /// <summary>
    ///   <para>akt:Beta-Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Software-Status</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Beta-Version">http://www.aktors.org/ontology/portal#Beta-Version</seealso>
    let Beta_Version = Prefixed_Name(akt, "Beta-Version") |> PrefixedName
    /// <summary>
    ///   <para>akt:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Book">http://www.aktors.org/ontology/portal#Book</seealso>
    let Book = Prefixed_Name(akt, "Book") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-publication-reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-publication-reference">http://www.aktors.org/ontology/portal#has-publication-reference</seealso>
    let has_publication_reference =
        Prefixed_Name(akt, "has-publication-reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:Small-Or-Medium-Sized-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>SME are important, so we define a class to represent them explicitly. In some case we might not know or we do not want to bother specifying excatly whether something is a small-organization or a medium-organization. Hence, we can just say 'x is a SME' without going into further detail.</para>
    /// labels<para>Small or Medium-sized Organization</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Small-Or-Medium-Sized-Organization">http://www.aktors.org/ontology/portal#Small-Or-Medium-Sized-Organization</seealso>
    let Small_Or_Medium_Sized_Organization =
        Prefixed_Name(akt, "Small-Or-Medium-Sized-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Software-Visualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Software-Visualization">http://www.aktors.org/ontology/portal#Software-Visualization</seealso>
    let Software_Visualization =
        Prefixed_Name(akt, "Software-Visualization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Specification-Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Specification-Language">http://www.aktors.org/ontology/portal#Specification-Language</seealso>
    let Specification_Language =
        Prefixed_Name(akt, "Specification-Language") |> PrefixedName

    /// <summary>
    ///   <para>akt:System-Administrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#System-Administrator">http://www.aktors.org/ontology/portal#System-Administrator</seealso>
    let System_Administrator =
        Prefixed_Name(akt, "System-Administrator") |> PrefixedName

    /// <summary>
    ///   <para>akt:Telepresence-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Telepresence-Research-Area">http://www.aktors.org/ontology/portal#Telepresence-Research-Area</seealso>
    let Telepresence_Research_Area =
        Prefixed_Name(akt, "Telepresence-Research-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:Thesis-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Thesis-Reference">http://www.aktors.org/ontology/portal#Thesis-Reference</seealso>
    let Thesis_Reference = Prefixed_Name(akt, "Thesis-Reference") |> PrefixedName
    /// <summary>
    ///   <para>akt:Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Town">http://www.aktors.org/ontology/portal#Town</seealso>
    let Town = Prefixed_Name(akt, "Town") |> PrefixedName
    /// <summary>
    ///   <para>akt:University-Faculty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#University-Faculty">http://www.aktors.org/ontology/portal#University-Faculty</seealso>
    let University_Faculty = Prefixed_Name(akt, "University-Faculty") |> PrefixedName
    /// <summary>
    ///   <para>akt:Village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Village">http://www.aktors.org/ontology/portal#Village</seealso>
    let Village = Prefixed_Name(akt, "Village") |> PrefixedName
    /// <summary>
    ///   <para>akt:Visiting-Researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Visiting-Researcher">http://www.aktors.org/ontology/portal#Visiting-Researcher</seealso>
    let Visiting_Researcher = Prefixed_Name(akt, "Visiting-Researcher") |> PrefixedName
    /// <summary>
    ///   <para>akt:Web-Based-System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A system which is accessible through the web</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Web-Based-System">http://www.aktors.org/ontology/portal#Web-Based-System</seealso>
    let Web_Based_System = Prefixed_Name(akt, "Web-Based-System") |> PrefixedName
    /// <summary>
    ///   <para>akt:Web-Browser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A web browser is not a web-based system!</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Web-Browser">http://www.aktors.org/ontology/portal#Web-Browser</seealso>
    let Web_Browser = Prefixed_Name(akt, "Web-Browser") |> PrefixedName

    /// <summary>
    ///   <para>akt:Higher-Educational-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Higher-Educational-Organization">http://www.aktors.org/ontology/portal#Higher-Educational-Organization</seealso>
    let Higher_Educational_Organization =
        Prefixed_Name(akt, "Higher-Educational-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Academic-Support-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Academic-Support-Unit">http://www.aktors.org/ontology/portal#Academic-Support-Unit</seealso>
    let Academic_Support_Unit =
        Prefixed_Name(akt, "Academic-Support-Unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:unit-of-organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#unit-of-organization">http://www.aktors.org/ontology/portal#unit-of-organization</seealso>
    let unit_of_organization =
        Prefixed_Name(akt, "unit-of-organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Hypermedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Hypermedia">http://www.aktors.org/ontology/portal#Hypermedia</seealso>
    let Hypermedia = Prefixed_Name(akt, "Hypermedia") |> PrefixedName
    /// <summary>
    ///   <para>akt:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic class for addresses, whether email or postal. We see an address as abstract information and therefore it is an intangible thing</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Address">http://www.aktors.org/ontology/portal#Address</seealso>
    let Address = Prefixed_Name(akt, "Address") |> PrefixedName
    /// <summary>
    ///   <para>akt:Amount-Of-Money</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Amount-Of-Money">http://www.aktors.org/ontology/portal#Amount-Of-Money</seealso>
    let Amount_Of_Money = Prefixed_Name(akt, "Amount-Of-Money") |> PrefixedName
    /// <summary>
    ///   <para>akt:Academic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Academic">http://www.aktors.org/ontology/portal#Academic</seealso>
    let Academic = Prefixed_Name(akt, "Academic") |> PrefixedName
    /// <summary>
    ///   <para>akt:Degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A degree is type of award</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Degree">http://www.aktors.org/ontology/portal#Degree</seealso>
    let Degree = Prefixed_Name(akt, "Degree") |> PrefixedName
    /// <summary>
    ///   <para>akt:Academic-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Academic-Unit">http://www.aktors.org/ontology/portal#Academic-Unit</seealso>
    let Academic_Unit = Prefixed_Name(akt, "Academic-Unit") |> PrefixedName
    /// <summary>
    ///   <para>akt:contains-article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#contains-article">http://www.aktors.org/ontology/portal#contains-article</seealso>
    let contains_article = Prefixed_Name(akt, "contains-article") |> PrefixedName
    /// <summary>
    ///   <para>akt:Knowledge-Retrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Retrieval">http://www.aktors.org/ontology/portal#Knowledge-Retrieval</seealso>
    let Knowledge_Retrieval = Prefixed_Name(akt, "Knowledge-Retrieval") |> PrefixedName

    /// <summary>
    ///   <para>akt:Lecturer-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Lecturer-In-Academia">http://www.aktors.org/ontology/portal#Lecturer-In-Academia</seealso>
    let Lecturer_In_Academia =
        Prefixed_Name(akt, "Lecturer-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:MA</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Academic-Degree</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#MA">http://www.aktors.org/ontology/portal#MA</seealso>
    let MA = Prefixed_Name(akt, "MA") |> PrefixedName
    /// <summary>
    ///   <para>akt:MSc</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Academic-Degree</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#MSc">http://www.aktors.org/ontology/portal#MSc</seealso>
    let MSc = Prefixed_Name(akt, "MSc") |> PrefixedName
    /// <summary>
    ///   <para>akt:Ms</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Ms">http://www.aktors.org/ontology/portal#Ms</seealso>
    let Ms = Prefixed_Name(akt, "Ms") |> PrefixedName
    /// <summary>
    ///   <para>akt:Multimedia-Designer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Multimedia-Designer">http://www.aktors.org/ontology/portal#Multimedia-Designer</seealso>
    let Multimedia_Designer = Prefixed_Name(akt, "Multimedia-Designer") |> PrefixedName

    /// <summary>
    ///   <para>akt:means-of-transport-used</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#means-of-transport-used">http://www.aktors.org/ontology/portal#means-of-transport-used</seealso>
    let means_of_transport_used =
        Prefixed_Name(akt, "means-of-transport-used") |> PrefixedName

    /// <summary>
    ///   <para>akt:Academic-Degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Academic-Degree">http://www.aktors.org/ontology/portal#Academic-Degree</seealso>
    let Academic_Degree = Prefixed_Name(akt, "Academic-Degree") |> PrefixedName

    /// <summary>
    ///   <para>akt:Knowledge-Acquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Acquisition">http://www.aktors.org/ontology/portal#Knowledge-Acquisition</seealso>
    let Knowledge_Acquisition =
        Prefixed_Name(akt, "Knowledge-Acquisition") |> PrefixedName

    /// <summary>
    ///   <para>akt:Language-Engineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Language-Engineering">http://www.aktors.org/ontology/portal#Language-Engineering</seealso>
    let Language_Engineering =
        Prefixed_Name(akt, "Language-Engineering") |> PrefixedName

    /// <summary>
    ///   <para>akt:meeting-attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#meeting-attendee">http://www.aktors.org/ontology/portal#meeting-attendee</seealso>
    let meeting_attendee = Prefixed_Name(akt, "meeting-attendee") |> PrefixedName

    /// <summary>
    ///   <para>akt:organization-being-visited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#organization-being-visited">http://www.aktors.org/ontology/portal#organization-being-visited</seealso>
    let organization_being_visited =
        Prefixed_Name(akt, "organization-being-visited") |> PrefixedName

    /// <summary>
    ///   <para>akt:Academic-Support-Staff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Academic-Support-Staff">http://www.aktors.org/ontology/portal#Academic-Support-Staff</seealso>
    let Academic_Support_Staff =
        Prefixed_Name(akt, "Academic-Support-Staff") |> PrefixedName

    /// <summary>
    ///   <para>akt:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#University">http://www.aktors.org/ontology/portal#University</seealso>
    let University = Prefixed_Name(akt, "University") |> PrefixedName
    /// <summary>
    ///   <para>akt:sub-area-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#sub-area-of">http://www.aktors.org/ontology/portal#sub-area-of</seealso>
    let sub_area_of = Prefixed_Name(akt, "sub-area-of") |> PrefixedName

    /// <summary>
    ///   <para>akt:Multimedia-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Multimedia-Research-Area">http://www.aktors.org/ontology/portal#Multimedia-Research-Area</seealso>
    let Multimedia_Research_Area =
        Prefixed_Name(akt, "Multimedia-Research-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:Ontologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Ontologies">http://www.aktors.org/ontology/portal#Ontologies</seealso>
    let Ontologies = Prefixed_Name(akt, "Ontologies") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-sub-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-sub-unit">http://www.aktors.org/ontology/portal#has-sub-unit</seealso>
    let has_sub_unit = Prefixed_Name(akt, "has-sub-unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:organization-part-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#organization-part-of">http://www.aktors.org/ontology/portal#organization-part-of</seealso>
    let organization_part_of =
        Prefixed_Name(akt, "organization-part-of") |> PrefixedName

    /// <summary>
    ///   <para>akt:affiliated-person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#affiliated-person">http://www.aktors.org/ontology/portal#affiliated-person</seealso>
    let affiliated_person = Prefixed_Name(akt, "affiliated-person") |> PrefixedName
    /// <summary>
    ///   <para>akt:small-size</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Organization-Size</para>
    ///   <para>An organization with no more than 50 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of small-sized enterprise. Finally, either the turnover total must be less than 7M Euros or the balance sheet total must be less than 5M Euros.</para>
    /// labels<para>small</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#small-size">http://www.aktors.org/ontology/portal#small-size</seealso>
    let small_size = Prefixed_Name(akt, "small-size") |> PrefixedName
    /// <summary>
    ///   <para>akt:micro-size</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Organization-Size</para>
    ///   <para>An organization with no more than 10 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of micro-sized enterprise.</para>
    /// labels<para>micro</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#micro-size">http://www.aktors.org/ontology/portal#micro-size</seealso>
    let micro_size = Prefixed_Name(akt, "micro-size") |> PrefixedName

    /// <summary>
    ///   <para>akt:runs-on-operating-system</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#runs-on-operating-system">http://www.aktors.org/ontology/portal#runs-on-operating-system</seealso>
    let runs_on_operating_system =
        Prefixed_Name(akt, "runs-on-operating-system") |> PrefixedName

    /// <summary>
    ///   <para>akt:runs-on-operating-system-on-client-side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#runs-on-operating-system-on-client-side">http://www.aktors.org/ontology/portal#runs-on-operating-system-on-client-side</seealso>
    let runs_on_operating_system_on_client_side =
        Prefixed_Name(akt, "runs-on-operating-system-on-client-side") |> PrefixedName

    /// <summary>
    ///   <para>akt:sub-unit-of-organization-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#sub-unit-of-organization-unit">http://www.aktors.org/ontology/portal#sub-unit-of-organization-unit</seealso>
    let sub_unit_of_organization_unit =
        Prefixed_Name(akt, "sub-unit-of-organization-unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:subsidiary-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#subsidiary-of">http://www.aktors.org/ontology/portal#subsidiary-of</seealso>
    let subsidiary_of = Prefixed_Name(akt, "subsidiary-of") |> PrefixedName

    /// <summary>
    ///   <para>akt:technology-builds-on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#technology-builds-on">http://www.aktors.org/ontology/portal#technology-builds-on</seealso>
    let technology_builds_on =
        Prefixed_Name(akt, "technology-builds-on") |> PrefixedName

    /// <summary>
    ///   <para>akt:works-in-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#works-in-unit">http://www.aktors.org/ontology/portal#works-in-unit</seealso>
    let works_in_unit = Prefixed_Name(akt, "works-in-unit") |> PrefixedName
    /// <summary>
    ///   <para>akt:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Activity">http://www.aktors.org/ontology/portal#Activity</seealso>
    let Activity = Prefixed_Name(akt, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>akt:Alpha-Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Software-Status</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Alpha-Version">http://www.aktors.org/ontology/portal#Alpha-Version</seealso>
    let Alpha_Version = Prefixed_Name(akt, "Alpha-Version") |> PrefixedName
    /// <summary>
    ///   <para>akt:Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Currency">http://www.aktors.org/ontology/portal#Currency</seealso>
    let Currency = Prefixed_Name(akt, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>akt:Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Appellation">http://www.aktors.org/ontology/portal#Appellation</seealso>
    let Appellation = Prefixed_Name(akt, "Appellation") |> PrefixedName

    /// <summary>
    ///   <para>akt:included-in-publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#included-in-publication">http://www.aktors.org/ontology/portal#included-in-publication</seealso>
    let included_in_publication =
        Prefixed_Name(akt, "included-in-publication") |> PrefixedName

    /// <summary>
    ///   <para>akt:Artificial-Intelligence-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Artificial-Intelligence-Research-Area">http://www.aktors.org/ontology/portal#Artificial-Intelligence-Research-Area</seealso>
    let Artificial_Intelligence_Research_Area =
        Prefixed_Name(akt, "Artificial-Intelligence-Research-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:produces-output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#produces-output">http://www.aktors.org/ontology/portal#produces-output</seealso>
    let produces_output = Prefixed_Name(akt, "produces-output") |> PrefixedName

    /// <summary>
    ///   <para>akt:Project-Officer-In-Academia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Project-Officer-In-Academia">http://www.aktors.org/ontology/portal#Project-Officer-In-Academia</seealso>
    let Project_Officer_In_Academia =
        Prefixed_Name(akt, "Project-Officer-In-Academia") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-place-of-publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-place-of-publication">http://www.aktors.org/ontology/portal#has-place-of-publication</seealso>
    let has_place_of_publication =
        Prefixed_Name(akt, "has-place-of-publication") |> PrefixedName

    /// <summary>
    ///   <para>akt:Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Research-Area">http://www.aktors.org/ontology/portal#Research-Area</seealso>
    let Research_Area = Prefixed_Name(akt, "Research-Area") |> PrefixedName
    /// <summary>
    ///   <para>akt:Organization-Size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>We use EU guidelines to distinguish between different organization sizes</para>
    /// labels<para>Organization Size</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Organization-Size">http://www.aktors.org/ontology/portal#Organization-Size</seealso>
    let Organization_Size = Prefixed_Name(akt, "Organization-Size") |> PrefixedName
    /// <summary>
    ///   <para>akt:PhD</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Academic-Degree</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#PhD">http://www.aktors.org/ontology/portal#PhD</seealso>
    let PhD = Prefixed_Name(akt, "PhD") |> PrefixedName
    /// <summary>
    ///   <para>akt:Private-Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Private-Company">http://www.aktors.org/ontology/portal#Private-Company</seealso>
    let Private_Company = Prefixed_Name(akt, "Private-Company") |> PrefixedName

    /// <summary>
    ///   <para>akt:Problem-Solving-Methods</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Problem-Solving-Methods">http://www.aktors.org/ontology/portal#Problem-Solving-Methods</seealso>
    let Problem_Solving_Methods =
        Prefixed_Name(akt, "Problem-Solving-Methods") |> PrefixedName

    /// <summary>
    ///   <para>akt:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Project">http://www.aktors.org/ontology/portal#Project</seealso>
    let Project = Prefixed_Name(akt, "Project") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-project-member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-project-member">http://www.aktors.org/ontology/portal#has-project-member</seealso>
    let has_project_member = Prefixed_Name(akt, "has-project-member") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-affiliation">http://www.aktors.org/ontology/portal#has-affiliation</seealso>
    let has_affiliation = Prefixed_Name(akt, "has-affiliation") |> PrefixedName
    /// <summary>
    ///   <para>akt:Software-Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Software-Status">http://www.aktors.org/ontology/portal#Software-Status</seealso>
    let Software_Status = Prefixed_Name(akt, "Software-Status") |> PrefixedName

    /// <summary>
    ///   <para>akt:Composite-Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication which contains items which cane be themselves referenced through a publication reference.  Composite publications include newspapers, magazines and journals. A book which is a collection of articles is a composite publication, a monograph is not</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Composite-Publication">http://www.aktors.org/ontology/portal#Composite-Publication</seealso>
    let Composite_Publication =
        Prefixed_Name(akt, "Composite-Publication") |> PrefixedName

    /// <summary>
    ///   <para>akt:Attending-A-Conference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Attending-A-Conference">http://www.aktors.org/ontology/portal#Attending-A-Conference</seealso>
    let Attending_A_Conference =
        Prefixed_Name(akt, "Attending-A-Conference") |> PrefixedName

    /// <summary>
    ///   <para>akt:Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An award is an intangible thing, even if the piece of paper which is often associated with an award is tangible.  What about the virtual piece of paper in the virtual degree ceremony?  I guess that ought to be an intangible</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Award">http://www.aktors.org/ontology/portal#Award</seealso>
    let Award = Prefixed_Name(akt, "Award") |> PrefixedName
    /// <summary>
    ///   <para>akt:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication is something which has one or more publication references. A publication can be both an article in a journal or a journal itself. The distinction between publication and publication-reference makes it possible to distinguish between multiple occurrences of the sam publication, for instance in different media</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Publication">http://www.aktors.org/ontology/portal#Publication</seealso>
    let Publication = Prefixed_Name(akt, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>akt:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a minimalist definition of class event.  We start with the very basic and we will then add slots as we specialise this definition for specific classes of events. The fillers of slots has-other-agents-involved and has-main-agent should not intersect</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Event">http://www.aktors.org/ontology/portal#Event</seealso>
    let Event = Prefixed_Name(akt, "Event") |> PrefixedName
    /// <summary>
    ///   <para>akt:Legal-Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Some agents have legal status: definitely organizations and people, anybody else?</para>
    /// labels<para>Legal Agent</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Legal-Agent">http://www.aktors.org/ontology/portal#Legal-Agent</seealso>
    let Legal_Agent = Prefixed_Name(akt, "Legal-Agent") |> PrefixedName
    /// <summary>
    ///   <para>akt:School</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#School">http://www.aktors.org/ontology/portal#School</seealso>
    let School = Prefixed_Name(akt, "School") |> PrefixedName

    /// <summary>
    ///   <para>akt:involves-organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#involves-organization">http://www.aktors.org/ontology/portal#involves-organization</seealso>
    let involves_organization =
        Prefixed_Name(akt, "involves-organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Conference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Conference">http://www.aktors.org/ontology/portal#Conference</seealso>
    let Conference = Prefixed_Name(akt, "Conference") |> PrefixedName
    /// <summary>
    ///   <para>akt:Recorded-Audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any kind of recorded audio, which is tangible.  This also includes a audio file on a machine</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Recorded-Audio">http://www.aktors.org/ontology/portal#Recorded-Audio</seealso>
    let Recorded_Audio = Prefixed_Name(akt, "Recorded-Audio") |> PrefixedName
    /// <summary>
    ///   <para>akt:Researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Researcher">http://www.aktors.org/ontology/portal#Researcher</seealso>
    let Researcher = Prefixed_Name(akt, "Researcher") |> PrefixedName
    /// <summary>
    ///   <para>akt:BA</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Academic-Degree</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#BA">http://www.aktors.org/ontology/portal#BA</seealso>
    let BA = Prefixed_Name(akt, "BA") |> PrefixedName
    /// <summary>
    ///   <para>akt:Book-Publishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Book-Publishing">http://www.aktors.org/ontology/portal#Book-Publishing</seealso>
    let Book_Publishing = Prefixed_Name(akt, "Book-Publishing") |> PrefixedName
    /// <summary>
    ///   <para>akt:published-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#published-by">http://www.aktors.org/ontology/portal#published-by</seealso>
    let published_by = Prefixed_Name(akt, "published-by") |> PrefixedName
    /// <summary>
    ///   <para>akt:Business-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Business-Area">http://www.aktors.org/ontology/portal#Business-Area</seealso>
    let Business_Area = Prefixed_Name(akt, "Business-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:Charitable-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Charitable-Organization">http://www.aktors.org/ontology/portal#Charitable-Organization</seealso>
    let Charitable_Organization =
        Prefixed_Name(akt, "Charitable-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Civil-Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Civil-Service">http://www.aktors.org/ontology/portal#Civil-Service</seealso>
    let Civil_Service = Prefixed_Name(akt, "Civil-Service") |> PrefixedName
    /// <summary>
    ///   <para>akt:Profit-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Profit-Organization">http://www.aktors.org/ontology/portal#Profit-Organization</seealso>
    let Profit_Organization = Prefixed_Name(akt, "Profit-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:contains-publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#contains-publication">http://www.aktors.org/ontology/portal#contains-publication</seealso>
    let contains_publication =
        Prefixed_Name(akt, "contains-publication") |> PrefixedName

    /// <summary>
    ///   <para>akt:Computing-Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Computing-Technology">http://www.aktors.org/ontology/portal#Computing-Technology</seealso>
    let Computing_Technology =
        Prefixed_Name(akt, "Computing-Technology") |> PrefixedName

    /// <summary>
    ///   <para>akt:Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>By technology we mean engineered applications of science. I guess we are probably confining ourselves to tangible things but as I am not sure I will use thing as the direct superclass - e.g., an algorithm is an intangible thing, but it could be seen as a technology, if we give a broad interpretation of the term</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Technology">http://www.aktors.org/ontology/portal#Technology</seealso>
    let Technology = Prefixed_Name(akt, "Technology") |> PrefixedName
    /// <summary>
    ///   <para>akt:BSc</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Academic-Degree</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#BSc">http://www.aktors.org/ontology/portal#BSc</seealso>
    let BSc = Prefixed_Name(akt, "BSc") |> PrefixedName
    /// <summary>
    ///   <para>akt:Sir</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Sir">http://www.aktors.org/ontology/portal#Sir</seealso>
    let Sir = Prefixed_Name(akt, "Sir") |> PrefixedName
    /// <summary>
    ///   <para>akt:Book-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Book-Reference">http://www.aktors.org/ontology/portal#Book-Reference</seealso>
    let Book_Reference = Prefixed_Name(akt, "Book-Reference") |> PrefixedName
    /// <summary>
    ///   <para>akt:Publishing-House</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Publishing-House">http://www.aktors.org/ontology/portal#Publishing-House</seealso>
    let Publishing_House = Prefixed_Name(akt, "Publishing-House") |> PrefixedName
    /// <summary>
    ///   <para>akt:studies-in-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#studies-in-unit">http://www.aktors.org/ontology/portal#studies-in-unit</seealso>
    let studies_in_unit = Prefixed_Name(akt, "studies-in-unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:Technical-Report-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Technical-Report-Reference">http://www.aktors.org/ontology/portal#Technical-Report-Reference</seealso>
    let Technical_Report_Reference =
        Prefixed_Name(akt, "Technical-Report-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:Publication-Type-Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Publication-Type-Event">http://www.aktors.org/ontology/portal#Publication-Type-Event</seealso>
    let Publication_Type_Event =
        Prefixed_Name(akt, "Publication-Type-Event") |> PrefixedName

    /// <summary>
    ///   <para>akt:Broken-Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Software-Status</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Broken-Version">http://www.aktors.org/ontology/portal#Broken-Version</seealso>
    let Broken_Version = Prefixed_Name(akt, "Broken-Version") |> PrefixedName
    /// <summary>
    ///   <para>akt:Capital-City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Capital-City">http://www.aktors.org/ontology/portal#Capital-City</seealso>
    let Capital_City = Prefixed_Name(akt, "Capital-City") |> PrefixedName

    /// <summary>
    ///   <para>akt:Non-Profit-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Non-Profit-Organization">http://www.aktors.org/ontology/portal#Non-Profit-Organization</seealso>
    let Non_Profit_Organization =
        Prefixed_Name(akt, "Non-Profit-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Cognitive-Modelling-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Cognitive-Modelling-Research-Area">http://www.aktors.org/ontology/portal#Cognitive-Modelling-Research-Area</seealso>
    let Cognitive_Modelling_Research_Area =
        Prefixed_Name(akt, "Cognitive-Modelling-Research-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:address-postcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-postcode">http://www.aktors.org/ontology/portal#address-postcode</seealso>
    let address_postcode = Prefixed_Name(akt, "address-postcode") |> PrefixedName
    /// <summary>
    ///   <para>akt:address-region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-region">http://www.aktors.org/ontology/portal#address-region</seealso>
    let address_region = Prefixed_Name(akt, "address-region") |> PrefixedName

    /// <summary>
    ///   <para>akt:Book-Section-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Book-Section-Reference">http://www.aktors.org/ontology/portal#Book-Section-Reference</seealso>
    let Book_Section_Reference =
        Prefixed_Name(akt, "Book-Section-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#City">http://www.aktors.org/ontology/portal#City</seealso>
    let City = Prefixed_Name(akt, "City") |> PrefixedName

    /// <summary>
    ///   <para>akt:Government-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Government-Organization">http://www.aktors.org/ontology/portal#Government-Organization</seealso>
    let Government_Organization =
        Prefixed_Name(akt, "Government-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Company">http://www.aktors.org/ontology/portal#Company</seealso>
    let Company = Prefixed_Name(akt, "Company") |> PrefixedName
    /// <summary>
    ///   <para>akt:Web-Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Web-Site">http://www.aktors.org/ontology/portal#Web-Site</seealso>
    let Web_Site = Prefixed_Name(akt, "Web-Site") |> PrefixedName

    /// <summary>
    ///   <para>akt:Workshop-Proceedings-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Workshop-Proceedings-Reference">http://www.aktors.org/ontology/portal#Workshop-Proceedings-Reference</seealso>
    let Workshop_Proceedings_Reference =
        Prefixed_Name(akt, "Workshop-Proceedings-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:address-building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-building">http://www.aktors.org/ontology/portal#address-building</seealso>
    let address_building = Prefixed_Name(akt, "address-building") |> PrefixedName
    /// <summary>
    ///   <para>akt:address-country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-country">http://www.aktors.org/ontology/portal#address-country</seealso>
    let address_country = Prefixed_Name(akt, "address-country") |> PrefixedName
    /// <summary>
    ///   <para>akt:address-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-number">http://www.aktors.org/ontology/portal#address-number</seealso>
    let address_number = Prefixed_Name(akt, "address-number") |> PrefixedName
    /// <summary>
    ///   <para>akt:address-street</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-street">http://www.aktors.org/ontology/portal#address-street</seealso>
    let address_street = Prefixed_Name(akt, "address-street") |> PrefixedName

    /// <summary>
    ///   <para>akt:addresses-generic-area-of-interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#addresses-generic-area-of-interest">http://www.aktors.org/ontology/portal#addresses-generic-area-of-interest</seealso>
    let addresses_generic_area_of_interest =
        Prefixed_Name(akt, "addresses-generic-area-of-interest") |> PrefixedName

    /// <summary>
    ///   <para>akt:confers-award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#confers-award">http://www.aktors.org/ontology/portal#confers-award</seealso>
    let confers_award = Prefixed_Name(akt, "confers-award") |> PrefixedName
    /// <summary>
    ///   <para>akt:thing-acted-on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What is being transferred</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#thing-acted-on">http://www.aktors.org/ontology/portal#thing-acted-on</seealso>
    let thing_acted_on = Prefixed_Name(akt, "thing-acted-on") |> PrefixedName
    /// <summary>
    ///   <para>akt:full-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#full-name">http://www.aktors.org/ontology/portal#full-name</seealso>
    let full_name = Prefixed_Name(akt, "full-name") |> PrefixedName
    /// <summary>
    ///   <para>akt:funding-source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#funding-source">http://www.aktors.org/ontology/portal#funding-source</seealso>
    let funding_source = Prefixed_Name(akt, "funding-source") |> PrefixedName

    /// <summary>
    ///   <para>akt:Generic-Area-Of-Interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic class to specify generic areas for research or business initiatives. For instance, the area in which a project is situated</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Generic-Area-Of-Interest">http://www.aktors.org/ontology/portal#Generic-Area-Of-Interest</seealso>
    let Generic_Area_Of_Interest =
        Prefixed_Name(akt, "Generic-Area-Of-Interest") |> PrefixedName

    /// <summary>
    ///   <para>akt:Municipal-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Municipal-Unit">http://www.aktors.org/ontology/portal#Municipal-Unit</seealso>
    let Municipal_Unit = Prefixed_Name(akt, "Municipal-Unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:Transportation-Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something tangible designed to transport people, animals, objects from A to B. For instance a bycicle, a car, a boat, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Transportation-Device">http://www.aktors.org/ontology/portal#Transportation-Device</seealso>
    let Transportation_Device =
        Prefixed_Name(akt, "Transportation-Device") |> PrefixedName

    /// <summary>
    ///   <para>akt:Collaborative-Hypermedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Collaborative-Hypermedia">http://www.aktors.org/ontology/portal#Collaborative-Hypermedia</seealso>
    let Collaborative_Hypermedia =
        Prefixed_Name(akt, "Collaborative-Hypermedia") |> PrefixedName

    /// <summary>
    ///   <para>akt:Computing-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Computing-Research-Area">http://www.aktors.org/ontology/portal#Computing-Research-Area</seealso>
    let Computing_Research_Area =
        Prefixed_Name(akt, "Computing-Research-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:Conference-Proceedings-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Conference-Proceedings-Reference">http://www.aktors.org/ontology/portal#Conference-Proceedings-Reference</seealso>
    let Conference_Proceedings_Reference =
        Prefixed_Name(akt, "Conference-Proceedings-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:Conferring-An-Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Conferring-An-Award">http://www.aktors.org/ontology/portal#Conferring-An-Award</seealso>
    let Conferring_An_Award = Prefixed_Name(akt, "Conferring-An-Award") |> PrefixedName
    /// <summary>
    ///   <para>akt:Geopolitical-Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geopolitical entity is a geographical area which is associated with some sort of political structure. For instance, Russia, Italy, The-city-of-Messina, etc. A geopolitical entity can be also seen as an agent - e.g., France declared war to Spain</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Geopolitical-Entity">http://www.aktors.org/ontology/portal#Geopolitical-Entity</seealso>
    let Geopolitical_Entity = Prefixed_Name(akt, "Geopolitical-Entity") |> PrefixedName
    /// <summary>
    ///   <para>akt:DEng</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Academic-Degree</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#DEng">http://www.aktors.org/ontology/portal#DEng</seealso>
    let DEng = Prefixed_Name(akt, "DEng") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-ISBN-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-ISBN-number">http://www.aktors.org/ontology/portal#has-ISBN-number</seealso>
    let has_ISBN_number = Prefixed_Name(akt, "has-ISBN-number") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-academic-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-academic-unit">http://www.aktors.org/ontology/portal#has-academic-unit</seealso>
    let has_academic_unit = Prefixed_Name(akt, "has-academic-unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-affiliation-to-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-affiliation-to-unit">http://www.aktors.org/ontology/portal#has-affiliation-to-unit</seealso>
    let has_affiliation_to_unit =
        Prefixed_Name(akt, "has-affiliation-to-unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-appellation">http://www.aktors.org/ontology/portal#has-appellation</seealso>
    let has_appellation = Prefixed_Name(akt, "has-appellation") |> PrefixedName
    /// <summary>
    ///   <para>akt:Web-Based-Editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Web-Based-Editor">http://www.aktors.org/ontology/portal#Web-Based-Editor</seealso>
    let Web_Based_Editor = Prefixed_Name(akt, "Web-Based-Editor") |> PrefixedName
    /// <summary>
    ///   <para>akt:Web-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Web-Reference">http://www.aktors.org/ontology/portal#Web-Reference</seealso>
    let Web_Reference = Prefixed_Name(akt, "Web-Reference") |> PrefixedName
    /// <summary>
    ///   <para>akt:Workshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Workshop">http://www.aktors.org/ontology/portal#Workshop</seealso>
    let Workshop = Prefixed_Name(akt, "Workshop") |> PrefixedName
    /// <summary>
    ///   <para>akt:address-area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-area">http://www.aktors.org/ontology/portal#address-area</seealso>
    let address_area = Prefixed_Name(akt, "address-area") |> PrefixedName

    /// <summary>
    ///   <para>akt:address-city-or-village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-city-or-village">http://www.aktors.org/ontology/portal#address-city-or-village</seealso>
    let address_city_or_village =
        Prefixed_Name(akt, "address-city-or-village") |> PrefixedName

    /// <summary>
    ///   <para>akt:address-pretty-label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#address-pretty-label">http://www.aktors.org/ontology/portal#address-pretty-label</seealso>
    let address_pretty_label =
        Prefixed_Name(akt, "address-pretty-label") |> PrefixedName

    /// <summary>
    ///   <para>akt:affiliated-people</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#affiliated-people">http://www.aktors.org/ontology/portal#affiliated-people</seealso>
    let affiliated_people = Prefixed_Name(akt, "affiliated-people") |> PrefixedName
    /// <summary>
    ///   <para>akt:contains-property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#contains-property">http://www.aktors.org/ontology/portal#contains-property</seealso>
    let contains_property = Prefixed_Name(akt, "contains-property") |> PrefixedName
    /// <summary>
    ///   <para>akt:family-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#family-name">http://www.aktors.org/ontology/portal#family-name</seealso>
    let family_name = Prefixed_Name(akt, "family-name") |> PrefixedName
    /// <summary>
    ///   <para>akt:given-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#given-name">http://www.aktors.org/ontology/portal#given-name</seealso>
    let given_name = Prefixed_Name(akt, "given-name") |> PrefixedName

    /// <summary>
    ///   <para>akt:government-of-country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#government-of-country">http://www.aktors.org/ontology/portal#government-of-country</seealso>
    let government_of_country =
        Prefixed_Name(akt, "government-of-country") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-URL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-URL">http://www.aktors.org/ontology/portal#has-URL</seealso>
    let has_URL = Prefixed_Name(akt, "has-URL") |> PrefixedName

    /// <summary>
    ///   <para>akt:published-proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#published-proceedings">http://www.aktors.org/ontology/portal#published-proceedings</seealso>
    let published_proceedings =
        Prefixed_Name(akt, "published-proceedings") |> PrefixedName

    /// <summary>
    ///   <para>akt:Generalized-Transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event in which the main agent transfers something (the thing-acted-on, tangible or intangible) to one or more recipient agents. Note that we do not say anything about whether the original agent still retain the thing-acted-on.  In some cases this is clearly true ('I pass my wisdom on to my daughter'), in other cases it is not (I give you my wallet).</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Generalized-Transfer">http://www.aktors.org/ontology/portal#Generalized-Transfer</seealso>
    let Generalized_Transfer =
        Prefixed_Name(akt, "Generalized-Transfer") |> PrefixedName

    /// <summary>
    ///   <para>akt:Distance-Teaching-University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Distance-Teaching-University">http://www.aktors.org/ontology/portal#Distance-Teaching-University</seealso>
    let Distance_Teaching_University =
        Prefixed_Name(akt, "Distance-Teaching-University") |> PrefixedName

    /// <summary>
    ///   <para>akt:Meeting-Taking-Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A meeting type of event. Note that both attendee and organizer have multiple cardinality</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Meeting-Taking-Place">http://www.aktors.org/ontology/portal#Meeting-Taking-Place</seealso>
    let Meeting_Taking_Place =
        Prefixed_Name(akt, "Meeting-Taking-Place") |> PrefixedName

    /// <summary>
    ///   <para>akt:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Country">http://www.aktors.org/ontology/portal#Country</seealso>
    let Country = Prefixed_Name(akt, "Country") |> PrefixedName
    /// <summary>
    ///   <para>akt:Daily-Newspaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Daily-Newspaper">http://www.aktors.org/ontology/portal#Daily-Newspaper</seealso>
    let Daily_Newspaper = Prefixed_Name(akt, "Daily-Newspaper") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-periodicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-periodicity">http://www.aktors.org/ontology/portal#has-periodicity</seealso>
    let has_periodicity = Prefixed_Name(akt, "has-periodicity") |> PrefixedName
    /// <summary>
    ///   <para>akt:Dr</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Dr">http://www.aktors.org/ontology/portal#Dr</seealso>
    let Dr = Prefixed_Name(akt, "Dr") |> PrefixedName
    /// <summary>
    ///   <para>akt:Edited-Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Edited-Book">http://www.aktors.org/ontology/portal#Edited-Book</seealso>
    let Edited_Book = Prefixed_Name(akt, "Edited-Book") |> PrefixedName
    /// <summary>
    ///   <para>akt:edited-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#edited-by">http://www.aktors.org/ontology/portal#edited-by</seealso>
    let edited_by = Prefixed_Name(akt, "edited-by") |> PrefixedName

    /// <summary>
    ///   <para>akt:Educational-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Educational-Organization">http://www.aktors.org/ontology/portal#Educational-Organization</seealso>
    let Educational_Organization =
        Prefixed_Name(akt, "Educational-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Organization-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization may have a number of units. Units may themselves have sub-units</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Organization-Unit">http://www.aktors.org/ontology/portal#Organization-Unit</seealso>
    let Organization_Unit = Prefixed_Name(akt, "Organization-Unit") |> PrefixedName
    /// <summary>
    ///   <para>akt:Email-Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Email-Message">http://www.aktors.org/ontology/portal#Email-Message</seealso>
    let Email_Message = Prefixed_Name(akt, "Email-Message") |> PrefixedName
    /// <summary>
    ///   <para>akt:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Message">http://www.aktors.org/ontology/portal#Message</seealso>
    let Message = Prefixed_Name(akt, "Message") |> PrefixedName

    /// <summary>
    ///   <para>akt:Event-Involving-Movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is an event in which the main agent (plus maybe others) goes from some place to another</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Event-Involving-Movement">http://www.aktors.org/ontology/portal#Event-Involving-Movement</seealso>
    let Event_Involving_Movement =
        Prefixed_Name(akt, "Event-Involving-Movement") |> PrefixedName

    /// <summary>
    ///   <para>akt:location-at-end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#location-at-end">http://www.aktors.org/ontology/portal#location-at-end</seealso>
    let location_at_end = Prefixed_Name(akt, "location-at-end") |> PrefixedName

    /// <summary>
    ///   <para>akt:Event-Involving-Production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When something is produced</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Event-Involving-Production">http://www.aktors.org/ontology/portal#Event-Involving-Production</seealso>
    let Event_Involving_Production =
        Prefixed_Name(akt, "Event-Involving-Production") |> PrefixedName

    /// <summary>
    ///   <para>akt:Experimental-Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Software-Status</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Experimental-Version">http://www.aktors.org/ontology/portal#Experimental-Version</seealso>
    let Experimental_Version =
        Prefixed_Name(akt, "Experimental-Version") |> PrefixedName

    /// <summary>
    ///   <para>akt:Female-Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Gender</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Female-Gender">http://www.aktors.org/ontology/portal#Female-Gender</seealso>
    let Female_Gender = Prefixed_Name(akt, "Female-Gender") |> PrefixedName
    /// <summary>
    ///   <para>akt:Male-Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Gender</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Male-Gender">http://www.aktors.org/ontology/portal#Male-Gender</seealso>
    let Male_Gender = Prefixed_Name(akt, "Male-Gender") |> PrefixedName

    /// <summary>
    ///   <para>akt:sender-of-information</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#sender-of-information">http://www.aktors.org/ontology/portal#sender-of-information</seealso>
    let sender_of_information =
        Prefixed_Name(akt, "sender-of-information") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Whether the software is released, alpha or beta</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-status">http://www.aktors.org/ontology/portal#has-status</seealso>
    let has_status = Prefixed_Name(akt, "has-status") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-sub-activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-sub-activity">http://www.aktors.org/ontology/portal#has-sub-activity</seealso>
    let has_sub_activity = Prefixed_Name(akt, "has-sub-activity") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-telephone-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-telephone-number">http://www.aktors.org/ontology/portal#has-telephone-number</seealso>
    let has_telephone_number =
        Prefixed_Name(akt, "has-telephone-number") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-title">http://www.aktors.org/ontology/portal#has-title</seealso>
    let has_title = Prefixed_Name(akt, "has-title") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-vice-chancellor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-vice-chancellor">http://www.aktors.org/ontology/portal#has-vice-chancellor</seealso>
    let has_vice_chancellor = Prefixed_Name(akt, "has-vice-chancellor") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-web-address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has web address</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-web-address">http://www.aktors.org/ontology/portal#has-web-address</seealso>
    let has_web_address = Prefixed_Name(akt, "has-web-address") |> PrefixedName

    /// <summary>
    ///   <para>akt:Information-Bearing-Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This notion comes from Cyc.  It is useful to group together all information bearing entities, including video, audio and documents. An information bearing object may have an author (a generic agent) and may be owned by a legal agent. It is a tangible object</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Information-Bearing-Object">http://www.aktors.org/ontology/portal#Information-Bearing-Object</seealso>
    let Information_Bearing_Object =
        Prefixed_Name(akt, "Information-Bearing-Object") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-academic-degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-academic-degree">http://www.aktors.org/ontology/portal#has-academic-degree</seealso>
    let has_academic_degree = Prefixed_Name(akt, "has-academic-degree") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-amount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-amount">http://www.aktors.org/ontology/portal#has-amount</seealso>
    let has_amount = Prefixed_Name(akt, "has-amount") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-award-rationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-award-rationale">http://www.aktors.org/ontology/portal#has-award-rationale</seealso>
    let has_award_rationale = Prefixed_Name(akt, "has-award-rationale") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-awarding-body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-awarding-body">http://www.aktors.org/ontology/portal#has-awarding-body</seealso>
    let has_awarding_body = Prefixed_Name(akt, "has-awarding-body") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-capital">http://www.aktors.org/ontology/portal#has-capital</seealso>
    let has_capital = Prefixed_Name(akt, "has-capital") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-currency">http://www.aktors.org/ontology/portal#has-currency</seealso>
    let has_currency = Prefixed_Name(akt, "has-currency") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-email-address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has email address</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-email-address">http://www.aktors.org/ontology/portal#has-email-address</seealso>
    let has_email_address = Prefixed_Name(akt, "has-email-address") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-faculty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-faculty">http://www.aktors.org/ontology/portal#has-faculty</seealso>
    let has_faculty = Prefixed_Name(akt, "has-faculty") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-fax-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-fax-number">http://www.aktors.org/ontology/portal#has-fax-number</seealso>
    let has_fax_number = Prefixed_Name(akt, "has-fax-number") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-goals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-goals">http://www.aktors.org/ontology/portal#has-goals</seealso>
    let has_goals = Prefixed_Name(akt, "has-goals") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-government</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-government">http://www.aktors.org/ontology/portal#has-government</seealso>
    let has_government = Prefixed_Name(akt, "has-government") |> PrefixedName
    /// <summary>
    ///   <para>akt:Newspaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Newspaper">http://www.aktors.org/ontology/portal#Newspaper</seealso>
    let Newspaper = Prefixed_Name(akt, "Newspaper") |> PrefixedName

    /// <summary>
    ///   <para>akt:E-Commerce-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#E-Commerce-Research-Area">http://www.aktors.org/ontology/portal#E-Commerce-Research-Area</seealso>
    let E_Commerce_Research_Area =
        Prefixed_Name(akt, "E-Commerce-Research-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:Edited-Book-Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Edited-Book-Reference">http://www.aktors.org/ontology/portal#Edited-Book-Reference</seealso>
    let Edited_Book_Reference =
        Prefixed_Name(akt, "Edited-Book-Reference") |> PrefixedName

    /// <summary>
    ///   <para>akt:Implemented-System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Implemented-System">http://www.aktors.org/ontology/portal#Implemented-System</seealso>
    let Implemented_System = Prefixed_Name(akt, "Implemented-System") |> PrefixedName

    /// <summary>
    ///   <para>akt:Learning-Centred-Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Learning-Centred-Organization">http://www.aktors.org/ontology/portal#Learning-Centred-Organization</seealso>
    let Learning_Centred_Organization =
        Prefixed_Name(akt, "Learning-Centred-Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Email-Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Information-Transfer-Medium</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Email-Medium">http://www.aktors.org/ontology/portal#Email-Medium</seealso>
    let Email_Medium = Prefixed_Name(akt, "Email-Medium") |> PrefixedName
    /// <summary>
    ///   <para>akt:Working-Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Working-Person">http://www.aktors.org/ontology/portal#Working-Person</seealso>
    let Working_Person = Prefixed_Name(akt, "Working-Person") |> PrefixedName
    /// <summary>
    ///   <para>akt:Temporary-Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Employment-Contract-Type</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Temporary-Contract">http://www.aktors.org/ontology/portal#Temporary-Contract</seealso>
    let Temporary_Contract = Prefixed_Name(akt, "Temporary-Contract") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-postal-address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-postal-address">http://www.aktors.org/ontology/portal#has-postal-address</seealso>
    let has_postal_address = Prefixed_Name(akt, "has-postal-address") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-project-leader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-project-leader">http://www.aktors.org/ontology/portal#has-project-leader</seealso>
    let has_project_leader = Prefixed_Name(akt, "has-project-leader") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-speaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-speaker">http://www.aktors.org/ontology/portal#has-speaker</seealso>
    let has_speaker = Prefixed_Name(akt, "has-speaker") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-supervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-supervisor">http://www.aktors.org/ontology/portal#has-supervisor</seealso>
    let has_supervisor = Prefixed_Name(akt, "has-supervisor") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-support-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-support-unit">http://www.aktors.org/ontology/portal#has-support-unit</seealso>
    let has_support_unit = Prefixed_Name(akt, "has-support-unit") |> PrefixedName

    /// <summary>
    ///   <para>akt:information-being-transferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#information-being-transferred">http://www.aktors.org/ontology/portal#information-being-transferred</seealso>
    let information_being_transferred =
        Prefixed_Name(akt, "information-being-transferred") |> PrefixedName

    /// <summary>
    ///   <para>akt:Dynamic-Linking</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Dynamic-Linking">http://www.aktors.org/ontology/portal#Dynamic-Linking</seealso>
    let Dynamic_Linking = Prefixed_Name(akt, "Dynamic-Linking") |> PrefixedName
    /// <summary>
    ///   <para>akt:Editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Editor">http://www.aktors.org/ontology/portal#Editor</seealso>
    let Editor = Prefixed_Name(akt, "Editor") |> PrefixedName
    /// <summary>
    ///   <para>akt:Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Employee">http://www.aktors.org/ontology/portal#Employee</seealso>
    let Employee = Prefixed_Name(akt, "Employee") |> PrefixedName

    /// <summary>
    ///   <para>akt:Information-Transfer-Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Information-Transfer-Medium">http://www.aktors.org/ontology/portal#Information-Transfer-Medium</seealso>
    let Information_Transfer_Medium =
        Prefixed_Name(akt, "Information-Transfer-Medium") |> PrefixedName

    /// <summary>
    ///   <para>akt:Employment-Contract-Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Employment-Contract-Type">http://www.aktors.org/ontology/portal#Employment-Contract-Type</seealso>
    let Employment_Contract_Type =
        Prefixed_Name(akt, "Employment-Contract-Type") |> PrefixedName

    /// <summary>
    ///   <para>akt:Permanent-Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Employment-Contract-Type</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Permanent-Contract">http://www.aktors.org/ontology/portal#Permanent-Contract</seealso>
    let Permanent_Contract = Prefixed_Name(akt, "Permanent-Contract") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-job-title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-job-title">http://www.aktors.org/ontology/portal#has-job-title</seealso>
    let has_job_title = Prefixed_Name(akt, "has-job-title") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-leading-organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-leading-organization">http://www.aktors.org/ontology/portal#has-leading-organization</seealso>
    let has_leading_organization =
        Prefixed_Name(akt, "has-leading-organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-other-agents-involved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Other agents involved in the event</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-other-agents-involved">http://www.aktors.org/ontology/portal#has-other-agents-involved</seealso>
    let has_other_agents_involved =
        Prefixed_Name(akt, "has-other-agents-involved") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-main-agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The agents causing the event to happen, if they are known.</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-main-agent">http://www.aktors.org/ontology/portal#has-main-agent</seealso>
    let has_main_agent = Prefixed_Name(akt, "has-main-agent") |> PrefixedName
    /// <summary>
    ///   <para>akt:is-capital-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#is-capital-of">http://www.aktors.org/ontology/portal#is-capital-of</seealso>
    let is_capital_of = Prefixed_Name(akt, "is-capital-of") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-contract-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-contract-type">http://www.aktors.org/ontology/portal#has-contract-type</seealso>
    let has_contract_type = Prefixed_Name(akt, "has-contract-type") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-gender">http://www.aktors.org/ontology/portal#has-gender</seealso>
    let has_gender = Prefixed_Name(akt, "has-gender") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location at which an event takes place</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-location">http://www.aktors.org/ontology/portal#has-location</seealso>
    let has_location = Prefixed_Name(akt, "has-location") |> PrefixedName
    /// <summary>
    ///   <para>akt:has-page-numbers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-page-numbers">http://www.aktors.org/ontology/portal#has-page-numbers</seealso>
    let has_page_numbers = Prefixed_Name(akt, "has-page-numbers") |> PrefixedName

    /// <summary>
    ///   <para>akt:has-research-interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>People and in general even organizations and organization units may have research interests.  This relation shoudl be used to specify them</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#has-research-interest">http://www.aktors.org/ontology/portal#has-research-interest</seealso>
    let has_research_interest =
        Prefixed_Name(akt, "has-research-interest") |> PrefixedName

    /// <summary>
    ///   <para>akt:Abstract-Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information in general, independent of an object in which it is encoded. Whatever is transferred in an information-transfer event. It is clearly an intangible thing</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Abstract-Information">http://www.aktors.org/ontology/portal#Abstract-Information</seealso>
    let Abstract_Information =
        Prefixed_Name(akt, "Abstract-Information") |> PrefixedName

    /// <summary>
    ///   <para>akt:works-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#works-for">http://www.aktors.org/ontology/portal#works-for</seealso>
    let works_for = Prefixed_Name(akt, "works-for") |> PrefixedName
    /// <summary>
    ///   <para>akt:Graphic-Designer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Graphic-Designer">http://www.aktors.org/ontology/portal#Graphic-Designer</seealso>
    let Graphic_Designer = Prefixed_Name(akt, "Graphic-Designer") |> PrefixedName
    /// <summary>
    ///   <para>akt:Hardware-Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Hardware-Platform">http://www.aktors.org/ontology/portal#Hardware-Platform</seealso>
    let Hardware_Platform = Prefixed_Name(akt, "Hardware-Platform") |> PrefixedName
    /// <summary>
    ///   <para>akt:Software-Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Software-Technology">http://www.aktors.org/ontology/portal#Software-Technology</seealso>
    let Software_Technology = Prefixed_Name(akt, "Software-Technology") |> PrefixedName
    /// <summary>
    ///   <para>akt:Incidental-KA</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Incidental-KA">http://www.aktors.org/ontology/portal#Incidental-KA</seealso>
    let Incidental_KA = Prefixed_Name(akt, "Incidental-KA") |> PrefixedName
    /// <summary>
    ///   <para>akt:owned-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#owned-by">http://www.aktors.org/ontology/portal#owned-by</seealso>
    let owned_by = Prefixed_Name(akt, "owned-by") |> PrefixedName
    /// <summary>
    ///   <para>akt:Serial-Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This used to be called periodical publication.  However, many periodicals do not appear at fixed intervals, which is why librarians refer to them as serials. So, we now use the concept of serial publication and the has-periodicity slot has been removed</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Serial-Publication">http://www.aktors.org/ontology/portal#Serial-Publication</seealso>
    let Serial_Publication = Prefixed_Name(akt, "Serial-Publication") |> PrefixedName
    /// <summary>
    ///   <para>akt:Magazine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Magazine">http://www.aktors.org/ontology/portal#Magazine</seealso>
    let Magazine = Prefixed_Name(akt, "Magazine") |> PrefixedName

    /// <summary>
    ///   <para>akt:Knowledge-Management</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Management">http://www.aktors.org/ontology/portal#Knowledge-Management</seealso>
    let Knowledge_Management =
        Prefixed_Name(akt, "Knowledge-Management") |> PrefixedName

    /// <summary>
    ///   <para>akt:Knowledge-Reuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Knowledge-Reuse">http://www.aktors.org/ontology/portal#Knowledge-Reuse</seealso>
    let Knowledge_Reuse = Prefixed_Name(akt, "Knowledge-Reuse") |> PrefixedName
    /// <summary>
    ///   <para>akt:Lady</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Appellation</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Lady">http://www.aktors.org/ontology/portal#Lady</seealso>
    let Lady = Prefixed_Name(akt, "Lady") |> PrefixedName
    /// <summary>
    ///   <para>akt:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization is a type of legal agent</para>
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Organization">http://www.aktors.org/ontology/portal#Organization</seealso>
    let Organization = Prefixed_Name(akt, "Organization") |> PrefixedName

    /// <summary>
    ///   <para>akt:Learning-Research-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>akt:Research-Area</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#Learning-Research-Area">http://www.aktors.org/ontology/portal#Learning-Research-Area</seealso>
    let Learning_Research_Area =
        Prefixed_Name(akt, "Learning-Research-Area") |> PrefixedName

    /// <summary>
    ///   <para>akt:person-being-visited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#person-being-visited">http://www.aktors.org/ontology/portal#person-being-visited</seealso>
    let person_being_visited =
        Prefixed_Name(akt, "person-being-visited") |> PrefixedName

    /// <summary>
    ///   <para>akt:published-book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#published-book">http://www.aktors.org/ontology/portal#published-book</seealso>
    let published_book = Prefixed_Name(akt, "published-book") |> PrefixedName
    /// <summary>
    ///   <para>akt:recipient-agents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The agents which receive the thing-acted-on</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#recipient-agents">http://www.aktors.org/ontology/portal#recipient-agents</seealso>
    let recipient_agents = Prefixed_Name(akt, "recipient-agents") |> PrefixedName

    /// <summary>
    ///   <para>akt:recipient-of-message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#recipient-of-message">http://www.aktors.org/ontology/portal#recipient-of-message</seealso>
    let recipient_of_message =
        Prefixed_Name(akt, "recipient-of-message") |> PrefixedName

    /// <summary>
    ///   <para>akt:requires-hardware-platform-on-server-side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#requires-hardware-platform-on-server-side">http://www.aktors.org/ontology/portal#requires-hardware-platform-on-server-side</seealso>
    let requires_hardware_platform_on_server_side =
        Prefixed_Name(akt, "requires-hardware-platform-on-server-side") |> PrefixedName

    /// <summary>
    ///   <para>akt:requires-software-technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#requires-software-technology">http://www.aktors.org/ontology/portal#requires-software-technology</seealso>
    let requires_software_technology =
        Prefixed_Name(akt, "requires-software-technology") |> PrefixedName

    /// <summary>
    ///   <para>akt:requires-software-technology-on-client-side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#requires-software-technology-on-client-side">http://www.aktors.org/ontology/portal#requires-software-technology-on-client-side</seealso>
    let requires_software_technology_on_client_side =
        Prefixed_Name(akt, "requires-software-technology-on-client-side") |> PrefixedName

    /// <summary>
    ///   <para>akt:requires-software-technology-on-server-side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#requires-software-technology-on-server-side">http://www.aktors.org/ontology/portal#requires-software-technology-on-server-side</seealso>
    let requires_software_technology_on_server_side =
        Prefixed_Name(akt, "requires-software-technology-on-server-side") |> PrefixedName

    /// <summary>
    ///   <para>akt:runs-on-operating-system-on-server-side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#runs-on-operating-system-on-server-side">http://www.aktors.org/ontology/portal#runs-on-operating-system-on-server-side</seealso>
    let runs_on_operating_system_on_server_side =
        Prefixed_Name(akt, "runs-on-operating-system-on-server-side") |> PrefixedName

    /// <summary>
    ///   <para>akt:sender-of-message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#sender-of-message">http://www.aktors.org/ontology/portal#sender-of-message</seealso>
    let sender_of_message = Prefixed_Name(akt, "sender-of-message") |> PrefixedName
    /// <summary>
    ///   <para>akt:supports-method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#supports-method">http://www.aktors.org/ontology/portal#supports-method</seealso>
    let supports_method = Prefixed_Name(akt, "supports-method") |> PrefixedName
    /// <summary>
    ///   <para>akt:time-of-message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#time-of-message">http://www.aktors.org/ontology/portal#time-of-message</seealso>
    let time_of_message = Prefixed_Name(akt, "time-of-message") |> PrefixedName
    /// <summary>
    ///   <para>akt:uses-resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.aktors.org/ontology/portal#uses-resource">http://www.aktors.org/ontology/portal#uses-resource</seealso>
    let uses_resource = Prefixed_Name(akt, "uses-resource") |> PrefixedName
