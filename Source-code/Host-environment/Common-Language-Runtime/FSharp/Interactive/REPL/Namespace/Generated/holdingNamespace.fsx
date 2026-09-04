#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module holding =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/holding#" "holding"

    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : Use one of bf:Agent or foaf:Agent</para>
    ///   <a href="http://purl.org/ontology/holding#Agent">holding:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Document</para>
    ///   <para>rdfs:comment : Use one of bibo:Document, foaf:Document, bf:Work or bf:Instance</para>
    ///   <a href="http://purl.org/ontology/holding#Document">holding:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : Use one of bf:HeldItem frbr:Item rdac:Item</para>
    ///   <a href="http://purl.org/ontology/holding#Item">holding:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : broader exemplar</para>
    ///   <para>rdfs:comment : Relates a document to an item that contains an exemplar of the document as part.</para>
    ///   <a href="http://purl.org/ontology/holding#broaderExemplar">holding:broaderExemplar</a>
    /// </summary>
    let broaderExemplar = _prefixId.prefix "broaderExemplar"
    /// <summary>
    ///   <para>rdfs:label : broader exemplar of</para>
    ///   <para>rdfs:comment : Relates an item to a document which is partly exemplified by the item.</para>
    ///   <a href="http://purl.org/ontology/holding#broaderExemplarOf">holding:broaderExemplarOf</a>
    /// </summary>
    let broaderExemplarOf = _prefixId.prefix "broaderExemplarOf"
    /// <summary>
    ///   <para>rdfs:label : collected byrdfs:label : collects</para>
    ///   <para>rdfs:comment : Relates an agent to a document and/or item that is collected by the agent.rdfs:comment : Relates a document and/or item to an agent who collects it.</para>
    ///   <a href="http://purl.org/ontology/holding#collectedBy">holding:collectedBy</a>
    /// </summary>
    let collectedBy = _prefixId.prefix "collectedBy"
    let collects = _prefixId.prefix "collects"
    /// <summary>
    ///   <para>rdfs:label : has exemplar</para>
    ///   <para>rdfs:comment : Relates a document to an item that is an exemplar of the document.</para>
    ///   <a href="http://purl.org/ontology/holding#exemplar">holding:exemplar</a>
    /// </summary>
    let exemplar = _prefixId.prefix "exemplar"
    /// <summary>
    ///   <para>rdfs:label : is examplar of</para>
    ///   <para>rdfs:comment : Relates an item to the document that is exemplified by the item.</para>
    ///   <a href="http://purl.org/ontology/holding#exemplarOf">holding:exemplarOf</a>
    /// </summary>
    let exemplarOf = _prefixId.prefix "exemplarOf"
    /// <summary>
    ///   <para>rdfs:label : held by</para>
    ///   <para>rdfs:comment : Relates an item to an agent who holds the item.</para>
    ///   <a href="http://purl.org/ontology/holding#heldBy">holding:heldBy</a>
    /// </summary>
    let heldBy = _prefixId.prefix "heldBy"
    /// <summary>
    ///   <para>rdfs:label : holds</para>
    ///   <para>rdfs:comment : Relates an agent to an item which the agent holds.</para>
    ///   <a href="http://purl.org/ontology/holding#holds">holding:holds</a>
    /// </summary>
    let holds = _prefixId.prefix "holds"
    /// <summary>
    ///   <para>rdfs:label : label</para>
    ///   <para>rdfs:comment : A call number, shelf mark or similar label of an item</para>
    ///   <a href="http://purl.org/ontology/holding#label">holding:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : narrower exemplar</para>
    ///   <para>rdfs:comment : Relates a document to an item that is an exemplar of a part of the document.</para>
    ///   <a href="http://purl.org/ontology/holding#narrowerExemplar">holding:narrowerExemplar</a>
    /// </summary>
    let narrowerExemplar = _prefixId.prefix "narrowerExemplar"
    /// <summary>
    ///   <para>rdfs:label : narrower exemplar of</para>
    ///   <para>rdfs:comment : Relates an item to a document which is partly exemplified by the item.</para>
    ///   <a href="http://purl.org/ontology/holding#narrowerExemplarOf">holding:narrowerExemplarOf</a>
    /// </summary>
    let narrowerExemplarOf = _prefixId.prefix "narrowerExemplarOf"
