namespace http.www.w3.org._2007.uwa.context.deliverycontext.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcn =
    let _namespace_iri = Namespace_Iri dcn |> NamespaceIRI
    /// <summary>
    ///   <para>dcn:AllDisjointSet_16</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#AllDisjointSet_16">http://www.w3.org/2007/uwa/context/deliverycontext.owl#AllDisjointSet_16</seealso>
    let AllDisjointSet_16 = Prefixed_Name(dcn, "AllDisjointSet_16") |> PrefixedName
    /// <summary>
    ///   <para>dcn:AllDisjointSet_17</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#AllDisjointSet_17">http://www.w3.org/2007/uwa/context/deliverycontext.owl#AllDisjointSet_17</seealso>
    let AllDisjointSet_17 = Prefixed_Name(dcn, "AllDisjointSet_17") |> PrefixedName
    /// <summary>
    ///   <para>dcn:AllDisjointSet_19</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#AllDisjointSet_19">http://www.w3.org/2007/uwa/context/deliverycontext.owl#AllDisjointSet_19</seealso>
    let AllDisjointSet_19 = Prefixed_Name(dcn, "AllDisjointSet_19") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents Aspects of the Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Aspect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Aspect">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Aspect</seealso>
    let Aspect = Prefixed_Name(dcn, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Aspects_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Aspects_Disjoint">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Aspects_Disjoint</seealso>
    let Aspects_Disjoint = Prefixed_Name(dcn, "Aspects_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Associated_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Associated_Disjoint">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Associated_Disjoint</seealso>
    let Associated_Disjoint = Prefixed_Name(dcn, "Associated_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Associated_Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the base class for associated entities in the ontology. Classes derived from this are not part of the delivery context. Rather, they provide information that could, for example, be used to help create normative documentation from the definitions for the delivery context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Associated Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Associated_Entity">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Associated_Entity</seealso>
    let Associated_Entity = Prefixed_Name(dcn, "Associated_Entity") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Context_Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the base class for the entities that define the Context and particularly the Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Context_Entity">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Context_Entity</seealso>
    let Context_Entity = Prefixed_Name(dcn, "Context_Entity") |> PrefixedName
    /// <summary>
    ///   <para>dcn:DeliveryContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the set of characteristics that describes the context in which materials are exchanged between a service and a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#DeliveryContext">http://www.w3.org/2007/uwa/context/deliverycontext.owl#DeliveryContext</seealso>
    let DeliveryContext = Prefixed_Name(dcn, "DeliveryContext") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a device in the delivery context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Device">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Device</seealso>
    let Device = Prefixed_Name(dcn, "Device") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Disjoint2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint2">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint2</seealso>
    let Disjoint2 = Prefixed_Name(dcn, "Disjoint2") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Disjoint3</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint3">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint3</seealso>
    let Disjoint3 = Prefixed_Name(dcn, "Disjoint3") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Disjoint4</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint4">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint4</seealso>
    let Disjoint4 = Prefixed_Name(dcn, "Disjoint4") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Disjoint5</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint5">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Disjoint5</seealso>
    let Disjoint5 = Prefixed_Name(dcn, "Disjoint5") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the physical environment in which an interaction takes place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Environment">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Environment</seealso>
    let Environment = Prefixed_Name(dcn, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Sibling_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    ///
    /// labels<para>"Main Disjoint Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Sibling_Disjoint">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Sibling_Disjoint</seealso>
    let Sibling_Disjoint = Prefixed_Name(dcn, "Sibling_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>dcn:TermGroup_Main</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TermGroup</para>
    ///   <para>"These are the fundamental Aspects and Properties such as the Device or the Delivery Context itself"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Main"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#TermGroup_Main">http://www.w3.org/2007/uwa/context/deliverycontext.owl#TermGroup_Main</seealso>
    let TermGroup_Main = Prefixed_Name(dcn, "TermGroup_Main") |> PrefixedName
    /// <summary>
    ///   <para>dcn:Top_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    ///   <para>"Global Disjoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Top Level  Disjoint Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#Top_Disjoint">http://www.w3.org/2007/uwa/context/deliverycontext.owl#Top_Disjoint</seealso>
    let Top_Disjoint = Prefixed_Name(dcn, "Top_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>dcn:activeComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is a generic property that represents what Components (Aspect instances) are active in the Context of an Aspect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Active"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#activeComponent">http://www.w3.org/2007/uwa/context/deliverycontext.owl#activeComponent</seealso>
    let activeComponent = Prefixed_Name(dcn, "activeComponent") |> PrefixedName
    /// <summary>
    ///   <para>dcn:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A generic property that represents the relationship between an Aspect of the Delivery Context and its Components (Aspect instances)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#component">http://www.w3.org/2007/uwa/context/deliverycontext.owl#component</seealso>
    let component_ = Prefixed_Name(dcn, "component") |> PrefixedName
    /// <summary>
    ///   <para>dcn:currentDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the currently used device in a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Current Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentDevice">http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentDevice</seealso>
    let currentDevice = Prefixed_Name(dcn, "currentDevice") |> PrefixedName
    /// <summary>
    ///   <para>dcn:currentEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The current physical environment associated to a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentEnvironment">http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentEnvironment</seealso>
    let currentEnvironment = Prefixed_Name(dcn, "currentEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>dcn:currentNetworkBearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the currently used network bearer in a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Current Network Bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentNetworkBearer">http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentNetworkBearer</seealso>
    let currentNetworkBearer =
        Prefixed_Name(dcn, "currentNetworkBearer") |> PrefixedName

    /// <summary>
    ///   <para>dcn:currentRuntimeEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the current runtime environment of a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Current Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentRuntimeEnvironment">http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentRuntimeEnvironment</seealso>
    let currentRuntimeEnvironment =
        Prefixed_Name(dcn, "currentRuntimeEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>dcn:currentUserAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The user agent currently used by the user and responsible of the current interaction in a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Current User Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentUserAgent">http://www.w3.org/2007/uwa/context/deliverycontext.owl#currentUserAgent</seealso>
    let currentUserAgent = Prefixed_Name(dcn, "currentUserAgent") |> PrefixedName
    /// <summary>
    ///   <para>dcn:defaultComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is a generic property that represents a default Component (Aspect instance)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#defaultComponent">http://www.w3.org/2007/uwa/context/deliverycontext.owl#defaultComponent</seealso>
    let defaultComponent = Prefixed_Name(dcn, "defaultComponent") |> PrefixedName
    /// <summary>
    ///   <para>dcn:globalDisjoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#globalDisjoints">http://www.w3.org/2007/uwa/context/deliverycontext.owl#globalDisjoints</seealso>
    let globalDisjoints = Prefixed_Name(dcn, "globalDisjoints") |> PrefixedName
    /// <summary>
    ///   <para>dcn:usablePixelsX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The typical number of pixels in the X direction of the display which can be used within a delivery context. This may be less than the total number available due to the presence of additional items on the display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Usable Pixels X"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#usablePixelsX">http://www.w3.org/2007/uwa/context/deliverycontext.owl#usablePixelsX</seealso>
    let usablePixelsX = Prefixed_Name(dcn, "usablePixelsX") |> PrefixedName
    /// <summary>
    ///   <para>dcn:usablePixelsY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The typical number of pixels in the Y direction of the display which can be used within a delivery context. This may be less than the total number available due to the presence of additional items on the display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Usable  Pixels Y"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#usablePixelsY">http://www.w3.org/2007/uwa/context/deliverycontext.owl#usablePixelsY</seealso>
    let usablePixelsY = Prefixed_Name(dcn, "usablePixelsY") |> PrefixedName
    /// <summary>
    ///   <para>dcn:xx</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:X509Certificate</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/deliverycontext.owl#xx">http://www.w3.org/2007/uwa/context/deliverycontext.owl#xx</seealso>
    let xx = Prefixed_Name(dcn, "xx") |> PrefixedName
