namespace http.ns.inria.fr.prissma.v2.hash

open DoxAletheia.Rdf_Vocabulary

module prissma =
    let _namespace_name = "http://ns.inria.fr/prissma/v2#"
    /// <summary>
    /// The Activity class consists in a placemark aimed at modeling a high-level representation of an user action, such as 'running', 'driving', 'working', 'shopping', etc.
    /// <see href="http://ns.inria.fr/prissma/v2#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    /// The Context class is represents the mobile context and is equivalent to a fresnel:Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#Context"></see></summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName
    /// <summary>
    /// The Device represents the mobile device on which Web of Data resource consumption takes place. It enables device-specific data representation. It is equivalent to the Device class of the delivery context ontology
    /// <see href="http://ns.inria.fr/prissma/v2#Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName

    /// <summary>
    /// The class Environment models the user context in which the resource consumption takes place, therefore enabling customized resource presentation according to specific situations.
    /// <see href="http://ns.inria.fr/prissma/v2#Environment"></see></summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    /// The class models a Point of Interest (POI) and consists in a simplified version of W3C Point of Interest Core specifications. POIs are defined as entities that "describe information about locations such as name, category, unique identifier, or civic address".
    /// <see href="http://ns.inria.fr/prissma/v2#POI"></see></summary>
    let POI = Namespaced_IRI.parse _namespace_name "POI" |> NamespacedName
    /// <summary>
    /// Wrapper class for describing the contextual conditions under which a given RDF presentation must be activated.
    /// <see href="http://ns.inria.fr/prissma/v2#Prism"></see></summary>
    let Prism = Namespaced_IRI.parse _namespace_name "Prism" |> NamespacedName
    /// <summary>
    /// Represents the target mobile user associated to a prissma:Context. To provide more flexibility, the class can be used to model both user stereotypes and specific users, according to the designer needs. The class is equivalent to foaf:Person
    /// <see href="http://ns.inria.fr/prissma/v2#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// The property associates a POI to a prissma:Environment
    /// <see href="http://ns.inria.fr/prissma/v2#currentPOI"></see></summary>
    let currentPOI = Namespaced_IRI.parse _namespace_name "currentPOI" |> NamespacedName
    /// <summary>
    /// The property associates a Device to a Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#device"></see></summary>
    let device = Namespaced_IRI.parse _namespace_name "device" |> NamespacedName

    /// <summary>
    /// The property associates an Environment to a Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#environment"></see></summary>
    let environment =
        Namespaced_IRI.parse _namespace_name "environment" |> NamespacedName

    /// <summary>
    /// Associates any given high-level representation of motion to a prissma:Environment
    /// <see href="http://ns.inria.fr/prissma/v2#motion"></see></summary>
    let motion = Namespaced_IRI.parse _namespace_name "motion" |> NamespacedName

    /// <summary>
    /// The environmental proximity of a generic real-world entity can trigger different resource representations. The property is therefore used to associate nearby objects to the Environment model.
    /// <see href="http://ns.inria.fr/prissma/v2#nearbyEntity"></see></summary>
    let nearbyEntity =
        Namespaced_IRI.parse _namespace_name "nearbyEntity" |> NamespacedName

    /// <summary>
    /// Associates a category to a POI (e.g. monument, restaurant, etc.)
    /// <see href="http://ns.inria.fr/prissma/v2#poiCategory"></see></summary>
    let poiCategory =
        Namespaced_IRI.parse _namespace_name "poiCategory" |> NamespacedName

    /// <summary>
    /// Associates an identifying resource to a POI (e.g. a given monument, a specific restaurant, etc.)
    /// <see href="http://ns.inria.fr/prissma/v2#poiLabel"></see></summary>
    let poiLabel = Namespaced_IRI.parse _namespace_name "poiLabel" |> NamespacedName
    /// <summary>
    /// Specifies the geographic extension of a POI. Value is expressed in metres.
    /// <see href="http://ns.inria.fr/prissma/v2#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName
    /// <summary>
    /// The property associates a User to a Purpose
    /// <see href="http://ns.inria.fr/prissma/v2#user"></see></summary>
    let user = Namespaced_IRI.parse _namespace_name "user" |> NamespacedName
