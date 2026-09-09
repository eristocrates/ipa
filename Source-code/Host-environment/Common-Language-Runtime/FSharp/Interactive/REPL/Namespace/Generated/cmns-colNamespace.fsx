#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-col`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Collections/" "cmns-col"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : arrangement^^xsd:string</para>
    ///   <para>skos:definition : systematic plan, manner, or method for making, doing, achieving, or organizing something^^xsd:string</para>
    ///   <para>skos:example : Examples include designs, schema, models, methodologies, alphabetical or numeric ordering, and the like.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/Arrangement">cmns-col:Arrangement</a>
    /// </summary>
    let Arrangement = _prefixId.prefix "Arrangement"
    /// <summary>
    ///   <para>rdfs:label : collection^^xsd:string</para>
    ///   <para>skos:definition : grouping of things (may be zero) that have some shared significance^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Users should use either comprises or hasPart, or one of their respective subproperties, to include things in a collection.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/Collection">cmns-col:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : constituent^^xsd:string</para>
    ///   <para>skos:definition : component of a collection or combination of things^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Users should use either isIncludedIn or isPartOf, or one of their respective subproperties, to include a constituent in a collection.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/Constituent">cmns-col:Constituent</a>
    /// </summary>
    let Constituent = _prefixId.prefix "Constituent"
    /// <summary>
    ///   <para>rdfs:label : structured collection^^xsd:string</para>
    ///   <para>skos:definition : collection that has a clearly defined structure or organization^^xsd:string</para>
    ///   <para>skos:example : Examples include collections organized thematically, alphabetically, by method used to develop them, according to time and/or version, or based on encoding schemes such as the Dewey Decimal System or Library of Congress Subject Headings.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Users should use the hasMethod property on arrangement to describe the methodology for structuring the collection.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/StructuredCollection">cmns-col:StructuredCollection</a>
    /// </summary>
    let StructuredCollection = _prefixId.prefix "StructuredCollection"
    /// <summary>
    ///   <para>rdfs:label : complies with^^xsd:string</para>
    ///   <para>skos:definition : adheres to policies or rules specified in^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/compliesWith">cmns-col:compliesWith</a>
    /// </summary>
    let compliesWith = _prefixId.prefix "compliesWith"
    /// <summary>
    ///   <para>rdfs:label : comprises^^xsd:string</para>
    ///   <para>skos:definition : includes, consists of, or contains, especially within a particular scope^^xsd:string</para>
    ///   <para>skos:note : Note that something can be comprised of something(s) that may or may not be understood as separable parts. In other words, comprises does not imply countability or uniqueness. Whole-part relations are transitive, whereas comprises is not defined to be transitive, so this property is useful in cases where cardinality constraints are needed. comprises and hasPart are not explicitly declared as disjoint to avoid reasoning issues, but should be considered as such.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/comprises">cmns-col:comprises</a>
    /// </summary>
    let comprises = _prefixId.prefix "comprises"
    /// <summary>
    ///   <para>rdfs:label : has arrangement^^xsd:string</para>
    ///   <para>skos:definition : is structured or organized according to^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/hasArrangement">cmns-col:hasArrangement</a>
    /// </summary>
    let hasArrangement = _prefixId.prefix "hasArrangement"
    /// <summary>
    ///   <para>rdfs:label : has constituent^^xsd:string</para>
    ///   <para>skos:definition : consists of or contains^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This property is disjoint with hasMember, and should be used in cases where the constituents of something are not considered discrete elements of whatever they are included in, such as a substance or composite.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/hasConstituent">cmns-col:hasConstituent</a>
    /// </summary>
    let hasConstituent = _prefixId.prefix "hasConstituent"
    /// <summary>
    ///   <para>rdfs:label : has direct part^^xsd:string</para>
    ///   <para>skos:definition : indicates an immediate 'child' part of something^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This property is useful in cases where one is interested in the direct relationships between parts of things, for example to build a tree view.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/hasDirectPart">cmns-col:hasDirectPart</a>
    /// </summary>
    let hasDirectPart = _prefixId.prefix "hasDirectPart"
    /// <summary>
    ///   <para>rdfs:label : has member^^xsd:string</para>
    ///   <para>skos:definition : includes, as a discrete element^^xsd:string</para>
    ///   <para>skos:note : Note that the domain of hasMember should be some sort of collection, aggregate, or group. In the Financial Industry Business Ontology (FIBO), hasMember is used in the case of parties (people and organizations), whereas comprises can have anything in its range.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/hasMember">cmns-col:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : has method^^xsd:string</para>
    ///   <para>skos:definition : provides a text description of an approach or method used to accomplish something^^xsd:string</para>
    ///   <para>skos:example : This property can be used to describe an arrangement or ordering applied to a collection.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/hasMethod">cmns-col:hasMethod</a>
    /// </summary>
    let hasMethod = _prefixId.prefix "hasMethod"
    /// <summary>
    ///   <para>rdfs:label : has part^^xsd:string</para>
    ///   <para>dct:source : Stanford Encyclopedia of Philosophy at http://plato.stanford.edu/entries/mereology/^^xsd:string</para>
    ///   <para>skos:definition : indicates any portion of something, regardless of whether the portion itself is attached to the remainder or detached; cognitively salient or arbitrarily demarcated; self-connected or disconnected; homogeneous or gerrymandered; material or immaterial; extended or unextended; spatial or temporal^^xsd:string</para>
    ///   <para>skos:note : Note that 'has part' is not a subproperty of 'comprises' in order to enable transitivity for whole-part relationships without limiting the use of cardinality constraints on comprises and membership.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/hasPart">cmns-col:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : is constituent of^^xsd:string</para>
    ///   <para>skos:definition : is a component of something else^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/isConstituentOf">cmns-col:isConstituentOf</a>
    /// </summary>
    let isConstituentOf = _prefixId.prefix "isConstituentOf"
    /// <summary>
    ///   <para>rdfs:label : is direct part of^^xsd:string</para>
    ///   <para>skos:definition : indicates an immediate 'parent' of this part^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This property is useful in cases where one is interested in the direct relationships between parts of things, for example to build a tree view.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/isDirectPartOf">cmns-col:isDirectPartOf</a>
    /// </summary>
    let isDirectPartOf = _prefixId.prefix "isDirectPartOf"
    /// <summary>
    ///   <para>rdfs:label : is included in^^xsd:string</para>
    ///   <para>skos:definition : is contained in or an element of^^xsd:string</para>
    ///   <para>skos:note : Something that is included in something else may be an independently identifiable, discrete element or may be an indistinguishable element once it is combined with the target.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/isIncludedIn">cmns-col:isIncludedIn</a>
    /// </summary>
    let isIncludedIn = _prefixId.prefix "isIncludedIn"
    /// <summary>
    ///   <para>rdfs:label : is member of^^xsd:string</para>
    ///   <para>skos:definition : is a discrete element of^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/isMemberOf">cmns-col:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : is part of^^xsd:string</para>
    ///   <para>dct:source : Stanford Encyclopedia of Philosophy at http://plato.stanford.edu/entries/mereology/^^xsd:string</para>
    ///   <para>skos:definition : relates something to another thing that it is some component or portion of, regardless of how that whole-part relationship is manifested^^xsd:string</para>
    ///   <para>skos:note : Note that 'is part of' is not a subproperty of 'isIncludedIn' in order to enable transitivity for whole-part relationships without limiting the use of cardinality constraints on inclusion and membership.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Collections/isPartOf">cmns-col:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
