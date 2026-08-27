namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.People.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_aap_ppl =
    let _namespace_iri = Namespace_Iri fibo_fnd_aap_ppl |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"People Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_aap_ppl, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:Adult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"adult"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Adult">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Adult</seealso>
    let Adult = Prefixed_Name(fibo_fnd_aap_ppl, "Adult") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:AgeOfMajority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"age of majority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/AgeOfMajority">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/AgeOfMajority</seealso>
    let AgeOfMajority = Prefixed_Name(fibo_fnd_aap_ppl, "AgeOfMajority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:BirthCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"birth certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificate">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificate</seealso>
    let BirthCertificate =
        Prefixed_Name(fibo_fnd_aap_ppl, "BirthCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:BirthCertificateIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"birth certificate identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentificationScheme</seealso>
    let BirthCertificateIdentificationScheme =
        Prefixed_Name(fibo_fnd_aap_ppl, "BirthCertificateIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:BirthCertificateIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"birth certificate identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentifier</seealso>
    let BirthCertificateIdentifier =
        Prefixed_Name(fibo_fnd_aap_ppl, "BirthCertificateIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Contact">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Contact</seealso>
    let Contact = Prefixed_Name(fibo_fnd_aap_ppl, "Contact") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:ContactRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contact record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/ContactRecord">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/ContactRecord</seealso>
    let ContactRecord = Prefixed_Name(fibo_fnd_aap_ppl, "ContactRecord") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date of birth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfBirth">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfBirth</seealso>
    let DateOfBirth = Prefixed_Name(fibo_fnd_aap_ppl, "DateOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date of death"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfDeath">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfDeath</seealso>
    let DateOfDeath = Prefixed_Name(fibo_fnd_aap_ppl, "DateOfDeath") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DeathCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"death certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificate">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificate</seealso>
    let DeathCertificate =
        Prefixed_Name(fibo_fnd_aap_ppl, "DeathCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DeathCertificateIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"death certificate identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentificationScheme</seealso>
    let DeathCertificateIdentificationScheme =
        Prefixed_Name(fibo_fnd_aap_ppl, "DeathCertificateIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DeathCertificateIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"death certificate identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentifier</seealso>
    let DeathCertificateIdentifier =
        Prefixed_Name(fibo_fnd_aap_ppl, "DeathCertificateIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DriversLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"driver's license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicense">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicense</seealso>
    let DriversLicense =
        Prefixed_Name(fibo_fnd_aap_ppl, "DriversLicense") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DriversLicenseIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"driver's license identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentificationScheme</seealso>
    let DriversLicenseIdentificationScheme =
        Prefixed_Name(fibo_fnd_aap_ppl, "DriversLicenseIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:DriversLicenseIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"driver's license identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentifier</seealso>
    let DriversLicenseIdentifier =
        Prefixed_Name(fibo_fnd_aap_ppl, "DriversLicenseIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:EmancipatedMinor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"emancipated minor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/EmancipatedMinor">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/EmancipatedMinor</seealso>
    let EmancipatedMinor =
        Prefixed_Name(fibo_fnd_aap_ppl, "EmancipatedMinor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:IdentityDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"identity document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IdentityDocument">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IdentityDocument</seealso>
    let IdentityDocument =
        Prefixed_Name(fibo_fnd_aap_ppl, "IdentityDocument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:IncapacitatedAdult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"incapacitated adult"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IncapacitatedAdult">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IncapacitatedAdult</seealso>
    let IncapacitatedAdult =
        Prefixed_Name(fibo_fnd_aap_ppl, "IncapacitatedAdult") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:LegalAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalAge">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalAge</seealso>
    let LegalAge = Prefixed_Name(fibo_fnd_aap_ppl, "LegalAge") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:LegalWorkingAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal working age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAge">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAge</seealso>
    let LegalWorkingAge =
        Prefixed_Name(fibo_fnd_aap_ppl, "LegalWorkingAge") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:LegalWorkingAgePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal working age person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAgePerson">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAgePerson</seealso>
    let LegalWorkingAgePerson =
        Prefixed_Name(fibo_fnd_aap_ppl, "LegalWorkingAgePerson") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:LegallyCapableAdult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legally capable adult"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegallyCapableAdult">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegallyCapableAdult</seealso>
    let LegallyCapableAdult =
        Prefixed_Name(fibo_fnd_aap_ppl, "LegallyCapableAdult") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:Minor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"minor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Minor">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Minor</seealso>
    let Minor = Prefixed_Name(fibo_fnd_aap_ppl, "Minor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:NationalIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"national identification number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumber">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumber</seealso>
    let NationalIdentificationNumber =
        Prefixed_Name(fibo_fnd_aap_ppl, "NationalIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:NationalIdentificationNumberScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"national identification number scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumberScheme">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumberScheme</seealso>
    let NationalIdentificationNumberScheme =
        Prefixed_Name(fibo_fnd_aap_ppl, "NationalIdentificationNumberScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:Passport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"passport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Passport">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Passport</seealso>
    let Passport = Prefixed_Name(fibo_fnd_aap_ppl, "Passport") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:PassportNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"passport number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumber">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumber</seealso>
    let PassportNumber =
        Prefixed_Name(fibo_fnd_aap_ppl, "PassportNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:PassportNumberIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"passport number identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumberIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumberIdentificationScheme</seealso>
    let PassportNumberIdentificationScheme =
        Prefixed_Name(fibo_fnd_aap_ppl, "PassportNumberIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"person"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Person">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Person</seealso>
    let Person = Prefixed_Name(fibo_fnd_aap_ppl, "Person") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:PersonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"person name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PersonName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PersonName</seealso>
    let PersonName = Prefixed_Name(fibo_fnd_aap_ppl, "PersonName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:PlaceOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"place of birth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PlaceOfBirth">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PlaceOfBirth</seealso>
    let PlaceOfBirth = Prefixed_Name(fibo_fnd_aap_ppl, "PlaceOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasAgeOfMajority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has age of majority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasAgeOfMajority">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasAgeOfMajority</seealso>
    let hasAgeOfMajority =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasAgeOfMajority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasCitizenship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has citizenship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasCitizenship">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasCitizenship</seealso>
    let hasCitizenship =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasCitizenship") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasDateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date of birth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfBirth">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfBirth</seealso>
    let hasDateOfBirth =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasDateOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasDateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date of death"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfDeath">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfDeath</seealso>
    let hasDateOfDeath =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasDateOfDeath") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasFamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has family name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFamilyName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFamilyName</seealso>
    let hasFamilyName = Prefixed_Name(fibo_fnd_aap_ppl, "hasFamilyName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasFirstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has first name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFirstName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFirstName</seealso>
    let hasFirstName = Prefixed_Name(fibo_fnd_aap_ppl, "hasFirstName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasFullLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has full legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFullLegalName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFullLegalName</seealso>
    let hasFullLegalName =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasFullLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGender">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGender</seealso>
    let hasGender = Prefixed_Name(fibo_fnd_aap_ppl, "hasGender") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasGivenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has given name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGivenName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGivenName</seealso>
    let hasGivenName = Prefixed_Name(fibo_fnd_aap_ppl, "hasGivenName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasLastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has last name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasLastName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasLastName</seealso>
    let hasLastName = Prefixed_Name(fibo_fnd_aap_ppl, "hasLastName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasMaidenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has maiden name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMaidenName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMaidenName</seealso>
    let hasMaidenName = Prefixed_Name(fibo_fnd_aap_ppl, "hasMaidenName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasMiddleNameOrInitial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has middle name or initial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMiddleNameOrInitial">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMiddleNameOrInitial</seealso>
    let hasMiddleNameOrInitial =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasMiddleNameOrInitial") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasMinimumLegalWorkingAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has minimum legal working age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMinimumLegalWorkingAge">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMinimumLegalWorkingAge</seealso>
    let hasMinimumLegalWorkingAge =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasMinimumLegalWorkingAge") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasNamePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNamePrefix">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNamePrefix</seealso>
    let hasNamePrefix = Prefixed_Name(fibo_fnd_aap_ppl, "hasNamePrefix") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasNameSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNameSuffix">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNameSuffix</seealso>
    let hasNameSuffix = Prefixed_Name(fibo_fnd_aap_ppl, "hasNameSuffix") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasPersonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has person name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPersonName">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPersonName</seealso>
    let hasPersonName = Prefixed_Name(fibo_fnd_aap_ppl, "hasPersonName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasPlaceOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has place of birth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPlaceOfBirth">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPlaceOfBirth</seealso>
    let hasPlaceOfBirth =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasPlaceOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasPointOfContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has point of contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPointOfContact">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPointOfContact</seealso>
    let hasPointOfContact =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasPointOfContact") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasPrimaryResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has primary residence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPrimaryResidence">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPrimaryResidence</seealso>
    let hasPrimaryResidence =
        Prefixed_Name(fibo_fnd_aap_ppl, "hasPrimaryResidence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has residence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasResidence">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasResidence</seealso>
    let hasResidence = Prefixed_Name(fibo_fnd_aap_ppl, "hasResidence") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:hasSurname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has surname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasSurname">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasSurname</seealso>
    let hasSurname = Prefixed_Name(fibo_fnd_aap_ppl, "hasSurname") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-ppl:isPointOfContactFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is point of contact for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/isPointOfContactFor">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/isPointOfContactFor</seealso>
    let isPointOfContactFor =
        Prefixed_Name(fibo_fnd_aap_ppl, "isPointOfContactFor") |> PrefixedName
