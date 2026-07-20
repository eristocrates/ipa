namespace http.linkeddata.finki.ukim.mk.lod.ontology.veo.hash

open DoxAletheia

module veo =
    let _namespace_name = "http://linkeddata.finki.ukim.mk/lod/ontology/veo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#Train"></see>
    /// </summary>
    let Train = _prefix "Train"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#emissionsPerPassenger"></see>
    /// </summary>
    let emissionsPerPassenger = _prefix "emissionsPerPassenger"
    /// <summary>
    /// This property represents the electric energy consumption of a vehicle measured in Wh/km.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasElectricEnergyConsumtion"></see></summary>
    let hasElectricEnergyConsumtion = _prefix "hasElectricEnergyConsumtion"
    /// <summary>
    /// This property represents emissions reduction measured in g/km that a vehicle has, through the implemented innovative technologies.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEmissionsReduction"></see></summary>
    let hasEmissionsReduction = _prefix "hasEmissionsReduction"
    /// <summary>
    /// This property shows the capacity of the engine of a vehicle measured in cm3
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEngineCapacity"></see></summary>
    let hasEngineCapacity = _prefix "hasEngineCapacity"
    /// <summary>
    /// This property represents the fuel mode of a vehicle
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasFuelMode"></see></summary>
    let hasFuelMode = _prefix "hasFuelMode"
    /// <summary>
    /// This property represents an innovation technology that a vehicle has implemented.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasInnovativeTechnology"></see></summary>
    let hasInnovativeTechnology = _prefix "hasInnovativeTechnology"
    /// <summary>
    /// This property represents a manufacturer name as in the registry of Member States of the European Environment Agency.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasMSRegManufacturerName"></see></summary>
    let hasMSRegManufacturerName = _prefix "hasMSRegManufacturerName"
    /// <summary>
    /// This property represents a manufacturer harmonised name.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerHarmonisedName"></see></summary>
    let hasManufacturerHarmonisedName = _prefix "hasManufacturerHarmonisedName"
    /// <summary>
    /// This property represents a manufacturers pooling.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerPooling"></see></summary>
    let hasManufacturerPooling = _prefix "hasManufacturerPooling"
    /// <summary>
    /// This property represents the width of the other steering axle of a vehicle measured in mm.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasOtherAxleWidth"></see></summary>
    let hasOtherAxleWidth = _prefix "hasOtherAxleWidth"
    /// <summary>
    /// This property represents the width of the steering axle of a vehicle measured in mm.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasSteeringAxleWidth"></see></summary>
    let hasSteeringAxleWidth = _prefix "hasSteeringAxleWidth"
    /// <summary>
    /// This property represents the nubmer of total new registration of a vehicle.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTotalNewRegistrations"></see></summary>
    let hasTotalNewRegistrations = _prefix "hasTotalNewRegistrations"
    /// <summary>
    /// This property represents an internal type approval number.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTypeApprovalNumber"></see></summary>
    let hasTypeApprovalNumber = _prefix "hasTypeApprovalNumber"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#numberOfPassengers"></see>
    /// </summary>
    let numberOfPassengers = _prefix "numberOfPassengers"
    /// <summary>
    /// This property represents an internal type of vehicle.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// This property represents an internal variant code.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#variant"></see></summary>
    let variant = _prefix "variant"
    /// <summary>
    /// This property represents a category of the approved vehicle type.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#vehicleTypeApprovedCategory"></see></summary>
    let vehicleTypeApprovedCategory = _prefix "vehicleTypeApprovedCategory"
    /// <summary>
    /// This property represents an internal version code of a vehicle.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#version"></see></summary>
    let version = _prefix "version"
