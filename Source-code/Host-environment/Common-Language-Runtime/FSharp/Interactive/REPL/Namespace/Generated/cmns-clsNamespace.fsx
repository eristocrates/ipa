#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-cls`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Classifiers/" "cmns-cls"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : aspect^^xsd:string</para>
    ///   <para>skos:definition : characteristic or feature that can be used to dimensionalize, filter, or subset a class, collection, or set of things^^xsd:string</para>
    ///   <para>cmns-av:synonym : characteristic^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/Aspect">cmns-cls:Aspect</a>
    /// </summary>
    let Aspect = _prefixId.prefix "Aspect"
    /// <summary>
    ///   <para>rdfs:label : classification scheme^^xsd:string</para>
    ///   <para>dct:source : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15^^xsd:string</para>
    ///   <para>skos:definition : system for allocating classifiers to things^^xsd:string</para>
    ///   <para>skos:note : ISO 11179-3 defines a classification scheme as descriptive information for an arrangement or division of objects into groups based on criteria such as characteristics, which the objects have in common. A classification scheme may be a taxonomy, a network, an ontology, or any other terminological system. Such classification schemes are intended to permit the classification of arbitrary objects into hierarchies, or partial orders, as appropriate. The classification may also be just a list of controlled vocabulary of property words (or terms). The list might be taken from the 'leaf level' of a taxonomy.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/ClassificationScheme">cmns-cls:ClassificationScheme</a>
    /// </summary>
    let ClassificationScheme = _prefixId.prefix "ClassificationScheme"
    /// <summary>
    ///   <para>rdfs:label : classifier^^xsd:string</para>
    ///   <para>dct:source : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15^^xsd:string</para>
    ///   <para>skos:definition : standardized classification or delineation for something, per some scheme for such delineation, within a specified context^^xsd:string</para>
    ///   <para>skos:example : The classifier 'color' embraces characteristics being red, blue, green, etc. The classifier 'material' embraces characteristics made of wood, metal, etc.^^xsd:string</para>
    ///   <para>skos:note : In ISO 1087, classifiers form categories of characteristics that serve as the criterion of subdivision when establishing concept systems.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/Classifier">cmns-cls:Classifier</a>
    /// </summary>
    let Classifier = _prefixId.prefix "Classifier"
    /// <summary>
    ///   <para>rdfs:label : characterizes^^xsd:string</para>
    ///   <para>skos:definition : provides a discriminating feature or quality of^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/characterizes">cmns-cls:characterizes</a>
    /// </summary>
    let characterizes = _prefixId.prefix "characterizes"
    /// <summary>
    ///   <para>rdfs:label : classifies^^xsd:string</para>
    ///   <para>skos:definition : arranges in categories according to one or more shared characteristics^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/classifies">cmns-cls:classifies</a>
    /// </summary>
    let classifies = _prefixId.prefix "classifies"
    /// <summary>
    ///   <para>rdfs:label : is characterized by^^xsd:string</para>
    ///   <para>skos:definition : indicates a quality or feature of something, distinguishing it from something else^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/isCharacterizedBy">cmns-cls:isCharacterizedBy</a>
    /// </summary>
    let isCharacterizedBy = _prefixId.prefix "isCharacterizedBy"
    /// <summary>
    ///   <para>rdfs:label : is classified by^^xsd:string</para>
    ///   <para>skos:definition : is systematically grouped based on characteristics by^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/isClassifiedBy">cmns-cls:isClassifiedBy</a>
    /// </summary>
    let isClassifiedBy = _prefixId.prefix "isClassifiedBy"
    /// <summary>
    ///   <para>rdfs:label : is exclusive^^xsd:string</para>
    ///   <para>skos:definition : indicates that the classifiers in the scheme are all disjoint and that only one classifier may be used to classify something^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This does not exclude classification by other classifiers from other schemes. It is simply a hint to users that whatever is classified by a classifier in this scheme should be classified by at most one of the classifiers in the scheme.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Classifiers/isExclusive">cmns-cls:isExclusive</a>
    /// </summary>
    let isExclusive = _prefixId.prefix "isExclusive"
