namespace https.saref.etsi.org.saref4syst.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4syst =
    let _namespace_iri = Namespace_Iri s4syst |> NamespaceIRI
    /// <summary>
    ///   <para>s4syst:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/">https://saref.etsi.org/saref4syst/</seealso>
    let _prefix_iri = Prefixed_Name(s4syst, "") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of connections between systems. This class qualifies property s4syst:connectedTo. A connection describes potential interactions between systems. Any two connected systems are connected through a connection. A connection can connect more than two systems at the same time."</para>
    /// labels<para>"Connection"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/Connection">https://saref.etsi.org/saref4syst/Connection</seealso>
    let Connection = Prefixed_Name(s4syst, "Connection") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:ConnectionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of connection points of systems, at which they may be connected to other systems. This class qualifies properties s4syst:connectsSystem and s4syst:connectedThrough. A connection point belongs to exactly one system. Any system connected through a connection is connected at one of its connection points to the connection. The system of a connection point that is connected through a connection is itself connected through the connection."</para>
    /// labels<para>"Connection Point"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/ConnectionPoint">https://saref.etsi.org/saref4syst/ConnectionPoint</seealso>
    let ConnectionPoint = Prefixed_Name(s4syst, "ConnectionPoint") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of systems, i.e., systems virtually isolated from the environment, whose behaviour and interactions with the environment are modeled. Systems can be connected to other systems. Connected systems interact in some ways. Systems can also have subsystems. Properties of subsystems somehow contribute to the properties of the supersystem."</para>
    /// labels<para>"System"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/System">https://saref.etsi.org/saref4syst/System</seealso>
    let System = Prefixed_Name(s4syst, "System") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:connectedThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a system to one of its connections to other systems."</para>
    /// labels<para>"connected through"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/connectedThrough">https://saref.etsi.org/saref4syst/connectedThrough</seealso>
    let connectedThrough = Prefixed_Name(s4syst, "connectedThrough") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:connectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Links a system to a system it is connected to. Connected systems interact in some way. The exact meaning of "interact" is defined by sub properties of s4syst:connectedTo. Property s4syst:connectedTo is symmetric. This property can be qualified using class s4syst:Connection, which connects the two systems. If there is a connection between several systems, then one may infer these systems are pairwise connected."</para>
    /// labels<para>"connected to"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/connectedTo">https://saref.etsi.org/saref4syst/connectedTo</seealso>
    let connectedTo = Prefixed_Name(s4syst, "connectedTo") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:connectionPointOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Links a connection point to the one and only one system it belongs to."</para>
    /// labels<para>"connection point to"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/connectionPointOf">https://saref.etsi.org/saref4syst/connectionPointOf</seealso>
    let connectionPointOf = Prefixed_Name(s4syst, "connectionPointOf") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:connectsAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Links a system to one of the connection points at which it connects."</para>
    /// labels<para>"connects at"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/connectsAt">https://saref.etsi.org/saref4syst/connectsAt</seealso>
    let connectsAt = Prefixed_Name(s4syst, "connectsAt") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:connectsSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a connection to one of the systems it connects."</para>
    /// labels<para>"connects system"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/connectsSystem">https://saref.etsi.org/saref4syst/connectsSystem</seealso>
    let connectsSystem = Prefixed_Name(s4syst, "connectsSystem") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:connectsSystemAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a connection to one of the connection points at which it connects a system."</para>
    /// labels<para>"connects system at"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/connectsSystemAt">https://saref.etsi.org/saref4syst/connectsSystemAt</seealso>
    let connectsSystemAt = Prefixed_Name(s4syst, "connectsSystemAt") |> PrefixedName

    /// <summary>
    ///   <para>s4syst:connectsSystemThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a connection point to one of the connections through which it connects its system."</para>
    /// labels<para>"connects system through"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/connectsSystemThrough">https://saref.etsi.org/saref4syst/connectsSystemThrough</seealso>
    let connectsSystemThrough =
        Prefixed_Name(s4syst, "connectsSystemThrough") |> PrefixedName

    /// <summary>
    ///   <para>s4syst:hasSubSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Links a system to one of its sub systems."</para>
    /// labels<para>"has sub-system"</para><para>"has sub system"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/hasSubSystem">https://saref.etsi.org/saref4syst/hasSubSystem</seealso>
    let hasSubSystem = Prefixed_Name(s4syst, "hasSubSystem") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:subSystemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a system to its super system. Properties of subsystems somehow contribute to the properties of the super system. The exact meaning of "contribute is defined by sub properties of s4syst:subSystemOf. Property s4syst:subSystemOf is transitive."</para>
    /// labels<para>"sub system of"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/subSystemOf">https://saref.etsi.org/saref4syst/subSystemOf</seealso>
    let subSystemOf = Prefixed_Name(s4syst, "subSystemOf") |> PrefixedName
    /// <summary>
    ///   <para>s4syst:v1.1.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4syst/v1.1.2/">https://saref.etsi.org/saref4syst/v1.1.2/</seealso>
    let ``v1.1.2/`` = Prefixed_Name(s4syst, "v1.1.2/") |> PrefixedName
