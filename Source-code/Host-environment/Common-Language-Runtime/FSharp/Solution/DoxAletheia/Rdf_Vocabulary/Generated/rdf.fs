namespace http.www.w3.org._1999._02._22_rdf_syntax_ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdf =
    let _namespace_iri = Namespace_Iri rdf |> NamespaceIRI
    /// <summary>
    ///   <para>rdf:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#">http://www.w3.org/1999/02/22-rdf-syntax-ns#</seealso>
    let _prefix_iri = Prefixed_Name(rdf, "") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Alt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The class of containers of alternatives."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt">http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt</seealso>
    let Alt = Prefixed_Name(rdf, "Alt") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Bag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The class of unordered containers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag">http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag</seealso>
    let Bag = Prefixed_Name(rdf, "Bag") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Class">http://www.w3.org/1999/02/22-rdf-syntax-ns#Class</seealso>
    let Class = Prefixed_Name(rdf, "Class") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Collection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Collection">http://www.w3.org/1999/02/22-rdf-syntax-ns#Collection</seealso>
    let Collection = Prefixed_Name(rdf, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>rdf:CompoundLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A class representing a compound literal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CompoundLiteral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral">http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral</seealso>
    let CompoundLiteral = Prefixed_Name(rdf, "CompoundLiteral") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Datatype</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Datatype">http://www.w3.org/1999/02/22-rdf-syntax-ns#Datatype</seealso>
    let Datatype = Prefixed_Name(rdf, "Datatype") |> PrefixedName
    /// <summary>
    ///   <para>rdf:HTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The datatype of RDF literals storing fragments of HTML content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HTML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML">http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML</seealso>
    let HTML = Prefixed_Name(rdf, "HTML") |> PrefixedName
    /// <summary>
    ///   <para>rdf:JSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The datatype of RDF literals storing JSON content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JSON"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON">http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON</seealso>
    let JSON = Prefixed_Name(rdf, "JSON") |> PrefixedName
    /// <summary>
    ///   <para>rdf:LIst</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#LIst">http://www.w3.org/1999/02/22-rdf-syntax-ns#LIst</seealso>
    let LIst = Prefixed_Name(rdf, "LIst") |> PrefixedName
    /// <summary>
    ///   <para>rdf:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The class of RDF Lists."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"the first element is related to the list by rdf:first, the second by (rdf:rest o rdf:first), the third by (rdf:rest o rdf:rest o rdf:first), and so on; where the list ends, it is related by rdf:rest to rdf:nil"</para>
    ///   <para>"List"</para>
    /// labels<para>"array"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#List">http://www.w3.org/1999/02/22-rdf-syntax-ns#List</seealso>
    let List = Prefixed_Name(rdf, "List") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Literal">http://www.w3.org/1999/02/22-rdf-syntax-ns#Literal</seealso>
    let Literal = Prefixed_Name(rdf, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>rdf:PlainLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PlainLiteral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral">http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral</seealso>
    let PlainLiteral = Prefixed_Name(rdf, "PlainLiteral") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Propert</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Propert">http://www.w3.org/1999/02/22-rdf-syntax-ns#Propert</seealso>
    let Propert = Prefixed_Name(rdf, "Propert") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of RDF properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property">http://www.w3.org/1999/02/22-rdf-syntax-ns#Property</seealso>
    let Property = Prefixed_Name(rdf, "Property") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Propertym</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Propertym">http://www.w3.org/1999/02/22-rdf-syntax-ns#Propertym</seealso>
    let Propertym = Prefixed_Name(rdf, "Propertym") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Resource">http://www.w3.org/1999/02/22-rdf-syntax-ns#Resource</seealso>
    let Resource = Prefixed_Name(rdf, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Schema</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Schema">http://www.w3.org/1999/02/22-rdf-syntax-ns#Schema</seealso>
    let Schema = Prefixed_Name(rdf, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Seq</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The class of ordered containers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Seq"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq">http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq</seealso>
    let Seq = Prefixed_Name(rdf, "Seq") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of RDF statements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement">http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement</seealso>
    let Statement = Prefixed_Name(rdf, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>rdf:XMLLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The datatype of XML literal values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XMLLiteral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral">http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral</seealso>
    let XMLLiteral = Prefixed_Name(rdf, "XMLLiteral") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_1">http://www.w3.org/1999/02/22-rdf-syntax-ns#_1</seealso>
    let _1 = Prefixed_Name(rdf, "_1") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_10</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_10">http://www.w3.org/1999/02/22-rdf-syntax-ns#_10</seealso>
    let _10 = Prefixed_Name(rdf, "_10") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_11</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_11">http://www.w3.org/1999/02/22-rdf-syntax-ns#_11</seealso>
    let _11 = Prefixed_Name(rdf, "_11") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_12</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_12">http://www.w3.org/1999/02/22-rdf-syntax-ns#_12</seealso>
    let _12 = Prefixed_Name(rdf, "_12") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_13</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_13">http://www.w3.org/1999/02/22-rdf-syntax-ns#_13</seealso>
    let _13 = Prefixed_Name(rdf, "_13") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_14</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_14">http://www.w3.org/1999/02/22-rdf-syntax-ns#_14</seealso>
    let _14 = Prefixed_Name(rdf, "_14") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_15</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_15">http://www.w3.org/1999/02/22-rdf-syntax-ns#_15</seealso>
    let _15 = Prefixed_Name(rdf, "_15") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_16</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_16">http://www.w3.org/1999/02/22-rdf-syntax-ns#_16</seealso>
    let _16 = Prefixed_Name(rdf, "_16") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_17</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_17">http://www.w3.org/1999/02/22-rdf-syntax-ns#_17</seealso>
    let _17 = Prefixed_Name(rdf, "_17") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_18</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_18">http://www.w3.org/1999/02/22-rdf-syntax-ns#_18</seealso>
    let _18 = Prefixed_Name(rdf, "_18") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_19</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_19">http://www.w3.org/1999/02/22-rdf-syntax-ns#_19</seealso>
    let _19 = Prefixed_Name(rdf, "_19") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_2">http://www.w3.org/1999/02/22-rdf-syntax-ns#_2</seealso>
    let _2 = Prefixed_Name(rdf, "_2") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_20</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_20">http://www.w3.org/1999/02/22-rdf-syntax-ns#_20</seealso>
    let _20 = Prefixed_Name(rdf, "_20") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_21</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_21">http://www.w3.org/1999/02/22-rdf-syntax-ns#_21</seealso>
    let _21 = Prefixed_Name(rdf, "_21") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_22</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_22">http://www.w3.org/1999/02/22-rdf-syntax-ns#_22</seealso>
    let _22 = Prefixed_Name(rdf, "_22") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_23</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_23">http://www.w3.org/1999/02/22-rdf-syntax-ns#_23</seealso>
    let _23 = Prefixed_Name(rdf, "_23") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_24</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_24">http://www.w3.org/1999/02/22-rdf-syntax-ns#_24</seealso>
    let _24 = Prefixed_Name(rdf, "_24") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_25</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_25">http://www.w3.org/1999/02/22-rdf-syntax-ns#_25</seealso>
    let _25 = Prefixed_Name(rdf, "_25") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_26</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_26">http://www.w3.org/1999/02/22-rdf-syntax-ns#_26</seealso>
    let _26 = Prefixed_Name(rdf, "_26") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_27</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_27">http://www.w3.org/1999/02/22-rdf-syntax-ns#_27</seealso>
    let _27 = Prefixed_Name(rdf, "_27") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_28</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_28">http://www.w3.org/1999/02/22-rdf-syntax-ns#_28</seealso>
    let _28 = Prefixed_Name(rdf, "_28") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_29">http://www.w3.org/1999/02/22-rdf-syntax-ns#_29</seealso>
    let _29 = Prefixed_Name(rdf, "_29") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_3">http://www.w3.org/1999/02/22-rdf-syntax-ns#_3</seealso>
    let _3 = Prefixed_Name(rdf, "_3") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_30</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_30">http://www.w3.org/1999/02/22-rdf-syntax-ns#_30</seealso>
    let _30 = Prefixed_Name(rdf, "_30") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_31</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_31">http://www.w3.org/1999/02/22-rdf-syntax-ns#_31</seealso>
    let _31 = Prefixed_Name(rdf, "_31") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_32</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_32">http://www.w3.org/1999/02/22-rdf-syntax-ns#_32</seealso>
    let _32 = Prefixed_Name(rdf, "_32") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_33</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_33">http://www.w3.org/1999/02/22-rdf-syntax-ns#_33</seealso>
    let _33 = Prefixed_Name(rdf, "_33") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_34</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_34">http://www.w3.org/1999/02/22-rdf-syntax-ns#_34</seealso>
    let _34 = Prefixed_Name(rdf, "_34") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_35</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_35">http://www.w3.org/1999/02/22-rdf-syntax-ns#_35</seealso>
    let _35 = Prefixed_Name(rdf, "_35") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_36</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_36">http://www.w3.org/1999/02/22-rdf-syntax-ns#_36</seealso>
    let _36 = Prefixed_Name(rdf, "_36") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_37</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_37">http://www.w3.org/1999/02/22-rdf-syntax-ns#_37</seealso>
    let _37 = Prefixed_Name(rdf, "_37") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_4">http://www.w3.org/1999/02/22-rdf-syntax-ns#_4</seealso>
    let _4 = Prefixed_Name(rdf, "_4") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_5">http://www.w3.org/1999/02/22-rdf-syntax-ns#_5</seealso>
    let _5 = Prefixed_Name(rdf, "_5") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_6</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_6">http://www.w3.org/1999/02/22-rdf-syntax-ns#_6</seealso>
    let _6 = Prefixed_Name(rdf, "_6") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_7</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_7">http://www.w3.org/1999/02/22-rdf-syntax-ns#_7</seealso>
    let _7 = Prefixed_Name(rdf, "_7") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_8</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_8">http://www.w3.org/1999/02/22-rdf-syntax-ns#_8</seealso>
    let _8 = Prefixed_Name(rdf, "_8") |> PrefixedName
    /// <summary>
    ///   <para>rdf:_9</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#_9">http://www.w3.org/1999/02/22-rdf-syntax-ns#_9</seealso>
    let _9 = Prefixed_Name(rdf, "_9") |> PrefixedName
    /// <summary>
    ///   <para>rdf:about</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#about">http://www.w3.org/1999/02/22-rdf-syntax-ns#about</seealso>
    let about = Prefixed_Name(rdf, "about") |> PrefixedName
    /// <summary>
    ///   <para>rdf:direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The base direction component of a CompoundLiteral."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"direction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction">http://www.w3.org/1999/02/22-rdf-syntax-ns#direction</seealso>
    let direction = Prefixed_Name(rdf, "direction") |> PrefixedName
    /// <summary>
    ///   <para>rdf:domain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#domain">http://www.w3.org/1999/02/22-rdf-syntax-ns#domain</seealso>
    let domain = Prefixed_Name(rdf, "domain") |> PrefixedName
    /// <summary>
    ///   <para>rdf:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates a rdf:List to its first element"</para>
    ///   <para>"The first item in the subject RDF list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"first"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#first">http://www.w3.org/1999/02/22-rdf-syntax-ns#first</seealso>
    let first = Prefixed_Name(rdf, "first") |> PrefixedName
    /// <summary>
    ///   <para>rdf:hasParent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#hasParent">http://www.w3.org/1999/02/22-rdf-syntax-ns#hasParent</seealso>
    let hasParent = Prefixed_Name(rdf, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>rdf:langString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The datatype of language-tagged string values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"langString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Language-Tagged String"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"rdf:langString"</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString">http://www.w3.org/1999/02/22-rdf-syntax-ns#langString</seealso>
    let langString = Prefixed_Name(rdf, "langString") |> PrefixedName
    /// <summary>
    ///   <para>rdf:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The language component of a CompoundLiteral."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#language">http://www.w3.org/1999/02/22-rdf-syntax-ns#language</seealso>
    let language = Prefixed_Name(rdf, "language") |> PrefixedName
    /// <summary>
    ///   <para>rdf:nil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:List</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>as:OrderedItems</para>
    ///   <para>swrl:AtomList</para>
    ///   <para>"The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil">http://www.w3.org/1999/02/22-rdf-syntax-ns#nil</seealso>
    let nil = Prefixed_Name(rdf, "nil") |> PrefixedName
    /// <summary>
    ///   <para>rdf:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>w3id:linkml/RelationalRoleEnum</para>
    ///   <para>"The object of the subject RDF statement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OBJECT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#object">http://www.w3.org/1999/02/22-rdf-syntax-ns#object</seealso>
    let object = Prefixed_Name(rdf, "object") |> PrefixedName
    /// <summary>
    ///   <para>rdf:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/RelationalRoleEnum</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The predicate of the subject RDF statement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PREDICATE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"predicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate">http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate</seealso>
    let predicate = Prefixed_Name(rdf, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>rdf:range</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#range">http://www.w3.org/1999/02/22-rdf-syntax-ns#range</seealso>
    let range = Prefixed_Name(rdf, "range") |> PrefixedName
    /// <summary>
    ///   <para>rdf:resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#resource">http://www.w3.org/1999/02/22-rdf-syntax-ns#resource</seealso>
    let resource = Prefixed_Name(rdf, "resource") |> PrefixedName
    /// <summary>
    ///   <para>rdf:rest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"relates a rdf:List to the part that remains when its first element is removed"</para>
    ///   <para>"The rest of the subject RDF list after the first item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest">http://www.w3.org/1999/02/22-rdf-syntax-ns#rest</seealso>
    let rest = Prefixed_Name(rdf, "rest") |> PrefixedName
    /// <summary>
    ///   <para>rdf:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/RelationalRoleEnum</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the subject RDF statement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SUBJECT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject">http://www.w3.org/1999/02/22-rdf-syntax-ns#subject</seealso>
    let subject = Prefixed_Name(rdf, "subject") |> PrefixedName
    /// <summary>
    ///   <para>rdf:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject is an instance of a class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#type">http://www.w3.org/1999/02/22-rdf-syntax-ns#type</seealso>
    let type_ = Prefixed_Name(rdf, "type") |> PrefixedName
    /// <summary>
    ///   <para>rdf:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Idiomatic property used for structured values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Idiomatic property used for structured values"</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"value"</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#value">http://www.w3.org/1999/02/22-rdf-syntax-ns#value</seealso>
    let value = Prefixed_Name(rdf, "value") |> PrefixedName
