#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-cvn`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/cvn/" "ceon-cvn"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Circular Value Network^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : ISO 59004:2024 - 3.5.3 value network^^xsd:string</para>
    ///   <para>rdfs:comment : A network of interlinked value chains and interested parties.</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/CVN">ceon-cvn:CVN</a>
    /// </summary>
    let CVN = _prefixId.prefix "CVN"
    /// <summary>
    ///   <para>rdfs:label : Circular Value Network Blueprint^^xsd:string</para>
    ///   <para>rdfs:comment : A plan or a pattern of a CVN configuration that can then be filled with actual actors and processes. The blueprint can be used to capture a desired setup of a network, or for reusing patterns of CVNs.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/CVNBlueprint">ceon-cvn:CVNBlueprint</a>
    /// </summary>
    let CVNBlueprint = _prefixId.prefix "CVNBlueprint"
    /// <summary>
    ///   <para>rdfs:label : Circular Strategy^^xsd:string</para>
    ///   <para>rdfs:comment : A circular strategy, such as to reccycle, reuse or refurbish something.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/CircularStrategy">ceon-cvn:CircularStrategy</a>
    /// </summary>
    let CircularStrategy = _prefixId.prefix "CircularStrategy"
    /// <summary>
    ///   <para>rdfs:label : Collaboration^^xsd:string</para>
    ///   <para>rdfs:comment : A collaboration between a set of actors.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/Collaboration">ceon-cvn:Collaboration</a>
    /// </summary>
    let Collaboration = _prefixId.prefix "Collaboration"
    /// <summary>
    ///   <para>rdfs:label : aims at value^^xsd:string</para>
    ///   <para>rdfs:comment : The value proposition that the planned abstract CVN configuration, or concrete network wants to achieve.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/aimsAtValue">ceon-cvn:aimsAtValue</a>
    /// </summary>
    let aimsAtValue = _prefixId.prefix "aimsAtValue"
    /// <summary>
    ///   <para>rdfs:label : composed of^^xsd:string</para>
    ///   <para>rdfs:comment : Both a CVN and a process can be composed of other CVNs or processes.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/composedOf">ceon-cvn:composedOf</a>
    /// </summary>
    let composedOf = _prefixId.prefix "composedOf"
    /// <summary>
    ///   <para>rdfs:label : creates value^^xsd:string</para>
    ///   <para>rdfs:comment : Value creation can be captured at the actor level, i.e. value created by an actor's participation in a collaboration, or at the process or complete CVN level.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/createsValue">ceon-cvn:createsValue</a>
    /// </summary>
    let createsValue = _prefixId.prefix "createsValue"
    /// <summary>
    ///   <para>rdfs:label : implements blueprint^^xsd:string</para>
    ///   <para>rdfs:comment : The blueprint (or plan) that this concrete CVN is an instance of.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/implementsBlueprint">ceon-cvn:implementsBlueprint</a>
    /// </summary>
    let implementsBlueprint = _prefixId.prefix "implementsBlueprint"
    /// <summary>
    ///   <para>rdfs:label : implements strategy^^xsd:string</para>
    ///   <para>rdfs:comment : A strategy that is implemented by this CVN or CVN blueprint.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/implementsStrategy">ceon-cvn:implementsStrategy</a>
    /// </summary>
    let implementsStrategy = _prefixId.prefix "implementsStrategy"
    /// <summary>
    ///   <para>rdfs:label : plans to implement strategy^^xsd:string</para>
    ///   <para>rdfs:comment : A strategy that is planned to be implemented by this CVN or CVN blueprint.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/plansToImplementStrategy">ceon-cvn:plansToImplementStrategy</a>
    /// </summary>
    let plansToImplementStrategy = _prefixId.prefix "plansToImplementStrategy"
    /// <summary>
    ///   <para>rdfs:label : related strategy^^xsd:string</para>
    ///   <para>rdfs:comment : A strategy that is targeted by this CVN or CVN blueprint.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/cvn/relatedStrategy">ceon-cvn:relatedStrategy</a>
    /// </summary>
    let relatedStrategy = _prefixId.prefix "relatedStrategy"
