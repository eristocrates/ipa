namespace http.purl.org.coo.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module coo =
    let _namespace_iri = Namespace_Iri coo |> NamespaceIRI
    /// <summary>
    ///   <para>coo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"COO: The Car Options Ontology
    ///
    /// The COO provides a vocabulary for exposing available configuration options for car models. It allows indicating choices that can be made as well as compatibility, dependency, and inclusion information.
    ///
    /// The ontology imports and extends the GoodRelations ontology for e-commerce, which provides an abstract framework for product model information via gr:ProductOrServiceModel and ist associated properies.
    ///
    /// The main difference between COO and the default patterns for model data in GoodRelations is that GoodRelations requires the materialization of all choices for features, which can quickly lead to very large amounts of data if features can be combines rather freely, due to the combinatorial effects.
    ///
    /// Vocabulary:    http://purl.org/coo/ns
    /// Namespace:     http://purl.org/coo/ns#
    ///
    /// The Car Options Ontology is designed to be used in combination with GoodRelations, a standard vocabulary for the commercial aspects of offers for sale or rental, and the Vehicle Sales Ontology.
    ///
    /// See http://purl.org/goodrelations/  and http://purl.org/vso/ns for more information."</para>
    /// labels<para>"Car Options Ontology"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#">http://purl.org/coo/ns#</seealso>
    let _prefix_iri = Prefixed_Name(coo, "") |> PrefixedName
    /// <summary>
    ///   <para>coo:BaseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Base Model is an abstract entity specifying the basic features of a group of vehicles.
    ///
    /// Examples: VW Golf, VW Polo, VW Passat"</para>
    /// labels<para>"BaseModel"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#BaseModel">http://purl.org/coo/ns#BaseModel</seealso>
    let BaseModel = Prefixed_Name(coo, "BaseModel") |> PrefixedName
    /// <summary>
    ///   <para>coo:ChoiceOrComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Choice or Component is a component (e.g. engine), add-on, feature (color "ocean blue"), or service that can be chosen to be part of a final vehicle configuration.
    ///
    /// Example: Engine 1.6 l TDI, color ocean blue, trailer hitch"</para>
    /// labels<para>"ChoiceOrComponent"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#ChoiceOrComponent">http://purl.org/coo/ns#ChoiceOrComponent</seealso>
    let ChoiceOrComponent = Prefixed_Name(coo, "ChoiceOrComponent") |> PrefixedName
    /// <summary>
    ///   <para>coo:CompleteCarModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Complete Car Model is an abstract entity specifying all features and configuration choices needed for actually producing a vehicle. In other words, it is the gr:ProductOrServiceModel ("datasheet") for a completely configured vehicle.
    /// While a Complete Car Model can be defined indepently of a Base Model, Trim, or Derivative, it is usually based on a Derivative plus choices for all mandatory configurational options (coo:SpecItemCollection) of that Derivative.
    /// A Complete Car Model should be linked to its Derivative via gr:isVariantOf, if available.
    ///
    /// Example: VW Golf S 1.6 TDI 3door Manual in ocean blue with air-conditioning, CD player, trailer hitch, power steering, and power windows
    ///
    /// Note: A coo:CompleteCarModel is NOT an actual car, but a complete feature description of one or multiple actual cars."</para>
    /// labels<para>"CompleteCarModel"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#CompleteCarModel">http://purl.org/coo/ns#CompleteCarModel</seealso>
    let CompleteCarModel = Prefixed_Name(coo, "CompleteCarModel") |> PrefixedName
    /// <summary>
    ///   <para>coo:ConfigurationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Configuration Info is an abstract entity that gives information on whether a set of Choices Or Components results in a valid configuration.
    /// Using coo:compatible, it is possible to indicate either compatibility (true) and incompatibility (false) so that modeling remains efficient, no matter whether most combinations are valid or whether most configurations are invalid.
    /// If no such statement is found, the validity of a configuration is unknown.
    ///
    /// Note: The two properties coo:includes and coo:dependsOn, attached to coo:ChoiceOrComponent, may contain additional information on the validity of configuration."</para>
    /// labels<para>"ConfigurationInfo"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#ConfigurationInfo">http://purl.org/coo/ns#ConfigurationInfo</seealso>
    let ConfigurationInfo = Prefixed_Name(coo, "ConfigurationInfo") |> PrefixedName
    /// <summary>
    ///   <para>coo:Derivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Derivative is an abstract entity specifying (1) the basic features plus (2) a set of functional (e.g. engine type) and non-functional configuration (e.g. upholstery) choices of a group of vehicles.
    /// A Derivative has often a number of remaining configuration choices (coo:SpecItemCollection attached via coo:hasSpecItems), which will determine the actual properties of the resulting vehicle.
    /// A Derivative should be linked to its Trim via gr:isVariantOf, if available.
    ///
    /// Examples: VW Golf S 1.6 TDI 3door Manual"</para>
    /// labels<para>"Derivative"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#Derivative">http://purl.org/coo/ns#Derivative</seealso>
    let Derivative = Prefixed_Name(coo, "Derivative") |> PrefixedName

    /// <summary>
    ///   <para>coo:PropertySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Property Specification is an abstract entity specifying a set of properties for a vehicle that results from a single choice or the combination of two or more choices and that override the individual properties of the resulting vehicle.
    ///
    /// Example 1: Power steering and Air conditioning in combination reduce the available engine power from 90 kW to 89 kW.
    /// Example 2: Choosing the color option "blue" changes the color of the car to "blue"."</para>
    /// labels<para>"PropertySpeciﬁcation"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#PropertySpecification">http://purl.org/coo/ns#PropertySpecification</seealso>
    let PropertySpecification =
        Prefixed_Name(coo, "PropertySpecification") |> PrefixedName

    /// <summary>
    ///   <para>coo:RelativePriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A shortcut for indicating the effect of a choice or set of choices on the unit price. Use positive values for a surcharge and negative values for a deduction.
    ///
    /// Note: Price information should in general be attached to a gr:Offering node, not to a Base Model, Trim, Derivative, or Complete Car Model. Use this shortcut with care."</para>
    /// labels<para>"RelativePriceSpeciﬁcation"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#RelativePriceSpecification">http://purl.org/coo/ns#RelativePriceSpecification</seealso>
    let RelativePriceSpecification =
        Prefixed_Name(coo, "RelativePriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>coo:SpecItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Spec Item Collection is an entity collating multiple coo:ChoiceOrComponent options for a given coo:Derivative, i.e. the available configurational choices.
    /// The default choice can be indicated using a coo:default link. All other choices are attached using coo:availableChoice. The number of coo:ChoiceOrComponent items that can / must be selected for a valid configuration are indicated via coo:min and coo:max."</para>
    /// labels<para>"SpecItemCollection"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#SpecItemCollection">http://purl.org/coo/ns#SpecItemCollection</seealso>
    let SpecItemCollection = Prefixed_Name(coo, "SpecItemCollection") |> PrefixedName
    /// <summary>
    ///   <para>coo:Trim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Trim is an abstract entity specifying (1) the basic features plus (2) a set of configuration choices (mostly non-functional) of a group of vehicles.
    /// A Trim should be linked to its Base Model via gr:isVariantOf, if available.
    ///
    /// Examples: VW Golf S, VW Polo Match, VW Passat SE"</para>
    /// labels<para>"Trim"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#Trim">http://purl.org/coo/ns#Trim</seealso>
    let Trim = Prefixed_Name(coo, "Trim") |> PrefixedName
    /// <summary>
    ///   <para>coo:availableChoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links available Choices or Components to a Spec Item."</para>
    /// labels<para>"availableChoice (1..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#availableChoice">http://purl.org/coo/ns#availableChoice</seealso>
    let availableChoice = Prefixed_Name(coo, "availableChoice") |> PrefixedName
    /// <summary>
    ///   <para>coo:compatibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links from a Derivative to information on whether a particular configuration is valid (true) or invalid (false)"</para>
    /// labels<para>"compatibility (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#compatibility">http://purl.org/coo/ns#compatibility</seealso>
    let compatibility = Prefixed_Name(coo, "compatibility") |> PrefixedName
    /// <summary>
    ///   <para>coo:compatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Indicates that two Choices or Components are compatible with each other.
    ///
    /// Note: This property is symmetric, i.e., if A is compatible with B, then B is also compatible with A."</para>
    /// labels<para>"compatibleWith (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#compatibleWith">http://purl.org/coo/ns#compatibleWith</seealso>
    let compatibleWith = Prefixed_Name(coo, "compatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>coo:default</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links the default Choice or Component to a Spec Item.
    /// Since it is defined a sub-property of coo:availableChoice, the default choice is automatically part of the available choices."</para>
    /// labels<para>"default (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#default">http://purl.org/coo/ns#default</seealso>
    let default_ = Prefixed_Name(coo, "default") |> PrefixedName
    /// <summary>
    ///   <para>coo:dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Links a Choice or Component to one or multiple other Choices Or Components required for that choice
    ///
    /// Note: This property is transitive, i.e., if B is required by A and C and D are required by B, then C and D are also required by A."</para>
    /// labels<para>"dependsOn (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#dependsOn">http://purl.org/coo/ns#dependsOn</seealso>
    let dependsOn = Prefixed_Name(coo, "dependsOn") |> PrefixedName
    /// <summary>
    ///   <para>coo:displayPos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The position at which the option or element should be listed in a menu or user dialog, lower numbers come first.
    /// The main usage of this property are coo:SpecItemCollection and coo:ChoiceOrComponent, but it is possible to apply it to any owl:Class.
    ///
    /// Note: It is recommended to rely on this property only for data originating from a single RDF graph; otherwise, unpredictable results are possible."</para>
    /// labels<para>"displayPos (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#displayPos">http://purl.org/coo/ns#displayPos</seealso>
    let displayPos = Prefixed_Name(coo, "displayPos") |> PrefixedName
    /// <summary>
    ///   <para>coo:featureOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a coo:ConfigurationInfo node to information on how a choice or component or the combination of multiple choices will override the regular properties of the resulting vehicle"</para>
    /// labels<para>"featureOverride (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#featureOverride">http://purl.org/coo/ns#featureOverride</seealso>
    let featureOverride = Prefixed_Name(coo, "featureOverride") |> PrefixedName
    /// <summary>
    ///   <para>coo:hasCompleteCarModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links one or multiple Complete Car Models to the underlying Derivative"</para>
    /// labels<para>"hasCompleteCarModel (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#hasCompleteCarModel">http://purl.org/coo/ns#hasCompleteCarModel</seealso>
    let hasCompleteCarModel = Prefixed_Name(coo, "hasCompleteCarModel") |> PrefixedName
    /// <summary>
    ///   <para>coo:hasDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Derivative to a Trim"</para>
    /// labels<para>"hasDerivative (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#hasDerivative">http://purl.org/coo/ns#hasDerivative</seealso>
    let hasDerivative = Prefixed_Name(coo, "hasDerivative") |> PrefixedName
    /// <summary>
    ///   <para>coo:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An annotation property that can be used to attach element identifiers from XML schemas for the corresponding XML data or schema."</para>
    /// labels<para>"hasID (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#hasID">http://purl.org/coo/ns#hasID</seealso>
    let hasID = Prefixed_Name(coo, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>coo:hasSpecItemChoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Complete Car Model to the choices for configurational options"</para>
    /// labels<para>"hasSpecItemChoice (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#hasSpecItemChoice">http://purl.org/coo/ns#hasSpecItemChoice</seealso>
    let hasSpecItemChoice = Prefixed_Name(coo, "hasSpecItemChoice") |> PrefixedName
    /// <summary>
    ///   <para>coo:hasSpecItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links available Spec Items to a Derivative."</para>
    /// labels<para>"hasSpecItems (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#hasSpecItems">http://purl.org/coo/ns#hasSpecItems</seealso>
    let hasSpecItems = Prefixed_Name(coo, "hasSpecItems") |> PrefixedName
    /// <summary>
    ///   <para>coo:hasTrim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Trim to Base Model"</para>
    /// labels<para>"hasTrim (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#hasTrim">http://purl.org/coo/ns#hasTrim</seealso>
    let hasTrim = Prefixed_Name(coo, "hasTrim") |> PrefixedName
    /// <summary>
    ///   <para>coo:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Links a Choice or Component to one or multiple other Choices Or Components implicity contained
    ///
    /// Note: This property is transitive, i.e., if B is included in A and C and D are included in B, then C and D are also included in A."</para>
    /// labels<para>"includes (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#includes">http://purl.org/coo/ns#includes</seealso>
    let includes = Prefixed_Name(coo, "includes") |> PrefixedName
    /// <summary>
    ///   <para>coo:includesChoices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the set of Choices Or Components to which the Configuration Info node refers
    ///
    /// Note 1: Complementing compatibility information can be attached to the components directly via coo:compatibleWith, coo:incompatibleWith, coo:dependsOn, and coo:includes.
    /// Note 2: The coo:ConfigurationInfo node makes only a valid statement for a configuration that includes ALL of the Choices or Components attached via this property.
    /// Note 3: If you want to know whether further components can be added, check that there are no coo:incompatibleWith relationships with any Choice or Component. This check must also be extended to all Choices or Components implicitly included via coo:includes.
    /// Note 4: If you want to know whether some components may be omitted without invalidating the configuration, check that there are no coo:dependsOn relationships with any Choice or Component. This check must also be extended to all Choices Or Components implicitly included via coo:includes.
    /// Note 5: Under an Open World Assumption (OWA), only an explicit compatibility statement for your configuration is really reliable. A weaker guarantee may be sufficient for your application, though."</para>
    /// labels<para>"includesChoices (1..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#includesChoices">http://purl.org/coo/ns#includesChoices</seealso>
    let includesChoices = Prefixed_Name(coo, "includesChoices") |> PrefixedName
    /// <summary>
    ///   <para>coo:incompatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Indicates that two Choices or Components are incompatible with each other, independent from other choices.
    ///
    /// Note: This property is symmetric, i.e., if A is incompatible with B, then B is also incompatible with A."</para>
    /// labels<para>"incompatibleWith (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#incompatibleWith">http://purl.org/coo/ns#incompatibleWith</seealso>
    let incompatibleWith = Prefixed_Name(coo, "incompatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>coo:max</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum number of coo:ChoiceOrComponent entities that can be selected for a valid configuration"</para>
    /// labels<para>"max (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#max">http://purl.org/coo/ns#max</seealso>
    let max = Prefixed_Name(coo, "max") |> PrefixedName
    /// <summary>
    ///   <para>coo:min</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The minimum number of coo:ChoiceOrComponent entities that must be selected for a valid configuration"</para>
    /// labels<para>"min (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#min">http://purl.org/coo/ns#min</seealso>
    let min = Prefixed_Name(coo, "min") |> PrefixedName
    /// <summary>
    ///   <para>coo:priceModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a coo:ConfigurationInfo node to information on a choice or component or the combination of multiple choices will affect the regular pricing of the resulting vehicle
    ///
    /// Note: The use of gr:addOn is in general a better way of modeling surcharges"</para>
    /// labels<para>"priceModiﬁer (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#priceModifier">http://purl.org/coo/ns#priceModifier</seealso>
    let priceModifier = Prefixed_Name(coo, "priceModifier") |> PrefixedName
    /// <summary>
    ///   <para>coo:valid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether the attached set of choices is a valid (true) or invalid (false) configuration for the Derivative"</para>
    /// labels<para>"valid (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/coo/ns#valid">http://purl.org/coo/ns#valid</seealso>
    let valid = Prefixed_Name(coo, "valid") |> PrefixedName
