namespace http.purl.org.dc.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcterms =
    let _namespace_iri = Namespace_Iri dcterms |> NamespaceIRI
    /// <summary>
    ///   <para>dcterms:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/">http://purl.org/dc/terms/</seealso>
    let _prefix_iri = Prefixed_Name(dcterms, "") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:AgentClass</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A resource that acts or has the power to act."</para>
    ///   <para>"An agent (eg. person, group, software or physical artifact)."</para>
    /// labels<para>"Agent (DCMI)"</para><para>"Agent"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Agent">http://purl.org/dc/terms/Agent</seealso>
    let Agent = Prefixed_Name(dcterms, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:AgentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A group of agents."</para>
    /// labels<para>"Agent Class"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/AgentClass">http://purl.org/dc/terms/AgentClass</seealso>
    let AgentClass = Prefixed_Name(dcterms, "AgentClass") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:BibliographicResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A book, article, or other documentary resource."</para>
    /// labels<para>"Bibliographic Resource"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/BibliographicResource">http://purl.org/dc/terms/BibliographicResource</seealso>
    let BibliographicResource =
        Prefixed_Name(dcterms, "BibliographicResource") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:Box</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The set of regions in space defined by their geographic coordinates according to the DCMI Box Encoding Scheme."</para>
    /// labels<para>"DCMI Box"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Box">http://purl.org/dc/terms/Box</seealso>
    let Box = Prefixed_Name(dcterms, "Box") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Collection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/Collection">http://purl.org/dc/terms/Collection</seealso>
    let Collection = Prefixed_Name(dcterms, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:DCMIType</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:TypeScheme</para>
    ///   <para>owl:Class</para>
    ///   <para>"The set of classes specified by the DCMI Type Vocabulary, used to categorize the nature or genre of the resource."</para>
    /// labels<para>"DCMI Type Vocabulary"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/DCMIType">http://purl.org/dc/terms/DCMIType</seealso>
    let DCMIType = Prefixed_Name(dcterms, "DCMIType") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:DDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"The set of conceptual resources specified by the Dewey Decimal Classification."</para>
    /// labels<para>"DDC"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/DDC">http://purl.org/dc/terms/DDC</seealso>
    let DDC = Prefixed_Name(dcterms, "DDC") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Dataset</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/Dataset">http://purl.org/dc/terms/Dataset</seealso>
    let Dataset = Prefixed_Name(dcterms, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/Description">http://purl.org/dc/terms/Description</seealso>
    let Description = Prefixed_Name(dcterms, "Description") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Extent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/Extent">http://purl.org/dc/terms/Extent</seealso>
    let Extent = Prefixed_Name(dcterms, "Extent") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:FileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A digital resource format."</para>
    ///   <para>"The dcterms:FileFormat class fully represents the RADion concept of a file format."</para>
    /// labels<para>"File Format"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/FileFormat">http://purl.org/dc/terms/FileFormat</seealso>
    let FileFormat = Prefixed_Name(dcterms, "FileFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A rate at which something recurs."</para>
    /// labels<para>"Frequency"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Frequency">http://purl.org/dc/terms/Frequency</seealso>
    let Frequency = Prefixed_Name(dcterms, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:IMT</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The set of media types specified by the Internet Assigned Numbers Authority."</para>
    /// labels<para>"IMT"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/IMT">http://purl.org/dc/terms/IMT</seealso>
    let IMT = Prefixed_Name(dcterms, "IMT") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:ISO3166</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of codes listed in ISO 3166-1 for the representation of names of countries."</para>
    /// labels<para>"ISO 3166"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ISO3166">http://purl.org/dc/terms/ISO3166</seealso>
    let ISO3166 = Prefixed_Name(dcterms, "ISO3166") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:ISO639-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The three-letter alphabetic codes listed in ISO639-2 for the representation of names of languages."</para>
    /// labels<para>"ISO 639-2"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ISO639-2">http://purl.org/dc/terms/ISO639-2</seealso>
    let ISO639_2 = Prefixed_Name(dcterms, "ISO639-2") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:ISO639-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of three-letter codes listed in ISO 639-3 for the representation of names of languages."</para>
    /// labels<para>"ISO 639-3"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ISO639-3">http://purl.org/dc/terms/ISO639-3</seealso>
    let ISO639_3 = Prefixed_Name(dcterms, "ISO639-3") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Identifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/Identifier">http://purl.org/dc/terms/Identifier</seealso>
    let Identifier = Prefixed_Name(dcterms, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The extent or range of judicial, law enforcement, or other authority."</para>
    /// labels<para>"Jurisdiction"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Jurisdiction">http://purl.org/dc/terms/Jurisdiction</seealso>
    let Jurisdiction = Prefixed_Name(dcterms, "Jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:LCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"The set of conceptual resources specified by the Library of Congress Classification."</para>
    /// labels<para>"LCC"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LCC">http://purl.org/dc/terms/LCC</seealso>
    let LCC = Prefixed_Name(dcterms, "LCC") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:LCSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"The set of labeled concepts specified by the Library of Congress Subject Headings."</para>
    /// labels<para>"LCSH"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LCSH">http://purl.org/dc/terms/LCSH</seealso>
    let LCSH = Prefixed_Name(dcterms, "LCSH") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/License">http://purl.org/dc/terms/License</seealso>
    let License = Prefixed_Name(dcterms, "License") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:LicenseDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A legal document giving official permission to do something with a resource."</para>
    ///   <para>"A legal document giving official permission to do something with a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A legal document giving official permission to do something with a Resource."</para>
    ///   <para>"The dcterms:LicenseDocument class fully represents the RADion concept of a Licence"</para>
    /// labels<para>"License Document"</para><para>"License Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"License"</para><para>"LicenseDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LicenseDocument">http://purl.org/dc/terms/LicenseDocument</seealso>
    let LicenseDocument = Prefixed_Name(dcterms, "LicenseDocument") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:LinguisticSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The dcterms:LinguisticSystem class fully represents the RADion concept of Language."</para>
    ///   <para>"A system of signs, symbols, sounds, gestures, or rules used in communication."</para>
    /// labels<para>"Language"</para><para>"Linguistic System"</para><para>"dcterms:LinguisticSystem"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LinguisticSystem">http://purl.org/dc/terms/LinguisticSystem</seealso>
    let LinguisticSystem = Prefixed_Name(dcterms, "LinguisticSystem") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"dcterms:Location class fully represents the Location Core Vocabulary class of Location."</para>
    ///   <para>"The dcterms:Location class fully represents the RADion class of Geographic Coverage."</para>
    ///   <para>"dcterms:Location class fully represents the ISA Programme Location Core Vocabulary class of Location."</para>
    ///   <para>"A spatial region or named place."</para>
    /// labels<para>"dcterms:Location"</para><para>"Lieu"</para><para>"location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Localizzazione"</para><para>"Location"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Location">http://purl.org/dc/terms/Location</seealso>
    let Location = Prefixed_Name(dcterms, "Location") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:LocationPeriodOrJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A location, period of time, or jurisdiction."</para>
    /// labels<para>"Location, Period, or Jurisdiction"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LocationPeriodOrJurisdiction">http://purl.org/dc/terms/LocationPeriodOrJurisdiction</seealso>
    let LocationPeriodOrJurisdiction =
        Prefixed_Name(dcterms, "LocationPeriodOrJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:MESH</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The set of labeled concepts specified by the Medical Subject Headings."</para>
    /// labels<para>"MeSH"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MESH">http://purl.org/dc/terms/MESH</seealso>
    let MESH = Prefixed_Name(dcterms, "MESH") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:MediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A file format or physical medium."</para>
    /// labels<para>"Media Type"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MediaType">http://purl.org/dc/terms/MediaType</seealso>
    let MediaType = Prefixed_Name(dcterms, "MediaType") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:MediaTypeOrExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A media type or extent."</para>
    /// labels<para>"Media Type or Extent"</para><para>"Media Type Or Extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MediaTypeOrExtent">http://purl.org/dc/terms/MediaTypeOrExtent</seealso>
    let MediaTypeOrExtent = Prefixed_Name(dcterms, "MediaTypeOrExtent") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:MethodOfAccrual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A method by which resources are added to a collection."</para>
    /// labels<para>"Method of Accrual"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MethodOfAccrual">http://purl.org/dc/terms/MethodOfAccrual</seealso>
    let MethodOfAccrual = Prefixed_Name(dcterms, "MethodOfAccrual") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:MethodOfInstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A process that is used to engender knowledge, attitudes, and skills."</para>
    /// labels<para>"Method of Instruction"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MethodOfInstruction">http://purl.org/dc/terms/MethodOfInstruction</seealso>
    let MethodOfInstruction =
        Prefixed_Name(dcterms, "MethodOfInstruction") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:NLM</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The set of conceptual resources specified by the National Library of Medicine Classification."</para>
    /// labels<para>"NLM"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/NLM">http://purl.org/dc/terms/NLM</seealso>
    let NLM = Prefixed_Name(dcterms, "NLM") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The set of time intervals defined by their limits according to the DCMI Period Encoding Scheme."</para>
    /// labels<para>"DCMI Period"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Period">http://purl.org/dc/terms/Period</seealso>
    let Period = Prefixed_Name(dcterms, "Period") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:PeriodOfTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"An interval of time that is named or defined by its start and end dates."</para>
    /// labels<para>"Period Of Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Period of Time"</para><para>"dcterms:PeriodOfTime"</para><para>"Period Of Time"</para><para>"period of time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/PeriodOfTime">http://purl.org/dc/terms/PeriodOfTime</seealso>
    let PeriodOfTime = Prefixed_Name(dcterms, "PeriodOfTime") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:PhysicalMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A physical material or carrier."</para>
    /// labels<para>"Physical Medium"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/PhysicalMedium">http://purl.org/dc/terms/PhysicalMedium</seealso>
    let PhysicalMedium = Prefixed_Name(dcterms, "PhysicalMedium") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:PhysicalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A material thing."</para>
    /// labels<para>"Physical Resource"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/PhysicalResource">http://purl.org/dc/terms/PhysicalResource</seealso>
    let PhysicalResource = Prefixed_Name(dcterms, "PhysicalResource") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of points in space defined by their geographic coordinates according to the DCMI Point Encoding Scheme."</para>
    /// labels<para>"DCMI Point"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Point">http://purl.org/dc/terms/Point</seealso>
    let Point = Prefixed_Name(dcterms, "Point") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters."</para>
    /// labels<para>"Policy"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Policy">http://purl.org/dc/terms/Policy</seealso>
    let Policy = Prefixed_Name(dcterms, "Policy") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:ProvenanceStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation."</para>
    ///   <para>"A statement of any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation."</para>
    /// labels<para>"Provenance Statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Provenance Statement"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ProvenanceStatement">http://purl.org/dc/terms/ProvenanceStatement</seealso>
    let ProvenanceStatement =
        Prefixed_Name(dcterms, "ProvenanceStatement") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:RFC1766</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of tags, constructed according to RFC 1766, for the identification of languages."</para>
    /// labels<para>"RFC 1766"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC1766">http://purl.org/dc/terms/RFC1766</seealso>
    let RFC1766 = Prefixed_Name(dcterms, "RFC1766") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RFC3066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of tags constructed according to RFC 3066 for the identification of languages."</para>
    /// labels<para>"RFC 3066"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC3066">http://purl.org/dc/terms/RFC3066</seealso>
    let RFC3066 = Prefixed_Name(dcterms, "RFC3066") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RFC4646</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The set of tags constructed according to RFC 4646 for the identification of languages."</para>
    /// labels<para>"RFC 4646"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC4646">http://purl.org/dc/terms/RFC4646</seealso>
    let RFC4646 = Prefixed_Name(dcterms, "RFC4646") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RFC5646</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The set of tags constructed according to RFC 5646 for the identification of languages."</para>
    /// labels<para>"RFC 5646"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC5646">http://purl.org/dc/terms/RFC5646</seealso>
    let RFC5646 = Prefixed_Name(dcterms, "RFC5646") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A related resource."</para>
    /// labels<para>"relation"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Relation">http://purl.org/dc/terms/Relation</seealso>
    let Relation = Prefixed_Name(dcterms, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RightsStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A statement about the intellectual property rights (IPR) held in or over a resource, a legal document giving official permission to do something with a resource, or a statement about access rights."</para>
    ///   <para>"A statement about the intellectual property rights (IPR) held in or over a Resource, a legal document giving official permission to do something with a resource, or a statement about access rights."</para>
    /// labels<para>"Rights Statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Rights statement"</para><para>"Rights Statement"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RightsStatement">http://purl.org/dc/terms/RightsStatement</seealso>
    let RightsStatement = Prefixed_Name(dcterms, "RightsStatement") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:SizeOrDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A dimension or extent, or a time taken to play or execute."</para>
    /// labels<para>"Size or Duration"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/SizeOrDuration">http://purl.org/dc/terms/SizeOrDuration</seealso>
    let SizeOrDuration = Prefixed_Name(dcterms, "SizeOrDuration") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A reference point against which other things can be evaluated or compared."</para>
    ///   <para>"A basis for comparison; a reference point against which other things can be evaluated."</para>
    /// labels<para>"Standard"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Standard">http://purl.org/dc/terms/Standard</seealso>
    let Standard = Prefixed_Name(dcterms, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:SubjectScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/SubjectScheme">http://purl.org/dc/terms/SubjectScheme</seealso>
    let SubjectScheme = Prefixed_Name(dcterms, "SubjectScheme") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:TGN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"The set of places specified by the Getty Thesaurus of Geographic Names."</para>
    /// labels<para>"TGN"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/TGN">http://purl.org/dc/terms/TGN</seealso>
    let TGN = Prefixed_Name(dcterms, "TGN") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:TypeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/TypeScheme">http://purl.org/dc/terms/TypeScheme</seealso>
    let TypeScheme = Prefixed_Name(dcterms, "TypeScheme") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:UDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The set of conceptual resources specified by the Universal Decimal Classification."</para>
    /// labels<para>"UDC"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/UDC">http://purl.org/dc/terms/UDC</seealso>
    let UDC = Prefixed_Name(dcterms, "UDC") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of identifiers constructed according to the generic syntax for Uniform Resource Identifiers as specified by the Internet Engineering Task Force."</para>
    /// labels<para>"URI"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/URI">http://purl.org/dc/terms/URI</seealso>
    let URI = Prefixed_Name(dcterms, "URI") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:W3CDTF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of dates and times constructed according to the W3C Date and Time Formats Specification."</para>
    /// labels<para>"W3C-DTF"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/W3CDTF">http://purl.org/dc/terms/W3CDTF</seealso>
    let W3CDTF = Prefixed_Name(dcterms, "W3CDTF") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A summary of the resource."</para>
    /// labels<para>"Abstract"</para><para>"abstract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"abstract"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/abstract">http://purl.org/dc/terms/abstract</seealso>
    let abstract_ = Prefixed_Name(dcterms, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:accessRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Information about who can access the resource or an indication of its security status."</para>
    ///   <para>"Information about who access the resource or an indication of its security status.
    /// Access Rights may include information regarding access or restrictions based on privacy, security, or other policies.
    ///
    /// Examples of access rights are: Public, Internal, Department (source: https://www.dublincore.org/groups/government/accessRights/)"</para>
    ///   <para>"Information about who access the resource or an indication of its security status."</para>
    ///   <para>"Identifies a dct:RightsStatement or a text concerning who and how the resource can be accessed. E.g., the statement http://publications.europa.eu/resource/authority/access-right/PUBLIC informs that something is 'publicly accessible by everyone'."</para>
    /// labels<para>"access rights"</para><para>"Access Rights"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accessRights">http://purl.org/dc/terms/accessRights</seealso>
    let accessRights = Prefixed_Name(dcterms, "accessRights") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:accrualMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The method by which items are added to a collection."</para>
    /// labels<para>"accrual method"</para><para>"Accrual Method"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accrualMethod">http://purl.org/dc/terms/accrualMethod</seealso>
    let accrualMethod = Prefixed_Name(dcterms, "accrualMethod") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:accrualPeriodicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The frequency with which items are added to a collection."</para>
    ///   <para>"The frequency at which dataset is published."</para>
    /// labels<para>"Accrual Periodicity"</para><para>"accrual periodicity"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accrualPeriodicity">http://purl.org/dc/terms/accrualPeriodicity</seealso>
    let accrualPeriodicity =
        Prefixed_Name(dcterms, "accrualPeriodicity") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:accrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The policy governing the addition of items to a collection."</para>
    ///   <para>"accrual policy"</para>
    /// labels<para>"Accrual Policy"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accrualPolicy">http://purl.org/dc/terms/accrualPolicy</seealso>
    let accrualPolicy = Prefixed_Name(dcterms, "accrualPolicy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:alternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Determines an alternative title for the resource. Accepts xsd:string and rdf:langString literals. E.g., 'OntoUML/UFO Catalog'@en."</para>
    ///   <para>"The dcterms:alternative property fully represents the Person Core Vocabulary property of alternative name."</para>
    ///   <para>"An alternative name for the resource."</para>
    ///   <para>"The dcterms:alternative property fully represents the RADion property of Alternative Name."</para>
    ///   <para>"An alternative to the title."</para>
    ///   <para>"The dcterms:alternative property fully represents the Business Core Vocabulary property of alternative name."</para>
    ///   <para>"The dcterms:alternative property fully represents the
    ///       Registered Organization vocabulary property of alternative name. Some jurisdictions recognize concepts such as
    ///       a trading name or alternative forms of a legal entity's name. The alternative name property can be
    ///       used to record such names but should not be used to record translations of the primary legal name.
    ///       Where more than one legal name exists and where they have equal standing but are expressed in
    ///       different languages, identify the language used in each of the multiple legal names."</para>
    ///   <para>"An alternative title."</para>
    /// labels<para>"Alternative Title"</para><para>"Alternative title"</para><para>"alternative"</para><para>"alternative name"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/alternative">http://purl.org/dc/terms/alternative</seealso>
    let alternative = Prefixed_Name(dcterms, "alternative") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:alternativeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/alternativeName">http://purl.org/dc/terms/alternativeName</seealso>
    let alternativeName = Prefixed_Name(dcterms, "alternativeName") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A class of entity for whom the resource is intended or useful."</para>
    ///   <para>"A class of agents for whom the resource is intended or useful."</para>
    /// labels<para>"audience"</para><para>"Audience"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/audience">http://purl.org/dc/terms/audience</seealso>
    let audience = Prefixed_Name(dcterms, "audience") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"author"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/author">http://purl.org/dc/terms/author</seealso>
    let author = Prefixed_Name(dcterms, "author") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:available</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date that the resource became or will become available."</para>
    ///   <para>"Date (often a range) that the resource became or will become available."</para>
    /// labels<para>"available"</para><para>"Date Available"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/available">http://purl.org/dc/terms/available</seealso>
    let available = Prefixed_Name(dcterms, "available") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:backwardCompatibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/backwardCompatibility">http://purl.org/dc/terms/backwardCompatibility</seealso>
    let backwardCompatibility =
        Prefixed_Name(dcterms, "backwardCompatibility") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:bibliographicCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines a bibliographic reference for the dataset in textual format. Accepts xsd:string and rdf:langString literals. E.g., "Weigand, H., Johannesson, P., &amp; Andersson, B. (2021). An artifact ontology for design science research. Data &amp; Knowledge Engineering, 133."@en"</para>
    ///   <para>"A bibliographic reference for the resource."</para>
    ///   <para>"Equivalent to TEI &lt;listBibl&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-listBibl.html"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bibliographic citation"</para><para>"Bibliographic Citation"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/bibliographicCitation">http://purl.org/dc/terms/bibliographicCitation</seealso>
    let bibliographicCitation =
        Prefixed_Name(dcterms, "bibliographicCitation") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:comment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/comment">http://purl.org/dc/terms/comment</seealso>
    let comment = Prefixed_Name(dcterms, "comment") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:conformsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An established standard to which the described resource conforms."</para>
    /// labels<para>"conforms to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Conforms To"</para><para>"conforms to"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/conformsTo">http://purl.org/dc/terms/conformsTo</seealso>
    let conformsTo = Prefixed_Name(dcterms, "conformsTo") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a foaf:Agent who contributed to the development of the resource."</para>
    ///   <para>"An agent who contributes towards the algorithm."</para>
    ///   <para>"An entity responsible for making contributions to the resource."</para>
    ///   <para>"An entity that
    ///             helped create the media recording."</para>
    /// labels<para>"contributeur"</para><para>"dcterms:contributor"</para><para>"contributor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"contributor"</para><para>"Contributor"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/contributor">http://purl.org/dc/terms/contributor</seealso>
    let contributor = Prefixed_Name(dcterms, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant."</para>
    ///   <para>"The spatial or temporal topic of the resource, spatial applicability of the resource, or jurisdiction under which the resource is relevant."</para>
    /// labels<para>"Coverage"</para><para>"coverage"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/coverage">http://purl.org/dc/terms/coverage</seealso>
    let coverage = Prefixed_Name(dcterms, "coverage") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The dcterms:created property fully represents the RADion property of Date of Creation."</para>
    ///   <para>"The range defined for dcterms:created is the class of rdfs:Literal. Values used with this property therefore have to be literal values."</para>
    ///   <para>"The date of creation of the algorithm."</para>
    ///   <para>"The date on which an entity has been created."</para>
    ///   <para>"Date of creation of the resource."</para>
    ///   <para>"A data property linking something to its date of creation."</para>
    /// labels<para>"created"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"dcterms:created"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Date Created"</para><para>"created"</para><para>"has creation date"</para><para>"date created"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/created">http://purl.org/dc/terms/created</seealso>
    let created = Prefixed_Name(dcterms, "created") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An entity primarily responsible for making the resource."</para>
    ///   <para>"The person who created the algorithm."</para>
    ///   <para>"An entity responsible for making the resource."</para>
    ///   <para>"The primary
    ///             creator or performer of the media recording."</para>
    ///   <para>"An entity primarily responsible for making the resource.
    ///
    /// Examples of a Creator include a person, an organization, or a service. Typically, the name of a Creator should be used to indicate the entity."</para>
    ///   <para>"Identifies a foaf:Agent who contributed to the creation of the resource."</para>
    /// labels<para>"creator"</para><para>"Author"</para><para>"issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"dcterms:creator"</para><para>"créateur"</para><para>"creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has creator"</para><para>"Creator"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/creator">http://purl.org/dc/terms/creator</seealso>
    let creator = Prefixed_Name(dcterms, "creator") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The date the
    ///             media recording was published."</para>
    ///   <para>"A point or period of time associated with an event in the lifecycle of the resource.
    ///
    /// Date may be used to express temporal information at any level of granularity. Recommended best practice is to use an encoding scheme, such as the W3CDTF profile of ISO 8601 [http://www.w3.org/TR/NOTE-datetime]."</para>
    ///   <para>"The date of the given real-time capacity."</para>
    ///   <para>"Date may be used to express temporal information at any level of granularity. Recommended best practice is to use an encoding scheme, such as the W3CDTF profile of ISO 8601 [W3CDTF]."</para>
    ///   <para>"A point or period of time associated with an event in the lifecycle of the resource."</para>
    /// labels<para>"has date"</para><para>"Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Date"</para><para>"Fecha"</para><para>"date"</para><para>"date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/date">http://purl.org/dc/terms/date</seealso>
    let date = Prefixed_Name(dcterms, "date") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:dateAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The date of acceptance of an entity. Examples of entities to which a Date Accepted may be relevant are a thesis (accepted by a university examination board) or an article (accepted by a journal editor)."</para>
    ///   <para>"Date of acceptance of the resource."</para>
    /// labels<para>"Date Accepted"</para><para>"has acceptance date"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/dateAccepted">http://purl.org/dc/terms/dateAccepted</seealso>
    let dateAccepted = Prefixed_Name(dcterms, "dateAccepted") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:dateCopyrighted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date on which an entity has been copyrighted."</para>
    ///   <para>"Date of copyright."</para>
    ///   <para>"Date of copyright of the resource."</para>
    /// labels<para>"Date Copyrighted"</para><para>"has copyright date"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/dateCopyrighted">http://purl.org/dc/terms/dateCopyrighted</seealso>
    let dateCopyrighted = Prefixed_Name(dcterms, "dateCopyrighted") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:dateSubmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date on which an entity has been submitted. Examples of resources to which a Date Submitted may be relevant are a thesis (submitted to a university department), a grant application (submitted to a funding agency) or an article (submitted to a journal)."</para>
    ///   <para>"Date of submission of the resource."</para>
    /// labels<para>"date submitted"</para><para>"dateSubmitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has submission date"</para><para>"Date Submitted"</para><para>"Date Submitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/dateSubmitted">http://purl.org/dc/terms/dateSubmitted</seealso>
    let dateSubmitted = Prefixed_Name(dcterms, "dateSubmitted") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:definition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/definition">http://purl.org/dc/terms/definition</seealso>
    let definition = Prefixed_Name(dcterms, "definition") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Description may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the resource."</para>
    ///   <para>"An account of the resource.
    /// Description may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the resource."</para>
    ///   <para>"The dcterms:description property fully covers the RADion property of the same name."</para>
    ///   <para>"The description
    ///             associated with the media recording."</para>
    ///   <para>"A description."</para>
    ///   <para>"Class has target description."</para>
    ///   <para>"A statement that represents something in words. It is the act of describing something. The description can include, for instance, the purpose of a thing, the scope, the area of applications of a thing, the history, etc."</para>
    ///   <para>"Determines a free-text account of the resource. Accepts xsd:string and rdf:langString literals."</para>
    ///   <para>"An account of the resource."</para>
    /// labels<para>"description"</para><para>"Description"</para><para>"Descripción"</para><para>"dcterms:description"</para><para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/description">http://purl.org/dc/terms/description</seealso>
    let description = Prefixed_Name(dcterms, "description") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:downloadURL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/downloadURL">http://purl.org/dc/terms/downloadURL</seealso>
    let downloadURL = Prefixed_Name(dcterms, "downloadURL") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:educationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A class of agents, defined in terms of progression through an educational or training context, for which the described resource is intended."</para>
    ///   <para>"A class of entity, defined in terms of progression through an educational or training context, for which the described resource is intended."</para>
    /// labels<para>"Audience Education Level"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/educationLevel">http://purl.org/dc/terms/educationLevel</seealso>
    let educationLevel = Prefixed_Name(dcterms, "educationLevel") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:extend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/extend">http://purl.org/dc/terms/extend</seealso>
    let extend = Prefixed_Name(dcterms, "extend") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The size or duration of the resource."</para>
    /// labels<para>"Extent"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/extent">http://purl.org/dc/terms/extent</seealso>
    let extent = Prefixed_Name(dcterms, "extent") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:firstName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/firstName">http://purl.org/dc/terms/firstName</seealso>
    let firstName = Prefixed_Name(dcterms, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The file format, physical medium, or dimensions of the resource.
    ///
    /// Examples of dimensions include size and duration. Recommended best practice is to use a controlled vocabulary such as the list of Internet Media Types."</para>
    ///   <para>"The file format, physical medium, or dimensions of the resource."</para>
    ///   <para>"The dcterms:format property fully represents the RADion relationship of the same name"</para>
    ///   <para>"Identifies the format of the distribution. This property should be used to complement dcat:mediaType when the distribution format is not listed by IANA. We limit the use of this property with URIs so that more context about how to manipulate a distribution can be provided. E.g., https://www.file-extension.info/format/vpp."</para>
    /// labels<para>"Format"</para><para>"Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"format"</para><para>"format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has format"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/format">http://purl.org/dc/terms/format</seealso>
    let format = Prefixed_Name(dcterms, "format") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A related resource that is substantially the same as the pre-existing described resource, but in another format."</para>
    ///   <para>"a related resource that is substantially the same as the pre-existing described resource, but in another format."</para>
    /// labels<para>"has format"</para><para>"Has Format"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/hasFormat">http://purl.org/dc/terms/hasFormat</seealso>
    let hasFormat = Prefixed_Name(dcterms, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"The dcterms:hasPart property fully represents the RADion relationship of includes."</para>
    ///   <para>"A related resource that is included either physically or logically in the described resource."</para>
    ///   <para>"This property is intended to be used with non-literal values. This property is an inverse property of Is Part Of."</para>
    ///   <para>"A related resource that is included either physically or logically in the described resource.(https://www.dublincore.org/specifications/dublin-core/dcmi-terms/#http://purl.org/dc/terms/isPartOf)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Part"</para><para>"a pour partie"</para><para>"includes"</para><para>"has Part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has part"</para><para>"hasPart"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/hasPart">http://purl.org/dc/terms/hasPart</seealso>
    let hasPart = Prefixed_Name(dcterms, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A related resource that is a version, edition, or adaptation of the described resource."</para>
    ///   <para>"A related resource (e.g., algorithm, program) that is a version, edition, or adaptation of the described resource."</para>
    ///   <para>"a related resource that is a version, edition, or adaptation of the described resource."</para>
    /// labels<para>"has Version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has verison"</para><para>"Has Version"</para><para>"dcterms:hasVersion"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/hasVersion">http://purl.org/dc/terms/hasVersion</seealso>
    let hasVersion = Prefixed_Name(dcterms, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"dcterms:identifier fully represents the Core Vocabulary property of the same name"</para>
    ///   <para>"A unique and unambiguous reference to the resource within a given context.
    ///
    /// Recommended best practice is to identify the resource by means of a string conforming to a formal identification system."</para>
    ///   <para>"An identifier."</para>
    ///   <para>"An unambiguous reference to the resource within a given context."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The range defined for dcterms:identifier is the class of rdfs:Literal. Values used with dcterms:identifier have to be instances of this class. Therefore this property can only be used with literal values."</para>
    ///   <para>"An unambiguous reference to the resource within a given context."</para>
    ///   <para>"An unambiguous reference to the resource within a given context.
    ///
    /// Recommended best practice is to identify the resource by means of a string conforming to a formal identification system.
    ///
    /// ESCO note:
    /// ESCO formats identiefers using
    /// {qualifier}:{identifier}
    ///
    /// {qualifier} is one of:
    /// CEFR: Common European Framework of Reference for Languages: Learning, Teaching, Assessment
    /// EQF: European Qualifications Framework identifer
    /// ISCED 2013 FoET: UNESCO ISCED 2013/FoET identifier for
    /// ESCO-CTC: Esco tool CTC
    /// ESCO ITM: ESCO TMS tool (ITM - from Mondeca)
    /// ESCO-TM: Esco tool for Text Mining
    /// ISO 3166-1.A2: 2 character ISO 3166 country code
    /// ISO 3166-1.A3: 3 character ISO 3166 country code
    /// ISO 3166-1.num: Numeric ISO 3166 country identifier
    /// ISO 639.1: The ISO 639-1 code (2 characters)
    /// ISO 639.2T: The ISO 639-2 terminological code (3 characters)
    /// ISO 639.2B: The ISO 639-2 bibliographic code (3 characters)
    /// ISO 639.3: The ISO 639-3 code (3 characters) – typical for use on sign languages
    /// NACE rev 2: NACE rev 2 industry sector identifiers
    /// NUTS 2008: The NUTS classification (Nomenclature of territorial units for statistics) is a hierarchical system for dividing up the economic territory of the EU"</para>
    /// labels<para>"has identifier"</para><para>"identifer"</para><para>"dcterms:identifier"</para><para>"identifier"</para><para>"identificativo"</para><para>"Identifier"</para><para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/identifier">http://purl.org/dc/terms/identifier</seealso>
    let identifier = Prefixed_Name(dcterms, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:imports</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/imports">http://purl.org/dc/terms/imports</seealso>
    let imports = Prefixed_Name(dcterms, "imports") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:instructionalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support."</para>
    /// labels<para>"Instructional Method"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/instructionalMethod">http://purl.org/dc/terms/instructionalMethod</seealso>
    let instructionalMethod =
        Prefixed_Name(dcterms, "instructionalMethod") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:isBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A related resource of which the described resource is a performance, production, derivation, translation or interpretation."</para>
    /// labels<para>"Has Version"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isBasedOn">http://purl.org/dc/terms/isBasedOn</seealso>
    let isBasedOn = Prefixed_Name(dcterms, "isBasedOn") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isBasisFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A related resource that is a performance, production, derivation, translation or interpretation of the described resource."</para>
    /// labels<para>"Is Version Of"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isBasisFor">http://purl.org/dc/terms/isBasisFor</seealso>
    let isBasisFor = Prefixed_Name(dcterms, "isBasisFor") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/isDescribedBy">http://purl.org/dc/terms/isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(dcterms, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isFormatOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A pre-existing related resource that is substantially the same as the described resource, but in another format."</para>
    ///   <para>"A related resource that is substantially the same as the described resource, but in another format."</para>
    ///   <para>"a related resource that is substantially the same as the described resource, but in another format."</para>
    /// labels<para>"is format of"</para><para>"Is Format Of"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isFormatOf">http://purl.org/dc/terms/isFormatOf</seealso>
    let isFormatOf = Prefixed_Name(dcterms, "isFormatOf") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"A related resource in which the described resource is physically or logically included."</para>
    ///   <para>"A related resource in which the described resource is physically or logically included.(https://www.dublincore.org/specifications/dublin-core/dcmi-terms/#http://purl.org/dc/terms/isPartOf)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The dcterms:isPartOf property fully represents the RADion relationship of repository origin.."</para>
    ///   <para>"This property is intended to be used with non-literal values. This property is an inverse property of Has Part."</para>
    /// labels<para>"is part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"fait partie de"</para><para>"Is Part Of"</para><para>"is Part Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"repository origin"</para><para>"Is Part Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"isPartOf"</para><para>"is part of"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isPartOf">http://purl.org/dc/terms/isPartOf</seealso>
    let isPartOf = Prefixed_Name(dcterms, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A related resource that references, cites, or otherwise points to the described resource."</para>
    /// labels<para>"Is Referenced By"</para><para>"isReferencedBy"</para><para>"is referenced by"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isReferencedBy">http://purl.org/dc/terms/isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(dcterms, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isReplacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A related resource that supplants, displaces, or supersedes the described resource."</para>
    /// labels<para>"Is Replaced By"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isReplacedBy">http://purl.org/dc/terms/isReplacedBy</seealso>
    let isReplacedBy = Prefixed_Name(dcterms, "isReplacedBy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isRequiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A related resource that requires the described resource to support its function, delivery, or coherence."</para>
    /// labels<para>"Is Required By"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isRequiredBy">http://purl.org/dc/terms/isRequiredBy</seealso>
    let isRequiredBy = Prefixed_Name(dcterms, "isRequiredBy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A related resource of which the described resource is a version, edition, or adaptation."</para>
    ///   <para>"A related resource (e.g., algorithm, program) of which the described resource is a version, edition, or adaptation."</para>
    /// labels<para>"is Version Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Is Version Of"</para><para>"dcterms:isVersionOf"</para><para>"is version of"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isVersionOf">http://purl.org/dc/terms/isVersionOf</seealso>
    let isVersionOf = Prefixed_Name(dcterms, "isVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Date of formal issuance (e.g., publication) of the resource."</para>
    ///   <para>"Date of formal issuance of a resource (e.g. a publication or a patent)."</para>
    ///   <para>"Determines when the resource was created. Accepts literals of the types xsd:dateTime, xsd:date, xsd:gYearMonth, and xsd:gYear. E.g., "2018"string^string^xsd:gYear, "2018-01-15"string^string^xsd:date. When cataloging a model from documents, we recommend using the publication date from the first one."</para>
    ///   <para>"Date of formal issuance of the resource."</para>
    /// labels<para>"dcterms:issued"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has issue date"</para><para>"issued"</para><para>"issued on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"date issued"</para><para>"Issued"</para><para>"Date Issued"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/issued">http://purl.org/dc/terms/issued</seealso>
    let issued = Prefixed_Name(dcterms, "issued") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A language of the resource."</para>
    ///   <para>"The dcterms:language property fully represents the RADion property of the same name."</para>
    ///   <para>"A language of the resource. Examples include written, spoken, sign, and computer languages.
    ///
    /// Recommended best practice is to use a controlled vocabulary such as RFC 4646 [http://www.ietf.org/rfc/rfc4646.txt]."</para>
    ///   <para>"Determines a language in which the lexical labels of the semantic artefact are written. We require the use of values listed in the IANA Language Sub Tag Registry. E.g., 'en', 'pt'."</para>
    /// labels<para>"has language"</para><para>"language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"language"</para><para>"Language"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/language">http://purl.org/dc/terms/language</seealso>
    let language = Prefixed_Name(dcterms, "language") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:lastModified</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/lastModified">http://purl.org/dc/terms/lastModified</seealso>
    let lastModified = Prefixed_Name(dcterms, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:lastName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/lastName">http://purl.org/dc/terms/lastName</seealso>
    let lastName = Prefixed_Name(dcterms, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:licence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/licence">http://purl.org/dc/terms/licence</seealso>
    let licence = Prefixed_Name(dcterms, "licence") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The dcterms:license property fully represents the RADion relationship of the same name."</para>
    ///   <para>"Identifies a legal document under which the resource is made available. E.g., https://creativecommons.org/licenses/by/4.0/."</para>
    ///   <para>"The licence under which the algorithm is published."</para>
    ///   <para>"A legal document giving official permission to do something with the resource."</para>
    /// labels<para>"License"</para><para>"has license"</para><para>"license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"license"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/license">http://purl.org/dc/terms/license</seealso>
    let license = Prefixed_Name(dcterms, "license") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:mediator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An entity that mediates access to the resource and for whom the resource is intended or useful."</para>
    ///   <para>"An entity that mediates access to the resource."</para>
    /// labels<para>"Mediator"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/mediator">http://purl.org/dc/terms/mediator</seealso>
    let mediator = Prefixed_Name(dcterms, "mediator") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The material or physical carrier of the resource."</para>
    /// labels<para>"Medium"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/medium">http://purl.org/dc/terms/medium</seealso>
    let medium = Prefixed_Name(dcterms, "medium") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:modifed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/modifed">http://purl.org/dc/terms/modifed</seealso>
    let modifed = Prefixed_Name(dcterms, "modifed") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The dcterms:modified property fully represents the RADion property Date of Last Modification."</para>
    ///   <para>"Date on which the resource was changed."</para>
    ///   <para>"The date on which an entity has been modified."</para>
    ///   <para>"Determines when the resource was last modified. Accepts literals of the types xsd:dateTime, xsd:date, xsd:gYearMonth, and xsd:gYear. When cataloging a model based on documents, we recommend using the publication date from the latest one."</para>
    /// labels<para>"has modification date"</para><para>"Date Modified"</para><para>"modified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Date modified"</para><para>"Modified"</para><para>"date modified"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/modified">http://purl.org/dc/terms/modified</seealso>
    let modified = Prefixed_Name(dcterms, "modified") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:motified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/motified">http://purl.org/dc/terms/motified</seealso>
    let motified = Prefixed_Name(dcterms, "motified") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/name">http://purl.org/dc/terms/name</seealso>
    let name = Prefixed_Name(dcterms, "name") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/partOf">http://purl.org/dc/terms/partOf</seealso>
    let partOf = Prefixed_Name(dcterms, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:previousVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/terms/previousVersion">http://purl.org/dc/terms/previousVersion</seealso>
    let previousVersion = Prefixed_Name(dcterms, "previousVersion") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation."</para>
    /// labels<para>"Provenance"</para><para>"provenance"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/provenance">http://purl.org/dc/terms/provenance</seealso>
    let provenance = Prefixed_Name(dcterms, "provenance") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An entity responsible for making the resource available."</para>
    ///   <para>"The dcterms:publisher property fully represents the RADion relationship of the same name"</para>
    ///   <para>"Identifies the foaf:Agent who added the resource to the catalog. The publisher does not need to have created or contributed to the resource."</para>
    ///   <para>"An entity responsible for making the resource available.
    ///
    /// Examples of a Publisher include a person, an organization, or a service. Typically, the name of a Publisher should be used to indicate the entity."</para>
    /// labels<para>"Publisher"</para><para>"publisher"</para><para>"éditeur"</para><para>"has publisher"</para><para>"publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/publisher">http://purl.org/dc/terms/publisher</seealso>
    let publisher = Prefixed_Name(dcterms, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A related resource that is referenced, cited, or otherwise pointed to by the described resource."</para>
    /// labels<para>"References"</para><para>"references"</para><para>"references"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/references">http://purl.org/dc/terms/references</seealso>
    let references = Prefixed_Name(dcterms, "references") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"The dcterms:relation property fully represents the RADion related asset property."</para>
    ///   <para>"A related resource.
    /// For example, a Sorting problem is related to a problem Convex Hull."</para>
    ///   <para>"A related resource."</para>
    /// labels<para>"relation"</para><para>"Relation"</para><para>"relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has relation"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/relation">http://purl.org/dc/terms/relation</seealso>
    let relation = Prefixed_Name(dcterms, "relation") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A related resource that is supplanted, displaced, or superseded by the described resource."</para>
    /// labels<para>"replaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Replaces"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/replaces">http://purl.org/dc/terms/replaces</seealso>
    let replaces = Prefixed_Name(dcterms, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A related resource that is required by the described resource to support its function, delivery, or coherence."</para>
    /// labels<para>"Requires"</para><para>"requires"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/requires">http://purl.org/dc/terms/requires</seealso>
    let requires = Prefixed_Name(dcterms, "requires") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:revised</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/revised">http://purl.org/dc/terms/revised</seealso>
    let revised = Prefixed_Name(dcterms, "revised") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information about rights held in and over the resource."</para>
    ///   <para>"Information about rights held in and over the resource.
    ///
    /// Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights."</para>
    /// labels<para>"has rights"</para><para>"dcterms:rights"</para><para>"rights"</para><para>"Rights"</para><para>"rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/rights">http://purl.org/dc/terms/rights</seealso>
    let rights = Prefixed_Name(dcterms, "rights") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:rightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A person or organization owning or managing rights over the resource."</para>
    /// labels<para>"rights holder"</para><para>"rightsHolder"</para><para>"Rights Holder"</para><para>"owner"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/rightsHolder">http://purl.org/dc/terms/rightsHolder</seealso>
    let rightsHolder = Prefixed_Name(dcterms, "rightsHolder") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:rightsholder</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/rightsholder">http://purl.org/dc/terms/rightsholder</seealso>
    let rightsholder = Prefixed_Name(dcterms, "rightsholder") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Un recurso relacionado de donde  resource from which the described resource is derived."</para>
    ///   <para>"A related resource from which the described resource is derived."</para>
    ///   <para>"Identifies resources that contain, present, or significantly influenced the development of the semantic artefact. We recommend the use of persistent and resolvable identifiers to refer to these resources, such as the Digital Object Identifier (DOI) or DBLP's URI. E.g., https://doi.org/10.3233/AO-150150, https://dblp.org/rec/journals/ao/Morales-Ramirez15."</para>
    /// labels<para>"Fuente"</para><para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Source"</para><para>"dcterms:source"</para><para>"source"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/source">http://purl.org/dc/terms/source</seealso>
    let source = Prefixed_Name(dcterms, "source") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The dcterms:spatial property fully represents the RADion relationship of spatial coverage."</para>
    ///   <para>"Spatial characteristics of the resource."</para>
    /// labels<para>"Spatial Coverage"</para><para>"spatial coverage"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/spatial">http://purl.org/dc/terms/spatial</seealso>
    let spatial = Prefixed_Name(dcterms, "spatial") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An enumeration of substances that may cause allergic reactions"</para>
    /// labels<para>"Allergens"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/status">http://purl.org/dc/terms/status</seealso>
    let status = Prefixed_Name(dcterms, "status") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A topic of the resource."</para>
    ///   <para>"The topic of the resource."</para>
    ///   <para>"The dcterms:subject property fully represents the RADion properties of theme and theme taxonomy."</para>
    /// labels<para>"subject"</para><para>"Subject"</para><para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"theme, theme taxonomy"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/subject">http://purl.org/dc/terms/subject</seealso>
    let subject = Prefixed_Name(dcterms, "subject") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:tableOfContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A list of subunits of the resource."</para>
    /// labels<para>"Table Of Contents"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/tableOfContents">http://purl.org/dc/terms/tableOfContents</seealso>
    let tableOfContents = Prefixed_Name(dcterms, "tableOfContents") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Temporal characteristics of the resource."</para>
    /// labels<para>"temporal coverage"</para><para>"temporal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Temporal Coverage"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/temporal">http://purl.org/dc/terms/temporal</seealso>
    let temporal = Prefixed_Name(dcterms, "temporal") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Describes the title of an entity (e.g. idea title, idea contest tile, review title etc.)."</para>
    ///   <para>"A name given to the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"http://purl.org/dc/terms/"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Determines a title for the resource. Accepts xsd:string and rdf:langString literals. E.g., "Common Ontology of Value and Risk"@en, "FAIR Model Catalog for Ontology-Driven Conceptual Modeling Research"@en. There must be at most one title per language."</para>
    ///   <para>"A name given to a resource.  Typically, the title will be the name by which the resource is formally known."</para>
    ///   <para>"A name given to the resource (e.g., book, algorithm, research software)."</para>
    ///   <para>"A name given to the resource."</para>
    ///   <para>"A title."</para>
    ///   <para>"title of the
    ///             media recording"</para>
    ///   <para>"Class has target title."</para>
    /// labels<para>"title"</para><para>"has title"</para><para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Título"</para><para>"Title"</para><para>"Food Wastage Ontology"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/title">http://purl.org/dc/terms/title</seealso>
    let title = Prefixed_Name(dcterms, "title") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The dcterms:type property fully represents the RADion property of type."</para>
    ///   <para>"The nature or genre of the resource."</para>
    ///   <para>"A genre that
    ///             should be associated with the media recording."</para>
    ///   <para>"Recommended best practice is to use a controlled vocabulary such as the DCMI Type Vocabulary [DCMITYPE]. To describe the file format, physical medium, or dimensions of the resource, use the Format element. The nature or genre of the resource."</para>
    /// labels<para>"Type"</para><para>"type"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/type">http://purl.org/dc/terms/type</seealso>
    let type_ = Prefixed_Name(dcterms, "type") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:valid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Date (often a range) of validity of a resource."</para>
    /// labels<para>"Date Valid"</para><para>"has validity date"</para><para>"valid"</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/valid">http://purl.org/dc/terms/valid</seealso>
    let valid = Prefixed_Name(dcterms, "valid") |> PrefixedName
