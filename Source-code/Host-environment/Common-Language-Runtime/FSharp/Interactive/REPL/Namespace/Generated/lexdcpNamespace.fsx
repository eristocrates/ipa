#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lexdcp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/decomp#" "lexdcp"

    /// <summary>
    ///   <para>rdfs:label : компонентrdfs:label : composantrdfs:label : componentrdfs:label : componentrdfs:label : bestanddeelrdfs:label : komponentrdfs:label : komponentrdfs:label : Komponenterdfs:label : componenterdfs:label : componenterdfs:label : componente</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A component is a particular realization of a lexical entry that forms part of a compound lexical entry.rdfs:comment : Компонент является конкретной реализацией лексического элемента, который образует часть составной лексической записи.</para>
    ///   <a href="http://www.w3.org/ns/lemon/decomp#Component">lexdcp:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>rdfs:label : constituentrdfs:label : constituentrdfs:label : constituentrdfs:label : constituentrdfs:label : costituenterdfs:label : Konstituenterdfs:label : составнойrdfs:label : konstituentrdfs:label : konstituentrdfs:label : constituinterdfs:label : constituyente</para>
    ///   <para>rdfs:comment : Свойство 'составной' связывает словарную единицу или компонент с компонентом, который он образует.rdfs:comment : The property 'constituent' relates a lexical entry or component to a component that it is constituted by.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/decomp#constituent">lexdcp:constituent</a>
    /// </summary>
    let constituent = _prefixId.prefix "constituent"
    /// <summary>
    ///   <para>rdfs:label : соответствиеrdfs:label : corresponds tordfs:label : correspond àrdfs:label : corrisponde ardfs:label : komt overeen metrdfs:label : corresponde ardfs:label : entspricht</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The property 'correspondsTo' links a component to a corresponding lexical entry or argument.rdfs:comment : Свойство 'соответствие' связывает компонент с соответствующей словарной единицей или аргументом.</para>
    ///   <a href="http://www.w3.org/ns/lemon/decomp#correspondsTo">lexdcp:correspondsTo</a>
    /// </summary>
    let correspondsTo = _prefixId.prefix "correspondsTo"
    /// <summary>
    ///   <para>rdfs:label : sotto-terminerdfs:label : subtermordfs:label : Teiltermrdfs:label : subtermrdfs:label : sous-termerdfs:label : subtermrdfs:label : subtermenrdfs:label : подчинениеrdfs:label : undertermrdfs:label : sub-término</para>
    ///   <para>rdfs:comment : The property 'subterm' relates a compound lexical entry to one of the lexical entries it is composed of.rdfs:comment : Свойство 'подчинение' связывает составную словарную единицу с одной из словарных единиц, из которых она состоит.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/decomp#subterm">lexdcp:subterm</a>
    /// </summary>
    let subterm = _prefixId.prefix "subterm"
