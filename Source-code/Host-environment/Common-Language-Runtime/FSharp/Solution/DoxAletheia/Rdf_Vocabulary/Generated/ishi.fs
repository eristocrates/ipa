namespace https.w3id.org.ishikawa_diagram_ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ishi =
    let _namespace_iri = Namespace_Iri ishi |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#4S</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#DesignPattern</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Categories are "surroundings", "suppliers", "skills", and  "systems""</para>
    /// labels<para>"Service industry 4S method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#4S">https://w3id.org/ishikawa-diagram-ontology#4S</seealso>
    let _4S = Prefixed_Name(ishi, "4S") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#5MandE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#DesignPattern</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The categories are "measurement", "materials", "methods", "manpower", and "environment""</para>
    /// labels<para>"5M&amp;E structure"</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#5MandE">https://w3id.org/ishikawa-diagram-ontology#5MandE</seealso>
    let _5MandE = Prefixed_Name(ishi, "5MandE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#8P</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#DesignPattern</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The categories are "price", "people", "place", "procedure", "promotion", "processes", "products", and "policies""</para>
    /// labels<para>"Service industry 8P method"</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#8P">https://w3id.org/ishikawa-diagram-ontology#8P</seealso>
    let _8P = Prefixed_Name(ishi, "8P") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Accountable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#Role</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Accountable">https://w3id.org/ishikawa-diagram-ontology#Accountable</seealso>
    let Accountable = Prefixed_Name(ishi, "Accountable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Cause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A cause is a factor where its characteristics has direct influence on the characteristics of another factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Cause">https://w3id.org/ishikawa-diagram-ontology#Cause</seealso>
    let Cause = Prefixed_Name(ishi, "Cause") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#CauseEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CauseEffect is the capacity of a factor to have an effect on the character of another. The class is used to record qualified cause-effect relationships."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CauseEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#CauseEffect">https://w3id.org/ishikawa-diagram-ontology#CauseEffect</seealso>
    let CauseEffect = Prefixed_Name(ishi, "CauseEffect") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#CauseEffectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class is used to record the type of cause-effect relationship that exists between at least one cause and at least one effect."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CauseEffectType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#CauseEffectType">https://w3id.org/ishikawa-diagram-ontology#CauseEffectType</seealso>
    let CauseEffectType = Prefixed_Name(ishi, "CauseEffectType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#CertaintyScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A WeightScale where the numerical weight refers to the certainty."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CertaintyScale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#CertaintyScale">https://w3id.org/ishikawa-diagram-ontology#CertaintyScale</seealso>
    let CertaintyScale = Prefixed_Name(ishi, "CertaintyScale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Consulted</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Consulted">https://w3id.org/ishikawa-diagram-ontology#Consulted</seealso>
    let Consulted = Prefixed_Name(ishi, "Consulted") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#DesignPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class is used to record the design pattern which was applied in the course of the Ishikawa diagram creation. Instances of the class refer to best practices."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DesignPattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#DesignPattern">https://w3id.org/ishikawa-diagram-ontology#DesignPattern</seealso>
    let DesignPattern = Prefixed_Name(ishi, "DesignPattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Diagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A visual representation of an Ishikawa diagram model or of a portion of it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diagram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Diagram">https://w3id.org/ishikawa-diagram-ontology#Diagram</seealso>
    let Diagram = Prefixed_Name(ishi, "Diagram") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#DiagramType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class is used to record the type of the Ishikawa diagram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DiagramType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#DiagramType">https://w3id.org/ishikawa-diagram-ontology#DiagramType</seealso>
    let DiagramType = Prefixed_Name(ishi, "DiagramType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#DoE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#DesignPattern</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The categories are "uncontrollable factors", "controllable factors", "blockable nuisance factors", and "held-constant factors""</para>
    /// labels<para>"Design of experiments"</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#DoE">https://w3id.org/ishikawa-diagram-ontology#DoE</seealso>
    let DoE = Prefixed_Name(ishi, "DoE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An effect is a factor where its characteristics are directly influenced by the characteristics of another factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Effect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Effect">https://w3id.org/ishikawa-diagram-ontology#Effect</seealso>
    let Effect = Prefixed_Name(ishi, "Effect") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evidence refers to all resources that (partially) validate a cause-effeect relationship."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Evidence">https://w3id.org/ishikawa-diagram-ontology#Evidence</seealso>
    let Evidence = Prefixed_Name(ishi, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#EvidenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class is used to specify Evidence resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EvidenceType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#EvidenceType">https://w3id.org/ishikawa-diagram-ontology#EvidenceType</seealso>
    let EvidenceType = Prefixed_Name(ishi, "EvidenceType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A factor is any activity or entity with identified cause-effect relationships in the context of root-cause analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Factor">https://w3id.org/ishikawa-diagram-ontology#Factor</seealso>
    let Factor = Prefixed_Name(ishi, "Factor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#ImpactScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A WeightScale where the numerical weight refers to an imact value. Impact describes the estimated and quantified effect an occurence of a cause-effect relationship might have."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ImpactScale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#ImpactScale">https://w3id.org/ishikawa-diagram-ontology#ImpactScale</seealso>
    let ImpactScale = Prefixed_Name(ishi, "ImpactScale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Informed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#Role</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Informed">https://w3id.org/ishikawa-diagram-ontology#Informed</seealso>
    let Informed = Prefixed_Name(ishi, "Informed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#MajorCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A major cause has a direct cause-effect relationship with the root cause in the context of an Ishikawa diagram. When design patterns are used, major causes are abstract causes which are commonly referred to as categories."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MajorCause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#MajorCause">https://w3id.org/ishikawa-diagram-ontology#MajorCause</seealso>
    let MajorCause = Prefixed_Name(ishi, "MajorCause") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Model class is used to record factors and their cause-effect relationships. It can be seen as the data model of an Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Model">https://w3id.org/ishikawa-diagram-ontology#Model</seealso>
    let Model = Prefixed_Name(ishi, "Model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#ProbabilityScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A WeightScale where the numerical weight refers to a probability value. Probability describes the likelihood of occurence of a cause-effect relationship."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ProbabilityScale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#ProbabilityScale">https://w3id.org/ishikawa-diagram-ontology#ProbabilityScale</seealso>
    let ProbabilityScale = Prefixed_Name(ishi, "ProbabilityScale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Problem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A problem is a factor which does not influence any known factor in the context of an Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Problem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Problem">https://w3id.org/ishikawa-diagram-ontology#Problem</seealso>
    let Problem = Prefixed_Name(ishi, "Problem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#RelevanceScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A WeightScale where the numerical weight refers to a relevance value. Relevance describes the importance a cause-effect relationship has in the context of a root-cause analysis."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RelevanceScale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#RelevanceScale">https://w3id.org/ishikawa-diagram-ontology#RelevanceScale</seealso>
    let RelevanceScale = Prefixed_Name(ishi, "RelevanceScale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Responsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Responsible">https://w3id.org/ishikawa-diagram-ontology#Responsible</seealso>
    let Responsible = Prefixed_Name(ishi, "Responsible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#RiskScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A WeightScale where the numerical weight refers to a risk value. Risk describes the estimated potential damage the occurence of a cause-effect relationship might have. Risk is often calculated as the product of probability and impact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RiskScale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#RiskScale">https://w3id.org/ishikawa-diagram-ontology#RiskScale</seealso>
    let RiskScale = Prefixed_Name(ishi, "RiskScale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role is the function of an agent with respect to a factor. The ontology incorporates role instances adhering to the RASCI model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Role">https://w3id.org/ishikawa-diagram-ontology#Role</seealso>
    let Role = Prefixed_Name(ishi, "Role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#RootCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A root cause is a factor which is not influenced by any known factor in the context of an Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RootCause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#RootCause">https://w3id.org/ishikawa-diagram-ontology#RootCause</seealso>
    let RootCause = Prefixed_Name(ishi, "RootCause") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#STEPC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#DesignPattern</para>
    ///   <para>"The categories are "site", "task", "equipment", "people", and "control""</para>
    /// labels<para>"STEPC method"</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#STEPC">https://w3id.org/ishikawa-diagram-ontology#STEPC</seealso>
    let STEPC = Prefixed_Name(ishi, "STEPC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Supporting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#Role</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Supporting">https://w3id.org/ishikawa-diagram-ontology#Supporting</seealso>
    let Supporting = Prefixed_Name(ishi, "Supporting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An established activity with the goal of peperapring or creating an Ishikawa diagram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Technique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Technique">https://w3id.org/ishikawa-diagram-ontology#Technique</seealso>
    let Technique = Prefixed_Name(ishi, "Technique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The weight class is used to assign values to a cause-effect relationship for priorization. The intended meaning of the weight depends on the referenced WeightScale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Weight">https://w3id.org/ishikawa-diagram-ontology#Weight</seealso>
    let Weight = Prefixed_Name(ishi, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#WeightRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The WeightRange class is used to specify and name subranges."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WeightRange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#WeightRange">https://w3id.org/ishikawa-diagram-ontology#WeightRange</seealso>
    let WeightRange = Prefixed_Name(ishi, "WeightRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#WeightScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class that specifies the min and max range of values for the weight of a cause-effect relationship."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WeightScale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#WeightScale">https://w3id.org/ishikawa-diagram-ontology#WeightScale</seealso>
    let WeightScale = Prefixed_Name(ishi, "WeightScale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#Workshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structured or guided activity to create an Ishikawa diagram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Workshop"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#Workshop">https://w3id.org/ishikawa-diagram-ontology#Workshop</seealso>
    let Workshop = Prefixed_Name(ishi, "Workshop") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#aggravating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#CauseEffectType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#aggravating">https://w3id.org/ishikawa-diagram-ontology#aggravating</seealso>
    let aggravating = Prefixed_Name(ishi, "aggravating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#cause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a Cause to CauseEffect ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#cause">https://w3id.org/ishikawa-diagram-ontology#cause</seealso>
    let cause = Prefixed_Name(ishi, "cause") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#causeEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property links CauseEffects to their Model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"causeEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#causeEffect">https://w3id.org/ishikawa-diagram-ontology#causeEffect</seealso>
    let causeEffect = Prefixed_Name(ishi, "causeEffect") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#causeEffectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link the CauseEffectType to a CauseEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"causeEffectType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#causeEffectType">https://w3id.org/ishikawa-diagram-ontology#causeEffectType</seealso>
    let causeEffectType = Prefixed_Name(ishi, "causeEffectType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#causeEnumerationDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#DiagramType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#causeEnumerationDiagram">https://w3id.org/ishikawa-diagram-ontology#causeEnumerationDiagram</seealso>
    let causeEnumerationDiagram =
        Prefixed_Name(ishi, "causeEnumerationDiagram") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#caused</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to directly link a Cause to an Effect without further qualification. For qualified cause-effect relationships the CauseEffect class is used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"caused"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#caused">https://w3id.org/ishikawa-diagram-ontology#caused</seealso>
    let caused = Prefixed_Name(ishi, "caused") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used to indicate the maximal depth of the visual representation of an Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"depth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#depth">https://w3id.org/ishikawa-diagram-ontology#depth</seealso>
    let depth = Prefixed_Name(ishi, "depth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#designPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property specifies which DesignPattern was used in an Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"designPattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#designPattern">https://w3id.org/ishikawa-diagram-ontology#designPattern</seealso>
    let designPattern = Prefixed_Name(ishi, "designPattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#diagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link the (data) model of an Ishikawa diagram to its visual representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"diagram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#diagram">https://w3id.org/ishikawa-diagram-ontology#diagram</seealso>
    let diagram = Prefixed_Name(ishi, "diagram") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#diagramType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to linke the DiagramType to Diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"diagramType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#diagramType">https://w3id.org/ishikawa-diagram-ontology#diagramType</seealso>
    let diagramType = Prefixed_Name(ishi, "diagramType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#dispersionAnalysisDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#DiagramType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#dispersionAnalysisDiagram">https://w3id.org/ishikawa-diagram-ontology#dispersionAnalysisDiagram</seealso>
    let dispersionAnalysisDiagram =
        Prefixed_Name(ishi, "dispersionAnalysisDiagram") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link an Effect to CauseEffect ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"effect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#effect">https://w3id.org/ishikawa-diagram-ontology#effect</seealso>
    let effect = Prefixed_Name(ishi, "effect") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#enumerated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used to indicate, if factors were enumerated in the visual representation of the Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"enumerated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#enumerated">https://w3id.org/ishikawa-diagram-ontology#enumerated</seealso>
    let enumerated = Prefixed_Name(ishi, "enumerated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#evidenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link the EvidenceType to an Evidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"evidenceType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#evidenceType">https://w3id.org/ishikawa-diagram-ontology#evidenceType</seealso>
    let evidenceType = Prefixed_Name(ishi, "evidenceType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property links Factors to their Model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#factor">https://w3id.org/ishikawa-diagram-ontology#factor</seealso>
    let factor = Prefixed_Name(ishi, "factor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#hadRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Ishikawa ontology, this property is used to assign roles according to the RASCI model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hadRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#hadRole">https://w3id.org/ishikawa-diagram-ontology#hadRole</seealso>
    let hadRole = Prefixed_Name(ishi, "hadRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#hasEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a CauseEffect to any Evidence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#hasEvidence">https://w3id.org/ishikawa-diagram-ontology#hasEvidence</seealso>
    let hasEvidence = Prefixed_Name(ishi, "hasEvidence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#hasNamedRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a WeightRange to a WeightScale."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasNamedRange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#hasNamedRange">https://w3id.org/ishikawa-diagram-ontology#hasNamedRange</seealso>
    let hasNamedRange = Prefixed_Name(ishi, "hasNamedRange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#hasQualitativeEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is qualitative.."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasQualitativeEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#hasQualitativeEvidence">https://w3id.org/ishikawa-diagram-ontology#hasQualitativeEvidence</seealso>
    let hasQualitativeEvidence =
        Prefixed_Name(ishi, "hasQualitativeEvidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#hasQuantitativeEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is quantitative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasQuantitativeEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#hasQuantitativeEvidence">https://w3id.org/ishikawa-diagram-ontology#hasQuantitativeEvidence</seealso>
    let hasQuantitativeEvidence =
        Prefixed_Name(ishi, "hasQuantitativeEvidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#hasWeightRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a WeightScale to the WeightRange which defines its total range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasWeightRange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#hasWeightRange">https://w3id.org/ishikawa-diagram-ontology#hasWeightRange</seealso>
    let hasWeightRange = Prefixed_Name(ishi, "hasWeightRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#illustratedEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used to indicate, if the evidence basis was emphasized in the visual representation of the Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"illustratedEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#illustratedEvidence">https://w3id.org/ishikawa-diagram-ontology#illustratedEvidence</seealso>
    let illustratedEvidence = Prefixed_Name(ishi, "illustratedEvidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#illustratedFactorInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used to indicate, if the factors' influence on the problem were emphasized in the visual representation of the Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"illustratedFactorInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#illustratedFactorInfluence">https://w3id.org/ishikawa-diagram-ontology#illustratedFactorInfluence</seealso>
    let illustratedFactorInfluence =
        Prefixed_Name(ishi, "illustratedFactorInfluence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#illustratedRoles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used to indicate, if responsibilities or roles towards factors were included in the visual representation of the Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"illustratedRoles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#illustratedRoles">https://w3id.org/ishikawa-diagram-ontology#illustratedRoles</seealso>
    let illustratedRoles = Prefixed_Name(ishi, "illustratedRoles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#illustratedWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used to indicate, if weight differences were emphasized in the visual representation of the Ishikawa diagram."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"illustratedWeight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#illustratedWeight">https://w3id.org/ishikawa-diagram-ontology#illustratedWeight</seealso>
    let illustratedWeight = Prefixed_Name(ishi, "illustratedWeight") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#isCauseEffectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse property to causeEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isCauseEffectOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#isCauseEffectOf">https://w3id.org/ishikawa-diagram-ontology#isCauseEffectOf</seealso>
    let isCauseEffectOf = Prefixed_Name(ishi, "isCauseEffectOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#isFactorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse property to factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isFactorOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#isFactorOf">https://w3id.org/ishikawa-diagram-ontology#isFactorOf</seealso>
    let isFactorOf = Prefixed_Name(ishi, "isFactorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link the visual representation of an Ishikawa diagram to its data model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#model">https://w3id.org/ishikawa-diagram-ontology#model</seealso>
    let model = Prefixed_Name(ishi, "model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#neutralizing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#CauseEffectType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#neutralizing">https://w3id.org/ishikawa-diagram-ontology#neutralizing</seealso>
    let neutralizing = Prefixed_Name(ishi, "neutralizing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#noEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#EvidenceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#noEvidence">https://w3id.org/ishikawa-diagram-ontology#noEvidence</seealso>
    let noEvidence = Prefixed_Name(ishi, "noEvidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#productProcessClassificationDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#DiagramType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#productProcessClassificationDiagram">https://w3id.org/ishikawa-diagram-ontology#productProcessClassificationDiagram</seealso>
    let productProcessClassificationDiagram =
        Prefixed_Name(ishi, "productProcessClassificationDiagram") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#qualifiedCauseEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a qualified CauseEffect to a Factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifiedCauseEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffect">https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffect</seealso>
    let qualifiedCauseEffect =
        Prefixed_Name(ishi, "qualifiedCauseEffect") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#qualifiedCauseEffectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a qualified CauseEffect to a Factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifiedCauseEffectOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffectOf">https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffectOf</seealso>
    let qualifiedCauseEffectOf =
        Prefixed_Name(ishi, "qualifiedCauseEffectOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#qualitativeEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#EvidenceType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#qualitativeEvidence">https://w3id.org/ishikawa-diagram-ontology#qualitativeEvidence</seealso>
    let qualitativeEvidence = Prefixed_Name(ishi, "qualitativeEvidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#quantitativeEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ishikawa-diagram-ontology#EvidenceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#quantitativeEvidence">https://w3id.org/ishikawa-diagram-ontology#quantitativeEvidence</seealso>
    let quantitativeEvidence =
        Prefixed_Name(ishi, "quantitativeEvidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property is used to link the WeigthScale to a Weight."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"scale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#scale">https://w3id.org/ishikawa-diagram-ontology#scale</seealso>
    let scale = Prefixed_Name(ishi, "scale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#undecided</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ishikawa-diagram-ontology#CauseEffectType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#undecided">https://w3id.org/ishikawa-diagram-ontology#undecided</seealso>
    let undecided = Prefixed_Name(ishi, "undecided") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#usedTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to indicate which Technique was used in the Workshop"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usedTechnique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#usedTechnique">https://w3id.org/ishikawa-diagram-ontology#usedTechnique</seealso>
    let usedTechnique = Prefixed_Name(ishi, "usedTechnique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#wasCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to directly link an Effect to a Cause without further qualification. For qualified cause-effect relationships the CauseEffect class is used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wasCausedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#wasCausedBy">https://w3id.org/ishikawa-diagram-ontology#wasCausedBy</seealso>
    let wasCausedBy = Prefixed_Name(ishi, "wasCausedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology#weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to link a Weight to a CauseEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"weight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology#weight">https://w3id.org/ishikawa-diagram-ontology#weight</seealso>
    let weight = Prefixed_Name(ishi, "weight") |> PrefixedName
