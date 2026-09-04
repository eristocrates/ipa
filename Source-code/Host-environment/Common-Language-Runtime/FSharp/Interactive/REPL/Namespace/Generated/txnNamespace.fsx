#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module txn =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://lod.taxonconcept.org/ontology/txn.owl#" "txn"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Area^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Area">txn:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : BinomialNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#BinomialNameID">txn:BinomialNameID</a>
    /// </summary>
    let BinomialNameID = _prefixId.prefix "BinomialNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : CommonNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#CommonNameID">txn:CommonNameID</a>
    /// </summary>
    let CommonNameID = _prefixId.prefix "CommonNameID"
    /// <summary>
    ///   <para>rdfs:label : DataObject</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#DataObject">txn:DataObject</a>
    /// </summary>
    let DataObject = _prefixId.prefix "DataObject"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : FamilyNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#FamilyNameID">txn:FamilyNameID</a>
    /// </summary>
    let FamilyNameID = _prefixId.prefix "FamilyNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : FreshwaterHabitat^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#FreshwaterHabitat">txn:FreshwaterHabitat</a>
    /// </summary>
    let FreshwaterHabitat = _prefixId.prefix "FreshwaterHabitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Gallery^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Gallery">txn:Gallery</a>
    /// </summary>
    let Gallery = _prefixId.prefix "Gallery"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : GenusNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#GenusNameID">txn:GenusNameID</a>
    /// </summary>
    let GenusNameID = _prefixId.prefix "GenusNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Habitat^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Habitat">txn:Habitat</a>
    /// </summary>
    let Habitat = _prefixId.prefix "Habitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <para>rdfs:comment : An identification action. The identification of a specimen.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Identification">txn:Identification</a>
    /// </summary>
    let Identification = _prefixId.prefix "Identification"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Image">txn:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : MapImage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#MapImage">txn:MapImage</a>
    /// </summary>
    let MapImage = _prefixId.prefix "MapImage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : FreshwaterHabitat^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#MarineHabitat">txn:MarineHabitat</a>
    /// </summary>
    let MarineHabitat = _prefixId.prefix "MarineHabitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : MonomialNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#MonomialNameID">txn:MonomialNameID</a>
    /// </summary>
    let MonomialNameID = _prefixId.prefix "MonomialNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Occurrence^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Occurrence">txn:Occurrence</a>
    /// </summary>
    let Occurrence = _prefixId.prefix "Occurrence"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceSpecimenTag">txn:OccurrenceSpecimenTag</a>
    /// </summary>
    let OccurrenceSpecimenTag = _prefixId.prefix "OccurrenceSpecimenTag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceTaxonTag">txn:OccurrenceTaxonTag</a>
    /// </summary>
    let OccurrenceTaxonTag = _prefixId.prefix "OccurrenceTaxonTag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : OpenCycTaxon^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#OpenCycTaxon">txn:OpenCycTaxon</a>
    /// </summary>
    let OpenCycTaxon = _prefixId.prefix "OpenCycTaxon"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Class^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankClass">txn:RankClass</a>
    /// </summary>
    let RankClass = _prefixId.prefix "RankClass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Division^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankDivision">txn:RankDivision</a>
    /// </summary>
    let RankDivision = _prefixId.prefix "RankDivision"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Domain^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankDomain">txn:RankDomain</a>
    /// </summary>
    let RankDomain = _prefixId.prefix "RankDomain"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Family^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankFamily">txn:RankFamily</a>
    /// </summary>
    let RankFamily = _prefixId.prefix "RankFamily"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Genus^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankGenus">txn:RankGenus</a>
    /// </summary>
    let RankGenus = _prefixId.prefix "RankGenus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Infraclass^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraclass">txn:RankInfraclass</a>
    /// </summary>
    let RankInfraclass = _prefixId.prefix "RankInfraclass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Infrakingdom^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfrakingdom">txn:RankInfrakingdom</a>
    /// </summary>
    let RankInfrakingdom = _prefixId.prefix "RankInfrakingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Infraorder^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraorder">txn:RankInfraorder</a>
    /// </summary>
    let RankInfraorder = _prefixId.prefix "RankInfraorder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Kingdom^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankKingdom">txn:RankKingdom</a>
    /// </summary>
    let RankKingdom = _prefixId.prefix "RankKingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Order^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankOrder">txn:RankOrder</a>
    /// </summary>
    let RankOrder = _prefixId.prefix "RankOrder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Parvorder^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankParvorder">txn:RankParvorder</a>
    /// </summary>
    let RankParvorder = _prefixId.prefix "RankParvorder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Phylum^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankPhylum">txn:RankPhylum</a>
    /// </summary>
    let RankPhylum = _prefixId.prefix "RankPhylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Species^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSpecies">txn:RankSpecies</a>
    /// </summary>
    let RankSpecies = _prefixId.prefix "RankSpecies"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subclass^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubclass">txn:RankSubclass</a>
    /// </summary>
    let RankSubclass = _prefixId.prefix "RankSubclass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subdivision^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdivision">txn:RankSubdivision</a>
    /// </summary>
    let RankSubdivision = _prefixId.prefix "RankSubdivision"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subdomain^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdomain">txn:RankSubdomain</a>
    /// </summary>
    let RankSubdomain = _prefixId.prefix "RankSubdomain"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subfamily^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubfamily">txn:RankSubfamily</a>
    /// </summary>
    let RankSubfamily = _prefixId.prefix "RankSubfamily"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subgenus^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubgenus">txn:RankSubgenus</a>
    /// </summary>
    let RankSubgenus = _prefixId.prefix "RankSubgenus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subkingdom^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubkingdom">txn:RankSubkingdom</a>
    /// </summary>
    let RankSubkingdom = _prefixId.prefix "RankSubkingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Suborder^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuborder">txn:RankSuborder</a>
    /// </summary>
    let RankSuborder = _prefixId.prefix "RankSuborder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subpecies^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubpecies">txn:RankSubpecies</a>
    /// </summary>
    let RankSubpecies = _prefixId.prefix "RankSubpecies"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Subphylum^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubphylum">txn:RankSubphylum</a>
    /// </summary>
    let RankSubphylum = _prefixId.prefix "RankSubphylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank SubspecificAggregate^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubspecificAggregate">txn:RankSubspecificAggregate</a>
    /// </summary>
    let RankSubspecificAggregate = _prefixId.prefix "RankSubspecificAggregate"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Superclass^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperclass">txn:RankSuperclass</a>
    /// </summary>
    let RankSuperclass = _prefixId.prefix "RankSuperclass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Superdivision^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperdivision">txn:RankSuperdivision</a>
    /// </summary>
    let RankSuperdivision = _prefixId.prefix "RankSuperdivision"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Superfamily^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperfamily">txn:RankSuperfamily</a>
    /// </summary>
    let RankSuperfamily = _prefixId.prefix "RankSuperfamily"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Superkingdom^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperkingdom">txn:RankSuperkingdom</a>
    /// </summary>
    let RankSuperkingdom = _prefixId.prefix "RankSuperkingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Superorder^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperorder">txn:RankSuperorder</a>
    /// </summary>
    let RankSuperorder = _prefixId.prefix "RankSuperorder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Superphylum^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperphylum">txn:RankSuperphylum</a>
    /// </summary>
    let RankSuperphylum = _prefixId.prefix "RankSuperphylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Tribe^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankTribe">txn:RankTribe</a>
    /// </summary>
    let RankTribe = _prefixId.prefix "RankTribe"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Rank Variety^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#RankVariety">txn:RankVariety</a>
    /// </summary>
    let RankVariety = _prefixId.prefix "RankVariety"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ScientificAuthorPerson^^xsd:string</para>
    ///   <para>rdfs:comment : Someone who has authored a scientific article.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificAuthorPerson">txn:ScientificAuthorPerson</a>
    /// </summary>
    let ScientificAuthorPerson = _prefixId.prefix "ScientificAuthorPerson"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ScientificCollectorPerson^^xsd:string</para>
    ///   <para>rdfs:comment : Someone who has collected a scientific sample or specimen.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificCollectorPerson">txn:ScientificCollectorPerson</a>
    /// </summary>
    let ScientificCollectorPerson = _prefixId.prefix "ScientificCollectorPerson"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ScientificDataCuratorPerson^^xsd:string</para>
    ///   <para>rdfs:comment : Someone who has curated or entered data into a scientific data set.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificDataCuratorPerson">txn:ScientificDataCuratorPerson</a>
    /// </summary>
    let ScientificDataCuratorPerson = _prefixId.prefix "ScientificDataCuratorPerson"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ScientificIdentifierPerson^^xsd:string</para>
    ///   <para>rdfs:comment : Someone who has identified a specimen.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificIdentifierPerson">txn:ScientificIdentifierPerson</a>
    /// </summary>
    let ScientificIdentifierPerson = _prefixId.prefix "ScientificIdentifierPerson"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ScientificNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameID">txn:ScientificNameID</a>
    /// </summary>
    let ScientificNameID = _prefixId.prefix "ScientificNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ScientificNameWithAuthorID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameWithAuthorID">txn:ScientificNameWithAuthorID</a>
    /// </summary>
    let ScientificNameWithAuthorID = _prefixId.prefix "ScientificNameWithAuthorID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Scientist</para>
    ///   <para>rdfs:comment : Class for Scientist a foaf:Person</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Scientist">txn:Scientist</a>
    /// </summary>
    let Scientist = _prefixId.prefix "Scientist"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Sex^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Sex">txn:Sex</a>
    /// </summary>
    let Sex = _prefixId.prefix "Sex"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>dcterms:description : Female (♀) is the sex of an organism, or a part of an organism, which produces mobile ova (egg cells).</para>
    ///   <para>rdfs:label : female</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_female">txn:Sex_female</a>
    /// </summary>
    let Sex_female = _prefixId.prefix "Sex_female"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>dcterms:description : one organism having both male and female sexual characteristics and organs; at birth an unambiguous assignment of male or female cannot be made</para>
    ///   <para>rdfs:label : hermaphrodite</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_hermaphrodite">txn:Sex_hermaphrodite</a>
    /// </summary>
    let Sex_hermaphrodite = _prefixId.prefix "Sex_hermaphrodite"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>dcterms:description : Male (♂) refers to the sex of an organism, or part of an organism, which produces small mobile gametes, called spermatozoa.</para>
    ///   <para>rdfs:label : male</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_male">txn:Sex_male</a>
    /// </summary>
    let Sex_male = _prefixId.prefix "Sex_male"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Sex Undetermined^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_undetermined">txn:Sex_undetermined</a>
    /// </summary>
    let Sex_undetermined = _prefixId.prefix "Sex_undetermined"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Sex Unknowable^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_unknowable">txn:Sex_unknowable</a>
    /// </summary>
    let Sex_unknowable = _prefixId.prefix "Sex_unknowable"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SpeciesConcept^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesConcept">txn:SpeciesConcept</a>
    /// </summary>
    let SpeciesConcept = _prefixId.prefix "SpeciesConcept"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SpeciesImageTag^^xsd:string</para>
    ///   <para>rdfs:comment : A tag like entity that can be used to indicate that an image is associated with a specific species concept. Instances of SpeciesImageTag take the form of the species concept URI with the fragment of #Image rather than #Species.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesImageTag">txn:SpeciesImageTag</a>
    /// </summary>
    let SpeciesImageTag = _prefixId.prefix "SpeciesImageTag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SpeciesIndividual^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividual">txn:SpeciesIndividual</a>
    /// </summary>
    let SpeciesIndividual = _prefixId.prefix "SpeciesIndividual"
    /// <summary>
    ///   <para>rdfs:label : SpeciesIndividualTag^^xsd:string</para>
    ///   <para>rdfs:comment : A tag like entity that can be used to indicate that an individual organism is an associated with a particular species concept. Instances of SpeciesIndividualTag take the form of the species concept URI with the fragment of #Individual rather than #Species.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividualTag">txn:SpeciesIndividualTag</a>
    /// </summary>
    let SpeciesIndividualTag = _prefixId.prefix "SpeciesIndividualTag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SpeciesModel^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesModel">txn:SpeciesModel</a>
    /// </summary>
    let SpeciesModel = _prefixId.prefix "SpeciesModel"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SpeciesOriginalDescription^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesOriginalDescription">txn:SpeciesOriginalDescription</a>
    /// </summary>
    let SpeciesOriginalDescription = _prefixId.prefix "SpeciesOriginalDescription"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SpeciesTaxonomyNCBI^^xsd:string</para>
    ///   <para>rdfs:comment : A tag like entity for the NCBI Taxonomic Classification.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesTaxonomyNCBI">txn:SpeciesTaxonomyNCBI</a>
    /// </summary>
    let SpeciesTaxonomyNCBI = _prefixId.prefix "SpeciesTaxonomyNCBI"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Specimen^^xsd:string</para>
    ///   <para>rdfs:comment : A organismal specimen that is related to a specific organism, parts of an individual organism, or a collection of these from several organisms. It should be used for the smallest entity in a specimen database. Ideally there should be at least one specimen per individual organism. Specimens consisting of multiple individuals or multiple species often complicate analysis. If one photo contains multiple entities, document these as separate specimens all linked to the same photo.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Specimen">txn:Specimen</a>
    /// </summary>
    let Specimen = _prefixId.prefix "Specimen"
    let Status_Preliminary = _prefixId.prefix "Status_Preliminary"
    let Status_Testing = _prefixId.prefix "Status_Testing"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SubfamilyNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SubfamilyNameID">txn:SubfamilyNameID</a>
    /// </summary>
    let SubfamilyNameID = _prefixId.prefix "SubfamilyNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SurrogateNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#SurrogateNameID">txn:SurrogateNameID</a>
    /// </summary>
    let SurrogateNameID = _prefixId.prefix "SurrogateNameID"
    let TDWG2010_BioBlitz_Project = _prefixId.prefix "TDWG2010_BioBlitz_Project"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : TaxonConcept^^xsd:string</para>
    ///   <para>rdfs:comment : A particular taxonomic concept. Currently only species concepts are implemented, however theoretically there could be additional subclasses of GenusConcepts, FamilyConcepts etc. A SubspeciesConcept and lower are considered to be subclasses of SpeciesConcepts, but one persons subspecies is often anothers species. My current thinking is to represent individuals and observations of subspecies as individuals and observations of the larger species concept. It has yet to be implemented but I am considering recording these as observations and individuals of a given species "in the form of" their subspecies indentifier or name.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept">txn:TaxonConcept</a>
    /// </summary>
    let TaxonConcept = _prefixId.prefix "TaxonConcept"

    let TaxonConcept_Knowledge_Base_Project =
        _prefixId.prefix "TaxonConcept_Knowledge_Base_Project"

    let TaxonConcept_Scheme = _prefixId.prefix "TaxonConcept_Scheme"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : TaxonNameGroupID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameGroupID">txn:TaxonNameGroupID</a>
    /// </summary>
    let TaxonNameGroupID = _prefixId.prefix "TaxonNameGroupID"
    /// <summary>
    ///   <para>rdfs:label : TaxonNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameID">txn:TaxonNameID</a>
    /// </summary>
    let TaxonNameID = _prefixId.prefix "TaxonNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : TaxonOntology^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonOntology">txn:TaxonOntology</a>
    /// </summary>
    let TaxonOntology = _prefixId.prefix "TaxonOntology"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : TaxonRank^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonRank">txn:TaxonRank</a>
    /// </summary>
    let TaxonRank = _prefixId.prefix "TaxonRank"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Taxonomist</para>
    ///   <para>rdfs:comment : Class for a Taxonomist a subclass of dbpedia-owl:Scientist</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Taxonomist">txn:Taxonomist</a>
    /// </summary>
    let Taxonomist = _prefixId.prefix "Taxonomist"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : TerrestrialHabitat^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#TerrestrialHabitat">txn:TerrestrialHabitat</a>
    /// </summary>
    let TerrestrialHabitat = _prefixId.prefix "TerrestrialHabitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : TrinomialNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#TrinomialNameID">txn:TrinomialNameID</a>
    /// </summary>
    let TrinomialNameID = _prefixId.prefix "TrinomialNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Year</para>
    ///   <para>rdfs:comment : Class for the Concept Year</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#Year">txn:Year</a>
    /// </summary>
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : acceptedName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedName">txn:acceptedName</a>
    /// </summary>
    let acceptedName = _prefixId.prefix "acceptedName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : acceptedNameID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Accepted Name String, should only be one.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedNameID">txn:acceptedNameID</a>
    /// </summary>
    let acceptedNameID = _prefixId.prefix "acceptedNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : acceptedTaxonNameID_Of^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedTaxonNameID_Of">txn:acceptedTaxonNameID_Of</a>
    /// </summary>
    let acceptedTaxonNameID_Of = _prefixId.prefix "acceptedTaxonNameID_Of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : altAcceptedNameID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to an Alternative Accepted Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID">txn:altAcceptedNameID</a>
    /// </summary>
    let altAcceptedNameID = _prefixId.prefix "altAcceptedNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : altAcceptedNameID_Of^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to an Alternative Accepted Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID_Of">txn:altAcceptedNameID_Of</a>
    /// </summary>
    let altAcceptedNameID_Of = _prefixId.prefix "altAcceptedNameID_Of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : areaHasIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Area to an Individual^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasIndividual">txn:areaHasIndividual</a>
    /// </summary>
    let areaHasIndividual = _prefixId.prefix "areaHasIndividual"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : areaHasObservedSpeciesConcept^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Area to a Species Concept^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasObservedSpeciesConcept">txn:areaHasObservedSpeciesConcept</a>
    /// </summary>
    let areaHasObservedSpeciesConcept = _prefixId.prefix "areaHasObservedSpeciesConcept"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : areaHasOccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Area to an Occurrence^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasOccurrence">txn:areaHasOccurrence</a>
    /// </summary>
    let areaHasOccurrence = _prefixId.prefix "areaHasOccurrence"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : areaInCounty^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Area to Geonames County URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#areaInCounty">txn:areaInCounty</a>
    /// </summary>
    let areaInCounty = _prefixId.prefix "areaInCounty"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : areaInStateProvince^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Area to Geonames State/Province URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#areaInStateProvince">txn:areaInStateProvince</a>
    /// </summary>
    let areaInStateProvince = _prefixId.prefix "areaInStateProvince"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : areaWithInFeature^^xsd:string</para>
    ///   <para>rdfs:comment : This is used to connect geo areas to geoname features^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#areaWithInFeature">txn:areaWithInFeature</a>
    /// </summary>
    let areaWithInFeature = _prefixId.prefix "areaWithInFeature"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : authority^^xsd:string</para>
    ///   <para>rdfs:comment : The author and year of the species description publication i.e (Baker, 1899)^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#authority">txn:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : basisOfRecord^^xsd:string</para>
    ///   <para>rdfs:comment : Assumed to be equivalent to TDWG Basis of Record^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#basisOfRecord">txn:basisOfRecord</a>
    /// </summary>
    let basisOfRecord = _prefixId.prefix "basisOfRecord"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : behavioralNote^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#behavioralNote">txn:behavioralNote</a>
    /// </summary>
    let behavioralNote = _prefixId.prefix "behavioralNote"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : binomial^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#binomial">txn:binomial</a>
    /// </summary>
    let binomial = _prefixId.prefix "binomial"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : botany author abbreviation^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#botanyAuthorName">txn:botanyAuthorName</a>
    /// </summary>
    let botanyAuthorName = _prefixId.prefix "botanyAuthorName"
    /// <summary>
    ///   <para>rdfs:label : canonicalFormID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID">txn:canonicalFormID</a>
    /// </summary>
    let canonicalFormID = _prefixId.prefix "canonicalFormID"
    /// <summary>
    ///   <para>rdfs:label : canonicalFormID Of^^xsd:string</para>
    ///   <para>rdfs:comment : The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID_Of">txn:canonicalFormID_Of</a>
    /// </summary>
    let canonicalFormID_Of = _prefixId.prefix "canonicalFormID_Of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : catalogCode^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#catalogCode">txn:catalogCode</a>
    /// </summary>
    let catalogCode = _prefixId.prefix "catalogCode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : class^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#class">txn:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : collectionCode^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#collectionCode">txn:collectionCode</a>
    /// </summary>
    let collectionCode = _prefixId.prefix "collectionCode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : commonName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#commonName">txn:commonName</a>
    /// </summary>
    let commonName = _prefixId.prefix "commonName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : conceptStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The Links to the Status of the TaxonConcept^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#conceptStatus">txn:conceptStatus</a>
    /// </summary>
    let conceptStatus = _prefixId.prefix "conceptStatus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : continent^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#continent">txn:continent</a>
    /// </summary>
    let continent = _prefixId.prefix "continent"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#country">txn:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : countryCode^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#countryCode">txn:countryCode</a>
    /// </summary>
    let countryCode = _prefixId.prefix "countryCode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : county^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#county">txn:county</a>
    /// </summary>
    let county = _prefixId.prefix "county"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : descYear^^xsd:string</para>
    ///   <para>rdfs:comment : This is the year of the description^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#descYear">txn:descYear</a>
    /// </summary>
    let descYear = _prefixId.prefix "descYear"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : descYearOf^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#descYearOf">txn:descYearOf</a>
    /// </summary>
    let descYearOf = _prefixId.prefix "descYearOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : endDate^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#endDate">txn:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : family^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#family">txn:family</a>
    /// </summary>
    let family = _prefixId.prefix "family"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : featureContainsArea^^xsd:string</para>
    ///   <para>rdfs:comment : This is used to link a geonames feature to a geo area. For example geo:44.86528100,-87.23147800;u=10^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#featureContainsArea">txn:featureContainsArea</a>
    /// </summary>
    let featureContainsArea = _prefixId.prefix "featureContainsArea"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : firstAuthorID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the First Author^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#firstAuthorID">txn:firstAuthorID</a>
    /// </summary>
    let firstAuthorID = _prefixId.prefix "firstAuthorID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : genus^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#genus">txn:genus</a>
    /// </summary>
    let genus = _prefixId.prefix "genus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : georeferenceProtocol^^xsd:string</para>
    ///   <para>rdfs:comment : The method used to determine the latitude, longitude as a URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceProtocol">txn:georeferenceProtocol</a>
    /// </summary>
    let georeferenceProtocol = _prefixId.prefix "georeferenceProtocol"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : georeferenceVerificationStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Was this location verified, controlled choices URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceVerificationStatus">txn:georeferenceVerificationStatus</a>
    /// </summary>
    let georeferenceVerificationStatus =
        _prefixId.prefix "georeferenceVerificationStatus"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : habitat^^xsd:string</para>
    ///   <para>rdfs:comment : associates a taxon with a habitat in which it may typically be found^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#habitat">txn:habitat</a>
    /// </summary>
    let habitat = _prefixId.prefix "habitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasADWPage^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the Animal Diversity Web site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasADWPage">txn:hasADWPage</a>
    /// </summary>
    let hasADWPage = _prefixId.prefix "hasADWPage"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : hasAcceptedName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasAcceptedName">txn:hasAcceptedName</a>
    /// </summary>
    let hasAcceptedName = _prefixId.prefix "hasAcceptedName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasBBCPage^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the BBC site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasBBCPage">txn:hasBBCPage</a>
    /// </summary>
    let hasBBCPage = _prefixId.prefix "hasBBCPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasBOLD^^xsd:string</para>
    ///   <para>rdfs:comment : The Barcode of Life Integer ID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLD">txn:hasBOLD</a>
    /// </summary>
    let hasBOLD = _prefixId.prefix "hasBOLD"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasBOLDPage^^xsd:string</para>
    ///   <para>rdfs:comment : A page at boldsystems.org</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLDPage">txn:hasBOLDPage</a>
    /// </summary>
    let hasBOLDPage = _prefixId.prefix "hasBOLDPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasBioimagesPage^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the Bioimages site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasBioimagesPage">txn:hasBioimagesPage</a>
    /// </summary>
    let hasBioimagesPage = _prefixId.prefix "hasBioimagesPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasBugGuidePage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasBugGuidePage">txn:hasBugGuidePage</a>
    /// </summary>
    let hasBugGuidePage = _prefixId.prefix "hasBugGuidePage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasCitation^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a uniprot pubmed uri for example http://purl.uniprot.org/pubmed/1083304 ^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasCitation">txn:hasCitation</a>
    /// </summary>
    let hasCitation = _prefixId.prefix "hasCitation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasCollector^^xsd:string</para>
    ///   <para>rdfs:comment : The occurrence observer or specimen collector, hasCollector?^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasCollector">txn:hasCollector</a>
    /// </summary>
    let hasCollector = _prefixId.prefix "hasCollector"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasDLPage^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the DiscoverLife.org site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasDLPage">txn:hasDLPage</a>
    /// </summary>
    let hasDLPage = _prefixId.prefix "hasDLPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasDiscoverLifePage^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the Discover Life Web site.^^xsd:stringrdfs:comment : The range is a page on the http://www.discoverlife.org/ site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasDiscoverLifePage">txn:hasDiscoverLifePage</a>
    /// </summary>
    let hasDiscoverLifePage = _prefixId.prefix "hasDiscoverLifePage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasEOL^^xsd:string</para>
    ///   <para>rdfs:comment : The Encyclopedia of Life Integer ID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOL">txn:hasEOL</a>
    /// </summary>
    let hasEOL = _prefixId.prefix "hasEOL"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasEOLPage^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the Encyclopedia of Life site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOLPage">txn:hasEOLPage</a>
    /// </summary>
    let hasEOLPage = _prefixId.prefix "hasEOLPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasEUNISPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasEUNISPage">txn:hasEUNISPage</a>
    /// </summary>
    let hasEUNISPage = _prefixId.prefix "hasEUNISPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasEbird^^xsd:string</para>
    ///   <para>rdfs:comment : eBird Species Code^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasEbird">txn:hasEbird</a>
    /// </summary>
    let hasEbird = _prefixId.prefix "hasEbird"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasEtypePage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasEtypePage">txn:hasEtypePage</a>
    /// </summary>
    let hasEtypePage = _prefixId.prefix "hasEtypePage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasExpectationOf^^xsd:string</para>
    ///   <para>rdfs:comment : This is to link between a geographical area and a taxon-like entity. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasExpectationOf">txn:hasExpectationOf</a>
    /// </summary>
    let hasExpectationOf = _prefixId.prefix "hasExpectationOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasGBIF^^xsd:string</para>
    ///   <para>rdfs:comment : The Global Biodiversity Information Facility integer ID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIF">txn:hasGBIF</a>
    /// </summary>
    let hasGBIF = _prefixId.prefix "hasGBIF"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasGBIFmap^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFMap">txn:hasGBIFMap</a>
    /// </summary>
    let hasGBIFMap = _prefixId.prefix "hasGBIFMap"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasGBIFPage^^xsd:string</para>
    ///   <para>rdfs:comment : A page at GBIF.org</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFPage">txn:hasGBIFPage</a>
    /// </summary>
    let hasGBIFPage = _prefixId.prefix "hasGBIFPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasITIS^^xsd:string</para>
    ///   <para>rdfs:comment : The ITIS ID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasITIS">txn:hasITIS</a>
    /// </summary>
    let hasITIS = _prefixId.prefix "hasITIS"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasITISPage^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the ITIS.gov site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasITISPage">txn:hasITISPage</a>
    /// </summary>
    let hasITISPage = _prefixId.prefix "hasITISPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasImage^^xsd:string</para>
    ///   <para>rdfs:comment : Superproperty of all the links to images^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasImage">txn:hasImage</a>
    /// </summary>
    let hasImage = _prefixId.prefix "hasImage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasMapImage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasMapImage">txn:hasMapImage</a>
    /// </summary>
    let hasMapImage = _prefixId.prefix "hasMapImage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasNCBI^^xsd:string</para>
    ///   <para>rdfs:comment : The NCBI Taxonomy ID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasNCBI">txn:hasNCBI</a>
    /// </summary>
    let hasNCBI = _prefixId.prefix "hasNCBI"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : hasOriginalName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasOriginalName">txn:hasOriginalName</a>
    /// </summary>
    let hasOriginalName = _prefixId.prefix "hasOriginalName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasSpeciesConceptID^^xsd:string</para>
    ///   <para>rdfs:comment : This is for a string urn type identifier^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasSpeciesConceptID">txn:hasSpeciesConceptID</a>
    /// </summary>
    let hasSpeciesConceptID = _prefixId.prefix "hasSpeciesConceptID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasUSDAPlantsPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasUSDAPlantsPage">txn:hasUSDAPlantsPage</a>
    /// </summary>
    let hasUSDAPlantsPage = _prefixId.prefix "hasUSDAPlantsPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasUnknownExpectationOf^^xsd:string</para>
    ///   <para>rdfs:comment : This is to link between a geographical area and a taxon-like entity. Where the association is not known. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasUnknownExpectationOf">txn:hasUnknownExpectationOf</a>
    /// </summary>
    let hasUnknownExpectationOf = _prefixId.prefix "hasUnknownExpectationOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasWikipediaArticle^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaArticle">txn:hasWikipediaArticle</a>
    /// </summary>
    let hasWikipediaArticle = _prefixId.prefix "hasWikipediaArticle"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasWikipediaMap^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaMap">txn:hasWikipediaMap</a>
    /// </summary>
    let hasWikipediaMap = _prefixId.prefix "hasWikipediaMap"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasWikispeciesArticle^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikispeciesArticle">txn:hasWikispeciesArticle</a>
    /// </summary>
    let hasWikispeciesArticle = _prefixId.prefix "hasWikispeciesArticle"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasWildObsPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hasWildObsPage">txn:hasWildObsPage</a>
    /// </summary>
    let hasWildObsPage = _prefixId.prefix "hasWildObsPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : heterochresonymID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Heterochresonym Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#heterochresonymID">txn:heterochresonymID</a>
    /// </summary>
    let heterochresonymID = _prefixId.prefix "heterochresonymID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : heterotypicNameID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the HeterotypicName Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#heterotypicNameID">txn:heterotypicNameID</a>
    /// </summary>
    let heterotypicNameID = _prefixId.prefix "heterotypicNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : homotypicNameID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the HomotypicName Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#homotypicNameID">txn:homotypicNameID</a>
    /// </summary>
    let homotypicNameID = _prefixId.prefix "homotypicNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hybrid^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#hybrid">txn:hybrid</a>
    /// </summary>
    let hybrid = _prefixId.prefix "hybrid"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationDate^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationDate">txn:identificationDate</a>
    /// </summary>
    let identificationDate = _prefixId.prefix "identificationDate"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationHasLabelImage^^xsd:string</para>
    ///   <para>rdfs:comment : The image of the identification label on a specimen^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasLabelImage">txn:identificationHasLabelImage</a>
    /// </summary>
    let identificationHasLabelImage = _prefixId.prefix "identificationHasLabelImage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationHasOcccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : The link between an Identification and an Occurrence^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasOcccurrence">txn:identificationHasOcccurrence</a>
    /// </summary>
    let identificationHasOcccurrence = _prefixId.prefix "identificationHasOcccurrence"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationHasSpeciesConcept^^xsd:string</para>
    ///   <para>rdfs:comment : The link between an Identification and Species Concept, redundant with identifiedAs^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasSpeciesConcept">txn:identificationHasSpeciesConcept</a>
    /// </summary>
    let identificationHasSpeciesConcept =
        _prefixId.prefix "identificationHasSpeciesConcept"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationMethod^^xsd:string</para>
    ///   <para>rdfs:comment : Method used to identify the individual, as a URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationMethod">txn:identificationMethod</a>
    /// </summary>
    let identificationMethod = _prefixId.prefix "identificationMethod"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationNote^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationNote">txn:identificationNote</a>
    /// </summary>
    let identificationNote = _prefixId.prefix "identificationNote"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationOfIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : Links an identification to an individual^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationOfIndividual">txn:identificationOfIndividual</a>
    /// </summary>
    let identificationOfIndividual = _prefixId.prefix "identificationOfIndividual"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identificationReference^^xsd:string</para>
    ///   <para>rdfs:comment : Links an identification to the URI for the reference used.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identificationReference">txn:identificationReference</a>
    /// </summary>
    let identificationReference = _prefixId.prefix "identificationReference"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : identifiedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Links an identification to the URI a human that made the identification as URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#identifiedBy">txn:identifiedBy</a>
    /// </summary>
    let identifiedBy = _prefixId.prefix "identifiedBy"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inClass^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inClass">txn:inClass</a>
    /// </summary>
    let inClass = _prefixId.prefix "inClass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inCoLClass^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a Catalog of Life Class in an ontology^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLClass">txn:inCoLClass</a>
    /// </summary>
    let inCoLClass = _prefixId.prefix "inCoLClass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inCoLFamily^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a Catalog of Life Family in an ontology^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLFamily">txn:inCoLFamily</a>
    /// </summary>
    let inCoLFamily = _prefixId.prefix "inCoLFamily"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inCoLKingdom^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a Catalog of Life Kingdom in an ontology^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLKingdom">txn:inCoLKingdom</a>
    /// </summary>
    let inCoLKingdom = _prefixId.prefix "inCoLKingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inCoLOrder^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a Catalog of Life Order in an ontology^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLOrder">txn:inCoLOrder</a>
    /// </summary>
    let inCoLOrder = _prefixId.prefix "inCoLOrder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inCoLPhylum^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a Catalog of Life Phylum in an ontology^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLPhylum">txn:inCoLPhylum</a>
    /// </summary>
    let inCoLPhylum = _prefixId.prefix "inCoLPhylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inDBpediaClade^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a clade in the DBpedia ontology^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inDBpediaClade">txn:inDBpediaClade</a>
    /// </summary>
    let inDBpediaClade = _prefixId.prefix "inDBpediaClade"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inFamily^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inFamily">txn:inFamily</a>
    /// </summary>
    let inFamily = _prefixId.prefix "inFamily"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inGenus^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inGenus">txn:inGenus</a>
    /// </summary>
    let inGenus = _prefixId.prefix "inGenus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inInfraclass^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inInfraclass">txn:inInfraclass</a>
    /// </summary>
    let inInfraclass = _prefixId.prefix "inInfraclass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inKingdom^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inKingdom">txn:inKingdom</a>
    /// </summary>
    let inKingdom = _prefixId.prefix "inKingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inOrder^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inOrder">txn:inOrder</a>
    /// </summary>
    let inOrder = _prefixId.prefix "inOrder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inPhylum^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inPhylum">txn:inPhylum</a>
    /// </summary>
    let inPhylum = _prefixId.prefix "inPhylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inSubclass^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inSubclass">txn:inSubclass</a>
    /// </summary>
    let inSubclass = _prefixId.prefix "inSubclass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inSubfamily^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inSubfamily">txn:inSubfamily</a>
    /// </summary>
    let inSubfamily = _prefixId.prefix "inSubfamily"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inSuborder^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inSuborder">txn:inSuborder</a>
    /// </summary>
    let inSuborder = _prefixId.prefix "inSuborder"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inSuperfamily^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperfamily">txn:inSuperfamily</a>
    /// </summary>
    let inSuperfamily = _prefixId.prefix "inSuperfamily"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : inSuperorder^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperorder">txn:inSuperorder</a>
    /// </summary>
    let inSuperorder = _prefixId.prefix "inSuperorder"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : individualHasCurrrentIdentificationAssertion^^xsd:string</para>
    ///   <para>rdfs:comment : Links an individual to the most appropriate identification. Should be one.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasCurrrentIdentificationAssertion">txn:individualHasCurrrentIdentificationAssertion</a>
    /// </summary>
    let individualHasCurrrentIdentificationAssertion =
        _prefixId.prefix "individualHasCurrrentIdentificationAssertion"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : individualHasObservedArea^^xsd:string</para>
    ///   <para>rdfs:comment : Links an individual to an Area^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasObservedArea">txn:individualHasObservedArea</a>
    /// </summary>
    let individualHasObservedArea = _prefixId.prefix "individualHasObservedArea"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : individualHasOccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : Links an individual to an Occurrence, correct^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasOccurrence">txn:individualHasOccurrence</a>
    /// </summary>
    let individualHasOccurrence = _prefixId.prefix "individualHasOccurrence"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : individualHasPreviousIdentificationAssertion^^xsd:string</para>
    ///   <para>rdfs:comment : Links an individual to the most appropriate identification. Zero to many^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasPreviousIdentificationAssertion">txn:individualHasPreviousIdentificationAssertion</a>
    /// </summary>
    let individualHasPreviousIdentificationAssertion =
        _prefixId.prefix "individualHasPreviousIdentificationAssertion"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : individualHasSpeciesConcept^^xsd:string</para>
    ///   <para>rdfs:comment : Links an individual a Species Concept^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasSpeciesConcept">txn:individualHasSpeciesConcept</a>
    /// </summary>
    let individualHasSpeciesConcept = _prefixId.prefix "individualHasSpeciesConcept"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : individualStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Links from an individual to a controlled vocabulary of URI's for the current status of that individual^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#individualStatus">txn:individualStatus</a>
    /// </summary>
    let individualStatus = _prefixId.prefix "individualStatus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : individualhasImage^^xsd:string</para>
    ///   <para>rdfs:comment : Intended to link an individual to a image. Should be subproperty of foaf:depiction^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#individualhasImage">txn:individualhasImage</a>
    /// </summary>
    let individualhasImage = _prefixId.prefix "individualhasImage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : infraspecificEpithet^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#infraspecificEpithet">txn:infraspecificEpithet</a>
    /// </summary>
    let infraspecificEpithet = _prefixId.prefix "infraspecificEpithet"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : institutionCode^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#institutionCode">txn:institutionCode</a>
    /// </summary>
    let institutionCode = _prefixId.prefix "institutionCode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : isBioimagesPageOf^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#isBioimagesPageOf">txn:isBioimagesPageOf</a>
    /// </summary>
    let isBioimagesPageOf = _prefixId.prefix "isBioimagesPageOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : isBugGuidePageOf^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#isBugGuidePageOf">txn:isBugGuidePageOf</a>
    /// </summary>
    let isBugGuidePageOf = _prefixId.prefix "isBugGuidePageOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : isEOLPageOf^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a page on the Encyclopedia of Life site.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#isEOLPageOf">txn:isEOLPageOf</a>
    /// </summary>
    let isEOLPageOf = _prefixId.prefix "isEOLPageOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : isExpectedIn^^xsd:string</para>
    ///   <para>rdfs:comment : This is to link between a taxon-like entity and a geographical area. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a particular individual organism is expecten in a geographical area, but to indicate that the species etc. is expected in a particular geographical area. For instance, it would be used to indicate that a species is expected in a particular state or province. The use should approximate assertions similar to what one might find in a state or country checklist.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#isExpectedIn">txn:isExpectedIn</a>
    /// </summary>
    let isExpectedIn = _prefixId.prefix "isExpectedIn"
    let isTaxonNameID_Of = _prefixId.prefix "isTaxonNameID_Of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : isUnknownAboutIn^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a Geonames URI where the relationship is unknown^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#isUnknownAboutIn">txn:isUnknownAboutIn</a>
    /// </summary>
    let isUnknownAboutIn = _prefixId.prefix "isUnknownAboutIn"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : isWikipediaArticleOf^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#isWikipediaArticleOf">txn:isWikipediaArticleOf</a>
    /// </summary>
    let isWikipediaArticleOf = _prefixId.prefix "isWikipediaArticleOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : isWikispeciesArticleOf^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#isWikispeciesArticleOf">txn:isWikispeciesArticleOf</a>
    /// </summary>
    let isWikispeciesArticleOf = _prefixId.prefix "isWikispeciesArticleOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : kingdom^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#kingdom">txn:kingdom</a>
    /// </summary>
    let kingdom = _prefixId.prefix "kingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : lastAuthorID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Last Author^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#lastAuthorID">txn:lastAuthorID</a>
    /// </summary>
    let lastAuthorID = _prefixId.prefix "lastAuthorID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : localityText^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#localityText">txn:localityText</a>
    /// </summary>
    let localityText = _prefixId.prefix "localityText"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : locationName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#locationName">txn:locationName</a>
    /// </summary>
    let locationName = _prefixId.prefix "locationName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : nameYear</para>
    ///   <para>rdfs:comment : The year that a name was published^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#nameYear">txn:nameYear</a>
    /// </summary>
    let nameYear = _prefixId.prefix "nameYear"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : nameYear</para>
    ///   <para>rdfs:comment : Inverse of The year that a name was published^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#nameYearOf">txn:nameYearOf</a>
    /// </summary>
    let nameYearOf = _prefixId.prefix "nameYearOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : NCBI Genus^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the most appropriate NCBI Genus^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiGenus">txn:ncbiGenus</a>
    /// </summary>
    let ncbiGenus = _prefixId.prefix "ncbiGenus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : NCBI Species^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the most appropriate NCBI Species^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiSpecies">txn:ncbiSpecies</a>
    /// </summary>
    let ncbiSpecies = _prefixId.prefix "ncbiSpecies"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceHasArea^^xsd:string</para>
    ///   <para>rdfs:comment : Links an occurrence to an area^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasArea">txn:occurrenceHasArea</a>
    /// </summary>
    let occurrenceHasArea = _prefixId.prefix "occurrenceHasArea"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceHasIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : Links an occurrence to an individual^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasIndividual">txn:occurrenceHasIndividual</a>
    /// </summary>
    let occurrenceHasIndividual = _prefixId.prefix "occurrenceHasIndividual"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceHasLabelImage^^xsd:string</para>
    ///   <para>rdfs:comment : The image of the occurrence label on a specimen^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasLabelImage">txn:occurrenceHasLabelImage</a>
    /// </summary>
    let occurrenceHasLabelImage = _prefixId.prefix "occurrenceHasLabelImage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceHasSpeciesConcept^^xsd:string</para>
    ///   <para>rdfs:comment : Links an occurrence to a species concept^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasSpeciesConcept">txn:occurrenceHasSpeciesConcept</a>
    /// </summary>
    let occurrenceHasSpeciesConcept = _prefixId.prefix "occurrenceHasSpeciesConcept"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceInContinent^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Occurrence to Geonames Continent URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInContinent">txn:occurrenceInContinent</a>
    /// </summary>
    let occurrenceInContinent = _prefixId.prefix "occurrenceInContinent"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceInCounty^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Occurrence to Geonames County URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInCounty">txn:occurrenceInCounty</a>
    /// </summary>
    let occurrenceInCounty = _prefixId.prefix "occurrenceInCounty"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceInFeature^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInFeature">txn:occurrenceInFeature</a>
    /// </summary>
    let occurrenceInFeature = _prefixId.prefix "occurrenceInFeature"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : occurrenceInStateProvince^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Occurrence to Geonames StateProvince URI^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInStateProvince">txn:occurrenceInStateProvince</a>
    /// </summary>
    let occurrenceInStateProvince = _prefixId.prefix "occurrenceInStateProvince"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : order^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#order">txn:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : originalName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#originalName">txn:originalName</a>
    /// </summary>
    let originalName = _prefixId.prefix "originalName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : originalNameID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Original Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID">txn:originalNameID</a>
    /// </summary>
    let originalNameID = _prefixId.prefix "originalNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : originalNameID_Of^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID_Of">txn:originalNameID_Of</a>
    /// </summary>
    let originalNameID_Of = _prefixId.prefix "originalNameID_Of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : orthochresonymID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Orthochresonym Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#orthochresonymID">txn:orthochresonymID</a>
    /// </summary>
    let orthochresonymID = _prefixId.prefix "orthochresonymID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : phylum^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#phylum">txn:phylum</a>
    /// </summary>
    let phylum = _prefixId.prefix "phylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : pubYearOf</para>
    ///   <para>rdfs:comment : The year that document was pub^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#pubYearOf">txn:pubYearOf</a>
    /// </summary>
    let pubYearOf = _prefixId.prefix "pubYearOf"
    /// <summary>
    ///   <para>rdfs:label : radius^^xsd:string</para>
    ///   <para>rdfs:comment : The radius in meters from a particular latitude, longitude point from within which a thing was observed or collected.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#radius">txn:radius</a>
    /// </summary>
    let radius = _prefixId.prefix "radius"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : relatedTaxonNameID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Taxon Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#relatedTaxonNameID">txn:relatedTaxonNameID</a>
    /// </summary>
    let relatedTaxonNameID = _prefixId.prefix "relatedTaxonNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : samplingProtocol^^xsd:string</para>
    ///   <para>rdfs:comment : Links an Occurrence to a standard vocabulary of sampling protocols as URI's^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#samplingProtocol">txn:samplingProtocol</a>
    /// </summary>
    let samplingProtocol = _prefixId.prefix "samplingProtocol"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : scientificName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#scientificName">txn:scientificName</a>
    /// </summary>
    let scientificName = _prefixId.prefix "scientificName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : scientificNameAuthorship^^xsd:string</para>
    ///   <para>rdfs:comment : The author and year of the species description publication i.e (Baker, 1899)^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameAuthorship">txn:scientificNameAuthorship</a>
    /// </summary>
    let scientificNameAuthorship = _prefixId.prefix "scientificNameAuthorship"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : scientificNameWithAuthor^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameWithAuthor">txn:scientificNameWithAuthor</a>
    /// </summary>
    let scientificNameWithAuthor = _prefixId.prefix "scientificNameWithAuthor"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : sodHasTypeSpecimen^^xsd:string</para>
    ///   <para>rdfs:comment : Links an original description to a species type specimen^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#sodHasTypeSpecimen">txn:sodHasTypeSpecimen</a>
    /// </summary>
    let sodHasTypeSpecimen = _prefixId.prefix "sodHasTypeSpecimen"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : speciesConceptBasedOn^^xsd:string</para>
    ///   <para>rdfs:comment : This describes the theoretical models behind the species concept. All species concepts are at least based on an Objective Model. In addition the may also be based on a Biological Species Model and or a Phylogenetic Species Model. A species concept could be based on all three of these. This is to reflect that there are several criteria used to support a species concept. It also allows one to create a species concept for the domestic cat that is separate from its wild relative. If one followed a strict phylogentic species model, than the domestic cat would be considered to be a subclass of the species Felis sylvestris. This would result in observations or references about the domestic cat being interpreted as observations or references of the African Wildcat Felis sylvestris.^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptBasedOn">txn:speciesConceptBasedOn</a>
    /// </summary>
    let speciesConceptBasedOn = _prefixId.prefix "speciesConceptBasedOn"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : speciesConceptHasObservedArea^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species to an area. Should be speciesConcept?^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasObservedArea">txn:speciesConceptHasObservedArea</a>
    /// </summary>
    let speciesConceptHasObservedArea = _prefixId.prefix "speciesConceptHasObservedArea"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : speciesConceptHasOcccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species to an occurrence. Should be speciesConcept?^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasOcccurrence">txn:speciesConceptHasOcccurrence</a>
    /// </summary>
    let speciesConceptHasOcccurrence = _prefixId.prefix "speciesConceptHasOcccurrence"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : speciesConcepthasVaritypeSpecimen^^xsd:string</para>
    ///   <para>rdfs:comment : Links a species concept to a varitype specimen^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConcepthasVaritypeSpecimen">txn:speciesConcepthasVaritypeSpecimen</a>
    /// </summary>
    let speciesConcepthasVaritypeSpecimen =
        _prefixId.prefix "speciesConcepthasVaritypeSpecimen"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Specific epithet^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#specificEpithet">txn:specificEpithet</a>
    /// </summary>
    let specificEpithet = _prefixId.prefix "specificEpithet"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : startDate^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#startDate">txn:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : stateProvince^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#stateProvince">txn:stateProvince</a>
    /// </summary>
    let stateProvince = _prefixId.prefix "stateProvince"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : surrogateName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#surrogateName">txn:surrogateName</a>
    /// </summary>
    let surrogateName = _prefixId.prefix "surrogateName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : synonymID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to a synonymID of the TaxonNameID^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#synonymID">txn:synonymID</a>
    /// </summary>
    let synonymID = _prefixId.prefix "synonymID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : synonymName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#synonymName">txn:synonymName</a>
    /// </summary>
    let synonymName = _prefixId.prefix "synonymName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : taxonNameGroupID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Taxon Name Group String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID">txn:taxonNameGroupID</a>
    /// </summary>
    let taxonNameGroupID = _prefixId.prefix "taxonNameGroupID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : taxonNameGroupID_Of^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID_Of">txn:taxonNameGroupID_Of</a>
    /// </summary>
    let taxonNameGroupID_Of = _prefixId.prefix "taxonNameGroupID_Of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : taxonNameID^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Taxon Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID">txn:taxonNameID</a>
    /// </summary>
    let taxonNameID = _prefixId.prefix "taxonNameID"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : taxonNameID_Of^^xsd:string</para>
    ///   <para>rdfs:comment : The URI to the Taxon Name String^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID_Of">txn:taxonNameID_Of</a>
    /// </summary>
    let taxonNameID_Of = _prefixId.prefix "taxonNameID_Of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : taxonRank^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#taxonRank">txn:taxonRank</a>
    /// </summary>
    let taxonRank = _prefixId.prefix "taxonRank"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : thumbnail^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnail">txn:thumbnail</a>
    /// </summary>
    let thumbnail = _prefixId.prefix "thumbnail"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : thumbnailOf^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnailOf">txn:thumbnailOf</a>
    /// </summary>
    let thumbnailOf = _prefixId.prefix "thumbnailOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : trinomial^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#trinomial">txn:trinomial</a>
    /// </summary>
    let trinomial = _prefixId.prefix "trinomial"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : typeSpecimenHasSod^^xsd:string</para>
    ///   <para>rdfs:comment : Links specimen to an original species description^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#typeSpecimenHasSod">txn:typeSpecimenHasSod</a>
    /// </summary>
    let typeSpecimenHasSod = _prefixId.prefix "typeSpecimenHasSod"
    /// <summary>
    ///   <para>rdfs:label : uniprotClass</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotClass">txn:uniprotClass</a>
    /// </summary>
    let uniprotClass = _prefixId.prefix "uniprotClass"
    /// <summary>
    ///   <para>rdfs:label : uniprotFamily</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotFamily">txn:uniprotFamily</a>
    /// </summary>
    let uniprotFamily = _prefixId.prefix "uniprotFamily"
    /// <summary>
    ///   <para>rdfs:label : uniprotGenus</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotGenus">txn:uniprotGenus</a>
    /// </summary>
    let uniprotGenus = _prefixId.prefix "uniprotGenus"
    /// <summary>
    ///   <para>rdfs:label : uniprotKingdom</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotKingdom">txn:uniprotKingdom</a>
    /// </summary>
    let uniprotKingdom = _prefixId.prefix "uniprotKingdom"
    /// <summary>
    ///   <para>rdfs:label : uniprotOrder</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotOrder">txn:uniprotOrder</a>
    /// </summary>
    let uniprotOrder = _prefixId.prefix "uniprotOrder"
    /// <summary>
    ///   <para>rdfs:label : uniprotPhylum</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotPhylum">txn:uniprotPhylum</a>
    /// </summary>
    let uniprotPhylum = _prefixId.prefix "uniprotPhylum"
    /// <summary>
    ///   <para>rdfs:label : uniprotSpecies</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotSpecies">txn:uniprotSpecies</a>
    /// </summary>
    let uniprotSpecies = _prefixId.prefix "uniprotSpecies"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : varitypeSpecimenHasSpeciesConcept^^xsd:string</para>
    ///   <para>rdfs:comment : Links a varitype specimen to a  species concept^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#varitypeSpecimenHasSpeciesConcept">txn:varitypeSpecimenHasSpeciesConcept</a>
    /// </summary>
    let varitypeSpecimenHasSpeciesConcept =
        _prefixId.prefix "varitypeSpecimenHasSpeciesConcept"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : yearBorn^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#yearBorn">txn:yearBorn</a>
    /// </summary>
    let yearBorn = _prefixId.prefix "yearBorn"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : yearDescribed^^xsd:string</para>
    ///   <para>rdfs:comment : The year that the species was originally described^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#yearDescribed">txn:yearDescribed</a>
    /// </summary>
    let yearDescribed = _prefixId.prefix "yearDescribed"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : yearDied^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#yearDied">txn:yearDied</a>
    /// </summary>
    let yearDied = _prefixId.prefix "yearDied"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : yearPub</para>
    ///   <para>rdfs:comment : The year that document was pub^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#yearPub">txn:yearPub</a>
    /// </summary>
    let yearPub = _prefixId.prefix "yearPub"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : zoology author abbreviation^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/txn.owl#zoologyAuthorName">txn:zoologyAuthorName</a>
    /// </summary>
    let zoologyAuthorName = _prefixId.prefix "zoologyAuthorName"
