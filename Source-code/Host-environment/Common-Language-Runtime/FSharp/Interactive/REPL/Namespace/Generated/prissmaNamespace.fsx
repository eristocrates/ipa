#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module prissma =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/prissma/v2#" "prissma"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Activity^^xsd:string</para>
    ///   <para>rdfs:comment : The Activity class consists in a placemark aimed at modeling a high-level representation of an user action, such as 'running', 'driving', 'working', 'shopping', etc.^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#Activity">prissma:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Context^^xsd:string</para>
    ///   <para>rdfs:comment : The Context class is represents the mobile context and is equivalent to a fresnel:Purpose^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#Context">prissma:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Device^^xsd:string</para>
    ///   <para>rdfs:comment : The Device represents the mobile device on which Web of Data resource consumption takes place. It enables device-specific data representation. It is equivalent to the Device class of the delivery context ontology^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#Device">prissma:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Environment^^xsd:string</para>
    ///   <para>rdfs:comment : The class Environment models the user context in which the resource consumption takes place, therefore enabling customized resource presentation according to specific situations. ^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#Environment">prissma:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : POI^^xsd:string</para>
    ///   <para>rdfs:comment : The class models a Point of Interest (POI) and consists in a simplified version of W3C Point of Interest Core specifications. POIs are defined as entities that "describe information about locations such as name, category, unique identifier, or civic address".^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#POI">prissma:POI</a>
    /// </summary>
    let POI = _prefixId.prefix "POI"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Prism^^xsd:string</para>
    ///   <para>rdfs:comment : Wrapper class for describing the contextual conditions under which a given RDF presentation must be activated.^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#Prism">prissma:Prism</a>
    /// </summary>
    let Prism = _prefixId.prefix "Prism"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the target mobile user associated to a prissma:Context. To provide more flexibility, the class can be used to model both user stereotypes and specific users, according to the designer needs. The class is equivalent to foaf:Person^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#User">prissma:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : currentPOI^^xsd:string</para>
    ///   <para>rdfs:comment : The property associates a POI to a prissma:Environment^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#currentPOI">prissma:currentPOI</a>
    /// </summary>
    let currentPOI = _prefixId.prefix "currentPOI"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : device^^xsd:string</para>
    ///   <para>rdfs:comment : The property associates a Device to a Purpose^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#device">prissma:device</a>
    /// </summary>
    let device = _prefixId.prefix "device"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : environment^^xsd:string</para>
    ///   <para>rdfs:comment : The property associates an Environment to a Purpose^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#environment">prissma:environment</a>
    /// </summary>
    let environment = _prefixId.prefix "environment"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : motion^^xsd:string</para>
    ///   <para>rdfs:comment : Associates any given high-level representation of motion to a prissma:Environment^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#motion">prissma:motion</a>
    /// </summary>
    let motion = _prefixId.prefix "motion"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : nearbyObject^^xsd:string</para>
    ///   <para>rdfs:comment : The environmental proximity of a generic real-world entity can trigger different resource representations. The property is therefore used to associate nearby objects to the Environment model.^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#nearbyEntity">prissma:nearbyEntity</a>
    /// </summary>
    let nearbyEntity = _prefixId.prefix "nearbyEntity"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : poiCategory^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a category to a POI (e.g. monument, restaurant, etc.)^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#poiCategory">prissma:poiCategory</a>
    /// </summary>
    let poiCategory = _prefixId.prefix "poiCategory"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : poiLabel^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an identifying resource to a POI (e.g. a given monument, a specific restaurant, etc.)^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#poiLabel">prissma:poiLabel</a>
    /// </summary>
    let poiLabel = _prefixId.prefix "poiLabel"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : radius^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the geographic extension of a POI. Value is expressed in metres.^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#radius">prissma:radius</a>
    /// </summary>
    let radius = _prefixId.prefix "radius"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : user^^xsd:string</para>
    ///   <para>rdfs:comment : The property associates a User to a Purpose^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/prissma/v2#user">prissma:user</a>
    /// </summary>
    let user = _prefixId.prefix "user"
