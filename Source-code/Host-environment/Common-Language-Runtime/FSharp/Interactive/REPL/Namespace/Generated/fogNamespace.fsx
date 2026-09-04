#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module fog =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/fog#" "fog"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Referenced content</para>
    ///   <para>rdfs:comment : Referenced content of the following geometry descriptions: glTF and OBJ. It contains exactly one link to a texture, separate binary glTF geometry or a OBJ material that is referenced by the main file (resp. .gltf and .obj). The name of the referenced file, as stored in the main file, is connected via a rdfs:label node</para>
    ///   <a href="https://w3id.org/fog#ReferencedContent">fog:ReferencedContent</a>
    /// </summary>
    let ReferencedContent = _prefixId.prefix "ReferencedContent"
    /// <summary>
    ///   <para>rdfs:label : as 3DMO ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the 3DMO ontology. It is strongly adviced to use the more specific subproperty (fog:as3dmo_v1.1)</para>
    ///   <a href="https://w3id.org/fog#as3dmo">fog:as3dmo</a>
    /// </summary>
    let as3dmo = _prefixId.prefix "as3dmo"
    /// <summary>
    ///   <para>rdfs:label : as 3DMO v1.1 ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the 3DMO ontology version 1.1. It should be connected to the topnode of the geometry description</para>
    ///   <a href="https://w3id.org/fog#as3dmo_v1.1">fog:as3dmo_v1.1</a>
    /// </summary>
    let ``as3dmo_v1.1`` = _prefixId.prefix "as3dmo_v1.1"
    /// <summary>
    ///   <para>rdfs:label : as COLLADA format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open COLLADA format from the Khronos Group. The format consists of a single .dae file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asCollada_v1.4.1).</para>
    ///   <a href="https://w3id.org/fog#asCollada">fog:asCollada</a>
    /// </summary>
    let asCollada = _prefixId.prefix "asCollada"
    /// <summary>
    ///   <para>rdfs:label : as COLLADA v1.4.1 format (.dae)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open COLLADA v1.4.1 format from the Khronos Group. It consists of a single .dae file (text-based).</para>
    ///   <para>http://dbpedia.org/property/extension : .dae^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asCollada_v1.4.1">fog:asCollada_v1.4.1</a>
    /// </summary>
    let ``asCollada_v1.4.1`` = _prefixId.prefix "asCollada_v1.4.1"
    /// <summary>
    ///   <para>rdfs:label : as COLLADA v1.5.0 format (.dae)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open COLLADA v1.5.0 format from the Khronos Group. It consists of a single .dae file (text-based).</para>
    ///   <para>http://dbpedia.org/property/extension : .dae^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asCollada_v1.5.0">fog:asCollada_v1.5.0</a>
    /// </summary>
    let ``asCollada_v1.5.0`` = _prefixId.prefix "asCollada_v1.5.0"
    /// <summary>
    ///   <para>rdfs:label : as DWG format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary DWG format from Autodesk. The Open Design Alliance created a 'specification for .dwg files' that is publicly available. The format consists of a single .dwg file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asDwg_v2018).</para>
    ///   <a href="https://w3id.org/fog#asDwg">fog:asDwg</a>
    /// </summary>
    let asDwg = _prefixId.prefix "asDwg"
    /// <summary>
    ///   <para>rdfs:label : as DWG 2010 format (.dwg)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary DWG v2010 format from Autodesk. It consists of a single .dwg file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .dwg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asDwg_v2010">fog:asDwg_v2010</a>
    /// </summary>
    let asDwg_v2010 = _prefixId.prefix "asDwg_v2010"
    /// <summary>
    ///   <para>rdfs:label : as DWG 2013 format (.dwg)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary DWG v2013 format from Autodesk. It consists of a single .dwg file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .dwg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asDwg_v2013">fog:asDwg_v2013</a>
    /// </summary>
    let asDwg_v2013 = _prefixId.prefix "asDwg_v2013"
    /// <summary>
    ///   <para>rdfs:label : as DWG 2018 format (.dwg)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary DWG v2018 format from Autodesk. It consists of a single .dwg file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .dwg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asDwg_v2018">fog:asDwg_v2018</a>
    /// </summary>
    let asDwg_v2018 = _prefixId.prefix "asDwg_v2018"
    /// <summary>
    ///   <para>rdfs:label : as E57 format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a point cloud geometry description following the open E57 format developed by the ASTM Committee E57. The format consists of a single .e57 file (partially binary, partially text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asE57_v1.0).</para>
    ///   <a href="https://w3id.org/fog#asE57">fog:asE57</a>
    /// </summary>
    let asE57 = _prefixId.prefix "asE57"
    /// <summary>
    ///   <para>rdfs:label : as E57 v1.0 format (.e57)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a point cloud geometry description following the open E57 format developed by the ASTM Committee E57. The format consists of a single .e57 file (partially binary, partially text-based).</para>
    ///   <para>http://dbpedia.org/property/extension : .e57^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asE57_v1.0">fog:asE57_v1.0</a>
    /// </summary>
    let ``asE57_v1.0`` = _prefixId.prefix "asE57_v1.0"
    /// <summary>
    ///   <para>rdfs:label : as GeoJSON format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open GeoJSON format. The format consists of a single .json file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asGeojson_v2016). Note that the version proposed by the IETF GeoJSON Working Group (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).</para>
    ///   <a href="https://w3id.org/fog#asGeojson">fog:asGeojson</a>
    /// </summary>
    let asGeojson = _prefixId.prefix "asGeojson"
    /// <summary>
    ///   <para>rdfs:label : as GeoJSON-LD</para>
    ///   <para>rdfs:comment : The object relation pointing to a GeoJSON-LD geometry description: a GeoJSON geometry description complemented with the corresponding JSON-LD context to make it RDF. It should be connected to the topnode of the geometry description. Note that this geometry description can only be used to depict single points, as the current JSON-LD specification v1.0 does not implement the deserialisation of nested lists to RDF</para>
    ///   <a href="https://w3id.org/fog#asGeojson-ld">fog:asGeojson-ld</a>
    /// </summary>
    let asGeojson_ld = _prefixId.prefix "asGeojson-ld"
    /// <summary>
    ///   <para>rdfs:label : as GeoJSON format v2008 (.json)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open GeoJSON v2008 format. The format consists of a single .json file (text-based). Note that the version proposed by the IETF (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).</para>
    ///   <para>http://dbpedia.org/property/extension : .json^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGeojson_v2008">fog:asGeojson_v2008</a>
    /// </summary>
    let asGeojson_v2008 = _prefixId.prefix "asGeojson_v2008"
    /// <summary>
    ///   <para>rdfs:label : as GeoJSON v2016 format (.json)</para>
    ///   <para>http://dbpedia.org/property/extension : .json^^xsd:stringhttp://dbpedia.org/property/extension : .geojson^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open GeoJSON v2016 format developed by the IETF GeoJSON Working Group. The format consists of a single .json file (text-based). Note that the version proposed by the IETF (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).</para>
    ///   <a href="https://w3id.org/fog#asGeojson_v2016">fog:asGeojson_v2016</a>
    /// </summary>
    let asGeojson_v2016 = _prefixId.prefix "asGeojson_v2016"
    /// <summary>
    ///   <para>rdfs:label : as GEOM ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the GEOM ontology. It should be connected to the topnode of the geometry description.</para>
    ///   <a href="https://w3id.org/fog#asGeomOntology">fog:asGeomOntology</a>
    /// </summary>
    let asGeomOntology = _prefixId.prefix "asGeomOntology"
    /// <summary>
    ///   <para>rdfs:label : as glTF format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open glTF format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders, or .glb) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asGltf_v2.0-gltf).</para>
    ///   <a href="https://w3id.org/fog#asGltf">fog:asGltf</a>
    /// </summary>
    let asGltf = _prefixId.prefix "asGltf"
    /// <summary>
    ///   <para>rdfs:label : as glTF v1.0 format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open glTF v1.0 format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subproperties (e.g. fog:asGltf_v1.0-gltf).</para>
    ///   <a href="https://w3id.org/fog#asGltf_v1.0">fog:asGltf_v1.0</a>
    /// </summary>
    let ``asGltf_v1.0`` = _prefixId.prefix "asGltf_v1.0"
    /// <summary>
    ///   <para>rdfs:label : as glTF v1.0 geometry file (.bin)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary geometry file (.bin) following the open glTF v1.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.</para>
    ///   <para>dcterms:requires : fog:asGltf_v1.0-gltf^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .bin^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGltf_v1.0-bin">fog:asGltf_v1.0-bin</a>
    /// </summary>
    let ``asGltf_v1.0_bin`` = _prefixId.prefix "asGltf_v1.0-bin"
    /// <summary>
    ///   <para>rdfs:label : as glTF v1.0 shader file (.glsl)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based shader file (.glsl) following the open glTF v1.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.</para>
    ///   <para>dcterms:requires : fog:asGltf_v1.0-gltf^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .glsl^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGltf_v1.0-glsl">fog:asGltf_v1.0-glsl</a>
    /// </summary>
    let ``asGltf_v1.0_glsl`` = _prefixId.prefix "asGltf_v1.0-glsl"
    /// <summary>
    ///   <para>rdfs:label : as glTF v1.0 JSON file (.gltf)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a JSON file (.gltf) following the open glTF v1.0 format from the Khronos Group. This file can be used on its own if geometry, shaders and optional textures are embedded (text-based) inside the JSON. In most cases however, it references other files containing geometry (.bin), optional shaders (.glsl) and optional textures (.bmp/.gif/.jpeg/.png).</para>
    ///   <para>http://dbpedia.org/property/extension : .gltf^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGltf_v1.0-gltf">fog:asGltf_v1.0-gltf</a>
    /// </summary>
    let ``asGltf_v1.0_gltf`` = _prefixId.prefix "asGltf_v1.0-gltf"
    /// <summary>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary texture file (.bmp/..gif/.jpeg/.png). This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.</para>
    ///   <para>http://dbpedia.org/property/extension : .bmp^^xsd:stringhttp://dbpedia.org/property/extension : .jpeg^^xsd:stringhttp://dbpedia.org/property/extension : .gif^^xsd:stringhttp://dbpedia.org/property/extension : .png^^xsd:string</para>
    ///   <para>dcterms:requires : fog:asGltf_v1.0-gltf^^xsd:string</para>
    ///   <para>rdfs:label : as glTF v1.0 texture file</para>
    ///   <a href="https://w3id.org/fog#asGltf_v1.0-texture">fog:asGltf_v1.0-texture</a>
    /// </summary>
    let ``asGltf_v1.0_texture`` = _prefixId.prefix "asGltf_v1.0-texture"
    /// <summary>
    ///   <para>rdfs:label : as glTF v2.0 format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open glTF v2.0 format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders, or .glb) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subproperties (e.g. fog:asGltf_v2.0-gltf).</para>
    ///   <a href="https://w3id.org/fog#asGltf_v2.0">fog:asGltf_v2.0</a>
    /// </summary>
    let ``asGltf_v2.0`` = _prefixId.prefix "asGltf_v2.0"
    /// <summary>
    ///   <para>rdfs:label : as glTF v2.0 geometry file (.bin)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary geometry file (.bin) following the open glTF v2.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v2.0-gltf) referencing it.</para>
    ///   <para>dcterms:requires : fog:asGltf_v2.0-gltf^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .bin^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGltf_v2.0-bin">fog:asGltf_v2.0-bin</a>
    /// </summary>
    let ``asGltf_v2.0_bin`` = _prefixId.prefix "asGltf_v2.0-bin"
    /// <summary>
    ///   <para>rdfs:label : as glTF v2.0 binary file (.glb)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary file (.glb) following the open glTF v2.0 format from the Khronos Group. This one file contains geometry and textures, and as a result can be used without other files.</para>
    ///   <para>http://dbpedia.org/property/extension : .glb^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGltf_v2.0-glb">fog:asGltf_v2.0-glb</a>
    /// </summary>
    let ``asGltf_v2.0_glb`` = _prefixId.prefix "asGltf_v2.0-glb"
    /// <summary>
    ///   <para>rdfs:label : as glTF v2.0 JSON file (.gltf)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a JSON file (.gltf) following the open glTF v2.0 format from the Khronos Group. This file can be used on its own if geometry and optional textures are embedded (text-based) inside the JSON. In most cases however, it references other files containing geometry (.bin) and optional textures (.jpeg/.png).</para>
    ///   <para>http://dbpedia.org/property/extension : .gltf^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGltf_v2.0-gltf">fog:asGltf_v2.0-gltf</a>
    /// </summary>
    let ``asGltf_v2.0_gltf`` = _prefixId.prefix "asGltf_v2.0-gltf"
    /// <summary>
    ///   <para>rdfs:label : as glTF v2.0 texture file</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary texture file (.jpeg/.png). This file always has to be used together with the central .gltf JSON file (fog:asGltf_v2.0-gltf) referencing it.</para>
    ///   <para>dcterms:requires : fog:asGltf_v2.0-gltf^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .png^^xsd:stringhttp://dbpedia.org/property/extension : .jpeg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGltf_v2.0-texture">fog:asGltf_v2.0-texture</a>
    /// </summary>
    let ``asGltf_v2.0_texture`` = _prefixId.prefix "asGltf_v2.0-texture"
    /// <summary>
    ///   <para>rdfs:label : as GML format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following one of the open GML formats developed by OGC and ISO. The format consists of a single .gml file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asGml_v3.3.0). Note that this property is disjoint with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    ///   <a href="https://w3id.org/fog#asGml">fog:asGml</a>
    /// </summary>
    let asGml = _prefixId.prefix "asGml"
    /// <summary>
    ///   <para>rdfs:label : as GML v3.1.1 format (.gml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.1.1 format developed by OGC and ISO. Note that this and older versions are considered depreciated. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    ///   <para>http://dbpedia.org/property/extension : .gml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGml_v3.1.1">fog:asGml_v3.1.1</a>
    /// </summary>
    let ``asGml_v3.1.1`` = _prefixId.prefix "asGml_v3.1.1"
    /// <summary>
    ///   <para>rdfs:label : as GML v3.2.1 format (.gml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.2.1 format developed by OGC and ISO. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    ///   <para>http://dbpedia.org/property/extension : .gml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGml_v3.2.1">fog:asGml_v3.2.1</a>
    /// </summary>
    let ``asGml_v3.2.1`` = _prefixId.prefix "asGml_v3.2.1"
    /// <summary>
    ///   <para>rdfs:label : as GML v3.2.2 format (.gml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.2.2 format developed by OGC and ISO. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    ///   <para>http://dbpedia.org/property/extension : .gml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGml_v3.2.2">fog:asGml_v3.2.2</a>
    /// </summary>
    let ``asGml_v3.2.2`` = _prefixId.prefix "asGml_v3.2.2"
    /// <summary>
    ///   <para>rdfs:label : as GML v3.3.0 format (.gml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.3.0 format developed by OGC and ISO. This format is an extension of the GML v3.2 format. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    ///   <para>http://dbpedia.org/property/extension : .gml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asGml_v3.3.0">fog:asGml_v3.3.0</a>
    /// </summary>
    let ``asGml_v3.3.0`` = _prefixId.prefix "asGml_v3.3.0"
    /// <summary>
    ///   <para>rdfs:label : as IFC format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format as documented by buildingSMART and in its ISO 16739 standard. The format consists of a single .ifc or .ifcxml file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asIfc_v2x4-icfxml).</para>
    ///   <a href="https://w3id.org/fog#asIfc">fog:asIfc</a>
    /// </summary>
    let asIfc = _prefixId.prefix "asIfc"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x3</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x3">fog:asIfc_v2x3</a>
    /// </summary>
    let asIfc_v2x3 = _prefixId.prefix "asIfc_v2x3"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x3 file (.ifc)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    ///   <para>http://dbpedia.org/property/extension : .ifc^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x3-ifc">fog:asIfc_v2x3-ifc</a>
    /// </summary>
    let asIfc_v2x3_ifc = _prefixId.prefix "asIfc_v2x3-ifc"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x3 file (.ifcxml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    ///   <para>http://dbpedia.org/property/extension : .ifcxml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x3-ifcxml">fog:asIfc_v2x3-ifcxml</a>
    /// </summary>
    let asIfc_v2x3_ifcxml = _prefixId.prefix "asIfc_v2x3-ifcxml"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x3 TC1</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x3tc1">fog:asIfc_v2x3tc1</a>
    /// </summary>
    let asIfc_v2x3tc1 = _prefixId.prefix "asIfc_v2x3tc1"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x3 TC1 file (.ifc)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    ///   <para>http://dbpedia.org/property/extension : .ifc^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x3tc1-ifc">fog:asIfc_v2x3tc1-ifc</a>
    /// </summary>
    let asIfc_v2x3tc1_ifc = _prefixId.prefix "asIfc_v2x3tc1-ifc"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x3 TC1 file (.ifcxml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    ///   <para>http://dbpedia.org/property/extension : .ifcxml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x3tc1-ifcxml">fog:asIfc_v2x3tc1-ifcxml</a>
    /// </summary>
    let asIfc_v2x3tc1_ifcxml = _prefixId.prefix "asIfc_v2x3tc1-ifcxml"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4">fog:asIfc_v2x4</a>
    /// </summary>
    let asIfc_v2x4 = _prefixId.prefix "asIfc_v2x4"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 file (.ifc)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    ///   <para>http://dbpedia.org/property/extension : .ifc^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4-ifc">fog:asIfc_v2x4-ifc</a>
    /// </summary>
    let asIfc_v2x4_ifc = _prefixId.prefix "asIfc_v2x4-ifc"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 file (.ifcxml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    ///   <para>http://dbpedia.org/property/extension : .ifcxml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4-ifcxml">fog:asIfc_v2x4-ifcxml</a>
    /// </summary>
    let asIfc_v2x4_ifcxml = _prefixId.prefix "asIfc_v2x4-ifcxml"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 Add1</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4add1">fog:asIfc_v2x4add1</a>
    /// </summary>
    let asIfc_v2x4add1 = _prefixId.prefix "asIfc_v2x4add1"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 Add1 file (.ifc)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    ///   <para>http://dbpedia.org/property/extension : .ifc^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4add1-ifc">fog:asIfc_v2x4add1-ifc</a>
    /// </summary>
    let asIfc_v2x4add1_ifc = _prefixId.prefix "asIfc_v2x4add1-ifc"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 Add1 file (.ifcxml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    ///   <para>http://dbpedia.org/property/extension : .ifcxml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4add1-ifcxml">fog:asIfc_v2x4add1-ifcxml</a>
    /// </summary>
    let asIfc_v2x4add1_ifcxml = _prefixId.prefix "asIfc_v2x4add1-ifcxml"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 Add2</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4add2">fog:asIfc_v2x4add2</a>
    /// </summary>
    let asIfc_v2x4add2 = _prefixId.prefix "asIfc_v2x4add2"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 Add2 file (.ifc)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    ///   <para>http://dbpedia.org/property/extension : .ifc^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4add2-ifc">fog:asIfc_v2x4add2-ifc</a>
    /// </summary>
    let asIfc_v2x4add2_ifc = _prefixId.prefix "asIfc_v2x4add2-ifc"
    /// <summary>
    ///   <para>rdfs:label : as IFC v2x4 Add 2 file (.ifcxml)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    ///   <para>http://dbpedia.org/property/extension : .ifcxml^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIfc_v2x4add2-ifcxml">fog:asIfc_v2x4add2-ifcxml</a>
    /// </summary>
    let asIfc_v2x4add2_ifcxml = _prefixId.prefix "asIfc_v2x4add2-ifcxml"
    /// <summary>
    ///   <para>rdfs:label : as ifcOWL ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the IfcOWL ontology.</para>
    ///   <a href="https://w3id.org/fog#asIfcowl">fog:asIfcowl</a>
    /// </summary>
    let asIfcowl = _prefixId.prefix "asIfcowl"
    /// <summary>
    ///   <para>rdfs:label : as ifcOWL v2x3 Final ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the IfcOWL v2x3 Final ontology.</para>
    ///   <a href="https://w3id.org/fog#asIfcowl_v2x3final">fog:asIfcowl_v2x3final</a>
    /// </summary>
    let asIfcowl_v2x3final = _prefixId.prefix "asIfcowl_v2x3final"
    /// <summary>
    ///   <para>rdfs:label : as ifcOWL v2x3 TC1 ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the IfcOWL v2x3 TC1 ontology.</para>
    ///   <a href="https://w3id.org/fog#asIfcowl_v2x3tc1">fog:asIfcowl_v2x3tc1</a>
    /// </summary>
    let asIfcowl_v2x3tc1 = _prefixId.prefix "asIfcowl_v2x3tc1"
    /// <summary>
    ///   <para>rdfs:label : as ifcOWL v2x4 Add1 ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Add1 ontology.</para>
    ///   <a href="https://w3id.org/fog#asIfcowl_v2x4add1">fog:asIfcowl_v2x4add1</a>
    /// </summary>
    let asIfcowl_v2x4add1 = _prefixId.prefix "asIfcowl_v2x4add1"
    /// <summary>
    ///   <para>rdfs:label : as ifcOWL v2x4 Add2 ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Add2 ontology.</para>
    ///   <a href="https://w3id.org/fog#asIfcowl_v2x4add2">fog:asIfcowl_v2x4add2</a>
    /// </summary>
    let asIfcowl_v2x4add2 = _prefixId.prefix "asIfcowl_v2x4add2"
    /// <summary>
    ///   <para>rdfs:label : as ifcOWL v2x4 Final ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Final ontology.</para>
    ///   <a href="https://w3id.org/fog#asIfcowl_v2x4final">fog:asIfcowl_v2x4final</a>
    /// </summary>
    let asIfcowl_v2x4final = _prefixId.prefix "asIfcowl_v2x4final"
    /// <summary>
    ///   <para>http://dbpedia.org/property/extension : .iges^^xsd:stringhttp://dbpedia.org/property/extension : .igs^^xsd:string</para>
    ///   <para>rdfs:label : as IGES format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the IGES format as documented in its ANSI standard. The format consists of a single .iges/.igs file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asIges_v5.3).</para>
    ///   <a href="https://w3id.org/fog#asIges">fog:asIges</a>
    /// </summary>
    let asIges = _prefixId.prefix "asIges"
    /// <summary>
    ///   <para>rdfs:label : as IGES v5.3 (.igs)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the IGES format v5.6 as documented in its ANSI standard.</para>
    ///   <para>http://dbpedia.org/property/extension : .igs^^xsd:stringhttp://dbpedia.org/property/extension : .iges^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asIges_v5.3">fog:asIges_v5.3</a>
    /// </summary>
    let ``asIges_v5.3`` = _prefixId.prefix "asIges_v5.3"
    /// <summary>
    ///   <para>rdfs:label : as OBJ format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the OBJ format developed by Wavefront Technologies. The format consists of a single .obj file and an optional material file (.mtl). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asObj_v3.0-obj).</para>
    ///   <a href="https://w3id.org/fog#asObj">fog:asObj</a>
    /// </summary>
    let asObj = _prefixId.prefix "asObj"
    /// <summary>
    ///   <para>rdfs:label : as OBJ v3.0 format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based geometry description following the OBJ v3.0 format developed by Wavefront Technologies. The format consists of a single .obj file and an optional material file (.mtl). It is strongly adviced to use the more specific subproperties (e.g. fog:asObj_v3.0-obj).</para>
    ///   <a href="https://w3id.org/fog#asObj_v3.0">fog:asObj_v3.0</a>
    /// </summary>
    let ``asObj_v3.0`` = _prefixId.prefix "asObj_v3.0"
    /// <summary>
    ///   <para>http://dbpedia.org/property/extension : .mtl^^xsd:string</para>
    ///   <para>rdfs:label : as OBJ v3.0 material file (.mtl)</para>
    ///   <para>dcterms:requires : fog:asObj_v3.0-obj^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based MTL file (.mtl) following the OBJ format developed by Wavefront Technologies. This file has to be used together with the main .obj file that references it.</para>
    ///   <a href="https://w3id.org/fog#asObj_v3.0-mtl">fog:asObj_v3.0-mtl</a>
    /// </summary>
    let ``asObj_v3.0_mtl`` = _prefixId.prefix "asObj_v3.0-mtl"
    /// <summary>
    ///   <para>rdfs:label : as OBJ v3.0 file (.obj)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a text-based OBJ file (.obj) following the OBJ format developed by Wavefront Technologies. This file can be used together with an optional material file (.mtl).</para>
    ///   <para>http://dbpedia.org/property/extension : .obj^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asObj_v3.0-obj">fog:asObj_v3.0-obj</a>
    /// </summary>
    let ``asObj_v3.0_obj`` = _prefixId.prefix "asObj_v3.0-obj"
    /// <summary>
    ///   <para>rdfs:label : as OBJ texture</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary texture file that is referenced in the .mtl file of the OBJ format.</para>
    ///   <a href="https://w3id.org/fog#asObj_v3.0-texture">fog:asObj_v3.0-texture</a>
    /// </summary>
    let ``asObj_v3.0_texture`` = _prefixId.prefix "asObj_v3.0-texture"
    /// <summary>
    ///   <para>rdfs:label : as OntoBREP ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the OntoBREP ontology. It should be connected to the topnode of the geometry description.</para>
    ///   <a href="https://w3id.org/fog#asOntobrepOntology">fog:asOntobrepOntology</a>
    /// </summary>
    let asOntobrepOntology = _prefixId.prefix "asOntobrepOntology"
    /// <summary>
    ///   <para>rdfs:label : as OntoSTEP ontology</para>
    ///   <para>rdfs:comment : The object relation pointing to a RDF-based geometry description following the OntoSTEP ontology. It should be connected to the topnode of the geometry description.</para>
    ///   <a href="https://w3id.org/fog#asOntostepOntology">fog:asOntostepOntology</a>
    /// </summary>
    let asOntostepOntology = _prefixId.prefix "asOntostepOntology"
    /// <summary>
    ///   <para>rdfs:label : as PCD point cloud format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary encoded point cloud following the open PCD format which was developed as part of the open source project PCL (point cloud library). The format consists of a single .pcd file (binary or text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asPcd_v0.7).</para>
    ///   <a href="https://w3id.org/fog#asPcd">fog:asPcd</a>
    /// </summary>
    let asPcd = _prefixId.prefix "asPcd"
    /// <summary>
    ///   <para>rdfs:label : as PCD v0.7 point cloud format (.pcd)^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary or text-based point cloud following the open PCD v0.7 (sometimes referred to as PCD_v7) format which was developed as part of the open source project PCL (point cloud library).</para>
    ///   <para>http://dbpedia.org/property/extension : .pcd^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asPcd_v0.7">fog:asPcd_v0.7</a>
    /// </summary>
    let ``asPcd_v0.7`` = _prefixId.prefix "asPcd_v0.7"
    /// <summary>
    ///   <para>rdfs:label : as PLY format^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .ply^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the PLY format which was developed by Greg Turk (Stanford University). The format consists of a single .ply file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asPly_v1.0-ascii).</para>
    ///   <a href="https://w3id.org/fog#asPly">fog:asPly</a>
    /// </summary>
    let asPly = _prefixId.prefix "asPly"
    /// <summary>
    ///   <para>rdfs:label : as PLY v1.0 format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The format consists of a single .ply file which is either text-based or binary. It is strongly adviced to use the more specific subproperties (e.g. fog:asPly_v1.0-ascii).</para>
    ///   <a href="https://w3id.org/fog#asPly_v1.0">fog:asPly_v1.0</a>
    /// </summary>
    let ``asPly_v1.0`` = _prefixId.prefix "asPly_v1.0"
    /// <summary>
    ///   <para>rdfs:label : as PLY ASCII format (.ply)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is text-based.</para>
    ///   <para>http://dbpedia.org/property/extension : .ply^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asPly_v1.0-ascii">fog:asPly_v1.0-ascii</a>
    /// </summary>
    let ``asPly_v1.0_ascii`` = _prefixId.prefix "asPly_v1.0-ascii"
    /// <summary>
    ///   <para>rdfs:label : as PLY binary (big endian) format (.ply)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is binary with big endian. Note that there is also a sibling property for a binary PLY with little endian.</para>
    ///   <para>http://dbpedia.org/property/extension : .ply^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asPly_v1.0-binaryBE">fog:asPly_v1.0-binaryBE</a>
    /// </summary>
    let ``asPly_v1.0_binaryBE`` = _prefixId.prefix "asPly_v1.0-binaryBE"
    /// <summary>
    ///   <para>rdfs:label : as PLY binary (little endian) format (.ply)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is binary with little endian. Note that there is also a sibling property for a binary PLY with big endian.</para>
    ///   <para>http://dbpedia.org/property/extension : .ply^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asPly_v1.0-binaryLE">fog:asPly_v1.0-binaryLE</a>
    /// </summary>
    let ``asPly_v1.0_binaryLE`` = _prefixId.prefix "asPly_v1.0-binaryLE"
    /// <summary>
    ///   <para>rdfs:label : as Revit format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Revit format (Autodesk). The format consists of a single .rvt file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asRevit_v2020)</para>
    ///   <para>http://dbpedia.org/property/extension : .rvt^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRevit">fog:asRevit</a>
    /// </summary>
    let asRevit = _prefixId.prefix "asRevit"
    /// <summary>
    ///   <para>rdfs:label : as Revit format v2017 (.rvt)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Revit v2017 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .rvt^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRevit_v2017">fog:asRevit_v2017</a>
    /// </summary>
    let asRevit_v2017 = _prefixId.prefix "asRevit_v2017"
    /// <summary>
    ///   <para>rdfs:label : as Revit format v2018 (.rvt)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Revit v2018 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .rvt^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRevit_v2018">fog:asRevit_v2018</a>
    /// </summary>
    let asRevit_v2018 = _prefixId.prefix "asRevit_v2018"
    /// <summary>
    ///   <para>rdfs:label : as Revit format v2019 (.rvt)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Revit v2019 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .rvt^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRevit_v2019">fog:asRevit_v2019</a>
    /// </summary>
    let asRevit_v2019 = _prefixId.prefix "asRevit_v2019"
    /// <summary>
    ///   <para>rdfs:label : as Revit format v2020 (.rvt)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Revit v2020 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .rvt^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRevit_v2020">fog:asRevit_v2020</a>
    /// </summary>
    let asRevit_v2020 = _prefixId.prefix "asRevit_v2020"
    /// <summary>
    ///   <para>rdfs:label : as Rhino format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Rhinoceros format (McNeel). The format consists of a single .3dm file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asRhino_v6)</para>
    ///   <para>http://dbpedia.org/property/extension : .3dm^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRhino">fog:asRhino</a>
    /// </summary>
    let asRhino = _prefixId.prefix "asRhino"
    /// <summary>
    ///   <para>rdfs:label : as Rhino format v5 (.3dm)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Rhinoceros format v5 (McNeel). The format consists of a single .3dm file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .3dm^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRhino_v5">fog:asRhino_v5</a>
    /// </summary>
    let asRhino_v5 = _prefixId.prefix "asRhino_v5"
    /// <summary>
    ///   <para>rdfs:label : as Rhino format v6 (.3dm)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary Rhinoceros format v6 (McNeel). The format consists of a single .3dm file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .3dm^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asRhino_v6">fog:asRhino_v6</a>
    /// </summary>
    let asRhino_v6 = _prefixId.prefix "asRhino_v6"
    /// <summary>
    ///   <para>rdfs:label : as Simple Feature Access geometry format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) standard developed by the OGC and ISO. The format consists of a single .wkt (text-based) or .wkb (binary) file. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asSfa_v2-wkt).</para>
    ///   <a href="https://w3id.org/fog#asSfa">fog:asSfa</a>
    /// </summary>
    let asSfa = _prefixId.prefix "asSfa"
    /// <summary>
    ///   <para>rdfs:label : as Simple Feature Access v1 format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) v1 standard developed by the OGC. The format is text-based. It is strongly adviced to use the more specific subproperties (e.g. fog:asSfa_v1-wkt). Note that this standard is now considered depreciated in favor of SFA v2.</para>
    ///   <a href="https://w3id.org/fog#asSfa_v1">fog:asSfa_v1</a>
    /// </summary>
    let asSfa_v1 = _prefixId.prefix "asSfa_v1"
    /// <summary>
    ///   <para>rdfs:label : as Well Known Text SFA v1 geometry</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a Well Know Text (WKT) geometry following the open Simple Feature Access (SFA) v1 standard developed by the OGC. The format is text-based. Note that the SFA v1 standard is now considered depreciated in favor of SFA v2. Note that this property is disjoint with geo:asWKT because of the more strict domain and range restrictions in GeoSPARQL.</para>
    ///   <a href="https://w3id.org/fog#asSfa_v1-wkt">fog:asSfa_v1-wkt</a>
    /// </summary>
    let asSfa_v1_wkt = _prefixId.prefix "asSfa_v1-wkt"
    /// <summary>
    ///   <para>rdfs:label : as Simple Feature Access v2 format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO. The format is either text-based (WKT) or binary (WKB). It is strongly adviced to use the more specific subproperties (e.g. fog:asSfa_v2-wkt).</para>
    ///   <a href="https://w3id.org/fog#asSfa_v2">fog:asSfa_v2</a>
    /// </summary>
    let asSfa_v2 = _prefixId.prefix "asSfa_v2"
    /// <summary>
    ///   <para>rdfs:label : as Well Known Binary SFA v2 geometry</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a Well Know Binary (WKB) geometry following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO.</para>
    ///   <a href="https://w3id.org/fog#asSfa_v2-wkb">fog:asSfa_v2-wkb</a>
    /// </summary>
    let asSfa_v2_wkb = _prefixId.prefix "asSfa_v2-wkb"
    /// <summary>
    ///   <para>rdfs:label : as Well Known Text SFA v2 geometry</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a Well Know Text (WKT) geometry following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO. The format is text-based. Note that this property is disjoint with geo:asWKT because of the more strict domain and range restrictions in GeoSPARQL.</para>
    ///   <a href="https://w3id.org/fog#asSfa_v2-wkt">fog:asSfa_v2-wkt</a>
    /// </summary>
    let asSfa_v2_wkt = _prefixId.prefix "asSfa_v2-wkt"
    /// <summary>
    ///   <para>rdfs:label : as Shapefile format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open Shapefile format developed by ESRI. The format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asShapefile-shp). Note that no file format version is provided by ESRI and that the format is expected to be stable.</para>
    ///   <a href="https://w3id.org/fog#asShapefile">fog:asShapefile</a>
    /// </summary>
    let asShapefile = _prefixId.prefix "asShapefile"
    /// <summary>
    ///   <para>dcterms:requires : fog:asShapefile-shx^^xsd:stringdcterms:requires : fog:asShapefile-shp^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .dbf^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a dBASE table file (.dbf) following the open Shapefile format developed by ESRI. This file contains the attributes of each shape. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    ///   <para>rdfs:label : as Shapefile dBASE table (.dbf)</para>
    ///   <a href="https://w3id.org/fog#asShapefile-dbf">fog:asShapefile-dbf</a>
    /// </summary>
    let asShapefile_dbf = _prefixId.prefix "asShapefile-dbf"
    /// <summary>
    ///   <para>dcterms:requires : fog:asShapefile-shx^^xsd:stringdcterms:requires : fog:asShapefile-dbf^^xsd:stringdcterms:requires : fog:asShapefile-shp^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .prj^^xsd:string</para>
    ///   <para>rdfs:label : as Shapefile projections file (.prj)^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a projection format file (.prj) following the open Shapefile format developed by ESRI. This file contains the the coordinate system and projection information of the shapes. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    ///   <a href="https://w3id.org/fog#asShapefile-prj">fog:asShapefile-prj</a>
    /// </summary>
    let asShapefile_prj = _prefixId.prefix "asShapefile-prj"
    /// <summary>
    ///   <para>dcterms:requires : fog:asShapefile-shx^^xsd:stringdcterms:requires : fog:asShapefile-dbf^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .shp^^xsd:string</para>
    ///   <para>rdfs:label : as Shapefile geometry (.shp)^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry file (.shp) following the open Shapefile format developed by ESRI. This file contains the geometry of the shape. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    ///   <a href="https://w3id.org/fog#asShapefile-shp">fog:asShapefile-shp</a>
    /// </summary>
    let asShapefile_shp = _prefixId.prefix "asShapefile-shp"
    /// <summary>
    ///   <para>rdfs:label : as Shapefile geometry index (.shx)^^xsd:string</para>
    ///   <para>dcterms:requires : fog:asShapefile-dbf^^xsd:stringdcterms:requires : fog:asShapefile-shp^^xsd:string</para>
    ///   <para>http://dbpedia.org/property/extension : .shx^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a shape index format file (.shx) following the open Shapefile format developed by ESRI. This file contains the positional index of the geometry. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    ///   <a href="https://w3id.org/fog#asShapefile-shx">fog:asShapefile-shx</a>
    /// </summary>
    let asShapefile_shx = _prefixId.prefix "asShapefile-shx"
    /// <summary>
    ///   <para>rdfs:label : as SketchUp format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary SketchUp format (Trimble). The format consists of a single .skp file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asSketchUp_v2019)</para>
    ///   <para>http://dbpedia.org/property/extension : .skp^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSketchUp">fog:asSketchUp</a>
    /// </summary>
    let asSketchUp = _prefixId.prefix "asSketchUp"
    /// <summary>
    ///   <para>rdfs:label : as SketchUp format v2017 (.skp)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary SketchUp v2017 format (Trimble). The format consists of a single .skp file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .skp^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSketchUp_v2017">fog:asSketchUp_v2017</a>
    /// </summary>
    let asSketchUp_v2017 = _prefixId.prefix "asSketchUp_v2017"
    /// <summary>
    ///   <para>rdfs:label : as SketchUp format v2018 (.skp)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary SketchUp v2018 format (Trimble). The format consists of a single .skp file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .skp^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSketchUp_v2018">fog:asSketchUp_v2018</a>
    /// </summary>
    let asSketchUp_v2018 = _prefixId.prefix "asSketchUp_v2018"
    /// <summary>
    ///   <para>rdfs:label : as SketchUp format v2019 (.skp)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the proprietary SketchUp v2019 format (Trimble). The format consists of a single .skp file (binary).</para>
    ///   <para>http://dbpedia.org/property/extension : .skp^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSketchUp_v2019">fog:asSketchUp_v2019</a>
    /// </summary>
    let asSketchUp_v2019 = _prefixId.prefix "asSketchUp_v2019"
    /// <summary>
    ///   <para>rdfs:label : as SPFF file (.step)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. It is strongly adviced to use more specific subproperties.</para>
    ///   <para>http://dbpedia.org/property/extension : .stp^^xsd:stringhttp://dbpedia.org/property/extension : .step^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asStep">fog:asStep</a>
    /// </summary>
    let asStep = _prefixId.prefix "asStep"
    /// <summary>
    ///   <para>rdfs:label : as STEP SPFF file (AP214)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. The STEP file is structured according to the Application Profile (AP) 214 - Core data for automative mechanical design processes.</para>
    ///   <para>http://dbpedia.org/property/extension : .stp^^xsd:stringhttp://dbpedia.org/property/extension : .step^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asStep_ap214">fog:asStep_ap214</a>
    /// </summary>
    let asStep_ap214 = _prefixId.prefix "asStep_ap214"
    /// <summary>
    ///   <para>rdfs:label : as STEP SPFF file (AP242)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. The STEP file is structured according to the Application Profile (AP) 242 - Managed model-based 3D engineering.</para>
    ///   <para>http://dbpedia.org/property/extension : .stp^^xsd:stringhttp://dbpedia.org/property/extension : .step^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asStep_ap242">fog:asStep_ap242</a>
    /// </summary>
    let asStep_ap242 = _prefixId.prefix "asStep_ap242"
    /// <summary>
    ///   <para>rdfs:label : as STL format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the STL format which was developed by 3D Systems. The format consists of a single .stl file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asStl_v1.0-ascii).</para>
    ///   <a href="https://w3id.org/fog#asStl">fog:asStl</a>
    /// </summary>
    let asStl = _prefixId.prefix "asStl"
    /// <summary>
    ///   <para>rdfs:label : as STL format v1.0</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asStl_v1.0-ascii)</para>
    ///   <para>http://dbpedia.org/property/extension : .stl^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asStl_v1.0">fog:asStl_v1.0</a>
    /// </summary>
    let ``asStl_v1.0`` = _prefixId.prefix "asStl_v1.0"
    /// <summary>
    ///   <para>rdfs:label : as STL format v1.0 (ASCII)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is text-based.</para>
    ///   <para>http://dbpedia.org/property/extension : .stl^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asStl_v1.0-ascii">fog:asStl_v1.0-ascii</a>
    /// </summary>
    let ``asStl_v1.0_ascii`` = _prefixId.prefix "asStl_v1.0-ascii"
    /// <summary>
    ///   <para>rdfs:label : as STL format v1.0 (binary)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is binary.</para>
    ///   <para>http://dbpedia.org/property/extension : .stl^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asStl_v1.0-binary">fog:asStl_v1.0-binary</a>
    /// </summary>
    let ``asStl_v1.0_binary`` = _prefixId.prefix "asStl_v1.0-binary"
    /// <summary>
    ///   <para>rdfs:label : as SVG format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open SVG format which was developed by the W3C. The format consists of a single .svg file which is text-based. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asSvg_v1.1).</para>
    ///   <para>http://dbpedia.org/property/extension : .svg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSvg">fog:asSvg</a>
    /// </summary>
    let asSvg = _prefixId.prefix "asSvg"
    /// <summary>
    ///   <para>rdfs:label : as SVG format v1.0</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open SVG v1.0 format which was developed by the W3C. The format consists of a single .svg file which is text-based. Note that this version (v1.0) is considered depreciated in favor of v1.1.</para>
    ///   <para>http://dbpedia.org/property/extension : .svg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSvg_v1.0">fog:asSvg_v1.0</a>
    /// </summary>
    let ``asSvg_v1.0`` = _prefixId.prefix "asSvg_v1.0"
    /// <summary>
    ///   <para>rdfs:label : as SVG format v1.1</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open SVG v1.1 format which was developed by the W3C. The format consists of a single .svg file which is text-based.</para>
    ///   <para>http://dbpedia.org/property/extension : .svg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSvg_v1.1">fog:asSvg_v1.1</a>
    /// </summary>
    let ``asSvg_v1.1`` = _prefixId.prefix "asSvg_v1.1"
    /// <summary>
    ///   <para>rdfs:label : as SVG format v2.0</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open SVG v2.0 format which was developed by the W3C. The format consists of a single .svg file which is text-based. Note that this version (v2.0) is not yet finalized and at the moment has the status of 'W3C Candidate Recommendation'.</para>
    ///   <para>http://dbpedia.org/property/extension : .svg^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asSvg_v2.0">fog:asSvg_v2.0</a>
    /// </summary>
    let ``asSvg_v2.0`` = _prefixId.prefix "asSvg_v2.0"
    /// <summary>
    ///   <para>rdfs:label : as X3D format</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open X3D format which was developed by the Web3D. The format consists of a single file which is either binary or text-based. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asX3d_v3.3_xml).</para>
    ///   <a href="https://w3id.org/fog#asX3d">fog:asX3d</a>
    /// </summary>
    let asX3d = _prefixId.prefix "asX3d"
    /// <summary>
    ///   <para>rdfs:label : as X3D format v3.3</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a geometry description following the open X3D v3.3 format which was developed by the Web3D. The format consists of a single file which is either binary or text-based. It is strongly adviced to use the more specific subproperties (e.g. fog:asX3d_v3.3_xml).</para>
    ///   <a href="https://w3id.org/fog#asX3d_v3.3">fog:asX3d_v3.3</a>
    /// </summary>
    let ``asX3d_v3.3`` = _prefixId.prefix "asX3d_v3.3"
    /// <summary>
    ///   <para>rdfs:label : as X3D v3.3 binary file (.x3db)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a binary X3D file (.x3db) following the open X3D v3.3 format which was developed by the Web3D.</para>
    ///   <para>http://dbpedia.org/property/extension : .x3db^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asX3d_v3.3-binary">fog:asX3d_v3.3-binary</a>
    /// </summary>
    let ``asX3d_v3.3_binary`` = _prefixId.prefix "asX3d_v3.3-binary"
    /// <summary>
    ///   <para>rdfs:label : as X3D v3.3 classic VRML file (.x3dv)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a classic VRML X3D file (.x3dv) following the open X3D v3.3 format which was developed by the Web3D. The file is text-based.</para>
    ///   <para>http://dbpedia.org/property/extension : .x3dv^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asX3d_v3.3-vrml">fog:asX3d_v3.3-vrml</a>
    /// </summary>
    let ``asX3d_v3.3_vrml`` = _prefixId.prefix "asX3d_v3.3-vrml"
    /// <summary>
    ///   <para>rdfs:label : as X3D v3.3 XML file (.x3d)</para>
    ///   <para>rdfs:comment : The datatype relation pointing to a regular X3D file (.x3d) following the open X3D v3.3 format which was developed by the Web3D. The file is text-based.</para>
    ///   <para>http://dbpedia.org/property/extension : .x3d^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#asX3d_v3.3-xml">fog:asX3d_v3.3-xml</a>
    /// </summary>
    let ``asX3d_v3.3_xml`` = _prefixId.prefix "asX3d_v3.3-xml"
    /// <summary>
    ///   <para>rdfs:label : has referenced content^^xsd:string</para>
    ///   <a href="https://w3id.org/fog#hasReferencedContent">fog:hasReferencedContent</a>
    /// </summary>
    let hasReferencedContent = _prefixId.prefix "hasReferencedContent"
