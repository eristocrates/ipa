#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``mdo-struc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/mdo/structure/" "mdo-struc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Angle Triple</para>
    ///   <para>rdfs:comment : A angle triple is a vector of three angles which represent the angles among three bases in a cell.</para>
    ///   <a href="https://w3id.org/mdo/structure/AngleTriple">mdo-struc:AngleTriple</a>
    /// </summary>
    let AngleTriple = _prefixId.prefix "AngleTriple"
    /// <summary>
    ///   <para>rdfs:label : Angle_alpha</para>
    ///   <para>rdfs:comment : Angle_alpha represents that an angle triple has the alpha angle's value in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/Angle_alpha">mdo-struc:Angle_alpha</a>
    /// </summary>
    let Angle_alpha = _prefixId.prefix "Angle_alpha"
    /// <summary>
    ///   <para>rdfs:label : Angle_beta</para>
    ///   <para>rdfs:comment : Angle_beta represents that an angle triple has the beta angle's value in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/Angle_beta">mdo-struc:Angle_beta</a>
    /// </summary>
    let Angle_beta = _prefixId.prefix "Angle_beta"
    /// <summary>
    ///   <para>rdfs:label : Angle_gamma</para>
    ///   <para>rdfs:comment : Angle_gamma represents that an angle triple has the gamma angle's value in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/Angle_gamma">mdo-struc:Angle_gamma</a>
    /// </summary>
    let Angle_gamma = _prefixId.prefix "Angle_gamma"
    /// <summary>
    ///   <para>rdfs:label : anonymous formula</para>
    ///   <para>rdfs:comment : AnonymousFormula represents that a composition has the anonymous formula in a string.</para>
    ///   <a href="https://w3id.org/mdo/structure/AnonymousFormula">mdo-struc:AnonymousFormula</a>
    /// </summary>
    let AnonymousFormula = _prefixId.prefix "AnonymousFormula"
    /// <summary>
    ///   <para>rdfs:label : Axis Vectors</para>
    ///   <para>rdfs:comment : An axis-vectors is the three vectors which represent the bases of cell.</para>
    ///   <a href="https://w3id.org/mdo/structure/AxisVectors">mdo-struc:AxisVectors</a>
    /// </summary>
    let AxisVectors = _prefixId.prefix "AxisVectors"
    /// <summary>
    ///   <para>rdfs:label : Basis</para>
    ///   <para>rdfs:comment : A basis defines a spatial unit used to express fractional coordinates.</para>
    ///   <a href="https://w3id.org/mdo/structure/Basis">mdo-struc:Basis</a>
    /// </summary>
    let Basis = _prefixId.prefix "Basis"
    /// <summary>
    ///   <para>rdfs:label : Composition</para>
    ///   <para>rdfs:comment : A composition is used to represent what chemical elements composing a structure and the ratio of the chemical elements.</para>
    ///   <a href="https://w3id.org/mdo/structure/Composition">mdo-struc:Composition</a>
    /// </summary>
    let Composition = _prefixId.prefix "Composition"
    /// <summary>
    ///   <para>rdfs:label : Coordinate Vector</para>
    ///   <para>rdfs:comment : A coordinate vector is the coordinates of a point in space.</para>
    ///   <a href="https://w3id.org/mdo/structure/CoordinateVector">mdo-struc:CoordinateVector</a>
    /// </summary>
    let CoordinateVector = _prefixId.prefix "CoordinateVector"
    /// <summary>
    ///   <para>rdfs:label : descriptive formula</para>
    ///   <para>rdfs:comment : DescriptiveFormula represents that a composition has the descriptive formula in a string.</para>
    ///   <a href="https://w3id.org/mdo/structure/DescriptiveFormula">mdo-struc:DescriptiveFormula</a>
    /// </summary>
    let DescriptiveFormula = _prefixId.prefix "DescriptiveFormula"
    /// <summary>
    ///   <para>rdfs:label : element ratio</para>
    ///   <para>rdfs:comment : ElementRatio represents that a species has the ratio in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/ElementRatio">mdo-struc:ElementRatio</a>
    /// </summary>
    let ElementRatio = _prefixId.prefix "ElementRatio"
    /// <summary>
    ///   <para>rdfs:label : hill formula</para>
    ///   <para>rdfs:comment : HillFormula represents that a composition has the hill formula in a string.</para>
    ///   <a href="https://w3id.org/mdo/structure/HillFormula">mdo-struc:HillFormula</a>
    /// </summary>
    let HillFormula = _prefixId.prefix "HillFormula"
    /// <summary>
    ///   <para>rdfs:label : Lattice</para>
    ///   <para>rdfs:comment : A lattice defines a peroidic arrangement of one or more atoms.</para>
    ///   <a href="https://w3id.org/mdo/structure/Lattice">mdo-struc:Lattice</a>
    /// </summary>
    let Lattice = _prefixId.prefix "Lattice"
    /// <summary>
    ///   <para>rdfs:label : lattice type</para>
    ///   <para>rdfs:comment : LatticeType represents that a lattice has the type in a string.</para>
    ///   <a href="https://w3id.org/mdo/structure/LatticeType">mdo-struc:LatticeType</a>
    /// </summary>
    let LatticeType = _prefixId.prefix "LatticeType"
    /// <summary>
    ///   <para>rdfs:label : lattice volume</para>
    ///   <para>rdfs:comment : LatticeVolume represents that a lattice has the volume in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/LatticeVolume">mdo-struc:LatticeVolume</a>
    /// </summary>
    let LatticeVolume = _prefixId.prefix "LatticeVolume"
    /// <summary>
    ///   <para>rdfs:label : Length Triple</para>
    ///   <para>rdfs:comment : A length triple defines the three parameters (a, b, c) that represent the lengths in three axes respectively.</para>
    ///   <a href="https://w3id.org/mdo/structure/LengthTriple">mdo-struc:LengthTriple</a>
    /// </summary>
    let LengthTriple = _prefixId.prefix "LengthTriple"
    /// <summary>
    ///   <para>rdfs:label : Length_a</para>
    ///   <para>rdfs:comment : Length_a represents that a length triple has the 'a' value in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/Length_a">mdo-struc:Length_a</a>
    /// </summary>
    let Length_a = _prefixId.prefix "Length_a"
    /// <summary>
    ///   <para>rdfs:label : Length_b</para>
    ///   <para>rdfs:comment : Length_b represents that a length triple has the 'b' value in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/Length_b">mdo-struc:Length_b</a>
    /// </summary>
    let Length_b = _prefixId.prefix "Length_b"
    /// <summary>
    ///   <para>rdfs:label : Length_c</para>
    ///   <para>rdfs:comment : Length_c represents that a length triple has the 'c' value in a double.</para>
    ///   <a href="https://w3id.org/mdo/structure/Length_c">mdo-struc:Length_c</a>
    /// </summary>
    let Length_c = _prefixId.prefix "Length_c"
    /// <summary>
    ///   <para>rdfs:label : Occupancy</para>
    ///   <para>rdfs:comment : An occupancy ties a specific species to a site.</para>
    ///   <a href="https://w3id.org/mdo/structure/Occupancy">mdo-struc:Occupancy</a>
    /// </summary>
    let Occupancy = _prefixId.prefix "Occupancy"
    /// <summary>
    ///   <para>rdfs:seeAlso : International Tables for Crystallography, Volume A, Fourth, revised edition, Section 8.1.5.</para>
    ///   <para>rdfs:label : Point Group</para>
    ///   <para>rdfs:comment : A group of linear mappings of vector space, which is corresonpond to the group of motions in point space determining the symmetry of the macroscopic crystal, is called the point group of the crystal, furthermore of the crystal structure, and is also called the point group of its space group.</para>
    ///   <a href="https://w3id.org/mdo/structure/PointGroup">mdo-struc:PointGroup</a>
    /// </summary>
    let PointGroup = _prefixId.prefix "PointGroup"
    /// <summary>
    ///   <para>rdfs:label : point group Hermann-Mauguin name</para>
    ///   <para>rdfs:comment : PointGroupHMName represents that a point group has the Hermann-Mauguin in a string.</para>
    ///   <a href="https://w3id.org/mdo/structure/PointGroupHMName">mdo-struc:PointGroupHMName</a>
    /// </summary>
    let PointGroupHMName = _prefixId.prefix "PointGroupHMName"
    /// <summary>
    ///   <para>rdfs:label : reduced formula</para>
    ///   <para>rdfs:comment : ReducedFormula represents that a composition has the reduced formula in a string.</para>
    ///   <a href="https://w3id.org/mdo/structure/ReducedFormula">mdo-struc:ReducedFormula</a>
    /// </summary>
    let ReducedFormula = _prefixId.prefix "ReducedFormula"
    /// <summary>
    ///   <para>rdfs:label : Site</para>
    ///   <para>rdfs:comment : A site is a point in a lattice.</para>
    ///   <a href="https://w3id.org/mdo/structure/Site">mdo-struc:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:seeAlso : International Tables for Crystallography, Volume !, Fourth, revised edition, Section 8.1.5.</para>
    ///   <para>rdfs:label : Space Group</para>
    ///   <para>rdfs:comment : A space group is the symmetry group of a three-dimensional crystal pattern is called its space group.</para>
    ///   <a href="https://w3id.org/mdo/structure/SpaceGroup">mdo-struc:SpaceGroup</a>
    /// </summary>
    let SpaceGroup = _prefixId.prefix "SpaceGroup"
    /// <summary>
    ///   <para>rdfs:label : space group ID</para>
    ///   <para>rdfs:comment : SpaceGroupID represents that a space group has the unique ID in an integer.</para>
    ///   <a href="https://w3id.org/mdo/structure/SpaceGroupID">mdo-struc:SpaceGroupID</a>
    /// </summary>
    let SpaceGroupID = _prefixId.prefix "SpaceGroupID"
    /// <summary>
    ///   <para>rdfs:label : space group symbol</para>
    ///   <para>rdfs:comment : SpaceGroupSymbol represents that a space group has the symbol in a string.</para>
    ///   <a href="https://w3id.org/mdo/structure/SpaceGroupSymbol">mdo-struc:SpaceGroupSymbol</a>
    /// </summary>
    let SpaceGroupSymbol = _prefixId.prefix "SpaceGroupSymbol"
    /// <summary>
    ///   <para>rdfs:label : Species</para>
    ///   <para>rdfs:comment : A species is the combination of atoms on each site.</para>
    ///   <a href="https://w3id.org/mdo/structure/Species">mdo-struc:Species</a>
    /// </summary>
    let Species = _prefixId.prefix "Species"
    /// <summary>
    ///   <para>rdfs:label : X_axis coordinate</para>
    ///   <para>rdfs:comment : X_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in X axis.</para>
    ///   <a href="https://w3id.org/mdo/structure/X_axisCoordinate">mdo-struc:X_axisCoordinate</a>
    /// </summary>
    let X_axisCoordinate = _prefixId.prefix "X_axisCoordinate"
    /// <summary>
    ///   <para>rdfs:label : Y_axis coordinate</para>
    ///   <para>rdfs:comment : Y_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Y axis.</para>
    ///   <a href="https://w3id.org/mdo/structure/Y_axisCoordinate">mdo-struc:Y_axisCoordinate</a>
    /// </summary>
    let Y_axisCoordinate = _prefixId.prefix "Y_axisCoordinate"
    /// <summary>
    ///   <para>rdfs:label : Z_axis coordinate</para>
    ///   <para>rdfs:comment : Z_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Z axis.</para>
    ///   <a href="https://w3id.org/mdo/structure/Z_axisCoordinate">mdo-struc:Z_axisCoordinate</a>
    /// </summary>
    let Z_axisCoordinate = _prefixId.prefix "Z_axisCoordinate"
    /// <summary>
    ///   <para>rdfs:label : has angle vector</para>
    ///   <para>rdfs:comment : hasAngleVector represents the relationship between a basis or a lattice and an angle triple it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasAngleVector">mdo-struc:hasAngleVector</a>
    /// </summary>
    let hasAngleVector = _prefixId.prefix "hasAngleVector"
    /// <summary>
    ///   <para>rdfs:label : has axis vectors</para>
    ///   <para>rdfs:comment : hasAxisVectors represents the relationship between a basis or a lattice and a axis-vectors it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasAxisVectors">mdo-struc:hasAxisVectors</a>
    /// </summary>
    let hasAxisVectors = _prefixId.prefix "hasAxisVectors"
    /// <summary>
    ///   <para>rdfs:label : has basis</para>
    ///   <para>rdfs:comment : hasBasis represents the relationship between a structure and the bases it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasBasis">mdo-struc:hasBasis</a>
    /// </summary>
    let hasBasis = _prefixId.prefix "hasBasis"
    /// <summary>
    ///   <para>rdfs:label : has cartesian coordinates</para>
    ///   <para>rdfs:comment : hasCartesianCoordinates represents the relationship between a site and coordinates in cartesian format it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasCartesianCoordinates">mdo-struc:hasCartesianCoordinates</a>
    /// </summary>
    let hasCartesianCoordinates = _prefixId.prefix "hasCartesianCoordinates"
    /// <summary>
    ///   <para>rdfs:label : has composition</para>
    ///   <para>rdfs:comment : hasComposition represents the relationship between a structure and a a composition it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasComposition">mdo-struc:hasComposition</a>
    /// </summary>
    let hasComposition = _prefixId.prefix "hasComposition"
    /// <summary>
    ///   <para>rdfs:label : has element</para>
    ///   <para>rdfs:comment : hasElement represents the relationship between a species and atoms it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasElement">mdo-struc:hasElement</a>
    /// </summary>
    let hasElement = _prefixId.prefix "hasElement"
    /// <summary>
    ///   <para>rdfs:label : has fractional coordinates</para>
    ///   <para>rdfs:comment : hasFractionalCoordinates represents the relationship between a site and coordinates in fractional format it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasFractionalCoordinates">mdo-struc:hasFractionalCoordinates</a>
    /// </summary>
    let hasFractionalCoordinates = _prefixId.prefix "hasFractionalCoordinates"
    /// <summary>
    ///   <para>rdfs:label : has lattice</para>
    ///   <para>rdfs:comment : hasLattice represents the relationship between a structure and lattices in it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasLattice">mdo-struc:hasLattice</a>
    /// </summary>
    let hasLattice = _prefixId.prefix "hasLattice"
    /// <summary>
    ///   <para>rdfs:label : has length vector</para>
    ///   <para>rdfs:comment : hasLengthVector represents the relationship between a basis or a lattice and a length triple it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasLengthVector">mdo-struc:hasLengthVector</a>
    /// </summary>
    let hasLengthVector = _prefixId.prefix "hasLengthVector"
    /// <summary>
    ///   <para>rdfs:label : has occupancy</para>
    ///   <para>rdfs:comment : hasOccupancy represents the relationship between a structure and occupancies it has.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasOccupancy">mdo-struc:hasOccupancy</a>
    /// </summary>
    let hasOccupancy = _prefixId.prefix "hasOccupancy"
    /// <summary>
    ///   <para>rdfs:label : has point group</para>
    ///   <para>rdfs:comment : hasPointGroup represents the relationship between a space group and point groups it corresponds to.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasPointGroup">mdo-struc:hasPointGroup</a>
    /// </summary>
    let hasPointGroup = _prefixId.prefix "hasPointGroup"
    /// <summary>
    ///   <para>rdfs:label : has site</para>
    ///   <para>rdfs:comment : hasSite represents the relationship between an occupancy and sites it ties.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasSite">mdo-struc:hasSite</a>
    /// </summary>
    let hasSite = _prefixId.prefix "hasSite"
    /// <summary>
    ///   <para>rdfs:label : has space group</para>
    ///   <para>rdfs:comment : hasSpaceGroup represents the relationship between a structure and a space group it corresponds to.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasSpaceGroup">mdo-struc:hasSpaceGroup</a>
    /// </summary>
    let hasSpaceGroup = _prefixId.prefix "hasSpaceGroup"
    /// <summary>
    ///   <para>rdfs:label : has species</para>
    ///   <para>rdfs:comment : hasSpecies represents the relationship between an occupancy and species it ties.</para>
    ///   <a href="https://w3id.org/mdo/structure/hasSpecies">mdo-struc:hasSpecies</a>
    /// </summary>
    let hasSpecies = _prefixId.prefix "hasSpecies"
    /// <summary>
    ///   <para>rdfs:label : has a_axis vector</para>
    ///   <para>rdfs:comment : has_a_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (a).</para>
    ///   <a href="https://w3id.org/mdo/structure/has_a_axisVector">mdo-struc:has_a_axisVector</a>
    /// </summary>
    let has_a_axisVector = _prefixId.prefix "has_a_axisVector"
    /// <summary>
    ///   <para>rdfs:label : has b_axis vector</para>
    ///   <para>rdfs:comment : has_b_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (b).</para>
    ///   <a href="https://w3id.org/mdo/structure/has_b_axisVector">mdo-struc:has_b_axisVector</a>
    /// </summary>
    let has_b_axisVector = _prefixId.prefix "has_b_axisVector"
    /// <summary>
    ///   <para>rdfs:label : has c_axis vector</para>
    ///   <para>rdfs:comment : has_c_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (c).</para>
    ///   <a href="https://w3id.org/mdo/structure/has_c_axisVector">mdo-struc:has_c_axisVector</a>
    /// </summary>
    let has_c_axisVector = _prefixId.prefix "has_c_axisVector"
