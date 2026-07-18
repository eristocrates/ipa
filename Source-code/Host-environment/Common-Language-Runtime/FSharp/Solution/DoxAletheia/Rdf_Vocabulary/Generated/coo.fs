namespace http.purl.org.coo.ns.hash

open DoxAletheia.Rdf_Vocabulary

module coo =
    let _namespace_name = "http://purl.org/coo/ns#"
    /// <summary>
    /// A Base Model is an abstract entity specifying the basic features of a group of vehicles.
    ///
    /// Examples: VW Golf, VW Polo, VW Passat
    /// <see href="http://purl.org/coo/ns#BaseModel"></see></summary>
    let BaseModel = Namespaced_IRI.parse _namespace_name "BaseModel" |> NamespacedName

    /// <summary>
    /// A Configuration Info is an abstract entity that gives information on whether a set of Choices Or Components results in a valid configuration.
    /// Using coo:compatible, it is possible to indicate either compatibility (true) and incompatibility (false) so that modeling remains efficient, no matter whether most combinations are valid or whether most configurations are invalid.
    /// If no such statement is found, the validity of a configuration is unknown.
    ///
    /// Note: The two properties coo:includes and coo:dependsOn, attached to coo:ChoiceOrComponent, may contain additional information on the validity of configuration.
    /// <see href="http://purl.org/coo/ns#ConfigurationInfo"></see></summary>
    let ConfigurationInfo =
        Namespaced_IRI.parse _namespace_name "ConfigurationInfo" |> NamespacedName

    /// <summary>
    /// A Choice or Component is a component (e.g. engine), add-on, feature (color "ocean blue"), or service that can be chosen to be part of a final vehicle configuration.
    ///
    /// Example: Engine 1.6 l TDI, color ocean blue, trailer hitch
    /// <see href="http://purl.org/coo/ns#ChoiceOrComponent"></see></summary>
    let ChoiceOrComponent =
        Namespaced_IRI.parse _namespace_name "ChoiceOrComponent" |> NamespacedName

    /// <summary>
    /// A Derivative is an abstract entity specifying (1) the basic features plus (2) a set of functional (e.g. engine type) and non-functional configuration (e.g. upholstery) choices of a group of vehicles.
    /// A Derivative has often a number of remaining configuration choices (coo:SpecItemCollection attached via coo:hasSpecItems), which will determine the actual properties of the resulting vehicle.
    /// A Derivative should be linked to its Trim via gr:isVariantOf, if available.
    ///
    /// Examples: VW Golf S 1.6 TDI 3door Manual
    /// <see href="http://purl.org/coo/ns#Derivative"></see></summary>
    let Derivative = Namespaced_IRI.parse _namespace_name "Derivative" |> NamespacedName

    /// <summary>
    /// A Property Specification is an abstract entity specifying a set of properties for a vehicle that results from a single choice or the combination of two or more choices and that override the individual properties of the resulting vehicle.
    ///
    /// Example 1: Power steering and Air conditioning in combination reduce the available engine power from 90 kW to 89 kW.
    /// Example 2: Choosing the color option "blue" changes the color of the car to "blue".
    /// <see href="http://purl.org/coo/ns#PropertySpecification"></see></summary>
    let PropertySpecification =
        Namespaced_IRI.parse _namespace_name "PropertySpecification" |> NamespacedName

    /// <summary>
    /// A shortcut for indicating the effect of a choice or set of choices on the unit price. Use positive values for a surcharge and negative values for a deduction.
    ///
    /// Note: Price information should in general be attached to a gr:Offering node, not to a Base Model, Trim, Derivative, or Complete Car Model. Use this shortcut with care.
    /// <see href="http://purl.org/coo/ns#RelativePriceSpecification"></see></summary>
    let RelativePriceSpecification =
        Namespaced_IRI.parse _namespace_name "RelativePriceSpecification" |> NamespacedName

    /// <summary>
    /// A Trim is an abstract entity specifying (1) the basic features plus (2) a set of configuration choices (mostly non-functional) of a group of vehicles.
    /// A Trim should be linked to its Base Model via gr:isVariantOf, if available.
    ///
    /// Examples: VW Golf S, VW Polo Match, VW Passat SE
    /// <see href="http://purl.org/coo/ns#Trim"></see></summary>
    let Trim = Namespaced_IRI.parse _namespace_name "Trim" |> NamespacedName

    /// <summary>
    /// A Complete Car Model is an abstract entity specifying all features and configuration choices needed for actually producing a vehicle. In other words, it is the gr:ProductOrServiceModel ("datasheet") for a completely configured vehicle.
    /// While a Complete Car Model can be defined indepently of a Base Model, Trim, or Derivative, it is usually based on a Derivative plus choices for all mandatory configurational options (coo:SpecItemCollection) of that Derivative.
    /// A Complete Car Model should be linked to its Derivative via gr:isVariantOf, if available.
    ///
    /// Example: VW Golf S 1.6 TDI 3door Manual in ocean blue with air-conditioning, CD player, trailer hitch, power steering, and power windows
    ///
    /// Note: A coo:CompleteCarModel is NOT an actual car, but a complete feature description of one or multiple actual cars.
    /// <see href="http://purl.org/coo/ns#CompleteCarModel"></see></summary>
    let CompleteCarModel =
        Namespaced_IRI.parse _namespace_name "CompleteCarModel" |> NamespacedName

    /// <summary>
    /// A Spec Item Collection is an entity collating multiple coo:ChoiceOrComponent options for a given coo:Derivative, i.e. the available configurational choices.
    /// The default choice can be indicated using a coo:default link. All other choices are attached using coo:availableChoice. The number of coo:ChoiceOrComponent items that can / must be selected for a valid configuration are indicated via coo:min and coo:max.
    /// <see href="http://purl.org/coo/ns#SpecItemCollection"></see></summary>
    let SpecItemCollection =
        Namespaced_IRI.parse _namespace_name "SpecItemCollection" |> NamespacedName

    /// <summary>
    /// This property links available Choices or Components to a Spec Item.
    /// <see href="http://purl.org/coo/ns#availableChoice"></see></summary>
    let availableChoice =
        Namespaced_IRI.parse _namespace_name "availableChoice" |> NamespacedName

    /// <summary>
    /// Links from a Derivative to information on whether a particular configuration is valid (true) or invalid (false)
    /// <see href="http://purl.org/coo/ns#compatibility"></see></summary>
    let compatibility =
        Namespaced_IRI.parse _namespace_name "compatibility" |> NamespacedName

    /// <summary>
    /// Indicates that two Choices or Components are compatible with each other.
    ///
    /// Note: This property is symmetric, i.e., if A is compatible with B, then B is also compatible with A.
    /// <see href="http://purl.org/coo/ns#compatibleWith"></see></summary>
    let compatibleWith =
        Namespaced_IRI.parse _namespace_name "compatibleWith" |> NamespacedName

    /// <summary>
    /// This property links the default Choice or Component to a Spec Item.
    /// Since it is defined a sub-property of coo:availableChoice, the default choice is automatically part of the available choices.
    /// <see href="http://purl.org/coo/ns#default"></see></summary>
    let default_ = Namespaced_IRI.parse _namespace_name "default" |> NamespacedName
    /// <summary>
    /// Links a Choice or Component to one or multiple other Choices Or Components required for that choice
    ///
    /// Note: This property is transitive, i.e., if B is required by A and C and D are required by B, then C and D are also required by A.
    /// <see href="http://purl.org/coo/ns#dependsOn"></see></summary>
    let dependsOn = Namespaced_IRI.parse _namespace_name "dependsOn" |> NamespacedName
    /// <summary>
    /// The position at which the option or element should be listed in a menu or user dialog, lower numbers come first.
    /// The main usage of this property are coo:SpecItemCollection and coo:ChoiceOrComponent, but it is possible to apply it to any owl:Class.
    ///
    /// Note: It is recommended to rely on this property only for data originating from a single RDF graph; otherwise, unpredictable results are possible.
    /// <see href="http://purl.org/coo/ns#displayPos"></see></summary>
    let displayPos = Namespaced_IRI.parse _namespace_name "displayPos" |> NamespacedName

    /// <summary>
    /// Links a coo:ConfigurationInfo node to information on how a choice or component or the combination of multiple choices will override the regular properties of the resulting vehicle
    /// <see href="http://purl.org/coo/ns#featureOverride"></see></summary>
    let featureOverride =
        Namespaced_IRI.parse _namespace_name "featureOverride" |> NamespacedName

    /// <summary>
    /// Links one or multiple Complete Car Models to the underlying Derivative
    /// <see href="http://purl.org/coo/ns#hasCompleteCarModel"></see></summary>
    let hasCompleteCarModel =
        Namespaced_IRI.parse _namespace_name "hasCompleteCarModel" |> NamespacedName

    /// <summary>
    /// Links a Derivative to a Trim
    /// <see href="http://purl.org/coo/ns#hasDerivative"></see></summary>
    let hasDerivative =
        Namespaced_IRI.parse _namespace_name "hasDerivative" |> NamespacedName

    /// <summary>
    /// An annotation property that can be used to attach element identifiers from XML schemas for the corresponding XML data or schema.
    /// <see href="http://purl.org/coo/ns#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName

    /// <summary>
    /// Links a Complete Car Model to the choices for configurational options
    /// <see href="http://purl.org/coo/ns#hasSpecItemChoice"></see></summary>
    let hasSpecItemChoice =
        Namespaced_IRI.parse _namespace_name "hasSpecItemChoice" |> NamespacedName

    /// <summary>
    /// This property links available Spec Items to a Derivative.
    /// <see href="http://purl.org/coo/ns#hasSpecItems"></see></summary>
    let hasSpecItems =
        Namespaced_IRI.parse _namespace_name "hasSpecItems" |> NamespacedName

    /// <summary>
    /// Links a Trim to Base Model
    /// <see href="http://purl.org/coo/ns#hasTrim"></see></summary>
    let hasTrim = Namespaced_IRI.parse _namespace_name "hasTrim" |> NamespacedName
    /// <summary>
    /// Links a Choice or Component to one or multiple other Choices Or Components implicity contained
    ///
    /// Note: This property is transitive, i.e., if B is included in A and C and D are included in B, then C and D are also included in A.
    /// <see href="http://purl.org/coo/ns#includes"></see></summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName

    /// <summary>
    /// Indicates the set of Choices Or Components to which the Configuration Info node refers
    ///
    /// Note 1: Complementing compatibility information can be attached to the components directly via coo:compatibleWith, coo:incompatibleWith, coo:dependsOn, and coo:includes.
    /// Note 2: The coo:ConfigurationInfo node makes only a valid statement for a configuration that includes ALL of the Choices or Components attached via this property.
    /// Note 3: If you want to know whether further components can be added, check that there are no coo:incompatibleWith relationships with any Choice or Component. This check must also be extended to all Choices or Components implicitly included via coo:includes.
    /// Note 4: If you want to know whether some components may be omitted without invalidating the configuration, check that there are no coo:dependsOn relationships with any Choice or Component. This check must also be extended to all Choices Or Components implicitly included via coo:includes.
    /// Note 5: Under an Open World Assumption (OWA), only an explicit compatibility statement for your configuration is really reliable. A weaker guarantee may be sufficient for your application, though.
    /// <see href="http://purl.org/coo/ns#includesChoices"></see></summary>
    let includesChoices =
        Namespaced_IRI.parse _namespace_name "includesChoices" |> NamespacedName

    /// <summary>
    /// Indicates that two Choices or Components are incompatible with each other, independent from other choices.
    ///
    /// Note: This property is symmetric, i.e., if A is incompatible with B, then B is also incompatible with A.
    /// <see href="http://purl.org/coo/ns#incompatibleWith"></see></summary>
    let incompatibleWith =
        Namespaced_IRI.parse _namespace_name "incompatibleWith" |> NamespacedName

    /// <summary>
    /// The maximum number of coo:ChoiceOrComponent entities that can be selected for a valid configuration
    /// <see href="http://purl.org/coo/ns#max"></see></summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName
    /// <summary>
    /// The minimum number of coo:ChoiceOrComponent entities that must be selected for a valid configuration
    /// <see href="http://purl.org/coo/ns#min"></see></summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName

    /// <summary>
    /// Links a coo:ConfigurationInfo node to information on a choice or component or the combination of multiple choices will affect the regular pricing of the resulting vehicle
    ///
    /// Note: The use of gr:addOn is in general a better way of modeling surcharges
    /// <see href="http://purl.org/coo/ns#priceModifier"></see></summary>
    let priceModifier =
        Namespaced_IRI.parse _namespace_name "priceModifier" |> NamespacedName

    /// <summary>
    /// Indicates whether the attached set of choices is a valid (true) or invalid (false) configuration for the Derivative
    /// <see href="http://purl.org/coo/ns#valid"></see></summary>
    let valid = Namespaced_IRI.parse _namespace_name "valid" |> NamespacedName
