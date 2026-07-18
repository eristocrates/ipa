namespace http.linkeddata.finki.ukim.mk.lod.ontology.veo.hash

open DoxAletheia.Rdf_Vocabulary

module veo =
    let _namespace_name = "http://linkeddata.finki.ukim.mk/lod/ontology/veo#"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#Train"></see>
    /// </summary>
    let Train = Namespaced_IRI.parse _namespace_name "Train" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#emissionsPerPassenger"></see>
    /// </summary>
    let emissionsPerPassenger =
        Namespaced_IRI.parse _namespace_name "emissionsPerPassenger" |> NamespacedName

    /// <summary>
    /// This property represents the electric energy consumption of a vehicle measured in Wh/km.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasElectricEnergyConsumtion"></see></summary>
    let hasElectricEnergyConsumtion =
        Namespaced_IRI.parse _namespace_name "hasElectricEnergyConsumtion" |> NamespacedName

    /// <summary>
    /// This property represents emissions reduction measured in g/km that a vehicle has, through the implemented innovative technologies.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEmissionsReduction"></see></summary>
    let hasEmissionsReduction =
        Namespaced_IRI.parse _namespace_name "hasEmissionsReduction" |> NamespacedName

    /// <summary>
    /// This property shows the capacity of the engine of a vehicle measured in cm3
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEngineCapacity"></see></summary>
    let hasEngineCapacity =
        Namespaced_IRI.parse _namespace_name "hasEngineCapacity" |> NamespacedName

    /// <summary>
    /// This property represents the fuel mode of a vehicle
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasFuelMode"></see></summary>
    let hasFuelMode =
        Namespaced_IRI.parse _namespace_name "hasFuelMode" |> NamespacedName

    /// <summary>
    /// This property represents an innovation technology that a vehicle has implemented.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasInnovativeTechnology"></see></summary>
    let hasInnovativeTechnology =
        Namespaced_IRI.parse _namespace_name "hasInnovativeTechnology" |> NamespacedName

    /// <summary>
    /// This property represents a manufacturer name as in the registry of Member States of the European Environment Agency.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasMSRegManufacturerName"></see></summary>
    let hasMSRegManufacturerName =
        Namespaced_IRI.parse _namespace_name "hasMSRegManufacturerName" |> NamespacedName

    /// <summary>
    /// This property represents a manufacturer harmonised name.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerHarmonisedName"></see></summary>
    let hasManufacturerHarmonisedName =
        Namespaced_IRI.parse _namespace_name "hasManufacturerHarmonisedName" |> NamespacedName

    /// <summary>
    /// This property represents a manufacturers pooling.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerPooling"></see></summary>
    let hasManufacturerPooling =
        Namespaced_IRI.parse _namespace_name "hasManufacturerPooling" |> NamespacedName

    /// <summary>
    /// This property represents the width of the other steering axle of a vehicle measured in mm.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasOtherAxleWidth"></see></summary>
    let hasOtherAxleWidth =
        Namespaced_IRI.parse _namespace_name "hasOtherAxleWidth" |> NamespacedName

    /// <summary>
    /// This property represents the width of the steering axle of a vehicle measured in mm.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasSteeringAxleWidth"></see></summary>
    let hasSteeringAxleWidth =
        Namespaced_IRI.parse _namespace_name "hasSteeringAxleWidth" |> NamespacedName

    /// <summary>
    /// This property represents the nubmer of total new registration of a vehicle.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTotalNewRegistrations"></see></summary>
    let hasTotalNewRegistrations =
        Namespaced_IRI.parse _namespace_name "hasTotalNewRegistrations" |> NamespacedName

    /// <summary>
    /// This property represents an internal type approval number.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTypeApprovalNumber"></see></summary>
    let hasTypeApprovalNumber =
        Namespaced_IRI.parse _namespace_name "hasTypeApprovalNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#numberOfPassengers"></see>
    /// </summary>
    let numberOfPassengers =
        Namespaced_IRI.parse _namespace_name "numberOfPassengers" |> NamespacedName

    /// <summary>
    /// This property represents an internal type of vehicle.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// This property represents an internal variant code.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#variant"></see></summary>
    let variant = Namespaced_IRI.parse _namespace_name "variant" |> NamespacedName

    /// <summary>
    /// This property represents a category of the approved vehicle type.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#vehicleTypeApprovedCategory"></see></summary>
    let vehicleTypeApprovedCategory =
        Namespaced_IRI.parse _namespace_name "vehicleTypeApprovedCategory" |> NamespacedName

    /// <summary>
    /// This property represents an internal version code of a vehicle.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
