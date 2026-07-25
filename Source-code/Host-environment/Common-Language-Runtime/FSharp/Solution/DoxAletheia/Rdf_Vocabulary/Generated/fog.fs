namespace https.w3id.org.fog.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fog =
    let _namespace_iri = Namespace_Iri fog |> NamespaceIRI
    /// <summary>
    ///   <para>fog:asGltf_v1.0-bin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a binary geometry file (.bin) following the open glTF v1.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.</para>
    /// labels<para>as glTF v1.0 geometry file (.bin)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v1.0-bin">https://w3id.org/fog#asGltf_v1.0-bin</seealso>
    let ``asGltf_v1.0_bin`` = Prefixed_Name(fog, "asGltf_v1.0-bin") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGltf_v2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open glTF v2.0 format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders, or .glb) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subproperties (e.g. fog:asGltf_v2.0-gltf).</para>
    /// labels<para>as glTF v2.0 format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v2.0">https://w3id.org/fog#asGltf_v2.0</seealso>
    let ``asGltf_v2.0`` = Prefixed_Name(fog, "asGltf_v2.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGltf_v2.0-bin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a binary geometry file (.bin) following the open glTF v2.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v2.0-gltf) referencing it.</para>
    /// labels<para>as glTF v2.0 geometry file (.bin)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v2.0-bin">https://w3id.org/fog#asGltf_v2.0-bin</seealso>
    let ``asGltf_v2.0_bin`` = Prefixed_Name(fog, "asGltf_v2.0-bin") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGml_v3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.1.1 format developed by OGC and ISO. Note that this and older versions are considered depreciated. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    /// labels<para>as GML v3.1.1 format (.gml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGml_v3.1.1">https://w3id.org/fog#asGml_v3.1.1</seealso>
    let ``asGml_v3.1.1`` = Prefixed_Name(fog, "asGml_v3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>fog:ReferencedContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Referenced content of the following geometry descriptions: glTF and OBJ. It contains exactly one link to a texture, separate binary glTF geometry or a OBJ material that is referenced by the main file (resp. .gltf and .obj). The name of the referenced file, as stored in the main file, is connected via a rdfs:label node</para>
    /// labels<para>Referenced content</para></remarks>
    /// <seealso href="https://w3id.org/fog#ReferencedContent">https://w3id.org/fog#ReferencedContent</seealso>
    let ReferencedContent = Prefixed_Name(fog, "ReferencedContent") |> PrefixedName
    /// <summary>
    ///   <para>fog:as3dmo_v1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the 3DMO ontology version 1.1. It should be connected to the topnode of the geometry description</para>
    /// labels<para>as 3DMO v1.1 ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#as3dmo_v1.1">https://w3id.org/fog#as3dmo_v1.1</seealso>
    let ``as3dmo_v1.1`` = Prefixed_Name(fog, "as3dmo_v1.1") |> PrefixedName
    /// <summary>
    ///   <para>fog:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/fog#">https://w3id.org/fog#</seealso>
    let _prefix_iri = Prefixed_Name(fog, "") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGml_v3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.3.0 format developed by OGC and ISO. This format is an extension of the GML v3.2 format. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    /// labels<para>as GML v3.3.0 format (.gml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGml_v3.3.0">https://w3id.org/fog#asGml_v3.3.0</seealso>
    let ``asGml_v3.3.0`` = Prefixed_Name(fog, "asGml_v3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard</para>
    /// labels<para>as IFC v2x3</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x3">https://w3id.org/fog#asIfc_v2x3</seealso>
    let asIfc_v2x3 = Prefixed_Name(fog, "asIfc_v2x3") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x3-ifc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    /// labels<para>as IFC v2x3 file (.ifc)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x3-ifc">https://w3id.org/fog#asIfc_v2x3-ifc</seealso>
    let asIfc_v2x3_ifc = Prefixed_Name(fog, "asIfc_v2x3-ifc") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format as documented by buildingSMART and in its ISO 16739 standard. The format consists of a single .ifc or .ifcxml file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asIfc_v2x4-icfxml).</para>
    /// labels<para>as IFC format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc">https://w3id.org/fog#asIfc</seealso>
    let asIfc = Prefixed_Name(fog, "asIfc") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x3-ifcxml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    /// labels<para>as IFC v2x3 file (.ifcxml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x3-ifcxml">https://w3id.org/fog#asIfc_v2x3-ifcxml</seealso>
    let asIfc_v2x3_ifcxml = Prefixed_Name(fog, "asIfc_v2x3-ifcxml") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x3tc1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard</para>
    /// labels<para>as IFC v2x3 TC1</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x3tc1">https://w3id.org/fog#asIfc_v2x3tc1</seealso>
    let asIfc_v2x3tc1 = Prefixed_Name(fog, "asIfc_v2x3tc1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x3tc1-ifc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    /// labels<para>as IFC v2x3 TC1 file (.ifc)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x3tc1-ifc">https://w3id.org/fog#asIfc_v2x3tc1-ifc</seealso>
    let asIfc_v2x3tc1_ifc = Prefixed_Name(fog, "asIfc_v2x3tc1-ifc") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard</para>
    /// labels<para>as IFC v2x4</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4">https://w3id.org/fog#asIfc_v2x4</seealso>
    let asIfc_v2x4 = Prefixed_Name(fog, "asIfc_v2x4") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x4-ifc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    /// labels<para>as IFC v2x4 file (.ifc)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4-ifc">https://w3id.org/fog#asIfc_v2x4-ifc</seealso>
    let asIfc_v2x4_ifc = Prefixed_Name(fog, "asIfc_v2x4-ifc") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x4add1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard</para>
    /// labels<para>as IFC v2x4 Add1</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4add1">https://w3id.org/fog#asIfc_v2x4add1</seealso>
    let asIfc_v2x4add1 = Prefixed_Name(fog, "asIfc_v2x4add1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x4add1-ifc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    /// labels<para>as IFC v2x4 Add1 file (.ifc)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4add1-ifc">https://w3id.org/fog#asIfc_v2x4add1-ifc</seealso>
    let asIfc_v2x4add1_ifc = Prefixed_Name(fog, "asIfc_v2x4add1-ifc") |> PrefixedName

    /// <summary>
    ///   <para>fog:asIfc_v2x4add1-ifcxml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    /// labels<para>as IFC v2x4 Add1 file (.ifcxml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4add1-ifcxml">https://w3id.org/fog#asIfc_v2x4add1-ifcxml</seealso>
    let asIfc_v2x4add1_ifcxml =
        Prefixed_Name(fog, "asIfc_v2x4add1-ifcxml") |> PrefixedName

    /// <summary>
    ///   <para>fog:asIfc_v2x4add2-ifc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the STEP Physical File Format (SPFF).</para>
    /// labels<para>as IFC v2x4 Add2 file (.ifc)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4add2-ifc">https://w3id.org/fog#asIfc_v2x4add2-ifc</seealso>
    let asIfc_v2x4add2_ifc = Prefixed_Name(fog, "asIfc_v2x4add2-ifc") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfcowl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the IfcOWL ontology.</para>
    /// labels<para>as ifcOWL ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfcowl">https://w3id.org/fog#asIfcowl</seealso>
    let asIfcowl = Prefixed_Name(fog, "asIfcowl") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfcowl_v2x3final</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the IfcOWL v2x3 Final ontology.</para>
    /// labels<para>as ifcOWL v2x3 Final ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfcowl_v2x3final">https://w3id.org/fog#asIfcowl_v2x3final</seealso>
    let asIfcowl_v2x3final = Prefixed_Name(fog, "asIfcowl_v2x3final") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfcowl_v2x4add1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Add1 ontology.</para>
    /// labels<para>as ifcOWL v2x4 Add1 ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfcowl_v2x4add1">https://w3id.org/fog#asIfcowl_v2x4add1</seealso>
    let asIfcowl_v2x4add1 = Prefixed_Name(fog, "asIfcowl_v2x4add1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfcowl_v2x4add2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Add2 ontology.</para>
    /// labels<para>as ifcOWL v2x4 Add2 ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfcowl_v2x4add2">https://w3id.org/fog#asIfcowl_v2x4add2</seealso>
    let asIfcowl_v2x4add2 = Prefixed_Name(fog, "asIfcowl_v2x4add2") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the IGES format as documented in its ANSI standard. The format consists of a single .iges/.igs file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asIges_v5.3).</para>
    /// labels<para>as IGES format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIges">https://w3id.org/fog#asIges</seealso>
    let asIges = Prefixed_Name(fog, "asIges") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIges_v5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the IGES format v5.6 as documented in its ANSI standard.</para>
    /// labels<para>as IGES v5.3 (.igs)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIges_v5.3">https://w3id.org/fog#asIges_v5.3</seealso>
    let ``asIges_v5.3`` = Prefixed_Name(fog, "asIges_v5.3") |> PrefixedName
    /// <summary>
    ///   <para>fog:asObj_v3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the OBJ v3.0 format developed by Wavefront Technologies. The format consists of a single .obj file and an optional material file (.mtl). It is strongly adviced to use the more specific subproperties (e.g. fog:asObj_v3.0-obj).</para>
    /// labels<para>as OBJ v3.0 format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asObj_v3.0">https://w3id.org/fog#asObj_v3.0</seealso>
    let ``asObj_v3.0`` = Prefixed_Name(fog, "asObj_v3.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asObj_v3.0-mtl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based MTL file (.mtl) following the OBJ format developed by Wavefront Technologies. This file has to be used together with the main .obj file that references it.</para>
    /// labels<para>as OBJ v3.0 material file (.mtl)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asObj_v3.0-mtl">https://w3id.org/fog#asObj_v3.0-mtl</seealso>
    let ``asObj_v3.0_mtl`` = Prefixed_Name(fog, "asObj_v3.0-mtl") |> PrefixedName
    /// <summary>
    ///   <para>fog:asObj_v3.0-obj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based OBJ file (.obj) following the OBJ format developed by Wavefront Technologies. This file can be used together with an optional material file (.mtl).</para>
    /// labels<para>as OBJ v3.0 file (.obj)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asObj_v3.0-obj">https://w3id.org/fog#asObj_v3.0-obj</seealso>
    let ``asObj_v3.0_obj`` = Prefixed_Name(fog, "asObj_v3.0-obj") |> PrefixedName

    /// <summary>
    ///   <para>fog:asObj_v3.0-texture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a binary texture file that is referenced in the .mtl file of the OBJ format.</para>
    /// labels<para>as OBJ texture</para></remarks>
    /// <seealso href="https://w3id.org/fog#asObj_v3.0-texture">https://w3id.org/fog#asObj_v3.0-texture</seealso>
    let ``asObj_v3.0_texture`` =
        Prefixed_Name(fog, "asObj_v3.0-texture") |> PrefixedName

    /// <summary>
    ///   <para>fog:asOntostepOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the OntoSTEP ontology. It should be connected to the topnode of the geometry description.</para>
    /// labels<para>as OntoSTEP ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asOntostepOntology">https://w3id.org/fog#asOntostepOntology</seealso>
    let asOntostepOntology = Prefixed_Name(fog, "asOntostepOntology") |> PrefixedName
    /// <summary>
    ///   <para>fog:asPcd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a binary encoded point cloud following the open PCD format which was developed as part of the open source project PCL (point cloud library). The format consists of a single .pcd file (binary or text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asPcd_v0.7).</para>
    /// labels<para>as PCD point cloud format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asPcd">https://w3id.org/fog#asPcd</seealso>
    let asPcd = Prefixed_Name(fog, "asPcd") |> PrefixedName
    /// <summary>
    ///   <para>fog:asPcd_v0.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a binary or text-based point cloud following the open PCD v0.7 (sometimes referred to as PCD_v7) format which was developed as part of the open source project PCL (point cloud library).</para>
    /// labels<para>as PCD v0.7 point cloud format (.pcd)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asPcd_v0.7">https://w3id.org/fog#asPcd_v0.7</seealso>
    let ``asPcd_v0.7`` = Prefixed_Name(fog, "asPcd_v0.7") |> PrefixedName
    /// <summary>
    ///   <para>fog:asPly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the PLY format which was developed by Greg Turk (Stanford University). The format consists of a single .ply file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asPly_v1.0-ascii).</para>
    /// labels<para>as PLY format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asPly">https://w3id.org/fog#asPly</seealso>
    let asPly = Prefixed_Name(fog, "asPly") |> PrefixedName
    /// <summary>
    ///   <para>fog:asPly_v1.0-ascii</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is text-based.</para>
    /// labels<para>as PLY ASCII format (.ply)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asPly_v1.0-ascii">https://w3id.org/fog#asPly_v1.0-ascii</seealso>
    let ``asPly_v1.0_ascii`` = Prefixed_Name(fog, "asPly_v1.0-ascii") |> PrefixedName

    /// <summary>
    ///   <para>fog:asPly_v1.0-binaryBE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is binary with big endian. Note that there is also a sibling property for a binary PLY with little endian.</para>
    /// labels<para>as PLY binary (big endian) format (.ply)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asPly_v1.0-binaryBE">https://w3id.org/fog#asPly_v1.0-binaryBE</seealso>
    let ``asPly_v1.0_binaryBE`` =
        Prefixed_Name(fog, "asPly_v1.0-binaryBE") |> PrefixedName

    /// <summary>
    ///   <para>fog:asRevit_v2017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Revit v2017 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    /// labels<para>as Revit format v2017 (.rvt)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRevit_v2017">https://w3id.org/fog#asRevit_v2017</seealso>
    let asRevit_v2017 = Prefixed_Name(fog, "asRevit_v2017") |> PrefixedName
    /// <summary>
    ///   <para>fog:asRevit_v2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Revit v2018 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    /// labels<para>as Revit format v2018 (.rvt)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRevit_v2018">https://w3id.org/fog#asRevit_v2018</seealso>
    let asRevit_v2018 = Prefixed_Name(fog, "asRevit_v2018") |> PrefixedName
    /// <summary>
    ///   <para>fog:asCollada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open COLLADA format from the Khronos Group. The format consists of a single .dae file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asCollada_v1.4.1).</para>
    /// labels<para>as COLLADA format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asCollada">https://w3id.org/fog#asCollada</seealso>
    let asCollada = Prefixed_Name(fog, "asCollada") |> PrefixedName
    /// <summary>
    ///   <para>fog:asRevit_v2020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Revit v2020 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    /// labels<para>as Revit format v2020 (.rvt)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRevit_v2020">https://w3id.org/fog#asRevit_v2020</seealso>
    let asRevit_v2020 = Prefixed_Name(fog, "asRevit_v2020") |> PrefixedName
    /// <summary>
    ///   <para>fog:asRhino_v5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Rhinoceros format v5 (McNeel). The format consists of a single .3dm file (binary).</para>
    /// labels<para>as Rhino format v5 (.3dm)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRhino_v5">https://w3id.org/fog#asRhino_v5</seealso>
    let asRhino_v5 = Prefixed_Name(fog, "asRhino_v5") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSfa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) standard developed by the OGC and ISO. The format consists of a single .wkt (text-based) or .wkb (binary) file. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asSfa_v2-wkt).</para>
    /// labels<para>as Simple Feature Access geometry format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSfa">https://w3id.org/fog#asSfa</seealso>
    let asSfa = Prefixed_Name(fog, "asSfa") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSfa_v2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO. The format is either text-based (WKT) or binary (WKB). It is strongly adviced to use the more specific subproperties (e.g. fog:asSfa_v2-wkt).</para>
    /// labels<para>as Simple Feature Access v2 format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSfa_v2">https://w3id.org/fog#asSfa_v2</seealso>
    let asSfa_v2 = Prefixed_Name(fog, "asSfa_v2") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSfa_v2-wkt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a Well Know Text (WKT) geometry following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO. The format is text-based. Note that this property is disjoint with geo:asWKT because of the more strict domain and range restrictions in GeoSPARQL.</para>
    /// labels<para>as Well Known Text SFA v2 geometry</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSfa_v2-wkt">https://w3id.org/fog#asSfa_v2-wkt</seealso>
    let asSfa_v2_wkt = Prefixed_Name(fog, "asSfa_v2-wkt") |> PrefixedName
    /// <summary>
    ///   <para>fog:asShapefile-dbf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a dBASE table file (.dbf) following the open Shapefile format developed by ESRI. This file contains the attributes of each shape. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    /// labels<para>as Shapefile dBASE table (.dbf)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asShapefile-dbf">https://w3id.org/fog#asShapefile-dbf</seealso>
    let asShapefile_dbf = Prefixed_Name(fog, "asShapefile-dbf") |> PrefixedName
    /// <summary>
    ///   <para>fog:asShapefile-shp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry file (.shp) following the open Shapefile format developed by ESRI. This file contains the geometry of the shape. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    /// labels<para>as Shapefile geometry (.shp)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asShapefile-shp">https://w3id.org/fog#asShapefile-shp</seealso>
    let asShapefile_shp = Prefixed_Name(fog, "asShapefile-shp") |> PrefixedName

    /// <summary>
    ///   <para>fog:asIfc_v2x3tc1-ifcxml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x3 TC1 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    /// labels<para>as IFC v2x3 TC1 file (.ifcxml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x3tc1-ifcxml">https://w3id.org/fog#asIfc_v2x3tc1-ifcxml</seealso>
    let asIfc_v2x3tc1_ifcxml =
        Prefixed_Name(fog, "asIfc_v2x3tc1-ifcxml") |> PrefixedName

    /// <summary>
    ///   <para>fog:asIfc_v2x4-ifcxml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    /// labels<para>as IFC v2x4 file (.ifcxml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4-ifcxml">https://w3id.org/fog#asIfc_v2x4-ifcxml</seealso>
    let asIfc_v2x4_ifcxml = Prefixed_Name(fog, "asIfc_v2x4-ifcxml") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfc_v2x4add2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard</para>
    /// labels<para>as IFC v2x4 Add2</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4add2">https://w3id.org/fog#asIfc_v2x4add2</seealso>
    let asIfc_v2x4add2 = Prefixed_Name(fog, "asIfc_v2x4add2") |> PrefixedName

    /// <summary>
    ///   <para>fog:asIfc_v2x4add2-ifcxml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the open IFC format v2x4 Add2 as documented by buildingSMART and in its ISO 16739 standard. The IFC file is serialised in the XML format.</para>
    /// labels<para>as IFC v2x4 Add 2 file (.ifcxml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfc_v2x4add2-ifcxml">https://w3id.org/fog#asIfc_v2x4add2-ifcxml</seealso>
    let asIfc_v2x4add2_ifcxml =
        Prefixed_Name(fog, "asIfc_v2x4add2-ifcxml") |> PrefixedName

    /// <summary>
    ///   <para>fog:asIfcowl_v2x3tc1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the IfcOWL v2x3 TC1 ontology.</para>
    /// labels<para>as ifcOWL v2x3 TC1 ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfcowl_v2x3tc1">https://w3id.org/fog#asIfcowl_v2x3tc1</seealso>
    let asIfcowl_v2x3tc1 = Prefixed_Name(fog, "asIfcowl_v2x3tc1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asObj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following the OBJ format developed by Wavefront Technologies. The format consists of a single .obj file and an optional material file (.mtl). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asObj_v3.0-obj).</para>
    /// labels<para>as OBJ format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asObj">https://w3id.org/fog#asObj</seealso>
    let asObj = Prefixed_Name(fog, "asObj") |> PrefixedName
    /// <summary>
    ///   <para>fog:asOntobrepOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the OntoBREP ontology. It should be connected to the topnode of the geometry description.</para>
    /// labels<para>as OntoBREP ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asOntobrepOntology">https://w3id.org/fog#asOntobrepOntology</seealso>
    let asOntobrepOntology = Prefixed_Name(fog, "asOntobrepOntology") |> PrefixedName
    /// <summary>
    ///   <para>fog:asPly_v1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The format consists of a single .ply file which is either text-based or binary. It is strongly adviced to use the more specific subproperties (e.g. fog:asPly_v1.0-ascii).</para>
    /// labels<para>as PLY v1.0 format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asPly_v1.0">https://w3id.org/fog#asPly_v1.0</seealso>
    let ``asPly_v1.0`` = Prefixed_Name(fog, "asPly_v1.0") |> PrefixedName

    /// <summary>
    ///   <para>fog:asPly_v1.0-binaryLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry file following the PLY v1.0 format which was developed by Greg Turk (Stanford University). The single .ply file is binary with little endian. Note that there is also a sibling property for a binary PLY with big endian.</para>
    /// labels<para>as PLY binary (little endian) format (.ply)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asPly_v1.0-binaryLE">https://w3id.org/fog#asPly_v1.0-binaryLE</seealso>
    let ``asPly_v1.0_binaryLE`` =
        Prefixed_Name(fog, "asPly_v1.0-binaryLE") |> PrefixedName

    /// <summary>
    ///   <para>fog:asRevit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Revit format (Autodesk). The format consists of a single .rvt file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asRevit_v2020)</para>
    /// labels<para>as Revit format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRevit">https://w3id.org/fog#asRevit</seealso>
    let asRevit = Prefixed_Name(fog, "asRevit") |> PrefixedName
    /// <summary>
    ///   <para>fog:asRevit_v2019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Revit v2019 format (Autodesk). The format consists of a single .rvt file (binary).</para>
    /// labels<para>as Revit format v2019 (.rvt)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRevit_v2019">https://w3id.org/fog#asRevit_v2019</seealso>
    let asRevit_v2019 = Prefixed_Name(fog, "asRevit_v2019") |> PrefixedName
    /// <summary>
    ///   <para>fog:asRhino</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Rhinoceros format (McNeel). The format consists of a single .3dm file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asRhino_v6)</para>
    /// labels<para>as Rhino format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRhino">https://w3id.org/fog#asRhino</seealso>
    let asRhino = Prefixed_Name(fog, "asRhino") |> PrefixedName
    /// <summary>
    ///   <para>fog:asRhino_v6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary Rhinoceros format v6 (McNeel). The format consists of a single .3dm file (binary).</para>
    /// labels<para>as Rhino format v6 (.3dm)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asRhino_v6">https://w3id.org/fog#asRhino_v6</seealso>
    let asRhino_v6 = Prefixed_Name(fog, "asRhino_v6") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSfa_v1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open Simple Feature Access (SFA) v1 standard developed by the OGC. The format is text-based. It is strongly adviced to use the more specific subproperties (e.g. fog:asSfa_v1-wkt). Note that this standard is now considered depreciated in favor of SFA v2.</para>
    /// labels<para>as Simple Feature Access v1 format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSfa_v1">https://w3id.org/fog#asSfa_v1</seealso>
    let asSfa_v1 = Prefixed_Name(fog, "asSfa_v1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSfa_v1-wkt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a Well Know Text (WKT) geometry following the open Simple Feature Access (SFA) v1 standard developed by the OGC. The format is text-based. Note that the SFA v1 standard is now considered depreciated in favor of SFA v2. Note that this property is disjoint with geo:asWKT because of the more strict domain and range restrictions in GeoSPARQL.</para>
    /// labels<para>as Well Known Text SFA v1 geometry</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSfa_v1-wkt">https://w3id.org/fog#asSfa_v1-wkt</seealso>
    let asSfa_v1_wkt = Prefixed_Name(fog, "asSfa_v1-wkt") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSfa_v2-wkb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a Well Know Binary (WKB) geometry following the open Simple Feature Access (SFA) v2 standard developed by the OGC and ISO.</para>
    /// labels<para>as Well Known Binary SFA v2 geometry</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSfa_v2-wkb">https://w3id.org/fog#asSfa_v2-wkb</seealso>
    let asSfa_v2_wkb = Prefixed_Name(fog, "asSfa_v2-wkb") |> PrefixedName
    /// <summary>
    ///   <para>fog:asShapefile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open Shapefile format developed by ESRI. The format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asShapefile-shp). Note that no file format version is provided by ESRI and that the format is expected to be stable.</para>
    /// labels<para>as Shapefile format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asShapefile">https://w3id.org/fog#asShapefile</seealso>
    let asShapefile = Prefixed_Name(fog, "asShapefile") |> PrefixedName
    /// <summary>
    ///   <para>fog:asShapefile-prj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a projection format file (.prj) following the open Shapefile format developed by ESRI. This file contains the the coordinate system and projection information of the shapes. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    /// labels<para>as Shapefile projections file (.prj)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asShapefile-prj">https://w3id.org/fog#asShapefile-prj</seealso>
    let asShapefile_prj = Prefixed_Name(fog, "asShapefile-prj") |> PrefixedName
    /// <summary>
    ///   <para>fog:asShapefile-shx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a shape index format file (.shx) following the open Shapefile format developed by ESRI. This file contains the positional index of the geometry. The Shapefile format consists of multiple files, including as a minimum the geometry (.shp), the index of the feature geometry (.shx) and attribute information of features (.dbf). These three files are binary, while others can be text-based (e.g. the .prj file).</para>
    /// labels<para>as Shapefile geometry index (.shx)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asShapefile-shx">https://w3id.org/fog#asShapefile-shx</seealso>
    let asShapefile_shx = Prefixed_Name(fog, "asShapefile-shx") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSketchUp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary SketchUp format (Trimble). The format consists of a single .skp file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asSketchUp_v2019)</para>
    /// labels<para>as SketchUp format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSketchUp">https://w3id.org/fog#asSketchUp</seealso>
    let asSketchUp = Prefixed_Name(fog, "asSketchUp") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSketchUp_v2017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary SketchUp v2017 format (Trimble). The format consists of a single .skp file (binary).</para>
    /// labels<para>as SketchUp format v2017 (.skp)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSketchUp_v2017">https://w3id.org/fog#asSketchUp_v2017</seealso>
    let asSketchUp_v2017 = Prefixed_Name(fog, "asSketchUp_v2017") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSketchUp_v2019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary SketchUp v2019 format (Trimble). The format consists of a single .skp file (binary).</para>
    /// labels<para>as SketchUp format v2019 (.skp)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSketchUp_v2019">https://w3id.org/fog#asSketchUp_v2019</seealso>
    let asSketchUp_v2019 = Prefixed_Name(fog, "asSketchUp_v2019") |> PrefixedName
    /// <summary>
    ///   <para>fog:asStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. It is strongly adviced to use more specific subproperties.</para>
    /// labels<para>as SPFF file (.step)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asStep">https://w3id.org/fog#asStep</seealso>
    let asStep = Prefixed_Name(fog, "asStep") |> PrefixedName
    /// <summary>
    ///   <para>fog:asStep_ap214</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. The STEP file is structured according to the Application Profile (AP) 214 - Core data for automative mechanical design processes.</para>
    /// labels<para>as STEP SPFF file (AP214)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asStep_ap214">https://w3id.org/fog#asStep_ap214</seealso>
    let asStep_ap214 = Prefixed_Name(fog, "asStep_ap214") |> PrefixedName
    /// <summary>
    ///   <para>fog:asStep_ap242</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the STEP Physical File Format (SPFF) format which was developed by ISO. The format consists of a single .step file which is text-based. The STEP file is structured according to the Application Profile (AP) 242 - Managed model-based 3D engineering.</para>
    /// labels<para>as STEP SPFF file (AP242)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asStep_ap242">https://w3id.org/fog#asStep_ap242</seealso>
    let asStep_ap242 = Prefixed_Name(fog, "asStep_ap242") |> PrefixedName
    /// <summary>
    ///   <para>fog:asStl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the STL format which was developed by 3D Systems. The format consists of a single .stl file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asStl_v1.0-ascii).</para>
    /// labels<para>as STL format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asStl">https://w3id.org/fog#asStl</seealso>
    let asStl = Prefixed_Name(fog, "asStl") |> PrefixedName
    /// <summary>
    ///   <para>fog:asStl_v1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is either text-based or binary. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asStl_v1.0-ascii)</para>
    /// labels<para>as STL format v1.0</para></remarks>
    /// <seealso href="https://w3id.org/fog#asStl_v1.0">https://w3id.org/fog#asStl_v1.0</seealso>
    let ``asStl_v1.0`` = Prefixed_Name(fog, "asStl_v1.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asStl_v1.0-ascii</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is text-based.</para>
    /// labels<para>as STL format v1.0 (ASCII)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asStl_v1.0-ascii">https://w3id.org/fog#asStl_v1.0-ascii</seealso>
    let ``asStl_v1.0_ascii`` = Prefixed_Name(fog, "asStl_v1.0-ascii") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSvg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open SVG format which was developed by the W3C. The format consists of a single .svg file which is text-based. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asSvg_v1.1).</para>
    /// labels<para>as SVG format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSvg">https://w3id.org/fog#asSvg</seealso>
    let asSvg = Prefixed_Name(fog, "asSvg") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSvg_v1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open SVG v1.0 format which was developed by the W3C. The format consists of a single .svg file which is text-based. Note that this version (v1.0) is considered depreciated in favor of v1.1.</para>
    /// labels<para>as SVG format v1.0</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSvg_v1.0">https://w3id.org/fog#asSvg_v1.0</seealso>
    let ``asSvg_v1.0`` = Prefixed_Name(fog, "asSvg_v1.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSvg_v1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open SVG v1.1 format which was developed by the W3C. The format consists of a single .svg file which is text-based.</para>
    /// labels<para>as SVG format v1.1</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSvg_v1.1">https://w3id.org/fog#asSvg_v1.1</seealso>
    let ``asSvg_v1.1`` = Prefixed_Name(fog, "asSvg_v1.1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSvg_v2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open SVG v2.0 format which was developed by the W3C. The format consists of a single .svg file which is text-based. Note that this version (v2.0) is not yet finalized and at the moment has the status of 'W3C Candidate Recommendation'.</para>
    /// labels<para>as SVG format v2.0</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSvg_v2.0">https://w3id.org/fog#asSvg_v2.0</seealso>
    let ``asSvg_v2.0`` = Prefixed_Name(fog, "asSvg_v2.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asX3d</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open X3D format which was developed by the Web3D. The format consists of a single file which is either binary or text-based. It is strongly adviced to use the more specific subsubproperties (e.g. fog:asX3d_v3.3_xml).</para>
    /// labels<para>as X3D format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asX3d">https://w3id.org/fog#asX3d</seealso>
    let asX3d = Prefixed_Name(fog, "asX3d") |> PrefixedName
    /// <summary>
    ///   <para>fog:asX3d_v3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open X3D v3.3 format which was developed by the Web3D. The format consists of a single file which is either binary or text-based. It is strongly adviced to use the more specific subproperties (e.g. fog:asX3d_v3.3_xml).</para>
    /// labels<para>as X3D format v3.3</para></remarks>
    /// <seealso href="https://w3id.org/fog#asX3d_v3.3">https://w3id.org/fog#asX3d_v3.3</seealso>
    let ``asX3d_v3.3`` = Prefixed_Name(fog, "asX3d_v3.3") |> PrefixedName
    /// <summary>
    ///   <para>fog:asX3d_v3.3-binary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a binary X3D file (.x3db) following the open X3D v3.3 format which was developed by the Web3D.</para>
    /// labels<para>as X3D v3.3 binary file (.x3db)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asX3d_v3.3-binary">https://w3id.org/fog#asX3d_v3.3-binary</seealso>
    let ``asX3d_v3.3_binary`` = Prefixed_Name(fog, "asX3d_v3.3-binary") |> PrefixedName
    /// <summary>
    ///   <para>fog:asX3d_v3.3-vrml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a classic VRML X3D file (.x3dv) following the open X3D v3.3 format which was developed by the Web3D. The file is text-based.</para>
    /// labels<para>as X3D v3.3 classic VRML file (.x3dv)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asX3d_v3.3-vrml">https://w3id.org/fog#asX3d_v3.3-vrml</seealso>
    let ``asX3d_v3.3_vrml`` = Prefixed_Name(fog, "asX3d_v3.3-vrml") |> PrefixedName
    /// <summary>
    ///   <para>fog:asX3d_v3.3-xml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a regular X3D file (.x3d) following the open X3D v3.3 format which was developed by the Web3D. The file is text-based.</para>
    /// labels<para>as X3D v3.3 XML file (.x3d)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asX3d_v3.3-xml">https://w3id.org/fog#asX3d_v3.3-xml</seealso>
    let ``asX3d_v3.3_xml`` = Prefixed_Name(fog, "asX3d_v3.3-xml") |> PrefixedName

    /// <summary>
    ///   <para>fog:hasReferencedContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>has referenced content</para></remarks>
    /// <seealso href="https://w3id.org/fog#hasReferencedContent">https://w3id.org/fog#hasReferencedContent</seealso>
    let hasReferencedContent =
        Prefixed_Name(fog, "hasReferencedContent") |> PrefixedName

    /// <summary>
    ///   <para>fog:asCollada_v1.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open COLLADA v1.4.1 format from the Khronos Group. It consists of a single .dae file (text-based).</para>
    /// labels<para>as COLLADA v1.4.1 format (.dae)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asCollada_v1.4.1">https://w3id.org/fog#asCollada_v1.4.1</seealso>
    let ``asCollada_v1.4.1`` = Prefixed_Name(fog, "asCollada_v1.4.1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asIfcowl_v2x4final</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the IfcOWL v2x4 Final ontology.</para>
    /// labels<para>as ifcOWL v2x4 Final ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asIfcowl_v2x4final">https://w3id.org/fog#asIfcowl_v2x4final</seealso>
    let asIfcowl_v2x4final = Prefixed_Name(fog, "asIfcowl_v2x4final") |> PrefixedName
    /// <summary>
    ///   <para>fog:asCollada_v1.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open COLLADA v1.5.0 format from the Khronos Group. It consists of a single .dae file (text-based).</para>
    /// labels<para>as COLLADA v1.5.0 format (.dae)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asCollada_v1.5.0">https://w3id.org/fog#asCollada_v1.5.0</seealso>
    let ``asCollada_v1.5.0`` = Prefixed_Name(fog, "asCollada_v1.5.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asDwg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary DWG format from Autodesk. The Open Design Alliance created a 'specification for .dwg files' that is publicly available. The format consists of a single .dwg file (binary). It is strongly adviced to use the more specific subproperties (e.g. fog:asDwg_v2018).</para>
    /// labels<para>as DWG format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asDwg">https://w3id.org/fog#asDwg</seealso>
    let asDwg = Prefixed_Name(fog, "asDwg") |> PrefixedName
    /// <summary>
    ///   <para>fog:asDwg_v2013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary DWG v2013 format from Autodesk. It consists of a single .dwg file (binary).</para>
    /// labels<para>as DWG 2013 format (.dwg)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asDwg_v2013">https://w3id.org/fog#asDwg_v2013</seealso>
    let asDwg_v2013 = Prefixed_Name(fog, "asDwg_v2013") |> PrefixedName
    /// <summary>
    ///   <para>fog:asDwg_v2010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary DWG v2010 format from Autodesk. It consists of a single .dwg file (binary).</para>
    /// labels<para>as DWG 2010 format (.dwg)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asDwg_v2010">https://w3id.org/fog#asDwg_v2010</seealso>
    let asDwg_v2010 = Prefixed_Name(fog, "asDwg_v2010") |> PrefixedName
    /// <summary>
    ///   <para>fog:asDwg_v2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary DWG v2018 format from Autodesk. It consists of a single .dwg file (binary).</para>
    /// labels<para>as DWG 2018 format (.dwg)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asDwg_v2018">https://w3id.org/fog#asDwg_v2018</seealso>
    let asDwg_v2018 = Prefixed_Name(fog, "asDwg_v2018") |> PrefixedName
    /// <summary>
    ///   <para>fog:asE57_v1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a point cloud geometry description following the open E57 format developed by the ASTM Committee E57. The format consists of a single .e57 file (partially binary, partially text-based).</para>
    /// labels<para>as E57 v1.0 format (.e57)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asE57_v1.0">https://w3id.org/fog#asE57_v1.0</seealso>
    let ``asE57_v1.0`` = Prefixed_Name(fog, "asE57_v1.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asSketchUp_v2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the proprietary SketchUp v2018 format (Trimble). The format consists of a single .skp file (binary).</para>
    /// labels<para>as SketchUp format v2018 (.skp)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asSketchUp_v2018">https://w3id.org/fog#asSketchUp_v2018</seealso>
    let asSketchUp_v2018 = Prefixed_Name(fog, "asSketchUp_v2018") |> PrefixedName
    /// <summary>
    ///   <para>fog:asE57</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a point cloud geometry description following the open E57 format developed by the ASTM Committee E57. The format consists of a single .e57 file (partially binary, partially text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asE57_v1.0).</para>
    /// labels<para>as E57 format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asE57">https://w3id.org/fog#asE57</seealso>
    let asE57 = Prefixed_Name(fog, "asE57") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGeojson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open GeoJSON format. The format consists of a single .json file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asGeojson_v2016). Note that the version proposed by the IETF GeoJSON Working Group (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).</para>
    /// labels<para>as GeoJSON format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGeojson">https://w3id.org/fog#asGeojson</seealso>
    let asGeojson = Prefixed_Name(fog, "asGeojson") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGeojson-ld</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The object relation pointing to a GeoJSON-LD geometry description: a GeoJSON geometry description complemented with the corresponding JSON-LD context to make it RDF. It should be connected to the topnode of the geometry description. Note that this geometry description can only be used to depict single points, as the current JSON-LD specification v1.0 does not implement the deserialisation of nested lists to RDF</para>
    /// labels<para>as GeoJSON-LD</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGeojson-ld">https://w3id.org/fog#asGeojson-ld</seealso>
    let asGeojson_ld = Prefixed_Name(fog, "asGeojson-ld") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGeojson_v2008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open GeoJSON v2008 format. The format consists of a single .json file (text-based). Note that the version proposed by the IETF (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).</para>
    /// labels<para>as GeoJSON format v2008 (.json)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGeojson_v2008">https://w3id.org/fog#asGeojson_v2008</seealso>
    let asGeojson_v2008 = Prefixed_Name(fog, "asGeojson_v2008") |> PrefixedName
    /// <summary>
    ///   <para>fog:asStl_v1.0-binary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the STL v1.0 format which was developed by 3D Systems. The format consists of a single .stl file which is binary.</para>
    /// labels<para>as STL format v1.0 (binary)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asStl_v1.0-binary">https://w3id.org/fog#asStl_v1.0-binary</seealso>
    let ``asStl_v1.0_binary`` = Prefixed_Name(fog, "asStl_v1.0-binary") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGeojson_v2016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open GeoJSON v2016 format developed by the IETF GeoJSON Working Group. The format consists of a single .json file (text-based). Note that the version proposed by the IETF (fog:asGeojson_v2016) is derived from the now obsolete 2008 version (fog:asGeojson_v2008).</para>
    /// labels<para>as GeoJSON v2016 format (.json)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGeojson_v2016">https://w3id.org/fog#asGeojson_v2016</seealso>
    let asGeojson_v2016 = Prefixed_Name(fog, "asGeojson_v2016") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGeomOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the GEOM ontology. It should be connected to the topnode of the geometry description.</para>
    /// labels<para>as GEOM ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGeomOntology">https://w3id.org/fog#asGeomOntology</seealso>
    let asGeomOntology = Prefixed_Name(fog, "asGeomOntology") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGltf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open glTF format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders, or .glb) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subsubproperties (e.g. fog:asGltf_v2.0-gltf).</para>
    /// labels<para>as glTF format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf">https://w3id.org/fog#asGltf</seealso>
    let asGltf = Prefixed_Name(fog, "asGltf") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGltf_v1.0-glsl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based shader file (.glsl) following the open glTF v1.0 format from the Khronos Group. This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.</para>
    /// labels<para>as glTF v1.0 shader file (.glsl)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v1.0-glsl">https://w3id.org/fog#asGltf_v1.0-glsl</seealso>
    let ``asGltf_v1.0_glsl`` = Prefixed_Name(fog, "asGltf_v1.0-glsl") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGltf_v1.0-gltf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a JSON file (.gltf) following the open glTF v1.0 format from the Khronos Group. This file can be used on its own if geometry, shaders and optional textures are embedded (text-based) inside the JSON. In most cases however, it references other files containing geometry (.bin), optional shaders (.glsl) and optional textures (.bmp/.gif/.jpeg/.png).</para>
    /// labels<para>as glTF v1.0 JSON file (.gltf)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v1.0-gltf">https://w3id.org/fog#asGltf_v1.0-gltf</seealso>
    let ``asGltf_v1.0_gltf`` = Prefixed_Name(fog, "asGltf_v1.0-gltf") |> PrefixedName

    /// <summary>
    ///   <para>fog:asGltf_v1.0-texture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a binary texture file (.bmp/..gif/.jpeg/.png). This file always has to be used together with the central .gltf JSON file (fog:asGltf_v1.0-gltf) referencing it.</para>
    /// labels<para>as glTF v1.0 texture file</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v1.0-texture">https://w3id.org/fog#asGltf_v1.0-texture</seealso>
    let ``asGltf_v1.0_texture`` =
        Prefixed_Name(fog, "asGltf_v1.0-texture") |> PrefixedName

    /// <summary>
    ///   <para>fog:asGltf_v1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a geometry description following the open glTF v1.0 format from the Khronos Group. The format consists of one (.gltf with embedded binary geometry/textures/shaders) or multiple files (combination of binary and/or text-based files). It is strongly adviced to use the more specific subproperties (e.g. fog:asGltf_v1.0-gltf).</para>
    /// labels<para>as glTF v1.0 format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v1.0">https://w3id.org/fog#asGltf_v1.0</seealso>
    let ``asGltf_v1.0`` = Prefixed_Name(fog, "asGltf_v1.0") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGltf_v2.0-gltf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a JSON file (.gltf) following the open glTF v2.0 format from the Khronos Group. This file can be used on its own if geometry and optional textures are embedded (text-based) inside the JSON. In most cases however, it references other files containing geometry (.bin) and optional textures (.jpeg/.png).</para>
    /// labels<para>as glTF v2.0 JSON file (.gltf)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v2.0-gltf">https://w3id.org/fog#asGltf_v2.0-gltf</seealso>
    let ``asGltf_v2.0_gltf`` = Prefixed_Name(fog, "asGltf_v2.0-gltf") |> PrefixedName

    /// <summary>
    ///   <para>fog:asGltf_v2.0-texture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a binary texture file (.jpeg/.png). This file always has to be used together with the central .gltf JSON file (fog:asGltf_v2.0-gltf) referencing it.</para>
    /// labels<para>as glTF v2.0 texture file</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v2.0-texture">https://w3id.org/fog#asGltf_v2.0-texture</seealso>
    let ``asGltf_v2.0_texture`` =
        Prefixed_Name(fog, "asGltf_v2.0-texture") |> PrefixedName

    /// <summary>
    ///   <para>fog:asGml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based geometry description following one of the open GML formats developed by OGC and ISO. The format consists of a single .gml file (text-based). It is strongly adviced to use the more specific subproperties (e.g. fog:asGml_v3.3.0). Note that this property is disjoint with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    /// labels<para>as GML format</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGml">https://w3id.org/fog#asGml</seealso>
    let asGml = Prefixed_Name(fog, "asGml") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGml_v3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.2.1 format developed by OGC and ISO. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    /// labels<para>as GML v3.2.1 format (.gml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGml_v3.2.1">https://w3id.org/fog#asGml_v3.2.1</seealso>
    let ``asGml_v3.2.1`` = Prefixed_Name(fog, "asGml_v3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGml_v3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a text-based GML file (.gml) following the open GML v3.2.2 format developed by OGC and ISO. Note that this property is disjoint (via its superproperty fog:asGml) with geo:asGML because of the more strict domain and range restrictions in GeoSPARQL.</para>
    /// labels<para>as GML v3.2.2 format (.gml)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGml_v3.2.2">https://w3id.org/fog#asGml_v3.2.2</seealso>
    let ``asGml_v3.2.2`` = Prefixed_Name(fog, "asGml_v3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>fog:as3dmo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object relation pointing to a RDF-based geometry description following the 3DMO ontology. It is strongly adviced to use the more specific subproperty (fog:as3dmo_v1.1)</para>
    /// labels<para>as 3DMO ontology</para></remarks>
    /// <seealso href="https://w3id.org/fog#as3dmo">https://w3id.org/fog#as3dmo</seealso>
    let as3dmo = Prefixed_Name(fog, "as3dmo") |> PrefixedName
    /// <summary>
    ///   <para>fog:asGltf_v2.0-glb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The datatype relation pointing to a binary file (.glb) following the open glTF v2.0 format from the Khronos Group. This one file contains geometry and textures, and as a result can be used without other files.</para>
    /// labels<para>as glTF v2.0 binary file (.glb)</para></remarks>
    /// <seealso href="https://w3id.org/fog#asGltf_v2.0-glb">https://w3id.org/fog#asGltf_v2.0-glb</seealso>
    let ``asGltf_v2.0_glb`` = Prefixed_Name(fog, "asGltf_v2.0-glb") |> PrefixedName
