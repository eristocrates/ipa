namespace http.www.w3.org.ns.lemon.decomp.hash

open DoxAletheia.Rdf_Vocabulary

module lexdcp =
    let _namespace_name = "http://www.w3.org/ns/lemon/decomp#"
    /// <summary>
    /// A component is a particular realization of a lexical entry that forms part of a compound lexical entry.
    /// <see href="http://www.w3.org/ns/lemon/decomp#Component"></see></summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName

    /// <summary>
    /// The property 'constituent' relates a lexical entry or component to a component that it is constituted by.
    /// <see href="http://www.w3.org/ns/lemon/decomp#constituent"></see></summary>
    let constituent =
        Namespaced_IRI.parse _namespace_name "constituent" |> NamespacedName

    /// <summary>
    /// The property 'correspondsTo' links a component to a corresponding lexical entry or argument.
    /// <see href="http://www.w3.org/ns/lemon/decomp#correspondsTo"></see></summary>
    let correspondsTo =
        Namespaced_IRI.parse _namespace_name "correspondsTo" |> NamespacedName

    /// <summary>
    /// The property 'subterm' relates a compound lexical entry to one of the lexical entries it is composed of.
    /// Свойство 'подчинение' связывает составную словарную единицу с одной из словарных единиц, из которых она состоит.
    /// <see href="http://www.w3.org/ns/lemon/decomp#subterm"></see></summary>
    let subterm = Namespaced_IRI.parse _namespace_name "subterm" |> NamespacedName
