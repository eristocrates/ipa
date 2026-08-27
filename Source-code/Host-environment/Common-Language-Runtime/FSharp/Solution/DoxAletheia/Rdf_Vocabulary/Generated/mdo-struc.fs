namespace https.w3id.org.mdo.structure.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mdo_struc =
    let _namespace_iri = Namespace_Iri mdo_struc |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:mdo/structure/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This is the structure module in Materials Design Ontology."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mdo/structure/">https://w3id.org/mdo/structure/</seealso>
    let _prefix_iri = Prefixed_Name(mdo_struc, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/1.0/">https://w3id.org/mdo/structure/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(mdo_struc, "1.0/") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/AngleTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A angle triple is a vector of three angles which represent the angles among three bases in a cell."</para>
    /// labels<para>"Angle Triple"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/AngleTriple">https://w3id.org/mdo/structure/AngleTriple</seealso>
    let AngleTriple = Prefixed_Name(mdo_struc, "AngleTriple") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Angle_alpha</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Angle_alpha represents that an angle triple has the alpha angle's value in a double."</para>
    /// labels<para>"Angle_alpha"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Angle_alpha">https://w3id.org/mdo/structure/Angle_alpha</seealso>
    let Angle_alpha = Prefixed_Name(mdo_struc, "Angle_alpha") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Angle_beta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Angle_beta represents that an angle triple has the beta angle's value in a double."</para>
    /// labels<para>"Angle_beta"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Angle_beta">https://w3id.org/mdo/structure/Angle_beta</seealso>
    let Angle_beta = Prefixed_Name(mdo_struc, "Angle_beta") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Angle_gamma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Angle_gamma represents that an angle triple has the gamma angle's value in a double."</para>
    /// labels<para>"Angle_gamma"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Angle_gamma">https://w3id.org/mdo/structure/Angle_gamma</seealso>
    let Angle_gamma = Prefixed_Name(mdo_struc, "Angle_gamma") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/AnonymousFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"AnonymousFormula represents that a composition has the anonymous formula in a string."</para>
    /// labels<para>"anonymous formula"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/AnonymousFormula">https://w3id.org/mdo/structure/AnonymousFormula</seealso>
    let AnonymousFormula = Prefixed_Name(mdo_struc, "AnonymousFormula") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/AxisVectors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An axis-vectors is the three vectors which represent the bases of cell."</para>
    /// labels<para>"Axis Vectors"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/AxisVectors">https://w3id.org/mdo/structure/AxisVectors</seealso>
    let AxisVectors = Prefixed_Name(mdo_struc, "AxisVectors") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Basis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A basis defines a spatial unit used to express fractional coordinates."</para>
    /// labels<para>"Basis"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Basis">https://w3id.org/mdo/structure/Basis</seealso>
    let Basis = Prefixed_Name(mdo_struc, "Basis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A composition is used to represent what chemical elements composing a structure and the ratio of the chemical elements."</para>
    /// labels<para>"Composition"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Composition">https://w3id.org/mdo/structure/Composition</seealso>
    let Composition = Prefixed_Name(mdo_struc, "Composition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/CoordinateVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A coordinate vector is the coordinates of a point in space."</para>
    /// labels<para>"Coordinate Vector"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/CoordinateVector">https://w3id.org/mdo/structure/CoordinateVector</seealso>
    let CoordinateVector = Prefixed_Name(mdo_struc, "CoordinateVector") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/structure/DescriptiveFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"DescriptiveFormula represents that a composition has the descriptive formula in a string."</para>
    /// labels<para>"descriptive formula"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/DescriptiveFormula">https://w3id.org/mdo/structure/DescriptiveFormula</seealso>
    let DescriptiveFormula =
        Prefixed_Name(mdo_struc, "DescriptiveFormula") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/structure/ElementRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ElementRatio represents that a species has the ratio in a double."</para>
    /// labels<para>"element ratio"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/ElementRatio">https://w3id.org/mdo/structure/ElementRatio</seealso>
    let ElementRatio = Prefixed_Name(mdo_struc, "ElementRatio") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/HillFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"HillFormula represents that a composition has the hill formula in a string."</para>
    /// labels<para>"hill formula"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/HillFormula">https://w3id.org/mdo/structure/HillFormula</seealso>
    let HillFormula = Prefixed_Name(mdo_struc, "HillFormula") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Lattice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A lattice defines a peroidic arrangement of one or more atoms."</para>
    /// labels<para>"Lattice"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Lattice">https://w3id.org/mdo/structure/Lattice</seealso>
    let Lattice = Prefixed_Name(mdo_struc, "Lattice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/LatticeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"LatticeType represents that a lattice has the type in a string."</para>
    /// labels<para>"lattice type"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/LatticeType">https://w3id.org/mdo/structure/LatticeType</seealso>
    let LatticeType = Prefixed_Name(mdo_struc, "LatticeType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/LatticeVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"LatticeVolume represents that a lattice has the volume in a double."</para>
    /// labels<para>"lattice volume"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/LatticeVolume">https://w3id.org/mdo/structure/LatticeVolume</seealso>
    let LatticeVolume = Prefixed_Name(mdo_struc, "LatticeVolume") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/LengthTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A length triple defines the three parameters (a, b, c) that represent the lengths in three axes respectively."</para>
    /// labels<para>"Length Triple"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/LengthTriple">https://w3id.org/mdo/structure/LengthTriple</seealso>
    let LengthTriple = Prefixed_Name(mdo_struc, "LengthTriple") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Length_a</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Length_a represents that a length triple has the 'a' value in a double."</para>
    /// labels<para>"Length_a"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Length_a">https://w3id.org/mdo/structure/Length_a</seealso>
    let Length_a = Prefixed_Name(mdo_struc, "Length_a") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Length_b</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Length_b represents that a length triple has the 'b' value in a double."</para>
    /// labels<para>"Length_b"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Length_b">https://w3id.org/mdo/structure/Length_b</seealso>
    let Length_b = Prefixed_Name(mdo_struc, "Length_b") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Length_c</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Length_c represents that a length triple has the 'c' value in a double."</para>
    /// labels<para>"Length_c"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Length_c">https://w3id.org/mdo/structure/Length_c</seealso>
    let Length_c = Prefixed_Name(mdo_struc, "Length_c") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Occupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An occupancy ties a specific species to a site."</para>
    /// labels<para>"Occupancy"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Occupancy">https://w3id.org/mdo/structure/Occupancy</seealso>
    let Occupancy = Prefixed_Name(mdo_struc, "Occupancy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/PointGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of linear mappings of vector space, which is corresonpond to the group of motions in point space determining the symmetry of the macroscopic crystal, is called the point group of the crystal, furthermore of the crystal structure, and is also called the point group of its space group."</para>
    /// labels<para>"Point Group"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/PointGroup">https://w3id.org/mdo/structure/PointGroup</seealso>
    let PointGroup = Prefixed_Name(mdo_struc, "PointGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/PointGroupHMName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"PointGroupHMName represents that a point group has the Hermann-Mauguin in a string."</para>
    /// labels<para>"point group Hermann-Mauguin name"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/PointGroupHMName">https://w3id.org/mdo/structure/PointGroupHMName</seealso>
    let PointGroupHMName = Prefixed_Name(mdo_struc, "PointGroupHMName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/ReducedFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ReducedFormula represents that a composition has the reduced formula in a string."</para>
    /// labels<para>"reduced formula"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/ReducedFormula">https://w3id.org/mdo/structure/ReducedFormula</seealso>
    let ReducedFormula = Prefixed_Name(mdo_struc, "ReducedFormula") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A site is a point in a lattice."</para>
    /// labels<para>"Site"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Site">https://w3id.org/mdo/structure/Site</seealso>
    let Site = Prefixed_Name(mdo_struc, "Site") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/SpaceGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A space group is the symmetry group of a three-dimensional crystal pattern is called its space group."</para>
    /// labels<para>"Space Group"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/SpaceGroup">https://w3id.org/mdo/structure/SpaceGroup</seealso>
    let SpaceGroup = Prefixed_Name(mdo_struc, "SpaceGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/SpaceGroupID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"SpaceGroupID represents that a space group has the unique ID in an integer."</para>
    /// labels<para>"space group ID"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/SpaceGroupID">https://w3id.org/mdo/structure/SpaceGroupID</seealso>
    let SpaceGroupID = Prefixed_Name(mdo_struc, "SpaceGroupID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/SpaceGroupSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"SpaceGroupSymbol represents that a space group has the symbol in a string."</para>
    /// labels<para>"space group symbol"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/SpaceGroupSymbol">https://w3id.org/mdo/structure/SpaceGroupSymbol</seealso>
    let SpaceGroupSymbol = Prefixed_Name(mdo_struc, "SpaceGroupSymbol") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A species is the combination of atoms on each site."</para>
    /// labels<para>"Species"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Species">https://w3id.org/mdo/structure/Species</seealso>
    let Species = Prefixed_Name(mdo_struc, "Species") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/X_axisCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"X_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in X axis."</para>
    /// labels<para>"X_axis coordinate"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/X_axisCoordinate">https://w3id.org/mdo/structure/X_axisCoordinate</seealso>
    let X_axisCoordinate = Prefixed_Name(mdo_struc, "X_axisCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Y_axisCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Y_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Y axis."</para>
    /// labels<para>"Y_axis coordinate"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Y_axisCoordinate">https://w3id.org/mdo/structure/Y_axisCoordinate</seealso>
    let Y_axisCoordinate = Prefixed_Name(mdo_struc, "Y_axisCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/Z_axisCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Z_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Z axis."</para>
    /// labels<para>"Z_axis coordinate"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/Z_axisCoordinate">https://w3id.org/mdo/structure/Z_axisCoordinate</seealso>
    let Z_axisCoordinate = Prefixed_Name(mdo_struc, "Z_axisCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasAngleVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasAngleVector represents the relationship between a basis or a lattice and an angle triple it has."</para>
    /// labels<para>"has angle vector"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasAngleVector">https://w3id.org/mdo/structure/hasAngleVector</seealso>
    let hasAngleVector = Prefixed_Name(mdo_struc, "hasAngleVector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasAxisVectors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"hasAxisVectors represents the relationship between a basis or a lattice and a axis-vectors it has."</para>
    /// labels<para>"has axis vectors"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasAxisVectors">https://w3id.org/mdo/structure/hasAxisVectors</seealso>
    let hasAxisVectors = Prefixed_Name(mdo_struc, "hasAxisVectors") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasBasis represents the relationship between a structure and the bases it has."</para>
    /// labels<para>"has basis"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasBasis">https://w3id.org/mdo/structure/hasBasis</seealso>
    let hasBasis = Prefixed_Name(mdo_struc, "hasBasis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/structure/hasCartesianCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasCartesianCoordinates represents the relationship between a site and coordinates in cartesian format it has."</para>
    /// labels<para>"has cartesian coordinates"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasCartesianCoordinates">https://w3id.org/mdo/structure/hasCartesianCoordinates</seealso>
    let hasCartesianCoordinates =
        Prefixed_Name(mdo_struc, "hasCartesianCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/structure/hasComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasComposition represents the relationship between a structure and a a composition it has."</para>
    /// labels<para>"has composition"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasComposition">https://w3id.org/mdo/structure/hasComposition</seealso>
    let hasComposition = Prefixed_Name(mdo_struc, "hasComposition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasElement represents the relationship between a species and atoms it has."</para>
    /// labels<para>"has element"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasElement">https://w3id.org/mdo/structure/hasElement</seealso>
    let hasElement = Prefixed_Name(mdo_struc, "hasElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/structure/hasFractionalCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasFractionalCoordinates represents the relationship between a site and coordinates in fractional format it has."</para>
    /// labels<para>"has fractional coordinates"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasFractionalCoordinates">https://w3id.org/mdo/structure/hasFractionalCoordinates</seealso>
    let hasFractionalCoordinates =
        Prefixed_Name(mdo_struc, "hasFractionalCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/structure/hasLattice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasLattice represents the relationship between a structure and lattices in it has."</para>
    /// labels<para>"has lattice"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasLattice">https://w3id.org/mdo/structure/hasLattice</seealso>
    let hasLattice = Prefixed_Name(mdo_struc, "hasLattice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasLengthVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasLengthVector represents the relationship between a basis or a lattice and a length triple it has."</para>
    /// labels<para>"has length vector"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasLengthVector">https://w3id.org/mdo/structure/hasLengthVector</seealso>
    let hasLengthVector = Prefixed_Name(mdo_struc, "hasLengthVector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasOccupancy represents the relationship between a structure and occupancies it has."</para>
    /// labels<para>"has occupancy"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasOccupancy">https://w3id.org/mdo/structure/hasOccupancy</seealso>
    let hasOccupancy = Prefixed_Name(mdo_struc, "hasOccupancy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasPointGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasPointGroup represents the relationship between a space group and point groups it corresponds to."</para>
    /// labels<para>"has point group"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasPointGroup">https://w3id.org/mdo/structure/hasPointGroup</seealso>
    let hasPointGroup = Prefixed_Name(mdo_struc, "hasPointGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasSite represents the relationship between an occupancy and sites it ties."</para>
    /// labels<para>"has site"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasSite">https://w3id.org/mdo/structure/hasSite</seealso>
    let hasSite = Prefixed_Name(mdo_struc, "hasSite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasSpaceGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasSpaceGroup represents the relationship between a structure and a space group it corresponds to."</para>
    /// labels<para>"has space group"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasSpaceGroup">https://w3id.org/mdo/structure/hasSpaceGroup</seealso>
    let hasSpaceGroup = Prefixed_Name(mdo_struc, "hasSpaceGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/hasSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasSpecies represents the relationship between an occupancy and species it ties."</para>
    /// labels<para>"has species"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/hasSpecies">https://w3id.org/mdo/structure/hasSpecies</seealso>
    let hasSpecies = Prefixed_Name(mdo_struc, "hasSpecies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/has_a_axisVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has_a_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (a)."</para>
    /// labels<para>"has a_axis vector"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/has_a_axisVector">https://w3id.org/mdo/structure/has_a_axisVector</seealso>
    let has_a_axisVector = Prefixed_Name(mdo_struc, "has_a_axisVector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/has_b_axisVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has_b_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (b)."</para>
    /// labels<para>"has b_axis vector"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/has_b_axisVector">https://w3id.org/mdo/structure/has_b_axisVector</seealso>
    let has_b_axisVector = Prefixed_Name(mdo_struc, "has_b_axisVector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/structure/has_c_axisVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has_c_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (c)."</para>
    /// labels<para>"has c_axis vector"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/structure/has_c_axisVector">https://w3id.org/mdo/structure/has_c_axisVector</seealso>
    let has_c_axisVector = Prefixed_Name(mdo_struc, "has_c_axisVector") |> PrefixedName
