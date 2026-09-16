#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sio =
    let _prefixId = PrefixId.fromNamespaceLabel "http://semanticscience.org/resource/" "sio"

    /// <summary>
    ///   <para>dc11:identifier : SIO_000000^^xsd:string</para>
    ///   <para>rdfs:label : entity</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : Every thing is an entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000000">sio:SIO_000000</a>
    /// </summary>
    let SIO_000000 = _prefixId.prefix "SIO_000000"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000001^^xsd:string</para>
    ///   <para>rdfs:label : is related to</para>
    ///   <para>sio:subset : relations+^^xsd:stringsio:subset : core^^xsd:string</para>
    ///   <para>schema:comment : 'is related to' is the top level relation in SIO^^xsd:string</para>
    ///   <para>dcterms:description : A is related to B iff there is some relation between A and B.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000001">sio:SIO_000001</a>
    /// </summary>
    let SIO_000001 = _prefixId.prefix "SIO_000001"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000004^^xsd:string</para>
    ///   <para>rdfs:label : material entity</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A material entity is a physical entity that is spatially extended, exists as a whole at any point in time and has mass.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000004">sio:SIO_000004</a>
    /// </summary>
    let SIO_000004 = _prefixId.prefix "SIO_000004"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000005^^xsd:string</para>
    ///   <para>rdfs:label : quality</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A quality is an attribute that is intrinsically associated with its bearer (or its parts), but whose presence/absence and observed/measured value may vary.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000005">sio:SIO_000005</a>
    /// </summary>
    let SIO_000005 = _prefixId.prefix "SIO_000005"
    /// <summary>
    ///   <para>sio:subset : core^^xsd:stringsio:subset : process+^^xsd:string</para>
    ///   <para>dcterms:description : A process is an entity that is identifiable only through the unfolding of time, has temporal parts, and unless otherwise specified/predicted, cannot be identified from any instant of time in which it exists.</para>
    ///   <para>dc11:identifier : SIO_000006^^xsd:string</para>
    ///   <para>rdfs:label : process</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000006">sio:SIO_000006</a>
    /// </summary>
    let SIO_000006 = _prefixId.prefix "SIO_000006"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000008^^xsd:string</para>
    ///   <para>rdfs:label : has attribute</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : has attribute is a relation that associates a entity with an attribute where an attribute is an intrinsic characteristic such as a quality, capability, disposition, function, or is an externally derived attribute determined from some descriptor (e.g. a quantity, position, label/identifier) either directly or indirectly through generalization of entities of the same type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000008">sio:SIO_000008</a>
    /// </summary>
    let SIO_000008 = _prefixId.prefix "SIO_000008"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000009^^xsd:string</para>
    ///   <para>rdfs:label : social entity</para>
    ///   <para>dcterms:description : A social entity pertains to the interaction among individuals and groups.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000009">sio:SIO_000009</a>
    /// </summary>
    let SIO_000009 = _prefixId.prefix "SIO_000009"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000010^^xsd:string</para>
    ///   <para>rdfs:label : social structure</para>
    ///   <para>dcterms:description : A social structure is a social entity which consists of relationships between two or more entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000010">sio:SIO_000010</a>
    /// </summary>
    let SIO_000010 = _prefixId.prefix "SIO_000010"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000011^^xsd:string</para>
    ///   <para>rdfs:label : is attribute of</para>
    ///   <para>dcterms:description : is attribute of is a relation that associates an attribute with an entity where an attribute is an intrinsic characteristic such as a quality, capability, disposition, function, or is an externally derived attribute determined from some descriptor (e.g. a quantity, position, label/identifier) either directly or indirectly through generalization of entities of the same type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000011">sio:SIO_000011</a>
    /// </summary>
    let SIO_000011 = _prefixId.prefix "SIO_000011"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000012^^xsd:string</para>
    ///   <para>rdfs:label : organization</para>
    ///   <para>dcterms:description : An organization is a collective with a complex articulation of tasks, roles and responsibilities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000012">sio:SIO_000012</a>
    /// </summary>
    let SIO_000012 = _prefixId.prefix "SIO_000012"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000013^^xsd:string</para>
    ///   <para>rdfs:label : geographic position</para>
    ///   <para>dcterms:description : A geographic position is the coordinate of an entity against some geographic coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000013">sio:SIO_000013</a>
    /// </summary>
    let SIO_000013 = _prefixId.prefix "SIO_000013"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000014^^xsd:string</para>
    ///   <para>rdfs:label : disposition</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>sio:example : solubility (to dissolve when put in fluid); fragility (disposition to break when dropped)</para>
    ///   <para>dcterms:description : A disposition is the tendency of a capability to be exhibited under certain conditions or in response to a certain stimulus (trigger).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000014">sio:SIO_000014</a>
    /// </summary>
    let SIO_000014 = _prefixId.prefix "SIO_000014"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000015^^xsd:string</para>
    ///   <para>rdfs:label : information content entity</para>
    ///   <para>sio:subset : ice+^^xsd:stringsio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : information content entity is an object that requires some background knowledge or procedure to correctly interpret.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000015">sio:SIO_000015</a>
    /// </summary>
    let SIO_000015 = _prefixId.prefix "SIO_000015"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000016^^xsd:string</para>
    ///   <para>rdfs:label : role</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A role is a realizable entity that describes behaviours, rights and obligations of an entity in some particular circumstance.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000016">sio:SIO_000016</a>
    /// </summary>
    let SIO_000016 = _prefixId.prefix "SIO_000016"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000017^^xsd:string</para>
    ///   <para>rdfs:label : function</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A function is a capability that satisfies some agentive objective, or (evolutionary) optimization.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000017">sio:SIO_000017</a>
    /// </summary>
    let SIO_000017 = _prefixId.prefix "SIO_000017"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000019^^xsd:string</para>
    ///   <para>rdfs:label : site</para>
    ///   <para>sio:example : A nostril; the interior of the heart valve; the interior of a bottle.</para>
    ///   <para>dcterms:description : A site is a spatial region bounded (in part or in whole) by material entities and may be occupied by material entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000019">sio:SIO_000019</a>
    /// </summary>
    let SIO_000019 = _prefixId.prefix "SIO_000019"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000020^^xsd:string</para>
    ///   <para>rdfs:label : denotes</para>
    ///   <para>sio:example : the symbol '%' denotes a proportion in relation to a whole.</para>
    ///   <para>dcterms:description : denotes is a relation between an entity and what it is a sign or indication of, or what specifically means.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000020">sio:SIO_000020</a>
    /// </summary>
    let SIO_000020 = _prefixId.prefix "SIO_000020"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000022^^xsd:string</para>
    ///   <para>rdfs:label : material boundary</para>
    ///   <para>sio:example : the external surface of the window; the surface of the p52 protein</para>
    ///   <para>dcterms:description : A material boundary is the boundary of a material entity which exists as a lower dimensional entity at exactly the location where its parts no longer extend into space. Every material entity has a boundary, and a boundary is the boundary of exactly 1 material entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000022">sio:SIO_000022</a>
    /// </summary>
    let SIO_000022 = _prefixId.prefix "SIO_000022"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000026^^xsd:string</para>
    ///   <para>rdfs:label : object quality</para>
    ///   <para>dcterms:description : An object quality is quality of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000026">sio:SIO_000026</a>
    /// </summary>
    let SIO_000026 = _prefixId.prefix "SIO_000026"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000027^^xsd:string</para>
    ///   <para>rdfs:label : process quality</para>
    ///   <para>dcterms:description : A process quality is quality that is associated with a process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000027">sio:SIO_000027</a>
    /// </summary>
    let SIO_000027 = _prefixId.prefix "SIO_000027"
    /// <summary>
    ///   <para>dcterms:description : has part is a transitive, reflexive and antisymmetric relation between a whole and itself or a whole and its part.</para>
    ///   <para>dc11:identifier : SIO_000028^^xsd:string</para>
    ///   <para>sio:example : a collection of cars has as a car as a part;a car has an engine as a part; a car has a piston as a part;</para>
    ///   <para>rdfs:label : has part</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000028">sio:SIO_000028</a>
    /// </summary>
    let SIO_000028 = _prefixId.prefix "SIO_000028"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000029^^xsd:string</para>
    ///   <para>rdfs:label : is time boundary of</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000029">sio:SIO_000029</a>
    /// </summary>
    let SIO_000029 = _prefixId.prefix "SIO_000029"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000030^^xsd:string</para>
    ///   <para>rdfs:label : biopolymer sequence</para>
    ///   <para>dcterms:description : A sequence is a primary structure descriptor in which each of the letters in the string represents a monomeric unit (residue) in which adjacent letters represent the connectivity between the monomeric units.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000030">sio:SIO_000030</a>
    /// </summary>
    let SIO_000030 = _prefixId.prefix "SIO_000030"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000031^^xsd:string</para>
    ///   <para>rdfs:label : start date</para>
    ///   <para>dcterms:description : A start date is a time instant pertaining to the date of the beginning of a process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000031">sio:SIO_000031</a>
    /// </summary>
    let SIO_000031 = _prefixId.prefix "SIO_000031"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000032^^xsd:string</para>
    ///   <para>rdfs:label : end date</para>
    ///   <para>dcterms:description : An end date is a time instant pertaining to date of the end of a process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000032">sio:SIO_000032</a>
    /// </summary>
    let SIO_000032 = _prefixId.prefix "SIO_000032"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000033^^xsd:string</para>
    ///   <para>rdfs:label : process status</para>
    ///   <para>dcterms:description : process status is a process quality that describes the state of a process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000033">sio:SIO_000033</a>
    /// </summary>
    let SIO_000033 = _prefixId.prefix "SIO_000033"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000034^^xsd:string</para>
    ///   <para>rdfs:label : completed</para>
    ///   <para>dcterms:description : completed is that status of a process that successfully unfolds.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000034">sio:SIO_000034</a>
    /// </summary>
    let SIO_000034 = _prefixId.prefix "SIO_000034"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000035^^xsd:string</para>
    ///   <para>rdfs:label : ongoing</para>
    ///   <para>dcterms:description : ongoing is the status of a process that is not yet complete.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000035">sio:SIO_000035</a>
    /// </summary>
    let SIO_000035 = _prefixId.prefix "SIO_000035"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000036^^xsd:string</para>
    ///   <para>rdfs:label : predicted</para>
    ///   <para>dcterms:description : predicted is the quality of an entity that is thought to exist, as evidenced by some rational procedure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000036">sio:SIO_000036</a>
    /// </summary>
    let SIO_000036 = _prefixId.prefix "SIO_000036"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000037^^xsd:string</para>
    ///   <para>rdfs:label : spatial quantity</para>
    ///   <para>sio:hasSynonym : physical dimensional quantity</para>
    ///   <para>dcterms:description : A spatial quantity is a quantity obtained from measuring the spatial extent of an entity </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000037">sio:SIO_000037</a>
    /// </summary>
    let SIO_000037 = _prefixId.prefix "SIO_000037"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000038^^xsd:string</para>
    ///   <para>rdfs:label : 1D extent quantity</para>
    ///   <para>dcterms:description : A quantity that extends in single dimension.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000038">sio:SIO_000038</a>
    /// </summary>
    let SIO_000038 = _prefixId.prefix "SIO_000038"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000039^^xsd:string</para>
    ///   <para>rdfs:label : depth</para>
    ///   <para>dcterms:description : depth is the dimensional extent into a plane of a 3D projection of the object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000039">sio:SIO_000039</a>
    /// </summary>
    let SIO_000039 = _prefixId.prefix "SIO_000039"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000040^^xsd:string</para>
    ///   <para>rdfs:label : height</para>
    ///   <para>dcterms:description : height is the one dimensional extent along the vertical projection of a 3D object from a base plane of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000040">sio:SIO_000040</a>
    /// </summary>
    let SIO_000040 = _prefixId.prefix "SIO_000040"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000041^^xsd:string</para>
    ///   <para>rdfs:label : length</para>
    ///   <para>dcterms:description : length is the longer dimensional extent along a 2D projection of the object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000041">sio:SIO_000041</a>
    /// </summary>
    let SIO_000041 = _prefixId.prefix "SIO_000041"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000042^^xsd:string</para>
    ///   <para>rdfs:label : width</para>
    ///   <para>dcterms:description : width is the shorter dimensional extent perpendicular to a 2D projection of the object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000042">sio:SIO_000042</a>
    /// </summary>
    let SIO_000042 = _prefixId.prefix "SIO_000042"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000043^^xsd:string</para>
    ///   <para>rdfs:label : thickness</para>
    ///   <para>dcterms:description : thickness is the shortest dimensional extent of a 3D projection of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000043">sio:SIO_000043</a>
    /// </summary>
    let SIO_000043 = _prefixId.prefix "SIO_000043"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000044^^xsd:string</para>
    ///   <para>rdfs:label : 2D extent quantity</para>
    ///   <para>dcterms:description : A quantity that extends in two dimensions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000044">sio:SIO_000044</a>
    /// </summary>
    let SIO_000044 = _prefixId.prefix "SIO_000044"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000045^^xsd:string</para>
    ///   <para>rdfs:label : area</para>
    ///   <para>dcterms:description : area is a quantity that pertains to the extent of a two-dimensional surface or shape, or planar lamina, in the plane.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000045">sio:SIO_000045</a>
    /// </summary>
    let SIO_000045 = _prefixId.prefix "SIO_000045"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000046^^xsd:string</para>
    ///   <para>rdfs:label : length of perimeter</para>
    ///   <para>dcterms:description : A perimeter is a length of the outline that surrounds a two-dimensional shape. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000046">sio:SIO_000046</a>
    /// </summary>
    let SIO_000046 = _prefixId.prefix "SIO_000046"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000047^^xsd:string</para>
    ///   <para>rdfs:label : circumference</para>
    ///   <para>dcterms:description : circumference is the length of the outline of a circle or ellipse. it is defined as c = 2*pi*r, where r is the radius.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000047">sio:SIO_000047</a>
    /// </summary>
    let SIO_000047 = _prefixId.prefix "SIO_000047"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000048^^xsd:string</para>
    ///   <para>rdfs:label : 3D extent quantity</para>
    ///   <para>dcterms:description : A quantity that extends in three dimensions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000048">sio:SIO_000048</a>
    /// </summary>
    let SIO_000048 = _prefixId.prefix "SIO_000048"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000049^^xsd:string</para>
    ///   <para>rdfs:label : volume</para>
    ///   <para>dcterms:description : volume is the quantity of three-dimensional space enclosed by some closed boundary.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000049">sio:SIO_000049</a>
    /// </summary>
    let SIO_000049 = _prefixId.prefix "SIO_000049"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000051^^xsd:string</para>
    ///   <para>rdfs:label : compositional quality</para>
    ///   <para>dcterms:description : composition quality is a quality that describes its composition or anatomy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000051">sio:SIO_000051</a>
    /// </summary>
    let SIO_000051 = _prefixId.prefix "SIO_000051"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000052^^xsd:string</para>
    ///   <para>rdfs:label : quantity</para>
    ///   <para>dcterms:description : A quantity is an informational entity that gives the magnitude of a property.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000052">sio:SIO_000052</a>
    /// </summary>
    let SIO_000052 = _prefixId.prefix "SIO_000052"
    /// <summary>
    ///   <para>rdfs:label : has proper part</para>
    ///   <para>sio:example : a car has an engine as a proper part; a car has a piston as a proper part;</para>
    ///   <para>dcterms:description : has proper part is an antisymmetric, irreflexive (normally transitive) relation between a whole and a distinct part.</para>
    ///   <para>dc11:identifier : SIO_000053^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000053">sio:SIO_000053</a>
    /// </summary>
    let SIO_000053 = _prefixId.prefix "SIO_000053"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000054^^xsd:string</para>
    ///   <para>rdfs:label : has boundary</para>
    ///   <para>sio:example : the surface of an apple is a 2D boundary of the apple.</para>
    ///   <para>dcterms:description : has boundary is a mereological relation between a whole and boundary located at its periphery.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000054">sio:SIO_000054</a>
    /// </summary>
    let SIO_000054 = _prefixId.prefix "SIO_000054"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000055^^xsd:string</para>
    ///   <para>rdfs:label : shape</para>
    ///   <para>dcterms:description : shape is the quality of a bearer that relates to its spatial extent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000055">sio:SIO_000055</a>
    /// </summary>
    let SIO_000055 = _prefixId.prefix "SIO_000055"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000056^^xsd:string</para>
    ///   <para>rdfs:label : position</para>
    ///   <para>dcterms:description : A measurement of a spatial location relative to a frame of reference or other objects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000056">sio:SIO_000056</a>
    /// </summary>
    let SIO_000056 = _prefixId.prefix "SIO_000056"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000057^^xsd:string</para>
    ///   <para>rdfs:label : orientation</para>
    ///   <para>dcterms:description : orientation is an angle between the bearer and an axis, or the angle between the bearer and another object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000057">sio:SIO_000057</a>
    /// </summary>
    let SIO_000057 = _prefixId.prefix "SIO_000057"
    /// <summary>
    ///   <para>rdfs:label : has member</para>
    ///   <para>dc11:identifier : SIO_000059^^xsd:string</para>
    ///   <para>sio:example : a collection of cars has as a car as a member</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : has member is a mereological relation between a collection and an item.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000059">sio:SIO_000059</a>
    /// </summary>
    let SIO_000059 = _prefixId.prefix "SIO_000059"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000060^^xsd:string</para>
    ///   <para>rdfs:label : is denoted by</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000060">sio:SIO_000060</a>
    /// </summary>
    let SIO_000060 = _prefixId.prefix "SIO_000060"
    /// <summary>
    ///   <para>dcterms:description : A is located in B iff the spatial region occupied by A is part of the spatial region occupied by B. [T][R]</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dc11:identifier : SIO_000061^^xsd:string</para>
    ///   <para>sio:equivalentTo : OBO_REL:located_in^^xsd:string</para>
    ///   <para>sio:example : A parasite in the interior of a person's intestine is located in their intestinal lumen.</para>
    ///   <para>rdfs:label : is located in</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000061">sio:SIO_000061</a>
    /// </summary>
    let SIO_000061 = _prefixId.prefix "SIO_000061"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000062^^xsd:string</para>
    ///   <para>rdfs:label : is participant in</para>
    ///   <para>sio:example : a car is a participant in a car race; glucose is a participant in glycolysis</para>
    ///   <para>dcterms:description : is participant in is a relation that describes the participation of the subject in the (processual) object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000062">sio:SIO_000062</a>
    /// </summary>
    let SIO_000062 = _prefixId.prefix "SIO_000062"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000063^^xsd:string</para>
    ///   <para>rdfs:label : is agent in</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>sio:example : hexokinase is an agent in the conversion of glucose to glucose-6-phosphate</para>
    ///   <para>dcterms:description : is agent in is a relation between an entity and a process, where the entity is present throughout the process, no permanent material change occurs, and is a causal participant in the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000063">sio:SIO_000063</a>
    /// </summary>
    let SIO_000063 = _prefixId.prefix "SIO_000063"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000064^^xsd:string</para>
    ///   <para>rdfs:label : is provider of</para>
    ///   <para>dcterms:description : is provider of is a relation between a source and the entity it makes available.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000064">sio:SIO_000064</a>
    /// </summary>
    let SIO_000064 = _prefixId.prefix "SIO_000064"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000066^^xsd:string</para>
    ///   <para>rdfs:label : has provider</para>
    ///   <para>sio:equivalentTo : dc:source^^xsd:string</para>
    ///   <para>dcterms:description : is provided by is a relation between an entity and the entity that provides it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000066">sio:SIO_000066</a>
    /// </summary>
    let SIO_000066 = _prefixId.prefix "SIO_000066"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000067^^xsd:string</para>
    ///   <para>rdfs:label : namespace</para>
    ///   <para>dcterms:description : A namespace is an informational entity that defines a logical container for a set of symbols or identifiers.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000067">sio:SIO_000067</a>
    /// </summary>
    let SIO_000067 = _prefixId.prefix "SIO_000067"
    /// <summary>
    ///   <para>sio:equivalentTo : OBO_REL:part_of^^xsd:string</para>
    ///   <para>rdfs:label : is part of</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : is part of is a transitive, reflexive and anti-symmetric mereological relation between a whole and itself or a part and its whole.</para>
    ///   <para>dc11:identifier : SIO_000068^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000068">sio:SIO_000068</a>
    /// </summary>
    let SIO_000068 = _prefixId.prefix "SIO_000068"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000069^^xsd:string</para>
    ///   <para>rdfs:label : data item</para>
    ///   <para>dcterms:description : A data item consists of information that has been collected/generated towards some purpose.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000069">sio:SIO_000069</a>
    /// </summary>
    let SIO_000069 = _prefixId.prefix "SIO_000069"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000070^^xsd:string</para>
    ///   <para>rdfs:label : measurement value</para>
    ///   <para>dcterms:description : A measurement value is a quantitative description that reflects the magnitude of some attribute.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000070">sio:SIO_000070</a>
    /// </summary>
    let SIO_000070 = _prefixId.prefix "SIO_000070"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000071^^xsd:string</para>
    ///   <para>rdfs:label : coordinate</para>
    ///   <para>dcterms:description : A coordinate is a measurement of position in n-dimensional space.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000071">sio:SIO_000071</a>
    /// </summary>
    let SIO_000071 = _prefixId.prefix "SIO_000071"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000072^^xsd:string</para>
    ///   <para>rdfs:label : cartesian coordinate</para>
    ///   <para>dcterms:description : A Cartesian coordinate is the signed distance of a point to some referent line.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000072">sio:SIO_000072</a>
    /// </summary>
    let SIO_000072 = _prefixId.prefix "SIO_000072"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000073^^xsd:string</para>
    ///   <para>rdfs:label : polar coordinate</para>
    ///   <para>dcterms:description : A polar coordinate is a position characterized by a distance from a fixed point and an angle from a fixed direction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000073">sio:SIO_000073</a>
    /// </summary>
    let SIO_000073 = _prefixId.prefix "SIO_000073"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000074^^xsd:string</para>
    ///   <para>rdfs:label : unit of measurement</para>
    ///   <para>dcterms:description : A unit of measurement is a definite magnitude of a physical quantity, defined and adopted by convention and/or by law, that is used as a standard for measurement of the same physical quantity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000074">sio:SIO_000074</a>
    /// </summary>
    let SIO_000074 = _prefixId.prefix "SIO_000074"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000075^^xsd:string</para>
    ///   <para>rdfs:label : mathematical entity</para>
    ///   <para>sio:subset : math+^^xsd:string</para>
    ///   <para>dcterms:description : A mathematical entity is an information content entity that are components of a mathematical system or can be defined in mathematical terms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000075">sio:SIO_000075</a>
    /// </summary>
    let SIO_000075 = _prefixId.prefix "SIO_000075"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000076^^xsd:string</para>
    ///   <para>rdfs:label : plan</para>
    ///   <para>dcterms:description : A plan is a set of intended actions, through which one expects to achieve a goal.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000076">sio:SIO_000076</a>
    /// </summary>
    let SIO_000076 = _prefixId.prefix "SIO_000076"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000077^^xsd:string</para>
    ///   <para>rdfs:label : generic name</para>
    ///   <para>dcterms:description : A generic name is the preferred name provided by manufacturer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000077">sio:SIO_000077</a>
    /// </summary>
    let SIO_000077 = _prefixId.prefix "SIO_000077"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000078^^xsd:string</para>
    ///   <para>rdfs:label : language entity</para>
    ///   <para>sio:subset : nlp+^^xsd:string</para>
    ///   <para>dcterms:description : A language entity implements some language specification for the visual interpretation and is part of some document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000078">sio:SIO_000078</a>
    /// </summary>
    let SIO_000078 = _prefixId.prefix "SIO_000078"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000079^^xsd:string</para>
    ///   <para>rdfs:label : visual language entity</para>
    ///   <para>dcterms:description : A visual language entity is a language entity that is manifested within the spectrum of light and can be pereceived and processed by a visual system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000079">sio:SIO_000079</a>
    /// </summary>
    let SIO_000079 = _prefixId.prefix "SIO_000079"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000080^^xsd:string</para>
    ///   <para>rdfs:label : figure</para>
    ///   <para>sio:hasSynonym : diagram</para>
    ///   <para>dcterms:description : A figure is a graphical entity which consists of a visual (n-dimentional) arrangement of information entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000080">sio:SIO_000080</a>
    /// </summary>
    let SIO_000080 = _prefixId.prefix "SIO_000080"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000081^^xsd:string</para>
    ///   <para>rdfs:label : image</para>
    ///   <para>sio:hasSynonym : depiction</para>
    ///   <para>dcterms:description : An image is an affine projection of a visual entity to a two dimensional surface.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000081">sio:SIO_000081</a>
    /// </summary>
    let SIO_000081 = _prefixId.prefix "SIO_000081"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000082^^xsd:string</para>
    ///   <para>rdfs:label : photograph</para>
    ///   <para>sio:hasSynonym : photo</para>
    ///   <para>dcterms:description : A photograph is an image created by light falling on a light-sensitive surface.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000082">sio:SIO_000082</a>
    /// </summary>
    let SIO_000082 = _prefixId.prefix "SIO_000082"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000083^^xsd:string</para>
    ///   <para>rdfs:label : statistical graph</para>
    ///   <para>sio:hasSynonym : chart^^xsd:string</para>
    ///   <para>dcterms:description : A statistical graph is a figure that displays the relationship among numeric data and/or mathematical functions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000083">sio:SIO_000083</a>
    /// </summary>
    let SIO_000083 = _prefixId.prefix "SIO_000083"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000085^^xsd:string</para>
    ///   <para>rdfs:label : question</para>
    ///   <para>dcterms:description : A question is a linguistic expression used to make a request for information.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000085">sio:SIO_000085</a>
    /// </summary>
    let SIO_000085 = _prefixId.prefix "SIO_000085"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000087^^xsd:string</para>
    ///   <para>rdfs:label : publication</para>
    ///   <para>dcterms:description : A publication is a document that has been made available by a publisher.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000087">sio:SIO_000087</a>
    /// </summary>
    let SIO_000087 = _prefixId.prefix "SIO_000087"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000088^^xsd:string</para>
    ///   <para>rdfs:label : record</para>
    ///   <para>dcterms:description : A record is a document containing a collection of statements about some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000088">sio:SIO_000088</a>
    /// </summary>
    let SIO_000088 = _prefixId.prefix "SIO_000088"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000089^^xsd:string</para>
    ///   <para>rdfs:label : data set</para>
    ///   <para>dcterms:description : A dataset is a data item that is a collection of data items.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000089">sio:SIO_000089</a>
    /// </summary>
    let SIO_000089 = _prefixId.prefix "SIO_000089"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000090^^xsd:string</para>
    ///   <para>rdfs:label : specification</para>
    ///   <para>dcterms:description : A specification is a description of the essential technical attributes/requirements for an object or procedure, and may be used to determine that the object / procedure meets its requirements/attributes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000090">sio:SIO_000090</a>
    /// </summary>
    let SIO_000090 = _prefixId.prefix "SIO_000090"
    /// <summary>
    ///   <para>sio:hasSynonym : effective specification^^xsd:string</para>
    ///   <para>rdfs:label : action specification</para>
    ///   <para>dc11:identifier : SIO_000091^^xsd:string</para>
    ///   <para>dcterms:description : An action specification is a specification composed of a sequence of instructions to achieve some objective.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000091">sio:SIO_000091</a>
    /// </summary>
    let SIO_000091 = _prefixId.prefix "SIO_000091"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000092^^xsd:string</para>
    ///   <para>rdfs:label : biopolymer</para>
    ///   <para>dcterms:description : A biopolymer is an organic polymer using biological components.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000092">sio:SIO_000092</a>
    /// </summary>
    let SIO_000092 = _prefixId.prefix "SIO_000092"
    /// <summary>
    ///   <para>dcterms:description : is proper part of is an asymmetric, irreflexive (normally transitive) relation between a part and its distinct whole.</para>
    ///   <para>dc11:identifier : SIO_000093^^xsd:string</para>
    ///   <para>rdfs:label : is proper part of</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>sio:equivalentTo : OBO_REL:proper_part_of^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000093">sio:SIO_000093</a>
    /// </summary>
    let SIO_000093 = _prefixId.prefix "SIO_000093"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000094^^xsd:string</para>
    ///   <para>rdfs:label : algorithm</para>
    ///   <para>dcterms:description : An algorithm is an effective method expressed as a finite list of well-defined instructions for calculating a function.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000094">sio:SIO_000094</a>
    /// </summary>
    let SIO_000094 = _prefixId.prefix "SIO_000094"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000095^^xsd:string</para>
    ///   <para>rdfs:label : is member of</para>
    ///   <para>dcterms:description : is member of is a mereological relation between a item and a collection.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000095">sio:SIO_000095</a>
    /// </summary>
    let SIO_000095 = _prefixId.prefix "SIO_000095"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000096^^xsd:string</para>
    ///   <para>rdfs:label : is boundary of</para>
    ///   <para>dcterms:description : is boundary of is a mereological relation between a boundary located at the periphery of a whole.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000096">sio:SIO_000096</a>
    /// </summary>
    let SIO_000096 = _prefixId.prefix "SIO_000096"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000097^^xsd:string</para>
    ///   <para>rdfs:label : software entity</para>
    ///   <para>dcterms:description : A software entity is a computational entity that can be interpreted by or directly executed by a processing unit.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000097">sio:SIO_000097</a>
    /// </summary>
    let SIO_000097 = _prefixId.prefix "SIO_000097"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000098^^xsd:string</para>
    ///   <para>rdfs:label : software method</para>
    ///   <para>dcterms:description : A software method (also called subroutine, subprogram, procedure, method, function, or routine) is software designed to execute a specific task.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000098">sio:SIO_000098</a>
    /// </summary>
    let SIO_000098 = _prefixId.prefix "SIO_000098"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000099^^xsd:string</para>
    ///   <para>rdfs:label : software module</para>
    ///   <para>dcterms:description : A software module is software composed of a collection of software methods.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000099">sio:SIO_000099</a>
    /// </summary>
    let SIO_000099 = _prefixId.prefix "SIO_000099"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000100^^xsd:string</para>
    ///   <para>rdfs:label : software library</para>
    ///   <para>dcterms:description : A software library is software composed of a collection of software modules and/or software methods in a form that can be statically or dynamically linked to some software application.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000100">sio:SIO_000100</a>
    /// </summary>
    let SIO_000100 = _prefixId.prefix "SIO_000100"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000101^^xsd:string</para>
    ///   <para>rdfs:label : software application</para>
    ///   <para>dcterms:description : A software application is software that can be directly executed by some processing unit.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000101">sio:SIO_000101</a>
    /// </summary>
    let SIO_000101 = _prefixId.prefix "SIO_000101"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000102^^xsd:string</para>
    ///   <para>rdfs:label : software interpreter</para>
    ///   <para>dcterms:description : A software interpreter is a software application that executes some specified input software.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000102">sio:SIO_000102</a>
    /// </summary>
    let SIO_000102 = _prefixId.prefix "SIO_000102"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000103^^xsd:string</para>
    ///   <para>rdfs:label : software script</para>
    ///   <para>dcterms:description : A software script is software whose instructions can be executed using a software interpreter.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000103">sio:SIO_000103</a>
    /// </summary>
    let SIO_000103 = _prefixId.prefix "SIO_000103"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000104^^xsd:string</para>
    ///   <para>rdfs:label : language</para>
    ///   <para>dcterms:description : Language is a language entity which is the result of encoding and decoding information through systematic creation and usage of systems of symbols, each pairing a specific sign with an intended meaning, established through social conventions</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000104">sio:SIO_000104</a>
    /// </summary>
    let SIO_000104 = _prefixId.prefix "SIO_000104"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000105^^xsd:string</para>
    ///   <para>rdfs:label : symbol</para>
    ///   <para>dcterms:description : A symbol is a proposition about what an entity represents.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000105">sio:SIO_000105</a>
    /// </summary>
    let SIO_000105 = _prefixId.prefix "SIO_000105"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000106^^xsd:string</para>
    ///   <para>rdfs:label : book</para>
    ///   <para>dcterms:description : A book is a publication composed of a large number of entries.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000106">sio:SIO_000106</a>
    /// </summary>
    let SIO_000106 = _prefixId.prefix "SIO_000106"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000107^^xsd:string</para>
    ///   <para>rdfs:label : chapter</para>
    ///   <para>dcterms:description : A chapter is a document section of a book or thesis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000107">sio:SIO_000107</a>
    /// </summary>
    let SIO_000107 = _prefixId.prefix "SIO_000107"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000108^^xsd:string</para>
    ///   <para>rdfs:label : character</para>
    ///   <para>dcterms:description : A character is a language symbol used to construct words.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000108">sio:SIO_000108</a>
    /// </summary>
    let SIO_000108 = _prefixId.prefix "SIO_000108"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000109^^xsd:string</para>
    ///   <para>rdfs:label : novel</para>
    ///   <para>dcterms:description : A novel is a fictitious prose narrative of book length, typically representing character and action with some degree of realism.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000109">sio:SIO_000109</a>
    /// </summary>
    let SIO_000109 = _prefixId.prefix "SIO_000109"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000110^^xsd:string</para>
    ///   <para>rdfs:label : paragraph</para>
    ///   <para>dcterms:description : A paragraph is a self-contained unit of written discourse consisting of one or more sentences.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000110">sio:SIO_000110</a>
    /// </summary>
    let SIO_000110 = _prefixId.prefix "SIO_000110"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000111^^xsd:string</para>
    ///   <para>rdfs:label : document section</para>
    ///   <para>dcterms:description : A document section is a component of a document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000111">sio:SIO_000111</a>
    /// </summary>
    let SIO_000111 = _prefixId.prefix "SIO_000111"
    /// <summary>
    ///   <para>rdfs:label : capability</para>
    ///   <para>sio:subset : capability+^^xsd:stringsio:subset : core^^xsd:string</para>
    ///   <para>dc11:identifier : SIO_000112^^xsd:string</para>
    ///   <para>dcterms:description : A capability is a realizable entity whose basis lies in one or more parts or qualities and reflects possility of an entity to act in a specified way under certain conditions or in response to a certain stimulus (trigger).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000112">sio:SIO_000112</a>
    /// </summary>
    let SIO_000112 = _prefixId.prefix "SIO_000112"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000113^^xsd:string</para>
    ///   <para>rdfs:label : sentence</para>
    ///   <para>dcterms:description : A sentence is a grammatical unit consisting of one or more words that bear minimal syntactic relation to the words that precede or follow it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000113">sio:SIO_000113</a>
    /// </summary>
    let SIO_000113 = _prefixId.prefix "SIO_000113"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000114^^xsd:string</para>
    ///   <para>rdfs:label : word</para>
    ///   <para>dcterms:description : A word is the smallest free form (an item that may be expressed in isolation with semantic or pragmatic content) in a language.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000114">sio:SIO_000114</a>
    /// </summary>
    let SIO_000114 = _prefixId.prefix "SIO_000114"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000115^^xsd:string</para>
    ///   <para>rdfs:label : identifier</para>
    ///   <para>dcterms:description : An identifier is a label that specifically refers to (identifies) an entity (instance/type).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000115">sio:SIO_000115</a>
    /// </summary>
    let SIO_000115 = _prefixId.prefix "SIO_000115"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000116^^xsd:string</para>
    ///   <para>rdfs:label : name</para>
    ///   <para>dcterms:description : A name is a label used to identify an entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000116">sio:SIO_000116</a>
    /// </summary>
    let SIO_000116 = _prefixId.prefix "SIO_000116"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000117^^xsd:string</para>
    ///   <para>rdfs:label : preferred name</para>
    ///   <para>dcterms:description : A preferred name is the name that is generally used by some organization. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000117">sio:SIO_000117</a>
    /// </summary>
    let SIO_000117 = _prefixId.prefix "SIO_000117"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000118^^xsd:string</para>
    ///   <para>rdfs:label : common name</para>
    ///   <para>dcterms:description : A common name is a name that is commonly used.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000118">sio:SIO_000118</a>
    /// </summary>
    let SIO_000118 = _prefixId.prefix "SIO_000118"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000119^^xsd:string</para>
    ///   <para>rdfs:label : brand name</para>
    ///   <para>dcterms:description : A brand name is a trademarked and marketed name of a product.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000119">sio:SIO_000119</a>
    /// </summary>
    let SIO_000119 = _prefixId.prefix "SIO_000119"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000120^^xsd:string</para>
    ///   <para>rdfs:label : scientific name</para>
    ///   <para>dcterms:description : A scientific name is a name given through scientific nomenclature.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000120">sio:SIO_000120</a>
    /// </summary>
    let SIO_000120 = _prefixId.prefix "SIO_000120"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000121^^xsd:string</para>
    ///   <para>rdfs:label : magazine</para>
    ///   <para>sio:equivalentTo : http://purl.org/ontology/bibo/Magazine^^xsd:string</para>
    ///   <para>dcterms:description : A magazine is a periodical that typically contains essays, stories, poems, etc., by many writers, and often photographs and drawings, frequently specializing in a particular subject or area, as hobbies, news, or sports.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000121">sio:SIO_000121</a>
    /// </summary>
    let SIO_000121 = _prefixId.prefix "SIO_000121"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000122^^xsd:string</para>
    ///   <para>rdfs:label : synonym</para>
    ///   <para>dcterms:description : A synonym is a word with the same or very similar meanings.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000122">sio:SIO_000122</a>
    /// </summary>
    let SIO_000122 = _prefixId.prefix "SIO_000122"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000123^^xsd:string</para>
    ///   <para>rdfs:label : antonym</para>
    ///   <para>dcterms:description : An antonym is a word with opposite or nearly opposite meaning.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000123">sio:SIO_000123</a>
    /// </summary>
    let SIO_000123 = _prefixId.prefix "SIO_000123"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000124^^xsd:string</para>
    ///   <para>rdfs:label : hypernym</para>
    ///   <para>dcterms:description : A hypernym is a term with a broader meaning.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000124">sio:SIO_000124</a>
    /// </summary>
    let SIO_000124 = _prefixId.prefix "SIO_000124"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000125^^xsd:string</para>
    ///   <para>rdfs:label : hyponym</para>
    ///   <para>dcterms:description : A hyponym is a term with a narrower meaning.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000125">sio:SIO_000125</a>
    /// </summary>
    let SIO_000125 = _prefixId.prefix "SIO_000125"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000126^^xsd:string</para>
    ///   <para>rdfs:label : homonym</para>
    ///   <para>dcterms:description : A homonym is a word that sounds the same but has different meaning.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000126">sio:SIO_000126</a>
    /// </summary>
    let SIO_000126 = _prefixId.prefix "SIO_000126"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000127^^xsd:string</para>
    ///   <para>rdfs:label : workflow</para>
    ///   <para>dcterms:description : A workflow is an algorithm that is is a depiction of a sequence of operations to achieve one or more objectives.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000127">sio:SIO_000127</a>
    /// </summary>
    let SIO_000127 = _prefixId.prefix "SIO_000127"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000128^^xsd:string</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>rdfs:label : is contained in</para>
    ///   <para>sio:equivalentTo : OBO_REL:contained_in^^xsd:string</para>
    ///   <para>dcterms:description : A is contained in B iff the spatial region occupied by A is part of the spatial region occupied by B and A is not part of B. [T]</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000128">sio:SIO_000128</a>
    /// </summary>
    let SIO_000128 = _prefixId.prefix "SIO_000128"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000129^^xsd:string</para>
    ///   <para>rdfs:label : ontology document</para>
    ///   <para>dcterms:description : An ontology document is a document that contains an ontology.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000129">sio:SIO_000129</a>
    /// </summary>
    let SIO_000129 = _prefixId.prefix "SIO_000129"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000130^^xsd:string</para>
    ///   <para>rdfs:label : pattern</para>
    ///   <para>dcterms:description : A pattern is a generalized representation of some repeatable concrete or informational item.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000130">sio:SIO_000130</a>
    /// </summary>
    let SIO_000130 = _prefixId.prefix "SIO_000130"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000131^^xsd:string</para>
    ///   <para>rdfs:label : sequence motif</para>
    ///   <para>dcterms:description : A sequence motif is a pattern of nucleotides in a DNA sequence or amino acids in a protein.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000131">sio:SIO_000131</a>
    /// </summary>
    let SIO_000131 = _prefixId.prefix "SIO_000131"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000132^^xsd:string</para>
    ///   <para>rdfs:label : has participant</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>sio:equivalentTo : OBO_REL:has_participant^^xsd:string</para>
    ///   <para>dcterms:description : has participant is a relation that describes the participation of the object in the (processual) subject.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000132">sio:SIO_000132</a>
    /// </summary>
    let SIO_000132 = _prefixId.prefix "SIO_000132"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000133^^xsd:string</para>
    ///   <para>rdfs:label : descriptor</para>
    ///   <para>dcterms:description : A descriptor (index term, subject term, subject heading) is a term that captures the essence of the topic of a document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000133">sio:SIO_000133</a>
    /// </summary>
    let SIO_000133 = _prefixId.prefix "SIO_000133"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000135^^xsd:string</para>
    ///   <para>rdfs:label : definition</para>
    ///   <para>dcterms:description : A definition is a description that succintly characterizes an entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000135">sio:SIO_000135</a>
    /// </summary>
    let SIO_000135 = _prefixId.prefix "SIO_000135"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000136^^xsd:string</para>
    ///   <para>rdfs:label : description</para>
    ///   <para>dcterms:description : A description is language entity in which elements of a language (formal or natural) are used to characterize an entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000136">sio:SIO_000136</a>
    /// </summary>
    let SIO_000136 = _prefixId.prefix "SIO_000136"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000137^^xsd:string</para>
    ///   <para>rdfs:label : category</para>
    ///   <para>dcterms:description : A category is a class of entities having particular shared characteristics.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000137">sio:SIO_000137</a>
    /// </summary>
    let SIO_000137 = _prefixId.prefix "SIO_000137"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000138^^xsd:string</para>
    ///   <para>rdfs:label : class</para>
    ///   <para>dcterms:description : A class is a collection of sets which can be unambiguously defined by a property that all its members share.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000138">sio:SIO_000138</a>
    /// </summary>
    let SIO_000138 = _prefixId.prefix "SIO_000138"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000139^^xsd:string</para>
    ///   <para>rdfs:label : has agent</para>
    ///   <para>sio:subset : sadisio:subset : core^^xsd:string</para>
    ///   <para>sio:equivalentTo : OBO_REL:has_agent^^xsd:string</para>
    ///   <para>dcterms:description : has agent is a relation between a process and an entity, where the entity is present throughout the process and is a causal participant in the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000139">sio:SIO_000139</a>
    /// </summary>
    let SIO_000139 = _prefixId.prefix "SIO_000139"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000140^^xsd:string</para>
    ///   <para>rdfs:label : web service</para>
    ///   <para>dcterms:description : A web service is a software application that can be accessed over a network, such as the Internet, and executed on a remote system hosting the requested services.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000140">sio:SIO_000140</a>
    /// </summary>
    let SIO_000140 = _prefixId.prefix "SIO_000140"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000141^^xsd:string</para>
    ///   <para>rdfs:label : criterion</para>
    ///   <para>dcterms:description : A criterion is a specification to describe properties used for evaluation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000141">sio:SIO_000141</a>
    /// </summary>
    let SIO_000141 = _prefixId.prefix "SIO_000141"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000142^^xsd:string</para>
    ///   <para>rdfs:label : inclusion criterion</para>
    ///   <para>dcterms:description : An inclusion criterion is a criterion that must be present to satisfy some objective.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000142">sio:SIO_000142</a>
    /// </summary>
    let SIO_000142 = _prefixId.prefix "SIO_000142"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000143^^xsd:string</para>
    ///   <para>rdfs:label : exclusion criterion</para>
    ///   <para>dcterms:description : An exclusion criterion is a criterion that must be absent to satistify the objective.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000143">sio:SIO_000143</a>
    /// </summary>
    let SIO_000143 = _prefixId.prefix "SIO_000143"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000144^^xsd:string</para>
    ///   <para>rdfs:label : parameter</para>
    ///   <para>dcterms:description : A parameter is variable whose value changes the characteristics of a system or a function.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000144">sio:SIO_000144</a>
    /// </summary>
    let SIO_000144 = _prefixId.prefix "SIO_000144"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000145^^xsd:string</para>
    ///   <para>rdfs:label : is location of</para>
    ///   <para>sio:subset : nlp+^^xsd:string</para>
    ///   <para>dcterms:description : A is location of B iff the spatial region occupied by A has the spatial region occupied by B as a part. [T][R]</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000145">sio:SIO_000145</a>
    /// </summary>
    let SIO_000145 = _prefixId.prefix "SIO_000145"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000146^^xsd:string</para>
    ///   <para>rdfs:label : monomer</para>
    ///   <para>dcterms:description : A monomer is a submolecule that is proper part of some polymer, and is a building block for such polymer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000146">sio:SIO_000146</a>
    /// </summary>
    let SIO_000146 = _prefixId.prefix "SIO_000146"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000147^^xsd:string</para>
    ///   <para>rdfs:label : keyword</para>
    ///   <para>dcterms:description : A keyword is a descriptor in which the association of the word with the entity facilitates information retrieval.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000147">sio:SIO_000147</a>
    /// </summary>
    let SIO_000147 = _prefixId.prefix "SIO_000147"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000148^^xsd:string</para>
    ///   <para>rdfs:label : document</para>
    ///   <para>dcterms:description : A document is a bounded physical or digital representation of a body of information designed with the capacity (and usually intent) to communicate.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000148">sio:SIO_000148</a>
    /// </summary>
    let SIO_000148 = _prefixId.prefix "SIO_000148"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000150^^xsd:string</para>
    ///   <para>rdfs:label : list</para>
    ///   <para>dcterms:description : A list is any enumeration of a set of items.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000150">sio:SIO_000150</a>
    /// </summary>
    let SIO_000150 = _prefixId.prefix "SIO_000150"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000151^^xsd:string</para>
    ///   <para>rdfs:label : manuscript</para>
    ///   <para>dcterms:description : A manuscript is a document prior to publication.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000151">sio:SIO_000151</a>
    /// </summary>
    let SIO_000151 = _prefixId.prefix "SIO_000151"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000152^^xsd:string</para>
    ///   <para>rdfs:label : note</para>
    ///   <para>dcterms:description : A note is a brief document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000152">sio:SIO_000152</a>
    /// </summary>
    let SIO_000152 = _prefixId.prefix "SIO_000152"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000153^^xsd:string</para>
    ///   <para>rdfs:label : patent</para>
    ///   <para>dcterms:description : A patent is an information entity granted by a patent issuing authority which confers upon the patenter the sole right to make, use and sell an invention for a set period of time.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000153">sio:SIO_000153</a>
    /// </summary>
    let SIO_000153 = _prefixId.prefix "SIO_000153"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000154^^xsd:string</para>
    ///   <para>rdfs:label : article</para>
    ///   <para>dcterms:description : An article is a publication that is stand-alone section of a larger work.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000154">sio:SIO_000154</a>
    /// </summary>
    let SIO_000154 = _prefixId.prefix "SIO_000154"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000155^^xsd:string</para>
    ///   <para>rdfs:label : blog</para>
    ///   <para>dcterms:description : A blog is a publication accessible at some website and is typically about various experiences.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000155">sio:SIO_000155</a>
    /// </summary>
    let SIO_000155 = _prefixId.prefix "SIO_000155"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000156^^xsd:string</para>
    ///   <para>rdfs:label : book volume</para>
    ///   <para>dcterms:description : A book volume is a book that is part of a collection.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000156">sio:SIO_000156</a>
    /// </summary>
    let SIO_000156 = _prefixId.prefix "SIO_000156"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000157^^xsd:string</para>
    ///   <para>rdfs:label : conference proceedings</para>
    ///   <para>dcterms:description : A conference proceedings is a book composed of papers presented at a conference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000157">sio:SIO_000157</a>
    /// </summary>
    let SIO_000157 = _prefixId.prefix "SIO_000157"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000158^^xsd:string</para>
    ///   <para>rdfs:label : book series</para>
    ///   <para>dcterms:description : A book series is a collection of books that have been sequentially published.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000158">sio:SIO_000158</a>
    /// </summary>
    let SIO_000158 = _prefixId.prefix "SIO_000158"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000159^^xsd:string</para>
    ///   <para>rdfs:label : edited publication</para>
    ///   <para>dcterms:description : An edited publication is a publication that has been examined and potentially changed by an editor.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000159">sio:SIO_000159</a>
    /// </summary>
    let SIO_000159 = _prefixId.prefix "SIO_000159"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000160^^xsd:string</para>
    ///   <para>rdfs:label : journal</para>
    ///   <para>sio:equivalentTo : http://purl.org/ontology/bibo/Journal^^xsd:anyURI</para>
    ///   <para>dcterms:description : A journal is a a peer-reviewed periodical in which scholarship relating to a particular academic discipline is published.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000160">sio:SIO_000160</a>
    /// </summary>
    let SIO_000160 = _prefixId.prefix "SIO_000160"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000161^^xsd:string</para>
    ///   <para>rdfs:label : manual</para>
    ///   <para>dcterms:description : A manual is a document that instructs on the usage of a device.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000161">sio:SIO_000161</a>
    /// </summary>
    let SIO_000161 = _prefixId.prefix "SIO_000161"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000162^^xsd:string</para>
    ///   <para>rdfs:label : periodical</para>
    ///   <para>sio:equivalentTo : http://purl.org/ontology/bibo/Periodical^^xsd:string</para>
    ///   <para>dcterms:description : A periodical is a publication that appears on a regular schedule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000162">sio:SIO_000162</a>
    /// </summary>
    let SIO_000162 = _prefixId.prefix "SIO_000162"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000163^^xsd:string</para>
    ///   <para>rdfs:label : newspaper</para>
    ///   <para>sio:equivalentTo : http://purl.org/ontology/bibo/Newspaper^^xsd:string</para>
    ///   <para>dcterms:description : A newspaper is a periodical publication containing news regarding current events, informative articles, diverse features, editorials, and advertising.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000163">sio:SIO_000163</a>
    /// </summary>
    let SIO_000163 = _prefixId.prefix "SIO_000163"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000164^^xsd:string</para>
    ///   <para>rdfs:label : technical report</para>
    ///   <para>dcterms:description : A technical report is a publication published by a school or other institution, usually numbered within a series.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000164">sio:SIO_000164</a>
    /// </summary>
    let SIO_000164 = _prefixId.prefix "SIO_000164"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000165^^xsd:string</para>
    ///   <para>rdfs:label : thesis document</para>
    ///   <para>dcterms:description : A thesis document is the written research component of a post-secondary institution  that contains a statement supported by arguments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000165">sio:SIO_000165</a>
    /// </summary>
    let SIO_000165 = _prefixId.prefix "SIO_000165"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000166^^xsd:string</para>
    ///   <para>rdfs:label : honor's thesis</para>
    ///   <para>dcterms:description : An honor's thesis is a thesis prepared as a requirement for an honor's undergraduate degree.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000166">sio:SIO_000166</a>
    /// </summary>
    let SIO_000166 = _prefixId.prefix "SIO_000166"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000167^^xsd:string</para>
    ///   <para>rdfs:label : master's thesis</para>
    ///   <para>dcterms:description : A Master's thesis is a thesis prepared as a requirement for a Master's degree.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000167">sio:SIO_000167</a>
    /// </summary>
    let SIO_000167 = _prefixId.prefix "SIO_000167"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000168^^xsd:string</para>
    ///   <para>rdfs:label : phd thesis</para>
    ///   <para>dcterms:description : A PhD thesis is a thesis prepared as a requirement for a doctoral degree.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000168">sio:SIO_000168</a>
    /// </summary>
    let SIO_000168 = _prefixId.prefix "SIO_000168"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000169^^xsd:string</para>
    ///   <para>rdfs:label : booklet</para>
    ///   <para>dcterms:description : A booklet is a document that lacks a named publisher or sponsoring institution.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000169">sio:SIO_000169</a>
    /// </summary>
    let SIO_000169 = _prefixId.prefix "SIO_000169"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000170^^xsd:string</para>
    ///   <para>rdfs:label : diary</para>
    ///   <para>dcterms:description : A diary is a document which describes day-to-day experiences.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000170">sio:SIO_000170</a>
    /// </summary>
    let SIO_000170 = _prefixId.prefix "SIO_000170"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000171^^xsd:string</para>
    ///   <para>rdfs:label : document component</para>
    ///   <para>dcterms:description : A bibliographic attribute is an attribute related to publications.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000171">sio:SIO_000171</a>
    /// </summary>
    let SIO_000171 = _prefixId.prefix "SIO_000171"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000172^^xsd:string</para>
    ///   <para>rdfs:label : address</para>
    ///   <para>dcterms:description : An address is a position that indicates the physical location of some entity using a social convention.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000172">sio:SIO_000172</a>
    /// </summary>
    let SIO_000172 = _prefixId.prefix "SIO_000172"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000173^^xsd:string</para>
    ///   <para>rdfs:label : affiliation</para>
    ///   <para>dcterms:description : An affiliation is a social relation which indicates the partnership between two or more entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000173">sio:SIO_000173</a>
    /// </summary>
    let SIO_000173 = _prefixId.prefix "SIO_000173"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000174^^xsd:string</para>
    ///   <para>rdfs:label : citation</para>
    ///   <para>dcterms:description : A citation is a textual entity which denotes a source described in the bibliography or reference section of a document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000174">sio:SIO_000174</a>
    /// </summary>
    let SIO_000174 = _prefixId.prefix "SIO_000174"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000175^^xsd:string</para>
    ///   <para>rdfs:label : document title</para>
    ///   <para>dcterms:description : A document title is a textual entity that summarizes the topic of the document in one sentence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000175">sio:SIO_000175</a>
    /// </summary>
    let SIO_000175 = _prefixId.prefix "SIO_000175"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000176^^xsd:string</para>
    ///   <para>rdfs:label : reference</para>
    ///   <para>dcterms:description : A reference is a textual entity that describes a single source used in the preparation or development of the work.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000176">sio:SIO_000176</a>
    /// </summary>
    let SIO_000176 = _prefixId.prefix "SIO_000176"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000177^^xsd:string</para>
    ///   <para>rdfs:label : page range</para>
    ///   <para>dcterms:description : A page range denotes the start and end page in some document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000177">sio:SIO_000177</a>
    /// </summary>
    let SIO_000177 = _prefixId.prefix "SIO_000177"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000178^^xsd:string</para>
    ///   <para>rdfs:label : page total</para>
    ///   <para>dcterms:description : A page total is a textual entity that is about the number of pages in some informational entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000178">sio:SIO_000178</a>
    /// </summary>
    let SIO_000178 = _prefixId.prefix "SIO_000178"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000179^^xsd:string</para>
    ///   <para>rdfs:label : label</para>
    ///   <para>dcterms:description : a label is a term that is associated with some entity</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000179">sio:SIO_000179</a>
    /// </summary>
    let SIO_000179 = _prefixId.prefix "SIO_000179"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000180^^xsd:string</para>
    ///   <para>rdfs:label : language label</para>
    ///   <para>dcterms:description : A language label is a label that denotes the language of a textual entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000180">sio:SIO_000180</a>
    /// </summary>
    let SIO_000180 = _prefixId.prefix "SIO_000180"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000181^^xsd:string</para>
    ///   <para>rdfs:label : first name</para>
    ///   <para>dcterms:description : A first name is a name that denotes a specific individual between members of a group of individuals, whose members usually share the same surname.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000181">sio:SIO_000181</a>
    /// </summary>
    let SIO_000181 = _prefixId.prefix "SIO_000181"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000182^^xsd:string</para>
    ///   <para>rdfs:label : last name</para>
    ///   <para>dcterms:description : A last name (surname) is a name added to a given name and is part of a personal name and is often the family name.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000182">sio:SIO_000182</a>
    /// </summary>
    let SIO_000182 = _prefixId.prefix "SIO_000182"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000183^^xsd:string</para>
    ///   <para>rdfs:label : personal name</para>
    ///   <para>sio:hasSynonym : full name^^xsd:string</para>
    ///   <para>dcterms:description : A personal name is a name to identify an individual person and usually comprises of a first name and a last name.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000183">sio:SIO_000183</a>
    /// </summary>
    let SIO_000183 = _prefixId.prefix "SIO_000183"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000184^^xsd:string</para>
    ///   <para>rdfs:label : legal name</para>
    ///   <para>dcterms:description : A legal name is a name given at birth, or which appears on their birth certificate, marriage certificate, or change of name certificate.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000184">sio:SIO_000184</a>
    /// </summary>
    let SIO_000184 = _prefixId.prefix "SIO_000184"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000185^^xsd:string</para>
    ///   <para>rdfs:label : title</para>
    ///   <para>dcterms:description : A title is a textual entity that summarily describes some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000185">sio:SIO_000185</a>
    /// </summary>
    let SIO_000185 = _prefixId.prefix "SIO_000185"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000186^^xsd:string</para>
    ///   <para>rdfs:label : document version</para>
    ///   <para>dcterms:description : A document version is a version of a work in some sequence of derivative works.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000186">sio:SIO_000186</a>
    /// </summary>
    let SIO_000186 = _prefixId.prefix "SIO_000186"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000188^^xsd:string</para>
    ///   <para>rdfs:label : abstract section</para>
    ///   <para>dcterms:description : An abstract section is a document section that provides brief summary of a document that explains the main argument(s), topic(s) or findings.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000188">sio:SIO_000188</a>
    /// </summary>
    let SIO_000188 = _prefixId.prefix "SIO_000188"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000189^^xsd:string</para>
    ///   <para>rdfs:label : acknowledgements section</para>
    ///   <para>dcterms:description : An acknowledgements section is a document section that identifies individuals, groups or organizations for their support in the development of the work.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000189">sio:SIO_000189</a>
    /// </summary>
    let SIO_000189 = _prefixId.prefix "SIO_000189"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000190^^xsd:string</para>
    ///   <para>rdfs:label : author contribution section</para>
    ///   <para>dcterms:description : An author contribution section is a document section that describes the contribution of the authors.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000190">sio:SIO_000190</a>
    /// </summary>
    let SIO_000190 = _prefixId.prefix "SIO_000190"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000191^^xsd:string</para>
    ///   <para>rdfs:label : author section</para>
    ///   <para>dcterms:description : An author section is a document section that lists the contributing authors.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000191">sio:SIO_000191</a>
    /// </summary>
    let SIO_000191 = _prefixId.prefix "SIO_000191"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000192^^xsd:string</para>
    ///   <para>rdfs:label : bibliography section</para>
    ///   <para>dcterms:description : A bibliography section is a document section that is composed of a list of references used in the development of the work.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000192">sio:SIO_000192</a>
    /// </summary>
    let SIO_000192 = _prefixId.prefix "SIO_000192"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000193^^xsd:string</para>
    ///   <para>rdfs:label : copyright section</para>
    ///   <para>dcterms:description : A copyright section is a document section that contains a notice of copyright.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000193">sio:SIO_000193</a>
    /// </summary>
    let SIO_000193 = _prefixId.prefix "SIO_000193"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000194^^xsd:string</para>
    ///   <para>rdfs:label : correspondence section</para>
    ///   <para>dcterms:description : A correspondence section is a document section that contains the details for contacting the corresponding author.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000194">sio:SIO_000194</a>
    /// </summary>
    let SIO_000194 = _prefixId.prefix "SIO_000194"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000195^^xsd:string</para>
    ///   <para>rdfs:label : discussion section</para>
    ///   <para>dcterms:description : The discussion section is a document section containing a summary of the findings, a reflection on the significance of findings, comparison with related work, among others.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000195">sio:SIO_000195</a>
    /// </summary>
    let SIO_000195 = _prefixId.prefix "SIO_000195"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000196^^xsd:string</para>
    ///   <para>rdfs:label : introduction section</para>
    ///   <para>dcterms:description : An introduction section is a document section that generally provides background, motivation and goals of the work.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000196">sio:SIO_000196</a>
    /// </summary>
    let SIO_000196 = _prefixId.prefix "SIO_000196"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000197^^xsd:string</para>
    ///   <para>rdfs:label : materials and methods section</para>
    ///   <para>dcterms:description : The materials and methods section is a document section containing a description of the materials and methods used in the study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000197">sio:SIO_000197</a>
    /// </summary>
    let SIO_000197 = _prefixId.prefix "SIO_000197"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000198^^xsd:string</para>
    ///   <para>rdfs:label : materials section</para>
    ///   <para>dcterms:description : The materials section is a document section containing a description of the materials used in the study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000198">sio:SIO_000198</a>
    /// </summary>
    let SIO_000198 = _prefixId.prefix "SIO_000198"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000199^^xsd:string</para>
    ///   <para>rdfs:label : methods section</para>
    ///   <para>dcterms:description : The methods section is a document section containing a description of the methods used in the study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000199">sio:SIO_000199</a>
    /// </summary>
    let SIO_000199 = _prefixId.prefix "SIO_000199"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000200^^xsd:string</para>
    ///   <para>rdfs:label : results section</para>
    ///   <para>dcterms:description : The results section is a document section describing the main findings of the study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000200">sio:SIO_000200</a>
    /// </summary>
    let SIO_000200 = _prefixId.prefix "SIO_000200"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000201^^xsd:string</para>
    ///   <para>rdfs:label : table of contents</para>
    ///   <para>dcterms:description : The table of contents is a document section that lists all sections (and optionally subsections) in a sequential order along with their page number.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000201">sio:SIO_000201</a>
    /// </summary>
    let SIO_000201 = _prefixId.prefix "SIO_000201"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000202^^xsd:string</para>
    ///   <para>rdfs:label : contains</para>
    ///   <para>dcterms:description : A contains B iff the spatial region occupied by A has the spatial region occupied by B as a part, and B is not part of A. [T]</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000202">sio:SIO_000202</a>
    /// </summary>
    let SIO_000202 = _prefixId.prefix "SIO_000202"
    /// <summary>
    ///   <para>sio:subset : nlp^^xsd:stringsio:subset : core^^xsd:string</para>
    ///   <para>dc11:identifier : SIO_000203^^xsd:string</para>
    ///   <para>rdfs:label : is connected to</para>
    ///   <para>dcterms:description : A is connected to B iff there exists a fiat, material or temporal path between A and B. [S][T]</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000203">sio:SIO_000203</a>
    /// </summary>
    let SIO_000203 = _prefixId.prefix "SIO_000203"
    /// <summary>
    ///   <para>dcterms:description : A is adjacent to B iff there is a small, but non-zero distance between A and B</para>
    ///   <para>sio:subset : nlp^^xsd:stringsio:subset : core^^xsd:string</para>
    ///   <para>rdfs:label : is adjacent to</para>
    ///   <para>dc11:identifier : SIO_000204^^xsd:string</para>
    ///   <para>sio:equivalentTo : OBO_REL:adjacent_to^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000204">sio:SIO_000204</a>
    /// </summary>
    let SIO_000204 = _prefixId.prefix "SIO_000204"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000205^^xsd:string</para>
    ///   <para>rdfs:label : is represented by</para>
    ///   <para>dcterms:description : is represented by: a relation between an entity and some symbol.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000205">sio:SIO_000205</a>
    /// </summary>
    let SIO_000205 = _prefixId.prefix "SIO_000205"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000206^^xsd:string</para>
    ///   <para>rdfs:label : is supported by</para>
    ///   <para>dcterms:description : is supported by is a relation between a proposition and something that supports the truth of the assertion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000206">sio:SIO_000206</a>
    /// </summary>
    let SIO_000206 = _prefixId.prefix "SIO_000206"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000207^^xsd:string</para>
    ///   <para>rdfs:label : is disputed by</para>
    ///   <para>dcterms:description : has disputing evidence is a relation between a proposition and something that disputes (does not directly support) the truth of the assertion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000207">sio:SIO_000207</a>
    /// </summary>
    let SIO_000207 = _prefixId.prefix "SIO_000207"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000208^^xsd:string</para>
    ///   <para>rdfs:label : is supporting evidence for</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000208">sio:SIO_000208</a>
    /// </summary>
    let SIO_000208 = _prefixId.prefix "SIO_000208"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000209^^xsd:string</para>
    ///   <para>rdfs:label : is disputing evidence for</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000209">sio:SIO_000209</a>
    /// </summary>
    let SIO_000209 = _prefixId.prefix "SIO_000209"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000210^^xsd:string</para>
    ///   <para>rdfs:label : represents</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : a represents b when a serves as a sign, symbol or model of b.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000210">sio:SIO_000210</a>
    /// </summary>
    let SIO_000210 = _prefixId.prefix "SIO_000210"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000211^^xsd:string</para>
    ///   <para>rdfs:label : is positionally after</para>
    ///   <para>dcterms:description : is positionally after is a relation between entities placed on a dimensional axis in which the projection of the position of the first entity is numerically greater than the projection of the position of the second entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000211">sio:SIO_000211</a>
    /// </summary>
    let SIO_000211 = _prefixId.prefix "SIO_000211"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000212^^xsd:string</para>
    ///   <para>rdfs:label : is referred to by</para>
    ///   <para>dcterms:description : A is referred to by B iff B is an informational entity that makes reference to A.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000212">sio:SIO_000212</a>
    /// </summary>
    let SIO_000212 = _prefixId.prefix "SIO_000212"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000213^^xsd:string</para>
    ///   <para>rdfs:label : has concretization</para>
    ///   <para>dcterms:description : A has concretization B iff A is an informational entity and B is the a quality of some material entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000213">sio:SIO_000213</a>
    /// </summary>
    let SIO_000213 = _prefixId.prefix "SIO_000213"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000214^^xsd:string</para>
    ///   <para>rdfs:label : is concretization of</para>
    ///   <para>dcterms:description : A is concretization of B iff A is a quality of a material entity and B is an informational entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000214">sio:SIO_000214</a>
    /// </summary>
    let SIO_000214 = _prefixId.prefix "SIO_000214"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000215^^xsd:string</para>
    ///   <para>rdfs:label : is measurement value of</para>
    ///   <para>dcterms:description : is measurement value of is a relation between a value and the entity that it is a measurement of.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000215">sio:SIO_000215</a>
    /// </summary>
    let SIO_000215 = _prefixId.prefix "SIO_000215"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000216^^xsd:string</para>
    ///   <para>rdfs:label : has measurement value</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : has measurement value is a relation between a quality/realizable and a measurement value.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000216">sio:SIO_000216</a>
    /// </summary>
    let SIO_000216 = _prefixId.prefix "SIO_000216"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000217^^xsd:string</para>
    ///   <para>rdfs:label : has quality</para>
    ///   <para>dcterms:description : has quality is a relation between an entity and the quality that it bears.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000217">sio:SIO_000217</a>
    /// </summary>
    let SIO_000217 = _prefixId.prefix "SIO_000217"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000218^^xsd:string</para>
    ///   <para>rdfs:label : is quality of</para>
    ///   <para>dcterms:description : is quality of is a relation between a quality and the entity that it is a property of.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000218">sio:SIO_000218</a>
    /// </summary>
    let SIO_000218 = _prefixId.prefix "SIO_000218"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000219^^xsd:string</para>
    ///   <para>rdfs:label : is source of</para>
    ///   <para>dcterms:description : is source of is a relation between a source of information about some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000219">sio:SIO_000219</a>
    /// </summary>
    let SIO_000219 = _prefixId.prefix "SIO_000219"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000220^^xsd:string</para>
    ///   <para>rdfs:label : implies (-&gt;)</para>
    ///   <para>dcterms:description : Implication is a logical operator that holds between a set T of propositions and a proposition B, when every model (or interpretation or valuation) of T is also a model of B.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000220">sio:SIO_000220</a>
    /// </summary>
    let SIO_000220 = _prefixId.prefix "SIO_000220"
    /// <summary>
    ///   <para>rdfs:label : has unit</para>
    ///   <para>dcterms:description : has unit is a relation between a quantity and the unit it is a multiple of.</para>
    ///   <para>dc11:identifier : SIO_000221^^xsd:string</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000221">sio:SIO_000221</a>
    /// </summary>
    let SIO_000221 = _prefixId.prefix "SIO_000221"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000222^^xsd:string</para>
    ///   <para>rdfs:label : is unit of</para>
    ///   <para>dcterms:description : is unit of is a relation between a unit and a quantity that it is a multiple of.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000222">sio:SIO_000222</a>
    /// </summary>
    let SIO_000222 = _prefixId.prefix "SIO_000222"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000223^^xsd:string</para>
    ///   <para>rdfs:label : has property</para>
    ///   <para>sio:example : michel's hair has the quality of being brown in colour.</para>
    ///   <para>dcterms:description : has property is a relation between an entity and the quality, capability or role that it and it alone bears.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000223">sio:SIO_000223</a>
    /// </summary>
    let SIO_000223 = _prefixId.prefix "SIO_000223"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000224^^xsd:string</para>
    ///   <para>rdfs:label : is property of</para>
    ///   <para>dcterms:description : is property of is a relation betweena  quality, capability or role and the entity that it and it alone bears.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000224">sio:SIO_000224</a>
    /// </summary>
    let SIO_000224 = _prefixId.prefix "SIO_000224"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000225^^xsd:string</para>
    ///   <para>rdfs:label : has function</para>
    ///   <para>dcterms:description : has function is the relation between an entity and a function that is ascribed to it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000225">sio:SIO_000225</a>
    /// </summary>
    let SIO_000225 = _prefixId.prefix "SIO_000225"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000226^^xsd:string</para>
    ///   <para>rdfs:label : is function of</para>
    ///   <para>dcterms:description : is function of is a relation between a function and an entity that it is a property of.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000226">sio:SIO_000226</a>
    /// </summary>
    let SIO_000226 = _prefixId.prefix "SIO_000226"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000227^^xsd:string</para>
    ///   <para>rdfs:label : is role of</para>
    ///   <para>dcterms:description : is role of is a relation between a role and the entity that it is a property of.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000227">sio:SIO_000227</a>
    /// </summary>
    let SIO_000227 = _prefixId.prefix "SIO_000227"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000228^^xsd:string</para>
    ///   <para>rdfs:label : has role</para>
    ///   <para>dcterms:description : has role is a relation between an entity and a role that it bears.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000228">sio:SIO_000228</a>
    /// </summary>
    let SIO_000228 = _prefixId.prefix "SIO_000228"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000229^^xsd:string</para>
    ///   <para>rdfs:label : has output</para>
    ///   <para>sio:subset : sadisio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : has output is a relation between an process and an entity, where the entity is present at the end of the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000229">sio:SIO_000229</a>
    /// </summary>
    let SIO_000229 = _prefixId.prefix "SIO_000229"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000230^^xsd:string</para>
    ///   <para>rdfs:label : has input</para>
    ///   <para>sio:subset : sadisio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : has input is a relation between a process and an entity, where the entity is present at the beginning of the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000230">sio:SIO_000230</a>
    /// </summary>
    let SIO_000230 = _prefixId.prefix "SIO_000230"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000231^^xsd:string</para>
    ///   <para>rdfs:label : is input in</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>sio:example : glucose and ATP are inputs in the hexokinase-mediated conversion of glucose to glucose-6-phosphate.</para>
    ///   <para>dcterms:description : is input in is a relation between an entity and a process, where the entity is present at the beginning of the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000231">sio:SIO_000231</a>
    /// </summary>
    let SIO_000231 = _prefixId.prefix "SIO_000231"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000232^^xsd:string</para>
    ///   <para>rdfs:label : is output of</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>sio:example : glucose-6-phosphate and ADP are outputs in the hexokinase-mediated conversion of glucose to glucose-6-phosphate.</para>
    ///   <para>dcterms:description : is output of is a relation between an entity and a process, where the entity is present at the end of the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000232">sio:SIO_000232</a>
    /// </summary>
    let SIO_000232 = _prefixId.prefix "SIO_000232"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000233^^xsd:string</para>
    ///   <para>rdfs:label : is implementation of</para>
    ///   <para>dcterms:description : is implementation of is a relation between an information entity and a specification that it conforms to.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000233">sio:SIO_000233</a>
    /// </summary>
    let SIO_000233 = _prefixId.prefix "SIO_000233"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000234^^xsd:string</para>
    ///   <para>rdfs:label : has implementation</para>
    ///   <para>dcterms:description : has implementation is a relation between a specification and an implementation that conforms to it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000234">sio:SIO_000234</a>
    /// </summary>
    let SIO_000234 = _prefixId.prefix "SIO_000234"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000235^^xsd:string</para>
    ///   <para>rdfs:label : has disposition</para>
    ///   <para>dcterms:description : has disposition is the relation between an entity and a disposition that it bears.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000235">sio:SIO_000235</a>
    /// </summary>
    let SIO_000235 = _prefixId.prefix "SIO_000235"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000236^^xsd:string</para>
    ///   <para>rdfs:label : is disposition of</para>
    ///   <para>dcterms:description : is disposition of is a relation between a disposition and the entity that it is a property of.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000236">sio:SIO_000236</a>
    /// </summary>
    let SIO_000236 = _prefixId.prefix "SIO_000236"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000237^^xsd:string</para>
    ///   <para>rdfs:label : namespace label</para>
    ///   <para>dcterms:description : A namespace label is a short name for a namespace.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000237">sio:SIO_000237</a>
    /// </summary>
    let SIO_000237 = _prefixId.prefix "SIO_000237"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000238^^xsd:string</para>
    ///   <para>rdfs:label : logical operator</para>
    ///   <para>dcterms:description : A logical operator is a unary or binary relation to construct logical expressions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000238">sio:SIO_000238</a>
    /// </summary>
    let SIO_000238 = _prefixId.prefix "SIO_000238"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000239^^xsd:string</para>
    ///   <para>rdfs:label : conjunction (and)</para>
    ///   <para>dcterms:description : AND is a logical operator that has the value true if both of its operands are true, otherwise a value of false.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000239">sio:SIO_000239</a>
    /// </summary>
    let SIO_000239 = _prefixId.prefix "SIO_000239"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000240^^xsd:string</para>
    ///   <para>rdfs:label : is positionally before</para>
    ///   <para>dcterms:description : is positionally before is a relation between entities placed on a dimensional axis in which the projection of the position of the first entity is numerically less than the projection of the position of the second entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000240">sio:SIO_000240</a>
    /// </summary>
    let SIO_000240 = _prefixId.prefix "SIO_000240"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000241^^xsd:string</para>
    ///   <para>rdfs:label : is directly after</para>
    ///   <para>dcterms:description : is directly after is a relation between entities placed on a dimensional axis in which the projection of the position of the first entity is numerically greater than the projection of the position of the second entity, and the entities are adjacent to one another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000241">sio:SIO_000241</a>
    /// </summary>
    let SIO_000241 = _prefixId.prefix "SIO_000241"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000242^^xsd:string</para>
    ///   <para>rdfs:label : is directly before</para>
    ///   <para>dcterms:description : is directly before is a relation between entities placed on a dimensional axis in which the projection of the position of the first entity is numerically less than the projection of the position of the second entity, and the entities are adjacent to one another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000242">sio:SIO_000242</a>
    /// </summary>
    let SIO_000242 = _prefixId.prefix "SIO_000242"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000243^^xsd:string</para>
    ///   <para>rdfs:label : is causally related with</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A transitive, symmetric, temporal relation in which one entity is causally related with another non-identical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000243">sio:SIO_000243</a>
    /// </summary>
    let SIO_000243 = _prefixId.prefix "SIO_000243"
    /// <summary>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>rdfs:label : is derived from</para>
    ///   <para>sio:equivalentTo : OBO_REL:derives_from^^xsd:string</para>
    ///   <para>dcterms:description : A transitive temporal relation in which one entity was materially formed from another non-identical entity.</para>
    ///   <para>dc11:identifier : SIO_000244^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000244">sio:SIO_000244</a>
    /// </summary>
    let SIO_000244 = _prefixId.prefix "SIO_000244"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000245^^xsd:string</para>
    ///   <para>rdfs:label : derives into</para>
    ///   <para>dcterms:description : a derives to b if and only if a or some part thereof is consumed in the formation of b.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000245">sio:SIO_000245</a>
    /// </summary>
    let SIO_000245 = _prefixId.prefix "SIO_000245"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000246^^xsd:string</para>
    ///   <para>rdfs:label : immediately derives into</para>
    ///   <para>dcterms:description : a immediately derives into b if and only if a or some significant part thereof is consumed in the formation of b and there are no identifiable intermediate entities between a and b.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000246">sio:SIO_000246</a>
    /// </summary>
    let SIO_000246 = _prefixId.prefix "SIO_000246"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000247^^xsd:string</para>
    ///   <para>rdfs:label : is immediately derived from</para>
    ///   <para>dcterms:description : A non-transitive temporal relation in which one entity is immediately derived from a non-identical entity such that there are no intermediate entities between them.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000247">sio:SIO_000247</a>
    /// </summary>
    let SIO_000247 = _prefixId.prefix "SIO_000247"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000248^^xsd:string</para>
    ///   <para>rdfs:label : precedes</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A transitive, temporal relation in which one process precedes (has occured earlier than) another process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000248">sio:SIO_000248</a>
    /// </summary>
    let SIO_000248 = _prefixId.prefix "SIO_000248"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000249^^xsd:string</para>
    ///   <para>rdfs:label : is preceded by</para>
    ///   <para>sio:equivalentTo : OBO_REL:preceded_by^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000249">sio:SIO_000249</a>
    /// </summary>
    let SIO_000249 = _prefixId.prefix "SIO_000249"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000250^^xsd:string</para>
    ///   <para>rdfs:label : immediately precedes</para>
    ///   <para>dcterms:description : A non-transitive temporal relation in which one process immediately precedes another process, such that there is no interval of time between the two processes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000250">sio:SIO_000250</a>
    /// </summary>
    let SIO_000250 = _prefixId.prefix "SIO_000250"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000251^^xsd:string</para>
    ///   <para>rdfs:label : is immediately preceded by</para>
    ///   <para>dcterms:description : A non-transitive temporal relation in which one process is immediately preceded by another process, such that there is no interval of time between the two processes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000251">sio:SIO_000251</a>
    /// </summary>
    let SIO_000251 = _prefixId.prefix "SIO_000251"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000252^^xsd:string</para>
    ///   <para>rdfs:label : is referenced by</para>
    ///   <para>dcterms:description : is reference for is a relation between a document that provides information about an entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000252">sio:SIO_000252</a>
    /// </summary>
    let SIO_000252 = _prefixId.prefix "SIO_000252"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000253^^xsd:string</para>
    ///   <para>rdfs:label : has source</para>
    ///   <para>dcterms:description : has source is a relation between an entity and another entity from which it stems from.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000253">sio:SIO_000253</a>
    /// </summary>
    let SIO_000253 = _prefixId.prefix "SIO_000253"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000254^^xsd:string</para>
    ///   <para>rdfs:label : is annotation of</para>
    ///   <para>dcterms:description : is annotation of is a relation between some textual entity and the entity that it annotates.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000254">sio:SIO_000254</a>
    /// </summary>
    let SIO_000254 = _prefixId.prefix "SIO_000254"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000255^^xsd:string</para>
    ///   <para>rdfs:label : has annotation</para>
    ///   <para>sio:example : document x is annotated with the keywords 'ontology','semantic web'</para>
    ///   <para>sio:hasSynonym : is annotated withsio:hasSynonym : was annotated with</para>
    ///   <para>dcterms:description : has annotation is a relation between an entity and some textual anntotation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000255">sio:SIO_000255</a>
    /// </summary>
    let SIO_000255 = _prefixId.prefix "SIO_000255"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000256^^xsd:string</para>
    ///   <para>rdfs:label : proposition</para>
    ///   <para>dcterms:description : A proposition is a sentence expressing something true or false.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000256">sio:SIO_000256</a>
    /// </summary>
    let SIO_000256 = _prefixId.prefix "SIO_000256"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000257^^xsd:string</para>
    ///   <para>rdfs:label : dimensionless quantity</para>
    ///   <para>dcterms:description : A dimensionless quantity is a quantity that has no associated unit.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000257">sio:SIO_000257</a>
    /// </summary>
    let SIO_000257 = _prefixId.prefix "SIO_000257"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000258^^xsd:string</para>
    ///   <para>rdfs:label : dimensional quantity</para>
    ///   <para>dcterms:description : A dimensional quantity is a quantity that has an associated unit.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000258">sio:SIO_000258</a>
    /// </summary>
    let SIO_000258 = _prefixId.prefix "SIO_000258"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000259^^xsd:string</para>
    ///   <para>rdfs:label : argument</para>
    ///   <para>dcterms:description : An argument is a set of one or more declarative sentences (or propositions) known as the premises along with another declarative sentence (or proposition) known as the conclusion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000259">sio:SIO_000259</a>
    /// </summary>
    let SIO_000259 = _prefixId.prefix "SIO_000259"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000261^^xsd:string</para>
    ///   <para>rdfs:label : premise</para>
    ///   <para>dcterms:description : A premise is a proposition of an argument from which the conclusion is drawn.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000261">sio:SIO_000261</a>
    /// </summary>
    let SIO_000261 = _prefixId.prefix "SIO_000261"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000262^^xsd:string</para>
    ///   <para>rdfs:label : conclusion</para>
    ///   <para>dcterms:description : A conclusion is a proposition which is reached after considering the evidence, arguments or premises.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000262">sio:SIO_000262</a>
    /// </summary>
    let SIO_000262 = _prefixId.prefix "SIO_000262"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000263^^xsd:string</para>
    ///   <para>rdfs:label : deductive argument</para>
    ///   <para>dcterms:description : A deductive argument is an argument that asserts that the truth of the conclusion is a logical consequence of the premises.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000263">sio:SIO_000263</a>
    /// </summary>
    let SIO_000263 = _prefixId.prefix "SIO_000263"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000264^^xsd:string</para>
    ///   <para>rdfs:label : inductive argument</para>
    ///   <para>dcterms:description : An inductive argument is an argument that asserts that the truth of the conclusion is supported by the premises.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000264">sio:SIO_000264</a>
    /// </summary>
    let SIO_000264 = _prefixId.prefix "SIO_000264"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000265^^xsd:string</para>
    ///   <para>rdfs:label : sound argument</para>
    ///   <para>dcterms:description : A sound argument is a valid argument with true premises.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000265">sio:SIO_000265</a>
    /// </summary>
    let SIO_000265 = _prefixId.prefix "SIO_000265"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000266^^xsd:string</para>
    ///   <para>rdfs:label : valid argument</para>
    ///   <para>dcterms:description : A valid argument is an argument where the truth of the conclusion is a logical consequence of the premises and (consequently) its corresponding conditional is a necessary truth.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000266">sio:SIO_000266</a>
    /// </summary>
    let SIO_000266 = _prefixId.prefix "SIO_000266"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000267^^xsd:string</para>
    ///   <para>rdfs:label : invalid argument</para>
    ///   <para>dcterms:description : An invalid argument is an argument where the truth of the conclusion is false because it is not a logical consequence of the premises.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000267">sio:SIO_000267</a>
    /// </summary>
    let SIO_000267 = _prefixId.prefix "SIO_000267"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000268^^xsd:string</para>
    ///   <para>rdfs:label : truth value</para>
    ///   <para>dcterms:description : truth value is a quality of information that is claimed/verified to be true or false.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000268">sio:SIO_000268</a>
    /// </summary>
    let SIO_000268 = _prefixId.prefix "SIO_000268"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000269^^xsd:string</para>
    ///   <para>rdfs:label : true</para>
    ///   <para>dcterms:description : true is a truth value that indicates that it holds under all possible worlds.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000269">sio:SIO_000269</a>
    /// </summary>
    let SIO_000269 = _prefixId.prefix "SIO_000269"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000270^^xsd:string</para>
    ///   <para>rdfs:label : false</para>
    ///   <para>dcterms:description : false is a truth value in that indicates that it is not true.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000270">sio:SIO_000270</a>
    /// </summary>
    let SIO_000270 = _prefixId.prefix "SIO_000270"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000272^^xsd:string</para>
    ///   <para>rdfs:label : is variant of</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : is variant of: a relationship indicating that two entities are different (by some measure), but either achieve the same objectives in different ways or are permutations of one another (temporal, logical or otherwise)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000272">sio:SIO_000272</a>
    /// </summary>
    let SIO_000272 = _prefixId.prefix "SIO_000272"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000273^^xsd:string</para>
    ///   <para>rdfs:label : has direct part</para>
    ///   <para>sio:example : a car has an engine as a direct part</para>
    ///   <para>dcterms:description : has direct part is a relation to specify a part at a particular level of granularity</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000273">sio:SIO_000273</a>
    /// </summary>
    let SIO_000273 = _prefixId.prefix "SIO_000273"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000274^^xsd:string</para>
    ///   <para>rdfs:label : is prior version of</para>
    ///   <para>dcterms:description : A is prior version of B iff A is a variant of B and B derives from A.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000274">sio:SIO_000274</a>
    /// </summary>
    let SIO_000274 = _prefixId.prefix "SIO_000274"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000275^^xsd:string</para>
    ///   <para>rdfs:label : term</para>
    ///   <para>dcterms:description : A term is a word or phrase used to denote one or more entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000275">sio:SIO_000275</a>
    /// </summary>
    let SIO_000275 = _prefixId.prefix "SIO_000275"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000276^^xsd:string</para>
    ///   <para>rdfs:label : emotion</para>
    ///   <para>sio:subset : emotion++^^xsd:string</para>
    ///   <para>dcterms:description : An emotion is a process (experience) that arises internally or from an involuntary physiological response to a stimulus.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000276">sio:SIO_000276</a>
    /// </summary>
    let SIO_000276 = _prefixId.prefix "SIO_000276"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000277^^xsd:string</para>
    ///   <para>rdfs:label : cites</para>
    ///   <para>dcterms:description : cites is a relation to refer to by way of example, authority or proof.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000277">sio:SIO_000277</a>
    /// </summary>
    let SIO_000277 = _prefixId.prefix "SIO_000277"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000278^^xsd:string</para>
    ///   <para>rdfs:label : is cited by</para>
    ///   <para>dcterms:description : is cited by is a relation from an object that is referred to by way of example, authority or proof.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000278">sio:SIO_000278</a>
    /// </summary>
    let SIO_000278 = _prefixId.prefix "SIO_000278"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000279^^xsd:string</para>
    ///   <para>rdfs:label : mass</para>
    ///   <para>dcterms:description : mass is the quality of the amount of substance.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000279">sio:SIO_000279</a>
    /// </summary>
    let SIO_000279 = _prefixId.prefix "SIO_000279"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000280^^xsd:string</para>
    ///   <para>rdfs:label : disjunction (or)</para>
    ///   <para>dcterms:description : OR is a logical operator that results in true whenever one or more of its operands are true.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000280">sio:SIO_000280</a>
    /// </summary>
    let SIO_000280 = _prefixId.prefix "SIO_000280"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000281^^xsd:string</para>
    ///   <para>rdfs:label : negation (not)</para>
    ///   <para>dcterms:description : NOT is a logical operator in that has the value true if its operand is false.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000281">sio:SIO_000281</a>
    /// </summary>
    let SIO_000281 = _prefixId.prefix "SIO_000281"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000282^^xsd:string</para>
    ///   <para>rdfs:label : exclusive disjunction (xor)</para>
    ///   <para>dcterms:description : XOR, also called exclusive disjunction or (symbolized XOR, EOR, EXOR, or ⊕), is a type of logical disjunction on two operands that results in a value of true if exactly one of the operands has a value of true.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000282">sio:SIO_000282</a>
    /// </summary>
    let SIO_000282 = _prefixId.prefix "SIO_000282"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000283^^xsd:string</para>
    ///   <para>rdfs:label : is similar to</para>
    ///   <para>dcterms:description : is similar to is a relation between two entities that share one or more features.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000283">sio:SIO_000283</a>
    /// </summary>
    let SIO_000283 = _prefixId.prefix "SIO_000283"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000284^^xsd:string</para>
    ///   <para>rdfs:label : hypothesis</para>
    ///   <para>dcterms:description : A hypothesis is a proposed explanation for a phenomenon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000284">sio:SIO_000284</a>
    /// </summary>
    let SIO_000284 = _prefixId.prefix "SIO_000284"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000285^^xsd:string</para>
    ///   <para>rdfs:label : academic organization</para>
    ///   <para>dcterms:description : An academic organization is a lawfully recognized organization that confers diplomas, degrees and other forms of recognition of academic achievement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000285">sio:SIO_000285</a>
    /// </summary>
    let SIO_000285 = _prefixId.prefix "SIO_000285"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000286^^xsd:string</para>
    ///   <para>rdfs:label : is subsequent version of</para>
    ///   <para>dcterms:description : A is subsequent version of B iff A is a variant of B and A derives from B.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000286">sio:SIO_000286</a>
    /// </summary>
    let SIO_000286 = _prefixId.prefix "SIO_000286"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000287^^xsd:string</para>
    ///   <para>rdfs:label : social relation</para>
    ///   <para>dcterms:description : A social relation is a social entity that describes a relationship  between two or more individuals or groups.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000287">sio:SIO_000287</a>
    /// </summary>
    let SIO_000287 = _prefixId.prefix "SIO_000287"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000288^^xsd:string</para>
    ///   <para>rdfs:label : is covalently connected to (transitive)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000288">sio:SIO_000288</a>
    /// </summary>
    let SIO_000288 = _prefixId.prefix "SIO_000288"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000289^^xsd:string</para>
    ///   <para>rdfs:label : set</para>
    ///   <para>dcterms:description : A set is a collection of entities, for which there may be zero members.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000289">sio:SIO_000289</a>
    /// </summary>
    let SIO_000289 = _prefixId.prefix "SIO_000289"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000290^^xsd:string</para>
    ///   <para>rdfs:label : university</para>
    ///   <para>dcterms:description : A university is an institution of higher education and research which grants academic degrees in a variety of subjects and provides both undergraduate education and postgraduate education. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000290">sio:SIO_000290</a>
    /// </summary>
    let SIO_000290 = _prefixId.prefix "SIO_000290"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000291^^xsd:string</para>
    ///   <para>rdfs:label : has target</para>
    ///   <para>dcterms:description : has target is a relation between a process and an entity, where the entity is present at the beginning  of the process and undergoes a change or transformation in the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000291">sio:SIO_000291</a>
    /// </summary>
    let SIO_000291 = _prefixId.prefix "SIO_000291"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000292^^xsd:string</para>
    ///   <para>rdfs:label : is target in</para>
    ///   <para>sio:example : glucose is a target in the hexokinase-mediated conversion of glucose to glucose-6-phosphate.</para>
    ///   <para>dcterms:description : is target in is a relation between an entity and a process, where the entity is present at the beginning  of the process and undergoes a change or transformation in the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000292">sio:SIO_000292</a>
    /// </summary>
    let SIO_000292 = _prefixId.prefix "SIO_000292"
    /// <summary>
    ///   <para>dcterms:description : is weakly interacting with is a symmetric relation between two molecular entities (or any part thereof) that are interacting through some weak force (van der waals, hydrogen bonds, electrostatic interactions)</para>
    ///   <para>dc11:identifier : SIO_000293^^xsd:string</para>
    ///   <para>rdfs:label : is weakly interacting with (transitive)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000293">sio:SIO_000293</a>
    /// </summary>
    let SIO_000293 = _prefixId.prefix "SIO_000293"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000294^^xsd:string</para>
    ///   <para>rdfs:label : is causally related to</para>
    ///   <para>dcterms:description : a is causally related to b iff there is a causal chain of events from a to b</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000294">sio:SIO_000294</a>
    /// </summary>
    let SIO_000294 = _prefixId.prefix "SIO_000294"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000295^^xsd:string</para>
    ///   <para>rdfs:label : collection of documents</para>
    ///   <para>sio:equivalentTo : http://purl.org/ontology/bibo/Collection^^xsd:string</para>
    ///   <para>dcterms:description : A collection of documents is a non-zero set of documents.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000295">sio:SIO_000295</a>
    /// </summary>
    let SIO_000295 = _prefixId.prefix "SIO_000295"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000296^^xsd:string</para>
    ///   <para>rdfs:label : website</para>
    ///   <para>dcterms:description : A website is a collection of documents published on the World Wide Web.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000296">sio:SIO_000296</a>
    /// </summary>
    let SIO_000296 = _prefixId.prefix "SIO_000296"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000297^^xsd:string</para>
    ///   <para>rdfs:label : movie</para>
    ///   <para>sio:hasSynonym : moving picturessio:hasSynonym : film</para>
    ///   <para>dcterms:description : A movie is a series of images that are displayed in rapid succession  to give the impression of movement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000297">sio:SIO_000297</a>
    /// </summary>
    let SIO_000297 = _prefixId.prefix "SIO_000297"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000298^^xsd:string</para>
    ///   <para>rdfs:label : excerpt</para>
    ///   <para>dcterms:description : An excerpt is a contiguous or discontiguous portion of a document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000298">sio:SIO_000298</a>
    /// </summary>
    let SIO_000298 = _prefixId.prefix "SIO_000298"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000299^^xsd:string</para>
    ///   <para>rdfs:label : quote</para>
    ///   <para>dcterms:description : A quote is a excerpt that is attributed to a particular source.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000299">sio:SIO_000299</a>
    /// </summary>
    let SIO_000299 = _prefixId.prefix "SIO_000299"
    /// <summary>
    ///   <para>sio:subset : relations^^xsd:stringsio:subset : core^^xsd:stringsio:subset : sadisio:subset : nlp^^xsd:string</para>
    ///   <para>dc11:identifier : SIO_000300^^xsd:string</para>
    ///   <para>rdfs:label : has value</para>
    ///   <para>dcterms:description : A relation between a informational entity and its actual value (numeric, date, text, etc).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000300">sio:SIO_000300</a>
    /// </summary>
    let SIO_000300 = _prefixId.prefix "SIO_000300"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000301^^xsd:string</para>
    ///   <para>rdfs:label : geographic image</para>
    ///   <para>dcterms:description : A geographic image is a photograph of some geographical area.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000301">sio:SIO_000301</a>
    /// </summary>
    let SIO_000301 = _prefixId.prefix "SIO_000301"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000302^^xsd:string</para>
    ///   <para>rdfs:label : web page</para>
    ///   <para>dcterms:description : A web page is a document that is published according to World Wide Web standards.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000302">sio:SIO_000302</a>
    /// </summary>
    let SIO_000302 = _prefixId.prefix "SIO_000302"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000304^^xsd:string</para>
    ///   <para>rdfs:label : email</para>
    ///   <para>dcterms:description : Email message is a digital document that is composed of a header and a body and is transmitted using the SMTP protocol.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000304">sio:SIO_000304</a>
    /// </summary>
    let SIO_000304 = _prefixId.prefix "SIO_000304"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000305^^xsd:string</para>
    ///   <para>rdfs:label : process number</para>
    ///   <para>dcterms:description : process number is a number associated with a process that denotes its ordinal position in a set of processes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000305">sio:SIO_000305</a>
    /// </summary>
    let SIO_000305 = _prefixId.prefix "SIO_000305"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000306^^xsd:string</para>
    ///   <para>rdfs:label : letter</para>
    ///   <para>dcterms:description : A letter is a document that contains a personal communication from one part to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000306">sio:SIO_000306</a>
    /// </summary>
    let SIO_000306 = _prefixId.prefix "SIO_000306"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000307^^xsd:string</para>
    ///   <para>rdfs:label : normality</para>
    ///   <para>dcterms:description : normality is the quality in which the value may differ from normal or average</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000307">sio:SIO_000307</a>
    /// </summary>
    let SIO_000307 = _prefixId.prefix "SIO_000307"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000308^^xsd:string</para>
    ///   <para>rdfs:label : edition number</para>
    ///   <para>dcterms:description : An edition number is count of a literary work edited and published, as by a certain editor or in a certain manner including being printed during some interval of time.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000308">sio:SIO_000308</a>
    /// </summary>
    let SIO_000308 = _prefixId.prefix "SIO_000308"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000309^^xsd:string</para>
    ///   <para>rdfs:label : volume number</para>
    ///   <para>dcterms:description : volume number is a count of a sequence of periodicals.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000309">sio:SIO_000309</a>
    /// </summary>
    let SIO_000309 = _prefixId.prefix "SIO_000309"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000310^^xsd:string</para>
    ///   <para>rdfs:label : is direct part of</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : is direct part of is a relation between a specific part (at some level of granularity) and its whole.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000310">sio:SIO_000310</a>
    /// </summary>
    let SIO_000310 = _prefixId.prefix "SIO_000310"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000311^^xsd:string</para>
    ///   <para>rdfs:label : is product of</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>sio:example : glucose-6-phosphate is the product of the hexokinase-mediated conversion of glucose to glucose-6-phosphate.</para>
    ///   <para>dcterms:description : is product of is a relation between an entity and a process, where the entity is present at the end  of the process as a result of a transformation in the process target.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000311">sio:SIO_000311</a>
    /// </summary>
    let SIO_000311 = _prefixId.prefix "SIO_000311"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000312^^xsd:string</para>
    ///   <para>rdfs:label : has product</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>dcterms:description : has product is a relation between an process and an entity, where a new entity exists at the end of the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000312">sio:SIO_000312</a>
    /// </summary>
    let SIO_000312 = _prefixId.prefix "SIO_000312"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000313^^xsd:string</para>
    ///   <para>rdfs:label : is component part of</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : is component part of is a relation between a component and a whole, where the component is instrinsic to the whole, and loss of the part would change the kind that the whole is.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000313">sio:SIO_000313</a>
    /// </summary>
    let SIO_000313 = _prefixId.prefix "SIO_000313"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000314^^xsd:string</para>
    ///   <para>rdfs:label : polymer</para>
    ///   <para>dcterms:description : A polymer is a molecule composed of a connected set of monomeric residues.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000314">sio:SIO_000314</a>
    /// </summary>
    let SIO_000314 = _prefixId.prefix "SIO_000314"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000315^^xsd:string</para>
    ///   <para>rdfs:label : functional specification</para>
    ///   <para>dcterms:description : A functional specification is a specification that describes the characteristics of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000315">sio:SIO_000315</a>
    /// </summary>
    let SIO_000315 = _prefixId.prefix "SIO_000315"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000316^^xsd:string</para>
    ///   <para>rdfs:label : design specification</para>
    ///   <para>dcterms:description : A design specification is a specification that provides precise and explicit information about the requirements for a product design.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000316">sio:SIO_000316</a>
    /// </summary>
    let SIO_000316 = _prefixId.prefix "SIO_000316"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000317^^xsd:string</para>
    ///   <para>rdfs:label : spatial specification</para>
    ///   <para>dcterms:description : A specification for spatial location is an effective specification towards representation spatial position or spatial data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000317">sio:SIO_000317</a>
    /// </summary>
    let SIO_000317 = _prefixId.prefix "SIO_000317"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000318^^xsd:string</para>
    ///   <para>rdfs:label : longitude</para>
    ///   <para>dcterms:description : Longitude is a geographic position that refers to  the angle east or west of a reference meridian between the two geographical poles to another meridian that passes through an arbitrary point.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000318">sio:SIO_000318</a>
    /// </summary>
    let SIO_000318 = _prefixId.prefix "SIO_000318"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000319^^xsd:string</para>
    ///   <para>rdfs:label : latitude</para>
    ///   <para>dcterms:description : Latitude is a geographic coordinate which refers to the angle from a point on the Earth's surface to the equatorial plane</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000319">sio:SIO_000319</a>
    /// </summary>
    let SIO_000319 = _prefixId.prefix "SIO_000319"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000320^^xsd:string</para>
    ///   <para>rdfs:label : coordinate system</para>
    ///   <para>dcterms:description : A coordinate system is a specification for spatial location that uses a set of numbers, or coordinates, to uniquely determine the position of a point or other geometric element.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000320">sio:SIO_000320</a>
    /// </summary>
    let SIO_000320 = _prefixId.prefix "SIO_000320"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000321^^xsd:string</para>
    ///   <para>rdfs:label : cartesian coordinate system</para>
    ///   <para>dcterms:description : A Cartesian coordinate system specifies each point uniquely in a plane by a pair of numerical coordinates, which are the signed distances from the point to two fixed perpendicular directed lines, measured in the same unit of length.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000321">sio:SIO_000321</a>
    /// </summary>
    let SIO_000321 = _prefixId.prefix "SIO_000321"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000322^^xsd:string</para>
    ///   <para>rdfs:label : is spatiotemporally related to</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A is spatiotemporally related to B iff A is in the spatial or temporal vicinity of B</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000322">sio:SIO_000322</a>
    /// </summary>
    let SIO_000322 = _prefixId.prefix "SIO_000322"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000323^^xsd:string</para>
    ///   <para>rdfs:label : is surrounded by</para>
    ///   <para>dcterms:description : A 'is surrounded by' B iff the A 'is contained by' B and A 'is adjacent to' B or A 'is directly connected to' B.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000323">sio:SIO_000323</a>
    /// </summary>
    let SIO_000323 = _prefixId.prefix "SIO_000323"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000324^^xsd:string</para>
    ///   <para>rdfs:label : surrounds</para>
    ///   <para>dcterms:description : A 'surrounds' B iff the A 'contains' B and A 'is adjacent to' B or A 'is directly connected to' B.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000324">sio:SIO_000324</a>
    /// </summary>
    let SIO_000324 = _prefixId.prefix "SIO_000324"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000325^^xsd:string</para>
    ///   <para>rdfs:label : overlaps with</para>
    ///   <para>dcterms:description : A overlaps with B iff there is some C that is part of both A and B. [S][R]</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000325">sio:SIO_000325</a>
    /// </summary>
    let SIO_000325 = _prefixId.prefix "SIO_000325"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000326^^xsd:string</para>
    ///   <para>rdfs:label : concept</para>
    ///   <para>dcterms:description : A concept is term that refers to a generalization of a set of attributes or entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000326">sio:SIO_000326</a>
    /// </summary>
    let SIO_000326 = _prefixId.prefix "SIO_000326"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000327^^xsd:string</para>
    ///   <para>rdfs:label : polar coordinate system</para>
    ///   <para>dcterms:description : A polar coordinate system is a two-dimensional coordinate system in which each point on a plane is determined by a distance from a fixed point and an angle from a fixed direction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000327">sio:SIO_000327</a>
    /// </summary>
    let SIO_000327 = _prefixId.prefix "SIO_000327"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000328^^xsd:string</para>
    ///   <para>rdfs:label : positional identifier</para>
    ///   <para>dcterms:description : A positional description is a description of location using some system or frame of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000328">sio:SIO_000328</a>
    /// </summary>
    let SIO_000328 = _prefixId.prefix "SIO_000328"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000329^^xsd:string</para>
    ///   <para>rdfs:label : cylindrical coordinate system</para>
    ///   <para>dcterms:description : A cylindrical coordinate system is a three-dimensional coordinate system that specifies point positions by the distance from a chosen reference axis, the direction from the axis relative to a chosen reference direction, and the distance from a chosen reference plane perpendicular to the axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000329">sio:SIO_000329</a>
    /// </summary>
    let SIO_000329 = _prefixId.prefix "SIO_000329"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000330^^xsd:string</para>
    ///   <para>rdfs:label : spherical coordinate system</para>
    ///   <para>dcterms:description : A spherical coordinate system is a coordinate system for three-dimensional space where the position of a point is specified by three numbers: the radial distance of that point from a fixed origin, its polar angle measured from a fixed zenith direction, and the azimuth angle of its orthogonal projection on a reference plane that passes through the origin and is orthogonal to the zenith, measured from a fixed reference direction on that plane.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000330">sio:SIO_000330</a>
    /// </summary>
    let SIO_000330 = _prefixId.prefix "SIO_000330"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000331^^xsd:string</para>
    ///   <para>rdfs:label : OWL ontology</para>
    ///   <para>dcterms:description : An OWL ontology is an ontology as specified by the W3C OWL specification.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000331">sio:SIO_000331</a>
    /// </summary>
    let SIO_000331 = _prefixId.prefix "SIO_000331"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000332^^xsd:string</para>
    ///   <para>rdfs:label : is about</para>
    ///   <para>dcterms:description : is about is a relation between an information content entity and the entity that its primary subject.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000332">sio:SIO_000332</a>
    /// </summary>
    let SIO_000332 = _prefixId.prefix "SIO_000332"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000333^^xsd:string</para>
    ///   <para>rdfs:label : 3D cartesian coordinate</para>
    ///   <para>dcterms:description : A 3D cartesian coordinate is a coordinate that is composed of an x, y and z coordinate.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000333">sio:SIO_000333</a>
    /// </summary>
    let SIO_000333 = _prefixId.prefix "SIO_000333"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000334^^xsd:string</para>
    ///   <para>rdfs:label : is covalently connected to</para>
    ///   <para>dcterms:description : is covalently connected to is a relation between an atom and another atom.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000334">sio:SIO_000334</a>
    /// </summary>
    let SIO_000334 = _prefixId.prefix "SIO_000334"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000335^^xsd:string</para>
    ///   <para>rdfs:label : is weakly interacting with</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000335">sio:SIO_000335</a>
    /// </summary>
    let SIO_000335 = _prefixId.prefix "SIO_000335"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000337^^xsd:string</para>
    ///   <para>rdfs:label : objective</para>
    ///   <para>dcterms:description : An objective is a proposition that indicates a planned or anticipated outcome.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000337">sio:SIO_000337</a>
    /// </summary>
    let SIO_000337 = _prefixId.prefix "SIO_000337"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000338^^xsd:string</para>
    ///   <para>rdfs:label : specifies</para>
    ///   <para>dcterms:description : A relation between an information content entity and a product that it (directly/indirectly) specifies</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000338">sio:SIO_000338</a>
    /// </summary>
    let SIO_000338 = _prefixId.prefix "SIO_000338"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000339^^xsd:string</para>
    ///   <para>rdfs:label : is specified by</para>
    ///   <para>dcterms:description : a relation between a product and the information content entity that specifies it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000339">sio:SIO_000339</a>
    /// </summary>
    let SIO_000339 = _prefixId.prefix "SIO_000339"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000340^^xsd:string</para>
    ///   <para>rdfs:label : realizable entity</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : A realizable entity is an attribute that is exhibited under some condition and is realized in some process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000340">sio:SIO_000340</a>
    /// </summary>
    let SIO_000340 = _prefixId.prefix "SIO_000340"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000341^^xsd:string</para>
    ///   <para>rdfs:label : is manifested as</para>
    ///   <para>sio:example : the english language version of 'war of the worlds' is manifested as a collection of english language versions of the book.</para>
    ///   <para>dcterms:description : is manifested as is a relation between an expression and its manifestations.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000341">sio:SIO_000341</a>
    /// </summary>
    let SIO_000341 = _prefixId.prefix "SIO_000341"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000342^^xsd:string</para>
    ///   <para>rdfs:label : term variant</para>
    ///   <para>dcterms:description : A term variant is a term that is a variant of another term.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000342">sio:SIO_000342</a>
    /// </summary>
    let SIO_000342 = _prefixId.prefix "SIO_000342"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000343^^xsd:string</para>
    ///   <para>rdfs:label : to modify</para>
    ///   <para>dcterms:description : to modify is the capability to change some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000343">sio:SIO_000343</a>
    /// </summary>
    let SIO_000343 = _prefixId.prefix "SIO_000343"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000344^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://purl.obolibrary.org/obo/OBI_0000368^^xsd:anyURI</para>
    ///   <para>rdfs:label : to record</para>
    ///   <para>dcterms:description : to record is the capability to detect and transcribe information in a specified format on some physical medium.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000344">sio:SIO_000344</a>
    /// </summary>
    let SIO_000344 = _prefixId.prefix "SIO_000344"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000345^^xsd:string</para>
    ///   <para>rdfs:label : to magnify</para>
    ///   <para>dcterms:description : to magnify is the capability to increase the appearance of the size of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000345">sio:SIO_000345</a>
    /// </summary>
    let SIO_000345 = _prefixId.prefix "SIO_000345"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000346^^xsd:string</para>
    ///   <para>rdfs:label : to heat</para>
    ///   <para>dcterms:description : to heat is a capability to increase the internal kinetic energy of a material.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000346">sio:SIO_000346</a>
    /// </summary>
    let SIO_000346 = _prefixId.prefix "SIO_000346"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000347^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://purl.obolibrary.org/obo/OBI_0000387^^xsd:anyURI</para>
    ///   <para>rdfs:label : to cool</para>
    ///   <para>dcterms:description : to cool is the capability to decrease the internal kinetic energy of a material.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000347">sio:SIO_000347</a>
    /// </summary>
    let SIO_000347 = _prefixId.prefix "SIO_000347"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000348^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://purl.obolibrary.org/obo/OBI_0000375^^xsd:anyURI</para>
    ///   <para>rdfs:label : to freeze</para>
    ///   <para>dcterms:description : to freeze is the capability to decrease the internal kinetic energy of a material such that it changes state from a gas or liquid to a solid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000348">sio:SIO_000348</a>
    /// </summary>
    let SIO_000348 = _prefixId.prefix "SIO_000348"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000349^^xsd:string</para>
    ///   <para>rdfs:label : to separate</para>
    ///   <para>dcterms:description : to separate is the capability to i) distinguish some entities based on some attribute(s) and ii) subsequently physically displace them.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000349">sio:SIO_000349</a>
    /// </summary>
    let SIO_000349 = _prefixId.prefix "SIO_000349"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000350^^xsd:string</para>
    ///   <para>rdfs:label : to ionize</para>
    ///   <para>dcterms:description : to ionize is the capability to physically convert an atom or molecule into an ion by adding or removing charged particles such as electrons or other ions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000350">sio:SIO_000350</a>
    /// </summary>
    let SIO_000350 = _prefixId.prefix "SIO_000350"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000351^^xsd:string</para>
    ///   <para>rdfs:label : to supply energy</para>
    ///   <para>dcterms:description : to supply energy is the capability to transfer energy from a source to a sink.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000351">sio:SIO_000351</a>
    /// </summary>
    let SIO_000351 = _prefixId.prefix "SIO_000351"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000352^^xsd:string</para>
    ///   <para>rdfs:label : is causally related from</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : a is causally related from b iff there is a causal chain of events from b to a</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000352">sio:SIO_000352</a>
    /// </summary>
    let SIO_000352 = _prefixId.prefix "SIO_000352"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000353^^xsd:string</para>
    ///   <para>rdfs:label : to observe</para>
    ///   <para>dcterms:description : to observe is the capability to watch attentively.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000353">sio:SIO_000353</a>
    /// </summary>
    let SIO_000353 = _prefixId.prefix "SIO_000353"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000354^^xsd:string</para>
    ///   <para>rdfs:label : dysfunction</para>
    ///   <para>dcterms:description : dysfunction is a capability to act in a manner that is abnormal or opposite  to the object's typical function.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000354">sio:SIO_000354</a>
    /// </summary>
    let SIO_000354 = _prefixId.prefix "SIO_000354"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000355^^xsd:string</para>
    ///   <para>rdfs:label : realizes</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : realizes is a relation between a process and a realizable entity (role, function, disposition).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000355">sio:SIO_000355</a>
    /// </summary>
    let SIO_000355 = _prefixId.prefix "SIO_000355"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000356^^xsd:string</para>
    ///   <para>rdfs:label : is realized in</para>
    ///   <para>sio:example : the role of a patient is realized in medical examination</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000356">sio:SIO_000356</a>
    /// </summary>
    let SIO_000356 = _prefixId.prefix "SIO_000356"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000357^^xsd:string</para>
    ///   <para>rdfs:label : fitness</para>
    ///   <para>dcterms:description : fitness is the quality of an object with respect to some stated functions or evolutionary adaptation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000357">sio:SIO_000357</a>
    /// </summary>
    let SIO_000357 = _prefixId.prefix "SIO_000357"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000358^^xsd:string</para>
    ///   <para>rdfs:label : intent</para>
    ///   <para>dcterms:description : intent is a desire to realize a particular outcome.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000358">sio:SIO_000358</a>
    /// </summary>
    let SIO_000358 = _prefixId.prefix "SIO_000358"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000359^^xsd:string</para>
    ///   <para>rdfs:label : purpose</para>
    ///   <para>dcterms:description : purpose is the reason for which something is done or created or for which something exists.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000359">sio:SIO_000359</a>
    /// </summary>
    let SIO_000359 = _prefixId.prefix "SIO_000359"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000360^^xsd:string</para>
    ///   <para>rdfs:label : belief</para>
    ///   <para>dcterms:description : A belief is a proposition that is believed to be true.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000360">sio:SIO_000360</a>
    /// </summary>
    let SIO_000360 = _prefixId.prefix "SIO_000360"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000362^^xsd:string</para>
    ///   <para>rdfs:label : satisfies</para>
    ///   <para>dcterms:description : satisfies is a relation between an entity and the specification or objective that it conforms to.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000362">sio:SIO_000362</a>
    /// </summary>
    let SIO_000362 = _prefixId.prefix "SIO_000362"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000363^^xsd:string</para>
    ///   <para>rdfs:label : is satisfied by</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000363">sio:SIO_000363</a>
    /// </summary>
    let SIO_000363 = _prefixId.prefix "SIO_000363"
    /// <summary>
    ///   <para>sio:equivalentTo : dc:creator^^xsd:string</para>
    ///   <para>rdfs:label : has creator</para>
    ///   <para>sio:hasSynonym : was created bysio:hasSynonym : is created by</para>
    ///   <para>sio:example : the iPhone was created by Apple Inc</para>
    ///   <para>dcterms:description : has creator is a relation between an entity and that which created it.</para>
    ///   <para>dc11:identifier : SIO_000364^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000364">sio:SIO_000364</a>
    /// </summary>
    let SIO_000364 = _prefixId.prefix "SIO_000364"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000365^^xsd:string</para>
    ///   <para>rdfs:label : is creator of</para>
    ///   <para>sio:hasSynonym : is created by</para>
    ///   <para>dcterms:description : is creator of is a relation between a creator and an entity..</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000365">sio:SIO_000365</a>
    /// </summary>
    let SIO_000365 = _prefixId.prefix "SIO_000365"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000366^^xsd:string</para>
    ///   <para>rdfs:label : number</para>
    ///   <para>dcterms:description : A number is a mathematical object used to count, label, and measure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000366">sio:SIO_000366</a>
    /// </summary>
    let SIO_000366 = _prefixId.prefix "SIO_000366"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000367^^xsd:string</para>
    ///   <para>rdfs:label : variable</para>
    ///   <para>dcterms:description : A variable is a value that may change within the scope of a given problem or set of operations.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000367">sio:SIO_000367</a>
    /// </summary>
    let SIO_000367 = _prefixId.prefix "SIO_000367"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000368^^xsd:string</para>
    ///   <para>rdfs:label : equation</para>
    ///   <para>dcterms:description : An equation is a mathematical statement that asserts the equality of two expressions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000368">sio:SIO_000368</a>
    /// </summary>
    let SIO_000368 = _prefixId.prefix "SIO_000368"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000369^^xsd:string</para>
    ///   <para>rdfs:label : has component part</para>
    ///   <para>sio:example : a human has blood as a component part</para>
    ///   <para>dcterms:description : has component part is a relation between a whole and a component part where the component is instrinsic to the whole, and loss of the part would change the kind that it is.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000369">sio:SIO_000369</a>
    /// </summary>
    let SIO_000369 = _prefixId.prefix "SIO_000369"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000370^^xsd:string</para>
    ///   <para>rdfs:label : spatial region</para>
    ///   <para>sio:hasSynonym : region^^xsd:string</para>
    ///   <para>sio:example : The airspace above Ottawa airport; the band around the northern hemisphere between 50 degrees N and 60 degrees N; the spatial region occupied by a bottle.</para>
    ///   <para>dcterms:description : A spatial region is an object contained in some region of space.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000370">sio:SIO_000370</a>
    /// </summary>
    let SIO_000370 = _prefixId.prefix "SIO_000370"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000371^^xsd:string</para>
    ///   <para>rdfs:label : to measure</para>
    ///   <para>dcterms:description : to measure is the capability to obtain information about some entity by examining its attributes in relation to some reference metric.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000371">sio:SIO_000371</a>
    /// </summary>
    let SIO_000371 = _prefixId.prefix "SIO_000371"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000372^^xsd:string</para>
    ///   <para>rdfs:label : to inject</para>
    ///   <para>dcterms:description : to inject is the capability to administer a substance into some object through its external barrier.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000372">sio:SIO_000372</a>
    /// </summary>
    let SIO_000372 = _prefixId.prefix "SIO_000372"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000373^^xsd:string</para>
    ///   <para>rdfs:label : to boil</para>
    ///   <para>dcterms:description : to boil is the capability to increase the internal kinetic energy of a material such that it changes state from a solid or liquid to a gas.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000373">sio:SIO_000373</a>
    /// </summary>
    let SIO_000373 = _prefixId.prefix "SIO_000373"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000374^^xsd:string</para>
    ///   <para>rdfs:label : to reduce energy</para>
    ///   <para>dcterms:description : to reduce energy is the capability to remove energy from a source.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000374">sio:SIO_000374</a>
    /// </summary>
    let SIO_000374 = _prefixId.prefix "SIO_000374"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000375^^xsd:string</para>
    ///   <para>rdfs:label : to supply electricity</para>
    ///   <para>dcterms:description : to supply electricity is the capability to transfer electricity from a source to a sink.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000375">sio:SIO_000375</a>
    /// </summary>
    let SIO_000375 = _prefixId.prefix "SIO_000375"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000376^^xsd:string</para>
    ///   <para>rdfs:label : to change materially</para>
    ///   <para>dcterms:description : to change appearance is the capability to change the material composition of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000376">sio:SIO_000376</a>
    /// </summary>
    let SIO_000376 = _prefixId.prefix "SIO_000376"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000377^^xsd:string</para>
    ///   <para>rdfs:label : to demagnify</para>
    ///   <para>dcterms:description : to demagnify is the capability to decrease the appearance of the size of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000377">sio:SIO_000377</a>
    /// </summary>
    let SIO_000377 = _prefixId.prefix "SIO_000377"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000378^^xsd:string</para>
    ///   <para>rdfs:label : to change appearance</para>
    ///   <para>dcterms:description : to change appearance is the capability to change the visual attributes of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000378">sio:SIO_000378</a>
    /// </summary>
    let SIO_000378 = _prefixId.prefix "SIO_000378"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000379^^xsd:string</para>
    ///   <para>rdfs:label : perception</para>
    ///   <para>dcterms:description : perception is the organization, identification, and interpretation of sensory information in order to fabricate a mental representation through the process of transduction, which sensors in the body transform signals from the environment into encoded neural signals.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000379">sio:SIO_000379</a>
    /// </summary>
    let SIO_000379 = _prefixId.prefix "SIO_000379"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000380^^xsd:string</para>
    ///   <para>rdfs:label : to contain</para>
    ///   <para>dcterms:description : to contain is the capability to bound or constrain a physical entity in some site.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000380">sio:SIO_000380</a>
    /// </summary>
    let SIO_000380 = _prefixId.prefix "SIO_000380"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000381^^xsd:string</para>
    ///   <para>rdfs:label : to immobilize</para>
    ///   <para>dcterms:description : to immobilize is the capability to contain an entity in such a way that it may not move in space.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000381">sio:SIO_000381</a>
    /// </summary>
    let SIO_000381 = _prefixId.prefix "SIO_000381"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000382^^xsd:string</para>
    ///   <para>rdfs:label : to filter</para>
    ///   <para>dcterms:description : to filter is the capability to retain certain entities based on selected attribute(s) while allowing other entities to pass through.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000382">sio:SIO_000382</a>
    /// </summary>
    let SIO_000382 = _prefixId.prefix "SIO_000382"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000383^^xsd:string</para>
    ///   <para>rdfs:label : to excite</para>
    ///   <para>dcterms:description : to excite is the capability to supply energy to a materila by bombarding it with energetic particles (e.g., photons).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000383">sio:SIO_000383</a>
    /// </summary>
    let SIO_000383 = _prefixId.prefix "SIO_000383"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000384^^xsd:string</para>
    ///   <para>rdfs:label : to emit</para>
    ///   <para>dcterms:description : to emit is the capability to release some physical entity (light, pollution, etc).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000384">sio:SIO_000384</a>
    /// </summary>
    let SIO_000384 = _prefixId.prefix "SIO_000384"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000385^^xsd:string</para>
    ///   <para>rdfs:label : to change energetically</para>
    ///   <para>dcterms:description : to change energetically is the capability to change the energetic aspects of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000385">sio:SIO_000385</a>
    /// </summary>
    let SIO_000385 = _prefixId.prefix "SIO_000385"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000386^^xsd:string</para>
    ///   <para>rdfs:label : to positively charge</para>
    ///   <para>dcterms:description : to positively charge is the capability to remove an electron or add a  positively charged ion to a chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000386">sio:SIO_000386</a>
    /// </summary>
    let SIO_000386 = _prefixId.prefix "SIO_000386"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000387^^xsd:string</para>
    ///   <para>rdfs:label : to negatively charge</para>
    ///   <para>dcterms:description : to negatively charge is the capability to add an electron or negatively charged ion to a chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000387">sio:SIO_000387</a>
    /// </summary>
    let SIO_000387 = _prefixId.prefix "SIO_000387"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000388^^xsd:string</para>
    ///   <para>rdfs:label : to assemble</para>
    ///   <para>dcterms:description : to assemble is the capability to combine entities together into a larger object that persists in time.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000388">sio:SIO_000388</a>
    /// </summary>
    let SIO_000388 = _prefixId.prefix "SIO_000388"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000389^^xsd:string</para>
    ///   <para>rdfs:label : to extract</para>
    ///   <para>dcterms:description : to extract is the capability to remove certain entities based on selected attribute(s) while allowing other entities to remain.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000389">sio:SIO_000389</a>
    /// </summary>
    let SIO_000389 = _prefixId.prefix "SIO_000389"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000390^^xsd:string</para>
    ///   <para>rdfs:label : to transport</para>
    ///   <para>dcterms:description : to transport is the capability to displace a material from one location to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000390">sio:SIO_000390</a>
    /// </summary>
    let SIO_000390 = _prefixId.prefix "SIO_000390"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000391^^xsd:string</para>
    ///   <para>rdfs:label : time measurement</para>
    ///   <para>sio:example : the duration of my life; the duration of a surgical procedure, the moment of death</para>
    ///   <para>schema:comment : Time intervals are specified as date/datetime ranges.^^xsd:string</para>
    ///   <para>dcterms:description : time measurement is a measurement value of the duration of some interval of time or a particular instant of time (against some frame of reference).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000391">sio:SIO_000391</a>
    /// </summary>
    let SIO_000391 = _prefixId.prefix "SIO_000391"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000392^^xsd:string</para>
    ///   <para>rdfs:label : to change spatially</para>
    ///   <para>dcterms:description : to change spatially is the capability to affect the physical movement of some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000392">sio:SIO_000392</a>
    /// </summary>
    let SIO_000392 = _prefixId.prefix "SIO_000392"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000393^^xsd:string</para>
    ///   <para>rdfs:label : patient</para>
    ///   <para>dcterms:description : A patient is an individual that is the recepient of medical care.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000393">sio:SIO_000393</a>
    /// </summary>
    let SIO_000393 = _prefixId.prefix "SIO_000393"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000394^^xsd:string</para>
    ///   <para>rdfs:label : doctor</para>
    ///   <para>dcterms:description : A doctor is an individual who practices medicine, which is concerned with promoting, maintaining or restoring human health through the study, diagnosis, and treatment of disease, injury, and other physical and mental impairments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000394">sio:SIO_000394</a>
    /// </summary>
    let SIO_000394 = _prefixId.prefix "SIO_000394"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000395^^xsd:string</para>
    ///   <para>rdfs:label : to regulate</para>
    ///   <para>sio:hasSynonym : to modulate</para>
    ///   <para>dcterms:description : to regulate is to control or maintain the rate or speed of an object or process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000395">sio:SIO_000395</a>
    /// </summary>
    let SIO_000395 = _prefixId.prefix "SIO_000395"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000396^^xsd:string</para>
    ///   <para>rdfs:label : file</para>
    ///   <para>dcterms:description : A file is an information-bearing object that contains a physical embodiment of some information using a particular character encoding.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000396">sio:SIO_000396</a>
    /// </summary>
    let SIO_000396 = _prefixId.prefix "SIO_000396"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000397^^xsd:string</para>
    ///   <para>rdfs:label : to provide</para>
    ///   <para>dcterms:description : to provide is the capability to make available some object to another that requires it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000397">sio:SIO_000397</a>
    /// </summary>
    let SIO_000397 = _prefixId.prefix "SIO_000397"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000398^^xsd:string</para>
    ///   <para>rdfs:label : nurse</para>
    ///   <para>dcterms:description : A nurse is an individual that is involved in the protection, promotion, and optimization of health and abilities, prevention of illness and injury, alleviation of suffering through the diagnosis and treatment of human response, and advocacy in the care of individuals, families, communities, and populations.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000398">sio:SIO_000398</a>
    /// </summary>
    let SIO_000398 = _prefixId.prefix "SIO_000398"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000399^^xsd:string</para>
    ///   <para>rdfs:label : study subject</para>
    ///   <para>dcterms:description : A study subject is an individual that is the subject of the study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000399">sio:SIO_000399</a>
    /// </summary>
    let SIO_000399 = _prefixId.prefix "SIO_000399"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000400^^xsd:string</para>
    ///   <para>rdfs:label : x cartesian coordinate</para>
    ///   <para>dcterms:description : An x cartesian coordinate is the coordinate of an object onto the x-axis of a cartesian coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000400">sio:SIO_000400</a>
    /// </summary>
    let SIO_000400 = _prefixId.prefix "SIO_000400"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000401^^xsd:string</para>
    ///   <para>rdfs:label : y cartesian coordinate</para>
    ///   <para>dcterms:description : An y cartesian coordinate is the coordinate of an object onto the y-axis of a cartesian coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000401">sio:SIO_000401</a>
    /// </summary>
    let SIO_000401 = _prefixId.prefix "SIO_000401"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000402^^xsd:string</para>
    ///   <para>rdfs:label : z cartesian coordinate</para>
    ///   <para>dcterms:description : A z cartesian coordinate is the coordinate of an object onto the z-axis of a cartesian coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000402">sio:SIO_000402</a>
    /// </summary>
    let SIO_000402 = _prefixId.prefix "SIO_000402"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000403^^xsd:string</para>
    ///   <para>rdfs:label : study group</para>
    ///   <para>dcterms:description : A study group is a group of individuals that are subjects in an observational or intervention study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000403">sio:SIO_000403</a>
    /// </summary>
    let SIO_000403 = _prefixId.prefix "SIO_000403"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000404^^xsd:string</para>
    ///   <para>rdfs:label : professor</para>
    ///   <para>dcterms:description : A professor is an individual that is a scholarly teacher.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000404">sio:SIO_000404</a>
    /// </summary>
    let SIO_000404 = _prefixId.prefix "SIO_000404"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000405^^xsd:string</para>
    ///   <para>rdfs:label : student</para>
    ///   <para>dcterms:description : A student is an individual who is attends an educational institution.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000405">sio:SIO_000405</a>
    /// </summary>
    let SIO_000405 = _prefixId.prefix "SIO_000405"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000406^^xsd:string</para>
    ///   <para>rdfs:label : academic</para>
    ///   <para>dcterms:description : An academic is an individual that participates in education and scholarship.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000406">sio:SIO_000406</a>
    /// </summary>
    let SIO_000406 = _prefixId.prefix "SIO_000406"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000407^^xsd:string</para>
    ///   <para>rdfs:label : to increase the rate of formation</para>
    ///   <para>dcterms:description : to increase the rate of formation is to regulate the rate of formation in a manner that increases this rate relative to a reference process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000407">sio:SIO_000407</a>
    /// </summary>
    let SIO_000407 = _prefixId.prefix "SIO_000407"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000408^^xsd:string</para>
    ///   <para>rdfs:label : to investigate</para>
    ///   <para>dcterms:description : to investigate is the capability to uncover facts.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000408">sio:SIO_000408</a>
    /// </summary>
    let SIO_000408 = _prefixId.prefix "SIO_000408"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000409^^xsd:string</para>
    ///   <para>rdfs:label : mutual disposition</para>
    ///   <para>dcterms:description : A mutual disposition is a disposition that simulataneously invokes another disposition when realized.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000409">sio:SIO_000409</a>
    /// </summary>
    let SIO_000409 = _prefixId.prefix "SIO_000409"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000410^^xsd:string</para>
    ///   <para>rdfs:label : anger</para>
    ///   <para>dcterms:description : anger is disgust directed toward an equal status individual.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000410">sio:SIO_000410</a>
    /// </summary>
    let SIO_000410 = _prefixId.prefix "SIO_000410"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000411^^xsd:string</para>
    ///   <para>rdfs:label : hate</para>
    ///   <para>dcterms:description : Hate is a deep and emotional extreme dislike, directed against a certain object or class of objects. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000411">sio:SIO_000411</a>
    /// </summary>
    let SIO_000411 = _prefixId.prefix "SIO_000411"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000412^^xsd:string</para>
    ///   <para>rdfs:label : love</para>
    ///   <para>dcterms:description : love is an emotion of a strong affection and personal attachment.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000412">sio:SIO_000412</a>
    /// </summary>
    let SIO_000412 = _prefixId.prefix "SIO_000412"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000413^^xsd:string</para>
    ///   <para>rdfs:label : geolegal region</para>
    ///   <para>sio:example : The 50 kph zones in Ottawa; the geographic region occupied by France.</para>
    ///   <para>dcterms:description : A geolegal region is a geographic region which has causal powers confered by a legal entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000413">sio:SIO_000413</a>
    /// </summary>
    let SIO_000413 = _prefixId.prefix "SIO_000413"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000414^^xsd:string</para>
    ///   <para>rdfs:label : geographic region</para>
    ///   <para>sio:example : The spatial region occupied by the province of ontario; the spatial region occupied by a lake.</para>
    ///   <para>dcterms:description : A geographic region is a spatial region whose boundaries are typically defined against some material frame of reference (like the earth).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000414">sio:SIO_000414</a>
    /// </summary>
    let SIO_000414 = _prefixId.prefix "SIO_000414"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000415^^xsd:string</para>
    ///   <para>rdfs:label : geopolitical region</para>
    ///   <para>sio:example : The geographic region bounded by Canada; the spatial region occupied by the US embassy in Ottawa.</para>
    ///   <para>dcterms:description : a geopolitical region is a geographic region recognized by social or legal convention.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000415">sio:SIO_000415</a>
    /// </summary>
    let SIO_000415 = _prefixId.prefix "SIO_000415"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000417^^xsd:string</para>
    ///   <para>rdfs:label : time interval</para>
    ///   <para>dcterms:description : A time internval is a contiguous temporal region having some duration.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000417">sio:SIO_000417</a>
    /// </summary>
    let SIO_000417 = _prefixId.prefix "SIO_000417"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000418^^xsd:string</para>
    ///   <para>rdfs:label : time instant</para>
    ///   <para>sio:example : at this moment; the moment at which a finger is detached in an industrial accident; the moment at which a child is born; the moment of death</para>
    ///   <para>dcterms:description : A time instant is a temporal region which occurs instantaneously, e.g. having no duration.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000418">sio:SIO_000418</a>
    /// </summary>
    let SIO_000418 = _prefixId.prefix "SIO_000418"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000419^^xsd:string</para>
    ///   <para>rdfs:label : table</para>
    ///   <para>dcterms:description : A table is a figure that consists of an ordered arrangement of columns and rows.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000419">sio:SIO_000419</a>
    /// </summary>
    let SIO_000419 = _prefixId.prefix "SIO_000419"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000420^^xsd:string</para>
    ///   <para>rdfs:label : has expression</para>
    ///   <para>sio:example : the story 'war of worlds' is expressed as every language edition of the book 'war of the worlds'</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000420">sio:SIO_000420</a>
    /// </summary>
    let SIO_000420 = _prefixId.prefix "SIO_000420"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000421^^xsd:string</para>
    ///   <para>rdfs:label : is expression of</para>
    ///   <para>sio:example : every language edition of 'war of the worlds' are expressions of the story of 'war of the worlds'</para>
    ///   <para>dcterms:description : is expression of is a relation between more concrete expression of some conceptualization.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000421">sio:SIO_000421</a>
    /// </summary>
    let SIO_000421 = _prefixId.prefix "SIO_000421"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000422^^xsd:string</para>
    ///   <para>dcterms:description : A is broader than B (t) iff for A is broader than B.</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#narrowerTransitive^^xsd:string</para>
    ///   <para>rdfs:label : is broader than (t)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000422">sio:SIO_000422</a>
    /// </summary>
    let SIO_000422 = _prefixId.prefix "SIO_000422"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000423^^xsd:string</para>
    ///   <para>rdfs:label : scatterplot</para>
    ///   <para>sio:hasSynonym : scatter graphsio:hasSynonym : scatter diagramsio:hasSynonym : scatter chart</para>
    ///   <para>dcterms:description : A scatterplot is a statistical graph which uses Cartesian coordinates to display values for two variables for a set of data. The data is displayed as a collection of points, each having the value of one variable determining the position on the horizontal axis and the value of the other variable determining the position on the vertical axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000423">sio:SIO_000423</a>
    /// </summary>
    let SIO_000423 = _prefixId.prefix "SIO_000423"
    /// <summary>
    ///   <para>dcterms:description : A is narrower than B (t) iff for A is narrower than B.</para>
    ///   <para>dc11:identifier : SIO_000424^^xsd:string</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#broaderTransitive^^xsd:string</para>
    ///   <para>rdfs:label : is narrower than (t)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000424">sio:SIO_000424</a>
    /// </summary>
    let SIO_000424 = _prefixId.prefix "SIO_000424"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000425^^xsd:string</para>
    ///   <para>rdfs:label : is generically related with</para>
    ///   <para>dcterms:description : A is generically related with B iff A is an abstract entity or an information content entity and B is a information content entity or a physical entity, respectively.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000425">sio:SIO_000425</a>
    /// </summary>
    let SIO_000425 = _prefixId.prefix "SIO_000425"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000426^^xsd:string</para>
    ///   <para>rdfs:label : is manifestation of</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000426">sio:SIO_000426</a>
    /// </summary>
    let SIO_000426 = _prefixId.prefix "SIO_000426"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000427^^xsd:string</para>
    ///   <para>rdfs:label : is narrower than</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#broader^^xsd:string</para>
    ///   <para>dcterms:description : A is narrower than B iff the meaning of term A is narrower in scope than the meaning of term B</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000427">sio:SIO_000427</a>
    /// </summary>
    let SIO_000427 = _prefixId.prefix "SIO_000427"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000428^^xsd:string</para>
    ///   <para>rdfs:label : year</para>
    ///   <para>dcterms:description : A year is a period of time taken by a planet to make one revolution around the sun.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000428">sio:SIO_000428</a>
    /// </summary>
    let SIO_000428 = _prefixId.prefix "SIO_000428"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000429^^xsd:string</para>
    ///   <para>rdfs:label : month</para>
    ///   <para>dcterms:description : A month is a period of time that divides the year.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000429">sio:SIO_000429</a>
    /// </summary>
    let SIO_000429 = _prefixId.prefix "SIO_000429"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000430^^xsd:string</para>
    ///   <para>rdfs:label : day</para>
    ///   <para>dcterms:description : A day is a period of 24 hours.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000430">sio:SIO_000430</a>
    /// </summary>
    let SIO_000430 = _prefixId.prefix "SIO_000430"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000431^^xsd:string</para>
    ///   <para>rdfs:label : century</para>
    ///   <para>dcterms:description : A century is a period of one hundred years.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000431">sio:SIO_000431</a>
    /// </summary>
    let SIO_000431 = _prefixId.prefix "SIO_000431"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000432^^xsd:string</para>
    ///   <para>rdfs:label : millenium</para>
    ///   <para>dcterms:description : A millenium is a period of 1000 years</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000432">sio:SIO_000432</a>
    /// </summary>
    let SIO_000432 = _prefixId.prefix "SIO_000432"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000433^^xsd:string</para>
    ///   <para>rdfs:label : hour</para>
    ///   <para>dcterms:description : An hour is a period of 60 minutes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000433">sio:SIO_000433</a>
    /// </summary>
    let SIO_000433 = _prefixId.prefix "SIO_000433"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000434^^xsd:string</para>
    ///   <para>rdfs:label : minute</para>
    ///   <para>dcterms:description : A minute is a period of 60 seconds.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000434">sio:SIO_000434</a>
    /// </summary>
    let SIO_000434 = _prefixId.prefix "SIO_000434"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000435^^xsd:string</para>
    ///   <para>rdfs:label : second</para>
    ///   <para>dcterms:description : A second (symbol: s) is the base unit of time in the International System of Units (SI) and is the second division of the hour by sixty, the first division by 60 being the minute.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000435">sio:SIO_000435</a>
    /// </summary>
    let SIO_000435 = _prefixId.prefix "SIO_000435"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000436^^xsd:string</para>
    ///   <para>rdfs:label : informational quality</para>
    ///   <para>dcterms:description : An informational quality is a quality that pertains to information.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000436">sio:SIO_000436</a>
    /// </summary>
    let SIO_000436 = _prefixId.prefix "SIO_000436"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000437^^xsd:string</para>
    ///   <para>rdfs:label : 2D cartesian point</para>
    ///   <para>dcterms:description : A 2D cartesian point is a point whose position is specified along two  dimensions using Cartesian coordinates.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000437">sio:SIO_000437</a>
    /// </summary>
    let SIO_000437 = _prefixId.prefix "SIO_000437"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000438^^xsd:string</para>
    ///   <para>rdfs:label : altitude</para>
    ///   <para>dcterms:description : Altitude is a distance above sea level.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000438">sio:SIO_000438</a>
    /// </summary>
    let SIO_000438 = _prefixId.prefix "SIO_000438"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000439^^xsd:string</para>
    ///   <para>rdfs:label : center of mass</para>
    ///   <para>dcterms:description : The center of mass (aka barycenter) is the weighted average location of all the mass in a body or group of bodies.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000439">sio:SIO_000439</a>
    /// </summary>
    let SIO_000439 = _prefixId.prefix "SIO_000439"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000440^^xsd:string</para>
    ///   <para>rdfs:label : 3D cartesian point</para>
    ///   <para>dcterms:description : A 3D cartesian point is a point whose position is specified along three  dimensions using Cartesian coordinates.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000440">sio:SIO_000440</a>
    /// </summary>
    let SIO_000440 = _prefixId.prefix "SIO_000440"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000441^^xsd:string</para>
    ///   <para>rdfs:label : 1D cartesian point</para>
    ///   <para>dcterms:description : A 1D cartesian point is a point whose position is specified along a single dimension using Cartesian coordinates.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000441">sio:SIO_000441</a>
    /// </summary>
    let SIO_000441 = _prefixId.prefix "SIO_000441"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000442^^xsd:string</para>
    ///   <para>rdfs:label : line graph</para>
    ///   <para>sio:hasSynonym : line chart</para>
    ///   <para>sio:example : Graph 1 in http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A line graph is a statistical graph in which lines contains the evaluation of functions or individual points connected by line segments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000442">sio:SIO_000442</a>
    /// </summary>
    let SIO_000442 = _prefixId.prefix "SIO_000442"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000443^^xsd:string</para>
    ///   <para>rdfs:label : bar graph</para>
    ///   <para>sio:example : Graphs 3,4,5 in http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A bar graph is a statistical graph with rectangular bars of lengths proportional to that value that they represent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000443">sio:SIO_000443</a>
    /// </summary>
    let SIO_000443 = _prefixId.prefix "SIO_000443"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000444^^xsd:string</para>
    ///   <para>rdfs:label : horizontal bar graph</para>
    ///   <para>sio:example : Graph 3 in http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A horizontal bar graph is a bar graph in which the rectangular bars are horizontally oriented in space.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000444">sio:SIO_000444</a>
    /// </summary>
    let SIO_000444 = _prefixId.prefix "SIO_000444"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000445^^xsd:string</para>
    ///   <para>rdfs:label : vertical bar graph</para>
    ///   <para>sio:example : Graph 4,5 in http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A vertical bar graph is a bar graph in which the rectangular bars are vertically oriented in space.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000445">sio:SIO_000445</a>
    /// </summary>
    let SIO_000445 = _prefixId.prefix "SIO_000445"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000446^^xsd:string</para>
    ///   <para>rdfs:label : stacked bar graph</para>
    ///   <para>sio:example : Graphs 6,7 in http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A stacked bar graph is a bar graph in which each rectangular bar is partioned by the categorical value of each series of data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000446">sio:SIO_000446</a>
    /// </summary>
    let SIO_000446 = _prefixId.prefix "SIO_000446"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000447^^xsd:string</para>
    ///   <para>rdfs:label : line-bar graph</para>
    ///   <para>sio:example : Graph 8 in http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A line-bar graph statistical graph that contains both lines and bars.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000447">sio:SIO_000447</a>
    /// </summary>
    let SIO_000447 = _prefixId.prefix "SIO_000447"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000448^^xsd:string</para>
    ///   <para>rdfs:label : figure part</para>
    ///   <para>dcterms:description : A figure part is a part of a figure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000448">sio:SIO_000448</a>
    /// </summary>
    let SIO_000448 = _prefixId.prefix "SIO_000448"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000449^^xsd:string</para>
    ///   <para>rdfs:label : plot</para>
    ///   <para>sio:example : The square portion of the chart bounded by lines that overlap with
    /// the two axes in Graph 1 of http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A plot is a part of a figure that corresponds to the spatial region between the set of axes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000449">sio:SIO_000449</a>
    /// </summary>
    let SIO_000449 = _prefixId.prefix "SIO_000449"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000450^^xsd:string</para>
    ///   <para>rdfs:label : axis</para>
    ///   <para>sio:example : The left vertical and bottom horizontal lines with tickmarks in
    /// Graph 1 http://tinyurl.com/opwnvm</para>
    ///   <para>schema:comment : The value of a plotted geometric objects (e.g. point) can be obtained from the perpendicular projection of the position of the object onto the axis. Axis may also be associated with a textual description of what the values on the axis represents.^^xsd:string</para>
    ///   <para>dcterms:description : An axis is a line segment that is part of a statistical graph in which the
    /// position along the line corresponds to a numeric or categorical value.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000450">sio:SIO_000450</a>
    /// </summary>
    let SIO_000450 = _prefixId.prefix "SIO_000450"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000451^^xsd:string</para>
    ///   <para>rdfs:label : Cartesian coordinate axis</para>
    ///   <para>dcterms:description : A Cartesian coordinate axis is an axis whose behavior follows that of a Cartesian coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000451">sio:SIO_000451</a>
    /// </summary>
    let SIO_000451 = _prefixId.prefix "SIO_000451"
    /// <summary>
    ///   <para>sio:hasSynonym : horizontal axis^^xsd:string</para>
    ///   <para>dcterms:description : An x-axis is a Cartesian coordinate axis that is aligned with the horizon.</para>
    ///   <para>schema:comment : In most figures, this axis represents categories, such as months, market segments, or other non-numeric data.</para>
    ///   <para>sio:example : The horizontal axis in http://tinyurl.com/opwnvm</para>
    ///   <para>rdfs:label : x-axis</para>
    ///   <para>dc11:identifier : SIO_000452^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000452">sio:SIO_000452</a>
    /// </summary>
    let SIO_000452 = _prefixId.prefix "SIO_000452"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000453^^xsd:string</para>
    ///   <para>rdfs:label : y-axis</para>
    ///   <para>sio:hasSynonym : vertical axis^^xsd:string</para>
    ///   <para>dcterms:description : A y-axis is a Cartesian coordinate axis that is spatially oriented perpendicular to the x-axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000453">sio:SIO_000453</a>
    /// </summary>
    let SIO_000453 = _prefixId.prefix "SIO_000453"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000454^^xsd:string</para>
    ///   <para>rdfs:label : z-axis</para>
    ///   <para>dcterms:description : A z-axis is a Cartesian coordinate axis that is spatially oriented normal to the plane formed by the x- and y-axes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000454">sio:SIO_000454</a>
    /// </summary>
    let SIO_000454 = _prefixId.prefix "SIO_000454"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000455^^xsd:string</para>
    ///   <para>rdfs:label : category axis</para>
    ///   <para>sio:example : The horizontal axis corresponding to months of the year in graph 4
    /// of http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A category axis is an axis in which the position along the line is partioned into categories.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000455">sio:SIO_000455</a>
    /// </summary>
    let SIO_000455 = _prefixId.prefix "SIO_000455"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000456^^xsd:string</para>
    ///   <para>rdfs:label : primary category axis</para>
    ///   <para>sio:example : The category axis that corresponds to years in Graph 1 of
    /// http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A primary category axis is a category axis that either defines the sole value range or holds the larger set of categorical values specified by the secondary category axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000456">sio:SIO_000456</a>
    /// </summary>
    let SIO_000456 = _prefixId.prefix "SIO_000456"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000457^^xsd:string</para>
    ///   <para>rdfs:label : secondary category axis</para>
    ///   <para>sio:example : The category axis that corresponds to months in Graph 1 of
    /// http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A secondary category axis is a category axis that defines a finer granular part (or subset) of the value range of the primary category axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000457">sio:SIO_000457</a>
    /// </summary>
    let SIO_000457 = _prefixId.prefix "SIO_000457"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000458^^xsd:string</para>
    ///   <para>rdfs:label : value axis</para>
    ///   <para>sio:example : The value axis that ranges from 3.0 to 7.4 and corresponds to
    /// billions of dollars in Graph 1 of http://tinyurl.com/opwnvm</para>
    ///   <para>schema:comment : A value axis holds the properties of having a minimum and a maximum value, and is usually associated with tickmarks that indicate intervals along the axis.</para>
    ///   <para>dcterms:description : A value axis is an axis in which the position along the line is partioned into numeric values.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000458">sio:SIO_000458</a>
    /// </summary>
    let SIO_000458 = _prefixId.prefix "SIO_000458"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000459^^xsd:string</para>
    ///   <para>rdfs:label : left value axis</para>
    ///   <para>sio:example : The value axis that ranges from 3.0 to 7.4 and corresponds to billions of dollars in Graph 1 of http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A left value axis is a value axis that is spatially positioned to the left of the plot area.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000459">sio:SIO_000459</a>
    /// </summary>
    let SIO_000459 = _prefixId.prefix "SIO_000459"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000460^^xsd:string</para>
    ///   <para>rdfs:label : right value axis</para>
    ///   <para>dcterms:description : A right value axis is a value axis that is spatially positioned to the right of the plot area.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000460">sio:SIO_000460</a>
    /// </summary>
    let SIO_000460 = _prefixId.prefix "SIO_000460"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000461^^xsd:string</para>
    ///   <para>rdfs:label : scaled value axis</para>
    ///   <para>dcterms:description : A scaled value axis is a value axis in which the value range was subject to a mathematic transformation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000461">sio:SIO_000461</a>
    /// </summary>
    let SIO_000461 = _prefixId.prefix "SIO_000461"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000462^^xsd:string</para>
    ///   <para>rdfs:label : linear value axis</para>
    ///   <para>dcterms:description : A linear value axis is a value axis that corresponds to a scaling factor of 1 of the value range.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000462">sio:SIO_000462</a>
    /// </summary>
    let SIO_000462 = _prefixId.prefix "SIO_000462"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000463^^xsd:string</para>
    ///   <para>rdfs:label : logarithmic value axis</para>
    ///   <para>dcterms:description : A logarithmic value axis is a scaled value axis that corresponds to a scaling factor of the logarithm of the value range.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000463">sio:SIO_000463</a>
    /// </summary>
    let SIO_000463 = _prefixId.prefix "SIO_000463"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000464^^xsd:string</para>
    ///   <para>rdfs:label : data series</para>
    ///   <para>sio:example : Example: The two series that correspond to "Seasonally adjusted" and "Trend" are composed of the seasonally adjusted value of permits in each month and values from a trend derived from some mathematical tranformation across those values, respectively, in  Graph 1 of http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A data series is a data set composed of related values displayed in a statistical graph.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000464">sio:SIO_000464</a>
    /// </summary>
    let SIO_000464 = _prefixId.prefix "SIO_000464"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000465^^xsd:string</para>
    ///   <para>rdfs:label : data point</para>
    ///   <para>dcterms:description : A data point is a point that which corresponds to the projection of the values of measurement data against the axes of a statistical graph.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000465">sio:SIO_000465</a>
    /// </summary>
    let SIO_000465 = _prefixId.prefix "SIO_000465"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000466^^xsd:string</para>
    ///   <para>rdfs:label : global maximal stationary point</para>
    ///   <para>dcterms:description : A global maximum stationary point is a data point that corresponds to a measurement value is larger than that of all other plotted datapoints.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000466">sio:SIO_000466</a>
    /// </summary>
    let SIO_000466 = _prefixId.prefix "SIO_000466"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000467^^xsd:string</para>
    ///   <para>rdfs:label : global minimal stationary point</para>
    ///   <para>dcterms:description : A global minimum data point is a data point that corresponds to a measurement value is smaller than that of all other plotted datapoints.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000467">sio:SIO_000467</a>
    /// </summary>
    let SIO_000467 = _prefixId.prefix "SIO_000467"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000468^^xsd:string</para>
    ///   <para>rdfs:label : legend</para>
    ///   <para>sio:example : The colored line segments and the adjacent textual descriptions in
    /// Graph 1 of http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A legend is a part of a figure that associates textual descriptions with symbols pertaining to plotted entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000468">sio:SIO_000468</a>
    /// </summary>
    let SIO_000468 = _prefixId.prefix "SIO_000468"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000469^^xsd:string</para>
    ///   <para>rdfs:label : graph title</para>
    ///   <para>sio:example : Total value of permits increased slightly in December" in Graph 1 of http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A graph title is a title that describes a graph.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000469">sio:SIO_000469</a>
    /// </summary>
    let SIO_000469 = _prefixId.prefix "SIO_000469"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000470^^xsd:string</para>
    ///   <para>rdfs:label : primary title</para>
    ///   <para>dcterms:description : A primary title is a title that should be first used in describing some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000470">sio:SIO_000470</a>
    /// </summary>
    let SIO_000470 = _prefixId.prefix "SIO_000470"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000471^^xsd:string</para>
    ///   <para>rdfs:label : secondary title</para>
    ///   <para>sio:hasSynonym : subtitle, alternative title^^xsd:string</para>
    ///   <para>dcterms:description : A secondary title is a title of lesser importance that should be used after the first title in describing some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000471">sio:SIO_000471</a>
    /// </summary>
    let SIO_000471 = _prefixId.prefix "SIO_000471"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000472^^xsd:string</para>
    ///   <para>rdfs:label : scientific data</para>
    ///   <para>dcterms:description : scientific data is data obtained from some scientific procedure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000472">sio:SIO_000472</a>
    /// </summary>
    let SIO_000472 = _prefixId.prefix "SIO_000472"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000473^^xsd:string</para>
    ///   <para>rdfs:label : primary graph title</para>
    ///   <para>sio:example : "Total value of permits increased slightly in December" in Graph 1 of http://tinyurl.com/opwnvm</para>
    ///   <para>dcterms:description : A primary graph title is a primary title that describes a statistical graph.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000473">sio:SIO_000473</a>
    /// </summary>
    let SIO_000473 = _prefixId.prefix "SIO_000473"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000474^^xsd:string</para>
    ///   <para>rdfs:label : secondary graph title</para>
    ///   <para>dcterms:description : A secondary graph title is a secondary title that describes a statistical graph.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000474">sio:SIO_000474</a>
    /// </summary>
    let SIO_000474 = _prefixId.prefix "SIO_000474"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000475^^xsd:string</para>
    ///   <para>rdfs:label : biological quality</para>
    ///   <para>dcterms:description : A biological quality is a quality held by a biological entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000475">sio:SIO_000475</a>
    /// </summary>
    let SIO_000475 = _prefixId.prefix "SIO_000475"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000476^^xsd:string</para>
    ///   <para>rdfs:label : cellular quality</para>
    ///   <para>dcterms:description : cellular quality is the quality of a cell</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000476">sio:SIO_000476</a>
    /// </summary>
    let SIO_000476 = _prefixId.prefix "SIO_000476"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000477^^xsd:string</para>
    ///   <para>rdfs:label : is broader than</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#narrower^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000477">sio:SIO_000477</a>
    /// </summary>
    let SIO_000477 = _prefixId.prefix "SIO_000477"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000478^^xsd:string</para>
    ///   <para>rdfs:label : sequence variant role</para>
    ///   <para>dcterms:description : A sequence variant role is a comparative role in which the composition of characters in a sequence differs when compared to another entity of similar type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000478">sio:SIO_000478</a>
    /// </summary>
    let SIO_000478 = _prefixId.prefix "SIO_000478"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000479^^xsd:string</para>
    ///   <para>rdfs:label : variant role</para>
    ///   <para>dcterms:description : A variant role is a comparative role in which the value of an attribute differs when compared to another entity</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000479">sio:SIO_000479</a>
    /// </summary>
    let SIO_000479 = _prefixId.prefix "SIO_000479"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000480^^xsd:string</para>
    ///   <para>rdfs:label : insertion variant role</para>
    ///   <para>dcterms:description : An insertion variant role is the role of an sequence that contains a sub-sequence that is considered to be an addition relative to the frame of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000480">sio:SIO_000480</a>
    /// </summary>
    let SIO_000480 = _prefixId.prefix "SIO_000480"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000481^^xsd:string</para>
    ///   <para>rdfs:label : deletion variant role</para>
    ///   <para>dcterms:description : A deletion variant role is the role of an sequence that lacks a sub-sequence relative to the frame of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000481">sio:SIO_000481</a>
    /// </summary>
    let SIO_000481 = _prefixId.prefix "SIO_000481"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000482^^xsd:string</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#relatedMatch^^xsd:string</para>
    ///   <para>rdfs:label : is match to</para>
    ///   <para>dcterms:description : A is match to B iff A and B are terms with similar (related, broad, close, exact) meanings</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000482">sio:SIO_000482</a>
    /// </summary>
    let SIO_000482 = _prefixId.prefix "SIO_000482"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000483^^xsd:string</para>
    ///   <para>rdfs:label : phrase</para>
    ///   <para>dcterms:description : A phrase is a group of words functioning as a single unit in the syntax of a sentence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000483">sio:SIO_000483</a>
    /// </summary>
    let SIO_000483 = _prefixId.prefix "SIO_000483"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000484^^xsd:string</para>
    ///   <para>rdfs:label : is exact match to</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#exactMatch^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000484">sio:SIO_000484</a>
    /// </summary>
    let SIO_000484 = _prefixId.prefix "SIO_000484"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000485^^xsd:string</para>
    ///   <para>rdfs:label : human</para>
    ///   <para>dcterms:description : A human is a primates of the family Hominidae and are characterized by having a large brain relative to body size, with a well developed neocortex, prefrontal cortex and temporal lobes, making them capable of abstract reasoning, language, introspection, problem solving and culture through social learning.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000485">sio:SIO_000485</a>
    /// </summary>
    let SIO_000485 = _prefixId.prefix "SIO_000485"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000486^^xsd:string</para>
    ///   <para>rdfs:label : mouse</para>
    ///   <para>dcterms:description : A mouse is a small mammal belonging to the order of rodents, characteristically having a pointed snout, small rounded ears, and a long naked or almost hairless tail. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000486">sio:SIO_000486</a>
    /// </summary>
    let SIO_000486 = _prefixId.prefix "SIO_000486"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000487^^xsd:string</para>
    ///   <para>rdfs:label : rat</para>
    ///   <para>dcterms:description : A rat is a medium-sized, long-tailed rodent of the superfamily Muroidea.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000487">sio:SIO_000487</a>
    /// </summary>
    let SIO_000487 = _prefixId.prefix "SIO_000487"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000488^^xsd:string</para>
    ///   <para>rdfs:label : worm</para>
    ///   <para>dcterms:description : A worm is a non-arthropod invertebrate animal that typically have a long cylindrical tube-like body and no legs.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000488">sio:SIO_000488</a>
    /// </summary>
    let SIO_000488 = _prefixId.prefix "SIO_000488"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000489^^xsd:string</para>
    ///   <para>rdfs:label : e.coli</para>
    ///   <para>dcterms:description : Escherichia coli (e coli) is a Gram-negative, rod-shaped bacterium that is commonly found in the lower intestine of warm-blooded organisms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000489">sio:SIO_000489</a>
    /// </summary>
    let SIO_000489 = _prefixId.prefix "SIO_000489"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000490^^xsd:string</para>
    ///   <para>rdfs:label : is close match to</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#closeMatch^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000490">sio:SIO_000490</a>
    /// </summary>
    let SIO_000490 = _prefixId.prefix "SIO_000490"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000491^^xsd:string</para>
    ///   <para>rdfs:label : is broad match to</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/2004/02/skos/core#broadMatch^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000491">sio:SIO_000491</a>
    /// </summary>
    let SIO_000491 = _prefixId.prefix "SIO_000491"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000492^^xsd:string</para>
    ///   <para>rdfs:label : to consume</para>
    ///   <para>dcterms:description : to consume is the capability to internalize a material entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000492">sio:SIO_000492</a>
    /// </summary>
    let SIO_000492 = _prefixId.prefix "SIO_000492"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000493^^xsd:string</para>
    ///   <para>rdfs:label : clause</para>
    ///   <para>dcterms:description : A clause consists of a subject and a predicate.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000493">sio:SIO_000493</a>
    /// </summary>
    let SIO_000493 = _prefixId.prefix "SIO_000493"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000494^^xsd:string</para>
    ///   <para>rdfs:label : to actively interact with</para>
    ///   <para>dcterms:description : to actively interact with is the capability to interact with another entity in a way that requires physical contact.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000494">sio:SIO_000494</a>
    /// </summary>
    let SIO_000494 = _prefixId.prefix "SIO_000494"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000495^^xsd:string</para>
    ///   <para>rdfs:label : is dissimilar to</para>
    ///   <para>dcterms:description : is dissimilar to is a relation between two entities in which one is considered dissimilar to the other based on some criteria.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000495">sio:SIO_000495</a>
    /// </summary>
    let SIO_000495 = _prefixId.prefix "SIO_000495"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000496^^xsd:string</para>
    ///   <para>rdfs:label : is opposite to</para>
    ///   <para>sio:example : hot is the opposite of cold; left is opposite of right</para>
    ///   <para>dcterms:description : is opposite to is a relation between two entities in which one is diametrically opposed to the other. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000496">sio:SIO_000496</a>
    /// </summary>
    let SIO_000496 = _prefixId.prefix "SIO_000496"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000497^^xsd:string</para>
    ///   <para>rdfs:label : is version of</para>
    ///   <para>dcterms:description : is version of is a relation that holds between any two versions in which one is a subsequent or alternate version of (through a branch).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000497">sio:SIO_000497</a>
    /// </summary>
    let SIO_000497 = _prefixId.prefix "SIO_000497"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000498^^xsd:string</para>
    ///   <para>rdfs:label : person</para>
    ///   <para>dcterms:description : A person is an object that has certain capacities or attributes constituting personhood.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000498">sio:SIO_000498</a>
    /// </summary>
    let SIO_000498 = _prefixId.prefix "SIO_000498"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000499^^xsd:string</para>
    ///   <para>rdfs:label : to decrease the rate of formation</para>
    ///   <para>dcterms:description : to decrease the rate of formation is to regulate the rate of formation in a manner that decreases this rate relative to a reference process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000499">sio:SIO_000499</a>
    /// </summary>
    let SIO_000499 = _prefixId.prefix "SIO_000499"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000500^^xsd:string</para>
    ///   <para>rdfs:label : polygon vertex</para>
    ///   <para>dcterms:description : A polygon vertex is a terminal point at which two polygon edges meet and are part of a polygon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000500">sio:SIO_000500</a>
    /// </summary>
    let SIO_000500 = _prefixId.prefix "SIO_000500"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000501^^xsd:string</para>
    ///   <para>rdfs:label : polygon edge</para>
    ///   <para>dcterms:description : A polygon edge is a line segment joining two polygon vertices.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000501">sio:SIO_000501</a>
    /// </summary>
    let SIO_000501 = _prefixId.prefix "SIO_000501"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000502^^xsd:string</para>
    ///   <para>rdfs:label : polyhedral skeleton</para>
    ///   <para>dcterms:description : A polyhedral skeleton is a collection of polygon edges.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000502">sio:SIO_000502</a>
    /// </summary>
    let SIO_000502 = _prefixId.prefix "SIO_000502"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000503^^xsd:string</para>
    ///   <para>rdfs:label : polygonal face</para>
    ///   <para>dcterms:description : A polygonal face is a polygon bounded by a circuit of polygon edges, and includes the flat (plane) region inside the boundary.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000503">sio:SIO_000503</a>
    /// </summary>
    let SIO_000503 = _prefixId.prefix "SIO_000503"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000504^^xsd:string</para>
    ///   <para>rdfs:label : polyhedral surface</para>
    ///   <para>dcterms:description : A polyhedral surface is composed of polygonal faces.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000504">sio:SIO_000504</a>
    /// </summary>
    let SIO_000504 = _prefixId.prefix "SIO_000504"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000505^^xsd:string</para>
    ///   <para>rdfs:label : polygon</para>
    ///   <para>dcterms:description : A polygon is a planar entity that is bounded by a closed path or circuit, composed of a finite connected sequence3 of straight line segments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000505">sio:SIO_000505</a>
    /// </summary>
    let SIO_000505 = _prefixId.prefix "SIO_000505"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000506^^xsd:string</para>
    ///   <para>rdfs:label : geometric entity</para>
    ///   <para>sio:subset : geometry+^^xsd:string</para>
    ///   <para>dcterms:description : A geometric entity is an information content entity that pertains to the structure and topology of a space.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000506">sio:SIO_000506</a>
    /// </summary>
    let SIO_000506 = _prefixId.prefix "SIO_000506"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000507^^xsd:string</para>
    ///   <para>rdfs:label : point</para>
    ///   <para>dcterms:description : A point is a geometric entity that is located in a zero-dimensional spatial region and whose position is defined by its coordinates in some coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000507">sio:SIO_000507</a>
    /// </summary>
    let SIO_000507 = _prefixId.prefix "SIO_000507"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000508^^xsd:string</para>
    ///   <para>rdfs:label : endpoint</para>
    ///   <para>dcterms:description : An endpoint is a terminal point that is the last of an ordered
    /// pair of points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000508">sio:SIO_000508</a>
    /// </summary>
    let SIO_000508 = _prefixId.prefix "SIO_000508"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000509^^xsd:string</para>
    ///   <para>rdfs:label : start point</para>
    ///   <para>dcterms:description : A start point is a terminal point which is the first of an ordered
    /// pair of points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000509">sio:SIO_000509</a>
    /// </summary>
    let SIO_000509 = _prefixId.prefix "SIO_000509"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000510^^xsd:string</para>
    ///   <para>rdfs:label : model</para>
    ///   <para>dcterms:description : A model is a representation of some thing.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000510">sio:SIO_000510</a>
    /// </summary>
    let SIO_000510 = _prefixId.prefix "SIO_000510"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000511^^xsd:string</para>
    ///   <para>rdfs:label : line</para>
    ///   <para>dcterms:description : A line is curve that extends in a single dimension (e.g. straight line; exhibits no curvature), and is composed of at least two fully connected points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000511">sio:SIO_000511</a>
    /// </summary>
    let SIO_000511 = _prefixId.prefix "SIO_000511"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000512^^xsd:string</para>
    ///   <para>rdfs:label : line segment</para>
    ///   <para>dcterms:description : A line segment is a line and a part of a curve that is (inclusively) bounded by two terminal points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000512">sio:SIO_000512</a>
    /// </summary>
    let SIO_000512 = _prefixId.prefix "SIO_000512"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000513^^xsd:string</para>
    ///   <para>rdfs:label : tick mark</para>
    ///   <para>dcterms:description : A tick mark is a line segment that is spatially positioned perpendicular to the axis of a statistical graph and indicates the position of a specific numeric value (which may be indicated by an adjacent value label) on a value axis, or is one of a pair of tick marks that delineates the boundary of a categorical value (which may be indicated by an adjacent category label) on the categorical axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000513">sio:SIO_000513</a>
    /// </summary>
    let SIO_000513 = _prefixId.prefix "SIO_000513"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000514^^xsd:string</para>
    ///   <para>rdfs:label : major tick mark</para>
    ///   <para>dcterms:description : A major tick mark is a tick mark that indicates the position of a specific numeric value and is adjacent to its value label on the value axis, or is one of a pair of tick marks that delineates the boundary of a categorical value indicated by an adjacent category label on the categorical axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000514">sio:SIO_000514</a>
    /// </summary>
    let SIO_000514 = _prefixId.prefix "SIO_000514"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000515^^xsd:string</para>
    ///   <para>rdfs:label : minor tick mark</para>
    ///   <para>dcterms:description : A minor tick mark is a tick mark that indicates the position of a specific numeric value but has no adjacent value label, or is one of a pair of tick marks that delineates the boundary of a categorical value but has no adjacent category label on the categorical axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000515">sio:SIO_000515</a>
    /// </summary>
    let SIO_000515 = _prefixId.prefix "SIO_000515"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000516^^xsd:string</para>
    ///   <para>rdfs:label : ray</para>
    ///   <para>dcterms:description : A ray is a line which that is bounded by a startpoint and extends outwards infinitely along one dimension.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000516">sio:SIO_000516</a>
    /// </summary>
    let SIO_000516 = _prefixId.prefix "SIO_000516"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000517^^xsd:string</para>
    ///   <para>rdfs:label : quadrilateral</para>
    ///   <para>dcterms:description : A quadrilateral is a polygon with composed of four points and four line segments, in which each point is fully connected to two other points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000517">sio:SIO_000517</a>
    /// </summary>
    let SIO_000517 = _prefixId.prefix "SIO_000517"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000518^^xsd:string</para>
    ///   <para>rdfs:label : rectangle</para>
    ///   <para>dcterms:description : A rectangle is a quadrilateral in which one pair of line segments are  parallel and the other pair are perpendicular to the first pair.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000518">sio:SIO_000518</a>
    /// </summary>
    let SIO_000518 = _prefixId.prefix "SIO_000518"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000519^^xsd:string</para>
    ///   <para>rdfs:label : bar</para>
    ///   <para>dcterms:description : A bar is a rectangle that is located in the plot of a statistical graph in which its length is proportional to the values that it represents.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000519">sio:SIO_000519</a>
    /// </summary>
    let SIO_000519 = _prefixId.prefix "SIO_000519"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000520^^xsd:string</para>
    ///   <para>rdfs:label : triangle</para>
    ///   <para>dcterms:description : A triangle is a polygon composed of three points and three line segments, in which each point is fully connected to another point along through the line segment.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000520">sio:SIO_000520</a>
    /// </summary>
    let SIO_000520 = _prefixId.prefix "SIO_000520"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000521^^xsd:string</para>
    ///   <para>rdfs:label : directed line segment</para>
    ///   <para>dcterms:description : A directed line segment is a line segment that is contained by an ordered pair
    /// of endpoints (a start point and an endpoint).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000521">sio:SIO_000521</a>
    /// </summary>
    let SIO_000521 = _prefixId.prefix "SIO_000521"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000522^^xsd:string</para>
    ///   <para>rdfs:label : arrowed line segment</para>
    ///   <para>dcterms:description : An arrowed line is a directed line segment in which one or both endpoints is tangentially part of a triangle that bisects the line.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000522">sio:SIO_000522</a>
    /// </summary>
    let SIO_000522 = _prefixId.prefix "SIO_000522"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000523^^xsd:string</para>
    ///   <para>rdfs:label : single arrowed line segment</para>
    ///   <para>dcterms:description : A single arrowed line is directed line in which the endpoint is tangentially part of a triangle that bisects the line.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000523">sio:SIO_000523</a>
    /// </summary>
    let SIO_000523 = _prefixId.prefix "SIO_000523"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000524^^xsd:string</para>
    ///   <para>rdfs:label : double arrowed line segment</para>
    ///   <para>dcterms:description : A double arrowed line is an arrowed line in which both terminal points are  tangentially part of different triangles that bisect the line.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000524">sio:SIO_000524</a>
    /// </summary>
    let SIO_000524 = _prefixId.prefix "SIO_000524"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000525^^xsd:string</para>
    ///   <para>rdfs:label : horizontal line</para>
    ///   <para>dcterms:description : A horizontal line is a line that is positionally oriented with the horizon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000525">sio:SIO_000525</a>
    /// </summary>
    let SIO_000525 = _prefixId.prefix "SIO_000525"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000526^^xsd:string</para>
    ///   <para>rdfs:label : vertical line</para>
    ///   <para>dcterms:description : A vertical line is a line that is positionally oriented perpendicular to the horizon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000526">sio:SIO_000526</a>
    /// </summary>
    let SIO_000526 = _prefixId.prefix "SIO_000526"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000527^^xsd:string</para>
    ///   <para>rdfs:label : trend line</para>
    ///   <para>dcterms:description : A trend line is a line, line segment or ray that is part of a statistical graph which indicates a statistical or visual direction across categorical or value data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000527">sio:SIO_000527</a>
    /// </summary>
    let SIO_000527 = _prefixId.prefix "SIO_000527"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000528^^xsd:string</para>
    ///   <para>rdfs:label : increasing line</para>
    ///   <para>dcterms:description : An increasing line is a line segment in which the startpoint and endpoint are ordered along one dimension and the difference of values in a second dimension is positive.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000528">sio:SIO_000528</a>
    /// </summary>
    let SIO_000528 = _prefixId.prefix "SIO_000528"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000529^^xsd:string</para>
    ///   <para>rdfs:label : decreasing line</para>
    ///   <para>dcterms:description : An decreasing line is a line segment in which the startpoint and endpoint are ordered along one dimension and the difference of values in a second dimension is negative.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000529">sio:SIO_000529</a>
    /// </summary>
    let SIO_000529 = _prefixId.prefix "SIO_000529"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000530^^xsd:string</para>
    ///   <para>rdfs:label : plateau line</para>
    ///   <para>dcterms:description : An plateau line is a line segment in which the startpoint and endpoint are ordered along one dimension and the difference of values in a second dimension is zero.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000530">sio:SIO_000530</a>
    /// </summary>
    let SIO_000530 = _prefixId.prefix "SIO_000530"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000531^^xsd:string</para>
    ///   <para>rdfs:label : drop line</para>
    ///   <para>dcterms:description : A drop line is a statistical graph line that vertically or horizontally connects a data series line with a value axis in a statistical graph.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000531">sio:SIO_000531</a>
    /// </summary>
    let SIO_000531 = _prefixId.prefix "SIO_000531"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000532^^xsd:string</para>
    ///   <para>rdfs:label : terminal point</para>
    ///   <para>dcterms:description : A terminal point is a point that defines the finite extension of a line.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000532">sio:SIO_000532</a>
    /// </summary>
    let SIO_000532 = _prefixId.prefix "SIO_000532"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000533^^xsd:string</para>
    ///   <para>rdfs:label : surface normal</para>
    ///   <para>dcterms:description : A surface normal is a vector that is perpendicular to a flat surface.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000533">sio:SIO_000533</a>
    /// </summary>
    let SIO_000533 = _prefixId.prefix "SIO_000533"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000534^^xsd:string</para>
    ///   <para>rdfs:label : positionally oriented line</para>
    ///   <para>dcterms:description : A positionally oriented line is a line that is positioned against some axis of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000534">sio:SIO_000534</a>
    /// </summary>
    let SIO_000534 = _prefixId.prefix "SIO_000534"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000535^^xsd:string</para>
    ///   <para>rdfs:label : statistical graph line</para>
    ///   <para>dcterms:description : A statistical graph line is a line used in a statistical graph to communicate some trend or feature of the embedded data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000535">sio:SIO_000535</a>
    /// </summary>
    let SIO_000535 = _prefixId.prefix "SIO_000535"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000536^^xsd:string</para>
    ///   <para>rdfs:label : to regulate the rate of formation</para>
    ///   <para>dcterms:description : to regulate the rate of formation is to modify the rate at which an object is formed.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000536">sio:SIO_000536</a>
    /// </summary>
    let SIO_000536 = _prefixId.prefix "SIO_000536"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000537^^xsd:string</para>
    ///   <para>rdfs:label : curvature</para>
    ///   <para>dcterms:description : curvature is a quality of a bearer that relates to the presence of curves, bends, or angles.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000537">sio:SIO_000537</a>
    /// </summary>
    let SIO_000537 = _prefixId.prefix "SIO_000537"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000538^^xsd:string</para>
    ///   <para>rdfs:seeAlso : PATO:0002180 [for material entities]^^xsd:string</para>
    ///   <para>rdfs:label : straight</para>
    ///   <para>dcterms:description : straight is a quality of a bearer that is free of curves, bends, or angles.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000538">sio:SIO_000538</a>
    /// </summary>
    let SIO_000538 = _prefixId.prefix "SIO_000538"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000539^^xsd:string</para>
    ///   <para>rdfs:label : infinite line</para>
    ///   <para>dcterms:description : An infinite line is a line that extends outwards in both directions of a single dimensional and is not bounded by terminal points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000539">sio:SIO_000539</a>
    /// </summary>
    let SIO_000539 = _prefixId.prefix "SIO_000539"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000540^^xsd:string</para>
    ///   <para>rdfs:label : vector</para>
    ///   <para>dcterms:description : A vector is a line which that is bounded by a startpoint and extends outwards along one dimension.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000540">sio:SIO_000540</a>
    /// </summary>
    let SIO_000540 = _prefixId.prefix "SIO_000540"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000541^^xsd:string</para>
    ///   <para>rdfs:label : vertex normal</para>
    ///   <para>dcterms:description : A vertext normal is the normalized average of the surface normals of the faces that contain that vertex.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000541">sio:SIO_000541</a>
    /// </summary>
    let SIO_000541 = _prefixId.prefix "SIO_000541"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000542^^xsd:string</para>
    ///   <para>rdfs:label : to serve as</para>
    ///   <para>dcterms:description : to serve as is the capability to act in a manner corresponding to some role.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000542">sio:SIO_000542</a>
    /// </summary>
    let SIO_000542 = _prefixId.prefix "SIO_000542"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000543^^xsd:string</para>
    ///   <para>rdfs:label : to serve as a host</para>
    ///   <para>dcterms:description : to serve as host is the capability to act in a manner that provides hospitality, serves to harbour an organism in or on itself.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000543">sio:SIO_000543</a>
    /// </summary>
    let SIO_000543 = _prefixId.prefix "SIO_000543"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000544^^xsd:string</para>
    ///   <para>rdfs:label : to infect</para>
    ///   <para>dcterms:description : to infect is the capability to administer a disease-causing organism into some object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000544">sio:SIO_000544</a>
    /// </summary>
    let SIO_000544 = _prefixId.prefix "SIO_000544"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000545^^xsd:string</para>
    ///   <para>rdfs:label : polyline</para>
    ///   <para>sio:hasSynonym : polygonal chain, polygonal curve, polygonal path, piecewise linear curve^^xsd:string</para>
    ///   <para>dcterms:description : A polyline is a connected sequence of line segments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000545">sio:SIO_000545</a>
    /// </summary>
    let SIO_000545 = _prefixId.prefix "SIO_000545"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000546^^xsd:string</para>
    ///   <para>rdfs:label : collection of points</para>
    ///   <para>dcterms:description : A collection of points is a geometric entity that contains a non-zero set of geometric points. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000546">sio:SIO_000546</a>
    /// </summary>
    let SIO_000546 = _prefixId.prefix "SIO_000546"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000547^^xsd:string</para>
    ///   <para>rdfs:label : to cause disease</para>
    ///   <para>dcterms:description : to cause disease is the capability to materially change a biological object in that it functions abnormally.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000547">sio:SIO_000547</a>
    /// </summary>
    let SIO_000547 = _prefixId.prefix "SIO_000547"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000549^^xsd:string</para>
    ///   <para>rdfs:label : to reduce the activation energy</para>
    ///   <para>sio:hasSynonym : to activate^^xsd:string</para>
    ///   <para>dcterms:description : to reduce the activation energy is to require a smaller amount of energy in order to form or break a chemical bond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000549">sio:SIO_000549</a>
    /// </summary>
    let SIO_000549 = _prefixId.prefix "SIO_000549"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000550^^xsd:string</para>
    ///   <para>rdfs:label : to increase the activation energy</para>
    ///   <para>sio:hasSynonym : to inhibit^^xsd:string</para>
    ///   <para>dcterms:description : to increase the activation energy is to require a larger amount of energy in order to form or break a chemical bond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000550">sio:SIO_000550</a>
    /// </summary>
    let SIO_000550 = _prefixId.prefix "SIO_000550"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000551^^xsd:string</para>
    ///   <para>rdfs:label : to change the activation energy</para>
    ///   <para>dcterms:description : to change the activation energy is to change the amount of energy required to form or break a chemical bond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000551">sio:SIO_000551</a>
    /// </summary>
    let SIO_000551 = _prefixId.prefix "SIO_000551"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000552^^xsd:string</para>
    ///   <para>rdfs:label : has parameter</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>dcterms:description : has parameter is a relation between a process and an information content entity which modulates the behaviour of some participant.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000552">sio:SIO_000552</a>
    /// </summary>
    let SIO_000552 = _prefixId.prefix "SIO_000552"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000553^^xsd:string</para>
    ///   <para>rdfs:label : is parameter in</para>
    ///   <para>dcterms:description : is parameter in is a relation between a data item and some data transformation process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000553">sio:SIO_000553</a>
    /// </summary>
    let SIO_000553 = _prefixId.prefix "SIO_000553"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000554^^xsd:string</para>
    ///   <para>rdfs:label : normal</para>
    ///   <para>sio:equivalentTo : PATO:0000461^^xsd:string</para>
    ///   <para>dcterms:description : A quality that has a value that is normal or average.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000554">sio:SIO_000554</a>
    /// </summary>
    let SIO_000554 = _prefixId.prefix "SIO_000554"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000555^^xsd:string</para>
    ///   <para>rdfs:label : abnormal</para>
    ///   <para>dcterms:description : A quality that has a value that is outside normal or average.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000555">sio:SIO_000555</a>
    /// </summary>
    let SIO_000555 = _prefixId.prefix "SIO_000555"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000556^^xsd:string</para>
    ///   <para>rdfs:label : lipid residue</para>
    ///   <para>dcterms:description : A lipid residue is a part of an organic molecule that was derived from a lipid molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000556">sio:SIO_000556</a>
    /// </summary>
    let SIO_000556 = _prefixId.prefix "SIO_000556"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000557^^xsd:string</para>
    ///   <para>rdfs:label : is described by</para>
    ///   <para>dcterms:description : is described by is a relation between one entity and another entity that provides a description (detailed account) of it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000557">sio:SIO_000557</a>
    /// </summary>
    let SIO_000557 = _prefixId.prefix "SIO_000557"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000558^^xsd:string</para>
    ///   <para>rdfs:label : is orthologous to</para>
    ///   <para>dcterms:description : is orthologous to is a relation between two biological entities that share a common ancestor and occur in different species.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000558">sio:SIO_000558</a>
    /// </summary>
    let SIO_000558 = _prefixId.prefix "SIO_000558"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000559^^xsd:string</para>
    ///   <para>rdfs:label : chemical synthesis</para>
    ///   <para>dcterms:description : chemical synthesis is synthesis of a chemical entity from physical precursors through one or more chemical interactions or reactions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000559">sio:SIO_000559</a>
    /// </summary>
    let SIO_000559 = _prefixId.prefix "SIO_000559"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000561^^xsd:string</para>
    ///   <para>rdfs:label : molecular orbitral</para>
    ///   <para>dcterms:description : A molecular orbital (or MO) is a mathematical function describing the wave-like behavior of an electron in a molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000561">sio:SIO_000561</a>
    /// </summary>
    let SIO_000561 = _prefixId.prefix "SIO_000561"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000562^^xsd:string</para>
    ///   <para>rdfs:label : passive transport</para>
    ///   <para>dcterms:description : passive transport is the movement of a substance across a membrane and does not require chemical energy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000562">sio:SIO_000562</a>
    /// </summary>
    let SIO_000562 = _prefixId.prefix "SIO_000562"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000563^^xsd:string</para>
    ///   <para>rdfs:label : describes</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : describes is a relation between one entity and another entity that it provides a description (detailed account of).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000563">sio:SIO_000563</a>
    /// </summary>
    let SIO_000563 = _prefixId.prefix "SIO_000563"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000564^^xsd:string</para>
    ///   <para>rdfs:label : diffusion</para>
    ///   <para>dcterms:description : diffusion is motion of particles at temperatures above absolute zero.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000564">sio:SIO_000564</a>
    /// </summary>
    let SIO_000564 = _prefixId.prefix "SIO_000564"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000565^^xsd:string</para>
    ///   <para>rdfs:label : diffusion equation</para>
    ///   <para>dcterms:description : A diffusion equation describes density fluctuations in a material undergoing diffusion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000565">sio:SIO_000565</a>
    /// </summary>
    let SIO_000565 = _prefixId.prefix "SIO_000565"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000566^^xsd:string</para>
    ///   <para>rdfs:label : movement equation</para>
    ///   <para>dcterms:description : A movement equation describes the displacement of an object in space over time.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000566">sio:SIO_000566</a>
    /// </summary>
    let SIO_000566 = _prefixId.prefix "SIO_000566"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000567^^xsd:string</para>
    ///   <para>rdfs:label : ordinary differential equation</para>
    ///   <para>dcterms:description : An ordinary differential equation (ODE) is a differential equation in which the unknown function (also known as the dependent variable) is a function of a single independent variable.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000567">sio:SIO_000567</a>
    /// </summary>
    let SIO_000567 = _prefixId.prefix "SIO_000567"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000568^^xsd:string</para>
    ///   <para>rdfs:label : partial differential equation</para>
    ///   <para>dcterms:description : A partial differential equation (PDE) is a differential equation in which the unknown function is a function of multiple independent variables and the equation involves its partial derivatives.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000568">sio:SIO_000568</a>
    /// </summary>
    let SIO_000568 = _prefixId.prefix "SIO_000568"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000569^^xsd:string</para>
    ///   <para>rdfs:label : differential equation</para>
    ///   <para>dcterms:description : A differential equation is a mathematical equation for an unknown function of one or several variables that relates the values of the function itself and its derivatives of various orders.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000569">sio:SIO_000569</a>
    /// </summary>
    let SIO_000569 = _prefixId.prefix "SIO_000569"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000570^^xsd:string</para>
    ///   <para>rdfs:label : movement</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : movement is the process in which an object is spatially displaced.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000570">sio:SIO_000570</a>
    /// </summary>
    let SIO_000570 = _prefixId.prefix "SIO_000570"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000571^^xsd:string</para>
    ///   <para>rdfs:label : brownian motion</para>
    ///   <para>dcterms:description : Brownian motion is the seemlingly random movement of particles suspended in a fluid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000571">sio:SIO_000571</a>
    /// </summary>
    let SIO_000571 = _prefixId.prefix "SIO_000571"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000572^^xsd:string</para>
    ///   <para>rdfs:label : osmosis</para>
    ///   <para>dcterms:description : osmosis is the movement of water molecules through a selectively-permeable membrane down a water potential gradient.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000572">sio:SIO_000572</a>
    /// </summary>
    let SIO_000572 = _prefixId.prefix "SIO_000572"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000573^^xsd:string</para>
    ///   <para>rdfs:label : passive movement</para>
    ///   <para>dcterms:description : passive movement is the process in which an object is spatially displaced without an expenditure of energy contained in molecular bonds.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000573">sio:SIO_000573</a>
    /// </summary>
    let SIO_000573 = _prefixId.prefix "SIO_000573"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000574^^xsd:string</para>
    ///   <para>rdfs:label : active movement</para>
    ///   <para>dcterms:description : active movement is the process in which an object is spatially displaced using some chemical energy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000574">sio:SIO_000574</a>
    /// </summary>
    let SIO_000574 = _prefixId.prefix "SIO_000574"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000575^^xsd:string</para>
    ///   <para>rdfs:label : transporting</para>
    ///   <para>dcterms:description : transporting is a  process in which one object physically moves another object from one location to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000575">sio:SIO_000575</a>
    /// </summary>
    let SIO_000575 = _prefixId.prefix "SIO_000575"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000576^^xsd:string</para>
    ///   <para>rdfs:label : membrane transport</para>
    ///   <para>dcterms:description : membrane transport is the movement of molecules across a membrane.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000576">sio:SIO_000576</a>
    /// </summary>
    let SIO_000576 = _prefixId.prefix "SIO_000576"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000577^^xsd:string</para>
    ///   <para>rdfs:label : primary active transport</para>
    ///   <para>dcterms:description : primary active transport, also called direct active transport, directly uses energy to transport molecules across a membrane.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000577">sio:SIO_000577</a>
    /// </summary>
    let SIO_000577 = _prefixId.prefix "SIO_000577"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000578^^xsd:string</para>
    ///   <para>rdfs:label : secondary active transport</para>
    ///   <para>dcterms:description : secondary active transport or co-transport uses electrochemical potential difference created by pumping ions out of the cell to transport molecules across a membrane.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000578">sio:SIO_000578</a>
    /// </summary>
    let SIO_000578 = _prefixId.prefix "SIO_000578"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000579^^xsd:string</para>
    ///   <para>rdfs:label : symport enabled secondary active transport</para>
    ///   <para>dcterms:description : symport enabled secondary active transport is a secondary active transfort in which both ion and molecule are transported in the same direction simultaneously.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000579">sio:SIO_000579</a>
    /// </summary>
    let SIO_000579 = _prefixId.prefix "SIO_000579"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000580^^xsd:string</para>
    ///   <para>rdfs:label : antiport enabled secondary active transport</para>
    ///   <para>dcterms:description : antiport enabled secondary active transport is a secondary active transfort in which both ion and molecule are transported in opposite directions simultaneously.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000580">sio:SIO_000580</a>
    /// </summary>
    let SIO_000580 = _prefixId.prefix "SIO_000580"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000581^^xsd:string</para>
    ///   <para>rdfs:label : locomotion</para>
    ///   <para>sio:broaderThan : GO:0040011^^xsd:string</para>
    ///   <para>dcterms:description : The self-propelled movement of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000581">sio:SIO_000581</a>
    /// </summary>
    let SIO_000581 = _prefixId.prefix "SIO_000581"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000582^^xsd:string</para>
    ///   <para>rdfs:label : birthing</para>
    ///   <para>dcterms:description : birthing is the process by which a biological organism is brought into existence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000582">sio:SIO_000582</a>
    /// </summary>
    let SIO_000582 = _prefixId.prefix "SIO_000582"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000583^^xsd:string</para>
    ///   <para>rdfs:label : dying</para>
    ///   <para>dcterms:description : dying is a process in which a biological entity ceases to exist.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000583">sio:SIO_000583</a>
    /// </summary>
    let SIO_000583 = _prefixId.prefix "SIO_000583"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000585^^xsd:string</para>
    ///   <para>rdfs:label : idea</para>
    ///   <para>dcterms:description : An idea is a proposition about some object of conceptual thought.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000585">sio:SIO_000585</a>
    /// </summary>
    let SIO_000585 = _prefixId.prefix "SIO_000585"
    /// <summary>
    ///   <para>sio:example : SIO has the capability to semantically integrate data.</para>
    ///   <para>dc11:identifier : SIO_000586^^xsd:string</para>
    ///   <para>dcterms:description : has capability is a relation between an entity and the capability that it bears.</para>
    ///   <para>rdfs:label : has capability</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000586">sio:SIO_000586</a>
    /// </summary>
    let SIO_000586 = _prefixId.prefix "SIO_000586"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000587^^xsd:string</para>
    ///   <para>rdfs:label : biological reproduction</para>
    ///   <para>dcterms:description : biological reproduction is the biological process by which one or more biological organisms are produced from their "parents". </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000587">sio:SIO_000587</a>
    /// </summary>
    let SIO_000587 = _prefixId.prefix "SIO_000587"
    /// <summary>
    ///   <para>sio:hasSynonym : development^^xsd:stringsio:hasSynonym : production^^xsd:stringsio:hasSynonym : synthesis^^xsd:stringsio:hasSynonym : formulation^^xsd:stringsio:hasSynonym : creation^^xsd:string</para>
    ///   <para>dcterms:description : creating is the process in which an entity comes into existence.</para>
    ///   <para>dc11:identifier : SIO_000588^^xsd:string</para>
    ///   <para>rdfs:label : creating</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000588">sio:SIO_000588</a>
    /// </summary>
    let SIO_000588 = _prefixId.prefix "SIO_000588"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000589^^xsd:string</para>
    ///   <para>rdfs:label : regulating</para>
    ///   <para>sio:hasSynonym : regulation</para>
    ///   <para>dcterms:description : regulating is a process that modulates the attributes of an object or process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000589">sio:SIO_000589</a>
    /// </summary>
    let SIO_000589 = _prefixId.prefix "SIO_000589"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000590^^xsd:string</para>
    ///   <para>rdfs:label : biosynthesis</para>
    ///   <para>dcterms:description : biosynthesis is the synthesis of an organic compound in a living organism, usually aided by enzymes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000590">sio:SIO_000590</a>
    /// </summary>
    let SIO_000590 = _prefixId.prefix "SIO_000590"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000591^^xsd:string</para>
    ///   <para>rdfs:label : destroying</para>
    ///   <para>sio:hasSynonym : destruction</para>
    ///   <para>dcterms:description : destroying is a process in which something is broken down and/or ceases to exist.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000591">sio:SIO_000591</a>
    /// </summary>
    let SIO_000591 = _prefixId.prefix "SIO_000591"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000592^^xsd:string</para>
    ///   <para>rdfs:label : chemical destruction</para>
    ///   <para>dcterms:description : chemical destruction is destruction of a chemical entity to its chemical constituents through one ormore chemical interactions or reactions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000592">sio:SIO_000592</a>
    /// </summary>
    let SIO_000592 = _prefixId.prefix "SIO_000592"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000593^^xsd:string</para>
    ///   <para>rdfs:label : interacting</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : interacting is a process characterized by the interaction between two or more entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000593">sio:SIO_000593</a>
    /// </summary>
    let SIO_000593 = _prefixId.prefix "SIO_000593"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000594^^xsd:string</para>
    ///   <para>rdfs:label : data transformation</para>
    ///   <para>dcterms:description : data transformation is the process of applying an algorithmic procedure to some input data and producing some output data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000594">sio:SIO_000594</a>
    /// </summary>
    let SIO_000594 = _prefixId.prefix "SIO_000594"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000595^^xsd:string</para>
    ///   <para>rdfs:label : parameterized data transformation</para>
    ///   <para>dcterms:description : A parameterized data transformation is a data transformation whose behaviour may be modified by one or more parameters.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000595">sio:SIO_000595</a>
    /// </summary>
    let SIO_000595 = _prefixId.prefix "SIO_000595"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000596^^xsd:string</para>
    ///   <para>rdfs:label : data storage device</para>
    ///   <para>dcterms:description : A data storage device is a device that is capable of storing information.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000596">sio:SIO_000596</a>
    /// </summary>
    let SIO_000596 = _prefixId.prefix "SIO_000596"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000597^^xsd:string</para>
    ///   <para>rdfs:label : solid state hard drive</para>
    ///   <para>dcterms:description : A solid-state drive (SSD) is a data storage device that uses solid-state memory to store persistent data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000597">sio:SIO_000597</a>
    /// </summary>
    let SIO_000597 = _prefixId.prefix "SIO_000597"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000598^^xsd:string</para>
    ///   <para>rdfs:label : hard disk drive</para>
    ///   <para>dcterms:description : A hard disk drive (HDD) is a non-volatile, random access device for digital data. It features rotating rigid platters on a motor-driven spindle within a protective enclosure. Data is magnetically read and written on the platter by read/write heads that float on a film of air above the platters.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000598">sio:SIO_000598</a>
    /// </summary>
    let SIO_000598 = _prefixId.prefix "SIO_000598"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000600^^xsd:string</para>
    ///   <para>rdfs:label : structure</para>
    ///   <para>dcterms:description : structure is the specification that refers to the composition and arrangement of parts of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000600">sio:SIO_000600</a>
    /// </summary>
    let SIO_000600 = _prefixId.prefix "SIO_000600"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000602^^xsd:string</para>
    ///   <para>rdfs:label : computational entity</para>
    ///   <para>dcterms:description : A computational entity is an information content entity operated on using some computational system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000602">sio:SIO_000602</a>
    /// </summary>
    let SIO_000602 = _prefixId.prefix "SIO_000602"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000605^^xsd:string</para>
    ///   <para>rdfs:label : sound wave</para>
    ///   <para>dcterms:description : A sound wave is a mechanical wave that is an oscillation of pressure transmitted through a solid, liquid, or gas, composed of frequencies within the range of hearing.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000605">sio:SIO_000605</a>
    /// </summary>
    let SIO_000605 = _prefixId.prefix "SIO_000605"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000608^^xsd:string</para>
    ///   <para>rdfs:label : curve</para>
    ///   <para>dcterms:description : A curve is a geometric entity that may be located in n-dimensional spatial region whose extension may be n-dimensional,  is composed of at least two fully connected points and does not intersect itself.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000608">sio:SIO_000608</a>
    /// </summary>
    let SIO_000608 = _prefixId.prefix "SIO_000608"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000609^^xsd:string</para>
    ///   <para>rdfs:label : regulation of process</para>
    ///   <para>dcterms:description : regulation of a process is a process that modulates the duration, frequency, spatial extent of a target process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000609">sio:SIO_000609</a>
    /// </summary>
    let SIO_000609 = _prefixId.prefix "SIO_000609"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000610^^xsd:string</para>
    ///   <para>rdfs:label : regulation of capability</para>
    ///   <para>dcterms:description : regulation of capability is the regulation of the ability of one party by another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000610">sio:SIO_000610</a>
    /// </summary>
    let SIO_000610 = _prefixId.prefix "SIO_000610"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000611^^xsd:string</para>
    ///   <para>rdfs:label : regulation of catalytic capability</para>
    ///   <para>dcterms:description : the regulation of the enzymatic activity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000611">sio:SIO_000611</a>
    /// </summary>
    let SIO_000611 = _prefixId.prefix "SIO_000611"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000612^^xsd:string</para>
    ///   <para>rdfs:label : representation</para>
    ///   <para>dcterms:description : A representation is a entity that in some way represents another entity (or attribute thereof).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000612">sio:SIO_000612</a>
    /// </summary>
    let SIO_000612 = _prefixId.prefix "SIO_000612"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000613^^xsd:string</para>
    ///   <para>rdfs:label : ordinal position</para>
    ///   <para>sio:hasSynonym : offset^^xsd:string</para>
    ///   <para>dcterms:description : A ordinal position is a number that designates the position of an entity from the first entity in an ordered sequence of entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000613">sio:SIO_000613</a>
    /// </summary>
    let SIO_000613 = _prefixId.prefix "SIO_000613"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000614^^xsd:string</para>
    ///   <para>rdfs:label : attribute</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : An attribute is a characteristic of some entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000614">sio:SIO_000614</a>
    /// </summary>
    let SIO_000614 = _prefixId.prefix "SIO_000614"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000616^^xsd:string</para>
    ///   <para>rdfs:label : collection</para>
    ///   <para>dcterms:description : A collection is a set for which there exists at least one member, although any member need not to exist at any point in the collection's existence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000616">sio:SIO_000616</a>
    /// </summary>
    let SIO_000616 = _prefixId.prefix "SIO_000616"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000617^^xsd:string</para>
    ///   <para>rdfs:label : empty set</para>
    ///   <para>dcterms:description : An empty set is a set for which there are exactly 0 members.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000617">sio:SIO_000617</a>
    /// </summary>
    let SIO_000617 = _prefixId.prefix "SIO_000617"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000618^^xsd:string</para>
    ///   <para>rdfs:label : standard</para>
    ///   <para>dcterms:description : A standard is a socially-agreed upon specification.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000618">sio:SIO_000618</a>
    /// </summary>
    let SIO_000618 = _prefixId.prefix "SIO_000618"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000619^^xsd:string</para>
    ///   <para>rdfs:label : regulatory authority</para>
    ///   <para>dcterms:description : A regulatory authority is an organization responsible for  exercising regulatory or supervisory capacity in some area of human activity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000619">sio:SIO_000619</a>
    /// </summary>
    let SIO_000619 = _prefixId.prefix "SIO_000619"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000620^^xsd:string</para>
    ///   <para>rdfs:label : collective</para>
    ///   <para>sio:hasSynonym : group^^xsd:string</para>
    ///   <para>dcterms:description : A collective is a group of entities that share or are motivated by at least one common issue or interest, or work together on a specific project(s) to achieve a common objective.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000620">sio:SIO_000620</a>
    /// </summary>
    let SIO_000620 = _prefixId.prefix "SIO_000620"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000621^^xsd:string</para>
    ///   <para>rdfs:label : formal specification</para>
    ///   <para>dcterms:description : A formal specification is a mathematical description of software or hardware that may be used to develop an implementation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000621">sio:SIO_000621</a>
    /// </summary>
    let SIO_000621 = _prefixId.prefix "SIO_000621"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000622^^xsd:string</para>
    ///   <para>rdfs:label : RDFS ontology</para>
    ///   <para>dcterms:description : An RDFS ontology is an ontology that conforms to the syntax and semantics of the Resource Description Framework Schema (RDFS).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000622">sio:SIO_000622</a>
    /// </summary>
    let SIO_000622 = _prefixId.prefix "SIO_000622"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000623^^xsd:string</para>
    ///   <para>rdfs:label : OBO ontology</para>
    ///   <para>dcterms:description : An OBO ontology is an ontology document as specified by the Open Biological Ontology community.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000623">sio:SIO_000623</a>
    /// </summary>
    let SIO_000623 = _prefixId.prefix "SIO_000623"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000624^^xsd:string</para>
    ///   <para>rdfs:label : chemical functional group</para>
    ///   <para>dcterms:description : A chemical functional group is a covalently connected part of a molecule which normally confer specific chemical properties.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000624">sio:SIO_000624</a>
    /// </summary>
    let SIO_000624 = _prefixId.prefix "SIO_000624"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000625^^xsd:string</para>
    ///   <para>rdfs:label : chemical structure</para>
    ///   <para>dcterms:description : chemical structure is the structure of a chemical entity in terms of its molecular geometry and electronic structure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000625">sio:SIO_000625</a>
    /// </summary>
    let SIO_000625 = _prefixId.prefix "SIO_000625"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000626^^xsd:string</para>
    ///   <para>rdfs:label : molecular structure</para>
    ///   <para>sio:hasSynonym : molecular geometry^^xsd:string</para>
    ///   <para>dcterms:description : molecular structure is the spatial arrangement of atoms in a molecule and the chemical bonds that hold the atoms together.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000626">sio:SIO_000626</a>
    /// </summary>
    let SIO_000626 = _prefixId.prefix "SIO_000626"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000628^^xsd:string</para>
    ///   <para>rdfs:label : refers to</para>
    ///   <para>sio:subset : nlp+^^xsd:stringsio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : refers to is a relation between one entity and the entity that it makes reference to.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000628">sio:SIO_000628</a>
    /// </summary>
    let SIO_000628 = _prefixId.prefix "SIO_000628"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000629^^xsd:string</para>
    ///   <para>rdfs:label : is subject of</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000629">sio:SIO_000629</a>
    /// </summary>
    let SIO_000629 = _prefixId.prefix "SIO_000629"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000630^^xsd:string</para>
    ///   <para>rdfs:label : is paralogous to</para>
    ///   <para>dcterms:description : is paralogous to is a relation between two entities which indicates their common ancestry as a result of a gene duplication.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000630">sio:SIO_000630</a>
    /// </summary>
    let SIO_000630 = _prefixId.prefix "SIO_000630"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000631^^xsd:string</para>
    ///   <para>rdfs:label : references</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>sio:hasSynonym : mentions^^xsd:string</para>
    ///   <para>dcterms:description : references is a relation between one entity and the entity that it makes reference to by name, but is not described by it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000631">sio:SIO_000631</a>
    /// </summary>
    let SIO_000631 = _prefixId.prefix "SIO_000631"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000632^^xsd:string</para>
    ///   <para>rdfs:label : is model of</para>
    ///   <para>sio:example : the architect builds a model that represents the building she envisions.</para>
    ///   <para>dcterms:description : is model of is a relation between a model (an artifact) and the entity it purports to represent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000632">sio:SIO_000632</a>
    /// </summary>
    let SIO_000632 = _prefixId.prefix "SIO_000632"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000633^^xsd:string</para>
    ///   <para>rdfs:label : is modelled by</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000633">sio:SIO_000633</a>
    /// </summary>
    let SIO_000633 = _prefixId.prefix "SIO_000633"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000634^^xsd:string</para>
    ///   <para>rdfs:label : is xenologous to</para>
    ///   <para>dcterms:description : a relation between two entities which indicates their common ancestry but due to horizontal gene transfer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000634">sio:SIO_000634</a>
    /// </summary>
    let SIO_000634 = _prefixId.prefix "SIO_000634"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000635^^xsd:string</para>
    ///   <para>rdfs:label : has trigger</para>
    ///   <para>dcterms:description : has trigger is a relation between a realizable and the factor that causes it to be realized.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000635">sio:SIO_000635</a>
    /// </summary>
    let SIO_000635 = _prefixId.prefix "SIO_000635"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000636^^xsd:string</para>
    ///   <para>rdfs:label : is trigger for</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000636">sio:SIO_000636</a>
    /// </summary>
    let SIO_000636 = _prefixId.prefix "SIO_000636"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000638^^xsd:string</para>
    ///   <para>rdfs:label : probability measure</para>
    ///   <para>dcterms:description : A probability measure is quantity of how likely it is that some event will occur.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000638">sio:SIO_000638</a>
    /// </summary>
    let SIO_000638 = _prefixId.prefix "SIO_000638"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000639^^xsd:string</para>
    ///   <para>rdfs:label : to passively interact with</para>
    ///   <para>dcterms:description : to passively interact with is the capability to interact with another entity in a way that does not require physical contact.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000639">sio:SIO_000639</a>
    /// </summary>
    let SIO_000639 = _prefixId.prefix "SIO_000639"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000640^^xsd:string</para>
    ///   <para>rdfs:label : increased</para>
    ///   <para>sio:equivalentTo : PATO:0002300^^xsd:string</para>
    ///   <para>dcterms:description : A quality that has a value that is increased compared to normal or average.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000640">sio:SIO_000640</a>
    /// </summary>
    let SIO_000640 = _prefixId.prefix "SIO_000640"
    /// <summary>
    ///   <para>sio:example : the solubility of salt (the disposition) is based on the molecular structure of NaCl (the quality) that allows the polarized water-molecules (the trigger)  to break the ion bonds (the realization).</para>
    ///   <para>dcterms:description : has basis is a relation between a realizable entity and the quality that forms the basis for it.</para>
    ///   <para>dc11:identifier : SIO_000641^^xsd:string</para>
    ///   <para>rdfs:label : has basis</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000641">sio:SIO_000641</a>
    /// </summary>
    let SIO_000641 = _prefixId.prefix "SIO_000641"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000642^^xsd:string</para>
    ///   <para>rdfs:label : is base for</para>
    ///   <para>sio:example : the solubility of salt (the disposition) is based on the molecular structure of NaCl (the quality) that allows the polarized water-molecules (the trigger)  to break the ion bonds (the realization).</para>
    ///   <para>dcterms:description : is base for is a relation between a quality and the realizable entity that it is the basis for.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000642">sio:SIO_000642</a>
    /// </summary>
    let SIO_000642 = _prefixId.prefix "SIO_000642"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000643^^xsd:string</para>
    ///   <para>rdfs:label : is realizable property of</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000643">sio:SIO_000643</a>
    /// </summary>
    let SIO_000643 = _prefixId.prefix "SIO_000643"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000644^^xsd:string</para>
    ///   <para>rdfs:label : has realizable property</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000644">sio:SIO_000644</a>
    /// </summary>
    let SIO_000644 = _prefixId.prefix "SIO_000644"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000646^^xsd:string</para>
    ///   <para>rdfs:label : is capability of</para>
    ///   <para>dcterms:description : is capability of is a relation between a capability and the entity that bears it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000646">sio:SIO_000646</a>
    /// </summary>
    let SIO_000646 = _prefixId.prefix "SIO_000646"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000647^^xsd:string</para>
    ///   <para>rdfs:label : process model</para>
    ///   <para>dcterms:description : A process model is a representation of some process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000647">sio:SIO_000647</a>
    /// </summary>
    let SIO_000647 = _prefixId.prefix "SIO_000647"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000648^^xsd:string</para>
    ///   <para>rdfs:label : object model</para>
    ///   <para>dcterms:description : An object model is a representation of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000648">sio:SIO_000648</a>
    /// </summary>
    let SIO_000648 = _prefixId.prefix "SIO_000648"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000649^^xsd:string</para>
    ///   <para>rdfs:label : information processing</para>
    ///   <para>dcterms:description : information processing is a process that involves the generation or use of information.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000649">sio:SIO_000649</a>
    /// </summary>
    let SIO_000649 = _prefixId.prefix "SIO_000649"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000650^^xsd:string</para>
    ///   <para>rdfs:label : wave</para>
    ///   <para>dcterms:description : A wave is a physical entity that travels through space and time, consist of oscillations or vibrations and may be accompanied by the transfer of energy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000650">sio:SIO_000650</a>
    /// </summary>
    let SIO_000650 = _prefixId.prefix "SIO_000650"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000651^^xsd:string</para>
    ///   <para>rdfs:label : textual entity</para>
    ///   <para>dcterms:description : A textual entity is language entity that is manifested as a sequence of one or more distinct characters.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000651">sio:SIO_000651</a>
    /// </summary>
    let SIO_000651 = _prefixId.prefix "SIO_000651"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000652^^xsd:string</para>
    ///   <para>rdfs:label : is directly connected to</para>
    ///   <para>dcterms:description : A is directly connected to B iff there exists a path direclty between A and B.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000652">sio:SIO_000652</a>
    /// </summary>
    let SIO_000652 = _prefixId.prefix "SIO_000652"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000653^^xsd:string</para>
    ///   <para>rdfs:label : version label</para>
    ///   <para>dcterms:description : A version label is a label for a particular form or variation of an earlier or original type.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000653">sio:SIO_000653</a>
    /// </summary>
    let SIO_000653 = _prefixId.prefix "SIO_000653"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000654^^xsd:string</para>
    ///   <para>rdfs:label : software version label</para>
    ///   <para>sio:example : major.minor[.build[.revision]]</para>
    ///   <para>dcterms:description : A software version label is a version label for a piece of software.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000654">sio:SIO_000654</a>
    /// </summary>
    let SIO_000654 = _prefixId.prefix "SIO_000654"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000655^^xsd:string</para>
    ///   <para>rdfs:label : transforms into</para>
    ///   <para>dcterms:description : A transitive temporal relation in which an entity mainstains identity from one state to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000655">sio:SIO_000655</a>
    /// </summary>
    let SIO_000655 = _prefixId.prefix "SIO_000655"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000656^^xsd:string</para>
    ///   <para>rdfs:label : immediately transforms into</para>
    ///   <para>dcterms:description : A  temporal relation in which an entity mainstains identity from one state to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000656">sio:SIO_000656</a>
    /// </summary>
    let SIO_000656 = _prefixId.prefix "SIO_000656"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000657^^xsd:string</para>
    ///   <para>rdfs:label : is transformed from</para>
    ///   <para>dcterms:description : A transitive temporal relation in which an entity mainstains identity from one state to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000657">sio:SIO_000657</a>
    /// </summary>
    let SIO_000657 = _prefixId.prefix "SIO_000657"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000658^^xsd:string</para>
    ///   <para>rdfs:label : is immediately transformed from</para>
    ///   <para>dcterms:description : A  temporal relation in which an entity mainstains identity from one state to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000658">sio:SIO_000658</a>
    /// </summary>
    let SIO_000658 = _prefixId.prefix "SIO_000658"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000660^^xsd:string</para>
    ///   <para>rdfs:label : hole</para>
    ///   <para>dcterms:description : A hole is a site that is opening into or through something.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000660">sio:SIO_000660</a>
    /// </summary>
    let SIO_000660 = _prefixId.prefix "SIO_000660"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000661^^xsd:string</para>
    ///   <para>rdfs:label : province</para>
    ///   <para>dcterms:description : A province is a territorial unit, almost always an administrative division, within a country or state.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000661">sio:SIO_000661</a>
    /// </summary>
    let SIO_000661 = _prefixId.prefix "SIO_000661"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000662^^xsd:string</para>
    ///   <para>rdfs:label : state</para>
    ///   <para>dcterms:description : A state is a set of governing and supportive institutions that have sovereignty over a definite territory and population.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000662">sio:SIO_000662</a>
    /// </summary>
    let SIO_000662 = _prefixId.prefix "SIO_000662"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000663^^xsd:string</para>
    ///   <para>rdfs:label : territory</para>
    ///   <para>dcterms:description : A territory is a non-sovereign geographic region.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000663">sio:SIO_000663</a>
    /// </summary>
    let SIO_000663 = _prefixId.prefix "SIO_000663"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000664^^xsd:string</para>
    ///   <para>rdfs:label : country</para>
    ///   <para>dcterms:description : A country is a region legally identified as a distinct entity in political geography. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000664">sio:SIO_000664</a>
    /// </summary>
    let SIO_000664 = _prefixId.prefix "SIO_000664"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000665^^xsd:string</para>
    ///   <para>rdfs:label : city</para>
    ///   <para>dcterms:description : A city is a relatively large and permanent settlement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000665">sio:SIO_000665</a>
    /// </summary>
    let SIO_000665 = _prefixId.prefix "SIO_000665"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000666^^xsd:string</para>
    ///   <para>rdfs:label : township</para>
    ///   <para>dcterms:description : A township is a rural or sub-urban settlement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000666">sio:SIO_000666</a>
    /// </summary>
    let SIO_000666 = _prefixId.prefix "SIO_000666"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000667^^xsd:string</para>
    ///   <para>rdfs:label : sofware execution</para>
    ///   <para>dcterms:description : software execution is the process of executing software on a computing device.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000667">sio:SIO_000667</a>
    /// </summary>
    let SIO_000667 = _prefixId.prefix "SIO_000667"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000668^^xsd:string</para>
    ///   <para>rdfs:label : in relation to</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : in relation to is a comparative relation to indicate that the instance of the class holding the relation exists in relation to another entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000668">sio:SIO_000668</a>
    /// </summary>
    let SIO_000668 = _prefixId.prefix "SIO_000668"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000669^^xsd:string</para>
    ///   <para>rdfs:label : start time</para>
    ///   <para>dcterms:description : A start time is a time instant pertaining to the time at which a process begins.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000669">sio:SIO_000669</a>
    /// </summary>
    let SIO_000669 = _prefixId.prefix "SIO_000669"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000670^^xsd:string</para>
    ///   <para>rdfs:label : end time</para>
    ///   <para>dcterms:description : An end time is a time instant pertaining to the time at which a process ends.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000670">sio:SIO_000670</a>
    /// </summary>
    let SIO_000670 = _prefixId.prefix "SIO_000670"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000671^^xsd:string</para>
    ///   <para>rdfs:label : has identifier</para>
    ///   <para>dcterms:description : a relation between an entity and an identifier.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000671">sio:SIO_000671</a>
    /// </summary>
    let SIO_000671 = _prefixId.prefix "SIO_000671"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000672^^xsd:string</para>
    ///   <para>rdfs:label : is identifier for</para>
    ///   <para>sio:hasSynonym : identifies^^xsd:string</para>
    ///   <para>dcterms:description : a relation between an identifier and an entity.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000672">sio:SIO_000672</a>
    /// </summary>
    let SIO_000672 = _prefixId.prefix "SIO_000672"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000673^^xsd:string</para>
    ///   <para>rdfs:label : has unique identifier</para>
    ///   <para>dcterms:description : has unique identifier is an inverse functional relation between an entity and an identifier that uniquely identifies it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000673">sio:SIO_000673</a>
    /// </summary>
    let SIO_000673 = _prefixId.prefix "SIO_000673"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000674^^xsd:string</para>
    ///   <para>rdfs:label : is unique identifier for</para>
    ///   <para>dcterms:description : is unique identifier for is a relation between an identifier and an entity that it uniquely identifies</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000674">sio:SIO_000674</a>
    /// </summary>
    let SIO_000674 = _prefixId.prefix "SIO_000674"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000675^^xsd:string</para>
    ///   <para>rdfs:label : unique identifier</para>
    ///   <para>dcterms:description : A unique identifier is an identifier that uniquely identifies some thing.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000675">sio:SIO_000675</a>
    /// </summary>
    let SIO_000675 = _prefixId.prefix "SIO_000675"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000676^^xsd:string</para>
    ///   <para>rdfs:label : social role</para>
    ///   <para>dcterms:description : A social role is a role that is ascribed to individuals in a community.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000676">sio:SIO_000676</a>
    /// </summary>
    let SIO_000676 = _prefixId.prefix "SIO_000676"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000677^^xsd:string</para>
    ///   <para>rdfs:label : processual role</para>
    ///   <para>dcterms:description : A processual role is a role that can only be realized in a process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000677">sio:SIO_000677</a>
    /// </summary>
    let SIO_000677 = _prefixId.prefix "SIO_000677"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000678^^xsd:string</para>
    ///   <para>rdfs:label : abstract role</para>
    ///   <para>dcterms:description : An abstract role is a role whose basis lies in spatial/temporal or comparative relations. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000678">sio:SIO_000678</a>
    /// </summary>
    let SIO_000678 = _prefixId.prefix "SIO_000678"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000679^^xsd:string</para>
    ///   <para>rdfs:label : has time boundary</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000679">sio:SIO_000679</a>
    /// </summary>
    let SIO_000679 = _prefixId.prefix "SIO_000679"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000680^^xsd:string</para>
    ///   <para>rdfs:label : has start time</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000680">sio:SIO_000680</a>
    /// </summary>
    let SIO_000680 = _prefixId.prefix "SIO_000680"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000681^^xsd:string</para>
    ///   <para>rdfs:label : has end time</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000681">sio:SIO_000681</a>
    /// </summary>
    let SIO_000681 = _prefixId.prefix "SIO_000681"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000682^^xsd:string</para>
    ///   <para>rdfs:label : is start time of</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000682">sio:SIO_000682</a>
    /// </summary>
    let SIO_000682 = _prefixId.prefix "SIO_000682"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000683^^xsd:string</para>
    ///   <para>rdfs:label : justification</para>
    ///   <para>dcterms:description : A justification is a proposition that defends, explains or excuses some argument.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000683">sio:SIO_000683</a>
    /// </summary>
    let SIO_000683 = _prefixId.prefix "SIO_000683"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000684^^xsd:string</para>
    ///   <para>rdfs:label : is end time of</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000684">sio:SIO_000684</a>
    /// </summary>
    let SIO_000684 = _prefixId.prefix "SIO_000684"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000686^^xsd:string</para>
    ///   <para>rdfs:label : academic department</para>
    ///   <para>dcterms:description : An academic department is a division of a university or school faculty devoted to a particular academic discipline.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000686">sio:SIO_000686</a>
    /// </summary>
    let SIO_000686 = _prefixId.prefix "SIO_000686"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000687^^xsd:string</para>
    ///   <para>rdfs:label : exists at</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : exists at is a relation between an entity and a time measurement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000687">sio:SIO_000687</a>
    /// </summary>
    let SIO_000687 = _prefixId.prefix "SIO_000687"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000688^^xsd:string</para>
    ///   <para>rdfs:label : institute</para>
    ///   <para>dcterms:description : institute is a society or organization having a object or common factor, and is normally applied to those with a scientific, educational, or social objective.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000688">sio:SIO_000688</a>
    /// </summary>
    let SIO_000688 = _prefixId.prefix "SIO_000688"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000689^^xsd:string</para>
    ///   <para>rdfs:label : to be a part of</para>
    ///   <para>dcterms:description : to be a part of is the capability to be assembled into a larger structure that persists in time.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000689">sio:SIO_000689</a>
    /// </summary>
    let SIO_000689 = _prefixId.prefix "SIO_000689"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000690^^xsd:string</para>
    ///   <para>rdfs:label : to associate</para>
    ///   <para>dcterms:description : to associate is the capability to physically interact with another object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000690">sio:SIO_000690</a>
    /// </summary>
    let SIO_000690 = _prefixId.prefix "SIO_000690"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000692^^xsd:string</para>
    ///   <para>rdfs:label : to be actively interacted with</para>
    ///   <para>dcterms:description : to be actively interacted with is the capability to be manipulated by some device or agent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000692">sio:SIO_000692</a>
    /// </summary>
    let SIO_000692 = _prefixId.prefix "SIO_000692"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000693^^xsd:string</para>
    ///   <para>rdfs:label : corporation</para>
    ///   <para>dcterms:description : A corporation is an organization that is granted a charter recognizing it as a separate legal entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000693">sio:SIO_000693</a>
    /// </summary>
    let SIO_000693 = _prefixId.prefix "SIO_000693"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000694^^xsd:string</para>
    ///   <para>rdfs:label : to be passively interacted with</para>
    ///   <para>dcterms:description : to be passively interacted with is the capability of an object to be observed.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000694">sio:SIO_000694</a>
    /// </summary>
    let SIO_000694 = _prefixId.prefix "SIO_000694"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000695^^xsd:string</para>
    ///   <para>rdfs:label : to be recorded</para>
    ///   <para>dcterms:description : to be recorded is the capability of an object to be observed in such a way that information about it can be transcribed in a specified format on some physical medium.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000695">sio:SIO_000695</a>
    /// </summary>
    let SIO_000695 = _prefixId.prefix "SIO_000695"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000696^^xsd:string</para>
    ///   <para>rdfs:label : to be observed</para>
    ///   <para>dcterms:description : to be observed is the capability of an object to be perceived.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000696">sio:SIO_000696</a>
    /// </summary>
    let SIO_000696 = _prefixId.prefix "SIO_000696"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000697^^xsd:string</para>
    ///   <para>rdfs:label : is mutual disposition of</para>
    ///   <para>dcterms:description : a is mutual disposition of b if and only if the realization of the disposition  a necessarily causes the realization of the disposition b.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000697">sio:SIO_000697</a>
    /// </summary>
    let SIO_000697 = _prefixId.prefix "SIO_000697"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000698^^xsd:string</para>
    ///   <para>rdfs:label : to disassemble</para>
    ///   <para>dcterms:description : to disassemble is to physically separate the parts of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000698">sio:SIO_000698</a>
    /// </summary>
    let SIO_000698 = _prefixId.prefix "SIO_000698"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000699^^xsd:string</para>
    ///   <para>rdfs:label : is greater than or equal to</para>
    ///   <para>dcterms:description : is greater than or equal to is a comparison relation between two quantities in which the first has a value larger or equal to the second.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000699">sio:SIO_000699</a>
    /// </summary>
    let SIO_000699 = _prefixId.prefix "SIO_000699"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000700^^xsd:string</para>
    ///   <para>rdfs:label : to disassociate</para>
    ///   <para>dcterms:description : to disassociate is to cease or break association with some thing.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000700">sio:SIO_000700</a>
    /// </summary>
    let SIO_000700 = _prefixId.prefix "SIO_000700"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000701^^xsd:string</para>
    ///   <para>rdfs:label : to interact with</para>
    ///   <para>dcterms:description : to interact with is a capabililty that involves another object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000701">sio:SIO_000701</a>
    /// </summary>
    let SIO_000701 = _prefixId.prefix "SIO_000701"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000702^^xsd:string</para>
    ///   <para>rdfs:label : to be interacted with</para>
    ///   <para>dcterms:description : to be interacted with is the capability of an object to be target of a physical interaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000702">sio:SIO_000702</a>
    /// </summary>
    let SIO_000702 = _prefixId.prefix "SIO_000702"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000703^^xsd:string</para>
    ///   <para>rdfs:label : evolving</para>
    ///   <para>dcterms:description : evolving is a process that elicits change across successive generations in the inherited characteristics of biological populations.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000703">sio:SIO_000703</a>
    /// </summary>
    let SIO_000703 = _prefixId.prefix "SIO_000703"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000704^^xsd:string</para>
    ///   <para>rdfs:label : positional role</para>
    ///   <para>dcterms:description : A positional role is an abstract role which holds by comparing position to another object of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000704">sio:SIO_000704</a>
    /// </summary>
    let SIO_000704 = _prefixId.prefix "SIO_000704"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000705^^xsd:string</para>
    ///   <para>rdfs:label : design</para>
    ///   <para>dcterms:description : A specification of an object, manifested by an agent, intended to accomplish goals, in a particular environment, using a set of primitive components, satisfying a set of requirements, subject to constraints.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000705">sio:SIO_000705</a>
    /// </summary>
    let SIO_000705 = _prefixId.prefix "SIO_000705"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000706^^xsd:string</para>
    ///   <para>rdfs:label : occupational role</para>
    ///   <para>dcterms:description : An occupational role is a social role that pertains to an organizational structure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000706">sio:SIO_000706</a>
    /// </summary>
    let SIO_000706 = _prefixId.prefix "SIO_000706"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000707^^xsd:string</para>
    ///   <para>rdfs:label : student role</para>
    ///   <para>dcterms:description : A student role is the role of an individual that is enrolled in courses at an academic institution.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000707">sio:SIO_000707</a>
    /// </summary>
    let SIO_000707 = _prefixId.prefix "SIO_000707"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000708^^xsd:string</para>
    ///   <para>rdfs:label : professor role</para>
    ///   <para>dcterms:description : A professor role is the role of an individual that is involved in teaching of students (undergraduate and/or graduate) at a post-secondary academic institution.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000708">sio:SIO_000708</a>
    /// </summary>
    let SIO_000708 = _prefixId.prefix "SIO_000708"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000709^^xsd:string</para>
    ///   <para>rdfs:label : is mutually related to</para>
    ///   <para>dcterms:description : a is mutually related to b if and only if the realization of the relation of a necessarily causes the realization of a relation to b.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000709">sio:SIO_000709</a>
    /// </summary>
    let SIO_000709 = _prefixId.prefix "SIO_000709"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000710^^xsd:string</para>
    ///   <para>rdfs:label : is mutual role of</para>
    ///   <para>dcterms:description : a is mutual role of b if and only if the realization of role  a necessarily causes the realization of role b.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000710">sio:SIO_000710</a>
    /// </summary>
    let SIO_000710 = _prefixId.prefix "SIO_000710"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000711^^xsd:string</para>
    ///   <para>rdfs:label : academic role</para>
    ///   <para>dcterms:description : An academic role is a social role that pertains to the academic institution.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000711">sio:SIO_000711</a>
    /// </summary>
    let SIO_000711 = _prefixId.prefix "SIO_000711"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000712^^xsd:string</para>
    ///   <para>rdfs:label : medical role</para>
    ///   <para>dcterms:description : A medical role is the role of an individual that is a participant in the delivery of medical care.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000712">sio:SIO_000712</a>
    /// </summary>
    let SIO_000712 = _prefixId.prefix "SIO_000712"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000713^^xsd:string</para>
    ///   <para>rdfs:label : doctor role</para>
    ///   <para>sio:hasSynonym : physician</para>
    ///   <para>dcterms:description : A doctor role is the role of an individual who practices medicine, which is concerned with promoting, maintaining or restoring human health through the study, diagnosis, and treatment of disease, injury, and other physical and mental impairments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000713">sio:SIO_000713</a>
    /// </summary>
    let SIO_000713 = _prefixId.prefix "SIO_000713"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000714^^xsd:string</para>
    ///   <para>rdfs:label : nurse role</para>
    ///   <para>dcterms:description : A nurse role is the role of an individual that is involved in the protection, promotion, and optimization of health and abilities, prevention of illness and injury, alleviation of suffering through the diagnosis and treatment of human response, and advocacy in the care of individuals, families, communities, and populations.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000714">sio:SIO_000714</a>
    /// </summary>
    let SIO_000714 = _prefixId.prefix "SIO_000714"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000715^^xsd:string</para>
    ///   <para>rdfs:label : patient role</para>
    ///   <para>dcterms:description : A patient role is the role of an individual that is the recepient of medical care.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000715">sio:SIO_000715</a>
    /// </summary>
    let SIO_000715 = _prefixId.prefix "SIO_000715"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000716^^xsd:string</para>
    ///   <para>rdfs:label : medical practitioner</para>
    ///   <para>dcterms:description : A medical practioner is an individual that provides medical care.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000716">sio:SIO_000716</a>
    /// </summary>
    let SIO_000716 = _prefixId.prefix "SIO_000716"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000717^^xsd:string</para>
    ///   <para>rdfs:label : dentist role</para>
    ///   <para>dcterms:description : A dentist role is the role of an individual that that specializes in the diagnosis, prevention, and treatment of diseases and conditions of the oral cavity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000717">sio:SIO_000717</a>
    /// </summary>
    let SIO_000717 = _prefixId.prefix "SIO_000717"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000719^^xsd:string</para>
    ///   <para>rdfs:label : to translocate</para>
    ///   <para>sio:hasSynonym : to move</para>
    ///   <para>dcterms:description : to translocate is the capability to displace oneself from one location to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000719">sio:SIO_000719</a>
    /// </summary>
    let SIO_000719 = _prefixId.prefix "SIO_000719"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000720^^xsd:string</para>
    ///   <para>rdfs:label : to be translocated</para>
    ///   <para>sio:hasSynonym : to be moved</para>
    ///   <para>dcterms:description : to be translocated is the capability to be physically displaced from one location to another</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000720">sio:SIO_000720</a>
    /// </summary>
    let SIO_000720 = _prefixId.prefix "SIO_000720"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000721^^xsd:string</para>
    ///   <para>rdfs:label : comparative role</para>
    ///   <para>dcterms:description : A comparative role is an abstract role which holds by comparing some attribute of another object of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000721">sio:SIO_000721</a>
    /// </summary>
    let SIO_000721 = _prefixId.prefix "SIO_000721"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000722^^xsd:string</para>
    ///   <para>rdfs:label : to be compared</para>
    ///   <para>dcterms:description : to be compared is the capability of an object to be examined in order to note the similarities or differences among a set of objects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000722">sio:SIO_000722</a>
    /// </summary>
    let SIO_000722 = _prefixId.prefix "SIO_000722"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000723^^xsd:string</para>
    ///   <para>rdfs:label : to compare</para>
    ///   <para>dcterms:description : to compare is the capability to examine in order to note the similarities or differences among a set of objects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000723">sio:SIO_000723</a>
    /// </summary>
    let SIO_000723 = _prefixId.prefix "SIO_000723"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000724^^xsd:string</para>
    ///   <para>rdfs:label : to examine</para>
    ///   <para>dcterms:description : to examine is the capability to make detailed observation. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000724">sio:SIO_000724</a>
    /// </summary>
    let SIO_000724 = _prefixId.prefix "SIO_000724"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000725^^xsd:string</para>
    ///   <para>rdfs:label : to be examined</para>
    ///   <para>dcterms:description : to be examined is the capability of an object to be observed in a detailed manner.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000725">sio:SIO_000725</a>
    /// </summary>
    let SIO_000725 = _prefixId.prefix "SIO_000725"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000726^^xsd:string</para>
    ///   <para>rdfs:label : administrative role</para>
    ///   <para>dcterms:description : An administrative role is the role of an individual that performs administrative tasks for some organization.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000726">sio:SIO_000726</a>
    /// </summary>
    let SIO_000726 = _prefixId.prefix "SIO_000726"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000727^^xsd:string</para>
    ///   <para>rdfs:label : secretary role</para>
    ///   <para>dcterms:description : A secretary role is the role of an individual that performs administrative tasks to support one or more individuals of the same organization.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000727">sio:SIO_000727</a>
    /// </summary>
    let SIO_000727 = _prefixId.prefix "SIO_000727"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000728^^xsd:string</para>
    ///   <para>rdfs:label : chemical identifier</para>
    ///   <para>dcterms:description : A chemical identifier is an identifier for a chemical entity</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000728">sio:SIO_000728</a>
    /// </summary>
    let SIO_000728 = _prefixId.prefix "SIO_000728"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000729^^xsd:string</para>
    ///   <para>rdfs:label : record identifier</para>
    ///   <para>dcterms:description : A record identifier is an identifier for a database entry.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000729">sio:SIO_000729</a>
    /// </summary>
    let SIO_000729 = _prefixId.prefix "SIO_000729"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000730^^xsd:string</para>
    ///   <para>rdfs:label : physical entity identifier</para>
    ///   <para>dcterms:description : A physical entity identifier is an identifier for a physical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000730">sio:SIO_000730</a>
    /// </summary>
    let SIO_000730 = _prefixId.prefix "SIO_000730"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000731^^xsd:string</para>
    ///   <para>rdfs:label : informational entity identifier</para>
    ///   <para>dcterms:description : An informational entity identifier is an identifier for an informational entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000731">sio:SIO_000731</a>
    /// </summary>
    let SIO_000731 = _prefixId.prefix "SIO_000731"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000732^^xsd:string</para>
    ///   <para>rdfs:label : molecular identifier</para>
    ///   <para>dcterms:description : A molecular identifier is an identifier for a molecular entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000732">sio:SIO_000732</a>
    /// </summary>
    let SIO_000732 = _prefixId.prefix "SIO_000732"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000733^^xsd:string</para>
    ///   <para>rdfs:label : is lesser than or equal to</para>
    ///   <para>dcterms:description : is greater than to is a comparison relation between two quantities in which the first has a value smaller or equal to the second.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000733">sio:SIO_000733</a>
    /// </summary>
    let SIO_000733 = _prefixId.prefix "SIO_000733"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000734^^xsd:string</para>
    ///   <para>rdfs:label : is greater than</para>
    ///   <para>dcterms:description : is greater than to is a comparison relation between two quantities in which the first has a value larger than the second.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000734">sio:SIO_000734</a>
    /// </summary>
    let SIO_000734 = _prefixId.prefix "SIO_000734"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000735^^xsd:string</para>
    ///   <para>rdfs:label : is lesser than</para>
    ///   <para>dcterms:description : is lesser than to is a comparison relation between two quantities in which the first has a value smaller than the second.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000735">sio:SIO_000735</a>
    /// </summary>
    let SIO_000735 = _prefixId.prefix "SIO_000735"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000736^^xsd:string</para>
    ///   <para>rdfs:label : is comparable to</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : is comparable to is a relation between two entities that share at least one feature whose value can be compared.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000736">sio:SIO_000736</a>
    /// </summary>
    let SIO_000736 = _prefixId.prefix "SIO_000736"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000737^^xsd:string</para>
    ///   <para>rdfs:label : is numerically comparable to</para>
    ///   <para>dcterms:description : is numerically comparable to is a comparison relation between two quantities whose datatype value can be compared.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000737">sio:SIO_000737</a>
    /// </summary>
    let SIO_000737 = _prefixId.prefix "SIO_000737"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000738^^xsd:string</para>
    ///   <para>rdfs:label : is equal to</para>
    ///   <para>dcterms:description : is equal to is a comparison relation between two quantities whose value are exactly the same.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000738">sio:SIO_000738</a>
    /// </summary>
    let SIO_000738 = _prefixId.prefix "SIO_000738"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000739^^xsd:string</para>
    ///   <para>rdfs:label : planning</para>
    ///   <para>dcterms:description : planning is the agentive process of developing a plan that specifies a set of actions in order to meet a set of goals or objectives.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000739">sio:SIO_000739</a>
    /// </summary>
    let SIO_000739 = _prefixId.prefix "SIO_000739"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000740^^xsd:string</para>
    ///   <para>rdfs:label : curve segment</para>
    ///   <para>dcterms:description : A curve segment is a part of a curve that consists of at least three points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000740">sio:SIO_000740</a>
    /// </summary>
    let SIO_000740 = _prefixId.prefix "SIO_000740"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000741^^xsd:string</para>
    ///   <para>rdfs:label : stationary point</para>
    ///   <para>dcterms:description : A stationary point is a point that is part of a curve in which the derivative at that point is zero, and hence its value is at least a local maximum or minimum.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000741">sio:SIO_000741</a>
    /// </summary>
    let SIO_000741 = _prefixId.prefix "SIO_000741"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000742^^xsd:string</para>
    ///   <para>rdfs:label : local maximum stationary point</para>
    ///   <para>dcterms:description : A local maximum stationary point is a point that has a higher value in  some axis than adjacent points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000742">sio:SIO_000742</a>
    /// </summary>
    let SIO_000742 = _prefixId.prefix "SIO_000742"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000743^^xsd:string</para>
    ///   <para>rdfs:label : local minimum stationary point</para>
    ///   <para>dcterms:description : A local minimum stationary point is a point that has a lower value in  some axis than adjacent points.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000743">sio:SIO_000743</a>
    /// </summary>
    let SIO_000743 = _prefixId.prefix "SIO_000743"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000744^^xsd:string</para>
    ///   <para>rdfs:label : learning</para>
    ///   <para>dcterms:description : learning is the agentive process of acquiring knowledge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000744">sio:SIO_000744</a>
    /// </summary>
    let SIO_000744 = _prefixId.prefix "SIO_000744"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000745^^xsd:string</para>
    ///   <para>rdfs:label : comparing</para>
    ///   <para>sio:hasSynonym : comparison^^xsd:string</para>
    ///   <para>dcterms:description : comparing is the process of examining a set of objects and determining their equality or inequality based on one or more features.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000745">sio:SIO_000745</a>
    /// </summary>
    let SIO_000745 = _prefixId.prefix "SIO_000745"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000746^^xsd:string</para>
    ///   <para>rdfs:label : reasoning</para>
    ///   <para>dcterms:description : reasoning is the agentive process of using knowledge to evaluate the truth value of a proposition.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000746">sio:SIO_000746</a>
    /// </summary>
    let SIO_000746 = _prefixId.prefix "SIO_000746"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000747^^xsd:string</para>
    ///   <para>rdfs:label : investigation</para>
    ///   <para>sio:hasSynonym : study^^xsd:string</para>
    ///   <para>dcterms:description : investigation is the process of carrying out a plan or procedure so as to discover facts or information about the object of study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000747">sio:SIO_000747</a>
    /// </summary>
    let SIO_000747 = _prefixId.prefix "SIO_000747"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000748^^xsd:string</para>
    ///   <para>rdfs:label : predicting</para>
    ///   <para>dcterms:description : predicting is the process of formulating a proposition about a state of affairs which might be realized in the future.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000748">sio:SIO_000748</a>
    /// </summary>
    let SIO_000748 = _prefixId.prefix "SIO_000748"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000749^^xsd:string</para>
    ///   <para>rdfs:label : is inequal to</para>
    ///   <para>dcterms:description : is inequal to is a comparison relation between two quantities whose value are not the same.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000749">sio:SIO_000749</a>
    /// </summary>
    let SIO_000749 = _prefixId.prefix "SIO_000749"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000750^^xsd:string</para>
    ///   <para>rdfs:label : database</para>
    ///   <para>dcterms:description : A database is a set of tables.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000750">sio:SIO_000750</a>
    /// </summary>
    let SIO_000750 = _prefixId.prefix "SIO_000750"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000751^^xsd:string</para>
    ///   <para>rdfs:label : decreased</para>
    ///   <para>sio:equivalentTo : PATO:0002301^^xsd:string</para>
    ///   <para>dcterms:description : A quality that has a value that is decreased compared to normal or average.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000751">sio:SIO_000751</a>
    /// </summary>
    let SIO_000751 = _prefixId.prefix "SIO_000751"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000752^^xsd:string</para>
    ///   <para>rdfs:label : row</para>
    ///   <para>dcterms:description : A row represents a single, implicitly structured data item in a table. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000752">sio:SIO_000752</a>
    /// </summary>
    let SIO_000752 = _prefixId.prefix "SIO_000752"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000753^^xsd:string</para>
    ///   <para>rdfs:label : column</para>
    ///   <para>dcterms:description : A column is a vertical sequence of cells in a cellular automata.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000753">sio:SIO_000753</a>
    /// </summary>
    let SIO_000753 = _prefixId.prefix "SIO_000753"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000754^^xsd:string</para>
    ///   <para>rdfs:label : database table</para>
    ///   <para>dcterms:description : A database table is a set of named columns with zero or more rows composed of cells that contain column values and is part of a database.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000754">sio:SIO_000754</a>
    /// </summary>
    let SIO_000754 = _prefixId.prefix "SIO_000754"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000755^^xsd:string</para>
    ///   <para>rdfs:label : cell (informational)</para>
    ///   <para>dcterms:description : The minimal unit of a cellular automaton that can change state and has an associated behavior.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000755">sio:SIO_000755</a>
    /// </summary>
    let SIO_000755 = _prefixId.prefix "SIO_000755"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000756^^xsd:string</para>
    ///   <para>rdfs:label : database entry</para>
    ///   <para>sio:hasSynonym : database record^^xsd:string</para>
    ///   <para>dcterms:description : A database entry is a single, implicitly structured data item in a table.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000756">sio:SIO_000756</a>
    /// </summary>
    let SIO_000756 = _prefixId.prefix "SIO_000756"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000757^^xsd:string</para>
    ///   <para>rdfs:label : database column</para>
    ///   <para>dcterms:description : A database collumn is a column in a database table.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000757">sio:SIO_000757</a>
    /// </summary>
    let SIO_000757 = _prefixId.prefix "SIO_000757"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000758^^xsd:string</para>
    ///   <para>rdfs:label : disordered</para>
    ///   <para>dcterms:description : disordered is a structural quality in which the parts of an object are non-rigid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000758">sio:SIO_000758</a>
    /// </summary>
    let SIO_000758 = _prefixId.prefix "SIO_000758"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000759^^xsd:string</para>
    ///   <para>rdfs:label : unique cell</para>
    ///   <para>dcterms:description : A unique cell is a cell that contains a unique value in the cellular automaton.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000759">sio:SIO_000759</a>
    /// </summary>
    let SIO_000759 = _prefixId.prefix "SIO_000759"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000760^^xsd:string</para>
    ///   <para>rdfs:label : referencing cell</para>
    ///   <para>dcterms:description : A referenceing cell is a cell of a cellular automata that refers to another cell.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000760">sio:SIO_000760</a>
    /// </summary>
    let SIO_000760 = _prefixId.prefix "SIO_000760"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000761^^xsd:string</para>
    ///   <para>rdfs:label : referent cell</para>
    ///   <para>dcterms:description : A referent cell is a cell that is the referent of some function or pointer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000761">sio:SIO_000761</a>
    /// </summary>
    let SIO_000761 = _prefixId.prefix "SIO_000761"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000762^^xsd:string</para>
    ///   <para>rdfs:label : database key</para>
    ///   <para>dcterms:description : A database key is an informational entity whose value is constructed from one or more database columns.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000762">sio:SIO_000762</a>
    /// </summary>
    let SIO_000762 = _prefixId.prefix "SIO_000762"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000763^^xsd:string</para>
    ///   <para>rdfs:label : primary database key</para>
    ///   <para>dcterms:description : A primary database key is a database key that identifies every row of a table.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000763">sio:SIO_000763</a>
    /// </summary>
    let SIO_000763 = _prefixId.prefix "SIO_000763"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000764^^xsd:string</para>
    ///   <para>rdfs:label : foreign database key</para>
    ///   <para>dcterms:description : A foreign database key is a database key that refers to a key in some table.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000764">sio:SIO_000764</a>
    /// </summary>
    let SIO_000764 = _prefixId.prefix "SIO_000764"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000765^^xsd:string</para>
    ///   <para>rdfs:label : probability value</para>
    ///   <para>sio:hasSynonym : p-value</para>
    ///   <para>dcterms:description : A p-value or probability value is the probability of obtaining a test statistic at least as extreme as the one that was actually observed, assuming that the null hypothesis is true</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000765">sio:SIO_000765</a>
    /// </summary>
    let SIO_000765 = _prefixId.prefix "SIO_000765"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000766^^xsd:string</para>
    ///   <para>rdfs:label : street name</para>
    ///   <para>dcterms:description : A street name is the token given to identify a particular street.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000766">sio:SIO_000766</a>
    /// </summary>
    let SIO_000766 = _prefixId.prefix "SIO_000766"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000767^^xsd:string</para>
    ///   <para>rdfs:label : postal code</para>
    ///   <para>dcterms:description : A postal code is a geographic coordinate composed of a series of letters and/or digits appended to a postal address for the purpose of sorting mail.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000767">sio:SIO_000767</a>
    /// </summary>
    let SIO_000767 = _prefixId.prefix "SIO_000767"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000768^^xsd:string</para>
    ///   <para>rdfs:label : apartment number</para>
    ///   <para>dcterms:description : An apartment number is the number assigned to identify an apartment in a building of apartments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000768">sio:SIO_000768</a>
    /// </summary>
    let SIO_000768 = _prefixId.prefix "SIO_000768"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000769^^xsd:string</para>
    ///   <para>rdfs:label : uncertainty value</para>
    ///   <para>dcterms:description : The uncertainty value (margin of error) of a measurement is a range of values likely to enclose the true value. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000769">sio:SIO_000769</a>
    /// </summary>
    let SIO_000769 = _prefixId.prefix "SIO_000769"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000770^^xsd:string</para>
    ///   <para>rdfs:label : standard deviation</para>
    ///   <para>dcterms:description : A standard deviation (represented by the symbol σ) is the quantity of  variation from the average (mean, or expected value).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000770">sio:SIO_000770</a>
    /// </summary>
    let SIO_000770 = _prefixId.prefix "SIO_000770"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000771^^xsd:string</para>
    ///   <para>rdfs:label : versioned record</para>
    ///   <para>dcterms:description : A versioned record is a record for which there exists another variant based that was derived via modification of the facts.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000771">sio:SIO_000771</a>
    /// </summary>
    let SIO_000771 = _prefixId.prefix "SIO_000771"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000772^^xsd:string</para>
    ///   <para>rdfs:label : has evidence</para>
    ///   <para>dcterms:description : has evidence is a relation between a proposition and something that demonstrates the truth of the assertion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000772">sio:SIO_000772</a>
    /// </summary>
    let SIO_000772 = _prefixId.prefix "SIO_000772"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000773^^xsd:string</para>
    ///   <para>rdfs:label : is evidence for</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000773">sio:SIO_000773</a>
    /// </summary>
    let SIO_000773 = _prefixId.prefix "SIO_000773"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000774^^xsd:string</para>
    ///   <para>rdfs:label : is refuted by</para>
    ///   <para>dcterms:description : has evidence is a relation between a proposition and something that refutes (is incompatible with) the truth of the assertion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000774">sio:SIO_000774</a>
    /// </summary>
    let SIO_000774 = _prefixId.prefix "SIO_000774"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000775^^xsd:string</para>
    ///   <para>rdfs:label : is refuting evidence for</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000775">sio:SIO_000775</a>
    /// </summary>
    let SIO_000775 = _prefixId.prefix "SIO_000775"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000776^^xsd:string</para>
    ///   <para>rdfs:label : object</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : An object is an entity that is wholly identifiable at any instant of time during which it exists.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000776">sio:SIO_000776</a>
    /// </summary>
    let SIO_000776 = _prefixId.prefix "SIO_000776"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000777^^xsd:string</para>
    ///   <para>rdfs:label : to be a member of</para>
    ///   <para>dcterms:description : to be a member of is the capability to be considered a part of a collection.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000777">sio:SIO_000777</a>
    /// </summary>
    let SIO_000777 = _prefixId.prefix "SIO_000777"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000778^^xsd:string</para>
    ///   <para>rdfs:label : to distort</para>
    ///   <para>dcterms:description : to distort is the capability to change the appearance of an entity by some transformation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000778">sio:SIO_000778</a>
    /// </summary>
    let SIO_000778 = _prefixId.prefix "SIO_000778"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000779^^xsd:string</para>
    ///   <para>rdfs:label : primer</para>
    ///   <para>dcterms:description : A primer is a nucleic acid that enables the synthesis of a complement strand of DNA by binding to it and acting as a point of transcription initiation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000779">sio:SIO_000779</a>
    /// </summary>
    let SIO_000779 = _prefixId.prefix "SIO_000779"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000780^^xsd:string</para>
    ///   <para>rdfs:label : to bind to</para>
    ///   <para>dcterms:description : to bind to is the capability to physically interact with another object through a set of non-covalent interactions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000780">sio:SIO_000780</a>
    /// </summary>
    let SIO_000780 = _prefixId.prefix "SIO_000780"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000783^^xsd:string</para>
    ///   <para>rdfs:label : spatial boundary</para>
    ///   <para>dcterms:description : A spatial boundary is the closure minus the interior of a subset of a topological space.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000783">sio:SIO_000783</a>
    /// </summary>
    let SIO_000783 = _prefixId.prefix "SIO_000783"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000784^^xsd:string</para>
    ///   <para>rdfs:label : hermaphrodite</para>
    ///   <para>sio:equivalentTo : PATO:0001827^^xsd:string</para>
    ///   <para>dcterms:description : hermaphrodite is a biological sex of an individual with both male and female sexual organs.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000784">sio:SIO_000784</a>
    /// </summary>
    let SIO_000784 = _prefixId.prefix "SIO_000784"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000785^^xsd:string</para>
    ///   <para>rdfs:label : answer</para>
    ///   <para>dcterms:description : An answer is a reply to a question.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000785">sio:SIO_000785</a>
    /// </summary>
    let SIO_000785 = _prefixId.prefix "SIO_000785"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000786^^xsd:string</para>
    ///   <para>rdfs:label : verbal language entity</para>
    ///   <para>dcterms:description : A verbal language entity is a language entity that is manifested through sound.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000786">sio:SIO_000786</a>
    /// </summary>
    let SIO_000786 = _prefixId.prefix "SIO_000786"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000787^^xsd:string</para>
    ///   <para>rdfs:label : page number</para>
    ///   <para>dcterms:description : A page number is the count of a page in a sequence of pages.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000787">sio:SIO_000787</a>
    /// </summary>
    let SIO_000787 = _prefixId.prefix "SIO_000787"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000788^^xsd:string</para>
    ///   <para>rdfs:label : linear position</para>
    ///   <para>dcterms:description : A linear position is the position of some object against a linear positioning system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000788">sio:SIO_000788</a>
    /// </summary>
    let SIO_000788 = _prefixId.prefix "SIO_000788"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000789^^xsd:string</para>
    ///   <para>rdfs:label : sequence element position</para>
    ///   <para>dcterms:description : A sequence element position is the position of an element of a linear sequence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000789">sio:SIO_000789</a>
    /// </summary>
    let SIO_000789 = _prefixId.prefix "SIO_000789"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000790^^xsd:string</para>
    ///   <para>rdfs:label : non-protein coding RNA (ncRNA) gene</para>
    ///   <para>sio:hasSynonym : ncRNA gene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0001263^^xsd:anyURI</para>
    ///   <para>dcterms:description : A non-protein coding RNA (ncRNA) gene is a gene that encodes for a RNA transcript that is not further translated into a protein product.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000790">sio:SIO_000790</a>
    /// </summary>
    let SIO_000790 = _prefixId.prefix "SIO_000790"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000791^^xsd:string</para>
    ///   <para>rdfs:label : sequence start position</para>
    ///   <para>dcterms:description : A sequence start position is the start position for a sequence of characters.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000791">sio:SIO_000791</a>
    /// </summary>
    let SIO_000791 = _prefixId.prefix "SIO_000791"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000792^^xsd:string</para>
    ///   <para>rdfs:label : sequence end position</para>
    ///   <para>dcterms:description : A sequence end position is the position of the last character in a sequence of characters relative to some linear frame of reference.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000792">sio:SIO_000792</a>
    /// </summary>
    let SIO_000792 = _prefixId.prefix "SIO_000792"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000793^^xsd:string</para>
    ///   <para>rdfs:label : measured at</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : measured at is a relation between a measurement value and the time measurement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000793">sio:SIO_000793</a>
    /// </summary>
    let SIO_000793 = _prefixId.prefix "SIO_000793"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000794^^xsd:string</para>
    ///   <para>rdfs:label : count</para>
    ///   <para>dcterms:description : The number of elements of a finite set of objects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000794">sio:SIO_000794</a>
    /// </summary>
    let SIO_000794 = _prefixId.prefix "SIO_000794"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000795^^xsd:string</para>
    ///   <para>rdfs:label : chemical entity role</para>
    ///   <para>dcterms:description : A chemical role is a processual role held by a chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000795">sio:SIO_000795</a>
    /// </summary>
    let SIO_000795 = _prefixId.prefix "SIO_000795"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000796^^xsd:string</para>
    ///   <para>rdfs:label : catalytic role</para>
    ///   <para>dcterms:description : The role of a chemical participant that serves to increase the rate of reaction by lowering the activiation energy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000796">sio:SIO_000796</a>
    /// </summary>
    let SIO_000796 = _prefixId.prefix "SIO_000796"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000797^^xsd:string</para>
    ///   <para>rdfs:label : substrate role</para>
    ///   <para>dcterms:description : The role of a chemical entity that is modified in a chemical reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000797">sio:SIO_000797</a>
    /// </summary>
    let SIO_000797 = _prefixId.prefix "SIO_000797"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000798^^xsd:string</para>
    ///   <para>rdfs:label : product role</para>
    ///   <para>dcterms:description : The role of a chemical entity present at the end of a chemical reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000798">sio:SIO_000798</a>
    /// </summary>
    let SIO_000798 = _prefixId.prefix "SIO_000798"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000799^^xsd:string</para>
    ///   <para>rdfs:label : cofactor role</para>
    ///   <para>dcterms:description : The role of a chemical entity involved in the mechanism for enzyme-mediated catalysis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000799">sio:SIO_000799</a>
    /// </summary>
    let SIO_000799 = _prefixId.prefix "SIO_000799"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000800^^xsd:string</para>
    ///   <para>rdfs:label : co-enzyme role</para>
    ///   <para>dcterms:description : A co-factor role in which the chemical entity is modified during catalysis and must be regenerated.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000800">sio:SIO_000800</a>
    /// </summary>
    let SIO_000800 = _prefixId.prefix "SIO_000800"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000801^^xsd:string</para>
    ///   <para>rdfs:label : prosthetic group role</para>
    ///   <para>dcterms:description : A coenzyme role of a chemical entity that is covalently bonded to the  enzyme.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000801">sio:SIO_000801</a>
    /// </summary>
    let SIO_000801 = _prefixId.prefix "SIO_000801"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000802^^xsd:string</para>
    ///   <para>rdfs:label : co-substrate role</para>
    ///   <para>dcterms:description : A co-enzyme role of a chemical entity that is transiently associated, and is regenerated in a separate reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000802">sio:SIO_000802</a>
    /// </summary>
    let SIO_000802 = _prefixId.prefix "SIO_000802"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000803^^xsd:string</para>
    ///   <para>rdfs:label : inhibitor role</para>
    ///   <para>dcterms:description : The role of a chemical entity that reduces the rate of reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000803">sio:SIO_000803</a>
    /// </summary>
    let SIO_000803 = _prefixId.prefix "SIO_000803"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000804^^xsd:string</para>
    ///   <para>rdfs:label : activator role</para>
    ///   <para>dcterms:description : The role of a chemical entity that increases the rate of reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000804">sio:SIO_000804</a>
    /// </summary>
    let SIO_000804 = _prefixId.prefix "SIO_000804"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000805^^xsd:string</para>
    ///   <para>rdfs:label : charged</para>
    ///   <para>dcterms:description : The quality of having a charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000805">sio:SIO_000805</a>
    /// </summary>
    let SIO_000805 = _prefixId.prefix "SIO_000805"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000806^^xsd:string</para>
    ///   <para>rdfs:label : uncharged</para>
    ///   <para>dcterms:description : The quality of not having a charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000806">sio:SIO_000806</a>
    /// </summary>
    let SIO_000806 = _prefixId.prefix "SIO_000806"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000807^^xsd:string</para>
    ///   <para>rdfs:label : partial positive charge</para>
    ///   <para>dcterms:description : A partial negative charge is a negative charge where the value of the charge is negative.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000807">sio:SIO_000807</a>
    /// </summary>
    let SIO_000807 = _prefixId.prefix "SIO_000807"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000808^^xsd:string</para>
    ///   <para>rdfs:label : partial negative charge</para>
    ///   <para>dcterms:description : A partial positive charge is a partial charge where the value of the charge is positive.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000808">sio:SIO_000808</a>
    /// </summary>
    let SIO_000808 = _prefixId.prefix "SIO_000808"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000809^^xsd:string</para>
    ///   <para>rdfs:label : partial charge</para>
    ///   <para>dcterms:description : The quality of having a charge that is not a full multiple of 1 unit charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000809">sio:SIO_000809</a>
    /// </summary>
    let SIO_000809 = _prefixId.prefix "SIO_000809"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000810^^xsd:string</para>
    ///   <para>rdfs:label : complete charge</para>
    ///   <para>dcterms:description : A complete charge is a charge where the value of the charge is a multiple of 1.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000810">sio:SIO_000810</a>
    /// </summary>
    let SIO_000810 = _prefixId.prefix "SIO_000810"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000811^^xsd:string</para>
    ///   <para>rdfs:label : URL</para>
    ///   <para>sio:hasSynonym : Uniform Resource Locator</para>
    ///   <para>dcterms:description : A Uniform Resource Locator or Universal Resource Locator (URL) is a specific character string that constitutes a reference to an Internet resource.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000811">sio:SIO_000811</a>
    /// </summary>
    let SIO_000811 = _prefixId.prefix "SIO_000811"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000812^^xsd:string</para>
    ///   <para>rdfs:label : affection</para>
    ///   <para>dcterms:description : affection is an emotion characterized with a feeling or type of love for another living thing.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000812">sio:SIO_000812</a>
    /// </summary>
    let SIO_000812 = _prefixId.prefix "SIO_000812"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000813^^xsd:string</para>
    ///   <para>rdfs:label : angst</para>
    ///   <para>dcterms:description : angst is the intense feeling of apprehension, anxiety or inner turmoil.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000813">sio:SIO_000813</a>
    /// </summary>
    let SIO_000813 = _prefixId.prefix "SIO_000813"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000814^^xsd:string</para>
    ///   <para>rdfs:label : annoyance</para>
    ///   <para>dcterms:description : Annoyance is an unpleasant emtion that is characterized by a abnormal or excessive sensitivity to some external stimulus.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000814">sio:SIO_000814</a>
    /// </summary>
    let SIO_000814 = _prefixId.prefix "SIO_000814"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000815^^xsd:string</para>
    ///   <para>rdfs:label : anxiety</para>
    ///   <para>dcterms:description : anxiety is an emotion charactersized by intense feeling of fear and concern coupled with a physical response.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000815">sio:SIO_000815</a>
    /// </summary>
    let SIO_000815 = _prefixId.prefix "SIO_000815"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000816^^xsd:string</para>
    ///   <para>rdfs:label : apathy</para>
    ///   <para>dcterms:description : apathy is an emotion characterized by lack of interest, enthusiasm, or concern.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000816">sio:SIO_000816</a>
    /// </summary>
    let SIO_000816 = _prefixId.prefix "SIO_000816"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000817^^xsd:string</para>
    ///   <para>rdfs:label : arousal</para>
    ///   <para>dcterms:description : arousal is an emotion characterized by state of reactive to stimuli. It involves the activation of the reticular activating system in the brain stem, the autonomic nervous system and the endocrine system, leading to increased heart rate and blood pressure and a condition of sensory alertness, mobility and readiness to respond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000817">sio:SIO_000817</a>
    /// </summary>
    let SIO_000817 = _prefixId.prefix "SIO_000817"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000818^^xsd:string</para>
    ///   <para>rdfs:label : awe</para>
    ///   <para>dcterms:description : awe is an emotion produced by that which is grand, sublime or powerful and is characterized by a combination of joy, fear and admiration/reverence/respect. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000818">sio:SIO_000818</a>
    /// </summary>
    let SIO_000818 = _prefixId.prefix "SIO_000818"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000819^^xsd:string</para>
    ///   <para>rdfs:label : boldness</para>
    ///   <para>dcterms:description : boldness is the trait of being willing to undertake things that involve risk or danger.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000819">sio:SIO_000819</a>
    /// </summary>
    let SIO_000819 = _prefixId.prefix "SIO_000819"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000820^^xsd:string</para>
    ///   <para>rdfs:label : boredom</para>
    ///   <para>dcterms:description : boredom is the emotion experience by those not interested in their surroundings or available activities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000820">sio:SIO_000820</a>
    /// </summary>
    let SIO_000820 = _prefixId.prefix "SIO_000820"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000821^^xsd:string</para>
    ///   <para>rdfs:label : contempt</para>
    ///   <para>dcterms:description : contempt is disgust towards a lower status individual.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000821">sio:SIO_000821</a>
    /// </summary>
    let SIO_000821 = _prefixId.prefix "SIO_000821"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000822^^xsd:string</para>
    ///   <para>rdfs:label : contentment</para>
    ///   <para>dcterms:description : contentment is an emotion characterized by acknowledgement and satisfaction of the current state of affairs.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000822">sio:SIO_000822</a>
    /// </summary>
    let SIO_000822 = _prefixId.prefix "SIO_000822"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000823^^xsd:string</para>
    ///   <para>rdfs:label : curiosity</para>
    ///   <para>dcterms:description : curiosity is the strong desire to know or learn something.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000823">sio:SIO_000823</a>
    /// </summary>
    let SIO_000823 = _prefixId.prefix "SIO_000823"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000824^^xsd:string</para>
    ///   <para>rdfs:label : depression</para>
    ///   <para>sio:hasSynonym : depressed^^xsd:string</para>
    ///   <para>dcterms:description : depression is an unpleasant emotion linked to aversion to activity that can affect a person's thoughts, behavior, feelings and physical well-being. Depressed individuals may feel sad, anxious, empty, hopeless, worried, helpless, worthless, guilty, irritable, or restless.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000824">sio:SIO_000824</a>
    /// </summary>
    let SIO_000824 = _prefixId.prefix "SIO_000824"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000825^^xsd:string</para>
    ///   <para>rdfs:label : desire</para>
    ///   <para>dcterms:description : desire is a strong emotion of wanting to have something or wishing for something to happen.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000825">sio:SIO_000825</a>
    /// </summary>
    let SIO_000825 = _prefixId.prefix "SIO_000825"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000826^^xsd:string</para>
    ///   <para>rdfs:label : despair</para>
    ///   <para>dcterms:description : despair is depression, hopelessness or lack of hope.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000826">sio:SIO_000826</a>
    /// </summary>
    let SIO_000826 = _prefixId.prefix "SIO_000826"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000827^^xsd:string</para>
    ///   <para>rdfs:label : disappointment</para>
    ///   <para>sio:hasSynonym : disappointing^^xsd:stringsio:hasSynonym : disappointed^^xsd:string</para>
    ///   <para>dcterms:description : disappointment is the feeling of dissatisfaction that follows the failure of expectations or hopes to manifest.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000827">sio:SIO_000827</a>
    /// </summary>
    let SIO_000827 = _prefixId.prefix "SIO_000827"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000828^^xsd:string</para>
    ///   <para>rdfs:label : disgust</para>
    ///   <para>dcterms:description : Disgust is a feeling of revulsion or profound disapproval aroused by something unpleasant or offensive.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000828">sio:SIO_000828</a>
    /// </summary>
    let SIO_000828 = _prefixId.prefix "SIO_000828"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000829^^xsd:string</para>
    ///   <para>rdfs:label : dread</para>
    ///   <para>dcterms:description : dread is the instense negative emotion that induces fear and apprehension.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000829">sio:SIO_000829</a>
    /// </summary>
    let SIO_000829 = _prefixId.prefix "SIO_000829"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000830^^xsd:string</para>
    ///   <para>rdfs:label : ecstasy</para>
    ///   <para>dcterms:description : ecstacy is an emotion characterized by a heightened state of consciousness with total involvement of a subject.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000830">sio:SIO_000830</a>
    /// </summary>
    let SIO_000830 = _prefixId.prefix "SIO_000830"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000831^^xsd:string</para>
    ///   <para>rdfs:label : positive emotion</para>
    ///   <para>dcterms:description : A positive emotion is an emotion that feels good.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000831">sio:SIO_000831</a>
    /// </summary>
    let SIO_000831 = _prefixId.prefix "SIO_000831"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000832^^xsd:string</para>
    ///   <para>rdfs:label : negative emotion</para>
    ///   <para>dcterms:description : negative emotion is an emotion that does not feel good.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000832">sio:SIO_000832</a>
    /// </summary>
    let SIO_000832 = _prefixId.prefix "SIO_000832"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000833^^xsd:string</para>
    ///   <para>rdfs:label : embarassment</para>
    ///   <para>dcterms:description : Embarrassment is the emotion of intense discomfort with oneself, experienced upon having a socially unacceptable act or condition witnessed by or revealed to other.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000833">sio:SIO_000833</a>
    /// </summary>
    let SIO_000833 = _prefixId.prefix "SIO_000833"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000834^^xsd:string</para>
    ///   <para>rdfs:label : envy</para>
    ///   <para>dcterms:description : envy is an emotion that occurs when a person lacks another's (perceived) superior quality, achievement or possession and wishes that the other lacked it.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000834">sio:SIO_000834</a>
    /// </summary>
    let SIO_000834 = _prefixId.prefix "SIO_000834"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000835^^xsd:string</para>
    ///   <para>rdfs:label : euphoria</para>
    ///   <para>dcterms:description : euphoria is an emotion characterized by intense feelings of well-being, elation, happiness, ecstasy, excitement, and joy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000835">sio:SIO_000835</a>
    /// </summary>
    let SIO_000835 = _prefixId.prefix "SIO_000835"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000836^^xsd:string</para>
    ///   <para>rdfs:label : excitement</para>
    ///   <para>dcterms:description : excitement is a positive emotion of feeling great enthusiasm and eagerness.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000836">sio:SIO_000836</a>
    /// </summary>
    let SIO_000836 = _prefixId.prefix "SIO_000836"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000837^^xsd:string</para>
    ///   <para>rdfs:label : fear</para>
    ///   <para>dcterms:description : Fear is a negative emotion induced by a perceived threat that induces one to hide or move quickly away from the location of the perceived threat.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000837">sio:SIO_000837</a>
    /// </summary>
    let SIO_000837 = _prefixId.prefix "SIO_000837"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000838^^xsd:string</para>
    ///   <para>rdfs:label : frustration</para>
    ///   <para>dcterms:description : Frustration is an emotion that arises from the perceived resistance to the fulfillment of individual will. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000838">sio:SIO_000838</a>
    /// </summary>
    let SIO_000838 = _prefixId.prefix "SIO_000838"
    /// <summary>
    ///   <para>sio:hasSynonym : thankfullness^^xsd:stringsio:hasSynonym : gratification^^xsd:stringsio:hasSynonym : gratefulness^^xsd:stringsio:hasSynonym : appreciation^^xsd:string</para>
    ///   <para>dcterms:description : Gratitude, thankfulness, gratefulness, or appreciation is a feeling, emotion or attitude in acknowledgment of a benefit that one has received or will receive.</para>
    ///   <para>rdfs:label : gratitude</para>
    ///   <para>dc11:identifier : SIO_000839^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000839">sio:SIO_000839</a>
    /// </summary>
    let SIO_000839 = _prefixId.prefix "SIO_000839"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000840^^xsd:string</para>
    ///   <para>rdfs:label : happiness</para>
    ///   <para>dcterms:description : happiness is an emotion characterized by positive or pleasant emotions ranging from contentment to intense joy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000840">sio:SIO_000840</a>
    /// </summary>
    let SIO_000840 = _prefixId.prefix "SIO_000840"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000841^^xsd:string</para>
    ///   <para>rdfs:label : guilt</para>
    ///   <para>sio:hasSynonym : guilty^^xsd:string</para>
    ///   <para>dcterms:description : Guilt is the emotion borne from feeling responsible for the commission of an offense and arises out of public humiliation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000841">sio:SIO_000841</a>
    /// </summary>
    let SIO_000841 = _prefixId.prefix "SIO_000841"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000842^^xsd:string</para>
    ///   <para>rdfs:label : grief</para>
    ///   <para>dcterms:description : grief is an emotion in response to loss, whether physical or abstract including death, unemployment, ill health or the end of a relationship.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000842">sio:SIO_000842</a>
    /// </summary>
    let SIO_000842 = _prefixId.prefix "SIO_000842"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000843^^xsd:string</para>
    ///   <para>rdfs:label : hope</para>
    ///   <para>dcterms:description : hope is an emotion of belief in a positive outcome related to events and circumstances in one's life.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000843">sio:SIO_000843</a>
    /// </summary>
    let SIO_000843 = _prefixId.prefix "SIO_000843"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000844^^xsd:string</para>
    ///   <para>rdfs:label : hostility</para>
    ///   <para>dcterms:description : Hostility is the intense negative emotion of being in conflict or opposition to someone or something.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000844">sio:SIO_000844</a>
    /// </summary>
    let SIO_000844 = _prefixId.prefix "SIO_000844"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000845^^xsd:string</para>
    ///   <para>rdfs:label : hurt</para>
    ///   <para>dcterms:description : hurt is an unpleasant feeling, emotion or sensation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000845">sio:SIO_000845</a>
    /// </summary>
    let SIO_000845 = _prefixId.prefix "SIO_000845"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000846^^xsd:string</para>
    ///   <para>rdfs:label : hysteria</para>
    ///   <para>dcterms:description : Hysteria is an unmanageable emotion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000846">sio:SIO_000846</a>
    /// </summary>
    let SIO_000846 = _prefixId.prefix "SIO_000846"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000847^^xsd:string</para>
    ///   <para>rdfs:label : indifference</para>
    ///   <para>dcterms:description : indifference is an emotion characterized by lack of interest, concern, or sympathy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000847">sio:SIO_000847</a>
    /// </summary>
    let SIO_000847 = _prefixId.prefix "SIO_000847"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000848^^xsd:string</para>
    ///   <para>rdfs:label : interest</para>
    ///   <para>dcterms:description : interest is the emotion of wanting to know or learn about something or someone.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000848">sio:SIO_000848</a>
    /// </summary>
    let SIO_000848 = _prefixId.prefix "SIO_000848"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000849^^xsd:string</para>
    ///   <para>rdfs:label : jealousy</para>
    ///   <para>dcterms:description : jealousy is an emotion and typically refers to the negative thoughts and feelings of insecurity, fear, and anxiety over an anticipated loss of something that the person values, particularly in reference to a human connection.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000849">sio:SIO_000849</a>
    /// </summary>
    let SIO_000849 = _prefixId.prefix "SIO_000849"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000850^^xsd:string</para>
    ///   <para>rdfs:label : joy</para>
    ///   <para>dcterms:description : joy is an emotion of intense happiness.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000850">sio:SIO_000850</a>
    /// </summary>
    let SIO_000850 = _prefixId.prefix "SIO_000850"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000851^^xsd:string</para>
    ///   <para>rdfs:label : loathing</para>
    ///   <para>dcterms:description : loathing is an intense dislike or disgust.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000851">sio:SIO_000851</a>
    /// </summary>
    let SIO_000851 = _prefixId.prefix "SIO_000851"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000852^^xsd:string</para>
    ///   <para>rdfs:label : loneliness</para>
    ///   <para>dcterms:description : Loneliness is an unpleasant emotion in which a person feels a strong sense of emptiness, yearning distress and solitude resulting from inadequate quantity or quality of social relationships.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000852">sio:SIO_000852</a>
    /// </summary>
    let SIO_000852 = _prefixId.prefix "SIO_000852"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000853^^xsd:string</para>
    ///   <para>rdfs:label : lust</para>
    ///   <para>dcterms:description : lust is the strong desire for sex.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000853">sio:SIO_000853</a>
    /// </summary>
    let SIO_000853 = _prefixId.prefix "SIO_000853"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000854^^xsd:string</para>
    ///   <para>rdfs:label : misery</para>
    ///   <para>dcterms:description : misery is a feeling of great unhappiness, suffering and/or pain.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000854">sio:SIO_000854</a>
    /// </summary>
    let SIO_000854 = _prefixId.prefix "SIO_000854"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000855^^xsd:string</para>
    ///   <para>rdfs:label : panic</para>
    ///   <para>dcterms:description : Panic is a sudden emotion of fear which is so strong as to dominate or prevent reason and logical thinking, replacing it with overwhelming feelings of anxiety and frantic agitation consistent with an animalistic fight-or-flight reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000855">sio:SIO_000855</a>
    /// </summary>
    let SIO_000855 = _prefixId.prefix "SIO_000855"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000856^^xsd:string</para>
    ///   <para>rdfs:label : passion</para>
    ///   <para>dcterms:description : passion is the intense desire for something.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000856">sio:SIO_000856</a>
    /// </summary>
    let SIO_000856 = _prefixId.prefix "SIO_000856"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000857^^xsd:string</para>
    ///   <para>rdfs:label : pity</para>
    ///   <para>dcterms:description : Pity is the emotion of sadness or sorrow for another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000857">sio:SIO_000857</a>
    /// </summary>
    let SIO_000857 = _prefixId.prefix "SIO_000857"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000858^^xsd:string</para>
    ///   <para>rdfs:label : pleasure</para>
    ///   <para>dcterms:description : pleasure is an emotion of happy satisfaction and enjoyment.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000858">sio:SIO_000858</a>
    /// </summary>
    let SIO_000858 = _prefixId.prefix "SIO_000858"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000859^^xsd:string</para>
    ///   <para>rdfs:label : pride</para>
    ///   <para>dcterms:description : pride is an emotion of satisfaction of attachment toward one's own or another's choices and actions, or toward a whole group of people, and is a product of praise, independent self-reflection, or a fulfilled feeling of belonging.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000859">sio:SIO_000859</a>
    /// </summary>
    let SIO_000859 = _prefixId.prefix "SIO_000859"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000860^^xsd:string</para>
    ///   <para>rdfs:label : rage</para>
    ///   <para>dcterms:description : Rage is a feeling of intense anger that is associated with the Fight-or-flight response.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000860">sio:SIO_000860</a>
    /// </summary>
    let SIO_000860 = _prefixId.prefix "SIO_000860"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000861^^xsd:string</para>
    ///   <para>rdfs:label : regret</para>
    ///   <para>dcterms:description : regret is a feeling of sadness, repentance, or disappointment over something that has happened or been done.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000861">sio:SIO_000861</a>
    /// </summary>
    let SIO_000861 = _prefixId.prefix "SIO_000861"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000862^^xsd:string</para>
    ///   <para>rdfs:label : remorse</para>
    ///   <para>dcterms:description : remorse is an emotion of personal regret felt by a person after he or she has committed an act which they deem to be shameful, hurtful, or violent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000862">sio:SIO_000862</a>
    /// </summary>
    let SIO_000862 = _prefixId.prefix "SIO_000862"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000863^^xsd:string</para>
    ///   <para>rdfs:label : sadness</para>
    ///   <para>sio:hasSynonym : unhappy^^xsd:stringsio:hasSynonym : unhappiness^^xsd:stringsio:hasSynonym : sad^^xsd:string</para>
    ///   <para>dcterms:description : sadness is emotional pain associated with, or characterized by feelings of disadvantage, loss, despair, helplessness, sorrow, and rage.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000863">sio:SIO_000863</a>
    /// </summary>
    let SIO_000863 = _prefixId.prefix "SIO_000863"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000864^^xsd:string</para>
    ///   <para>rdfs:label : satisfaction</para>
    ///   <para>dcterms:description : satisfaction is an emotion of fulfillment of one's wishes, expectations, or needs, or the pleasure derived from this.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000864">sio:SIO_000864</a>
    /// </summary>
    let SIO_000864 = _prefixId.prefix "SIO_000864"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000865^^xsd:string</para>
    ///   <para>rdfs:label : shame</para>
    ///   <para>dcterms:description : shame is the emotion borne from feeling responsible for the commission of an offense.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000865">sio:SIO_000865</a>
    /// </summary>
    let SIO_000865 = _prefixId.prefix "SIO_000865"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000866^^xsd:string</para>
    ///   <para>rdfs:label : shock</para>
    ///   <para>dcterms:description : shock is an emotion of sudden upset or surprise.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000866">sio:SIO_000866</a>
    /// </summary>
    let SIO_000866 = _prefixId.prefix "SIO_000866"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000867^^xsd:string</para>
    ///   <para>rdfs:label : shyness</para>
    ///   <para>dcterms:description : shyness is an emotion of apprehension, lack of comfort, or awkwardness experienced when in proximity to, approaching, or being approached by other individuals, especially in new situations or with unfamiliar individuals.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000867">sio:SIO_000867</a>
    /// </summary>
    let SIO_000867 = _prefixId.prefix "SIO_000867"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000868^^xsd:string</para>
    ///   <para>rdfs:label : sorrow</para>
    ///   <para>dcterms:description : sorrow is the emotion that is characterized by a long term state of intense sadness, distress and a degree of resignation (not accepting).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000868">sio:SIO_000868</a>
    /// </summary>
    let SIO_000868 = _prefixId.prefix "SIO_000868"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000869^^xsd:string</para>
    ///   <para>rdfs:label : suffering</para>
    ///   <para>dcterms:description : Suffering is the unpleasant emotion and aversion associated with the perception of harm or threat of harm in an individual.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000869">sio:SIO_000869</a>
    /// </summary>
    let SIO_000869 = _prefixId.prefix "SIO_000869"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000870^^xsd:string</para>
    ///   <para>rdfs:label : surprise</para>
    ///   <para>dcterms:description : surprise is a brief emotion experienced as the result of an unexpected event. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000870">sio:SIO_000870</a>
    /// </summary>
    let SIO_000870 = _prefixId.prefix "SIO_000870"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000871^^xsd:string</para>
    ///   <para>rdfs:label : terror</para>
    ///   <para>dcterms:description : terror is the extreme feeling of fear.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000871">sio:SIO_000871</a>
    /// </summary>
    let SIO_000871 = _prefixId.prefix "SIO_000871"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000872^^xsd:string</para>
    ///   <para>rdfs:label : wonder</para>
    ///   <para>dcterms:description : wonder is an emotion of perceiving something very rare or unexpected, but not threatening.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000872">sio:SIO_000872</a>
    /// </summary>
    let SIO_000872 = _prefixId.prefix "SIO_000872"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000873^^xsd:string</para>
    ///   <para>rdfs:label : worry</para>
    ///   <para>dcterms:description : worry is the emotion characterized by concer over a real or imaginary issue.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000873">sio:SIO_000873</a>
    /// </summary>
    let SIO_000873 = _prefixId.prefix "SIO_000873"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000875^^xsd:string</para>
    ///   <para>rdfs:label : department chair role</para>
    ///   <para>dcterms:description : A department chain role is the role of an individual that heads a department at a academic organization.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000875">sio:SIO_000875</a>
    /// </summary>
    let SIO_000875 = _prefixId.prefix "SIO_000875"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000876^^xsd:string</para>
    ///   <para>rdfs:label : student advisor role</para>
    ///   <para>dcterms:description : A student advisor role is the role of an individual employed at an academic organization that is involved in advising students.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000876">sio:SIO_000876</a>
    /// </summary>
    let SIO_000876 = _prefixId.prefix "SIO_000876"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000877^^xsd:string</para>
    ///   <para>rdfs:label : undergraduate student advisor role</para>
    ///   <para>dcterms:description : An undergraduate student advisor role is the role of an individual employed at an academic organization that is involved in advising undergraduate students.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000877">sio:SIO_000877</a>
    /// </summary>
    let SIO_000877 = _prefixId.prefix "SIO_000877"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000878^^xsd:string</para>
    ///   <para>rdfs:label : graduate student advisor role</para>
    ///   <para>dcterms:description : A graduate student advisor role is the role of an individual employed at an academic organization that is involved in advising graduate students.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000878">sio:SIO_000878</a>
    /// </summary>
    let SIO_000878 = _prefixId.prefix "SIO_000878"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000879^^xsd:string</para>
    ///   <para>rdfs:label : reactant role</para>
    ///   <para>dcterms:description : The role of a chemical entity present at the beginning of a chemical reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000879">sio:SIO_000879</a>
    /// </summary>
    let SIO_000879 = _prefixId.prefix "SIO_000879"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000880^^xsd:string</para>
    ///   <para>rdfs:label : regulator role</para>
    ///   <para>dcterms:description : The role of a chemical entity that modifies the rate of reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000880">sio:SIO_000880</a>
    /// </summary>
    let SIO_000880 = _prefixId.prefix "SIO_000880"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000881^^xsd:string</para>
    ///   <para>rdfs:label : investigational role</para>
    ///   <para>dcterms:description : An investigational role is a role held by participants involved in an investigation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000881">sio:SIO_000881</a>
    /// </summary>
    let SIO_000881 = _prefixId.prefix "SIO_000881"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000882^^xsd:string</para>
    ///   <para>rdfs:label : host role</para>
    ///   <para>dcterms:description : The role of an organism in providing resources to maintain the survival and/or reproduction of another organism.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000882">sio:SIO_000882</a>
    /// </summary>
    let SIO_000882 = _prefixId.prefix "SIO_000882"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000883^^xsd:string</para>
    ///   <para>rdfs:label : subject role</para>
    ///   <para>dcterms:description : A subject role is the role of an individual that is the target of the study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000883">sio:SIO_000883</a>
    /// </summary>
    let SIO_000883 = _prefixId.prefix "SIO_000883"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000884^^xsd:string</para>
    ///   <para>rdfs:label : publishing role</para>
    ///   <para>dcterms:description : A publishing role is the role of an individual that is involved in the preparation and issue of creative works for consumption by a wider audience.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000884">sio:SIO_000884</a>
    /// </summary>
    let SIO_000884 = _prefixId.prefix "SIO_000884"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000885^^xsd:string</para>
    ///   <para>rdfs:label : publisher role</para>
    ///   <para>dcterms:description : A publisher role is the role of an individual that prepares and issues creative works.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000885">sio:SIO_000885</a>
    /// </summary>
    let SIO_000885 = _prefixId.prefix "SIO_000885"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000886^^xsd:string</para>
    ///   <para>rdfs:label : author role</para>
    ///   <para>dcterms:description : An author role is the role of an individual that creates a creative, written work.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000886">sio:SIO_000886</a>
    /// </summary>
    let SIO_000886 = _prefixId.prefix "SIO_000886"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000887^^xsd:string</para>
    ///   <para>rdfs:label : buffer role</para>
    ///   <para>dcterms:description : A buffer role is the role of a chemical substance which maintains a pH at a near constant value.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000887">sio:SIO_000887</a>
    /// </summary>
    let SIO_000887 = _prefixId.prefix "SIO_000887"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000888^^xsd:string</para>
    ///   <para>rdfs:label : chemical substance role</para>
    ///   <para>dcterms:description : A chemical substance role is a chemical entity role held by a chemical substance.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000888">sio:SIO_000888</a>
    /// </summary>
    let SIO_000888 = _prefixId.prefix "SIO_000888"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000889^^xsd:string</para>
    ///   <para>rdfs:label : molecular entity role</para>
    ///   <para>dcterms:description : A molecular entity role is a chemical entity role held by a molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000889">sio:SIO_000889</a>
    /// </summary>
    let SIO_000889 = _prefixId.prefix "SIO_000889"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000890^^xsd:string</para>
    ///   <para>rdfs:label : toxin role</para>
    ///   <para>dcterms:description : A toxin role is a toxic role of a chemical substance that is poisonous and is produced by an organism.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000890">sio:SIO_000890</a>
    /// </summary>
    let SIO_000890 = _prefixId.prefix "SIO_000890"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000891^^xsd:string</para>
    ///   <para>rdfs:label : toxic role</para>
    ///   <para>dcterms:description : A toxic role is the role of a chemical substance that is poisonous.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000891">sio:SIO_000891</a>
    /// </summary>
    let SIO_000891 = _prefixId.prefix "SIO_000891"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000892^^xsd:string</para>
    ///   <para>rdfs:label : in relation from</para>
    ///   <para>dcterms:description : a in relation from b is a comparative relation in a is the object of reference in a relation with b. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000892">sio:SIO_000892</a>
    /// </summary>
    let SIO_000892 = _prefixId.prefix "SIO_000892"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000893^^xsd:string</para>
    ///   <para>rdfs:label : reagent role</para>
    ///   <para>dcterms:description : A role of a chemical substance that participates in a chemical reaction as part of some scientific investigation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000893">sio:SIO_000893</a>
    /// </summary>
    let SIO_000893 = _prefixId.prefix "SIO_000893"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000894^^xsd:string</para>
    ///   <para>rdfs:label : to luminesce</para>
    ///   <para>dcterms:description : to luminesce is to emit light through cold body radiation</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000894">sio:SIO_000894</a>
    /// </summary>
    let SIO_000894 = _prefixId.prefix "SIO_000894"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000895^^xsd:string</para>
    ///   <para>rdfs:label : to fluoresce</para>
    ///   <para>dcterms:description : to fluoresce is to emit light as a result of absorbing light or other electromagnetic radiation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000895">sio:SIO_000895</a>
    /// </summary>
    let SIO_000895 = _prefixId.prefix "SIO_000895"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000896^^xsd:string</para>
    ///   <para>rdfs:label : molecular tracer role</para>
    ///   <para>dcterms:description : A molecular tracer role is a reactant role of a molecular entity that serves as a marker for the presence, abundance, or location of a molecular target that it associates with.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000896">sio:SIO_000896</a>
    /// </summary>
    let SIO_000896 = _prefixId.prefix "SIO_000896"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000897^^xsd:string</para>
    ///   <para>rdfs:label : association</para>
    ///   <para>dcterms:description : An assocation is a relationship between two or more entities derived by some informational analysis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000897">sio:SIO_000897</a>
    /// </summary>
    let SIO_000897 = _prefixId.prefix "SIO_000897"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000898^^xsd:string</para>
    ///   <para>rdfs:label : statistical association</para>
    ///   <para>dcterms:description : A statistical association is any relationship between two measured quantities that renders them statistically dependent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000898">sio:SIO_000898</a>
    /// </summary>
    let SIO_000898 = _prefixId.prefix "SIO_000898"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000899^^xsd:string</para>
    ///   <para>rdfs:label : chromosome</para>
    ///   <para>dcterms:description : A chromosome is a molecular complex of circular or linear DNA and bound proteins.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000899">sio:SIO_000899</a>
    /// </summary>
    let SIO_000899 = _prefixId.prefix "SIO_000899"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000900^^xsd:string</para>
    ///   <para>rdfs:label : has frequency</para>
    ///   <para>dcterms:description : has frequency is a relation that specifies the occurence of an object or event</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000900">sio:SIO_000900</a>
    /// </summary>
    let SIO_000900 = _prefixId.prefix "SIO_000900"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000901^^xsd:string</para>
    ///   <para>rdfs:label : is frequency of</para>
    ///   <para>dcterms:description : is frequency of is a relation between a temporal unit and an object or event</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000901">sio:SIO_000901</a>
    /// </summary>
    let SIO_000901 = _prefixId.prefix "SIO_000901"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000902^^xsd:string</para>
    ///   <para>rdfs:label : top value axis</para>
    ///   <para>dcterms:description : A top value axis is a value axis that is spatially positioned to the top of the plot area.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000902">sio:SIO_000902</a>
    /// </summary>
    let SIO_000902 = _prefixId.prefix "SIO_000902"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000903^^xsd:string</para>
    ///   <para>rdfs:label : bottom value axis</para>
    ///   <para>dcterms:description : A bottom value axis is a value axis that is spatially positioned to the bottom of the plot area.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000903">sio:SIO_000903</a>
    /// </summary>
    let SIO_000903 = _prefixId.prefix "SIO_000903"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000904^^xsd:string</para>
    ///   <para>rdfs:label : chart</para>
    ///   <para>dcterms:description : A chart is a figure that displays the relationship among tabular numeric data, functions or some kinds of qualitative structures.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000904">sio:SIO_000904</a>
    /// </summary>
    let SIO_000904 = _prefixId.prefix "SIO_000904"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000905^^xsd:string</para>
    ///   <para>rdfs:label : has substrate</para>
    ///   <para>dcterms:description : has substrate is a relation between a process and an object where the object is destroyed by its participation in the process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000905">sio:SIO_000905</a>
    /// </summary>
    let SIO_000905 = _prefixId.prefix "SIO_000905"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000906^^xsd:string</para>
    ///   <para>rdfs:label : map</para>
    ///   <para>dcterms:description : A map is a a visual representation of an area that depicts the relationship between elements of that space.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000906">sio:SIO_000906</a>
    /// </summary>
    let SIO_000906 = _prefixId.prefix "SIO_000906"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000907^^xsd:string</para>
    ///   <para>rdfs:label : heatmap</para>
    ///   <para>dcterms:description : A heatmap is a graphical representation of data where the individual values contained in a matrix are represented as colors.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000907">sio:SIO_000907</a>
    /// </summary>
    let SIO_000907 = _prefixId.prefix "SIO_000907"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000908^^xsd:string</para>
    ///   <para>rdfs:label : streamgraph</para>
    ///   <para>dcterms:description : A streamgraph is a multi-line stacked graph that yields the appearance of continuous y-values across the x-axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000908">sio:SIO_000908</a>
    /// </summary>
    let SIO_000908 = _prefixId.prefix "SIO_000908"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000909^^xsd:string</para>
    ///   <para>rdfs:label : boxplot</para>
    ///   <para>dcterms:description : A boxplot (box-and-whisker diagram) is a convenient way of graphically depicting groups of numerical data through their five-number summaries: the smallest observation (sample minimum), lower quartile (Q1), median (Q2), upper quartile (Q3), and largest observation (sample maximum).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000909">sio:SIO_000909</a>
    /// </summary>
    let SIO_000909 = _prefixId.prefix "SIO_000909"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000910^^xsd:string</para>
    ///   <para>rdfs:label : geographic heatmap</para>
    ///   <para>dcterms:description : A geographic heatmap is a graphical representation of data over a geographic region where individual values are represented as colors.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000910">sio:SIO_000910</a>
    /// </summary>
    let SIO_000910 = _prefixId.prefix "SIO_000910"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000911^^xsd:string</para>
    ///   <para>rdfs:label : histogram</para>
    ///   <para>dcterms:description : A histogram is a graphical representation of data which consists of tabular frequencies, shown as adjacent rectangles, over discrete intervals (bins) , with an area equal to the frequency of the observations in the interval.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000911">sio:SIO_000911</a>
    /// </summary>
    let SIO_000911 = _prefixId.prefix "SIO_000911"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000912^^xsd:string</para>
    ///   <para>rdfs:label : measurement scale</para>
    ///   <para>dcterms:description : A measurement scale is a functional specification that specifies an allowed range of categories or values.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000912">sio:SIO_000912</a>
    /// </summary>
    let SIO_000912 = _prefixId.prefix "SIO_000912"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000913^^xsd:string</para>
    ///   <para>rdfs:label : nomimal scale</para>
    ///   <para>dcterms:description : A nominal scale of measurement only specifies a limited set of categories.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000913">sio:SIO_000913</a>
    /// </summary>
    let SIO_000913 = _prefixId.prefix "SIO_000913"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000914^^xsd:string</para>
    ///   <para>rdfs:label : binary scale</para>
    ///   <para>dcterms:description : A binary scale is a measurement scale that specifies a choice between two values.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000914">sio:SIO_000914</a>
    /// </summary>
    let SIO_000914 = _prefixId.prefix "SIO_000914"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000915^^xsd:string</para>
    ///   <para>rdfs:label : numeric scale</para>
    ///   <para>dcterms:description : A numeric scale of measurement is one that only specifies numeric values.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000915">sio:SIO_000915</a>
    /// </summary>
    let SIO_000915 = _prefixId.prefix "SIO_000915"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000916^^xsd:string</para>
    ///   <para>rdfs:label : decimal scale</para>
    ///   <para>dcterms:description : A decimal scale of measurement is one that only specifies decimal values.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000916">sio:SIO_000916</a>
    /// </summary>
    let SIO_000916 = _prefixId.prefix "SIO_000916"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000917^^xsd:string</para>
    ///   <para>rdfs:label : integer scale</para>
    ///   <para>dcterms:description : An integer scale of measurement is one that only specifies integer values.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000917">sio:SIO_000917</a>
    /// </summary>
    let SIO_000917 = _prefixId.prefix "SIO_000917"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000918^^xsd:string</para>
    ///   <para>rdfs:label : modifying</para>
    ///   <para>sio:hasSynonym : modification</para>
    ///   <para>dcterms:description : modifying is the process by which an entity gains or loses parts, qualities, roles, dispositions, functions, etc, but maintains their identity through these changes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000918">sio:SIO_000918</a>
    /// </summary>
    let SIO_000918 = _prefixId.prefix "SIO_000918"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000919^^xsd:string</para>
    ///   <para>rdfs:label : reproducing</para>
    ///   <para>dcterms:description : reproducing is a process characterized by creation of an entity that is similar or exactly the same as the template from which it is derived.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000919">sio:SIO_000919</a>
    /// </summary>
    let SIO_000919 = _prefixId.prefix "SIO_000919"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000920^^xsd:string</para>
    ///   <para>rdfs:label : independent variable</para>
    ///   <para>dcterms:description : An independent variable is a variable that may take on different values independent of other elements in a system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000920">sio:SIO_000920</a>
    /// </summary>
    let SIO_000920 = _prefixId.prefix "SIO_000920"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000921^^xsd:string</para>
    ///   <para>rdfs:label : dependent variable</para>
    ///   <para>dcterms:description : A dependent variable is one whose value changes as a consequence of changes in other values in the system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000921">sio:SIO_000921</a>
    /// </summary>
    let SIO_000921 = _prefixId.prefix "SIO_000921"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000922^^xsd:string</para>
    ///   <para>rdfs:label : Gantt chart</para>
    ///   <para>dcterms:description : A Gantt chart is a bar chart that illustrates a project schedule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000922">sio:SIO_000922</a>
    /// </summary>
    let SIO_000922 = _prefixId.prefix "SIO_000922"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000923^^xsd:string</para>
    ///   <para>rdfs:label : correlation</para>
    ///   <para>dcterms:description : A correlation is a statistical relationship involving dependence between two random variables or datasets.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000923">sio:SIO_000923</a>
    /// </summary>
    let SIO_000923 = _prefixId.prefix "SIO_000923"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000924^^xsd:string</para>
    ///   <para>rdfs:label : television program</para>
    ///   <para>dcterms:description : A television program is a audiovisual media that is produced and broadcast using a television.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000924">sio:SIO_000924</a>
    /// </summary>
    let SIO_000924 = _prefixId.prefix "SIO_000924"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000926^^xsd:string</para>
    ///   <para>rdfs:label : radio receiver</para>
    ///   <para>dcterms:description : A radio receiver is a communication device that receives its input from an antenna, uses electronic filters to separate a wanted radio signal from all other signals picked up by this antenna, amplifies it to a level suitable for further processing, and finally converts through demodulation and decoding the signal into a form usable for the consumer, such as sound, pictures, digital data, measurement values, navigational positions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000926">sio:SIO_000926</a>
    /// </summary>
    let SIO_000926 = _prefixId.prefix "SIO_000926"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000927^^xsd:string</para>
    ///   <para>rdfs:label : telephone</para>
    ///   <para>dcterms:description : The telephone is a communications device that transmits and receives sounds, and are minimally composed of a microphone to speak into, a speaker'which reproduces the voice of the other person and a ringer which makes a sound to alert the owner when a call is coming in.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000927">sio:SIO_000927</a>
    /// </summary>
    let SIO_000927 = _prefixId.prefix "SIO_000927"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000928^^xsd:string</para>
    ///   <para>rdfs:label : radar</para>
    ///   <para>dcterms:description : A radar is an object-detection system which uses radio waves to determine the range, altitude, direction, or speed of objects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000928">sio:SIO_000928</a>
    /// </summary>
    let SIO_000928 = _prefixId.prefix "SIO_000928"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000929^^xsd:string</para>
    ///   <para>rdfs:label : pie chart</para>
    ///   <para>dcterms:description : A pie chart is a circular chart divided into sectors each of whose length  is proportional to the quantity it represents.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000929">sio:SIO_000929</a>
    /// </summary>
    let SIO_000929 = _prefixId.prefix "SIO_000929"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000930^^xsd:string</para>
    ///   <para>rdfs:label : matrix chart</para>
    ///   <para>dcterms:description : A matrix chart summarizes a multidimensional data set in a grid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000930">sio:SIO_000930</a>
    /// </summary>
    let SIO_000930 = _prefixId.prefix "SIO_000930"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000931^^xsd:string</para>
    ///   <para>rdfs:label : network diagram</para>
    ///   <para>dcterms:description : A network diagram consists of a set of vertices connected by edges.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000931">sio:SIO_000931</a>
    /// </summary>
    let SIO_000931 = _prefixId.prefix "SIO_000931"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000932^^xsd:string</para>
    ///   <para>rdfs:label : block histogram</para>
    ///   <para>dcterms:description : A block histogram contains an x-axis that is divided into bins which correspond to value ranges. Each item in the data set is drawn as a rectangular block, and the blocks are piled into the bins to show how many values in each range.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000932">sio:SIO_000932</a>
    /// </summary>
    let SIO_000932 = _prefixId.prefix "SIO_000932"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000933^^xsd:string</para>
    ///   <para>rdfs:label : bubble chart</para>
    ///   <para>dcterms:description : A bubble chart contains circles whose area corresponds to a value. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000933">sio:SIO_000933</a>
    /// </summary>
    let SIO_000933 = _prefixId.prefix "SIO_000933"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000934^^xsd:string</para>
    ///   <para>rdfs:label : stack graph</para>
    ///   <para>dcterms:description : A stack graph is a statistical graph which presents multiple series in which the distance between one series and another indicates the relative contribution to the total for any x-value.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000934">sio:SIO_000934</a>
    /// </summary>
    let SIO_000934 = _prefixId.prefix "SIO_000934"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000935^^xsd:string</para>
    ///   <para>rdfs:label : treemap</para>
    ///   <para>dcterms:description : A treemap is a chart that fully partitions the area into a set of rectangles whose area represents its relative value.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000935">sio:SIO_000935</a>
    /// </summary>
    let SIO_000935 = _prefixId.prefix "SIO_000935"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000936^^xsd:string</para>
    ///   <para>rdfs:label : word tree</para>
    ///   <para>dcterms:description : A word tree is a chart that links phrases with contexts through a tree-like branching structure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000936">sio:SIO_000936</a>
    /// </summary>
    let SIO_000936 = _prefixId.prefix "SIO_000936"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000937^^xsd:string</para>
    ///   <para>rdfs:label : textual chart</para>
    ///   <para>dcterms:description : A textual chart is a chart containing text.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000937">sio:SIO_000937</a>
    /// </summary>
    let SIO_000937 = _prefixId.prefix "SIO_000937"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000938^^xsd:string</para>
    ///   <para>rdfs:label : tag cloud</para>
    ///   <para>sio:hasSynonym : word cloud</para>
    ///   <para>dcterms:description : A tag cloud is a visualization of word frequencies.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000938">sio:SIO_000938</a>
    /// </summary>
    let SIO_000938 = _prefixId.prefix "SIO_000938"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000939^^xsd:string</para>
    ///   <para>rdfs:label : phrase net diagram</para>
    ///   <para>dcterms:description : A phrase net diagram illustrates the relationship between different words used in a text.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000939">sio:SIO_000939</a>
    /// </summary>
    let SIO_000939 = _prefixId.prefix "SIO_000939"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000940^^xsd:string</para>
    ///   <para>rdfs:label : mereological chart</para>
    ///   <para>dcterms:description : A mereological chart is a chart that illustrates the parts in the context of the whole.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000940">sio:SIO_000940</a>
    /// </summary>
    let SIO_000940 = _prefixId.prefix "SIO_000940"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000941^^xsd:string</para>
    ///   <para>rdfs:label : conversing</para>
    ///   <para>dcterms:description : conversing a form of interactive, spontaneous communication between two or more agents who are following rules of etiquette.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000941">sio:SIO_000941</a>
    /// </summary>
    let SIO_000941 = _prefixId.prefix "SIO_000941"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000942^^xsd:string</para>
    ///   <para>rdfs:label : numeric label</para>
    ///   <para>dcterms:description : A numeric label is a number used as a label.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000942">sio:SIO_000942</a>
    /// </summary>
    let SIO_000942 = _prefixId.prefix "SIO_000942"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000943^^xsd:string</para>
    ///   <para>rdfs:label : start position</para>
    ///   <para>dcterms:description : A start position is the proximal position of an object relative to an origin in a linear system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000943">sio:SIO_000943</a>
    /// </summary>
    let SIO_000943 = _prefixId.prefix "SIO_000943"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000944^^xsd:string</para>
    ///   <para>rdfs:label : interval</para>
    ///   <para>dcterms:description : An interval is a set of real numbers that includes all numbers between any two numbers in the set.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000944">sio:SIO_000944</a>
    /// </summary>
    let SIO_000944 = _prefixId.prefix "SIO_000944"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000945^^xsd:string</para>
    ///   <para>rdfs:label : tree diagram</para>
    ///   <para>dcterms:description : A tree diagram is a hierarchical network diagram in which a root vertex is connected to one or more other vertices through a directed edge, which in turn may be connected to other vertices.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000945">sio:SIO_000945</a>
    /// </summary>
    let SIO_000945 = _prefixId.prefix "SIO_000945"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000946^^xsd:string</para>
    ///   <para>rdfs:label : flowchart</para>
    ///   <para>dcterms:description : A flowchart is a diagram that represents an algorithm or process, showing the steps as boxes of various kinds, and their order by connecting these with arrows.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000946">sio:SIO_000946</a>
    /// </summary>
    let SIO_000946 = _prefixId.prefix "SIO_000946"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000947^^xsd:string</para>
    ///   <para>rdfs:label : venn diagram</para>
    ///   <para>dcterms:description : A Venn diagram is a chart that illustrates all possible logical relations between a finite collection of sets as overlapping circles.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000947">sio:SIO_000947</a>
    /// </summary>
    let SIO_000947 = _prefixId.prefix "SIO_000947"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000948^^xsd:string</para>
    ///   <para>rdfs:label : dendrogram</para>
    ///   <para>dcterms:description : A dendrogram is a tree diagram used to illustrate the arrangement of the clusters produced by hierarchical clustering.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000948">sio:SIO_000948</a>
    /// </summary>
    let SIO_000948 = _prefixId.prefix "SIO_000948"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000949^^xsd:string</para>
    ///   <para>rdfs:label : apprehension</para>
    ///   <para>dcterms:description : apprehension is the negative emotion that something unpleasant will occur.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000949">sio:SIO_000949</a>
    /// </summary>
    let SIO_000949 = _prefixId.prefix "SIO_000949"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000950^^xsd:string</para>
    ///   <para>rdfs:label : resentment</para>
    ///   <para>dcterms:description : resentment is disgust directed toward a higher status individual.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000950">sio:SIO_000950</a>
    /// </summary>
    let SIO_000950 = _prefixId.prefix "SIO_000950"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000951^^xsd:string</para>
    ///   <para>rdfs:label : pain</para>
    ///   <para>dcterms:description : Pain is an unpleasant sensory and emotional experience associated with actual or potential tissue damage, or described in terms of such damage.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000951">sio:SIO_000951</a>
    /// </summary>
    let SIO_000951 = _prefixId.prefix "SIO_000951"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000952^^xsd:string</para>
    ///   <para>rdfs:label : default parameter</para>
    ///   <para>dcterms:description : A default parameter is a parameter which has a default value.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000952">sio:SIO_000952</a>
    /// </summary>
    let SIO_000952 = _prefixId.prefix "SIO_000952"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000953^^xsd:string</para>
    ///   <para>rdfs:label : end position</para>
    ///   <para>sio:hasSynonym : stop position^^xsd:string</para>
    ///   <para>dcterms:description : An end position is the distal position of an object relative to an origin in a linear system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000953">sio:SIO_000953</a>
    /// </summary>
    let SIO_000953 = _prefixId.prefix "SIO_000953"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000954^^xsd:string</para>
    ///   <para>rdfs:label : sick</para>
    ///   <para>dcterms:description : sick is the status of a living organism that is behaving at a sub-optimal level.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000954">sio:SIO_000954</a>
    /// </summary>
    let SIO_000954 = _prefixId.prefix "SIO_000954"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000955^^xsd:string</para>
    ///   <para>rdfs:label : environment</para>
    ///   <para>dcterms:description : An environment is a geographic region that hosts certain processes or objects.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000955">sio:SIO_000955</a>
    /// </summary>
    let SIO_000955 = _prefixId.prefix "SIO_000955"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000956^^xsd:string</para>
    ///   <para>rdfs:label : device</para>
    ///   <para>dcterms:description : A device is usually a constructed tool.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000956">sio:SIO_000956</a>
    /// </summary>
    let SIO_000956 = _prefixId.prefix "SIO_000956"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000957^^xsd:string</para>
    ///   <para>rdfs:label : communication device</para>
    ///   <para>dcterms:description : A communication device is a device that facilitates the transmission of information through encoded in an audio or digital signal between a sender and a receiver.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000957">sio:SIO_000957</a>
    /// </summary>
    let SIO_000957 = _prefixId.prefix "SIO_000957"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000959^^xsd:string</para>
    ///   <para>rdfs:label : existence quality</para>
    ///   <para>dcterms:description : existence quality is the quality of an entity that describe in what environment it is known to exist.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000959">sio:SIO_000959</a>
    /// </summary>
    let SIO_000959 = _prefixId.prefix "SIO_000959"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000960^^xsd:string</para>
    ///   <para>rdfs:label : real</para>
    ///   <para>dcterms:description : real is the quality of an entity that exists in real space and time.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000960">sio:SIO_000960</a>
    /// </summary>
    let SIO_000960 = _prefixId.prefix "SIO_000960"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000961^^xsd:string</para>
    ///   <para>rdfs:label : fictional</para>
    ///   <para>dcterms:description : fictional is the quality of an entity that exists only in a creative work of fiction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000961">sio:SIO_000961</a>
    /// </summary>
    let SIO_000961 = _prefixId.prefix "SIO_000961"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000962^^xsd:string</para>
    ///   <para>rdfs:label : virtual</para>
    ///   <para>dcterms:description : virtual is the quality of an entity that exists only in a virtual setting such as a simulation or game environment.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000962">sio:SIO_000962</a>
    /// </summary>
    let SIO_000962 = _prefixId.prefix "SIO_000962"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000963^^xsd:string</para>
    ///   <para>rdfs:label : not started</para>
    ///   <para>dcterms:description : not started is the status of a process that is predicted to exist but has not yet begun.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000963">sio:SIO_000963</a>
    /// </summary>
    let SIO_000963 = _prefixId.prefix "SIO_000963"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000964^^xsd:string</para>
    ///   <para>rdfs:label : standard operating procedure</para>
    ///   <para>dcterms:description : A standard operating procedure is a specification approved for use in specific environments.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000964">sio:SIO_000964</a>
    /// </summary>
    let SIO_000964 = _prefixId.prefix "SIO_000964"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000965^^xsd:string</para>
    ///   <para>rdfs:label : agreement quality</para>
    ///   <para>dcterms:description : agreement quality is a quality that exhibits the degree of consensus for some set of assertions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000965">sio:SIO_000965</a>
    /// </summary>
    let SIO_000965 = _prefixId.prefix "SIO_000965"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000966^^xsd:string</para>
    ///   <para>rdfs:label : agreement</para>
    ///   <para>dcterms:description : agreement is the result of consensus decision making when members of the group agree.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000966">sio:SIO_000966</a>
    /// </summary>
    let SIO_000966 = _prefixId.prefix "SIO_000966"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000967^^xsd:string</para>
    ///   <para>rdfs:label : disagreement</para>
    ///   <para>dcterms:description : agreement is the result of consensus decision making when members of the group do not all agree.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000967">sio:SIO_000967</a>
    /// </summary>
    let SIO_000967 = _prefixId.prefix "SIO_000967"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000968^^xsd:string</para>
    ///   <para>rdfs:label : poison role</para>
    ///   <para>dcterms:description : A poison role is the role of a substance that causes some negative disturbance in an organism.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000968">sio:SIO_000968</a>
    /// </summary>
    let SIO_000968 = _prefixId.prefix "SIO_000968"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000969^^xsd:string</para>
    ///   <para>rdfs:label : communicating</para>
    ///   <para>sio:hasSynonym : communication^^xsd:string</para>
    ///   <para>dcterms:description : communicating is the process of conveying information through the exchange of thoughts, messages, or information, as by speech, visuals, signals, writing, or behaviour.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000969">sio:SIO_000969</a>
    /// </summary>
    let SIO_000969 = _prefixId.prefix "SIO_000969"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000970^^xsd:string</para>
    ///   <para>rdfs:label : is first part of</para>
    ///   <para>dcterms:description : is first part of is a proper part relation in which the part is the first of a set of linearly ordered parts resulting from the projection of the whole on a linear coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000970">sio:SIO_000970</a>
    /// </summary>
    let SIO_000970 = _prefixId.prefix "SIO_000970"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000971^^xsd:string</para>
    ///   <para>rdfs:label : has first part</para>
    ///   <para>dcterms:description : has first part is a proper part relation in which the part is the first of a set of linearly ordered parts resulting from the projection of the whole on a linear coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000971">sio:SIO_000971</a>
    /// </summary>
    let SIO_000971 = _prefixId.prefix "SIO_000971"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000972^^xsd:string</para>
    ///   <para>rdfs:label : has last part</para>
    ///   <para>dcterms:description : has last part is a proper part relation in which the part is the last of a set of linearly ordered parts resulting from the projection of the whole on a linear coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000972">sio:SIO_000972</a>
    /// </summary>
    let SIO_000972 = _prefixId.prefix "SIO_000972"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000973^^xsd:string</para>
    ///   <para>rdfs:label : is last part of</para>
    ///   <para>dcterms:description : is last part of is a proper part relation in which the part is the last of a set of linearly ordered parts resulting from the projection of the whole on a linear coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000973">sio:SIO_000973</a>
    /// </summary>
    let SIO_000973 = _prefixId.prefix "SIO_000973"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000974^^xsd:string</para>
    ///   <para>rdfs:label : has ordered part</para>
    ///   <para>dcterms:description : has ordered part of is a proper part relation in which the part is one of a set of linearly ordered parts resulting from the projection of the whole on a linear coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000974">sio:SIO_000974</a>
    /// </summary>
    let SIO_000974 = _prefixId.prefix "SIO_000974"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000975^^xsd:string</para>
    ///   <para>rdfs:label : is ordered part of</para>
    ///   <para>dcterms:description : is ordered part of is a proper part relation in which the part is one of a set of linearly ordered parts resulting from the projection of the whole on a linear coordinate system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000975">sio:SIO_000975</a>
    /// </summary>
    let SIO_000975 = _prefixId.prefix "SIO_000975"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000976^^xsd:string</para>
    ///   <para>rdfs:label : observational study</para>
    ///   <para>dcterms:description : observational study draws inferences about the possible effect of a treatment on subjects, where the assignment of subjects into a treated group versus a control group is outside the control of the investigator</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000976">sio:SIO_000976</a>
    /// </summary>
    let SIO_000976 = _prefixId.prefix "SIO_000976"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000977^^xsd:string</para>
    ///   <para>rdfs:label : syllable</para>
    ///   <para>dcterms:description : A syllable is a verbal entity of language having one vowel sound, with or without surrounding consonants, forming the whole or a part of a word.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000977">sio:SIO_000977</a>
    /// </summary>
    let SIO_000977 = _prefixId.prefix "SIO_000977"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000978^^xsd:string</para>
    ///   <para>rdfs:label : consonant</para>
    ///   <para>dcterms:description : A consonant is a verbal entity of language that is articulated with complete or partial closure of the vocal tract.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000978">sio:SIO_000978</a>
    /// </summary>
    let SIO_000978 = _prefixId.prefix "SIO_000978"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000979^^xsd:string</para>
    ///   <para>rdfs:label : vowel</para>
    ///   <para>dcterms:description : A vowel is a verbal entity of language that is pronounced with an open vocal tract so that there is no build-up of air pressure at any point above the glottis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000979">sio:SIO_000979</a>
    /// </summary>
    let SIO_000979 = _prefixId.prefix "SIO_000979"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000980^^xsd:string</para>
    ///   <para>rdfs:label : sign language</para>
    ///   <para>dcterms:description : A sign language (also signed language) is a language that involves manual communication and body language to convey meaning. This can involve simultaneously combining hand shapes, orientation and movement of the hands, arms or body, and facial expressions to fluidly express a speaker's thoughts.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000980">sio:SIO_000980</a>
    /// </summary>
    let SIO_000980 = _prefixId.prefix "SIO_000980"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000981^^xsd:string</para>
    ///   <para>rdfs:label : verbal language</para>
    ///   <para>dcterms:description : A verbal language is a language that uses sounds to communicate.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000981">sio:SIO_000981</a>
    /// </summary>
    let SIO_000981 = _prefixId.prefix "SIO_000981"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000982^^xsd:string</para>
    ///   <para>rdfs:label : written language</para>
    ///   <para>dcterms:description : written language is a language that is communicated through a writing system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000982">sio:SIO_000982</a>
    /// </summary>
    let SIO_000982 = _prefixId.prefix "SIO_000982"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000983^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association</para>
    ///   <para>dcterms:description : A gene-disease association is an association between a gene and a disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000983">sio:SIO_000983</a>
    /// </summary>
    let SIO_000983 = _prefixId.prefix "SIO_000983"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000984^^xsd:string</para>
    ///   <para>rdfs:label : genome</para>
    ///   <para>dcterms:description : A genome is a collection of nucleic acids.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000984">sio:SIO_000984</a>
    /// </summary>
    let SIO_000984 = _prefixId.prefix "SIO_000984"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000985^^xsd:string</para>
    ///   <para>rdfs:label : protein coding gene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0001217^^xsd:anyURI</para>
    ///   <para>dcterms:description : A gene that contains an open reading frame which codes for a protein.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000985">sio:SIO_000985</a>
    /// </summary>
    let SIO_000985 = _prefixId.prefix "SIO_000985"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000986^^xsd:string</para>
    ///   <para>rdfs:label : functional rna coding gene</para>
    ///   <para>dcterms:description : A gene that codes for a functional RNA molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000986">sio:SIO_000986</a>
    /// </summary>
    let SIO_000986 = _prefixId.prefix "SIO_000986"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000987^^xsd:string</para>
    ///   <para>rdfs:label : predicted gene</para>
    ///   <para>dcterms:description : A predicted gene is a gene that was identified through computational method but has not been experimentally validated.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000987">sio:SIO_000987</a>
    /// </summary>
    let SIO_000987 = _prefixId.prefix "SIO_000987"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000988^^xsd:string</para>
    ///   <para>rdfs:label : pseudogene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0000336^^xsd:anyURI</para>
    ///   <para>dcterms:description : A pseudo gene is a region of a nucleic acid that either cannot be transcribed, or its RNA transcript cannot be translated.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000988">sio:SIO_000988</a>
    /// </summary>
    let SIO_000988 = _prefixId.prefix "SIO_000988"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000989^^xsd:string</para>
    ///   <para>rdfs:label : sequence assembly</para>
    ///   <para>dcterms:description : A sequence assembly is a sequence that is produced as by the alignment of two or more sequences.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000989">sio:SIO_000989</a>
    /// </summary>
    let SIO_000989 = _prefixId.prefix "SIO_000989"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000991^^xsd:string</para>
    ///   <para>rdfs:label : validated gene</para>
    ///   <para>dcterms:description : An experimentally validated gene is a gene whose existence has been demonstrated through experimental methods.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000991">sio:SIO_000991</a>
    /// </summary>
    let SIO_000991 = _prefixId.prefix "SIO_000991"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000992^^xsd:string</para>
    ///   <para>rdfs:label : unsupported</para>
    ///   <para>dcterms:description : unsupported is an existence quality in which there is no evidence to support the existence of the entity in any world (real or hypothetical)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000992">sio:SIO_000992</a>
    /// </summary>
    let SIO_000992 = _prefixId.prefix "SIO_000992"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000993^^xsd:string</para>
    ///   <para>rdfs:label : chemical-disease association</para>
    ///   <para>dcterms:description : A chemical-disease association is an association between a chemical and a disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000993">sio:SIO_000993</a>
    /// </summary>
    let SIO_000993 = _prefixId.prefix "SIO_000993"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000994^^xsd:string</para>
    ///   <para>rdfs:label : experiment</para>
    ///   <para>sio:hasSynonym : study^^xsd:string</para>
    ///   <para>dcterms:description : An experiment is an investigation that has the goal of verifying, falsifying, or establishing the validity of a hypothesis. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_000994">sio:SIO_000994</a>
    /// </summary>
    let SIO_000994 = _prefixId.prefix "SIO_000994"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000995^^xsd:string</para>
    ///   <para>rdfs:label : suspended</para>
    ///   <para>dcterms:description : suspended is the status of a process that is no longer progressing towards completion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000995">sio:SIO_000995</a>
    /// </summary>
    let SIO_000995 = _prefixId.prefix "SIO_000995"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000996^^xsd:string</para>
    ///   <para>rdfs:label : cancelled</para>
    ///   <para>dcterms:description : cancelled is a process status in which the process, while planned to occur, will not occur.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000996">sio:SIO_000996</a>
    /// </summary>
    let SIO_000996 = _prefixId.prefix "SIO_000996"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000997^^xsd:string</para>
    ///   <para>rdfs:label : aborted</para>
    ///   <para>dcterms:description : aborted is a process status in which a started process will not complete as intended.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000997">sio:SIO_000997</a>
    /// </summary>
    let SIO_000997 = _prefixId.prefix "SIO_000997"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000998^^xsd:string</para>
    ///   <para>rdfs:label : literature curation</para>
    ///   <para>dcterms:description : literature curation is the process of an agent selecting and extracting terms and phrases from a document.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000998">sio:SIO_000998</a>
    /// </summary>
    let SIO_000998 = _prefixId.prefix "SIO_000998"
    /// <summary>
    ///   <para>dc11:identifier : SIO_000999^^xsd:string</para>
    ///   <para>rdfs:label : procedure</para>
    ///   <para>dcterms:description : A procedure is a process that attempts to achieve one or more objectives by following an established set of actions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_000999">sio:SIO_000999</a>
    /// </summary>
    let SIO_000999 = _prefixId.prefix "SIO_000999"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001000^^xsd:string</para>
    ///   <para>rdfs:label : clinical trial</para>
    ///   <para>dcterms:description : A clinical trial is an intervention trial to determine the safety and efficacy of  medical interventions (e.g., drugs, diagnostics, devices, therapy protocols). </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001000">sio:SIO_001000</a>
    /// </summary>
    let SIO_001000 = _prefixId.prefix "SIO_001000"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001001^^xsd:string</para>
    ///   <para>rdfs:label : medical diagnosis</para>
    ///   <para>dcterms:description : A medical diagnosis (often simply termed diagnosis) refers to the process of attempting to determine or identify a possible disease or disorder.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001001">sio:SIO_001001</a>
    /// </summary>
    let SIO_001001 = _prefixId.prefix "SIO_001001"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001002^^xsd:string</para>
    ///   <para>rdfs:label : differential diagnosis</para>
    ///   <para>dcterms:description : A differential diagnosis (sometimes abbreviated DDx, ddx, DD, D/Dx, or ΔΔ) is a systematic diagnostic method used to identify the presence of an entity where multiple alternatives are possible (and the process may be termed differential diagnostic procedure), and may also refer to any of the included candidate alternatives (which may also be termed candidate condition).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001002">sio:SIO_001002</a>
    /// </summary>
    let SIO_001002 = _prefixId.prefix "SIO_001002"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001003^^xsd:string</para>
    ///   <para>rdfs:label : diagnostic opinion</para>
    ///   <para>dcterms:description : A diagnostic opinion is an opinion resulting from a medical diagnostic procedure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001003">sio:SIO_001003</a>
    /// </summary>
    let SIO_001003 = _prefixId.prefix "SIO_001003"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001004^^xsd:string</para>
    ///   <para>rdfs:label : opinion</para>
    ///   <para>dcterms:description : An opinion is a belief that is the result of emotion or interpretation of facts. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001004">sio:SIO_001004</a>
    /// </summary>
    let SIO_001004 = _prefixId.prefix "SIO_001004"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001005^^xsd:string</para>
    ///   <para>rdfs:label : drug effect</para>
    ///   <para>dcterms:description : A drug effect is a chemical interaction in which a chemical elicits a marked characteristic of a biological system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001005">sio:SIO_001005</a>
    /// </summary>
    let SIO_001005 = _prefixId.prefix "SIO_001005"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001006^^xsd:string</para>
    ///   <para>rdfs:label : drug drug interaction</para>
    ///   <para>dcterms:description : A drug-drug interaction is an interaction in which two drugs interact in such a way to produce a non-additive biological response.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001006">sio:SIO_001006</a>
    /// </summary>
    let SIO_001006 = _prefixId.prefix "SIO_001006"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001007^^xsd:string</para>
    ///   <para>rdfs:label : assay</para>
    ///   <para>dcterms:description : An assay is an investigative (analytic) procedure in laboratory medicine, pharmacology, environmental biology, and molecular biology for qualitatively assessing or quantitatively measuring the presence or amount or the functional activity of a target entity (the analyte) which can be a drug or biochemical substance or a cell in an organism or organic sample.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001007">sio:SIO_001007</a>
    /// </summary>
    let SIO_001007 = _prefixId.prefix "SIO_001007"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001008^^xsd:string</para>
    ///   <para>rdfs:label : toxicity</para>
    ///   <para>dcterms:description : toxicity is the quality of a chemical substance to cause injury to an organism in a dose dependent manner.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001008">sio:SIO_001008</a>
    /// </summary>
    let SIO_001008 = _prefixId.prefix "SIO_001008"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001009^^xsd:string</para>
    ///   <para>rdfs:label : toxic</para>
    ///   <para>dcterms:description : toxic is the quality of a substance imparing the normal functioning of a  system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001009">sio:SIO_001009</a>
    /// </summary>
    let SIO_001009 = _prefixId.prefix "SIO_001009"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001010^^xsd:string</para>
    ///   <para>rdfs:label : non toxic</para>
    ///   <para>dcterms:description : non toxic is the quality of a substance having no damaging effect to a system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001010">sio:SIO_001010</a>
    /// </summary>
    let SIO_001010 = _prefixId.prefix "SIO_001010"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001011^^xsd:string</para>
    ///   <para>rdfs:label : chemical quality</para>
    ///   <para>dcterms:description : chemical quality is the quality of a chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001011">sio:SIO_001011</a>
    /// </summary>
    let SIO_001011 = _prefixId.prefix "SIO_001011"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001012^^xsd:string</para>
    ///   <para>rdfs:label : healthy</para>
    ///   <para>dcterms:description : healthy is an organismal state of complete physical, mental and social well-being.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001012">sio:SIO_001012</a>
    /// </summary>
    let SIO_001012 = _prefixId.prefix "SIO_001012"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001013^^xsd:string</para>
    ///   <para>rdfs:label : age</para>
    ///   <para>dcterms:description : age is the length of time that a person has lived or a thing has existed.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001013">sio:SIO_001013</a>
    /// </summary>
    let SIO_001013 = _prefixId.prefix "SIO_001013"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001014^^xsd:string</para>
    ///   <para>rdfs:label : ethnicity</para>
    ///   <para>dcterms:description : ethnicity is the biological quality of membership in a social group based on a common heritage.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001014">sio:SIO_001014</a>
    /// </summary>
    let SIO_001014 = _prefixId.prefix "SIO_001014"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001015^^xsd:string</para>
    ///   <para>rdfs:label : race</para>
    ///   <para>dcterms:description : race is a characteristic of an individual by heritable phenotypic characteristics, geographic ancestry, physical appearance, ethnicity, and social status.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001015">sio:SIO_001015</a>
    /// </summary>
    let SIO_001015 = _prefixId.prefix "SIO_001015"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001016^^xsd:string</para>
    ///   <para>rdfs:label : ethnic group</para>
    ///   <para>dcterms:description : An ethnic group is a group of people whose members identify with each other through a common heritage, consisting of a common culture, including a shared language or dialect. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001016">sio:SIO_001016</a>
    /// </summary>
    let SIO_001016 = _prefixId.prefix "SIO_001016"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001017^^xsd:string</para>
    ///   <para>rdfs:label : syndrome</para>
    ///   <para>dcterms:description : A syndrome is composed of a set of several clinically recognizable features, signs (observed by someone other than the patient), symptoms (reported by the patient), phenomena or characteristics that often occur together.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001017">sio:SIO_001017</a>
    /// </summary>
    let SIO_001017 = _prefixId.prefix "SIO_001017"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001018^^xsd:string</para>
    ///   <para>rdfs:label : ratio</para>
    ///   <para>dcterms:description : A ratio is a relationship between two numbers of the same kind expressed arithmetically as a dimensionless quotient of the two which explicitly indicates how many times the first number contains the second.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001018">sio:SIO_001018</a>
    /// </summary>
    let SIO_001018 = _prefixId.prefix "SIO_001018"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001019^^xsd:string</para>
    ///   <para>rdfs:label : dose</para>
    ///   <para>dcterms:description : A dose is the quantity of a chemical substance administered to a biological system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001019">sio:SIO_001019</a>
    /// </summary>
    let SIO_001019 = _prefixId.prefix "SIO_001019"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001020^^xsd:string</para>
    ///   <para>rdfs:label : effective dose</para>
    ///   <para>dcterms:description : effective dose is the amount of a substance required to produce an effect on a predefined percentage of a population.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001020">sio:SIO_001020</a>
    /// </summary>
    let SIO_001020 = _prefixId.prefix "SIO_001020"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001021^^xsd:string</para>
    ///   <para>rdfs:label : expected value</para>
    ///   <para>dcterms:description : An expected value (or e-value) is the weighted average of all possible values that a random variable can take on.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001021">sio:SIO_001021</a>
    /// </summary>
    let SIO_001021 = _prefixId.prefix "SIO_001021"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001022^^xsd:string</para>
    ///   <para>rdfs:label : diagnostic test</para>
    ///   <para>dcterms:description : A diagnostic test is a procedure performed to confirm, or determine the presence of disease in an individual suspected of having the disease, usually following the report of symptoms, or based on the results of other medical tests.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001022">sio:SIO_001022</a>
    /// </summary>
    let SIO_001022 = _prefixId.prefix "SIO_001022"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001023^^xsd:string</para>
    ///   <para>rdfs:label : medical screening</para>
    ///   <para>dcterms:description : A medical screening is a medical test or series used to detect or predict the presence of disease in individuals at risk for disease within a defined group, such as a population, family, or workforce</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001023">sio:SIO_001023</a>
    /// </summary>
    let SIO_001023 = _prefixId.prefix "SIO_001023"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001024^^xsd:string</para>
    ///   <para>rdfs:label : medical procedure</para>
    ///   <para>dcterms:description : A medical procedure is a procedure to identify, examine, alleviate or eliminate an undesirable biological disease or disorder.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001024">sio:SIO_001024</a>
    /// </summary>
    let SIO_001024 = _prefixId.prefix "SIO_001024"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001025^^xsd:string</para>
    ///   <para>rdfs:label : prognosis</para>
    ///   <para>dcterms:description : A prognosis is a proposition about the likely course of a disease, the chance of recovery or recurrence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001025">sio:SIO_001025</a>
    /// </summary>
    let SIO_001025 = _prefixId.prefix "SIO_001025"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001026^^xsd:string</para>
    ///   <para>rdfs:label : report</para>
    ///   <para>dcterms:description : A report is a textual document made that present focused, salient content to a specific audience.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001026">sio:SIO_001026</a>
    /// </summary>
    let SIO_001026 = _prefixId.prefix "SIO_001026"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001027^^xsd:string</para>
    ///   <para>rdfs:label : medical health record</para>
    ///   <para>dcterms:description : A medical health record is a record of a single patient's medical history.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001027">sio:SIO_001027</a>
    /// </summary>
    let SIO_001027 = _prefixId.prefix "SIO_001027"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001028^^xsd:string</para>
    ///   <para>rdfs:label : medical report</para>
    ///   <para>dcterms:description : A medical report is a report prepared by a health care practioner about test outcomes or health status of an individual.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001028">sio:SIO_001028</a>
    /// </summary>
    let SIO_001028 = _prefixId.prefix "SIO_001028"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001029^^xsd:string</para>
    ///   <para>rdfs:label : peer reviewed article</para>
    ///   <para>dcterms:description : A peer reviewed article is an article that has undergone peer-review and deemed acceptable for publication.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001029">sio:SIO_001029</a>
    /// </summary>
    let SIO_001029 = _prefixId.prefix "SIO_001029"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001030^^xsd:string</para>
    ///   <para>rdfs:label : major version number</para>
    ///   <para>dcterms:description : A major version number is a version of a software that exhibits a significant change in functionalilty from a prior version.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001030">sio:SIO_001030</a>
    /// </summary>
    let SIO_001030 = _prefixId.prefix "SIO_001030"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001031^^xsd:string</para>
    ///   <para>rdfs:label : minor version number</para>
    ///   <para>dcterms:description : A minor version number is a version of a software that exhibits minor features or significant fix from a prior version.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001031">sio:SIO_001031</a>
    /// </summary>
    let SIO_001031 = _prefixId.prefix "SIO_001031"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001032^^xsd:string</para>
    ///   <para>rdfs:label : revision number</para>
    ///   <para>dcterms:description : A revision number is a version of a software in which bugs have been fixed from a prior version.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001032">sio:SIO_001032</a>
    /// </summary>
    let SIO_001032 = _prefixId.prefix "SIO_001032"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001033^^xsd:string</para>
    ///   <para>rdfs:label : text quality</para>
    ///   <para>dcterms:description : text quality is the quality of a textual entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001033">sio:SIO_001033</a>
    /// </summary>
    let SIO_001033 = _prefixId.prefix "SIO_001033"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001034^^xsd:string</para>
    ///   <para>rdfs:label : reviewed</para>
    ///   <para>dcterms:description : reviewed is the quality of a textual entity that has been examined and commented on by another party.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001034">sio:SIO_001034</a>
    /// </summary>
    let SIO_001034 = _prefixId.prefix "SIO_001034"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001035^^xsd:string</para>
    ///   <para>rdfs:label : peer-reviewed</para>
    ///   <para>dcterms:description : peer-reviewed is the quality of a textual entity that has been examined and commented by a peer expert reviewer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001035">sio:SIO_001035</a>
    /// </summary>
    let SIO_001035 = _prefixId.prefix "SIO_001035"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001036^^xsd:string</para>
    ///   <para>rdfs:label : draft</para>
    ///   <para>sio:hasSynonym : drafted^^xsd:string</para>
    ///   <para>dcterms:description : draft is the quality of text that has not yet complete.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001036">sio:SIO_001036</a>
    /// </summary>
    let SIO_001036 = _prefixId.prefix "SIO_001036"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001037^^xsd:string</para>
    ///   <para>rdfs:label : finalized</para>
    ///   <para>dcterms:description : finalized is the quality of a textual entity that is in its final form.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001037">sio:SIO_001037</a>
    /// </summary>
    let SIO_001037 = _prefixId.prefix "SIO_001037"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001038^^xsd:string</para>
    ///   <para>rdfs:label : editor reviewed</para>
    ///   <para>dcterms:description : editor reviewed is the quality of a textual entity that has been examined and commented on by an editor.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001038">sio:SIO_001038</a>
    /// </summary>
    let SIO_001038 = _prefixId.prefix "SIO_001038"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001039^^xsd:string</para>
    ///   <para>rdfs:label : written</para>
    ///   <para>dcterms:description : written is the quality of information that is embodied as visual glyphs in some material form.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001039">sio:SIO_001039</a>
    /// </summary>
    let SIO_001039 = _prefixId.prefix "SIO_001039"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001040^^xsd:string</para>
    ///   <para>rdfs:label : morpheme</para>
    ///   <para>dcterms:description : A morpheme is the smallest semantically meaningful unit in a language.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001040">sio:SIO_001040</a>
    /// </summary>
    let SIO_001040 = _prefixId.prefix "SIO_001040"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001041^^xsd:string</para>
    ///   <para>rdfs:label : study design</para>
    ///   <para>sio:hasSynonym : study protocol^^xsd:string</para>
    ///   <para>dcterms:description : A study design is a protocol for the proper execution of a study which normally requires a carefullly crafted research question or hypothesis and at least one variable under observation and observed values for that variable.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001041">sio:SIO_001041</a>
    /// </summary>
    let SIO_001041 = _prefixId.prefix "SIO_001041"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001042^^xsd:string</para>
    ///   <para>rdfs:label : recipe</para>
    ///   <para>dcterms:description : A recipe is a set of instructions that describe how to prepare or make something.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001042">sio:SIO_001042</a>
    /// </summary>
    let SIO_001042 = _prefixId.prefix "SIO_001042"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001043^^xsd:string</para>
    ///   <para>rdfs:label : experimental protocol</para>
    ///   <para>dcterms:description : An experimental protocol is an action specification with respect to the design and implementation of experiments. In addition to providing a detailed set of procedures and lists of required equipment and instruments, experimental protocols often include information on safety precautions, the calculation of results and reporting standards, including statistical analysis and rules for predefining and documenting excluded data to avoid bias.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001043">sio:SIO_001043</a>
    /// </summary>
    let SIO_001043 = _prefixId.prefix "SIO_001043"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001044^^xsd:string</para>
    ///   <para>rdfs:label : viroid</para>
    ///   <para>dcterms:description : A viroid is a molecule of RNA that does not code for and is not protected by a protein coat.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001044">sio:SIO_001044</a>
    /// </summary>
    let SIO_001044 = _prefixId.prefix "SIO_001044"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001045^^xsd:string</para>
    ///   <para>rdfs:label : polar quality</para>
    ///   <para>dcterms:description : The quality of being polar or not polar.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001045">sio:SIO_001045</a>
    /// </summary>
    let SIO_001045 = _prefixId.prefix "SIO_001045"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001046^^xsd:string</para>
    ///   <para>rdfs:label : polar</para>
    ///   <para>dcterms:description : polar is the quality of having a dipole.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001046">sio:SIO_001046</a>
    /// </summary>
    let SIO_001046 = _prefixId.prefix "SIO_001046"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001047^^xsd:string</para>
    ///   <para>rdfs:label : non-polar</para>
    ///   <para>dcterms:description : non-polar is the quality of not having a dipole.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001047">sio:SIO_001047</a>
    /// </summary>
    let SIO_001047 = _prefixId.prefix "SIO_001047"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001048^^xsd:string</para>
    ///   <para>rdfs:label : intervention study</para>
    ///   <para>dcterms:description : An intervention study has the objective of improving the condition of an individual or a group of individuals, and demonstrates the magnitude of that capability by comparing it to a control group.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001048">sio:SIO_001048</a>
    /// </summary>
    let SIO_001048 = _prefixId.prefix "SIO_001048"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001049^^xsd:string</para>
    ///   <para>rdfs:label : sampling</para>
    ///   <para>dcterms:description : sampling is the act of obtaining a sample, whether through selection, collection or preparation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001049">sio:SIO_001049</a>
    /// </summary>
    let SIO_001049 = _prefixId.prefix "SIO_001049"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001050^^xsd:string</para>
    ///   <para>rdfs:label : sample</para>
    ///   <para>dcterms:description : A sample is a limited quantity of something (e.g. an individual or set of individuals from a population, or a portion of a substance) to be used for testing, analysis, inspection, investigation, demonstration, or trial use.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001050">sio:SIO_001050</a>
    /// </summary>
    let SIO_001050 = _prefixId.prefix "SIO_001050"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001051^^xsd:string</para>
    ///   <para>rdfs:label : data analysis</para>
    ///   <para>dcterms:description : data analysis is a process of inspecting, cleaning, transforming, and modeling data with the goal of highlighting useful information, suggesting conclusions, and supporting decision making.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001051">sio:SIO_001051</a>
    /// </summary>
    let SIO_001051 = _prefixId.prefix "SIO_001051"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001052^^xsd:string</para>
    ///   <para>rdfs:label : data collection</para>
    ///   <para>dcterms:description : data collection is the process of acquiring information.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001052">sio:SIO_001052</a>
    /// </summary>
    let SIO_001052 = _prefixId.prefix "SIO_001052"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001053^^xsd:string</para>
    ///   <para>rdfs:label : reason</para>
    ///   <para>dcterms:description : A reason is a justification that specifies the motive for an action or a determination.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001053">sio:SIO_001053</a>
    /// </summary>
    let SIO_001053 = _prefixId.prefix "SIO_001053"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001054^^xsd:string</para>
    ///   <para>rdfs:label : measuring</para>
    ///   <para>sio:hasSynonym : measurement</para>
    ///   <para>dcterms:description : measuring is the process of determining the size, amount, or degree of (something) by using an instrument or device marked in standard units</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001054">sio:SIO_001054</a>
    /// </summary>
    let SIO_001054 = _prefixId.prefix "SIO_001054"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001055^^xsd:string</para>
    ///   <para>rdfs:label : observing</para>
    ///   <para>sio:hasSynonym : observation</para>
    ///   <para>dcterms:description : observing is a process of passive interaction in which one entity makes note of attributes of one or more entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001055">sio:SIO_001055</a>
    /// </summary>
    let SIO_001055 = _prefixId.prefix "SIO_001055"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001056^^xsd:string</para>
    ///   <para>rdfs:label : character position</para>
    ///   <para>sio:hasSynonym : character offset^^xsd:string</para>
    ///   <para>dcterms:description : The ordinal position of a character in a sequence of characters.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001056">sio:SIO_001056</a>
    /// </summary>
    let SIO_001056 = _prefixId.prefix "SIO_001056"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001057^^xsd:string</para>
    ///   <para>rdfs:label : word start position</para>
    ///   <para>dcterms:description : The position of the first character in a word as an offset from the first character of the text in which it is found.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001057">sio:SIO_001057</a>
    /// </summary>
    let SIO_001057 = _prefixId.prefix "SIO_001057"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001058^^xsd:string</para>
    ///   <para>rdfs:label : word end position</para>
    ///   <para>dcterms:description : word end position is the position of the last character in a word as an offset from the first character of the text in which it is found.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001058">sio:SIO_001058</a>
    /// </summary>
    let SIO_001058 = _prefixId.prefix "SIO_001058"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001059^^xsd:string</para>
    ///   <para>rdfs:label : gesturing</para>
    ///   <para>dcterms:description : gesturing is a form of non-verbal communication in which visible bodily actions communicate particular messages, either in place of speech or together and in parallel with spoken words. Gestures include movement of the hands, face, or other parts of the body.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001059">sio:SIO_001059</a>
    /// </summary>
    let SIO_001059 = _prefixId.prefix "SIO_001059"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001060^^xsd:string</para>
    ///   <para>rdfs:label : planned</para>
    ///   <para>dcterms:description : planned is a process status for a process that has not yet started, but is referred to in a plan.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001060">sio:SIO_001060</a>
    /// </summary>
    let SIO_001060 = _prefixId.prefix "SIO_001060"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001061^^xsd:string</para>
    ///   <para>rdfs:label : population</para>
    ///   <para>dcterms:description : A population is all the organisms that both belong to the same group or species and live in the same geographical area.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001061">sio:SIO_001061</a>
    /// </summary>
    let SIO_001061 = _prefixId.prefix "SIO_001061"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001062^^xsd:string</para>
    ///   <para>rdfs:label : human population</para>
    ///   <para>dcterms:description : A human population refers to a collection of human beings.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001062">sio:SIO_001062</a>
    /// </summary>
    let SIO_001062 = _prefixId.prefix "SIO_001062"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001063^^xsd:string</para>
    ///   <para>rdfs:label : family</para>
    ///   <para>dcterms:description : A group of people affiliated by consanguinity, affinity, or co-residence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001063">sio:SIO_001063</a>
    /// </summary>
    let SIO_001063 = _prefixId.prefix "SIO_001063"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001064^^xsd:string</para>
    ///   <para>rdfs:label : community</para>
    ///   <para>dcterms:description : A community is a sizeable social unit that shares common values.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001064">sio:SIO_001064</a>
    /// </summary>
    let SIO_001064 = _prefixId.prefix "SIO_001064"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001065^^xsd:string</para>
    ///   <para>rdfs:label : speculation</para>
    ///   <para>dcterms:description : speculation is an opinion based on incomplete evidence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001065">sio:SIO_001065</a>
    /// </summary>
    let SIO_001065 = _prefixId.prefix "SIO_001065"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001066^^xsd:string</para>
    ///   <para>rdfs:label : study</para>
    ///   <para>dcterms:description : A study is a process that realizes the steps of a study design.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001066">sio:SIO_001066</a>
    /// </summary>
    let SIO_001066 = _prefixId.prefix "SIO_001066"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001067^^xsd:string</para>
    ///   <para>rdfs:label : controlled observational cohort study</para>
    ///   <para>dcterms:description : In a controlled observational cohort study, two groups of subjects are selected from two populations that are thought to differ in only one characteristic. The groups of subjects are studied for a specific period and contrasted at the end of the study period.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001067">sio:SIO_001067</a>
    /// </summary>
    let SIO_001067 = _prefixId.prefix "SIO_001067"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001068^^xsd:string</para>
    ///   <para>rdfs:label : control group</para>
    ///   <para>dcterms:description : A control group is a group of individuals that are not subject to an intervention of interest, but rather serve as a baseline to compare the outcomes in the intervention group.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001068">sio:SIO_001068</a>
    /// </summary>
    let SIO_001068 = _prefixId.prefix "SIO_001068"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001069^^xsd:string</para>
    ///   <para>rdfs:label : intervention group</para>
    ///   <para>dcterms:description : An intervention group is a group of individuals that are subject to an intervention.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001069">sio:SIO_001069</a>
    /// </summary>
    let SIO_001069 = _prefixId.prefix "SIO_001069"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001070^^xsd:string</para>
    ///   <para>rdfs:label : control variable</para>
    ///   <para>sio:hasSynonym : extraneous variable^^xsd:stringsio:hasSynonym : controlled variable^^xsd:string</para>
    ///   <para>dcterms:description : A control variable that is believed to alter the dependent or independent variables, but may not actually be the focus of the experiment. So that variable will be kept constant or monitored to try to minimise its effect on the experiment.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001070">sio:SIO_001070</a>
    /// </summary>
    let SIO_001070 = _prefixId.prefix "SIO_001070"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001071^^xsd:string</para>
    ///   <para>rdfs:label : text span start position</para>
    ///   <para>dcterms:description : text span start position is the position (offset) of the first character of a text span in relation the text it is from.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001071">sio:SIO_001071</a>
    /// </summary>
    let SIO_001071 = _prefixId.prefix "SIO_001071"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001072^^xsd:string</para>
    ///   <para>rdfs:label : text span end position</para>
    ///   <para>dcterms:description : text span end position is the position (offset) of the last character of a text span in relation the text it is from.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001072">sio:SIO_001072</a>
    /// </summary>
    let SIO_001072 = _prefixId.prefix "SIO_001072"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001073^^xsd:string</para>
    ///   <para>rdfs:label : text span</para>
    ///   <para>sio:hasSynonym : selector^^xsd:string</para>
    ///   <para>dcterms:description : A text span is a subset of contiguous sequence of characters of a textual entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001073">sio:SIO_001073</a>
    /// </summary>
    let SIO_001073 = _prefixId.prefix "SIO_001073"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001074^^xsd:string</para>
    ///   <para>rdfs:label : t-statistic</para>
    ///   <para>dcterms:description : A t-statistic is a ratio of the departure of an estimated parameter from its notional value and its standard error. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001074">sio:SIO_001074</a>
    /// </summary>
    let SIO_001074 = _prefixId.prefix "SIO_001074"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001075^^xsd:string</para>
    ///   <para>rdfs:label : microarray probe set identifier</para>
    ///   <para>dcterms:description : A microarray probe set identifier is an identifier for a set of probe pairs selected to represent expressed sequences on an array. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001075">sio:SIO_001075</a>
    /// </summary>
    let SIO_001075 = _prefixId.prefix "SIO_001075"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001076^^xsd:string</para>
    ///   <para>rdfs:label : microarray experiment</para>
    ///   <para>dcterms:description : A microarray experiment is an experiment that involves a microarray device to measure the expression of one or more genes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001076">sio:SIO_001076</a>
    /// </summary>
    let SIO_001076 = _prefixId.prefix "SIO_001076"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001077^^xsd:string</para>
    ///   <para>rdfs:label : gene expression value</para>
    ///   <para>dcterms:description : A gene expression value is a measured value obtained from a gene expression experiment.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001077">sio:SIO_001077</a>
    /// </summary>
    let SIO_001077 = _prefixId.prefix "SIO_001077"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001078^^xsd:string</para>
    ///   <para>rdfs:label : differential gene expression ratio</para>
    ///   <para>dcterms:description : A differential gene expression ratio is the ratio of gene expression values from a test sample compared to a control sample.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001078">sio:SIO_001078</a>
    /// </summary>
    let SIO_001078 = _prefixId.prefix "SIO_001078"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001079^^xsd:string</para>
    ///   <para>rdfs:label : genotype</para>
    ///   <para>dcterms:description : A genotype is a functional specification of a biological entity in terms of its genetic composition (or lack thereof).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001079">sio:SIO_001079</a>
    /// </summary>
    let SIO_001079 = _prefixId.prefix "SIO_001079"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001080^^xsd:string</para>
    ///   <para>rdfs:label : vocabulary</para>
    ///   <para>dcterms:description : A vocabulary is a collection of terms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001080">sio:SIO_001080</a>
    /// </summary>
    let SIO_001080 = _prefixId.prefix "SIO_001080"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001081^^xsd:string</para>
    ///   <para>rdfs:label : t-statistic based increased differential gene expression</para>
    ///   <para>dcterms:description : A t-statistic based increased differential gene expression is a differential gene expression ratio in which the t-statistic is greater than zero.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001081">sio:SIO_001081</a>
    /// </summary>
    let SIO_001081 = _prefixId.prefix "SIO_001081"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001082^^xsd:string</para>
    ///   <para>rdfs:label : t-statistic based decreased differential gene expression</para>
    ///   <para>dcterms:description : A t-statistic based decreased differential gene expression is a differential gene expression ratio in which the t-statistic is less than zero.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001082">sio:SIO_001082</a>
    /// </summary>
    let SIO_001082 = _prefixId.prefix "SIO_001082"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001083^^xsd:string</para>
    ///   <para>rdfs:label : date of database submission</para>
    ///   <para>dcterms:description : A date of database submission refers to the moment in time in which some information was submitted/received to a database system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001083">sio:SIO_001083</a>
    /// </summary>
    let SIO_001083 = _prefixId.prefix "SIO_001083"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001084^^xsd:string</para>
    ///   <para>rdfs:label : liquid solution</para>
    ///   <para>dcterms:description : A liquid solution is a heterogeneous substance in a liquid state.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001084">sio:SIO_001084</a>
    /// </summary>
    let SIO_001084 = _prefixId.prefix "SIO_001084"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001085^^xsd:string</para>
    ///   <para>rdfs:label : to remove a covalent bond</para>
    ///   <para>dcterms:description : to remove a covalent bond is the capability to covalently modify a chemical entity by removing a covalent bond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001085">sio:SIO_001085</a>
    /// </summary>
    let SIO_001085 = _prefixId.prefix "SIO_001085"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001086^^xsd:string</para>
    ///   <para>rdfs:label : to add a covalent bond</para>
    ///   <para>dcterms:description : to add a covalent bond is the capability to covalently modify a chemical entity by adding a covalent bond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001086">sio:SIO_001086</a>
    /// </summary>
    let SIO_001086 = _prefixId.prefix "SIO_001086"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001087^^xsd:string</para>
    ///   <para>rdfs:label : to modify electronically</para>
    ///   <para>dcterms:description : to modify electronically is the capability to change the electronic properties of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001087">sio:SIO_001087</a>
    /// </summary>
    let SIO_001087 = _prefixId.prefix "SIO_001087"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001088^^xsd:string</para>
    ///   <para>rdfs:label : concentration</para>
    ///   <para>dcterms:description : concentration is the quantity of a constituent divided by the total volume of a mixture.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001088">sio:SIO_001088</a>
    /// </summary>
    let SIO_001088 = _prefixId.prefix "SIO_001088"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001089^^xsd:string</para>
    ///   <para>rdfs:label : pH</para>
    ///   <para>schema:comment : pH is defined as the decimal logarithm of the reciprocal of the hydrogen ion activity, aH+, in a solution.^^xsd:string</para>
    ///   <para>dcterms:description : pH is a measure of the activity of the (solvated) hydrogen ion. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001089">sio:SIO_001089</a>
    /// </summary>
    let SIO_001089 = _prefixId.prefix "SIO_001089"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001090^^xsd:string</para>
    ///   <para>rdfs:label : homogeneous</para>
    ///   <para>dcterms:description : homogeneous is a quality that describes the uniform composition of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001090">sio:SIO_001090</a>
    /// </summary>
    let SIO_001090 = _prefixId.prefix "SIO_001090"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001091^^xsd:string</para>
    ///   <para>rdfs:label : heterogeneous</para>
    ///   <para>dcterms:description : homogeneous is a quality that describes the varied composition of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001091">sio:SIO_001091</a>
    /// </summary>
    let SIO_001091 = _prefixId.prefix "SIO_001091"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001092^^xsd:string</para>
    ///   <para>rdfs:label : structural quality</para>
    ///   <para>dcterms:description : A structural quality is a quality of an object that describes its structure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001092">sio:SIO_001092</a>
    /// </summary>
    let SIO_001092 = _prefixId.prefix "SIO_001092"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001093^^xsd:string</para>
    ///   <para>rdfs:label : rigid</para>
    ///   <para>dcterms:description : rigid is the quality of maintaining structural integrity (and not bending) under pressure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001093">sio:SIO_001093</a>
    /// </summary>
    let SIO_001093 = _prefixId.prefix "SIO_001093"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001094^^xsd:string</para>
    ///   <para>rdfs:label : bent</para>
    ///   <para>dcterms:description : bent is the quality of a line being sharply curved or having an angle.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001094">sio:SIO_001094</a>
    /// </summary>
    let SIO_001094 = _prefixId.prefix "SIO_001094"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001095^^xsd:string</para>
    ///   <para>rdfs:label : curved</para>
    ///   <para>dcterms:description : curved is the quality of a line that deviates from straightness in a smooth, continuous fashion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001095">sio:SIO_001095</a>
    /// </summary>
    let SIO_001095 = _prefixId.prefix "SIO_001095"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001096^^xsd:string</para>
    ///   <para>rdfs:label : is specialization of</para>
    ///   <para>sio:example : a weather forecast for the city of London produced at a specific time is a specialization of a weather forecast for the city of London.</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/ns/prov#specializationOf^^xsd:anyURI</para>
    ///   <para>dcterms:description : is specialization of is a relation between a more specific instance (in terms of spatial/temporal localization &amp; other attributres) than the other.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001096">sio:SIO_001096</a>
    /// </summary>
    let SIO_001096 = _prefixId.prefix "SIO_001096"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001097^^xsd:string</para>
    ///   <para>rdfs:label : is generalization of</para>
    ///   <para>dcterms:description : is generalization of is a relation between a more general instance (in terms of spatial/temporal localization &amp; other attributres) than the other.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001097">sio:SIO_001097</a>
    /// </summary>
    let SIO_001097 = _prefixId.prefix "SIO_001097"
    /// <summary>
    ///   <para>sio:example : two weather forecasts for the city of London produced at different times or by different organizations (etc) are alternates of each other, and instances of / specializations of forecasts for the city of London.</para>
    ///   <para>sio:equivalentTo : http://www.w3.org/ns/prov#alternateOf^^xsd:anyURI</para>
    ///   <para>rdfs:label : is alternate of</para>
    ///   <para>dcterms:description : is alternate of relates two specialized instances.</para>
    ///   <para>dc11:identifier : SIO_001098^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001098">sio:SIO_001098</a>
    /// </summary>
    let SIO_001098 = _prefixId.prefix "SIO_001098"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001099^^xsd:string</para>
    ///   <para>rdfs:label : electronic structure</para>
    ///   <para>sio:hasSynonym : electronic configuration^^xsd:string</para>
    ///   <para>sio:example : the electron configuration of the neon atom is 1s2 2s2 2p6.</para>
    ///   <para>dcterms:description : electronic structure is the electron configuration is the distribution of electrons of an atom or molecule (or other physical structure) in atomic or molecular orbitals.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001099">sio:SIO_001099</a>
    /// </summary>
    let SIO_001099 = _prefixId.prefix "SIO_001099"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001100^^xsd:string</para>
    ///   <para>rdfs:label : crystal structure</para>
    ///   <para>dcterms:description : A crystal structure is the arrangement of atoms or molecules in a crystalline liquid or solid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001100">sio:SIO_001100</a>
    /// </summary>
    let SIO_001100 = _prefixId.prefix "SIO_001100"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001101^^xsd:string</para>
    ///   <para>rdfs:label : is mutual capability of</para>
    ///   <para>dcterms:description : a is mutual capability of b if and only if the realization of capability  a necessarily causes the realization of capability b.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001101">sio:SIO_001101</a>
    /// </summary>
    let SIO_001101 = _prefixId.prefix "SIO_001101"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001102^^xsd:string</para>
    ///   <para>rdfs:label : to interact and to be interacted with</para>
    ///   <para>dcterms:description : to interact and to be interacted with is a mutual disposition of interacting objects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001102">sio:SIO_001102</a>
    /// </summary>
    let SIO_001102 = _prefixId.prefix "SIO_001102"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001103^^xsd:string</para>
    ///   <para>rdfs:label : to gain a covalent bond</para>
    ///   <para>dcterms:description : to gain a covalent bond is the capability of a chemical entity to have bonds added.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001103">sio:SIO_001103</a>
    /// </summary>
    let SIO_001103 = _prefixId.prefix "SIO_001103"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001104^^xsd:string</para>
    ///   <para>rdfs:label : to lose a covalent bond</para>
    ///   <para>dcterms:description : to lose a covalent bond is the capability of a chemical entity to have bonds removed.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001104">sio:SIO_001104</a>
    /// </summary>
    let SIO_001104 = _prefixId.prefix "SIO_001104"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001105^^xsd:string</para>
    ///   <para>rdfs:label : to ingest</para>
    ///   <para>dcterms:description : to ingest is the capability to take into the body by the mouth for digestion or absorption.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001105">sio:SIO_001105</a>
    /// </summary>
    let SIO_001105 = _prefixId.prefix "SIO_001105"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001106^^xsd:string</para>
    ///   <para>rdfs:label : to produce</para>
    ///   <para>dcterms:description : to produce is the capability to create new objects</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001106">sio:SIO_001106</a>
    /// </summary>
    let SIO_001106 = _prefixId.prefix "SIO_001106"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001107^^xsd:string</para>
    ///   <para>rdfs:label : pathway</para>
    ///   <para>sio:hasSynonym : biological pathway^^xsd:string</para>
    ///   <para>dcterms:description : A pathway is an effective specification that outlines a set of actions that forms a way to achieve an objective.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001107">sio:SIO_001107</a>
    /// </summary>
    let SIO_001107 = _prefixId.prefix "SIO_001107"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001108^^xsd:string</para>
    ///   <para>rdfs:label : centrality measure</para>
    ///   <para>dcterms:description : A central tendency measure is a central value or a typical value for a probability distribution.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001108">sio:SIO_001108</a>
    /// </summary>
    let SIO_001108 = _prefixId.prefix "SIO_001108"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001109^^xsd:string</para>
    ///   <para>rdfs:label : mean</para>
    ///   <para>sio:hasSynonym : average^^xsd:stringsio:hasSynonym : arithmeritic mean^^xsd:string</para>
    ///   <para>dcterms:description : A mean is the central tendency of a collection of numbers taken as the sum of the numbers divided by the size of the collection.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001109">sio:SIO_001109</a>
    /// </summary>
    let SIO_001109 = _prefixId.prefix "SIO_001109"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001110^^xsd:string</para>
    ///   <para>rdfs:label : median</para>
    ///   <para>dcterms:description : A median is the numerical value separating the higher half of a sample, a population, or a probability distribution, from the lower half. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001110">sio:SIO_001110</a>
    /// </summary>
    let SIO_001110 = _prefixId.prefix "SIO_001110"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001111^^xsd:string</para>
    ///   <para>rdfs:label : mode</para>
    ///   <para>dcterms:description : A mode is the value that appears most often in a set of data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001111">sio:SIO_001111</a>
    /// </summary>
    let SIO_001111 = _prefixId.prefix "SIO_001111"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001112^^xsd:string</para>
    ///   <para>rdfs:label : sum</para>
    ///   <para>dcterms:description : A sum is the result of adding a set of values together.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001112">sio:SIO_001112</a>
    /// </summary>
    let SIO_001112 = _prefixId.prefix "SIO_001112"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001113^^xsd:string</para>
    ///   <para>rdfs:label : minimal value</para>
    ///   <para>sio:hasSynonym : min^^xsd:string</para>
    ///   <para>dcterms:description : A minimal value is smallest value of an attribute for the entities in the defined set.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001113">sio:SIO_001113</a>
    /// </summary>
    let SIO_001113 = _prefixId.prefix "SIO_001113"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001114^^xsd:string</para>
    ///   <para>rdfs:label : maximal value</para>
    ///   <para>sio:hasSynonym : max^^xsd:string</para>
    ///   <para>dcterms:description : A maximal value is largest value of an attribute for the entities in the defined set.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001114">sio:SIO_001114</a>
    /// </summary>
    let SIO_001114 = _prefixId.prefix "SIO_001114"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001115^^xsd:string</para>
    ///   <para>rdfs:label : member count</para>
    ///   <para>dcterms:description : A count of the instances of a class or members in a collection.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001115">sio:SIO_001115</a>
    /// </summary>
    let SIO_001115 = _prefixId.prefix "SIO_001115"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001116^^xsd:string</para>
    ///   <para>rdfs:label : union</para>
    ///   <para>dcterms:description : A union is a list of all of the values of an attribute for the entities in the defined set.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001116">sio:SIO_001116</a>
    /// </summary>
    let SIO_001116 = _prefixId.prefix "SIO_001116"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001117^^xsd:string</para>
    ///   <para>rdfs:label : intersection</para>
    ///   <para>dcterms:description : An intersection is a list of only the values of an attribute for the entities in the defined set where all entities have that value.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001117">sio:SIO_001117</a>
    /// </summary>
    let SIO_001117 = _prefixId.prefix "SIO_001117"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001118^^xsd:string</para>
    ///   <para>rdfs:label : sequence</para>
    ///   <para>sio:example : For example, (M, A, R, Y) is a sequence of letters that differs from (A, R, M, Y), as the ordering matters, and (1, 1, 2, 3, 5, 8), which contains the number 1 at two different positions, is a valid sequence. </para>
    ///   <para>dcterms:description : A sequence is an ordered list of entities. Like a set, it contains members (also called elements, or terms).</para>
    ///   <para>dcterms:alternative : ordered list^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001118">sio:SIO_001118</a>
    /// </summary>
    let SIO_001118 = _prefixId.prefix "SIO_001118"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001119^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with causal mutation</para>
    ///   <para>dcterms:description : A gene-variant disease association in which a mutation in the gene/protein results in the development or maintenance of the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001119">sio:SIO_001119</a>
    /// </summary>
    let SIO_001119 = _prefixId.prefix "SIO_001119"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001120^^xsd:string</para>
    ///   <para>rdfs:label : therapeutic gene-disease association</para>
    ///   <para>sio:hasSynonym : gene-disease association arising from a therapeutic role of the gene/protein^^xsd:string</para>
    ///   <para>dcterms:description : A gene disease association in which the gene is a therapeutic marker for the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001120">sio:SIO_001120</a>
    /// </summary>
    let SIO_001120 = _prefixId.prefix "SIO_001120"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001121^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease biomarker association</para>
    ///   <para>dcterms:description : A gene-disease association in which the gene/protein is involved in the etiology or maintenance of the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001121">sio:SIO_001121</a>
    /// </summary>
    let SIO_001121 = _prefixId.prefix "SIO_001121"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001122^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with genetic variation</para>
    ///   <para>sio:hasSynonym : gene variant-disease association^^xsd:string</para>
    ///   <para>dcterms:description : A gene-disease association in which a sequence variation (a mutation, a SNP) is associated with the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001122">sio:SIO_001122</a>
    /// </summary>
    let SIO_001122 = _prefixId.prefix "SIO_001122"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001123^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with altered gene expression</para>
    ///   <para>dcterms:description : A gene-disease association in which the disease phenotype is associated with an altered expression of the gene.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001123">sio:SIO_001123</a>
    /// </summary>
    let SIO_001123 = _prefixId.prefix "SIO_001123"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001124^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with post-translational modification</para>
    ///   <para>sio:example : methylation or phosphorylation of protein product</para>
    ///   <para>dcterms:description : A gene-disease association in which the disease phenotype is associated with post-translational modifications in the protein product.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001124">sio:SIO_001124</a>
    /// </summary>
    let SIO_001124 = _prefixId.prefix "SIO_001124"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001125^^xsd:string</para>
    ///   <para>rdfs:label : regulation of transcription</para>
    ///   <para>dcterms:description : A process that modulates the frequency, rate or extent of transcription.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001125">sio:SIO_001125</a>
    /// </summary>
    let SIO_001125 = _prefixId.prefix "SIO_001125"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001126^^xsd:string</para>
    ///   <para>rdfs:label : regulation of translation</para>
    ///   <para>dcterms:description : A process that modulates the frequency, rate or extent of translation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001126">sio:SIO_001126</a>
    /// </summary>
    let SIO_001126 = _prefixId.prefix "SIO_001126"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001127^^xsd:string</para>
    ///   <para>rdfs:label : regulation of molecular quantity</para>
    ///   <para>dcterms:description : A process that modulates the frequency, rate or extent of process involved in the creation or destruction of a molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001127">sio:SIO_001127</a>
    /// </summary>
    let SIO_001127 = _prefixId.prefix "SIO_001127"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001128^^xsd:string</para>
    ///   <para>rdfs:label : regulation of molecular production</para>
    ///   <para>dcterms:description : A process that modulates the frequency, rate or extent of process involved in the production of a molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001128">sio:SIO_001128</a>
    /// </summary>
    let SIO_001128 = _prefixId.prefix "SIO_001128"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001129^^xsd:string</para>
    ///   <para>rdfs:label : regulation of molecular degradation</para>
    ///   <para>dcterms:description : A process that modulates the frequency, rate or extent of process involved in the destruction of a molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001129">sio:SIO_001129</a>
    /// </summary>
    let SIO_001129 = _prefixId.prefix "SIO_001129"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001130^^xsd:string</para>
    ///   <para>rdfs:label : protein mediated regulation of translation</para>
    ///   <para>dcterms:description : A process mediated by a protein that modulates the frequency, rate or extent of translation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001130">sio:SIO_001130</a>
    /// </summary>
    let SIO_001130 = _prefixId.prefix "SIO_001130"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001131^^xsd:string</para>
    ///   <para>rdfs:label : rna mediated regulation of translation</para>
    ///   <para>dcterms:description : A process mediated by rna that modulates the frequency, rate or extent of translation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001131">sio:SIO_001131</a>
    /// </summary>
    let SIO_001131 = _prefixId.prefix "SIO_001131"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001132^^xsd:string</para>
    ///   <para>rdfs:label : process maintenance</para>
    ///   <para>dcterms:description : The process of maintaining some the frequency, rate or extent of another process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001132">sio:SIO_001132</a>
    /// </summary>
    let SIO_001132 = _prefixId.prefix "SIO_001132"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001133^^xsd:string</para>
    ///   <para>rdfs:label : increased frequency of process from increased regulation</para>
    ///   <para>dcterms:description : The increase of regulation leads to a increased occurence of processes of the target type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001133">sio:SIO_001133</a>
    /// </summary>
    let SIO_001133 = _prefixId.prefix "SIO_001133"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001134^^xsd:string</para>
    ///   <para>rdfs:label : decreased frequency of process from increased regulation</para>
    ///   <para>dcterms:description : The increase of regulation leads to a decreased occurence of processes of the target process type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001134">sio:SIO_001134</a>
    /// </summary>
    let SIO_001134 = _prefixId.prefix "SIO_001134"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001135^^xsd:string</para>
    ///   <para>rdfs:label : regulation of process frequency</para>
    ///   <para>dcterms:description : regulation of a process duration is a process that modulates the frequency of another process relative to some reference process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001135">sio:SIO_001135</a>
    /// </summary>
    let SIO_001135 = _prefixId.prefix "SIO_001135"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001136^^xsd:string</para>
    ///   <para>rdfs:label : regulation of process duration</para>
    ///   <para>dcterms:description : regulation of a process duration is a process that modulates the duration of another process relative to some reference process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001136">sio:SIO_001136</a>
    /// </summary>
    let SIO_001136 = _prefixId.prefix "SIO_001136"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001137^^xsd:string</para>
    ///   <para>rdfs:label : increased duration of process from increased regulation</para>
    ///   <para>dcterms:description : increased duration of process from increased regulation is a process in which the duration of the target process is increased as a result of increased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001137">sio:SIO_001137</a>
    /// </summary>
    let SIO_001137 = _prefixId.prefix "SIO_001137"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001138^^xsd:string</para>
    ///   <para>rdfs:label : decreased duration of process from increased regulation</para>
    ///   <para>dcterms:description : decreased duration of process from increased regulation is a process in which the duration of the target process is decreased as a result of increased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001138">sio:SIO_001138</a>
    /// </summary>
    let SIO_001138 = _prefixId.prefix "SIO_001138"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001139^^xsd:string</para>
    ///   <para>rdfs:label : regulation of process spatial extent</para>
    ///   <para>sio:example : heating the solution causes greater diffusion of a chemical.</para>
    ///   <para>dcterms:description : regulation of a process spatial extent is a process that modulates the spatial extent of another process relative to some reference process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001139">sio:SIO_001139</a>
    /// </summary>
    let SIO_001139 = _prefixId.prefix "SIO_001139"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001140^^xsd:string</para>
    ///   <para>rdfs:label : increased spatial extent of process from increased regulation</para>
    ///   <para>dcterms:description : The increase of regulation leads to a increased spatial extent of the target process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001140">sio:SIO_001140</a>
    /// </summary>
    let SIO_001140 = _prefixId.prefix "SIO_001140"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001141^^xsd:string</para>
    ///   <para>rdfs:label : decreased spatial extent of process from decreased regulation</para>
    ///   <para>dcterms:description : The increase of regulation leads to a decreased spatial extent of the target process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001141">sio:SIO_001141</a>
    /// </summary>
    let SIO_001141 = _prefixId.prefix "SIO_001141"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001142^^xsd:string</para>
    ///   <para>rdfs:label : maintenance of spatial extent of process</para>
    ///   <para>dcterms:description : maintenance of spatial extent of process is a regulation of a process' spatial extent within some specified parameter.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001142">sio:SIO_001142</a>
    /// </summary>
    let SIO_001142 = _prefixId.prefix "SIO_001142"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001143^^xsd:string</para>
    ///   <para>rdfs:label : maintenance of duration of process</para>
    ///   <para>dcterms:description : maintenance of duration of process is a process that regulates a target process to maintain its duration within an expected interval.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001143">sio:SIO_001143</a>
    /// </summary>
    let SIO_001143 = _prefixId.prefix "SIO_001143"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001144^^xsd:string</para>
    ///   <para>rdfs:label : maintenance of frequency of process</para>
    ///   <para>dcterms:description : maintenance of frequency of process is a process that regulates the number of occurences of a target process type to a specified number or interval.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001144">sio:SIO_001144</a>
    /// </summary>
    let SIO_001144 = _prefixId.prefix "SIO_001144"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001145^^xsd:string</para>
    ///   <para>rdfs:label : regulation of object quantity</para>
    ///   <para>dcterms:description : regulation of a participant quantity is the regulation of a process in which the quantity of its partcipants is changed.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001145">sio:SIO_001145</a>
    /// </summary>
    let SIO_001145 = _prefixId.prefix "SIO_001145"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001146^^xsd:string</para>
    ///   <para>rdfs:label : increased object production from increased regulation</para>
    ///   <para>dcterms:description : increased regulation leads to an increase in the number of target objects of a specified type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001146">sio:SIO_001146</a>
    /// </summary>
    let SIO_001146 = _prefixId.prefix "SIO_001146"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001147^^xsd:string</para>
    ///   <para>rdfs:label : decreased object production from increased regulation</para>
    ///   <para>dcterms:description : increased regulation leads to a decrease in the number of target objects of a specified type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001147">sio:SIO_001147</a>
    /// </summary>
    let SIO_001147 = _prefixId.prefix "SIO_001147"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001148^^xsd:string</para>
    ///   <para>rdfs:label : increased object consumption from increased regulation</para>
    ///   <para>dcterms:description : increased regulation leads to an increase in the consumption of an object of specified type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001148">sio:SIO_001148</a>
    /// </summary>
    let SIO_001148 = _prefixId.prefix "SIO_001148"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001149^^xsd:string</para>
    ///   <para>rdfs:label : decreased object consumption from increased regulation</para>
    ///   <para>dcterms:description : increased regulation leads to an decrease in the consumption of an object of specified type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001149">sio:SIO_001149</a>
    /// </summary>
    let SIO_001149 = _prefixId.prefix "SIO_001149"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001150^^xsd:string</para>
    ///   <para>rdfs:label : regulation of object consumption</para>
    ///   <para>dcterms:description : A process that modulates the frequency, rate or extent of process involved in the consumption of an object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001150">sio:SIO_001150</a>
    /// </summary>
    let SIO_001150 = _prefixId.prefix "SIO_001150"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001151^^xsd:string</para>
    ///   <para>rdfs:label : regulation of object production</para>
    ///   <para>dcterms:description : regulation of a participant quantity is the regulation of a process in which the quantity of a selected participant is increased.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001151">sio:SIO_001151</a>
    /// </summary>
    let SIO_001151 = _prefixId.prefix "SIO_001151"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001152^^xsd:string</para>
    ///   <para>rdfs:label : maintenance of quantity of object production</para>
    ///   <para>dcterms:description : maintenance of quantity of object production is a regulation of object production in which the number of objects produced is held more or less constant.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001152">sio:SIO_001152</a>
    /// </summary>
    let SIO_001152 = _prefixId.prefix "SIO_001152"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001153^^xsd:string</para>
    ///   <para>rdfs:label : maintenance of level of object consumption</para>
    ///   <para>dcterms:description : regulation of a participant quantity is the regulation of a process in which the quantity of a selected participant is maintained at a steady level.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001153">sio:SIO_001153</a>
    /// </summary>
    let SIO_001153 = _prefixId.prefix "SIO_001153"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001154^^xsd:string</para>
    ///   <para>rdfs:label : regulates</para>
    ///   <para>dcterms:description : x regulates y if and only if x is a process and y is either a process or a quality, and the progression of x exerts an effect on the frequency, rate or extent of y</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001154">sio:SIO_001154</a>
    /// </summary>
    let SIO_001154 = _prefixId.prefix "SIO_001154"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001155^^xsd:string</para>
    ///   <para>rdfs:label : is regulated by</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001155">sio:SIO_001155</a>
    /// </summary>
    let SIO_001155 = _prefixId.prefix "SIO_001155"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001156^^xsd:string</para>
    ///   <para>rdfs:label : results in</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001156">sio:SIO_001156</a>
    /// </summary>
    let SIO_001156 = _prefixId.prefix "SIO_001156"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001157^^xsd:string</para>
    ///   <para>rdfs:label : is result of</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001157">sio:SIO_001157</a>
    /// </summary>
    let SIO_001157 = _prefixId.prefix "SIO_001157"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001158^^xsd:string</para>
    ///   <para>rdfs:label : affects</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001158">sio:SIO_001158</a>
    /// </summary>
    let SIO_001158 = _prefixId.prefix "SIO_001158"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001159^^xsd:string</para>
    ///   <para>rdfs:label : is affected by</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001159">sio:SIO_001159</a>
    /// </summary>
    let SIO_001159 = _prefixId.prefix "SIO_001159"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001160^^xsd:string</para>
    ///   <para>rdfs:label : number of objects produced</para>
    ///   <para>dcterms:description : number of objects produced is a count of objects that were produced in some process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001160">sio:SIO_001160</a>
    /// </summary>
    let SIO_001160 = _prefixId.prefix "SIO_001160"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001161^^xsd:string</para>
    ///   <para>rdfs:label : number of objects consumed</para>
    ///   <para>dcterms:description : number of objects consumed is a count of objects that were consumed in some process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001161">sio:SIO_001161</a>
    /// </summary>
    let SIO_001161 = _prefixId.prefix "SIO_001161"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001162^^xsd:string</para>
    ///   <para>rdfs:label : difference in number of objects produced</para>
    ///   <para>dcterms:description : A difference in number of objects produced is a count of the number of objects produced with respect to a second variable (space, time, etc)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001162">sio:SIO_001162</a>
    /// </summary>
    let SIO_001162 = _prefixId.prefix "SIO_001162"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001163^^xsd:string</para>
    ///   <para>rdfs:label : increase in number of objects produced</para>
    ///   <para>dcterms:description : An increase in the number of objects produced is the positive value of a difference in number of objects produced.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001163">sio:SIO_001163</a>
    /// </summary>
    let SIO_001163 = _prefixId.prefix "SIO_001163"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001164^^xsd:string</para>
    ///   <para>rdfs:label : decrease in number of objects produced</para>
    ///   <para>dcterms:description : An decrease in the number of objects produced is the negative value of a difference in number of objects produced.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001164">sio:SIO_001164</a>
    /// </summary>
    let SIO_001164 = _prefixId.prefix "SIO_001164"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001165^^xsd:string</para>
    ///   <para>rdfs:label : user account</para>
    ///   <para>dcterms:description : user account allows a user to authenticate to system services and be granted authorization to access them.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001165">sio:SIO_001165</a>
    /// </summary>
    let SIO_001165 = _prefixId.prefix "SIO_001165"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001166^^xsd:string</para>
    ///   <para>rdfs:label : annotation</para>
    ///   <para>dcterms:description : An annotation is a written explanatory or critical description, or other in-context information (e.g., pattern, motif, link), that has been associated with data or other types of information.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001166">sio:SIO_001166</a>
    /// </summary>
    let SIO_001166 = _prefixId.prefix "SIO_001166"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001167^^xsd:string</para>
    ///   <para>rdfs:label : comment</para>
    ///   <para>dcterms:description : A comment is a verbal or written remark often related to an added piece of information, or an observation or statement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001167">sio:SIO_001167</a>
    /// </summary>
    let SIO_001167 = _prefixId.prefix "SIO_001167"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001168^^xsd:string</para>
    ///   <para>rdfs:label : audio recording</para>
    ///   <para>dcterms:description : An audio recording is an electrical or mechanical inscription and re-creation of sound waves, such as spoken voice, singing, instrumental music, or sound effects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001168">sio:SIO_001168</a>
    /// </summary>
    let SIO_001168 = _prefixId.prefix "SIO_001168"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001169^^xsd:string</para>
    ///   <para>rdfs:label : issue</para>
    ///   <para>dcterms:description : An issue is a single instance of a periodically published journal, magazine, or newspaper.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001169">sio:SIO_001169</a>
    /// </summary>
    let SIO_001169 = _prefixId.prefix "SIO_001169"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001170^^xsd:string</para>
    ///   <para>rdfs:label : slideshow</para>
    ///   <para>dcterms:description : A slideshow is a visual presentation of information contained within a collection of slides.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001170">sio:SIO_001170</a>
    /// </summary>
    let SIO_001170 = _prefixId.prefix "SIO_001170"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001171^^xsd:string</para>
    ///   <para>rdfs:label : database cross-reference</para>
    ///   <para>sio:hasSynonym : dbxref^^xsd:string</para>
    ///   <para>dcterms:description : A database cross-reference is an association between one data item and another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001171">sio:SIO_001171</a>
    /// </summary>
    let SIO_001171 = _prefixId.prefix "SIO_001171"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001172^^xsd:string</para>
    ///   <para>rdfs:label : exact cross-reference</para>
    ///   <para>dcterms:description : An exact cross-reference is a database cross-reference in which one entity is equivalent to the other based on all the entitie's attributes (minus the source).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001172">sio:SIO_001172</a>
    /// </summary>
    let SIO_001172 = _prefixId.prefix "SIO_001172"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001173^^xsd:string</para>
    ///   <para>rdfs:label : double stranded DNA</para>
    ///   <para>dcterms:description : double stranded nucleic acid is a molecular complex composed of two weakly connected deoxyribonucleic acids.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001173">sio:SIO_001173</a>
    /// </summary>
    let SIO_001173 = _prefixId.prefix "SIO_001173"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001174^^xsd:string</para>
    ///   <para>rdfs:label : nucleic acid strand</para>
    ///   <para>dcterms:description : A nucleic acid strand is a single-stranded nucleic acid that is part of a double stranded nucleic acid complex.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001174">sio:SIO_001174</a>
    /// </summary>
    let SIO_001174 = _prefixId.prefix "SIO_001174"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001175^^xsd:string</para>
    ///   <para>rdfs:label : positive nucleic acid strand</para>
    ///   <para>sio:hasSynonym : forward strand</para>
    ///   <para>dcterms:description : The positive nucleic acid strand refers to the strand that is to be read 5' to 3'.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001175">sio:SIO_001175</a>
    /// </summary>
    let SIO_001175 = _prefixId.prefix "SIO_001175"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001176^^xsd:string</para>
    ///   <para>rdfs:label : negative nucleic acid strand</para>
    ///   <para>sio:hasSynonym : reverse strand</para>
    ///   <para>dcterms:description : The negative nucleic acid strand is the strand that is that is complimentary to the forward strand and appears from 3' to 5'.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001176">sio:SIO_001176</a>
    /// </summary>
    let SIO_001176 = _prefixId.prefix "SIO_001176"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001177^^xsd:string</para>
    ///   <para>rdfs:label : double stranded nucleic acid</para>
    ///   <para>dcterms:description : double stranded nucleic acid is a molecular complex composed of two weakly connected nucleic acids.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001177">sio:SIO_001177</a>
    /// </summary>
    let SIO_001177 = _prefixId.prefix "SIO_001177"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001178^^xsd:string</para>
    ///   <para>rdfs:label : double stranded RNA</para>
    ///   <para>dcterms:description : double stranded nucleic acid is a molecular complex composed of two weakly connected ribonucleic acids.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001178">sio:SIO_001178</a>
    /// </summary>
    let SIO_001178 = _prefixId.prefix "SIO_001178"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001179^^xsd:string</para>
    ///   <para>rdfs:label : full agreement</para>
    ///   <para>dcterms:description : full agreement is the result of consensus decision making when members of the group unanimously agree.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001179">sio:SIO_001179</a>
    /// </summary>
    let SIO_001179 = _prefixId.prefix "SIO_001179"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001180^^xsd:string</para>
    ///   <para>rdfs:label : mass spectrometry experiment</para>
    ///   <para>dcterms:description : A mass spectrometry experiment is an experiment that involves the use of a mass spectrometer. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001180">sio:SIO_001180</a>
    /// </summary>
    let SIO_001180 = _prefixId.prefix "SIO_001180"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001181^^xsd:string</para>
    ///   <para>rdfs:label : full disagreement</para>
    ///   <para>dcterms:description : full agreement is the result of consensus decision making when members of the group unanimously disagree.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001181">sio:SIO_001181</a>
    /// </summary>
    let SIO_001181 = _prefixId.prefix "SIO_001181"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001182^^xsd:string</para>
    ///   <para>rdfs:label : ribosomal RNA gene</para>
    ///   <para>sio:hasSynonym : rRNA gene^^xsd:string</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0001637^^xsd:anyURI</para>
    ///   <para>dcterms:description : A ribosomal RNA gene is a gene that codes for a ribosomal RNA molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001182">sio:SIO_001182</a>
    /// </summary>
    let SIO_001182 = _prefixId.prefix "SIO_001182"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001183^^xsd:string</para>
    ///   <para>rdfs:label : statement</para>
    ///   <para>dcterms:description : A statement is a proposition that is either (a) a meaningful declarative sentence that is either true or false, or (b) that which a true or false declarative sentence asserts.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001183">sio:SIO_001183</a>
    /// </summary>
    let SIO_001183 = _prefixId.prefix "SIO_001183"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001184^^xsd:string</para>
    ///   <para>rdfs:label : slope</para>
    ///   <para>dcterms:description : A slope or gradient of a line describes its steepness, incline, or grade. A higher slope value indicates a steeper incline. Slope is normally described by the ratio of the "rise" divided by the "run" between two points on a line.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001184">sio:SIO_001184</a>
    /// </summary>
    let SIO_001184 = _prefixId.prefix "SIO_001184"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001185^^xsd:string</para>
    ///   <para>rdfs:label : software process identifier</para>
    ///   <para>dcterms:description : A software process identifier is an identifier for a software process in some operating system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001185">sio:SIO_001185</a>
    /// </summary>
    let SIO_001185 = _prefixId.prefix "SIO_001185"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001186^^xsd:string</para>
    ///   <para>rdfs:label : hypothetical</para>
    ///   <para>dcterms:description : hypothetical is the quality of an entity that is conjectured to exist.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001186">sio:SIO_001186</a>
    /// </summary>
    let SIO_001186 = _prefixId.prefix "SIO_001186"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001187^^xsd:string</para>
    ///   <para>rdfs:label : database row</para>
    ///   <para>dcterms:description : A database row is a row that is part of a database table.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001187">sio:SIO_001187</a>
    /// </summary>
    let SIO_001187 = _prefixId.prefix "SIO_001187"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001188^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://en.wikipedia.org/wiki/SADI^^xsd:anyURI</para>
    ///   <para>rdfs:label : SADI semantic web service</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>dcterms:description : a SADI semantic web service is a semantic web service that follows the SADI specification</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001188">sio:SIO_001188</a>
    /// </summary>
    let SIO_001188 = _prefixId.prefix "SIO_001188"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001189^^xsd:string</para>
    ///   <para>rdfs:label : semantic web service</para>
    ///   <para>dcterms:description : a semantic web service is a web service that provides a formal, machine understanble description of its functionality.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001189">sio:SIO_001189</a>
    /// </summary>
    let SIO_001189 = _prefixId.prefix "SIO_001189"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001190^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://en.wikipedia.org/wiki/REST^^xsd:anyURI</para>
    ///   <para>rdfs:label : REST web service</para>
    ///   <para>dcterms:description : a REST web service is a web service that provides functionality according to the Representational State Transfer (REST) specification.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001190">sio:SIO_001190</a>
    /// </summary>
    let SIO_001190 = _prefixId.prefix "SIO_001190"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001191^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://en.wikipedia.org/wiki/SOAP^^xsd:anyURI</para>
    ///   <para>rdfs:label : SOAP web service</para>
    ///   <para>dcterms:description : a SOAP web service is a web service that implements Simple Object Access Protocol (SOAP).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001191">sio:SIO_001191</a>
    /// </summary>
    let SIO_001191 = _prefixId.prefix "SIO_001191"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001192^^xsd:string</para>
    ///   <para>rdfs:label : web service invocation</para>
    ///   <para>dcterms:description : A web service invocation involves the execution of a web service.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001192">sio:SIO_001192</a>
    /// </summary>
    let SIO_001192 = _prefixId.prefix "SIO_001192"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001193^^xsd:string</para>
    ///   <para>rdfs:label : SADI web service invocation</para>
    ///   <para>sio:subset : sadi</para>
    ///   <para>dcterms:description : A SADI web service invocation is the excution of a SADI web service.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001193">sio:SIO_001193</a>
    /// </summary>
    let SIO_001193 = _prefixId.prefix "SIO_001193"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001194^^xsd:string</para>
    ///   <para>rdfs:label : media</para>
    ///   <para>dcterms:description : media are audo/visual/audiovisual modes of communicating information for mass consumption.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001194">sio:SIO_001194</a>
    /// </summary>
    let SIO_001194 = _prefixId.prefix "SIO_001194"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001195^^xsd:string</para>
    ///   <para>rdfs:label : behaviour</para>
    ///   <para>sio:subset : core^^xsd:stringsio:subset : behaviour+^^xsd:string</para>
    ///   <para>dcterms:description : Behaviour is the set of actions and mannerisms made by systems (biological or otherwise) in response to stimuli or inputs, whether internal or external, conscious or subconscious, overt or covert, and voluntary or involuntary.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001195">sio:SIO_001195</a>
    /// </summary>
    let SIO_001195 = _prefixId.prefix "SIO_001195"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001196^^xsd:string</para>
    ///   <para>rdfs:label : history</para>
    ///   <para>dcterms:description : history is a sequence of past events.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001196">sio:SIO_001196</a>
    /// </summary>
    let SIO_001196 = _prefixId.prefix "SIO_001196"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001197^^xsd:string</para>
    ///   <para>rdfs:label : structural motif</para>
    ///   <para>dcterms:description : A structural motif is a pattern in a structure formed by the spatial arrangement of atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001197">sio:SIO_001197</a>
    /// </summary>
    let SIO_001197 = _prefixId.prefix "SIO_001197"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001198^^xsd:string</para>
    ///   <para>rdfs:label : consensus</para>
    ///   <para>dcterms:description : consensus is an acceptable resolution, one that can be supported, even if not the preferred outcome for each individual.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001198">sio:SIO_001198</a>
    /// </summary>
    let SIO_001198 = _prefixId.prefix "SIO_001198"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001199^^xsd:string</para>
    ///   <para>rdfs:label : increased molecular degradation from increased regulation</para>
    ///   <para>dcterms:description : A process that increases the frequency, rate or extent of process involved in the destruction of a molecule as a result of increased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001199">sio:SIO_001199</a>
    /// </summary>
    let SIO_001199 = _prefixId.prefix "SIO_001199"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001200^^xsd:string</para>
    ///   <para>rdfs:label : decreased molecular degradation from decreased regulation</para>
    ///   <para>dcterms:description : A process that decreases the frequency, rate or extent of process involved in the destruction of a molecule as a result of decreased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001200">sio:SIO_001200</a>
    /// </summary>
    let SIO_001200 = _prefixId.prefix "SIO_001200"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001201^^xsd:string</para>
    ///   <para>rdfs:label : increased molecular degradation from decreased regulation</para>
    ///   <para>dcterms:description : A process that increases the frequency, rate or extent of process involved in the destruction of a molecule as a result of decreased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001201">sio:SIO_001201</a>
    /// </summary>
    let SIO_001201 = _prefixId.prefix "SIO_001201"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001202^^xsd:string</para>
    ///   <para>rdfs:label : decreased molecular degradation from increased regulation</para>
    ///   <para>dcterms:description : A process that decreases the frequency, rate or extent of process involved in the destruction of a molecule as a result of increased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001202">sio:SIO_001202</a>
    /// </summary>
    let SIO_001202 = _prefixId.prefix "SIO_001202"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001203^^xsd:string</para>
    ///   <para>rdfs:label : increased molecular production from increased regulation</para>
    ///   <para>dcterms:description : A process that increases the frequency, rate or extent of process involved in the production of a molecule as a result of increased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001203">sio:SIO_001203</a>
    /// </summary>
    let SIO_001203 = _prefixId.prefix "SIO_001203"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001204^^xsd:string</para>
    ///   <para>rdfs:label : decreased molecular production from increased regulation</para>
    ///   <para>dcterms:description : A process that decreases the frequency, rate or extent of process involved in the production of a molecule as a result of increased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001204">sio:SIO_001204</a>
    /// </summary>
    let SIO_001204 = _prefixId.prefix "SIO_001204"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001205^^xsd:string</para>
    ///   <para>rdfs:label : increased molecular production from decreased regulation</para>
    ///   <para>dcterms:description : A process that increases the frequency, rate or extent of process involved in the production of a molecule as a result of decreased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001205">sio:SIO_001205</a>
    /// </summary>
    let SIO_001205 = _prefixId.prefix "SIO_001205"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001206^^xsd:string</para>
    ///   <para>rdfs:label : decreased molecular production from decreased regulation</para>
    ///   <para>dcterms:description : A process that decreases the frequency, rate or extent of process involved in the production of a molecule as a result of decreased regulation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001206">sio:SIO_001206</a>
    /// </summary>
    let SIO_001206 = _prefixId.prefix "SIO_001206"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001207^^xsd:string</para>
    ///   <para>rdfs:label : increased chemical destruction</para>
    ///   <para>dcterms:description : increased chemical destruction is a process in which there is an increase in the amount of chemical destroyed relative to some reference process</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001207">sio:SIO_001207</a>
    /// </summary>
    let SIO_001207 = _prefixId.prefix "SIO_001207"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001208^^xsd:string</para>
    ///   <para>rdfs:label : decreased chemical destruction</para>
    ///   <para>dcterms:description : decreased chemical destruction is a process in which there is a decrease in the amount of chemical destroyed relative to some reference process</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001208">sio:SIO_001208</a>
    /// </summary>
    let SIO_001208 = _prefixId.prefix "SIO_001208"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001209^^xsd:string</para>
    ///   <para>rdfs:label : assertional qualifier</para>
    ///   <para>dcterms:description : An assertional qualifier is the quality of affirmation, either being positive or negative.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001209">sio:SIO_001209</a>
    /// </summary>
    let SIO_001209 = _prefixId.prefix "SIO_001209"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001210^^xsd:string</para>
    ///   <para>rdfs:label : positive</para>
    ///   <para>dcterms:description : positive is an assertional qualifier that expresses the validity or truth of a basic assertion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001210">sio:SIO_001210</a>
    /// </summary>
    let SIO_001210 = _prefixId.prefix "SIO_001210"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001211^^xsd:string</para>
    ///   <para>rdfs:label : negative</para>
    ///   <para>dcterms:description : negative is an assertional qualifier that expresses the falsity or lack of truth of a basic assertion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001211">sio:SIO_001211</a>
    /// </summary>
    let SIO_001211 = _prefixId.prefix "SIO_001211"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001212^^xsd:string</para>
    ///   <para>rdfs:label : intensity</para>
    ///   <para>dcterms:description : intensity is a quality that represents the strength or degree of something.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001212">sio:SIO_001212</a>
    /// </summary>
    let SIO_001212 = _prefixId.prefix "SIO_001212"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001213^^xsd:string</para>
    ///   <para>rdfs:label : mild</para>
    ///   <para>dcterms:description : mild is a qualitative intensity value that is more intense than weak, but less intense than moderate.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001213">sio:SIO_001213</a>
    /// </summary>
    let SIO_001213 = _prefixId.prefix "SIO_001213"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001214^^xsd:string</para>
    ///   <para>rdfs:label : moderate</para>
    ///   <para>dcterms:description : moderate is a qualitative intensity value that is more intense than mild, but less intense than strong.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001214">sio:SIO_001214</a>
    /// </summary>
    let SIO_001214 = _prefixId.prefix "SIO_001214"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001215^^xsd:string</para>
    ///   <para>rdfs:label : severe</para>
    ///   <para>dcterms:description : severe is a qualitative intensity value that is more intense than strong, but less intense than fatal.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001215">sio:SIO_001215</a>
    /// </summary>
    let SIO_001215 = _prefixId.prefix "SIO_001215"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001216^^xsd:string</para>
    ///   <para>rdfs:label : fatal</para>
    ///   <para>dcterms:description : fatal is a qualitative intensity value that is more intense than severe, leading to the death/non-functioning of a system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001216">sio:SIO_001216</a>
    /// </summary>
    let SIO_001216 = _prefixId.prefix "SIO_001216"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001217^^xsd:string</para>
    ///   <para>rdfs:label : strong</para>
    ///   <para>dcterms:description : strong is a qualitative intensity value that is more intense than moderate, but less intense than severe.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001217">sio:SIO_001217</a>
    /// </summary>
    let SIO_001217 = _prefixId.prefix "SIO_001217"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001218^^xsd:string</para>
    ///   <para>rdfs:label : weak</para>
    ///   <para>dcterms:description : weak is a qualitative intensity value that is more intense than none, but less intense than mild.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001218">sio:SIO_001218</a>
    /// </summary>
    let SIO_001218 = _prefixId.prefix "SIO_001218"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001219^^xsd:string</para>
    ///   <para>rdfs:label : to test a hypothesis</para>
    ///   <para>dcterms:description : to test a hypothesis is the capability to evaluate the truth value of a proposition based on gathered evidence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001219">sio:SIO_001219</a>
    /// </summary>
    let SIO_001219 = _prefixId.prefix "SIO_001219"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001220^^xsd:string</para>
    ///   <para>rdfs:label : to characterize</para>
    ///   <para>dcterms:description : to characterize is the capability to classify the attributes or features of an entity against a reference classification.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001220">sio:SIO_001220</a>
    /// </summary>
    let SIO_001220 = _prefixId.prefix "SIO_001220"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001221^^xsd:string</para>
    ///   <para>rdfs:label : to describe</para>
    ///   <para>dcterms:description : to describe is the capabilty to communicate facts about an entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001221">sio:SIO_001221</a>
    /// </summary>
    let SIO_001221 = _prefixId.prefix "SIO_001221"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001222^^xsd:string</para>
    ///   <para>rdfs:label : 5' splice site</para>
    ///   <para>dcterms:description : The 5' splice site is the terminal region of an exon that is 5' to the intron that is to be excised.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001222">sio:SIO_001222</a>
    /// </summary>
    let SIO_001222 = _prefixId.prefix "SIO_001222"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001223^^xsd:string</para>
    ///   <para>rdfs:label : 3' splice site</para>
    ///   <para>dcterms:description : The 3' splice site is the terminal region of an exon that is 3' to the intron that is to be excised.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001223">sio:SIO_001223</a>
    /// </summary>
    let SIO_001223 = _prefixId.prefix "SIO_001223"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001224^^xsd:string</para>
    ///   <para>rdfs:label : amino acid</para>
    ///   <para>dcterms:description : An amino acid is an organic molecule composed of a carbon bonded to four different groups: a carboxyl group, an amino group, an R group, and a hydrogen atom. In the case of glycine, the R group is another hydrogen atom.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001224">sio:SIO_001224</a>
    /// </summary>
    let SIO_001224 = _prefixId.prefix "SIO_001224"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001225^^xsd:string</para>
    ///   <para>rdfs:label : cis regulatory element</para>
    ///   <para>dcterms:description : A cisregulatory element is a DNA sequence located on the same DNA strand or chromosome as the gene whose expression it affects. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001225">sio:SIO_001225</a>
    /// </summary>
    let SIO_001225 = _prefixId.prefix "SIO_001225"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001226^^xsd:string</para>
    ///   <para>rdfs:label : trans-regulatory element</para>
    ///   <para>dcterms:description : A trans-regulatory element is a DNA sequence associated with the regulation of a gene located outside the genomic region supporting the corresponding structural DNA region of the trans-regulatory element (i.e., a different DNA strand or different chromosome).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001226">sio:SIO_001226</a>
    /// </summary>
    let SIO_001226 = _prefixId.prefix "SIO_001226"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001227^^xsd:string</para>
    ///   <para>rdfs:label : small cytoplasmic RNA (scRNA) gene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0001266^^xsd:anyURI</para>
    ///   <para>dcterms:description : A small cytoplasmic RNA (scRNA) gene is a gene that encodes a small (7S; 129 nucleotides) RNA molecule found in the cytosol and rough endoplasmic reticulum that are normally associated with proteins that are involved in specific selection and transport of other proteins.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001227">sio:SIO_001227</a>
    /// </summary>
    let SIO_001227 = _prefixId.prefix "SIO_001227"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001228^^xsd:string</para>
    ///   <para>rdfs:label : small nuclear RNA (snRNA) gene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0001268^^xsd:anyURI</para>
    ///   <para>dcterms:description : A small nuclear RNA (snRNA) gene is a gene that encodes a small niuclear RNA molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001228">sio:SIO_001228</a>
    /// </summary>
    let SIO_001228 = _prefixId.prefix "SIO_001228"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001229^^xsd:string</para>
    ///   <para>rdfs:label : small nucleolar RNA (snoRNA) gene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0001267^^xsd:anyURI</para>
    ///   <para>dcterms:description : A small nucleolar RNA (snoRNA) gene is a gene that encodes a small RNA that are associated with the eukaryotic nucleus as components of small nucleolar ribonucleoproteins.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001229">sio:SIO_001229</a>
    /// </summary>
    let SIO_001229 = _prefixId.prefix "SIO_001229"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001230^^xsd:string</para>
    ///   <para>sio:hasSynonym : tRNA genesio:hasSynonym : solube RNA (sRNA) gene</para>
    ///   <para>dcterms:description : A transfer RNA (tRNA) gene is a gene that codes for a tRNA used in the translation of a messenger RNA (mRNA) to produce a protein product.</para>
    ///   <para>rdfs:label : transfer RNA (tRNA) gene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0001272^^xsd:anyURI</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001230">sio:SIO_001230</a>
    /// </summary>
    let SIO_001230 = _prefixId.prefix "SIO_001230"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001231^^xsd:string</para>
    ///   <para>rdfs:label : small cytoplasmic RNA (scRNA)</para>
    ///   <para>sio:hasSynonym : scRNA</para>
    ///   <para>dcterms:description : A small cytoplasmic RNA (scRNA) molecule is a small (7S; 129 nucleotides) RNA molecule found in the cytosol and rough endoplasmic reticulum that are normally associated with proteins that are involved in specific selection and transport of other proteins.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001231">sio:SIO_001231</a>
    /// </summary>
    let SIO_001231 = _prefixId.prefix "SIO_001231"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001232^^xsd:string</para>
    ///   <para>rdfs:label : transfer RNA (tRNA)</para>
    ///   <para>sio:hasSynonym : tRNA</para>
    ///   <para>dcterms:description : A transfer RNA (tRNA) is an RNA molecule that aids in the translation of a messenger RNA (mRNA) to produce a protein product.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001232">sio:SIO_001232</a>
    /// </summary>
    let SIO_001232 = _prefixId.prefix "SIO_001232"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001233^^xsd:string</para>
    ///   <para>rdfs:label : small nuclear RNA (snRNA)</para>
    ///   <para>sio:hasSynonym : snRNA</para>
    ///   <para>dcterms:description : A small nuclear RNA (snRNA) is a small RNA molecule that is located in the nucleus of a cell.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001233">sio:SIO_001233</a>
    /// </summary>
    let SIO_001233 = _prefixId.prefix "SIO_001233"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001234^^xsd:string</para>
    ///   <para>rdfs:label : small nucleolar RNA (snoRNA)</para>
    ///   <para>sio:hasSynonym : snoRNA</para>
    ///   <para>dcterms:description : A small nucleolar RNA (snoRNA) is a small RNA that are associated with the eukaryotic nucleus as components of small nucleolar ribonucleoproteins.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001234">sio:SIO_001234</a>
    /// </summary>
    let SIO_001234 = _prefixId.prefix "SIO_001234"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001235^^xsd:string</para>
    ///   <para>rdfs:label : non-protein coding RNA (ncRNA)</para>
    ///   <para>dcterms:description : A non-protein coding RNA (ncRNA) is a RNA molecular that cannot be used as a template for generating a protein product.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001235">sio:SIO_001235</a>
    /// </summary>
    let SIO_001235 = _prefixId.prefix "SIO_001235"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001236^^xsd:string</para>
    ///   <para>rdfs:label : data collection device</para>
    ///   <para>dcterms:description : A data collection device is a device that collects information about one or more objects.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001236">sio:SIO_001236</a>
    /// </summary>
    let SIO_001236 = _prefixId.prefix "SIO_001236"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001237^^xsd:string</para>
    ///   <para>rdfs:label : mass spectrometer</para>
    ///   <para>sio:similarTo : http://purl.obolibrary.org/obo/OBI_0000049^^xsd:anyURI</para>
    ///   <para>dcterms:description : A mass spectrometer is a device that identifies ions based on their mass to charge ratio using an electromagnetic field.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001237">sio:SIO_001237</a>
    /// </summary>
    let SIO_001237 = _prefixId.prefix "SIO_001237"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001238^^xsd:string</para>
    ///   <para>rdfs:label : microarray device</para>
    ///   <para>sio:similarTo : http://purl.obolibrary.org/obo/OBI_0000052^^xsd:anyURI</para>
    ///   <para>sio:hasSynonym : microarray platform</para>
    ///   <para>dcterms:description : A microarray device is a device that identifies the binding of a target substance to a physically immobile substrate placed in an array or lattice.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001238">sio:SIO_001238</a>
    /// </summary>
    let SIO_001238 = _prefixId.prefix "SIO_001238"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001239^^xsd:string</para>
    ///   <para>rdfs:label : to identify</para>
    ///   <para>dcterms:description : to identify is the capability to determine the identity of something.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001239">sio:SIO_001239</a>
    /// </summary>
    let SIO_001239 = _prefixId.prefix "SIO_001239"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001240^^xsd:string</para>
    ///   <para>rdfs:label : nmr device</para>
    ///   <para>sio:hasSynonym : nuclear magnetic resonance device</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/OBI_0000566^^xsd:anyURI</para>
    ///   <para>dcterms:description : A nuclear magnetic resonance (NMR) device is a device that applies a magnetic field to perturb nuclei with an odd number of protons and/or of neutrons in order to hav them absort and re-emit electromagnetic radiation. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001240">sio:SIO_001240</a>
    /// </summary>
    let SIO_001240 = _prefixId.prefix "SIO_001240"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001241^^xsd:string</para>
    ///   <para>rdfs:label : catalog</para>
    ///   <para>sio:hasSynonym : registry</para>
    ///   <para>dcterms:description : A catalog is a systemic collection of items of the same type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001241">sio:SIO_001241</a>
    /// </summary>
    let SIO_001241 = _prefixId.prefix "SIO_001241"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001242^^xsd:string</para>
    ///   <para>rdfs:label : is identical to</para>
    ///   <para>dcterms:description : is identical to is a relation between two objects that are conceptually the same notwithstanding provenance or other non-intrinsic attributes.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001242">sio:SIO_001242</a>
    /// </summary>
    let SIO_001242 = _prefixId.prefix "SIO_001242"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001243^^xsd:string</para>
    ///   <para>rdfs:label : likelihood</para>
    ///   <para>dcterms:description : Likelihood is the hypothetical probability that an event that has already occurred would yield a specific outcome.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001243">sio:SIO_001243</a>
    /// </summary>
    let SIO_001243 = _prefixId.prefix "SIO_001243"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001244^^xsd:string</para>
    ///   <para>rdfs:label : log likelihood</para>
    ///   <para>dcterms:description : Log likelihood is the natural logarithm of the likelihood function</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001244">sio:SIO_001244</a>
    /// </summary>
    let SIO_001244 = _prefixId.prefix "SIO_001244"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001245^^xsd:string</para>
    ///   <para>rdfs:label : standard score</para>
    ///   <para>sio:hasSynonym : z-value, z-score, normal score, standardadized variable.</para>
    ///   <para>dcterms:description : A standard score is the (signed) number of standard deviations an observation or datum is above the mean. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001245">sio:SIO_001245</a>
    /// </summary>
    let SIO_001245 = _prefixId.prefix "SIO_001245"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001246^^xsd:string</para>
    ///   <para>rdfs:label : interval</para>
    ///   <para>sio:example : The set of all numbers x satisfying 0&lt;=x&lt;=1 is an interval which contains 0 and 1, as well as numbers between them.</para>
    ///   <para>dcterms:description : an interval is a set of real numbers with the property that any number that lies between thwo numbers in the set is also included in the set. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_001246">sio:SIO_001246</a>
    /// </summary>
    let SIO_001246 = _prefixId.prefix "SIO_001246"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001247^^xsd:string</para>
    ///   <para>rdfs:label : is transitively related to</para>
    ///   <para>sio:subset : ovopub^^xsd:string</para>
    ///   <para>schema:comment : not implemented in standard distribution^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001247">sio:SIO_001247</a>
    /// </summary>
    let SIO_001247 = _prefixId.prefix "SIO_001247"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001248^^xsd:string</para>
    ///   <para>rdfs:label : open interval</para>
    ///   <para>sio:example : (0,1) is an open interval that is greater than 0 and less than 1.</para>
    ///   <para>dcterms:description : an open interval is an interval that does not include its endpoints.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001248">sio:SIO_001248</a>
    /// </summary>
    let SIO_001248 = _prefixId.prefix "SIO_001248"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001249^^xsd:string</para>
    ///   <para>rdfs:label : closed interval</para>
    ///   <para>sio:example : [0,1] is a closed interval that is greater than or equal to 0 and less than or equal to 1.</para>
    ///   <para>dcterms:description : A closed interval is an interval that includes its endpoints, and is denoted with square brackets.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001249">sio:SIO_001249</a>
    /// </summary>
    let SIO_001249 = _prefixId.prefix "SIO_001249"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001250^^xsd:string</para>
    ///   <para>rdfs:label : chemical-pathway association</para>
    ///   <para>sio:hasSynonym : drug-pathway association</para>
    ///   <para>dcterms:description : a chemical-pathway association is an association between a chemical and a pathway.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001250">sio:SIO_001250</a>
    /// </summary>
    let SIO_001250 = _prefixId.prefix "SIO_001250"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001251^^xsd:string</para>
    ///   <para>rdfs:label : left open interval</para>
    ///   <para>dcterms:description : a left open interval is an interval in which there is no element that is smaller than all other elements.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001251">sio:SIO_001251</a>
    /// </summary>
    let SIO_001251 = _prefixId.prefix "SIO_001251"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001252^^xsd:string</para>
    ///   <para>rdfs:label : right open interval</para>
    ///   <para>dcterms:description : a right open interval is an interval in which there is no element that is greater than all other elements.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001252">sio:SIO_001252</a>
    /// </summary>
    let SIO_001252 = _prefixId.prefix "SIO_001252"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001253^^xsd:string</para>
    ///   <para>rdfs:label : right closed interval</para>
    ///   <para>dcterms:description : a right closed interval is an interval in which there is a real number that is larger than all of its elements.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001253">sio:SIO_001253</a>
    /// </summary>
    let SIO_001253 = _prefixId.prefix "SIO_001253"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001254^^xsd:string</para>
    ///   <para>rdfs:label : left closed interval</para>
    ///   <para>dcterms:description : a left closed interval is an interval in which there is a real number that is smaller than all its elements.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001254">sio:SIO_001254</a>
    /// </summary>
    let SIO_001254 = _prefixId.prefix "SIO_001254"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001255^^xsd:string</para>
    ///   <para>rdfs:label : pharmacokinetic pathway</para>
    ///   <para>dcterms:description : a pharmacokinetic pathway is a metabolic pathway which describes the metabolism of a drug molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001255">sio:SIO_001255</a>
    /// </summary>
    let SIO_001255 = _prefixId.prefix "SIO_001255"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001256^^xsd:string</para>
    ///   <para>rdfs:label : pharmacodynamic pathway</para>
    ///   <para>dcterms:description : a pharmacodynamic pathay is a regulatory pathway in which a drug molecule regulates the activity of one or more components organized in a pathway.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001256">sio:SIO_001256</a>
    /// </summary>
    let SIO_001256 = _prefixId.prefix "SIO_001256"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001257^^xsd:string</para>
    ///   <para>rdfs:label : chemical-gene assocation</para>
    ///   <para>dcterms:description : a chemical-gene assocation is an assocation between a chemical and a gene.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001257">sio:SIO_001257</a>
    /// </summary>
    let SIO_001257 = _prefixId.prefix "SIO_001257"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001258^^xsd:string</para>
    ///   <para>rdfs:label : set item</para>
    ///   <para>dcterms:description : set item is an item in a set.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001258">sio:SIO_001258</a>
    /// </summary>
    let SIO_001258 = _prefixId.prefix "SIO_001258"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001259^^xsd:string</para>
    ///   <para>rdfs:label : collection item</para>
    ///   <para>dcterms:description : a collection item is an item in a collection.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001259">sio:SIO_001259</a>
    /// </summary>
    let SIO_001259 = _prefixId.prefix "SIO_001259"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001260^^xsd:string</para>
    ///   <para>rdfs:label : list item</para>
    ///   <para>dcterms:description : a list item is an item in a list.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001260">sio:SIO_001260</a>
    /// </summary>
    let SIO_001260 = _prefixId.prefix "SIO_001260"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001261^^xsd:string</para>
    ///   <para>rdfs:label : ordered list item</para>
    ///   <para>dcterms:description : an ordered list item is an item in an ordered list.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001261">sio:SIO_001261</a>
    /// </summary>
    let SIO_001261 = _prefixId.prefix "SIO_001261"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001262^^xsd:string</para>
    ///   <para>rdfs:label : anatomical entity</para>
    ///   <para>dcterms:description : an anatomical entity is an object that is a structural part (material or immaterial) of a biological entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001262">sio:SIO_001262</a>
    /// </summary>
    let SIO_001262 = _prefixId.prefix "SIO_001262"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001263^^xsd:string</para>
    ///   <para>rdfs:label : zygosity</para>
    ///   <para>dcterms:description : zygosity is the quality pertaining to the allelic complement of a biological system at a single locus on the DNA.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001263">sio:SIO_001263</a>
    /// </summary>
    let SIO_001263 = _prefixId.prefix "SIO_001263"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001264^^xsd:string</para>
    ///   <para>rdfs:label : homozygous</para>
    ///   <para>dcterms:description : homozygous is the quality of a biological organism in which there are two identical alleles at a given locus.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001264">sio:SIO_001264</a>
    /// </summary>
    let SIO_001264 = _prefixId.prefix "SIO_001264"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001265^^xsd:string</para>
    ///   <para>rdfs:label : heterozygous</para>
    ///   <para>dcterms:description : homozygous is the quality of a biological organism in which there are two different alleles at a given locus.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001265">sio:SIO_001265</a>
    /// </summary>
    let SIO_001265 = _prefixId.prefix "SIO_001265"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001266^^xsd:string</para>
    ///   <para>rdfs:label : hemizygous</para>
    ///   <para>dcterms:description : hemizygous is the quality of a biological organism in which, based on the ploidy of the organism, there is half the number of alleles than normal at a given locus.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001266">sio:SIO_001266</a>
    /// </summary>
    let SIO_001266 = _prefixId.prefix "SIO_001266"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001267^^xsd:string</para>
    ///   <para>rdfs:label : nullizygous</para>
    ///   <para>dcterms:description : nullizygous is the quality of a biological organism in which there are no allelles at a given locus.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001267">sio:SIO_001267</a>
    /// </summary>
    let SIO_001267 = _prefixId.prefix "SIO_001267"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001268^^xsd:string</para>
    ///   <para>rdfs:label : parental transmission</para>
    ///   <para>dcterms:description : parental transmition is the quality of a biological organism in which the (genetic) material is transmitted from a parental unit.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001268">sio:SIO_001268</a>
    /// </summary>
    let SIO_001268 = _prefixId.prefix "SIO_001268"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001269^^xsd:string</para>
    ///   <para>rdfs:label : maternally transmitted</para>
    ///   <para>dcterms:description : maternally transmitted is the quality of a biological organism in which the (genetic) material is transmitted from the maternal line.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001269">sio:SIO_001269</a>
    /// </summary>
    let SIO_001269 = _prefixId.prefix "SIO_001269"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001270^^xsd:string</para>
    ///   <para>rdfs:label : paternally transmitted</para>
    ///   <para>dcterms:description : paternally transmitted is the quality of a biological organism in which the (genetic) material is transmitted from the paternal line.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001270">sio:SIO_001270</a>
    /// </summary>
    let SIO_001270 = _prefixId.prefix "SIO_001270"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001271^^xsd:string</para>
    ///   <para>rdfs:label : helicity</para>
    ///   <para>dcterms:description : helicity is the quality of being helical</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001271">sio:SIO_001271</a>
    /// </summary>
    let SIO_001271 = _prefixId.prefix "SIO_001271"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001272^^xsd:string</para>
    ///   <para>rdfs:label : circularly helical</para>
    ///   <para>dcterms:description : a circularly helical quality is the quality of a helix that is connected in a circle or loop.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001272">sio:SIO_001272</a>
    /// </summary>
    let SIO_001272 = _prefixId.prefix "SIO_001272"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001273^^xsd:string</para>
    ///   <para>rdfs:label : left-handed helical</para>
    ///   <para>dcterms:description : left-handed helical quality is the quality in which a clockwise screwing motion moves the helix towards the observed along the line of sight along the helix's axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001273">sio:SIO_001273</a>
    /// </summary>
    let SIO_001273 = _prefixId.prefix "SIO_001273"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001274^^xsd:string</para>
    ///   <para>rdfs:label : right-handed helical</para>
    ///   <para>dcterms:description : right-handed helical quality is the quality in which a clockwise screwing motion moves the helix away from the observed along the line of sight along the helix's axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001274">sio:SIO_001274</a>
    /// </summary>
    let SIO_001274 = _prefixId.prefix "SIO_001274"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001275^^xsd:string</para>
    ///   <para>rdfs:label : coding frame offset</para>
    ///   <para>dcterms:description : a coding frame offset is a numeric value that indicates the number of bases from a reference start codon position.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001275">sio:SIO_001275</a>
    /// </summary>
    let SIO_001275 = _prefixId.prefix "SIO_001275"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001276^^xsd:string</para>
    ///   <para>rdfs:label : coding sequence</para>
    ///   <para>dcterms:description : a coding sequence is a sequence of nucleotides which encode a RNA or protein product..</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001276">sio:SIO_001276</a>
    /// </summary>
    let SIO_001276 = _prefixId.prefix "SIO_001276"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001277^^xsd:string</para>
    ///   <para>rdfs:label : has data item</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : has data item is a relation between a dataset and any described / referrenced entity.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001277">sio:SIO_001277</a>
    /// </summary>
    let SIO_001277 = _prefixId.prefix "SIO_001277"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001278^^xsd:string</para>
    ///   <para>rdfs:label : is data item in</para>
    ///   <para>sio:subset : core^^xsd:string</para>
    ///   <para>dcterms:description : 'is data item in' is a relation between an entity that is described or referenced in a dataset.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001278">sio:SIO_001278</a>
    /// </summary>
    let SIO_001278 = _prefixId.prefix "SIO_001278"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001279^^xsd:string</para>
    ///   <para>rdfs:label : has phenotype</para>
    ///   <para>dcterms:description : has phenotype is a relation between an object and an observable/measurable characteristic.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001279">sio:SIO_001279</a>
    /// </summary>
    let SIO_001279 = _prefixId.prefix "SIO_001279"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001280^^xsd:string</para>
    ///   <para>rdfs:label : is phenotype of</para>
    ///   <para>dcterms:description : is phenotype of is a relation between an observable/measurable characteristic and an object.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001280">sio:SIO_001280</a>
    /// </summary>
    let SIO_001280 = _prefixId.prefix "SIO_001280"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001281^^xsd:string</para>
    ///   <para>rdfs:label : humiliation</para>
    ///   <para>dcterms:description : Humiliation is the abasement of pride, which creates mortification or leads to a state of being humbled or reduced to lowliness or submission.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001281">sio:SIO_001281</a>
    /// </summary>
    let SIO_001281 = _prefixId.prefix "SIO_001281"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001282^^xsd:string</para>
    ///   <para>rdfs:label : hunger</para>
    ///   <para>dcterms:description : hunger is the craving for food.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001282">sio:SIO_001282</a>
    /// </summary>
    let SIO_001282 = _prefixId.prefix "SIO_001282"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001283^^xsd:string</para>
    ///   <para>rdfs:label : discouragement</para>
    ///   <para>sio:hasSynonym : discouraged^^xsd:string</para>
    ///   <para>dcterms:description : Discouragement is the emtion of having lost confidence or enthusiasm.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001283">sio:SIO_001283</a>
    /// </summary>
    let SIO_001283 = _prefixId.prefix "SIO_001283"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001284^^xsd:string</para>
    ///   <para>rdfs:label : satisfaction</para>
    ///   <para>sio:hasSynonym : pleasure^^xsd:stringsio:hasSynonym : contentment^^xsd:string</para>
    ///   <para>dcterms:description : satisfaction is the emotion of fulfillling one's wishes, expectations, or needs.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001284">sio:SIO_001284</a>
    /// </summary>
    let SIO_001284 = _prefixId.prefix "SIO_001284"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001285^^xsd:string</para>
    ///   <para>rdfs:label : suicidal</para>
    ///   <para>dcterms:description : suicidal is the emotion of being deeply unhappy or depressed with thoughts of killing one's self.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001285">sio:SIO_001285</a>
    /// </summary>
    let SIO_001285 = _prefixId.prefix "SIO_001285"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001286^^xsd:string</para>
    ///   <para>rdfs:label : irritability</para>
    ///   <para>sio:hasSynonym : irritable^^xsd:string</para>
    ///   <para>dcterms:description : irritability is the negative emotion of quick excitability to annoyance, impatience, or anger.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001286">sio:SIO_001286</a>
    /// </summary>
    let SIO_001286 = _prefixId.prefix "SIO_001286"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001287^^xsd:string</para>
    ///   <para>rdfs:label : indecision</para>
    ///   <para>sio:hasSynonym : indecisiveness^^xsd:string</para>
    ///   <para>dcterms:description : indecision is the emotion of being unable to choose between two or more possible courses of action.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001287">sio:SIO_001287</a>
    /// </summary>
    let SIO_001287 = _prefixId.prefix "SIO_001287"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001288^^xsd:string</para>
    ///   <para>rdfs:label : temporal qualifier</para>
    ///   <para>dcterms:description : a temporal qualifier is pertains to the frequency of the event of interest.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001288">sio:SIO_001288</a>
    /// </summary>
    let SIO_001288 = _prefixId.prefix "SIO_001288"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001289^^xsd:string</para>
    ///   <para>rdfs:label : never</para>
    ///   <para>sio:hasSynonym : none of the time^^xsd:string</para>
    ///   <para>dcterms:description : never refers to in none of the occasions.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001289">sio:SIO_001289</a>
    /// </summary>
    let SIO_001289 = _prefixId.prefix "SIO_001289"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001290^^xsd:string</para>
    ///   <para>rdfs:label : some of the time</para>
    ///   <para>sio:hasSynonym : some of the time^^xsd:string</para>
    ///   <para>dcterms:description : some refers to in the minority of occasions^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001290">sio:SIO_001290</a>
    /// </summary>
    let SIO_001290 = _prefixId.prefix "SIO_001290"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001291^^xsd:string</para>
    ///   <para>rdfs:label : most of the time</para>
    ///   <para>sio:hasSynonym : most of the time^^xsd:string</para>
    ///   <para>dcterms:description : most refers to in the majority of occasions^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001291">sio:SIO_001291</a>
    /// </summary>
    let SIO_001291 = _prefixId.prefix "SIO_001291"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001292^^xsd:string</para>
    ///   <para>rdfs:label : always</para>
    ///   <para>sio:hasSynonym : all of the time^^xsd:string</para>
    ///   <para>dcterms:description : always indicates that the event occurs at all times.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001292">sio:SIO_001292</a>
    /// </summary>
    let SIO_001292 = _prefixId.prefix "SIO_001292"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001293^^xsd:string</para>
    ///   <para>rdfs:label : quality descriptor</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001293">sio:SIO_001293</a>
    /// </summary>
    let SIO_001293 = _prefixId.prefix "SIO_001293"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001294^^xsd:string</para>
    ///   <para>rdfs:label : very poor quality</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001294">sio:SIO_001294</a>
    /// </summary>
    let SIO_001294 = _prefixId.prefix "SIO_001294"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001295^^xsd:string</para>
    ///   <para>rdfs:label : poor quality</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001295">sio:SIO_001295</a>
    /// </summary>
    let SIO_001295 = _prefixId.prefix "SIO_001295"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001296^^xsd:string</para>
    ///   <para>rdfs:label : neither good nor poor quality</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001296">sio:SIO_001296</a>
    /// </summary>
    let SIO_001296 = _prefixId.prefix "SIO_001296"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001297^^xsd:string</para>
    ///   <para>rdfs:label : good quality</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001297">sio:SIO_001297</a>
    /// </summary>
    let SIO_001297 = _prefixId.prefix "SIO_001297"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001298^^xsd:string</para>
    ///   <para>rdfs:label : very good quality</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001298">sio:SIO_001298</a>
    /// </summary>
    let SIO_001298 = _prefixId.prefix "SIO_001298"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001299^^xsd:string</para>
    ///   <para>rdfs:label : quantity modifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001299">sio:SIO_001299</a>
    /// </summary>
    let SIO_001299 = _prefixId.prefix "SIO_001299"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001300^^xsd:string</para>
    ///   <para>rdfs:label : ovopub</para>
    ///   <para>sio:subset : ovopub+^^xsd:string</para>
    ///   <para>dcterms:description : An ovopub is an information content entity that contains and links to one or more resources and/or statements, including those describing its provenance, and is itself a dereferenceable resource.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001300">sio:SIO_001300</a>
    /// </summary>
    let SIO_001300 = _prefixId.prefix "SIO_001300"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001301^^xsd:string</para>
    ///   <para>rdfs:label : collection ovopub</para>
    ///   <para>dcterms:description : A collection ovopub is an ovopub that contains and links to one or more assertion subgraphs and/or ovopubs, as well as statements describing its provenance. It is used to share a specific set of items or restrict a search to the resources contained therein.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001301">sio:SIO_001301</a>
    /// </summary>
    let SIO_001301 = _prefixId.prefix "SIO_001301"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001302^^xsd:string</para>
    ///   <para>rdfs:label : assertion ovopub</para>
    ///   <para>dcterms:description : An assertion ovopub is an ovopub that contains and links to an assertion subgraph with one or more statements that may be true or false, as well as statements describing its provenance.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001302">sio:SIO_001302</a>
    /// </summary>
    let SIO_001302 = _prefixId.prefix "SIO_001302"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001303^^xsd:string</para>
    ///   <para>rdfs:label : none quantifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001303">sio:SIO_001303</a>
    /// </summary>
    let SIO_001303 = _prefixId.prefix "SIO_001303"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001304^^xsd:string</para>
    ///   <para>rdfs:label : a little quantifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001304">sio:SIO_001304</a>
    /// </summary>
    let SIO_001304 = _prefixId.prefix "SIO_001304"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001305^^xsd:string</para>
    ///   <para>rdfs:label : moderately quantifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001305">sio:SIO_001305</a>
    /// </summary>
    let SIO_001305 = _prefixId.prefix "SIO_001305"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001306^^xsd:string</para>
    ///   <para>rdfs:label : mostly quantifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001306">sio:SIO_001306</a>
    /// </summary>
    let SIO_001306 = _prefixId.prefix "SIO_001306"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001307^^xsd:string</para>
    ///   <para>rdfs:label : completely quantifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001307">sio:SIO_001307</a>
    /// </summary>
    let SIO_001307 = _prefixId.prefix "SIO_001307"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001308^^xsd:string</para>
    ///   <para>rdfs:label : satisfaction qualifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001308">sio:SIO_001308</a>
    /// </summary>
    let SIO_001308 = _prefixId.prefix "SIO_001308"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001309^^xsd:string</para>
    ///   <para>rdfs:label : very dissatisfied qualifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001309">sio:SIO_001309</a>
    /// </summary>
    let SIO_001309 = _prefixId.prefix "SIO_001309"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001310^^xsd:string</para>
    ///   <para>rdfs:label : dissatisfied qualifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001310">sio:SIO_001310</a>
    /// </summary>
    let SIO_001310 = _prefixId.prefix "SIO_001310"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001311^^xsd:string</para>
    ///   <para>rdfs:label : neither satisfied or dissatisfied qualifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001311">sio:SIO_001311</a>
    /// </summary>
    let SIO_001311 = _prefixId.prefix "SIO_001311"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001312^^xsd:string</para>
    ///   <para>rdfs:label : satisfied qualifier</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001312">sio:SIO_001312</a>
    /// </summary>
    let SIO_001312 = _prefixId.prefix "SIO_001312"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001313^^xsd:string</para>
    ///   <para>rdfs:label : excellent quality</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001313">sio:SIO_001313</a>
    /// </summary>
    let SIO_001313 = _prefixId.prefix "SIO_001313"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001314^^xsd:string</para>
    ///   <para>rdfs:label : date of issue</para>
    ///   <para>dcterms:description : the date at which an information content entity was made public.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001314">sio:SIO_001314</a>
    /// </summary>
    let SIO_001314 = _prefixId.prefix "SIO_001314"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001315^^xsd:string</para>
    ///   <para>rdfs:label : author list</para>
    ///   <para>dcterms:description : an ordered list of authors.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001315">sio:SIO_001315</a>
    /// </summary>
    let SIO_001315 = _prefixId.prefix "SIO_001315"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001316^^xsd:string</para>
    ///   <para>rdfs:label : ordered list</para>
    ///   <para>dcterms:description : an ordered list is a list in which items are sequentially ordered.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001316">sio:SIO_001316</a>
    /// </summary>
    let SIO_001316 = _prefixId.prefix "SIO_001316"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001317^^xsd:string</para>
    ///   <para>rdfs:label : middle name</para>
    ///   <para>dcterms:description : a middle name is a name assigned to an individual that is not the first or last name.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001317">sio:SIO_001317</a>
    /// </summary>
    let SIO_001317 = _prefixId.prefix "SIO_001317"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001318^^xsd:string</para>
    ///   <para>rdfs:label : middle initial</para>
    ///   <para>dcterms:description : a middle initial is an abbreviated middle name.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001318">sio:SIO_001318</a>
    /// </summary>
    let SIO_001318 = _prefixId.prefix "SIO_001318"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001319^^xsd:string</para>
    ///   <para>rdfs:label : telephone number</para>
    ///   <para>dcterms:description : a telephone number is an identifier used to connect to a physical device capable of transfering voice or data over a network.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001319">sio:SIO_001319</a>
    /// </summary>
    let SIO_001319 = _prefixId.prefix "SIO_001319"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001320^^xsd:string</para>
    ///   <para>rdfs:label : cellular phone number</para>
    ///   <para>dcterms:description : a cellular phone number is a number to connect to a mobile device^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001320">sio:SIO_001320</a>
    /// </summary>
    let SIO_001320 = _prefixId.prefix "SIO_001320"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001321^^xsd:string</para>
    ///   <para>rdfs:label : fax number</para>
    ///   <para>dcterms:description : a fax number is a number to connect to fax device^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001321">sio:SIO_001321</a>
    /// </summary>
    let SIO_001321 = _prefixId.prefix "SIO_001321"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001322^^xsd:string</para>
    ///   <para>rdfs:label : IP number</para>
    ///   <para>sio:hasSynonym : IP address^^xsd:string</para>
    ///   <para>dcterms:description : an IP number is an number to connect to a device on the internet.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001322">sio:SIO_001322</a>
    /// </summary>
    let SIO_001322 = _prefixId.prefix "SIO_001322"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001323^^xsd:string</para>
    ///   <para>rdfs:label : email address</para>
    ///   <para>dcterms:description : an email address is an identifier to send mail to particular electronic mailbox.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001323">sio:SIO_001323</a>
    /// </summary>
    let SIO_001323 = _prefixId.prefix "SIO_001323"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001324^^xsd:string</para>
    ///   <para>rdfs:label : work phone number</para>
    ///   <para>dcterms:description : a work phone number is the number to connect to an phone at a place of work.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001324">sio:SIO_001324</a>
    /// </summary>
    let SIO_001324 = _prefixId.prefix "SIO_001324"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001325^^xsd:string</para>
    ///   <para>rdfs:label : home phone number</para>
    ///   <para>dcterms:description : a home phone number is the number to connect to an phone at a place of residence.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001325">sio:SIO_001325</a>
    /// </summary>
    let SIO_001325 = _prefixId.prefix "SIO_001325"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001326^^xsd:string</para>
    ///   <para>rdfs:label : status descriptor</para>
    ///   <para>dcterms:description : status descriptor is a descriptor for the state of a process or object.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001326">sio:SIO_001326</a>
    /// </summary>
    let SIO_001326 = _prefixId.prefix "SIO_001326"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001327^^xsd:string</para>
    ///   <para>rdfs:label : protein expression value</para>
    ///   <para>dcterms:description : A protein expression value is a quantity obtained from a protein expression experiment.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001327">sio:SIO_001327</a>
    /// </summary>
    let SIO_001327 = _prefixId.prefix "SIO_001327"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001328^^xsd:string</para>
    ///   <para>rdfs:label : copy number variation</para>
    ///   <para>sio:hasSynonym : CNV</para>
    ///   <para>dcterms:description : copy number variation refers to the number of deletions/duplications of a DNA region as compared to some reference state.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001328">sio:SIO_001328</a>
    /// </summary>
    let SIO_001328 = _prefixId.prefix "SIO_001328"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001329^^xsd:string</para>
    ///   <para>rdfs:label : single nucleotide variation</para>
    ///   <para>dcterms:description : a single nucleotide variation (SNV) is a nucleotide residue that is a variant compared to some reference nucleic acid sequence.</para>
    ///   <para>dcterms:alternative : SNV</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001329">sio:SIO_001329</a>
    /// </summary>
    let SIO_001329 = _prefixId.prefix "SIO_001329"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001330^^xsd:string</para>
    ///   <para>rdfs:label : metadata</para>
    ///   <para>dcterms:description : metadata is data that provides information about data.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001330">sio:SIO_001330</a>
    /// </summary>
    let SIO_001330 = _prefixId.prefix "SIO_001330"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001331^^xsd:string</para>
    ///   <para>rdfs:label : diagnosis</para>
    ///   <para>dcterms:description : A diagnosis is the result of a medical investigation to identify a disorder from its signs and symptoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001331">sio:SIO_001331</a>
    /// </summary>
    let SIO_001331 = _prefixId.prefix "SIO_001331"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001332^^xsd:string</para>
    ///   <para>rdfs:label : directed acyclic graph</para>
    ///   <para>dcterms:description : a directed acyclic graph or DAG is a network digram that contains directed edges in which nodes may have multiple parents, but there are no cycles.</para>
    ///   <para>dcterms:alternative : dag</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001332">sio:SIO_001332</a>
    /// </summary>
    let SIO_001332 = _prefixId.prefix "SIO_001332"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001333^^xsd:string</para>
    ///   <para>rdfs:label : arc</para>
    ///   <para>dcterms:description : an arc is a closed segment of a differentiable curve.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001333">sio:SIO_001333</a>
    /// </summary>
    let SIO_001333 = _prefixId.prefix "SIO_001333"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001334^^xsd:string</para>
    ///   <para>rdfs:label : edge</para>
    ///   <para>dcterms:description : an edge is a line connecting two graph vertices.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001334">sio:SIO_001334</a>
    /// </summary>
    let SIO_001334 = _prefixId.prefix "SIO_001334"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001335^^xsd:string</para>
    ///   <para>rdfs:label : node</para>
    ///   <para>sio:hasSynonym : vertex</para>
    ///   <para>dcterms:description : a node or vertex is a point in a graph.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001335">sio:SIO_001335</a>
    /// </summary>
    let SIO_001335 = _prefixId.prefix "SIO_001335"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001336^^xsd:string</para>
    ///   <para>rdfs:label : epimer</para>
    ///   <para>dcterms:description : An epimer is a stereoisomer that differs in configuration at only one stereogenic center.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001336">sio:SIO_001336</a>
    /// </summary>
    let SIO_001336 = _prefixId.prefix "SIO_001336"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001337^^xsd:string</para>
    ///   <para>rdfs:label : epimer association</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001337">sio:SIO_001337</a>
    /// </summary>
    let SIO_001337 = _prefixId.prefix "SIO_001337"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001338^^xsd:string</para>
    ///   <para>rdfs:label : mereological quality</para>
    ///   <para>dcterms:description : a mereological quality is a quality of an entity vis-a-vis containment or parthood</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001338">sio:SIO_001338</a>
    /// </summary>
    let SIO_001338 = _prefixId.prefix "SIO_001338"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001339^^xsd:string</para>
    ///   <para>rdfs:label : empty</para>
    ///   <para>dcterms:description : empty is the quality of not containing some thing</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001339">sio:SIO_001339</a>
    /// </summary>
    let SIO_001339 = _prefixId.prefix "SIO_001339"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001340^^xsd:string</para>
    ///   <para>rdfs:label : full</para>
    ///   <para>dcterms:description : full is the quality of contain an entity such that there is no more space for any additional entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001340">sio:SIO_001340</a>
    /// </summary>
    let SIO_001340 = _prefixId.prefix "SIO_001340"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001341^^xsd:string</para>
    ///   <para>rdfs:label : containment quality</para>
    ///   <para>dcterms:description : a containment quality is a quality of being able to contain another entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001341">sio:SIO_001341</a>
    /// </summary>
    let SIO_001341 = _prefixId.prefix "SIO_001341"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001342^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with modifying mutation</para>
    ///   <para>dcterms:description : A gene-disease association in which a gene mutation is known to modify the clinical presentation of the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001342">sio:SIO_001342</a>
    /// </summary>
    let SIO_001342 = _prefixId.prefix "SIO_001342"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001343^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with susceptibility mutation</para>
    ///   <para>dcterms:description : A gene-disease association in which a germline mutation in the gene predisposes to the development of the disease, and it is necessary but not sufficient for the manifestation of the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001343">sio:SIO_001343</a>
    /// </summary>
    let SIO_001343 = _prefixId.prefix "SIO_001343"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001344^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with germline causal mutation</para>
    ///   <para>dcterms:description : A gene-variant disease association in which a germline mutation in the gene/protein results in the development or maintenance of the disease, and it may be passed on to offspring.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001344">sio:SIO_001344</a>
    /// </summary>
    let SIO_001344 = _prefixId.prefix "SIO_001344"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001345^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with somatic causal mutation</para>
    ///   <para>dcterms:description : A gene-variant disease association in which a somatic mutation in the gene/protein results in the development or maintenance of the disease, and it may not be passed on to offspring.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001345">sio:SIO_001345</a>
    /// </summary>
    let SIO_001345 = _prefixId.prefix "SIO_001345"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001346^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with somatic modifying mutation</para>
    ///   <para>dcterms:description : A gene-variant disease association in which a somatic mutation in the gene modifies the clinical presentation of the disease, and it may not be passed on to offspring.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001346">sio:SIO_001346</a>
    /// </summary>
    let SIO_001346 = _prefixId.prefix "SIO_001346"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001347^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with germline modifying mutation</para>
    ///   <para>dcterms:description : A gene-variant disease association in which a germline mutation in the gene modifies the clinical presentation of the disease, and it may be passed on to offspring.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001347">sio:SIO_001347</a>
    /// </summary>
    let SIO_001347 = _prefixId.prefix "SIO_001347"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001348^^xsd:string</para>
    ///   <para>rdfs:label : fusion gene-disease association</para>
    ///   <para>dcterms:description : A gene-disease association in which the fusion between two different genes (promotor and/or other coding DNA regions) is associated with the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001348">sio:SIO_001348</a>
    /// </summary>
    let SIO_001348 = _prefixId.prefix "SIO_001348"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001349^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with chromosomal rearrangement</para>
    ///   <para>dcterms:description : A gene-disease association in which the gene is included in a chromosomal rearrangement associated with a particular manifestation of the disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001349">sio:SIO_001349</a>
    /// </summary>
    let SIO_001349 = _prefixId.prefix "SIO_001349"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001350^^xsd:string</para>
    ///   <para>rdfs:label : gene-disease association linked with genomic alterations</para>
    ///   <para>dcterms:description : a gene-disease association that is linked with some genomic alteration</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001350">sio:SIO_001350</a>
    /// </summary>
    let SIO_001350 = _prefixId.prefix "SIO_001350"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001351^^xsd:string</para>
    ///   <para>rdfs:label : DisGeNET disease specificity</para>
    ///   <para>dcterms:description : DisGeNET Disease specificity is a measure of disease coverage. It is calculated from the negative base 2 log of the ratio of number of diseases associated to the total number of diseases.
    ///
    /// The measure is described here: http://www.disgenet.org/web/DisGeNET/menu/dbinfo#specificity</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001351">sio:SIO_001351</a>
    /// </summary>
    let SIO_001351 = _prefixId.prefix "SIO_001351"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001352^^xsd:string</para>
    ///   <para>rdfs:label : DisGeNET Pleiotropy Index</para>
    ///   <para>dcterms:description : The DisGeNET pleiotropy index is a measure of specificity as it pertains to classes of disease. The disease pleotropy index is computed from the ratio of the number of disease classes associated with an entity over the total number of disease classes multplied by 100.
    ///
    /// The measure is defined here: http://www.disgenet.org/web/DisGeNET/menu/dbinfo#pleiotropy</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001352">sio:SIO_001352</a>
    /// </summary>
    let SIO_001352 = _prefixId.prefix "SIO_001352"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001353^^xsd:string</para>
    ///   <para>rdfs:label : specialized object</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001353">sio:SIO_001353</a>
    /// </summary>
    let SIO_001353 = _prefixId.prefix "SIO_001353"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001354^^xsd:string</para>
    ///   <para>rdfs:label : week</para>
    ///   <para>dcterms:description : A week is a period of 7 consecutive days.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001354">sio:SIO_001354</a>
    /// </summary>
    let SIO_001354 = _prefixId.prefix "SIO_001354"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001355^^xsd:string</para>
    ///   <para>rdfs:label : specific gravity</para>
    ///   <para>dcterms:description : Specific gravity is the ratio of the density of a substance to the density of a reference substance; equivalently, it is the ratio of the mass of a substance to the mass of a reference substance for the same given volume.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001355">sio:SIO_001355</a>
    /// </summary>
    let SIO_001355 = _prefixId.prefix "SIO_001355"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001356^^xsd:string</para>
    ///   <para>rdfs:label : information encoding</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001356">sio:SIO_001356</a>
    /// </summary>
    let SIO_001356 = _prefixId.prefix "SIO_001356"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001357^^xsd:string</para>
    ///   <para>rdfs:label : speech</para>
    ///   <para>dcterms:description : speech is the expression of thoughts and feelings by sound.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001357">sio:SIO_001357</a>
    /// </summary>
    let SIO_001357 = _prefixId.prefix "SIO_001357"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001358^^xsd:string</para>
    ///   <para>rdfs:label : to retrieve</para>
    ///   <para>dcterms:description : the capability to retrieve a (digitial/physical/mental) object from a location.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001358">sio:SIO_001358</a>
    /// </summary>
    let SIO_001358 = _prefixId.prefix "SIO_001358"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001359^^xsd:string</para>
    ///   <para>rdfs:label : information translation</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001359">sio:SIO_001359</a>
    /// </summary>
    let SIO_001359 = _prefixId.prefix "SIO_001359"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001360^^xsd:string</para>
    ///   <para>rdfs:label : information decoding</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001360">sio:SIO_001360</a>
    /// </summary>
    let SIO_001360 = _prefixId.prefix "SIO_001360"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001361^^xsd:string</para>
    ///   <para>rdfs:label : to store</para>
    ///   <para>dcterms:description : to store is the capability to place an object into a medium in which it can be retrieved in the future.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001361">sio:SIO_001361</a>
    /// </summary>
    let SIO_001361 = _prefixId.prefix "SIO_001361"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001362^^xsd:string</para>
    ///   <para>rdfs:label : to encode information</para>
    ///   <para>dcterms:description : the capability to encode information in a different representation^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001362">sio:SIO_001362</a>
    /// </summary>
    let SIO_001362 = _prefixId.prefix "SIO_001362"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001363^^xsd:string</para>
    ///   <para>rdfs:label : to maintain information</para>
    ///   <para>dcterms:description : the capability to maintain information such that it can be retrieved in the future.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001363">sio:SIO_001363</a>
    /// </summary>
    let SIO_001363 = _prefixId.prefix "SIO_001363"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001364^^xsd:string</para>
    ///   <para>rdfs:label : to decode information</para>
    ///   <para>dcterms:description : the ability to reverse an encoding operation^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001364">sio:SIO_001364</a>
    /// </summary>
    let SIO_001364 = _prefixId.prefix "SIO_001364"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001365^^xsd:string</para>
    ///   <para>rdfs:label : rate of change</para>
    ///   <para>dcterms:description : The amount of change accumulated per unit time.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001365">sio:SIO_001365</a>
    /// </summary>
    let SIO_001365 = _prefixId.prefix "SIO_001365"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001366^^xsd:string</para>
    ///   <para>rdfs:label : information maintenance</para>
    ///   <para>dcterms:description : the regulation or maintenance of information</para>
    ///   <para>dc11:alternativeName : regulation of information^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001366">sio:SIO_001366</a>
    /// </summary>
    let SIO_001366 = _prefixId.prefix "SIO_001366"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001367^^xsd:string</para>
    ///   <para>rdfs:label : frequency</para>
    ///   <para>dcterms:description : Frequency is the number of occurrences of a repeating event per unit time</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001367">sio:SIO_001367</a>
    /// </summary>
    let SIO_001367 = _prefixId.prefix "SIO_001367"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001368^^xsd:string</para>
    ///   <para>rdfs:label : speed</para>
    ///   <para>dcterms:description : Speed is the rate of change of an object's position.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001368">sio:SIO_001368</a>
    /// </summary>
    let SIO_001368 = _prefixId.prefix "SIO_001368"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001369^^xsd:string</para>
    ///   <para>rdfs:label : velocity</para>
    ///   <para>dcterms:description : The rate of change of an object's position and the direction of that change</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001369">sio:SIO_001369</a>
    /// </summary>
    let SIO_001369 = _prefixId.prefix "SIO_001369"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001370^^xsd:string</para>
    ///   <para>rdfs:label : slide</para>
    ///   <para>dcterms:description : A slide is an visual representation meant to communicate some information.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001370">sio:SIO_001370</a>
    /// </summary>
    let SIO_001370 = _prefixId.prefix "SIO_001370"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001371^^xsd:string</para>
    ///   <para>rdfs:label : statute</para>
    ///   <para>dcterms:description : A statute is a formal written enactment of a legislative authority that governs a state, city or country.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001371">sio:SIO_001371</a>
    /// </summary>
    let SIO_001371 = _prefixId.prefix "SIO_001371"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001372^^xsd:string</para>
    ///   <para>rdfs:label : legislation</para>
    ///   <para>dcterms:description : A legal document proposing or enacting a law or a group of laws.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001372">sio:SIO_001372</a>
    /// </summary>
    let SIO_001372 = _prefixId.prefix "SIO_001372"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001373^^xsd:string</para>
    ///   <para>rdfs:label : legal document</para>
    ///   <para>dcterms:description : A legal document is a formally executed written document that can be formally attributed to its author, records and formally expresses a legally enforceable act, process, or contractual duty, obligation, or right, and therefore evidences that act, process, or agreement.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001373">sio:SIO_001373</a>
    /// </summary>
    let SIO_001373 = _prefixId.prefix "SIO_001373"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001374^^xsd:string</para>
    ///   <para>rdfs:label : brief</para>
    ///   <para>dcterms:description : A brief is a written legal document used in various legal adversarial systems that is presented to a court arguing why one party to a particular case should prevail.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001374">sio:SIO_001374</a>
    /// </summary>
    let SIO_001374 = _prefixId.prefix "SIO_001374"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001375^^xsd:string</para>
    ///   <para>rdfs:label : book section</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001375">sio:SIO_001375</a>
    /// </summary>
    let SIO_001375 = _prefixId.prefix "SIO_001375"
    /// <summary>
    ///   <para>dc11:identifier : SIO_001376^^xsd:string</para>
    ///   <para>rdfs:label : bill</para>
    ///   <para>dcterms:description : A bill is proposed legislation under consideration by a legislature.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_001376">sio:SIO_001376</a>
    /// </summary>
    let SIO_001376 = _prefixId.prefix "SIO_001376"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010000^^xsd:string</para>
    ///   <para>rdfs:label : organism</para>
    ///   <para>dcterms:description : A biological organisn is a biological entity that consists of one or more cells and is capable of genomic replication (independently or not).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010000">sio:SIO_010000</a>
    /// </summary>
    let SIO_010000 = _prefixId.prefix "SIO_010000"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010001^^xsd:string</para>
    ///   <para>rdfs:label : cell</para>
    ///   <para>dcterms:description : A cell is a biological entity that is contained by a plasma membrane.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010001">sio:SIO_010001</a>
    /// </summary>
    let SIO_010001 = _prefixId.prefix "SIO_010001"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010002^^xsd:string</para>
    ///   <para>rdfs:label : tissue</para>
    ///   <para>dcterms:description : A tissue is a mereologically maximal collection of cells that together perform some function.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010002">sio:SIO_010002</a>
    /// </summary>
    let SIO_010002 = _prefixId.prefix "SIO_010002"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010003^^xsd:string</para>
    ///   <para>rdfs:label : organ</para>
    ///   <para>dcterms:description : An organ is a collection of tissues joined in structural unit to serve a common function.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010003">sio:SIO_010003</a>
    /// </summary>
    let SIO_010003 = _prefixId.prefix "SIO_010003"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010004^^xsd:string</para>
    ///   <para>rdfs:label : chemical entity</para>
    ///   <para>sio:subset : chemical+^^xsd:string</para>
    ///   <para>sio:example : atom, ion, molecule, chemical substance,</para>
    ///   <para>sio:equivalentTo : CHEBI:23367^^xsd:string</para>
    ///   <para>dcterms:description : A chemical entity is a material entity that pertains to chemistry.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010004">sio:SIO_010004</a>
    /// </summary>
    let SIO_010004 = _prefixId.prefix "SIO_010004"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010005^^xsd:string</para>
    ///   <para>rdfs:label : weak submolecular component</para>
    ///   <para>dcterms:description : A weak submolecular component is a submolecular component that weakly connects submolecular components.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010005">sio:SIO_010005</a>
    /// </summary>
    let SIO_010005 = _prefixId.prefix "SIO_010005"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010007^^xsd:string</para>
    ///   <para>rdfs:label : polypeptide</para>
    ///   <para>dcterms:description : A polypeptide is an organic polymer composed of amino acid residues.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010007">sio:SIO_010007</a>
    /// </summary>
    let SIO_010007 = _prefixId.prefix "SIO_010007"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010008^^xsd:string</para>
    ///   <para>rdfs:label : nucleic acid</para>
    ///   <para>dcterms:description : A nucleic acid is an organic polymer composed of a sequence of nucleotide residues.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010008">sio:SIO_010008</a>
    /// </summary>
    let SIO_010008 = _prefixId.prefix "SIO_010008"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010009^^xsd:string</para>
    ///   <para>rdfs:label : ribonucleic acid</para>
    ///   <para>dcterms:description : A ribonucleic acid is an organic polymer composed of a sequence of ribonucleotide residues.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010009">sio:SIO_010009</a>
    /// </summary>
    let SIO_010009 = _prefixId.prefix "SIO_010009"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010010^^xsd:string</para>
    ///   <para>rdfs:label : deoxyribonucleic acid</para>
    ///   <para>dcterms:description : A deoxyribonucleic acid is an organic polymer composed of a sequence of deoxyribonucleotide residues.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010010">sio:SIO_010010</a>
    /// </summary>
    let SIO_010010 = _prefixId.prefix "SIO_010010"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010011^^xsd:string</para>
    ///   <para>rdfs:label : lipid</para>
    ///   <para>dcterms:description : A lipid is a water-insoluable organic molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010011">sio:SIO_010011</a>
    /// </summary>
    let SIO_010011 = _prefixId.prefix "SIO_010011"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010013^^xsd:string</para>
    ///   <para>rdfs:label : chemical interaction</para>
    ///   <para>sio:equivalentTo : biopax:Interaction^^xsd:string</para>
    ///   <para>dcterms:description : A chemical interaction is a biochemical process in which chemical entities interact through some set of attractive forces.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010013">sio:SIO_010013</a>
    /// </summary>
    let SIO_010013 = _prefixId.prefix "SIO_010013"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010014^^xsd:string</para>
    ///   <para>rdfs:label : primary structure descriptor</para>
    ///   <para>dcterms:description : A primary structure descriptor describes a biomolecular object in terms of a 1D or 2D topology.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010014">sio:SIO_010014</a>
    /// </summary>
    let SIO_010014 = _prefixId.prefix "SIO_010014"
    /// <summary>
    ///   <para>dcterms:description : A protein acid sequence is the character representation of the molecular structure of a protein.</para>
    ///   <para>sio:hasSynonym : polypeptide sequencesio:hasSynonym : amino acid sequence</para>
    ///   <para>dc11:identifier : SIO_010015^^xsd:string</para>
    ///   <para>rdfs:label : protein sequence</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010015">sio:SIO_010015</a>
    /// </summary>
    let SIO_010015 = _prefixId.prefix "SIO_010015"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010016^^xsd:string</para>
    ///   <para>rdfs:label : nucleic acid sequence</para>
    ///   <para>dcterms:description : A nucleic acid sequence is a symbolic representation of the sequence of nucleic acid residues in a nucleic acid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010016">sio:SIO_010016</a>
    /// </summary>
    let SIO_010016 = _prefixId.prefix "SIO_010016"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010017^^xsd:string</para>
    ///   <para>rdfs:label : ribonucleic acid sequence</para>
    ///   <para>sio:hasSynonym : RNA sequence</para>
    ///   <para>dcterms:description : A ribonucleic acid sequence is a symbolic representation of the sequence of ribonucleic acid residues in a ribonucleic acid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010017">sio:SIO_010017</a>
    /// </summary>
    let SIO_010017 = _prefixId.prefix "SIO_010017"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010018^^xsd:string</para>
    ///   <para>rdfs:label : deoxyribonucleic acid sequence</para>
    ///   <para>sio:hasSynonym : DNA sequence</para>
    ///   <para>dcterms:description : A deoxyribonucleic acid sequence is a symbolic representation of the sequence of deoxyribonucleic acid residues in a deoxyribonucleic acid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010018">sio:SIO_010018</a>
    /// </summary>
    let SIO_010018 = _prefixId.prefix "SIO_010018"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010019^^xsd:string</para>
    ///   <para>rdfs:label : biological data</para>
    ///   <para>dcterms:description : biological data is scientific data relevant to biology.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010019">sio:SIO_010019</a>
    /// </summary>
    let SIO_010019 = _prefixId.prefix "SIO_010019"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010020^^xsd:string</para>
    ///   <para>rdfs:label : submolecular entity</para>
    ///   <para>dcterms:description : A submolecular entity is a part of a molecular entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010020">sio:SIO_010020</a>
    /// </summary>
    let SIO_010020 = _prefixId.prefix "SIO_010020"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010022^^xsd:string</para>
    ///   <para>rdfs:label : secondary structure descriptor</para>
    ///   <para>dcterms:description : A secondary structure descriptor describes local topological patterns in  a biopolymer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010022">sio:SIO_010022</a>
    /// </summary>
    let SIO_010022 = _prefixId.prefix "SIO_010022"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010023^^xsd:string</para>
    ///   <para>rdfs:label : tertiary structure descriptor</para>
    ///   <para>dcterms:description : A tertiary structure descriptor describes 3D topological patterns in a biopolymer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010023">sio:SIO_010023</a>
    /// </summary>
    let SIO_010023 = _prefixId.prefix "SIO_010023"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010024^^xsd:string</para>
    ///   <para>rdfs:label : quaternary structure</para>
    ///   <para>dcterms:description : A quaternary structure descriptor describes topological patterns in a multi-unit biopolymer complex.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010024">sio:SIO_010024</a>
    /// </summary>
    let SIO_010024 = _prefixId.prefix "SIO_010024"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010025^^xsd:string</para>
    ///   <para>rdfs:label : oligosaccharide</para>
    ///   <para>dcterms:description : An oligosaccharide is an organic polymer composed of monosaccharides joined by glycosidic bonds.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010025">sio:SIO_010025</a>
    /// </summary>
    let SIO_010025 = _prefixId.prefix "SIO_010025"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010026^^xsd:string</para>
    ///   <para>rdfs:label : genetic polymorphism</para>
    ///   <para>dcterms:description : genetic polymorphism is the description of a difference in genetic composition at some location.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010026">sio:SIO_010026</a>
    /// </summary>
    let SIO_010026 = _prefixId.prefix "SIO_010026"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010027^^xsd:string</para>
    ///   <para>rdfs:label : snp</para>
    ///   <para>dcterms:description : single nucleotide polymorphism (SNP) is a variation in a single base in the genetic composition between different individuals of the same species.</para>
    ///   <para>dcterms:alternative : single nucleotide polymorphism</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010027">sio:SIO_010027</a>
    /// </summary>
    let SIO_010027 = _prefixId.prefix "SIO_010027"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010028^^xsd:string</para>
    ///   <para>rdfs:label : genetic data</para>
    ///   <para>dcterms:description : genetic data is data pertaining to genetics.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010028">sio:SIO_010028</a>
    /// </summary>
    let SIO_010028 = _prefixId.prefix "SIO_010028"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010029^^xsd:string</para>
    ///   <para>rdfs:label : biological sex</para>
    ///   <para>dcterms:description : biological sex is the quality of a biological organism based on reproductive function or organs.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010029">sio:SIO_010029</a>
    /// </summary>
    let SIO_010029 = _prefixId.prefix "SIO_010029"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010030^^xsd:string</para>
    ///   <para>rdfs:label : monosaccharide</para>
    ///   <para>dcterms:description : A monosaccharide is an organic polymer that consists of a single polyhydroxy aldehyde or ketone group.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010030">sio:SIO_010030</a>
    /// </summary>
    let SIO_010030 = _prefixId.prefix "SIO_010030"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010031^^xsd:string</para>
    ///   <para>rdfs:label : PDB chain identifier</para>
    ///   <para>dcterms:description : A PDB chain identifier is a alphabetical label to identify a molecule in a structure provided by the Protein DataBank .</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010031">sio:SIO_010031</a>
    /// </summary>
    let SIO_010031 = _prefixId.prefix "SIO_010031"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010032^^xsd:string</para>
    ///   <para>rdfs:label : PDB record identifier</para>
    ///   <para>dcterms:description : A PDB record identifier is an identifier for a PDB generated record.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010032">sio:SIO_010032</a>
    /// </summary>
    let SIO_010032 = _prefixId.prefix "SIO_010032"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010033^^xsd:string</para>
    ///   <para>rdfs:label : hydrogen bond</para>
    ///   <para>dcterms:description : A hydrogen bond is a weak submolecular interaction formed between a hydrogen atom and a electronegative atom.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010033">sio:SIO_010033</a>
    /// </summary>
    let SIO_010033 = _prefixId.prefix "SIO_010033"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010034^^xsd:string</para>
    ///   <para>rdfs:label : cation pi interaction</para>
    ///   <para>dcterms:description : A cation pi interaction is an ionic interaction between the localized negative charge of π orbital electrons, located above and below the plane of an aromatic ring, and a positive charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010034">sio:SIO_010034</a>
    /// </summary>
    let SIO_010034 = _prefixId.prefix "SIO_010034"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010035^^xsd:string</para>
    ///   <para>rdfs:label : gene</para>
    ///   <para>sio:equivalentTo : http://purl.obolibrary.org/obo/SO_0000704^^xsd:anyURIsio:equivalentTo : biopax:Gene^^xsd:string</para>
    ///   <para>dcterms:description : A gene is part of a nucleic acid that contains all the necessary elements to encode a functional transcript.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010035">sio:SIO_010035</a>
    /// </summary>
    let SIO_010035 = _prefixId.prefix "SIO_010035"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010036^^xsd:string</para>
    ///   <para>rdfs:label : biochemical reaction</para>
    ///   <para>sio:equivalentTo : biopax:Conversion^^xsd:stringsio:equivalentTo : biopax:BiochemicalReaction^^xsd:string</para>
    ///   <para>dcterms:description : A biochemical reaction is a biochemical process that involves the conversion of at least one chemical participant (target) into another (product) by an enzyme (agent).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010036">sio:SIO_010036</a>
    /// </summary>
    let SIO_010036 = _prefixId.prefix "SIO_010036"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010037^^xsd:string</para>
    ///   <para>rdfs:label : chemical element</para>
    ///   <para>dcterms:description : A chemical element is a (effectively) homogeneous substance composed of one type of atom.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010037">sio:SIO_010037</a>
    /// </summary>
    let SIO_010037 = _prefixId.prefix "SIO_010037"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010038^^xsd:string</para>
    ///   <para>rdfs:label : drug</para>
    ///   <para>dcterms:description : A drug is a chemical entity that regulates a biological process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010038">sio:SIO_010038</a>
    /// </summary>
    let SIO_010038 = _prefixId.prefix "SIO_010038"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010039^^xsd:string</para>
    ///   <para>rdfs:label : pharmaceutical preparation</para>
    ///   <para>sio:hasSynonym : drug^^xsd:string</para>
    ///   <para>dcterms:description : A pharmaceutical preparation is a chemical substance approved for use in the medical diagnosis, cure, treatment, or prevention of disease.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010039">sio:SIO_010039</a>
    /// </summary>
    let SIO_010039 = _prefixId.prefix "SIO_010039"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010040^^xsd:string</para>
    ///   <para>rdfs:label : binding site</para>
    ///   <para>dcterms:description : A binding site is a molecular site which when occupied with particular ligands leads to structural transformations that initiatiate new moelcular processes. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_010040">sio:SIO_010040</a>
    /// </summary>
    let SIO_010040 = _prefixId.prefix "SIO_010040"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010041^^xsd:string</para>
    ///   <para>rdfs:label : active site</para>
    ///   <para>dcterms:description : An active site is a molecular site in which a chemical event occurs (structural transformation or conformational change).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010041">sio:SIO_010041</a>
    /// </summary>
    let SIO_010041 = _prefixId.prefix "SIO_010041"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010042^^xsd:string</para>
    ///   <para>rdfs:label : haplotype</para>
    ///   <para>dcterms:description : A haplotype is one of a set of genomic sequence variants.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010042">sio:SIO_010042</a>
    /// </summary>
    let SIO_010042 = _prefixId.prefix "SIO_010042"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010043^^xsd:string</para>
    ///   <para>rdfs:label : protein</para>
    ///   <para>sio:equivalentTo : CHEBI:36080^^xsd:string</para>
    ///   <para>dcterms:description : A protein is an organic polymer that is composed of one or more linear polymers of amino acids.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010043">sio:SIO_010043</a>
    /// </summary>
    let SIO_010043 = _prefixId.prefix "SIO_010043"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010044^^xsd:string</para>
    ///   <para>rdfs:label : atom</para>
    ///   <para>dcterms:description : An atom is composed of a core of protons and/or neutrons which may be surrounded by a cloud of electrons.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010044">sio:SIO_010044</a>
    /// </summary>
    let SIO_010044 = _prefixId.prefix "SIO_010044"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010045^^xsd:string</para>
    ///   <para>rdfs:label : base pair</para>
    ///   <para>dcterms:description : A base pair is a weak molecular interaction composed of hydrogen bonds between nucleobases.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010045">sio:SIO_010045</a>
    /// </summary>
    let SIO_010045 = _prefixId.prefix "SIO_010045"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010046^^xsd:string</para>
    ///   <para>rdfs:label : biological entity</para>
    ///   <para>sio:subset : chemical-^^xsd:string</para>
    ///   <para>dcterms:description : A biological entity is a heterogeneous substance that contains genomic material or is the product of a biological process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010046">sio:SIO_010046</a>
    /// </summary>
    let SIO_010046 = _prefixId.prefix "SIO_010046"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010047^^xsd:string</para>
    ///   <para>rdfs:label : strong submolecular component</para>
    ///   <para>dcterms:description : A strong submolecular component is a submolecular component that strongly connects submolecular components.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010047">sio:SIO_010047</a>
    /// </summary>
    let SIO_010047 = _prefixId.prefix "SIO_010047"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010048^^xsd:string</para>
    ///   <para>rdfs:label : male</para>
    ///   <para>sio:equivalentTo : PATO:0000384^^xsd:string</para>
    ///   <para>dcterms:description : male is a biological sex of an individual with male sexual organs.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010048">sio:SIO_010048</a>
    /// </summary>
    let SIO_010048 = _prefixId.prefix "SIO_010048"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010049^^xsd:string</para>
    ///   <para>rdfs:label : molecular site</para>
    ///   <para>dcterms:description : A moleclar site is a spatial region bounded (in part or in whole) by a molecule and may be occupied by other material entities (e.g. drugs).^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010049">sio:SIO_010049</a>
    /// </summary>
    let SIO_010049 = _prefixId.prefix "SIO_010049"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010050^^xsd:string</para>
    ///   <para>rdfs:label : allosteric site</para>
    ///   <para>dcterms:description : An allosteric site is a binding site that when bound to particular ligand changes the conformational state and affects its functionality.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010050">sio:SIO_010050</a>
    /// </summary>
    let SIO_010050 = _prefixId.prefix "SIO_010050"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010051^^xsd:string</para>
    ///   <para>rdfs:label : biological fluid</para>
    ///   <para>dcterms:description : A biological fluid is a fluid of biological origin.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010051">sio:SIO_010051</a>
    /// </summary>
    let SIO_010051 = _prefixId.prefix "SIO_010051"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010052^^xsd:string</para>
    ///   <para>rdfs:label : female</para>
    ///   <para>dcterms:description : female is a biological sex of an individual with female sexual organs.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010052">sio:SIO_010052</a>
    /// </summary>
    let SIO_010052 = _prefixId.prefix "SIO_010052"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010053^^xsd:string</para>
    ///   <para>rdfs:label : evolutionary lineage</para>
    ///   <para>dcterms:description : evolutionary lineage is a sequence of species, that form a line of descent, each new species the direct result of speciation from an immediate ancestral species.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010053">sio:SIO_010053</a>
    /// </summary>
    let SIO_010053 = _prefixId.prefix "SIO_010053"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010054^^xsd:string</para>
    ///   <para>rdfs:label : cell line</para>
    ///   <para>dcterms:description : A cell line is a collection of genetically identifical cells.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010054">sio:SIO_010054</a>
    /// </summary>
    let SIO_010054 = _prefixId.prefix "SIO_010054"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010055^^xsd:string</para>
    ///   <para>rdfs:label : strain</para>
    ///   <para>dcterms:description : A strain is a genetic variant or kind of microorganism.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010055">sio:SIO_010055</a>
    /// </summary>
    let SIO_010055 = _prefixId.prefix "SIO_010055"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010056^^xsd:string</para>
    ///   <para>rdfs:label : phenotype</para>
    ///   <para>dcterms:description : A phenotype is an observable characteristic of an individual.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010056">sio:SIO_010056</a>
    /// </summary>
    let SIO_010056 = _prefixId.prefix "SIO_010056"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010057^^xsd:string</para>
    ///   <para>rdfs:label : life status</para>
    ///   <para>dcterms:description : life status is the quality of whether something is alive or dead.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010057">sio:SIO_010057</a>
    /// </summary>
    let SIO_010057 = _prefixId.prefix "SIO_010057"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010058^^xsd:string</para>
    ///   <para>rdfs:label : alive</para>
    ///   <para>dcterms:description : alive is the state of a biological organism that exhibits biological functions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010058">sio:SIO_010058</a>
    /// </summary>
    let SIO_010058 = _prefixId.prefix "SIO_010058"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010059^^xsd:string</para>
    ///   <para>rdfs:label : dead</para>
    ///   <para>dcterms:description : dead is the quality of an object in which there is a cessation of all biological functions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010059">sio:SIO_010059</a>
    /// </summary>
    let SIO_010059 = _prefixId.prefix "SIO_010059"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010060^^xsd:string</para>
    ///   <para>rdfs:label : family history</para>
    ///   <para>dcterms:description : family history is the systematic narrative and research of past events relating to a specific family, or specific families.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010060">sio:SIO_010060</a>
    /// </summary>
    let SIO_010060 = _prefixId.prefix "SIO_010060"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010061^^xsd:string</para>
    ///   <para>rdfs:label : generation number</para>
    ///   <para>dcterms:description : generation number is a count of the number of biological reproduction events elapsed from some starting reference point.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010061">sio:SIO_010061</a>
    /// </summary>
    let SIO_010061 = _prefixId.prefix "SIO_010061"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010064^^xsd:string</para>
    ///   <para>rdfs:label : 5' untranslated region</para>
    ///   <para>dcterms:description : The five prime untranslated region (5' UTR) is a section of messenger RNA (mRNA) and the DNA that codes for it that starts at the +1 position (where transcription begins) and ends one nucleotide before the start codon (usually AUG) of the coding region.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010064">sio:SIO_010064</a>
    /// </summary>
    let SIO_010064 = _prefixId.prefix "SIO_010064"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010065^^xsd:string</para>
    ///   <para>rdfs:label : bioinformatic data</para>
    ///   <para>dcterms:description : bioinformatic data is data genereated or used for computer-based investigations of biological phenomena.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010065">sio:SIO_010065</a>
    /// </summary>
    let SIO_010065 = _prefixId.prefix "SIO_010065"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010066^^xsd:string</para>
    ///   <para>rdfs:label : sequence alignment</para>
    ///   <para>dcterms:description : A sequence alignment is the character-based alignment of sequences using some method.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010066">sio:SIO_010066</a>
    /// </summary>
    let SIO_010066 = _prefixId.prefix "SIO_010066"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010067^^xsd:string</para>
    ///   <para>rdfs:label : multiple sequence alignment</para>
    ///   <para>dcterms:description : A multiple sequence alignment is a sequence alignment involving more than two sequences.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010067">sio:SIO_010067</a>
    /// </summary>
    let SIO_010067 = _prefixId.prefix "SIO_010067"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010068^^xsd:string</para>
    ///   <para>rdfs:label : pairwise sequence alignment</para>
    ///   <para>dcterms:description : A pairwise sequence alignment is the alignment of exactly 2 sequences.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010068">sio:SIO_010068</a>
    /// </summary>
    let SIO_010068 = _prefixId.prefix "SIO_010068"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010070^^xsd:string</para>
    ///   <para>rdfs:label : 3' untranslated region</para>
    ///   <para>dcterms:description : A three prime untranslated region (3'-UTR) is the section of messenger RNA (mRNA) that immediately follows the translation termination codon. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_010070">sio:SIO_010070</a>
    /// </summary>
    let SIO_010070 = _prefixId.prefix "SIO_010070"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010071^^xsd:string</para>
    ///   <para>rdfs:label : organic submolecule</para>
    ///   <para>dcterms:description : An organic submolecule is connected region of a molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010071">sio:SIO_010071</a>
    /// </summary>
    let SIO_010071 = _prefixId.prefix "SIO_010071"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010072^^xsd:string</para>
    ///   <para>rdfs:label : organic molecule</para>
    ///   <para>dcterms:description : An organic molecular entity is a chemical entity composed of organic atoms (at least carbon, hydrogen, and optionally oxygen, phosphorus, nitrogen)</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010072">sio:SIO_010072</a>
    /// </summary>
    let SIO_010072 = _prefixId.prefix "SIO_010072"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010073^^xsd:string</para>
    ///   <para>rdfs:label : open reading frame</para>
    ///   <para>dcterms:description : An open reading frame (ORF) is a part of a gene that encodes a protein but does not contain a stop codon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010073">sio:SIO_010073</a>
    /// </summary>
    let SIO_010073 = _prefixId.prefix "SIO_010073"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010074^^xsd:string</para>
    ///   <para>rdfs:label : amino acid residue</para>
    ///   <para>dcterms:description : An amino acid residue is a part of a molecule that is derived from an amino acid molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010074">sio:SIO_010074</a>
    /// </summary>
    let SIO_010074 = _prefixId.prefix "SIO_010074"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010075^^xsd:string</para>
    ///   <para>rdfs:label : nucleotide residue</para>
    ///   <para>dcterms:description : A nucleotide residue is a part of a molecule that derives from a nucleotide.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010075">sio:SIO_010075</a>
    /// </summary>
    let SIO_010075 = _prefixId.prefix "SIO_010075"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010076^^xsd:string</para>
    ///   <para>rdfs:label : poison</para>
    ///   <para>dcterms:description : A poison is a drug that is harzardous or toxic to an organism when ingested at a certain quantity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010076">sio:SIO_010076</a>
    /// </summary>
    let SIO_010076 = _prefixId.prefix "SIO_010076"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010077^^xsd:string</para>
    ///   <para>rdfs:label : active ingredient</para>
    ///   <para>dcterms:description : An active ingredient is a molecular entity that exhibits biological activity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010077">sio:SIO_010077</a>
    /// </summary>
    let SIO_010077 = _prefixId.prefix "SIO_010077"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010078^^xsd:string</para>
    ///   <para>rdfs:label : encodes</para>
    ///   <para>sio:example : an open reading frame encodes a protein (it contains information that specifies the amino acid composition and topology)</para>
    ///   <para>dcterms:description : A relation between two objects, in which the first object contains information that is used to produce the second object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010078">sio:SIO_010078</a>
    /// </summary>
    let SIO_010078 = _prefixId.prefix "SIO_010078"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010079^^xsd:string</para>
    ///   <para>rdfs:label : is encoded by</para>
    ///   <para>dcterms:description : A relation between two objects, in which the first object is produced from the information contained in the second object.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010079">sio:SIO_010079</a>
    /// </summary>
    let SIO_010079 = _prefixId.prefix "SIO_010079"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010080^^xsd:string</para>
    ///   <para>rdfs:label : is transcribed into</para>
    ///   <para>sio:example : DNA is transcribed into RNA</para>
    ///   <para>dcterms:description : a relation between two information content entities in which one is transcribed into (an exact or similar kind) another through some process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010080">sio:SIO_010080</a>
    /// </summary>
    let SIO_010080 = _prefixId.prefix "SIO_010080"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010081^^xsd:string</para>
    ///   <para>rdfs:label : is transcribed from</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010081">sio:SIO_010081</a>
    /// </summary>
    let SIO_010081 = _prefixId.prefix "SIO_010081"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010082^^xsd:string</para>
    ///   <para>rdfs:label : is translated into</para>
    ///   <para>sio:example : a relation between two information content entities in which one is translated into (a completely different kind of entity) another through some process.sio:example : RNA is translated into Protein</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010082">sio:SIO_010082</a>
    /// </summary>
    let SIO_010082 = _prefixId.prefix "SIO_010082"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010083^^xsd:string</para>
    ///   <para>rdfs:label : is translated from</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010083">sio:SIO_010083</a>
    /// </summary>
    let SIO_010083 = _prefixId.prefix "SIO_010083"
    /// <summary>
    ///   <para>rdfs:label : operon</para>
    ///   <para>dc11:identifier : SIO_010084^^xsd:string</para>
    ///   <para>dcterms:description : An operon is a collection of contiguous genes transcribed as a single (polycistronic) mRNA.</para>
    ///   <para>sio:similarTo : SO:0000178^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010084">sio:SIO_010084</a>
    /// </summary>
    let SIO_010084 = _prefixId.prefix "SIO_010084"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010085^^xsd:string</para>
    ///   <para>rdfs:label : gene regulatory component</para>
    ///   <para>dcterms:description : A gene regulatory component is a gene component that exerts a regulatory function.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010085">sio:SIO_010085</a>
    /// </summary>
    let SIO_010085 = _prefixId.prefix "SIO_010085"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010086^^xsd:string</para>
    ///   <para>rdfs:label : gene enhancer</para>
    ///   <para>dcterms:description : A gene enhancer is a short region of DNA that can be bound with proteins to enhance transcription levels of genes in a gene cluster.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010086">sio:SIO_010086</a>
    /// </summary>
    let SIO_010086 = _prefixId.prefix "SIO_010086"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010087^^xsd:string</para>
    ///   <para>rdfs:label : inactive ingredient</para>
    ///   <para>dcterms:description : Aninactive ingredient is a molecular entity that does not exhibit biological activity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010087">sio:SIO_010087</a>
    /// </summary>
    let SIO_010087 = _prefixId.prefix "SIO_010087"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010088^^xsd:string</para>
    ///   <para>rdfs:label : to serve as a template for molecular synthesis</para>
    ///   <para>dcterms:description : to serve as a template for molecular synthesis is the capability of a chemical entity to provide the necessary information or scaffold by which another molecule may be produced.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010088">sio:SIO_010088</a>
    /// </summary>
    let SIO_010088 = _prefixId.prefix "SIO_010088"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010089^^xsd:string</para>
    ///   <para>rdfs:label : to serve as a template for protein synthesis</para>
    ///   <para>dcterms:description : to serve as a template for protein synthesis is the capability of a chemical entity to provide the necessary information or scaffold by which a protein may be produced.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010089">sio:SIO_010089</a>
    /// </summary>
    let SIO_010089 = _prefixId.prefix "SIO_010089"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010090^^xsd:string</para>
    ///   <para>rdfs:label : to serve as a template for RNA synthesis</para>
    ///   <para>dcterms:description : to serve as a template for RNA synthesis is the capability of a chemical entity to provide the necessary information or scaffold by which an RNA molecule may be produced.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010090">sio:SIO_010090</a>
    /// </summary>
    let SIO_010090 = _prefixId.prefix "SIO_010090"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010091^^xsd:string</para>
    ///   <para>rdfs:label : to serve as a template for DNA synthesis</para>
    ///   <para>dcterms:description : to serve as a template for DNA synthesis is the capability of a chemical entity to provide the necessary information or scaffold by which a DNA molecule may be produced.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010091">sio:SIO_010091</a>
    /// </summary>
    let SIO_010091 = _prefixId.prefix "SIO_010091"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010092^^xsd:string</para>
    ///   <para>rdfs:label : deoxyribonucleic acid template</para>
    ///   <para>dcterms:description : A deoxyribonucleic acid template is a deoxyribonucleic acid that provides the template to synthesize a complementary strand of DNA through transcription.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010092">sio:SIO_010092</a>
    /// </summary>
    let SIO_010092 = _prefixId.prefix "SIO_010092"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010093^^xsd:string</para>
    ///   <para>rdfs:label : deoxyribonucleic acid primer</para>
    ///   <para>dcterms:description : A deoxyribonucleic acid primer is a deoxyribonucleic acid that enables the synthesis of a complement strand of DNA by binding to it and acting as a point of transcription initiation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010093">sio:SIO_010093</a>
    /// </summary>
    let SIO_010093 = _prefixId.prefix "SIO_010093"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010094^^xsd:string</para>
    ///   <para>rdfs:label : to serve as a primer for DNA synthesis</para>
    ///   <para>dcterms:description : to serve as a primer for DNA synthesis is the capability of a short nucleic acid to bind to the 5' end of single strand of DNA template and help initiate DNA replication.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010094">sio:SIO_010094</a>
    /// </summary>
    let SIO_010094 = _prefixId.prefix "SIO_010094"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010095^^xsd:string</para>
    ///   <para>rdfs:label : RNA transcript component</para>
    ///   <para>dcterms:description : An RNA transcript component is a region of an RNA transcript. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_010095">sio:SIO_010095</a>
    /// </summary>
    let SIO_010095 = _prefixId.prefix "SIO_010095"
    /// <summary>
    ///   <para>dcterms:description : A mature RNA is a ribonucleic acid that contains an untranslated region (UTR) and protein coding sequence and lacks introns.</para>
    ///   <para>dc11:identifier : SIO_010096^^xsd:string</para>
    ///   <para>rdfs:label : mature mRNA</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010096">sio:SIO_010096</a>
    /// </summary>
    let SIO_010096 = _prefixId.prefix "SIO_010096"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010097^^xsd:string</para>
    ///   <para>rdfs:label : pre-mRNA</para>
    ///   <para>dcterms:description : Precursor mRNA (pre-mRNA) is a single strand of messenger ribonucleic acid (mRNA) that is synthesized from a DNA template throught transcription.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010097">sio:SIO_010097</a>
    /// </summary>
    let SIO_010097 = _prefixId.prefix "SIO_010097"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010098^^xsd:string</para>
    ///   <para>rdfs:label : mRNA splice variant</para>
    ///   <para>dcterms:description : An mRNA splice variant is an mRNA molecule that varies from another mRNA molecule of the same gene origin but having a different final sequence due to differences in its assembly from splice sites.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010098">sio:SIO_010098</a>
    /// </summary>
    let SIO_010098 = _prefixId.prefix "SIO_010098"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010099^^xsd:string</para>
    ///   <para>rdfs:label : messenger RNA</para>
    ///   <para>dcterms:description : A messenger RNA is a ribonucleic acid that contains an untranslated region (UTR) and protein coding sequence and lacks introns.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010099">sio:SIO_010099</a>
    /// </summary>
    let SIO_010099 = _prefixId.prefix "SIO_010099"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010100^^xsd:string</para>
    ///   <para>rdfs:label : dna gene</para>
    ///   <para>dcterms:description : A gene that is located on DNA.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010100">sio:SIO_010100</a>
    /// </summary>
    let SIO_010100 = _prefixId.prefix "SIO_010100"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010101^^xsd:string</para>
    ///   <para>rdfs:label : rna gene</para>
    ///   <para>dcterms:description : A gene that is located on RNA.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010101">sio:SIO_010101</a>
    /// </summary>
    let SIO_010101 = _prefixId.prefix "SIO_010101"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010277^^xsd:string</para>
    ///   <para>rdfs:label : allele</para>
    ///   <para>dcterms:description : An allele is one of a set of sequence variants of a gene.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010277">sio:SIO_010277</a>
    /// </summary>
    let SIO_010277 = _prefixId.prefix "SIO_010277"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010278^^xsd:string</para>
    ///   <para>rdfs:label : ploidy</para>
    ///   <para>dcterms:description : ploidy is the cellular quality relating to the amount of DNA contained in a cell.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010278">sio:SIO_010278</a>
    /// </summary>
    let SIO_010278 = _prefixId.prefix "SIO_010278"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010283^^xsd:string</para>
    ///   <para>rdfs:label : chemical transport</para>
    ///   <para>sio:equivalentTo : biopax:Transport^^xsd:string</para>
    ///   <para>dcterms:description : chemical transport is the directed movement of a chemical entity by some agent (e.g. transporter).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010283">sio:SIO_010283</a>
    /// </summary>
    let SIO_010283 = _prefixId.prefix "SIO_010283"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010284^^xsd:string</para>
    ///   <para>rdfs:label : active transport</para>
    ///   <para>sio:equivalentTo : biopax:TransportWithBiochemicalReaction^^xsd:string</para>
    ///   <para>dcterms:description : active transport is the movement of a substance across a membrane against its concentration gradient (from low to high concentration) and requires chemical energy.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010284">sio:SIO_010284</a>
    /// </summary>
    let SIO_010284 = _prefixId.prefix "SIO_010284"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010285^^xsd:string</para>
    ///   <para>rdfs:label : molecular complex formation</para>
    ///   <para>dcterms:description : molecular complex formation is the process of forming a molecular complex from its constituent parts.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010285">sio:SIO_010285</a>
    /// </summary>
    let SIO_010285 = _prefixId.prefix "SIO_010285"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010286^^xsd:string</para>
    ///   <para>rdfs:label : molecular complex dissociation</para>
    ///   <para>dcterms:description : molecular complex disassociation is the process of dissambly of a molecular complex into its constitutent parts.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010286">sio:SIO_010286</a>
    /// </summary>
    let SIO_010286 = _prefixId.prefix "SIO_010286"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010287^^xsd:string</para>
    ///   <para>rdfs:label : regulation of biochemical process</para>
    ///   <para>dcterms:description : regulation of biochemical process is a process that changes the frequency, rate or extent of a target biochemical process.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010287">sio:SIO_010287</a>
    /// </summary>
    let SIO_010287 = _prefixId.prefix "SIO_010287"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010288^^xsd:string</para>
    ///   <para>rdfs:label : biochemical activation</para>
    ///   <para>dcterms:description : biochemical activation is a molecular interaction that increases the catalytic rate of the target enzyme.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010288">sio:SIO_010288</a>
    /// </summary>
    let SIO_010288 = _prefixId.prefix "SIO_010288"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010289^^xsd:string</para>
    ///   <para>rdfs:label : biochemical inhibition</para>
    ///   <para>dcterms:description : biochemical inhibition is a molecular interaction that decreases the catalytic rate of the target enzyme.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010289">sio:SIO_010289</a>
    /// </summary>
    let SIO_010289 = _prefixId.prefix "SIO_010289"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010295^^xsd:string</para>
    ///   <para>rdfs:label : process up-regulation</para>
    ///   <para>sio:hasSynonym : positive regulation</para>
    ///   <para>dcterms:description : process up-regulation is a process that increases the frequency, rate or extent of one or more processes in relation to a reference state.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010295">sio:SIO_010295</a>
    /// </summary>
    let SIO_010295 = _prefixId.prefix "SIO_010295"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010296^^xsd:string</para>
    ///   <para>rdfs:label : process down-regulation</para>
    ///   <para>sio:hasSynonym : negative regulation</para>
    ///   <para>dcterms:description : process down-regulation is a process that decreases the frequency, rate or extent of one or more processes in relation to a reference state.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010296">sio:SIO_010296</a>
    /// </summary>
    let SIO_010296 = _prefixId.prefix "SIO_010296"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010298^^xsd:string</para>
    ///   <para>rdfs:label : medical data</para>
    ///   <para>dcterms:description : medical data is data of interest to medicine.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010298">sio:SIO_010298</a>
    /// </summary>
    let SIO_010298 = _prefixId.prefix "SIO_010298"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010299^^xsd:string</para>
    ///   <para>rdfs:label : disease</para>
    ///   <para>dcterms:description : disease is the outward manifestation of one or more disorders.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010299">sio:SIO_010299</a>
    /// </summary>
    let SIO_010299 = _prefixId.prefix "SIO_010299"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010300^^xsd:string</para>
    ///   <para>rdfs:label : transcription</para>
    ///   <para>dcterms:description : transcription is the process of creating a complementary RNA copy of a sequence of DNA.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010300">sio:SIO_010300</a>
    /// </summary>
    let SIO_010300 = _prefixId.prefix "SIO_010300"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010301^^xsd:string</para>
    ///   <para>rdfs:label : translation</para>
    ///   <para>dcterms:description : translation is the process of producing a polypeptide from a ribonucleic acid by a ribosome.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010301">sio:SIO_010301</a>
    /// </summary>
    let SIO_010301 = _prefixId.prefix "SIO_010301"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010302^^xsd:string</para>
    ///   <para>rdfs:label : is homologous to</para>
    ///   <para>dcterms:description : a relation between two entities which indicates their common ancestry.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010302">sio:SIO_010302</a>
    /// </summary>
    let SIO_010302 = _prefixId.prefix "SIO_010302"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010307^^xsd:string</para>
    ///   <para>rdfs:label : molecular modification</para>
    ///   <para>dcterms:description : Molecular modification is chemical alteration of a known and previously characterized lead compound for the purpose of enhancing its usefulness as a drug. This could mean enhancing its specificity for a particular body target site, increasing its potency, improving its rate and extent of absorption, modifying to advantage its time course in the body, reducing its toxicity, changing its physical or chemical properties (like solubility) to provide desired features.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010307">sio:SIO_010307</a>
    /// </summary>
    let SIO_010307 = _prefixId.prefix "SIO_010307"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010308^^xsd:string</para>
    ///   <para>rdfs:label : metabolism</para>
    ///   <para>dcterms:description : Metabolism is the set of chemical processes that occur within a living organism in order to maintain life.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010308">sio:SIO_010308</a>
    /// </summary>
    let SIO_010308 = _prefixId.prefix "SIO_010308"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010309^^xsd:string</para>
    ///   <para>rdfs:label : catabolism</para>
    ///   <para>dcterms:description : Anabolism is the set of metabolic processes that take apart larger chemical entities units into smaller chemical entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010309">sio:SIO_010309</a>
    /// </summary>
    let SIO_010309 = _prefixId.prefix "SIO_010309"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010310^^xsd:string</para>
    ///   <para>rdfs:label : anabolism</para>
    ///   <para>dcterms:description : Anabolism is the set of metabolic processes that construct larger chemical entities units from smaller chemical entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010310">sio:SIO_010310</a>
    /// </summary>
    let SIO_010310 = _prefixId.prefix "SIO_010310"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010334^^xsd:string</para>
    ///   <para>rdfs:label : carbohydrate residue</para>
    ///   <para>dcterms:description : A carbohydrate residue is a part of a molecule that was derived from a monosaccharide molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010334">sio:SIO_010334</a>
    /// </summary>
    let SIO_010334 = _prefixId.prefix "SIO_010334"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010335^^xsd:string</para>
    ///   <para>rdfs:label : nucleic acid part</para>
    ///   <para>dcterms:description : A nucleic acid part is a component of a nucleic acid.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010335">sio:SIO_010335</a>
    /// </summary>
    let SIO_010335 = _prefixId.prefix "SIO_010335"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010336^^xsd:string</para>
    ///   <para>rdfs:label : deoxyribonucleotide residue</para>
    ///   <para>dcterms:description : A deoxyribonucleotide residue is a part of a molecule that derives from a deoxyribonucleotide.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010336">sio:SIO_010336</a>
    /// </summary>
    let SIO_010336 = _prefixId.prefix "SIO_010336"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010337^^xsd:string</para>
    ///   <para>rdfs:label : ribonucleotide residue</para>
    ///   <para>dcterms:description : A ribonucleotide residue is a part of a molecule that derives from a ribonucleotide.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010337">sio:SIO_010337</a>
    /// </summary>
    let SIO_010337 = _prefixId.prefix "SIO_010337"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010338^^xsd:string</para>
    ///   <para>rdfs:label : pharmaceutical component</para>
    ///   <para>dcterms:description : A pharmaceutical component is a part of a pharmaceutical preparation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010338">sio:SIO_010338</a>
    /// </summary>
    let SIO_010338 = _prefixId.prefix "SIO_010338"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010340^^xsd:string</para>
    ///   <para>rdfs:label : to covalently modify</para>
    ///   <para>dcterms:description : to covalently modify is to materially change a molecule by adding or removing covalent bonds between atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010340">sio:SIO_010340</a>
    /// </summary>
    let SIO_010340 = _prefixId.prefix "SIO_010340"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010341^^xsd:string</para>
    ///   <para>rdfs:label : covalently connected entity</para>
    ///   <para>dcterms:description : A covalently connected molecular entity is the mereological sum of a collection of covalently bonded atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010341">sio:SIO_010341</a>
    /// </summary>
    let SIO_010341 = _prefixId.prefix "SIO_010341"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010342^^xsd:string</para>
    ///   <para>rdfs:label : chemical complex</para>
    ///   <para>dcterms:description : A chemical complex is a chemical entity composed of a weakly connected ions or molecules.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010342">sio:SIO_010342</a>
    /// </summary>
    let SIO_010342 = _prefixId.prefix "SIO_010342"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010343^^xsd:string</para>
    ///   <para>rdfs:label : enzyme</para>
    ///   <para>dcterms:description : An enzyme is a protein or protein complex that realizes its disposition to covalently modify some molecule during a chemical reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010343">sio:SIO_010343</a>
    /// </summary>
    let SIO_010343 = _prefixId.prefix "SIO_010343"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010344^^xsd:string</para>
    ///   <para>rdfs:label : catalyst</para>
    ///   <para>dcterms:description : A catalyst is a molecule that has the capability to reduce the activation energy of a reaction and hence increase the overall rate of reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010344">sio:SIO_010344</a>
    /// </summary>
    let SIO_010344 = _prefixId.prefix "SIO_010344"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010345^^xsd:string</para>
    ///   <para>rdfs:label : chemical reaction</para>
    ///   <para>dcterms:description : A chemical reaction is a process that leads to the transformation of one set of chemical substances to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010345">sio:SIO_010345</a>
    /// </summary>
    let SIO_010345 = _prefixId.prefix "SIO_010345"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010346^^xsd:string</para>
    ///   <para>rdfs:label : organic polymer</para>
    ///   <para>dcterms:description : An organic polymer is an organic molecule composed of connected set of monomeric units.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010346">sio:SIO_010346</a>
    /// </summary>
    let SIO_010346 = _prefixId.prefix "SIO_010346"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010347^^xsd:string</para>
    ///   <para>rdfs:label : to modify conformation of</para>
    ///   <para>dcterms:description : to modify conformation of is to affect the spatial arrangement of an entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010347">sio:SIO_010347</a>
    /// </summary>
    let SIO_010347 = _prefixId.prefix "SIO_010347"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010349^^xsd:string</para>
    ///   <para>rdfs:label : to cleave</para>
    ///   <para>dcterms:description : to cleave is to split or sever an object along a natural line or grain.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010349">sio:SIO_010349</a>
    /// </summary>
    let SIO_010349 = _prefixId.prefix "SIO_010349"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010351^^xsd:string</para>
    ///   <para>rdfs:label : to combine</para>
    ///   <para>dcterms:description : to combine is the capability to modify a set of objects in a way that the object is merged with another object to form a new object or substance.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010351">sio:SIO_010351</a>
    /// </summary>
    let SIO_010351 = _prefixId.prefix "SIO_010351"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010353^^xsd:string</para>
    ///   <para>rdfs:label : to breathe</para>
    ///   <para>dcterms:description : to breathe is the capability to inhale and exhale air into the body during respiration.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010353">sio:SIO_010353</a>
    /// </summary>
    let SIO_010353 = _prefixId.prefix "SIO_010353"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010354^^xsd:string</para>
    ///   <para>rdfs:label : to conformationally activate</para>
    ///   <para>dcterms:description : to conformationally activate is to modify the conformation of an entity in such a way that it becomes activated or functional.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010354">sio:SIO_010354</a>
    /// </summary>
    let SIO_010354 = _prefixId.prefix "SIO_010354"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010355^^xsd:string</para>
    ///   <para>rdfs:label : to conformationally inhibit</para>
    ///   <para>dcterms:description : to conformationally inhibit is to modify the conformation of an entity in such a way that it functionally is reduced or inhibited.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010355">sio:SIO_010355</a>
    /// </summary>
    let SIO_010355 = _prefixId.prefix "SIO_010355"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010358^^xsd:string</para>
    ///   <para>rdfs:label : to oxidize</para>
    ///   <para>dcterms:description : to oxidize is the capability to remove an electron or an increase in oxidation state of a chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010358">sio:SIO_010358</a>
    /// </summary>
    let SIO_010358 = _prefixId.prefix "SIO_010358"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010359^^xsd:string</para>
    ///   <para>rdfs:label : to reduce</para>
    ///   <para>dcterms:description : to reduce is the capability to add an electron or an decrease in oxidation state of a chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010359">sio:SIO_010359</a>
    /// </summary>
    let SIO_010359 = _prefixId.prefix "SIO_010359"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010360^^xsd:string</para>
    ///   <para>rdfs:label : to modify oxidation state of</para>
    ///   <para>dcterms:description : to modify the oxidation state of is to change the number of electrons of a molecule, atom or ion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010360">sio:SIO_010360</a>
    /// </summary>
    let SIO_010360 = _prefixId.prefix "SIO_010360"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010362^^xsd:string</para>
    ///   <para>rdfs:label : substrate</para>
    ///   <para>dcterms:description : A substrate is a molecule that is consumed in the course of a biochemical reaction.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010362">sio:SIO_010362</a>
    /// </summary>
    let SIO_010362 = _prefixId.prefix "SIO_010362"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010363^^xsd:string</para>
    ///   <para>rdfs:label : product</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010363">sio:SIO_010363</a>
    /// </summary>
    let SIO_010363 = _prefixId.prefix "SIO_010363"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010364^^xsd:string</para>
    ///   <para>rdfs:label : to be modified</para>
    ///   <para>dcterms:description : to be modified is the capability to be actively interacted with in such a way that it leads to a physical reconfiguration.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010364">sio:SIO_010364</a>
    /// </summary>
    let SIO_010364 = _prefixId.prefix "SIO_010364"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010365^^xsd:string</para>
    ///   <para>rdfs:label : to be cleaved</para>
    ///   <para>dcterms:description : to be cleaved is the capability to be modified in a way that splits one part of the object from the other.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010365">sio:SIO_010365</a>
    /// </summary>
    let SIO_010365 = _prefixId.prefix "SIO_010365"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010366^^xsd:string</para>
    ///   <para>rdfs:label : to be covalently modified</para>
    ///   <para>dcterms:description : to be covalently modified is the capability of a chemical entity to have bonds added or removed</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010366">sio:SIO_010366</a>
    /// </summary>
    let SIO_010366 = _prefixId.prefix "SIO_010366"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010367^^xsd:string</para>
    ///   <para>rdfs:label : to be combined</para>
    ///   <para>dcterms:description : to be combined is the capability to be modified in a way that the object is merged with another object to form a new object or substance.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010367">sio:SIO_010367</a>
    /// </summary>
    let SIO_010367 = _prefixId.prefix "SIO_010367"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010368^^xsd:string</para>
    ///   <para>rdfs:label : to be transported</para>
    ///   <para>dcterms:description : to be transported is the disposition to undergo motion.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010368">sio:SIO_010368</a>
    /// </summary>
    let SIO_010368 = _prefixId.prefix "SIO_010368"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010369^^xsd:string</para>
    ///   <para>rdfs:label : to be electronically modified</para>
    ///   <para>dcterms:description : to be electronically modified is the capability of a chemical entity to have electrons added or removed.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010369">sio:SIO_010369</a>
    /// </summary>
    let SIO_010369 = _prefixId.prefix "SIO_010369"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010370^^xsd:string</para>
    ///   <para>rdfs:label : to gain an electron</para>
    ///   <para>dcterms:description : to gain an electron is the capability of a chemical entity to receive an electron.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010370">sio:SIO_010370</a>
    /// </summary>
    let SIO_010370 = _prefixId.prefix "SIO_010370"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010371^^xsd:string</para>
    ///   <para>rdfs:label : to lose an electron</para>
    ///   <para>dcterms:description : to lose an electron is the capability of a chemical entity to lose an electron.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010371">sio:SIO_010371</a>
    /// </summary>
    let SIO_010371 = _prefixId.prefix "SIO_010371"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010372^^xsd:string</para>
    ///   <para>rdfs:label : to be activated</para>
    ///   <para>dcterms:description : to be activated is the capability to be modified in such a way that the conformational change leads to an increase in another capability.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010372">sio:SIO_010372</a>
    /// </summary>
    let SIO_010372 = _prefixId.prefix "SIO_010372"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010373^^xsd:string</para>
    ///   <para>rdfs:label : to be inhibited</para>
    ///   <para>dcterms:description : to be inhibited is the capability to be modified in such a way that the conformational change leads to an decrease in another capability.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010373">sio:SIO_010373</a>
    /// </summary>
    let SIO_010373 = _prefixId.prefix "SIO_010373"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010374^^xsd:string</para>
    ///   <para>rdfs:label : to be conformationally changed</para>
    ///   <para>dcterms:description : to be conformationally changed is the capability to be modified in such a way that the object's conformation is changed.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010374">sio:SIO_010374</a>
    /// </summary>
    let SIO_010374 = _prefixId.prefix "SIO_010374"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010375^^xsd:string</para>
    ///   <para>rdfs:label : multicellular organism</para>
    ///   <para>dcterms:description : A multi-cellular organism is an organism that consists of more than one cell.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010375">sio:SIO_010375</a>
    /// </summary>
    let SIO_010375 = _prefixId.prefix "SIO_010375"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010376^^xsd:string</para>
    ///   <para>rdfs:label : unicellular organism</para>
    ///   <para>dcterms:description : A unicellular organism is a organism that is composed of a single cell.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010376">sio:SIO_010376</a>
    /// </summary>
    let SIO_010376 = _prefixId.prefix "SIO_010376"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010377^^xsd:string</para>
    ///   <para>rdfs:label : cellular organism</para>
    ///   <para>dcterms:description : A cellular organism is an organism that contains one or more cells.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010377">sio:SIO_010377</a>
    /// </summary>
    let SIO_010377 = _prefixId.prefix "SIO_010377"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010378^^xsd:string</para>
    ///   <para>rdfs:label : non-cellular organism</para>
    ///   <para>dcterms:description : A non-cellular organism is an organism that does not contain a cell.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010378">sio:SIO_010378</a>
    /// </summary>
    let SIO_010378 = _prefixId.prefix "SIO_010378"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010379^^xsd:string</para>
    ///   <para>rdfs:label : virus</para>
    ///   <para>dcterms:description : A virus is a non-cellular organism that can replicate only inside the living cells of an organism.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010379">sio:SIO_010379</a>
    /// </summary>
    let SIO_010379 = _prefixId.prefix "SIO_010379"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010383^^xsd:string</para>
    ///   <para>rdfs:label : drug regulatory authority</para>
    ///   <para>dcterms:description : A drug regulatory authority is a regulatory authority which acts to control what substances may be used to treat individuals.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010383">sio:SIO_010383</a>
    /// </summary>
    let SIO_010383 = _prefixId.prefix "SIO_010383"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010410^^xsd:string</para>
    ///   <para>rdfs:label : specialized material entity</para>
    ///   <para>dcterms:description : A specialized material entity is a material entity that is defined by having some quality, role or capability.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010410">sio:SIO_010410</a>
    /// </summary>
    let SIO_010410 = _prefixId.prefix "SIO_010410"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010411^^xsd:string</para>
    ///   <para>rdfs:label : reagent</para>
    ///   <para>dcterms:description : A reagent is a substance that is added to a system in order to bring about a chemical reaction, or added to see if a reaction occurs.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010411">sio:SIO_010411</a>
    /// </summary>
    let SIO_010411 = _prefixId.prefix "SIO_010411"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010412^^xsd:string</para>
    ///   <para>rdfs:label : specimen</para>
    ///   <para>dcterms:description : A specimen is a portion of material for use in testing, examination, or study.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010412">sio:SIO_010412</a>
    /// </summary>
    let SIO_010412 = _prefixId.prefix "SIO_010412"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010414^^xsd:string</para>
    ///   <para>rdfs:label : pathogen</para>
    ///   <para>dcterms:description : A pathogen or infectious agent  is a microorganism that causes disease in its host.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010414">sio:SIO_010414</a>
    /// </summary>
    let SIO_010414 = _prefixId.prefix "SIO_010414"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010415^^xsd:string</para>
    ///   <para>rdfs:label : host</para>
    ///   <para>dcterms:description : A host is an organism that harbors a parasite, or a mutual or commensal symbiont, typically providing nourishment and shelter.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010415">sio:SIO_010415</a>
    /// </summary>
    let SIO_010415 = _prefixId.prefix "SIO_010415"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010416^^xsd:string</para>
    ///   <para>rdfs:label : buffer</para>
    ///   <para>dcterms:description : A buffer is a dissolved chemical substance that resists change in pH upon addition of small amounts of acid or base.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010416">sio:SIO_010416</a>
    /// </summary>
    let SIO_010416 = _prefixId.prefix "SIO_010416"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010417^^xsd:string</para>
    ///   <para>rdfs:label : solvent</para>
    ///   <para>dcterms:description : A solvent is a substance that can dissolve other substances (solutes).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010417">sio:SIO_010417</a>
    /// </summary>
    let SIO_010417 = _prefixId.prefix "SIO_010417"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010418^^xsd:string</para>
    ///   <para>rdfs:label : solute</para>
    ///   <para>dcterms:description : A solute is a substance that becomes dissolved in a solvent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010418">sio:SIO_010418</a>
    /// </summary>
    let SIO_010418 = _prefixId.prefix "SIO_010418"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010419^^xsd:string</para>
    ///   <para>rdfs:label : antigen</para>
    ///   <para>dcterms:description : An antigen is a chemical entity that can be bound by a major histocompatibility complex (MHC) and presented to a T-cell receptor.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010419">sio:SIO_010419</a>
    /// </summary>
    let SIO_010419 = _prefixId.prefix "SIO_010419"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010420^^xsd:string</para>
    ///   <para>rdfs:label : receptor</para>
    ///   <para>dcterms:description : A receptor molecule is a molecule that has the capability to bind to a signal and propogate a response to that signal.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010420">sio:SIO_010420</a>
    /// </summary>
    let SIO_010420 = _prefixId.prefix "SIO_010420"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010423^^xsd:string</para>
    ///   <para>rdfs:label : target</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010423">sio:SIO_010423</a>
    /// </summary>
    let SIO_010423 = _prefixId.prefix "SIO_010423"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010424^^xsd:string</para>
    ///   <para>rdfs:label : centrifugation pellet</para>
    ///   <para>dcterms:description : A centrifugation pellet is a solid substance that forms as a result of compaction by a centrifuge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010424">sio:SIO_010424</a>
    /// </summary>
    let SIO_010424 = _prefixId.prefix "SIO_010424"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010425^^xsd:string</para>
    ///   <para>rdfs:label : supernatant</para>
    ///   <para>dcterms:description : A supernatent is a liquid substance that remains after centrifugation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010425">sio:SIO_010425</a>
    /// </summary>
    let SIO_010425 = _prefixId.prefix "SIO_010425"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010426^^xsd:string</para>
    ///   <para>rdfs:label : centrifugation substance</para>
    ///   <para>dcterms:description : A centrifugation substance is a substance that is the target or product of centrifugation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010426">sio:SIO_010426</a>
    /// </summary>
    let SIO_010426 = _prefixId.prefix "SIO_010426"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010427^^xsd:string</para>
    ///   <para>rdfs:label : liquid solution component</para>
    ///   <para>dcterms:description : A liquid solution component is a part of a liquid solution.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010427">sio:SIO_010427</a>
    /// </summary>
    let SIO_010427 = _prefixId.prefix "SIO_010427"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010428^^xsd:string</para>
    ///   <para>rdfs:label : evaluation role</para>
    ///   <para>dcterms:description : An evaluation role is a processual role held by an entity during some evaluation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010428">sio:SIO_010428</a>
    /// </summary>
    let SIO_010428 = _prefixId.prefix "SIO_010428"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010429^^xsd:string</para>
    ///   <para>rdfs:label : placebo</para>
    ///   <para>dcterms:description : A placebo is a medically ineffectual treatment for a medical condition intended to deceive the recipient.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010429">sio:SIO_010429</a>
    /// </summary>
    let SIO_010429 = _prefixId.prefix "SIO_010429"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010430^^xsd:string</para>
    ///   <para>rdfs:label : test role</para>
    ///   <para>dcterms:description : A test role is the role of an individual that is a participant in the study and is the target of the intervention.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010430">sio:SIO_010430</a>
    /// </summary>
    let SIO_010430 = _prefixId.prefix "SIO_010430"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010431^^xsd:string</para>
    ///   <para>rdfs:label : control role</para>
    ///   <para>dcterms:description : A control role is the role of an individual that is part of a study, but is not subject to the intervention that is to be tested.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010431">sio:SIO_010431</a>
    /// </summary>
    let SIO_010431 = _prefixId.prefix "SIO_010431"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010432^^xsd:string</para>
    ///   <para>rdfs:label : ligand</para>
    ///   <para>dcterms:description : A ligand is a molecule that is part of a complex by weakly interacting with another molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010432">sio:SIO_010432</a>
    /// </summary>
    let SIO_010432 = _prefixId.prefix "SIO_010432"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010433^^xsd:string</para>
    ///   <para>rdfs:label : low barrier hydrogen bond</para>
    ///   <para>dcterms:description : A low barrier hydrogen bond is a shorter, stronger hydrogen bond that is formed between both heteroatoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010433">sio:SIO_010433</a>
    /// </summary>
    let SIO_010433 = _prefixId.prefix "SIO_010433"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010434^^xsd:string</para>
    ///   <para>rdfs:label : activator</para>
    ///   <para>dcterms:description : A molecular activator is a molecular regulator that realizes its disposition to conformationally change a target molecule and increase its functionality.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010434">sio:SIO_010434</a>
    /// </summary>
    let SIO_010434 = _prefixId.prefix "SIO_010434"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010435^^xsd:string</para>
    ///   <para>rdfs:label : inhibitor</para>
    ///   <para>dcterms:description : A molecular inhibitor is a molecular regulator that realizes its disposition to conformationally change a target molecule and decrease its functionality.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010435">sio:SIO_010435</a>
    /// </summary>
    let SIO_010435 = _prefixId.prefix "SIO_010435"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010436^^xsd:string</para>
    ///   <para>rdfs:label : molecular regulator</para>
    ///   <para>dcterms:description : A molecular regulator is a molecule that regulates the function of another chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010436">sio:SIO_010436</a>
    /// </summary>
    let SIO_010436 = _prefixId.prefix "SIO_010436"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010437^^xsd:string</para>
    ///   <para>rdfs:label : signal transducer</para>
    ///   <para>dcterms:description : A signal transducer is a molecule that responds to and amplifies a signal in a signalling system.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010437">sio:SIO_010437</a>
    /// </summary>
    let SIO_010437 = _prefixId.prefix "SIO_010437"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010438^^xsd:string</para>
    ///   <para>rdfs:label : signal</para>
    ///   <para>dcterms:description : A signal is an object that initiates a sequence of events.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010438">sio:SIO_010438</a>
    /// </summary>
    let SIO_010438 = _prefixId.prefix "SIO_010438"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010439^^xsd:string</para>
    ///   <para>rdfs:label : messenger</para>
    ///   <para>dcterms:description : A mesenger is a molecule involved in either signal detection or signal propagation from receptors on the cell surface to target molecules inside the cell, in the cytoplasm or nucleus.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010439">sio:SIO_010439</a>
    /// </summary>
    let SIO_010439 = _prefixId.prefix "SIO_010439"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010440^^xsd:string</para>
    ///   <para>rdfs:label : second messenger</para>
    ///   <para>dcterms:description : A second messenger is a molecule that relay signals from receptors on the cell surface to target molecules inside the cell, in the cytoplasm or nucleus. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_010440">sio:SIO_010440</a>
    /// </summary>
    let SIO_010440 = _prefixId.prefix "SIO_010440"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010441^^xsd:string</para>
    ///   <para>rdfs:label : submolecule</para>
    ///   <para>dcterms:description : A submolecule is a mereological sum of covalently bonded atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010441">sio:SIO_010441</a>
    /// </summary>
    let SIO_010441 = _prefixId.prefix "SIO_010441"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010442^^xsd:string</para>
    ///   <para>rdfs:label : charge quality</para>
    ///   <para>dcterms:description : charge quality is the quality pertaining to electric charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010442">sio:SIO_010442</a>
    /// </summary>
    let SIO_010442 = _prefixId.prefix "SIO_010442"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010443^^xsd:string</para>
    ///   <para>rdfs:label : intron</para>
    ///   <para>dcterms:description : An intron is a region of a gene that is removed from the final protein open reading frame.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010443">sio:SIO_010443</a>
    /// </summary>
    let SIO_010443 = _prefixId.prefix "SIO_010443"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010444^^xsd:string</para>
    ///   <para>rdfs:label : gene component</para>
    ///   <para>dcterms:description : A gene component is a component of a gene.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010444">sio:SIO_010444</a>
    /// </summary>
    let SIO_010444 = _prefixId.prefix "SIO_010444"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010445^^xsd:string</para>
    ///   <para>rdfs:label : exon</para>
    ///   <para>dcterms:description : An exon is a nucleotide sequence encoded by a gene that remains present within the final mature RNA product of that gene after introns have been removed by RNA splicing. </para>
    ///   <a href="http://semanticscience.org/resource/SIO_010445">sio:SIO_010445</a>
    /// </summary>
    let SIO_010445 = _prefixId.prefix "SIO_010445"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010446^^xsd:string</para>
    ///   <para>rdfs:label : gene promoter</para>
    ///   <para>dcterms:description : A gene promoter is a region of DNA that initiates transcription of a particular gene.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010446">sio:SIO_010446</a>
    /// </summary>
    let SIO_010446 = _prefixId.prefix "SIO_010446"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010447^^xsd:string</para>
    ///   <para>rdfs:label : start codon</para>
    ///   <para>dcterms:description : A start codon is the first codon of a messenger RNA (mRNA) transcript translated by a ribosome. The start codon is almost always preceded by an untranslated region 5' UTR.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010447">sio:SIO_010447</a>
    /// </summary>
    let SIO_010447 = _prefixId.prefix "SIO_010447"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010448^^xsd:string</para>
    ///   <para>rdfs:label : stop codon</para>
    ///   <para>dcterms:description : A stop codon (or termination codon) is a nucleotide triplet within messenger RNA that signals a termination of translation.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010448">sio:SIO_010448</a>
    /// </summary>
    let SIO_010448 = _prefixId.prefix "SIO_010448"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010450^^xsd:string</para>
    ///   <para>rdfs:label : RNA transcript</para>
    ///   <para>dcterms:description : An RNA transcript is an RNA molecule that is produced from transcription of a nucleic acid template.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010450">sio:SIO_010450</a>
    /// </summary>
    let SIO_010450 = _prefixId.prefix "SIO_010450"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010451^^xsd:string</para>
    ///   <para>rdfs:label : splice site</para>
    ///   <para>dcterms:description : A splice site is a region required for the excision of an intron and connection to another exon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010451">sio:SIO_010451</a>
    /// </summary>
    let SIO_010451 = _prefixId.prefix "SIO_010451"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010452^^xsd:string</para>
    ///   <para>rdfs:label : molecular pocket</para>
    ///   <para>dcterms:description : A molecular pocket is a site on a molecule that appears as a depression into the structure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010452">sio:SIO_010452</a>
    /// </summary>
    let SIO_010452 = _prefixId.prefix "SIO_010452"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010453^^xsd:string</para>
    ///   <para>rdfs:label : acid</para>
    ///   <para>dcterms:description : An acid is a molecular entity in solution capable of donating a hydron (Bronsted acid) or capable of forming a covalent bond with an electron pair (Lewis acid).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010453">sio:SIO_010453</a>
    /// </summary>
    let SIO_010453 = _prefixId.prefix "SIO_010453"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010454^^xsd:string</para>
    ///   <para>rdfs:label : base</para>
    ///   <para>dcterms:description : A base is a molecular entity dissolved in a solvent that is capable of accepting a proton (Bronsted base) or forming a covalent bond with a hydron (Lewis base) .</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010454">sio:SIO_010454</a>
    /// </summary>
    let SIO_010454 = _prefixId.prefix "SIO_010454"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010455^^xsd:string</para>
    ///   <para>rdfs:label : isomer</para>
    ///   <para>dcterms:description : An isomer is a molecule that is compositionally identical to another molecule as a result of a different atomic connectivity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010455">sio:SIO_010455</a>
    /// </summary>
    let SIO_010455 = _prefixId.prefix "SIO_010455"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010456^^xsd:string</para>
    ///   <para>rdfs:label : ion</para>
    ///   <para>dcterms:description : An ion is an atom or molecule in which the total number of electrons is not equal to the total number of protons, giving it a net positive or negative electrical charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010456">sio:SIO_010456</a>
    /// </summary>
    let SIO_010456 = _prefixId.prefix "SIO_010456"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010457^^xsd:string</para>
    ///   <para>rdfs:label : cation</para>
    ///   <para>dcterms:description : An anion is an atom or molecule with a net positive electrical charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010457">sio:SIO_010457</a>
    /// </summary>
    let SIO_010457 = _prefixId.prefix "SIO_010457"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010458^^xsd:string</para>
    ///   <para>rdfs:label : anion</para>
    ///   <para>dcterms:description : An anion is an atom or molecule with a net negative electrical charge.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010458">sio:SIO_010458</a>
    /// </summary>
    let SIO_010458 = _prefixId.prefix "SIO_010458"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010459^^xsd:string</para>
    ///   <para>rdfs:label : polar solvent</para>
    ///   <para>dcterms:description : A polar solvent is a solvent that exhibits a polar quality.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010459">sio:SIO_010459</a>
    /// </summary>
    let SIO_010459 = _prefixId.prefix "SIO_010459"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010460^^xsd:string</para>
    ///   <para>rdfs:label : nonpolar solvent</para>
    ///   <para>dcterms:description : A non-polar solvent is a solvent that exhibits a non-polar quality.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010460">sio:SIO_010460</a>
    /// </summary>
    let SIO_010460 = _prefixId.prefix "SIO_010460"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010461^^xsd:string</para>
    ///   <para>rdfs:label : positive charge</para>
    ///   <para>dcterms:description : A positive charge is a charge where the value is positive.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010461">sio:SIO_010461</a>
    /// </summary>
    let SIO_010461 = _prefixId.prefix "SIO_010461"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010462^^xsd:string</para>
    ///   <para>rdfs:label : heterogeneous substance</para>
    ///   <para>dcterms:description : A heterogeneous substance is a chemical substance that is composed of more than one different kind of component.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010462">sio:SIO_010462</a>
    /// </summary>
    let SIO_010462 = _prefixId.prefix "SIO_010462"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010463^^xsd:string</para>
    ///   <para>rdfs:label : homogeneous substance</para>
    ///   <para>dcterms:description : A homogeneous substance is a substance that is composed of a uniform type of entity.^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010463">sio:SIO_010463</a>
    /// </summary>
    let SIO_010463 = _prefixId.prefix "SIO_010463"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010464^^xsd:string</para>
    ///   <para>rdfs:label : negative charge</para>
    ///   <para>dcterms:description : A negative charge is a charge where the value is negative.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010464">sio:SIO_010464</a>
    /// </summary>
    let SIO_010464 = _prefixId.prefix "SIO_010464"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010465^^xsd:string</para>
    ///   <para>rdfs:label : antibody</para>
    ///   <para>dcterms:description : An antibody (also known as immunoglobulins, abbreviated Ig) are gamma globulin proteins that are used by the immune system to identify and neutralize foreign objects. They are typically made of two large heavy chains and two small light chains.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010465">sio:SIO_010465</a>
    /// </summary>
    let SIO_010465 = _prefixId.prefix "SIO_010465"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010468^^xsd:string</para>
    ///   <para>rdfs:label : alpha helix</para>
    ///   <para>dcterms:description : An alpha helix is structural region of a protein that is characterized by 3.6 residues per turn,  a translation of 1.5 angstroms along the helical axis in which backbone N-H groups form a hydrogen bond to the backbone carboxyl group of the amino acid four residues prior.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010468">sio:SIO_010468</a>
    /// </summary>
    let SIO_010468 = _prefixId.prefix "SIO_010468"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010469^^xsd:string</para>
    ///   <para>rdfs:label : beta strand</para>
    ///   <para>dcterms:description : A beta strand is structural region of a protein that is characterized by a roughly planar sequence of amino acid residues forming hydrogen bonds between the N-O and the C=O  of another part of the peptide
    /// and having their side chains perpendicular to the planar axis.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010469">sio:SIO_010469</a>
    /// </summary>
    let SIO_010469 = _prefixId.prefix "SIO_010469"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010471^^xsd:string</para>
    ///   <para>rdfs:label : protein part</para>
    ///   <para>dcterms:description : A protein part is any submolecule of a protein.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010471">sio:SIO_010471</a>
    /// </summary>
    let SIO_010471 = _prefixId.prefix "SIO_010471"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010496^^xsd:string</para>
    ///   <para>rdfs:label : ionic interaction</para>
    ///   <para>dcterms:description : An ionic interaction is a weak submolecular interaction between a charged submolecules.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010496">sio:SIO_010496</a>
    /// </summary>
    let SIO_010496 = _prefixId.prefix "SIO_010496"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010497^^xsd:string</para>
    ///   <para>rdfs:label : protein complex</para>
    ///   <para>dcterms:description : A protein complex is a molecular complex composed of at least two polypeptide chains.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010497">sio:SIO_010497</a>
    /// </summary>
    let SIO_010497 = _prefixId.prefix "SIO_010497"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010498^^xsd:string</para>
    ///   <para>rdfs:label : single bond</para>
    ///   <para>dcterms:description : A single bond is a covalent bond between a pair of atoms in which one pair of electrons are shared.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010498">sio:SIO_010498</a>
    /// </summary>
    let SIO_010498 = _prefixId.prefix "SIO_010498"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010499^^xsd:string</para>
    ///   <para>rdfs:label : double bond</para>
    ///   <para>dcterms:description : A double bond is a covalent bond between a pair of atoms in which two pairs of electrons are shared.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010499">sio:SIO_010499</a>
    /// </summary>
    let SIO_010499 = _prefixId.prefix "SIO_010499"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010500^^xsd:string</para>
    ///   <para>rdfs:label : triple bond</para>
    ///   <para>dcterms:description : A triple bond is a covalent bond between a pair of atoms in which three pairs of electrons are shared.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010500">sio:SIO_010500</a>
    /// </summary>
    let SIO_010500 = _prefixId.prefix "SIO_010500"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010501^^xsd:string</para>
    ///   <para>rdfs:label : aromatic bond</para>
    ///   <para>dcterms:description : An aromatic bond is an interaction between a set of atoms across which pairs of electrons are shared.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010501">sio:SIO_010501</a>
    /// </summary>
    let SIO_010501 = _prefixId.prefix "SIO_010501"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010502^^xsd:string</para>
    ///   <para>rdfs:label : disulfide bond</para>
    ///   <para>dcterms:description : A disulfide bond is a bond between two sulfur atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010502">sio:SIO_010502</a>
    /// </summary>
    let SIO_010502 = _prefixId.prefix "SIO_010502"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010503^^xsd:string</para>
    ///   <para>rdfs:label : dipole-dipole interaction</para>
    ///   <para>dcterms:description : A dipole-dipole interaction is a weak submolecular interaction between strongly electronegative atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010503">sio:SIO_010503</a>
    /// </summary>
    let SIO_010503 = _prefixId.prefix "SIO_010503"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010504^^xsd:string</para>
    ///   <para>rdfs:label : van der Waals interaction</para>
    ///   <para>dcterms:description : van der Waals' interaction is an a weak submolecular interaction between an instantaneous dipole and induced dipole.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010504">sio:SIO_010504</a>
    /// </summary>
    let SIO_010504 = _prefixId.prefix "SIO_010504"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010505^^xsd:string</para>
    ///   <para>rdfs:label : base stack</para>
    ///   <para>dcterms:description : A base stack is a stabilizing interaction of DNA and RNA between spatially adjacent nucleotides and possibly involving London dispersion, hydrophobic and electrostatic forces.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010505">sio:SIO_010505</a>
    /// </summary>
    let SIO_010505 = _prefixId.prefix "SIO_010505"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010506^^xsd:string</para>
    ///   <para>rdfs:label : molecular complex</para>
    ///   <para>dcterms:description : A molecular complex is a chemical complex composed of weakly interacting molecular entities, and excludes bulk solvent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010506">sio:SIO_010506</a>
    /// </summary>
    let SIO_010506 = _prefixId.prefix "SIO_010506"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010507^^xsd:string</para>
    ///   <para>rdfs:label : acid-base reaction</para>
    ///   <para>dcterms:description : An acid-base reaction is a chemical reaction between an acid and a base.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010507">sio:SIO_010507</a>
    /// </summary>
    let SIO_010507 = _prefixId.prefix "SIO_010507"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010508^^xsd:string</para>
    ///   <para>rdfs:label : catalyzed reaction</para>
    ///   <para>dcterms:description : A catalyzed reaction is a chemical reaction that is facilitated by a catalyst.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010508">sio:SIO_010508</a>
    /// </summary>
    let SIO_010508 = _prefixId.prefix "SIO_010508"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010509^^xsd:string</para>
    ///   <para>rdfs:label : redox reaction</para>
    ///   <para>dcterms:description : A redox reaction is a chemical reaction in which there is a net movement of electrons from one reactant to another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010509">sio:SIO_010509</a>
    /// </summary>
    let SIO_010509 = _prefixId.prefix "SIO_010509"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010510^^xsd:string</para>
    ///   <para>rdfs:label : inorganic reaction</para>
    ///   <para>dcterms:description : An inorganic reaction is a chemical reaction that involves the transformation of inorganic molecules.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010510">sio:SIO_010510</a>
    /// </summary>
    let SIO_010510 = _prefixId.prefix "SIO_010510"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010511^^xsd:string</para>
    ///   <para>rdfs:label : decomposition reaction</para>
    ///   <para>dcterms:description : A decomposition reaction is an inorganic reaction in which molecule is fragmented into submolecules or atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010511">sio:SIO_010511</a>
    /// </summary>
    let SIO_010511 = _prefixId.prefix "SIO_010511"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010512^^xsd:string</para>
    ///   <para>rdfs:label : displacement reaction</para>
    ///   <para>dcterms:description : A displacement reaction is an inorganic reaction in which a elementary substance displaces and sets free a constituent atom from a molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010512">sio:SIO_010512</a>
    /// </summary>
    let SIO_010512 = _prefixId.prefix "SIO_010512"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010513^^xsd:string</para>
    ///   <para>rdfs:label : double displacement reaction</para>
    ///   <para>dcterms:description : A double displacement reaction is a displacement reaction in which two molecules swap ions, effectively displacing each other to form two new molecules.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010513">sio:SIO_010513</a>
    /// </summary>
    let SIO_010513 = _prefixId.prefix "SIO_010513"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010514^^xsd:string</para>
    ///   <para>rdfs:label : single displacement reaction</para>
    ///   <para>dcterms:description : A single displacement reaction where one atom is transferred out of one molecule and into another.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010514">sio:SIO_010514</a>
    /// </summary>
    let SIO_010514 = _prefixId.prefix "SIO_010514"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010515^^xsd:string</para>
    ///   <para>rdfs:label : synthesis reaction</para>
    ///   <para>dcterms:description : A synthesis reaction is an inorganic reaction in which two or more molecules are chemically bonded together to produce a single product.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010515">sio:SIO_010515</a>
    /// </summary>
    let SIO_010515 = _prefixId.prefix "SIO_010515"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010516^^xsd:string</para>
    ///   <para>rdfs:label : organic reaction</para>
    ///   <para>dcterms:description : An organic reaction is a chemical reaction involving at least one organic molecule.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010516">sio:SIO_010516</a>
    /// </summary>
    let SIO_010516 = _prefixId.prefix "SIO_010516"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010517^^xsd:string</para>
    ///   <para>rdfs:label : isomerization reaction</para>
    ///   <para>dcterms:description : An isomerization reaction is a chemical reaction in which a molecule is converted into its isomer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010517">sio:SIO_010517</a>
    /// </summary>
    let SIO_010517 = _prefixId.prefix "SIO_010517"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010518^^xsd:string</para>
    ///   <para>rdfs:label : addition reaction</para>
    ///   <para>dcterms:description : An addition reaction is an organic reaction where two or more molecules combine to form a larger one. Addition reactions are limited to chemical compounds that have multiply-bonded atoms:
    ///     * Molecules with carbon-carbon double bonds or triple bonds
    ///     * Molecules with carbon - hetero double bonds like C=O or C=N</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010518">sio:SIO_010518</a>
    /// </summary>
    let SIO_010518 = _prefixId.prefix "SIO_010518"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010519^^xsd:string</para>
    ///   <para>rdfs:label : polar addition reaction</para>
    ///   <para>dcterms:description : A polar addition reaction is an addition reaction involving polar residues.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010519">sio:SIO_010519</a>
    /// </summary>
    let SIO_010519 = _prefixId.prefix "SIO_010519"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010520^^xsd:string</para>
    ///   <para>rdfs:label : non-polar addition reaction</para>
    ///   <para>dcterms:description : A non-polar addition reaction is an addition reaction involving non-polar residues.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010520">sio:SIO_010520</a>
    /// </summary>
    let SIO_010520 = _prefixId.prefix "SIO_010520"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010521^^xsd:string</para>
    ///   <para>rdfs:label : free radical addition</para>
    ///   <para>dcterms:description : A free radical addition is a non-polar addition reaction involving free radicals.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010521">sio:SIO_010521</a>
    /// </summary>
    let SIO_010521 = _prefixId.prefix "SIO_010521"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010522^^xsd:string</para>
    ///   <para>rdfs:label : nucleophilic addition reaction</para>
    ///   <para>dcterms:description : A nucleophilic addition reaction is an addition reaction where a pi bond is removed by the creation of two new covalent bonds by the addition from a nucleophile.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010522">sio:SIO_010522</a>
    /// </summary>
    let SIO_010522 = _prefixId.prefix "SIO_010522"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010523^^xsd:string</para>
    ///   <para>rdfs:label : electrophilic addition reaction</para>
    ///   <para>dcterms:description : An electrophilic addition reaction is a polar addition reaction where a pi bond is removed by the creation of two new covalent bonds.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010523">sio:SIO_010523</a>
    /// </summary>
    let SIO_010523 = _prefixId.prefix "SIO_010523"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010525^^xsd:string</para>
    ///   <para>rdfs:label : biochemical pathway</para>
    ///   <para>dcterms:description : A biochemical pathway specifies a series of biochemical modifications and transformations towards achieving some biological outcome.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010525">sio:SIO_010525</a>
    /// </summary>
    let SIO_010525 = _prefixId.prefix "SIO_010525"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010526^^xsd:string</para>
    ///   <para>rdfs:label : chemical reaction pathway</para>
    ///   <para>dcterms:description : A chemical reaction pathway specifies a series of chemical reactions towards producing some chemical product.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010526">sio:SIO_010526</a>
    /// </summary>
    let SIO_010526 = _prefixId.prefix "SIO_010526"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010527^^xsd:string</para>
    ///   <para>rdfs:label : chemical synthesis pathway</para>
    ///   <para>dcterms:description : A chemical synthesis pathway is a pathway involved in the assembly of a chemical.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010527">sio:SIO_010527</a>
    /// </summary>
    let SIO_010527 = _prefixId.prefix "SIO_010527"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010528^^xsd:string</para>
    ///   <para>rdfs:label : chemical degradation pathway</para>
    ///   <para>dcterms:description : A chemical degradation pathway is a pathway involved in the disassembly of a chemical.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010528">sio:SIO_010528</a>
    /// </summary>
    let SIO_010528 = _prefixId.prefix "SIO_010528"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010530^^xsd:string</para>
    ///   <para>rdfs:label : 3d structure model</para>
    ///   <para>dcterms:description : A 3D structure model is a representation of the spatial arrangement of one or more chemical entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010530">sio:SIO_010530</a>
    /// </summary>
    let SIO_010530 = _prefixId.prefix "SIO_010530"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010531^^xsd:string</para>
    ///   <para>rdfs:label : sequence profile</para>
    ///   <para>dcterms:description : A sequence profile is provides the preference for a character at each position of an abstracted sequence.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010531">sio:SIO_010531</a>
    /// </summary>
    let SIO_010531 = _prefixId.prefix "SIO_010531"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010532^^xsd:string</para>
    ///   <para>rdfs:label : metabolic pathway</para>
    ///   <para>dcterms:description : A metabolic pathway is a series of biochemical reactions that begins with one or more substrates and ends with one or more products.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010532">sio:SIO_010532</a>
    /// </summary>
    let SIO_010532 = _prefixId.prefix "SIO_010532"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010533^^xsd:string</para>
    ///   <para>rdfs:label : regulatory pathway</para>
    ///   <para>dcterms:description : A regulatory pathway is a series of biochemical reactions that lead to the increase or decrease of activity of participating molecular components.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010533">sio:SIO_010533</a>
    /// </summary>
    let SIO_010533 = _prefixId.prefix "SIO_010533"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010673^^xsd:string</para>
    ///   <para>rdfs:label : medical history</para>
    ///   <para>dcterms:description : A medical history is a record of the events of a recipient of medical care.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010673">sio:SIO_010673</a>
    /// </summary>
    let SIO_010673 = _prefixId.prefix "SIO_010673"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010674^^xsd:string</para>
    ///   <para>rdfs:label : binary compound</para>
    ///   <para>dcterms:description : A binary compound is a mereological maximum sum of two kinds of weakly connected entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010674">sio:SIO_010674</a>
    /// </summary>
    let SIO_010674 = _prefixId.prefix "SIO_010674"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010775^^xsd:string</para>
    ///   <para>rdfs:label : stereoisomer</para>
    ///   <para>dcterms:description : A stereoisomer is an isomer in which the atomic connectivity is the same, but differs in its spatial arrangement of atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010775">sio:SIO_010775</a>
    /// </summary>
    let SIO_010775 = _prefixId.prefix "SIO_010775"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010776^^xsd:string</para>
    ///   <para>rdfs:label : diastereomer</para>
    ///   <para>dcterms:description : A diastereomer is a stereoisomer that is not a mirror image of its isomer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010776">sio:SIO_010776</a>
    /// </summary>
    let SIO_010776 = _prefixId.prefix "SIO_010776"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010777^^xsd:string</para>
    ///   <para>rdfs:label : enantiomer</para>
    ///   <para>dcterms:description : An enantiomer is a stereoisomer that is a mirror image of its isomer.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010777">sio:SIO_010777</a>
    /// </summary>
    let SIO_010777 = _prefixId.prefix "SIO_010777"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010778^^xsd:string</para>
    ///   <para>rdfs:label : optical isomer</para>
    ///   <para>dcterms:description : An optical isomer is a stereoisomer that rotates the plane of polarization of a beam of plane polarized light.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010778">sio:SIO_010778</a>
    /// </summary>
    let SIO_010778 = _prefixId.prefix "SIO_010778"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010779^^xsd:string</para>
    ///   <para>rdfs:label : structural isomer</para>
    ///   <para>dcterms:description : A structural isomer is an isomer in which the atoms are joined together in different ways.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010779">sio:SIO_010779</a>
    /// </summary>
    let SIO_010779 = _prefixId.prefix "SIO_010779"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010780^^xsd:string</para>
    ///   <para>rdfs:label : ring</para>
    ///   <para>dcterms:description : A ring is a submolecule with a circular topology.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010780">sio:SIO_010780</a>
    /// </summary>
    let SIO_010780 = _prefixId.prefix "SIO_010780"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010781^^xsd:string</para>
    ///   <para>rdfs:label : aromatic ring</para>
    ///   <para>dcterms:description : An aromatic ring is a ring in which the electrons are delocalized across all atoms in the ring.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010781">sio:SIO_010781</a>
    /// </summary>
    let SIO_010781 = _prefixId.prefix "SIO_010781"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010782^^xsd:string</para>
    ///   <para>rdfs:label : heterocyclic ring</para>
    ///   <para>dcterms:description : A heterocyclic ring is a ring containing a hetero atom.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010782">sio:SIO_010782</a>
    /// </summary>
    let SIO_010782 = _prefixId.prefix "SIO_010782"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010783^^xsd:string</para>
    ///   <para>rdfs:label : homocyclic ring</para>
    ///   <para>dcterms:description : A homocyclic ring is a ring where the atoms are of a single type.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010783">sio:SIO_010783</a>
    /// </summary>
    let SIO_010783 = _prefixId.prefix "SIO_010783"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010784^^xsd:string</para>
    ///   <para>rdfs:label : ionic compound</para>
    ///   <para>dcterms:description : An ionic compound is a mereological maximal sum of weakly connected paired positive and negative ions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010784">sio:SIO_010784</a>
    /// </summary>
    let SIO_010784 = _prefixId.prefix "SIO_010784"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010785^^xsd:string</para>
    ///   <para>rdfs:label : allotrope</para>
    ///   <para>dcterms:description : An allotrope is a structural variant of a chemical element.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010785">sio:SIO_010785</a>
    /// </summary>
    let SIO_010785 = _prefixId.prefix "SIO_010785"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010786^^xsd:string</para>
    ///   <para>rdfs:label : carbon allotrope</para>
    ///   <para>dcterms:description : A carbon allotrope is a chemical substance composed of carbon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010786">sio:SIO_010786</a>
    /// </summary>
    let SIO_010786 = _prefixId.prefix "SIO_010786"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010787^^xsd:string</para>
    ///   <para>rdfs:label : diamond</para>
    ///   <para>dcterms:description : diamond is a carbon allotrope in which each carbon atom in diamond is covalently bonded to four other carbons in a tetrahedron. These tetrahedrons together form a 3-dimensional network of puckered six-membered rings of atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010787">sio:SIO_010787</a>
    /// </summary>
    let SIO_010787 = _prefixId.prefix "SIO_010787"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010788^^xsd:string</para>
    ///   <para>rdfs:label : graphite</para>
    ///   <para>dcterms:description : graphite is an allotrope of carbon which is a conductor, and is the most stable form of solid carbon.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010788">sio:SIO_010788</a>
    /// </summary>
    let SIO_010788 = _prefixId.prefix "SIO_010788"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010789^^xsd:string</para>
    ///   <para>rdfs:label : fullerene</para>
    ///   <para>dcterms:description : fullerene is a carbon allotrope which take the form of a hollow sphere, ellipsoid, or tube.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010789">sio:SIO_010789</a>
    /// </summary>
    let SIO_010789 = _prefixId.prefix "SIO_010789"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010790^^xsd:string</para>
    ///   <para>rdfs:label : aggregated carbon nanorods</para>
    ///   <para>dcterms:description : aggregate of carbon nanorods is an allotrope of carbon considered to be the least compressible material known, as measured by its isothermal bulk modulus; aggregated diamond nanorods have a modulus of 491 gigapascals (GPa), while a conventional diamond has a modulus of 442 GPa. ADNRs are also 0.3% denser than regular diamond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010790">sio:SIO_010790</a>
    /// </summary>
    let SIO_010790 = _prefixId.prefix "SIO_010790"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010791^^xsd:string</para>
    ///   <para>rdfs:label : amorphous carbon</para>
    ///   <para>dcterms:description : amorphous carbon is an allotrope of carbon that does not have any crystalline structure. As with all glassy materials, some short-range order can be observed, but there is no long-range pattern of atomic positions.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010791">sio:SIO_010791</a>
    /// </summary>
    let SIO_010791 = _prefixId.prefix "SIO_010791"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010792^^xsd:string</para>
    ///   <para>rdfs:label : carbon nanofoam</para>
    ///   <para>dcterms:description : carbon nanofoam is an allotrope of carbon that consists of a low-density cluster-assembly of carbon atoms strung together in a loose three-dimensional web. Each cluster is about 6 nanometers wide and consists of about 4000 carbon atoms linked in graphite-like sheets that are given negative curvature by the inclusion of heptagons among the regular hexagonal pattern.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010792">sio:SIO_010792</a>
    /// </summary>
    let SIO_010792 = _prefixId.prefix "SIO_010792"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010793^^xsd:string</para>
    ///   <para>rdfs:label : chaoite</para>
    ///   <para>dcterms:description : chaoite is an allotrope of carbon that is slightly harder than graphite with a reflection colour of grey to white.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010793">sio:SIO_010793</a>
    /// </summary>
    let SIO_010793 = _prefixId.prefix "SIO_010793"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010794^^xsd:string</para>
    ///   <para>rdfs:label : glassy carbon</para>
    ///   <para>dcterms:description : glassy carbon is an allotrope of carbon which is widely used as an electrode material in electrochemistry, as well as for high temperature crucibles and as a component of some prosthetic devices.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010794">sio:SIO_010794</a>
    /// </summary>
    let SIO_010794 = _prefixId.prefix "SIO_010794"
    /// <summary>
    ///   <para>dc11:identifier : SIO_010795^^xsd:string</para>
    ///   <para>rdfs:label : ionsdaleite</para>
    ///   <para>dcterms:description : ionsdaleite is a hexagonal allotrope of the carbon allotrope diamond.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_010795">sio:SIO_010795</a>
    /// </summary>
    let SIO_010795 = _prefixId.prefix "SIO_010795"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011000^^xsd:string</para>
    ///   <para>rdfs:label : boron atom</para>
    ///   <para>sio:seeAlso : CHEBI:27560^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011000">sio:SIO_011000</a>
    /// </summary>
    let SIO_011000 = _prefixId.prefix "SIO_011000"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011001^^xsd:string</para>
    ///   <para>rdfs:label : carbon atom</para>
    ///   <para>sio:seeAlso : CHEBI:27594^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011001">sio:SIO_011001</a>
    /// </summary>
    let SIO_011001 = _prefixId.prefix "SIO_011001"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011002^^xsd:string</para>
    ///   <para>rdfs:label : hydrogen atom</para>
    ///   <para>sio:seeAlso : CHEBI:49637^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011002">sio:SIO_011002</a>
    /// </summary>
    let SIO_011002 = _prefixId.prefix "SIO_011002"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011003^^xsd:string</para>
    ///   <para>rdfs:label : helium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30217^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011003">sio:SIO_011003</a>
    /// </summary>
    let SIO_011003 = _prefixId.prefix "SIO_011003"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011004^^xsd:string</para>
    ///   <para>rdfs:label : lithium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30145^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011004">sio:SIO_011004</a>
    /// </summary>
    let SIO_011004 = _prefixId.prefix "SIO_011004"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011005^^xsd:string</para>
    ///   <para>rdfs:label : beryllium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30501^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011005">sio:SIO_011005</a>
    /// </summary>
    let SIO_011005 = _prefixId.prefix "SIO_011005"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011006^^xsd:string</para>
    ///   <para>rdfs:label : nitrogen atom</para>
    ///   <para>sio:seeAlso : CHEBI:25555^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011006">sio:SIO_011006</a>
    /// </summary>
    let SIO_011006 = _prefixId.prefix "SIO_011006"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011007^^xsd:string</para>
    ///   <para>rdfs:label : oxygen atom</para>
    ///   <para>sio:seeAlso : CHEBI:25805^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011007">sio:SIO_011007</a>
    /// </summary>
    let SIO_011007 = _prefixId.prefix "SIO_011007"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011008^^xsd:string</para>
    ///   <para>rdfs:label : fluorine atom</para>
    ///   <para>sio:seeAlso : CHEBI:24061^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011008">sio:SIO_011008</a>
    /// </summary>
    let SIO_011008 = _prefixId.prefix "SIO_011008"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011009^^xsd:string</para>
    ///   <para>rdfs:label : neon atom</para>
    ///   <para>sio:seeAlso : CHEBI:33310^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011009">sio:SIO_011009</a>
    /// </summary>
    let SIO_011009 = _prefixId.prefix "SIO_011009"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011010^^xsd:string</para>
    ///   <para>rdfs:label : sodium atom</para>
    ///   <para>sio:seeAlso : CHEBI:26708^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011010">sio:SIO_011010</a>
    /// </summary>
    let SIO_011010 = _prefixId.prefix "SIO_011010"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011011^^xsd:string</para>
    ///   <para>rdfs:label : magnesium atom</para>
    ///   <para>sio:seeAlso : CHEBI:25107^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011011">sio:SIO_011011</a>
    /// </summary>
    let SIO_011011 = _prefixId.prefix "SIO_011011"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011012^^xsd:string</para>
    ///   <para>rdfs:label : aluminium atom</para>
    ///   <para>sio:seeAlso : CHEBI:28984^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011012">sio:SIO_011012</a>
    /// </summary>
    let SIO_011012 = _prefixId.prefix "SIO_011012"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011013^^xsd:string</para>
    ///   <para>rdfs:label : silicon atom</para>
    ///   <para>sio:seeAlso : CHEBI:27573^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011013">sio:SIO_011013</a>
    /// </summary>
    let SIO_011013 = _prefixId.prefix "SIO_011013"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011014^^xsd:string</para>
    ///   <para>rdfs:label : phosphorus atom</para>
    ///   <para>sio:seeAlso : CHEBI:28659^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011014">sio:SIO_011014</a>
    /// </summary>
    let SIO_011014 = _prefixId.prefix "SIO_011014"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011015^^xsd:string</para>
    ///   <para>rdfs:label : sulfur atom</para>
    ///   <para>sio:seeAlso : CHEBI:26833^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011015">sio:SIO_011015</a>
    /// </summary>
    let SIO_011015 = _prefixId.prefix "SIO_011015"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011016^^xsd:string</para>
    ///   <para>rdfs:label : chlorine atom</para>
    ///   <para>sio:seeAlso : CHEBI:23116^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011016">sio:SIO_011016</a>
    /// </summary>
    let SIO_011016 = _prefixId.prefix "SIO_011016"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011017^^xsd:string</para>
    ///   <para>rdfs:label : argon atom</para>
    ///   <para>sio:seeAlso : CHEBI:49475^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011017">sio:SIO_011017</a>
    /// </summary>
    let SIO_011017 = _prefixId.prefix "SIO_011017"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011018^^xsd:string</para>
    ///   <para>rdfs:label : potassium atom</para>
    ///   <para>sio:seeAlso : CHEBI:26216^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011018">sio:SIO_011018</a>
    /// </summary>
    let SIO_011018 = _prefixId.prefix "SIO_011018"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011019^^xsd:string</para>
    ///   <para>rdfs:label : calcium atom</para>
    ///   <para>sio:seeAlso : CHEBI:22984^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011019">sio:SIO_011019</a>
    /// </summary>
    let SIO_011019 = _prefixId.prefix "SIO_011019"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011020^^xsd:string</para>
    ///   <para>rdfs:label : scandium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33330^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011020">sio:SIO_011020</a>
    /// </summary>
    let SIO_011020 = _prefixId.prefix "SIO_011020"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011021^^xsd:string</para>
    ///   <para>rdfs:label : titanium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33341^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011021">sio:SIO_011021</a>
    /// </summary>
    let SIO_011021 = _prefixId.prefix "SIO_011021"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011022^^xsd:string</para>
    ///   <para>rdfs:label : vanadium atom</para>
    ///   <para>sio:seeAlso : CHEBI:27698^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011022">sio:SIO_011022</a>
    /// </summary>
    let SIO_011022 = _prefixId.prefix "SIO_011022"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011023^^xsd:string</para>
    ///   <para>rdfs:label : chromium atom</para>
    ///   <para>sio:seeAlso : CHEBI:28073^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011023">sio:SIO_011023</a>
    /// </summary>
    let SIO_011023 = _prefixId.prefix "SIO_011023"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011024^^xsd:string</para>
    ///   <para>rdfs:label : manganese atom</para>
    ///   <para>sio:seeAlso : CHEBI:18291^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011024">sio:SIO_011024</a>
    /// </summary>
    let SIO_011024 = _prefixId.prefix "SIO_011024"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011025^^xsd:string</para>
    ///   <para>rdfs:label : iron atom</para>
    ///   <para>sio:seeAlso : CHEBI:18248^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011025">sio:SIO_011025</a>
    /// </summary>
    let SIO_011025 = _prefixId.prefix "SIO_011025"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011026^^xsd:string</para>
    ///   <para>rdfs:label : cobalt atom</para>
    ///   <para>sio:seeAlso : CHEBI:27638^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011026">sio:SIO_011026</a>
    /// </summary>
    let SIO_011026 = _prefixId.prefix "SIO_011026"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011027^^xsd:string</para>
    ///   <para>rdfs:label : nickel atom</para>
    ///   <para>sio:seeAlso : CHEBI:28112^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011027">sio:SIO_011027</a>
    /// </summary>
    let SIO_011027 = _prefixId.prefix "SIO_011027"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011028^^xsd:string</para>
    ///   <para>rdfs:label : copper atom</para>
    ///   <para>sio:seeAlso : CHEBI:28694^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011028">sio:SIO_011028</a>
    /// </summary>
    let SIO_011028 = _prefixId.prefix "SIO_011028"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011029^^xsd:string</para>
    ///   <para>rdfs:label : zinc atom</para>
    ///   <para>sio:seeAlso : CHEBI:27363^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011029">sio:SIO_011029</a>
    /// </summary>
    let SIO_011029 = _prefixId.prefix "SIO_011029"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011030^^xsd:string</para>
    ///   <para>rdfs:label : gallium atom</para>
    ///   <para>sio:seeAlso : CHEBI:49631^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011030">sio:SIO_011030</a>
    /// </summary>
    let SIO_011030 = _prefixId.prefix "SIO_011030"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011031^^xsd:string</para>
    ///   <para>rdfs:label : germanium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30441^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011031">sio:SIO_011031</a>
    /// </summary>
    let SIO_011031 = _prefixId.prefix "SIO_011031"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011032^^xsd:string</para>
    ///   <para>rdfs:label : arsenic atom</para>
    ///   <para>sio:seeAlso : CHEBI:27563^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011032">sio:SIO_011032</a>
    /// </summary>
    let SIO_011032 = _prefixId.prefix "SIO_011032"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011033^^xsd:string</para>
    ///   <para>rdfs:label : selenium atom</para>
    ///   <para>sio:seeAlso : CHEBI:27568^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011033">sio:SIO_011033</a>
    /// </summary>
    let SIO_011033 = _prefixId.prefix "SIO_011033"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011034^^xsd:string</para>
    ///   <para>rdfs:label : bromine atom</para>
    ///   <para>sio:seeAlso : CHEBI:22927^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011034">sio:SIO_011034</a>
    /// </summary>
    let SIO_011034 = _prefixId.prefix "SIO_011034"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011035^^xsd:string</para>
    ///   <para>rdfs:label : krypton atom</para>
    ///   <para>sio:seeAlso : CHEBI:49696^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011035">sio:SIO_011035</a>
    /// </summary>
    let SIO_011035 = _prefixId.prefix "SIO_011035"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011036^^xsd:string</para>
    ///   <para>rdfs:label : rubidium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33322^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011036">sio:SIO_011036</a>
    /// </summary>
    let SIO_011036 = _prefixId.prefix "SIO_011036"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011037^^xsd:string</para>
    ///   <para>rdfs:label : strontium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33324^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011037">sio:SIO_011037</a>
    /// </summary>
    let SIO_011037 = _prefixId.prefix "SIO_011037"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011038^^xsd:string</para>
    ///   <para>rdfs:label : yttrium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33331^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011038">sio:SIO_011038</a>
    /// </summary>
    let SIO_011038 = _prefixId.prefix "SIO_011038"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011039^^xsd:string</para>
    ///   <para>rdfs:label : zirconium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33342^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011039">sio:SIO_011039</a>
    /// </summary>
    let SIO_011039 = _prefixId.prefix "SIO_011039"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011040^^xsd:string</para>
    ///   <para>rdfs:label : niobium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33344^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011040">sio:SIO_011040</a>
    /// </summary>
    let SIO_011040 = _prefixId.prefix "SIO_011040"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011041^^xsd:string</para>
    ///   <para>rdfs:label : molybdemum atom</para>
    ///   <para>sio:seeAlso : CHEBI:28685^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011041">sio:SIO_011041</a>
    /// </summary>
    let SIO_011041 = _prefixId.prefix "SIO_011041"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011042^^xsd:string</para>
    ///   <para>rdfs:label : technetium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33353^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011042">sio:SIO_011042</a>
    /// </summary>
    let SIO_011042 = _prefixId.prefix "SIO_011042"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011043^^xsd:string</para>
    ///   <para>rdfs:label : ruthenium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30682^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011043">sio:SIO_011043</a>
    /// </summary>
    let SIO_011043 = _prefixId.prefix "SIO_011043"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011044^^xsd:string</para>
    ///   <para>rdfs:label : rhodium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33359^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011044">sio:SIO_011044</a>
    /// </summary>
    let SIO_011044 = _prefixId.prefix "SIO_011044"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011045^^xsd:string</para>
    ///   <para>rdfs:label : palladium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33363^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011045">sio:SIO_011045</a>
    /// </summary>
    let SIO_011045 = _prefixId.prefix "SIO_011045"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011046^^xsd:string</para>
    ///   <para>rdfs:label : silver atom</para>
    ///   <para>sio:seeAlso : CHEBI:30512^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011046">sio:SIO_011046</a>
    /// </summary>
    let SIO_011046 = _prefixId.prefix "SIO_011046"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011047^^xsd:string</para>
    ///   <para>rdfs:label : cadmium atom</para>
    ///   <para>sio:seeAlso : CHEBI:22977^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011047">sio:SIO_011047</a>
    /// </summary>
    let SIO_011047 = _prefixId.prefix "SIO_011047"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011048^^xsd:string</para>
    ///   <para>rdfs:label : indium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30430^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011048">sio:SIO_011048</a>
    /// </summary>
    let SIO_011048 = _prefixId.prefix "SIO_011048"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011049^^xsd:string</para>
    ///   <para>rdfs:label : tin atom</para>
    ///   <para>sio:seeAlso : CHEBI:27007^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011049">sio:SIO_011049</a>
    /// </summary>
    let SIO_011049 = _prefixId.prefix "SIO_011049"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011050^^xsd:string</para>
    ///   <para>rdfs:label : antimony atom</para>
    ///   <para>sio:seeAlso : CHEBI:30513^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011050">sio:SIO_011050</a>
    /// </summary>
    let SIO_011050 = _prefixId.prefix "SIO_011050"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011051^^xsd:string</para>
    ///   <para>rdfs:label : tellurium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30452^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011051">sio:SIO_011051</a>
    /// </summary>
    let SIO_011051 = _prefixId.prefix "SIO_011051"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011052^^xsd:string</para>
    ///   <para>rdfs:label : iodine atom</para>
    ///   <para>sio:seeAlso : CHEBI:24859^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011052">sio:SIO_011052</a>
    /// </summary>
    let SIO_011052 = _prefixId.prefix "SIO_011052"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011053^^xsd:string</para>
    ///   <para>rdfs:label : xenon atom</para>
    ///   <para>sio:seeAlso : CHEBI:49957^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011053">sio:SIO_011053</a>
    /// </summary>
    let SIO_011053 = _prefixId.prefix "SIO_011053"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011054^^xsd:string</para>
    ///   <para>rdfs:label : caesium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30514^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011054">sio:SIO_011054</a>
    /// </summary>
    let SIO_011054 = _prefixId.prefix "SIO_011054"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011055^^xsd:string</para>
    ///   <para>rdfs:label : barium atom</para>
    ///   <para>sio:seeAlso : CHEBI:32594^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011055">sio:SIO_011055</a>
    /// </summary>
    let SIO_011055 = _prefixId.prefix "SIO_011055"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011056^^xsd:string</para>
    ///   <para>rdfs:label : lanthanum atom</para>
    ///   <para>sio:seeAlso : CHEBI:33336^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011056">sio:SIO_011056</a>
    /// </summary>
    let SIO_011056 = _prefixId.prefix "SIO_011056"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011057^^xsd:string</para>
    ///   <para>rdfs:label : hafnium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33343^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011057">sio:SIO_011057</a>
    /// </summary>
    let SIO_011057 = _prefixId.prefix "SIO_011057"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011058^^xsd:string</para>
    ///   <para>rdfs:label : tantalum atom</para>
    ///   <para>sio:seeAlso : CHEBI:33348^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011058">sio:SIO_011058</a>
    /// </summary>
    let SIO_011058 = _prefixId.prefix "SIO_011058"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011059^^xsd:string</para>
    ///   <para>rdfs:label : tungsten atom</para>
    ///   <para>sio:seeAlso : CHEBI:27998^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011059">sio:SIO_011059</a>
    /// </summary>
    let SIO_011059 = _prefixId.prefix "SIO_011059"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011060^^xsd:string</para>
    ///   <para>rdfs:label : rhenium atom</para>
    ///   <para>sio:seeAlso : CHEBI:49882^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011060">sio:SIO_011060</a>
    /// </summary>
    let SIO_011060 = _prefixId.prefix "SIO_011060"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011061^^xsd:string</para>
    ///   <para>rdfs:label : osmium atom</para>
    ///   <para>sio:seeAlso : CHEBI:30687^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011061">sio:SIO_011061</a>
    /// </summary>
    let SIO_011061 = _prefixId.prefix "SIO_011061"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011062^^xsd:string</para>
    ///   <para>rdfs:label : iridium atom</para>
    ///   <para>sio:seeAlso : CHEBI:49666^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011062">sio:SIO_011062</a>
    /// </summary>
    let SIO_011062 = _prefixId.prefix "SIO_011062"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011063^^xsd:string</para>
    ///   <para>rdfs:label : platinum atom</para>
    ///   <para>sio:seeAlso : CHEBI:33364^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011063">sio:SIO_011063</a>
    /// </summary>
    let SIO_011063 = _prefixId.prefix "SIO_011063"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011064^^xsd:string</para>
    ///   <para>rdfs:label : gold atom</para>
    ///   <para>sio:seeAlso : CHEBI:29287^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011064">sio:SIO_011064</a>
    /// </summary>
    let SIO_011064 = _prefixId.prefix "SIO_011064"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011065^^xsd:string</para>
    ///   <para>rdfs:label : mercury atom</para>
    ///   <para>sio:seeAlso : CHEBI:25195^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011065">sio:SIO_011065</a>
    /// </summary>
    let SIO_011065 = _prefixId.prefix "SIO_011065"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011066^^xsd:string</para>
    ///   <para>rdfs:label : thallium atom</para>
    ///   <para>sio:seeAlso : CHEBI:49920^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011066">sio:SIO_011066</a>
    /// </summary>
    let SIO_011066 = _prefixId.prefix "SIO_011066"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011067^^xsd:string</para>
    ///   <para>rdfs:label : lead atom</para>
    ///   <para>sio:seeAlso : CHEBI:25016^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011067">sio:SIO_011067</a>
    /// </summary>
    let SIO_011067 = _prefixId.prefix "SIO_011067"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011068^^xsd:string</para>
    ///   <para>rdfs:label : bismuth atom</para>
    ///   <para>sio:seeAlso : CHEBI:33301^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011068">sio:SIO_011068</a>
    /// </summary>
    let SIO_011068 = _prefixId.prefix "SIO_011068"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011069^^xsd:string</para>
    ///   <para>rdfs:label : polonium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33313^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011069">sio:SIO_011069</a>
    /// </summary>
    let SIO_011069 = _prefixId.prefix "SIO_011069"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011070^^xsd:string</para>
    ///   <para>rdfs:label : astatine atom</para>
    ///   <para>sio:seeAlso : CHEBI:30415^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011070">sio:SIO_011070</a>
    /// </summary>
    let SIO_011070 = _prefixId.prefix "SIO_011070"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011071^^xsd:string</para>
    ///   <para>rdfs:label : radon atom</para>
    ///   <para>sio:seeAlso : CHEBI:33314^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011071">sio:SIO_011071</a>
    /// </summary>
    let SIO_011071 = _prefixId.prefix "SIO_011071"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011072^^xsd:string</para>
    ///   <para>rdfs:label : francium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33323^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011072">sio:SIO_011072</a>
    /// </summary>
    let SIO_011072 = _prefixId.prefix "SIO_011072"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011073^^xsd:string</para>
    ///   <para>rdfs:label : radium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33325^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011073">sio:SIO_011073</a>
    /// </summary>
    let SIO_011073 = _prefixId.prefix "SIO_011073"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011074^^xsd:string</para>
    ///   <para>rdfs:label : actinium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33337^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011074">sio:SIO_011074</a>
    /// </summary>
    let SIO_011074 = _prefixId.prefix "SIO_011074"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011075^^xsd:string</para>
    ///   <para>rdfs:label : rutherfordium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33346^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011075">sio:SIO_011075</a>
    /// </summary>
    let SIO_011075 = _prefixId.prefix "SIO_011075"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011076^^xsd:string</para>
    ///   <para>rdfs:label : dubnium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33349^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011076">sio:SIO_011076</a>
    /// </summary>
    let SIO_011076 = _prefixId.prefix "SIO_011076"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011077^^xsd:string</para>
    ///   <para>rdfs:label : seaborgium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33351^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011077">sio:SIO_011077</a>
    /// </summary>
    let SIO_011077 = _prefixId.prefix "SIO_011077"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011078^^xsd:string</para>
    ///   <para>rdfs:label : bohrium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33355^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011078">sio:SIO_011078</a>
    /// </summary>
    let SIO_011078 = _prefixId.prefix "SIO_011078"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011079^^xsd:string</para>
    ///   <para>rdfs:label : hassium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33357^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011079">sio:SIO_011079</a>
    /// </summary>
    let SIO_011079 = _prefixId.prefix "SIO_011079"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011080^^xsd:string</para>
    ///   <para>rdfs:label : meitnerium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33361^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011080">sio:SIO_011080</a>
    /// </summary>
    let SIO_011080 = _prefixId.prefix "SIO_011080"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011081^^xsd:string</para>
    ///   <para>rdfs:label : darmstadtium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33367^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011081">sio:SIO_011081</a>
    /// </summary>
    let SIO_011081 = _prefixId.prefix "SIO_011081"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011082^^xsd:string</para>
    ///   <para>rdfs:label : roentgenium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33368^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011082">sio:SIO_011082</a>
    /// </summary>
    let SIO_011082 = _prefixId.prefix "SIO_011082"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011083^^xsd:string</para>
    ///   <para>rdfs:label : copernicium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33517^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011083">sio:SIO_011083</a>
    /// </summary>
    let SIO_011083 = _prefixId.prefix "SIO_011083"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011084^^xsd:string</para>
    ///   <para>rdfs:label : unutrium atom</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011084">sio:SIO_011084</a>
    /// </summary>
    let SIO_011084 = _prefixId.prefix "SIO_011084"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011085^^xsd:string</para>
    ///   <para>rdfs:label : ununquadium atom</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011085">sio:SIO_011085</a>
    /// </summary>
    let SIO_011085 = _prefixId.prefix "SIO_011085"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011086^^xsd:string</para>
    ///   <para>rdfs:label : ununpentium atom</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011086">sio:SIO_011086</a>
    /// </summary>
    let SIO_011086 = _prefixId.prefix "SIO_011086"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011087^^xsd:string</para>
    ///   <para>rdfs:label : ununhexium atom</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011087">sio:SIO_011087</a>
    /// </summary>
    let SIO_011087 = _prefixId.prefix "SIO_011087"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011088^^xsd:string</para>
    ///   <para>rdfs:label : ununseptium atom</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011088">sio:SIO_011088</a>
    /// </summary>
    let SIO_011088 = _prefixId.prefix "SIO_011088"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011089^^xsd:string</para>
    ///   <para>rdfs:label : ununoctium atom</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011089">sio:SIO_011089</a>
    /// </summary>
    let SIO_011089 = _prefixId.prefix "SIO_011089"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011090^^xsd:string</para>
    ///   <para>rdfs:label : cerium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33369^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011090">sio:SIO_011090</a>
    /// </summary>
    let SIO_011090 = _prefixId.prefix "SIO_011090"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011091^^xsd:string</para>
    ///   <para>rdfs:label : praseodymium atom</para>
    ///   <para>sio:seeAlso : CHEBI:49828^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011091">sio:SIO_011091</a>
    /// </summary>
    let SIO_011091 = _prefixId.prefix "SIO_011091"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011092^^xsd:string</para>
    ///   <para>rdfs:label : neodymium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33372^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011092">sio:SIO_011092</a>
    /// </summary>
    let SIO_011092 = _prefixId.prefix "SIO_011092"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011093^^xsd:string</para>
    ///   <para>rdfs:label : promethium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33373^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011093">sio:SIO_011093</a>
    /// </summary>
    let SIO_011093 = _prefixId.prefix "SIO_011093"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011094^^xsd:string</para>
    ///   <para>rdfs:label : samarium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33374^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011094">sio:SIO_011094</a>
    /// </summary>
    let SIO_011094 = _prefixId.prefix "SIO_011094"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011095^^xsd:string</para>
    ///   <para>rdfs:label : europium atom</para>
    ///   <para>sio:seeAlso : CHEBI:32999^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011095">sio:SIO_011095</a>
    /// </summary>
    let SIO_011095 = _prefixId.prefix "SIO_011095"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011096^^xsd:string</para>
    ///   <para>rdfs:label : gadolinium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33375^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011096">sio:SIO_011096</a>
    /// </summary>
    let SIO_011096 = _prefixId.prefix "SIO_011096"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011097^^xsd:string</para>
    ///   <para>rdfs:label : terbium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33376^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011097">sio:SIO_011097</a>
    /// </summary>
    let SIO_011097 = _prefixId.prefix "SIO_011097"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011098^^xsd:string</para>
    ///   <para>rdfs:label : dysprosium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33377^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011098">sio:SIO_011098</a>
    /// </summary>
    let SIO_011098 = _prefixId.prefix "SIO_011098"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011099^^xsd:string</para>
    ///   <para>rdfs:label : holmium atom</para>
    ///   <para>sio:seeAlso : CHEBI:49648^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011099">sio:SIO_011099</a>
    /// </summary>
    let SIO_011099 = _prefixId.prefix "SIO_011099"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011100^^xsd:string</para>
    ///   <para>rdfs:label : erbium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33379^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011100">sio:SIO_011100</a>
    /// </summary>
    let SIO_011100 = _prefixId.prefix "SIO_011100"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011101^^xsd:string</para>
    ///   <para>rdfs:label : thulium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33380^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011101">sio:SIO_011101</a>
    /// </summary>
    let SIO_011101 = _prefixId.prefix "SIO_011101"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011102^^xsd:string</para>
    ///   <para>rdfs:label : ytterbium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33381^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011102">sio:SIO_011102</a>
    /// </summary>
    let SIO_011102 = _prefixId.prefix "SIO_011102"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011103^^xsd:string</para>
    ///   <para>rdfs:label : lutetium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33382^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011103">sio:SIO_011103</a>
    /// </summary>
    let SIO_011103 = _prefixId.prefix "SIO_011103"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011104^^xsd:string</para>
    ///   <para>rdfs:label : thorium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33385^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011104">sio:SIO_011104</a>
    /// </summary>
    let SIO_011104 = _prefixId.prefix "SIO_011104"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011105^^xsd:string</para>
    ///   <para>rdfs:label : protactinium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33386^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011105">sio:SIO_011105</a>
    /// </summary>
    let SIO_011105 = _prefixId.prefix "SIO_011105"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011106^^xsd:string</para>
    ///   <para>rdfs:label : uranium atom</para>
    ///   <para>sio:seeAlso : CHEBI:27214^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011106">sio:SIO_011106</a>
    /// </summary>
    let SIO_011106 = _prefixId.prefix "SIO_011106"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011107^^xsd:string</para>
    ///   <para>rdfs:label : neptunium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33387^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011107">sio:SIO_011107</a>
    /// </summary>
    let SIO_011107 = _prefixId.prefix "SIO_011107"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011108^^xsd:string</para>
    ///   <para>rdfs:label : plutonium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33388^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011108">sio:SIO_011108</a>
    /// </summary>
    let SIO_011108 = _prefixId.prefix "SIO_011108"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011109^^xsd:string</para>
    ///   <para>rdfs:label : americium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33389^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011109">sio:SIO_011109</a>
    /// </summary>
    let SIO_011109 = _prefixId.prefix "SIO_011109"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011110^^xsd:string</para>
    ///   <para>rdfs:label : curium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33390^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011110">sio:SIO_011110</a>
    /// </summary>
    let SIO_011110 = _prefixId.prefix "SIO_011110"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011111^^xsd:string</para>
    ///   <para>rdfs:label : berkelium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33391^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011111">sio:SIO_011111</a>
    /// </summary>
    let SIO_011111 = _prefixId.prefix "SIO_011111"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011112^^xsd:string</para>
    ///   <para>rdfs:label : californium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33392^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011112">sio:SIO_011112</a>
    /// </summary>
    let SIO_011112 = _prefixId.prefix "SIO_011112"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011113^^xsd:string</para>
    ///   <para>rdfs:label : einsteinium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33393^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011113">sio:SIO_011113</a>
    /// </summary>
    let SIO_011113 = _prefixId.prefix "SIO_011113"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011114^^xsd:string</para>
    ///   <para>rdfs:label : fermium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33394^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011114">sio:SIO_011114</a>
    /// </summary>
    let SIO_011114 = _prefixId.prefix "SIO_011114"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011115^^xsd:string</para>
    ///   <para>rdfs:label : mendelevium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33395^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011115">sio:SIO_011115</a>
    /// </summary>
    let SIO_011115 = _prefixId.prefix "SIO_011115"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011116^^xsd:string</para>
    ///   <para>rdfs:label : nobelium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33396^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011116">sio:SIO_011116</a>
    /// </summary>
    let SIO_011116 = _prefixId.prefix "SIO_011116"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011117^^xsd:string</para>
    ///   <para>rdfs:label : lawrencium atom</para>
    ///   <para>sio:seeAlso : CHEBI:33397^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011117">sio:SIO_011117</a>
    /// </summary>
    let SIO_011117 = _prefixId.prefix "SIO_011117"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011118^^xsd:string</para>
    ///   <para>rdfs:label : covalent bond</para>
    ///   <para>sio:seeAlso : CHEMINF:000063^^xsd:string</para>
    ///   <para>dcterms:description : A covalent bond is a strong submolecular interaction between atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011118">sio:SIO_011118</a>
    /// </summary>
    let SIO_011118 = _prefixId.prefix "SIO_011118"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011119^^xsd:string</para>
    ///   <para>rdfs:label : biomolecular structure descriptor</para>
    ///   <para>dcterms:description : A biomolecular structure descriptor is structure description for organic compounds.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011119">sio:SIO_011119</a>
    /// </summary>
    let SIO_011119 = _prefixId.prefix "SIO_011119"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011120^^xsd:string</para>
    ///   <para>rdfs:label : molecular structure file</para>
    ///   <para>dcterms:description : A molecular structure file is a file that contains a description of molecular structure.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011120">sio:SIO_011120</a>
    /// </summary>
    let SIO_011120 = _prefixId.prefix "SIO_011120"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011121^^xsd:string</para>
    ///   <para>rdfs:label : molecular structure descriptor</para>
    ///   <para>sio:seeAlso : CHEMINF:000085^^xsd:string</para>
    ///   <para>dcterms:description : molecular structure descriptor is data that describes some aspect of the molecular structure (composition) and is about some chemical entity.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011121">sio:SIO_011121</a>
    /// </summary>
    let SIO_011121 = _prefixId.prefix "SIO_011121"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011123^^xsd:string</para>
    ///   <para>rdfs:label : chemical data</para>
    ///   <para>sio:seeAlso : CHEMINF:000123^^xsd:string</para>
    ///   <para>dcterms:description : A chemical datum is a scientific data item which conforms to some specification, either for how it is calculated or for how it is measured, and is commonly used in the domain of chemistry to name and differentiate different numeric properties (both calculated and measured) which are about chemical entities.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011123">sio:SIO_011123</a>
    /// </summary>
    let SIO_011123 = _prefixId.prefix "SIO_011123"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011125^^xsd:string</para>
    ///   <para>rdfs:label : molecule</para>
    ///   <para>sio:seeAlso : CHEBI:23367^^xsd:string</para>
    ///   <para>dcterms:description : A molecule is the mereological maximal sum of a collection of covalently bonded atoms.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011125">sio:SIO_011125</a>
    /// </summary>
    let SIO_011125 = _prefixId.prefix "SIO_011125"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011126^^xsd:string</para>
    ///   <para>rdfs:label : chemical substance</para>
    ///   <para>sio:seeAlso : CHEMINF:440533^^xsd:string</para>
    ///   <para>dcterms:description : A chemical substance is a chemical complex of weakly interacting molecular entities, and may include bulk solvent.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011126">sio:SIO_011126</a>
    /// </summary>
    let SIO_011126 = _prefixId.prefix "SIO_011126"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011130^^xsd:string</para>
    ///   <para>rdfs:label : PDB file</para>
    ///   <para>dcterms:description : A PDB file is a molecular structure file specified by the Protein DataBank (PDB).</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011130">sio:SIO_011130</a>
    /// </summary>
    let SIO_011130 = _prefixId.prefix "SIO_011130"
    /// <summary>
    ///   <para>dc11:identifier : SIO_011131^^xsd:string</para>
    ///   <para>rdfs:label : collection of 3d molecular structure models</para>
    ///   <para>dcterms:description : A collection of 3D molecular structure models is just that.</para>
    ///   <a href="http://semanticscience.org/resource/SIO_011131">sio:SIO_011131</a>
    /// </summary>
    let SIO_011131 = _prefixId.prefix "SIO_011131"
    /// <summary>
    ///   <para>dc11:identifier : broaderThan^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/broaderThan">sio:broaderThan</a>
    /// </summary>
    let broaderThan = _prefixId.prefix "broaderThan"
    /// <summary>
    ///   <para>dc11:identifier : equivalentTo^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/equivalentTo">sio:equivalentTo</a>
    /// </summary>
    let equivalentTo = _prefixId.prefix "equivalentTo"
    /// <summary>
    ///   <para>dc11:identifier : example^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/example">sio:example</a>
    /// </summary>
    let example = _prefixId.prefix "example"
    /// <summary>
    ///   <para>dc11:identifier : hasSynonym^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/hasSynonym">sio:hasSynonym</a>
    /// </summary>
    let hasSynonym = _prefixId.prefix "hasSynonym"
    /// <summary>
    ///   <para>dc11:identifier : narrowerThan^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/narrowerThan">sio:narrowerThan</a>
    /// </summary>
    let narrowerThan = _prefixId.prefix "narrowerThan"
    /// <summary>
    ///   <para>dc11:identifier : seeAlso^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/seeAlso">sio:seeAlso</a>
    /// </summary>
    let seeAlso = _prefixId.prefix "seeAlso"
    /// <summary>
    ///   <para>dc11:identifier : similarTo^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/similarTo">sio:similarTo</a>
    /// </summary>
    let similarTo = _prefixId.prefix "similarTo"
    /// <summary>
    ///   <para>dc11:identifier : subset^^xsd:string</para>
    ///   <a href="http://semanticscience.org/resource/subset">sio:subset</a>
    /// </summary>
    let subset = _prefixId.prefix "subset"
