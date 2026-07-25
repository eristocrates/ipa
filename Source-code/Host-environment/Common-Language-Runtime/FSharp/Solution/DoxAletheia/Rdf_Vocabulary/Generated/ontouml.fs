namespace https.w3id.org.ontouml.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ontouml =
    let _namespace_iri = Namespace_Iri ontouml |> NamespaceIRI
    /// <summary>
    ///   <para>ontouml:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.</para>
    /// labels<para>abstract</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#abstract">https://w3id.org/ontouml#abstract</seealso>
    let abstract_ = Prefixed_Name(ontouml, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>A rigid mixin that does not require a dependency to be specified. It is used to aggregate essential properties of individuals following different identity principles.</para>
    /// labels<para>category</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#category">https://w3id.org/ontouml#category</seealso>
    let category = Prefixed_Name(ontouml, "category") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:collective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>An ontouml:ClassStereotype used to represent rigid concepts that provide an identity principle for their instances.</para>
    /// labels<para>collective</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#collective">https://w3id.org/ontouml#collective</seealso>
    let collective = Prefixed_Name(ontouml, "collective") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:componentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A parthood relation between two complexes.</para>
    /// labels<para>componentOf</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#componentOf">https://w3id.org/ontouml#componentOf</seealso>
    let componentOf = Prefixed_Name(ontouml, "componentOf") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.</para>
    /// labels<para>datatype</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#datatype">https://w3id.org/ontouml#datatype</seealso>
    let datatype = Prefixed_Name(ontouml, "datatype") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:externalDependence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>Identifies an endurant on which the extrinsicMode depends.</para>
    /// labels<para>externalDependence</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#externalDependence">https://w3id.org/ontouml#externalDependence</seealso>
    let externalDependence =
        Prefixed_Name(ontouml, "externalDependence") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:historicalDependence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>Identifies a concrete individual on which another concrete individual depends historically.</para>
    /// labels<para>historicalDependence</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#historicalDependence">https://w3id.org/ontouml#historicalDependence</seealso>
    let historicalDependence =
        Prefixed_Name(ontouml, "historicalDependence") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:intrinsicModeNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>Indicates that the restricted type includes intrinsic mode individuals among its instances.</para>
    /// labels<para>intrinsicModeNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#intrinsicModeNature">https://w3id.org/ontouml#intrinsicModeNature</seealso>
    let intrinsicModeNature =
        Prefixed_Name(ontouml, "intrinsicModeNature") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:mediation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A type of existential dependence relation (a form of nonfunctional inherence). It can be derived from the relation between the relata and the qua individuals that compose the relator and that inhere in the relata.</para>
    /// labels<para>mediation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#mediation">https://w3id.org/ontouml#mediation</seealso>
    let mediation = Prefixed_Name(ontouml, "mediation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:mixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Represents a semi-rigid type, i.e., it behaves as a rigid type for some individuals and as an anti-rigid one for others.</para>
    /// labels<para>mixin</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#mixin">https://w3id.org/ontouml#mixin</seealso>
    let mixin_ = Prefixed_Name(ontouml, "mixin") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>A particular type of intrinsic property that has no structured value.</para>
    /// labels<para>mode</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#mode">https://w3id.org/ontouml#mode</seealso>
    let mode = Prefixed_Name(ontouml, "mode") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:phaseMixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>The equivalent of Phase for types that aggregate instances with different identity principles. A class stereotyped as PhaseMixin is also an anti-rigid type. PhaseMixin is similar semantically to RoleMixin with the difference in relational dependency.</para>
    /// labels<para>phaseMixin</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#phaseMixin">https://w3id.org/ontouml#phaseMixin</seealso>
    let phaseMixin = Prefixed_Name(ontouml, "phaseMixin") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A Quality is a particular type of intrinsic property that has a structured value. Qualities are things that existentially depend on the things they characterize, called their bearers.</para>
    /// labels<para>quality</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#quality">https://w3id.org/ontouml#quality</seealso>
    let quality = Prefixed_Name(ontouml, "quality") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>Used to represent anti-rigid specializations of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity) that are instantiated in relational contexts.</para>
    /// labels<para>role</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#role">https://w3id.org/ontouml#role</seealso>
    let role = Prefixed_Name(ontouml, "role") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:roleMixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The equivalent of Role for types that aggregate instances with different identity principles.</para>
    /// labels<para>roleMixin</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#roleMixin">https://w3id.org/ontouml#roleMixin</seealso>
    let roleMixin = Prefixed_Name(ontouml, "roleMixin") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:subkind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>Used to represent rigid specializations of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity).</para>
    /// labels<para>subkind</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#subkind">https://w3id.org/ontouml#subkind</seealso>
    let subkind = Prefixed_Name(ontouml, "subkind") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:termination</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.</para>
    /// labels<para>termination</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#termination">https://w3id.org/ontouml#termination</seealso>
    let termination = Prefixed_Name(ontouml, "termination") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:OntoumlElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups different elements an ontoUML model can have.</para>
    /// labels<para>OntoumlElement</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#OntoumlElement">https://w3id.org/ontouml#OntoumlElement</seealso>
    let OntoumlElement = Prefixed_Name(ontouml, "OntoumlElement") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains the ontouml:xCoordinate value and ontouml:yCoordinate value. These values represent the top left position of an ontouml:RectangularShape, to which the ontouml:Point is related vian ontouml:topLeftPosition property.</para>
    /// labels<para>Point</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Point">https://w3id.org/ontouml#Point</seealso>
    let Point = Prefixed_Name(ontouml, "Point") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A list of connected ontouml:Point values to represent an ontouml:ElementView's shape.</para>
    /// labels<para>Path</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Path">https://w3id.org/ontouml#Path</seealso>
    let Path = Prefixed_Name(ontouml, "Path") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype different than ontouml:type must have an ontouml:order value equal to 1.</para>
    ///   <para>Indicates the order of an ontouml:Class, enabling multi-level modeling.</para>
    ///   <para>Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype ontouml:type must have an ontouml:order value grater than 1.</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#order">https://w3id.org/ontouml#order</seealso>
    let order = Prefixed_Name(ontouml, "order") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an ontouml:Diagram to an ontouml:ModelElement that is represented on it, i.e., to an ontouml:ModelElement that has an ontouml:ElementView on that ontouml:Diagram.</para>
    /// labels<para>owner</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#owner">https://w3id.org/ontouml#owner</seealso>
    let owner = Prefixed_Name(ontouml, "owner") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:abstractNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that the restricted type includes abstract individuals among its instances.</para>
    /// labels<para>abstractNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#abstractNature">https://w3id.org/ontouml#abstractNature</seealso>
    let abstractNature = Prefixed_Name(ontouml, "abstractNature") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:bringsAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.</para>
    /// labels<para>bringsAbout</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#bringsAbout">https://w3id.org/ontouml#bringsAbout</seealso>
    let bringsAbout = Prefixed_Name(ontouml, "bringsAbout") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:collectiveNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>Indicates that the restricted type includes collective individuals among its instances.</para>
    /// labels<para>collectiveNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#collectiveNature">https://w3id.org/ontouml#collectiveNature</seealso>
    let collectiveNature = Prefixed_Name(ontouml, "collectiveNature") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:composite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#AggregationKind</para>
    ///   <para>The value denoting that an ontouml:Property represents a composite aggregation, i.e., a strong form of aggregation.</para>
    /// labels<para>composite</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#composite">https://w3id.org/ontouml#composite</seealso>
    let composite = Prefixed_Name(ontouml, "composite") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:derivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.</para>
    /// labels<para>derivation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#derivation">https://w3id.org/ontouml#derivation</seealso>
    let derivation = Prefixed_Name(ontouml, "derivation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Things that happen to or are performed by endurants (Casati and Varzi, 2015).</para>
    ///   <para>An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.</para>
    /// labels<para>event</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#event">https://w3id.org/ontouml#event</seealso>
    let event_ = Prefixed_Name(ontouml, "event") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:extrinsicModeNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>Identifies what inheres in a concrete individual and depends on others for its existence.</para>
    /// labels<para>extrinsicModeNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#extrinsicModeNature">https://w3id.org/ontouml#extrinsicModeNature</seealso>
    let extrinsicModeNature =
        Prefixed_Name(ontouml, "extrinsicModeNature") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:historicalRoleMixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>Denotes the equivalent of historicalRole for types that aggregate instances with different identity principles.</para>
    /// labels<para>historicalRoleMixin</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#historicalRoleMixin">https://w3id.org/ontouml#historicalRoleMixin</seealso>
    let historicalRoleMixin =
        Prefixed_Name(ontouml, "historicalRoleMixin") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Used to represent rigid concepts that provide an identity principle for their instances and do not require a relational dependency.</para>
    /// labels<para>kind</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#kind">https://w3id.org/ontouml#kind</seealso>
    let kind = Prefixed_Name(ontouml, "kind") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A parthood relation between a functional complex or a Collective (as a part) and a Collective (as a whole).</para>
    /// labels<para>memberOf</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#memberOf">https://w3id.org/ontouml#memberOf</seealso>
    let memberOf = Prefixed_Name(ontouml, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:participational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>Denotes a kind of event decomposition.</para>
    /// labels<para>participational</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#participational">https://w3id.org/ontouml#participational</seealso>
    let participational = Prefixed_Name(ontouml, "participational") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:quantityNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that the restricted type includes quantity individuals among its instances.</para>
    /// labels<para>quantityNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#quantityNature">https://w3id.org/ontouml#quantityNature</seealso>
    let quantityNature = Prefixed_Name(ontouml, "quantityNature") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:relator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>A construct used to represent truth-makers of material relations, i.e., the things that must exist for two or more individuals to be connected by material relations.</para>
    /// labels<para>relator</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#relator">https://w3id.org/ontouml#relator</seealso>
    let relator = Prefixed_Name(ontouml, "relator") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:shared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#AggregationKind</para>
    ///   <para>Indicates that the ontouml:Property has shared aggregation semantics.</para>
    /// labels<para>shared</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#shared">https://w3id.org/ontouml#shared</seealso>
    let shared = Prefixed_Name(ontouml, "shared") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Can be used to represent certain configurations of entities that can be comprehended as a whole.</para>
    /// labels<para>situation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#situation">https://w3id.org/ontouml#situation</seealso>
    let situation = Prefixed_Name(ontouml, "situation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:triggers</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.</para>
    /// labels<para>triggers</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#triggers">https://w3id.org/ontouml#triggers</seealso>
    let triggers = Prefixed_Name(ontouml, "triggers") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The stereotype for high-order types.</para>
    /// labels<para>type</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#type">https://w3id.org/ontouml#type</seealso>
    let type_ = Prefixed_Name(ontouml, "type") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Stereotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates meta-properties of classes, properties, or relations.</para>
    /// labels<para>Stereotype</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Stereotype">https://w3id.org/ontouml#Stereotype</seealso>
    let Stereotype = Prefixed_Name(ontouml, "Stereotype") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:ClassStereotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Class.</para>
    ///   <para>This class is an enumeration of its individuals, which are: ontouml:abstract, ontouml:category, ontouml:collective, ontouml:datatype, ontouml:enumeration, ontouml:event, ontouml:historicalRole, ontouml:historicalRoleMixin, ontouml:kind, ontouml:mixin, ontouml:mode, ontouml:phase, ontouml:phaseMixin, ontouml:quality, ontouml:quantity, ontouml:relator, ontouml:role, ontouml:roleMixin, ontouml:situation, ontouml:subkind, and ontouml:type.</para>
    /// labels<para>ClassStereotype</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#ClassStereotype">https://w3id.org/ontouml#ClassStereotype</seealso>
    let ClassStereotype = Prefixed_Name(ontouml, "ClassStereotype") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Classifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups the classes ontouml:Class and ontouml:Relation.</para>
    /// labels<para>Classifier</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Classifier">https://w3id.org/ontouml#Classifier</seealso>
    let Classifier = Prefixed_Name(ontouml, "Classifier") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:ClassView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Does not directly contain data about the visual representation (rectangular shape's size and position) itself, but is related to this information via the ontouml:shape property.</para>
    ///   <para>Represents the diagramation (i.e., the visual representation) of an ontouml:Class in a given ontouml:Diagram.</para>
    /// labels<para>ClassView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#ClassView">https://w3id.org/ontouml#ClassView</seealso>
    let ClassView = Prefixed_Name(ontouml, "ClassView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:NodeView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups the classes ontouml:NoteView, ontouml:ClassView, and ontouml:PackageView.</para>
    /// labels<para>NodeView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#NodeView">https://w3id.org/ontouml#NodeView</seealso>
    let NodeView = Prefixed_Name(ontouml, "NodeView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:ConnectorView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups the classes ontouml:RelationView and ontouml:GeneralizationView.</para>
    /// labels<para>ConnectorView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#ConnectorView">https://w3id.org/ontouml#ConnectorView</seealso>
    let ConnectorView = Prefixed_Name(ontouml, "ConnectorView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:ElementView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups the classes ontouml:ConnectorView, ontouml:GeneralizationSetView, and ontouml:NodeView.</para>
    ///   <para>Represents the diagramatical representation of an element on an ontouml:Diagram.</para>
    ///   <para>E.g., an ontouml:ClassView is created whenever an ontouml:ModelElement is represented in an ontouml:Diagram.</para>
    /// labels<para>ElementView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#ElementView">https://w3id.org/ontouml#ElementView</seealso>
    let ElementView = Prefixed_Name(ontouml, "ElementView") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:GeneralizationView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the diagramation (i.e., the visual representation) of an ontouml:Generalization in a given ontouml:Diagram.</para>
    /// labels<para>GeneralizationView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#GeneralizationView">https://w3id.org/ontouml#GeneralizationView</seealso>
    let GeneralizationView =
        Prefixed_Name(ontouml, "GeneralizationView") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:RelationView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the diagramation (i.e., the visual representation) of an ontouml:Relation in a given ontouml:Diagram.</para>
    /// labels<para>RelationView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#RelationView">https://w3id.org/ontouml#RelationView</seealso>
    let RelationView = Prefixed_Name(ontouml, "RelationView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:ModelElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups diverse elements that can be represented in on OntoUML model.</para>
    /// labels<para>ModelElement</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#ModelElement">https://w3id.org/ontouml#ModelElement</seealso>
    let ModelElement = Prefixed_Name(ontouml, "ModelElement") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a property defined in the ontology. Properties contained by classes are deemed attributes and those contained by relations are deemed association ends.</para>
    ///   <para>An ontouml:Property may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:PropertyStereotype. This information is formalized by the ontouml:stereotype property.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Property">https://w3id.org/ontouml#Property</seealso>
    let Property = Prefixed_Name(ontouml, "Property") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Diagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A visual representation of an OntoUML model or of a portion of it.</para>
    /// labels<para>Diagram</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Diagram">https://w3id.org/ontouml#Diagram</seealso>
    let Diagram = Prefixed_Name(ontouml, "Diagram") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:GeneralizationSetView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the diagramation (i.e., the visual representation) of an ontouml:GeneralizationSet in a given ontouml:Diagram.</para>
    /// labels<para>GeneralizationSetView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#GeneralizationSetView">https://w3id.org/ontouml#GeneralizationSetView</seealso>
    let GeneralizationSetView =
        Prefixed_Name(ontouml, "GeneralizationSetView") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:Generalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a generalization defined in an ontology.</para>
    /// labels<para>Generalization</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Generalization">https://w3id.org/ontouml#Generalization</seealso>
    let Generalization = Prefixed_Name(ontouml, "Generalization") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:GeneralizationSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a generalization set defined in the ontology.</para>
    /// labels<para>GeneralizationSet</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#GeneralizationSet">https://w3id.org/ontouml#GeneralizationSet</seealso>
    let GeneralizationSet = Prefixed_Name(ontouml, "GeneralizationSet") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a possible value for an ontouml:Class defined by an ontouml:enumeration.</para>
    /// labels<para>Literal</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Literal">https://w3id.org/ontouml#Literal</seealso>
    let Literal = Prefixed_Name(ontouml, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of ontouml:ModelElement used to represent textual information.</para>
    /// labels<para>Note</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Note">https://w3id.org/ontouml#Note</seealso>
    let Note = Prefixed_Name(ontouml, "Note") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Aggregates ontology components, working as a container.</para>
    /// labels<para>Package</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Package">https://w3id.org/ontouml#Package</seealso>
    let Package = Prefixed_Name(ontouml, "Package") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:NoteView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the diagramation (i.e., the visual representation) of an ontouml:Note in a given ontouml:Diagram.</para>
    /// labels<para>NoteView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#NoteView">https://w3id.org/ontouml#NoteView</seealso>
    let NoteView = Prefixed_Name(ontouml, "NoteView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:PackageView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the diagramation (i.e., the visual representation) of an ontouml:Package in a given ontouml:Diagram.</para>
    /// labels<para>PackageView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#PackageView">https://w3id.org/ontouml#PackageView</seealso>
    let PackageView = Prefixed_Name(ontouml, "PackageView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Aggregates all entities that are part of a same conceptual model, including concepts declaration and their visual representation.</para>
    ///   <para>It is the upper non-abstract class available in the OntoUML Vocabulary.</para>
    /// labels<para>Project</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Project">https://w3id.org/ontouml#Project</seealso>
    let Project = Prefixed_Name(ontouml, "Project") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Rectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A particular type of ontouml:RectangularShape, mainly used to represent entities of type ontouml:Class.</para>
    /// labels<para>Rectangle</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Rectangle">https://w3id.org/ontouml#Rectangle</seealso>
    let Rectangle = Prefixed_Name(ontouml, "Rectangle") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:RectangularShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a rectangular shape in a given ontouml:Diagram.</para>
    /// labels<para>RectangularShape</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#RectangularShape">https://w3id.org/ontouml#RectangularShape</seealso>
    let RectangularShape = Prefixed_Name(ontouml, "RectangularShape") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ontouml:RectangularShape used to represent some textual information in an ontouml:Diagram.</para>
    /// labels<para>Text</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Text">https://w3id.org/ontouml#Text</seealso>
    let Text = Prefixed_Name(ontouml, "Text") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:RelationStereotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is an enumeration of its individuals, which are: ontouml:bringsAbout, ontouml:characterization, ontouml:comparative, ontouml:componentOf, ontouml:creation, ontouml:derivation, ontouml:externalDependence, ontouml:historicalDependence, ontouml:instantiation, ontouml:manifestation, ontouml:material, ontouml:mediation, ontouml:memberOf, ontouml:participation, ontouml:participational, ontouml:subCollectionOf, ontouml:subQuantityOf, ontouml:termination, and ontouml:triggers.</para>
    ///   <para>Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Relation.</para>
    /// labels<para>RelationStereotype</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#RelationStereotype">https://w3id.org/ontouml#RelationStereotype</seealso>
    let RelationStereotype =
        Prefixed_Name(ontouml, "RelationStereotype") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:aggregationKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Characterizes an ontouml:Property with an ontouml:AggregationKind instance, i.e., indicates whether the ontouml:Property is a simple (ontouml:none), a shared (ontouml:shared), or a composite (ontouml:composite) property.</para>
    /// labels<para>aggregationKind</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#aggregationKind">https://w3id.org/ontouml#aggregationKind</seealso>
    let aggregationKind = Prefixed_Name(ontouml, "aggregationKind") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an instance of an ontouml:Class to its properties, which are instances of the ontouml:Property class.</para>
    /// labels<para>attribute</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#attribute">https://w3id.org/ontouml#attribute</seealso>
    let attribute = Prefixed_Name(ontouml, "attribute") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an ontouml:Property exhibited by an ontouml:Classifier. If the ontouml:Classifier is of type ontouml:Class, the ontouml:property is specialized in ontouml:attribute. If the ontouml:Classifier is an ontouml:Relation, the property is specialized in ontouml:relationEnd.</para>
    ///   <para>Aggregates its subproperties ontouml:attribute and ontouml:relationEnd. Should not be directly used.</para>
    /// labels<para>property</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#property">https://w3id.org/ontouml#property</seealso>
    let property = Prefixed_Name(ontouml, "property") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the individual of type ontouml:Cardinality that represents the cardinalities of an ontouml:Property.</para>
    /// labels<para>cardinality</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#cardinality">https://w3id.org/ontouml#cardinality</seealso>
    let cardinality = Prefixed_Name(ontouml, "cardinality") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:cardinalityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides the complete (i.e., both lower and upper cardinality's bounds) cardinalities of an ontouml:Property via its related ontouml:Cardinality.</para>
    /// labels<para>cardinalityValue</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#cardinalityValue">https://w3id.org/ontouml#cardinalityValue</seealso>
    let cardinalityValue = Prefixed_Name(ontouml, "cardinalityValue") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:categorizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> Identifies the ontouml:Class that is instantiated by the specific classes of the ontouml:Generalization type composing the ontouml:GeneralizationSet</para>
    /// labels<para>categorizer</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#categorizer">https://w3id.org/ontouml#categorizer</seealso>
    let categorizer = Prefixed_Name(ontouml, "categorizer") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:containsModelElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an instance of type ontouml:ModelElement that composes in an ontouml:Package.</para>
    ///   <para>It is mapped to the OntoUML Metamodel's 'contents' relation between the Package and ModelElement classes.</para>
    /// labels<para>containsModelElement</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#containsModelElement">https://w3id.org/ontouml#containsModelElement</seealso>
    let containsModelElement =
        Prefixed_Name(ontouml, "containsModelElement") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:containsView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an instance of type ontouml:ElementView that is contained in an ontouml:Diagram, representing the concrete diagramation of an ontouml:ModelElement.</para>
    /// labels<para>containsView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#containsView">https://w3id.org/ontouml#containsView</seealso>
    let containsView = Prefixed_Name(ontouml, "containsView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relates an ontouml:OntoumlElement to a string representing its description in free textual format.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#description">https://w3id.org/ontouml#description</seealso>
    let description = Prefixed_Name(ontouml, "description") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:general</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the parent ontouml:Classifier (e.g., a superclass) that participates in an ontouml:Generalization relation.</para>
    /// labels<para>general</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#general">https://w3id.org/ontouml#general</seealso>
    let general = Prefixed_Name(ontouml, "general") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:generalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an ontouml:Generalization that participates in an ontouml:GeneralizationSet.</para>
    /// labels<para>generalization</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#generalization">https://w3id.org/ontouml#generalization</seealso>
    let generalization = Prefixed_Name(ontouml, "generalization") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the height of an ontouml:RectangularShape that is represented in an ontouml:Diagram.</para>
    /// labels<para>height</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#height">https://w3id.org/ontouml#height</seealso>
    let height = Prefixed_Name(ontouml, "height") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if the ontouml:Classifier can have direct instances. If set to true, the classifier must be specialized before being instantiated. Otherwise, it can have direct instances.</para>
    /// labels<para>isAbstract</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isAbstract">https://w3id.org/ontouml#isAbstract</seealso>
    let isAbstract = Prefixed_Name(ontouml, "isAbstract") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if an ontouml:GeneralizationSet is complete, i.e., if it does not admit further generalizations.</para>
    /// labels<para>isComplete</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isComplete">https://w3id.org/ontouml#isComplete</seealso>
    let isComplete = Prefixed_Name(ontouml, "isComplete") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isDerived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if an ontouml:DecoratableElement can be defined through a derivation rule.</para>
    /// labels<para>isDerived</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isDerived">https://w3id.org/ontouml#isDerived</seealso>
    let isDerived = Prefixed_Name(ontouml, "isDerived") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if an ontouml:GeneralizationSet is disjoint, i.e., it does not admit generalizations having overlapping subclasses.</para>
    /// labels<para>isDisjoint</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isDisjoint">https://w3id.org/ontouml#isDisjoint</seealso>
    let isDisjoint = Prefixed_Name(ontouml, "isDisjoint") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isExtensional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if an ontouml:Class is extensionally defined (i.e., it's parts cannot change).</para>
    /// labels<para>isExtensional</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isExtensional">https://w3id.org/ontouml#isExtensional</seealso>
    let isExtensional = Prefixed_Name(ontouml, "isExtensional") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isOrdered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if an ontouml:Property is ordered or not, i.e., if it requires an exact order of its values or not.</para>
    /// labels<para>isOrdered</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isOrdered">https://w3id.org/ontouml#isOrdered</seealso>
    let isOrdered = Prefixed_Name(ontouml, "isOrdered") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isPowertype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if an ontouml:Class is a powertype in multi-level modeling.</para>
    ///   <para>The ontouml:Class data property ontouml:isPowertype must not be true when it has an ontouml:order equal to one.</para>
    /// labels<para>isPowertype</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isPowertype">https://w3id.org/ontouml#isPowertype</seealso>
    let isPowertype = Prefixed_Name(ontouml, "isPowertype") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isReadOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if an ontouml:Property can or cannot be updated or modified.</para>
    /// labels<para>isReadOnly</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isReadOnly">https://w3id.org/ontouml#isReadOnly</seealso>
    let isReadOnly = Prefixed_Name(ontouml, "isReadOnly") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:isViewOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an ontouml:ElementView to ontouml:ModelElement, indicating the diagrammatical representation of the latter in an ontouml:Diagram.</para>
    /// labels<para>isViewOf</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#isViewOf">https://w3id.org/ontouml#isViewOf</seealso>
    let isViewOf = Prefixed_Name(ontouml, "isViewOf") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an ontouml:Project to an ontouml:Package that is part of it.</para>
    /// labels<para>model</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#model">https://w3id.org/ontouml#model</seealso>
    let model = Prefixed_Name(ontouml, "model") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A string that identifies or names an ontouml:OntoumlElement.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#name">https://w3id.org/ontouml#name</seealso>
    let name = Prefixed_Name(ontouml, "name") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an ontouml:Path to an ontouml:Point that composes it.</para>
    /// labels<para>point</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#point">https://w3id.org/ontouml#point</seealso>
    let point = Prefixed_Name(ontouml, "point") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an ontouml:OntoumlElement different than ontouml:Project to an ontouml:Project that it composes.</para>
    /// labels<para>project</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#project">https://w3id.org/ontouml#project</seealso>
    let project = Prefixed_Name(ontouml, "project") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:propertyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an ontouml:Class or ontouml:Relation (i.e., an ontouml:Classifier) to which an ontouml:Property refers.</para>
    /// labels<para>propertyType</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#propertyType">https://w3id.org/ontouml#propertyType</seealso>
    let propertyType = Prefixed_Name(ontouml, "propertyType") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:redefinesProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies a target ontouml:Property that is redefined by a source ontouml:Property.</para>
    /// labels<para>redefinesProperty</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#redefinesProperty">https://w3id.org/ontouml#redefinesProperty</seealso>
    let redefinesProperty = Prefixed_Name(ontouml, "redefinesProperty") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:relationEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies a property that represents one end (source or target) of an ontouml:Relation.</para>
    /// labels<para>relationEnd</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#relationEnd">https://w3id.org/ontouml#relationEnd</seealso>
    let relationEnd = Prefixed_Name(ontouml, "relationEnd") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:restrictedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an ontouml:Class to an ontouml:OntologicalNature, restricting its allowed values.</para>
    /// labels<para>restrictedTo</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#restrictedTo">https://w3id.org/ontouml#restrictedTo</seealso>
    let restrictedTo = Prefixed_Name(ontouml, "restrictedTo") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an ontouml:ElementView to an ontouml:Shape that contains the diagramation's data (size and position) about the ontouml:ModelElement it is a view of.</para>
    /// labels<para>shape</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#shape">https://w3id.org/ontouml#shape</seealso>
    let shape = Prefixed_Name(ontouml, "shape") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:sourceEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an ontouml:Property that represents the source side of an ontouml:Relation.</para>
    /// labels<para>sourceEnd</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#sourceEnd">https://w3id.org/ontouml#sourceEnd</seealso>
    let sourceEnd = Prefixed_Name(ontouml, "sourceEnd") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:sourceView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an ontouml:ElementView that participates as source of an ontouml:RelationView or ontouml:GeneralizationView.</para>
    /// labels<para>sourceView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#sourceView">https://w3id.org/ontouml#sourceView</seealso>
    let sourceView = Prefixed_Name(ontouml, "sourceView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:specific</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the child ontouml:Classifier (e.g., a subclass) that participates in an ontouml:Generalization relation.</para>
    /// labels<para>specific</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#specific">https://w3id.org/ontouml#specific</seealso>
    let specific = Prefixed_Name(ontouml, "specific") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:subsetsProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies a target ontouml:Property that is subsetted by a source ontouml:Property.</para>
    /// labels<para>subsetsProperty</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#subsetsProperty">https://w3id.org/ontouml#subsetsProperty</seealso>
    let subsetsProperty = Prefixed_Name(ontouml, "subsetsProperty") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:targetEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an ontouml:Property that represents the target side of an ontouml:Relation.</para>
    /// labels<para>targetEnd</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#targetEnd">https://w3id.org/ontouml#targetEnd</seealso>
    let targetEnd = Prefixed_Name(ontouml, "targetEnd") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:targetView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an ontouml:ElementView that participates as target of an ontouml:ConnectorView.</para>
    /// labels<para>targetView</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#targetView">https://w3id.org/ontouml#targetView</seealso>
    let targetView = Prefixed_Name(ontouml, "targetView") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A string that register any information of an ontouml:Note</para>
    /// labels<para>text</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#text">https://w3id.org/ontouml#text</seealso>
    let text = Prefixed_Name(ontouml, "text") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:topLeftPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Is direct mapped to the OntoUML Metamodel's 'topLeft' relationship between the classes RectangularShape and Point.</para>
    ///   <para>Relates an ontouml:RectangularShape to an ontouml:Point that contains the horizontal and vertical coordinates (ontouml:xCoordinate and ontouml:yCoordinate, respectively) representing the former's top left position in an ontouml:Diagram.</para>
    /// labels<para>topLeftPosition</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#topLeftPosition">https://w3id.org/ontouml#topLeftPosition</seealso>
    let topLeftPosition = Prefixed_Name(ontouml, "topLeftPosition") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:upperBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An ontouml:Cardinality's upper bound must correspond to the one indicated by its ontouml:cardinalityValue property.</para>
    ///   <para>Identifies the upper bound of an ontouml:Cardinality.</para>
    ///   <para>E.g., if the ontouml:cardinalityValue set is [1..*] then the upper bound is '*'.</para>
    /// labels<para>upperBound</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#upperBound">https://w3id.org/ontouml#upperBound</seealso>
    let upperBound = Prefixed_Name(ontouml, "upperBound") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the width of an ontouml:RectangularShape that is represented in an ontouml:Diagram.</para>
    /// labels<para>width</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#width">https://w3id.org/ontouml#width</seealso>
    let width = Prefixed_Name(ontouml, "width") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:xCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relates an ontouml:Point to the value indicating the specific x (horizontal) coordinate of the top left position of an ontouml:RectangularShape.</para>
    ///   <para>Is direct mapped to the metamodel's 'x' attribute of the Point class.</para>
    /// labels<para>xCoordinate</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#xCoordinate">https://w3id.org/ontouml#xCoordinate</seealso>
    let xCoordinate = Prefixed_Name(ontouml, "xCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:yCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relates an ontouml:Point to the value indicating the specific y (vertical) coordinate of the top left position of an ontouml:RectangularShape.</para>
    ///   <para>Is direct mapped to the metamodel's 'y' attribute of the Point class.</para>
    /// labels<para>yCoordinate</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#yCoordinate">https://w3id.org/ontouml#yCoordinate</seealso>
    let yCoordinate = Prefixed_Name(ontouml, "yCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:characterization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>An ontouml:RelationStereotype attributed to a relation between a bearer type and its feature.</para>
    /// labels<para>characterization</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#characterization">https://w3id.org/ontouml#characterization</seealso>
    let characterization = Prefixed_Name(ontouml, "characterization") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:enumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Represents the enumeration stereotype, having values represented using ontouml:Literal instances.</para>
    /// labels<para>enumeration</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#enumeration">https://w3id.org/ontouml#enumeration</seealso>
    let enumeration = Prefixed_Name(ontouml, "enumeration") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:historicalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>Denotes the role of an endurant in virtue of having participated in an event of a particular type.</para>
    /// labels<para>historicalRole</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#historicalRole">https://w3id.org/ontouml#historicalRole</seealso>
    let historicalRole = Prefixed_Name(ontouml, "historicalRole") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.</para>
    /// labels<para>manifestation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#manifestation">https://w3id.org/ontouml#manifestation</seealso>
    let manifestation = Prefixed_Name(ontouml, "manifestation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:diagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies which entities of type ontouml:Diagram are part of an ontouml:Project.</para>
    ///   <para>It is mapped to the OntoUML Metamodel's 'diagrams' relation between the Project and Diagram classes.</para>
    /// labels<para>diagram</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#diagram">https://w3id.org/ontouml#diagram</seealso>
    let diagram = Prefixed_Name(ontouml, "diagram") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:situationNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>Indicates that the restricted type includes situation individuals among its instances.</para>
    /// labels<para>situationNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#situationNature">https://w3id.org/ontouml#situationNature</seealso>
    let situationNature = Prefixed_Name(ontouml, "situationNature") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:typeNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>Indicates that the restricted type includes type individuals among its instances.</para>
    /// labels<para>typeNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#typeNature">https://w3id.org/ontouml#typeNature</seealso>
    let typeNature = Prefixed_Name(ontouml, "typeNature") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:OntologicalNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is an enumeration of its individuals, which are: ontouml:abstractNature, ontouml:collectiveNature, ontouml:eventNature, ontouml:extrinsicModeNature, ontouml:functionalComplexNature, ontouml:intrinsicModeNature, ontouml:qualityNature, ontouml:quantityNature, ontouml:relatorNature, ontouml:situationNature, and ontouml:typeNature.</para>
    ///   <para>Collection of individuals that represent fundamental conceptual modeling issues according to the Unified Foundational Ontology (UFO) theory.</para>
    /// labels<para>OntologicalNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#OntologicalNature">https://w3id.org/ontouml#OntologicalNature</seealso>
    let OntologicalNature = Prefixed_Name(ontouml, "OntologicalNature") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:PropertyStereotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is an enumeration of its individuals, which are: ontouml:begin, and ontouml:end.</para>
    ///   <para>Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Property.</para>
    /// labels<para>PropertyStereotype</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#PropertyStereotype">https://w3id.org/ontouml#PropertyStereotype</seealso>
    let PropertyStereotype =
        Prefixed_Name(ontouml, "PropertyStereotype") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:none</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#AggregationKind</para>
    ///   <para>Denotes that an ontouml:Property is neither ontouml:shared nor ontouml:composite, but just an aggregation.</para>
    /// labels<para>none</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#none">https://w3id.org/ontouml#none</seealso>
    let none = Prefixed_Name(ontouml, "none") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>Construct used to represent rigid concepts that provide an identity principle for their instances.</para>
    /// labels<para>quantity</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#quantity">https://w3id.org/ontouml#quantity</seealso>
    let quantity = Prefixed_Name(ontouml, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a type defined in the ontology.</para>
    ///   <para>An ontouml:Class have exactly one ontouml:Stereotype (i.e., it is a mandatory property) of specific type ontouml:ClassStereotype. This information is formalized by the ontouml:stereotype property.</para>
    /// labels<para>Class</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Class">https://w3id.org/ontouml#Class</seealso>
    let Class = Prefixed_Name(ontouml, "Class") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:stereotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the ontouml:Stereotype applied to the ontouml:DecoratableElement.</para>
    /// labels<para>stereotype</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#stereotype">https://w3id.org/ontouml#stereotype</seealso>
    let stereotype = Prefixed_Name(ontouml, "stereotype") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:lowerBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>E.g., if the ontouml:cardinalityValue set is [1..*] then the lower bound is '1'.</para>
    ///   <para>Identifies the lower bound of an ontouml:Cardinality.</para>
    ///   <para>An ontouml:Cardinality's lower bound must correspond to the one indicated by its ontouml:cardinalityValue property.</para>
    /// labels<para>lowerBound</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#lowerBound">https://w3id.org/ontouml#lowerBound</seealso>
    let lowerBound = Prefixed_Name(ontouml, "lowerBound") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an ontouml:Literal to its container enumeration class (an ontouml:Class that has the ontouml:stereotype property with ontouml:enumeration).</para>
    /// labels<para>literal</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#literal">https://w3id.org/ontouml#literal</seealso>
    let literal = Prefixed_Name(ontouml, "literal") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#PropertyStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual of the ontouml:PropertyStereotype used to assign the corresponding stereotype to a given ontouml:Property.</para>
    /// labels<para>begin</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#begin">https://w3id.org/ontouml#begin</seealso>
    let begin_ = Prefixed_Name(ontouml, "begin") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:comparative</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The stereotype for comparative relations (e.g., heavier-than). Decorates relations that always hold between any two individuals bearing the same relevant quality.</para>
    /// labels<para>comparative</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#comparative">https://w3id.org/ontouml#comparative</seealso>
    let comparative = Prefixed_Name(ontouml, "comparative") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.</para>
    /// labels<para>creation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#creation">https://w3id.org/ontouml#creation</seealso>
    let creation = Prefixed_Name(ontouml, "creation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#PropertyStereotype</para>
    ///   <para>An individual of the ontouml:PropertyStereotype used to assign the corresponding stereotype to a given ontouml:Property.</para>
    /// labels<para>end</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#end">https://w3id.org/ontouml#end</seealso>
    let end_ = Prefixed_Name(ontouml, "end") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:eventNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that the restricted type includes event individuals among its instances.</para>
    /// labels<para>eventNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#eventNature">https://w3id.org/ontouml#eventNature</seealso>
    let eventNature = Prefixed_Name(ontouml, "eventNature") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:functionalComplexNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Identifies the nature of a complex object whose parts (components) play different roles in its composition.</para>
    /// labels<para>functionalComplexNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#functionalComplexNature">https://w3id.org/ontouml#functionalComplexNature</seealso>
    let functionalComplexNature =
        Prefixed_Name(ontouml, "functionalComplexNature") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:instantiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.</para>
    /// labels<para>instantiation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#instantiation">https://w3id.org/ontouml#instantiation</seealso>
    let instantiation = Prefixed_Name(ontouml, "instantiation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Identifies relations that have material structure on their own and include examples such as employments, kisses, enrollments, flight, connections and commitments.</para>
    /// labels<para>material</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#material">https://w3id.org/ontouml#material</seealso>
    let material = Prefixed_Name(ontouml, "material") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:participation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>A relation for representing when an event depends on a single object.</para>
    /// labels<para>participation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#participation">https://w3id.org/ontouml#participation</seealso>
    let participation = Prefixed_Name(ontouml, "participation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#ClassStereotype</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Used to represent anti-rigid subtypes of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity) that are instantiated by changes in intrinsic properties (e.g., the age of a person, the color of an object, the condition of a car).Phases always come in partitions.</para>
    /// labels<para>phase</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#phase">https://w3id.org/ontouml#phase</seealso>
    let phase = Prefixed_Name(ontouml, "phase") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:qualityNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that the restricted type includes quality individuals among its instances.</para>
    /// labels<para>qualityNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#qualityNature">https://w3id.org/ontouml#qualityNature</seealso>
    let qualityNature = Prefixed_Name(ontouml, "qualityNature") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:relatorNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml#OntologicalNature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that the restricted type includes relator individuals among its instances.</para>
    /// labels<para>relatorNature</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#relatorNature">https://w3id.org/ontouml#relatorNature</seealso>
    let relatorNature = Prefixed_Name(ontouml, "relatorNature") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:subCollectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>A parthood relation between two collectives.</para>
    /// labels<para>subCollectionOf</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#subCollectionOf">https://w3id.org/ontouml#subCollectionOf</seealso>
    let subCollectionOf = Prefixed_Name(ontouml, "subCollectionOf") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:subQuantityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml#RelationStereotype</para>
    ///   <para>A parthood relation between two quantities.</para>
    /// labels<para>subQuantityOf</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#subQuantityOf">https://w3id.org/ontouml#subQuantityOf</seealso>
    let subQuantityOf = Prefixed_Name(ontouml, "subQuantityOf") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:AggregationKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Groups all possible aggregation kinds to which an ontouml:Property can be related.</para>
    ///   <para>This class is an enumeration of its individuals, which are: ontouml:composite, ontouml:none, and ontouml:shared.</para>
    /// labels<para>AggregationKind</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#AggregationKind">https://w3id.org/ontouml#AggregationKind</seealso>
    let AggregationKind = Prefixed_Name(ontouml, "AggregationKind") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the cardinality of an ontouml:Property through its data property ontouml:cardinalityValue.</para>
    /// labels<para>Cardinality</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Cardinality">https://w3id.org/ontouml#Cardinality</seealso>
    let Cardinality = Prefixed_Name(ontouml, "Cardinality") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:DecoratableElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups the classes ontouml:Classifier and the ontouml:Property.</para>
    /// labels<para>DecoratableElement</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#DecoratableElement">https://w3id.org/ontouml#DecoratableElement</seealso>
    let DecoratableElement =
        Prefixed_Name(ontouml, "DecoratableElement") |> PrefixedName

    /// <summary>
    ///   <para>ontouml:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a relation defined in the ontology.</para>
    ///   <para>An ontouml:Relation may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:RelationStereotype. This information is formalized by the ontouml:stereotype property.</para>
    /// labels<para>Relation</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Relation">https://w3id.org/ontouml#Relation</seealso>
    let Relation = Prefixed_Name(ontouml, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:DiagramElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class that groups the classes ontouml:ElementView and the ontouml:Shape.</para>
    /// labels<para>DiagramElement</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#DiagramElement">https://w3id.org/ontouml#DiagramElement</seealso>
    let DiagramElement = Prefixed_Name(ontouml, "DiagramElement") |> PrefixedName
    /// <summary>
    ///   <para>ontouml:Shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains information about the diagramation of an ontouml:ModelElement through its relation with an ontouml:ElementView.</para>
    /// labels<para>Shape</para></remarks>
    /// <seealso href="https://w3id.org/ontouml#Shape">https://w3id.org/ontouml#Shape</seealso>
    let Shape = Prefixed_Name(ontouml, "Shape") |> PrefixedName
