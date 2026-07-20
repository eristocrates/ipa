namespace http.ns.inria.fr.prissma.v2.hash

open DoxAletheia

module prissma =
    let _namespace_name = "http://ns.inria.fr/prissma/v2#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The Activity class consists in a placemark aimed at modeling a high-level representation of an user action, such as 'running', 'driving', 'working', 'shopping', etc.
    /// <see href="http://ns.inria.fr/prissma/v2#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// The Context class is represents the mobile context and is equivalent to a fresnel:Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// The Device represents the mobile device on which Web of Data resource consumption takes place. It enables device-specific data representation. It is equivalent to the Device class of the delivery context ontology
    /// <see href="http://ns.inria.fr/prissma/v2#Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// The class Environment models the user context in which the resource consumption takes place, therefore enabling customized resource presentation according to specific situations.
    /// <see href="http://ns.inria.fr/prissma/v2#Environment"></see></summary>
    let Environment = _prefix "Environment"
    /// <summary>
    /// The class models a Point of Interest (POI) and consists in a simplified version of W3C Point of Interest Core specifications. POIs are defined as entities that "describe information about locations such as name, category, unique identifier, or civic address".
    /// <see href="http://ns.inria.fr/prissma/v2#POI"></see></summary>
    let POI = _prefix "POI"
    /// <summary>
    /// Wrapper class for describing the contextual conditions under which a given RDF presentation must be activated.
    /// <see href="http://ns.inria.fr/prissma/v2#Prism"></see></summary>
    let Prism = _prefix "Prism"
    /// <summary>
    /// Represents the target mobile user associated to a prissma:Context. To provide more flexibility, the class can be used to model both user stereotypes and specific users, according to the designer needs. The class is equivalent to foaf:Person
    /// <see href="http://ns.inria.fr/prissma/v2#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// The property associates a POI to a prissma:Environment
    /// <see href="http://ns.inria.fr/prissma/v2#currentPOI"></see></summary>
    let currentPOI = _prefix "currentPOI"
    /// <summary>
    /// The property associates a Device to a Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#device"></see></summary>
    let device = _prefix "device"
    /// <summary>
    /// The property associates an Environment to a Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#environment"></see></summary>
    let environment = _prefix "environment"
    /// <summary>
    /// Associates any given high-level representation of motion to a prissma:Environment
    /// <see href="http://ns.inria.fr/prissma/v2#motion"></see></summary>
    let motion = _prefix "motion"
    /// <summary>
    /// The environmental proximity of a generic real-world entity can trigger different resource representations. The property is therefore used to associate nearby objects to the Environment model.
    /// <see href="http://ns.inria.fr/prissma/v2#nearbyEntity"></see></summary>
    let nearbyEntity = _prefix "nearbyEntity"
    /// <summary>
    /// Associates a category to a POI (e.g. monument, restaurant, etc.)
    /// <see href="http://ns.inria.fr/prissma/v2#poiCategory"></see></summary>
    let poiCategory = _prefix "poiCategory"
    /// <summary>
    /// Associates an identifying resource to a POI (e.g. a given monument, a specific restaurant, etc.)
    /// <see href="http://ns.inria.fr/prissma/v2#poiLabel"></see></summary>
    let poiLabel = _prefix "poiLabel"
    /// <summary>
    /// Specifies the geographic extension of a POI. Value is expressed in metres.
    /// <see href="http://ns.inria.fr/prissma/v2#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    /// The property associates a User to a Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#user"></see></summary>
    let user = _prefix "user"
