namespace http.eulersharp.sourceforge.net._2003._03swap.space.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapspace =
    let _namespace_iri = Namespace_Iri swapspace |> NamespaceIRI
    /// <summary>
    ///   <para>swapspace:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#">http://eulersharp.sourceforge.net/2003/03swap/space#</seealso>
    let _prefix_iri = Prefixed_Name(swapspace, "") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>spatial point</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Point">http://eulersharp.sourceforge.net/2003/03swap/space#Point</seealso>
    let Point = Prefixed_Name(swapspace, "Point") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>length</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Length">http://eulersharp.sourceforge.net/2003/03swap/space#Length</seealso>
    let Length = Prefixed_Name(swapspace, "Length") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Line</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>line</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Line">http://eulersharp.sourceforge.net/2003/03swap/space#Line</seealso>
    let Line = Prefixed_Name(swapspace, "Line") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>polygon</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Polygon">http://eulersharp.sourceforge.net/2003/03swap/space#Polygon</seealso>
    let Polygon = Prefixed_Name(swapspace, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Rectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>rectangle</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Rectangle">http://eulersharp.sourceforge.net/2003/03swap/space#Rectangle</seealso>
    let Rectangle = Prefixed_Name(swapspace, "Rectangle") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>transfer</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Transfer">http://eulersharp.sourceforge.net/2003/03swap/space#Transfer</seealso>
    let Transfer = Prefixed_Name(swapspace, "Transfer") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Transferring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>transferring</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Transferring">http://eulersharp.sourceforge.net/2003/03swap/space#Transferring</seealso>
    let Transferring = Prefixed_Name(swapspace, "Transferring") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:XCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>X coordinate</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#XCoordinate">http://eulersharp.sourceforge.net/2003/03swap/space#XCoordinate</seealso>
    let XCoordinate = Prefixed_Name(swapspace, "XCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:containedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#containedBy">http://eulersharp.sourceforge.net/2003/03swap/space#containedBy</seealso>
    let containedBy = Prefixed_Name(swapspace, "containedBy") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasPoint">http://eulersharp.sourceforge.net/2003/03swap/space#hasPoint</seealso>
    let hasPoint = Prefixed_Name(swapspace, "hasPoint") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasLength">http://eulersharp.sourceforge.net/2003/03swap/space#hasLength</seealso>
    let hasLength = Prefixed_Name(swapspace, "hasLength") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:hasUpperLeftAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasUpperLeftAngle">http://eulersharp.sourceforge.net/2003/03swap/space#hasUpperLeftAngle</seealso>
    let hasUpperLeftAngle =
        Prefixed_Name(swapspace, "hasUpperLeftAngle") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:hasWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasWidth">http://eulersharp.sourceforge.net/2003/03swap/space#hasWidth</seealso>
    let hasWidth = Prefixed_Name(swapspace, "hasWidth") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasYCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasYCoordinate">http://eulersharp.sourceforge.net/2003/03swap/space#hasYCoordinate</seealso>
    let hasYCoordinate = Prefixed_Name(swapspace, "hasYCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasZCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasZCoordinate">http://eulersharp.sourceforge.net/2003/03swap/space#hasZCoordinate</seealso>
    let hasZCoordinate = Prefixed_Name(swapspace, "hasZCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#locatedIn">http://eulersharp.sourceforge.net/2003/03swap/space#locatedIn</seealso>
    let locatedIn = Prefixed_Name(swapspace, "locatedIn") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:locatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#locatedOn">http://eulersharp.sourceforge.net/2003/03swap/space#locatedOn</seealso>
    let locatedOn = Prefixed_Name(swapspace, "locatedOn") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:transferOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#transferOf">http://eulersharp.sourceforge.net/2003/03swap/space#transferOf</seealso>
    let transferOf = Prefixed_Name(swapspace, "transferOf") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:transferredFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#transferredFrom">http://eulersharp.sourceforge.net/2003/03swap/space#transferredFrom</seealso>
    let transferredFrom = Prefixed_Name(swapspace, "transferredFrom") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:transferredTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#transferredTo">http://eulersharp.sourceforge.net/2003/03swap/space#transferredTo</seealso>
    let transferredTo = Prefixed_Name(swapspace, "transferredTo") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:transferringOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#transferringOf">http://eulersharp.sourceforge.net/2003/03swap/space#transferringOf</seealso>
    let transferringOf = Prefixed_Name(swapspace, "transferringOf") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:whereonLocated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#whereonLocated">http://eulersharp.sourceforge.net/2003/03swap/space#whereonLocated</seealso>
    let whereonLocated = Prefixed_Name(swapspace, "whereonLocated") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:OneDimensionalSpatialResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>one-dimensional spatial resource</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#OneDimensionalSpatialResource">http://eulersharp.sourceforge.net/2003/03swap/space#OneDimensionalSpatialResource</seealso>
    let OneDimensionalSpatialResource =
        Prefixed_Name(swapspace, "OneDimensionalSpatialResource") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:OuterSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>outer surface</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#OuterSurface">http://eulersharp.sourceforge.net/2003/03swap/space#OuterSurface</seealso>
    let OuterSurface = Prefixed_Name(swapspace, "OuterSurface") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasCentroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasCentroid">http://eulersharp.sourceforge.net/2003/03swap/space#hasCentroid</seealso>
    let hasCentroid = Prefixed_Name(swapspace, "hasCentroid") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A position is described by 0 to n coordinates.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasPosition">http://eulersharp.sourceforge.net/2003/03swap/space#hasPosition</seealso>
    let hasPosition = Prefixed_Name(swapspace, "hasPosition") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasSide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasSide">http://eulersharp.sourceforge.net/2003/03swap/space#hasSide</seealso>
    let hasSide = Prefixed_Name(swapspace, "hasSide") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:hasXCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasXCoordinate">http://eulersharp.sourceforge.net/2003/03swap/space#hasXCoordinate</seealso>
    let hasXCoordinate = Prefixed_Name(swapspace, "hasXCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>surface</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Surface">http://eulersharp.sourceforge.net/2003/03swap/space#Surface</seealso>
    let Surface = Prefixed_Name(swapspace, "Surface") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:TwoDimensionalSpatialResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>two-dimensional spatial resource</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#TwoDimensionalSpatialResource">http://eulersharp.sourceforge.net/2003/03swap/space#TwoDimensionalSpatialResource</seealso>
    let TwoDimensionalSpatialResource =
        Prefixed_Name(swapspace, "TwoDimensionalSpatialResource") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:Quadrilateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>quadrilateral</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Quadrilateral">http://eulersharp.sourceforge.net/2003/03swap/space#Quadrilateral</seealso>
    let Quadrilateral = Prefixed_Name(swapspace, "Quadrilateral") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:ThreeDimensionalSpatialResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>three-dimensional spatial resource</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#ThreeDimensionalSpatialResource">http://eulersharp.sourceforge.net/2003/03swap/space#ThreeDimensionalSpatialResource</seealso>
    let ThreeDimensionalSpatialResource =
        Prefixed_Name(swapspace, "ThreeDimensionalSpatialResource") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:Width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>width</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Width">http://eulersharp.sourceforge.net/2003/03swap/space#Width</seealso>
    let Width = Prefixed_Name(swapspace, "Width") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:ZCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Z coordinate</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#ZCoordinate">http://eulersharp.sourceforge.net/2003/03swap/space#ZCoordinate</seealso>
    let ZCoordinate = Prefixed_Name(swapspace, "ZCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#contains">http://eulersharp.sourceforge.net/2003/03swap/space#contains</seealso>
    let contains = Prefixed_Name(swapspace, "contains") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:hasLowerLeftAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#hasLowerLeftAngle">http://eulersharp.sourceforge.net/2003/03swap/space#hasLowerLeftAngle</seealso>
    let hasLowerLeftAngle =
        Prefixed_Name(swapspace, "hasLowerLeftAngle") |> PrefixedName

    /// <summary>
    ///   <para>swapspace:whereinLocated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#whereinLocated">http://eulersharp.sourceforge.net/2003/03swap/space#whereinLocated</seealso>
    let whereinLocated = Prefixed_Name(swapspace, "whereinLocated") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Square</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>square</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Square">http://eulersharp.sourceforge.net/2003/03swap/space#Square</seealso>
    let Square = Prefixed_Name(swapspace, "Square") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:YCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Y coordinate</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#YCoordinate">http://eulersharp.sourceforge.net/2003/03swap/space#YCoordinate</seealso>
    let YCoordinate = Prefixed_Name(swapspace, "YCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#from">http://eulersharp.sourceforge.net/2003/03swap/space#from</seealso>
    let from = Prefixed_Name(swapspace, "from") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Centroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>centroid</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Centroid">http://eulersharp.sourceforge.net/2003/03swap/space#Centroid</seealso>
    let Centroid = Prefixed_Name(swapspace, "Centroid") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Curve</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>curve</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Curve">http://eulersharp.sourceforge.net/2003/03swap/space#Curve</seealso>
    let Curve = Prefixed_Name(swapspace, "Curve") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:Side</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>side</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#Side">http://eulersharp.sourceforge.net/2003/03swap/space#Side</seealso>
    let Side = Prefixed_Name(swapspace, "Side") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:SpatialResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>spatial resource</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#SpatialResource">http://eulersharp.sourceforge.net/2003/03swap/space#SpatialResource</seealso>
    let SpatialResource = Prefixed_Name(swapspace, "SpatialResource") |> PrefixedName
    /// <summary>
    ///   <para>swapspace:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/space#to">http://eulersharp.sourceforge.net/2003/03swap/space#to</seealso>
    let to_ = Prefixed_Name(swapspace, "to") |> PrefixedName
