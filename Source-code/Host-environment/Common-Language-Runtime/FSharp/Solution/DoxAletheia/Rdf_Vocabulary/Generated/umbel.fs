namespace http.umbel.org.umbel.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module umbel =
    let _namespace_iri = Namespace_Iri umbel |> NamespaceIRI
    /// <summary>
    ///   <para>umbel:Extraterrestrial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Extraterrestrial">http://umbel.org/umbel#Extraterrestrial</seealso>
    let Extraterrestrial = Prefixed_Name(umbel, "Extraterrestrial") |> PrefixedName
    /// <summary>
    ///   <para>umbel:NaturalSubstances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#NaturalSubstances">http://umbel.org/umbel#NaturalSubstances</seealso>
    let NaturalSubstances = Prefixed_Name(umbel, "NaturalSubstances") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Prokaryotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Prokaryotes">http://umbel.org/umbel#Prokaryotes</seealso>
    let Prokaryotes = Prefixed_Name(umbel, "Prokaryotes") |> PrefixedName
    /// <summary>
    ///   <para>umbel:ProtistsFungus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#ProtistsFungus">http://umbel.org/umbel#ProtistsFungus</seealso>
    let ProtistsFungus = Prefixed_Name(umbel, "ProtistsFungus") |> PrefixedName
    /// <summary>
    ///   <para>umbel:FinanceEconomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#FinanceEconomy">http://umbel.org/umbel#FinanceEconomy</seealso>
    let FinanceEconomy = Prefixed_Name(umbel, "FinanceEconomy") |> PrefixedName
    /// <summary>
    ///   <para>umbel:superPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#superPropertyOf">http://umbel.org/umbel#superPropertyOf</seealso>
    let superPropertyOf = Prefixed_Name(umbel, "superPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToActivity">http://umbel.org/umbel#relatesToActivity</seealso>
    let relatesToActivity = Prefixed_Name(umbel, "relatesToActivity") |> PrefixedName
    /// <summary>
    ///   <para>umbel:isLike</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#isLike">http://umbel.org/umbel#isLike</seealso>
    let isLike = Prefixed_Name(umbel, "isLike") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToAbstraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToAbstraction">http://umbel.org/umbel#relatesToAbstraction</seealso>
    let relatesToAbstraction =
        Prefixed_Name(umbel, "relatesToAbstraction") |> PrefixedName

    /// <summary>
    ///   <para>umbel:AbstractLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#AbstractLevel">http://umbel.org/umbel#AbstractLevel</seealso>
    let AbstractLevel = Prefixed_Name(umbel, "AbstractLevel") |> PrefixedName
    /// <summary>
    ///   <para>umbel:SuperType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#SuperType">http://umbel.org/umbel#SuperType</seealso>
    let SuperType = Prefixed_Name(umbel, "SuperType") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Activities">http://umbel.org/umbel#Activities</seealso>
    let Activities = Prefixed_Name(umbel, "Activities") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Animals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Animals">http://umbel.org/umbel#Animals</seealso>
    let Animals = Prefixed_Name(umbel, "Animals") |> PrefixedName
    /// <summary>
    ///   <para>umbel:AudioInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#AudioInfo">http://umbel.org/umbel#AudioInfo</seealso>
    let AudioInfo = Prefixed_Name(umbel, "AudioInfo") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Chemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Chemistry">http://umbel.org/umbel#Chemistry</seealso>
    let Chemistry = Prefixed_Name(umbel, "Chemistry") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Drugs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Drugs">http://umbel.org/umbel#Drugs</seealso>
    let Drugs = Prefixed_Name(umbel, "Drugs") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Earthscape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Earthscape">http://umbel.org/umbel#Earthscape</seealso>
    let Earthscape = Prefixed_Name(umbel, "Earthscape") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Facilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Facilities">http://umbel.org/umbel#Facilities</seealso>
    let Facilities = Prefixed_Name(umbel, "Facilities") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Geopolitical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Geopolitical">http://umbel.org/umbel#Geopolitical</seealso>
    let Geopolitical = Prefixed_Name(umbel, "Geopolitical") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Numbers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Numbers">http://umbel.org/umbel#Numbers</seealso>
    let Numbers = Prefixed_Name(umbel, "Numbers") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Organizations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Organizations">http://umbel.org/umbel#Organizations</seealso>
    let Organizations = Prefixed_Name(umbel, "Organizations") |> PrefixedName
    /// <summary>
    ///   <para>umbel:PersonTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#PersonTypes">http://umbel.org/umbel#PersonTypes</seealso>
    let PersonTypes = Prefixed_Name(umbel, "PersonTypes") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Plants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Plants">http://umbel.org/umbel#Plants</seealso>
    let Plants = Prefixed_Name(umbel, "Plants") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Society</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Society">http://umbel.org/umbel#Society</seealso>
    let Society = Prefixed_Name(umbel, "Society") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Time">http://umbel.org/umbel#Time</seealso>
    let Time = Prefixed_Name(umbel, "Time") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Workplaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Workplaces">http://umbel.org/umbel#Workplaces</seealso>
    let Workplaces = Prefixed_Name(umbel, "Workplaces") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Events</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Events">http://umbel.org/umbel#Events</seealso>
    let Events = Prefixed_Name(umbel, "Events") |> PrefixedName
    /// <summary>
    ///   <para>umbel:NaturalPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#NaturalPhenomena">http://umbel.org/umbel#NaturalPhenomena</seealso>
    let NaturalPhenomena = Prefixed_Name(umbel, "NaturalPhenomena") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Notations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Notations">http://umbel.org/umbel#Notations</seealso>
    let Notations = Prefixed_Name(umbel, "Notations") |> PrefixedName
    /// <summary>
    ///   <para>umbel:StructuredInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#StructuredInfo">http://umbel.org/umbel#StructuredInfo</seealso>
    let StructuredInfo = Prefixed_Name(umbel, "StructuredInfo") |> PrefixedName
    /// <summary>
    ///   <para>umbel:VisualInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#VisualInfo">http://umbel.org/umbel#VisualInfo</seealso>
    let VisualInfo = Prefixed_Name(umbel, "VisualInfo") |> PrefixedName
    /// <summary>
    ///   <para>umbel:WrittenInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#WrittenInfo">http://umbel.org/umbel#WrittenInfo</seealso>
    let WrittenInfo = Prefixed_Name(umbel, "WrittenInfo") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Attributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Attributes">http://umbel.org/umbel#Attributes</seealso>
    let Attributes = Prefixed_Name(umbel, "Attributes") |> PrefixedName
    /// <summary>
    ///   <para>umbel:Diseases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Diseases">http://umbel.org/umbel#Diseases</seealso>
    let Diseases = Prefixed_Name(umbel, "Diseases") |> PrefixedName
    /// <summary>
    ///   <para>umbel:FoodDrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#FoodDrink">http://umbel.org/umbel#FoodDrink</seealso>
    let FoodDrink = Prefixed_Name(umbel, "FoodDrink") |> PrefixedName

    /// <summary>
    ///   <para>umbel:AutomaticInspectedSMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>umbel:Qualifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#AutomaticInspectedSMatch">http://umbel.org/umbel#AutomaticInspectedSMatch</seealso>
    let AutomaticInspectedSMatch =
        Prefixed_Name(umbel, "AutomaticInspectedSMatch") |> PrefixedName

    /// <summary>
    ///   <para>umbel:Qualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Qualifier">http://umbel.org/umbel#Qualifier</seealso>
    let Qualifier = Prefixed_Name(umbel, "Qualifier") |> PrefixedName

    /// <summary>
    ///   <para>umbel:AutomaticInspectedSV</para>
    /// </summary>
    /// <remarks>
    ///   <para>umbel:Qualifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#AutomaticInspectedSV">http://umbel.org/umbel#AutomaticInspectedSV</seealso>
    let AutomaticInspectedSV =
        Prefixed_Name(umbel, "AutomaticInspectedSV") |> PrefixedName

    /// <summary>
    ///   <para>umbel:AutomaticNotSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>umbel:Qualifier</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#AutomaticNotSpecified">http://umbel.org/umbel#AutomaticNotSpecified</seealso>
    let AutomaticNotSpecified =
        Prefixed_Name(umbel, "AutomaticNotSpecified") |> PrefixedName

    /// <summary>
    ///   <para>umbel:Products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#Products">http://umbel.org/umbel#Products</seealso>
    let Products = Prefixed_Name(umbel, "Products") |> PrefixedName

    /// <summary>
    ///   <para>umbel:ExternalDBOntologyMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>umbel:Qualifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#ExternalDBOntologyMapping">http://umbel.org/umbel#ExternalDBOntologyMapping</seealso>
    let ExternalDBOntologyMapping =
        Prefixed_Name(umbel, "ExternalDBOntologyMapping") |> PrefixedName

    /// <summary>
    ///   <para>umbel:ExternalGeoNamesMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>umbel:Qualifier</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#ExternalGeoNamesMapping">http://umbel.org/umbel#ExternalGeoNamesMapping</seealso>
    let ExternalGeoNamesMapping =
        Prefixed_Name(umbel, "ExternalGeoNamesMapping") |> PrefixedName

    /// <summary>
    ///   <para>umbel:ExternalOpenCycMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>umbel:Qualifier</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#ExternalOpenCycMapping">http://umbel.org/umbel#ExternalOpenCycMapping</seealso>
    let ExternalOpenCycMapping =
        Prefixed_Name(umbel, "ExternalOpenCycMapping") |> PrefixedName

    /// <summary>
    ///   <para>umbel:HeuristicListOfBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>umbel:Qualifier</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#HeuristicListOfBasis">http://umbel.org/umbel#HeuristicListOfBasis</seealso>
    let HeuristicListOfBasis =
        Prefixed_Name(umbel, "HeuristicListOfBasis") |> PrefixedName

    /// <summary>
    ///   <para>umbel:HeuristicNotSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>umbel:Qualifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#HeuristicNotSpecified">http://umbel.org/umbel#HeuristicNotSpecified</seealso>
    let HeuristicNotSpecified =
        Prefixed_Name(umbel, "HeuristicNotSpecified") |> PrefixedName

    /// <summary>
    ///   <para>umbel:ManualNearlyEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>umbel:Qualifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#ManualNearlyEquivalent">http://umbel.org/umbel#ManualNearlyEquivalent</seealso>
    let ManualNearlyEquivalent =
        Prefixed_Name(umbel, "ManualNearlyEquivalent") |> PrefixedName

    /// <summary>
    ///   <para>umbel:ManualSimilarSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>umbel:Qualifier</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#ManualSimilarSense">http://umbel.org/umbel#ManualSimilarSense</seealso>
    let ManualSimilarSense = Prefixed_Name(umbel, "ManualSimilarSense") |> PrefixedName
    /// <summary>
    ///   <para>umbel:MarketsIndustries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#MarketsIndustries">http://umbel.org/umbel#MarketsIndustries</seealso>
    let MarketsIndustries = Prefixed_Name(umbel, "MarketsIndustries") |> PrefixedName
    /// <summary>
    ///   <para>umbel:RefConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#RefConcept">http://umbel.org/umbel#RefConcept</seealso>
    let RefConcept = Prefixed_Name(umbel, "RefConcept") |> PrefixedName
    /// <summary>
    ///   <para>umbel:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#isRelatedTo">http://umbel.org/umbel#isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(umbel, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>umbel:TopicsCategories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#TopicsCategories">http://umbel.org/umbel#TopicsCategories</seealso>
    let TopicsCategories = Prefixed_Name(umbel, "TopicsCategories") |> PrefixedName
    /// <summary>
    ///   <para>umbel:correspondsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property umbel:correspondsTo is used to assert a close correspondence between an external class, named entity, individual or instance with a Reference Concept class. umbel:correspondsTo relates the external class, named entity, individual or instance to the class through the basis of both its subject matter and intended scope. This predicate should be used where the correspondence between the two entities is felt to be nearly equivalent to a sameAs assertion, and is reflexive, but without the full entailments of intensional class memberships. In these cases, both entities are understood to have the same type and intended scope, but without asserting a full class-level or sameAs individual relationship.
    ///
    /// This predicate is designed for the circumstance of aligning two different ontologies or knowledge bases based on node-level correspondences, but without entailing the actual ontological relationships and structure of the object source. For example, the umbel:correspondsTo predicate is used to assert close correspondence between UMBEL Reference Concepts and Wikipedia categories or pages, yet without entailing the actual Wikipedia category structure.
    ///
    /// This property asserts a different and stronger relationship than umbel:isAbout. One practical use is to guide specific instance member determinations when, say, the native structure of the external ontology or knowledge base is to be analyzed and replaced with an UMBEL-based structure.
    ///
    /// This property is therefore used to create a nearly equivalent assertion (however, with the degree of that equivalence being unknown or unknowable) between an external instance or class and a Reference Concept class</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#correspondsTo">http://umbel.org/umbel#correspondsTo</seealso>
    let correspondsTo = Prefixed_Name(umbel, "correspondsTo") |> PrefixedName
    /// <summary>
    ///   <para>umbel:hasCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#hasCharacteristic">http://umbel.org/umbel#hasCharacteristic</seealso>
    let hasCharacteristic = Prefixed_Name(umbel, "hasCharacteristic") |> PrefixedName
    /// <summary>
    ///   <para>umbel:hasMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#hasMapping">http://umbel.org/umbel#hasMapping</seealso>
    let hasMapping = Prefixed_Name(umbel, "hasMapping") |> PrefixedName
    /// <summary>
    ///   <para>umbel:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#isAbout">http://umbel.org/umbel#isAbout</seealso>
    let isAbout = Prefixed_Name(umbel, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>umbel:isCharacteristicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#isCharacteristicOf">http://umbel.org/umbel#isCharacteristicOf</seealso>
    let isCharacteristicOf = Prefixed_Name(umbel, "isCharacteristicOf") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToAnimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToAnimal">http://umbel.org/umbel#relatesToAnimal</seealso>
    let relatesToAnimal = Prefixed_Name(umbel, "relatesToAnimal") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToAttribute">http://umbel.org/umbel#relatesToAttribute</seealso>
    let relatesToAttribute = Prefixed_Name(umbel, "relatesToAttribute") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToAudioInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToAudioInfo">http://umbel.org/umbel#relatesToAudioInfo</seealso>
    let relatesToAudioInfo = Prefixed_Name(umbel, "relatesToAudioInfo") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToChemistry">http://umbel.org/umbel#relatesToChemistry</seealso>
    let relatesToChemistry = Prefixed_Name(umbel, "relatesToChemistry") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToDisease">http://umbel.org/umbel#relatesToDisease</seealso>
    let relatesToDisease = Prefixed_Name(umbel, "relatesToDisease") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToDrug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToDrug">http://umbel.org/umbel#relatesToDrug</seealso>
    let relatesToDrug = Prefixed_Name(umbel, "relatesToDrug") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToEarth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToEarth">http://umbel.org/umbel#relatesToEarth</seealso>
    let relatesToEarth = Prefixed_Name(umbel, "relatesToEarth") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToEvent">http://umbel.org/umbel#relatesToEvent</seealso>
    let relatesToEvent = Prefixed_Name(umbel, "relatesToEvent") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToFacility">http://umbel.org/umbel#relatesToFacility</seealso>
    let relatesToFacility = Prefixed_Name(umbel, "relatesToFacility") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToFinanceEconomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToFinanceEconomy">http://umbel.org/umbel#relatesToFinanceEconomy</seealso>
    let relatesToFinanceEconomy =
        Prefixed_Name(umbel, "relatesToFinanceEconomy") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToFoodDrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToFoodDrink">http://umbel.org/umbel#relatesToFoodDrink</seealso>
    let relatesToFoodDrink = Prefixed_Name(umbel, "relatesToFoodDrink") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToGeoEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToGeoEntity">http://umbel.org/umbel#relatesToGeoEntity</seealso>
    let relatesToGeoEntity = Prefixed_Name(umbel, "relatesToGeoEntity") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToHeavens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToHeavens">http://umbel.org/umbel#relatesToHeavens</seealso>
    let relatesToHeavens = Prefixed_Name(umbel, "relatesToHeavens") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToMarketIndustry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToMarketIndustry">http://umbel.org/umbel#relatesToMarketIndustry</seealso>
    let relatesToMarketIndustry =
        Prefixed_Name(umbel, "relatesToMarketIndustry") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToNotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToNotation">http://umbel.org/umbel#relatesToNotation</seealso>
    let relatesToNotation = Prefixed_Name(umbel, "relatesToNotation") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToNumbers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToNumbers">http://umbel.org/umbel#relatesToNumbers</seealso>
    let relatesToNumbers = Prefixed_Name(umbel, "relatesToNumbers") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToOrganizationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToOrganizationType">http://umbel.org/umbel#relatesToOrganizationType</seealso>
    let relatesToOrganizationType =
        Prefixed_Name(umbel, "relatesToOrganizationType") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToOtherOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToOtherOrganism">http://umbel.org/umbel#relatesToOtherOrganism</seealso>
    let relatesToOtherOrganism =
        Prefixed_Name(umbel, "relatesToOtherOrganism") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToPersonType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToPersonType">http://umbel.org/umbel#relatesToPersonType</seealso>
    let relatesToPersonType =
        Prefixed_Name(umbel, "relatesToPersonType") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToPhenomenon">http://umbel.org/umbel#relatesToPhenomenon</seealso>
    let relatesToPhenomenon =
        Prefixed_Name(umbel, "relatesToPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToPlant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToPlant">http://umbel.org/umbel#relatesToPlant</seealso>
    let relatesToPlant = Prefixed_Name(umbel, "relatesToPlant") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToProductType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToProductType">http://umbel.org/umbel#relatesToProductType</seealso>
    let relatesToProductType =
        Prefixed_Name(umbel, "relatesToProductType") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToSociety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToSociety">http://umbel.org/umbel#relatesToSociety</seealso>
    let relatesToSociety = Prefixed_Name(umbel, "relatesToSociety") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToStructuredInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToStructuredInfo">http://umbel.org/umbel#relatesToStructuredInfo</seealso>
    let relatesToStructuredInfo =
        Prefixed_Name(umbel, "relatesToStructuredInfo") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToSubstance">http://umbel.org/umbel#relatesToSubstance</seealso>
    let relatesToSubstance = Prefixed_Name(umbel, "relatesToSubstance") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToTime">http://umbel.org/umbel#relatesToTime</seealso>
    let relatesToTime = Prefixed_Name(umbel, "relatesToTime") |> PrefixedName
    /// <summary>
    ///   <para>umbel:relatesToTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToTopic">http://umbel.org/umbel#relatesToTopic</seealso>
    let relatesToTopic = Prefixed_Name(umbel, "relatesToTopic") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToVisualInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToVisualInfo">http://umbel.org/umbel#relatesToVisualInfo</seealso>
    let relatesToVisualInfo =
        Prefixed_Name(umbel, "relatesToVisualInfo") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToWorkplace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToWorkplace">http://umbel.org/umbel#relatesToWorkplace</seealso>
    let relatesToWorkplace = Prefixed_Name(umbel, "relatesToWorkplace") |> PrefixedName

    /// <summary>
    ///   <para>umbel:relatesToWrittenInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://umbel.org/umbel#relatesToWrittenInfo">http://umbel.org/umbel#relatesToWrittenInfo</seealso>
    let relatesToWrittenInfo =
        Prefixed_Name(umbel, "relatesToWrittenInfo") |> PrefixedName
