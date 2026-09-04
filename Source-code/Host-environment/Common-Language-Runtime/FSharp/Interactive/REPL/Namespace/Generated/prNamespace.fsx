#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/prv/core#" "pr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Property Reification</para>
    ///   <para>rdfs:comment : The class, which describes the relations of a property reification. That means, its "shortcut relation", its
    /// reification class, and the properties that are relating to the subject and object of the "shortcut relation".</para>
    ///   <a href="http://purl.org/ontology/prv/core#PropertyReification">pr:PropertyReification</a>
    /// </summary>
    let PropertyReification = _prefixId.prefix "PropertyReification"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has object property</para>
    ///   <para>rdfs:comment : Relates to the property of the reification class, which relates to the object of the "shortcut relation".</para>
    ///   <a href="http://purl.org/ontology/prv/core#object_property">pr:object_property</a>
    /// </summary>
    let object_property = _prefixId.prefix "object_property"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has reification class</para>
    ///   <para>rdfs:comment : Relates to the reification class, which can be related to the object and subject property to be able to associate the
    /// object and subject of the "shortcut relation". The reification class should provide detailed descriptions of the relationship that is
    /// described in a simple form by the "shortcut relation".</para>
    ///   <a href="http://purl.org/ontology/prv/core#reification_class">pr:reification_class</a>
    /// </summary>
    let reification_class = _prefixId.prefix "reification_class"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : reified</para>
    ///   <para>rdfs:comment : This property relates an statement identifier of a shortcut relation with an instance of a reification class. Although, this is at the moment not really applicable, because it requires a notation for statement identifier as optional fourth element of a tuple; that means, triple + statement identifier.</para>
    ///   <a href="http://purl.org/ontology/prv/core#reified">pr:reified</a>
    /// </summary>
    let reified = _prefixId.prefix "reified"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has shortcut</para>
    ///   <para>rdfs:comment : Relates to the property of the "shortcut relation" (its predicate).</para>
    ///   <a href="http://purl.org/ontology/prv/core#shortcut">pr:shortcut</a>
    /// </summary>
    let shortcut = _prefixId.prefix "shortcut"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has shortcut property</para>
    ///   <para>rdfs:comment : Relates to the property of the reification class,  which relates to the predicate of the "shortcut relation". So
    /// that the specific property reification can be "verified" (the property of the prv:shortcut relation and this one associated by the
    /// referred shortcut property should be equal).</para>
    ///   <a href="http://purl.org/ontology/prv/core#shortcut_property">pr:shortcut_property</a>
    /// </summary>
    let shortcut_property = _prefixId.prefix "shortcut_property"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has subject property</para>
    ///   <para>rdfs:comment : Relates to the property of the reification class, which relates to the subject of the "shortcut relation".</para>
    ///   <a href="http://purl.org/ontology/prv/core#subject_property">pr:subject_property</a>
    /// </summary>
    let subject_property = _prefixId.prefix "subject_property"
