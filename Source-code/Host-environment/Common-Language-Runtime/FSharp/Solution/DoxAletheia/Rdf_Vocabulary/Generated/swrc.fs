namespace http.swrc.ontoware.org.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swrc =
    let _namespace_iri = Namespace_Iri swrc |> NamespaceIRI
    /// <summary>
    ///   <para>swrc:organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>meaning not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class definition of swrc:Document. I think it is obsolete, since you may link a document via the dc:creator, dc:contributor or dc:publisher property to an organization.</para>
    /// labels<para>organisation</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#organization">http://swrc.ontoware.org/ontology#organization</seealso>
    let organization = Prefixed_Name(swrc, "organization") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Projekt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Project">http://swrc.ontoware.org/ontology#Project</seealso>
    let Project = Prefixed_Name(swrc, "Project") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Person">http://swrc.ontoware.org/ontology#Person</seealso>
    let Person = Prefixed_Name(swrc, "Person") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organisation</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Organization">http://swrc.ontoware.org/ontology#Organization</seealso>
    let Organization = Prefixed_Name(swrc, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>swrc:TechnicalStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Technischer_Angestellter</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#TechnicalStaff">http://swrc.ontoware.org/ontology#TechnicalStaff</seealso>
    let TechnicalStaff = Prefixed_Name(swrc, "TechnicalStaff") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Verband</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Association">http://swrc.ontoware.org/ontology#Association</seealso>
    let Association = Prefixed_Name(swrc, "Association") |> PrefixedName
    /// <summary>
    ///   <para>swrc:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unversität</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#University">http://swrc.ontoware.org/ontology#University</seealso>
    let University = Prefixed_Name(swrc, "University") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Institut</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Institute">http://swrc.ontoware.org/ontology#Institute</seealso>
    let Institute = Prefixed_Name(swrc, "Institute") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Seminar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Seminar</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Seminar">http://swrc.ontoware.org/ontology#Seminar</seealso>
    let Seminar = Prefixed_Name(swrc, "Seminar") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Workshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Workshop</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Workshop">http://swrc.ontoware.org/ontology#Workshop</seealso>
    let Workshop = Prefixed_Name(swrc, "Workshop") |> PrefixedName
    /// <summary>
    ///   <para>swrc:eventTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ereignisTitel</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#eventTitle">http://swrc.ontoware.org/ontology#eventTitle</seealso>
    let eventTitle = Prefixed_Name(swrc, "eventTitle") |> PrefixedName
    /// <summary>
    ///   <para>swrc:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>titel</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#title">http://swrc.ontoware.org/ontology#title</seealso>
    let title = Prefixed_Name(swrc, "title") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Produkt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Product">http://swrc.ontoware.org/ontology#Product</seealso>
    let Product = Prefixed_Name(swrc, "Product") |> PrefixedName
    /// <summary>
    ///   <para>swrc:organizerOrChairOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>veranstalterOderVorsitzenderVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#organizerOrChairOf">http://swrc.ontoware.org/ontology#organizerOrChairOf</seealso>
    let organizerOrChairOf = Prefixed_Name(swrc, "organizerOrChairOf") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Manager</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Manager">http://swrc.ontoware.org/ontology#Manager</seealso>
    let Manager = Prefixed_Name(swrc, "Manager") |> PrefixedName
    /// <summary>
    ///   <para>swrc:projectInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>projektInfo</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#projectInfo">http://swrc.ontoware.org/ontology#projectInfo</seealso>
    let projectInfo = Prefixed_Name(swrc, "projectInfo") |> PrefixedName
    /// <summary>
    ///   <para>swrc:InBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of a book, which may be a chapter and/or range of pages.</para>
    /// labels<para>Teil_eines_Buches</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#InBook">http://swrc.ontoware.org/ontology#InBook</seealso>
    let InBook = Prefixed_Name(swrc, "InBook") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entire issue of a refereed learned journal.</para>
    /// labels<para>Journal</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Journal">http://swrc.ontoware.org/ontology#Journal</seealso>
    let Journal = Prefixed_Name(swrc, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Magazine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entire issue of an unrefereed journal or magazine.</para>
    /// labels<para>Magazin</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Magazine">http://swrc.ontoware.org/ontology#Magazine</seealso>
    let Magazine = Prefixed_Name(swrc, "Magazine") |> PrefixedName
    /// <summary>
    ///   <para>swrc:develops</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>entwickelt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#develops">http://swrc.ontoware.org/ontology#develops</seealso>
    let develops = Prefixed_Name(swrc, "develops") |> PrefixedName
    /// <summary>
    ///   <para>swrc:TechnicalReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>technischer_Bericht</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#TechnicalReport">http://swrc.ontoware.org/ontology#TechnicalReport</seealso>
    let TechnicalReport = Prefixed_Name(swrc, "TechnicalReport") |> PrefixedName
    /// <summary>
    ///   <para>swrc:employs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>beschaeftigt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#employs">http://swrc.ontoware.org/ontology#employs</seealso>
    let employs = Prefixed_Name(swrc, "employs") |> PrefixedName
    /// <summary>
    ///   <para>swrc:lastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>nachname</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#lastName">http://swrc.ontoware.org/ontology#lastName</seealso>
    let lastName = Prefixed_Name(swrc, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>swrc:firstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>vorname</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#firstName">http://swrc.ontoware.org/ontology#firstName</seealso>
    let firstName = Prefixed_Name(swrc, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>swrc:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>email</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#email">http://swrc.ontoware.org/ontology#email</seealso>
    let email = Prefixed_Name(swrc, "email") |> PrefixedName
    /// <summary>
    ///   <para>swrc:fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>fax</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#fax">http://swrc.ontoware.org/ontology#fax</seealso>
    let fax = Prefixed_Name(swrc, "fax") |> PrefixedName
    /// <summary>
    ///   <para>swrc:supervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hatBetreuer</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#supervisor">http://swrc.ontoware.org/ontology#supervisor</seealso>
    let supervisor = Prefixed_Name(swrc, "supervisor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>preis</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#price">http://swrc.ontoware.org/ontology#price</seealso>
    let price = Prefixed_Name(swrc, "price") |> PrefixedName
    /// <summary>
    ///   <para>swrc:vendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>verkaeufer</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#vendor">http://swrc.ontoware.org/ontology#vendor</seealso>
    let vendor = Prefixed_Name(swrc, "vendor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ExchangeProfessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Austauschprofessor</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ExchangeProfessor">http://swrc.ontoware.org/ontology#ExchangeProfessor</seealso>
    let ExchangeProfessor = Prefixed_Name(swrc, "ExchangeProfessor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Graduate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>disjoint with undergrad? Olivier 2006-06-07
    /// Philipp: I wouldn't make it disjoint, since someone can be a bachelor-graduate, but if he is doing his master he is a master-undergraduate at the same time.</para>
    /// labels<para>Absolvent</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Graduate">http://swrc.ontoware.org/ontology#Graduate</seealso>
    let Graduate = Prefixed_Name(swrc, "Graduate") |> PrefixedName
    /// <summary>
    ///   <para>swrc:HonoraryProfessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Honorarprofessor</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#HonoraryProfessor">http://swrc.ontoware.org/ontology#HonoraryProfessor</seealso>
    let HonoraryProfessor = Prefixed_Name(swrc, "HonoraryProfessor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:InProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single paper from a published workshop or conference proceedings.</para>
    /// labels<para>Artikel_eines_Tagungsbandes</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#InProceedings">http://swrc.ontoware.org/ontology#InProceedings</seealso>
    let InProceedings = Prefixed_Name(swrc, "InProceedings") |> PrefixedName
    /// <summary>
    ///   <para>swrc:atEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>beiEreignis</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#atEvent">http://swrc.ontoware.org/ontology#atEvent</seealso>
    let atEvent = Prefixed_Name(swrc, "atEvent") |> PrefixedName
    /// <summary>
    ///   <para>swrc:hasPartEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Example: FIFA World Cup 2006 hasPartEvent Final</para>
    /// labels<para>hatTeilEreignis</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#hasPartEvent">http://swrc.ontoware.org/ontology#hasPartEvent</seealso>
    let hasPartEvent = Prefixed_Name(swrc, "hasPartEvent") |> PrefixedName
    /// <summary>
    ///   <para>swrc:FullProfessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ordentlicher_Professor</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#FullProfessor">http://swrc.ontoware.org/ontology#FullProfessor</seealso>
    let FullProfessor = Prefixed_Name(swrc, "FullProfessor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Student</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Student">http://swrc.ontoware.org/ontology#Student</seealso>
    let Student = Prefixed_Name(swrc, "Student") |> PrefixedName
    /// <summary>
    ///   <para>swrc:GraduateClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see: http://www.neurolabor.de/socrate/ects_ganz.htm</para>
    /// labels<para>Oberseminar</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#GraduateClass">http://swrc.ontoware.org/ontology#GraduateClass</seealso>
    let GraduateClass = Prefixed_Name(swrc, "GraduateClass") |> PrefixedName

    /// <summary>
    ///   <para>swrc:UndergraduateAdvancedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see: http://www.neurolabor.de/socrate/ects_ganz.htm</para>
    /// labels<para>Hauptseminar</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#UndergraduateAdvancedClass">http://swrc.ontoware.org/ontology#UndergraduateAdvancedClass</seealso>
    let UndergraduateAdvancedClass =
        Prefixed_Name(swrc, "UndergraduateAdvancedClass") |> PrefixedName

    /// <summary>
    ///   <para>swrc:UndergraduateIntermediateClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see: http://www.neurolabor.de/socrate/ects_ganz.htm
    ///
    /// http://dict.leo.org/cgi-bin/dict/urlexp/20030705201638</para>
    /// labels<para>Proseminar </para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#UndergraduateIntermediateClass">http://swrc.ontoware.org/ontology#UndergraduateIntermediateClass</seealso>
    let UndergraduateIntermediateClass =
        Prefixed_Name(swrc, "UndergraduateIntermediateClass") |> PrefixedName

    /// <summary>
    ///   <para>swrc:InCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single paper or article from a published collection.</para>
    /// labels<para>Teil_eines_Buches_mit_eigenem_Titel</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#InCollection">http://swrc.ontoware.org/ontology#InCollection</seealso>
    let InCollection = Prefixed_Name(swrc, "InCollection") |> PrefixedName
    /// <summary>
    ///   <para>swrc:givenBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>check domain. Olivier 2006-06-07
    /// Philipp: checked.</para>
    /// labels<para>gehaltenVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#givenBy">http://swrc.ontoware.org/ontology#givenBy</seealso>
    let givenBy = Prefixed_Name(swrc, "givenBy") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Lecturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lehrbeauftragter</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Lecturer">http://swrc.ontoware.org/ontology#Lecturer</seealso>
    let Lecturer = Prefixed_Name(swrc, "Lecturer") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An operations manual for a product.</para>
    /// labels<para>Handbuch</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Manual">http://swrc.ontoware.org/ontology#Manual</seealso>
    let Manual = Prefixed_Name(swrc, "Manual") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Misc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Work of another or undetermined type. This is the default scheme value if the scheme is not explicitly stated.</para>
    /// labels<para>Sonstiges</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Misc">http://swrc.ontoware.org/ontology#Misc</seealso>
    let Misc = Prefixed_Name(swrc, "Misc") |> PrefixedName
    /// <summary>
    ///   <para>swrc:carriesOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>durchfuehren</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#carriesOut">http://swrc.ontoware.org/ontology#carriesOut</seealso>
    let carriesOut = Prefixed_Name(swrc, "carriesOut") |> PrefixedName
    /// <summary>
    ///   <para>swrc:technicalReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// </para>
    /// labels<para>fachbericht</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#technicalReport">http://swrc.ontoware.org/ontology#technicalReport</seealso>
    let technicalReport = Prefixed_Name(swrc, "technicalReport") |> PrefixedName
    /// <summary>
    ///   <para>swrc:finances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>finanziert</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#finances">http://swrc.ontoware.org/ontology#finances</seealso>
    let finances = Prefixed_Name(swrc, "finances") |> PrefixedName
    /// <summary>
    ///   <para>swrc:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>adresse</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#address">http://swrc.ontoware.org/ontology#address</seealso>
    let address = Prefixed_Name(swrc, "address") |> PrefixedName
    /// <summary>
    ///   <para>swrc:phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>telefon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#phone">http://swrc.ontoware.org/ontology#phone</seealso>
    let phone = Prefixed_Name(swrc, "phone") |> PrefixedName
    /// <summary>
    ///   <para>swrc:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>homepage</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#homepage">http://swrc.ontoware.org/ontology#homepage</seealso>
    let homepage = Prefixed_Name(swrc, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>swrc:publisherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>check range. Olivier 2006-06-07
    /// Philipp: checked.</para>
    ///   <para>check domain. Olivier 2006-06-07
    /// Philipp: checked.</para>
    /// labels<para>herausgeberVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#publisherOf">http://swrc.ontoware.org/ontology#publisherOf</seealso>
    let publisherOf = Prefixed_Name(swrc, "publisherOf") |> PrefixedName
    /// <summary>
    ///   <para>swrc:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>status</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#status">http://swrc.ontoware.org/ontology#status</seealso>
    let status = Prefixed_Name(swrc, "status") |> PrefixedName
    /// <summary>
    ///   <para>swrc:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>can an organization be a member of another organization? olivier 2006-06-07
    /// Philipp: Hmm could be possible. Therefore I added Organization to the range that one can state: Organization (has)member Organization.</para>
    /// labels<para>hatMitglied</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#member">http://swrc.ontoware.org/ontology#member</seealso>
    let member_ = Prefixed_Name(swrc, "member") |> PrefixedName
    /// <summary>
    ///   <para>swrc:outcomeProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ergebnisProdukt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#outcomeProduct">http://swrc.ontoware.org/ontology#outcomeProduct</seealso>
    let outcomeProduct = Prefixed_Name(swrc, "outcomeProduct") |> PrefixedName
    /// <summary>
    ///   <para>swrc:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>check domain. Olivier 2006-06-07
    /// Philipp: checked.</para>
    /// labels<para>ueber</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#isAbout">http://swrc.ontoware.org/ontology#isAbout</seealso>
    let isAbout = Prefixed_Name(swrc, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>swrc:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>startDatum</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#startDate">http://swrc.ontoware.org/ontology#startDate</seealso>
    let startDate = Prefixed_Name(swrc, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>swrc:carriedOutBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>durchgefuehrtVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#carriedOutBy">http://swrc.ontoware.org/ontology#carriedOutBy</seealso>
    let carriedOutBy = Prefixed_Name(swrc, "carriedOutBy") |> PrefixedName
    /// <summary>
    ///   <para>swrc:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>endDatum</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#endDate">http://swrc.ontoware.org/ontology#endDate</seealso>
    let endDate = Prefixed_Name(swrc, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ProjectReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Projekt_Bericht</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ProjectReport">http://swrc.ontoware.org/ontology#ProjectReport</seealso>
    let ProjectReport = Prefixed_Name(swrc, "ProjectReport") |> PrefixedName
    /// <summary>
    ///   <para>swrc:cite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>check domain. Olivier 2006-06-07
    /// Philipp: checked.</para>
    /// labels<para>zitiert</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#cite">http://swrc.ontoware.org/ontology#cite</seealso>
    let cite = Prefixed_Name(swrc, "cite") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Unpublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document with an author and title, but not formally published.</para>
    /// labels<para>Ein_nicht_formell_publiziertes_Dokument</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Unpublished">http://swrc.ontoware.org/ontology#Unpublished</seealso>
    let Unpublished = Prefixed_Name(swrc, "Unpublished") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ResearchPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A piece of research work.</para>
    /// labels<para>Forschungsarbeit</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ResearchPaper">http://swrc.ontoware.org/ontology#ResearchPaper</seealso>
    let ResearchPaper = Prefixed_Name(swrc, "ResearchPaper") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ResearchProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Forschungsprojekt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ResearchProject">http://swrc.ontoware.org/ontology#ResearchProject</seealso>
    let ResearchProject = Prefixed_Name(swrc, "ResearchProject") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ResearchTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Forschungsthema</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ResearchTopic">http://swrc.ontoware.org/ontology#ResearchTopic</seealso>
    let ResearchTopic = Prefixed_Name(swrc, "ResearchTopic") |> PrefixedName
    /// <summary>
    ///   <para>swrc:isWorkedOnBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>wirdBearbeitetVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#isWorkedOnBy">http://swrc.ontoware.org/ontology#isWorkedOnBy</seealso>
    let isWorkedOnBy = Prefixed_Name(swrc, "isWorkedOnBy") |> PrefixedName
    /// <summary>
    ///   <para>swrc:dealtWithIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>behandeltIn</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#dealtWithIn">http://swrc.ontoware.org/ontology#dealtWithIn</seealso>
    let dealtWithIn = Prefixed_Name(swrc, "dealtWithIn") |> PrefixedName
    /// <summary>
    ///   <para>swrc:RootRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// </para>
    /// labels<para>wurzelRelation</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#RootRelation">http://swrc.ontoware.org/ontology#RootRelation</seealso>
    let RootRelation = Prefixed_Name(swrc, "RootRelation") |> PrefixedName
    /// <summary>
    ///   <para>swrc:SoftwareProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Softwareprojekt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#SoftwareProject">http://swrc.ontoware.org/ontology#SoftwareProject</seealso>
    let SoftwareProject = Prefixed_Name(swrc, "SoftwareProject") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A whole published workshop or conference proceedings.</para>
    /// labels<para>Tagungsband</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Proceedings">http://swrc.ontoware.org/ontology#Proceedings</seealso>
    let Proceedings = Prefixed_Name(swrc, "Proceedings") |> PrefixedName
    /// <summary>
    ///   <para>swrc:developedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>entwickeltVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#developedBy">http://swrc.ontoware.org/ontology#developedBy</seealso>
    let developedBy = Prefixed_Name(swrc, "developedBy") |> PrefixedName
    /// <summary>
    ///   <para>swrc:creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Herstellungsdatum</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#creationDate">http://swrc.ontoware.org/ontology#creationDate</seealso>
    let creationDate = Prefixed_Name(swrc, "creationDate") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ProfessorEmeritus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Emeritierter_Professor</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ProfessorEmeritus">http://swrc.ontoware.org/ontology#ProfessorEmeritus</seealso>
    let ProfessorEmeritus = Prefixed_Name(swrc, "ProfessorEmeritus") |> PrefixedName
    /// <summary>
    ///   <para>swrc:worksAtProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>arbeitetAnProjekt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#worksAtProject">http://swrc.ontoware.org/ontology#worksAtProject</seealso>
    let worksAtProject = Prefixed_Name(swrc, "worksAtProject") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mitarbeiter</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Employee">http://swrc.ontoware.org/ontology#Employee</seealso>
    let Employee = Prefixed_Name(swrc, "Employee") |> PrefixedName
    /// <summary>
    ///   <para>swrc:describesProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>beschreibtProjekt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#describesProject">http://swrc.ontoware.org/ontology#describesProject</seealso>
    let describesProject = Prefixed_Name(swrc, "describesProject") |> PrefixedName
    /// <summary>
    ///   <para>swrc:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>editor</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#editor">http://swrc.ontoware.org/ontology#editor</seealso>
    let editor = Prefixed_Name(swrc, "editor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:head</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>leiter</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#head">http://swrc.ontoware.org/ontology#head</seealso>
    let head = Prefixed_Name(swrc, "head") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>If changing this concept (or its subconcepts) consider that the swrc topic ontology depends on the foresaid one.
    /// The swrc topic ontology can be found at:
    /// http://ontoware.org/frs/download.php/187/swrc-swtopics.owl</para>
    /// labels<para>Thema</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Topic">http://swrc.ontoware.org/ontology#Topic</seealso>
    let Topic = Prefixed_Name(swrc, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>swrc:outcomeDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ergebnisDokument</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#outcomeDocument">http://swrc.ontoware.org/ontology#outcomeDocument</seealso>
    let outcomeDocument = Prefixed_Name(swrc, "outcomeDocument") |> PrefixedName
    /// <summary>
    ///   <para>swrc:memberOfPC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>mitgliedVonPC</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#memberOfPC">http://swrc.ontoware.org/ontology#memberOfPC</seealso>
    let memberOfPC = Prefixed_Name(swrc, "memberOfPC") |> PrefixedName
    /// <summary>
    ///   <para>swrc:headOfGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>added domain and range. Olivier 2006-06-07</para>
    ///   <para>made a subproperty of headOf. Olivier 2006-06-07</para>
    /// labels<para>leiterVonGruppe</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#headOfGroup">http://swrc.ontoware.org/ontology#headOfGroup</seealso>
    let headOfGroup = Prefixed_Name(swrc, "headOfGroup") |> PrefixedName
    /// <summary>
    ///   <para>swrc:cooperateWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>zusammenarbeitenMit</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#cooperateWith">http://swrc.ontoware.org/ontology#cooperateWith</seealso>
    let cooperateWith = Prefixed_Name(swrc, "cooperateWith") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Root</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// </para>
    /// labels<para>wurzel</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Root">http://swrc.ontoware.org/ontology#Root</seealso>
    let Root = Prefixed_Name(swrc, "Root") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ereignis</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Event">http://swrc.ontoware.org/ontology#Event</seealso>
    let Event = Prefixed_Name(swrc, "Event") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ResearchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Forschungsgruppe</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ResearchGroup">http://swrc.ontoware.org/ontology#ResearchGroup</seealso>
    let ResearchGroup = Prefixed_Name(swrc, "ResearchGroup") |> PrefixedName
    /// <summary>
    ///   <para>swrc:supervises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>betreut</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#supervises">http://swrc.ontoware.org/ontology#supervises</seealso>
    let supervises = Prefixed_Name(swrc, "supervises") |> PrefixedName
    /// <summary>
    ///   <para>swrc:publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>check domain. Olivier 2006-06-07
    /// Philipp: checked.</para>
    ///   <para>hasPublication (?). Olivier 2006-06-07
    /// Philipp: Yes, I think it is meant as "hasPublication". Anytime you have just the verb, it is meant as has + verb in a property.</para>
    /// labels<para>publikation</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#publication">http://swrc.ontoware.org/ontology#publication</seealso>
    let publication = Prefixed_Name(swrc, "publication") |> PrefixedName
    /// <summary>
    ///   <para>swrc:SoftwareComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Softwarekomponente</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#SoftwareComponent">http://swrc.ontoware.org/ontology#SoftwareComponent</seealso>
    let SoftwareComponent = Prefixed_Name(swrc, "SoftwareComponent") |> PrefixedName
    /// <summary>
    ///   <para>swrc:studiesAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>studiertAn</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#studiesAt">http://swrc.ontoware.org/ontology#studiesAt</seealso>
    let studiesAt = Prefixed_Name(swrc, "studiesAt") |> PrefixedName
    /// <summary>
    ///   <para>swrc:school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>meaning is not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class description of Thesis and I think should relate a Thesis to the associated university.</para>
    /// labels<para>schule</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#school">http://swrc.ontoware.org/ontology#school</seealso>
    let school = Prefixed_Name(swrc, "school") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Undergraduate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Student_ohne_Abschluss</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Undergraduate">http://swrc.ontoware.org/ontology#Undergraduate</seealso>
    let Undergraduate = Prefixed_Name(swrc, "Undergraduate") |> PrefixedName
    /// <summary>
    ///   <para>swrc:student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>student</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#student">http://swrc.ontoware.org/ontology#student</seealso>
    let student = Prefixed_Name(swrc, "student") |> PrefixedName
    /// <summary>
    ///   <para>swrc:UnrefereedArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An unrefereed article from a journal, magazine or newspaper.
    ///
    /// possible german translation for "unrefereed", also: unredigiert ?!</para>
    /// labels<para>Nicht_begutachteter_Artikel</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#UnrefereedArticle">http://swrc.ontoware.org/ontology#UnrefereedArticle</seealso>
    let UnrefereedArticle = Prefixed_Name(swrc, "UnrefereedArticle") |> PrefixedName
    /// <summary>
    ///   <para>swrc:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>zusammenfassung</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#abstract">http://swrc.ontoware.org/ontology#abstract</seealso>
    let abstract_ = Prefixed_Name(swrc, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>swrc:PhDStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Doktorand</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#PhDStudent">http://swrc.ontoware.org/ontology#PhDStudent</seealso>
    let PhDStudent = Prefixed_Name(swrc, "PhDStudent") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A peer reviewed , refereed article from a journal.</para>
    /// labels<para>Artikel</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Article">http://swrc.ontoware.org/ontology#Article</seealso>
    let Article = Prefixed_Name(swrc, "Article") |> PrefixedName
    /// <summary>
    ///   <para>swrc:FacultyMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fakultaetsmitglied</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#FacultyMember">http://swrc.ontoware.org/ontology#FacultyMember</seealso>
    let FacultyMember = Prefixed_Name(swrc, "FacultyMember") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fachbereich</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Department">http://swrc.ontoware.org/ontology#Department</seealso>
    let Department = Prefixed_Name(swrc, "Department") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A complete book, not formed from separate papers.</para>
    /// labels<para>Buch</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Book">http://swrc.ontoware.org/ontology#Book</seealso>
    let Book = Prefixed_Name(swrc, "Book") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Booklet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A work that is printed and bound but without a named publisher or sponsering institution.</para>
    /// labels<para>Broschuere</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Booklet">http://swrc.ontoware.org/ontology#Booklet</seealso>
    let Booklet = Prefixed_Name(swrc, "Booklet") |> PrefixedName
    /// <summary>
    ///   <para>swrc:edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ausgabe</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#edition">http://swrc.ontoware.org/ontology#edition</seealso>
    let edition = Prefixed_Name(swrc, "edition") |> PrefixedName
    /// <summary>
    ///   <para>swrc:AdministrativeStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Verwaltungsangestellter</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#AdministrativeStaff">http://swrc.ontoware.org/ontology#AdministrativeStaff</seealso>
    let AdministrativeStaff = Prefixed_Name(swrc, "AdministrativeStaff") |> PrefixedName
    /// <summary>
    ///   <para>swrc:AssistantProfessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Privatdozent</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#AssistantProfessor">http://swrc.ontoware.org/ontology#AssistantProfessor</seealso>
    let AssistantProfessor = Prefixed_Name(swrc, "AssistantProfessor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Exhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Messe</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Exhibition">http://swrc.ontoware.org/ontology#Exhibition</seealso>
    let Exhibition = Prefixed_Name(swrc, "Exhibition") |> PrefixedName
    /// <summary>
    ///   <para>swrc:hasParts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hatTeile</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#hasParts">http://swrc.ontoware.org/ontology#hasParts</seealso>
    let hasParts = Prefixed_Name(swrc, "hasParts") |> PrefixedName
    /// <summary>
    ///   <para>swrc:DiplomaThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Diplomarbeit</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#DiplomaThesis">http://swrc.ontoware.org/ontology#DiplomaThesis</seealso>
    let DiplomaThesis = Prefixed_Name(swrc, "DiplomaThesis") |> PrefixedName
    /// <summary>
    ///   <para>swrc:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>bemerkung</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#note">http://swrc.ontoware.org/ontology#note</seealso>
    let note = Prefixed_Name(swrc, "note") |> PrefixedName
    /// <summary>
    ///   <para>swrc:series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>serie</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#series">http://swrc.ontoware.org/ontology#series</seealso>
    let series = Prefixed_Name(swrc, "series") |> PrefixedName
    /// <summary>
    ///   <para>swrc:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>quelle</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#source">http://swrc.ontoware.org/ontology#source</seealso>
    let source = Prefixed_Name(swrc, "source") |> PrefixedName
    /// <summary>
    ///   <para>swrc:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>volume</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#volume">http://swrc.ontoware.org/ontology#volume</seealso>
    let volume = Prefixed_Name(swrc, "volume") |> PrefixedName
    /// <summary>
    ///   <para>swrc:AssociateProfessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ausserordentlicher_Professor</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#AssociateProfessor">http://swrc.ontoware.org/ontology#AssociateProfessor</seealso>
    let AssociateProfessor = Prefixed_Name(swrc, "AssociateProfessor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Enterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unternehmen</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Enterprise">http://swrc.ontoware.org/ontology#Enterprise</seealso>
    let Enterprise = Prefixed_Name(swrc, "Enterprise") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A book produced from a collection of separate papers.</para>
    /// labels<para>Sammelband</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Collection">http://swrc.ontoware.org/ontology#Collection</seealso>
    let Collection = Prefixed_Name(swrc, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Colloquium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kolloquium</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Colloquium">http://swrc.ontoware.org/ontology#Colloquium</seealso>
    let Colloquium = Prefixed_Name(swrc, "Colloquium") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Lecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Vortrag</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Lecture">http://swrc.ontoware.org/ontology#Lecture</seealso>
    let Lecture = Prefixed_Name(swrc, "Lecture") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Conference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Konferenz</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Conference">http://swrc.ontoware.org/ontology#Conference</seealso>
    let Conference = Prefixed_Name(swrc, "Conference") |> PrefixedName
    /// <summary>
    ///   <para>swrc:DevelopmentProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>disjoint with researchProject? maybe not. Olivier 2006-06-07</para>
    /// labels<para>Entwicklungsvorhaben</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#DevelopmentProject">http://swrc.ontoware.org/ontology#DevelopmentProject</seealso>
    let DevelopmentProject = Prefixed_Name(swrc, "DevelopmentProject") |> PrefixedName
    /// <summary>
    ///   <para>swrc:PhDThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A university Doctoral thesis.</para>
    /// labels<para>Doktorarbeit</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#PhDThesis">http://swrc.ontoware.org/ontology#PhDThesis</seealso>
    let PhDThesis = Prefixed_Name(swrc, "PhDThesis") |> PrefixedName
    /// <summary>
    ///   <para>swrc:MasterThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A university Masters thesis.</para>
    /// labels<para>Master_Thesis</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#MasterThesis">http://swrc.ontoware.org/ontology#MasterThesis</seealso>
    let MasterThesis = Prefixed_Name(swrc, "MasterThesis") |> PrefixedName
    /// <summary>
    ///   <para>swrc:VisitingProfessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gastdozent</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#VisitingProfessor">http://swrc.ontoware.org/ontology#VisitingProfessor</seealso>
    let VisitingProfessor = Prefixed_Name(swrc, "VisitingProfessor") |> PrefixedName
    /// <summary>
    ///   <para>swrc:chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>kapitel</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#chapter">http://swrc.ontoware.org/ontology#chapter</seealso>
    let chapter = Prefixed_Name(swrc, "chapter") |> PrefixedName
    /// <summary>
    ///   <para>swrc:citedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>zitiertVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#citedBy">http://swrc.ontoware.org/ontology#citedBy</seealso>
    let citedBy = Prefixed_Name(swrc, "citedBy") |> PrefixedName
    /// <summary>
    ///   <para>swrc:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>datum</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#date">http://swrc.ontoware.org/ontology#date</seealso>
    let date = Prefixed_Name(swrc, "date") |> PrefixedName
    /// <summary>
    ///   <para>swrc:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>teilnehmer</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#participant">http://swrc.ontoware.org/ontology#participant</seealso>
    let participant = Prefixed_Name(swrc, "participant") |> PrefixedName
    /// <summary>
    ///   <para>swrc:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>name</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#name">http://swrc.ontoware.org/ontology#name</seealso>
    let name = Prefixed_Name(swrc, "name") |> PrefixedName
    /// <summary>
    ///   <para>swrc:howpublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>veroeffentlichungsArt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#howpublished">http://swrc.ontoware.org/ontology#howpublished</seealso>
    let howpublished = Prefixed_Name(swrc, "howpublished") |> PrefixedName
    /// <summary>
    ///   <para>swrc:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>isbn</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#isbn">http://swrc.ontoware.org/ontology#isbn</seealso>
    let isbn = Prefixed_Name(swrc, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>swrc:journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>journal</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#journal">http://swrc.ontoware.org/ontology#journal</seealso>
    let journal = Prefixed_Name(swrc, "journal") |> PrefixedName
    /// <summary>
    ///   <para>swrc:keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>schlagwoerter</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#keywords">http://swrc.ontoware.org/ontology#keywords</seealso>
    let keywords = Prefixed_Name(swrc, "keywords") |> PrefixedName
    /// <summary>
    ///   <para>swrc:month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>monat</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#month">http://swrc.ontoware.org/ontology#month</seealso>
    let month = Prefixed_Name(swrc, "month") |> PrefixedName
    /// <summary>
    ///   <para>swrc:pages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>seiten</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#pages">http://swrc.ontoware.org/ontology#pages</seealso>
    let pages = Prefixed_Name(swrc, "pages") |> PrefixedName
    /// <summary>
    ///   <para>swrc:photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>foto</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#photo">http://swrc.ontoware.org/ontology#photo</seealso>
    let photo = Prefixed_Name(swrc, "photo") |> PrefixedName
    /// <summary>
    ///   <para>swrc:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.</para>
    /// labels<para>produkt</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#product">http://swrc.ontoware.org/ontology#product</seealso>
    let product = Prefixed_Name(swrc, "product") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Besprechung</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Meeting">http://swrc.ontoware.org/ontology#Meeting</seealso>
    let Meeting = Prefixed_Name(swrc, "Meeting") |> PrefixedName
    /// <summary>
    ///   <para>swrc:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ort</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#location">http://swrc.ontoware.org/ontology#location</seealso>
    let location = Prefixed_Name(swrc, "location") |> PrefixedName
    /// <summary>
    ///   <para>swrc:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>nummer</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#number">http://swrc.ontoware.org/ontology#number</seealso>
    let number = Prefixed_Name(swrc, "number") |> PrefixedName
    /// <summary>
    ///   <para>swrc:institution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>meaning not clear
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.</para>
    /// labels<para>einrichtung</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#institution">http://swrc.ontoware.org/ontology#institution</seealso>
    let institution = Prefixed_Name(swrc, "institution") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abschlussarbeit</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Thesis">http://swrc.ontoware.org/ontology#Thesis</seealso>
    let Thesis = Prefixed_Name(swrc, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>swrc:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>jahr</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#year">http://swrc.ontoware.org/ontology#year</seealso>
    let year = Prefixed_Name(swrc, "year") |> PrefixedName
    /// <summary>
    ///   <para>swrc:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>typ</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#type">http://swrc.ontoware.org/ontology#type</seealso>
    let type_ = Prefixed_Name(swrc, "type") |> PrefixedName
    /// <summary>
    ///   <para>swrc:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>zugehoerigkeit</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#affiliation">http://swrc.ontoware.org/ontology#affiliation</seealso>
    let affiliation = Prefixed_Name(swrc, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dublin Core elements added.
    /// See: http://dublincore.org/documents/dces/
    ///
    /// for document types see:
    /// http://www.bsz-bw.de/diglib/medserv/konvent/metadat/dcresour.html</para>
    /// labels<para>Dokument</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Document">http://swrc.ontoware.org/ontology#Document</seealso>
    let Document = Prefixed_Name(swrc, "Document") |> PrefixedName
    /// <summary>
    ///   <para>swrc:AcademicStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Wissenschaftlicher_Mitarbeiter</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#AcademicStaff">http://swrc.ontoware.org/ontology#AcademicStaff</seealso>
    let AcademicStaff = Prefixed_Name(swrc, "AcademicStaff") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Publikation</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Publication">http://swrc.ontoware.org/ontology#Publication</seealso>
    let Publication = Prefixed_Name(swrc, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>swrc:headOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>leiterVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#headOf">http://swrc.ontoware.org/ontology#headOf</seealso>
    let headOf = Prefixed_Name(swrc, "headOf") |> PrefixedName
    /// <summary>
    ///   <para>swrc:financedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>finanziertVon</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#financedBy">http://swrc.ontoware.org/ontology#financedBy</seealso>
    let financedBy = Prefixed_Name(swrc, "financedBy") |> PrefixedName
    /// <summary>
    ///   <para>swrc:ProjectMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Projektbesprechung</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#ProjectMeeting">http://swrc.ontoware.org/ontology#ProjectMeeting</seealso>
    let ProjectMeeting = Prefixed_Name(swrc, "ProjectMeeting") |> PrefixedName
    /// <summary>
    ///   <para>swrc:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bericht</para></remarks>
    /// <seealso href="http://swrc.ontoware.org/ontology#Report">http://swrc.ontoware.org/ontology#Report</seealso>
    let Report = Prefixed_Name(swrc, "Report") |> PrefixedName
