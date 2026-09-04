#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ibis =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://privatealpha.com/ontology/ibis/1#" "ibis"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:usageNote : An Argument need not only relate in scope to another Argument, but it must only be replaced by another argument.</para>
    ///   <para>rdfs:label : Argument</para>
    ///   <para>rdfs:comment : An Argument is a type of Issue that explicitly supports or refutes a Position.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#Argument">ibis:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>rdfs:label : Invariant</para>
    ///   <para>rdfs:comment : An Issue or Position can be marked Invariant to denote that it has been deemed outside of the influence of the Agents in the system, i.e., something to be steered around.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#Invariant">ibis:Invariant</a>
    /// </summary>
    let Invariant = _prefixId.prefix "Invariant"
    /// <summary>
    ///   <para>rdfs:comment : An Issue is a state of affairs, claimed by one or more Agents to either be a misfit itself, or affecting some other Issue or Position.</para>
    ///   <para>rdfs:label : Issue</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#Issue">ibis:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>rdfs:label : Network</para>
    ///   <para>rdfs:comment : A network of issues, positions, and arguments.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#Network">ibis:Network</a>
    /// </summary>
    let Network = _prefixId.prefix "Network"
    /// <summary>
    ///   <para>rdfs:label : Position</para>
    ///   <para>rdfs:comment : A Position asserts a moral, ethical, pragmatic, or similar kind of assertion, typically identifying what, if anything, should be done about an Issue.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#Position">ibis:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:label : concerns</para>
    ///   <para>rdfs:comment : The subject is an issue concerning the object, which can be any resource.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#concerns">ibis:concerns</a>
    /// </summary>
    let concerns = _prefixId.prefix "concerns"
    /// <summary>
    ///   <para>skos:note : This term, along with ibis:endorses, enables an Agent to signal its agreement with a concept. To signal disagreement, explain why with an ibis:Argument that ibis:opposes the concept.</para>
    ///   <para>rdfs:label : endorsed by</para>
    ///   <para>rdfs:comment : A concept can be endorsed by an Agent without said Agent having mentioned or advanced it initially, and without any additional comment.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#endorsed-by">ibis:endorsed-by</a>
    /// </summary>
    let endorsed_by = _prefixId.prefix "endorsed-by"
    /// <summary>
    ///   <para>skos:note : This term, along with ibis:endorsed-by, enables an Agent to signal its agreement with a concept. To signal disagreement, explain why with an ibis:Argument that ibis:opposes the concept.</para>
    ///   <para>rdfs:label : endorses</para>
    ///   <para>rdfs:comment : An Agent can endorse a concept without having initially mentioned or advanced it, and without any additional comment.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#endorses">ibis:endorses</a>
    /// </summary>
    let endorses = _prefixId.prefix "endorses"
    /// <summary>
    ///   <para>skos:note : The equivalent property skos:narrower asserts that the object is narrower than the subject, while the subject of ibis:generalizes is more general than the object.</para>
    ///   <para>rdfs:label : generalizes</para>
    ///   <para>rdfs:comment : The subject is a more generic form of the object.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#generalizes">ibis:generalizes</a>
    /// </summary>
    let generalizes = _prefixId.prefix "generalizes"
    /// <summary>
    ///   <para>rdfs:label : opposed by</para>
    ///   <para>rdfs:comment : Indicates a subject position opposed by an object argument.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#opposed-by">ibis:opposed-by</a>
    /// </summary>
    let opposed_by = _prefixId.prefix "opposed-by"
    /// <summary>
    ///   <para>rdfs:label : opposes</para>
    ///   <para>rdfs:comment : Indicates a subject argument that opposes an object position.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#opposes">ibis:opposes</a>
    /// </summary>
    let opposes = _prefixId.prefix "opposes"
    /// <summary>
    ///   <para>rdfs:label : questioned by</para>
    ///   <para>rdfs:comment : Indicates a belief called into question by an issue.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#questioned-by">ibis:questioned-by</a>
    /// </summary>
    let questioned_by = _prefixId.prefix "questioned-by"
    /// <summary>
    ///   <para>rdfs:label : questions</para>
    ///   <para>rdfs:comment : Indicates an issue that raises doubt on a belief.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#questions">ibis:questions</a>
    /// </summary>
    let questions = _prefixId.prefix "questions"
    /// <summary>
    ///   <para>rdfs:label : replaced by</para>
    ///   <para>rdfs:comment : Indicates when a concept is replaced by another concept of the same type.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#replaced-by">ibis:replaced-by</a>
    /// </summary>
    let replaced_by = _prefixId.prefix "replaced-by"
    /// <summary>
    ///   <para>rdfs:label : replaces</para>
    ///   <para>rdfs:comment : Indicates when a concept replaces another concept of the same type.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#replaces">ibis:replaces</a>
    /// </summary>
    let replaces = _prefixId.prefix "replaces"
    /// <summary>
    ///   <para>rdfs:label : responds to</para>
    ///   <para>rdfs:comment : Indicates an issue to which the subject position responds.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#responds-to">ibis:responds-to</a>
    /// </summary>
    let responds_to = _prefixId.prefix "responds-to"
    /// <summary>
    ///   <para>rdfs:label : response</para>
    ///   <para>rdfs:comment : Indicates a position that responds to the subject issue.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#response">ibis:response</a>
    /// </summary>
    let response = _prefixId.prefix "response"
    /// <summary>
    ///   <para>skos:note : The equivalent property skos:broader asserts that the object is broader than the subject, while the subject of ibis:specializes is more specific than the object.</para>
    ///   <para>rdfs:label : specializes</para>
    ///   <para>rdfs:comment : The subject is a more specific form of the object.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#specializes">ibis:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"
    /// <summary>
    ///   <para>rdfs:label : suggested by</para>
    ///   <para>rdfs:comment : Indicates when the subject issue is suggested by the object belief.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#suggested-by">ibis:suggested-by</a>
    /// </summary>
    let suggested_by = _prefixId.prefix "suggested-by"
    /// <summary>
    ///   <para>rdfs:label : suggests</para>
    ///   <para>rdfs:comment : Indicates when the subject belief suggests the object issue.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#suggests">ibis:suggests</a>
    /// </summary>
    let suggests = _prefixId.prefix "suggests"
    /// <summary>
    ///   <para>rdfs:label : supported by</para>
    ///   <para>rdfs:comment : Indicates a subject position supported by an object argument.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#supported-by">ibis:supported-by</a>
    /// </summary>
    let supported_by = _prefixId.prefix "supported-by"
    /// <summary>
    ///   <para>rdfs:label : supports</para>
    ///   <para>rdfs:comment : Indicates a subject argument that supports an object position.</para>
    ///   <a href="https://privatealpha.com/ontology/ibis/1#supports">ibis:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
