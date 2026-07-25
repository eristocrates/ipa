namespace http.lod.taxonconcept.org.ontology.txn.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module txn =
    let _namespace_iri = Namespace_Iri txn |> NamespaceIRI
    /// <summary>
    ///   <para>txn:Sex_female</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:Sex</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>female</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_female">http://lod.taxonconcept.org/ontology/txn.owl#Sex_female</seealso>
    let Sex_female = Prefixed_Name(txn, "Sex_female") |> PrefixedName
    /// <summary>
    ///   <para>txn:Sex_undetermined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:Sex</para>
    ///
    /// labels<para>Sex Undetermined</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_undetermined">http://lod.taxonconcept.org/ontology/txn.owl#Sex_undetermined</seealso>
    let Sex_undetermined = Prefixed_Name(txn, "Sex_undetermined") |> PrefixedName
    /// <summary>
    ///   <para>txn:BinomialNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>BinomialNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#BinomialNameID">http://lod.taxonconcept.org/ontology/txn.owl#BinomialNameID</seealso>
    let BinomialNameID = Prefixed_Name(txn, "BinomialNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:ScientificNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ScientificNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameID">http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameID</seealso>
    let ScientificNameID = Prefixed_Name(txn, "ScientificNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:DataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>DataObject</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#DataObject">http://lod.taxonconcept.org/ontology/txn.owl#DataObject</seealso>
    let DataObject = Prefixed_Name(txn, "DataObject") |> PrefixedName
    /// <summary>
    ///   <para>txn:FamilyNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FamilyNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#FamilyNameID">http://lod.taxonconcept.org/ontology/txn.owl#FamilyNameID</seealso>
    let FamilyNameID = Prefixed_Name(txn, "FamilyNameID") |> PrefixedName

    /// <summary>
    ///   <para>txn:ScientificDataCuratorPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Someone who has curated or entered data into a scientific data set.</para>
    /// labels<para>ScientificDataCuratorPerson</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificDataCuratorPerson">http://lod.taxonconcept.org/ontology/txn.owl#ScientificDataCuratorPerson</seealso>
    let ScientificDataCuratorPerson =
        Prefixed_Name(txn, "ScientificDataCuratorPerson") |> PrefixedName

    /// <summary>
    ///   <para>txn:ScientificNameWithAuthorID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ScientificNameWithAuthorID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameWithAuthorID">http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameWithAuthorID</seealso>
    let ScientificNameWithAuthorID =
        Prefixed_Name(txn, "ScientificNameWithAuthorID") |> PrefixedName

    /// <summary>
    ///   <para>txn:Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sex</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Sex">http://lod.taxonconcept.org/ontology/txn.owl#Sex</seealso>
    let Sex = Prefixed_Name(txn, "Sex") |> PrefixedName
    /// <summary>
    ///   <para>txn:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>country</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#country">http://lod.taxonconcept.org/ontology/txn.owl#country</seealso>
    let country = Prefixed_Name(txn, "country") |> PrefixedName
    /// <summary>
    ///   <para>txn:uniprotGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotGenus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotGenus">http://lod.taxonconcept.org/ontology/txn.owl#uniprotGenus</seealso>
    let uniprotGenus = Prefixed_Name(txn, "uniprotGenus") |> PrefixedName
    /// <summary>
    ///   <para>txn:Sex_male</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>txn:Sex</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>male</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_male">http://lod.taxonconcept.org/ontology/txn.owl#Sex_male</seealso>
    let Sex_male = Prefixed_Name(txn, "Sex_male") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Subpecies</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubpecies">http://lod.taxonconcept.org/ontology/txn.owl#RankSubpecies</seealso>
    let RankSubpecies = Prefixed_Name(txn, "RankSubpecies") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Subdivision</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdivision">http://lod.taxonconcept.org/ontology/txn.owl#RankSubdivision</seealso>
    let RankSubdivision = Prefixed_Name(txn, "RankSubdivision") |> PrefixedName

    /// <summary>
    ///   <para>txn:RankSubspecificAggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank SubspecificAggregate</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubspecificAggregate">http://lod.taxonconcept.org/ontology/txn.owl#RankSubspecificAggregate</seealso>
    let RankSubspecificAggregate =
        Prefixed_Name(txn, "RankSubspecificAggregate") |> PrefixedName

    /// <summary>
    ///   <para>txn:RankSuperdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Superdivision</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperdivision">http://lod.taxonconcept.org/ontology/txn.owl#RankSuperdivision</seealso>
    let RankSuperdivision = Prefixed_Name(txn, "RankSuperdivision") |> PrefixedName

    /// <summary>
    ///   <para>txn:individualHasObservedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an individual to an Area</para>
    /// labels<para>individualHasObservedArea</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasObservedArea">http://lod.taxonconcept.org/ontology/txn.owl#individualHasObservedArea</seealso>
    let individualHasObservedArea =
        Prefixed_Name(txn, "individualHasObservedArea") |> PrefixedName

    /// <summary>
    ///   <para>txn:individualHasOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an individual to an Occurrence, correct</para>
    /// labels<para>individualHasOccurrence</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasOccurrence">http://lod.taxonconcept.org/ontology/txn.owl#individualHasOccurrence</seealso>
    let individualHasOccurrence =
        Prefixed_Name(txn, "individualHasOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>txn:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Image">http://lod.taxonconcept.org/ontology/txn.owl#Image</seealso>
    let Image = Prefixed_Name(txn, "Image") |> PrefixedName
    /// <summary>
    ///   <para>txn:MarineHabitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FreshwaterHabitat</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#MarineHabitat">http://lod.taxonconcept.org/ontology/txn.owl#MarineHabitat</seealso>
    let MarineHabitat = Prefixed_Name(txn, "MarineHabitat") |> PrefixedName
    /// <summary>
    ///   <para>txn:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>class</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#class">http://lod.taxonconcept.org/ontology/txn.owl#class</seealso>
    let class_ = Prefixed_Name(txn, "class") |> PrefixedName
    /// <summary>
    ///   <para>txn:commonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>commonName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#commonName">http://lod.taxonconcept.org/ontology/txn.owl#commonName</seealso>
    let commonName = Prefixed_Name(txn, "commonName") |> PrefixedName
    /// <summary>
    ///   <para>txn:continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>continent</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#continent">http://lod.taxonconcept.org/ontology/txn.owl#continent</seealso>
    let continent = Prefixed_Name(txn, "continent") |> PrefixedName
    /// <summary>
    ///   <para>txn:countryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>countryCode</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#countryCode">http://lod.taxonconcept.org/ontology/txn.owl#countryCode</seealso>
    let countryCode = Prefixed_Name(txn, "countryCode") |> PrefixedName
    /// <summary>
    ///   <para>txn:descYearOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>descYearOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#descYearOf">http://lod.taxonconcept.org/ontology/txn.owl#descYearOf</seealso>
    let descYearOf = Prefixed_Name(txn, "descYearOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:featureContainsArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is used to link a geonames feature to a geo area. For example geo:44.86528100,-87.23147800;u=10</para>
    /// labels<para>featureContainsArea</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#featureContainsArea">http://lod.taxonconcept.org/ontology/txn.owl#featureContainsArea</seealso>
    let featureContainsArea = Prefixed_Name(txn, "featureContainsArea") |> PrefixedName
    /// <summary>
    ///   <para>txn:firstAuthorID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the First Author</para>
    /// labels<para>firstAuthorID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#firstAuthorID">http://lod.taxonconcept.org/ontology/txn.owl#firstAuthorID</seealso>
    let firstAuthorID = Prefixed_Name(txn, "firstAuthorID") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSuborder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Suborder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuborder">http://lod.taxonconcept.org/ontology/txn.owl#RankSuborder</seealso>
    let RankSuborder = Prefixed_Name(txn, "RankSuborder") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Order</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankOrder">http://lod.taxonconcept.org/ontology/txn.owl#RankOrder</seealso>
    let RankOrder = Prefixed_Name(txn, "RankOrder") |> PrefixedName

    /// <summary>
    ///   <para>txn:identificationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an identification to the URI for the reference used.</para>
    /// labels<para>identificationReference</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationReference">http://lod.taxonconcept.org/ontology/txn.owl#identificationReference</seealso>
    let identificationReference =
        Prefixed_Name(txn, "identificationReference") |> PrefixedName

    /// <summary>
    ///   <para>txn:TaxonConcept_Knowledge_Base_Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Project</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>TaxonConcept_Knowledge_Base_Project</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Knowledge_Base_Project">http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Knowledge_Base_Project</seealso>
    let TaxonConcept_Knowledge_Base_Project =
        Prefixed_Name(txn, "TaxonConcept_Knowledge_Base_Project") |> PrefixedName

    /// <summary>
    ///   <para>txn:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Area</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Area">http://lod.taxonconcept.org/ontology/txn.owl#Area</seealso>
    let Area = Prefixed_Name(txn, "Area") |> PrefixedName
    /// <summary>
    ///   <para>txn:CommonNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>CommonNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#CommonNameID">http://lod.taxonconcept.org/ontology/txn.owl#CommonNameID</seealso>
    let CommonNameID = Prefixed_Name(txn, "CommonNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:TaxonNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TaxonNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameID">http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameID</seealso>
    let TaxonNameID = Prefixed_Name(txn, "TaxonNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:FreshwaterHabitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FreshwaterHabitat</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#FreshwaterHabitat">http://lod.taxonconcept.org/ontology/txn.owl#FreshwaterHabitat</seealso>
    let FreshwaterHabitat = Prefixed_Name(txn, "FreshwaterHabitat") |> PrefixedName
    /// <summary>
    ///   <para>txn:Gallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gallery</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Gallery">http://lod.taxonconcept.org/ontology/txn.owl#Gallery</seealso>
    let Gallery = Prefixed_Name(txn, "Gallery") |> PrefixedName
    /// <summary>
    ///   <para>txn:Status_Testing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Status_Testing</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Status_Testing">http://lod.taxonconcept.org/ontology/txn.owl#Status_Testing</seealso>
    let Status_Testing = Prefixed_Name(txn, "Status_Testing") |> PrefixedName
    /// <summary>
    ///   <para>txn:SurrogateNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SurrogateNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SurrogateNameID">http://lod.taxonconcept.org/ontology/txn.owl#SurrogateNameID</seealso>
    let SurrogateNameID = Prefixed_Name(txn, "SurrogateNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:TaxonConcept_Scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>TaxonConcept_Scheme</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Scheme">http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Scheme</seealso>
    let TaxonConcept_Scheme = Prefixed_Name(txn, "TaxonConcept_Scheme") |> PrefixedName

    /// <summary>
    ///   <para>txn:occurrenceInStateProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Occurrence to Geonames StateProvince URI</para>
    /// labels<para>occurrenceInStateProvince</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInStateProvince">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInStateProvince</seealso>
    let occurrenceInStateProvince =
        Prefixed_Name(txn, "occurrenceInStateProvince") |> PrefixedName

    /// <summary>
    ///   <para>txn:RankVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Variety</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankVariety">http://lod.taxonconcept.org/ontology/txn.owl#RankVariety</seealso>
    let RankVariety = Prefixed_Name(txn, "RankVariety") |> PrefixedName

    /// <summary>
    ///   <para>txn:ScientificAuthorPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Someone who has authored a scientific article.</para>
    /// labels<para>ScientificAuthorPerson</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificAuthorPerson">http://lod.taxonconcept.org/ontology/txn.owl#ScientificAuthorPerson</seealso>
    let ScientificAuthorPerson =
        Prefixed_Name(txn, "ScientificAuthorPerson") |> PrefixedName

    /// <summary>
    ///   <para>txn:ScientificCollectorPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Someone who has collected a scientific sample or specimen.</para>
    /// labels<para>ScientificCollectorPerson</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificCollectorPerson">http://lod.taxonconcept.org/ontology/txn.owl#ScientificCollectorPerson</seealso>
    let ScientificCollectorPerson =
        Prefixed_Name(txn, "ScientificCollectorPerson") |> PrefixedName

    /// <summary>
    ///   <para>txn:Scientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for Scientist a foaf:Person</para>
    /// labels<para>Scientist</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Scientist">http://lod.taxonconcept.org/ontology/txn.owl#Scientist</seealso>
    let Scientist = Prefixed_Name(txn, "Scientist") |> PrefixedName

    /// <summary>
    ///   <para>txn:ScientificIdentifierPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Someone who has identified a specimen.</para>
    /// labels<para>ScientificIdentifierPerson</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificIdentifierPerson">http://lod.taxonconcept.org/ontology/txn.owl#ScientificIdentifierPerson</seealso>
    let ScientificIdentifierPerson =
        Prefixed_Name(txn, "ScientificIdentifierPerson") |> PrefixedName

    /// <summary>
    ///   <para>txn:institutionCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>institutionCode</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#institutionCode">http://lod.taxonconcept.org/ontology/txn.owl#institutionCode</seealso>
    let institutionCode = Prefixed_Name(txn, "institutionCode") |> PrefixedName
    /// <summary>
    ///   <para>txn:MonomialNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>MonomialNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#MonomialNameID">http://lod.taxonconcept.org/ontology/txn.owl#MonomialNameID</seealso>
    let MonomialNameID = Prefixed_Name(txn, "MonomialNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:GenusNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>GenusNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#GenusNameID">http://lod.taxonconcept.org/ontology/txn.owl#GenusNameID</seealso>
    let GenusNameID = Prefixed_Name(txn, "GenusNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:MapImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>MapImage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#MapImage">http://lod.taxonconcept.org/ontology/txn.owl#MapImage</seealso>
    let MapImage = Prefixed_Name(txn, "MapImage") |> PrefixedName
    /// <summary>
    ///   <para>txn:altAcceptedNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to an Alternative Accepted Name String</para>
    /// labels<para>altAcceptedNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID">http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID</seealso>
    let altAcceptedNameID = Prefixed_Name(txn, "altAcceptedNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:areaHasOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Area to an Occurrence</para>
    /// labels<para>areaHasOccurrence</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasOccurrence">http://lod.taxonconcept.org/ontology/txn.owl#areaHasOccurrence</seealso>
    let areaHasOccurrence = Prefixed_Name(txn, "areaHasOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>txn:areaInStateProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Area to Geonames State/Province URI</para>
    /// labels<para>areaInStateProvince</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#areaInStateProvince">http://lod.taxonconcept.org/ontology/txn.owl#areaInStateProvince</seealso>
    let areaInStateProvince = Prefixed_Name(txn, "areaInStateProvince") |> PrefixedName
    /// <summary>
    ///   <para>txn:basisOfRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Assumed to be equivalent to TDWG Basis of Record</para>
    /// labels<para>basisOfRecord</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#basisOfRecord">http://lod.taxonconcept.org/ontology/txn.owl#basisOfRecord</seealso>
    let basisOfRecord = Prefixed_Name(txn, "basisOfRecord") |> PrefixedName
    /// <summary>
    ///   <para>txn:behavioralNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>behavioralNote</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#behavioralNote">http://lod.taxonconcept.org/ontology/txn.owl#behavioralNote</seealso>
    let behavioralNote = Prefixed_Name(txn, "behavioralNote") |> PrefixedName
    /// <summary>
    ///   <para>txn:botanyAuthorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>botany author abbreviation</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#botanyAuthorName">http://lod.taxonconcept.org/ontology/txn.owl#botanyAuthorName</seealso>
    let botanyAuthorName = Prefixed_Name(txn, "botanyAuthorName") |> PrefixedName
    /// <summary>
    ///   <para>txn:canonicalFormID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping</para>
    /// labels<para>canonicalFormID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID">http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID</seealso>
    let canonicalFormID = Prefixed_Name(txn, "canonicalFormID") |> PrefixedName
    /// <summary>
    ///   <para>txn:relatedTaxonNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Taxon Name String</para>
    /// labels<para>relatedTaxonNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#relatedTaxonNameID">http://lod.taxonconcept.org/ontology/txn.owl#relatedTaxonNameID</seealso>
    let relatedTaxonNameID = Prefixed_Name(txn, "relatedTaxonNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:canonicalFormID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping</para>
    /// labels<para>canonicalFormID Of</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID_Of">http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID_Of</seealso>
    let canonicalFormID_Of = Prefixed_Name(txn, "canonicalFormID_Of") |> PrefixedName
    /// <summary>
    ///   <para>txn:scientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>scientificName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#scientificName">http://lod.taxonconcept.org/ontology/txn.owl#scientificName</seealso>
    let scientificName = Prefixed_Name(txn, "scientificName") |> PrefixedName
    /// <summary>
    ///   <para>txn:collectionCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>collectionCode</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#collectionCode">http://lod.taxonconcept.org/ontology/txn.owl#collectionCode</seealso>
    let collectionCode = Prefixed_Name(txn, "collectionCode") |> PrefixedName
    /// <summary>
    ///   <para>txn:conceptStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Links to the Status of the TaxonConcept</para>
    /// labels<para>conceptStatus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#conceptStatus">http://lod.taxonconcept.org/ontology/txn.owl#conceptStatus</seealso>
    let conceptStatus = Prefixed_Name(txn, "conceptStatus") |> PrefixedName
    /// <summary>
    ///   <para>txn:county</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>county</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#county">http://lod.taxonconcept.org/ontology/txn.owl#county</seealso>
    let county = Prefixed_Name(txn, "county") |> PrefixedName
    /// <summary>
    ///   <para>txn:descYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the year of the description</para>
    /// labels<para>descYear</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#descYear">http://lod.taxonconcept.org/ontology/txn.owl#descYear</seealso>
    let descYear = Prefixed_Name(txn, "descYear") |> PrefixedName
    /// <summary>
    ///   <para>txn:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>endDate</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#endDate">http://lod.taxonconcept.org/ontology/txn.owl#endDate</seealso>
    let endDate = Prefixed_Name(txn, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>txn:family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>family</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#family">http://lod.taxonconcept.org/ontology/txn.owl#family</seealso>
    let family = Prefixed_Name(txn, "family") |> PrefixedName

    /// <summary>
    ///   <para>txn:georeferenceProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The method used to determine the latitude, longitude as a URI</para>
    /// labels<para>georeferenceProtocol</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceProtocol">http://lod.taxonconcept.org/ontology/txn.owl#georeferenceProtocol</seealso>
    let georeferenceProtocol =
        Prefixed_Name(txn, "georeferenceProtocol") |> PrefixedName

    /// <summary>
    ///   <para>txn:georeferenceVerificationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Was this location verified, controlled choices URI</para>
    /// labels<para>georeferenceVerificationStatus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceVerificationStatus">http://lod.taxonconcept.org/ontology/txn.owl#georeferenceVerificationStatus</seealso>
    let georeferenceVerificationStatus =
        Prefixed_Name(txn, "georeferenceVerificationStatus") |> PrefixedName

    /// <summary>
    ///   <para>txn:habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon with a habitat in which it may typically be found</para>
    /// labels<para>habitat</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#habitat">http://lod.taxonconcept.org/ontology/txn.owl#habitat</seealso>
    let habitat = Prefixed_Name(txn, "habitat") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasAcceptedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasAcceptedName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasAcceptedName">http://lod.taxonconcept.org/ontology/txn.owl#hasAcceptedName</seealso>
    let hasAcceptedName = Prefixed_Name(txn, "hasAcceptedName") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasBBCPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the BBC site.</para>
    /// labels<para>hasBBCPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasBBCPage">http://lod.taxonconcept.org/ontology/txn.owl#hasBBCPage</seealso>
    let hasBBCPage = Prefixed_Name(txn, "hasBBCPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasBOLDPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A page at boldsystems.org</para>
    /// labels<para>hasBOLDPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLDPage">http://lod.taxonconcept.org/ontology/txn.owl#hasBOLDPage</seealso>
    let hasBOLDPage = Prefixed_Name(txn, "hasBOLDPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasBioimagesPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the Bioimages site.</para>
    /// labels<para>hasBioimagesPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasBioimagesPage">http://lod.taxonconcept.org/ontology/txn.owl#hasBioimagesPage</seealso>
    let hasBioimagesPage = Prefixed_Name(txn, "hasBioimagesPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The occurrence observer or specimen collector, hasCollector?</para>
    /// labels<para>hasCollector</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasCollector">http://lod.taxonconcept.org/ontology/txn.owl#hasCollector</seealso>
    let hasCollector = Prefixed_Name(txn, "hasCollector") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasDLPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the DiscoverLife.org site.</para>
    /// labels<para>hasDLPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasDLPage">http://lod.taxonconcept.org/ontology/txn.owl#hasDLPage</seealso>
    let hasDLPage = Prefixed_Name(txn, "hasDLPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasEOL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Encyclopedia of Life Integer ID</para>
    /// labels<para>hasEOL</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOL">http://lod.taxonconcept.org/ontology/txn.owl#hasEOL</seealso>
    let hasEOL = Prefixed_Name(txn, "hasEOL") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasEOLPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the Encyclopedia of Life site.</para>
    /// labels<para>hasEOLPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOLPage">http://lod.taxonconcept.org/ontology/txn.owl#hasEOLPage</seealso>
    let hasEOLPage = Prefixed_Name(txn, "hasEOLPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasEbird</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>eBird Species Code</para>
    /// labels<para>hasEbird</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasEbird">http://lod.taxonconcept.org/ontology/txn.owl#hasEbird</seealso>
    let hasEbird = Prefixed_Name(txn, "hasEbird") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasEtypePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasEtypePage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasEtypePage">http://lod.taxonconcept.org/ontology/txn.owl#hasEtypePage</seealso>
    let hasEtypePage = Prefixed_Name(txn, "hasEtypePage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is to link between a geographical area and a taxon-like entity. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.</para>
    /// labels<para>hasExpectationOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasExpectationOf">http://lod.taxonconcept.org/ontology/txn.owl#hasExpectationOf</seealso>
    let hasExpectationOf = Prefixed_Name(txn, "hasExpectationOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasGBIFMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasGBIFmap</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFMap">http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFMap</seealso>
    let hasGBIFMap = Prefixed_Name(txn, "hasGBIFMap") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasMapImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasMapImage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasMapImage">http://lod.taxonconcept.org/ontology/txn.owl#hasMapImage</seealso>
    let hasMapImage = Prefixed_Name(txn, "hasMapImage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasGBIFPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A page at GBIF.org</para>
    /// labels<para>hasGBIFPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFPage">http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFPage</seealso>
    let hasGBIFPage = Prefixed_Name(txn, "hasGBIFPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasITISPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the ITIS.gov site.</para>
    /// labels<para>hasITISPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasITISPage">http://lod.taxonconcept.org/ontology/txn.owl#hasITISPage</seealso>
    let hasITISPage = Prefixed_Name(txn, "hasITISPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Superproperty of all the links to images</para>
    /// labels<para>hasImage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasImage">http://lod.taxonconcept.org/ontology/txn.owl#hasImage</seealso>
    let hasImage = Prefixed_Name(txn, "hasImage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasNCBI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The NCBI Taxonomy ID</para>
    /// labels<para>hasNCBI</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasNCBI">http://lod.taxonconcept.org/ontology/txn.owl#hasNCBI</seealso>
    let hasNCBI = Prefixed_Name(txn, "hasNCBI") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasOriginalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasOriginalName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasOriginalName">http://lod.taxonconcept.org/ontology/txn.owl#hasOriginalName</seealso>
    let hasOriginalName = Prefixed_Name(txn, "hasOriginalName") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasSpeciesConceptID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This is for a string urn type identifier</para>
    /// labels<para>hasSpeciesConceptID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasSpeciesConceptID">http://lod.taxonconcept.org/ontology/txn.owl#hasSpeciesConceptID</seealso>
    let hasSpeciesConceptID = Prefixed_Name(txn, "hasSpeciesConceptID") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasUSDAPlantsPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasUSDAPlantsPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasUSDAPlantsPage">http://lod.taxonconcept.org/ontology/txn.owl#hasUSDAPlantsPage</seealso>
    let hasUSDAPlantsPage = Prefixed_Name(txn, "hasUSDAPlantsPage") |> PrefixedName

    /// <summary>
    ///   <para>txn:hasUnknownExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is to link between a geographical area and a taxon-like entity. Where the association is not known. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.</para>
    /// labels<para>hasUnknownExpectationOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasUnknownExpectationOf">http://lod.taxonconcept.org/ontology/txn.owl#hasUnknownExpectationOf</seealso>
    let hasUnknownExpectationOf =
        Prefixed_Name(txn, "hasUnknownExpectationOf") |> PrefixedName

    /// <summary>
    ///   <para>txn:isUnknownAboutIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a Geonames URI where the relationship is unknown</para>
    /// labels<para>isUnknownAboutIn</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isUnknownAboutIn">http://lod.taxonconcept.org/ontology/txn.owl#isUnknownAboutIn</seealso>
    let isUnknownAboutIn = Prefixed_Name(txn, "isUnknownAboutIn") |> PrefixedName

    /// <summary>
    ///   <para>txn:hasWikispeciesArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasWikispeciesArticle</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikispeciesArticle">http://lod.taxonconcept.org/ontology/txn.owl#hasWikispeciesArticle</seealso>
    let hasWikispeciesArticle =
        Prefixed_Name(txn, "hasWikispeciesArticle") |> PrefixedName

    /// <summary>
    ///   <para>txn:hasWildObsPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasWildObsPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasWildObsPage">http://lod.taxonconcept.org/ontology/txn.owl#hasWildObsPage</seealso>
    let hasWildObsPage = Prefixed_Name(txn, "hasWildObsPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:heterochresonymID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Heterochresonym Name String</para>
    /// labels<para>heterochresonymID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#heterochresonymID">http://lod.taxonconcept.org/ontology/txn.owl#heterochresonymID</seealso>
    let heterochresonymID = Prefixed_Name(txn, "heterochresonymID") |> PrefixedName
    /// <summary>
    ///   <para>txn:synonymID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to a synonymID of the TaxonNameID</para>
    /// labels<para>synonymID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#synonymID">http://lod.taxonconcept.org/ontology/txn.owl#synonymID</seealso>
    let synonymID = Prefixed_Name(txn, "synonymID") |> PrefixedName
    /// <summary>
    ///   <para>txn:heterotypicNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the HeterotypicName Name String</para>
    /// labels<para>heterotypicNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#heterotypicNameID">http://lod.taxonconcept.org/ontology/txn.owl#heterotypicNameID</seealso>
    let heterotypicNameID = Prefixed_Name(txn, "heterotypicNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:homotypicNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the HomotypicName Name String</para>
    /// labels<para>homotypicNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#homotypicNameID">http://lod.taxonconcept.org/ontology/txn.owl#homotypicNameID</seealso>
    let homotypicNameID = Prefixed_Name(txn, "homotypicNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:hybrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hybrid</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hybrid">http://lod.taxonconcept.org/ontology/txn.owl#hybrid</seealso>
    let hybrid = Prefixed_Name(txn, "hybrid") |> PrefixedName

    /// <summary>
    ///   <para>txn:identificationHasOcccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link between an Identification and an Occurrence</para>
    /// labels<para>identificationHasOcccurrence</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasOcccurrence">http://lod.taxonconcept.org/ontology/txn.owl#identificationHasOcccurrence</seealso>
    let identificationHasOcccurrence =
        Prefixed_Name(txn, "identificationHasOcccurrence") |> PrefixedName

    /// <summary>
    ///   <para>txn:identificationHasSpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link between an Identification and Species Concept, redundant with identifiedAs</para>
    /// labels<para>identificationHasSpeciesConcept</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasSpeciesConcept">http://lod.taxonconcept.org/ontology/txn.owl#identificationHasSpeciesConcept</seealso>
    let identificationHasSpeciesConcept =
        Prefixed_Name(txn, "identificationHasSpeciesConcept") |> PrefixedName

    /// <summary>
    ///   <para>txn:identificationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Method used to identify the individual, as a URI</para>
    /// labels<para>identificationMethod</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationMethod">http://lod.taxonconcept.org/ontology/txn.owl#identificationMethod</seealso>
    let identificationMethod =
        Prefixed_Name(txn, "identificationMethod") |> PrefixedName

    /// <summary>
    ///   <para>txn:identificationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>identificationNote</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationNote">http://lod.taxonconcept.org/ontology/txn.owl#identificationNote</seealso>
    let identificationNote = Prefixed_Name(txn, "identificationNote") |> PrefixedName

    /// <summary>
    ///   <para>txn:identificationOfIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an identification to an individual</para>
    /// labels<para>identificationOfIndividual</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationOfIndividual">http://lod.taxonconcept.org/ontology/txn.owl#identificationOfIndividual</seealso>
    let identificationOfIndividual =
        Prefixed_Name(txn, "identificationOfIndividual") |> PrefixedName

    /// <summary>
    ///   <para>txn:identifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an identification to the URI a human that made the identification as URI</para>
    /// labels<para>identifiedBy</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identifiedBy">http://lod.taxonconcept.org/ontology/txn.owl#identifiedBy</seealso>
    let identifiedBy = Prefixed_Name(txn, "identifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>txn:inClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inClass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inClass">http://lod.taxonconcept.org/ontology/txn.owl#inClass</seealso>
    let inClass = Prefixed_Name(txn, "inClass") |> PrefixedName
    /// <summary>
    ///   <para>txn:inCoLClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a Catalog of Life Class in an ontology</para>
    /// labels<para>inCoLClass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLClass">http://lod.taxonconcept.org/ontology/txn.owl#inCoLClass</seealso>
    let inCoLClass = Prefixed_Name(txn, "inCoLClass") |> PrefixedName
    /// <summary>
    ///   <para>txn:inCoLFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a Catalog of Life Family in an ontology</para>
    /// labels<para>inCoLFamily</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLFamily">http://lod.taxonconcept.org/ontology/txn.owl#inCoLFamily</seealso>
    let inCoLFamily = Prefixed_Name(txn, "inCoLFamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:inCoLKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a Catalog of Life Kingdom in an ontology</para>
    /// labels<para>inCoLKingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLKingdom">http://lod.taxonconcept.org/ontology/txn.owl#inCoLKingdom</seealso>
    let inCoLKingdom = Prefixed_Name(txn, "inCoLKingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:inCoLPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a Catalog of Life Phylum in an ontology</para>
    /// labels<para>inCoLPhylum</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLPhylum">http://lod.taxonconcept.org/ontology/txn.owl#inCoLPhylum</seealso>
    let inCoLPhylum = Prefixed_Name(txn, "inCoLPhylum") |> PrefixedName
    /// <summary>
    ///   <para>txn:inDBpediaClade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a clade in the DBpedia ontology</para>
    /// labels<para>inDBpediaClade</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inDBpediaClade">http://lod.taxonconcept.org/ontology/txn.owl#inDBpediaClade</seealso>
    let inDBpediaClade = Prefixed_Name(txn, "inDBpediaClade") |> PrefixedName
    /// <summary>
    ///   <para>txn:inFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inFamily</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inFamily">http://lod.taxonconcept.org/ontology/txn.owl#inFamily</seealso>
    let inFamily = Prefixed_Name(txn, "inFamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:inGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inGenus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inGenus">http://lod.taxonconcept.org/ontology/txn.owl#inGenus</seealso>
    let inGenus = Prefixed_Name(txn, "inGenus") |> PrefixedName
    /// <summary>
    ///   <para>txn:inInfraclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inInfraclass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inInfraclass">http://lod.taxonconcept.org/ontology/txn.owl#inInfraclass</seealso>
    let inInfraclass = Prefixed_Name(txn, "inInfraclass") |> PrefixedName
    /// <summary>
    ///   <para>txn:inKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inKingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inKingdom">http://lod.taxonconcept.org/ontology/txn.owl#inKingdom</seealso>
    let inKingdom = Prefixed_Name(txn, "inKingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:inPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inPhylum</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inPhylum">http://lod.taxonconcept.org/ontology/txn.owl#inPhylum</seealso>
    let inPhylum = Prefixed_Name(txn, "inPhylum") |> PrefixedName
    /// <summary>
    ///   <para>txn:inSubclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inSubclass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inSubclass">http://lod.taxonconcept.org/ontology/txn.owl#inSubclass</seealso>
    let inSubclass = Prefixed_Name(txn, "inSubclass") |> PrefixedName
    /// <summary>
    ///   <para>txn:inSubfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inSubfamily</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inSubfamily">http://lod.taxonconcept.org/ontology/txn.owl#inSubfamily</seealso>
    let inSubfamily = Prefixed_Name(txn, "inSubfamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:inSuborder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inSuborder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inSuborder">http://lod.taxonconcept.org/ontology/txn.owl#inSuborder</seealso>
    let inSuborder = Prefixed_Name(txn, "inSuborder") |> PrefixedName
    /// <summary>
    ///   <para>txn:inSuperfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inSuperfamily</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperfamily">http://lod.taxonconcept.org/ontology/txn.owl#inSuperfamily</seealso>
    let inSuperfamily = Prefixed_Name(txn, "inSuperfamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:inSuperorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inSuperorder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperorder">http://lod.taxonconcept.org/ontology/txn.owl#inSuperorder</seealso>
    let inSuperorder = Prefixed_Name(txn, "inSuperorder") |> PrefixedName

    /// <summary>
    ///   <para>txn:individualHasCurrrentIdentificationAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an individual to the most appropriate identification. Should be one.</para>
    /// labels<para>individualHasCurrrentIdentificationAssertion</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasCurrrentIdentificationAssertion">http://lod.taxonconcept.org/ontology/txn.owl#individualHasCurrrentIdentificationAssertion</seealso>
    let individualHasCurrrentIdentificationAssertion =
        Prefixed_Name(txn, "individualHasCurrrentIdentificationAssertion") |> PrefixedName

    /// <summary>
    ///   <para>txn:individualHasPreviousIdentificationAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an individual to the most appropriate identification. Zero to many</para>
    /// labels<para>individualHasPreviousIdentificationAssertion</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasPreviousIdentificationAssertion">http://lod.taxonconcept.org/ontology/txn.owl#individualHasPreviousIdentificationAssertion</seealso>
    let individualHasPreviousIdentificationAssertion =
        Prefixed_Name(txn, "individualHasPreviousIdentificationAssertion") |> PrefixedName

    /// <summary>
    ///   <para>txn:individualHasSpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an individual a Species Concept</para>
    /// labels<para>individualHasSpeciesConcept</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasSpeciesConcept">http://lod.taxonconcept.org/ontology/txn.owl#individualHasSpeciesConcept</seealso>
    let individualHasSpeciesConcept =
        Prefixed_Name(txn, "individualHasSpeciesConcept") |> PrefixedName

    /// <summary>
    ///   <para>txn:individualStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links from an individual to a controlled vocabulary of URI's for the current status of that individual</para>
    /// labels<para>individualStatus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#individualStatus">http://lod.taxonconcept.org/ontology/txn.owl#individualStatus</seealso>
    let individualStatus = Prefixed_Name(txn, "individualStatus") |> PrefixedName
    /// <summary>
    ///   <para>txn:individualhasImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Intended to link an individual to a image. Should be subproperty of foaf:depiction</para>
    /// labels<para>individualhasImage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#individualhasImage">http://lod.taxonconcept.org/ontology/txn.owl#individualhasImage</seealso>
    let individualhasImage = Prefixed_Name(txn, "individualhasImage") |> PrefixedName

    /// <summary>
    ///   <para>txn:infraspecificEpithet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>infraspecificEpithet</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#infraspecificEpithet">http://lod.taxonconcept.org/ontology/txn.owl#infraspecificEpithet</seealso>
    let infraspecificEpithet =
        Prefixed_Name(txn, "infraspecificEpithet") |> PrefixedName

    /// <summary>
    ///   <para>txn:isBioimagesPageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isBioimagesPageOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isBioimagesPageOf">http://lod.taxonconcept.org/ontology/txn.owl#isBioimagesPageOf</seealso>
    let isBioimagesPageOf = Prefixed_Name(txn, "isBioimagesPageOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:isBugGuidePageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isBugGuidePageOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isBugGuidePageOf">http://lod.taxonconcept.org/ontology/txn.owl#isBugGuidePageOf</seealso>
    let isBugGuidePageOf = Prefixed_Name(txn, "isBugGuidePageOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:isEOLPageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the Encyclopedia of Life site.</para>
    /// labels<para>isEOLPageOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isEOLPageOf">http://lod.taxonconcept.org/ontology/txn.owl#isEOLPageOf</seealso>
    let isEOLPageOf = Prefixed_Name(txn, "isEOLPageOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:isExpectedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is to link between a taxon-like entity and a geographical area. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a particular individual organism is expecten in a geographical area, but to indicate that the species etc. is expected in a particular geographical area. For instance, it would be used to indicate that a species is expected in a particular state or province. The use should approximate assertions similar to what one might find in a state or country checklist.</para>
    /// labels<para>isExpectedIn</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isExpectedIn">http://lod.taxonconcept.org/ontology/txn.owl#isExpectedIn</seealso>
    let isExpectedIn = Prefixed_Name(txn, "isExpectedIn") |> PrefixedName
    /// <summary>
    ///   <para>txn:isTaxonNameID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isTaxonNameID_Of">http://lod.taxonconcept.org/ontology/txn.owl#isTaxonNameID_Of</seealso>
    let isTaxonNameID_Of = Prefixed_Name(txn, "isTaxonNameID_Of") |> PrefixedName

    /// <summary>
    ///   <para>txn:isWikipediaArticleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isWikipediaArticleOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isWikipediaArticleOf">http://lod.taxonconcept.org/ontology/txn.owl#isWikipediaArticleOf</seealso>
    let isWikipediaArticleOf =
        Prefixed_Name(txn, "isWikipediaArticleOf") |> PrefixedName

    /// <summary>
    ///   <para>txn:isWikispeciesArticleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isWikispeciesArticleOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#isWikispeciesArticleOf">http://lod.taxonconcept.org/ontology/txn.owl#isWikispeciesArticleOf</seealso>
    let isWikispeciesArticleOf =
        Prefixed_Name(txn, "isWikispeciesArticleOf") |> PrefixedName

    /// <summary>
    ///   <para>txn:lastAuthorID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Last Author</para>
    /// labels<para>lastAuthorID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#lastAuthorID">http://lod.taxonconcept.org/ontology/txn.owl#lastAuthorID</seealso>
    let lastAuthorID = Prefixed_Name(txn, "lastAuthorID") |> PrefixedName
    /// <summary>
    ///   <para>txn:localityText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>localityText</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#localityText">http://lod.taxonconcept.org/ontology/txn.owl#localityText</seealso>
    let localityText = Prefixed_Name(txn, "localityText") |> PrefixedName
    /// <summary>
    ///   <para>txn:locationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>locationName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#locationName">http://lod.taxonconcept.org/ontology/txn.owl#locationName</seealso>
    let locationName = Prefixed_Name(txn, "locationName") |> PrefixedName
    /// <summary>
    ///   <para>txn:nameYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The year that a name was published</para>
    /// labels<para>nameYear</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#nameYear">http://lod.taxonconcept.org/ontology/txn.owl#nameYear</seealso>
    let nameYear = Prefixed_Name(txn, "nameYear") |> PrefixedName
    /// <summary>
    ///   <para>txn:nameYearOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse of The year that a name was published</para>
    /// labels<para>nameYear</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#nameYearOf">http://lod.taxonconcept.org/ontology/txn.owl#nameYearOf</seealso>
    let nameYearOf = Prefixed_Name(txn, "nameYearOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:ncbiGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the most appropriate NCBI Genus</para>
    /// labels<para>NCBI Genus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiGenus">http://lod.taxonconcept.org/ontology/txn.owl#ncbiGenus</seealso>
    let ncbiGenus = Prefixed_Name(txn, "ncbiGenus") |> PrefixedName
    /// <summary>
    ///   <para>txn:ncbiSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the most appropriate NCBI Species</para>
    /// labels<para>NCBI Species</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiSpecies">http://lod.taxonconcept.org/ontology/txn.owl#ncbiSpecies</seealso>
    let ncbiSpecies = Prefixed_Name(txn, "ncbiSpecies") |> PrefixedName
    /// <summary>
    ///   <para>txn:occurrenceHasArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an occurrence to an area</para>
    /// labels<para>occurrenceHasArea</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasArea">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasArea</seealso>
    let occurrenceHasArea = Prefixed_Name(txn, "occurrenceHasArea") |> PrefixedName

    /// <summary>
    ///   <para>txn:occurrenceHasIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an occurrence to an individual</para>
    /// labels<para>occurrenceHasIndividual</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasIndividual">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasIndividual</seealso>
    let occurrenceHasIndividual =
        Prefixed_Name(txn, "occurrenceHasIndividual") |> PrefixedName

    /// <summary>
    ///   <para>txn:occurrenceHasLabelImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The image of the occurrence label on a specimen</para>
    /// labels<para>occurrenceHasLabelImage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasLabelImage">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasLabelImage</seealso>
    let occurrenceHasLabelImage =
        Prefixed_Name(txn, "occurrenceHasLabelImage") |> PrefixedName

    /// <summary>
    ///   <para>txn:occurrenceHasSpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an occurrence to a species concept</para>
    /// labels<para>occurrenceHasSpeciesConcept</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasSpeciesConcept">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasSpeciesConcept</seealso>
    let occurrenceHasSpeciesConcept =
        Prefixed_Name(txn, "occurrenceHasSpeciesConcept") |> PrefixedName

    /// <summary>
    ///   <para>txn:occurrenceInContinent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Occurrence to Geonames Continent URI</para>
    /// labels<para>occurrenceInContinent</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInContinent">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInContinent</seealso>
    let occurrenceInContinent =
        Prefixed_Name(txn, "occurrenceInContinent") |> PrefixedName

    /// <summary>
    ///   <para>txn:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>order</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#order">http://lod.taxonconcept.org/ontology/txn.owl#order</seealso>
    let order = Prefixed_Name(txn, "order") |> PrefixedName
    /// <summary>
    ///   <para>txn:originalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>originalName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#originalName">http://lod.taxonconcept.org/ontology/txn.owl#originalName</seealso>
    let originalName = Prefixed_Name(txn, "originalName") |> PrefixedName
    /// <summary>
    ///   <para>txn:originalNameID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>originalNameID_Of</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID_Of">http://lod.taxonconcept.org/ontology/txn.owl#originalNameID_Of</seealso>
    let originalNameID_Of = Prefixed_Name(txn, "originalNameID_Of") |> PrefixedName
    /// <summary>
    ///   <para>txn:orthochresonymID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Orthochresonym Name String</para>
    /// labels<para>orthochresonymID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#orthochresonymID">http://lod.taxonconcept.org/ontology/txn.owl#orthochresonymID</seealso>
    let orthochresonymID = Prefixed_Name(txn, "orthochresonymID") |> PrefixedName
    /// <summary>
    ///   <para>txn:phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>phylum</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#phylum">http://lod.taxonconcept.org/ontology/txn.owl#phylum</seealso>
    let phylum = Prefixed_Name(txn, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>txn:pubYearOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The year that document was pub</para>
    /// labels<para>pubYearOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#pubYearOf">http://lod.taxonconcept.org/ontology/txn.owl#pubYearOf</seealso>
    let pubYearOf = Prefixed_Name(txn, "pubYearOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:yearPub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The year that document was pub</para>
    /// labels<para>yearPub</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#yearPub">http://lod.taxonconcept.org/ontology/txn.owl#yearPub</seealso>
    let yearPub = Prefixed_Name(txn, "yearPub") |> PrefixedName
    /// <summary>
    ///   <para>txn:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The radius in meters from a particular latitude, longitude point from within which a thing was observed or collected.</para>
    /// labels<para>radius</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#radius">http://lod.taxonconcept.org/ontology/txn.owl#radius</seealso>
    let radius = Prefixed_Name(txn, "radius") |> PrefixedName
    /// <summary>
    ///   <para>txn:samplingProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Occurrence to a standard vocabulary of sampling protocols as URI's</para>
    /// labels<para>samplingProtocol</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#samplingProtocol">http://lod.taxonconcept.org/ontology/txn.owl#samplingProtocol</seealso>
    let samplingProtocol = Prefixed_Name(txn, "samplingProtocol") |> PrefixedName

    /// <summary>
    ///   <para>txn:scientificNameAuthorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The author and year of the species description publication i.e (Baker, 1899)</para>
    /// labels<para>scientificNameAuthorship</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameAuthorship">http://lod.taxonconcept.org/ontology/txn.owl#scientificNameAuthorship</seealso>
    let scientificNameAuthorship =
        Prefixed_Name(txn, "scientificNameAuthorship") |> PrefixedName

    /// <summary>
    ///   <para>txn:scientificNameWithAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>scientificNameWithAuthor</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameWithAuthor">http://lod.taxonconcept.org/ontology/txn.owl#scientificNameWithAuthor</seealso>
    let scientificNameWithAuthor =
        Prefixed_Name(txn, "scientificNameWithAuthor") |> PrefixedName

    /// <summary>
    ///   <para>txn:speciesConcepthasVaritypeSpecimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a varitype specimen</para>
    /// labels<para>speciesConcepthasVaritypeSpecimen</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConcepthasVaritypeSpecimen">http://lod.taxonconcept.org/ontology/txn.owl#speciesConcepthasVaritypeSpecimen</seealso>
    let speciesConcepthasVaritypeSpecimen =
        Prefixed_Name(txn, "speciesConcepthasVaritypeSpecimen") |> PrefixedName

    /// <summary>
    ///   <para>txn:varitypeSpecimenHasSpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a varitype specimen to a  species concept</para>
    /// labels<para>varitypeSpecimenHasSpeciesConcept</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#varitypeSpecimenHasSpeciesConcept">http://lod.taxonconcept.org/ontology/txn.owl#varitypeSpecimenHasSpeciesConcept</seealso>
    let varitypeSpecimenHasSpeciesConcept =
        Prefixed_Name(txn, "varitypeSpecimenHasSpeciesConcept") |> PrefixedName

    /// <summary>
    ///   <para>txn:specificEpithet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Specific epithet</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#specificEpithet">http://lod.taxonconcept.org/ontology/txn.owl#specificEpithet</seealso>
    let specificEpithet = Prefixed_Name(txn, "specificEpithet") |> PrefixedName
    /// <summary>
    ///   <para>txn:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>startDate</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#startDate">http://lod.taxonconcept.org/ontology/txn.owl#startDate</seealso>
    let startDate = Prefixed_Name(txn, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>txn:stateProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>stateProvince</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#stateProvince">http://lod.taxonconcept.org/ontology/txn.owl#stateProvince</seealso>
    let stateProvince = Prefixed_Name(txn, "stateProvince") |> PrefixedName
    /// <summary>
    ///   <para>txn:surrogateName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>surrogateName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#surrogateName">http://lod.taxonconcept.org/ontology/txn.owl#surrogateName</seealso>
    let surrogateName = Prefixed_Name(txn, "surrogateName") |> PrefixedName
    /// <summary>
    ///   <para>txn:synonymName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>synonymName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#synonymName">http://lod.taxonconcept.org/ontology/txn.owl#synonymName</seealso>
    let synonymName = Prefixed_Name(txn, "synonymName") |> PrefixedName
    /// <summary>
    ///   <para>txn:taxonNameGroupID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Taxon Name Group String</para>
    /// labels<para>taxonNameGroupID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID">http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID</seealso>
    let taxonNameGroupID = Prefixed_Name(txn, "taxonNameGroupID") |> PrefixedName
    /// <summary>
    ///   <para>txn:taxonNameGroupID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>taxonNameGroupID_Of</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID_Of">http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID_Of</seealso>
    let taxonNameGroupID_Of = Prefixed_Name(txn, "taxonNameGroupID_Of") |> PrefixedName
    /// <summary>
    ///   <para>txn:taxonRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>taxonRank</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#taxonRank">http://lod.taxonconcept.org/ontology/txn.owl#taxonRank</seealso>
    let taxonRank = Prefixed_Name(txn, "taxonRank") |> PrefixedName
    /// <summary>
    ///   <para>txn:thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>thumbnail</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnail">http://lod.taxonconcept.org/ontology/txn.owl#thumbnail</seealso>
    let thumbnail = Prefixed_Name(txn, "thumbnail") |> PrefixedName
    /// <summary>
    ///   <para>txn:thumbnailOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>thumbnailOf</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnailOf">http://lod.taxonconcept.org/ontology/txn.owl#thumbnailOf</seealso>
    let thumbnailOf = Prefixed_Name(txn, "thumbnailOf") |> PrefixedName
    /// <summary>
    ///   <para>txn:uniprotKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotKingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotKingdom">http://lod.taxonconcept.org/ontology/txn.owl#uniprotKingdom</seealso>
    let uniprotKingdom = Prefixed_Name(txn, "uniprotKingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:uniprotOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotOrder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotOrder">http://lod.taxonconcept.org/ontology/txn.owl#uniprotOrder</seealso>
    let uniprotOrder = Prefixed_Name(txn, "uniprotOrder") |> PrefixedName
    /// <summary>
    ///   <para>txn:uniprotPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotPhylum</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotPhylum">http://lod.taxonconcept.org/ontology/txn.owl#uniprotPhylum</seealso>
    let uniprotPhylum = Prefixed_Name(txn, "uniprotPhylum") |> PrefixedName
    /// <summary>
    ///   <para>txn:uniprotSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotSpecies</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotSpecies">http://lod.taxonconcept.org/ontology/txn.owl#uniprotSpecies</seealso>
    let uniprotSpecies = Prefixed_Name(txn, "uniprotSpecies") |> PrefixedName
    /// <summary>
    ///   <para>txn:yearBorn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>yearBorn</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#yearBorn">http://lod.taxonconcept.org/ontology/txn.owl#yearBorn</seealso>
    let yearBorn = Prefixed_Name(txn, "yearBorn") |> PrefixedName
    /// <summary>
    ///   <para>txn:yearDescribed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year that the species was originally described</para>
    /// labels<para>yearDescribed</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#yearDescribed">http://lod.taxonconcept.org/ontology/txn.owl#yearDescribed</seealso>
    let yearDescribed = Prefixed_Name(txn, "yearDescribed") |> PrefixedName
    /// <summary>
    ///   <para>txn:yearDied</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>yearDied</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#yearDied">http://lod.taxonconcept.org/ontology/txn.owl#yearDied</seealso>
    let yearDied = Prefixed_Name(txn, "yearDied") |> PrefixedName
    /// <summary>
    ///   <para>txn:zoologyAuthorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>zoology author abbreviation</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#zoologyAuthorName">http://lod.taxonconcept.org/ontology/txn.owl#zoologyAuthorName</seealso>
    let zoologyAuthorName = Prefixed_Name(txn, "zoologyAuthorName") |> PrefixedName
    /// <summary>
    ///   <para>txn:SpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SpeciesConcept</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesConcept">http://lod.taxonconcept.org/ontology/txn.owl#SpeciesConcept</seealso>
    let SpeciesConcept = Prefixed_Name(txn, "SpeciesConcept") |> PrefixedName
    /// <summary>
    ///   <para>txn:SpeciesImageTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tag like entity that can be used to indicate that an image is associated with a specific species concept. Instances of SpeciesImageTag take the form of the species concept URI with the fragment of #Image rather than #Species.</para>
    /// labels<para>SpeciesImageTag</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesImageTag">http://lod.taxonconcept.org/ontology/txn.owl#SpeciesImageTag</seealso>
    let SpeciesImageTag = Prefixed_Name(txn, "SpeciesImageTag") |> PrefixedName
    /// <summary>
    ///   <para>txn:kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>kingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#kingdom">http://lod.taxonconcept.org/ontology/txn.owl#kingdom</seealso>
    let kingdom = Prefixed_Name(txn, "kingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:Habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Habitat</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Habitat">http://lod.taxonconcept.org/ontology/txn.owl#Habitat</seealso>
    let Habitat = Prefixed_Name(txn, "Habitat") |> PrefixedName

    /// <summary>
    ///   <para>txn:SpeciesIndividualTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tag like entity that can be used to indicate that an individual organism is an associated with a particular species concept. Instances of SpeciesIndividualTag take the form of the species concept URI with the fragment of #Individual rather than #Species.</para>
    /// labels<para>SpeciesIndividualTag</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividualTag">http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividualTag</seealso>
    let SpeciesIndividualTag =
        Prefixed_Name(txn, "SpeciesIndividualTag") |> PrefixedName

    /// <summary>
    ///   <para>txn:SpeciesOriginalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SpeciesOriginalDescription</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesOriginalDescription">http://lod.taxonconcept.org/ontology/txn.owl#SpeciesOriginalDescription</seealso>
    let SpeciesOriginalDescription =
        Prefixed_Name(txn, "SpeciesOriginalDescription") |> PrefixedName

    /// <summary>
    ///   <para>txn:Specimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A organismal specimen that is related to a specific organism, parts of an individual organism, or a collection of these from several organisms. It should be used for the smallest entity in a specimen database. Ideally there should be at least one specimen per individual organism. Specimens consisting of multiple individuals or multiple species often complicate analysis. If one photo contains multiple entities, document these as separate specimens all linked to the same photo.</para>
    /// labels<para>Specimen</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Specimen">http://lod.taxonconcept.org/ontology/txn.owl#Specimen</seealso>
    let Specimen = Prefixed_Name(txn, "Specimen") |> PrefixedName
    /// <summary>
    ///   <para>txn:Status_Preliminary</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Status_Preliminary</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Status_Preliminary">http://lod.taxonconcept.org/ontology/txn.owl#Status_Preliminary</seealso>
    let Status_Preliminary = Prefixed_Name(txn, "Status_Preliminary") |> PrefixedName
    /// <summary>
    ///   <para>txn:SubfamilyNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SubfamilyNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SubfamilyNameID">http://lod.taxonconcept.org/ontology/txn.owl#SubfamilyNameID</seealso>
    let SubfamilyNameID = Prefixed_Name(txn, "SubfamilyNameID") |> PrefixedName

    /// <summary>
    ///   <para>txn:TDWG2010_BioBlitz_Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Project</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>TDWG2010 BioBlitz Project</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TDWG2010_BioBlitz_Project">http://lod.taxonconcept.org/ontology/txn.owl#TDWG2010_BioBlitz_Project</seealso>
    let TDWG2010_BioBlitz_Project =
        Prefixed_Name(txn, "TDWG2010_BioBlitz_Project") |> PrefixedName

    /// <summary>
    ///   <para>txn:TaxonNameGroupID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TaxonNameGroupID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameGroupID">http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameGroupID</seealso>
    let TaxonNameGroupID = Prefixed_Name(txn, "TaxonNameGroupID") |> PrefixedName
    /// <summary>
    ///   <para>txn:TaxonOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TaxonOntology</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonOntology">http://lod.taxonconcept.org/ontology/txn.owl#TaxonOntology</seealso>
    let TaxonOntology = Prefixed_Name(txn, "TaxonOntology") |> PrefixedName
    /// <summary>
    ///   <para>txn:Taxonomist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for a Taxonomist a subclass of dbpedia-owl:Scientist</para>
    /// labels<para>Taxonomist</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Taxonomist">http://lod.taxonconcept.org/ontology/txn.owl#Taxonomist</seealso>
    let Taxonomist = Prefixed_Name(txn, "Taxonomist") |> PrefixedName
    /// <summary>
    ///   <para>txn:TerrestrialHabitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TerrestrialHabitat</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TerrestrialHabitat">http://lod.taxonconcept.org/ontology/txn.owl#TerrestrialHabitat</seealso>
    let TerrestrialHabitat = Prefixed_Name(txn, "TerrestrialHabitat") |> PrefixedName
    /// <summary>
    ///   <para>txn:TrinomialNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TrinomialNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TrinomialNameID">http://lod.taxonconcept.org/ontology/txn.owl#TrinomialNameID</seealso>
    let TrinomialNameID = Prefixed_Name(txn, "TrinomialNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:acceptedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>acceptedName</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedName">http://lod.taxonconcept.org/ontology/txn.owl#acceptedName</seealso>
    let acceptedName = Prefixed_Name(txn, "acceptedName") |> PrefixedName
    /// <summary>
    ///   <para>txn:taxonNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Taxon Name String</para>
    /// labels<para>taxonNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID">http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID</seealso>
    let taxonNameID = Prefixed_Name(txn, "taxonNameID") |> PrefixedName

    /// <summary>
    ///   <para>txn:acceptedTaxonNameID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>acceptedTaxonNameID_Of</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedTaxonNameID_Of">http://lod.taxonconcept.org/ontology/txn.owl#acceptedTaxonNameID_Of</seealso>
    let acceptedTaxonNameID_Of =
        Prefixed_Name(txn, "acceptedTaxonNameID_Of") |> PrefixedName

    /// <summary>
    ///   <para>txn:originalNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Original Name String</para>
    /// labels<para>originalNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID">http://lod.taxonconcept.org/ontology/txn.owl#originalNameID</seealso>
    let originalNameID = Prefixed_Name(txn, "originalNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:areaHasIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Area to an Individual</para>
    /// labels<para>areaHasIndividual</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasIndividual">http://lod.taxonconcept.org/ontology/txn.owl#areaHasIndividual</seealso>
    let areaHasIndividual = Prefixed_Name(txn, "areaHasIndividual") |> PrefixedName
    /// <summary>
    ///   <para>txn:sodHasTypeSpecimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an original description to a species type specimen</para>
    /// labels<para>sodHasTypeSpecimen</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#sodHasTypeSpecimen">http://lod.taxonconcept.org/ontology/txn.owl#sodHasTypeSpecimen</seealso>
    let sodHasTypeSpecimen = Prefixed_Name(txn, "sodHasTypeSpecimen") |> PrefixedName
    /// <summary>
    ///   <para>txn:typeSpecimenHasSod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links specimen to an original species description</para>
    /// labels<para>typeSpecimenHasSod</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#typeSpecimenHasSod">http://lod.taxonconcept.org/ontology/txn.owl#typeSpecimenHasSod</seealso>
    let typeSpecimenHasSod = Prefixed_Name(txn, "typeSpecimenHasSod") |> PrefixedName

    /// <summary>
    ///   <para>txn:speciesConceptBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This describes the theoretical models behind the species concept. All species concepts are at least based on an Objective Model. In addition the may also be based on a Biological Species Model and or a Phylogenetic Species Model. A species concept could be based on all three of these. This is to reflect that there are several criteria used to support a species concept. It also allows one to create a species concept for the domestic cat that is separate from its wild relative. If one followed a strict phylogentic species model, than the domestic cat would be considered to be a subclass of the species Felis sylvestris. This would result in observations or references about the domestic cat being interpreted as observations or references of the African Wildcat Felis sylvestris.</para>
    /// labels<para>speciesConceptBasedOn</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptBasedOn">http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptBasedOn</seealso>
    let speciesConceptBasedOn =
        Prefixed_Name(txn, "speciesConceptBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>txn:TaxonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A particular taxonomic concept. Currently only species concepts are implemented, however theoretically there could be additional subclasses of GenusConcepts, FamilyConcepts etc. A SubspeciesConcept and lower are considered to be subclasses of SpeciesConcepts, but one persons subspecies is often anothers species. My current thinking is to represent individuals and observations of subspecies as individuals and observations of the larger species concept. It has yet to be implemented but I am considering recording these as observations and individuals of a given species "in the form of" their subspecies indentifier or name.</para>
    /// labels<para>TaxonConcept</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept">http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept</seealso>
    let TaxonConcept = Prefixed_Name(txn, "TaxonConcept") |> PrefixedName
    /// <summary>
    ///   <para>txn:SpeciesIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SpeciesIndividual</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividual">http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividual</seealso>
    let SpeciesIndividual = Prefixed_Name(txn, "SpeciesIndividual") |> PrefixedName
    /// <summary>
    ///   <para>txn:SpeciesModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SpeciesModel</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesModel">http://lod.taxonconcept.org/ontology/txn.owl#SpeciesModel</seealso>
    let SpeciesModel = Prefixed_Name(txn, "SpeciesModel") |> PrefixedName
    /// <summary>
    ///   <para>txn:SpeciesTaxonomyNCBI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tag like entity for the NCBI Taxonomic Classification.</para>
    /// labels<para>SpeciesTaxonomyNCBI</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesTaxonomyNCBI">http://lod.taxonconcept.org/ontology/txn.owl#SpeciesTaxonomyNCBI</seealso>
    let SpeciesTaxonomyNCBI = Prefixed_Name(txn, "SpeciesTaxonomyNCBI") |> PrefixedName
    /// <summary>
    ///   <para>txn:Identification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identification action. The identification of a specimen.</para>
    /// labels<para>Identification</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Identification">http://lod.taxonconcept.org/ontology/txn.owl#Identification</seealso>
    let Identification = Prefixed_Name(txn, "Identification") |> PrefixedName
    /// <summary>
    ///   <para>txn:occurrenceInCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Occurrence to Geonames County URI</para>
    /// labels<para>occurrenceInCounty</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInCounty">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInCounty</seealso>
    let occurrenceInCounty = Prefixed_Name(txn, "occurrenceInCounty") |> PrefixedName
    /// <summary>
    ///   <para>txn:occurrenceInFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>occurrenceInFeature</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInFeature">http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInFeature</seealso>
    let occurrenceInFeature = Prefixed_Name(txn, "occurrenceInFeature") |> PrefixedName
    /// <summary>
    ///   <para>txn:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The author and year of the species description publication i.e (Baker, 1899)</para>
    /// labels<para>authority</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#authority">http://lod.taxonconcept.org/ontology/txn.owl#authority</seealso>
    let authority = Prefixed_Name(txn, "authority") |> PrefixedName
    /// <summary>
    ///   <para>txn:catalogCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>catalogCode</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#catalogCode">http://lod.taxonconcept.org/ontology/txn.owl#catalogCode</seealso>
    let catalogCode = Prefixed_Name(txn, "catalogCode") |> PrefixedName
    /// <summary>
    ///   <para>txn:trinomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>trinomial</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#trinomial">http://lod.taxonconcept.org/ontology/txn.owl#trinomial</seealso>
    let trinomial = Prefixed_Name(txn, "trinomial") |> PrefixedName
    /// <summary>
    ///   <para>txn:uniprotClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotClass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotClass">http://lod.taxonconcept.org/ontology/txn.owl#uniprotClass</seealso>
    let uniprotClass = Prefixed_Name(txn, "uniprotClass") |> PrefixedName
    /// <summary>
    ///   <para>txn:uniprotFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotFamily</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotFamily">http://lod.taxonconcept.org/ontology/txn.owl#uniprotFamily</seealso>
    let uniprotFamily = Prefixed_Name(txn, "uniprotFamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for the Concept Year</para>
    /// labels<para>Year</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Year">http://lod.taxonconcept.org/ontology/txn.owl#Year</seealso>
    let Year = Prefixed_Name(txn, "Year") |> PrefixedName
    /// <summary>
    ///   <para>txn:acceptedNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Accepted Name String, should only be one.</para>
    /// labels<para>acceptedNameID</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedNameID">http://lod.taxonconcept.org/ontology/txn.owl#acceptedNameID</seealso>
    let acceptedNameID = Prefixed_Name(txn, "acceptedNameID") |> PrefixedName
    /// <summary>
    ///   <para>txn:taxonNameID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to the Taxon Name String</para>
    /// labels<para>taxonNameID_Of</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID_Of">http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID_Of</seealso>
    let taxonNameID_Of = Prefixed_Name(txn, "taxonNameID_Of") |> PrefixedName

    /// <summary>
    ///   <para>txn:altAcceptedNameID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to an Alternative Accepted Name String</para>
    /// labels<para>altAcceptedNameID_Of</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID_Of">http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID_Of</seealso>
    let altAcceptedNameID_Of =
        Prefixed_Name(txn, "altAcceptedNameID_Of") |> PrefixedName

    /// <summary>
    ///   <para>txn:areaHasObservedSpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Area to a Species Concept</para>
    /// labels<para>areaHasObservedSpeciesConcept</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasObservedSpeciesConcept">http://lod.taxonconcept.org/ontology/txn.owl#areaHasObservedSpeciesConcept</seealso>
    let areaHasObservedSpeciesConcept =
        Prefixed_Name(txn, "areaHasObservedSpeciesConcept") |> PrefixedName

    /// <summary>
    ///   <para>txn:areaInCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Area to Geonames County URI</para>
    /// labels<para>areaInCounty</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#areaInCounty">http://lod.taxonconcept.org/ontology/txn.owl#areaInCounty</seealso>
    let areaInCounty = Prefixed_Name(txn, "areaInCounty") |> PrefixedName
    /// <summary>
    ///   <para>txn:areaWithInFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is used to connect geo areas to geoname features</para>
    /// labels<para>areaWithInFeature</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#areaWithInFeature">http://lod.taxonconcept.org/ontology/txn.owl#areaWithInFeature</seealso>
    let areaWithInFeature = Prefixed_Name(txn, "areaWithInFeature") |> PrefixedName
    /// <summary>
    ///   <para>txn:binomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>binomial</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#binomial">http://lod.taxonconcept.org/ontology/txn.owl#binomial</seealso>
    let binomial = Prefixed_Name(txn, "binomial") |> PrefixedName

    /// <summary>
    ///   <para>txn:speciesConceptHasObservedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species to an area. Should be speciesConcept?</para>
    /// labels<para>speciesConceptHasObservedArea</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasObservedArea">http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasObservedArea</seealso>
    let speciesConceptHasObservedArea =
        Prefixed_Name(txn, "speciesConceptHasObservedArea") |> PrefixedName

    /// <summary>
    ///   <para>txn:speciesConceptHasOcccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species to an occurrence. Should be speciesConcept?</para>
    /// labels<para>speciesConceptHasOcccurrence</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasOcccurrence">http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasOcccurrence</seealso>
    let speciesConceptHasOcccurrence =
        Prefixed_Name(txn, "speciesConceptHasOcccurrence") |> PrefixedName

    /// <summary>
    ///   <para>txn:Occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Occurrence</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Occurrence">http://lod.taxonconcept.org/ontology/txn.owl#Occurrence</seealso>
    let Occurrence = Prefixed_Name(txn, "Occurrence") |> PrefixedName
    /// <summary>
    ///   <para>txn:OccurrenceTaxonTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceTaxonTag">http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceTaxonTag</seealso>
    let OccurrenceTaxonTag = Prefixed_Name(txn, "OccurrenceTaxonTag") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Class</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankClass">http://lod.taxonconcept.org/ontology/txn.owl#RankClass</seealso>
    let RankClass = Prefixed_Name(txn, "RankClass") |> PrefixedName
    /// <summary>
    ///   <para>txn:TaxonRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TaxonRank</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonRank">http://lod.taxonconcept.org/ontology/txn.owl#TaxonRank</seealso>
    let TaxonRank = Prefixed_Name(txn, "TaxonRank") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Division</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankDivision">http://lod.taxonconcept.org/ontology/txn.owl#RankDivision</seealso>
    let RankDivision = Prefixed_Name(txn, "RankDivision") |> PrefixedName

    /// <summary>
    ///   <para>txn:OccurrenceSpecimenTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceSpecimenTag">http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceSpecimenTag</seealso>
    let OccurrenceSpecimenTag =
        Prefixed_Name(txn, "OccurrenceSpecimenTag") |> PrefixedName

    /// <summary>
    ///   <para>txn:genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>genus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#genus">http://lod.taxonconcept.org/ontology/txn.owl#genus</seealso>
    let genus = Prefixed_Name(txn, "genus") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasADWPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the Animal Diversity Web site.</para>
    /// labels<para>hasADWPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasADWPage">http://lod.taxonconcept.org/ontology/txn.owl#hasADWPage</seealso>
    let hasADWPage = Prefixed_Name(txn, "hasADWPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasBOLD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Barcode of Life Integer ID</para>
    /// labels<para>hasBOLD</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLD">http://lod.taxonconcept.org/ontology/txn.owl#hasBOLD</seealso>
    let hasBOLD = Prefixed_Name(txn, "hasBOLD") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasBugGuidePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasBugGuidePage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasBugGuidePage">http://lod.taxonconcept.org/ontology/txn.owl#hasBugGuidePage</seealso>
    let hasBugGuidePage = Prefixed_Name(txn, "hasBugGuidePage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a uniprot pubmed uri for example http://purl.uniprot.org/pubmed/1083304 </para>
    /// labels<para>hasCitation</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasCitation">http://lod.taxonconcept.org/ontology/txn.owl#hasCitation</seealso>
    let hasCitation = Prefixed_Name(txn, "hasCitation") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasDiscoverLifePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The range is a page on the Discover Life Web site.</para>
    ///   <para>The range is a page on the http://www.discoverlife.org/ site.</para>
    /// labels<para>hasDiscoverLifePage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasDiscoverLifePage">http://lod.taxonconcept.org/ontology/txn.owl#hasDiscoverLifePage</seealso>
    let hasDiscoverLifePage = Prefixed_Name(txn, "hasDiscoverLifePage") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasEUNISPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasEUNISPage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasEUNISPage">http://lod.taxonconcept.org/ontology/txn.owl#hasEUNISPage</seealso>
    let hasEUNISPage = Prefixed_Name(txn, "hasEUNISPage") |> PrefixedName
    /// <summary>
    ///   <para>txn:OpenCycTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>OpenCycTaxon</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#OpenCycTaxon">http://lod.taxonconcept.org/ontology/txn.owl#OpenCycTaxon</seealso>
    let OpenCycTaxon = Prefixed_Name(txn, "OpenCycTaxon") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSuperclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Superclass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperclass">http://lod.taxonconcept.org/ontology/txn.owl#RankSuperclass</seealso>
    let RankSuperclass = Prefixed_Name(txn, "RankSuperclass") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Domain</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankDomain">http://lod.taxonconcept.org/ontology/txn.owl#RankDomain</seealso>
    let RankDomain = Prefixed_Name(txn, "RankDomain") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasGBIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Global Biodiversity Information Facility integer ID</para>
    /// labels<para>hasGBIF</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIF">http://lod.taxonconcept.org/ontology/txn.owl#hasGBIF</seealso>
    let hasGBIF = Prefixed_Name(txn, "hasGBIF") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasITIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ITIS ID</para>
    /// labels<para>hasITIS</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasITIS">http://lod.taxonconcept.org/ontology/txn.owl#hasITIS</seealso>
    let hasITIS = Prefixed_Name(txn, "hasITIS") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Subclass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubclass">http://lod.taxonconcept.org/ontology/txn.owl#RankSubclass</seealso>
    let RankSubclass = Prefixed_Name(txn, "RankSubclass") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubdomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Subdomain</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdomain">http://lod.taxonconcept.org/ontology/txn.owl#RankSubdomain</seealso>
    let RankSubdomain = Prefixed_Name(txn, "RankSubdomain") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Genus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankGenus">http://lod.taxonconcept.org/ontology/txn.owl#RankGenus</seealso>
    let RankGenus = Prefixed_Name(txn, "RankGenus") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Family</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankFamily">http://lod.taxonconcept.org/ontology/txn.owl#RankFamily</seealso>
    let RankFamily = Prefixed_Name(txn, "RankFamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Subfamily</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubfamily">http://lod.taxonconcept.org/ontology/txn.owl#RankSubfamily</seealso>
    let RankSubfamily = Prefixed_Name(txn, "RankSubfamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankInfraclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Infraclass</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraclass">http://lod.taxonconcept.org/ontology/txn.owl#RankInfraclass</seealso>
    let RankInfraclass = Prefixed_Name(txn, "RankInfraclass") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSuperfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Superfamily</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperfamily">http://lod.taxonconcept.org/ontology/txn.owl#RankSuperfamily</seealso>
    let RankSuperfamily = Prefixed_Name(txn, "RankSuperfamily") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubgenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Subgenus</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubgenus">http://lod.taxonconcept.org/ontology/txn.owl#RankSubgenus</seealso>
    let RankSubgenus = Prefixed_Name(txn, "RankSubgenus") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSuperorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Superorder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperorder">http://lod.taxonconcept.org/ontology/txn.owl#RankSuperorder</seealso>
    let RankSuperorder = Prefixed_Name(txn, "RankSuperorder") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasWikipediaArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasWikipediaArticle</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaArticle">http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaArticle</seealso>
    let hasWikipediaArticle = Prefixed_Name(txn, "hasWikipediaArticle") |> PrefixedName
    /// <summary>
    ///   <para>txn:hasWikipediaMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasWikipediaMap</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaMap">http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaMap</seealso>
    let hasWikipediaMap = Prefixed_Name(txn, "hasWikipediaMap") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankTribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Tribe</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankTribe">http://lod.taxonconcept.org/ontology/txn.owl#RankTribe</seealso>
    let RankTribe = Prefixed_Name(txn, "RankTribe") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankInfrakingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Infrakingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfrakingdom">http://lod.taxonconcept.org/ontology/txn.owl#RankInfrakingdom</seealso>
    let RankInfrakingdom = Prefixed_Name(txn, "RankInfrakingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSuperphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Superphylum</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperphylum">http://lod.taxonconcept.org/ontology/txn.owl#RankSuperphylum</seealso>
    let RankSuperphylum = Prefixed_Name(txn, "RankSuperphylum") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Kingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankKingdom">http://lod.taxonconcept.org/ontology/txn.owl#RankKingdom</seealso>
    let RankKingdom = Prefixed_Name(txn, "RankKingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:identificationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>identificationDate</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationDate">http://lod.taxonconcept.org/ontology/txn.owl#identificationDate</seealso>
    let identificationDate = Prefixed_Name(txn, "identificationDate") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Subkingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubkingdom">http://lod.taxonconcept.org/ontology/txn.owl#RankSubkingdom</seealso>
    let RankSubkingdom = Prefixed_Name(txn, "RankSubkingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSuperkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rank Superkingdom</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperkingdom">http://lod.taxonconcept.org/ontology/txn.owl#RankSuperkingdom</seealso>
    let RankSuperkingdom = Prefixed_Name(txn, "RankSuperkingdom") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankInfraorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Infraorder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraorder">http://lod.taxonconcept.org/ontology/txn.owl#RankInfraorder</seealso>
    let RankInfraorder = Prefixed_Name(txn, "RankInfraorder") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankParvorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Parvorder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankParvorder">http://lod.taxonconcept.org/ontology/txn.owl#RankParvorder</seealso>
    let RankParvorder = Prefixed_Name(txn, "RankParvorder") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSubphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Subphylum</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubphylum">http://lod.taxonconcept.org/ontology/txn.owl#RankSubphylum</seealso>
    let RankSubphylum = Prefixed_Name(txn, "RankSubphylum") |> PrefixedName
    /// <summary>
    ///   <para>txn:inCoLOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a species concept to a Catalog of Life Order in an ontology</para>
    /// labels<para>inCoLOrder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLOrder">http://lod.taxonconcept.org/ontology/txn.owl#inCoLOrder</seealso>
    let inCoLOrder = Prefixed_Name(txn, "inCoLOrder") |> PrefixedName

    /// <summary>
    ///   <para>txn:identificationHasLabelImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The image of the identification label on a specimen</para>
    /// labels<para>identificationHasLabelImage</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasLabelImage">http://lod.taxonconcept.org/ontology/txn.owl#identificationHasLabelImage</seealso>
    let identificationHasLabelImage =
        Prefixed_Name(txn, "identificationHasLabelImage") |> PrefixedName

    /// <summary>
    ///   <para>txn:RankPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>txn:TaxonRank</para>
    ///
    /// labels<para>Rank Phylum</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankPhylum">http://lod.taxonconcept.org/ontology/txn.owl#RankPhylum</seealso>
    let RankPhylum = Prefixed_Name(txn, "RankPhylum") |> PrefixedName
    /// <summary>
    ///   <para>txn:RankSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>txn:TaxonRank</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rank Species</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#RankSpecies">http://lod.taxonconcept.org/ontology/txn.owl#RankSpecies</seealso>
    let RankSpecies = Prefixed_Name(txn, "RankSpecies") |> PrefixedName
    /// <summary>
    ///   <para>txn:inOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inOrder</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#inOrder">http://lod.taxonconcept.org/ontology/txn.owl#inOrder</seealso>
    let inOrder = Prefixed_Name(txn, "inOrder") |> PrefixedName
    /// <summary>
    ///   <para>txn:Sex_hermaphrodite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>txn:Sex</para>
    ///
    /// labels<para>hermaphrodite</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_hermaphrodite">http://lod.taxonconcept.org/ontology/txn.owl#Sex_hermaphrodite</seealso>
    let Sex_hermaphrodite = Prefixed_Name(txn, "Sex_hermaphrodite") |> PrefixedName
    /// <summary>
    ///   <para>txn:Sex_unknowable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>txn:Sex</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Sex Unknowable</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_unknowable">http://lod.taxonconcept.org/ontology/txn.owl#Sex_unknowable</seealso>
    let Sex_unknowable = Prefixed_Name(txn, "Sex_unknowable") |> PrefixedName
