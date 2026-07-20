namespace https.saref.etsi.org.saref4syst.slash

open DoxAletheia

module s4syst =
    let _namespace_name = "https://saref.etsi.org/saref4syst/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4syst/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = _prefix "v1.1.2/"
    /// <summary>
    /// The class of connections between systems. This class qualifies property s4syst:connectedTo. A connection describes potential interactions between systems. Any two connected systems are connected through a connection. A connection can connect more than two systems at the same time.
    /// <see href="https://saref.etsi.org/saref4syst/Connection"></see></summary>
    let Connection = _prefix "Connection"
    /// <summary>
    /// The class of systems, i.e., systems virtually isolated from the environment, whose behaviour and interactions with the environment are modeled. Systems can be connected to other systems. Connected systems interact in some ways. Systems can also have subsystems. Properties of subsystems somehow contribute to the properties of the supersystem.
    /// <see href="https://saref.etsi.org/saref4syst/System"></see></summary>
    let System = _prefix "System"
    /// <summary>
    /// Links a connection to one of the systems it connects.
    /// <see href="https://saref.etsi.org/saref4syst/connectsSystem"></see></summary>
    let connectsSystem = _prefix "connectsSystem"
    /// <summary>
    /// The class of connection points of systems, at which they may be connected to other systems. This class qualifies properties s4syst:connectsSystem and s4syst:connectedThrough. A connection point belongs to exactly one system. Any system connected through a connection is connected at one of its connection points to the connection. The system of a connection point that is connected through a connection is itself connected through the connection.
    /// <see href="https://saref.etsi.org/saref4syst/ConnectionPoint"></see></summary>
    let ConnectionPoint = _prefix "ConnectionPoint"
    /// <summary>
    /// Links a connection to one of the connection points at which it connects a system.
    /// <see href="https://saref.etsi.org/saref4syst/connectsSystemAt"></see></summary>
    let connectsSystemAt = _prefix "connectsSystemAt"
    /// <summary>
    /// Links a connection point to the one and only one system it belongs to.
    /// <see href="https://saref.etsi.org/saref4syst/connectionPointOf"></see></summary>
    let connectionPointOf = _prefix "connectionPointOf"
    /// <summary>
    /// Links a system to one of its connections to other systems.
    /// <see href="https://saref.etsi.org/saref4syst/connectedThrough"></see></summary>
    let connectedThrough = _prefix "connectedThrough"
    /// <summary>
    /// Links a system to one of the connection points at which it connects.
    /// <see href="https://saref.etsi.org/saref4syst/connectsAt"></see></summary>
    let connectsAt = _prefix "connectsAt"
    /// <summary>
    /// Links a connection point to one of the connections through which it connects its system.
    /// <see href="https://saref.etsi.org/saref4syst/connectsSystemThrough"></see></summary>
    let connectsSystemThrough = _prefix "connectsSystemThrough"
    /// <summary>
    /// Links a system to a system it is connected to. Connected systems interact in some way. The exact meaning of "interact" is defined by sub properties of s4syst:connectedTo. Property s4syst:connectedTo is symmetric. This property can be qualified using class s4syst:Connection, which connects the two systems. If there is a connection between several systems, then one may infer these systems are pairwise connected.
    /// <see href="https://saref.etsi.org/saref4syst/connectedTo"></see></summary>
    let connectedTo = _prefix "connectedTo"
    /// <summary>
    /// Links a system to one of its sub systems.
    /// <see href="https://saref.etsi.org/saref4syst/hasSubSystem"></see></summary>
    let hasSubSystem = _prefix "hasSubSystem"
    /// <summary>
    /// Links a system to its super system. Properties of subsystems somehow contribute to the properties of the super system. The exact meaning of "contribute is defined by sub properties of s4syst:subSystemOf. Property s4syst:subSystemOf is transitive.
    /// <see href="https://saref.etsi.org/saref4syst/subSystemOf"></see></summary>
    let subSystemOf = _prefix "subSystemOf"
