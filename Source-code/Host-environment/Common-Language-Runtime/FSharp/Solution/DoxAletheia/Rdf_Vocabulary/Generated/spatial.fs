namespace http.geovocab.org.spatial.hash

open DoxAletheia

module spatial =
    let _namespace_name = "http://geovocab.org/spatial#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Relation C(x,y), read as 'x is connected with y'. This relation holds when two regions share a common point. It is the primitive relation
    /// 				in the RCC theory.
    /// <see href="http://geovocab.org/spatial#C"></see></summary>
    let C = _prefix "C"
    /// <summary>
    /// A geographical feature, capable of holding spatial relations.
    /// <see href="http://geovocab.org/spatial#Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// Relation DC(x,y), read as 'x is disconnected from y'. In order to prevent an exponential growth of triples when handling large
    /// 				  amounts of data, a closed world assumption may also be possible. More precisely, by considering not explicitely connected regions as discrete
    /// 				  regions. Moreover, discrete regions, which are not explicitely labeled as externally connected, would be considered disconnected from
    /// 				  eachother.
    /// <see href="http://geovocab.org/spatial#DC"></see></summary>
    let DC = _prefix "DC"
    /// <summary>
    /// Relation DR(x,y), read as 'x is discrete from y'. In order to prevent an exponential growth of triples when handling large
    /// 				  amounts of data, a closed world assumption may also be possible. More precisely, by considering not explicitely connected regions as discrete
    /// 				  regions. Moreover, discrete regions, which are not explicitely labeled as externally connected, would be considered disconnected from
    /// 				  eachother.
    /// <see href="http://geovocab.org/spatial#DR"></see></summary>
    let DR = _prefix "DR"
    /// <summary>
    /// Relation EC(x,y), read as 'x is externally connected with y'. This relation holds, when the two regions share at least
    /// 						 one common point of their borders, but share no points of their interiors, i.e. they do not overlap.
    /// <see href="http://geovocab.org/spatial#EC"></see></summary>
    let EC = _prefix "EC"
    /// <summary>
    /// Relation x=y, read as 'x is identical with y'. This relation holds when two regions are spatially co-located.
    /// <see href="http://geovocab.org/spatial#EQ"></see></summary>
    let EQ = _prefix "EQ"
    /// <summary>
    /// Relation Pi(x,y), read as 'x contains y'. Inverse of the P(x,y) relation.
    /// <see href="http://geovocab.org/spatial#Pi"></see></summary>
    let Pi = _prefix "Pi"
    /// <summary>
    /// Relation P(x,y), read as 'x is a part of y', holds whenever the region x is contained within the borders of the region y.
    /// <see href="http://geovocab.org/spatial#P"></see></summary>
    let P = _prefix "P"
    /// <summary>
    /// Relation NTPP(x,y), read as 'x is a non-tangential proper part of y'. This relation holds, whenever a region x is
    /// 							 labeled as a proper part of a region y, and they do not share common point in their borders.
    /// <see href="http://geovocab.org/spatial#NTPP"></see></summary>
    let NTPP = _prefix "NTPP"
    /// <summary>
    /// Relation PP(x,y), read as 'x is a proper part of y', means that the region x is contained within the borders of the
    /// 				region y, and region y is not contained within the borders of the region y, which means they are not equals.
    /// <see href="http://geovocab.org/spatial#PP"></see></summary>
    let PP = _prefix "PP"
    /// <summary>
    /// Relation NTPPi(x,y), read as 'x non-tangentially properly contains y'. Inverse of the NTPP(x,y) relation.
    /// <see href="http://geovocab.org/spatial#NTPPi"></see></summary>
    let NTPPi = _prefix "NTPPi"
    /// <summary>
    /// Relation PPi(x,y), read as 'x properly contains y'. Inverse of the PP(x,y) relation.
    /// <see href="http://geovocab.org/spatial#PPi"></see></summary>
    let PPi = _prefix "PPi"
    /// <summary>
    /// Relation O(x,y), read as 'x overlaps y'. A region x overlaps a region y, if they share at least one common point of their interiors.
    /// <see href="http://geovocab.org/spatial#O"></see></summary>
    let O = _prefix "O"
    /// <summary>
    /// Relation PO(x,y), read as 'x partially overlaps y'. A region x overlaps a region y, if they share at least one common point of their
    /// 				   interiors, and one does not contain the other within its borders.
    /// <see href="http://geovocab.org/spatial#PO"></see></summary>
    let PO = _prefix "PO"
    /// <summary>
    /// Relation TPP(x,y), read as 'x is a tangential proper part of y'. This relation holds, whenever a region x is
    /// 						  labeled as a proper part of a region y, and they share at least one common point in their borders, which means that they are
    /// 						  externally connected.
    /// <see href="http://geovocab.org/spatial#TPP"></see></summary>
    let TPP = _prefix "TPP"
    /// <summary>
    /// Relation TPPi(x,y), read as 'x tangentially properly contains y'. Inverse of the TPP(x,y) relation.
    /// <see href="http://geovocab.org/spatial#TPPi"></see></summary>
    let TPPi = _prefix "TPPi"
    /// <summary>
    /// Although this relation is not a part of the RCC theory, it has been introduced in order to detect relations between regions
    /// 								which are inconsistent with the RCC axioms.
    /// <see href="http://geovocab.org/spatial#inconsistentWith"></see></summary>
    let inconsistentWith = _prefix "inconsistentWith"
