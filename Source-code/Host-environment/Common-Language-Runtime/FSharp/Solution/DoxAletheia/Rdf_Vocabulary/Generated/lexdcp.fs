namespace http.www.w3.org.ns.lemon.decomp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lexdcp =
    let _namespace_iri = Namespace_Iri lexdcp |> NamespaceIRI
    /// <summary>
    ///   <para>lexdcp:constituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'составной' связывает словарную единицу или компонент с компонентом, который он образует.</para>
    ///   <para>The property 'constituent' relates a lexical entry or component to a component that it is constituted by.</para>
    /// labels<para>constituyente</para><para>constituinte</para><para>Konstituente</para><para>constituent</para><para>constituent</para><para>konstituent</para><para>costituente</para><para>konstituent</para><para>constituent</para><para>constituent</para><para>составной</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/decomp#constituent">http://www.w3.org/ns/lemon/decomp#constituent</seealso>
    let constituent = Prefixed_Name(lexdcp, "constituent") |> PrefixedName
    /// <summary>
    ///   <para>lexdcp:subterm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property 'subterm' relates a compound lexical entry to one of the lexical entries it is composed of.</para>
    ///   <para>Свойство 'подчинение' связывает составную словарную единицу с одной из словарных единиц, из которых она состоит.</para>
    /// labels<para>sotto-termine</para><para>sub-término</para><para>sous-terme</para><para>подчинение</para><para>subtermen</para><para>underterm</para><para>subtermo</para><para>Teilterm</para><para>subterm</para><para>subterm</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/decomp#subterm">http://www.w3.org/ns/lemon/decomp#subterm</seealso>
    let subterm = Prefixed_Name(lexdcp, "subterm") |> PrefixedName
    /// <summary>
    ///   <para>lexdcp:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Компонент является конкретной реализацией лексического элемента, который образует часть составной лексической записи.</para>
    ///   <para>A component is a particular realization of a lexical entry that forms part of a compound lexical entry.</para>
    /// labels<para>bestanddeel</para><para>componente</para><para>Komponente</para><para>componente</para><para>componente</para><para>component</para><para>компонент</para><para>composant</para><para>komponent</para><para>component</para><para>komponent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/decomp#Component">http://www.w3.org/ns/lemon/decomp#Component</seealso>
    let Component = Prefixed_Name(lexdcp, "Component") |> PrefixedName
    /// <summary>
    ///   <para>lexdcp:correspondsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property 'correspondsTo' links a component to a corresponding lexical entry or argument.</para>
    ///   <para>Свойство 'соответствие' связывает компонент с соответствующей словарной единицей или аргументом.</para>
    /// labels<para>komt overeen met</para><para>corresponds to</para><para>corresponde a</para><para>corrisponde a</para><para>correspond à</para><para>соответствие</para><para>entspricht</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/decomp#correspondsTo">http://www.w3.org/ns/lemon/decomp#correspondsTo</seealso>
    let correspondsTo = Prefixed_Name(lexdcp, "correspondsTo") |> PrefixedName
