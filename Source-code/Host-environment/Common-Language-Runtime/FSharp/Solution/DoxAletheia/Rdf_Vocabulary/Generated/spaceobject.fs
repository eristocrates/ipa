namespace http.sweet.jpl.nasa.gov._2._3.reprSpaceGeometry.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spaceobject =
    let _namespace_iri = Namespace_Iri spaceobject |> NamespaceIRI
    /// <summary>
    ///   <para>spaceobject:Curve</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Curve">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Curve</seealso>
    let Curve = Prefixed_Name(spaceobject, "Curve") |> PrefixedName

    /// <summary>
    ///   <para>spaceobject:GeometricalObject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject</seealso>
    let GeometricalObject =
        Prefixed_Name(spaceobject, "GeometricalObject") |> PrefixedName

    /// <summary>
    ///   <para>spaceobject:GeometricalObject_1D</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject_1D">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject_1D</seealso>
    let GeometricalObject_1D =
        Prefixed_Name(spaceobject, "GeometricalObject_1D") |> PrefixedName

    /// <summary>
    ///   <para>spaceobject:GeometricalObject_2D</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject_2D">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject_2D</seealso>
    let GeometricalObject_2D =
        Prefixed_Name(spaceobject, "GeometricalObject_2D") |> PrefixedName

    /// <summary>
    ///   <para>spaceobject:GeometricalObject_3D</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject_3D">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#GeometricalObject_3D</seealso>
    let GeometricalObject_3D =
        Prefixed_Name(spaceobject, "GeometricalObject_3D") |> PrefixedName

    /// <summary>
    ///   <para>spaceobject:Line</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Line">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Line</seealso>
    let Line = Prefixed_Name(spaceobject, "Line") |> PrefixedName
    /// <summary>
    ///   <para>spaceobject:Point</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Point">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Point</seealso>
    let Point = Prefixed_Name(spaceobject, "Point") |> PrefixedName
    /// <summary>
    ///   <para>spaceobject:Polygon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Polygon">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Polygon</seealso>
    let Polygon = Prefixed_Name(spaceobject, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>spaceobject:Rectangle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Rectangle">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Rectangle</seealso>
    let Rectangle = Prefixed_Name(spaceobject, "Rectangle") |> PrefixedName
    /// <summary>
    ///   <para>spaceobject:Square</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Square">http://sweet.jpl.nasa.gov/2.3/reprSpaceGeometry.owl#Square</seealso>
    let Square = Prefixed_Name(spaceobject, "Square") |> PrefixedName
