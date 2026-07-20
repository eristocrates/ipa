namespace https.w3id.org.mdo.structure.slash

open DoxAletheia

module mdo_struc =
    let _namespace_name = "https://w3id.org/mdo/structure/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A space group is the symmetry group of a three-dimensional crystal pattern is called its space group.
    /// <see href="https://w3id.org/mdo/structure/SpaceGroup"></see></summary>
    let SpaceGroup = _prefix "SpaceGroup"
    /// <summary>
    /// hasSpaceGroup represents the relationship between a structure and a space group it corresponds to.
    /// <see href="https://w3id.org/mdo/structure/hasSpaceGroup"></see></summary>
    let hasSpaceGroup = _prefix "hasSpaceGroup"
    /// <summary>
    /// A composition is used to represent what chemical elements composing a structure and the ratio of the chemical elements.
    /// <see href="https://w3id.org/mdo/structure/Composition"></see></summary>
    let Composition = _prefix "Composition"
    /// <summary>
    /// hasComposition represents the relationship between a structure and a a composition it has.
    /// <see href="https://w3id.org/mdo/structure/hasComposition"></see></summary>
    let hasComposition = _prefix "hasComposition"
    /// <summary>
    /// An occupancy ties a specific species to a site.
    /// <see href="https://w3id.org/mdo/structure/Occupancy"></see></summary>
    let Occupancy = _prefix "Occupancy"
    /// <summary>
    /// hasOccupancy represents the relationship between a structure and occupancies it has.
    /// <see href="https://w3id.org/mdo/structure/hasOccupancy"></see></summary>
    let hasOccupancy = _prefix "hasOccupancy"
    /// <summary>
    /// A basis defines a spatial unit used to express fractional coordinates.
    /// <see href="https://w3id.org/mdo/structure/Basis"></see></summary>
    let Basis = _prefix "Basis"
    /// <summary>
    /// hasBasis represents the relationship between a structure and the bases it has.
    /// <see href="https://w3id.org/mdo/structure/hasBasis"></see></summary>
    let hasBasis = _prefix "hasBasis"
    /// <summary>
    /// A lattice defines a peroidic arrangement of one or more atoms.
    /// <see href="https://w3id.org/mdo/structure/Lattice"></see></summary>
    let Lattice = _prefix "Lattice"
    /// <summary>
    /// hasLattice represents the relationship between a structure and lattices in it has.
    /// <see href="https://w3id.org/mdo/structure/hasLattice"></see></summary>
    let hasLattice = _prefix "hasLattice"
    /// <summary>
    ///   <see href="https://w3id.org/mdo/structure/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
    /// <summary>
    /// A angle triple is a vector of three angles which represent the angles among three bases in a cell.
    /// <see href="https://w3id.org/mdo/structure/AngleTriple"></see></summary>
    let AngleTriple = _prefix "AngleTriple"
    /// <summary>
    /// Angle_gamma represents that an angle triple has the gamma angle's value in a double.
    /// <see href="https://w3id.org/mdo/structure/Angle_gamma"></see></summary>
    let Angle_gamma = _prefix "Angle_gamma"
    /// <summary>
    /// Angle_beta represents that an angle triple has the beta angle's value in a double.
    /// <see href="https://w3id.org/mdo/structure/Angle_beta"></see></summary>
    let Angle_beta = _prefix "Angle_beta"
    /// <summary>
    /// Angle_alpha represents that an angle triple has the alpha angle's value in a double.
    /// <see href="https://w3id.org/mdo/structure/Angle_alpha"></see></summary>
    let Angle_alpha = _prefix "Angle_alpha"
    /// <summary>
    /// AnonymousFormula represents that a composition has the anonymous formula in a string.
    /// <see href="https://w3id.org/mdo/structure/AnonymousFormula"></see></summary>
    let AnonymousFormula = _prefix "AnonymousFormula"
    /// <summary>
    /// An axis-vectors is the three vectors which represent the bases of cell.
    /// <see href="https://w3id.org/mdo/structure/AxisVectors"></see></summary>
    let AxisVectors = _prefix "AxisVectors"
    /// <summary>
    /// A coordinate vector is the coordinates of a point in space.
    /// <see href="https://w3id.org/mdo/structure/CoordinateVector"></see></summary>
    let CoordinateVector = _prefix "CoordinateVector"
    /// <summary>
    /// has_a_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (a).
    /// <see href="https://w3id.org/mdo/structure/has_a_axisVector"></see></summary>
    let has_a_axisVector = _prefix "has_a_axisVector"
    /// <summary>
    /// has_b_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (b).
    /// <see href="https://w3id.org/mdo/structure/has_b_axisVector"></see></summary>
    let has_b_axisVector = _prefix "has_b_axisVector"
    /// <summary>
    /// has_c_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (c).
    /// <see href="https://w3id.org/mdo/structure/has_c_axisVector"></see></summary>
    let has_c_axisVector = _prefix "has_c_axisVector"
    /// <summary>
    /// hasAngleVector represents the relationship between a basis or a lattice and an angle triple it has.
    /// <see href="https://w3id.org/mdo/structure/hasAngleVector"></see></summary>
    let hasAngleVector = _prefix "hasAngleVector"
    /// <summary>
    /// A length triple defines the three parameters (a, b, c) that represent the lengths in three axes respectively.
    /// <see href="https://w3id.org/mdo/structure/LengthTriple"></see></summary>
    let LengthTriple = _prefix "LengthTriple"
    /// <summary>
    /// hasLengthVector represents the relationship between a basis or a lattice and a length triple it has.
    /// <see href="https://w3id.org/mdo/structure/hasLengthVector"></see></summary>
    let hasLengthVector = _prefix "hasLengthVector"
    /// <summary>
    /// hasAxisVectors represents the relationship between a basis or a lattice and a axis-vectors it has.
    /// <see href="https://w3id.org/mdo/structure/hasAxisVectors"></see></summary>
    let hasAxisVectors = _prefix "hasAxisVectors"
    /// <summary>
    /// Z_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Z axis.
    /// <see href="https://w3id.org/mdo/structure/Z_axisCoordinate"></see></summary>
    let Z_axisCoordinate = _prefix "Z_axisCoordinate"
    /// <summary>
    /// Y_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Y axis.
    /// <see href="https://w3id.org/mdo/structure/Y_axisCoordinate"></see></summary>
    let Y_axisCoordinate = _prefix "Y_axisCoordinate"
    /// <summary>
    /// X_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in X axis.
    /// <see href="https://w3id.org/mdo/structure/X_axisCoordinate"></see></summary>
    let X_axisCoordinate = _prefix "X_axisCoordinate"
    /// <summary>
    /// DescriptiveFormula represents that a composition has the descriptive formula in a string.
    /// <see href="https://w3id.org/mdo/structure/DescriptiveFormula"></see></summary>
    let DescriptiveFormula = _prefix "DescriptiveFormula"
    /// <summary>
    /// ElementRatio represents that a species has the ratio in a double.
    /// <see href="https://w3id.org/mdo/structure/ElementRatio"></see></summary>
    let ElementRatio = _prefix "ElementRatio"
    /// <summary>
    /// A species is the combination of atoms on each site.
    /// <see href="https://w3id.org/mdo/structure/Species"></see></summary>
    let Species = _prefix "Species"
    /// <summary>
    /// HillFormula represents that a composition has the hill formula in a string.
    /// <see href="https://w3id.org/mdo/structure/HillFormula"></see></summary>
    let HillFormula = _prefix "HillFormula"
    /// <summary>
    /// LatticeType represents that a lattice has the type in a string.
    /// <see href="https://w3id.org/mdo/structure/LatticeType"></see></summary>
    let LatticeType = _prefix "LatticeType"
    /// <summary>
    /// LatticeVolume represents that a lattice has the volume in a double.
    /// <see href="https://w3id.org/mdo/structure/LatticeVolume"></see></summary>
    let LatticeVolume = _prefix "LatticeVolume"
    /// <summary>
    /// Length_c represents that a length triple has the 'c' value in a double.
    /// <see href="https://w3id.org/mdo/structure/Length_c"></see></summary>
    let Length_c = _prefix "Length_c"
    /// <summary>
    /// Length_b represents that a length triple has the 'b' value in a double.
    /// <see href="https://w3id.org/mdo/structure/Length_b"></see></summary>
    let Length_b = _prefix "Length_b"
    /// <summary>
    /// Length_a represents that a length triple has the 'a' value in a double.
    /// <see href="https://w3id.org/mdo/structure/Length_a"></see></summary>
    let Length_a = _prefix "Length_a"
    /// <summary>
    /// hasSpecies represents the relationship between an occupancy and species it ties.
    /// <see href="https://w3id.org/mdo/structure/hasSpecies"></see></summary>
    let hasSpecies = _prefix "hasSpecies"
    /// <summary>
    /// A site is a point in a lattice.
    /// <see href="https://w3id.org/mdo/structure/Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    /// hasSite represents the relationship between an occupancy and sites it ties.
    /// <see href="https://w3id.org/mdo/structure/hasSite"></see></summary>
    let hasSite = _prefix "hasSite"
    /// <summary>
    /// A group of linear mappings of vector space, which is corresonpond to the group of motions in point space determining the symmetry of the macroscopic crystal, is called the point group of the crystal, furthermore of the crystal structure, and is also called the point group of its space group.
    /// <see href="https://w3id.org/mdo/structure/PointGroup"></see></summary>
    let PointGroup = _prefix "PointGroup"
    /// <summary>
    /// PointGroupHMName represents that a point group has the Hermann-Mauguin in a string.
    /// <see href="https://w3id.org/mdo/structure/PointGroupHMName"></see></summary>
    let PointGroupHMName = _prefix "PointGroupHMName"
    /// <summary>
    /// ReducedFormula represents that a composition has the reduced formula in a string.
    /// <see href="https://w3id.org/mdo/structure/ReducedFormula"></see></summary>
    let ReducedFormula = _prefix "ReducedFormula"
    /// <summary>
    /// hasFractionalCoordinates represents the relationship between a site and coordinates in fractional format it has.
    /// <see href="https://w3id.org/mdo/structure/hasFractionalCoordinates"></see></summary>
    let hasFractionalCoordinates = _prefix "hasFractionalCoordinates"
    /// <summary>
    /// hasCartesianCoordinates represents the relationship between a site and coordinates in cartesian format it has.
    /// <see href="https://w3id.org/mdo/structure/hasCartesianCoordinates"></see></summary>
    let hasCartesianCoordinates = _prefix "hasCartesianCoordinates"
    /// <summary>
    /// SpaceGroupSymbol represents that a space group has the symbol in a string.
    /// <see href="https://w3id.org/mdo/structure/SpaceGroupSymbol"></see></summary>
    let SpaceGroupSymbol = _prefix "SpaceGroupSymbol"
    /// <summary>
    /// SpaceGroupID represents that a space group has the unique ID in an integer.
    /// <see href="https://w3id.org/mdo/structure/SpaceGroupID"></see></summary>
    let SpaceGroupID = _prefix "SpaceGroupID"
    /// <summary>
    /// hasPointGroup represents the relationship between a space group and point groups it corresponds to.
    /// <see href="https://w3id.org/mdo/structure/hasPointGroup"></see></summary>
    let hasPointGroup = _prefix "hasPointGroup"
    /// <summary>
    /// hasElement represents the relationship between a species and atoms it has.
    /// <see href="https://w3id.org/mdo/structure/hasElement"></see></summary>
    let hasElement = _prefix "hasElement"
