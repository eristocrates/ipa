namespace http.geovocab.org.spatial.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spatial =
    let _namespace_iri = Namespace_Iri spatial |> NamespaceIRI
    /// <summary>
    ///   <para>geovocab:spatial#C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Relation C(x,y), read as 'x is connected with y'. This relation holds when two regions share a common point. It is the primitive relation
    /// 				in the RCC theory."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"connects with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#C">http://geovocab.org/spatial#C</seealso>
    let C = Prefixed_Name(spatial, "C") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#DC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Relation DC(x,y), read as 'x is disconnected from y'. In order to prevent an exponential growth of triples when handling large
    /// 				  amounts of data, a closed world assumption may also be possible. More precisely, by considering not explicitely connected regions as discrete
    /// 				  regions. Moreover, discrete regions, which are not explicitely labeled as externally connected, would be considered disconnected from
    /// 				  eachother."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"disconnected from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#DC">http://geovocab.org/spatial#DC</seealso>
    let DC = Prefixed_Name(spatial, "DC") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#DR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation DR(x,y), read as 'x is discrete from y'. In order to prevent an exponential growth of triples when handling large
    /// 				  amounts of data, a closed world assumption may also be possible. More precisely, by considering not explicitely connected regions as discrete
    /// 				  regions. Moreover, discrete regions, which are not explicitely labeled as externally connected, would be considered disconnected from
    /// 				  eachother."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"discrete from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#DR">http://geovocab.org/spatial#DR</seealso>
    let DR = Prefixed_Name(spatial, "DR") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#EC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Relation EC(x,y), read as 'x is externally connected with y'. This relation holds, when the two regions share at least
    /// 						 one common point of their borders, but share no points of their interiors, i.e. they do not overlap."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"externally connected with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#EC">http://geovocab.org/spatial#EC</seealso>
    let EC = Prefixed_Name(spatial, "EC") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#EQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation x=y, read as 'x is identical with y'. This relation holds when two regions are spatially co-located."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"equals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#EQ">http://geovocab.org/spatial#EQ</seealso>
    let EQ = Prefixed_Name(spatial, "EQ") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A geographical feature, capable of holding spatial relations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#Feature">http://geovocab.org/spatial#Feature</seealso>
    let Feature = Prefixed_Name(spatial, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#NTPP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relation NTPP(x,y), read as 'x is a non-tangential proper part of y'. This relation holds, whenever a region x is
    /// 							 labeled as a proper part of a region y, and they do not share common point in their borders."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is non-tangential proper part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#NTPP">http://geovocab.org/spatial#NTPP</seealso>
    let NTPP = Prefixed_Name(spatial, "NTPP") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#NTPPi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation NTPPi(x,y), read as 'x non-tangentially properly contains y'. Inverse of the NTPP(x,y) relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"non tangentially properly contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#NTPPi">http://geovocab.org/spatial#NTPPi</seealso>
    let NTPPi = Prefixed_Name(spatial, "NTPPi") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#O</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation O(x,y), read as 'x overlaps y'. A region x overlaps a region y, if they share at least one common point of their interiors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"overlaps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#O">http://geovocab.org/spatial#O</seealso>
    let O = Prefixed_Name(spatial, "O") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#P</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation P(x,y), read as 'x is a part of y', holds whenever the region x is contained within the borders of the region y."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#P">http://geovocab.org/spatial#P</seealso>
    let P = Prefixed_Name(spatial, "P") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#PO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation PO(x,y), read as 'x partially overlaps y'. A region x overlaps a region y, if they share at least one common point of their
    /// 				   interiors, and one does not contain the other within its borders."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"partially overlaps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#PO">http://geovocab.org/spatial#PO</seealso>
    let PO = Prefixed_Name(spatial, "PO") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#PP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relation PP(x,y), read as 'x is a proper part of y', means that the region x is contained within the borders of the
    /// 				region y, and region y is not contained within the borders of the region y, which means they are not equals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is proper part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#PP">http://geovocab.org/spatial#PP</seealso>
    let PP = Prefixed_Name(spatial, "PP") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#PPi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relation PPi(x,y), read as 'x properly contains y'. Inverse of the PP(x,y) relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"properly contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#PPi">http://geovocab.org/spatial#PPi</seealso>
    let PPi = Prefixed_Name(spatial, "PPi") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#Pi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation Pi(x,y), read as 'x contains y'. Inverse of the P(x,y) relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#Pi">http://geovocab.org/spatial#Pi</seealso>
    let Pi = Prefixed_Name(spatial, "Pi") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#TPP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relation TPP(x,y), read as 'x is a tangential proper part of y'. This relation holds, whenever a region x is
    /// 						  labeled as a proper part of a region y, and they share at least one common point in their borders, which means that they are
    /// 						  externally connected."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is tangential proper part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#TPP">http://geovocab.org/spatial#TPP</seealso>
    let TPP = Prefixed_Name(spatial, "TPP") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#TPPi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relation TPPi(x,y), read as 'x tangentially properly contains y'. Inverse of the TPP(x,y) relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tangentially properly contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#TPPi">http://geovocab.org/spatial#TPPi</seealso>
    let TPPi = Prefixed_Name(spatial, "TPPi") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:spatial#inconsistentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Although this relation is not a part of the RCC theory, it has been introduced in order to detect relations between regions
    /// 								which are inconsistent with the RCC axioms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inconsistent with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial#inconsistentWith">http://geovocab.org/spatial#inconsistentWith</seealso>
    let inconsistentWith = Prefixed_Name(spatial, "inconsistentWith") |> PrefixedName
