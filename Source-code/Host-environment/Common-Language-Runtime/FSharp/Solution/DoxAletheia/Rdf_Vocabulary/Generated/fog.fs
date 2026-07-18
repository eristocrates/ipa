namespace https.w3id.org.fog.hash

open DoxAletheia.Rdf_Vocabulary

module fog =
    let _namespace_name = "https://w3id.org/fog#"

    /// <summary>
    /// Referenced content of the following geometry descriptions: glTF and OBJ. It contains exactly one link to a texture, separate binary glTF geometry or a OBJ material that is referenced by the main file (resp. .gltf and .obj). The name of the referenced file, as stored in the main file, is connected via a rdfs:label node
    /// <see href="https://w3id.org/fog#ReferencedContent"></see></summary>
    let ReferencedContent =
        Namespaced_IRI.parse _namespace_name "ReferencedContent" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the 3DMO ontology. It is strongly adviced to use the more specific subproperty (fog:as3dmo_v1.1)
    /// <see href="https://w3id.org/fog#as3dmo"></see></summary>
    let as3dmo = Namespaced_IRI.parse _namespace_name "as3dmo" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the 3DMO ontology version 1.1. It should be connected to the topnode of the geometry description
    /// <see href="https://w3id.org/fog#as3dmo_v1.1"></see></summary>
    let ``as3dmo_v1.1`` =
        Namespaced_IRI.parse _namespace_name "as3dmo_v1.1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open COLLADA format from the Khronos Group. The format consists of a single .dae file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asCollada_v1.4.1).
    /// <see href="https://w3id.org/fog#asCollada"></see></summary>
    let asCollada = Namespaced_IRI.parse _namespace_name "asCollada" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open COLLADA v1.4.1 format from the Khronos Group. It consists of a single .dae file (text-based).
    /// <see href="https://w3id.org/fog#asCollada_v1.4.1"></see></summary>
    let ``asCollada_v1.4.1`` =
        Namespaced_IRI.parse _namespace_name "asCollada_v1.4.1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open COLLADA v1.5.0 format from the Khronos Group. It consists of a single .dae file (text-based).
    /// <see href="https://w3id.org/fog#asCollada_v1.5.0"></see></summary>
    let ``asCollada_v1.5.0`` =
        Namespaced_IRI.parse _namespace_name "asCollada_v1.5.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary DWG format from Autodesk. The Open Design Alliance created a 'specification for .dwg files' that is publicly available. The format consists of a single .dwg file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asDwg_v2018).
    /// <see href="https://w3id.org/fog#asDwg"></see></summary>
    let asDwg = Namespaced_IRI.parse _namespace_name "asDwg" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary DWG v2010 format from Autodesk. It consists of a single .dwg file (binary).
    /// <see href="https://w3id.org/fog#asDwg_v2010"></see></summary>
    let asDwg_v2010 =
        Namespaced_IRI.parse _namespace_name "asDwg_v2010" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary DWG v2013 format from Autodesk. It consists of a single .dwg file (binary).
    /// <see href="https://w3id.org/fog#asDwg_v2013"></see></summary>
    let asDwg_v2013 =
        Namespaced_IRI.parse _namespace_name "asDwg_v2013" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary DWG v2018 format from Autodesk. It consists of a single .dwg file (binary).
    /// <see href="https://w3id.org/fog#asDwg_v2018"></see></summary>
    let asDwg_v2018 =
        Namespaced_IRI.parse _namespace_name "asDwg_v2018" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a point cloud geometry description following the open E57 format developed by the ASTM Committee E57. The format consists of a single .e57 file (partially binary, partially text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asE57_v1.0).
    /// <see href="https://w3id.org/fog#asE57"></see></summary>
    let asE57 = Namespaced_IRI.parse _namespace_name "asE57" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a point cloud geometry description following the open E57 format developed by the ASTM Committee E57. The format consists of a single .e57 file (partially binary, partially text-based).
    /// <see href="https://w3id.org/fog#asE57_v1.0"></see></summary>
    let ``asE57_v1.0`` =
        Namespaced_IRI.parse _namespace_name "asE57_v1.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open GeoJSON format. The format consists of a single .json file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asGeojson_v2016). Note that the version proposed by the IETF GeoJSON Working Group (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).
    /// <see href="https://w3id.org/fog#asGeojson"></see></summary>
    let asGeojson = Namespaced_IRI.parse _namespace_name "asGeojson" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a GeoJSON-LD geometry description: a GeoJSON geometry description complemented with the corresponding JSON-LD context to make it RDF. It should be connected to the topnode of the geometry description. Note that this geometry description can only be used to depict single points, as the current JSON-LD specification v1.0 does not implement the deserialisation of nested lists to RDF
    /// <see href="https://w3id.org/fog#asGeojson-ld"></see></summary>
    let ``asGeojson-ld`` =
        Namespaced_IRI.parse _namespace_name "asGeojson-ld" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open GeoJSON v2008 format. The format consists of a single .json file (text-based). Note that the version proposed by the IETF (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).
    /// <see href="https://w3id.org/fog#asGeojson_v2008"></see></summary>
    let asGeojson_v2008 =
        Namespaced_IRI.parse _namespace_name "asGeojson_v2008" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open GeoJSON v2016 format developed by the IETF GeoJSON Working Group. The format consists of a single .json file (text-based). Note that the version proposed by the IETF (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).
    /// <see href="https://w3id.org/fog#asGeojson_v2016"></see></summary>
    let asGeojson_v2016 =
        Namespaced_IRI.parse _namespace_name "asGeojson_v2016" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the GEOM ontology. It should be connected to the topnode of the geometry description.
    /// <see href="https://w3id.org/fog#asGeomOntology"></see></summary>
    let asGeomOntology =
        Namespaced_IRI.parse _namespace_name "asGeomOntology" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open glTF format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders, or .glb) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asGltf_v2.0-gltf).
    /// <see href="https://w3id.org/fog#asGltf"></see></summary>
    let asGltf = Namespaced_IRI.parse _namespace_name "asGltf" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open glTF v1.0 format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subproperties (e.g. fog:asGltf_v1.0-gltf).
    /// <see href="https://w3id.org/fog#asGltf_v1.0"></see></summary>
    let ``asGltf_v1.0`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v1.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary geometry file (.bin) following the open glTF v1.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.
    /// <see href="https://w3id.org/fog#asGltf_v1.0-bin"></see></summary>
    let ``asGltf_v1.0-bin`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v1.0-bin" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based shader file (.glsl) following the open glTF v1.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.
    /// <see href="https://w3id.org/fog#asGltf_v1.0-glsl"></see></summary>
    let ``asGltf_v1.0-glsl`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v1.0-glsl" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a JSON file (.gltf) following the open glTF v1.0 format from the Khronos Group. This file can be used on its own if geometry, shaders and optional textures are embedded (text-based) inside the JSON. In most cases however, it references other files containing geometry (.bin), optional shaders (.glsl) and optional textures (.bmp/.gif/.jpeg/.png).
    /// <see href="https://w3id.org/fog#asGltf_v1.0-gltf"></see></summary>
    let ``asGltf_v1.0-gltf`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v1.0-gltf" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary texture file (.bmp/..gif/.jpeg/.png). This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.
    /// <see href="https://w3id.org/fog#asGltf_v1.0-texture"></see></summary>
    let ``asGltf_v1.0-texture`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v1.0-texture" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open glTF v2.0 format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders, or .glb) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subproperties (e.g. fog:asGltf_v2.0-gltf).
    /// <see href="https://w3id.org/fog#asGltf_v2.0"></see></summary>
    let ``asGltf_v2.0`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v2.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary geometry file (.bin) following the open glTF v2.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v2.0-gltf) referencing it.
    /// <see href="https://w3id.org/fog#asGltf_v2.0-bin"></see></summary>
    let ``asGltf_v2.0-bin`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v2.0-bin" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary file (.glb) following the open glTF v2.0 format from the Khronos Group. This one file contains geometry and textures, and as a result can be used without other files.
    /// <see href="https://w3id.org/fog#asGltf_v2.0-glb"></see></summary>
    let ``asGltf_v2.0-glb`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v2.0-glb" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a JSON file (.gltf) following the open glTF v2.0 format from the Khronos Group. This file can be used on its own if geometry and optional textures are embedded (text-based) inside the JSON. In most cases however, it references other files containing geometry (.bin) and optional textures (.jpeg/.png).
    /// <see href="https://w3id.org/fog#asGltf_v2.0-gltf"></see></summary>
    let ``asGltf_v2.0-gltf`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v2.0-gltf" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary texture file (.jpeg/.png). This file always has to be used together with the central .gltf JSON file (fog:asGltf_v2.0-gltf) referencing it.
    /// <see href="https://w3id.org/fog#asGltf_v2.0-texture"></see></summary>
    let ``asGltf_v2.0-texture`` =
        Namespaced_IRI.parse _namespace_name "asGltf_v2.0-texture" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following one of the open GML formats developed by OGC and ISO. The format consists of a single .gml file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asGml_v3.3.0). Note that this property is disjoint with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.
    /// <see href="https://w3id.org/fog#asGml"></see></summary>
    let asGml = Namespaced_IRI.parse _namespace_name "asGml" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.1.1 format developed by OGC and ISO. Note that this and older versions are considered depreciated. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.
    /// <see href="https://w3id.org/fog#asGml_v3.1.1"></see></summary>
    let ``asGml_v3.1.1`` =
        Namespaced_IRI.parse _namespace_name "asGml_v3.1.1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.2.1 format developed by OGC and ISO. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.
    /// <see href="https://w3id.org/fog#asGml_v3.2.1"></see></summary>
    let ``asGml_v3.2.1`` =
        Namespaced_IRI.parse _namespace_name "asGml_v3.2.1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.2.2 format developed by OGC and ISO. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.
    /// <see href="https://w3id.org/fog#asGml_v3.2.2"></see></summary>
    let ``asGml_v3.2.2`` =
        Namespaced_IRI.parse _namespace_name "asGml_v3.2.2" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.3.0 format developed by OGC and ISO. This format is an extension of the GML v3.2 format. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.
    /// <see href="https://w3id.org/fog#asGml_v3.3.0"></see></summary>
    let ``asGml_v3.3.0`` =
        Namespaced_IRI.parse _namespace_name "asGml_v3.3.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format as documented by buildingSMART and in its ISO 16739 standard. The format consists of a single .ifc or .ifcxml file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asIfc_v2x4-icfxml).
    /// <see href="https://w3id.org/fog#asIfc"></see></summary>
    let asIfc = Namespaced_IRI.parse _namespace_name "asIfc" |> NamespacedName
    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard
    /// <see href="https://w3id.org/fog#asIfc_v2x3"></see></summary>
    let asIfc_v2x3 = Namespaced_IRI.parse _namespace_name "asIfc_v2x3" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).
    /// <see href="https://w3id.org/fog#asIfc_v2x3-ifc"></see></summary>
    let ``asIfc_v2x3-ifc`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x3-ifc" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.
    /// <see href="https://w3id.org/fog#asIfc_v2x3-ifcxml"></see></summary>
    let ``asIfc_v2x3-ifcxml`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x3-ifcxml" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard
    /// <see href="https://w3id.org/fog#asIfc_v2x3tc1"></see></summary>
    let asIfc_v2x3tc1 =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x3tc1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).
    /// <see href="https://w3id.org/fog#asIfc_v2x3tc1-ifc"></see></summary>
    let ``asIfc_v2x3tc1-ifc`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x3tc1-ifc" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.
    /// <see href="https://w3id.org/fog#asIfc_v2x3tc1-ifcxml"></see></summary>
    let ``asIfc_v2x3tc1-ifcxml`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x3tc1-ifcxml" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard
    /// <see href="https://w3id.org/fog#asIfc_v2x4"></see></summary>
    let asIfc_v2x4 = Namespaced_IRI.parse _namespace_name "asIfc_v2x4" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).
    /// <see href="https://w3id.org/fog#asIfc_v2x4-ifc"></see></summary>
    let ``asIfc_v2x4-ifc`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4-ifc" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.
    /// <see href="https://w3id.org/fog#asIfc_v2x4-ifcxml"></see></summary>
    let ``asIfc_v2x4-ifcxml`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4-ifcxml" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard
    /// <see href="https://w3id.org/fog#asIfc_v2x4add1"></see></summary>
    let asIfc_v2x4add1 =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4add1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).
    /// <see href="https://w3id.org/fog#asIfc_v2x4add1-ifc"></see></summary>
    let ``asIfc_v2x4add1-ifc`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4add1-ifc" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.
    /// <see href="https://w3id.org/fog#asIfc_v2x4add1-ifcxml"></see></summary>
    let ``asIfc_v2x4add1-ifcxml`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4add1-ifcxml" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard
    /// <see href="https://w3id.org/fog#asIfc_v2x4add2"></see></summary>
    let asIfc_v2x4add2 =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4add2" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).
    /// <see href="https://w3id.org/fog#asIfc_v2x4add2-ifc"></see></summary>
    let ``asIfc_v2x4add2-ifc`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4add2-ifc" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.
    /// <see href="https://w3id.org/fog#asIfc_v2x4add2-ifcxml"></see></summary>
    let ``asIfc_v2x4add2-ifcxml`` =
        Namespaced_IRI.parse _namespace_name "asIfc_v2x4add2-ifcxml" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the IfcOWL ontology.
    /// <see href="https://w3id.org/fog#asIfcowl"></see></summary>
    let asIfcowl = Namespaced_IRI.parse _namespace_name "asIfcowl" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the IfcOWL v2x3 Final ontology.
    /// <see href="https://w3id.org/fog#asIfcowl_v2x3final"></see></summary>
    let asIfcowl_v2x3final =
        Namespaced_IRI.parse _namespace_name "asIfcowl_v2x3final" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the IfcOWL v2x3 TC1 ontology.
    /// <see href="https://w3id.org/fog#asIfcowl_v2x3tc1"></see></summary>
    let asIfcowl_v2x3tc1 =
        Namespaced_IRI.parse _namespace_name "asIfcowl_v2x3tc1" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Add1 ontology.
    /// <see href="https://w3id.org/fog#asIfcowl_v2x4add1"></see></summary>
    let asIfcowl_v2x4add1 =
        Namespaced_IRI.parse _namespace_name "asIfcowl_v2x4add1" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Add2 ontology.
    /// <see href="https://w3id.org/fog#asIfcowl_v2x4add2"></see></summary>
    let asIfcowl_v2x4add2 =
        Namespaced_IRI.parse _namespace_name "asIfcowl_v2x4add2" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Final ontology.
    /// <see href="https://w3id.org/fog#asIfcowl_v2x4final"></see></summary>
    let asIfcowl_v2x4final =
        Namespaced_IRI.parse _namespace_name "asIfcowl_v2x4final" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the IGES format as documented in its ANSI standard. The format consists of a single .iges/.igs file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asIges_v5.3).
    /// <see href="https://w3id.org/fog#asIges"></see></summary>
    let asIges = Namespaced_IRI.parse _namespace_name "asIges" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the IGES format v5.6 as documented in its ANSI standard.
    /// <see href="https://w3id.org/fog#asIges_v5.3"></see></summary>
    let ``asIges_v5.3`` =
        Namespaced_IRI.parse _namespace_name "asIges_v5.3" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the OBJ format developed by Wavefront Technologies. The format consists of a single .obj file and an optional material file (.mtl). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asObj_v3.0-obj).
    /// <see href="https://w3id.org/fog#asObj"></see></summary>
    let asObj = Namespaced_IRI.parse _namespace_name "asObj" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based geometry description following the OBJ v3.0 format developed by Wavefront Technologies. The format consists of a single .obj file and an optional material file (.mtl). It is strongly adviced to use the more specific subproperties (e.g. fog:asObj_v3.0-obj).
    /// <see href="https://w3id.org/fog#asObj_v3.0"></see></summary>
    let ``asObj_v3.0`` =
        Namespaced_IRI.parse _namespace_name "asObj_v3.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based MTL file (.mtl) following the OBJ format developed by Wavefront Technologies. This file has to be used together with the main .obj file that references it.
    /// <see href="https://w3id.org/fog#asObj_v3.0-mtl"></see></summary>
    let ``asObj_v3.0-mtl`` =
        Namespaced_IRI.parse _namespace_name "asObj_v3.0-mtl" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a text-based OBJ file (.obj) following the OBJ format developed by Wavefront Technologies. This file can be used together with an optional material file (.mtl).
    /// <see href="https://w3id.org/fog#asObj_v3.0-obj"></see></summary>
    let ``asObj_v3.0-obj`` =
        Namespaced_IRI.parse _namespace_name "asObj_v3.0-obj" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary texture file that is referenced in the .mtl file of the OBJ format.
    /// <see href="https://w3id.org/fog#asObj_v3.0-texture"></see></summary>
    let ``asObj_v3.0-texture`` =
        Namespaced_IRI.parse _namespace_name "asObj_v3.0-texture" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the OntoBREP ontology. It should be connected to the topnode of the geometry description.
    /// <see href="https://w3id.org/fog#asOntobrepOntology"></see></summary>
    let asOntobrepOntology =
        Namespaced_IRI.parse _namespace_name "asOntobrepOntology" |> NamespacedName

    /// <summary>
    /// The object relation pointing to a RDF-based geometry description following the OntoSTEP ontology. It should be connected to the topnode of the geometry description.
    /// <see href="https://w3id.org/fog#asOntostepOntology"></see></summary>
    let asOntostepOntology =
        Namespaced_IRI.parse _namespace_name "asOntostepOntology" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary encoded point cloud following the open PCD format which was developed as part of the open source project PCL (point cloud library). The format consists of a single .pcd file (binary or text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asPcd_v0.7).
    /// <see href="https://w3id.org/fog#asPcd"></see></summary>
    let asPcd = Namespaced_IRI.parse _namespace_name "asPcd" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary or text-based point cloud following the open PCD v0.7 (sometimes referred to as PCD_v7) format which was developed as part of the open source project PCL (point cloud library).
    /// <see href="https://w3id.org/fog#asPcd_v0.7"></see></summary>
    let ``asPcd_v0.7`` =
        Namespaced_IRI.parse _namespace_name "asPcd_v0.7" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the PLY format which was developed by Greg Turk (Stanford University). The format consists of a single .ply file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asPly_v1.0-ascii).
    /// <see href="https://w3id.org/fog#asPly"></see></summary>
    let asPly = Namespaced_IRI.parse _namespace_name "asPly" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The format consists of a single .ply file which is either text-based or binary. It is strongly adviced to use the more specific subproperties (e.g. fog:asPly_v1.0-ascii).
    /// <see href="https://w3id.org/fog#asPly_v1.0"></see></summary>
    let ``asPly_v1.0`` =
        Namespaced_IRI.parse _namespace_name "asPly_v1.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is text-based.
    /// <see href="https://w3id.org/fog#asPly_v1.0-ascii"></see></summary>
    let ``asPly_v1.0-ascii`` =
        Namespaced_IRI.parse _namespace_name "asPly_v1.0-ascii" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is binary with big endian. Note that there is also a sibling property for a binary PLY with little endian.
    /// <see href="https://w3id.org/fog#asPly_v1.0-binaryBE"></see></summary>
    let ``asPly_v1.0-binaryBE`` =
        Namespaced_IRI.parse _namespace_name "asPly_v1.0-binaryBE" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is binary with little endian. Note that there is also a sibling property for a binary PLY with big endian.
    /// <see href="https://w3id.org/fog#asPly_v1.0-binaryLE"></see></summary>
    let ``asPly_v1.0-binaryLE`` =
        Namespaced_IRI.parse _namespace_name "asPly_v1.0-binaryLE" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Revit format (Autodesk). The format consists of a single .rvt file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asRevit_v2020)
    /// <see href="https://w3id.org/fog#asRevit"></see></summary>
    let asRevit = Namespaced_IRI.parse _namespace_name "asRevit" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Revit v2017 format (Autodesk). The format consists of a single .rvt file (binary).
    /// <see href="https://w3id.org/fog#asRevit_v2017"></see></summary>
    let asRevit_v2017 =
        Namespaced_IRI.parse _namespace_name "asRevit_v2017" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Revit v2018 format (Autodesk). The format consists of a single .rvt file (binary).
    /// <see href="https://w3id.org/fog#asRevit_v2018"></see></summary>
    let asRevit_v2018 =
        Namespaced_IRI.parse _namespace_name "asRevit_v2018" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Revit v2019 format (Autodesk). The format consists of a single .rvt file (binary).
    /// <see href="https://w3id.org/fog#asRevit_v2019"></see></summary>
    let asRevit_v2019 =
        Namespaced_IRI.parse _namespace_name "asRevit_v2019" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Revit v2020 format (Autodesk). The format consists of a single .rvt file (binary).
    /// <see href="https://w3id.org/fog#asRevit_v2020"></see></summary>
    let asRevit_v2020 =
        Namespaced_IRI.parse _namespace_name "asRevit_v2020" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Rhinoceros format (McNeel). The format consists of a single .3dm file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asRhino_v6)
    /// <see href="https://w3id.org/fog#asRhino"></see></summary>
    let asRhino = Namespaced_IRI.parse _namespace_name "asRhino" |> NamespacedName
    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Rhinoceros format v5 (McNeel). The format consists of a single .3dm file (binary).
    /// <see href="https://w3id.org/fog#asRhino_v5"></see></summary>
    let asRhino_v5 = Namespaced_IRI.parse _namespace_name "asRhino_v5" |> NamespacedName
    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary Rhinoceros format v6 (McNeel). The format consists of a single .3dm file (binary).
    /// <see href="https://w3id.org/fog#asRhino_v6"></see></summary>
    let asRhino_v6 = Namespaced_IRI.parse _namespace_name "asRhino_v6" |> NamespacedName
    /// <summary>
    /// The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) standard developed by the OGC and ISO. The format consists of a single .wkt (text-based) or .wkb (binary) file. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asSfa_v2-wkt).
    /// <see href="https://w3id.org/fog#asSfa"></see></summary>
    let asSfa = Namespaced_IRI.parse _namespace_name "asSfa" |> NamespacedName
    /// <summary>
    /// The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) v1 standard developed by the OGC. The format is text-based. It is strongly adviced to use the more specific subproperties (e.g. fog:asSfa_v1-wkt). Note that this standard is now considered depreciated in favor of SFA v2.
    /// <see href="https://w3id.org/fog#asSfa_v1"></see></summary>
    let asSfa_v1 = Namespaced_IRI.parse _namespace_name "asSfa_v1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a Well Know Text (WKT) geometry following the open Simple Feature Access (SFA) v1 standard developed by the OGC. The format is text-based. Note that the SFA v1 standard is now considered depreciated in favor of SFA v2. Note that this property is disjoint with geo:asWKT because of the more strict domain and range restrictions in GeoSPARQL.
    /// <see href="https://w3id.org/fog#asSfa_v1-wkt"></see></summary>
    let ``asSfa_v1-wkt`` =
        Namespaced_IRI.parse _namespace_name "asSfa_v1-wkt" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO. The format is either text-based (WKT) or binary (WKB). It is strongly adviced to use the more specific subproperties (e.g. fog:asSfa_v2-wkt).
    /// <see href="https://w3id.org/fog#asSfa_v2"></see></summary>
    let asSfa_v2 = Namespaced_IRI.parse _namespace_name "asSfa_v2" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a Well Know Binary (WKB) geometry following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO.
    /// <see href="https://w3id.org/fog#asSfa_v2-wkb"></see></summary>
    let ``asSfa_v2-wkb`` =
        Namespaced_IRI.parse _namespace_name "asSfa_v2-wkb" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a Well Know Text (WKT) geometry following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO. The format is text-based. Note that this property is disjoint with geo:asWKT because of the more strict domain and range restrictions in GeoSPARQL.
    /// <see href="https://w3id.org/fog#asSfa_v2-wkt"></see></summary>
    let ``asSfa_v2-wkt`` =
        Namespaced_IRI.parse _namespace_name "asSfa_v2-wkt" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open Shapefile format developed by ESRI. The format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asShapefile-shp). Note that no file format version is provided by ESRI and that the format is expected to be stable.
    /// <see href="https://w3id.org/fog#asShapefile"></see></summary>
    let asShapefile =
        Namespaced_IRI.parse _namespace_name "asShapefile" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a dBASE table file (.dbf) following the open Shapefile format developed by ESRI. This file contains the attributes of each shape. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).
    /// <see href="https://w3id.org/fog#asShapefile-dbf"></see></summary>
    let ``asShapefile-dbf`` =
        Namespaced_IRI.parse _namespace_name "asShapefile-dbf" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a projection format file (.prj) following the open Shapefile format developed by ESRI. This file contains the the coordinate system and projection information of the shapes. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).
    /// <see href="https://w3id.org/fog#asShapefile-prj"></see></summary>
    let ``asShapefile-prj`` =
        Namespaced_IRI.parse _namespace_name "asShapefile-prj" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry file (.shp) following the open Shapefile format developed by ESRI. This file contains the geometry of the shape. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).
    /// <see href="https://w3id.org/fog#asShapefile-shp"></see></summary>
    let ``asShapefile-shp`` =
        Namespaced_IRI.parse _namespace_name "asShapefile-shp" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a shape index format file (.shx) following the open Shapefile format developed by ESRI. This file contains the positional index of the geometry. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).
    /// <see href="https://w3id.org/fog#asShapefile-shx"></see></summary>
    let ``asShapefile-shx`` =
        Namespaced_IRI.parse _namespace_name "asShapefile-shx" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary SketchUp format (Trimble). The format consists of a single .skp file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asSketchUp_v2019)
    /// <see href="https://w3id.org/fog#asSketchUp"></see></summary>
    let asSketchUp = Namespaced_IRI.parse _namespace_name "asSketchUp" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary SketchUp v2017 format (Trimble). The format consists of a single .skp file (binary).
    /// <see href="https://w3id.org/fog#asSketchUp_v2017"></see></summary>
    let asSketchUp_v2017 =
        Namespaced_IRI.parse _namespace_name "asSketchUp_v2017" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary SketchUp v2018 format (Trimble). The format consists of a single .skp file (binary).
    /// <see href="https://w3id.org/fog#asSketchUp_v2018"></see></summary>
    let asSketchUp_v2018 =
        Namespaced_IRI.parse _namespace_name "asSketchUp_v2018" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the proprietary SketchUp v2019 format (Trimble). The format consists of a single .skp file (binary).
    /// <see href="https://w3id.org/fog#asSketchUp_v2019"></see></summary>
    let asSketchUp_v2019 =
        Namespaced_IRI.parse _namespace_name "asSketchUp_v2019" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. It is strongly adviced to use more specific subproperties.
    /// <see href="https://w3id.org/fog#asStep"></see></summary>
    let asStep = Namespaced_IRI.parse _namespace_name "asStep" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. The STEP file is structured according to the Application Profile (AP) 214 - Core data for automative mechanical design processes.
    /// <see href="https://w3id.org/fog#asStep_ap214"></see></summary>
    let asStep_ap214 =
        Namespaced_IRI.parse _namespace_name "asStep_ap214" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. The STEP file is structured according to the Application Profile (AP) 242 - Managed model-based 3D engineering.
    /// <see href="https://w3id.org/fog#asStep_ap242"></see></summary>
    let asStep_ap242 =
        Namespaced_IRI.parse _namespace_name "asStep_ap242" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the STL format which was developed by 3D Systems. The format consists of a single .stl file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asStl_v1.0-ascii).
    /// <see href="https://w3id.org/fog#asStl"></see></summary>
    let asStl = Namespaced_IRI.parse _namespace_name "asStl" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asStl_v1.0-ascii)
    /// <see href="https://w3id.org/fog#asStl_v1.0"></see></summary>
    let ``asStl_v1.0`` =
        Namespaced_IRI.parse _namespace_name "asStl_v1.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is text-based.
    /// <see href="https://w3id.org/fog#asStl_v1.0-ascii"></see></summary>
    let ``asStl_v1.0-ascii`` =
        Namespaced_IRI.parse _namespace_name "asStl_v1.0-ascii" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is binary.
    /// <see href="https://w3id.org/fog#asStl_v1.0-binary"></see></summary>
    let ``asStl_v1.0-binary`` =
        Namespaced_IRI.parse _namespace_name "asStl_v1.0-binary" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open SVG format which was developed by the W3C. The format consists of a single .svg file which is text-based. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asSvg_v1.1).
    /// <see href="https://w3id.org/fog#asSvg"></see></summary>
    let asSvg = Namespaced_IRI.parse _namespace_name "asSvg" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open SVG v1.0 format which was developed by the W3C. The format consists of a single .svg file which is text-based. Note that this version (v1.0) is considered depreciated in favor of v1.1.
    /// <see href="https://w3id.org/fog#asSvg_v1.0"></see></summary>
    let ``asSvg_v1.0`` =
        Namespaced_IRI.parse _namespace_name "asSvg_v1.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open SVG v1.1 format which was developed by the W3C. The format consists of a single .svg file which is text-based.
    /// <see href="https://w3id.org/fog#asSvg_v1.1"></see></summary>
    let ``asSvg_v1.1`` =
        Namespaced_IRI.parse _namespace_name "asSvg_v1.1" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open SVG v2.0 format which was developed by the W3C. The format consists of a single .svg file which is text-based. Note that this version (v2.0) is not yet finalized and at the moment has the status of 'W3C Candidate Recommendation'.
    /// <see href="https://w3id.org/fog#asSvg_v2.0"></see></summary>
    let ``asSvg_v2.0`` =
        Namespaced_IRI.parse _namespace_name "asSvg_v2.0" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open X3D format which was developed by the Web3D. The format consists of a single file which is either binary or text-based. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asX3d_v3.3_xml).
    /// <see href="https://w3id.org/fog#asX3d"></see></summary>
    let asX3d = Namespaced_IRI.parse _namespace_name "asX3d" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a geometry description following the open X3D v3.3 format which was developed by the Web3D. The format consists of a single file which is either binary or text-based. It is strongly adviced to use the more specific subproperties (e.g. fog:asX3d_v3.3_xml).
    /// <see href="https://w3id.org/fog#asX3d_v3.3"></see></summary>
    let ``asX3d_v3.3`` =
        Namespaced_IRI.parse _namespace_name "asX3d_v3.3" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a binary X3D file (.x3db) following the open X3D v3.3 format which was developed by the Web3D.
    /// <see href="https://w3id.org/fog#asX3d_v3.3-binary"></see></summary>
    let ``asX3d_v3.3-binary`` =
        Namespaced_IRI.parse _namespace_name "asX3d_v3.3-binary" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a classic VRML X3D file (.x3dv) following the open X3D v3.3 format which was developed by the Web3D. The file is text-based.
    /// <see href="https://w3id.org/fog#asX3d_v3.3-vrml"></see></summary>
    let ``asX3d_v3.3-vrml`` =
        Namespaced_IRI.parse _namespace_name "asX3d_v3.3-vrml" |> NamespacedName

    /// <summary>
    /// The datatype relation pointing to a regular X3D file (.x3d) following the open X3D v3.3 format which was developed by the Web3D. The file is text-based.
    /// <see href="https://w3id.org/fog#asX3d_v3.3-xml"></see></summary>
    let ``asX3d_v3.3-xml`` =
        Namespaced_IRI.parse _namespace_name "asX3d_v3.3-xml" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/fog#hasReferencedContent"></see>
    /// </summary>
    let hasReferencedContent =
        Namespaced_IRI.parse _namespace_name "hasReferencedContent" |> NamespacedName
