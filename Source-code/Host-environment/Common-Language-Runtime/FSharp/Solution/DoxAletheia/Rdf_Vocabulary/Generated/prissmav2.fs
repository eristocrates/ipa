namespace http.ns.inria.fr.prissma.v2.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module prissmav2 =
    let _namespace_iri = Namespace_Iri prissmav2 |> NamespaceIRI
    /// <summary>
    ///   <para>prissmav2:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#">http://ns.inria.fr/prissma/v2#</seealso>
    let _prefix_iri = Prefixed_Name(prissmav2, "") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Activity class consists in a placemark aimed at modeling a high-level representation of an user action, such as 'running', 'driving', 'working', 'shopping', etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#Activity">http://ns.inria.fr/prissma/v2#Activity</seealso>
    let Activity = Prefixed_Name(prissmav2, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Context class is represents the mobile context and is equivalent to a fresnel:Purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#Context">http://ns.inria.fr/prissma/v2#Context</seealso>
    let Context = Prefixed_Name(prissmav2, "Context") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Device represents the mobile device on which Web of Data resource consumption takes place. It enables device-specific data representation. It is equivalent to the Device class of the delivery context ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#Device">http://ns.inria.fr/prissma/v2#Device</seealso>
    let Device = Prefixed_Name(prissmav2, "Device") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class Environment models the user context in which the resource consumption takes place, therefore enabling customized resource presentation according to specific situations. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#Environment">http://ns.inria.fr/prissma/v2#Environment</seealso>
    let Environment = Prefixed_Name(prissmav2, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:POI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class models a Point of Interest (POI) and consists in a simplified version of W3C Point of Interest Core specifications. POIs are defined as entities that "describe information about locations such as name, category, unique identifier, or civic address"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"POI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#POI">http://ns.inria.fr/prissma/v2#POI</seealso>
    let POI = Prefixed_Name(prissmav2, "POI") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:Prism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Wrapper class for describing the contextual conditions under which a given RDF presentation must be activated."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Prism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#Prism">http://ns.inria.fr/prissma/v2#Prism</seealso>
    let Prism = Prefixed_Name(prissmav2, "Prism") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the target mobile user associated to a prissma:Context. To provide more flexibility, the class can be used to model both user stereotypes and specific users, according to the designer needs. The class is equivalent to foaf:Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#User">http://ns.inria.fr/prissma/v2#User</seealso>
    let User = Prefixed_Name(prissmav2, "User") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:currentPOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property associates a POI to a prissma:Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"currentPOI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#currentPOI">http://ns.inria.fr/prissma/v2#currentPOI</seealso>
    let currentPOI = Prefixed_Name(prissmav2, "currentPOI") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:device</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property associates a Device to a Purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#device">http://ns.inria.fr/prissma/v2#device</seealso>
    let device = Prefixed_Name(prissmav2, "device") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property associates an Environment to a Purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#environment">http://ns.inria.fr/prissma/v2#environment</seealso>
    let environment = Prefixed_Name(prissmav2, "environment") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:motion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Associates any given high-level representation of motion to a prissma:Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"motion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#motion">http://ns.inria.fr/prissma/v2#motion</seealso>
    let motion = Prefixed_Name(prissmav2, "motion") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:nearbyEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The environmental proximity of a generic real-world entity can trigger different resource representations. The property is therefore used to associate nearby objects to the Environment model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nearbyObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#nearbyEntity">http://ns.inria.fr/prissma/v2#nearbyEntity</seealso>
    let nearbyEntity = Prefixed_Name(prissmav2, "nearbyEntity") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:poi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#poi">http://ns.inria.fr/prissma/v2#poi</seealso>
    let poi = Prefixed_Name(prissmav2, "poi") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:poiCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Associates a category to a POI (e.g. monument, restaurant, etc.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"poiCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#poiCategory">http://ns.inria.fr/prissma/v2#poiCategory</seealso>
    let poiCategory = Prefixed_Name(prissmav2, "poiCategory") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:poiLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Associates an identifying resource to a POI (e.g. a given monument, a specific restaurant, etc.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"poiLabel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#poiLabel">http://ns.inria.fr/prissma/v2#poiLabel</seealso>
    let poiLabel = Prefixed_Name(prissmav2, "poiLabel") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the geographic extension of a POI. Value is expressed in metres."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"radius"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#radius">http://ns.inria.fr/prissma/v2#radius</seealso>
    let radius = Prefixed_Name(prissmav2, "radius") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:string</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#string">http://ns.inria.fr/prissma/v2#string</seealso>
    let string = Prefixed_Name(prissmav2, "string") |> PrefixedName
    /// <summary>
    ///   <para>prissmav2:user</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property associates a User to a Purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/prissma/v2#user">http://ns.inria.fr/prissma/v2#user</seealso>
    let user = Prefixed_Name(prissmav2, "user") |> PrefixedName
