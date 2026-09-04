#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module spatial =
    let _prefixId = PrefixId.fromNamespaceLabel "http://geovocab.org/spatial#" "spatial"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : connects with^^xsd:string</para>
    ///   <para>rdfs:comment : Relation C(x,y), read as 'x is connected with y'. This relation holds when two regions share a common point. It is the primitive relation
    /// 				in the RCC theory.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#C">spatial:C</a>
    /// </summary>
    let C = _prefixId.prefix "C"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : disconnected from^^xsd:string</para>
    ///   <para>rdfs:comment : Relation DC(x,y), read as 'x is disconnected from y'. In order to prevent an exponential growth of triples when handling large
    /// 				  amounts of data, a closed world assumption may also be possible. More precisely, by considering not explicitely connected regions as discrete
    /// 				  regions. Moreover, discrete regions, which are not explicitely labeled as externally connected, would be considered disconnected from
    /// 				  eachother.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#DC">spatial:DC</a>
    /// </summary>
    let DC = _prefixId.prefix "DC"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : discrete from^^xsd:string</para>
    ///   <para>rdfs:comment : Relation DR(x,y), read as 'x is discrete from y'. In order to prevent an exponential growth of triples when handling large
    /// 				  amounts of data, a closed world assumption may also be possible. More precisely, by considering not explicitely connected regions as discrete
    /// 				  regions. Moreover, discrete regions, which are not explicitely labeled as externally connected, would be considered disconnected from
    /// 				  eachother.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#DR">spatial:DR</a>
    /// </summary>
    let DR = _prefixId.prefix "DR"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : externally connected with^^xsd:string</para>
    ///   <para>rdfs:comment : Relation EC(x,y), read as 'x is externally connected with y'. This relation holds, when the two regions share at least
    /// 						 one common point of their borders, but share no points of their interiors, i.e. they do not overlap.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#EC">spatial:EC</a>
    /// </summary>
    let EC = _prefixId.prefix "EC"
    /// <summary>
    ///   <para>rdfs:label : equals^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Relation x=y, read as 'x is identical with y'. This relation holds when two regions are spatially co-located.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#EQ">spatial:EQ</a>
    /// </summary>
    let EQ = _prefixId.prefix "EQ"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Feature^^xsd:string</para>
    ///   <para>rdfs:comment : A geographical feature, capable of holding spatial relations.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#Feature">spatial:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : is non-tangential proper part of^^xsd:string</para>
    ///   <para>rdfs:comment : Relation NTPP(x,y), read as 'x is a non-tangential proper part of y'. This relation holds, whenever a region x is
    /// 							 labeled as a proper part of a region y, and they do not share common point in their borders.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#NTPP">spatial:NTPP</a>
    /// </summary>
    let NTPP = _prefixId.prefix "NTPP"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : non tangentially properly contains^^xsd:string</para>
    ///   <para>rdfs:comment : Relation NTPPi(x,y), read as 'x non-tangentially properly contains y'. Inverse of the NTPP(x,y) relation.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#NTPPi">spatial:NTPPi</a>
    /// </summary>
    let NTPPi = _prefixId.prefix "NTPPi"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : overlaps^^xsd:string</para>
    ///   <para>rdfs:comment : Relation O(x,y), read as 'x overlaps y'. A region x overlaps a region y, if they share at least one common point of their interiors.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#O">spatial:O</a>
    /// </summary>
    let O = _prefixId.prefix "O"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : is part of^^xsd:string</para>
    ///   <para>rdfs:comment : Relation P(x,y), read as 'x is a part of y', holds whenever the region x is contained within the borders of the region y.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#P">spatial:P</a>
    /// </summary>
    let P = _prefixId.prefix "P"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : partially overlaps^^xsd:string</para>
    ///   <para>rdfs:comment : Relation PO(x,y), read as 'x partially overlaps y'. A region x overlaps a region y, if they share at least one common point of their
    /// 				   interiors, and one does not contain the other within its borders.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#PO">spatial:PO</a>
    /// </summary>
    let PO = _prefixId.prefix "PO"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : is proper part of^^xsd:string</para>
    ///   <para>rdfs:comment : Relation PP(x,y), read as 'x is a proper part of y', means that the region x is contained within the borders of the
    /// 				region y, and region y is not contained within the borders of the region y, which means they are not equals.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#PP">spatial:PP</a>
    /// </summary>
    let PP = _prefixId.prefix "PP"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : properly contains^^xsd:string</para>
    ///   <para>rdfs:comment : Relation PPi(x,y), read as 'x properly contains y'. Inverse of the PP(x,y) relation.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#PPi">spatial:PPi</a>
    /// </summary>
    let PPi = _prefixId.prefix "PPi"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <para>rdfs:comment : Relation Pi(x,y), read as 'x contains y'. Inverse of the P(x,y) relation.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#Pi">spatial:Pi</a>
    /// </summary>
    let Pi = _prefixId.prefix "Pi"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : is tangential proper part of^^xsd:string</para>
    ///   <para>rdfs:comment : Relation TPP(x,y), read as 'x is a tangential proper part of y'. This relation holds, whenever a region x is
    /// 						  labeled as a proper part of a region y, and they share at least one common point in their borders, which means that they are
    /// 						  externally connected.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#TPP">spatial:TPP</a>
    /// </summary>
    let TPP = _prefixId.prefix "TPP"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tangentially properly contains^^xsd:string</para>
    ///   <para>rdfs:comment : Relation TPPi(x,y), read as 'x tangentially properly contains y'. Inverse of the TPP(x,y) relation.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#TPPi">spatial:TPPi</a>
    /// </summary>
    let TPPi = _prefixId.prefix "TPPi"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : inconsistent with^^xsd:string</para>
    ///   <para>rdfs:comment : Although this relation is not a part of the RCC theory, it has been introduced in order to detect relations between regions
    /// 								which are inconsistent with the RCC axioms.^^xsd:string</para>
    ///   <a href="http://geovocab.org/spatial#inconsistentWith">spatial:inconsistentWith</a>
    /// </summary>
    let inconsistentWith = _prefixId.prefix "inconsistentWith"
