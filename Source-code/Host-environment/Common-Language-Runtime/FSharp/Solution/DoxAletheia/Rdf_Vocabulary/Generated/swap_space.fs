namespace http.eulersharp.sourceforge.net._2003._03swap.space.hash

open DoxAletheia

module swap_space =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/space#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Centroid"></see>
    /// </summary>
    let Centroid = _prefix "Centroid"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Point"></see>
    /// </summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Curve"></see>
    /// </summary>
    let Curve = _prefix "Curve"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#OneDimensionalSpatialResource"></see>
    /// </summary>
    let OneDimensionalSpatialResource = _prefix "OneDimensionalSpatialResource"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Length"></see>
    /// </summary>
    let Length = _prefix "Length"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Side"></see>
    /// </summary>
    let Side = _prefix "Side"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Line"></see>
    /// </summary>
    let Line = _prefix "Line"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#SpatialResource"></see>
    /// </summary>
    let SpatialResource = _prefix "SpatialResource"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#OuterSurface"></see>
    /// </summary>
    let OuterSurface = _prefix "OuterSurface"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Surface"></see>
    /// </summary>
    let Surface = _prefix "Surface"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Polygon"></see>
    /// </summary>
    let Polygon = _prefix "Polygon"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#TwoDimensionalSpatialResource"></see>
    /// </summary>
    let TwoDimensionalSpatialResource = _prefix "TwoDimensionalSpatialResource"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Quadrilateral"></see>
    /// </summary>
    let Quadrilateral = _prefix "Quadrilateral"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Rectangle"></see>
    /// </summary>
    let Rectangle = _prefix "Rectangle"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Square"></see>
    /// </summary>
    let Square = _prefix "Square"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#ThreeDimensionalSpatialResource"></see>
    /// </summary>
    let ThreeDimensionalSpatialResource = _prefix "ThreeDimensionalSpatialResource"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Transfer"></see>
    /// </summary>
    let Transfer = _prefix "Transfer"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Transferring"></see>
    /// </summary>
    let Transferring = _prefix "Transferring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#Width"></see>
    /// </summary>
    let Width = _prefix "Width"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#XCoordinate"></see>
    /// </summary>
    let XCoordinate = _prefix "XCoordinate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#YCoordinate"></see>
    /// </summary>
    let YCoordinate = _prefix "YCoordinate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#ZCoordinate"></see>
    /// </summary>
    let ZCoordinate = _prefix "ZCoordinate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#containedBy"></see>
    /// </summary>
    let containedBy = _prefix "containedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#from"></see>
    /// </summary>
    let from = _prefix "from"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasCentroid"></see>
    /// </summary>
    let hasCentroid = _prefix "hasCentroid"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasPoint"></see>
    /// </summary>
    let hasPoint = _prefix "hasPoint"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasLength"></see>
    /// </summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasLowerLeftAngle"></see>
    /// </summary>
    let hasLowerLeftAngle = _prefix "hasLowerLeftAngle"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#whereinLocated"></see>
    /// </summary>
    let whereinLocated = _prefix "whereinLocated"
    /// <summary>
    /// A position is described by 0 to n coordinates.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasPosition"></see></summary>
    let hasPosition = _prefix "hasPosition"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasSide"></see>
    /// </summary>
    let hasSide = _prefix "hasSide"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasUpperLeftAngle"></see>
    /// </summary>
    let hasUpperLeftAngle = _prefix "hasUpperLeftAngle"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasWidth"></see>
    /// </summary>
    let hasWidth = _prefix "hasWidth"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasXCoordinate"></see>
    /// </summary>
    let hasXCoordinate = _prefix "hasXCoordinate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasYCoordinate"></see>
    /// </summary>
    let hasYCoordinate = _prefix "hasYCoordinate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#hasZCoordinate"></see>
    /// </summary>
    let hasZCoordinate = _prefix "hasZCoordinate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#locatedIn"></see>
    /// </summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#locatedOn"></see>
    /// </summary>
    let locatedOn = _prefix "locatedOn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#to"></see>
    /// </summary>
    let to_ = _prefix "to"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#transferOf"></see>
    /// </summary>
    let transferOf = _prefix "transferOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#transferredFrom"></see>
    /// </summary>
    let transferredFrom = _prefix "transferredFrom"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#transferredTo"></see>
    /// </summary>
    let transferredTo = _prefix "transferredTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#transferringOf"></see>
    /// </summary>
    let transferringOf = _prefix "transferringOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/space#whereonLocated"></see>
    /// </summary>
    let whereonLocated = _prefix "whereonLocated"
