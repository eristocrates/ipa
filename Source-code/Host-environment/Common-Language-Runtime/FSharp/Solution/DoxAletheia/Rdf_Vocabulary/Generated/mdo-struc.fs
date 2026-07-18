namespace https.w3id.org.mdo.structure.slash

open DoxAletheia.Rdf_Vocabulary

module mdo_struc =
    let _namespace_name = "https://w3id.org/mdo/structure/"
    /// <summary>
    /// A space group is the symmetry group of a three-dimensional crystal pattern is called its space group.
    /// <see href="https://w3id.org/mdo/structure/SpaceGroup"></see></summary>
    let SpaceGroup = Namespaced_IRI.parse _namespace_name "SpaceGroup" |> NamespacedName

    /// <summary>
    /// hasSpaceGroup represents the relationship between a structure and a space group it corresponds to.
    /// <see href="https://w3id.org/mdo/structure/hasSpaceGroup"></see></summary>
    let hasSpaceGroup =
        Namespaced_IRI.parse _namespace_name "hasSpaceGroup" |> NamespacedName

    /// <summary>
    /// A composition is used to represent what chemical elements composing a structure and the ratio of the chemical elements.
    /// <see href="https://w3id.org/mdo/structure/Composition"></see></summary>
    let Composition =
        Namespaced_IRI.parse _namespace_name "Composition" |> NamespacedName

    /// <summary>
    /// hasComposition represents the relationship between a structure and a a composition it has.
    /// <see href="https://w3id.org/mdo/structure/hasComposition"></see></summary>
    let hasComposition =
        Namespaced_IRI.parse _namespace_name "hasComposition" |> NamespacedName

    /// <summary>
    /// An occupancy ties a specific species to a site.
    /// <see href="https://w3id.org/mdo/structure/Occupancy"></see></summary>
    let Occupancy = Namespaced_IRI.parse _namespace_name "Occupancy" |> NamespacedName

    /// <summary>
    /// hasOccupancy represents the relationship between a structure and occupancies it has.
    /// <see href="https://w3id.org/mdo/structure/hasOccupancy"></see></summary>
    let hasOccupancy =
        Namespaced_IRI.parse _namespace_name "hasOccupancy" |> NamespacedName

    /// <summary>
    /// A basis defines a spatial unit used to express fractional coordinates.
    /// <see href="https://w3id.org/mdo/structure/Basis"></see></summary>
    let Basis = Namespaced_IRI.parse _namespace_name "Basis" |> NamespacedName
    /// <summary>
    /// hasBasis represents the relationship between a structure and the bases it has.
    /// <see href="https://w3id.org/mdo/structure/hasBasis"></see></summary>
    let hasBasis = Namespaced_IRI.parse _namespace_name "hasBasis" |> NamespacedName
    /// <summary>
    /// A lattice defines a peroidic arrangement of one or more atoms.
    /// <see href="https://w3id.org/mdo/structure/Lattice"></see></summary>
    let Lattice = Namespaced_IRI.parse _namespace_name "Lattice" |> NamespacedName
    /// <summary>
    /// hasLattice represents the relationship between a structure and lattices in it has.
    /// <see href="https://w3id.org/mdo/structure/hasLattice"></see></summary>
    let hasLattice = Namespaced_IRI.parse _namespace_name "hasLattice" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/mdo/structure/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = Namespaced_IRI.parse _namespace_name "1.0/" |> NamespacedName

    /// <summary>
    /// A angle triple is a vector of three angles which represent the angles among three bases in a cell.
    /// <see href="https://w3id.org/mdo/structure/AngleTriple"></see></summary>
    let AngleTriple =
        Namespaced_IRI.parse _namespace_name "AngleTriple" |> NamespacedName

    /// <summary>
    /// Angle_gamma represents that an angle triple has the gamma angle's value in a double.
    /// <see href="https://w3id.org/mdo/structure/Angle_gamma"></see></summary>
    let Angle_gamma =
        Namespaced_IRI.parse _namespace_name "Angle_gamma" |> NamespacedName

    /// <summary>
    /// Angle_beta represents that an angle triple has the beta angle's value in a double.
    /// <see href="https://w3id.org/mdo/structure/Angle_beta"></see></summary>
    let Angle_beta = Namespaced_IRI.parse _namespace_name "Angle_beta" |> NamespacedName

    /// <summary>
    /// Angle_alpha represents that an angle triple has the alpha angle's value in a double.
    /// <see href="https://w3id.org/mdo/structure/Angle_alpha"></see></summary>
    let Angle_alpha =
        Namespaced_IRI.parse _namespace_name "Angle_alpha" |> NamespacedName

    /// <summary>
    /// AnonymousFormula represents that a composition has the anonymous formula in a string.
    /// <see href="https://w3id.org/mdo/structure/AnonymousFormula"></see></summary>
    let AnonymousFormula =
        Namespaced_IRI.parse _namespace_name "AnonymousFormula" |> NamespacedName

    /// <summary>
    /// An axis-vectors is the three vectors which represent the bases of cell.
    /// <see href="https://w3id.org/mdo/structure/AxisVectors"></see></summary>
    let AxisVectors =
        Namespaced_IRI.parse _namespace_name "AxisVectors" |> NamespacedName

    /// <summary>
    /// A coordinate vector is the coordinates of a point in space.
    /// <see href="https://w3id.org/mdo/structure/CoordinateVector"></see></summary>
    let CoordinateVector =
        Namespaced_IRI.parse _namespace_name "CoordinateVector" |> NamespacedName

    /// <summary>
    /// has_a_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (a).
    /// <see href="https://w3id.org/mdo/structure/has_a_axisVector"></see></summary>
    let has_a_axisVector =
        Namespaced_IRI.parse _namespace_name "has_a_axisVector" |> NamespacedName

    /// <summary>
    /// has_b_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (b).
    /// <see href="https://w3id.org/mdo/structure/has_b_axisVector"></see></summary>
    let has_b_axisVector =
        Namespaced_IRI.parse _namespace_name "has_b_axisVector" |> NamespacedName

    /// <summary>
    /// has_c_axisVector represents the relationship between an axis-vectors and a coordinate vector to define the coordiantes of the translation vector (c).
    /// <see href="https://w3id.org/mdo/structure/has_c_axisVector"></see></summary>
    let has_c_axisVector =
        Namespaced_IRI.parse _namespace_name "has_c_axisVector" |> NamespacedName

    /// <summary>
    /// hasAngleVector represents the relationship between a basis or a lattice and an angle triple it has.
    /// <see href="https://w3id.org/mdo/structure/hasAngleVector"></see></summary>
    let hasAngleVector =
        Namespaced_IRI.parse _namespace_name "hasAngleVector" |> NamespacedName

    /// <summary>
    /// A length triple defines the three parameters (a, b, c) that represent the lengths in three axes respectively.
    /// <see href="https://w3id.org/mdo/structure/LengthTriple"></see></summary>
    let LengthTriple =
        Namespaced_IRI.parse _namespace_name "LengthTriple" |> NamespacedName

    /// <summary>
    /// hasLengthVector represents the relationship between a basis or a lattice and a length triple it has.
    /// <see href="https://w3id.org/mdo/structure/hasLengthVector"></see></summary>
    let hasLengthVector =
        Namespaced_IRI.parse _namespace_name "hasLengthVector" |> NamespacedName

    /// <summary>
    /// hasAxisVectors represents the relationship between a basis or a lattice and a axis-vectors it has.
    /// <see href="https://w3id.org/mdo/structure/hasAxisVectors"></see></summary>
    let hasAxisVectors =
        Namespaced_IRI.parse _namespace_name "hasAxisVectors" |> NamespacedName

    /// <summary>
    /// Z_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Z axis.
    /// <see href="https://w3id.org/mdo/structure/Z_axisCoordinate"></see></summary>
    let Z_axisCoordinate =
        Namespaced_IRI.parse _namespace_name "Z_axisCoordinate" |> NamespacedName

    /// <summary>
    /// Y_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in Y axis.
    /// <see href="https://w3id.org/mdo/structure/Y_axisCoordinate"></see></summary>
    let Y_axisCoordinate =
        Namespaced_IRI.parse _namespace_name "Y_axisCoordinate" |> NamespacedName

    /// <summary>
    /// X_axisCoordinate represents that a coordinate vector has the value of a coordinate in a double in X axis.
    /// <see href="https://w3id.org/mdo/structure/X_axisCoordinate"></see></summary>
    let X_axisCoordinate =
        Namespaced_IRI.parse _namespace_name "X_axisCoordinate" |> NamespacedName

    /// <summary>
    /// DescriptiveFormula represents that a composition has the descriptive formula in a string.
    /// <see href="https://w3id.org/mdo/structure/DescriptiveFormula"></see></summary>
    let DescriptiveFormula =
        Namespaced_IRI.parse _namespace_name "DescriptiveFormula" |> NamespacedName

    /// <summary>
    /// ElementRatio represents that a species has the ratio in a double.
    /// <see href="https://w3id.org/mdo/structure/ElementRatio"></see></summary>
    let ElementRatio =
        Namespaced_IRI.parse _namespace_name "ElementRatio" |> NamespacedName

    /// <summary>
    /// A species is the combination of atoms on each site.
    /// <see href="https://w3id.org/mdo/structure/Species"></see></summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName

    /// <summary>
    /// HillFormula represents that a composition has the hill formula in a string.
    /// <see href="https://w3id.org/mdo/structure/HillFormula"></see></summary>
    let HillFormula =
        Namespaced_IRI.parse _namespace_name "HillFormula" |> NamespacedName

    /// <summary>
    /// LatticeType represents that a lattice has the type in a string.
    /// <see href="https://w3id.org/mdo/structure/LatticeType"></see></summary>
    let LatticeType =
        Namespaced_IRI.parse _namespace_name "LatticeType" |> NamespacedName

    /// <summary>
    /// LatticeVolume represents that a lattice has the volume in a double.
    /// <see href="https://w3id.org/mdo/structure/LatticeVolume"></see></summary>
    let LatticeVolume =
        Namespaced_IRI.parse _namespace_name "LatticeVolume" |> NamespacedName

    /// <summary>
    /// Length_c represents that a length triple has the 'c' value in a double.
    /// <see href="https://w3id.org/mdo/structure/Length_c"></see></summary>
    let Length_c = Namespaced_IRI.parse _namespace_name "Length_c" |> NamespacedName
    /// <summary>
    /// Length_b represents that a length triple has the 'b' value in a double.
    /// <see href="https://w3id.org/mdo/structure/Length_b"></see></summary>
    let Length_b = Namespaced_IRI.parse _namespace_name "Length_b" |> NamespacedName
    /// <summary>
    /// Length_a represents that a length triple has the 'a' value in a double.
    /// <see href="https://w3id.org/mdo/structure/Length_a"></see></summary>
    let Length_a = Namespaced_IRI.parse _namespace_name "Length_a" |> NamespacedName
    /// <summary>
    /// hasSpecies represents the relationship between an occupancy and species it ties.
    /// <see href="https://w3id.org/mdo/structure/hasSpecies"></see></summary>
    let hasSpecies = Namespaced_IRI.parse _namespace_name "hasSpecies" |> NamespacedName
    /// <summary>
    /// A site is a point in a lattice.
    /// <see href="https://w3id.org/mdo/structure/Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    /// hasSite represents the relationship between an occupancy and sites it ties.
    /// <see href="https://w3id.org/mdo/structure/hasSite"></see></summary>
    let hasSite = Namespaced_IRI.parse _namespace_name "hasSite" |> NamespacedName
    /// <summary>
    /// A group of linear mappings of vector space, which is corresonpond to the group of motions in point space determining the symmetry of the macroscopic crystal, is called the point group of the crystal, furthermore of the crystal structure, and is also called the point group of its space group.
    /// <see href="https://w3id.org/mdo/structure/PointGroup"></see></summary>
    let PointGroup = Namespaced_IRI.parse _namespace_name "PointGroup" |> NamespacedName

    /// <summary>
    /// PointGroupHMName represents that a point group has the Hermann-Mauguin in a string.
    /// <see href="https://w3id.org/mdo/structure/PointGroupHMName"></see></summary>
    let PointGroupHMName =
        Namespaced_IRI.parse _namespace_name "PointGroupHMName" |> NamespacedName

    /// <summary>
    /// ReducedFormula represents that a composition has the reduced formula in a string.
    /// <see href="https://w3id.org/mdo/structure/ReducedFormula"></see></summary>
    let ReducedFormula =
        Namespaced_IRI.parse _namespace_name "ReducedFormula" |> NamespacedName

    /// <summary>
    /// hasFractionalCoordinates represents the relationship between a site and coordinates in fractional format it has.
    /// <see href="https://w3id.org/mdo/structure/hasFractionalCoordinates"></see></summary>
    let hasFractionalCoordinates =
        Namespaced_IRI.parse _namespace_name "hasFractionalCoordinates" |> NamespacedName

    /// <summary>
    /// hasCartesianCoordinates represents the relationship between a site and coordinates in cartesian format it has.
    /// <see href="https://w3id.org/mdo/structure/hasCartesianCoordinates"></see></summary>
    let hasCartesianCoordinates =
        Namespaced_IRI.parse _namespace_name "hasCartesianCoordinates" |> NamespacedName

    /// <summary>
    /// SpaceGroupSymbol represents that a space group has the symbol in a string.
    /// <see href="https://w3id.org/mdo/structure/SpaceGroupSymbol"></see></summary>
    let SpaceGroupSymbol =
        Namespaced_IRI.parse _namespace_name "SpaceGroupSymbol" |> NamespacedName

    /// <summary>
    /// SpaceGroupID represents that a space group has the unique ID in an integer.
    /// <see href="https://w3id.org/mdo/structure/SpaceGroupID"></see></summary>
    let SpaceGroupID =
        Namespaced_IRI.parse _namespace_name "SpaceGroupID" |> NamespacedName

    /// <summary>
    /// hasPointGroup represents the relationship between a space group and point groups it corresponds to.
    /// <see href="https://w3id.org/mdo/structure/hasPointGroup"></see></summary>
    let hasPointGroup =
        Namespaced_IRI.parse _namespace_name "hasPointGroup" |> NamespacedName

    /// <summary>
    /// hasElement represents the relationship between a species and atoms it has.
    /// <see href="https://w3id.org/mdo/structure/hasElement"></see></summary>
    let hasElement = Namespaced_IRI.parse _namespace_name "hasElement" |> NamespacedName
