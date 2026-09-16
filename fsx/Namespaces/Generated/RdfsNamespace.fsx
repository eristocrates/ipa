#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdfs =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/01/rdf-schema#" "rdfs"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The class of classes.^^xsd:string</para>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Class">rdfs:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF containers.^^xsd:string</para>
    ///   <para>rdfs:label : Container^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Container">rdfs:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    /// <summary>
    ///   <para>rdfs:comment : The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.^^xsd:string</para>
    ///   <para>rdfs:label : ContainerMembershipProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty">rdfs:ContainerMembershipProperty</a>
    /// </summary>
    let ContainerMembershipProperty = _prefixId.prefix "ContainerMembershipProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF datatypes.^^xsd:string</para>
    ///   <para>rdfs:label : Datatype^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Datatype">rdfs:Datatype</a>
    /// </summary>
    let Datatype = _prefixId.prefix "Datatype"
    /// <summary>
    ///   <para>rdfs:comment : The class of literal values, eg. textual strings and integers.^^xsd:string</para>
    ///   <para>rdfs:label : Literal^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Literal">rdfs:Literal</a>
    /// </summary>
    let Literal = _prefixId.prefix "Literal"
    /// <summary>
    ///   <para>rdfs:comment : The class resource, everything.^^xsd:string</para>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Resource">rdfs:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:comment : A description of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#comment">rdfs:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:comment : A domain of the subject property.^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#domain">rdfs:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:comment : The defininition of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : isDefinedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#isDefinedBy">rdfs:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = _prefixId.prefix "isDefinedBy"
    /// <summary>
    ///   <para>rdfs:comment : A human-readable name for the subject.^^xsd:string</para>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#label">rdfs:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:comment : A member of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#member">rdfs:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:comment : A range of the subject property.^^xsd:string</para>
    ///   <para>rdfs:label : range^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#range">rdfs:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:comment : Further information about the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : seeAlso^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#seeAlso">rdfs:seeAlso</a>
    /// </summary>
    let seeAlso = _prefixId.prefix "seeAlso"
    /// <summary>
    ///   <para>rdfs:comment : The subject is a subclass of a class.^^xsd:string</para>
    ///   <para>rdfs:label : subClassOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#subClassOf">rdfs:subClassOf</a>
    /// </summary>
    let subClassOf = _prefixId.prefix "subClassOf"
    /// <summary>
    ///   <para>rdfs:comment : The subject is a subproperty of a property.^^xsd:string</para>
    ///   <para>rdfs:label : subPropertyOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#subPropertyOf">rdfs:subPropertyOf</a>
    /// </summary>
    let subPropertyOf = _prefixId.prefix "subPropertyOf"
